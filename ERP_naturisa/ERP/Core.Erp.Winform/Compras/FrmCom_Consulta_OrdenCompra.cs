using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.Compras;
using Core.Erp.Info.Compras;
using Core.Erp.Business.General;


namespace Core.Erp.Winform.Compras
{
    public partial class FrmCom_Consulta_OrdenCompra : Form
    {
        #region Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        List<com_ordencompra_local_Info> listOrdenCompra = new List<com_ordencompra_local_Info>();
        string mensaje = "";
        public com_ordencompra_local_Info Info_orden_compra { get; set; }
        #endregion
        
        public FrmCom_Consulta_OrdenCompra()
        {
            InitializeComponent();
            ucGe_Menu.event_btnAceptar_Click += ucGe_Menu_event_btnAceptar_Click;

        }

        void ucGe_Menu_event_btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {

                Info_orden_compra = (com_ordencompra_local_Info)gridView_oc.GetFocusedRow();
                this.Close();


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void cargar_ordencompra_x_devolver()
        {

            try
            {
              
              com_ordencompra_local_Bus OCBus = new com_ordencompra_local_Bus();

              listOrdenCompra = OCBus.Get_List_ordencompra_local_x_devolver(param.IdEmpresa, Info_orden_compra.IdProveedor, ref mensaje);
              gridControl_Oc.DataSource = listOrdenCompra;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmCom_Consulta_OrdenCompra_Load(object sender, EventArgs e)
        {
            try
            {

                set(lista);
            }
            catch (Exception ex)
            {
                
                
            }

        }

       public List<com_ordencompra_local_Info> lista { get; set; }

       void set(List<com_ordencompra_local_Info> LstOC)
        {

            try
            {
               decimal id=lista.FirstOrDefault().IdProveedor;
                
                com_ordencompra_local_Bus OCBus = new com_ordencompra_local_Bus();

                listOrdenCompra = OCBus.Get_List_ordencompra_local_x_devolver(param.IdEmpresa, id, ref mensaje);

                gridControl_Oc.DataSource = LstOC;
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
               Close();
           }
           catch (Exception ex)
           {
               Log_Error_bus.Log_Error(ex.ToString());
               MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
       }
    }
}
