using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.General;
using Core.Erp.Business.Bancos;
using Core.Erp.Info.General;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Info.Bancos;
using Core.Erp.Business.CuentasxPagar;


namespace Core.Erp.Winform.CuentasxPagar
{
    public partial class frmCP_OrdenGiro_CanceXOtrosMoti : Form
    {
        #region Declaración de Variables
         tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        private Cl_Enumeradores.eTipo_action _Accion;
        ct_Cbtecble_det_Bus detCbt_B = new ct_Cbtecble_det_Bus();
        vwct_cbtecble_Con_Saldo_Info detCbt_I = new vwct_cbtecble_Con_Saldo_Info();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        vwba_ordenGiroPendientes_Bus OGP_B = new vwba_ordenGiroPendientes_Bus();
        List<vwba_ordenGiroPendientes_Info> Lst_OGP_I = new List<vwba_ordenGiroPendientes_Info>();
        List<cp_orden_giro_pagos_Info> lisOG_Paga = new List<cp_orden_giro_pagos_Info>();
        //cp_orden_giro_pagos_Bus OGPagos_B = new cp_orden_giro_pagos_Bus();
        vwba_Cbte_Ban_detallePagos_Bus CbtPagosOG_B = new vwba_Cbte_Ban_detallePagos_Bus();
        List<vwct_cbtecble_Con_Saldo_Info> ListCbt_I = new List<vwct_cbtecble_Con_Saldo_Info>();
        decimal IdCancelacion;
        decimal SaldoCblDisponible = 0;
        int c = 0;
        decimal sumaOG = 0;
        public delegate void delegate_frmCP_OrdenGiro_CanceXOtrosMoti_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmCP_OrdenGiro_CanceXOtrosMoti_FormClosing event_frmCP_OrdenGiro_CanceXOtrosMoti_FormClosing;

        #endregion

        public frmCP_OrdenGiro_CanceXOtrosMoti()
        {
            try
            {
                InitializeComponent();
                Lst_OGP_I = OGP_B.Get_List_ordenGiroPendientes(param.IdEmpresa);
                foreach (var item in Lst_OGP_I)
                {
                    item.valorAPagar = Math.Round(Convert.ToDouble(item.valorAPagar), 2);
                    item.saldo = Convert.ToDouble(Math.Round(Convert.ToDecimal(item.saldo), 2));
                    item.valorAplicado = Math.Round(Convert.ToDecimal(item.valorAplicado), 2);
                }
                gridControl_OrdenGiro.DataSource = Lst_OGP_I;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }       

        public List<cp_orden_giro_pagos_Info> get_lisOG_Paga()
        {
            try
            {
                for (int i = 0; i < UltraGrid_OrdenGiro.RowCount; i++)
                {
                    cp_orden_giro_pagos_Info OGP_I = new cp_orden_giro_pagos_Info();
                    if (Convert.ToDecimal(UltraGrid_OrdenGiro.GetRowCellValue(i, "valorAplicado")) > 0)
                    {
                        OGP_I.Fecha_Transac = param.Fecha_Transac;
                        OGP_I.Fecha_UltAnu = param.Fecha_Transac;
                        OGP_I.Fecha_UltMod = param.Fecha_Transac;
                        OGP_I.IdCbteCble_cbte = Convert.ToDecimal(txt_NCbte.Text);
                        OGP_I.IdEmpresa_cbte = param.IdEmpresa;
                        OGP_I.IdUsuario = param.IdUsuario;
                        OGP_I.IdUsuarioUltAnu = param.IdUsuario;
                        OGP_I.IdUsuarioUltMod = param.IdUsuario;
                        OGP_I.ip = param.ip;
                        OGP_I.nom_pc = param.nom_pc;
                        OGP_I.IdCbteCble_Ogiro = Convert.ToDecimal(UltraGrid_OrdenGiro.GetRowCellValue(i, "IdCbteCble_Ogiro"));
                        OGP_I.IdEmpresa_Og = Convert.ToInt32(UltraGrid_OrdenGiro.GetRowCellValue(i, "IdEmpresa"));
                        OGP_I.IdTipocbte_cbte = detCbt_I.IdTipoCbte;
                        OGP_I.IdTipoCbte_Ogiro = Convert.ToInt32(UltraGrid_OrdenGiro.GetRowCellValue(i, "IdTipoCbte_Ogiro"));
                        OGP_I.pg_MontoAplicado = Convert.ToDouble(UltraGrid_OrdenGiro.GetRowCellValue(i, "valorAplicado"));
                        OGP_I.pg_saldoAnterior = Convert.ToDouble(UltraGrid_OrdenGiro.GetRowCellValue(i, "saldo2"));
                        OGP_I.pg_saldoActual = Convert.ToDouble(UltraGrid_OrdenGiro.GetRowCellValue(i, "saldo"));
                        OGP_I.estado = "A";
                        lisOG_Paga.Add(OGP_I);
                    }
                }
                return lisOG_Paga;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<cp_orden_giro_pagos_Info>();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                   this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            try
            {
                string MensajeError = "";
                List<vwct_cbtecble_Con_Saldo_Info> consul = detCbt_B.Get_list_Cbtecble_Con_Saldo(param.IdEmpresa, dtp_FechaIni.Value, dtp_FechaFin.Value, ref MensajeError);
                foreach (var item in consul)
                {

                    item.ValorDiario = Convert.ToDouble(Math.Round(Convert.ToDecimal(item.ValorDiario), 2));
                    item.MontoOG = Convert.ToDouble(Math.Round(Convert.ToDecimal(item.MontoOG), 2));
                    item.SaldoDiario = Convert.ToDouble(Math.Round(Convert.ToDecimal(item.SaldoDiario), 2));
                }
               gridCbte.DataSource = consul;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        void loadOG_xempresa()
        {
            try
            {
                List<vwba_ordenGiroPendientes_Info> Consulta = OGP_B.Get_List_ordenGiroPendientes(param.IdEmpresa);
                foreach (var item in Consulta)
                    {
                        item.valorAPagar = Math.Round(Convert.ToDouble(item.valorAPagar), 2);
                        item.saldo = Convert.ToDouble(Math.Round(Convert.ToDecimal(item.saldo), 2));
                        item.valorAplicado = Math.Round(Convert.ToDecimal(item.valorAplicado), 2);
                    }
                    gridControl_OrdenGiro.DataSource = Consulta;
            }
            catch (Exception ex)
            {
                 Log_Error_bus.Log_Error(ex.ToString());
                 MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void set_Accion(Cl_Enumeradores.eTipo_action iAccion)
        {
            try
            {
                _Accion = iAccion;
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:

                        loadOG_xempresa();
                        btnAnular.Enabled = false;
                        break;

                    case Cl_Enumeradores.eTipo_action.actualizar:


                        break;

                    case Cl_Enumeradores.eTipo_action.Anular:

                        btn_grabar.Enabled = false;
                        btn_grabarysalir.Enabled = false;

                        break;

                    case Cl_Enumeradores.eTipo_action.consultar:

                        btn_grabar.Enabled = false;
                        btn_grabarysalir.Enabled = false;
                        btnAnular.Enabled = false;
                        gridViewCbte.OptionsBehavior.Editable = false;
                        UltraGrid_OrdenGiro.OptionsBehavior.Editable = false;
                        toolStripButton1.Enabled = false;
                        gridColumn16.Visible = false;
                        Chek.Visible = false;
                        grpB_OG.Text = "Ordenes de Giro Cruzadas";

                        break;

                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SumaOG()
        {
            try
            {
                sumaOG = 0;
                List<vwba_ordenGiroPendientes_Info> Lista = (List<vwba_ordenGiroPendientes_Info>)UltraGrid_OrdenGiro.DataSource;

                sumaOG = Convert.ToDecimal(Lista.Sum(c => c.valorAplicado));

                txt_SumOG.EditValue = sumaOG;
                txt_diferencia.EditValue = Convert.ToDecimal(txt_saldo.EditValue) - sumaOG;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewCbte_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                if (e.Column.FieldName == "chek")
                {
                    (from q in Lst_OGP_I select q).ToList().ForEach(OD => { OD.chek = false; OD.valorAplicado = 0; OD.saldo = OD.saldo2; });
                    gridControl_OrdenGiro.DataSource = null;
                    foreach (var item in Lst_OGP_I)
                    {
                        item.valorAPagar = Math.Round(Convert.ToDouble(item.valorAPagar), 2);
                        item.saldo = Convert.ToDouble(Math.Round(Convert.ToDecimal(item.saldo), 2));
                        item.valorAplicado = Math.Round(Convert.ToDecimal(item.valorAplicado), 2);
                    }
                    gridControl_OrdenGiro.DataSource = Lst_OGP_I;

                    if (Convert.ToBoolean(gridViewCbte.GetRowCellValue(e.RowHandle, "chek")) == false)
                    {
                        for (int i = 0; i < gridViewCbte.RowCount; i++)
                        {
                            gridViewCbte.SetRowCellValue(i, "chek", false);
                        }
                        gridViewCbte.SetRowCellValue(gridViewCbte.GetFocusedDataSourceRowIndex(), "chek", true);
                        detCbt_I = (vwct_cbtecble_Con_Saldo_Info)gridViewCbte.GetRow(e.RowHandle);
                        SaldoCblDisponible = Convert.ToDecimal(detCbt_I.SaldoDiario);
                        txt_saldo.EditValue = Convert.ToDecimal(detCbt_I.SaldoDiario);
                        txt_NCbte.Text = detCbt_I.IdCbteCble.ToString();
                        txt_tipoCbte.Text = detCbt_I.TipoCbte.ToString();
                    }
                    else
                    {
                        gridViewCbte.SetRowCellValue(gridViewCbte.GetFocusedDataSourceRowIndex(), "chek", false);
                        detCbt_I = null;
                        SaldoCblDisponible = 0;
                        txt_saldo.EditValue = 0;
                        txt_NCbte.Text = "";
                        txt_tipoCbte.Text = "";
                    }

                    sumaOG = 0;
                    txt_SumOG.EditValue = 0;
                    txt_diferencia.EditValue = Convert.ToDecimal(txt_saldo.EditValue) - Convert.ToDecimal(txt_SumOG.EditValue);
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Grabar()
        {
            try
            {
                if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    get_lisOG_Paga();
                    //if (OGPagos_B.GrabarLista(lisOG_Paga, param.IdEmpresa, ref IdCancelacion))
                    //{
                    //    MessageBox.Show("Se Grabo correctamente los pagos de la Ordenes de Giro aplicadas", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //    lbl_NPago.Text = "Pago de O.G. # " + IdCancelacion;
                    //    //btn_grabar.Enabled = false;
                    //    //btn_grabarysalir.Enabled = false;
                    //    LimpiarDatos();
                    //}
                    //else
                    //    MessageBox.Show("No se pudo Grabar los pagos de la Ordenes de Giro aplicadas", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (_Accion == Cl_Enumeradores.eTipo_action.Anular)
                {
                    if (MessageBox.Show("¿Está seguro que desea Borras los Pagos de Ordenes de Giro asociados al Comprobante Contable #: " + detCbt_I.IdCbteCble, "Anulación de Comprobante", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        //if (OGPagos_B.EliminarPagos(param.IdEmpresa, detCbt_I.IdCbteCble, detCbt_I.IdTipoCbte))
                        //{
                        //    MessageBox.Show("La liberación de las cancelaciones de pago de las ordenes de giro se Realizado Correctamente", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //    _Accion = Cl_Enumeradores.eTipo_action.grabar;
                        //    //gridControl_OrdenGiro.DataSource = OGP_B.ObtenerList(param.IdEmpresa);
                        //    loadOG_xempresa();
                        //    txt_diferencia.EditValue = txt_saldo.EditValue;
                        //    txt_SumOG.EditValue = 0;
                        //    SaldoCblDisponible = Convert.ToDecimal(txt_saldo.EditValue);
                        //}
                        //else
                        //    MessageBox.Show("No se pudo Eliminar los pagos relacionados a esta Comprobante bancario...", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtp_FechaFin_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                string MensajeError = "";
                if (e.KeyChar.ToString() == "\r")
                {
                    List<vwct_cbtecble_Con_Saldo_Info> consul = detCbt_B.Get_list_Cbtecble_Con_Saldo(param.IdEmpresa, dtp_FechaIni.Value, dtp_FechaFin.Value, ref MensajeError);
                    foreach (var item in consul)
                    {

                        item.ValorDiario = Convert.ToDouble(Math.Round(Convert.ToDecimal(item.ValorDiario), 2));
                        item.MontoOG = Convert.ToDouble(Math.Round(Convert.ToDecimal(item.MontoOG), 2));
                        item.SaldoDiario = Convert.ToDouble(Math.Round(Convert.ToDecimal(item.SaldoDiario), 2));
                    }
                    gridCbte.DataSource = consul;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_grabar_Click(object sender, EventArgs e)
        {
            try
            {
                Grabar();
            }
            catch (Exception ex)
            { Log_Error_bus.Log_Error(ex.ToString());
            MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        public void set_CbteCble(vwct_cbtecble_Con_Saldo_Info info)
        {
            try
            {
                string MensajeError = "";
                lbl_NPago.Text = "Pago de O.G. # " + info.IdCancelacion;
                List<vwct_cbtecble_Con_Saldo_Info> consul = detCbt_B.Get_list_Cbtecble_OG_otrosPagos(info.IdEmpresa, info.IdCbteCble, info.IdTipoCbte, ref MensajeError);
                foreach (var item in consul)
                {
                
                    item.ValorDiario = Convert.ToDouble(Math.Round(Convert.ToDecimal(item.ValorDiario), 2));
                    item.MontoOG = Convert.ToDouble(Math.Round(Convert.ToDecimal(item.MontoOG), 2));
                    item.SaldoDiario = Convert.ToDouble(Math.Round(Convert.ToDecimal(item.SaldoDiario), 2));    
                }
                gridCbte.DataSource = consul;
                                

                List < vwba_ordenGiroPendientes_Info > Consulta = CbtPagosOG_B.Get_List_PgCheque(info.IdEmpresa, info.IdTipoCbte, info.IdCbteCble);
                foreach (var item in Consulta)
                {
                    item.valorAPagar = Math.Round(Convert.ToDouble(item.valorAPagar), 2);
                    item.saldo = Convert.ToDouble(Math.Round(Convert.ToDecimal(item.saldo), 2));
                    item.valorAplicado = Math.Round(Convert.ToDecimal(item.valorAplicado), 2);
                }
                gridControl_OrdenGiro.DataSource = Consulta;

                detCbt_I = info;
                SaldoCblDisponible = Convert.ToDecimal(detCbt_I.SaldoDiario);
                txt_saldo.EditValue = Convert.ToDecimal(detCbt_I.ValorDiario);
                txt_SumOG.EditValue = Convert.ToDecimal(detCbt_I.MontoOG);
                txt_diferencia.EditValue = Convert.ToDecimal(detCbt_I.SaldoDiario);
                txt_NCbte.Text = detCbt_I.IdCbteCble.ToString();
                txt_tipoCbte.Text = detCbt_I.TipoCbte.ToString();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_grabarysalir_Click(object sender, EventArgs e)
        {
            try
            {
                Grabar();
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }        

        private void frmCP_OrdenGiro_CanceXOtrosMoti_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                this.event_frmCP_OrdenGiro_CanceXOtrosMoti_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCP_OrdenGiro_CanceXOtrosMoti_Load(object sender, EventArgs e)
        {
            try
            {
                this.event_frmCP_OrdenGiro_CanceXOtrosMoti_FormClosing += new delegate_frmCP_OrdenGiro_CanceXOtrosMoti_FormClosing(frmCP_OrdenGiro_CanceXOtrosMoti_event_frmCP_OrdenGiro_CanceXOtrosMoti_FormClosing);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void frmCP_OrdenGiro_CanceXOtrosMoti_event_frmCP_OrdenGiro_CanceXOtrosMoti_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                    Log_Error_bus.Log_Error(ex.ToString());
                    MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                _Accion = Cl_Enumeradores.eTipo_action.Anular;
                Grabar();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UltraGrid_OrdenGiro_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                decimal valorApli = Convert.ToDecimal(UltraGrid_OrdenGiro.GetFocusedRowCellValue(ValorAplicado));
                if (e.Column.FieldName == "valorAplicado")
                {
                    if (valorApli > Convert.ToDecimal(UltraGrid_OrdenGiro.GetFocusedRowCellValue(saldo2)))
                    {
                        UltraGrid_OrdenGiro.SetFocusedRowCellValue(ValorAplicado, Convert.ToDecimal(UltraGrid_OrdenGiro.GetFocusedRowCellValue(saldo2)));
                    }

                    UltraGrid_OrdenGiro.SetFocusedRowCellValue(saldo, Convert.ToDecimal(UltraGrid_OrdenGiro.GetFocusedRowCellValue(saldo2)) - Convert.ToDecimal(UltraGrid_OrdenGiro.GetFocusedRowCellValue(ValorAplicado)));

                    if (valorApli > 0)
                        UltraGrid_OrdenGiro.SetFocusedRowCellValue(Chek, true);
                    else
                        UltraGrid_OrdenGiro.SetFocusedRowCellValue(Chek, false);

                    SumaOG();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UltraGrid_OrdenGiro_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                if (_Accion != Cl_Enumeradores.eTipo_action.grabar)
                {
                    decimal saldos = Convert.ToDecimal(UltraGrid_OrdenGiro.GetFocusedRowCellValue(saldo2));
                    if ((bool)UltraGrid_OrdenGiro.GetFocusedRowCellValue(Chek))
                    {
                        decimal sal = Convert.ToDecimal(UltraGrid_OrdenGiro.GetFocusedRowCellValue(saldo2));
                        UltraGrid_OrdenGiro.SetFocusedRowCellValue(saldo, sal);
                        UltraGrid_OrdenGiro.SetFocusedRowCellValue(ValorAplicado, 0);

                        UltraGrid_OrdenGiro.SetFocusedRowCellValue(Chek, false);
                    }
                    else
                    {
                        UltraGrid_OrdenGiro.SetFocusedRowCellValue(Chek, true);
                        if (txt_diferencia.EditValue == null)
                        {
                            UltraGrid_OrdenGiro.SetFocusedRowCellValue(Chek, false);
                        }
                        else
                        {
                            if (saldos > Convert.ToDecimal(txt_diferencia.EditValue))
                            {
                                UltraGrid_OrdenGiro.SetFocusedRowCellValue(ValorAplicado, txt_diferencia.EditValue);
                            }
                            else
                            {
                                UltraGrid_OrdenGiro.SetFocusedRowCellValue(ValorAplicado, Convert.ToDecimal(UltraGrid_OrdenGiro.GetFocusedRowCellValue(saldo2)));
                            }

                            UltraGrid_OrdenGiro.SetFocusedRowCellValue(saldo, Convert.ToDecimal(UltraGrid_OrdenGiro.GetFocusedRowCellValue(saldo2)) - Convert.ToDecimal(UltraGrid_OrdenGiro.GetFocusedRowCellValue(ValorAplicado)));
                        }
                    }


                    SumaOG();
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void gridControl_OrdenGiro_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar.ToString() == " ")
                    UltraGrid_OrdenGiro_RowClick(sender, new DevExpress.XtraGrid.Views.Grid.RowClickEventArgs(new DevExpress.Utils.DXMouseEventArgs(new System.Windows.Forms.MouseButtons(), 0, 0, 0, 0), 0));
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                LimpiarDatos();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        void LimpiarDatos()
        {
            try
            {
                Lst_OGP_I = new List<vwba_ordenGiroPendientes_Info>();                
                gridControl_OrdenGiro.DataSource = Lst_OGP_I;
                gridCbte.DataSource = new List<vwct_cbtecble_Con_Saldo_Info>();
                detCbt_I = null;
                SaldoCblDisponible = 0;
                txt_saldo.EditValue = 0;
                txt_NCbte.Text = "";
                txt_tipoCbte.Text = "";
                lbl_NPago.Text = ".";
                sumaOG = 0;
                txt_SumOG.EditValue = 0;
                txt_diferencia.EditValue = Convert.ToDecimal(txt_saldo.EditValue) - Convert.ToDecimal(txt_SumOG.EditValue);

                btn_grabar.Enabled = true;
                btn_grabarysalir.Enabled = true;
                _Accion = Cl_Enumeradores.eTipo_action.grabar;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void gridCbte_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                    Log_Error_bus.Log_Error(ex.ToString());
                    MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
