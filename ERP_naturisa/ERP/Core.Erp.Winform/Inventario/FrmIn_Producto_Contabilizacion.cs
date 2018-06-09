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
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.Contabilidad;


namespace Core.Erp.Winform.Inventario
{
    public partial class FrmIn_Producto_Contabilizacion : Form
    {
        string MensajeError = "";
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        in_producto_x_tb_bodega_Info Info = new in_producto_x_tb_bodega_Info();

        in_producto_x_tb_bodega_Bus BusProdu_x_Bod = new in_producto_x_tb_bodega_Bus();
        BindingList<in_producto_x_tb_bodega_Info> Bindinglist_prod_x_bodega = new BindingList<in_producto_x_tb_bodega_Info>();

        in_producto_Bus Bus_Producto = new in_producto_Bus();
        bool Sp_Inventario = false;

        public FrmIn_Producto_Contabilizacion()
        {
            InitializeComponent();
            ucGe_Menu.btnGuardar.Text = "Guardar";

        }

        private void FrmIn_Producto_Contabilizacion_Load(object sender, EventArgs e)
        {
            try
            {
                dtpFechaHoy.Value = DateTime.Now;


                Cargar_combo();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void Cargar_combo()
        {
            try
            {
                ct_Plancta_Bus BusPlaCta = new ct_Plancta_Bus();
                List<ct_Plancta_Info> ListPlanCta = new List<ct_Plancta_Info>();
                ListPlanCta = BusPlaCta.Get_List_Plancta_x_ctas_Movimiento(param.IdEmpresa, ref MensajeError);
                cmb_CtaCble_costo.DataSource = ListPlanCta;
                cmb_CtaCble_DescVta.DataSource = ListPlanCta;
                cmb_CtaCble_DevVta.DataSource = ListPlanCta;
                cmb_CtaCble_Gasto.DataSource = ListPlanCta;
                cmb_CtaCble_Inv.DataSource = ListPlanCta;
                cmb_CtaCble_Vta.DataSource = ListPlanCta;

               
               
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        private void Cargar_Grid()
        {
            try
            {
                int IdSucursal = 0;
                int IdBodega = 0;

                IdSucursal = ucIn_Sucursal_Bodega.get_IdSucursal();
                IdBodega =(IdSucursal==0)?0: ucIn_Sucursal_Bodega.get_IdBodega();

                Bindinglist_prod_x_bodega = new BindingList<in_producto_x_tb_bodega_Info>(BusProdu_x_Bod.Get_List_Producto_x_Bodega_x_CtasCbles(param.IdEmpresa, IdSucursal, IdBodega));
                gridControlProducto_x_Bodg.DataSource = Bindinglist_prod_x_bodega;

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                Cargar_Grid();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Guardar();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }


        void Guardar()
        {
            try
            {
                Boolean respuesta = false;

                dtpFechaHoy.Focus();


                List<in_producto_x_tb_bodega_Info> lista_Modificar= new List<in_producto_x_tb_bodega_Info>();
                lista_Modificar = Bindinglist_prod_x_bodega.ToList<in_producto_x_tb_bodega_Info>().FindAll(v => v.RegModificado == true);

               respuesta= BusProdu_x_Bod.ModificarDB(lista_Modificar,param.IdEmpresa, ref MensajeError);

               if (respuesta == true)
               {
                   MessageBox.Show("Actualizacion Ok.", param.Nombre_sistema, MessageBoxButtons.OK,MessageBoxIcon.Information);
               }
               else
               {
                   MessageBox.Show(MensajeError, param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Error);
               }


            }
            catch (Exception ex)
            {

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
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        

        private void advBandedGridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {

                in_producto_x_tb_bodega_Info info = new in_producto_x_tb_bodega_Info();
                Info = (in_producto_x_tb_bodega_Info)this.advBandedGridView1.GetFocusedRow();
                info = Bindinglist_prod_x_bodega.FirstOrDefault(q => q.IdEmpresa == Info.IdEmpresa && q.IdSucursal == Info.IdSucursal && q.IdBodega == Info.IdBodega 
                    && q.IdProducto == Info.IdProducto );



                foreach (var item in Bindinglist_prod_x_bodega)
                {
                    if (item.IdProducto == info.IdProducto && item.IdEmpresa == info.IdEmpresa && item.IdSucursal == info.IdSucursal && item.IdBodega == info.IdBodega )
                    {
                        item.RegModificado = true;
                    }
                }

                gridControlProducto_x_Bodg.RefreshDataSource();


            }
            catch (Exception ex)
            {

            }

        }

    }
}
