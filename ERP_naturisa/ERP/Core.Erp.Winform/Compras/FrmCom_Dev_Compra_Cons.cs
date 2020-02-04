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
using Core.Erp.Info.General;



namespace Core.Erp.Winform.Compras
{
    public partial class FrmCom_Dev_Compra_Cons : Form
    {
        #region Declaración de Variables

            Cl_Enumeradores.eTipo_action eAccion = new Cl_Enumeradores.eTipo_action();
            cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
            tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

            List<com_dev_compra_Info> listCompra = new List<com_dev_compra_Info>();
            com_dev_compra_Bus devcomp_bus = new com_dev_compra_Bus();
            com_dev_compra_Info Info = new com_dev_compra_Info();
            FrmCom_Dev_Compra_Mant frm = new FrmCom_Dev_Compra_Mant();

        

        #endregion
        
        public FrmCom_Dev_Compra_Cons()
        {
            InitializeComponent();

            ucGe_Menu_Mantenimiento_x_usuario.event_btnNuevo_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick;
            ucGe_Menu_Mantenimiento_x_usuario.event_btnModificar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick;
            ucGe_Menu_Mantenimiento_x_usuario.event_btnconsultar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick;
            ucGe_Menu_Mantenimiento_x_usuario.event_btnAnular_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick;
            ucGe_Menu_Mantenimiento_x_usuario.event_btnBuscar_Click += ucGe_Menu_Mantenimiento_x_usuario_event_btnBuscar_Click;
            ucGe_Menu_Mantenimiento_x_usuario.event_btnSalir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick;
            ucGe_Menu_Mantenimiento_x_usuario.event_btnImprimir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnImprimir_ItemClick;
            

        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                gridControl_dev_compra.ShowPrintPreview();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                 cargar_grid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Preparar_Formulario(Cl_Enumeradores.eTipo_action.Anular);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {

                Preparar_Formulario(Cl_Enumeradores.eTipo_action.consultar);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {

                Preparar_Formulario(Cl_Enumeradores.eTipo_action.actualizar);

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Preparar_Formulario(Cl_Enumeradores.eTipo_action.grabar);
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        void frm_event_FrmCom_Dev_Compra_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                cargar_grid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmCom_Dev_Compra_Cons_Load(object sender, EventArgs e)
        {
            try
            {
               

                cargar_grid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cargar_grid()
        {
            try
            {
                DateTime fecha_desde;
                DateTime fecha_hasta;
                int idsucursal = 0;
                int idbodega = 0;

                fecha_desde= ucGe_Menu_Mantenimiento_x_usuario.fecha_desde;
                fecha_hasta= ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta;
                idsucursal = ucGe_Menu_Mantenimiento_x_usuario.getIdSucursal;
                idbodega = ucGe_Menu_Mantenimiento_x_usuario.getIdBodega;

                listCompra = devcomp_bus.Get_List_dev_compra(param.IdEmpresa, idsucursal , fecha_desde, fecha_hasta);
                gridControl_dev_compra.DataSource = listCompra;


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }

        }

        private void gridView_dev_compra_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridView_dev_compra.GetRow(e.RowHandle) as com_dev_compra_Info;
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


        private void Preparar_Formulario(Cl_Enumeradores.eTipo_action iAccion)
        {

            try
            {

                string mensajeFrm = "";

                Info = new com_dev_compra_Info();

                switch (iAccion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        mensajeFrm = "REGISTRO NUEVO";
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        mensajeFrm = "MODIFICAR REGISTRO";
                        Info = (com_dev_compra_Info)gridView_dev_compra.GetFocusedRow();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        mensajeFrm = "ANULAR REGISTRO";
                        Info = (com_dev_compra_Info)gridView_dev_compra.GetFocusedRow();
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        mensajeFrm = "CONSULTAR REGISTRO";
                        Info = (com_dev_compra_Info)gridView_dev_compra.GetFocusedRow();
                        break;
                    default:
                        break;
                }


                if (Info != null)
                {
                    frm = new FrmCom_Dev_Compra_Mant();
                    frm.Text = frm.Text + "***" + mensajeFrm + "***";
                    frm.Set_Accion(iAccion);
                    frm.Set_Info(Info);
                    frm.Show();
                    frm.MdiParent = this.MdiParent;
                    frm.event_FrmCom_Dev_Compra_Mant_FormClosing+=frm_event_FrmCom_Dev_Compra_Mant_FormClosing;

                }
                else
                {
                    MessageBox.Show("Seleccione un Registro ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
                }




            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

    }
}
