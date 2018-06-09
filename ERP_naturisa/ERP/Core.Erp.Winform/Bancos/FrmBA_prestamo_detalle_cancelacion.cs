using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.Bancos;
using Core.Erp.Business.Bancos;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using Core.Erp.Winform.General;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.Contabilidad;

namespace Core.Erp.Winform.Bancos
{
    public partial class FrmBA_prestamo_detalle_cancelacion : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        ba_prestamo_Bus busPrestamo = new ba_prestamo_Bus();
        ba_prestamo_detalle_cancelacion_Bus bus_PrestamoCan = new ba_prestamo_detalle_cancelacion_Bus();
        ba_prestamo_detalle_Bus bus_PrestamoDet = new ba_prestamo_detalle_Bus();
        ba_prestamo_Info Info = new ba_prestamo_Info();
        BindingList<ba_prestamo_detalle_Info> BindLstPrestamo = new BindingList<ba_prestamo_detalle_Info>();
        string mensaje = "";
        List<ba_prestamo_detalle_Info> ListaDetalle = new List<ba_prestamo_detalle_Info>();
        List<ba_prestamo_detalle_Info> ListaCancTtCuota = new List<ba_prestamo_detalle_Info>();

        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        public string tipollamada = "N";
        List<ba_Cbte_Ban_Info> List_CbteBan_I = new List<ba_Cbte_Ban_Info>();
        string cod_CbteCble = "";
        ba_prestamo_detalle_Bus busPrestamoDetalle = new ba_prestamo_detalle_Bus();
        List<ct_Cbtecble_Info> List_CbteCble_I = new List<ct_Cbtecble_Info>();
        ba_prestamo_detalle_Info Info_DetPrest;
        List<ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Info> listParaBan = new List<ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Info>();
        ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Bus paramBa_B = new ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Bus();
        ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Info paramBa_I = new ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Info();
        int _IdTipoCbte_ND = 0;

        ct_Periodo_Info Per_I = new ct_Periodo_Info();
        ct_Periodo_Bus Per_B = new ct_Periodo_Bus();

        public FrmBA_prestamo_detalle_cancelacion()
        {
            InitializeComponent();

        }
       
        private void FrmBA_prestamo_detalle_cancelacion_Load(object sender, EventArgs e)
        {
            try
            {
                if (tipollamada == "Anular")
                    { btnAnular.Visible = true; btn_guardar.Enabled = false; btnGuardarSalir.Enabled = false;
                    gridViewCancelacion.OptionsBehavior.Editable = false;
                    }
                    if (tipollamada == "Editar")
                    {
                        colCheck.OptionsColumn.AllowEdit = false;
                        colCheck.OptionsColumn.ReadOnly = false;
                        repositoryItemCheckEdit1.ReadOnly = false;
                    }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void GET_Editar_o_Anular(ba_prestamo_detalle_Info info)
        {
            try
            {
                
                BindLstPrestamo = new BindingList<ba_prestamo_detalle_Info>();
                BindLstPrestamo.Add(info);
                gridControlCancelacion.DataSource = BindLstPrestamo;
                colMonto_Canc.OptionsColumn.AllowEdit = false;
                colMonto_Canc.Caption = "Monto Cancelado";
                if (tipollamada == "Editar")
                    lblEtiq.Text = "- Solo es editable la fecha y observación.";

                if(tipollamada == "Anular")
                    if (info.Monto_x_Canc == 0)
                    {   
                        lblAnulado.Visible = true; MessageBox.Show("El pago ya se encuentra anulado."); btnAnular.Enabled = false;
                                           
                    }
                if (tipollamada == "Editar")
                    if (info.Monto_x_Canc == 0)
                    { lblAnulado.Visible = true; MessageBox.Show("No se puede editar un pago anulado."); btn_guardar.Enabled = false; btnGuardarSalir.Enabled = false; }
                                        
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString()); 
            }
        }

        private Boolean GetInfo()
        {
            Boolean res = false;
            try
            {
                ListaDetalle = BindLstPrestamo.ToList();
                ListaDetalle = ListaDetalle.FindAll(var => var.Check == true && var.Monto_x_Canc > 0);
                if (ListaDetalle.Count == 0)
                { MessageBox.Show("Seleccione correctamente una cuota para poder grabar.", param.Nombre_sistema); return false; }
                foreach (var item in ListaDetalle)
                {
                    item.IdEmpresa = param.IdEmpresa;
                    item.IdUsuario = param.IdUsuario;
                    item.Fecha_Transac = param.Fecha_Transac;
                    item.Saldo = Convert.ToDouble(item.TotalCuota) -Convert.ToDouble (item.Monto_Canc )-Convert.ToDouble(item.Monto_x_Canc);
                    item.Saldo = Convert.ToDouble( Math.Round(Convert.ToDecimal(item.Saldo), 2));
                    item.Monto_Canc = Convert.ToDouble( Math.Round(Convert.ToDecimal(item.Monto_Canc), 2));
                    item.Monto_x_Canc = Convert.ToDouble( Math.Round(Convert.ToDecimal( item.Monto_x_Canc), 2));
                    item.ip = param.ip;
                    item.nom_pc = param.nom_pc;
                    if (item.Saldo_Canc == 0)
                        ListaCancTtCuota.Add(item);

                }
                res = true;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
            return res;        
        }

        public Boolean validaColumna()
        {
            try
            {
                string MensajeError = "";
                Boolean estado = true;
                Per_I = Per_B.Get_Info_Periodo(param.IdEmpresa, param.Fecha_Transac, ref MensajeError);

                if (Per_I.pe_cerrado == "S")
                {
                    MessageBox.Show("No se procedio a Grabar porque el Periodo se encuentra cerrado ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    estado = false;
                    return estado;
                }           
                return true;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
        }


        void get_Cbtecble()
        {
            try
            {
                ListaDetalle = BindLstPrestamo.ToList();
                ListaDetalle = ListaDetalle.FindAll(var => var.Check == true && var.Monto_x_Canc > 0);
                if (ListaDetalle.Count != 0)
                {
                    foreach (var item in ListaDetalle)
                    {
                         ct_Cbtecble_Info CbteCble_I = new ct_Cbtecble_Info();

                         CbteCble_I.IdEmpresa = param.IdEmpresa;
                         CbteCble_I.IdTipoCbte = _IdTipoCbte_ND;
                         CbteCble_I.IdPeriodo = Per_I.IdPeriodo;
                         CbteCble_I.cb_Fecha = param.Fecha_Transac;  //duda
                         CbteCble_I.cb_Valor = Convert.ToDouble(item.Monto_x_Canc);
                         CbteCble_I.cb_Observacion = "Nota de Débtio de la Cuota#: " + item.NumCuota + " ,del Préstamo#: " + item.IdPrestamo + " y Valor: " + item.Monto_x_Canc;
                         CbteCble_I.Secuencia = 0;
                         CbteCble_I.Estado = "A";
                         CbteCble_I.Anio = param.Fecha_Transac.Year;
                         CbteCble_I.Mes = param.Fecha_Transac.Month;
                         CbteCble_I.IdUsuario = param.IdUsuario;

                         CbteCble_I.cb_FechaTransac = param.Fecha_Transac;

                         CbteCble_I.Mayorizado = "N";

                        //Detalle Diario
                        //Debe
                         ct_Cbtecble_det_Info debe = new ct_Cbtecble_det_Info();
                         debe.IdEmpresa = param.IdEmpresa;
                         debe.IdTipoCbte = _IdTipoCbte_ND;
                         debe.IdCtaCble = "";                    //duda
                         debe.dc_Observacion = "Nota de Débtio de la Cuota#: " + item.NumCuota + " ,del Préstamo#: " + item.IdPrestamo + " y Valor: " + item.Monto_x_Canc;
                         debe.dc_Valor = Convert.ToDouble(item.Monto_x_Canc);
                         CbteCble_I._cbteCble_det_lista_info.Add(debe);

                        //Haber
                         ct_Cbtecble_det_Info Haber = new ct_Cbtecble_det_Info();
                         Haber.IdEmpresa = param.IdEmpresa;
                         Haber.IdTipoCbte = _IdTipoCbte_ND;                      
                         Haber.IdCtaCble = "";                 //duda
                         Haber.dc_Observacion = "Nota de Débtio de la Cuota#: " + item.NumCuota + " ,del Préstamo#: " + item.IdPrestamo + " y Valor: " + item.Monto_x_Canc;
                         Haber.dc_Valor = Convert.ToDouble(item.Monto_x_Canc) * -1;
                         CbteCble_I._cbteCble_det_lista_info.Add(Haber);


                         List_CbteCble_I.Add(CbteCble_I);

                         item.Lista_CbteCble = List_CbteCble_I;
                    }              
                }              
             
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }




        void get_CbteBan_ND()
        {
            try
            {
                ListaDetalle = BindLstPrestamo.ToList();
                ListaDetalle = ListaDetalle.FindAll(var => var.Check == true && var.Monto_x_Canc > 0);
                if (ListaDetalle.Count != 0)
                {

                    foreach (var item in ListaDetalle)
                    {

                        ba_Cbte_Ban_Info CbteBan_I = new ba_Cbte_Ban_Info();
                        
                        CbteBan_I.IdEmpresa = param.IdEmpresa;
                        CbteBan_I.IdTipocbte = _IdTipoCbte_ND;
                        //  CbteBan_I.IdCbteCble = Convert.ToDecimal(txt_Ncomprobante.Text);
                        CbteBan_I.Cod_Cbtecble = (CbteBan_I.Cod_Cbtecble == "" || CbteBan_I.Cod_Cbtecble == null || CbteBan_I.Cod_Cbtecble == "0") ? cod_CbteCble : CbteBan_I.Cod_Cbtecble;
                        CbteBan_I.IdPeriodo = Per_I.IdPeriodo;

                        //if (IdBanco == 0)
                        //    CbteBan_I.IdBanco = this.ucBa_CuentaBanco.get_BaCuentaInfo().IdBanco;
                        //else
                        //    CbteBan_I.IdBanco = IdBanco;

                        CbteBan_I.cb_Fecha = param.Fecha_Transac;   //duda

                        // CbteBan_I.IdTipoNota = ucbA_TipoNota.get_TipoNotaInfo().IdTipoNota;
                        CbteBan_I.cb_Observacion = "Nota de Débtio de la Cuota#: " + item.NumCuota + " ,del Préstamo#: " + item.IdPrestamo + " y Valor: " + item.Monto_x_Canc;
                        CbteBan_I.cb_secuencia = (CbteBan_I.cb_secuencia == 0) ? 0 : CbteBan_I.cb_secuencia;
                        CbteBan_I.cb_Valor = Convert.ToDouble(item.Monto_x_Canc);
                        CbteBan_I.Estado = "A";
                        CbteBan_I.IdUsuario = param.IdUsuario;
                        CbteBan_I.Fecha_Transac = param.Fecha_Transac;

                        CbteBan_I.cb_ChequeImpreso = "N";
                        CbteBan_I.ip = param.ip;
                        CbteBan_I.nom_pc = param.nom_pc;

                        List_CbteBan_I.Add(CbteBan_I);

                        item.Lista_CbteBan = List_CbteBan_I;
                    }                                       
                }
                
               // return CbteBan_I;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }


        private Boolean grabar()
        {
            textEdit1.Focus();
            Boolean res = false;
            try
            {
                get_Cbtecble();
                get_CbteBan_ND();
                
                if (GetInfo())
                {
                    if (tipollamada == "Editar")
                    {
                        if (bus_PrestamoCan.ActualizarDetallePrestamosCancelados(ListaDetalle[0], ref mensaje))
                        {
                            MessageBox.Show("Se ha procedido a actualizar exitosamente.", param.Nombre_sistema);
                            btn_guardar.Enabled = false;
                            btnGuardarSalir.Enabled = false; res = true;
                        }
                    }
                    else
                    {
                        if (bus_PrestamoCan.GuardarDetallePrestamosCancelados(ListaDetalle, ref mensaje))
                        {
                            foreach (var item in ListaCancTtCuota)
                            {
                                if (!busPrestamoDetalle.CancelarEstadoDetallePrestamo(item, ref mensaje))
                                    return false;
                            }
                            SetInfo(Info);
                            btn_guardar.Enabled = false;
                            btnGuardarSalir.Enabled = false;

                            MessageBox.Show(Core.Erp.Recursos.Properties.Resources.msgDespues_Grabar, param.Nombre_sistema);                        
                            //MessageBox.Show("Se ha procedido a grabar exitosamente.", param.Nombre_sistema);
                            res = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
            return res;
         }

    
        public void SetInfo(ba_prestamo_Info info)
        {
            try
            {
                Info = info;


                lblIdPrestamo.Text = info.IdPrestamo.ToString();
                txtCodPrestamo.Text = info.CodPrestamo;
                txtBanco.Text = info.NomBanco;
                txtCalculo.Text = info.MetodoCalculo;
                txtMotivo.Text = info.NomMotivo_Prestamo;
                txtObservacion.Text = info.Observacion;
                
                info.lista_detalle = bus_PrestamoDet.Get_List_DetallePrestamosxCancelar(Info, ref mensaje);
                BindLstPrestamo = new BindingList<ba_prestamo_detalle_Info>(info.lista_detalle.Where(v=>v.Monto_Canc==0).ToList());
                gridControlCancelacion.DataSource = BindLstPrestamo;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void CalcularSaldo()
        {
            try
            {
                double SaldoP = 0;
                double MontoCanc = 0;
                foreach (var item in BindLstPrestamo)
                {
                    if (item.Check == true)
                    {
                        SaldoP = SaldoP + Convert.ToDouble( item.Saldo_Canc);
                        MontoCanc = MontoCanc + Convert.ToDouble(item.Monto_Canc);
                    }
                }

                //txtMontCanc.Text = MontoCanc.ToString();
                //txtSdoPend.Text = SaldoP.ToString();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }


        }
        
        private void gridViewCancelacion_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                
                //e.HitInfo.Column.FieldName = gridViewCancelacion.FocusedColumn.FieldName;
                
                //if (tipollamada != "Editar" && tipollamada != "Anular")
                //{
                //    if (e.HitInfo.Column.FieldName == "Check")
                //    {
                //        //var row = (ba_prestamo_detalle_Info)gridViewCancelacion.GetFocusedRow();
                //        //if (row.Check == false)
                //        //{
                //        //    gridViewCancelacion.SetFocusedRowCellValue("Monto_x_Canc", row.TotalCuota - row.Monto_Canc);
                //        //    gridViewCancelacion.SetFocusedRowCellValue("Saldo_Canc", 0);
                //        //    gridViewCancelacion.SetFocusedRowCellValue("Check", true);
                //        //}
                //        //else if (row.Check == true)
                //        //{

                //        //    gridViewCancelacion.SetFocusedRowCellValue("Saldo_Canc", row.TotalCuota - row.Monto_Canc);
                //        //    gridViewCancelacion.SetFocusedRowCellValue("Monto_x_Canc", 0);
                //        //    gridViewCancelacion.SetFocusedRowCellValue("Check", false);
                //        //}
                //        //CalcularSaldo();
                //        if ((bool)gridViewCancelacion.GetFocusedRowCellValue(colCheck))
                //        {
                //            gridViewCancelacion.SetFocusedRowCellValue(colCheck, false);
                //        }

                //        else
                //        {
                //            gridViewCancelacion.SetFocusedRowCellValue(colCheck, true);


                //        }

                //    }
                //}
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void gridViewCancelacion_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                //if (e.Column.FieldName == "Monto_x_Canc")
                //{
                //    if (Convert.ToDouble(e.Value) != 0)
                //    {
                //        var row = (ba_prestamo_detalle_Info)gridViewCancelacion.GetFocusedRow();
                //        if (row != null)
                //        {
                //            if (row.Monto_x_Canc > (row.TotalCuota ))// - Convert.ToDouble(e.Value)))
                //            {
                //                MessageBox.Show("El Monto a cancelar no puede ser mayor que el Saldo Pendiente",param.Nombre_sistema);

                //                gridViewCancelacion.SetFocusedRowCellValue("Monto_x_Canc", row.TotalCuota - row.Monto_Canc);
                //                gridViewCancelacion.SetFocusedRowCellValue("Saldo_Canc", 0);
                //                gridViewCancelacion.SetFocusedRowCellValue("Check", true);
                //                CalcularSaldo();
                //            }
                //            else
                //            {
                //                //gridViewCancelacion.SetFocusedRowCellValue("Monto_x_Canc", ); 
                //                //saldo pendiente
                //                gridViewCancelacion.SetFocusedRowCellValue("Saldo_Canc", row.TotalCuota - row.Monto_Canc - row.Monto_x_Canc);
                //                gridViewCancelacion.SetFocusedRowCellValue("Check", true);
                //                CalcularSaldo();
                //            }
                //        }
                //    }
                //}

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                FrmBA_Cancelacion_Cuotas frm = new FrmBA_Cancelacion_Cuotas();

                Info_DetPrest = BindLstPrestamo.FirstOrDefault(q=>q.Check==true);
                if (Info_DetPrest == null)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_un_registro),param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                         
                frm.Info_DetPrestamo = Info_DetPrest;
                frm.ShowDialog();

               
               
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }


        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                gridViewCancelacion.OptionsPrint.PrintHorzLines = true;
                //gridViewCancelacion.OptionsPrint.
                gridViewCancelacion.OptionsView.ShowViewCaption = true;
                gridViewCancelacion.ViewCaption = "Cuotas Pendientes de Pago del Préstamo Cód :" + Info.CodPrestamo +
                    " Id# " + Info.IdPrestamo + "al Banco " + Info.NomBanco + " a la fecha: " +DateTime.Now.ToShortDateString();
                gridControlCancelacion.ShowPrintPreview();
                gridViewCancelacion.OptionsView.ShowViewCaption = false;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
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
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        void anular()
        {
            try
            {
                if (GetInfo())
                {
                    if (lblAnulado.Visible == true)
                    { MessageBox.Show("No se procederá porque el pago ya se encuentra anulado."); return; }
                    else
                    {
                        if (MessageBox.Show("¿Está seguro que desea anular el pago de la cuota: " + Info.CodPrestamo + " ?", "Anulación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            FrmGe_MotivoAnulacion oFrm = new FrmGe_MotivoAnulacion();
                    
                            string msg = "";
                            oFrm.ShowDialog();

                            ListaDetalle[0].MotiAnula = oFrm.motivoAnulacion;
                            ListaDetalle[0].IdUsuarioUltAnu = param.IdUsuario;
                            ListaDetalle[0].Fecha_UltAnu = param.Fecha_Transac;

                            if (bus_PrestamoCan.AnularDetallePrestamosCancelados(ListaDetalle[0], ref mensaje))
                            {
                                ListaDetalle[0].EstadoPago = "PEN";
                                if (busPrestamoDetalle.ReversaEstadoCanc(ListaDetalle[0], ref mensaje))
                                {
                                    MessageBox.Show(Core.Erp.Recursos.Properties.Resources.msgConfirmaAnulacionOk,param.Nombre_sistema);
                                    btnAnular.Enabled = false;
                                }
                                else MessageBox.Show("Ha ocurrido un error." + mensaje + " \r Comuniquese con Sistemas.", param.Nombre_sistema);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
               anular(); 
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }


        private void gridViewCancelacion_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
               
                ba_prestamo_detalle_Info Info_DetPrest = (ba_prestamo_detalle_Info)gridViewCancelacion.GetFocusedRow();

                if (Info_DetPrest != null)

                    e.HitInfo.Column.FieldName = gridViewCancelacion.FocusedColumn.FieldName;

                if (e.HitInfo.Column.FieldName == "Check")
                {

                    if ((bool)gridViewCancelacion.GetFocusedRowCellValue(colCheck))
                    {
                        gridViewCancelacion.SetFocusedRowCellValue(colCheck, false);

                    }

                    else
                    {
                        foreach (var item in BindLstPrestamo)
                        {
                            if (item.chek_aux == 1)
                            {
                                item.Check = false;
                                item.chek_aux = 0;

                            }

                        }

                        gridControlCancelacion.RefreshDataSource();

                        gridViewCancelacion.SetFocusedRowCellValue(colCheck, true);
                        gridViewCancelacion.SetFocusedRowCellValue(colchek_aux, 1);

                    }
                }


            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }


        public void load_datos()
        {
            try
            {
                gridControlCancelacion.DataSource = BindLstPrestamo;


                listParaBan = paramBa_B.Get_List_Banco_Parametros(param.IdEmpresa);
                paramBa_I = listParaBan.Find(delegate(ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Info P) { return P.CodTipoCbteBan == "NDBA"; });


                if (paramBa_I == null)
                {
                    MessageBox.Show("No puede continuar porque no han ingresado los parámetros de banco.. Ingréselos desde la pantalla de parámetros de banco", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
                else
                {
                    if (paramBa_I.IdCtaCble == null || paramBa_I.IdCtaCble == "" || paramBa_I.IdTipoCbteCble == null || paramBa_I.IdTipoCbteCble < 1 || paramBa_I.IdTipoCbteCble_Anu == null || paramBa_I.IdTipoCbteCble_Anu < 1)
                    {
                        MessageBox.Show("No puede continuar porque están incompletos los parámetros de banco.. Ingréselos desde la pantalla de parámetros de banco", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                    }
                }

                _IdTipoCbte_ND = paramBa_I.IdTipoCbteCble;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
            
       
        }
    }
}
