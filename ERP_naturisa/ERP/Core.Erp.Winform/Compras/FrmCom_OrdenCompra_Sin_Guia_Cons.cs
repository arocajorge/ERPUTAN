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
using Core.Erp.Info.Compras;
using Core.Erp.Business.Compras;

namespace Core.Erp.Winform.Compras
{
    public partial class FrmCom_OrdenCompra_Sin_Guia_Cons : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        
        com_ordencompra_local_Bus Bus_OCSinGuia = new com_ordencompra_local_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        
        List<com_ordencompra_local_Info> LstOCSinGuia = new List<com_ordencompra_local_Info>();

        public int IdSucursal { get; set; }
        public DateTime FechaIni { get; set; }
        public DateTime FechaFin { get; set; }
        
        public FrmCom_OrdenCompra_Sin_Guia_Cons()
        {
            InitializeComponent();
        }
                  
        private void cargagrid()
        {
            try
            {                                            
                LstOCSinGuia = Bus_OCSinGuia.Get_List_ordencompra_local_sin_Guia_x_traspaso_bodega(param.IdEmpresa, IdSucursal, FechaIni, FechaFin); 
                gridControlConsulta.DataSource = LstOCSinGuia;              
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);    
            }
        }

        private void FrmCom_OrdenCompra_Sin_Guia_Cons_Load(object sender, EventArgs e)
        {
            try
            {
                dtpFechaIni.Value = DateTime.Now.Date.AddMonths(-1);
                dtpFechaFin.Value = DateTime.Now.Date;
                 
                cargagrid();
             
            }
            catch (Exception ex)
            {               
               Log_Error_bus.Log_Error(ex.ToString());
               MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);    
            }
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            try
            {
                IdSucursal = cmb_sucursal.get_SucursalInfo().IdSucursal;
                FechaIni = dtpFechaIni.Value;
                FechaFin = dtpFechaFin.Value;

                cargagrid();

                if (LstOCSinGuia.Count() == 0)
                {
                    MessageBox.Show("No existe información para estos filtros", "Sistemas");
                    return;
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);    
            }
        }

        public int idempresa { get; set; }
        public int idsucursal { get; set; }
        public decimal idOrdenCompra { get; set; }
     
        private void gridViewConsulta_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                idempresa = Convert.ToInt32(gridViewConsulta.GetFocusedRowCellValue(colIdEmpresa));
                idsucursal = Convert.ToInt32(gridViewConsulta.GetFocusedRowCellValue(colIdSucursal));
                idOrdenCompra = Convert.ToDecimal(gridViewConsulta.GetFocusedRowCellValue(colIdOrdenCompra));
               
                this.Close();
            }
            catch (Exception ex)
            {               
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);    
            }
        }
    }
}
