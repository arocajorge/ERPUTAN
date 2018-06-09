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
using Core.Erp.Business.General;
namespace Core.Erp.Winform.Roles
{

    
    public partial class frmRo_Generacion_Utilidades_Consulta : Form
    {
        List<ro_Participacion_Utilidad_Info> ListadoReparto_Utilidad = new List<ro_Participacion_Utilidad_Info>();
        ro_Participacion_Utilidad_Bus BusUtilidades = new ro_Participacion_Utilidad_Bus();
        ro_Participacion_Utilidad_Info info = new ro_Participacion_Utilidad_Info();
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        string mensaje = "";

        public frmRo_Generacion_Utilidades_Consulta()
        {
            InitializeComponent();
        }

        private void frmRo_Generacion_Utilidades_Consulta_Load(object sender, EventArgs e)
        {
            try
            {
                string mesg="";
                ListadoReparto_Utilidad = BusUtilidades.GetListGeneral(param.IdEmpresa, ref mesg);
                gridControlUtilidad.DataSource = ListadoReparto_Utilidad;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void ucGe_Menu_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {


                frmRo_Departamento_Mant frm = new frmRo_Departamento_Mant();
                frm.set_Accion(Info.General.Cl_Enumeradores.eTipo_action.grabar);
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }


        }

        private void ucGe_Menu_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {


                frmRo_Generacion_Utilidades_Mant frm = new frmRo_Generacion_Utilidades_Mant();
                frm.SetAccion(Info.General.Cl_Enumeradores.eTipo_action.actualizar);
                frm.Set(info);
                frm.ShowDialog();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }

        }

        private void ucGe_Menu_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();

        }

        private void gridControlUtilidad_Click(object sender, EventArgs e)
        {

        }

        private void gridViewUtilidad_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                info = (ro_Participacion_Utilidad_Info)gridViewUtilidad.GetFocusedRow();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }

        private void gridViewUtilidad_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                info = (ro_Participacion_Utilidad_Info)gridViewUtilidad.GetFocusedRow();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }

        }
    }
}
