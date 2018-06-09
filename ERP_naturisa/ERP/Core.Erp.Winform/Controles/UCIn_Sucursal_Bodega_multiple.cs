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

namespace Core.Erp.Winform.Controles
{
    public partial class UCIn_Sucursal_Bodega_multiple : UserControl
    {
        #region Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        List<tb_Sucursal_Info> lst_sucursal = new List<tb_Sucursal_Info>();
        tb_Sucursal_Bus bus_sucursal = new tb_Sucursal_Bus();

        List<tb_Bodega_Info> lst_bodega = new List<tb_Bodega_Info>();
        tb_Bodega_Bus bus_bodega = new tb_Bodega_Bus();
        #endregion

        #region Delegados
        public delegate void delegate_cmb_sucursal_EditValueChanged(object sender, EventArgs e);
        public event delegate_cmb_sucursal_EditValueChanged event_delegate_cmb_sucursal_EditValueChanged;

        #endregion

        public UCIn_Sucursal_Bodega_multiple()
        {
            InitializeComponent();
            event_delegate_cmb_sucursal_EditValueChanged += UCIn_Sucursal_Bodega_multiple_event_delegate_cmb_sucursal_EditValueChanged;
        }

        void UCIn_Sucursal_Bodega_multiple_event_delegate_cmb_sucursal_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        public void Cargar_combos()
        {
            try
            {
                lst_sucursal = bus_sucursal.Get_List_Sucursal(param.IdEmpresa);
                cmb_sucursal.Properties.DataSource = lst_sucursal;
                lst_bodega = bus_bodega.Get_List_Bodega(param.IdEmpresa, Cl_Enumeradores.eTipoFiltro.Normal);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error comunicarse con Sistemas " + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cargar_bodegas_x_sucursal()
        {
            try
            {
                chk_cmb_bodegas.Properties.Items.Clear();
                foreach (var item in lst_bodega)
                {
                    chk_cmb_bodegas.Properties.Items.Add(item.IdBodega, item.bo_Descripcion2);   
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error comunicarse con Sistemas " + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmb_sucursal_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmb_sucursal.EditValue == null)
                    lst_bodega = new List<tb_Bodega_Info>();
                else
                    lst_bodega = bus_bodega.Get_List_Bodega(param.IdEmpresa, Convert.ToInt32(cmb_sucursal.EditValue));
                Cargar_bodegas_x_sucursal();

                event_delegate_cmb_sucursal_EditValueChanged(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error comunicarse con Sistemas " + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public tb_Sucursal_Info Get_info_sucursal()
        {
            try
            {
                if (cmb_sucursal.EditValue == null) return null;
                else return lst_sucursal.FirstOrDefault(q=>q.IdEmpresa == param.IdEmpresa && q.IdSucursal == Convert.ToInt32(cmb_sucursal.EditValue));
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error comunicarse con Sistemas " + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public List<tb_Bodega_Info> Get_list_bodegas()
        {
            try
            {
                List<tb_Bodega_Info> Lista = new List<tb_Bodega_Info>();

                foreach (var item in chk_cmb_bodegas.Properties.Items.GetCheckedValues())
                {
                    Lista.Add(lst_bodega.FirstOrDefault(q=>q.IdEmpresa == param.IdEmpresa && q.IdSucursal == Convert.ToInt32(cmb_sucursal.EditValue) && q.IdBodega == Convert.ToInt32(item)));
                }

                return Lista;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error comunicarse con Sistemas " + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<tb_Bodega_Info>();
            }
        }
    }
}
