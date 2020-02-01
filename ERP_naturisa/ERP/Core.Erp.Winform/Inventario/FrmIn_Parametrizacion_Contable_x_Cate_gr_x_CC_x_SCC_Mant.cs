using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.Inventario;
using Core.Erp.Business.General;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.Contabilidad;


namespace Core.Erp.Winform.Inventario
{
    public partial class FrmIn_Parametrizacion_Contable_x_Cate_gr_x_CC_x_SCC_Mant : Form
    {
        in_subgrupo_x_CentroCosto_x_SubCentroCosto_x_CtaCble_Bus BusContaCC = new in_subgrupo_x_CentroCosto_x_SubCentroCosto_x_CtaCble_Bus();
        in_subgrupo_x_CentroCosto_x_SubCentroCosto_x_CtaCble_Info InfoContaCC = new in_subgrupo_x_CentroCosto_x_SubCentroCosto_x_CtaCble_Info();
        in_Producto_Info Info_Producto = new in_Producto_Info();
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        ct_centro_costo_sub_centro_costo_Bus busSubCentrCosto = new ct_centro_costo_sub_centro_costo_Bus();
        ct_Centro_costo_Bus busCentroCosto = new ct_Centro_costo_Bus();
        List<ct_centro_costo_sub_centro_costo_Info> lstSubCentro = new List<ct_centro_costo_sub_centro_costo_Info>();
        

        public delegate void delegate_FormClosed(object sender, FormClosedEventArgs e);
        public event delegate_FormClosed event_delegate_FormClosed;

        public FrmIn_Parametrizacion_Contable_x_Cate_gr_x_CC_x_SCC_Mant()
        {
            InitializeComponent();
            event_delegate_FormClosed += FrmIn_Parametrizacion_Contable_x_Cate_gr_x_CC_x_SCC_Mant_event_delegate_FormClosed;
        }

        void FrmIn_Parametrizacion_Contable_x_Cate_gr_x_CC_x_SCC_Mant_event_delegate_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        bool Validar()
        {
            try
            {
                if (ucin_cat_lin_gr_sgr.Get_info_categoria() == null)
                {
                    MessageBox.Show("Seleccione la categoría", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (ucin_cat_lin_gr_sgr.Get_info_linea() == null)
                {
                    MessageBox.Show("Seleccione la línea", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (ucin_cat_lin_gr_sgr.Get_info_grupo() == null)
                {
                    MessageBox.Show("Seleccione el grupo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (ucin_cat_lin_gr_sgr.Get_info_subgrupo() == null)
                {
                    MessageBox.Show("Seleccione el subgrupo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (cmbCentroCosto.EditValue == null)
                {
                    MessageBox.Show("Seleccione el centro de costo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (cmbSubcentroCosto.EditValue == null)
                {
                    MessageBox.Show("Seleccione el sub centro de costo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        void Get_info()
        {
            try
            {
                InfoContaCC = new in_subgrupo_x_CentroCosto_x_SubCentroCosto_x_CtaCble_Info();

                InfoContaCC.IdEmpresa = param.IdEmpresa;
                InfoContaCC.IdCategoria = ucin_cat_lin_gr_sgr.Get_info_categoria().IdCategoria;
                InfoContaCC.IdLinea = ucin_cat_lin_gr_sgr.Get_info_linea().IdLinea;
                InfoContaCC.IdGrupo = ucin_cat_lin_gr_sgr.Get_info_grupo().IdGrupo;
                InfoContaCC.IdSubgrupo = ucin_cat_lin_gr_sgr.Get_info_subgrupo().IdSubgrupo;
                InfoContaCC.IdCtaCble = ucct_plancta.get_CuentaInfo().IdCtaCble == "" ? null : ucct_plancta.get_CuentaInfo().IdCtaCble;
                InfoContaCC.IdCentroCosto = cmbCentroCosto.EditValue.ToString();
                InfoContaCC.IdSub_centro_costo = cmbSubcentroCosto.EditValue.ToString();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }    
 
        private void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (GuardarDB())
                    limpiar();       
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void limpiar()
        {
            try
            {
                ucin_cat_lin_gr_sgr.inicializar_controles();
                ucct_plancta.Inicializar_cmb_cuentas();
                ucIn_ProductoCmb1.Inicializar_cmbProducto();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (GuardarDB())
                    this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        bool GuardarDB()
        {
            try
            {
                if (!Validar()) return false;
                Get_info();
                if (BusContaCC.ActualizarDB(InfoContaCC))
                {
                    MessageBox.Show("Transacción realizada exitosamente", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return true;
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void FrmIn_Parametrizacion_Contable_x_Cate_gr_x_CC_x_SCC_Mant_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                event_delegate_FormClosed(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmIn_Parametrizacion_Contable_x_Cate_gr_x_CC_x_SCC_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                string MensajeError = string.Empty;
                ucIn_ProductoCmb1.cargar_productos();
                cmbCentroCosto.Properties.DataSource = busCentroCosto.Get_list_Centro_Costo(param.IdEmpresa, ref MensajeError);
                lstSubCentro = busSubCentrCosto.Get_list_centro_costo_sub_centro_costo(param.IdEmpresa);
                Set_info_in_controls();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucIn_ProductoCmb1_event_cmb_producto_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                Info_Producto = ucIn_ProductoCmb1.get_ProductoInfo();
                if (Info_Producto != null)
                {
                    ucin_cat_lin_gr_sgr.set_item_Catgoria(ucIn_ProductoCmb1.get_ProductoInfo().IdCategoria);
                    ucin_cat_lin_gr_sgr.set_item_Linea(ucIn_ProductoCmb1.get_ProductoInfo().IdLinea);
                    ucin_cat_lin_gr_sgr.set_item_Grupo(ucIn_ProductoCmb1.get_ProductoInfo().IdGrupo);
                    ucin_cat_lin_gr_sgr.set_item_SubGrupo(ucIn_ProductoCmb1.get_ProductoInfo().IdSubGrupo);
                }
                else
                {
                    ucin_cat_lin_gr_sgr.inicializar_controles();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Set_info_in_controls()
        {
            try
            {
                if (InfoContaCC.IdEmpresa != 0)
                {
                    ucin_cat_lin_gr_sgr.set_item_Catgoria(InfoContaCC.IdCategoria);
                    ucin_cat_lin_gr_sgr.set_item_Linea(Convert.ToInt32(InfoContaCC.IdLinea));
                    ucin_cat_lin_gr_sgr.set_item_Grupo(Convert.ToInt32(InfoContaCC.IdGrupo));
                    ucin_cat_lin_gr_sgr.set_item_SubGrupo(Convert.ToInt32(InfoContaCC.IdSubgrupo));
                    cmbCentroCosto.EditValue = InfoContaCC.IdCentroCosto;
                    cmbSubcentroCosto.EditValue = InfoContaCC.IdSub_centro_costo;
                    ucct_plancta.set_IdCtaCble(InfoContaCC.IdCtaCble);
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public in_subgrupo_x_CentroCosto_x_SubCentroCosto_x_CtaCble_Info Get_info_param()
        {
            try
            {
                return InfoContaCC;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public void Set_info(in_subgrupo_x_CentroCosto_x_SubCentroCosto_x_CtaCble_Info _Info)
        {
            try
            {
                InfoContaCC = _Info;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbCentroCosto_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbCentroCosto.EditValue == null)
                {
                    cmbSubcentroCosto.Properties.DataSource = null;
                }
                else
                {
                    cmbSubcentroCosto.Properties.DataSource = lstSubCentro.Where(q=> q.IdCentroCosto == cmbCentroCosto.EditValue.ToString()).ToList();
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
