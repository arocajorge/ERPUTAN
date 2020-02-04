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
using Core.Erp.Info.Inventario;
using Core.Erp.Business.Inventario;

namespace Core.Erp.Winform.Inventario
{
    public partial class FrmIn_Transferencia_Sin_Guia_Cons : Form
    {
        public FrmIn_Transferencia_Sin_Guia_Cons()
        {
            InitializeComponent();
        }


        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;       

        int idsucursal=0;
        in_transferencia_bus Bus_transferecia = new in_transferencia_bus();
        List<in_transferencia_Info> Listados_Transferencia = new List<in_transferencia_Info>();

        public in_transferencia_Info info_Transferencia { get; set; }

        public int IdSucursal { get; set; }
        public DateTime FechaIni { get; set; }
        public DateTime FechaFin { get; set; }

        
                  
        private void cargagrid()
        {
            try
            {
                idsucursal = cmb_sucursal.get_SucursalInfo().IdSucursal;
                Listados_Transferencia = Bus_transferecia.ObtenerTransferencias(param.IdEmpresa, FechaIni, FechaFin, idsucursal);

                gridControlConsulta.DataSource = Listados_Transferencia;              
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

                if (Listados_Transferencia.Count() == 0)
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

        private void FrmIn_Transferencia_Sin_Guia_Cons_Load(object sender, EventArgs e)
        {
             try
            {
               
                 
                cargagrid();
             
            }
            catch (Exception ex)
            {               
               Log_Error_bus.Log_Error(ex.ToString());
               MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);    
            }
        }

        private void gridViewConsulta_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                info_Transferencia = (in_transferencia_Info)gridViewConsulta.GetFocusedRow();

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
