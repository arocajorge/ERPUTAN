using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.Inventario;
using Core.Erp.Business.General;
using Core.Erp.Info.General;

namespace Core.Erp.Winform.Inventario
{
    public partial class FrmIn_Producto_Cons : Form
    {

       public Boolean llamado_externamente = false;

        public delegate void delegate_FrmIn_Producto_Cons_FormClosing(object sender, FormClosingEventArgs e,in_Producto_Info info );
        public event delegate_FrmIn_Producto_Cons_FormClosing event_FrmIn_Producto_Cons_FormClosing;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        in_producto_Bus Bus_Producto = new in_producto_Bus();
        List<in_Producto_Info> list_Info_Producto = new List<in_Producto_Info>();

        FrmIn_Producto_Mant frm = new FrmIn_Producto_Mant();


       in_Producto_Info Info_Producto = new in_Producto_Info();

       public in_Producto_Info Get_Info_Producto()
       {
           try
           {
               return Info_Producto;
           }
           catch (Exception ex)
           {

               return new in_Producto_Info();
           }
       
       }

        public FrmIn_Producto_Cons()
        {
            InitializeComponent();
            try
            {
                ucGe_Menu.event_btnNuevo_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick;
                ucGe_Menu.event_btnconsultar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick;
                ucGe_Menu.event_btnAnular_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick;
                ucGe_Menu.event_btnModificar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick;
                ucGe_Menu.event_btnSalir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick;
                ucGe_Menu.event_btnImprimir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnImprimir_ItemClick;
                ucGe_Menu.event_btnImpExcel_ItemClick += ucGe_Menu_event_btnImpExcel_ItemClick;
                event_FrmIn_Producto_Cons_FormClosing += FrmIn_Producto_Cons_event_FrmIn_Producto_Cons_FormClosing;
            }
            catch (Exception ex)
            {
                 Log_Error_bus.Log_Error(ex.ToString());
                 MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_event_btnImpExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                FrmIn_Producto_Winzard_Import frmImp = new FrmIn_Producto_Winzard_Import();
                frmImp.event_frmRo_Empleado_ImportacionWizard_FormClosing += frmImp_event_frmRo_Empleado_ImportacionWizard_FormClosing;
                frmImp.Show();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void frmImp_event_frmRo_Empleado_ImportacionWizard_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                load_grid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void FrmIn_Producto_Cons_event_FrmIn_Producto_Cons_FormClosing(object sender, FormClosingEventArgs e, in_Producto_Info info)
        {
            
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.gridViewProducto.ShowPrintPreview();
            }
            catch (Exception ex)
            {
                 Log_Error_bus.Log_Error(ex.ToString());
                 MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                 MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                  MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                 MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmIn_ProductoConsulta_Load(object sender, EventArgs e)
        {
            try
            {
                load_grid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void load_grid()
        {
            try
            {
                in_marca_bus busmarca = new in_marca_bus();
                in_ProductoTipo_Bus busTipo = new in_ProductoTipo_Bus();
                in_categorias_bus busCat = new in_categorias_bus();
                list_Info_Producto = Bus_Producto.Get_list_Producto(param.IdEmpresa);
               
                gridControlProducto.DataSource  = list_Info_Producto;
                                  
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);             
            }
        }

        private void gridViewProducto_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridViewProducto.GetRow(e.RowHandle) as in_Producto_Info;
                if (data == null)
                    return;
                if (data.Estado == "I")
                    e.Appearance.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                 Log_Error_bus.Log_Error(ex.ToString());
                 MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewProducto_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                Info_Producto = (in_Producto_Info)gridViewProducto.GetFocusedRow();
            }
            catch (Exception ex)
            {
                 Log_Error_bus.Log_Error(ex.ToString());
                 MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewProducto_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                Info_Producto = (in_Producto_Info)gridViewProducto.GetFocusedRow();
            }
            catch (Exception ex)
            {
                 Log_Error_bus.Log_Error(ex.ToString());
                 MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void gridViewProducto_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (llamado_externamente == true)
                {
                    Info_Producto = (in_Producto_Info)gridViewProducto.GetFocusedRow();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                
                 Log_Error_bus.Log_Error(ex.ToString());
                 MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FrmIn_Producto_Cons_FormClosing(object sender, FormClosingEventArgs e)
        {

          
        }

        private void Preparar_Formulario(Cl_Enumeradores.eTipo_action iAccion)
        {

            try
            {

                string mensajeFrm = "";

                Info_Producto = new in_Producto_Info();

                switch (iAccion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        mensajeFrm = "REGISTRO NUEVO";
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        mensajeFrm = "MODIFICAR REGISTRO";
                        Info_Producto = (in_Producto_Info)gridViewProducto.GetFocusedRow();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        mensajeFrm = "ANULAR REGISTRO";
                        Info_Producto = (in_Producto_Info)gridViewProducto.GetFocusedRow();
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        mensajeFrm = "CONSULTAR REGISTRO";
                        Info_Producto = (in_Producto_Info)gridViewProducto.GetFocusedRow();
                        break;
                    default:
                        break;
                }


                if (Info_Producto != null)
                {
                    frm = new FrmIn_Producto_Mant();
                    frm.Text = frm.Text + "***" + mensajeFrm + "***";
                    frm.set_Accion(iAccion);
                    frm.set_Info_producto(Info_Producto);
                    frm.Show();
                    frm.MdiParent = this.MdiParent;
                    frm.event_FrmIn_Producto_Mant_FormClosing += frm_event_FrmIn_Producto_Mant_FormClosing;

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

        void frm_event_FrmIn_Producto_Mant_FormClosing(object sender, FormClosingEventArgs e, in_Producto_Info info)
        {
            try
            {
                load_grid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void ucGe_Menu_event_btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                load_grid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
