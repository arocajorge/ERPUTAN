using Core.Erp.Business.General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Info.Caja;
using Core.Erp.Business.Caja;
using Core.Erp.Info.General;
using Core.Erp.Info.Facturacion;
using Core.Erp.Business.Facturacion;
using Core.Erp.Info.Academico;
using Core.Erp.Business.Academico;

namespace Core.Erp.Winform.Academico
{
    public partial class Frm_Aca_Parametros : Form
    {
        #region Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        Aca_Parametros_Info info_param_aca = new Aca_Parametros_Info();
        Aca_Parametros_Bus bus_param_aca = new Aca_Parametros_Bus();

        List<caj_Caja_Info> lst_caja = new List<caj_Caja_Info>();
        caj_Caja_Info info_caja = new caj_Caja_Info();
        caj_Caja_Bus bus_caja = new caj_Caja_Bus();

        List<tb_Sucursal_Info> lst_sucursal = new List<tb_Sucursal_Info>();
        tb_Sucursal_Bus bus_sucursal = new tb_Sucursal_Bus();
        tb_Sucursal_Info info_sucursal = new tb_Sucursal_Info();

        List<tb_Bodega_Info> lst_bodega = new List<tb_Bodega_Info>();
        tb_Bodega_Bus bus_bodega = new tb_Bodega_Bus();
        tb_banco_Info info_bodega = new tb_banco_Info();

        List<fa_PuntoVta_Info> lst_punto_venta = new List<fa_PuntoVta_Info>();
        fa_PuntoVta_Info info_punto_venta = new fa_PuntoVta_Info();
        fa_PuntoVta_Bus bus_punto_venta = new fa_PuntoVta_Bus();

        string Mensaje_error = "";
        #endregion

        public Frm_Aca_Parametros()
        {
            InitializeComponent();
        }

        private void Cargar_combos()
        {
            try
            {
                lst_sucursal = bus_sucursal.Get_List_Sucursal(param.IdEmpresa);
                cmb_sucursal_fact.Properties.DataSource = lst_sucursal;

                lst_caja = bus_caja.Get_list_caja(param.IdEmpresa, ref Mensaje_error);
                cmb_caja_fact.Properties.DataSource = lst_caja;

                cmb_bodega_fact.Properties.DataSource = lst_bodega;
                cmb_ptovta_fact.Properties.DataSource = lst_punto_venta;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Frm_Aca_Parametros_Load(object sender, EventArgs e)
        {
            try
            {
                Cargar_combos();
                set_info();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmb_sucursal_fact_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmb_sucursal_fact.EditValue == null)
                {
                    lst_bodega = new List<tb_Bodega_Info>();
                    lst_punto_venta = new List<fa_PuntoVta_Info>();
                }
                else
                {
                    int IdSucursal = Convert.ToInt32(cmb_sucursal_fact.EditValue);
                    lst_bodega = bus_bodega.Get_List_Bodega(param.IdEmpresa, IdSucursal);
                    lst_punto_venta = bus_punto_venta.Get_List_PuntoVta(param.IdEmpresa, IdSucursal);
                }
                cmb_bodega_fact.EditValue = null;
                cmb_bodega_fact.Properties.DataSource = lst_bodega;
                cmb_ptovta_fact.EditValue = null;
                cmb_ptovta_fact.Properties.DataSource = lst_punto_venta;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void set_info()
        {
            try
            {
                info_param_aca = bus_param_aca.Get_info_parametros(param.IdEmpresa, param.IdInstitucion);
                if (info_param_aca.IdEmpresa != 0)
                {
                    cmb_sucursal_fact.EditValue = info_param_aca.IdSucursal_fact;
                    cmb_bodega_fact.EditValue = info_param_aca.IdBodega_fact;
                    cmb_ptovta_fact.EditValue = info_param_aca.IdPuntoVta_fact;
                    cmb_caja_fact.EditValue = info_param_aca.IdCaja_fact;    
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }      

        private void get_info()
        {
            try
            {
                info_param_aca.IdEmpresa = param.IdEmpresa;
                info_param_aca.IdInstitucion = param.IdInstitucion;
                if (cmb_sucursal_fact.EditValue != null) info_param_aca.IdSucursal_fact = Convert.ToInt32(cmb_sucursal_fact.EditValue); else info_param_aca.IdSucursal_fact = null;
                if (cmb_bodega_fact.EditValue != null) info_param_aca.IdBodega_fact = Convert.ToInt32(cmb_bodega_fact.EditValue); else info_param_aca.IdBodega_fact = null;
                if (cmb_ptovta_fact.EditValue != null) info_param_aca.IdPuntoVta_fact = Convert.ToInt32(cmb_ptovta_fact.EditValue); else info_param_aca.IdPuntoVta_fact = null;
                if (cmb_caja_fact.EditValue != null) info_param_aca.IdCaja_fact = Convert.ToInt32(cmb_caja_fact.EditValue); else info_param_aca.IdCaja_fact = null;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool GuardarDB()
        {
            try
            {
                get_info();

                if (bus_param_aca.GuardarDB(info_param_aca))
                {
                    MessageBox.Show("Se han actualizado los parámetros exitosamente",param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (GuardarDB())
                {
                    
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_guardar_y_salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (GuardarDB())
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
