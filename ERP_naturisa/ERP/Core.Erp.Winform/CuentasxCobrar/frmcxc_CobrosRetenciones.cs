using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;


using Core.Erp.Info.CuentasxCobrar;
using Core.Erp.Business.CuentasxCobrar;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Info.Facturacion;
using Core.Erp.Business.Facturacion;
using Core.Erp.Reportes.CuentasxCobrar;
using Cus.Erp.Reports.Naturisa.Contabilidad;
using Core.Erp.Reportes.Contabilidad;



namespace Core.Erp.Winform.CuentasxCobrar
{
    public partial class frmCxc_CobrosRetenciones : Form
    {

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cxc_cobro_tipo_Bus busTipCobro = new cxc_cobro_tipo_Bus();
        List<cxc_cobro_tipo_Info> LstTipCobro = new List<cxc_cobro_tipo_Info>();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        cxc_cobro_Info InfoGrabarRteFU = new cxc_cobro_Info();
        cxc_cobro_Info InfoGrabarRteIVA = new cxc_cobro_Info();
        List<cxc_cobro_Info> ListaGrabar = new List<cxc_cobro_Info>();
        string Tipo_documento = "";
        int IDCaja = 0;
        int contRetFU = 0;
        int contRetIVA = 0;


        fa_factura_Info InfoFactura = new fa_factura_Info();
        fa_notaCreDeb_Info InfoNota = new fa_notaCreDeb_Info();

        cxc_cobro_Bus busCobro = new cxc_cobro_Bus();
        BindingList<vwcxc_cobros_x_vta_nota_x_Ret_Info> ListBindRtFU = new BindingList<vwcxc_cobros_x_vta_nota_x_Ret_Info>();
        BindingList<vwcxc_cobros_x_vta_nota_x_Ret_Info> ListBindRtIVA = new BindingList<vwcxc_cobros_x_vta_nota_x_Ret_Info>();

        public Cl_Enumeradores.eTipo_action Accion { get; set; }
        cxc_cobro_tipo_Param_conta_x_sucursal_Bus busParam = new cxc_cobro_tipo_Param_conta_x_sucursal_Bus();

        public frmCxc_CobrosRetenciones()
        {
            InitializeComponent();
            try
            {
                cargarCombos();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        void cargarCombos()
        {
            try
            {
                LstTipCobro = busTipCobro.Get_List_Cobro_Tipo();
                cmb_TipoRteFU.DataSource = LstTipCobro.FindAll(var => var.ESRetenFTE.Trim() == "S");
                cmb_tipoRetIVA.DataSource = LstTipCobro.FindAll(var => var.ESRetenIVA.Trim() == "S");
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mnu_salir_Click(object sender, EventArgs e)
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

        public void setInfo(fa_factura_Info Info_FACT, fa_notaCreDeb_Info Info_ND, string NomCliente, int idCaja, string _Tipo_documento)
        {
            try
            {
                Tipo_documento = _Tipo_documento;
                int IdSucursal = Tipo_documento == "FACT" ? Info_FACT.IdSucursal : Info_ND.IdSucursal;
                int IdBodega = Tipo_documento == "FACT" ? Info_FACT.IdBodega : Info_ND.IdBodega;
                decimal IdCbteVta = Tipo_documento == "FACT" ? Info_FACT.IdCbteVta : Info_ND.IdNota;

                switch (Tipo_documento)
                {
                    case "FACT":
                        InfoFactura = Info_FACT;
                        txttipoDoc.Text = Info_FACT.vt_tipoDoc.Trim();
                        IDCaja = idCaja;
                        txtNCobro.Text = Info_FACT.vt_NumFactura;
                        txtNomCliente.Text = NomCliente;
                        txtSubtotal.Text = Convert.ToString(Info_FACT.Subtotal);
                        txtIVA.Text = Convert.ToString(Info_FACT.IVA);
                        txtTotal.Text = Convert.ToString(Info_FACT.Total);                        
                    break;
                    case "NTDB":
                        InfoNota = Info_ND;
                        txttipoDoc.Text = Tipo_documento;
                        IDCaja = idCaja;
                        txtNCobro.Text = Info_ND.NumNota_Impresa;
                        txtNomCliente.Text = NomCliente;
                        txtSubtotal.Text = Convert.ToString(Info_ND.Subtotal);
                        txtIVA.Text = Convert.ToString(Info_ND.Iva);
                        txtTotal.Text = Convert.ToString(Info_ND.Total);
                    break;    
                }

                List<vwcxc_cobros_x_vta_nota_x_Ret_Info> ListaRFU = busCobro.Get_List_cobro_x_RteFte(param.IdEmpresa, IdSucursal, IdBodega, IdCbteVta, Tipo_documento);
                List<vwcxc_cobros_x_vta_nota_x_Ret_Info> ListaRIVA = busCobro.Get_List_cobro_x_RteIVA(param.IdEmpresa, IdSucursal, IdBodega, IdCbteVta, Tipo_documento);
                
                ListaRFU.ForEach(var => { var.Modificable = false; contRetFU = 1; });
                ListaRIVA.ForEach(var => { var.Modificable = false; contRetIVA = 1; });

                ListBindRtFU = new BindingList<vwcxc_cobros_x_vta_nota_x_Ret_Info>(ListaRFU);
                ListBindRtIVA = new BindingList<vwcxc_cobros_x_vta_nota_x_Ret_Info>(ListaRIVA);

                ListaGrabar = new List<cxc_cobro_Info>();

                foreach (var item in ListaRFU)
                {
                    cxc_cobro_Info info_cobro = new cxc_cobro_Info();
                    info_cobro.IdEmpresa = param.IdEmpresa;
                    info_cobro.IdSucursal = item.IdSucursal;
                    info_cobro.IdCobro = item.IdCobro;
                    ListaGrabar.Add(info_cobro);
                }
                foreach (var item in ListaRIVA)
                {
                    cxc_cobro_Info info_cobro = new cxc_cobro_Info();
                    info_cobro.IdEmpresa = param.IdEmpresa;
                    info_cobro.IdSucursal = item.IdSucursal;
                    info_cobro.IdCobro = item.IdCobro;
                    ListaGrabar.Add(info_cobro);
                }

                gridControlRteFU.DataSource = ListBindRtFU;
                gridControlRteIVA.DataSource = ListBindRtIVA;                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Boolean grabar()
        {
            txtSubtotal.Focus();
            Boolean res = true;
            
            string mensajeE = "";

            try
            {
                if (validar())
                {
                    foreach (var item in ListaGrabar)
                    {
                        cxc_cobro_Info info = item;
                        if (!busCobro.GuardarDB(Cl_Enumeradores.PantallaEjecucion.COBROS, ref info, ref mensajeE))
                        {
                            mensajeE = mensajeE + " \n\n" + " Tipo Cobro: " + info.IdCobro_tipo + " Valor:" + info.dc_ValorPago;
                            res = false;
                        }
                        else
                        {
                            item.IdSucursal = info.IdSucursal;
                            item.IdCobro = info.IdCobro;
                        }
                    }

                    if (res == false)
                    {
                        MessageBox.Show("al menos uno de los cobros no se guardo.. :" + mensajeE, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {

                        MessageBox.Show("Se guardo con exito la retención.", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (MessageBox.Show("¿Desea imprimir la retención?",param.Nombre_sistema,MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            

                            switch (param.IdCliente_Ven_x_Default)
                            {
                                case Cl_Enumeradores.eCliente_Vzen.GRAFINPRENT:
                                    CargarReporte();
                                    break;
                                case Cl_Enumeradores.eCliente_Vzen.NATURISA:
                                    CargarReporte_diarios();
                                    break;
                                default:
                                    CargarReporte();
                                    if (MessageBox.Show("¿Desea imprimir los diarios de la retención?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                    {
                                        CargarReporte_diarios();
                                    }
                                    break;
                            }
                            
                        }
                    }

                    btnGuardar.Enabled = false;
                    btnGuardarSalir.Enabled = false;
                }
                else res = false;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                res = false;
            }
            return res;
        }

        private void btnGuardarSalir_Click(object sender, EventArgs e)
        {
            try
            {
                if (grabar())
                { Close(); }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private Boolean validar()
        {
            Boolean res = true;
            try
            {
                ///Verifica que todos los Tipos de Cobros tengan asociados las Ctas Cbles Deudora y Acreedora en 
                ///la tabla cxc_cobro_tipo_Param_conta_x_sucursal
                {
                    if (txtObservaciones.EditValue == null )
                    {
                        MessageBox.Show("Ingrese la Observación.", param.Nombre_sistema, MessageBoxButtons.OK);
                        return false;
                    }

                    List<cxc_cobro_tipo_Param_conta_x_sucursal_Info> paramCxC = new List<cxc_cobro_tipo_Param_conta_x_sucursal_Info>();
                    paramCxC = busParam.Get_List_cobro_tipo_Param_conta_x_sucursal(param.IdEmpresa);
                    foreach (var item in ListBindRtFU)
                    {
                        if (item.Modificable == true)
                        {
                            cxc_cobro_tipo_Param_conta_x_sucursal_Info tipocobro = new cxc_cobro_tipo_Param_conta_x_sucursal_Info();
                            try
                            {
                                tipocobro = paramCxC.First(var => var.IdCobro_tipo == item.IdCobro_tipo);
                                if (tipocobro == null || tipocobro.IdCobro_tipo == null
                                    || String.IsNullOrEmpty(tipocobro.IdCtaCble))
                                {
                                    MessageBox.Show("Por favor, verifique los parametros de Ctas Cbles x Tipos de Cobro..", param.Nombre_sistema, MessageBoxButtons.OK);
                                    return false;
                                }
                            }
                            catch (Exception ex)
                            {
                                Log_Error_bus.Log_Error(ex.ToString());
                                MessageBox.Show("Por favor, verifique los parametros de Ctas Cbles x Tipos de Cobro..", param.Nombre_sistema, MessageBoxButtons.OK);
                                return false;
                            }

                        }
                    }

                    foreach (var item in ListBindRtIVA)
                    {
                        if (item.Modificable == true)
                        {
                            cxc_cobro_tipo_Param_conta_x_sucursal_Info tipocobro = new cxc_cobro_tipo_Param_conta_x_sucursal_Info();
                            try
                            {
                                tipocobro = paramCxC.First(var => var.IdCobro_tipo == item.IdCobro_tipo);
                                if (tipocobro == null || tipocobro.IdCobro_tipo == null
                                    || String.IsNullOrEmpty(tipocobro.IdCtaCble))
                                {
                                    MessageBox.Show("Por favor, verifique los parametros de Ctas Cbles x Tipos de Cobro..", param.Nombre_sistema, MessageBoxButtons.OK);
                                    return false;
                                }
                            }
                            catch (Exception ex)
                            {
                                Log_Error_bus.Log_Error(ex.ToString());
                                MessageBox.Show("Por favor, verifique los parametros de Ctas Cbles x Tipos de Cobro..", param.Nombre_sistema, MessageBoxButtons.OK);
                                return false;
                            }
                        }

                    }
                }
                ///No se actualiza por eso verifica que haya por lo menos un registro nuevo a grabar
                ///
                try
                {

                    

                    if ((ListBindRtFU.Count < 1 && ListBindRtIVA.Count < 1))
                    {
                        MessageBox.Show("Por favor, ingrese una nueva retención para grabar..", param.Nombre_sistema, MessageBoxButtons.OK);
                        return false;
                    }
                }

                catch (Exception ex)
                {
                    Log_Error_bus.Log_Error(ex.ToString());
                    MessageBox.Show("Por favor, ingrese una nueva retención para grabar..", param.Nombre_sistema, MessageBoxButtons.OK);
                    return false;
                }

                ///(ListBindRtFU.All(var => var.Modificable != true) && 
                ///ListBindRtIVA.All(var => var.Modificable != true)))
                ///
                int cont = 0;
                foreach (var item in ListBindRtFU)
                {
                    if (item.Modificable == true)
                    {
                        if (Convert.ToDouble(item.Base) <= 0)
                        {
                            MessageBox.Show("Por favor, revise las Bases de la Rte FU, no puede ser 0.", param.Nombre_sistema, MessageBoxButtons.OK);
                            return false;
                        }
                        else
                            if (String.IsNullOrEmpty(item.IdCobro_tipo))
                            {
                                MessageBox.Show("Por favor, seleccione los tipos de retención en la fuente..", param.Nombre_sistema, MessageBoxButtons.OK);
                                return false;

                            }
                            else cont++;
                    }
                }
                foreach (var item in ListBindRtIVA)
                {
                    if (item.Modificable == true)
                    {
                        if (Convert.ToDouble(item.Base) <= 0)
                        {
                            MessageBox.Show("Por favor, revise las Bases de la Rte FU, no puede ser 0.", param.Nombre_sistema, MessageBoxButtons.OK);
                            return false;
                        }
                        else
                            if (String.IsNullOrEmpty(item.IdCobro_tipo))
                            {
                                MessageBox.Show("Por favor, seleccione los tipos de retención en la fuente..", param.Nombre_sistema, MessageBoxButtons.OK);
                                return false;

                            }
                            else cont++;
                    }
                }

                if (cont == 0)
                {
                    MessageBox.Show("Por favor, ingrese una nueva retención para grabar..", param.Nombre_sistema, MessageBoxButtons.OK);
                    return false;

                }


                ///validar que la base de la Rte FU no sume más que el subtotal de la factura y el IVA
                ///
                double totalBase = 0;
                foreach (var item in ListBindRtFU)
                {
                    totalBase = totalBase + Convert.ToDouble(item.Base);
                }
                if (Math.Round(totalBase, 2) >Math.Round(Convert.ToDouble(txtSubtotal.Text),2))
                {
                    MessageBox.Show(
                        "Por favor, revise la suma de la Base de la Retención de la Fuente excede el Subtotal de la factura.."
                        , param.Nombre_sistema, MessageBoxButtons.OK);
                    return false;
                }
                totalBase = 0;
                foreach (var item in ListBindRtIVA)
                {
                    totalBase = totalBase + Convert.ToDouble(item.Base);
                }
                if (Math.Round(totalBase,2) > Math.Round(Convert.ToDouble(txtIVA.Text),2))
                {
                    MessageBox.Show(
                        "Por favor, revise la suma de la Base de la Retención del IVA excede el IVA de la factura.."
                        , param.Nombre_sistema, MessageBoxButtons.OK);
                    return false;
                }

                res = getInfo();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                res = false;
            }
            return res;

        }

        private Boolean getInfo()
        {
            Boolean res = true;
            ListaGrabar = new List<cxc_cobro_Info>();
            try
            {
                foreach (var item in ListBindRtFU)
                {
                    if (item.Modificable == true)
                    {
                        cxc_cobro_Info info = new cxc_cobro_Info();
                        cxc_cobro_Det_Info det = new cxc_cobro_Det_Info();
                        ///cabecera
                        ///
                        info.IdEmpresa = det.IdEmpresa = param.IdEmpresa;
                        info.IdSucursal = det.IdSucursal = Tipo_documento == "FACT" ? InfoFactura.IdSucursal : InfoNota.IdSucursal;
                        info.IdBodega_Cbte = det.IdBodega_Cbte = Tipo_documento == "FACT" ? InfoFactura.IdBodega : InfoNota.IdBodega;
                        info.IdCliente = Tipo_documento == "FACT" ? InfoFactura.IdCliente : InfoNota.IdCliente;
                        det.IdCbte_vta_nota = Tipo_documento == "FACT" ? InfoFactura.IdCbteVta : InfoNota.IdNota;

                        info.IdCaja = IDCaja;                        
                        info.IdCobro_tipo = item.IdCobro_tipo;
                        info.cr_NumDocumento = item.cr_NumDocumento;

                        info.cr_fecha = Convert.ToDateTime(item.cr_fecha.ToShortDateString());
                        info.cr_fechaDocu = Convert.ToDateTime(item.cr_fechaDocu.ToShortDateString());
                        info.cr_fechaCobro = Convert.ToDateTime(item.cr_fechaDocu.ToShortDateString());

                        
                        
                        info.cr_observacion = txtObservaciones.EditValue + "Ret:FTE" + item.PorcentajeRet + "% ";
                        info.estado = "A";
                        info.IdUsuario = det.IdUsuario = param.IdUsuario;
                        info.Fecha_Transac = det.Fecha_Transac = param.Fecha_Transac;
                        info.ip = param.ip;
                        info.nom_pc = param.nom_pc;
                        info.IdBanco = null;

                        ///detalle
                        ///
                        det.dc_TipoDocumento = txttipoDoc.Text.Trim();                        
                        det.secuencial = 1;
                        info.cr_TotalCobro = det.dc_ValorPago = Convert.ToDouble(item.dc_ValorPago);
                        info.ListaCobro = new List<cxc_cobro_Det_Info>();
                        info.ListaCobro.Add(det);
                        ListaGrabar.Add(info);
                    }
                }

                foreach (var item in ListBindRtIVA)
                {
                    if (item.Modificable == true)
                    {
                        cxc_cobro_Info info = new cxc_cobro_Info();
                        cxc_cobro_Det_Info det = new cxc_cobro_Det_Info();
                        ///cabecera
                        ///
                        info.IdEmpresa = det.IdEmpresa = param.IdEmpresa;
                        info.IdSucursal = det.IdSucursal = Tipo_documento == "FACT" ? InfoFactura.IdSucursal : InfoNota.IdSucursal;
                        info.IdBodega_Cbte = det.IdBodega_Cbte = Tipo_documento == "FACT" ? InfoFactura.IdBodega : InfoNota.IdBodega;
                        info.IdCliente = Tipo_documento == "FACT" ? InfoFactura.IdCliente : InfoNota.IdCliente;
                        info.IdCaja = IDCaja;                        
                        info.IdCobro_tipo = item.IdCobro_tipo;
                        info.cr_NumDocumento = item.cr_NumDocumento;

                        info.cr_fecha = Convert.ToDateTime(item.cr_fecha.ToShortDateString());
                        info.cr_fechaDocu = Convert.ToDateTime(item.cr_fechaDocu.ToShortDateString());
                        info.cr_fechaCobro = Convert.ToDateTime(item.cr_fechaDocu.ToShortDateString());

                        info.cr_observacion = txtObservaciones.EditValue +  "Ret:IVA" + item.PorcentajeRet + "% ";
                        info.estado = "A";
                        info.IdUsuario = det.IdUsuario = param.IdUsuario;
                        info.Fecha_Transac = det.Fecha_Transac = param.Fecha_Transac;
                        info.ip = param.ip;
                        info.nom_pc = param.nom_pc;
                        info.IdBanco = null;
                        ///detalle
                        ///
                        det.dc_TipoDocumento = txttipoDoc.Text.Trim();
                        det.IdCbte_vta_nota = Tipo_documento == "FACT" ? InfoFactura.IdCbteVta : InfoNota.IdNota;
                        det.secuencial = 1;
                        info.cr_TotalCobro = det.dc_ValorPago = Convert.ToDouble(item.dc_ValorPago);
                        info.ListaCobro = new List<cxc_cobro_Det_Info>();
                        info.ListaCobro.Add(det);
                        ListaGrabar.Add(info);
                    }
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                res = false;
            } 
            return res;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
              grabar();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        
        private void gridViewRteFU_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                if (e.Column.FieldName == "IdCobro_tipo")
                {
                    vwcxc_cobros_x_vta_nota_x_Ret_Info row = (vwcxc_cobros_x_vta_nota_x_Ret_Info)gridViewRteFU.GetFocusedRow();
                    if (row != null)
                    {
                        cxc_cobro_tipo_Info tipo = LstTipCobro.First(var => var.IdCobro_tipo == e.Value);
                        gridViewRteFU.SetFocusedRowCellValue("PorcentajeRet", tipo.PorcentajeRet);
                        if (row.Base != null && row.Base > 0)
                        {
                            gridViewRteFU.SetFocusedRowCellValue("dc_ValorPago", row.Base * row.PorcentajeRet / 100);
                        }
                        if (contRetFU == 0)
                        { gridViewRteFU.SetFocusedRowCellValue("Base", Convert.ToDouble(txtSubtotal.Text)); contRetFU = 1; }
                    }
                }
                else if (e.Column.FieldName == "Base")
                {
                    vwcxc_cobros_x_vta_nota_x_Ret_Info row = (vwcxc_cobros_x_vta_nota_x_Ret_Info)gridViewRteFU.GetFocusedRow();
                    if (row != null)
                    {

                        if (row.Base != null && row.Base > 0)
                        {
                            gridViewRteFU.SetFocusedRowCellValue("dc_ValorPago", row.Base * row.PorcentajeRet / 100);
                            gridViewRteFU.SetFocusedRowCellValue("Modificable", true);
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewRteIVA_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                if (e.Column.FieldName == "IdCobro_tipo")
                {
                    vwcxc_cobros_x_vta_nota_x_Ret_Info row = (vwcxc_cobros_x_vta_nota_x_Ret_Info)gridViewRteIVA.GetFocusedRow();
                    if (row != null)
                    {
                        cxc_cobro_tipo_Info tipo = LstTipCobro.First(var => var.IdCobro_tipo == e.Value);
                        gridViewRteIVA.SetFocusedRowCellValue("PorcentajeRet", tipo.PorcentajeRet);
                        if (row.Base != null && row.Base > 0)
                        {
                            gridViewRteIVA.SetFocusedRowCellValue("dc_ValorPago", row.Base * row.PorcentajeRet / 100);
                        }
                        gridViewRteIVA.SetFocusedRowCellValue("Modificable", true);
                        if (contRetIVA == 0)
                        {
                            gridViewRteIVA.SetFocusedRowCellValue("Base", Convert.ToDouble(txtIVA.Text)); contRetIVA = 1;
                        }
                    }
                }
                else if (e.Column.FieldName == "Base")
                {
                    vwcxc_cobros_x_vta_nota_x_Ret_Info row = (vwcxc_cobros_x_vta_nota_x_Ret_Info)gridViewRteIVA.GetFocusedRow();
                    if (row != null)
                    {

                        if (row.Base != null && row.Base > 0)
                        {
                            gridViewRteIVA.SetFocusedRowCellValue("dc_ValorPago", row.Base * row.PorcentajeRet / 100);
                            gridViewRteIVA.SetFocusedRowCellValue("Modificable", true);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridControlRteFU_Click(object sender, EventArgs e)
        {

        }

        private void gridViewRteFU_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                vwcxc_cobros_x_vta_nota_x_Ret_Info row = (vwcxc_cobros_x_vta_nota_x_Ret_Info)gridViewRteFU.GetFocusedRow();
                if (row != null)
                {
                    if (row.Modificable == false)
                    {
                        colcr_fechaCobro.OptionsColumn.AllowEdit = false;
                        colIdCobro_tipo2.OptionsColumn.AllowEdit = false;
                        colBase1.OptionsColumn.AllowEdit = false;
                        colPorcentajeRet2.OptionsColumn.AllowEdit = false;
                        coldc_ValorPago.OptionsColumn.AllowEdit = false;
                        colcr_NumDocumento1.OptionsColumn.AllowEdit = false;
                    }
                    else// if(row.Modificable == true)
                    {
                        colcr_fechaCobro.OptionsColumn.AllowEdit = true;
                        colIdCobro_tipo2.OptionsColumn.AllowEdit = true;
                        colBase1.OptionsColumn.AllowEdit = true;
                        colPorcentajeRet2.OptionsColumn.AllowEdit = true;
                        coldc_ValorPago.OptionsColumn.AllowEdit = true;
                        colcr_NumDocumento1.OptionsColumn.AllowEdit = true;
                    }
                }
                else
                {
                    colcr_fechaCobro.OptionsColumn.AllowEdit = true;
                    colIdCobro_tipo2.OptionsColumn.AllowEdit = true;
                    colBase1.OptionsColumn.AllowEdit = true;
                    colPorcentajeRet2.OptionsColumn.AllowEdit = true;
                    coldc_ValorPago.OptionsColumn.AllowEdit = true;
                    colcr_NumDocumento1.OptionsColumn.AllowEdit = true;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void gridViewRteIVA_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                vwcxc_cobros_x_vta_nota_x_Ret_Info row = (vwcxc_cobros_x_vta_nota_x_Ret_Info)gridViewRteIVA.GetFocusedRow();
                if (row != null)
                {
                    if (row.Modificable == false)
                    {
                        colcr_fecha_ri.OptionsColumn.AllowEdit = false;
                        colIdCobro_tipo3.OptionsColumn.AllowEdit = false;
                        colBase.OptionsColumn.AllowEdit = false;
                        colPorcentajeRet3.OptionsColumn.AllowEdit = false;
                        coldc_ValorPago1.OptionsColumn.AllowEdit = false;
                        colcr_NumDocumento.OptionsColumn.AllowEdit = false;
                    }
                    else //if (row.Modificable == true)
                    {
                        colcr_fecha_ri.OptionsColumn.AllowEdit = true;
                        colIdCobro_tipo3.OptionsColumn.AllowEdit = true;
                        colBase.OptionsColumn.AllowEdit = true;
                        colPorcentajeRet3.OptionsColumn.AllowEdit = true;
                        coldc_ValorPago1.OptionsColumn.AllowEdit = true;
                        colcr_NumDocumento.OptionsColumn.AllowEdit = true;
                    }
                }
                else
                {

                    colcr_fecha_ri.OptionsColumn.AllowEdit = true;
                    colIdCobro_tipo3.OptionsColumn.AllowEdit = true;
                    colBase.OptionsColumn.AllowEdit = true;
                    colPorcentajeRet3.OptionsColumn.AllowEdit = true;
                    coldc_ValorPago1.OptionsColumn.AllowEdit = true;
                    colcr_NumDocumento.OptionsColumn.AllowEdit = true;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewRteFU_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode.ToString() == "Delete")
                {

                    vwcxc_cobros_x_vta_nota_x_Ret_Info row = (vwcxc_cobros_x_vta_nota_x_Ret_Info)gridViewRteFU.GetFocusedRow();
                   

                    if (row != null)
                    {
                        if (row.Modificable == false)
                        {
                            MessageBox.Show("No se puede modificar un registro grabado");
                        }else
                            gridViewRteFU.DeleteSelectedRows();
                    }else gridViewRteFU.DeleteSelectedRows();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewRteIVA_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode.ToString() == "Delete")
                {

                    vwcxc_cobros_x_vta_nota_x_Ret_Info row = (vwcxc_cobros_x_vta_nota_x_Ret_Info)gridViewRteIVA.GetFocusedRow();
                 
                    if (row != null)
                    {
                        if (row.Modificable == false)
                        {
                            MessageBox.Show("No se puede modificar un registro grabado");
                        }
                        else
                            gridViewRteIVA.DeleteSelectedRows();
                    }
                    else gridViewRteIVA.DeleteSelectedRows();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmcxc_CobrosRetenciones_Load(object sender, EventArgs e)
        {
            try
            {
                if (Accion == Cl_Enumeradores.eTipo_action.consultar)
                {
                    btnGuardar.Enabled = false;
                    btnGuardarSalir.Enabled = false;
                    gridViewRteIVA.OptionsBehavior.ReadOnly = true;
                    gridViewRteIVA.OptionsBehavior.ReadOnly = true;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

          
        }

        private void gridViewRteFU_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                vwcxc_cobros_x_vta_nota_x_Ret_Info row = (vwcxc_cobros_x_vta_nota_x_Ret_Info)gridViewRteFU.GetFocusedRow();
                if (row != null)
                {
                    if (row.Modificable == false)
                    {
                        colcr_fechaCobro.OptionsColumn.AllowEdit = false;
                        colIdCobro_tipo2.OptionsColumn.AllowEdit = false;
                        colBase1.OptionsColumn.AllowEdit = false;
                        colPorcentajeRet2.OptionsColumn.AllowEdit = false;
                        coldc_ValorPago.OptionsColumn.AllowEdit = false;
                        colcr_NumDocumento1.OptionsColumn.AllowEdit = false;
                    }
                    else// if(row.Modificable == true)
                    {
                        colcr_fechaCobro.OptionsColumn.AllowEdit = true;
                        colIdCobro_tipo2.OptionsColumn.AllowEdit = true;
                        colBase1.OptionsColumn.AllowEdit = true;
                        colPorcentajeRet2.OptionsColumn.AllowEdit = true;
                        coldc_ValorPago.OptionsColumn.AllowEdit = true;
                        colcr_NumDocumento1.OptionsColumn.AllowEdit = true;
                    }
                }
               
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }    

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                switch (param.IdCliente_Ven_x_Default)
                {
                    case Cl_Enumeradores.eCliente_Vzen.GRAFINPRENT:
                        CargarReporte();
                        break;
                    case Cl_Enumeradores.eCliente_Vzen.NATURISA:
                        CargarReporte_diarios();
                        break;
                    default:
                        CargarReporte();
                        if (MessageBox.Show("¿Desea imprimir los diarios de la retención?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            CargarReporte_diarios();
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        void CargarReporte()
        {
            try
            {                


                XCXC_Rpt016_Rpt reporte = new XCXC_Rpt016_Rpt();
                reporte.RequestParameters = false;
                reporte.PIdEmpresa.Value = Tipo_documento == "FACT" ? InfoFactura.IdEmpresa : InfoNota.IdEmpresa;
                reporte.PIdEmpresa.Visible = false;
                reporte.PIdSucursal.Value = Tipo_documento == "FACT" ? InfoFactura.IdSucursal : InfoNota.IdSucursal;
                reporte.PIdSucursal.Visible = false;
                reporte.PIdBodega_Cbte.Value = Tipo_documento == "FACT" ? InfoFactura.IdBodega : InfoNota.IdBodega;
                reporte.PIdBodega_Cbte.Visible = false;
                reporte.PIdCbte_vta_nota.Value = Tipo_documento == "FACT" ? InfoFactura.IdCbteVta : InfoNota.IdNota;
                reporte.PIdCbte_vta_nota.Visible = false;
                reporte.PTipoDocumento.Value = Tipo_documento;
                reporte.PTipoDocumento.Visible = false;

                reporte.ShowPreview();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void CargarReporte_diarios()
        {
            try
            {
                cxc_cobro_x_ct_cbtecble_Bus bus_cbte_x_cobro = new cxc_cobro_x_ct_cbtecble_Bus();
                foreach (var item in ListaGrabar)
                {
                    cxc_cobro_x_ct_cbtecble_Info info_cbte_x_cobro = new cxc_cobro_x_ct_cbtecble_Info();
                    info_cbte_x_cobro = bus_cbte_x_cobro.Get_Info_cobro_x_ct_cbtecble(item.IdEmpresa, item.IdSucursal, item.IdCobro);
                    if (info_cbte_x_cobro!= null)
                    {
                        switch (param.IdCliente_Ven_x_Default)
                        {
                           case Cl_Enumeradores.eCliente_Vzen.NATURISA:
                        XCONTA_NATU_Rpt002_Rpt reporte_personalizado = new XCONTA_NATU_Rpt002_Rpt();

                        reporte_personalizado.PIdEmpresa.Value = param.IdEmpresa;
                        reporte_personalizado.PIdTipoCbte.Value = info_cbte_x_cobro.ct_IdTipoCbte;
                        reporte_personalizado.PIdCbteCble.Value = info_cbte_x_cobro.ct_IdCbteCble;
                        reporte_personalizado.RequestParameters = false;
                        reporte_personalizado.PIdEmpresa.Visible = false;
                        reporte_personalizado.PIdTipoCbte.Visible = false;
                        reporte_personalizado.PIdCbteCble.Visible = false;
                        reporte_personalizado.ShowPreviewDialog();
                        break;
                    default:
                        XCONTA_Rpt003_rpt reporte = new XCONTA_Rpt003_rpt();

                        reporte.set_parametros(param.IdEmpresa, info_cbte_x_cobro.ct_IdTipoCbte, info_cbte_x_cobro.ct_IdCbteCble);
                        reporte.RequestParameters = false;
                        reporte.ShowPreviewDialog();
                        break;
                        }   
                    }
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}

