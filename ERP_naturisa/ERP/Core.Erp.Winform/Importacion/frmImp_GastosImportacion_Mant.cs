using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.Importacion;
using Core.Erp.Business.Bancos;
using Core.Erp.Info.Bancos;
using Core.Erp.Info.Importacion;
using Core.Erp.Business.General;
using Core.Erp.Business.CuentasxPagar;
using Core.Erp.Info.General;
using Core.Erp.Winform.General;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Winform.Controles;
using Core.Erp.Winform.Contabilidad;


namespace Core.Erp.Winform.Importacion
{
    public partial class frmImp_GastosImportacion_Mant : Form
    {

        #region
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        ct_Cbtecble_det_Bus _CbteCbleBus = new ct_Cbtecble_det_Bus();
        public Boolean GenerarDiario { get; set; }
        //UCCon_DiarioContable ctrl_diario = new UCCon_DiarioContable();
        imp_gastosxImport_Bus BusGastos = new imp_gastosxImport_Bus();
        ba_Banco_Cuenta_Bus BusBancos = new ba_Banco_Cuenta_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        imp_Tipo_docu_pago_Bus BusTipoPagos = new imp_Tipo_docu_pago_Bus();
        cp_proveedor_Bus BusProveedor = new cp_proveedor_Bus();
        imp_ordencompra_ext_Bus busImpOrdenExt = new imp_ordencompra_ext_Bus();
        tb_Sucursal_Bus BusSucursal = new Business.General.tb_Sucursal_Bus();
        imp_ordencompra_ext_x_imp_gastosxImport_Bus Bus = new imp_ordencompra_ext_x_imp_gastosxImport_Bus();
        imp_ordencompra_ext_x_imp_gastosxImport_Det_Bus BusDetalle = new imp_ordencompra_ext_x_imp_gastosxImport_Det_Bus();
        Cl_Enumeradores.eTipo_action _Accion;
        ct_Periodo_Info Per_I = new ct_Periodo_Info();
        imp_Tipo_docu_pago_x_Empresa_x_tipocbte_Bus BusTipoPagoTipoCb = new imp_Tipo_docu_pago_x_Empresa_x_tipocbte_Bus();
        List<imp_Tipo_docu_pago_x_Empresa_x_tipocbte_Info> InfoTipoPagoTipoCb = new List<imp_Tipo_docu_pago_x_Empresa_x_tipocbte_Info>();
        imp_Tipo_docu_pago_x_Empresa_x_tipocbte_Info tipocbte = new imp_Tipo_docu_pago_x_Empresa_x_tipocbte_Info();
        ct_Cbtecble_Bus CbteCble_B = new ct_Cbtecble_Bus();
        ba_Cbte_Ban_Bus BusCbteBanco = new ba_Cbte_Ban_Bus();
        ct_Cbtecble_Info CbteCble_I = new ct_Cbtecble_Info();
        imp_gastosximport_x_empresa_Bus BusGastosXEmpresa = new imp_gastosximport_x_empresa_Bus();
        List<imp_gastosximport_x_empresa_Info> lstGastosXEmpresa = new List<imp_gastosximport_x_empresa_Info>();
        List<imp_Tipo_docu_pago_Info> LstTipoPago = new List<imp_Tipo_docu_pago_Info>();
        ba_Cbte_Ban_Info CbteBan_I = new ba_Cbte_Ban_Info();
        List<imp_gastosxImport_Info> lstGastosPOrImportacion = new List<imp_gastosxImport_Info>();
        string MensajeError = "";
        #endregion

        public void SetAccion(Cl_Enumeradores.eTipo_action iAccion) 
        {
            try
            {
                 _Accion = iAccion;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }


        }

        public frmImp_GastosImportacion_Mant()
        {
            try
            {

                InitializeComponent();

                lstGastosPOrImportacion = BusGastos.Get_List_gastosxImport().FindAll(var=> var.ga_estado =="A");
                repositoryItemSearchLookUpEdit1.DataSource = lstGastosPOrImportacion;
                lstGastosXEmpresa = BusGastosXEmpresa.Consulta(param.IdEmpresa);
                InfoTipoPagoTipoCb = BusTipoPagoTipoCb.Get_List_Tipo_docu_pago_x_Empresa_x_tipocbte(param.IdEmpresa);

                CargarCombos();
                Importaciones = busImpOrdenExt.Get_List_ordencompra_ext_x_Gastos(param.IdEmpresa).FindAll(var => var.IdEstadoLiquidacion == "XLQDAR" && var.Estado == "A");
                Importaciones.ForEach(var => { if (var.IdEstadoLiquidacion == "XLQDAR") { var.IdEstadoLiquidacion = "Por Liquidar"; } });
                searchLookUpEditImportacion.Properties.DataSource = Importaciones;//.FindAll(var=> var.Estado == "A");
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }



        }
        
        public void CargarCombos() 
        {
            try
            {
                List<ba_Banco_Cuenta_Info> listaBanco = new List<ba_Banco_Cuenta_Info>();
                listaBanco = BusBancos.Get_list_Banco_Cuenta(param.IdEmpresa);

                cmbBanco.Properties.DataSource = listaBanco;
                cmbBanco.Properties.DisplayMember = "ba_descripcion";
                cmbBanco.Properties.ValueMember = "IdBanco";
             
                ba_Banco_Cuenta_Info Idbanco = listaBanco.FirstOrDefault();
                cmbBanco.EditValue = Idbanco.IdBanco;


                LstTipoPago = BusTipoPagos.Get_List_Tipo_docu_pago();
                cmbTipoPagos.DataSource = LstTipoPago;
                cmbTipoPagos.DisplayMember = "Descripcion";
                cmbTipoPagos.ValueMember = "CodDocu_Pago";


                searchLookUpEdit_Proveedor.Properties.DataSource = BusProveedor.Get_List_proveedor(param.IdEmpresa);



                cmbTipoPagos.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }


     
        }

        public void ValidarParametrosContables() 
        {
            try
            {
                var sq = from q in lstGastosXEmpresa
                         select q.IdGastoImp;

                var s = from sd in lstGastosPOrImportacion
                        where !sq.Contains(sd.IdGastoImp)
                        select sd.IdGastoImp;

                var sese = from q in lstGastosPOrImportacion
                           from se in s
                           where q.IdGastoImp == se && !sq.Contains(se)
                           select q;
                if (s.Count()!=0)
                {
                    string faltante = "";
                    foreach (var item in sese)
                    {
                        faltante = faltante + ", " + item.ga_decripcion;
                    }

                    MessageBox.Show("No Se puede Contabilizar debido a que faltan Parametros Contables en " + "/n" + "  las siguientes  " + faltante, "Mensaje ERP");
                    //btnOk.Enabled= false;
                    //BtnGuardarYsalir.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        List<imp_ordencompra_ext_Info> Importaciones;
        
        private void frmImp_RegistroGastosImportacion_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                
                cmbTipoPagos_ValueChanged(new Object(), new EventArgs());
                ValidarParametrosContables();
                GenerarDiario = true;

                
                //pnlDiario.Controls.Add(ctrl_diario);

                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        this.btnOk.Text = "Grabar";
                        btnOk.Text = "Guardar";
                        btnAnular.Enabled = false;
                        //toolStripButton3.Enabled = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        this.btnOk.Text = "Anular";
                        BtnGuardarYsalir.Enabled = false;
                        btnOk.Enabled = false;
                        if (_SetInfo.Estado == "I")
                        {
                            lbl_Estado.Visible = true;
                            btnAnular.Enabled = false;

                        }
                        Set();
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        btnOk.Enabled = false;
                        BtnGuardarYsalir.Enabled = false;
                        btnAnular.Enabled = false;
                        if (_SetInfo.Estado == "I")
                        {
                            lbl_Estado.Visible = true;
                            btnAnular.Enabled = false;
                        }
                        Set();
                        break;
                    default:
                        break;


                }



                Event_frmImp_RegistroGastosImportacion_Mant_FormClosing += new Delegate_frmImp_RegistroGastosImportacion_Mant_FormClosing(frmImp_RegistroGastosImportacion_Mant_Event_frmImp_RegistroGastosImportacion_Mant_FormClosing);


                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
        
        void frmImp_RegistroGastosImportacion_Mant_Event_frmImp_RegistroGastosImportacion_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void lblFecha_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
        
        public void GetCbteCtb() 
        {
            try
            {
                var DatosDiario = from p in _Info.ListaGastos
                                  join w in lstGastosXEmpresa
                                  on new { p.IdGastoImp } equals new { w.IdGastoImp }
                                  select new { p.IdGastoImp, w.IdCtaCble, p.Valor, w.debcre_DebBanco };
                // asdasdasd
                ba_Banco_Cuenta_Info banco = (ba_Banco_Cuenta_Info)cmbBanco.EditValue;//.ListObject;
                string contracuenta = banco.IdCtaCble;
                List<ct_Cbtecble_det_Info> LstCbteCble = new List<ct_Cbtecble_det_Info>();
                foreach (var item in DatosDiario)
                {
                    ct_Cbtecble_det_Info obj = new ct_Cbtecble_det_Info();

                    obj.dc_Observacion = "DEB " + txtObservacion.Text;
                    obj.IdCtaCble = item.IdCtaCble;

                    obj.IdTipoCbte = tipocbte.IdTipoCbte;
                    obj.IdEmpresa = param.IdEmpresa;

                    if (item.debcre_DebBanco == "C")
                    {
                        obj.dc_Valor = item.Valor * -1;
                    }
                    else
                    {
                        obj.dc_Valor = item.Valor;
                    }
                    LstCbteCble.Add(obj);

                }


                ct_Cbtecble_det_Info obj2 = new ct_Cbtecble_det_Info();
                double Valor = 0;
                foreach (var item in _Info.ListaGastos)
                {
                    Valor = Valor + item.Valor;
                }
                obj2.dc_Observacion = "Importacion: " + txtObservacion.Text.Trim();
                obj2.IdCtaCble = banco.IdCtaCble;
                obj2.IdTipoCbte = tipocbte.IdTipoCbte;
                obj2.IdEmpresa = param.IdEmpresa;
                obj2.dc_Valor = Valor * -1;


                LstCbteCble.Add(obj2);


                CbteCble_I.IdEmpresa = param.IdEmpresa;
                CbteCble_I.IdTipoCbte = tipocbte.IdTipoCbte;
                CbteCble_I.IdPeriodo = Per_I.IdPeriodo;
                CbteCble_I.cb_Fecha = Convert.ToDateTime(dtpFecha.Value.ToShortDateString());
                CbteCble_I.cb_Valor = Valor;
                CbteCble_I.cb_Observacion = txtObservacion.Text.Trim();
                CbteCble_I.Secuencia = 0;
                CbteCble_I.Estado = "A";
                CbteCble_I.Anio = dtpFecha.Value.Year;
                CbteCble_I.Mes = dtpFecha.Value.Month;
                CbteCble_I.IdUsuario = param.IdUsuario;
                CbteCble_I.IdUsuarioUltModi = param.IdUsuario;
                CbteCble_I.cb_FechaTransac = param.Fecha_Transac;
                CbteCble_I.cb_FechaUltModi = param.Fecha_Transac;
                CbteCble_I.Mayorizado = "N";
                CbteCble_I._cbteCble_det_lista_info = LstCbteCble;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
        
        public void GetCbteBcario(decimal idCbteCble, string cod_CbteCble) 
        {
            try
            {

                CbteBan_I.IdEmpresa = param.IdEmpresa;
                CbteBan_I.IdTipocbte = tipocbte.IdTipoCbte;
                CbteBan_I.IdCbteCble = idCbteCble;
                CbteBan_I.Cod_Cbtecble = cod_CbteCble;
                CbteBan_I.IdPeriodo = Per_I.IdPeriodo;
                CbteBan_I.IdBanco = _Info.IdBanco;
                CbteBan_I.cb_Fecha = Convert.ToDateTime(dtpFecha.Value.ToShortDateString());
                CbteBan_I.cb_Observacion = txtObservacion.Text.Trim();
                double Valor = 0;
                foreach (var item in _Info.ListaGastos)
                {
                    Valor = Valor + item.Valor;
                }
                CbteBan_I.cb_Valor = Valor;
                CbteBan_I.Estado = "A";
                CbteBan_I.IdUsuario = param.IdUsuario;
                CbteBan_I.IdUsuario_Anu = param.IdUsuario;
                CbteBan_I.FechaAnulacion = param.Fecha_Transac;
                CbteBan_I.Fecha_Transac = param.Fecha_Transac;
                CbteBan_I.Fecha_UltMod = param.Fecha_Transac;
                CbteBan_I.IdUsuarioUltMod = param.IdUsuario;
                CbteBan_I.ip = param.ip;
                CbteBan_I.nom_pc = param.nom_pc;
            }   
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
        
        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                txtObservacion.Focus();
                Get();

                if (validar())
                {
                    if (Bus.GuardarDB(ref _Info))
                    {
                        txtIdRegistroGasto.Text = _Info.IdRegistroGasto.ToString();
                        MessageBox.Show("Guardado OK");
                        btnAnular.Enabled = true;
                        //toolStripButton3.Enabled = true;
                        BtnGuardarYsalir.Enabled = false;
                        btnOk.Enabled = false;
                        _Accion = Cl_Enumeradores.eTipo_action.actualizar;
                        GetCbteCtb();

                        decimal idCbteCble = 0;
                        string cod_CbteCble = "";
                        string msg = "";
                        string Tipo = tipocbte.CodDocu_Pago;
                        if (generarDiarioTipoImp == true)
                        {
                            if (GenerarDiario)
                            {
                                if (Bus.GenerarDiario(param.IdEmpresa, _Info.IdSucusal, _Info.IdRegistroGasto, ref msg, ref idCbteCble, ref Tipo) == false)
                                {
                                    MessageBox.Show(msg);
                                }
                                //lblDiario.Text = lblDiario.Text + "" + idCbteCble;
                                //lblDiario.Visible = true;
                            }
                        }

                    }
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }
        
        public Boolean validar()
        {

            try
            {
                ct_Periodo_Bus Per_B = new ct_Periodo_Bus();
                Per_I = Per_B.Get_Info_Periodo(param.IdEmpresa, dtpFecha.Value, ref MensajeError);

                if (Per_I.pe_estado == "I")
                {
                    MessageBox.Show("No se procedio a Grabar porque el Periodo se encuentra cerrado ", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                if (_Info.IdOrdenCompraExt == null || _Info.IdOrdenCompraExt == 0)
                {
                    MessageBox.Show("Por Favor seleccione Importacion");
                    return false;
                }
                if (_Info.CodDocu_Pago == "" || _Info.CodDocu_Pago == null)
                {
                    MessageBox.Show("Por Favor seleccione Documento de Pago");
                    return false;

                }
                if (_Info.CodDocu_Pago == "DEBBAN")
                {
                    if (_Info.IdProveedor == null || _Info.IdProveedor == 0)
                    {
                        MessageBox.Show("Por Favor seleccione Proveedor");
                        return false;
                    }
                }
               
                if (_Info.ListaGastos.Count == 0 || _Info.ListaGastos == null)
                {
                    MessageBox.Show("Por favor Ingrese Tipo de gasto");
                    return false;
                }
                foreach (var item in _Info.ListaGastos)
                {
                    int c = 0;
                    foreach (var item1 in _Info.ListaGastos)
                    {
                        if (item.IdGastoImp == item1.IdGastoImp)
                        {
                            c++;
                            if (c > 1)
                            {
                                MessageBox.Show("No puede seleccionar dos tipos de gastos iguales");
                                return false;
                            }

                        }
                    }
                    if (item.Valor == 0)
                    {

                        MessageBox.Show("Debe Ingresar Valores En los tipos de gastos");
                        return false;
                    }

                }

                for (int i = 0; i < gridViewGastos.RowCount; i++)
                {
                    imp_ordencompra_ext_x_imp_gastosxImport_Det_Info asd = (imp_ordencompra_ext_x_imp_gastosxImport_Det_Info)gridViewGastos.GetRow(i);
                    if (asd != null)
                    {
                        if (asd.IdGastoImp == null || asd.IdGastoImp == 0)
                        {
                            MessageBox.Show("Verifique datos De la Tabla Sean correcto");
                            return false;

                        }
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

        private void btnBuscarImportacion_Click(object sender, EventArgs e)
        {
            
        }

        imp_ordencompra_ext_x_imp_gastosxImport_Info _Info = new imp_ordencompra_ext_x_imp_gastosxImport_Info();
        
        public void Get()
        {
            try
            {
               // var imp = busImpOrdenExt.obtenerOrdenCompra(param.IdEmpresa,txtImportacion.Text,(int)cmbSucursal.SelectedValue);
                _Info = new imp_ordencompra_ext_x_imp_gastosxImport_Info();
                _Info.IdEmpresa = param.IdEmpresa;

                _Info.IdOrdenCompraExt = Convert.ToDecimal(searchLookUpEditImportacion.EditValue);
                _Info.IdBanco = Convert.ToInt32(cmbBanco.EditValue);
               
                _Info.IdTipoCbte = tipocbte.IdTipoCbte;
                //_Info.IdSucusal = 1;
              //  imp_ordencompra_ext_Info imp = (imp_ordencompra_ext_Info)searchLookUpEditImportacion.GetSelectedDataRow();
                var idSucursa = Importaciones.Find(var => var.IdOrdenCompraExt == _Info.IdOrdenCompraExt).IdSucusal;



                _Info.IdSucusal = idSucursa;

                _Info.Fecha = Convert.ToDateTime(dtpFecha.Value.ToShortDateString());
                _Info.CodDocu_Pago = cmbTipoPagos.SelectedValue.ToString();
                _Info.Observacion = txtObservacion.Text;
                for (int i = 0; i < gridViewGastos.RowCount; i++)
                {
                    imp_ordencompra_ext_x_imp_gastosxImport_Det_Info asd = (imp_ordencompra_ext_x_imp_gastosxImport_Det_Info)gridViewGastos.GetRow(i);
                   
                    if (asd != null)
                    {
                        asd.Secuencia = i + 1;
                        asd.IdEmpresa = param.IdEmpresa;
                        asd.IdOrdenCompraExt = _Info.IdOrdenCompraExt;
                        asd.IdSucusal = _Info.IdSucusal;
                       
                        _Info.ListaGastos.Add(asd);
                    }
                }

                if (_Info.CodDocu_Pago != "PROVI")
                {
                    _Info.IdProveedor = Convert.ToDecimal(this.searchLookUpEdit_Proveedor.EditValue);
                }
                else 
                {
                    _Info.IdProveedor = null;
                }
                //_Info.IdRegistroGasto = Convert.ToDecimal(txtIdRegistroGasto.Text);
            }
            catch(Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        public imp_ordencompra_ext_x_imp_gastosxImport_Info _SetInfo { get; set; }
        
        public void Set()
        {
            try
            {

                if (_SetInfo.Tipo_Importacion == "IMPORTACION")
                {
                    //lblTipoImportacion.Visible = true;
                    //lblTipoImportacion.Text = _SetInfo.Tipo_Importacion;
                    generarDiarioTipoImp = true;
                }
                else 
                {
                    
                    generarDiarioTipoImp = false;
                }
                lblTipoImportacion.Visible = true;
                lblTipoImportacion.Text = _SetInfo.Tipo_Importacion;
                txtIdRegistroGasto.Text = _SetInfo.IdRegistroGasto.ToString();
                searchLookUpEditImportacion.EditValue = _SetInfo.IdOrdenCompraExt.ToString();
                txtObservacion.Text = _SetInfo.Observacion;
                cmbBanco.EditValue = _SetInfo.IdBanco;
                searchLookUpEdit_Proveedor.EditValue=_SetInfo.IdProveedor;
                //cmbSucursal.SelectedValue= _SetInfo.IdSucusal;
                cmbTipoPagos.SelectedValue = _SetInfo.CodDocu_Pago;
                gridControlGastos.DataSource = BusDetalle.Get_List_ordencompra_ext_x_imp_gastosxImport_Det(_SetInfo);
                cmbTipoPagos_ValueChanged(new Object(), new EventArgs());
                ct_Cbtecble_det_Bus _CbteCbleBus = new ct_Cbtecble_det_Bus();
                ct_Cbtecble_Bus _CbteCbleBus_Cab = new ct_Cbtecble_Bus();
                List<ct_Cbtecble_det_Info> lm = new List<ct_Cbtecble_det_Info>();
                ct_Cbtecble_tipo_Bus BusTipoCbte = new ct_Cbtecble_tipo_Bus();
                string MensajeError = "";
                var TiposCtbts = BusTipoCbte.Get_list_Cbtecble_tipo(param.IdEmpresa,Cl_Enumeradores.eTipoFiltro.Normal, ref MensajeError);
                lm = _CbteCbleBus.Get_list_Cbtecble_det(param.IdEmpresa, tipocbte.IdTipoCbte, _SetInfo.IdCbteCble, ref MensajeError);
                #region Comentado
                
                
                //if (_SetInfo.Estado == "I")
                //{
                //    var _CbteCbleInfoCab = _CbteCbleBus_Cab.ObtenerObjeto(param.IdEmpresa, _SetInfo.IdTipoCbte_Anul,_SetInfo.IdCbteCble_Anulado);
                //    var tipoCprbate_Anulado = TiposCtbts.First(var => var.IdTipoCbte == _SetInfo.IdTipoCbte_Anul);
                //    //lblDiario.Text = lblDiario.Text + " " + _SetInfo.IdCbteCble_Anulado ;
                //    //LblTipoComprobante.Text = LblTipoComprobante.Text +": " + tipoCprbate_Anulado.tc_TipoCbte;
                //    //LblTipoComprobante.Visible = true;
                //    //lblObservacion.Text = lblObservacion.Text + " " + _CbteCbleInfoCab.Observacion;
                //    //lblObservacion.Visible = true;
                //    //lblfechaDiario.Text = _CbteCbleInfoCab.Fecha.ToShortDateString();
                //    //lblfechaDiario.Visible = true;
                //}
                //else
                //{
                //    var _CbteCbleInfoCab = _CbteCbleBus_Cab.ObtenerObjeto(param.IdEmpresa, _SetInfo.IdTipoCbte, _SetInfo.IdCbteCble);
                //    var tipoCprbate = TiposCtbts.First(var => var.IdTipoCbte == tipocbte.IdTipoCbte);
                //    //lblDiario.Text = lblDiario.Text + " " + _SetInfo.IdCbteCble ;
                //    //LblTipoComprobante.Text = LblTipoComprobante.Text +": " + tipoCprbate.tc_TipoCbte;
                //    //LblTipoComprobante.Visible = true;
                //    //lblObservacion.Text = lblObservacion.Text + " " + _CbteCbleInfoCab.Observacion;
                //    //lblObservacion.Visible = true;
                //    //lblfechaDiario.Text = _CbteCbleInfoCab.Fecha.ToShortDateString();
                //    //lblfechaDiario.Visible = true;
                //}

                //lblDiario.Visible = true;
                #endregion
                //ctrl_diario.set_CbteCbleInfo(lm);
                //gridControlDiarios.DataSource = Bus.DiariosXgastos(param.IdEmpresa, _SetInfo.IdSucusal, _SetInfo.IdOrdenCompraExt, _SetInfo.IdRegistroGasto);

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }
        
        public delegate void Delegate_frmImp_RegistroGastosImportacion_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event Delegate_frmImp_RegistroGastosImportacion_Mant_FormClosing Event_frmImp_RegistroGastosImportacion_Mant_FormClosing;
        
        private void frmImp_RegistroGastosImportacion_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
              Event_frmImp_RegistroGastosImportacion_Mant_FormClosing(sender, e);
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
                imp_ordencompra_ext_x_ct_cbtecble_Bus BusOrdxCbt = new imp_ordencompra_ext_x_ct_cbtecble_Bus();
                Get();
                ct_Cbtecble_Bus CbteCble_B = new ct_Cbtecble_Bus();
                if (lbl_Estado.Visible)
                {
                    MessageBox.Show("No se puede anular el gasto debido a que ya se encuentra anulado.", "Mensaje Erp");
                    return;
                }
                FrmGe_MotivoAnulacion oFrm = new FrmGe_MotivoAnulacion();
                if (MessageBox.Show("¿Está seguro que desea anular el Gasto #" + txtIdRegistroGasto.Text + " ?", "Anulación de Gastos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    oFrm.ShowDialog();
                    String MovitoAnulacion = oFrm.motivoAnulacion;
                    _Info.IdTipoCbte_Anul = tipocbte.IdTipoCbte_Anul;
                    string mensej = "";
                    if (Bus.AnularDB(_Info))
                    {
                        MessageBox.Show("Anulado con exito el Gasto # " + _Info.IdRegistroGasto);
                        lbl_Estado.Visible = true;
                        btnOk.Enabled = false;
                        BtnGuardarYsalir.Enabled = false;
                        decimal IdCbteCbleRev = 0;
                        string msg2 = "";
                        if (generarDiarioTipoImp == true)
                        {
                            CbteCble_B.ReversoCbteCble(param.IdEmpresa, _SetInfo.IdCbteCble, tipocbte.IdTipoCbte, tipocbte.IdTipoCbte_Anul, ref IdCbteCbleRev, ref msg2, param.IdUsuario, MovitoAnulacion);

                            Bus.ACtualizarAnulado(_Info, IdCbteCbleRev);
                            imp_ordencompra_ext_x_ct_cbtecble_Info ordCompraxCbte_info = new imp_ordencompra_ext_x_ct_cbtecble_Info();
                            ordCompraxCbte_info.ct_IdEmpresa = ordCompraxCbte_info.imp_IdEmpresa = param.IdEmpresa;
                            ordCompraxCbte_info.imp_IdOrdenCompraExt = Convert.ToDecimal(searchLookUpEditImportacion.EditValue);
                            var idSucursa = Importaciones.Find(var => var.IdOrdenCompraExt == ordCompraxCbte_info.imp_IdOrdenCompraExt).IdSucusal;
                            ordCompraxCbte_info.imp_IdSucusal = Convert.ToInt32(idSucursa);
                            ordCompraxCbte_info.ct_IdTipoCbte = tipocbte.IdTipoCbte_Anul;
                            ordCompraxCbte_info.ct_IdCbteCble = IdCbteCbleRev;
                            ordCompraxCbte_info.TipoReg = "AGAST";
                            BusOrdxCbt.GuardarDB(ordCompraxCbte_info, ref msg2);


                        }

                    }
                }

         
            
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
            
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void cmbTipoPagos_ValueChanged(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void cmbTipoPagos_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                imp_Tipo_docu_pago_Info tipo = (imp_Tipo_docu_pago_Info)cmbTipoPagos.SelectedItem;
                if (tipo.PideBanco == "S")
                {
                    pnlBanco.Visible = true;
                }
                else
                {
                    pnlBanco.Visible = false;
                }
                if (tipo.PideProveedor == "S")
                {
                    pnlProveedor.Visible = true;
                }
                else
                {
                    pnlProveedor.Visible = false;
                }

                var idtipodpago = InfoTipoPagoTipoCb.First(var => var.CodDocu_Pago == tipo.CodDocu_Pago);
                tipocbte.IdTipoCbte = idtipodpago.IdTipoCbte;
                tipocbte.IdTipoCbte_Anul = idtipodpago.IdTipoCbte_Anul;
                tipocbte.CodDocu_Pago = idtipodpago.CodDocu_Pago;
                if (idtipodpago != null)
                {
                    if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                    {
                        BtnGuardarYsalir.Enabled = true;
                        btnOk.Enabled = true;
                    }
                }

                GenerarDiario = true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    MessageBox.Show("Usted a Seleccionado Facrtura por proveedor este \n  diario se genera desde el modulo cuentas por Pagar", "Sistema Erp");
                    GenerarDiario = false;
                }
            }

        }


        private void label4_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }



        private void toolStripButton4_Click(object sender, EventArgs e)
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

        private void gridViewGastos_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }


        

        private void gridViewDiario_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                if (e.Button == System.Windows.Forms.MouseButtons.Left)
                {

        
                    
        


                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }


        
        private void BtnGuardarYsalir_Click(object sender, EventArgs e)
        {
            try
            {
                Get();
                txtObservacion.Focus();
                if (validar())
                {
                    btnOk_Click(sender, e);
                    Close();

                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
                MessageBox.Show(ex.ToString());
            }
        }

        private void gridViewGastos_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                 Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void gridViewGastos_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyValue.ToString() == "46")
                    gridViewGastos.DeleteSelectedRows();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void cmbBanco_ValueChanged(object sender, EventArgs e)
        {
            try
            {

                var OS = (ba_Banco_Cuenta_Info)cmbBanco.EditValue;//.ListObject;
                   if (string.IsNullOrEmpty(OS.IdCtaCble)) 
                    {
                        BtnGuardarYsalir.Enabled = false;
                        btnOk.Enabled = false;
                        MessageBox.Show("El banco seleccionado no posee cuenta contable");
                    }
                    else
                    {
                        BtnGuardarYsalir.Enabled = true;
                        btnOk.Enabled = true;
            }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void ultraComboImportacion_Validating(object sender, CancelEventArgs e)
        {
            
        }
        
        Boolean generarDiarioTipoImp;
        
        private void searchLookUpEditImportacion_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                var TipoImpr = ((List<imp_ordencompra_ext_Info>)(searchLookUpEditImportacion.Properties.DataSource)).First(v => v.IdOrdenCompraExt == Convert.ToDecimal(searchLookUpEditImportacion.EditValue));
                if (TipoImpr != null)
                {
                    lblTipoImportacion.Text = TipoImpr.Tipo_Importacion;
                    lblTipoImportacion.Visible = true;

                    if (TipoImpr.Tipo_Importacion == "IMPORTACION")
                    {
                        generarDiarioTipoImp = true;
                    }
                    else
                    {
                        generarDiarioTipoImp = false;
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            
                MessageBox.Show(ex.ToString());
            }
        }


        

        private void cmbBanco_EditValueChanged(object sender, EventArgs e)
        {
            try
            {

                var OS = (ba_Banco_Cuenta_Info)cmbBanco.EditValue;//.ListObject;
                if (string.IsNullOrEmpty(OS.IdCtaCble))
                {
                    BtnGuardarYsalir.Enabled = false;
                    btnOk.Enabled = false;
                    MessageBox.Show("El banco seleccionado no posee cuenta contable");
                }
                else
                {
                    BtnGuardarYsalir.Enabled = true;
                    btnOk.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }


    

        

        



    }
}
