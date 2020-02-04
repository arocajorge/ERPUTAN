using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Business.CuentasxPagar;
using Core.Erp.Business.General;
using Core.Erp.Info.Bancos;
using Core.Erp.Business.Bancos;
using DevExpress.XtraGrid;
using Core.Erp.Reportes.CuentasxPagar;
using Core.Erp.Info.General;

namespace Core.Erp.Winform.CuentasxPagar
{
    public partial class frmCP_Aprobacion_Facturas_x_Pagar : Form
    {
        #region Declaración de Variables
      
        //Bus
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        ba_Banco_Cuenta_Bus bus_banco = new ba_Banco_Cuenta_Bus();
        cp_orden_pago_estado_aprob_Bus bus_estado = new cp_orden_pago_estado_aprob_Bus();
        cp_orden_giro_Bus bus_ogiro = new cp_orden_giro_Bus();
        cp_orden_pago_formapago_Bus Bus_FormaPago = new cp_orden_pago_formapago_Bus();
        int RowHandle = 0;
      //Infos
        cp_orden_giro_Info info_og;

      //Listas      
        List<ba_Banco_Cuenta_Info> lista_ban = new List<ba_Banco_Cuenta_Info>();     
        List<cp_orden_pago_estado_aprob_Info> lista_estado = new List<cp_orden_pago_estado_aprob_Info>();   
        List<cp_orden_giro_Info> lista = new List<cp_orden_giro_Info>();
        List<cp_orden_pago_formapago_Info> lista_FormaPago = new List<cp_orden_pago_formapago_Info>();
        cp_parametros_Info info_parametros_cp = new cp_parametros_Info();
        cp_parametros_Bus bus_parametros_cp = new cp_parametros_Bus();
        List<cp_orden_giro_Info> Lista_validar = new List<cp_orden_giro_Info>();
        cp_orden_giro_Info Info_a_validar = new cp_orden_giro_Info();
        BindingList<cp_orden_giro_Info> factura_x_pagar;

        //variables
        decimal auxliar1 = 0;



        public delegate void delegate_frmCP_Aprobacion_Facturas_x_Pagar(object sender, FormClosingEventArgs e);
        public event delegate_frmCP_Aprobacion_Facturas_x_Pagar event_frmCP_Aprobacion_Facturas_x_Pagar;


        #endregion


        public string StringBusqueda { get; set; }


        public frmCP_Aprobacion_Facturas_x_Pagar()
        {
            InitializeComponent();

            ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
            ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
            ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
            ucGe_Menu.event_btnImprimir_Click += ucGe_Menu_event_btnImprimir_Click;
            event_frmCP_Aprobacion_Facturas_x_Pagar += frmCP_Aprobacion_Facturas_x_Pagar_event_frmCP_Aprobacion_Facturas_x_Pagar;
        }

        void frmCP_Aprobacion_Facturas_x_Pagar_event_frmCP_Aprobacion_Facturas_x_Pagar(object sender, FormClosingEventArgs e)
        {
            
        }

        void ucGe_Menu_event_btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                List<cp_orden_giro_Info> Lista_temp = new List<cp_orden_giro_Info>();
                foreach (cp_orden_giro_Info item in factura_x_pagar)
                {
                    if (item.check)
                    {
                        Lista_temp.Add(item);
                    }
                }

                XCXP_Rpt020_Rpt report = new XCXP_Rpt020_Rpt();
                if(Lista_temp.Count!=0)
                report.DataSource = Lista_temp;
                else
                    report.DataSource = factura_x_pagar;
                report.ShowPreview();
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (Valida_Detalle())
                {
                    Generar_OP();
                    Close();
                }
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
              if (Valida_Detalle())
              {
                  Generar_OP();       
              }
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void Generar_OP()
        {
            try
            {
                GetDetalle();
                string mensaje = "";

                foreach (var item in lista)
                {
                    bus_ogiro = new cp_orden_giro_Bus();
                    bus_ogiro.Generar_OrdenPago_x_Faxtura(item, Convert.ToDateTime(dte_Fecha_op.EditValue == null ? DateTime.Now.Date : dte_Fecha_op.EditValue).Date, ref  mensaje);                    
                }
                MessageBox.Show("Facturas Aprobadas con Exito", "Sistemas");

                carga_grid();
            }
            catch (Exception ex)
            {                
               Log_Error_bus.Log_Error(ex.ToString());
               MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        
        }

        void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {
                
              Log_Error_bus.Log_Error(ex.ToString());
              MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCP_Aprobacion_Facturas_x_Pagar_Load(object sender, EventArgs e)
        {
            try
            {
                dte_Fecha.EditValue = DateTime.Now.Date;
                dte_Fecha_op.EditValue = DateTime.Now.Date;
                                     
               //carga forma pago
                lista_FormaPago = Bus_FormaPago.Get_List_orden_pago_formapago();
                cmbFormaPago.DataSource = lista_FormaPago;
                cmbFormaPago.DisplayMember = "descripcion";
                cmbFormaPago.ValueMember = "IdFormaPago";

                //carga banco            
                lista_ban = bus_banco.Get_list_Banco_Cuenta(param.IdEmpresa);
                cmbBanco.DataSource = lista_ban;
                cmbBanco.DisplayMember = "ba_descripcion";
                cmbBanco.ValueMember = "IdBanco";

                // carga estado aprobacion            
                lista_estado = bus_estado.Get_List_orden_pago_estado_aprob();
                cmbEstadoApro.DataSource = lista_estado;
                cmbEstadoApro.DisplayMember = "Descripcion";
                cmbEstadoApro.ValueMember = "IdEstadoAprobacion";

                //suma = 0;
                carga_grid();

                                             
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void carga_grid()
        {
            try
            {
                string mensaje = "";
                lista = new List<cp_orden_giro_Info>();
                lista = bus_ogiro.Get_List_orden_giro_x_Pagar(param.IdEmpresa, chk_mostrar_fact_en_conciliacion_Caja.Checked, ref mensaje);
                info_parametros_cp = bus_parametros_cp.Get_Info_parametros(param.IdEmpresa);

                if (lista.Count != 0)
                {
                    factura_x_pagar = new BindingList<cp_orden_giro_Info>(lista);

                    foreach (var item in factura_x_pagar)
                    {                                            
                        item.IdBanco = info_parametros_cp.pa_IdBancoCuenta_default_para_OP == null ? lista_ban.FirstOrDefault().IdBanco : Convert.ToInt32(info_parametros_cp.pa_IdBancoCuenta_default_para_OP);
                        item.IdFormaPago = lista_FormaPago.FirstOrDefault().IdFormaPago = "CHEQUE";
                        
                        //Saco la diferencia entre el vencimiento y la fecha de corte
                        TimeSpan Diferencia = item.co_FechaFactura_vct - Convert.ToDateTime(dte_Fecha.EditValue == null ? DateTime.Now.Date : dte_Fecha.EditValue);
                        item.Dias_Vencidos = Diferencia.Days;

                        if (item.Dias_Vencidos < 0) //Por vencer
                        {
                            item.Icono = (Bitmap)imageList1.Images[1];                       
                        }else
                        if (item.Dias_Vencidos < 5) //normal
                        {
                            item.Icono = (Bitmap)imageList1.Images[2];                          
                        }else
                        if (item.Dias_Vencidos > 0) // vencido
                        {
                            item.Icono = (Bitmap)imageList1.Images[0];                          
                        }
                    }
                    gridControl_Factura_x_Pagar.DataSource = factura_x_pagar;
                }


                if (string.IsNullOrEmpty(StringBusqueda)==false)
                {

                    this.gridView_Factura_x_Pagar.ActiveFilterString = "[InfoProveedor.pr_nombre] like '" + StringBusqueda + "'";

                    if (gridView_Factura_x_Pagar.RowCount == 0)
                    {
                        this.gridView_Factura_x_Pagar.ActiveFilterString = "";
                    }
                }
            }
            catch (Exception ex)
            {
                
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
              
        }

        public Boolean Valida_Detalle()
        {
            try
            {
                Boolean res = true;
         
                int focus = this.gridView_Factura_x_Pagar.FocusedRowHandle;
                gridView_Factura_x_Pagar.FocusedRowHandle = focus + 1;

                    int cont = 0;
                    foreach (var item in factura_x_pagar)
                    {
                        if (item.check == true)
                        {
                            cont = cont + 1;
                        }                
                    }

                    if (cont == 0)
                    {
                        MessageBox.Show("Seleccione las facturas por Aprobar ", "Sistemas");
                        res = false;
                    }

                    foreach (var item in factura_x_pagar)
                    {
                        if (item.check == true)
                        {
                            if (String.IsNullOrEmpty(item.IdFormaPago))
                            {
                                MessageBox.Show("Ingrese la Forma de Pago a la Factura:  " + item.Referencia, "Sistemas");
                                res = false;                         
                            }
                            if (String.IsNullOrEmpty(item.IdEstadoAprobacion))
                            {
                                MessageBox.Show("Ingrese el Estado de Aprobación a la Factura:  " + item.Referencia, "Sistemas");
                                res = false;
                            }
                        }
                    }

                    if (!param.Validar_periodo_cerrado_x_modulo(param.IdEmpresa, Cl_Enumeradores.eModulos.CXP, Convert.ToDateTime(dte_Fecha.EditValue)))
                        return false;

                return res;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public void GetDetalle()
        {
            try
            {
                
                int focus = this.gridView_Factura_x_Pagar.FocusedRowHandle;
                gridView_Factura_x_Pagar.FocusedRowHandle = focus + 1;

                Lista_validar = new List<cp_orden_giro_Info>(factura_x_pagar.Where(q => q.check == true).ToList());
                carga_grid();
                lista = new List<cp_orden_giro_Info>();

                foreach (var item in Lista_validar)
                {
                    Info_a_validar = factura_x_pagar.FirstOrDefault(q => q.IdEmpresa == item.IdEmpresa && q.IdTipoCbte_Ogiro == item.IdTipoCbte_Ogiro && q.IdCbteCble_Ogiro == item.IdCbteCble_Ogiro);

                    if (Info_a_validar != null)
                    {
                        factura_x_pagar.FirstOrDefault(q => q.IdEmpresa == item.IdEmpresa && q.IdTipoCbte_Ogiro == item.IdTipoCbte_Ogiro && q.IdCbteCble_Ogiro == item.IdCbteCble_Ogiro).check= true;
                        factura_x_pagar.FirstOrDefault(q => q.IdEmpresa == item.IdEmpresa && q.IdTipoCbte_Ogiro == item.IdTipoCbte_Ogiro && q.IdCbteCble_Ogiro == item.IdCbteCble_Ogiro).Valor_a_Pagar = item.Valor_a_Pagar;
                        factura_x_pagar.FirstOrDefault(q => q.IdEmpresa == item.IdEmpresa && q.IdTipoCbte_Ogiro == item.IdTipoCbte_Ogiro && q.IdCbteCble_Ogiro == item.IdCbteCble_Ogiro).Info_cuotas_x_doc.Cancela_cuota = item.Info_cuotas_x_doc.Cancela_cuota;
                    }
                }
                gridControl_Factura_x_Pagar.DataSource = factura_x_pagar;

                foreach (var item in factura_x_pagar.Where(q=>q.check == true))
                {
                    info_og = new cp_orden_giro_Info();

                        info_og.IdEmpresa = item.IdEmpresa;
                        info_og.IdCbteCble_Ogiro = item.IdCbteCble_Ogiro;
                        info_og.IdTipoCbte_Ogiro = item.IdTipoCbte_Ogiro;
                        info_og.IdOrden_giro_Tipo = item.IdOrden_giro_Tipo;
                        info_og.IdProveedor = item.IdProveedor;
                        info_og.co_serie = item.co_serie;
                        info_og.co_factura = item.co_factura;
                        info_og.co_FechaFactura = item.co_FechaFactura;
                        info_og.co_observacion = item.co_observacion;
                        info_og.IdSucursal = item.IdSucursal;
                        info_og.co_fechaOg = item.co_fechaOg;
                        info_og.co_subtotal_iva = item.co_subtotal_iva;
                        info_og.co_subtotal_siniva = item.co_subtotal_siniva;
                        info_og.co_baseImponible = item.co_baseImponible;
                        info_og.co_Por_iva = item.co_Por_iva;
                        info_og.co_valoriva = item.co_valoriva;
                        info_og.co_total = item.co_total;
                        info_og.IdTipo_op = item.IdTipo_op;
                        info_og.IdEstadoAprobacion = item.IdEstadoAprobacion;
                        info_og.co_FechaFactura_vct = item.co_FechaFactura_vct;
                        info_og.IdFormaPago = item.IdFormaPago;
                        info_og.Saldo_OG = item.Saldo_OG;
                        info_og.co_valorpagar = item.co_valorpagar;                        
                        info_og.Valor_a_Pagar = item.Valor_a_Pagar;
                        info_og.IdBanco = item.IdBanco;
                        info_og.IdTipoFlujo = item.IdTipoFlujo;
                        info_og.IdPersona = item.IdPersona;
                        info_og.Referencia = item.Referencia;
                        info_og.IdUsuario = param.IdUsuario;
                        info_og.nom_pc = param.nom_pc;
                        info_og.ip = param.ip;
                    //Campos para cuota
                        info_og.Info_cuotas_x_doc.Cancela_cuota = item.Info_cuotas_x_doc.Cancela_cuota;
                        info_og.Info_cuotas_x_doc.IdCuota = item.Info_cuotas_x_doc.IdCuota;
                        info_og.Info_cuotas_x_doc.Secuencia = item.Info_cuotas_x_doc.Secuencia;

                        lista.Add(info_og);
                    
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
     
        private void gridView_Factura_x_Pagar_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
          
        }

        private void gridView_Factura_x_Pagar_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                cp_orden_giro_Info row1 = new cp_orden_giro_Info();
                row1 = (cp_orden_giro_Info)gridView_Factura_x_Pagar.GetRow(e.RowHandle);
                
                if (e.Column.Name == "colcheck")
                {
                    if (row1.Saldo_OG_AUX == 0)
                    {
                        MessageBox.Show("No hay saldo para Asignar", "Sistemas");
                        return;
                    }

                    if ((bool)gridView_Factura_x_Pagar.GetFocusedRowCellValue(colcheck))
                    {
                        gridView_Factura_x_Pagar.SetFocusedRowCellValue(colcheck, false);

                        gridView_Factura_x_Pagar.SetFocusedRowCellValue(colIdEstadoAprobacion, row1.IdEstadoAprobacion_aux);
                        gridView_Factura_x_Pagar.SetFocusedRowCellValue(colSaldo_OG, row1.Saldo_OG_AUX);
                        gridView_Factura_x_Pagar.SetFocusedRowCellValue(colValor_a_Pagar, 0);
                        row1.Info_cuotas_x_doc.Cancela_cuota = false;
                     
                    }
                    else
                    {
                        gridView_Factura_x_Pagar.SetFocusedRowCellValue(colcheck, true);
                        gridView_Factura_x_Pagar.SetFocusedRowCellValue(colIdEstadoAprobacion, "APRO");
                        if (row1.Info_cuotas_x_doc.Valor_cuota != null)
                        {
                            if (MessageBox.Show("¿Este documento tiene una cuota pendiente de pago, ¿Desea cancelar la cuota actual?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                gridView_Factura_x_Pagar.SetFocusedRowCellValue(colValor_a_Pagar, row1.Info_cuotas_x_doc.Valor_cuota);
                                gridView_Factura_x_Pagar.SetFocusedRowCellValue(colSaldo_OG, 0);
                                row1.Info_cuotas_x_doc.Cancela_cuota = true;
                                
                            }
                            else
                            {
                                gridView_Factura_x_Pagar.SetFocusedRowCellValue(colValor_a_Pagar, row1.Saldo_OG_AUX);
                                gridView_Factura_x_Pagar.SetFocusedRowCellValue(colSaldo_OG, 0);
                            }
                        }
                        else
                        {
                            gridView_Factura_x_Pagar.SetFocusedRowCellValue(colValor_a_Pagar, row1.Saldo_OG_AUX);
                            gridView_Factura_x_Pagar.SetFocusedRowCellValue(colSaldo_OG, 0);
                        }
                        

                        frmCP_Alerta_Anticipos_x_NotasCreditos ofrm = new frmCP_Alerta_Anticipos_x_NotasCreditos();
                        ofrm.IdEmpresa = row1.IdEmpresa;
                        ofrm.IProveedor = row1.IdProveedor;
                        ofrm.carga_Grid();

                        if (auxliar1 != ofrm.IProveedor)
                        {
                            if (ofrm.lista_AnticipoSaldo.Count != 0) 
                            {
                                ofrm.ShowDialog();
                                auxliar1 = row1.IdProveedor;
                            }
                        }
                    }
                
                }
            }
            catch (Exception ex)
            {
                
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridView_Factura_x_Pagar_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                cp_orden_giro_Info row1 = new cp_orden_giro_Info();
                row1 = (cp_orden_giro_Info)gridView_Factura_x_Pagar.GetRow(e.RowHandle);

                if (e.Column.Name == "colValor_a_Pagar")
                {
                    if (Convert.ToDouble(gridView_Factura_x_Pagar.GetFocusedRowCellValue(colValor_a_Pagar)) < 0)
                    {
                        /*
                        MessageBox.Show("No se permiten valores negativos", "Sistemas");
                        gridView_Factura_x_Pagar.SetFocusedRowCellValue(colValor_a_Pagar, 0);
                        return;
                         * */
                    }
                    else
                    {
                        if (Convert.ToDouble(gridView_Factura_x_Pagar.GetFocusedRowCellValue(colValor_a_Pagar)) == 0)
                        {
                            gridView_Factura_x_Pagar.SetFocusedRowCellValue(colcheck, false);
                            gridView_Factura_x_Pagar.SetFocusedRowCellValue(colSaldo_OG, row1.Saldo_OG_AUX);
                            return;
                        }
                        if (Convert.ToDouble(gridView_Factura_x_Pagar.GetFocusedRowCellValue(colValor_a_Pagar)) > row1.Saldo_OG_AUX)
                        {
                            MessageBox.Show("El Valor a Pagar no puede ser mayor al Saldo", "Sistemas");
                            gridView_Factura_x_Pagar.SetFocusedRowCellValue(colValor_a_Pagar, 0);
                            return;
                        }

                        else
                        {
                            double total = 0;
                            total = row1.Saldo_OG_AUX - Convert.ToDouble(gridView_Factura_x_Pagar.GetFocusedRowCellValue(colValor_a_Pagar));

                            gridView_Factura_x_Pagar.SetFocusedRowCellValue(colSaldo_OG, total);
                            gridView_Factura_x_Pagar.SetFocusedRowCellValue(colcheck, true);
                        }
                    }
                }
                Calcular_Total_a_Pagar();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                carga_grid();
                txtValor_a_pagar.Text = string.Empty;
            }
            catch (Exception ex)
            {
                
               Log_Error_bus.Log_Error(ex.ToString());
               MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Calcular_Total_a_Pagar()
        {
            try
            {
                double total_a_pagar = 0;

                foreach (var item in factura_x_pagar)
                {
                    if (item.check)
                    {
                        total_a_pagar += item.Valor_a_Pagar;
                    }
                }
                txtValor_a_pagar.Text = total_a_pagar.ToString();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnImprimir_Grid_Click(object sender, EventArgs e)
        {
            try
            {
                gridControl_Factura_x_Pagar.ShowPrintPreview();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkAprobar_Click(object sender, EventArgs e)
        {
            
        }

        private void gridView_Factura_x_Pagar_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                RowHandle = e.FocusedRowHandle;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkAprobar_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                cp_orden_giro_Info row1 = new cp_orden_giro_Info();
                row1 = (cp_orden_giro_Info)gridView_Factura_x_Pagar.GetRow(RowHandle);

                if (row1 == null)
                {
                    return;
                }
                if (row1.Saldo_OG_AUX == 0)
                {
                    MessageBox.Show("No hay saldo para Asignar", "Sistemas");
                    return;
                }

                if ((bool)gridView_Factura_x_Pagar.GetFocusedRowCellValue(colcheck))
                {
                    gridView_Factura_x_Pagar.SetFocusedRowCellValue(colcheck, false);

                    gridView_Factura_x_Pagar.SetFocusedRowCellValue(colIdEstadoAprobacion, row1.IdEstadoAprobacion_aux);
                    gridView_Factura_x_Pagar.SetFocusedRowCellValue(colSaldo_OG, row1.Saldo_OG_AUX);
                    gridView_Factura_x_Pagar.SetFocusedRowCellValue(colValor_a_Pagar, 0);
                    row1.Info_cuotas_x_doc.Cancela_cuota = false;
                }
                else
                {
                    gridView_Factura_x_Pagar.SetFocusedRowCellValue(colcheck, true);
                    gridView_Factura_x_Pagar.SetFocusedRowCellValue(colIdEstadoAprobacion, "APRO");
                    if (row1.Info_cuotas_x_doc.Valor_cuota != null)
                    {
                        if (MessageBox.Show("¿Este documento tiene una cuota pendiente de pago, \n¿Desea cancelar la cuota actual [SI] o desea cancelarla totalmente [NO]?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            gridView_Factura_x_Pagar.SetFocusedRowCellValue(colValor_a_Pagar, row1.Info_cuotas_x_doc.Valor_cuota);
                            gridView_Factura_x_Pagar.SetFocusedRowCellValue(colSaldo_OG, 0);
                            row1.Info_cuotas_x_doc.Cancela_cuota = true;
                        }
                        else
                        {
                            gridView_Factura_x_Pagar.SetFocusedRowCellValue(colValor_a_Pagar, row1.Saldo_OG_AUX);
                            gridView_Factura_x_Pagar.SetFocusedRowCellValue(colSaldo_OG, 0);
                        }
                    }
                    else
                    {
                        gridView_Factura_x_Pagar.SetFocusedRowCellValue(colValor_a_Pagar, row1.Saldo_OG_AUX);
                        gridView_Factura_x_Pagar.SetFocusedRowCellValue(colSaldo_OG, 0);
                    }

                    
                   
                    frmCP_Alerta_Anticipos_x_NotasCreditos ofrm = new frmCP_Alerta_Anticipos_x_NotasCreditos();
                    ofrm.IdEmpresa = row1.IdEmpresa;
                    ofrm.IProveedor = row1.IdProveedor;
                    ofrm.carga_Grid();

                    if (auxliar1 != ofrm.IProveedor)
                    {
                        if (ofrm.lista_AnticipoSaldo.Count != 0)
                        {
                            ofrm.ShowDialog();
                            auxliar1 = row1.IdProveedor;
                        }
                    }
                     
                    



                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Agrupar_Click(object sender, EventArgs e)
        {
            try
            {
                if (btn_Agrupar.Text=="Agrupar por beneficiario")
                {
                    colnom_proveedor.GroupIndex = 1;
                    btn_Agrupar.Text = "Desagrupar";
                    //colnom_proveedor.Visible = true;
                }
                else
                {
                    colnom_proveedor.GroupIndex = -1;
                    btn_Agrupar.Text = "Agrupar por beneficiario";
                    //colnom_proveedor.Visible = true;
                }
                
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCP_Aprobacion_Facturas_x_Pagar_FormClosing(object sender, FormClosingEventArgs e)
        {
            event_frmCP_Aprobacion_Facturas_x_Pagar(sender, e);
        }

        
    }
}
