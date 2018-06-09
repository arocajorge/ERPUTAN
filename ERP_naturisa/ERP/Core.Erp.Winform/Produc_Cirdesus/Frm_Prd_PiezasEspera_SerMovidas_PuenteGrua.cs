using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Business.Produc_Cirdesus;
using Core.Erp.Business.General;
namespace Core.Erp.Winform.Produc_Cirdesus
{
    public partial class Frm_Prd_PiezasEspera_SerMovidas_PuenteGrua : Form
    {
        int mm = 5, ss = 0;
        public Frm_Prd_PiezasEspera_SerMovidas_PuenteGrua()
        {
            InitializeComponent();
        }

        # region Variables
        string msg = "";
        List<prd_MovPteGrua_Info> ListaPiezasMover = new List<prd_MovPteGrua_Info>();
         prd_PuenteGruaMovimiento_Bus BusPiezasPenMover = new prd_PuenteGruaMovimiento_Bus();
         cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        #endregion
         private void Frm_Prd_PiezasEspera_SerMovidas_PuenteGrua_Load(object sender, EventArgs e)
        {
            try
            {
                 mm = 5;ss = 60;
                dtpFechaInicio.Value = DateTime.Now.AddDays(-5);
                CargarData();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public void CargarData()
        {
            try
            {
              ListaPiezasMover=  BusPiezasPenMover.GetLisListadoPiezasPendMover(param.IdEmpresa, dtpFechaInicio.Value, dtpFechaFin.Value, ref msg);
              gridControlPiezaEsperaSerMovidas.DataSource = ListaPiezasMover;
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                CargarData();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void gridViewPiezasEsperasSerMovidas_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
               var data = gridViewPiezasEsperasSerMovidas.GetRow(e.RowHandle) as prd_MovPteGrua_Info;
                if (data == null)
                    return;
                if (data.TiempoEspera.Hours == 0 && data.TiempoEspera.Minutes>30)
                    e.Appearance.ForeColor = Color.Yellow;
                 if(data.TiempoEspera.Hours > 0 && data.TiempoEspera.Minutes>60)
                     e.Appearance.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                
              
            }
        }

        private void timercontadorMinutos_Tick(object sender, EventArgs e)
        {
            try
            {

                mm = mm - 1;
               
            }
            catch (Exception)
            {
                
                throw;
            }

        }

        private void timerContadorSegundos_Tick(object sender, EventArgs e)
        {
            try
            {
                LbMinutos.Text = "Se Actualizaran los Datos en " + mm+" MIN y "+ss+" SEG";

                if (mm == 0)
                {
                    CargarData();
                    mm = 5;
                    ss = 60;
                }
                if (ss == 0)
                {
                    ss = 60;
                }
                ss = ss - 1;
                
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void timerMinutos_Tick(object sender, EventArgs e)
        {

        }

        private void BtnPantallaCompleta_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();

                Frm_Prd_PiezasEspera_SerMovidas_PuenteGrua frm = new Frm_Prd_PiezasEspera_SerMovidas_PuenteGrua();
                frm.ShowDialog();
              //  frm.WindowState = MaximumSize;
                BtnPantallaCompleta.Enabled = false;
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
        }
    }
}
