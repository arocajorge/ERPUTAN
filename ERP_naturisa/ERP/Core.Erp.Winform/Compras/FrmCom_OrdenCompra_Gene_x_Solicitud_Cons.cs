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

using Core.Erp.Business.Compras;
using Core.Erp.Info.Compras;

using Cus.Erp.Reports.Naturisa.Compras;

namespace Core.Erp.Winform.Compras
{
    public partial class FrmCom_OrdenCompra_Gene_x_Solicitud_Cons : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus;
        BindingList<com_ordencompra_local_Info> ListaBind;
        
        public FrmCom_OrdenCompra_Gene_x_Solicitud_Cons()
        {
            InitializeComponent();
        }
        
        public List<com_ordencompra_local_Info> list_OrdComp { get; set; }
   
        void carga_grid()
        {
            try
            {
                if (list_OrdComp.Count !=0)
                {
                    com_ordencompra_local_Bus bus_OrdComp = new com_ordencompra_local_Bus();
                    com_ordencompra_local_Info info_OrdComp = new com_ordencompra_local_Info();
                    List<com_ordencompra_local_Info> lista_OrdComp = new List<com_ordencompra_local_Info>();

                    foreach (var item in list_OrdComp)
                    {
                        info_OrdComp = bus_OrdComp.Get_Info_ordencompra_local(item.IdEmpresa, item.IdSucursal, item.IdOrdenCompra);

                        lista_OrdComp.Add(info_OrdComp);
                    }

                    ListaBind = new BindingList<com_ordencompra_local_Info>(lista_OrdComp);
                    gridControlOrdComp.DataSource = ListaBind;
                }                                                                                                                          
            }
            catch (Exception ex)
            {
                Log_Error_bus = new Business.General.tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);    
            }        
        }

        private void FrmCom_OrdenCompra_Gene_x_Solicitud_Cons_Load(object sender, EventArgs e)
        {
            try
            {
                carga_grid();
            }
            catch (Exception ex)
            {

                Log_Error_bus = new Business.General.tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);    
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {

                Log_Error_bus = new Business.General.tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);    
            }
        }

        private void ucGe_Menu_event_btnAprobar_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Se generó la Orden de Compra Exitosamente", "Sistemas");
                Close();
            }
            catch (Exception ex)
            {

                Log_Error_bus = new Business.General.tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);    
            }
        }

        private void ucGe_Menu_event_btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {

                if (list_OrdComp.Count != 0)
                {
                    MessageBox.Show("Se procederá a Imprimir todas las Ordenes de Compras", "Sistemas");

                    foreach (var item in ListaBind)
                    {
                        XCOMP_Rpt001_Rpt reporte = new XCOMP_Rpt001_Rpt();

                        int IdEmpresa = 0;
                        int IdSucursal = 0;
                        decimal IdOrdenCompra = 0;

                        IdEmpresa = item.IdEmpresa;
                        IdSucursal = item.IdSucursal;
                        IdOrdenCompra = item.IdOrdenCompra;

                        reporte.set_parametros(IdEmpresa, IdSucursal, IdOrdenCompra);
                        reporte.RequestParameters = true;
                        reporte.ShowPreviewDialog();
                    }
                }

            }
            catch (Exception ex)
            {

                Log_Error_bus = new Business.General.tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);    
            }
        }

        private void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {

                Log_Error_bus = new Business.General.tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);    
            }
        }
    }
}
