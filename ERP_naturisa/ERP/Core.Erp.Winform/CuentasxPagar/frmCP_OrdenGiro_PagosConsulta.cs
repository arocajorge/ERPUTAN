using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.CuentasxPagar;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Info.Contabilidad;


namespace Core.Erp.Winform.CuentasxPagar
{
    public partial class frmCP_OrdenGiro_PagosConsulta : Form
    {
        public frmCP_OrdenGiro_PagosConsulta()
        {
            try
            {
              InitializeComponent();
              ucGe_Menu_Mantenimiento_x_usuario.event_btnAnular_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick;
              ucGe_Menu_Mantenimiento_x_usuario.event_btnconsultar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick;
              ucGe_Menu_Mantenimiento_x_usuario.event_btnNuevo_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick;
              ucGe_Menu_Mantenimiento_x_usuario.event_btnSalir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.Dispose();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                PrepararForm(Cl_Enumeradores.eTipo_action.grabar, info);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (info == null)
                {
                    MessageBox.Show("Selecciones una fila", "sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    PrepararForm(Cl_Enumeradores.eTipo_action.consultar, info);
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (info == null)
                {
                    MessageBox.Show("Selecciones una fila", "sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    PrepararForm(Cl_Enumeradores.eTipo_action.Anular, info);
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        //cp_orden_giro_pagos_Bus PagosOG_B = new cp_orden_giro_pagos_Bus();
        frmCP_OrdenGiro_CanceXOtrosMoti frm = new frmCP_OrdenGiro_CanceXOtrosMoti();
        vwct_cbtecble_Con_Saldo_Info info = new vwct_cbtecble_Con_Saldo_Info();

        private void load_data()
        {
            try
            {
                //List<vwct_cbtecble_Con_Saldo_Info> listado = new List<vwct_cbtecble_Con_Saldo_Info>();
                //List<vwct_cbtecble_Con_Saldo_Info> consulta = PagosOG_B.ObtenerListPagosOG_X_Cbte(param.IdEmpresa);
                //var lista = from c in consulta
                //            group c by new { c.IdCancelacion }
                //                into agrupado
                //                select new { agrupado.Key };

                //foreach (var grup in lista)
                //{
                //    foreach (var item in consulta)
                //    {
                //        if (grup.Key.IdCancelacion == item.IdCancelacion)
                //        {
                //            item.ValorDiario = Convert.ToDouble(Math.Round(Convert.ToDecimal(item.ValorDiario), 2));
                //            item.MontoOG = Convert.ToDouble(Math.Round(Convert.ToDecimal(item.MontoOG), 2));
                //            item.SaldoDiario = Convert.ToDouble(Math.Round(Convert.ToDecimal(item.SaldoDiario), 2));
                //            listado.Add(item);
                //            break;
                //        }
                //    }

                //}
                ////listado = PagosOG_B.ObtenerListPagosOG_X_Cbte(param.IdEmpresa);
                //this.gridControl_OrdenGiroPagos.DataSource = listado;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PrepararForm(Cl_Enumeradores.eTipo_action Accion, vwct_cbtecble_Con_Saldo_Info info)
        {
            try
            {
                frm = new frmCP_OrdenGiro_CanceXOtrosMoti();
                frm.event_frmCP_OrdenGiro_CanceXOtrosMoti_FormClosing += new frmCP_OrdenGiro_CanceXOtrosMoti.delegate_frmCP_OrdenGiro_CanceXOtrosMoti_FormClosing(frm_event_frmCP_OrdenGiro_CanceXOtrosMoti_FormClosing);
                frm.set_Accion(Accion);
                frm.MdiParent = this.MdiParent;
                if (!(Accion == Cl_Enumeradores.eTipo_action.grabar))
                {
                    frm.set_CbteCble(info);
                }
                frm.Show();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void frm_event_frmCP_OrdenGiro_CanceXOtrosMoti_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
              load_data();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        private void frmCP_OrdenGiro_PagosConsulta_Load(object sender, EventArgs e)
        {
            try
            {
                 load_data();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void UltraGrid_OrdenGiroPagos_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                info = (vwct_cbtecble_Con_Saldo_Info)UltraGrid_OrdenGiroPagos.GetRow(e.FocusedRowHandle);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }




    }
}
