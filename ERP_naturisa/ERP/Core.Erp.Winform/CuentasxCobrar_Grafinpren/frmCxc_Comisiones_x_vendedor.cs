using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Info.CuentasxCobrar_Grafinpren;
using Core.Erp.Business.CuentasxCobrar_Grafinpren;
using Core.Erp.Business.General;
using DevExpress.XtraEditors;
using Core.Erp.Info.CuentasxCobrar;
using Core.Erp.Business.CuentasxCobrar;
using Cus.ERP.Reports.Grafinpren.CuentasxCobrar;
using Core.Erp.Info.Facturacion;
using Core.Erp.Winform.Facturacion_Grafinpren;
using Core.Erp.Business.Facturacion;
using Core.Erp.Business.Facturacion_Grafinpren;

namespace Core.Erp.Winform.CuentasxCobrar_Grafinpren
{
    public partial class frmCxc_Comisiones_x_vendedor : Form
    {
        #region Variables
        #region Parametros
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        #endregion
        #region cxc_comisiones_x_vendedor
        cxc_Comisiones_x_vendedor_Bus bus_comisiones = new cxc_Comisiones_x_vendedor_Bus();
        cxc_Comisiones_x_vendedor_Info row = new cxc_Comisiones_x_vendedor_Info();
        BindingList<cxc_Comisiones_x_vendedor_Info> blist_comisiones = new BindingList<cxc_Comisiones_x_vendedor_Info>();
        List<cxc_Comisiones_x_vendedor_Info> list_comisiones = new List<cxc_Comisiones_x_vendedor_Info>();        
        #endregion
        #region cxc_cobro
        BindingList<cxc_cobro_tipo_Info> Bind_List_Cobro = new BindingList<cxc_cobro_tipo_Info>();
        cxc_cobro_tipo_Bus Bus_cobro_tipo = new cxc_cobro_tipo_Bus();
        List<string> lst_Cobro = new List<string>();
        #endregion
        #region fa_Factura
        fa_factura_Info info_factura = new fa_factura_Info();
        Core.Erp.Business.Facturacion.fa_factura_Bus bus_Factura = new Business.Facturacion.fa_factura_Bus();
        Core.Erp.Business.Facturacion_Grafinpren.fa_factura_Bus bus_factura_graf = new Business.Facturacion_Grafinpren.fa_factura_Bus();
        #endregion
        #region fa_notaCreDeb
        fa_notaCreDeb_Info info_NotaDebito = new fa_notaCreDeb_Info();
        fa_notaCredDeb_Bus bus_NotaDebito = new fa_notaCredDeb_Bus();
        fa_notaCreDeb_graf_Bus bus_NotaDebito_graf = new fa_notaCreDeb_graf_Bus(); 

        #endregion
        #region Variables
        int rowHandle = 0;
        #endregion
        #endregion

        public frmCxc_Comisiones_x_vendedor()
        {
            InitializeComponent();
        }

        private void ucGe_Menu_Mantenimiento_x_usuario1_event_btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                Cargar_comisiones();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_Superior_Mant1_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Guardar())
                {
                    MessageBox.Show(param.Get_Mensaje_sys(Info.General.enum_Mensajes_sys.Se_guardaron_los_datos_correctamente), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    if (MessageBox.Show(param.Get_Mensaje_sys(Info.General.enum_Mensajes_sys.Desea_Imprimir), param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                    {
                        Imprimir();
                    }
                    Limpiar();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cargar_combos()
        {
            try
            {
                Bind_List_Cobro = new BindingList<cxc_cobro_tipo_Info>(Bus_cobro_tipo.Get_List_Cobro_Tipo());
                
                foreach (var item in Bind_List_Cobro)
                {
                    string tipo = item.IdCobro_tipo;
                    lst_Cobro.Add(tipo);
                }
                chkCombo_TipoCobro.Properties.DataSource = lst_Cobro;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_Superior_Mant1_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (Guardar())
                {
                    MessageBox.Show(param.Get_Mensaje_sys(Info.General.enum_Mensajes_sys.Se_guardaron_los_datos_correctamente), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    if (MessageBox.Show(param.Get_Mensaje_sys(Info.General.enum_Mensajes_sys.Desea_Imprimir), param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                    {
                        Imprimir();
                    }
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_Superior_Mant1_event_btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                Imprimir();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_Superior_Mant1_event_btnlimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                Limpiar();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cargar_comisiones()
        {
            try
            {
                int IdVendedor = ucFa_VendedorCmb1.get_VendedorInfo() == null ? 0 : ucFa_VendedorCmb1.get_VendedorInfo().IdVendedor;
                DateTime Fecha_ini = ucGe_Menu_Mantenimiento_x_usuario1.fecha_desde;
                DateTime Fecha_fin = ucGe_Menu_Mantenimiento_x_usuario1.fecha_hasta;
                fa_Vendedor_Info info_vendedor = ucFa_VendedorCmb1.get_VendedorInfo();

                lst_Cobro = new List<string>();
                foreach (var item in chkCombo_TipoCobro.Properties.Items.GetCheckedValues().ToList())
                {
     	            lst_Cobro.Add(item.ToString());
                }
                blist_comisiones = new BindingList<cxc_Comisiones_x_vendedor_Info>(bus_comisiones.Get_list_x_empresa(param.IdEmpresa, Fecha_ini, Fecha_fin,lst_Cobro,IdVendedor));
                gridControlComisiones_x_vendedor.DataSource = blist_comisiones;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Limpiar()
        {
            try
            {
                list_comisiones = new List<cxc_Comisiones_x_vendedor_Info>();
                blist_comisiones = new BindingList<cxc_Comisiones_x_vendedor_Info>();
                gridControlComisiones_x_vendedor.DataSource = blist_comisiones;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Imprimir()
        {
            try
            {
                int IdVendedor = ucFa_VendedorCmb1.get_VendedorInfo() == null ? 0 : ucFa_VendedorCmb1.get_VendedorInfo().IdVendedor;
                DateTime Fecha_ini = ucGe_Menu_Mantenimiento_x_usuario1.fecha_desde;
                DateTime Fecha_fin = ucGe_Menu_Mantenimiento_x_usuario1.fecha_hasta;
                lst_Cobro = new List<string>();
                foreach (var item in chkCombo_TipoCobro.Properties.Items.GetCheckedValues().ToList())
                {
     	            lst_Cobro.Add(item.ToString());
                }
                XCXC_GRAF_Rpt001_Rpt rpt = new XCXC_GRAF_Rpt001_Rpt();
                rpt.set_parametros(param.IdEmpresa, IdVendedor, Fecha_ini, Fecha_fin, lst_Cobro);
                rpt.ShowPreviewDialog();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool Guardar()
        {
            try
            {
                bool res = false;
                if (Validar())
                {
                    Get();
                    Calcular();
                    if (bus_comisiones.GuardarDB(list_comisiones))
                    {
                       res = true;
                    }
                }
                return res;    
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void Get()
        {
            try
            {
                list_comisiones = new List<cxc_Comisiones_x_vendedor_Info>(blist_comisiones);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool Validar()
        {
            try
            {
                if (blist_comisiones.Count == 0)
                {
                    MessageBox.Show("No existen registros para guardar.",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    return false;
                }
                if (chkCombo_TipoCobro.Text == "")
                {
                    MessageBox.Show("Seleccione un tipo de cobro.",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void gridViewComisiones_x_vendedor_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                row = (cxc_Comisiones_x_vendedor_Info)gridViewComisiones_x_vendedor.GetRow(e.RowHandle);
                double Valor_pagado = 0;
                Valor_pagado = (double)row.Base_com * ((double)row.Porc_pagado / 100);
                if (e.Column == col_Porc_pactado)
                {
                    
                }
                if (e.Column == col_Porc_pagado)
                {
                    gridViewComisiones_x_vendedor.SetFocusedRowCellValue(col_Valor_pagado, Valor_pagado);
                    
                }                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
        }

        private void Calcular()
        {
            try
            {
                foreach (var item in blist_comisiones)
                {
                    item.Valor_pagado = (double)item.Base_com * (item.Porc_pagado / 100);
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                Calcular();
                Guardar();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCxc_Comisiones_x_vendedor_Load(object sender, EventArgs e)
        {
            try
            {
                Cargar_combos();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_Superior_Mant1_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
                
        private void Llamar_formulario_NTDB(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdNota)
        {
            try
            {
                info_NotaDebito = bus_NotaDebito.Get_Info_notaCreDeb_x_ND(IdEmpresa, IdSucursal, IdBodega, IdNota);

                if (info_NotaDebito!=null)
                {
                    info_NotaDebito.NotaCreDeb_Graf_Info = bus_NotaDebito_graf.get_Info_graf(IdEmpresa, IdSucursal, IdBodega, IdNota);
                    frmFa_Nota_Deb_Graf_Mant frm = new frmFa_Nota_Deb_Graf_Mant();
                    frm.setAccion(Info.General.Cl_Enumeradores.eTipo_action.actualizar);
                    frm.SetInfo(info_NotaDebito);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                    frm.Event_frmFA_NotaCreditoDebito_FormClosing += frm_Event_frmFA_NotaCreditoDebito_FormClosing;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void frm_Event_frmFA_NotaCreditoDebito_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Cargar_comisiones();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Llamar_formulario_FACT(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdCbteVta)
        {
            try
            {
                info_factura = bus_Factura.Get_Info_factura(IdEmpresa, IdSucursal, IdBodega, IdCbteVta);                
                if (info_factura!=null)
                {
                    info_factura.Factura_Graf = bus_factura_graf.Get_Info_graf(IdEmpresa, IdSucursal, IdBodega, IdCbteVta);
                    frmFa_Factura_Mant frm = new frmFa_Factura_Mant();
                    frm.Set_Accion(Info.General.Cl_Enumeradores.eTipo_action.actualizar);
                    frm.Set_Info(info_factura);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                    frm.event_frmFA_Factura_FormClosing += frm_event_frmFA_Factura_FormClosing;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void frm_event_frmFA_Factura_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Cargar_comisiones();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                row = (cxc_Comisiones_x_vendedor_Info)gridViewComisiones_x_vendedor.GetRow(rowHandle);
                if (row == null) return;
                switch (row.vt_tipoDoc)
                {
                    case "SIN CBTE":
                        MessageBox.Show("El registro es un cobro sin comprobante.", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        break;
                    case "NTDB":
                        Llamar_formulario_NTDB(row.IdEmpresa, (int)row.IdSucursal_fact, (int)row.IdBodega_fact, (decimal)row.IdCbteVta_fact);
                        break;
                    default:
                        Llamar_formulario_FACT(row.IdEmpresa, (int)row.IdSucursal_fact, (int)row.IdBodega_fact, (decimal)row.IdCbteVta_fact);
                        break;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewComisiones_x_vendedor_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                rowHandle = e.FocusedRowHandle;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
    }
}
