using Core.Erp.Business.Academico;
using Core.Erp.Business.General;
using Core.Erp.Info.Academico;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Core.Erp.Winform.Academico
{
    public partial class Frm_Aca_Forma_Pago_Cons : Form
    {
        public Frm_Aca_Forma_Pago_Cons()
        {
            InitializeComponent();
        }


        bool Es_consulta = true;
        int Row_handle = 0;
        List<Aca_Tipo_mecanismo_de_pago_Info> List_meca_pago = new List<Aca_Tipo_mecanismo_de_pago_Info>();
        Aca_Tipo_mecanismo_de_pago_Info Meca_Pago_Info = new Aca_Tipo_mecanismo_de_pago_Info();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        Aca_tipo_mecanismo_de_pago_Bus bus_tipo_meca_pago = new Aca_tipo_mecanismo_de_pago_Bus();

        public void set_config_combo(List<Aca_Tipo_mecanismo_de_pago_Info> _Lista)
        {
            try
            {
                Es_consulta = false;
                //ucGe_BarraEstado.Hide();
                //ucGe_Menu.Hide();
                this.ControlBox = false;
                //toolStrip1.Visible = true;
                colEstado.Visible = false;
                col_Codigo.Visible = false;
                this.Text = "";
                List_meca_pago = _Lista;

                gridView_Mecanismo_Pago.FocusedRowHandle = DevExpress.XtraGrid.GridControl.AutoFilterRowHandle;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Frm_Aca_Forma_Pago_Cons_Load(object sender, EventArgs e)
        {
            try
            {
                cargar_grid();
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cargar_grid()
        {
            try
            {
                if (Es_consulta)
                {
                    List_meca_pago = bus_tipo_meca_pago.Get_Lista_tipo_mecanismo_Pago();
                    gridControl_Mecanismo_Pago.DataSource = List_meca_pago;
                }
                else
                {
                    gridControl_Mecanismo_Pago.DataSource = List_meca_pago;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void gridView_Mecanismo_Pago_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (!Es_consulta)
                {
                    Meca_Pago_Info = (Aca_Tipo_mecanismo_de_pago_Info)gridView_Mecanismo_Pago.GetRow(Row_handle);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Aca_Tipo_mecanismo_de_pago_Info Get_info_meca_Pago()
        {
            try
            {
                return Meca_Pago_Info;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void gridView_Mecanismo_Pago_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                Meca_Pago_Info = (Aca_Tipo_mecanismo_de_pago_Info)gridView_Mecanismo_Pago.GetFocusedRow();
                Row_handle = e.FocusedRowHandle;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridView_Mecanismo_Pago_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (!Es_consulta)
                    if (e.KeyCode == Keys.Enter)
                    {
                        this.Close();
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
