using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Info.Roles;
using Core.Erp.Business.Roles;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
namespace Core.Erp.Winform.Roles
{
    public partial class frmRo_Registro_Dias_Faltados_Cons : Form
    {
        frmRo_Registro_Dias_Faltados_Mant Frm = new frmRo_Registro_Dias_Faltados_Mant();

        ro_DiasFaltados_x_Empleado_Info Info = new ro_DiasFaltados_x_Empleado_Info();

        List<ro_DiasFaltados_x_Empleado_Info> Lista = new List<ro_DiasFaltados_x_Empleado_Info>();
        ro_DiasFaltados_x_Empleado_Bus BusDiasFalta = new ro_DiasFaltados_x_Empleado_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        
        public frmRo_Registro_Dias_Faltados_Cons()
        {
            InitializeComponent();
            

        }

        private void ucGe_Menu_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                 Frm = new frmRo_Registro_Dias_Faltados_Mant();

                Frm.SetAccion (Cl_Enumeradores.eTipo_action.grabar);
                Frm.Show();
                
                Frm.Text = "Registro de Nuevas Actividades";

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        private void gridViewDiasFaltados_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridViewDiasFaltados.GetRow(e.RowHandle) as ro_DiasFaltados_x_Empleado_Info;
                if (data == null)
                    return;
                if (data.estado == "I")
                    e.Appearance.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

       

        private void frmRo_Registro_Dias_Faltados_Cons_Load(object sender, EventArgs e)
        {
            try
            {
                Lista = BusDiasFalta.ConsultaGeneral(param.IdEmpresa, ucGe_Menu.fecha_desde, ucGe_Menu.fecha_hasta);
                gridControlDiasFaltados.DataSource = Lista;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        private void ucGe_Menu_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                 Frm = new frmRo_Registro_Dias_Faltados_Mant();
              
                Frm.Text = "Editar Registro";
                Frm.SetAccion(Cl_Enumeradores.eTipo_action.actualizar);
                Frm.Set(Info);
                Frm.ShowDialog();
               
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

       

        private void gridViewDiasFaltados_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

            try
            {
                Info = new ro_DiasFaltados_x_Empleado_Info();
                Info = (ro_DiasFaltados_x_Empleado_Info)gridViewDiasFaltados.GetFocusedRow();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        private void ucGe_Menu_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                 Frm = new frmRo_Registro_Dias_Faltados_Mant();

                Frm.Text = "ANULAR REGISTRO";
                Frm.SetAccion(Cl_Enumeradores.eTipo_action.Anular);
                Frm.Set(Info);
                Frm.ShowDialog();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        private void ucGe_Menu_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                 Frm = new frmRo_Registro_Dias_Faltados_Mant();

                Frm.Text = "CONSULTA DE REGISTRO";
                Frm.SetAccion(Cl_Enumeradores.eTipo_action.consultar);
                Frm.Set(Info);
                Frm.ShowDialog();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        void Frm_Event_frmRo_Registro_Dias_Faltados_Mant(object sender, FormClosingEventArgs e)
        {
            try
            {
                Lista = BusDiasFalta.ConsultaGeneral(param.IdEmpresa,ucGe_Menu.fecha_desde,ucGe_Menu.fecha_hasta);
                gridControlDiasFaltados.DataSource = Lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }

        private void ucGe_Menu_Load(object sender, EventArgs e)
        {

        }

        private void ucGe_Menu_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
                
              
            }
        }





    }
}
