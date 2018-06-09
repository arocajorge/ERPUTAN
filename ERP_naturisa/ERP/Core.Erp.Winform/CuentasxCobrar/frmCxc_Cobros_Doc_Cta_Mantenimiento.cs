using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.General;
using Core.Erp.Info.CuentasxCobrar;
using Core.Erp.Business.CuentasxCobrar;
using Core.Erp.Business.General;
using Core.Erp.Business.Facturacion;
using Core.Erp.Business.Caja;
using Core.Erp.Info.Caja;
///Prog: Catherine Jimenez
///11:14 22/02/2014
///
//V26022014 CJ
namespace Core.Erp.Winform.CuentasxCobrar
{
    public partial class frmCxc_Cobros_Doc_Cta_Mantenimiento : Form
    {

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        vwcxc_cobro_x_documentos_x_cobrar_Info InfoVista = new vwcxc_cobro_x_documentos_x_cobrar_Info();
        private cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        cxc_cobro_tipo_Bus cobroTipoBus = new cxc_cobro_tipo_Bus();
        tb_banco_Bus bancoBus = new tb_banco_Bus();
        BindingList<cxc_cobro_Info> lstCobro;
        cxc_cobro_Bus cobroBus = new cxc_cobro_Bus();
        cxc_cobro_Info row = new cxc_cobro_Info();
        public Cl_Enumeradores.eTipo_action _Accion { get; set; }
        List<caj_Caja_Info> listaCaja = new List<caj_Caja_Info>();
        caj_Caja_Bus cajaBus = new caj_Caja_Bus();
        BindingList<cxc_cobro_Info> lstCobroNew = new BindingList<cxc_cobro_Info>();
        cxc_cobro_tipo_x_cobros_Docxc_Bus cobroTipoDocBus = new cxc_cobro_tipo_x_cobros_Docxc_Bus();
        string MensajeError = "";

        public frmCxc_Cobros_Doc_Cta_Mantenimiento()
        {
            try
            {
                InitializeComponent();
                tb_tarjeta_Bus Bus_tarjeta = new tb_tarjeta_Bus();
                List<tb_tarjeta_Info> Info_tarjeta = new List<tb_tarjeta_Info>();
                Info_tarjeta = Bus_tarjeta.Get_List_tarjeta();
                this.cmbTarjeta.DataSource = Info_tarjeta;
                listaCaja = cajaBus.Get_list_caja(param.IdEmpresa, ref  MensajeError);
                this.cmbCaja.Properties.DataSource = listaCaja;
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private Boolean validar()
        {
            try
            {
                if (this.cmbCaja.EditValue == "" || this.cmbCaja.EditValue == null)
                {
                    MessageBox.Show("Ingrese la caja. Por favor", "Sistemas");
                    return false;
                }

                if (!param.Validar_periodo_cerrado_x_modulo(param.IdEmpresa, Cl_Enumeradores.eModulos.CXC, Convert.ToDateTime(dtFechaFactura.EditValue)))
                    return false;

                if (!param.Validar_periodo_cerrado_x_modulo(param.IdEmpresa, Cl_Enumeradores.eModulos.CXC, Convert.ToDateTime(dtFechaCobro.EditValue)))
                    return false;

                if (!param.Validar_periodo_cerrado_x_modulo(param.IdEmpresa, Cl_Enumeradores.eModulos.CXC, Convert.ToDateTime(dtFechaCreacion.EditValue)))
                    return false;

                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }


        }

        /// <summary>
        /// Establece el Info de tipo vista vwcxc_cobro_x_documentos_x_cobrar_Info
        /// </summary>
        /// <param name="InfoVista"></param>
        public void setInfoVista(vwcxc_cobro_x_documentos_x_cobrar_Info InfoVista)
        {
            try
            {
                this.InfoVista = InfoVista;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void setInfo()
        {
            try
            {
                txtSucursal.Text = InfoVista.Sucursal;
                lbl_IdBodega.Text = InfoVista.IdSucursal.ToString();
                txtBodega.Text = InfoVista.Bodega;
                txtIdCobro.Text = InfoVista.IdCobro.ToString();
                dtFechaCreacion.EditValue = InfoVista.cr_fecha;
                dtFechaCobro.EditValue = InfoVista.cr_fechaCobro;
                txtTipoDoc.Text = InfoVista.TipoCobro;
                txtNDoc.Text = InfoVista.NumDocumento;
                txtDoc.Text = InfoVista.Documento_Aplicado;
                txtCliente.Text = InfoVista.Cliente;
                txeSaldo.EditValue = Convert.ToDouble(InfoVista.saldo);
                txeTotal.EditValue = Convert.ToDouble(InfoVista.Total_Doc_vta);
                txtSubtotal.Text = InfoVista.SubTotal_Doc_vta.ToString();
                txtIva.Text = InfoVista.Iva_Doc_vta.ToString();
                dtFechaFactura.EditValue = InfoVista.Fecha_vta;
                txeTotalDoc.EditValue = Convert.ToDouble(InfoVista.cr_TotalCobro);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void frmCxc_Cobros_Doc_Cta_Mantenimiento_Load(object sender, EventArgs e)
        {
            try
            {
                setInfo();
                load();
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
        private void load()
        {
            try
            {
                repositoryTipoCobro.DataSource = cobroTipoDocBus.ObtenerListaDescripcion();
                repositoryItemGridLookUpEditBanco.DataSource = bancoBus.Get_List_Banco();
                lstCobro = new BindingList<cxc_cobro_Info>(cobroBus.Get_List_cobro_x_Factura_x_DocxCobrar(param.IdEmpresa, InfoVista.IdSucursal, Convert.ToInt32(InfoVista.IdBodega_Cbte_doc_aplica), InfoVista.IdCble_vta_nota,InfoVista.TipoDoc_Aplicado,InfoVista.IdCobro));
                griddetalle.DataSource = lstCobro;
                repositorydc_ValorPago_ParseEditValue(new object(), new DevExpress.XtraEditors.Controls.ConvertEditValueEventArgs());
                if (_Accion == Cl_Enumeradores.eTipo_action.consultar)
                {
                    gridView_detalle.OptionsBehavior.Editable = false;
                    cmbCaja.Enabled = false;
                    cmbCaja.BackColor = Color.White;
                    cmbCaja.ForeColor = Color.Black;
                    gridView_NCND.OptionsBehavior.Editable = false;
                    btnGuardar.Visible = false;
                    btnGuardarSalir.Visible = false;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());               
            }
        }

        private void mnu_salir_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Guardar();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void gridView_detalle_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                
                var Item = (cxc_cobro_Info)gridView_detalle.GetRow(e.FocusedRowHandle);

                if (Item.IdCobro == 0)
                {
                    colIdCobro_tipo.OptionsColumn.AllowEdit = true;
                    colcr_Banco.OptionsColumn.AllowEdit = true;
                    colcr_cuenta.OptionsColumn.AllowEdit = true;
                    colcr_NumDocumento.OptionsColumn.AllowEdit = true;
                    colcr_Valor.OptionsColumn.AllowEdit = true;
                    colcr_fechaCobro.OptionsColumn.AllowEdit = true;
                    colcr_fechaDocu.OptionsColumn.AllowEdit = true;
                    colcr_observacion.OptionsColumn.AllowEdit = true;
                }
                else
                {
                    colIdCobro_tipo.OptionsColumn.AllowEdit = false;
                    colcr_Banco.OptionsColumn.AllowEdit = false;
                    colcr_cuenta.OptionsColumn.AllowEdit = false;
                    colcr_NumDocumento.OptionsColumn.AllowEdit = false;
                    colcr_Valor.OptionsColumn.AllowEdit = false;
                    colcr_fechaCobro.OptionsColumn.AllowEdit = false;
                    colcr_fechaDocu.OptionsColumn.AllowEdit = false;
                    colcr_observacion.OptionsColumn.AllowEdit = false;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                colIdCobro_tipo.OptionsColumn.AllowEdit = true;
                colcr_Banco.OptionsColumn.AllowEdit = true;
                colcr_cuenta.OptionsColumn.AllowEdit = true;
                colcr_NumDocumento.OptionsColumn.AllowEdit = true;
                colcr_Valor.OptionsColumn.AllowEdit = true;
                colcr_fechaCobro.OptionsColumn.AllowEdit = true;
                colcr_fechaDocu.OptionsColumn.AllowEdit = true;
                colcr_observacion.OptionsColumn.AllowEdit = true;
            }
        }

        private void gridView_detalle_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            try
            {
                gridView_detalle.SetFocusedRowCellValue(colcr_fechaCobro, DateTime.Now);
                gridView_detalle.SetFocusedRowCellValue(colcr_fechaDocu, DateTime.Now);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void Grabar()
        {
            try
            {
                // List<cxc_cobro_Info> listax = new List<cxc_cobro_Info>();
                //BindingList<cxc_cobro_Info> lista_Cobro = new BindingList<cxc_cobro_Info>();
                get_Cobro();
                List<cxc_cobro_Info> rLst1 = new List<cxc_cobro_Info>();
                cxc_cobro_Det_Info lista_det;
                if (lstCobroNew.Count() == 0)
                {
                    // MessageBox.Show("No se pudo Ingresar los Cobros", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                else
                {
                    cxc_cobro_Info Info_CobroNew;
                    foreach (var item in lstCobroNew)
                    {
                        Info_CobroNew = new cxc_cobro_Info();

                        Info_CobroNew.IdEmpresa = item.IdEmpresa;
                        Info_CobroNew.IdSucursal = item.IdSucursal;
                        Info_CobroNew.IdCliente = item.IdCliente;
                        // Info_Cobro.cr_TotalCobro = item.cr_TotalCobro;
                        Info_CobroNew.cr_TotalCobro = item.dc_ValorPago;
                        Info_CobroNew.cr_Banco = item.cr_Banco;

                        Info_CobroNew.cr_Tarjeta = item.cr_Tarjeta;

                        Info_CobroNew.IdCobro_a_aplicar = item.IdCobro_a_aplicar;
                        Info_CobroNew.cr_observacion = item.cr_observacion;
                        Info_CobroNew.IdCobro_tipo = item.IdCobro_tipo;
                        Info_CobroNew.cr_Banco = item.cr_Banco;
                        Info_CobroNew.cr_fechaDocu = Convert.ToDateTime(item.cr_fechaDocu.ToShortDateString());
                        Info_CobroNew.cr_fecha = Convert.ToDateTime(item.cr_fecha.ToShortDateString());
                        Info_CobroNew.cr_fechaCobro = Convert.ToDateTime(item.cr_fechaCobro.ToShortDateString());
                        Info_CobroNew.cr_cuenta = item.cr_cuenta;
                        Info_CobroNew.cr_NumDocumento = item.cr_NumDocumento;
                        Info_CobroNew.dc_ValorPago = item.dc_ValorPago;
                        Info_CobroNew.dc_TipoDocumento = item.dc_TipoDocumento;
                        Info_CobroNew.IdCbte_vta_nota = item.IdCbte_vta_nota;
                        Info_CobroNew.IdEmpresa = item.IdEmpresa;
                        Info_CobroNew.secuencial = 1;
                        Info_CobroNew.nom_pc = item.nom_pc;
                        Info_CobroNew.ip = item.ip;
                        Info_CobroNew.Fecha_Transac = Convert.ToDateTime(DateTime.Now);
                        Info_CobroNew.IdUsuario = item.IdUsuario;
                        Info_CobroNew.IdBodega_Cbte = item.IdBodega_Cbte;

                        Info_CobroNew.IdCaja = item.IdCaja;

                        lista_det = new cxc_cobro_Det_Info();

                        lista_det.IdEmpresa = Info_CobroNew.IdEmpresa;
                        lista_det.IdEmpresa = item.IdEmpresa;
                        lista_det.IdSucursal = Info_CobroNew.IdSucursal;
                        lista_det.IdCobro = Info_CobroNew.IdCobro;
                        lista_det.secuencial = Info_CobroNew.secuencial;
                        lista_det.dc_TipoDocumento = Info_CobroNew.dc_TipoDocumento;
                        lista_det.IdBodega_Cbte = Info_CobroNew.IdBodega_Cbte;
                        lista_det.IdCbte_vta_nota = Info_CobroNew.IdCbte_vta_nota;
                        lista_det.dc_ValorPago = Info_CobroNew.dc_ValorPago;
                        lista_det.IdUsuario = Info_CobroNew.IdUsuario;

                        lista_det.Fecha_Transac = Convert.ToDateTime(DateTime.Now);
                        lista_det.nom_pc = Info_CobroNew.nom_pc;
                        lista_det.ip = Info_CobroNew.ip;


                        Info_CobroNew.ListaCobro = new List<cxc_cobro_Det_Info>();

                        Info_CobroNew.ListaCobro.Add(lista_det);

                        string MsgError = "";
                        if (cobroBus.GuardarDB(Cl_Enumeradores.PantallaEjecucion.COBROS, ref Info_CobroNew, ref MsgError))
                        {
                            //lista_Cobro.Add(Info_CobroNew);
                        }
                        else
                        {
                            //MessageBox.Show("No se pudo Ingresar los Cobros", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);                 
                        }

                    }

                    btnGuardar.Enabled = false;
                    btnGuardarSalir.Enabled = false;
                    MessageBox.Show("Cobros Ingresados correctamente", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //lista = new BindingList<cxc_cobro_x_caj_Caja_Movimiento_Info>();

                    //lst = new BindingList<cxc_cobro_Info>(lista_Cobro);

                    //this.gridControl_NCND.DataSource = carga_grid_caj_Movimiento(lst, lista);

                    //vwcxc_cartera_x_cobrar_Info cartera = new vwcxc_cartera_x_cobrar_Info();
                    //cartera = cartera_B.ConsultaInfo(cartera_I.IdEmpresa, cartera_I.IdSucursal, cartera_I.IdBodega, cartera_I.IdComprobante);
                    //txt_saldo.Value = Convert.ToDecimal(cartera.Saldo);
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void Guardar()
        {
            try
            {
                if(validar())
                {
                    if (validaciones())
                    {
                        Grabar();
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());                
            }
        }

        private Boolean validaciones()
        {
            try
            {

                foreach (var item in lstCobro)
                {
                    if (item.IdCobro_tipo == null)
                    {
                        MessageBox.Show("Ingrese el tipo de pago ", "Sistemas");
                        return false;
                    }
                }
                return true;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }

        }

        public void get_Cobro()
        {
            txtBodega.Focus();

            cxc_cobro_Info _Info;
            try
            {
                foreach (var item in lstCobro)
                {
                    if (item.IdEmpresa == 0)
                    {
                        _Info = new cxc_cobro_Info();

                        _Info.IdEmpresa = param.IdEmpresa;
                        _Info.IdSucursal = InfoVista.IdSucursal;
                        _Info.IdCliente = InfoVista.IdCliente;
                        _Info.IdCobro_a_aplicar = InfoVista.IdCobro;
                        _Info.cr_TotalCobro = item.dc_ValorPago;
                        _Info.cr_Banco = item.cr_Banco;
                        _Info.cr_Tarjeta = item.cr_Tarjeta;
                        
                        _Info.cr_observacion = item.cr_observacion + " Doc"+InfoVista.IdCobro+" " + InfoVista.Documento_Aplicado + " " + InfoVista.TipoCobro;
                        _Info.IdCobro_tipo = item.IdCobro_tipo;
                        _Info.cr_Banco = item.cr_Banco;
                        _Info.cr_fechaDocu = Convert.ToDateTime(item.cr_fechaDocu.ToShortDateString());
                        _Info.cr_fecha = Convert.ToDateTime(item.cr_fechaDocu.ToShortDateString());
                        _Info.cr_fechaCobro = Convert.ToDateTime(item.cr_fechaCobro.ToShortDateString());
                        _Info.cr_cuenta = item.cr_cuenta;
                        _Info.cr_NumDocumento = item.cr_NumDocumento;
                        _Info.dc_ValorPago = item.dc_ValorPago;
                        _Info.dc_TipoDocumento = InfoVista.TipoDoc_Aplicado;
                        _Info.IdCbte_vta_nota = InfoVista.IdCble_vta_nota;
                        _Info.secuencial = 1;
                        _Info.nom_pc = param.nom_pc;
                        _Info.ip = param.ip;
                        _Info.Fecha_Transac = DateTime.Now;
                        _Info.IdUsuario = param.IdUsuario;
                        _Info.IdBodega_Cbte = Convert.ToInt32(lbl_IdBodega.Text);
                        _Info.IdCaja = Convert.ToInt32(this.cmbCaja.EditValue);

                        lstCobroNew.Add(_Info);
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void gridView_detalle_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {   
                if (e.RowHandle == gridView_detalle.FocusedRowHandle)
                {
                    e.Appearance.BackColor = Color.AliceBlue;
                }
                else
                {
                    var data = gridView_detalle.GetRow(e.RowHandle) as cxc_cobro_Info;
                    if (data == null)
                        return;
                    if (data.IdCobro > 0)
                        e.Appearance.BackColor = Color.GhostWhite;
                    if (data.cr_estado == "I")
                        e.Appearance.ForeColor = Color.Red;

                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
        cxc_cobro_tipo_Param_conta_x_sucursal_Bus bus = new cxc_cobro_tipo_Param_conta_x_sucursal_Bus();
       

        private void repositorydc_ValorPago_ParseEditValue(object sender, DevExpress.XtraEditors.Controls.ConvertEditValueEventArgs e)
        {
            try
            {
                this.txtSubtotal.Focus();

                row = (cxc_cobro_Info)gridView_detalle.GetRow(gridView_detalle.FocusedRowHandle);
                double sumEFEC = 0;
                double sumDEPO = 0;
                double sumCXC = 0;
                double sumCHQF = 0;
                double sumOTROS = 0;
                double sumCHQV_TARJ = 0;


                if (row.IdCobro_tipo == "" || row.IdCobro_tipo == null)
                {
                    MessageBox.Show("Seleccione primero el tipo de cobro", "Sistemas");
                    gridView_detalle.DeleteRow(gridView_detalle.FocusedRowHandle);
                }

                else
                {

                    //   foreach (var item in lst)
                    foreach (var item in lstCobro)
                    {

                        string caseSwitch = item.IdCobro_tipo;
                        switch (caseSwitch)
                        {
                            case "EFEC":
                                sumEFEC = sumEFEC + item.dc_ValorPago;
                                this.txtEfectivo.EditValue = sumEFEC;
                                break;
                            case "DEPO":
                                sumDEPO = sumDEPO + item.dc_ValorPago;
                                this.txtDeposito.EditValue = sumDEPO;
                                break;
                            case "CXC":
                                sumCXC = sumCXC + item.dc_ValorPago;
                                this.txtCXC.EditValue = sumCXC;
                                break;
                            case "CHQF":
                                sumCHQF = sumCHQF + item.dc_ValorPago;
                                this.txtCHQF.EditValue = sumCHQF;
                                break;
                            case "CHQV":
                                sumCHQV_TARJ = sumCHQV_TARJ + item.dc_ValorPago;
                                this.txtChq_Tarj.EditValue = sumCHQV_TARJ;
                                break;
                            case "TARJ":
                                sumCHQV_TARJ = sumCHQV_TARJ + item.dc_ValorPago;
                                this.txtChq_Tarj.EditValue = sumCHQV_TARJ;
                                break;
                            default:
                                sumOTROS = sumOTROS + item.dc_ValorPago;
                                this.txtOtros.EditValue = sumOTROS;
                                break;
                        }
                    } // fin for

                } // fin else
                // fin col_valor


                this.txtTotalCobrado.EditValue = sumEFEC + sumDEPO + sumCXC + sumCHQF + sumCHQV_TARJ + sumOTROS;
                txeSaldo.EditValue = Convert.ToDouble(txeTotalDoc.EditValue) - Convert.ToDouble(txtTotalCobrado.EditValue);

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void btn_ApliReten_Click(object sender, EventArgs e)
        {
            try
            {
                frmCxc_CobrosRetenciones frm = new frmCxc_CobrosRetenciones();
                frm.Show();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
              //pendiente
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void btnND_Click(object sender, EventArgs e)
        {
            try
            {
              //pendiente
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void btnNC_Click(object sender, EventArgs e)
        {
            try
            {
               //prendiente
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

    }
}///512
 ///513
//27022014 cj