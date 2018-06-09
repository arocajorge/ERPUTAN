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



namespace Core.Erp.Reportes.Controles
{
    public partial class UCGe_Sucursal : UserControl
    {

        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        public UCGe_Sucursal()
        {
            InitializeComponent();
        }

        List<tb_Sucursal_Info> ListSucursal = new List<tb_Sucursal_Info>();
        tb_Sucursal_Bus BusSucursal = new tb_Sucursal_Bus();

        public Boolean Mostrar_Registro_Todos { get; set; }


        /// <summary>
        /// funcion para obtener el Id de la Sucursal Seleccionada en el combo
        /// </summary>
        /// <returns></returns>
        public int Get_IdSucursal()
        {
            try
            {
              tb_Sucursal_Info InfoSucu=  ListSucursal.FirstOrDefault(v => v.IdSucursal == Convert.ToInt32(cmb_sucursal.EditValue));

              return InfoSucu.IdSucursal;
            }
            catch (Exception ex)
            {
                return 0;
                
            }
        }
        
        /// <summary>
        /// Funcion para obtener el Info de Sucursal Seleccionada en el combo
        /// </summary>
        /// <returns></returns>
        public tb_Sucursal_Info Get_InfoSucursal()
        {
            try
            {
                tb_Sucursal_Info InfoSucu = ListSucursal.FirstOrDefault(v => v.IdSucursal == Convert.ToInt32(cmb_sucursal.EditValue));

                return InfoSucu;
            }
            catch (Exception ex)
            {
                return new tb_Sucursal_Info();

            }
        }


        
        private void Cargar_sucursales()
        {

            try
            {

                ListSucursal=BusSucursal.Get_List_Sucursal(param.IdEmpresa);

                if (Mostrar_Registro_Todos == true)
                {

                    tb_Sucursal_Info InfoTodos = new tb_Sucursal_Info();
                    InfoTodos.IdEmpresa = param.IdEmpresa;
                    InfoTodos.IdSucursal = 0;
                    InfoTodos.Su_Descripcion = "TODOS";
                    InfoTodos.Su_Descripcion2 = "TODOS";
                    ListSucursal.Add(InfoTodos);
                }

                cmb_sucursal.Properties.DataSource = ListSucursal;
                

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(ex.ToString());   
                
            }

        }

        private void searchLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void UCGe_Sucursal_Load(object sender, EventArgs e)
        {
            try
            {
                Cargar_sucursales();
            }
            catch (Exception ex)
            {
                
                
            }
            
        }
    }
}
