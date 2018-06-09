using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.Inventario;
using Core.Erp.Business.General;
using Core.Erp.Info.General;



namespace Core.Erp.Winform.Controles
{
    public partial class UCIn_Movimiento_Inventario : UserControl
    {


        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        in_movi_inve_Bus MoviInBus = new in_movi_inve_Bus();
        in_movi_inve_Info InfoMoviInven = new in_movi_inve_Info();


        public UCIn_Movimiento_Inventario()
        {
            try
            {
                InitializeComponent();
                ucGe_Menu.event_btnImprimir_Click += ucGe_Menu_event_btnImprimir_Click;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

            
        }

        void ucGe_Menu_event_btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("En construccion", param.nom_pc, MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        



        public void cargar_ajuste_inventario(int IdEmpresa, int IdSucursal, int IdBodega, int IdMovi_inven_tipo, decimal IdNumMovi)
        {
            try
            {
                InfoMoviInven = new in_movi_inve_Info();
                InfoMoviInven =MoviInBus.Get_Info_Movi_inven(IdEmpresa, IdSucursal, IdBodega, IdMovi_inven_tipo, IdNumMovi);

                lblsucursal.Text = InfoMoviInven.nom_sucursal;
                lblbodega.Text = InfoMoviInven.nom_bodega;
                lblNum_Transaccion.Text = InfoMoviInven.IdNumMovi.ToString();
                lblobservacion.Text = InfoMoviInven.cm_observacion;
                dtpfecha.Value = InfoMoviInven.cm_fecha;
                lblTipoMovi_Inven.Text = InfoMoviInven.NomTipoMovi;


                lblanulado.Visible = (InfoMoviInven.Estado == "I") ? true : false;


                this.gridControl_producto.DataSource = InfoMoviInven.listmovi_inve_detalle_Info;

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        private void UCIn_Movimiento_Inventario_Load(object sender, EventArgs e)
        {

        }



    }
}
