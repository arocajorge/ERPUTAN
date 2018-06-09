using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.Inventario;
using System.Threading;

using Core.Erp.Winform.Inventario;



namespace Core.Erp.Winform.Inventario
{

    public partial class FrmIn_ContabilizarInventario : Form
    {
        #region Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        
        string Mensaje = "";

        
        vwin_movi_inve_detalle_x_Contabilizar_x_ctacbles_Bus BusMovi_Inv_det_x_Conta = new vwin_movi_inve_detalle_x_Contabilizar_x_ctacbles_Bus();
        List<vwin_movi_inve_detalle_x_Contabilizar_x_ctacbles_Info> ListMovi_Inv_det_x_Conta = new List<vwin_movi_inve_detalle_x_Contabilizar_x_ctacbles_Info>();
        in_movi_inven_tipo_Bus BusMoviInvenTipo = new in_movi_inven_tipo_Bus();




        #endregion

        public FrmIn_ContabilizarInventario()
        {
            try
            {
               InitializeComponent();
            }
            catch (Exception ex)
            {
               Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        
        
        private void frmIn_ContabilizarInventario_Load(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            cargar_grid();
        }

        private void cargar_grid()
        { 
            int IdSucursal=0;
            int IdBodega=0;
            int IdMovi_inven_tipo=0;
            DateTime fechaIni;
            DateTime fechaFin;
            
            IdSucursal = ucIn_Sucursal_Bodega.get_IdSucursal();
            IdBodega = ucIn_Sucursal_Bodega.get_IdBodega();
            fechaIni = dtpDesde.Value;
            fechaFin = dtpHasta.Value;

            ListMovi_Inv_det_x_Conta = BusMovi_Inv_det_x_Conta.Get_List_movi_inve_detalle_x_Contabilizar_x_ctacbles(param.IdEmpresa, IdSucursal, IdBodega, "", IdMovi_inven_tipo, fechaIni, fechaFin);

            gridControlMoviInven.DataSource = ListMovi_Inv_det_x_Conta;
        
        }

        

        
        
        
    }
}
