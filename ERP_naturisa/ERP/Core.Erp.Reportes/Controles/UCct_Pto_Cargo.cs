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
    public partial class UCct_Pto_Cargo : UserControl
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        List<ct_punto_cargo_Info> Lista_Pto_Cargo = new List<ct_punto_cargo_Info>();
        ct_punto_cargo_Bus BusCentroCosto = new ct_punto_cargo_Bus();
        public Boolean Mostrar_Registro_Todos { get; set; }
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();


        public delegate void delegate_cmb_Pto_Cargo_EditValueChanged(object sender, EventArgs e);
        public event delegate_cmb_Pto_Cargo_EditValueChanged event_delegate_cmb_Pto_Cargo_EditValueChanged;

        /// <summary>
        /// Función para obtener el IdPto_Cargo en el combo
        /// </summary>
        /// <returns></returns>
        public int Get_Id_Pto_Cargo()
        {
            try
            {
                ct_punto_cargo_Info Info = new ct_punto_cargo_Info();
                if (cmb_Pto_Cargo.EditValue == null)
                    Info = new ct_punto_cargo_Info();
                else
                    Info = Lista_Pto_Cargo.FirstOrDefault(v => v.IdPunto_cargo == Convert.ToInt32(cmb_Pto_Cargo.EditValue));
                return Info.IdPunto_cargo;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        /// <summary>
        /// Función para llenar todo el Info de la lista del combo de tipo ct_punto_cargo_info
        /// </summary>
        /// <returns></returns>
        public ct_punto_cargo_Info Get_Pto_Cargo()
        {
            try
            {
                ct_punto_cargo_Info Info = new ct_punto_cargo_Info();
                if (cmb_Pto_Cargo.EditValue == null)
                    Info = null;
                else
                    Info = Lista_Pto_Cargo.FirstOrDefault(v => v.IdPunto_cargo == Convert.ToInt32(cmb_Pto_Cargo.EditValue));
                return Info;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public void Cargar_Pto_Cargo()
        {
            try
            {
                Lista_Pto_Cargo = BusCentroCosto.Get_List_PuntoCargo(param.IdEmpresa);

                if (Mostrar_Registro_Todos == true)
                {

                    ct_punto_cargo_Info InfoTodos = new ct_punto_cargo_Info();
                    InfoTodos.IdEmpresa = param.IdEmpresa;
                    InfoTodos.codPunto_cargo = "";
                    InfoTodos.nom_punto_cargo = "TODOS";
                    Lista_Pto_Cargo.Add(InfoTodos);
                }
                cmb_Pto_Cargo.Properties.DataSource = Lista_Pto_Cargo;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public UCct_Pto_Cargo()
        {
            InitializeComponent();
            event_delegate_cmb_Pto_Cargo_EditValueChanged += UCct_Pto_Cargo_event_delegate_cmb_Pto_Cargo_EditValueChanged;
        }

        void UCct_Pto_Cargo_event_delegate_cmb_Pto_Cargo_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void UCct_Pto_Cargo_Load(object sender, EventArgs e)
        {
            try
            {
                Cargar_Pto_Cargo();
            }
            catch (Exception ex)
            {
                
            }
        }

        private void cmb_Pto_Cargo_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                event_delegate_cmb_Pto_Cargo_EditValueChanged(sender, e);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public void Set_info_punto_Cargo(int IdPunto_Cargo)
        {
            try
            {
                if (IdPunto_Cargo != 0)
                    cmb_Pto_Cargo.EditValue = IdPunto_Cargo;
                else
                    cmb_Pto_Cargo.EditValue = null;
                
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
