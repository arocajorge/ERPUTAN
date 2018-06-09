using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.Roles;
using Core.Erp.Business.Roles;
using Core.Erp.Business.CuentasxPagar;
using Core.Erp.Business.General;
using Core.Erp.Business.Presupuesto;
using Core.Erp.Info.Presupuesto;

namespace Core.Erp.Winform.Presupuesto
{
    public partial class frmpre_pedidoProductoAprobacion : Form
    {
        public frmpre_pedidoProductoAprobacion()
        {
            try
            {
                InitializeComponent(); 
                List<ro_Departamento_Info> depaInfo = new List<ro_Departamento_Info>();
                ro_Departamento_Bus depaBus = new ro_Departamento_Bus();
                depaInfo = depaBus.Get_List_Departamento(param.IdEmpresa);
                repositoryItemSearchLookUpEdit_departamento.DataSource = depaInfo;
                cp_proveedor_Bus proveedorB = new cp_proveedor_Bus();
                repositoryItemSearchLookUpEdit_Proveedor.DataSource = proveedorB.Get_List_proveedor(param.IdEmpresa);
                
                repositoryItemSearchLookUpEdit_estadoA.DataSource = estaA_B.obtenerList();
                LstestaB = estaA_B.obtenerList();

                EstadoA.CodEstado = "T"; EstadoA.Descripcion = "Todos";
                LstestaB.Add(EstadoA);
                
                cmb_estadoApro.DataSource = LstestaB;
                cmb_estadoApro.SelectedValue = EstadoA.CodEstado;
               
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        pre_estadoAprobacion_Info EstadoA = new pre_estadoAprobacion_Info();
        string EstadoApro = "T";
        List<pre_estadoAprobacion_Info> LstestaA = new List<pre_estadoAprobacion_Info>();
        List<pre_estadoAprobacion_Info> LstestaB = new List<pre_estadoAprobacion_Info>();
        pre_estadoAprobacion_Bus estaA_B = new pre_estadoAprobacion_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        pre_PedidoXPresupuesto_det_Bus pedido_B = new pre_PedidoXPresupuesto_det_Bus();
        List<pre_PedidoXPresupuesto_det_Info> LstPedido = new List<pre_PedidoXPresupuesto_det_Info>();

        private void loadData()
        {
            try
            {
                LstPedido.Clear();
                gridControl_Pedido.DataSource = pedido_B.ObtenerListFiltro(param.IdEmpresa, dtp_desde.Value, dtp_hasta.Value, EstadoApro);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void toolStripButtonSalir_Click(object sender, EventArgs e)
        {
            try
            {
              this.Close();
            }
            catch (Exception ex)
            {
                 Log_Error_bus.Log_Error(ex.ToString());
            }           
        }

        private void frmpre_pedidoProductoAprobacion_Load(object sender, EventArgs e)
        {
            try
            {
                  dtp_desde.Value = dtp_desde.Value.AddYears(-1);
                  loadData();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            try
            {
                  loadData();
            }
            catch (Exception ex)
            {
                 Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void dtp_desde_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == '\r')
                    loadData();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void dtp_hasta_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == '\r')
                    loadData();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                 Grabar();
            }
            catch (Exception ex)
            {
                 Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void Grabar()
        {
            try
            {
                cmb_estadoApro.Focus();
                if (pedido_B.ModificarDBEstadoAprobacionLst(LstPedido))
                {
                    MessageBox.Show("Proceso realizada exitosamente", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadData();
                }
                else
                    MessageBox.Show("Inconveniente  al realizar el Proceso", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void cmb_estadoApro_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                EstadoApro = cmb_estadoApro.SelectedValue.ToString() ;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void gridView_Pedido_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                //var data = gridView_Pedido.GetRow(e.RowHandle) as pre_PedidoXPresupuesto_det_Info;
                //if (data == null)
                //    return;
                //if (data.Estado == "I")
                //    e.Appearance.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void gridView_Pedido_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            try
            {
                pre_PedidoXPresupuesto_det_Info c = (pre_PedidoXPresupuesto_det_Info)gridView_Pedido.GetFocusedRow();
                c.UltiFechaEstadoApro = Convert.ToDateTime(param.Fecha_Transac.ToShortDateString());
                c.IdUsuarioEstadoApro = param.IdUsuario;
              //  MessageBox.Show("ijij");
                LstPedido.Add(c);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
    }
}
