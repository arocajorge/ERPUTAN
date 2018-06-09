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
using Core.Erp.Info.Inventario;
using Core.Erp.Business.Inventario;
using Core.Erp.Winform.Inventario;
using Core.Erp.Winform.General;



namespace Core.Erp.Winform.Inventario
{
    public partial class FrmIn_Marca_Cons : Form
    {
        #region Variables
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        in_Marca_Info marcaI = new in_Marca_Info();
        #endregion
       
        public FrmIn_Marca_Cons()
        {
            try
            {
             InitializeComponent();
             ucGe_Menu_Mantenimiento_x_usuario.event_btnNuevo_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick;
             ucGe_Menu_Mantenimiento_x_usuario.event_btnModificar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick;
             ucGe_Menu_Mantenimiento_x_usuario.event_btnconsultar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick;
             ucGe_Menu_Mantenimiento_x_usuario.event_btnSalir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick;
             ucGe_Menu_Mantenimiento_x_usuario.event_btnAnular_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick;
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
                marcaI = (in_Marca_Info)gridViewMarca.GetFocusedRow(); 

                if (marcaI.IdMarca == 0)
                {
                    MessageBox.Show("Selecciones una registro", "sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else if (marcaI.Estado == "I")
                {
                    MessageBox.Show("No se procedio con la Anulación porque ya esta Anulado", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (MessageBox.Show("¿Está seguro que desea anular dicha Marca?", "Anulación de Marca", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    FrmIn_Marca_Mant frm = new FrmIn_Marca_Mant();

                    frm.set_Accion(Cl_Enumeradores.eTipo_action.Anular);
                    frm.marcaI = marcaI;
                    in_marca_bus MB = new in_marca_bus();
                    FrmGe_MotivoAnulacion FRM = new FrmGe_MotivoAnulacion();
                    FRM.ShowDialog();
                    frm.event_FrmIn_Marca_Mant_FormClosing += frm_event_FrmIn_Marca_Mant_FormClosing;
                    marcaI.MotiAnula = FRM.motivoAnulacion;
                    if (MB.AnularDB(marcaI))

                        MessageBox.Show("Anulado ok", "Operación Exitosa");
                    else
                        MessageBox.Show("No se Anulado", "Operación Fallida");

                    load_datos();
                }
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

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                marcaI = (in_Marca_Info)gridViewMarca.GetFocusedRow(); 

                if (marcaI.IdMarca == 0)
                {
                    MessageBox.Show("Seleccione una registro", "sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                   
                    FrmIn_Marca_Mant frm = new FrmIn_Marca_Mant();
                    frm.set_Accion(Cl_Enumeradores.eTipo_action.consultar);
                    frm.set_Info(marcaI);
                    frm.ShowDialog();
                    frm.event_FrmIn_Marca_Mant_FormClosing += frm_event_FrmIn_Marca_Mant_FormClosing;
                    load_datos();
                }
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
                marcaI = (in_Marca_Info)gridViewMarca.GetFocusedRow(); 

                if (marcaI.IdMarca == 0)
                {
                    MessageBox.Show("Seleccione una registro", "sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (marcaI.Estado == "I")
                    {
                        MessageBox.Show("No se pueden modificar registros inactivos", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        FrmIn_Marca_Mant frm = new FrmIn_Marca_Mant();

                        frm.set_Accion(Cl_Enumeradores.eTipo_action.actualizar);
                        frm.set_Info(marcaI);
                        frm.ShowDialog();
                        frm.event_FrmIn_Marca_Mant_FormClosing += frm_event_FrmIn_Marca_Mant_FormClosing;
                        load_datos();
                    }
                }
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
                FrmIn_Marca_Mant frm = new FrmIn_Marca_Mant();
                frm.set_Accion(Cl_Enumeradores.eTipo_action.grabar);
                frm.ShowDialog();
                frm.event_FrmIn_Marca_Mant_FormClosing += frm_event_FrmIn_Marca_Mant_FormClosing;
                load_datos();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void frm_event_FrmIn_Marca_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                load_datos();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void load_datos()
        {
            try
            {
                in_marca_bus dat_ti = new in_marca_bus();
                gridControlMarca.DataSource = dat_ti.Get_list_Marca(param.IdEmpresa);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }        
        }

        private void frmIN_MarcaConsulta_Load(object sender, EventArgs e)
        {
            try
            {
                load_datos();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        

        private void gridViewMarca_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridViewMarca.GetRow(e.RowHandle) as in_Marca_Info;
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

        private void gridViewMarca_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                marcaI = (in_Marca_Info)gridViewMarca.GetFocusedRow(); 
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

     
    }
}
