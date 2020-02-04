using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Business.Compras;
using Core.Erp.Info.Compras;
using Core.Erp.Business.Inventario;
using Core.Erp.Info.Inventario;
using Core.Erp.Winform.Inventario;





using DevExpress.XtraPrinting;


namespace Core.Erp.Winform.Compras
{
    public partial class frmCom_OrdenCompra_Aprobar : Form
    {
        #region Declaración de Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        BindingList<com_ordencompra_local_Info> LstOC = new BindingList<com_ordencompra_local_Info>();
        com_ordencompra_local_Bus BusOC = new com_ordencompra_local_Bus();
        com_ordencompra_local_Info InfoOC = new com_ordencompra_local_Info();
        frmCom_OrdenCompra_Mant frm = new frmCom_OrdenCompra_Mant();
        com_Catalogo_Bus BusEstAP = new com_Catalogo_Bus();
        List<com_Catalogo_Info> LstEA = new List<com_Catalogo_Info>();
        com_ordencompra_local_Info info = new com_ordencompra_local_Info();
        tb_Sucursal_Bus BusSucursal = new tb_Sucursal_Bus();
        double? Total = 0;
        #endregion
        
        public frmCom_OrdenCompra_Aprobar()
        {
            try
            {
                InitializeComponent();

                LstEA = BusEstAP.Get_ListEstadoAprobacion();
                com_Catalogo_Info todos = new com_Catalogo_Info();
                todos.CodCatalogo = "TODOS";
                todos.descripcion = "TODOS";
                LstEA.Add(todos);

                cmbEstadoApro.Properties.DataSource = LstEA;
                cmbEstadoApro.Properties.ValueMember = "IdCatalogocompra";
                cmbEstadoApro.Properties.DisplayMember = "descripcion";
                cmbEstadoApro.EditValue = "xAPRO";
                DateTime  fecha = new DateTime();
                fecha = DateTime.Now;
                dTPFechaFin.Value = fecha.AddDays(1);
                dTPFechaIni.Value = fecha.AddDays(-30);

                ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
                ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
                ucGe_Menu.event_btnImprimir_Click += ucGe_Menu_event_btnImprimir_Click;
                ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
                ucGe_Menu.event_btnlimpiar_Click += ucGe_Menu_event_btnlimpiar_Click;
            
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_event_btnlimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                LimpiarDatos();
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
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        void LimpiarDatos()
        {
            try
            {                
                 dTPFechaFin.Focus();
                 LstOC = new BindingList<com_ordencompra_local_Info>();
                seteargrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        void ucGe_Menu_event_btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                string leftColumn = "Fecha: [Date Printed][Time Printed]";
                string middleColumn = "Página:[Page # of Pages #]";
                string rightColumn = "Usuario:" + param.IdUsuario;

                PageHeaderFooter phf = printableComponentLink1.PageHeaderFooter as PageHeaderFooter;

                phf.Header.Content.Clear();
                phf.Footer.Content.Clear();
                Font fte = new System.Drawing.Font("Tahoma", 8.5f, FontStyle.Bold, GraphicsUnit.Point);

                phf.Header.Font = fte;
                phf.Footer.Font = fte;
                phf.Header.Content.AddRange(new string[] { leftColumn, "", rightColumn, "hola" });
                phf.Header.LineAlignment = BrickAlignment.Center;
                phf.Footer.Content.AddRange(new string[] { "", "", middleColumn });
                phf.Footer.LineAlignment = BrickAlignment.Center;
                printableComponentLink1.Component = gridCtrlOCPend;

                printableComponentLink1.ShowPreview();
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
                if (getDet())
                {
                    grabar();
                    this.Close();
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
                if (getDet())
                {
                    grabar();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }
        
        void buscar()
        {
            try
            {               
                cmb_Aprob.DataSource = BusEstAP.Get_ListEstadoAprobacion();
              //  LstOC = BusOC.BusquedasOrdenCompra(param.IdEmpresa,1, dTPFechaIni.Value, dTPFechaFin.Value, Convert.ToString(this.cmbEstadoApro.EditValue));              

                LstOC = new BindingList<com_ordencompra_local_Info>(BusOC.Get_List_ordencompra_local(param.IdEmpresa, dTPFechaIni.Value, dTPFechaFin.Value, Convert.ToString(this.cmbEstadoApro.EditValue), "A"));

                foreach (var item in LstOC)
                {
                    item.Ico = (Bitmap)imageList1.Images[0];
                }

                gridCtrlOCPend.DataSource = LstOC; 
    
            }
            catch (Exception ex)
            {
            }
        
        }
       
        private void mnu_Modificar_Click(object sender, EventArgs e)
        {
            try
            {

                InfoOC = (com_ordencompra_local_Info)gridVwOCPend.GetFocusedRow();
                if (InfoOC != null)
                {

                    frm = new frmCom_OrdenCompra_Mant();
                    frm.Set_Info(InfoOC);
                    frm.Set_Accion(Cl_Enumeradores.eTipo_action.actualizar);
                    frm.Text = frm.Text + " ***MODIFICAR***";
                    frm.event_frmCom_OrdenCompra_Mant_FormClosing += new frmCom_OrdenCompra_Mant.delegate_frmCom_OrdenCompra_Mant_FormClosing(frm_event_frmCom_OrdenCompra_Mant_FormClosing);
                    frm.Show();

                }
                else
                {
                    MessageBox.Show("Seleccione un Registro a Modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);         
            }
        }

        void frm_event_frmCom_OC_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                   buscar();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mnu_consultar_Click(object sender, EventArgs e)
        {

            try
            {
                InfoOC = (com_ordencompra_local_Info)gridVwOCPend.GetFocusedRow();
                if (InfoOC != null)
                {
                    frm = new frmCom_OrdenCompra_Mant();
                    frm.Set_Info(InfoOC);
                    frm.Set_Accion(Cl_Enumeradores.eTipo_action.consultar);
                    frm.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Seleccione un Registro a Mostrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        private void gridVwOCPend_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                if (e.RowHandle > -1)
                    gridVwOCPend.SetFocusedRowCellValue(colCheck, true);

                
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
             buscar();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        void seteargrid()
        {
            try
            {
                LstOC = new BindingList<com_ordencompra_local_Info>();
                gridCtrlOCPend.DataSource = LstOC;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }     
        }

        void grabar()
         {

            try
            {
                string msg = "";
                cmbEstadoApro.Focus();

                foreach (var item in LstOC)
                {
                    if (item.check==true)
                    {
                        switch (item.IdEstadoAprobacion_cat)
                        {

                            case "ANU":
                                item.FechaHoraAnul = param.Fecha_Transac;
                                item.IdUsuarioUltAnu = param.IdUsuario;
                                item.MotivoAnulacion = "O/C Anulada x " + item.MotivoReprobacion;
                                if (item.MotivoAnulacion.Length > 499)
                                    item.MotivoAnulacion = item.MotivoAnulacion.Substring(0, 498);


                                if (BusOC.ReversarOC(item, ref msg))
                                    MessageBox.Show("Se ha Anulado la Orden de Compra No." +
                                        item.oc_NumDocumento, "SISTEMAS", MessageBoxButtons.OK, MessageBoxIcon.Information);


                                break;

                            case "APRO":

                                item.co_fecha_aprobacion = DateTime.Now;
                                item.IdUsuario_Aprueba = param.IdUsuario;
                                item.MotivoReprobacion="O/C Aprobada x " + item.MotivoReprobacion;
                                if (item.MotivoReprobacion.Length > 499)
                                    item.MotivoReprobacion = item.MotivoReprobacion.Substring(0, 498);

                                if (BusOC.Modificar_Estado_Aprob(item, ref msg))
                                {
                                    MessageBox.Show("Se ha actualizado correctamente la Orden de Compra No." +
                                       item.oc_NumDocumento, "SISTEMAS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                   
                                }
                           
                                break;

                            case "xAPRO":

                               // MessageBox.Show("LA OPCION DE DESAPROBAR ESTA BLOQUEADA TEMPORALMENTE ..OC#" + item.oc_NumDocumento, "SISTEMAS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


                                if (BusOC.Modificar_Estado_Aprob(item, ref msg))
                                {
                                    MessageBox.Show("Se ha actualizado correctamente la Orden de Compra No." +
                                       item.oc_NumDocumento, "SISTEMAS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }

                                break;

                            case "REP":

                                item.IdUsuario_Reprue = param.IdUsuario;
                                item.co_fechaReproba = param.Fecha_Transac;
                                item.MotivoReprobacion="O/C Reprobada x " + item.MotivoReprobacion;
                                if (item.MotivoReprobacion.Length > 499)
                                    item.MotivoReprobacion = item.MotivoReprobacion.Substring(0, 498);

                                if (BusOC.Modificar_Estado_Aprob(item, ref msg))
                                {
                                    MessageBox.Show("Se ha actualizado correctamente la Orden de Compra No." +
                                       item.oc_NumDocumento, "SISTEMAS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                  
                                }
                               
                                break;
                            default:
                                break;
                        }                   
                    }                                     
                }
                LimpiarDatos();
                cmbEstadoApro.EditValue = "xAPRO";
                buscar();
                
      
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);           
            }      
        }

        private Boolean getDet()
        {
            try
            {
                dTPFechaFin.Focus();
                LstOC = new BindingList<com_ordencompra_local_Info>();
                if (gridVwOCPend.RowCount > 0)
                {
                    for (int i = 0; i < gridVwOCPend.RowCount; i++)
                    {
                        var info = gridVwOCPend.GetRow(i) as com_ordencompra_local_Info;

                        if (info != null && info.check == true)
                        {
                           
                            LstOC.Add(info);
                        }
                    }

                    if (LstOC.Count < 1)
                    {
                        MessageBox.Show("Debe seleccionar las Ordenes de Compra a grabar", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        return false;                   
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar las Ordenes de Compra a grabar", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

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
               
        private void gridVwOCPend_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridVwOCPend.GetRow(e.RowHandle) as com_ordencompra_local_Info;
                if (data == null)
                    return;
                if (data.Estado == "I" /*||data.IdEstadoAprobacion == "REP"*/)
                    e.Appearance.ForeColor = Color.Red;
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridCtrlOCPend_Load(object sender, EventArgs e)
        {
            try
            {
                cmbEstadoApro.Text = "xAPRO";
                buscar();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
       
        private void gridVwOCPend_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                info = (com_ordencompra_local_Info)this.gridVwOCPend.GetFocusedRow();
                
                if (e.Column.Name == "colAbrirOC")
                {
                    var row = (com_ordencompra_local_Info)gridVwOCPend.GetFocusedRow();
                    if (row != null)
                    {
                        frmCom_OrdenCompra_Mant frm = new frmCom_OrdenCompra_Mant();
                        frm = new frmCom_OrdenCompra_Mant();
                        frm.Set_Info(row);
                        frm.event_frmCom_OrdenCompra_Mant_FormClosing += frm_event_frmCom_OrdenCompra_Mant_FormClosing;
                        frm.event_frmCom_OrdenCompra_Mant_FormClosing += new frmCom_OrdenCompra_Mant.delegate_frmCom_OrdenCompra_Mant_FormClosing(frm_event_frmCom_OrdenCompra_Mant_FormClosing);
                        frm.Set_Accion(Cl_Enumeradores.eTipo_action.consultar); 
                        frm.MdiParent = this.MdiParent;
                        frm.Show();
                    }
                }


                if (e.Column.Name == "colCheck")
                {
                    if ((Boolean)gridVwOCPend.GetFocusedRowCellValue(colCheck))
                    {
                        gridVwOCPend.SetFocusedRowCellValue(colCheck, false);
                        gridVwOCPend.SetFocusedRowCellValue(colap_descripcion, info.IdEstadoAprobacion_AUX);                       
                    }

                    else
                    {


                        //lista = bus_inven.Get_List_Ing_Egr_Inven_det_x_OrdenCompra(info.IdEmpresa, info.IdSucursal, info.IdOrdenCompra);


                        //if (lista.Count > 0)
                        //{
                            
                        //    FrmIn_Detalle_Ing_Egr_Bodega_Alerta frmConsulta = new FrmIn_Detalle_Ing_Egr_Bodega_Alerta();
                        //    frmConsulta.Text = "La OC#: " + info.IdOrdenCompra + " tiene Ingesos a Bodega";
                        //    frmConsulta.set_info_list(lista);
                        //    info.IdEstadoAprobacion_cat = info.IdEstadoAprobacion_AUX;
                        //    info.check = false;
                        //    frmConsulta.ShowDialog();
                        //}
                     
                      

                        if (info.IdEstadoAprobacion_AUX=="ANU")
                        {
                            MessageBox.Show("No se pueden modificar registros Inactivos", "Sistemas");
                            return;
                        
                        }
                       
                        gridVwOCPend.SetFocusedRowCellValue(colCheck, true );
                        gridVwOCPend.SetFocusedRowCellValue(colap_descripcion, "APRO");                    
                    }            
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void frm_event_frmCom_OrdenCompra_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
            }
        }

        private void toolStripButtonConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                 buscar();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cmbEstadoApro_ValueChanged(object sender, EventArgs e)
        {
            try
            {
              toolStripButtonConsultar_Click(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (checkBox1.Checked == true && LstOC.Count > 0)
                {
                    foreach (var item in LstOC)
                    {
                        item.check = true;
                        item.IdEstadoAprobacion_cat = "APRO";
                    }

                    //LstOC.ForEach(var =>
                    //{
                    //    var.check = true;
                    //    var.IdEstadoAprobacion = "APRO";
                    //});
                    gridCtrlOCPend.DataSource = null;
                    gridCtrlOCPend.DataSource = LstOC;


                } if (checkBox1.Checked == false && LstOC.Count > 0)
                {

                    foreach (var item in LstOC)
                    {
                        item.check = false;
                        item.IdEstadoAprobacion_cat = "xAPRO";
                    }

                    //LstOC.ForEach(var =>
                    //{
                    //    var.check = false;
                    //    var.IdEstadoAprobacion = "xAPRO";
                    //});
                    gridCtrlOCPend.DataSource = null;
                    gridCtrlOCPend.DataSource = LstOC;


                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnbuscar_Click_1(object sender, EventArgs e)
        {
            try
            {
                buscar();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        in_Ing_Egr_Inven_det_Bus bus_inven = new in_Ing_Egr_Inven_det_Bus();
                    List<in_Ing_Egr_Inven_det_Info> lista = new List<in_Ing_Egr_Inven_det_Info>();
                 



        private void gridVwOCPend_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                info = (com_ordencompra_local_Info)this.gridVwOCPend.GetFocusedRow();

                if (e.Column.Name == "colap_descripcion")
                {

                    lista = bus_inven.Get_List_Ing_Egr_Inven_det_x_OrdenCompra(info.IdEmpresa, info.IdSucursal, info.IdOrdenCompra);
                    

                    if (lista.Count >0)
                    {
                        
                        FrmIn_Detalle_Ing_Egr_Bodega_Alerta frmConsulta = new FrmIn_Detalle_Ing_Egr_Bodega_Alerta();
                        frmConsulta.Text = "Alertas";
                        frmConsulta.lblMensaje.Text = "La OC#: " + info.IdOrdenCompra + " tiene Ingesos a Bodega";
                        
                        frmConsulta.set_info_list(lista);
                        info.IdEstadoAprobacion_cat = info.IdEstadoAprobacion_AUX;
                        info.check = false;
                        frmConsulta.ShowDialog();
                        return;
                    }
                    else
                    {
                        if (info.IdEstadoAprobacion_AUX == "ANU")
                        {
                            MessageBox.Show("No se pueden modificar registros Inactivos");

                        }                   
                    }                                                              
                }

                CalcularTotal();
            }
            catch (Exception ex)
            {
                
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

     

        public void CalcularTotal()
        {
            try
            {
                Total = 0;

                foreach (var item in LstOC)
                {
                    if (item.check==true)
                    {
                        if (Total==null)
                        {
                            Total = 0;
                        }
                        Total = Total + item.total;
                    }
                } txtTotal.Text = Total==null ? "" :Total.ToString();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        private void frmCom_OrdenCompra_Aprobar_Load(object sender, EventArgs e)
        {

        }
      
    }
}
