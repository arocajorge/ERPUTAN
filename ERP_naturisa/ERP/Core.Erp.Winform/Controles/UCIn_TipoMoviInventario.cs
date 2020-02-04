using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.Inventario;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.General;


namespace Core.Erp.Winform.Controles
{
    public partial class UCIn_TipoMoviInventario : UserControl
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        in_movi_inven_tipo_Bus TipoMoviBu = new in_movi_inven_tipo_Bus();
        List<in_movi_inven_tipo_Info> listTipoMovi = new List<in_movi_inven_tipo_Info>();
        in_movi_inve_Info info = new in_movi_inve_Info();

        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        public int IdBodega { get; set; }
        public int IdSucursal { get; set; }
        public string sTipoMoviInven { get; set; }
        public string SInterno { get; set; }


        #region declaracion de delegados

        public delegate void delegate_ultraComboTipoMoviInven_EditValueChanged(object sender, EventArgs e);
        public event delegate_ultraComboTipoMoviInven_EditValueChanged Event_ultraComboTipoMoviInven_EditValueChanged;
        #endregion

        public UCIn_TipoMoviInventario()
        {
            try
            {
              InitializeComponent();
                Event_ultraComboTipoMoviInven_EditValueChanged +=UCIn_TipoMoviInventario_Event_ultraComboTipoMoviInven_EditValueChanged;
              
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        public void CargarCombo()
        {
            try
            {
                listTipoMovi = TipoMoviBu.Get_list_movi_inven_tipo_x_bodega(param.IdEmpresa, IdSucursal, IdBodega,sTipoMoviInven, SInterno);
            
                
                ultraComboTipoMoviInven.Properties.DisplayMember = "tm_descripcion2";
                ultraComboTipoMoviInven.Properties.ValueMember = "IdMovi_inven_tipo";
                ultraComboTipoMoviInven.Properties.DataSource = listTipoMovi;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());             
            }

        }
        
        int idTipoMoviInventario;
        
        public int get_TipoMovi() 
        {
            try
            {
                idTipoMoviInventario = Convert.ToInt32(ultraComboTipoMoviInven.EditValue);
                return idTipoMoviInventario;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return -1;
            }
        }
        
        public void Set_tipoMovi(int idTipoMOvi) 
        {
            try
            {
                ultraComboTipoMoviInven.EditValue = idTipoMOvi;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());               
            }
        }

        

        private void UCIn_TipoMoviInventario_Load(object sender, EventArgs e)
        {
            try
            {
                this.Event_ultraComboTipoMoviInven_EditValueChanged += UCIn_TipoMoviInventario_Event_ultraComboTipoMoviInven_EditValueChanged;
                
                CargarCombo();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void UCIn_TipoMoviInventario_Event_ultraComboTipoMoviInven_EditValueChanged(object sender, EventArgs e)
        {
           
        }


        public void limpiar()
        {
            try
            {
                ultraComboTipoMoviInven.Properties.DataSource = null;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        
        }

        private void ultraComboTipoMoviInven_ValueChanged(object sender, EventArgs e){}

        private void ultraComboTipoMoviInven_ValueChanged_1(object sender, EventArgs e){}

        private void ultraComboTipoMoviInven_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                
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
