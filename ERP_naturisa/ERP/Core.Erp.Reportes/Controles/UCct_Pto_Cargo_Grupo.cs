using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Business.General;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.Contabilidad;

namespace Core.Erp.Reportes.Controles
{
    public partial class UCct_Pto_Cargo_Grupo : UserControl
    {
        #region Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        string msg = "";

        List<ct_punto_cargo_Info> lst_punto_cargo = new List<ct_punto_cargo_Info>();
        ct_punto_cargo_Bus bus_punto_cargo = new ct_punto_cargo_Bus();
        ct_punto_cargo_Info info_punto_cargo = new ct_punto_cargo_Info();

        List<ct_punto_cargo_grupo_Info> lst_grupo = new List<ct_punto_cargo_grupo_Info>();
        ct_punto_cargo_grupo_Bus bus_grupo = new ct_punto_cargo_grupo_Bus();
        ct_punto_cargo_grupo_Info info_grupo = new ct_punto_cargo_grupo_Info();

        

        #endregion

        public UCct_Pto_Cargo_Grupo()
        {
            InitializeComponent();
        }

        public void Cargar_combos()
        {
            try
            {
                lst_grupo = bus_grupo.Get_List_punto_cargo_grupo(param.IdEmpresa, ref msg);
                cmb_Grupo.Properties.DataSource = lst_grupo;
                cmb_Grupo.Properties.ValueMember = "IdPunto_cargo_grupo";
                cmb_Grupo.Properties.DisplayMember = "nom_punto_cargo_grupo2";

                cmb_Punto_cargo.Properties.DataSource = null;
                cmb_Punto_cargo.Properties.DisplayMember = "nom_punto_cargo2";
                cmb_Punto_cargo.Properties.ValueMember = "IdPunto_cargo";
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cargar_punto_cargo_x_grupo()
        {
            try
            {
                lst_punto_cargo = bus_punto_cargo.Get_list_PuntoCargo_x_grupo(param.IdEmpresa, info_grupo.IdPunto_cargo_grupo);
                cmb_Punto_cargo.Properties.DataSource = lst_punto_cargo;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmb_Grupo_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmb_Grupo.EditValue != null)
                {
                    int IdGrupo = Convert.ToInt32(cmb_Grupo.EditValue);
                    info_grupo = lst_grupo.FirstOrDefault(q => q.IdPunto_cargo_grupo == IdGrupo);
                    Cargar_punto_cargo_x_grupo();
                    cmb_Punto_cargo.EditValue = null;
                }
                else
                {
                    cmb_Punto_cargo.EditValue = null;
                    cmb_Punto_cargo.Properties.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public ct_punto_cargo_grupo_Info Get_info_grupo()
        {
            try
            {
                if (cmb_Grupo.EditValue != null)
                {
                    int IdGrupo = Convert.ToInt32(cmb_Grupo.EditValue);
                    info_grupo = lst_grupo.FirstOrDefault(q => q.IdPunto_cargo_grupo == IdGrupo);
                }
                else
                    info_grupo = null;
                
                return info_grupo;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public int Get_Id_grupo()
        {
            try
            {
                int idGrupo = 0;
                if (cmb_Grupo.EditValue != null)
                {
                    int IdGrupo = Convert.ToInt32(cmb_Grupo.EditValue);
                    info_grupo = lst_grupo.FirstOrDefault(q => q.IdPunto_cargo_grupo == IdGrupo);
                    idGrupo = info_grupo.IdPunto_cargo_grupo;
                }
                return idGrupo;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        public ct_punto_cargo_Info Get_info_punto_cargo()
        {
            try
            {
                if (cmb_Punto_cargo.EditValue != null)
                {
                    int IdPunto_cargo = Convert.ToInt32(cmb_Punto_cargo.EditValue);
                    info_punto_cargo = lst_punto_cargo.FirstOrDefault(q => q.IdPunto_cargo == IdPunto_cargo);
                }
                else
                    info_punto_cargo = null;

                return info_punto_cargo;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public int Get_Id_punto_cargo()
        {
            try
            {
                int IdPunto = 0;
                if (cmb_Punto_cargo.EditValue != null)
                {
                    int IdPunto_cargo = Convert.ToInt32(cmb_Punto_cargo.EditValue);
                    info_punto_cargo = lst_punto_cargo.FirstOrDefault(q => q.IdPunto_cargo == IdPunto_cargo);
                    IdPunto = info_punto_cargo.IdPunto_cargo;
                }
                

                return IdPunto;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        public void Set_info_grupo(Nullable<int> IdGrupo)
        {
            try
            {
                cmb_Grupo.EditValue = IdGrupo;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Set_info_punto_cargo(Nullable<int> IdPunto_cargo)
        {
            try
            {
                cmb_Punto_cargo.EditValue = IdPunto_cargo;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Inicializar_combos()
        {
            try
            {
                cmb_Grupo.EditValue = null;
                cmb_Punto_cargo.EditValue = null;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UCct_Pto_Cargo_Grupo_Load(object sender, EventArgs e)
        {

        }
    }
}
