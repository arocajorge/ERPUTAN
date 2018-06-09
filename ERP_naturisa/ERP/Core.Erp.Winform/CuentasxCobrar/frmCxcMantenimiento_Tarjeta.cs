using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.CuentasxCobrar;
using Core.Erp.Business.General;
using Core.Erp.Info.CuentasxCobrar;
using Core.Erp.Business.Bancos;
using Core.Erp.Info.Facturacion;
using Core.Erp.Business.Facturacion;
using System.Diagnostics;
using Core.Erp.Info.General;
///Prog: Héctor Ayauca
///V 10.13 22022014
///

namespace Core.Erp.Winform.CuentasxCobrar
{
    public partial class frmCxcMantenimiento_Tarjeta : Form
    {
        public frmCxcMantenimiento_Tarjeta()
        {
            try
            {
               InitializeComponent();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        #region declaraciones

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cxc_cobro_Bus Bus = new cxc_cobro_Bus();
        cxc_cobro_x_tarjeta_Bus BusCobroTarjeta = new cxc_cobro_x_tarjeta_Bus();
        cxc_cobro_Info infoCxC = new cxc_cobro_Info();
        cxc_cobro_tipo_Bus BusTipo = new cxc_cobro_tipo_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        List<cxc_cobro_Info> lista = new List<cxc_cobro_Info>();
        List<cxc_cobro_tipo_Info> listaTipo = new List<cxc_cobro_tipo_Info>();
        ba_Banco_Cuenta_Bus busBancoCta = new ba_Banco_Cuenta_Bus();
        fa_notaCreDeb_Info NDCInfo = new fa_notaCreDeb_Info();
        List<fa_notaCreDeb_det_Info> ListaNDC = new List<fa_notaCreDeb_det_Info>(); 
        cxc_parametro_Bus busParam = new cxc_parametro_Bus();
        cxc_parametro_Info infoParam = new cxc_parametro_Info(); 
        cxc_cobro_x_EstadoCobro_Bus busCobroEstado = new cxc_cobro_x_EstadoCobro_Bus();
        List<cxc_cobro_x_EstadoCobro_Info> listaCxCestado = new List<cxc_cobro_x_EstadoCobro_Info>();
        

        string msg = "";
        decimal d = 0;
        decimal idcobro = 0;
        string idtipocobro = "";
        #endregion

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


        private void btnCobrar_Click(object sender, EventArgs e)
        {
            try
            {
                recalcular();
                int cantRegistros = 0;
                txtFocus.Focus();
                lista = new List<cxc_cobro_Info>();
                listaCxCestado = new List<cxc_cobro_x_EstadoCobro_Info>();
                lista = ((List<cxc_cobro_Info>)gridConsulta.DataSource).Where(q => (q.chek == true || q.cr_estadoCobro == "PORC") &&q.ValorCheque>0 && q.ValorCheque<q.cr_TotalCobro).ToList();

                foreach (var item in lista)
                {
                    cxc_cobro_x_EstadoCobro_Info info = new cxc_cobro_x_EstadoCobro_Info();
                    info.Fecha = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                    info.IdCobro = item.IdCobro;
                    info.IdCobro_tipo = item.IdCobro_tipo;
                    info.IdEmpresa = param.IdEmpresa;
                    info.IdEstadoCobro = "COBR";
                    info.observacion = "Tipo Pago " + ((Convert.ToString(item.TipoPagoTarjeta) == "EFEC") ? Convert.ToString(item.TipoPagoTarjeta) : Convert.ToString(item.TipoPagoTarjeta)+" del Banco " + Convert.ToString(item.BancoTarjeta)) + 
                        ((Convert.ToString(item.RF)=="")?"":" con "+Convert.ToString(item.RF)+" de "+Convert.ToString(item.valorRF))+
                        ((Convert.ToString(item.RI)=="")?"":" con "+Convert.ToString(item.RI)+" de "+Convert.ToString(item.valorRI))+
                        " Por el monto de " + item.ValorCheque.ToString();
                    info.IdSucursal = item.IdSucursal;
                    listaCxCestado.Add(info);
                }
                
                
                if (validarDatos())
                {
                    if (MessageBox.Show("¿Desea Continuar?", "?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        foreach (var item in lista)
                        {
                            idcobro = item.IdCobro;
                            idtipocobro = item.IdCobro_tipo;

                            //guarda la comision
                            if (item.valorComision > 0)
                            {
                                guardarRF(item, infoParam.pa_IdCobro_tipo_Comision_TC, item.valorComision);
                            }
                            //guarda la retencion fte
                            if (item.valorRF > 0)
                            {
                                guardarRF(item, item.RF, item.valorRF);
                            }
                            //guarda la retencion de iva
                            if (item.valorRI > 0)
                            {
                                guardarRF(item, item.RI, item.valorRI);
                            }

                            if (Convert.ToString(item.TipoPagoTarjeta) != null)
                            {
                                guardarRF(item, item.TipoPagoTarjeta, item.ValorCheque, Convert.ToString(item.BancoTarjeta), item.cuentaTarjeta, item.chequeTarjeta);
                                if (busCobroEstado.GuardarDB_Verifica_si_es_Protestado(listaCxCestado, ref msg))
                                    cantRegistros = cantRegistros + 1;
                            }
                        }

                        MessageBox.Show("Se Guardo con exito " + cantRegistros + " Registros", "OK", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }


                    cargarGrid();
                }
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private Boolean validarDatos() 
        {
            try
            {
                lista = ((List<cxc_cobro_Info>)gridConsulta.DataSource).Where(q => (q.chek == true || q.cr_estadoCobro == "PORC") && q.ValorCheque > 0 ).ToList();

                if (lista.Count() == 0)
                {
                    MessageBox.Show("No ha seleccionado ningun registro Valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }


                foreach (var item in lista)
                {                    
                    if (item.cr_TotalCobro != (item.valorComision + item.valorRF + item.valorRI + item.ValorCheque))
                    {
                        MessageBox.Show("La sumatoria de los valores no conciden en el cobro " + item.IdCobro, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }

                    if (item.valorRF != 0)
                    {
                        if (item.RF == null || item.RF == "")
                        {
                            MessageBox.Show("Ingrese el Tipo de Retencion en la Fuente en el cobro " + item.IdCobro, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return false;
                        }
                    }

                    if (item.valorRI != 0)
                    {
                        if (item.RI == null || item.RI == "")
                        {
                            MessageBox.Show("Ingrese el Tipo de Retencion del IVA en el cobro " + item.IdCobro, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return false;
                        }
                    }

                    if (item.TipoPagoTarjeta == null || item.TipoPagoTarjeta == "")
                    {
                        MessageBox.Show("Ingrese la Forma de Pago en el cobro " + item.IdCobro, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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



        private void guardarRF(cxc_cobro_Info info,string tipoCobro,double valor,string banco="",string cuenta="",string numCh="")
        {
            try
            {     
                

                info.cr_observacion = "Cobro por " + tipoCobro + " de la Tarjeta " + info.cr_Tarjeta + " # " + info.cr_NumDocumento + " del Cobro " + idcobro.ToString();

                info.cr_Banco = banco;
                info.cr_Codigo = "";
                info.cr_cuenta = cuenta;
                info.cr_NumDocumento = numCh;
                //info.Fecha_Cobro = param.Fecha_Transac;
                info.IdCobro_tipo = tipoCobro;
                info.cr_TotalCobro = valor;
                info.cr_fecha = DateTime.Now;
                info.cr_fechaDocu = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                info.Fecha_Transac = param.Fecha_Transac;
                info.cr_fechaCobro = DateTime.Now;

                info.ListaCobro = getDetalle(info);

                string Mensaj = "";

                if (Bus.GuardarDB(Cl_Enumeradores.PantallaEjecucion.TARJETA, ref info, ref Mensaj, idcobro))
                {
                    BusCobroTarjeta.GuardarDB(Get(info, idcobro, idtipocobro));
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public List<cxc_cobro_Det_Info> getDetalle(cxc_cobro_Info _info)
        {
            try
            {
                List<cxc_cobro_Det_Info> listacxcDET = new List<cxc_cobro_Det_Info>();

                    cxc_cobro_Det_Info info = new cxc_cobro_Det_Info();
                    info.IdEmpresa = param.IdEmpresa;
                    info.IdSucursal = _info.IdSucursal;
                    info.dc_TipoDocumento = _info.dc_TipoDocumento;
                    info.dc_ValorPago = _info.cr_TotalCobro;
                    info.estado = "A";
                    info.Fecha_UltMod = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                    info.IdBodega_Cbte = _info.IdBodega_Cbte;
                    info.IdCbte_vta_nota = _info.IdCbte_vta_nota;
                    info.IdCobro = _info.IdCobro;
                    info.IdUsuario = param.IdUsuario;
                    info.ip = param.ip;
                    info.nom_pc = param.nom_pc;
                    listacxcDET.Add(info);

                return listacxcDET;
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<cxc_cobro_Det_Info>();
            }
        }

      


       
        public cxc_cobro_x_tarjeta_Info Get(cxc_cobro_Info info, decimal idcobro, string idtipocobro)
        {
            try
            {
                cxc_cobro_x_tarjeta_Info inf = new cxc_cobro_x_tarjeta_Info();
                inf.IdEmpresa=param.IdEmpresa;
                inf.IdSucursal=info.IdSucursal;
                inf.IdCobro=info.IdCobro;
                inf.IdCobro_Aplicado = idcobro;
                inf.IdCobro_tipo=info.IdCobro_tipo;
                inf.IdCobro_tipo_Aplicado = idtipocobro;
                inf.IdCbte_vta_aplicado = info.IdCbte_vta_nota;
                return inf;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new cxc_cobro_x_tarjeta_Info();
            }
        }


        private void frmCo_cxcMantenimiento_Tarjeta_Load(object sender, EventArgs e)
        {
            try
            {
                listaTipo=BusTipo.Get_List_Cobro_Tipo();
                cargarCombos();

                
                dtpFechaIni.Value = DateTime.Now.AddDays(-30);
                infoParam = busParam.Get_Info_parametro(param.IdEmpresa);
                cargarGrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void cargarGrid()
        {
            try
            {
                List<cxc_cobro_Info> lstCobroInfo = new List<cxc_cobro_Info>();
                lstCobroInfo = Bus.Get_List_cobro_x_Tarjeta(param.IdEmpresa, "TARJ", "PORC", Convert.ToDateTime(dtpFechaIni.Value.ToShortDateString()), Convert.ToDateTime(dtpFechaFin.Value.ToShortDateString()));
                gridConsulta.DataSource = lstCobroInfo;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void cargarCombos()
        {
            try
            {
                GridLookUpEditRF.DataSource = listaTipo.Where(q => q.ESRetenFTE == "S").ToList();
                GridLookUpEditRI.DataSource = listaTipo.Where(q => q.ESRetenIVA == "S").ToList();
                GridLookUpEditTP.DataSource = listaTipo.Where(q => q.IdCobro_tipo == "DEPO" || q.IdCobro_tipo == "CHQV").ToList();
                GridLookUpEditBanco.DataSource = busBancoCta.Get_list_Banco_Cuenta(param.IdEmpresa);
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                cargarGrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridView_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                infoCxC = GetSelectedRow((DevExpress.XtraGrid.Views.Grid.GridView)sender);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private cxc_cobro_Info GetSelectedRow(DevExpress.XtraGrid.Views.Grid.GridView view)
        {
            try
            {
                return (cxc_cobro_Info)view.GetRow(view.FocusedRowHandle);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new cxc_cobro_Info();
            }
        }


        private void gridView_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {

                if (Convert.ToString(gridView.GetFocusedRowCellValue(colRF)) == "") { gridView.SetFocusedRowCellValue(colvalorRF, 0); }
                if (Convert.ToString(gridView.GetFocusedRowCellValue(colRI)) == "") { gridView.SetFocusedRowCellValue(colvalorRI, 0); }

                if(Convert.ToDecimal(gridView.GetFocusedRowCellValue(colIdCobro))!=0){gridView.SetFocusedRowCellValue(colchek, true);}

                recalcular();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        double ret = 0;
        double iva = 0;
        private void gridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                recalcular();                   
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void recalcular() {
            try
            {
                ((List<cxc_cobro_Info>)gridConsulta.DataSource).ForEach(q => q.ValorCheque = q.cr_TotalCobro - q.valorRF - q.valorRI - q.valorComision);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void GridLookUpEditRFView_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                cxc_cobro_tipo_Info infotipo = new cxc_cobro_tipo_Info();
                infotipo = GetSelectedRowR((DevExpress.XtraGrid.Views.Grid.GridView)sender);
                ret =infotipo.PorcentajeRet;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GridLookUpEditRIView_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                cxc_cobro_tipo_Info infotipo = new cxc_cobro_tipo_Info();
                infotipo = GetSelectedRowR((DevExpress.XtraGrid.Views.Grid.GridView)sender);
                iva = infotipo.PorcentajeRet;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private cxc_cobro_tipo_Info GetSelectedRowR(DevExpress.XtraGrid.Views.Grid.GridView view)
        {
            try
            {
                return (cxc_cobro_tipo_Info)view.GetRow(view.FocusedRowHandle);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new cxc_cobro_tipo_Info();
            }
        }

        private void gridView_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (Char)8) {
                
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



    }
}
