using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Business.Facturacion;
using Core.Erp.Info.Facturacion;
using Core.Erp.Info.General;
using Core.Erp.Business.General;

using Core.Erp.Business.Inventario;
using Core.Erp.Info.Inventario;
using Core.Erp.Winform.Inventario;
using Core.Erp.Winform.Contabilidad;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.Contabilidad;



namespace Core.Erp.Winform.General
{
    public partial class FrmGe_Auditoria_de_Sistemas : Form
    {
        #region Variables
        FrmGe_Banco_Mant frm;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        vwin_movi_inve_x_cbteCble_Datos_Bus BusMovi_x_Cbte = new vwin_movi_inve_x_cbteCble_Datos_Bus();
        List<vwin_movi_inve_x_cbteCble_Datos_Info> list_vwin_movi_inve_x_cbteCble_Datos = new List<vwin_movi_inve_x_cbteCble_Datos_Info>();
        BindingList<vwin_movi_inve_x_cbteCble_Datos_Info> list_vwin_movi_inve_x_cbteCble_Datos_no_contabilizados = new BindingList<vwin_movi_inve_x_cbteCble_Datos_Info>();

        #endregion

        public FrmGe_Auditoria_de_Sistemas()
        {
            InitializeComponent();
        }
               
        private void FrmGe_Auditoria_de_Sistemas_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            gridControlVentas_cbtecble.ShowPrintPreview();
        }        
       
        private void gridViewTransMoviInven_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                string mesn="";

                vwin_movi_inve_x_cbteCble_Datos_Info infofila = new vwin_movi_inve_x_cbteCble_Datos_Info();
                infofila = (vwin_movi_inve_x_cbteCble_Datos_Info)gridViewTransMoviInven.GetFocusedRow();


                if (e.Column == col_modificar_contabilidad)
                {
                    if (infofila.IdCbteCble > 0)
                    {
                        frmCon_CbteCble_Mant frm = new frmCon_CbteCble_Mant();
                        ct_Cbtecble_Info InfoCbte = new ct_Cbtecble_Info();
                        ct_Cbtecble_Bus BusCbte = new ct_Cbtecble_Bus();
                        InfoCbte = BusCbte.Get_Info_CbteCble(Convert.ToInt32(infofila.IdEmpresa), Convert.ToInt32(infofila.IdTipoCbte), Convert.ToDecimal(infofila.IdCbteCble), ref mesn);
                        frm.event_frmCon_CbteCble_Mant_FormClosing += frm_event_frmCon_CbteCble_Mant_FormClosing;
                        frm.set_Info(InfoCbte);
                        frm.setAccion(Cl_Enumeradores.eTipo_action.actualizar);
                        frm.ShowDialog();                        
                    }                     
                }
                if (e.Column == col_modificar_producto)
                {
                    if (infofila.IdProducto>0)
                    {
                        FrmIn_Producto_Mant frm = new FrmIn_Producto_Mant();
                        in_Producto_Info info_producto = new in_Producto_Info();
                        in_producto_Bus bus_producto = new in_producto_Bus();
                        info_producto = bus_producto.Get_Info_BuscarProducto(infofila.IdProducto, param.IdEmpresa);
                        frm.event_FrmIn_Producto_Mant_FormClosing += frm_event_FrmIn_Producto_Mant_FormClosing;
                        frm.set_Info_producto(info_producto);
                        frm.set_Accion(Cl_Enumeradores.eTipo_action.actualizar);
                        frm.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error comunicarse con Sistemas " + ex.Message + " ", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void frm_event_FrmIn_Producto_Mant_FormClosing(object sender, FormClosingEventArgs e, in_Producto_Info info)
        {
            try
            {
                Cargar_inventario();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error comunicarse con Sistemas " + ex.Message + " ", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void frm_event_frmCon_CbteCble_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Cargar_inventario();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error comunicarse con Sistemas " + ex.Message + " ", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Contabilizar_Click(object sender, EventArgs e)
        {
            try
            {

                var lista_a_contabilizar = from c in list_vwin_movi_inve_x_cbteCble_Datos_no_contabilizados
                        where c.cheked==true
                        select c;




                foreach (var item in lista_a_contabilizar)
                {
                    string msg = "";
                    in_movi_inve_Bus BusMovi_Inven = new in_movi_inve_Bus();
                    in_movi_inve_Info Info_Movi_Inven = new in_movi_inve_Info();

                    Info_Movi_Inven = BusMovi_Inven.Get_Info_Movi_inven(Convert.ToInt32(item.IdEmpresa_inv), Convert.ToInt32(item.IdSucursal_inv),
                        Convert.ToInt32(item.IdBodega_inv), Convert.ToInt32(item.IdMovi_inven_tipo_inv), Convert.ToDecimal(item.IdNumMovi_inv));

                    BusMovi_Inven.Contabilizar(Info_Movi_Inven, ref msg, ref msg);

                    

                }

                MessageBox.Show("Contabilizacion finalizada..", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error comunicarse con Sistemas " + ex.Message + " ", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                
            }

        }

        private void Cargar_ventas()
        {
            try
            {
                tbSys_Ge_Comparativo_Modulo_vs_Contas_Bus Bus = new tbSys_Ge_Comparativo_Modulo_vs_Contas_Bus();
                List<tbSys_Ge_Comparativo_Modulo_vs_Contas_Info> List_comp_conta = new List<tbSys_Ge_Comparativo_Modulo_vs_Contas_Info>();

                DateTime Fecha_ini;
                DateTime Fecha_Fin;

                Fecha_ini = menu_filtro.fecha_desde;
                Fecha_Fin = menu_filtro.fecha_hasta;

                List_comp_conta = Bus.Get_List_Comparativo_Modulo_vs_Contas(param.IdEmpresa, Fecha_ini, Fecha_Fin);
                gridControlVentas_cbtecble.DataSource = List_comp_conta;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error comunicarse con Sistemas " + ex.Message + " ", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void Cargar_inventario()
        {
            try
            {
                string Tipo_Conta = (chkMostrar_movi_Inv_NO_Conta.Checked == true) ? "NO CONTABILIZADO" : "";
                string tipo_ing_egr = (cmbtipo_ing_egr.Text == "TODOS") ? "" : (cmbtipo_ing_egr.Text == "INGRESOS") ? "+" : "-";
                string tipo_ing_egr_no_conta = (cmbtipo_ing_egr_no_conta.Text == "TODOS") ? "" : (cmbtipo_ing_egr_no_conta.Text == "INGRESOS") ? "+" : "-";

                list_vwin_movi_inve_x_cbteCble_Datos = BusMovi_x_Cbte.Get_List_vwin_movi_inve_x_cbteCble_Datos(param.IdEmpresa, menu_filtro.fecha_desde.Date, menu_filtro.fecha_hasta.Date, tipo_ing_egr, Tipo_Conta);
                list_vwin_movi_inve_x_cbteCble_Datos_no_contabilizados = new BindingList<vwin_movi_inve_x_cbteCble_Datos_Info>(BusMovi_x_Cbte.Get_List_vwin_movi_inve_x_cbteCble_Datos_No_Contabilizados(param.IdEmpresa, menu_filtro.fecha_desde, menu_filtro.fecha_hasta, tipo_ing_egr_no_conta));
                gridControlTransInven.DataSource = list_vwin_movi_inve_x_cbteCble_Datos;
                gc_no_contabilizados.DataSource = list_vwin_movi_inve_x_cbteCble_Datos_no_contabilizados;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error comunicarse con Sistemas " + ex.Message + " ", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void menu_filtro_event_btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (xtraTabControlGeneral.SelectedTabPage == TabPage_ventas)
                {
                    Cargar_ventas();
                }else
                    if (xtraTabControlGeneral.SelectedTabPage == TabPage_inventario)
                    {
                        Cargar_inventario();
                    }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error comunicarse con Sistemas " + ex.Message + " ", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_Superior_Mant1_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error comunicarse con Sistemas " + ex.Message + " ", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chketodos_CheckedChanged(object sender, EventArgs e)
        {
            foreach (var item in list_vwin_movi_inve_x_cbteCble_Datos_no_contabilizados)
            {
                item.cheked = chketodos.Checked;
            }

            gc_no_contabilizados.RefreshDataSource();
        }              
        
    }
}
