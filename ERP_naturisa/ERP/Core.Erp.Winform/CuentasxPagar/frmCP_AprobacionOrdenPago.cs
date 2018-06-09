using Core.Erp.Business.CuentasxPagar;
using Core.Erp.Business.General;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Core.Erp.Winform.CuentasxPagar
{
    public partial class frmCP_AprobacionOrdenPago : Form
    {
        #region Declaración Variables

        //Listas
        List<vwtb_persona_beneficiario_Info> list_Beneficiario = new List<vwtb_persona_beneficiario_Info>();
        List<cp_orden_pago_tipo_Info> list_OrdenTipPago = new List<cp_orden_pago_tipo_Info>();
        List<cp_Aprobacion_Orden_Pago_Det_Info> Listdet;
        List<cp_orden_pago_formapago_Info> lista_FormaPago = new List<cp_orden_pago_formapago_Info>();
        List<cp_orden_pago_estado_aprob_Info> lista_EstadoAprobacion = new List<cp_orden_pago_estado_aprob_Info>();


        //bus
        vwtb_persona_beneficiario_Bus Bus_Proveedor = new vwtb_persona_beneficiario_Bus();
        cp_orden_pago_formapago_Bus Bus_FormaPago = new cp_orden_pago_formapago_Bus();
        cp_orden_pago_estado_aprob_Bus Bus_EstadoAprobacion = new cp_orden_pago_estado_aprob_Bus();
        cp_orden_pago_tipo_Bus Bus_OrdenTipPago = new cp_orden_pago_tipo_Bus();
        cp_orden_pago_tipo_x_empresa_Bus Bus_OrdTipPagEmpr = new cp_orden_pago_tipo_x_empresa_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        cp_Aprobacion_Orden_Pago_Bus Bus_AprobacionOrdenCab = new cp_Aprobacion_Orden_Pago_Bus();
        cp_Aprobacion_Orden_Pago_Det_Bus Bus_AprobacionOrden = new cp_Aprobacion_Orden_Pago_Det_Bus();
        cp_Aprobacion_Orden_Pago_Info Cab = new cp_Aprobacion_Orden_Pago_Info();
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        //cp_orden_pago_Info Info_Orden_Pago = new cp_orden_pago_Info();
        vwcp_orden_pago_con_cancelacion_Bus orden_pago_con_cancelacion_Bus = new vwcp_orden_pago_con_cancelacion_Bus();

        //BindingList<cp_Aprobacion_Orden_Pago_Det_Info> Obj_DetalleAprob = new BindingList<cp_Aprobacion_Orden_Pago_Det_Info>();
        BindingList<vwcp_orden_pago_con_cancelacion_Info> Obj_DetalleAprob = new BindingList<vwcp_orden_pago_con_cancelacion_Info>();

        vwtb_persona_beneficiario_Info G_persona_beneficiario_Info_obj = new vwtb_persona_beneficiario_Info();
     
        //variables
            int i;//bandera para controlar check
            int j;//bandera para validar si se esta selccionando un check
            string Estado = "";
        
            Cl_Enumeradores.eTipo_action enu = new Cl_Enumeradores.eTipo_action();
            int bandera = 0;
            int contador = 0;
            string FormaPago = "";
        #endregion

        public frmCP_AprobacionOrdenPago()
        {
            try
            {
                InitializeComponent();
                //G_persona_beneficiario_Info_obj = new vwtb_persona_beneficiario_Info();                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       

        public void Insertar_OrdenPago()
        {
           
            try
            {
                GetCabecera();

                decimal Id = 0;
                string mensaje = "";

                cp_Aprobacion_Orden_Pago_Det_Bus detalle = new cp_Aprobacion_Orden_Pago_Det_Bus();

                if (Bus_AprobacionOrdenCab.Guardar_AprobacionOrdenPago(Cab, ref Id, ref mensaje))
                {
                    detalle.GuardarDB(Cab.Detalle, ref Id, ref mensaje);

                    string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Grabar, "La Aprobación Orden de Pago", Id);
                    MessageBox.Show(smensaje, param.Nombre_sistema);

                    this.txtNumAprobacion.Text = Convert.ToString(Id);
                    //ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                    //ucGe_Menu.Visible_btnGuardar = false;
                    ucGe_Menu.Visible_bntLimpiar = true;
                    
                    List<vwcp_orden_pago_con_cancelacion_Info> list = new List<vwcp_orden_pago_con_cancelacion_Info>();
                    list = orden_pago_con_cancelacion_Bus.Get_List_orden_pago_para_aprobacion(param.IdEmpresa, "", 0, 0, "PENDI");
                    Obj_DetalleAprob = new BindingList<vwcp_orden_pago_con_cancelacion_Info>(list);

                    this.gridAprobacionOrdenPago.DataSource = Obj_DetalleAprob;
                    LimpiarDatos();
                }
                else
                {
                    string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgError_Grabar);
                    MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);   
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void GetCabecera()
        {
            try
            {              
                    Cab.IdEmpresa = param.IdEmpresa;
                    Cab.Fecha_Aprobacion = dtpFecha.Value;
                    Cab.Observacion = this.txtObservacion.Text;
                    Cab.UsuarioAprobacion = param.IdUsuario;
                    Cab.Fecha_Transaccion = DateTime.Now;

                    GetDetalle();

                    // Cab.Detalle = DataSource.ToList();           
                    Cab.Detalle = Listdet;
              
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Boolean Validar()
        {
            try
            {
                int conta = 0;
                foreach (var item in Obj_DetalleAprob)
                {
                    if (item.Check == true)
                    {
                        conta = conta + 1;
                        
                        if (item.Total_cancelado_OP > 0 && item.IdEstadoAprobacion == "REPRO")
                        {
                            MessageBox.Show("No se puede reporbar una Orden de Pago cuando ya a sido cancelada");
                            return false;
                        }
                        else if (item.IdEstadoAprobacion == "REPRO" && (item.Observacion == null || item.Observacion == ""))
                        {
                            MessageBox.Show("Para reprobar una Orden de Pago es obligatorio ingresar el motivo");
                            return false;
                        }
                        else if (item.Estado == "I")
                        {
                            MessageBox.Show("No se puede modificar una Orden de Pago Anulada.");
                            return false;
                        }
                    }

                    
                }

                if(conta==0)
                {
                    MessageBox.Show(param.Get_Mensaje_sys( enum_Mensajes_sys.Seleccione_un_registro), param.Nombre_sistema);
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public void GetDetalle()
        {
            try
            {
                Listdet = new List<cp_Aprobacion_Orden_Pago_Det_Info>();

                foreach (var item in Obj_DetalleAprob)
                {
                    if (item.Check == true)
                    {
                        cp_Aprobacion_Orden_Pago_Det_Info info_det = new cp_Aprobacion_Orden_Pago_Det_Info();
                        
                        
                      // detalle de update
                            info_det.IdEmpresa = param.IdEmpresa;
                            info_det.Fecha_OP = item.Fecha_OP;
                            info_det.IdFormaPago = item.IdFormaPago;
                            info_det.Fecha_Pago = item.Fecha_Pago;
                            info_det.IdEstadoAprobacion = item.IdEstadoAprobacion;
                            info_det.Motivo = item.Observacion;
                            info_det.Usuario = param.IdUsuario;

                            //detalle de aprobación
                            info_det.IdAprobacion = item.IdAprobacion;
                            info_det.IdEmpresa_OP = item.IdEmpresa;
                            info_det.Secuencia_OP = item.Secuencia_OP;
                            info_det.IdOrdenPago_OP = item.IdOrdenPago;

                            Listdet.Add(info_det);
                        
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCP_AprobacionOrdenPago_Load(object sender, EventArgs e)
        {
            try
            {
                Carga_Combos();
                cp_Aprobacion_Orden_Pago_Info info = new cp_Aprobacion_Orden_Pago_Info();
                info.Fecha_Transaccion = param.Fecha_Transac;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void Carga_Combos()
        {
            try
            {
                //decimal i = 1;

                orden_pago_con_cancelacion_Bus = new vwcp_orden_pago_con_cancelacion_Bus();

                lista_EstadoAprobacion = Bus_EstadoAprobacion.Get_List_orden_pago_estado_aprob();
                cmbEstadoAprobacion.Properties.DataSource = lista_EstadoAprobacion;
                cmbEstadoAprobacion.EditValue = "PENDI";
                Estado=cmbEstadoAprobacion.EditValue.ToString();

                //cargar combo forma de pago y estado de aprobacion
                lista_FormaPago = Bus_FormaPago.Get_List_orden_pago_formapago();
                cmbFormaPago.Properties.DataSource = lista_FormaPago;

                repositoryItemSearchLookUpEdit1.DataSource = Bus_FormaPago.Get_List_orden_pago_formapago();
                repositoryItemSearchLookUpEdit2.DataSource = Bus_EstadoAprobacion.Get_List_orden_pago_estado_aprob();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void cargar_grid()
        {
            try
            {
                // Carga de Grid
                Obj_DetalleAprob = new BindingList<vwcp_orden_pago_con_cancelacion_Info>(orden_pago_con_cancelacion_Bus.Get_List_orden_pago_con_cancelacion(param.IdEmpresa,
                    G_persona_beneficiario_Info_obj.IdTipo_Persona, G_persona_beneficiario_Info_obj.IdPersona
                    , G_persona_beneficiario_Info_obj.IdEntidad, Estado));

                gridAprobacionOrdenPago.DataSource = Obj_DetalleAprob;
                
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
 

        private void cmbBeneficiario_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
           
        }

        private void checkTodos_CheckedChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (checkTodos.Checked == true)
                {
                    foreach (var item in Obj_DetalleAprob)
                    {
                        if (item.Estado == "A")
                        {
                            item.Check = true;
                            item.IdEstadoAprobacion = "APRO";
                            contador++;
                            j = 1;
                        }
                    }
                }
                else
                {
                    if (i == 0)
                    {
                        foreach (var item in Obj_DetalleAprob)
                        {
                            if (item.Estado == "A")
                            {
                                item.Check = false;
                                item.IdEstadoAprobacion = item.IdEstadoAprobacion_AUX;
                                contador = 0;
                            }
                        }
                    }
                    i = 0;
                    j = 0;
                }
                gridAprobacionOrdenPago.RefreshDataSource();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbEstadoAprobacion_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                //vwcp_orden_pago_con_cancelacion_Info Info_Pago = new vwcp_orden_pago_con_cancelacion_Info();
                //orden_pago_con_cancelacion_Bus = new vwcp_orden_pago_con_cancelacion_Bus();

                //List<vwcp_orden_pago_con_cancelacion_Info> list = new List<vwcp_orden_pago_con_cancelacion_Info>();

                //G_persona_beneficiario_Info_obj = (vwtb_persona_beneficiario_Info)cmbBeneficiario.Properties.View.GetFocusedRow();

                //if (G_persona_beneficiario_Info_obj == null)
                //{
                //    G_persona_beneficiario_Info_obj = new vwtb_persona_beneficiario_Info();
                //}

                //Estado=cmbEstadoAprobacion.EditValue.ToString();

                //list = orden_pago_con_cancelacion_Bus.Get_List_orden_pago_con_cancelacion(param.IdEmpresa
                //    , G_persona_beneficiario_Info_obj.IdTipo_Persona, G_persona_beneficiario_Info_obj.IdPersona
                //    , G_persona_beneficiario_Info_obj.IdEntidad, Estado);

                //Obj_DetalleAprob = new BindingList<vwcp_orden_pago_con_cancelacion_Info>(list);
                //this.gridAprobacionOrdenPago.DataSource = Obj_DetalleAprob;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbFormaPago_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (ucGe_Beneficiario.Get_Persona_beneficiario_Info() == null)
                {

                    gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
                    Obj_DetalleAprob = new BindingList<vwcp_orden_pago_con_cancelacion_Info>();
                    gridAprobacionOrdenPago.DataSource = Obj_DetalleAprob;
                    return;
                }
                foreach (var item in Obj_DetalleAprob)
                {
                    item.IdFormaPago = cmbFormaPago.EditValue.ToString();
                    contador++;
                    j = 1;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkTodosBenif_CheckedChanged(object sender, EventArgs e)
        {
            try
            {

                    
                    cmbEstadoAprobacion.EditValue = "PENDI";
                    //cmbBeneficiario.Text = "[Vacío]";
                    List<vwcp_orden_pago_con_cancelacion_Info> list = new List<vwcp_orden_pago_con_cancelacion_Info>();
                    list = orden_pago_con_cancelacion_Bus.Get_List_orden_pago_con_cancelacion(param.IdEmpresa, "", 0, 0, "PENDI");
                    Obj_DetalleAprob = new BindingList<vwcp_orden_pago_con_cancelacion_Info>(list);

                    this.gridAprobacionOrdenPago.DataSource = Obj_DetalleAprob;                  
                 
                

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
 
        private void gridView_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                info = new vwcp_orden_pago_con_cancelacion_Info();
                info = (vwcp_orden_pago_con_cancelacion_Info)gridView.GetRow(e.RowHandle);
                if (info != null)
                {
                    if (info.Estado == "I")
                    {
                        MessageBox.Show("El registro está Inactivo, no se puede Aprobar", param.Nombre_sistema);

                        gridView.SetFocusedRowCellValue(cmbEstadoAprobacionGrid, info.IdEstadoAprobacion_AUX);
                        return;

                    }

                    var item = gridView.GetFocusedRowCellValue(cmbFormaPagoGrid);
                    var item2 = gridView.GetFocusedRowCellValue(cmbEstadoAprobacionGrid);
                    var item3 = gridView.GetFocusedRowCellValue(Fecha_Pago);
                    if (item != null && item2 != null && item3 != null)
                    {
                        gridView.SetFocusedRowCellValue(check, true);
                    }
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void gridView_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridView.GetRow(e.RowHandle) as vwcp_orden_pago_con_cancelacion_Info;
                if (data == null)
                    return;

                if (data.Estado == "I")
                    e.Appearance.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                this.txtNumAprobacion.Focus();
                if (Validar())
                {
                    Insertar_OrdenPago();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }

        private void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                this.txtNumAprobacion.Focus();
                if (Validar())
                {
                    Insertar_OrdenPago();
                }
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
        }

        private void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_event_btnlimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                LimpiarDatos();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        void LimpiarDatos()
        {
            try
            {
               
                
                ucGe_Menu.Visible_bntGuardar_y_Salir = true;
                ucGe_Menu.Visible_btnGuardar = true;
                ucGe_Menu.Visible_bntLimpiar = true;

                txtNumAprobacion.Text = "";
                txtObservacion.Text = "";
                cmbEstadoAprobacion.EditValue = "PENDI";
                cmbFormaPago.Text = "[Vacío]";
                dtpFecha.Value = DateTime.Now;
                checkTodos.Checked = false;
                Estado = "PENDI";
                Obj_DetalleAprob = new BindingList<vwcp_orden_pago_con_cancelacion_Info>(orden_pago_con_cancelacion_Bus.Get_List_orden_pago_para_aprobacion(param.IdEmpresa,
                        G_persona_beneficiario_Info_obj.IdTipo_Persona, G_persona_beneficiario_Info_obj.IdPersona
                        , G_persona_beneficiario_Info_obj.IdEntidad, Estado));
                this.gridAprobacionOrdenPago.DataSource = Obj_DetalleAprob;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        vwcp_orden_pago_con_cancelacion_Info info;
        
        private void gridView_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                info = new vwcp_orden_pago_con_cancelacion_Info();
                info = (vwcp_orden_pago_con_cancelacion_Info)gridView.GetRow(e.RowHandle);
              
                              
                if (e.Column.Name == "check")
                {
                    if (info.Estado == "I")
                    {
                        MessageBox.Show("El registro está Inactivo, no se puede Aprobar", param.Nombre_sistema);
                        return;

                    }
                    
                    if ((bool)gridView.GetFocusedRowCellValue(check))
                    {
                        gridView.SetFocusedRowCellValue(check, false);
                        gridView.SetFocusedRowCellValue(cmbEstadoAprobacionGrid, gridView.GetFocusedRowCellValue(colIdEstadoAprobacion_AUX));

                    }

                    else
                    {                                                                 
                        gridView.SetFocusedRowCellValue(check, true);
                        gridView.SetFocusedRowCellValue(cmbEstadoAprobacionGrid, "APRO");
                                          
                    }
                }
                Calcular_total_seleccionadas();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Calcular_total_seleccionadas()
        {
            try
            {
                double Total = 0;

                foreach (var item in Obj_DetalleAprob.Where(q => q.Check == true).ToList())
                {
                    Total += item.Valor_estimado_a_pagar_OP;
                }

                txtTotal_op_seleccionadas.Text = Math.Round(Total,2,MidpointRounding.AwayFromZero).ToString();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                
                    vwcp_orden_pago_con_cancelacion_Info Info_Pago = new vwcp_orden_pago_con_cancelacion_Info();
                    orden_pago_con_cancelacion_Bus = new vwcp_orden_pago_con_cancelacion_Bus();

                    List<vwcp_orden_pago_con_cancelacion_Info> list = new List<vwcp_orden_pago_con_cancelacion_Info>();

                    G_persona_beneficiario_Info_obj = (vwtb_persona_beneficiario_Info)ucGe_Beneficiario.Get_Persona_beneficiario_Info();

                    
                        Estado = cmbEstadoAprobacion.EditValue.ToString();
                        list = orden_pago_con_cancelacion_Bus.Get_List_orden_pago_para_aprobacion(param.IdEmpresa
                            , ucGe_Beneficiario.IdTipo_Persona.ToString(), G_persona_beneficiario_Info_obj.IdPersona
                            , G_persona_beneficiario_Info_obj.IdEntidad, Estado);
                        if (list.Count() != 0)
                        {
                            Obj_DetalleAprob = new BindingList<vwcp_orden_pago_con_cancelacion_Info>(list);
                            this.gridAprobacionOrdenPago.DataSource = Obj_DetalleAprob;
                        }
                        else
                        {
                            MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.El_beneficiario_no_tiene_Orden_Pago_pendi), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    
                

                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }       
         
    }
}
