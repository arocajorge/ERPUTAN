using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.Facturacion;
using Core.Erp.Business.CuentasxCobrar;
using Core.Erp.Info.CuentasxCobrar;
using Core.Erp.Info.Facturacion;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using Core.Erp.Info.Caja;
using Core.Erp.Business.Caja;
using Core.Erp.Winform.Controles;
using Core.Erp.Reportes.CuentasxCobrar;


namespace Core.Erp.Winform.CuentasxCobrar
{
    public partial class frmCxc_Cobros_x_Ventas_Mant : Form
    {
        #region Declaración de Variables
        //Bus
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        tb_Sucursal_Bus sucur_B = new tb_Sucursal_Bus();
        fa_factura_Bus Fa_B = new fa_factura_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        vwcxc_cartera_x_cobrar_Bus cartera_B = new vwcxc_cartera_x_cobrar_Bus();
        fa_Cliente_Bus Cliente_B = new fa_Cliente_Bus();
        cxc_cobro_Bus cobro_B = new cxc_cobro_Bus();
        cxc_cobro_tipo_Param_conta_x_sucursal_Bus bus = new cxc_cobro_tipo_Param_conta_x_sucursal_Bus();
        caj_Caja_Bus Bus_caja = new caj_Caja_Bus();

        //BindingList
        BindingList<cxc_cobro_Info> list_datasour = new BindingList<cxc_cobro_Info>();
        BindingList<cxc_cobro_Info> ListaBind;
        BindingList<cxc_cobro_Info> lst;
        BindingList<cxc_cobro_x_caj_Caja_Movimiento_Info> lista;

        //Info
        caj_Caja_Movimiento_Info CajaMovi_I = new caj_Caja_Movimiento_Info();
        vwcxc_cartera_x_cobrar_Info cartera_I = new vwcxc_cartera_x_cobrar_Info();
        fa_Cliente_Info Cliente_I = new fa_Cliente_Info();
        fa_Vendedor_Info Vendedor_I = new fa_Vendedor_Info();

        //Variables
        double sumEFEC = 0;
        double sumDEPO = 0;
        double sumCXC = 0;
        double sumCHQF = 0;
        double sumOTROS = 0;
        double sumCHQV_TARJ = 0;

        string MensajeError = "";
        UCCon_GridDiarioContable UCDiario = new UCCon_GridDiarioContable();
        #endregion
       
        public frmCxc_Cobros_x_Ventas_Mant()
        {
            InitializeComponent();
            ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
            ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
            ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
            ucGe_Menu.event_btnImprimirSoporte_Click += ucGe_Menu_event_btnImprimirSoporte_Click;
            try
            {
                griddetalle.DataSource = list_datasour;
                tb_banco_Bus BusBanco = new tb_banco_Bus();
                cxc_cobro_tipo_Bus BustipoCxC = new cxc_cobro_tipo_Bus();
                repositoryItemGridLookUpEditBanco.DataSource = (from q in BusBanco.Get_List_Banco() select q.ba_descripcion).ToList();

                repositoryItemGridLookUpEditTipoCobro.DataSource = (from q in BustipoCxC.Get_List_Cobro_Tipo() select new { q.IdCobro_tipo, q.tc_descripcion }).ToList();

                // Cargando Combo tarjeta
                tb_tarjeta_Bus Bus_tarjeta = new tb_tarjeta_Bus();
                List<tb_tarjeta_Info> Info_tarjeta = new List<tb_tarjeta_Info>();
                Info_tarjeta = Bus_tarjeta.Get_List_tarjeta();
                this.cmbTarjeta.DataSource = Info_tarjeta;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_event_btnImprimirSoporte_Click(object sender, EventArgs e)
        {
            try
            {
                List<XCXC_Rpt005_Info> lstRpt = new List<XCXC_Rpt005_Info>();
                XCXC_Rpt005_Bus busRpt = new XCXC_Rpt005_Bus();
                XCXC_Rpt005_rpt reporte = new XCXC_Rpt005_rpt(param.IdUsuario);

                reporte.RequestParameters = false;

                lstRpt = busRpt.get_ImpresionCobro_x_Venta(cartera_I.IdEmpresa, cartera_I.IdSucursal, cartera_I.IdBodega, cartera_I.IdComprobante, cartera_I.vt_tipoDoc);
                reporte.lstRpt = lstRpt;

                reporte.CreateDocument();
                reporte.ShowPreviewDialog();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
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

        void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (guardarDatos())
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                guardarDatos();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        Boolean guardarDatos()
        {
            try
            {
                if (validar())
                    if (validaciones())
                        if (validarValores())
                            return Grabar();
                        else
                            return false;
                    else
                        return false;
                else
                    return false;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public void cargarGridContable(int IdEmpresa, int IdSucursal, decimal idCuenta)
        {
            try
            {
              /*  cxc_cobro_x_ct_cbtecble_Info InfoCxCxCt = new cxc_cobro_x_ct_cbtecble_Info();
                cxc_cobro_x_ct_cbtecble_Bus BusCxCxCt = new cxc_cobro_x_ct_cbtecble_Bus();
                InfoCxCxCt = BusCxCxCt.Obtener(IdEmpresa, IdSucursal, idCuenta);
                UCDiario.setInfo(InfoCxCxCt.ct_IdEmpresa, InfoCxCxCt.ct_IdTipoCbte, InfoCxCxCt.ct_IdCbteCble);
                UCDiario.VisibleCabecera(false);
                UCDiario.Botones_Visible = false;
                pnlDiario.Controls.Add(UCDiario);
                
                UCDiario.Dock = DockStyle.Fill;*/
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void set(int IdEmpresa, int IdSucursal, int IdBodega, string TipoDoc, decimal IdCbteCble, Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {
                cartera_I = cartera_B.Get_Info_cartera_x_cobrar(IdEmpresa, IdSucursal, IdBodega, IdCbteCble, TipoDoc);
                txt_sucursal.Text = (cartera_I.Su_Descripcion != null) ? cartera_I.Su_Descripcion.Trim() : "";
                txt_bodega.Text = (cartera_I.Bodega != null) ? cartera_I.Bodega.Trim() : "";
                txe_total.EditValue = Convert.ToDouble(cartera_I.vt_total);
                lbl_IdBodega.Text = cartera_I.IdBodega.ToString();
                
                //haac 23/01/2014
                this.txtSubtotal.EditValue = cartera_I.vt_Subtotal;
                this.txtIva.EditValue = cartera_I.vt_iva;

                //haac 23/01/2014
                txe_saldo.EditValue = Convert.ToDouble(cartera_I.Saldo);
                dtp_fecha.Value = Convert.ToDateTime(cartera_I.vt_fecha);
                txt_NDoc.Text = cartera_I.vt_NunDocumento;
                txtObservacion.Text = cartera_I.Referencia;
                Cliente_I.IdCliente = cartera_I.IdCliente;
                Cliente_B.ConsultarClienteVendedor(IdEmpresa, ref Cliente_I, ref Vendedor_I);
                txt_cliente.Text = (Cliente_I.Nombre_Cliente != "" || Cliente_I.Nombre_Cliente != null) ? Cliente_I.Nombre_Cliente.Trim() : Cliente_I.Persona_Info.pe_razonSocial;

                //haac 23/01/2014
                this.txtSubtotal.Enabled = false;
                this.txtSubtotal.BackColor = System.Drawing.Color.White;
                this.txtSubtotal.ForeColor = System.Drawing.Color.Black;

                this.txtIva.Enabled = false;
                this.txtIva.BackColor = System.Drawing.Color.White;
                this.txtIva.ForeColor = System.Drawing.Color.Black;
                //haac 23/01/2014

                if (!(Accion == Cl_Enumeradores.eTipo_action.grabar))
                {
                    ucGe_Menu.Visible_btnGuardar = false;
                    ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                }

                if (Accion == Cl_Enumeradores.eTipo_action.grabar)
                {

                    this.txtCXC.Enabled = false;
                    this.txtCXC.BackColor = System.Drawing.Color.White;
                    this.txtCXC.ForeColor = System.Drawing.Color.Black;

                    this.txtCHQF.Enabled = false;
                    this.txtCHQF.BackColor = System.Drawing.Color.White;
                    this.txtCHQF.ForeColor = System.Drawing.Color.Black;

                    this.txtEfectivo.Enabled = false;
                    this.txtEfectivo.BackColor = System.Drawing.Color.White;
                    this.txtEfectivo.ForeColor = System.Drawing.Color.Black;

                    this.txtChq_Tarj.Enabled = false;
                    this.txtChq_Tarj.BackColor = System.Drawing.Color.White;
                    this.txtChq_Tarj.ForeColor = System.Drawing.Color.Black;

                    this.txtOtros.Enabled = false;
                    this.txtOtros.BackColor = System.Drawing.Color.White;
                    this.txtOtros.ForeColor = System.Drawing.Color.Black;

                    this.txtDeposito.Enabled = false;
                    this.txtDeposito.BackColor = System.Drawing.Color.White;
                    this.txtDeposito.ForeColor = System.Drawing.Color.Black;

                    this.txtTotalCobrado.Enabled = false;
                    this.txtTotalCobrado.BackColor = System.Drawing.Color.White;
                    this.txtTotalCobrado.ForeColor = System.Drawing.Color.Black;

                }


                if (Accion == Cl_Enumeradores.eTipo_action.consultar)
                {
                    this.gridView_detalle.OptionsBehavior.Editable = false;

                    this.cmbCaja.Enabled = false;
                    this.cmbCaja.BackColor = System.Drawing.Color.White;
                    this.cmbCaja.ForeColor = System.Drawing.Color.Black;

                    this.txtCXC.Enabled = false;
                    this.txtCXC.BackColor = System.Drawing.Color.White;
                    this.txtCXC.ForeColor = System.Drawing.Color.Black;

                    this.txtCHQF.Enabled = false;
                    this.txtCHQF.BackColor = System.Drawing.Color.White;
                    this.txtCHQF.ForeColor = System.Drawing.Color.Black;

                    this.txtEfectivo.Enabled = false;
                    this.txtEfectivo.BackColor = System.Drawing.Color.White;
                    this.txtEfectivo.ForeColor = System.Drawing.Color.Black;

                    this.txtChq_Tarj.Enabled = false;
                    this.txtChq_Tarj.BackColor = System.Drawing.Color.White;
                    this.txtChq_Tarj.ForeColor = System.Drawing.Color.Black;

                    this.txtOtros.Enabled = false;
                    this.txtOtros.BackColor = System.Drawing.Color.White;
                    this.txtOtros.ForeColor = System.Drawing.Color.Black;

                    this.txtDeposito.Enabled = false;
                    this.txtDeposito.BackColor = System.Drawing.Color.White;
                    this.txtDeposito.ForeColor = System.Drawing.Color.Black;

                    this.txtTotalCobrado.Enabled = false;
                    this.txtTotalCobrado.BackColor = System.Drawing.Color.White;
                    this.txtTotalCobrado.ForeColor = System.Drawing.Color.Black;

                    this.txtObservacion.Enabled = false;
                    this.txtObservacion.BackColor = System.Drawing.Color.White;
                    this.txtObservacion.ForeColor = System.Drawing.Color.Black;

                }

                list_datasour = new BindingList<cxc_cobro_Info>(cobro_B.Get_List_cobros_x_Factura(IdEmpresa, IdSucursal, IdBodega, IdCbteCble, TipoDoc));
                griddetalle.DataSource = list_datasour;
                
                lista = new BindingList<cxc_cobro_x_caj_Caja_Movimiento_Info>();
                int idCaja = 0;
                decimal idCobro = 0;
                foreach (var item in list_datasour)
	            {
		            idCaja = item.IdCaja;
                    idCobro = item.IdCobro;
	            }
                cmbCaja.EditValue = idCaja;
                cargarGridContable(IdEmpresa, IdSucursal, idCobro);
                //haac 07-FEB-2014
                List<cxc_cobro_x_caj_Caja_Movimiento_Info> lista1 = new List<cxc_cobro_x_caj_Caja_Movimiento_Info>();
                cxc_cobro_x_caj_Caja_Movimiento_Bus Bus_cajMov = new cxc_cobro_x_caj_Caja_Movimiento_Bus();
                lista1 = Bus_cajMov.Get_List_cobro_x_caj_Caja_Movimiento(IdEmpresa);
                this.gridControl_NCND.DataSource = lista1;
                //haac 07-FEB-2014

                if (list_datasour != null)
                {
                    this.Calcula_Totales();

                }

            }
            catch (Exception ex) 
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void Calcula_Totales()
        {
            try
            {
                
                     sumEFEC = 0;
                     sumDEPO = 0;
                     sumCXC = 0;
                     sumCHQF = 0;
                     sumOTROS = 0;
                     sumCHQV_TARJ = 0;

                    

                    foreach (var item in list_datasour)
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
                    }
                    this.txtTotalCobrado.EditValue = sumEFEC + sumDEPO + sumCXC + sumCHQF + sumCHQV_TARJ + sumOTROS;
            
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }

        // haac 28/01/2014  
        public BindingList<cxc_cobro_x_caj_Caja_Movimiento_Info> carga_grid_caj_Movimiento(BindingList<cxc_cobro_Info> lista_cobro, BindingList<cxc_cobro_x_caj_Caja_Movimiento_Info> lista_grid)
        {
            try
            {
                List<cxc_cobro_x_caj_Caja_Movimiento_Info> lista_Caj_Mov = new List<cxc_cobro_x_caj_Caja_Movimiento_Info>();
                BindingList<cxc_cobro_x_caj_Caja_Movimiento_Info> Bindlista_Cobro_Caja = new BindingList<cxc_cobro_x_caj_Caja_Movimiento_Info>();

                cxc_cobro_x_caj_Caja_Movimiento_Bus data = new cxc_cobro_x_caj_Caja_Movimiento_Bus();
                foreach (var item in lista_cobro)
                {
                    lista_Caj_Mov = data.Get_List_cobro_x_caj_Caja_Movimiento(item.IdEmpresa /*, item.IdSucursal, item.IdCobro*/);

                    foreach (var item1 in lista_Caj_Mov)
                    {
                        cxc_cobro_x_caj_Caja_Movimiento_Info info = new cxc_cobro_x_caj_Caja_Movimiento_Info();

                        info.cbr_IdEmpresa = item1.cbr_IdEmpresa;
                        info.cbr_IdSucursal = item1.cbr_IdSucursal;
                        info.cbr_IdCobro = item1.cbr_IdCobro;
                        info.mcj_IdEmpresa = item1.mcj_IdEmpresa;
                        info.mcj_IdCbteCble = item1.mcj_IdCbteCble;
                        info.mcj_IdTipocbte = item1.mcj_IdTipocbte;
                        info.em_nombre = item1.em_nombre;
                        info.Su_Descripcion = item1.Su_Descripcion;
                        info.tc_descripcion = item1.tc_descripcion;
                        info.tc_TipoCbte = item1.tc_TipoCbte;
                        Bindlista_Cobro_Caja.Add(info);
                    }
                }
                lista_grid = Bindlista_Cobro_Caja;
                return lista_grid;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return lista_grid;
            }
        }

        public List<cxc_cobro_Info> LstCobros = new List<cxc_cobro_Info>();

        public void get_Cobro()
        {
            txt_bodega.Focus();
            LstCobros.Clear();

            try
            {
                foreach (var item in list_datasour)
                {
                    if (item.IdEmpresa == 0)
                    {
                        cxc_cobro_Info _Info = new cxc_cobro_Info();

                        _Info.IdEmpresa = param.IdEmpresa;
                        _Info.IdSucursal = cartera_I.IdSucursal;
                        _Info.IdCliente = cartera_I.IdCliente;
                        _Info.cr_TotalCobro = item.dc_ValorPago;
                        _Info.cr_Banco = item.cr_Banco;
                        _Info.cr_Tarjeta = item.cr_Tarjeta;
                        _Info.cr_observacion = item.cr_observacion;
                        _Info.IdCobro_tipo = item.IdCobro_tipo;
                        _Info.cr_Banco = item.cr_Banco;
                        _Info.cr_fechaDocu = Convert.ToDateTime(item.cr_fechaDocu.ToShortDateString());
                        _Info.cr_fecha = Convert.ToDateTime(item.cr_fechaDocu.ToShortDateString());
                        _Info.cr_fechaCobro = Convert.ToDateTime(item.cr_fechaCobro.ToShortDateString());
                        _Info.cr_cuenta = item.cr_cuenta;
                        _Info.cr_NumDocumento = item.cr_NumDocumento;
                        _Info.dc_ValorPago = item.dc_ValorPago;
                        _Info.dc_TipoDocumento = cartera_I.vt_tipoDoc;
                        _Info.IdCbte_vta_nota = cartera_I.IdComprobante;
                        item.cr_observacion = (item.cr_observacion == null) ? "Cancelación de : " + _Info.cr_NumDocumento : item.cr_observacion;
                        _Info.cr_observacion = item.cr_observacion;
                        _Info.IdEmpresa = param.IdEmpresa;
                        _Info.secuencial = 1;
                        _Info.nom_pc = param.nom_pc;
                        _Info.ip = param.ip;
                        _Info.Fecha_Transac = Convert.ToDateTime(DateTime.Now);
                        _Info.IdUsuario = param.IdUsuario;
                        _Info.IdBodega_Cbte = Convert.ToInt32(lbl_IdBodega.Text);
                        _Info.IdCaja = Convert.ToInt32(this.cmbCaja.EditValue);

                        LstCobros.Add(_Info);
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmcxc_CobrosXFactura_Load(object sender, EventArgs e)
        {
            try
            {
                //ListaBind = new BindingList<cxc_cobro_Info>();
                //griddetalle.DataSource = ListaBind;

                //haac 24/01/2014
                List<caj_Caja_Info> listaCaja = new List<caj_Caja_Info>();
                listaCaja = Bus_caja.Get_list_caja(param.IdEmpresa, ref  MensajeError);
                this.cmbCaja.Properties.DataSource = listaCaja;
                //haac 24/01/2014

                this.event_frmcxc_CobrosXFactura_FormClosing += new delegate_frmcxc_CobrosXFactura_FormClosing(frmcxc_CobrosXFactura_event_frmcxc_CobrosXFactura_FormClosing);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void frmcxc_CobrosXFactura_event_frmcxc_CobrosXFactura_FormClosing(object sender, FormClosingEventArgs e)
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

        public delegate void delegate_frmcxc_CobrosXFactura_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmcxc_CobrosXFactura_FormClosing event_frmcxc_CobrosXFactura_FormClosing;

        private void frmcxc_CobrosXFactura_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
               this.event_frmcxc_CobrosXFactura_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridView_detalle_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Delete)
                {
                    cxc_cobro_Info Info = (cxc_cobro_Info)this.gridView_detalle.GetFocusedRow();
                    int IdBog = 0;
                    if (cobro_B.ExisteCobro(Info.IdEmpresa, Info.IdSucursal, IdBog, Info.IdCbte_vta_nota, Info.dc_TipoDocumento))
                    {
                        MessageBox.Show("Este registro no se puede eliminar. Ya existe en la base de datos ", param.Nombre_sistema);
                        return;
                    }
                    else
                    {
                        if (MessageBox.Show("¿Está seguro que desea Eliminar este registro ?", "Elimina", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            gridView_detalle.DeleteSelectedRows();

                            this.txtEfectivo.EditValue = 0;
                            this.txtDeposito.EditValue = 0;
                            this.txtCXC.EditValue = 0;
                            this.txtCHQF.EditValue = 0;
                            this.txtChq_Tarj.EditValue = 0;
                            this.txtOtros.EditValue = 0;

                            this.Calcula_Totales();                                                                  
                        }
                    }
                }
            }
            catch (Exception ex)
            { Log_Error_bus.Log_Error(ex.ToString());
            MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridView_detalle_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                // Aquamarine; //Red;
                var data = gridView_detalle.GetRow(e.RowHandle) as cxc_cobro_Info;
                if (data == null)
                    return;
                if (data.IdCobro > 0)
                    e.Appearance.BackColor = Color.AliceBlue;//.CornflowerBlue; // AliceBlue;// e.Appearance.ForeColor = Color.Red;           
            }
            catch (Exception ex)
            { Log_Error_bus.Log_Error(ex.ToString());
            MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {/////////////
        }

        Boolean Grabar()
        {
            try
            {
                Boolean bolResult = false;
                // List<cxc_cobro_Info> listax = new List<cxc_cobro_Info>();
                BindingList<cxc_cobro_Info> lista_Cobro = new BindingList<cxc_cobro_Info>();

                get_Cobro();
                List<cxc_cobro_Info> rLst1 = new List<cxc_cobro_Info>();

                if (LstCobros.Count() == 0)
                {
                    bolResult = false;
                }

                else
                {
                    foreach (var item in LstCobros)
                    {
                        cxc_cobro_Info Info_Cobro = new cxc_cobro_Info();
                                              
                        Info_Cobro.IdEmpresa = item.IdEmpresa;
                        Info_Cobro.IdSucursal = item.IdSucursal;
                        Info_Cobro.IdCliente = item.IdCliente;
                        Info_Cobro.cr_TotalCobro = item.dc_ValorPago;
                        Info_Cobro.cr_Banco = item.cr_Banco;

                        Info_Cobro.cr_Tarjeta = item.cr_Tarjeta;

                        Info_Cobro.cr_observacion = item.cr_observacion;
                        Info_Cobro.IdCobro_tipo = item.IdCobro_tipo;
                        Info_Cobro.cr_Banco = item.cr_Banco;
                        Info_Cobro.cr_fechaDocu = Convert.ToDateTime(item.cr_fechaDocu.ToShortDateString());
                        Info_Cobro.cr_fecha = Convert.ToDateTime(item.cr_fecha.ToShortDateString());
                        Info_Cobro.cr_fechaCobro = Convert.ToDateTime(item.cr_fechaCobro.ToShortDateString());
                        Info_Cobro.cr_cuenta = item.cr_cuenta;
                        Info_Cobro.cr_NumDocumento = item.cr_NumDocumento;
                        Info_Cobro.dc_ValorPago = item.dc_ValorPago;
                        Info_Cobro.dc_TipoDocumento = item.dc_TipoDocumento;
                        Info_Cobro.IdCbte_vta_nota = item.IdCbte_vta_nota;
                        Info_Cobro.IdEmpresa = item.IdEmpresa;
                        Info_Cobro.secuencial = 1;
                        Info_Cobro.nom_pc = item.nom_pc;
                        Info_Cobro.ip = item.ip;
                        Info_Cobro.Fecha_Transac = Convert.ToDateTime(DateTime.Now);
                        Info_Cobro.IdUsuario = item.IdUsuario;
                        Info_Cobro.IdBodega_Cbte = item.IdBodega_Cbte;

                        Info_Cobro.IdCaja = item.IdCaja;

                        cxc_cobro_Det_Info lista_det = new cxc_cobro_Det_Info();

                        lista_det.IdEmpresa = Info_Cobro.IdEmpresa;
                        lista_det.IdEmpresa = item.IdEmpresa;
                        lista_det.IdSucursal = Info_Cobro.IdSucursal;
                        lista_det.IdCobro = Info_Cobro.IdCobro;
                        lista_det.secuencial = Info_Cobro.secuencial;
                        lista_det.dc_TipoDocumento = Info_Cobro.dc_TipoDocumento;
                        lista_det.IdBodega_Cbte = Info_Cobro.IdBodega_Cbte;
                        lista_det.IdCbte_vta_nota = Info_Cobro.IdCbte_vta_nota;
                        lista_det.dc_ValorPago = Info_Cobro.dc_ValorPago;
                        lista_det.IdUsuario = Info_Cobro.IdUsuario;

                        lista_det.Fecha_Transac = Convert.ToDateTime(DateTime.Now);
                        lista_det.nom_pc = Info_Cobro.nom_pc;
                        lista_det.ip = Info_Cobro.ip;


                        Info_Cobro.ListaCobro = new List<cxc_cobro_Det_Info>();

                        Info_Cobro.ListaCobro.Add(lista_det);
                        string MsgError = "";


                        if (cobro_B.GuardarDB(Cl_Enumeradores.PantallaEjecucion.COBROS, ref Info_Cobro, ref MsgError))
                        {
                            lista_Cobro.Add(Info_Cobro);
                        }                     

                    }

                    ucGe_Menu.Visible_btnGuardar = false;
                    ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                    ucGe_Menu.Enabled_btnImprimirSoporte = false;

                    MessageBox.Show("Cobros Ingresados correctamente", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bolResult = true;
                    lista = new BindingList<cxc_cobro_x_caj_Caja_Movimiento_Info>();

                    lst = new BindingList<cxc_cobro_Info>(lista_Cobro);

                    this.gridControl_NCND.DataSource = carga_grid_caj_Movimiento(lst, lista);

                    vwcxc_cartera_x_cobrar_Info cartera = new vwcxc_cartera_x_cobrar_Info();
                    cartera = cartera_B.Get_Info_cartera_x_cobrar(cartera_I.IdEmpresa, cartera_I.IdSucursal, cartera_I.IdBodega, cartera_I.IdComprobante, cartera_I.vt_tipoDoc);
                    txe_saldo.EditValue = Convert.ToDouble(cartera.Saldo);

                    if (MessageBox.Show("¿Desea Imprimir el Cobro \n" + "Imprimir", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        ucGe_Menu_event_btnImprimirSoporte_Click(null, null);
                    }
                }
                return bolResult;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private Boolean validarValores()
        {
            try
            {
                decimal total_cobrado = 0;
                decimal total_factura = 0;

                total_cobrado = Math.Round(Convert.ToDecimal(txtTotalCobrado.EditValue), 2);
                total_factura = Math.Round(Convert.ToDecimal(txe_total.EditValue), 2);

                if (total_cobrado > total_factura)
                {
                    MessageBox.Show("El Valor Ingresado es Mayor al de la Factura ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (total_cobrado <= 0)
                {                
                    MessageBox.Show("El Valor Ingresado no puede ser menor o igual a 0", param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    return false;
                }
                return true;
            }
            catch (Exception ex) {
                 Log_Error_bus.Log_Error(ex.ToString());
                 MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        
        private Boolean validaciones()
        {
            try
            {

                foreach (var item in list_datasour)
                {
                    if (item.IdCobro_tipo == null || item.IdCobro_tipo == "")
                    {
                        MessageBox.Show("Ingrese el tipo de pago ", param.Nombre_sistema);
                        return false;
                    }


                    if (item.IdCobro_tipo == "NTDE" || item.IdCobro_tipo  == "NTCR")
                    {
                        MessageBox.Show("Los cobros por notas de credito o debito deben ser realizados por la pantalla de Nota Credito y Debito "
                         ,param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                         return false;
                     }
                }
                return true;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        List<cxc_cobro_Info> LstCob = new List<cxc_cobro_Info>();
        
        private void gridView_detalle_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                var Item = (cxc_cobro_Info)gridView_detalle.GetRow(e.FocusedRowHandle);

                if (Item == null || Item.IdCobro == 0)
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
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // haac 24/01/2014
        cxc_cobro_Info row = new cxc_cobro_Info();

        private void gridView_detalle_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                this.txtSubtotal.Focus();
                row = (cxc_cobro_Info)gridView_detalle.GetRow(e.RowHandle);
                if (row != null)
                {
                    if (e.Column.Name == "colIdCobro_tipo")
                    {
                        if (row.IdCobro_tipo != null)
                        {
                            cxc_cobro_tipo_Param_conta_x_sucursal_Info info = new cxc_cobro_tipo_Param_conta_x_sucursal_Info();
                            info = bus.Get_Info_cobro_tipo_Param_conta_x_sucursal(param.IdEmpresa, cartera_I.IdSucursal, row.IdCobro_tipo);
                            sumEFEC = 0;
                            sumDEPO = 0;
                            sumCXC = 0;
                            sumCHQF = 0;
                            sumOTROS = 0;
                            sumCHQV_TARJ = 0;
                            this.txtEfectivo.EditValue = sumEFEC;
                            this.txtDeposito.EditValue = sumDEPO;
                            this.txtCXC.EditValue = sumCXC;
                            this.txtCHQF.EditValue = sumCHQF;
                            this.txtChq_Tarj.EditValue = sumCHQV_TARJ;
                            this.txtOtros.EditValue = sumOTROS;
                            row.dc_ValorPago = 0;
                        }
                    }
                    if (e.Column.Name == "colcr_Valor")
                    {
                        if (row.IdCobro_tipo == "" || row.IdCobro_tipo == null)
                        {
                            MessageBox.Show("Seleccione primero el tipo de cobro", param.Nombre_sistema);
                            gridView_detalle.DeleteRow(gridView_detalle.FocusedRowHandle);
                        }
                        else
                        {
                            this.Calcula_Totales();
                        } // fin else
                    }  // fin col_valor
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        Boolean validar()
        {
            try
            {
                if (this.cmbCaja.EditValue == "" || this.cmbCaja.EditValue == null)
                {
                    MessageBox.Show("Ingrese la caja. Por favor", param.Nombre_sistema);
                    return false;
                }

                if (!param.Validar_periodo_cerrado_x_modulo(param.IdEmpresa,Cl_Enumeradores.eModulos.CXC, Convert.ToDateTime(dtp_fecha.Value)))
                    return false;

                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
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
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}