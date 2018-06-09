using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.Contabilidad;

namespace Core.Erp.Reportes.Controles
{
    public partial class UCct_CentroCosto : UserControl
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        List<ct_Centro_costo_Info> ListaCentroCosto = new List<ct_Centro_costo_Info>();
        List<ct_centro_costo_sub_centro_costo_Info> List_SubCentroCosto = new List<ct_centro_costo_sub_centro_costo_Info>();
        ct_Centro_costo_Bus BusCentroCosto = new ct_Centro_costo_Bus();
        ct_centro_costo_sub_centro_costo_Bus Bus_SubCentro_Costo = new ct_centro_costo_sub_centro_costo_Bus();
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        public Boolean Mostrar_Registro_Todos { get; set; }
        string mensaje="";

        /// <summary>
        /// Esta función es para obtener solo el Id del Centro de Costo en el combo
        /// </summary>
        /// <returns></returns>
        public string Get_IdCentroCosto()
        {
            try
            {
                if (cmb_CentroCosto.EditValue != null)
                {
                    //comente lo del nivel, ya que casi nunca se va a dar esa coincidencia --Pedro Salinas--
                    //ct_Centro_costo_Info info = ListaCentroCosto.FirstOrDefault(v => v.IdCentroCosto == Convert.ToString(cmb_CentroCosto.EditValue) /*&& v.IdNivel == 1*/);
                    return cmb_CentroCosto.EditValue.ToString();
                }
                else return null;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return "";
            }
        }

        public string Get_IdSubCentro_Costo()
        {
            try
            {
                if (cmb_SubCentro_Costo.EditValue != null)
                {
                    //comente lo del nivel, ya que casi nunca se va a dar esa coincidencia --Pedro Salinas--
                   // ct_centro_costo_sub_centro_costo_Info info_Susbcentro = List_SubCentroCosto.FirstOrDefault(v => v.IdCentroCosto_sub_centro_costo == Convert.ToString(cmb_SubCentro_Costo.EditValue) /*&& v.IdNivel == 1*/);
                    return cmb_SubCentro_Costo.EditValue.ToString();
                }
                else return null;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return "";
            }
        }

        /// <summary>
        /// Esta función es para obtener todo el info del Centro de Costo en el combo
        /// </summary>
        /// <returns></returns>
        public ct_Centro_costo_Info Get_CentroCosto()
        {
            try
            {
                ct_Centro_costo_Info infoCentro = ListaCentroCosto.FirstOrDefault(v => v.IdCentroCosto == Convert.ToString(cmb_CentroCosto.EditValue));
                return infoCentro;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new ct_Centro_costo_Info();
            }
        }

        private void Cargar_Centro_Costo()
        {
            try
            {
                ListaCentroCosto = BusCentroCosto.Get_list_Centro_Costo(param.IdEmpresa,ref mensaje);
                if (Mostrar_Registro_Todos == true)
                {
                    ct_Centro_costo_Info InfoTodos = new ct_Centro_costo_Info();
                    InfoTodos.IdEmpresa = param.IdEmpresa;
                    InfoTodos.IdCentroCosto = "";
                    InfoTodos.Centro_costo2 = "TODOS";
                    ListaCentroCosto.Add(InfoTodos);
                }
                cmb_CentroCosto.Properties.DataSource = ListaCentroCosto;
                Cargar_SubCentroCosto();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void Cargar_SubCentroCosto()
        {
            try
            {
                List_SubCentroCosto = Bus_SubCentro_Costo.Get_list_centro_costo_sub_centro_costo(param.IdEmpresa);
                if (Mostrar_Registro_Todos == true)
                {
                    ct_centro_costo_sub_centro_costo_Info InfoTodos = new ct_centro_costo_sub_centro_costo_Info();
                    InfoTodos.IdEmpresa = param.IdEmpresa;
                    InfoTodos.IdCentroCosto_sub_centro_costo = "";
                    InfoTodos.Centro_costo2 = "TODOS";
                    List_SubCentroCosto.Add(InfoTodos);
                }
                cmb_SubCentro_Costo.Properties.DataSource = List_SubCentroCosto;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void Set_centro_costo(string IdCentroCosto)
        {
            try
            {
                if (IdCentroCosto == "")
                {
                    cmb_CentroCosto.EditValue = null;
                }else
                    cmb_CentroCosto.EditValue = IdCentroCosto;
                
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void Set_sub_centro_costo(string IdCentroCosto_subcentro)
        {
            try
            {
                if (IdCentroCosto_subcentro == "")
                {
                    cmb_SubCentro_Costo.EditValue = null;
                }else
                    cmb_SubCentro_Costo.EditValue = IdCentroCosto_subcentro;
                
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
        
        public UCct_CentroCosto()
        {
            InitializeComponent();
        }

        private void UCct_CentroCosto_Load(object sender, EventArgs e)
        {
            try
            {
                Cargar_Centro_Costo(); 
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
    }
}
