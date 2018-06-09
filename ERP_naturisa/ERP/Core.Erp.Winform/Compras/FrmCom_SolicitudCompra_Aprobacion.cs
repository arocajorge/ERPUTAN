using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.Compras;
using Core.Erp.Business.Compras;
using Core.Erp.Business.General;



namespace Core.Erp.Winform.Compras
{
    public partial class FrmCom_SolicitudCompra_Aprobacion : Form
    {
        com_solicitud_compra_Bus SolComBus = new com_solicitud_compra_Bus();


        BindingList<com_solicitud_compra_Info> listSolCom = new BindingList<com_solicitud_compra_Info>();


        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        List<com_Catalogo_Info> listEstadoAprobacion = new List<com_Catalogo_Info>();
        com_Catalogo_Bus com_cataBus = new com_Catalogo_Bus();
        com_parametro_Bus ParamBus = new com_parametro_Bus();
        com_parametro_Info ParamInfo = new com_parametro_Info();



        
        
        public FrmCom_SolicitudCompra_Aprobacion()
        {
            InitializeComponent();

            ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
            ucGe_Menu.event_btnAprobar_Click += ucGe_Menu_event_btnAprobar_Click;
            ucGe_Menu.event_btnAprobarGuardarSalir_Click += ucGe_Menu_event_btnAprobarGuardarSalir_Click;
            ucGe_Menu.event_btnImprimir_Click += ucGe_Menu_event_btnImprimir_Click;
            ucGe_Menu.event_btnlimpiar_Click += ucGe_Menu_event_btnlimpiar_Click;

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

        void ucGe_Menu_event_btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                this.gridView_solicitud_com.ShowPrintPreview();

                

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
                listSolCom = new BindingList<com_solicitud_compra_Info>();  
                gridControl_solicitud_compra.DataSource = listSolCom;              

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        void ucGe_Menu_event_btnAprobarGuardarSalir_Click(object sender, EventArgs e)
        {
            try
            {

                if (guardar() )
                {
                    this.Close();
                    cargar_grilla();
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
            
        }

        void ucGe_Menu_event_btnAprobar_Click(object sender, EventArgs e)
        {

            try
            {
                if (guardar())
                {
                    cargar_grilla();
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }


        private Boolean guardar()
        {

            try
            {

                com_solicitud_compra_Info InfoSolCom= new com_solicitud_compra_Info();
                string msg = "";

                foreach (var item in listSolCom)
                {
                    item.IdUsuarioAprobo = param.IdUsuario;
                    item.IdUsuarioUltMod = param.IdUsuario;
                    item.FechaHoraAprobacion = param.Fecha_Transac;
                    item.Fecha_UltMod = param.Fecha_Transac;

                }

                var ListaRes=    listSolCom.ToList().FindAll(v => v.Checked);


                SolComBus.ModificarDBEstadoAprobacion(ListaRes, ref msg);


                MessageBox.Show("Actualizacion de Estado de Aprobacion ok...",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Information);
                LimpiarDatos();

                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                return false;
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



        private void cargar_combos()
        {

            try
            {

                ParamInfo= ParamBus.Get_Info_parametro(param.IdEmpresa);

                listEstadoAprobacion= com_cataBus.Get_ListEstadoAprobacion_solicitud_compra();
                cmbEstadoAprobacion.Properties.DataSource = listEstadoAprobacion;
                cmbEstadoAprobacion.EditValue = "PEN_SOL";

                ucGe_Sucursal_combo1.set_SucursalInfo(param.IdSucursal);




                cmbEstadoAprobacion_grid.DataSource = listEstadoAprobacion;



            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }


        private void cargar_grilla()
        {
            try
            {
                string sTitulo = "";


                listSolCom = new BindingList<com_solicitud_compra_Info>(SolComBus.Get_List_solicitud_compra(param.IdEmpresa, ucGe_Sucursal_combo1.get_SucursalInfo().IdSucursal, dtpFecha_desde.Value, dtpFecha_Hasta.Value
                    , cmbEstadoAprobacion.EditValue.ToString()));

                gridControl_solicitud_compra.DataSource = listSolCom;

                sTitulo = "Sucursal:" + ucGe_Sucursal_combo1.cmbsucursal.Text + "    " + " Estado de Aprobacion:" + cmbEstadoAprobacion.Text
                    + " Desde:" + dtpFecha_desde.Value.ToShortDateString() + " Hasta:" + dtpFecha_Hasta.Value.ToShortDateString()   ;


                gridControl_solicitud_compra.MainView.ViewCaption = sTitulo;



            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                cargar_grilla();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        private void FrmCom_SolicitudCompra_Aprobacion_Load(object sender, EventArgs e)
        {
            try
            {
                cargar_combos();

                dtpFecha_desde.Value = DateTime.Now.AddDays(-60);
                dtpFecha_Hasta.Value = DateTime.Now.AddDays(60);
                cargar_grilla();


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        private void gridControl_solicitud_compra_Click(object sender, EventArgs e)
        {

        }

        private void gridView_solicitud_com_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {

        }

        private void gridView_solicitud_com_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                e.HitInfo.Column.FieldName = gridView_solicitud_com.FocusedColumn.FieldName;

                if (e.HitInfo.Column.FieldName == "Checked")
                {
                    if ((Boolean)gridView_solicitud_com.GetFocusedRowCellValue(colChecked)) //verdadero
                    {
                        gridView_solicitud_com.SetFocusedRowCellValue(colChecked, false);
                        return;
                    }
                    else //false
                    {
                        gridView_solicitud_com.SetFocusedRowCellValue(colChecked, true);
                        gridView_solicitud_com.SetFocusedRowCellValue(colIdEstadoAprobacion, "APR_SOL");
                    }
                }


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
            

        }

        private void ucGe_Menu_Load(object sender, EventArgs e)
        {

        }

        private void gridView_solicitud_com_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {

                var data = gridView_solicitud_com.GetRow(e.RowHandle) as com_solicitud_compra_Info;
             
                if (data == null)
                    return;

                if (data.IdEstadoAprobacion == "APR_SOL")
                    e.Appearance.ForeColor = Color.Blue;


                if (data.IdEstadoAprobacion == "REP_SOL")
                    e.Appearance.ForeColor = Color.Red;


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }
    }
}
