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
using Core.Erp.Info.Facturacion;
using Core.Erp.Business.Facturacion;


namespace Core.Erp.Winform.CuentasxCobrar
{
    public partial class frmCxcMantenimiento_Cheques : Form
    {
        decimal d = 0;
        int idBanco = 0;
        string msg = "";
        string a = "";
        string b = "";
        string c = "";
        int x = 0;
        int porfecha = 0;
        double multa = 0;

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        cxc_cobro_x_EstadoCobro_Bus BusCobroEstado = new cxc_cobro_x_EstadoCobro_Bus();
        cxc_cobro_x_EstadoCobro_Info Info_cobro_x_EstadoCobro = new cxc_cobro_x_EstadoCobro_Info();
        cxc_cobro_Info Info_Cobro = new cxc_cobro_Info();
        cxc_cobro_Bus Bus_Cobro = new cxc_cobro_Bus();
        cxc_cobro_tipo_Bus Bus_Cobro_Tipo = new cxc_cobro_tipo_Bus();
        cxc_parametro_Bus BusParam_cxc = new cxc_parametro_Bus();
        cxc_parametro_Info InfoParam_cxc = new cxc_parametro_Info();
        List<cxc_cobro_Info> List_Cobro = new List<cxc_cobro_Info>();
        List<cxc_cobro_tipo_Info> list_Cobro_Tipo = new List<cxc_cobro_tipo_Info>();
        List<cxc_cobro_x_EstadoCobro_Info> list_Cobro_EstadoCobro = new List<cxc_cobro_x_EstadoCobro_Info>();
        fa_notaCreDeb_Info Info_NDC = new fa_notaCreDeb_Info();
        List<fa_notaCreDeb_det_Info> List_Info_NDC = new List<fa_notaCreDeb_det_Info>();
        fa_notaCredDeb_Bus Bus_NotaDB = new fa_notaCredDeb_Bus();

        string ObservacionProtesta = "";


        public frmCxcMantenimiento_Cheques()
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
        
        private void frmCo_cxcMantenimiento_Cheques_Load(object sender, EventArgs e)
        {
            try
            {

                dtpFechaIni.Value = DateTime.Now.AddMonths(-1);
                dtpFechaFin.Value = DateTime.Now.AddMonths(1);


                ultraComboEditorEstado.Properties.DataSource = Bus_Cobro.Get_List_CobroEstado();
                ultraComboEditorEstado.Properties.ValueMember = "IdEstadoCobro";
                ultraComboEditorEstado.Properties.DisplayMember = "Descripcion";
                ultraComboEditorEstado.EditValue = "PORC";
                

                cxc_cobro_tipo_Info INFO = new cxc_cobro_tipo_Info();

                list_Cobro_Tipo = Bus_Cobro_Tipo.Get_List_Cobro_Tipo_ParaMantCheque();
                INFO.tc_descripcion = "Todos";
                INFO.IdCobro_tipo = "-1";
                INFO.tc_Orden = -1;

                list_Cobro_Tipo.Add(INFO);
                var s = (from q in list_Cobro_Tipo
                        orderby q.tc_Orden ascending
                        select q);

                ultraComboEditorTipoTransaccion.Properties.DataSource = s.ToList();
                ultraComboEditorTipoTransaccion.Properties.ValueMember = "IdCobro_tipo";
                ultraComboEditorTipoTransaccion.Properties.DisplayMember = "tc_descripcion";
                ultraComboEditorTipoTransaccion.EditValue = "CHQF";


                list_Cobro_Tipo = new List<cxc_cobro_tipo_Info>();
                list_Cobro_Tipo = Bus_Cobro_Tipo.Get_List_Cobro_Tipo_ParaMantCheque();
                foreach (var item in list_Cobro_Tipo)
                {
                    if (x == 0) { a = item.IdCobro_tipo; }
                    if (x == 1) { b = item.IdCobro_tipo; }
                    if (x == 2) { c = item.IdCobro_tipo; }
                    x = x + 1;
                }



                InfoParam_cxc = BusParam_cxc.Get_Info_parametro(param.IdEmpresa);
                if(InfoParam_cxc.pa_tipoND_x_CheqProtestado==0){
                    MessageBox.Show("No existe Parametros para Cuentas x Cobrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnCobrar.Enabled = false;
                    btnProtestar.Enabled = false;
                }
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
                List<cxc_cobro_x_EstadoCobro_Info>  TEMP = new List<cxc_cobro_x_EstadoCobro_Info>();
                List<cxc_cobro_Info> ListCobro = new List<cxc_cobro_Info>();
                List<cxc_cobro_Info> ListCobroTodo = new List<cxc_cobro_Info>();
                ListCobroTodo = Bus_Cobro.Get_List_cobro(param.IdEmpresa, ultraComboEditorTipoTransaccion.EditValue.ToString(), ultraComboEditorEstado.EditValue.ToString(), Convert.ToDateTime(dtpFechaIni.Value.ToShortDateString()), Convert.ToDateTime(dtpFechaFin.Value.ToShortDateString()), porfecha);
                cxc_cobro_x_EstadoCobro_Bus Cobro_x_EstadoCobro = new cxc_cobro_x_EstadoCobro_Bus();
                var LstCbr = Cobro_x_EstadoCobro.Get_List_cobro_x_EstadoCobro(param.IdEmpresa);

                var EstadoCobro =  Bus_Cobro.Get_List_CobroEstado();

                var Join = from q in LstCbr
                           join w in EstadoCobro
                           on new {q.IdEstadoCobro} equals new {w.IdEstadoCobro}
                           select new {q.IdCobro,w.posicion, q.IdSucursal};

                foreach(var item in Join)
                {
                    if (item.IdCobro == 4)
                    {
                        var temp2 = Join.ToList().FindAll(v => v.IdCobro == item.IdCobro && v.IdSucursal == item.IdSucursal);
                    }
                    var temp1 = Join.ToList().FindAll(v => v.IdCobro == item.IdCobro && v.IdSucursal == item.IdSucursal);
                    int maximo = temp1.Max(v=>v.posicion);
                    var Obj = temp1.First(p => p.posicion == maximo);
                    var Item = LstCbr.First(v => v.IdCobro == Obj.IdCobro && v.posicion == Obj.posicion && v.IdSucursal == Obj.IdSucursal);
                    TEMP.Add(Item);
                }

                var ListaGrid = TEMP.GroupBy(v => v).ToList();

                List<cxc_cobro_x_EstadoCobro_Info> Lst2 = new List<cxc_cobro_x_EstadoCobro_Info>();

                var pru = TEMP.Where(q => q.IdSucursal == 2 && q.IdCobro == 4);

                foreach(var item in ListaGrid)
                {
                    cxc_cobro_x_EstadoCobro_Info info = new cxc_cobro_x_EstadoCobro_Info();

                    info.Fecha = item.Key.Fecha;
                    info.IdBanco = item.Key.IdBanco;
                    info.IdCbte_vta_nota = item.Key.IdCbte_vta_nota;
                    info.IdCobro = item.Key.IdCobro;
                    info.IdCobro_tipo = item.Key.IdCobro_tipo;
                    info.IdEmpresa = item.Key.IdEmpresa;
                    info.IdEstadoCobro = item.Key.IdEstadoCobro;
                    info.IdSucursal = item.Key.IdSucursal;
                    info.nt_IdBodega = item.Key.nt_IdBodega;
                    info.nt_IdNota = item.Key.nt_IdNota;
                    info.nt_IdSucursal = item.Key.nt_IdSucursal;
                    info.observacion = item.Key.observacion;
                    info.posicion = item.Key.posicion;
                    
                    Lst2.Add(info);
                }


                var lst = Lst2.ToList().FindAll(c => c.IdEstadoCobro == ultraComboEditorEstado.EditValue.ToString());




                foreach(var item in lst)
                {
                     foreach(var item2 in ListCobroTodo)
	                 {
		                 if(item.IdCobro==item2.IdCobro && item.IdEmpresa==item2.IdEmpresa && item.IdSucursal==item2.IdSucursal)
                         {
                             cxc_cobro_Info info = new cxc_cobro_Info();

                             info.BancoCuenta = item2.BancoCuenta;
                             info.BancoTarjeta = item2.BancoTarjeta;
                             info.Caja = item2.Caja;
                             info.chequeTarjeta = item2.chequeTarjeta;
                             info.cr_Banco = item2.cr_Banco;
                             info.cr_Codigo = item2.cr_Codigo;
                             info.cr_cuenta = item2.cr_cuenta;
                             info.cr_estado = item2.cr_estado;
                             info.cr_fecha = item2.cr_fecha;
                             info.cr_estadoCobro = item2.cr_estadoCobro;
                             info.cr_fechaCobro = item2.cr_fechaCobro;
                             info.IdBanco = item2.IdBanco;
                             info.IdBodega_Cbte = item2.IdBodega_Cbte;
                             info.IdCbte_vta_nota = item2.IdCbte_vta_nota;
                             info.IdCbteCble_MoviCaja = item2.IdCbteCble_MoviCaja;
                             info.IdCliente = item2.IdCliente;
                             info.IdCobro = item2.IdCobro;
                             info.IdCobro_tipo = item2.IdCobro_tipo;
                             info.IdEmpresa = item.IdEmpresa;
                             info.IdEstadoCobro = item.IdEstadoCobro;
                             info.IdSucursal = item.IdSucursal;
                             info.IdTipocbte_MoviCaja = item2.IdTipocbte_MoviCaja;
                             info.IdTipoNotaCredito = item2.IdTipoNotaCredito;
                             info.IdVendedorCliente = item2.IdVendedorCliente;
                             info.nCliente = item2.nCliente;
                             info.nSucursal = item2.nSucursal;
                             info.RF = item2.RF;
                             info.RI = item2.RI;
                             info.secuencial = item2.secuencial;
                             info.Tipo = item2.Tipo;
                             info.TipoPagoTarjeta = item2.TipoPagoTarjeta;
                             info.ValorCheque = item2.ValorCheque;
                             info.valorComision = item2.valorComision;
                             info.valorRF = item2.valorRF;
                             info.valorRI = item2.valorRI;
                             info.cr_TotalCobro = item2.cr_TotalCobro;
                             info.cr_NumDocumento = item2.cr_NumDocumento;
                             info.IdCaja = item2.IdCaja;
                             ListCobro.Add(info);
                         }
	                 }
                }

                gridConsulta.DataSource = ListCobro;//ListCobro;
            }
            catch(Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rbFechaIng_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbFechaIng.Checked){ porfecha = 0; }else{ porfecha = 1; }
            }
            catch(Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            try
            {
                list_Cobro_EstadoCobro = new List<cxc_cobro_x_EstadoCobro_Info>();
                textBox1.Focus();
                
                
                var s = from q in (List<cxc_cobro_Info>)gridConsulta.DataSource
                        where q.IdEstadoCobro == "PORC" && q.chek == true && (q.IdCobro_tipo == a || q.IdCobro_tipo == b || q.IdCobro_tipo == c)
                       select q;
                foreach (var item in s)
                {
                    Info_cobro_x_EstadoCobro = new cxc_cobro_x_EstadoCobro_Info();
                    Info_cobro_x_EstadoCobro.Fecha = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                    Info_cobro_x_EstadoCobro.IdCobro = item.IdCobro;
                    Info_cobro_x_EstadoCobro.IdCobro_tipo = item.IdCobro_tipo;
                    Info_cobro_x_EstadoCobro.IdEmpresa = param.IdEmpresa;
                    Info_cobro_x_EstadoCobro.IdEstadoCobro = "COBR";
                    Info_cobro_x_EstadoCobro.IdSucursal = item.IdSucursal;
                    list_Cobro_EstadoCobro.Add(Info_cobro_x_EstadoCobro);
                }
                if (list_Cobro_EstadoCobro.Count() == 0){ MessageBox.Show("No ha seleccionado ningun registro Valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; }
                if (MessageBox.Show("¿Desea Continuar?", "?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                if (BusCobroEstado.GuardarDB_Verifica_si_es_Protestado(list_Cobro_EstadoCobro, ref msg)) { MessageBox.Show("Guardado con exito", "OK", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
                }
                cargarGrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnProtestar_Click(object sender, EventArgs e)
        {
            try
            {
                
                string mensajeDocumentoDupli = "";
                string mensajeError = "";
                string numDocumento = "";
                list_Cobro_EstadoCobro = new List<cxc_cobro_x_EstadoCobro_Info>();
                textBox1.Focus();
                var s = from q in (List<cxc_cobro_Info>)gridConsulta.DataSource
                        where (q.IdEstadoCobro == "COBR" || q.IdCobro_tipo == "CHQV") && q.chek == true
                        select q;
          
                foreach (var item in s)
                {

                        cxc_Parametros_x_cheqProtesto_Info Info_Param = InfoParam_cxc.LstParamProtesto.FirstOrDefault(v => v.IdEmpresa == param.IdEmpresa
                      && v.pa_IdSucursal_x_default_x_cheqProtes == item.IdSucursal);

                    Info_cobro_x_EstadoCobro = new cxc_cobro_x_EstadoCobro_Info();
                    Info_cobro_x_EstadoCobro.Fecha = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                    Info_cobro_x_EstadoCobro.IdCobro = item.IdCobro;
                    Info_cobro_x_EstadoCobro.IdCobro_tipo = item.IdCobro_tipo;
                    Info_cobro_x_EstadoCobro.IdEmpresa = param.IdEmpresa;
                    Info_cobro_x_EstadoCobro.IdEstadoCobro = "PRTS";
                    Info_cobro_x_EstadoCobro.IdSucursal = item.IdSucursal;
                    Info_cobro_x_EstadoCobro.nt_IdBodega = Convert.ToInt32(Info_Param.pa_IdBodega_x_default_x_cheqProtes);
                    Info_Cobro = item;
                    Info_cobro_x_EstadoCobro.nt_IdSucursal = Info_Cobro.IdSucursal;

                    
                    list_Cobro_EstadoCobro.Add(Info_cobro_x_EstadoCobro);
                }

                if (list_Cobro_EstadoCobro.Count() == 0) { MessageBox.Show("No ha seleccionado ningun registro Valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; }
                if (list_Cobro_EstadoCobro.Count() >1) { MessageBox.Show("Solo debe Seleccionar un cheque a Protestar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; }
                frmCxcMantenimiento_Cheques_Multa frm = new frmCxcMantenimiento_Cheques_Multa();
                if (MessageBox.Show("¿Desea Continuar?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    frm.idSucursal = Info_Cobro.IdSucursal;
                    frm.idCobro = Info_Cobro.IdCobro;
                    frm.txtNCh.Text = Info_Cobro.cr_NumDocumento;
                    frm.txtCta.Text = Info_Cobro.cr_cuenta;
                    frm.txtBanco.Text = Info_Cobro.cr_Banco;
                frm.ShowDialog();
                ObservacionProtesta=frm.txtObservacion.Text;
                if(frm.protestar){
                
                    GetNotaDC();
                    GetNotaDCDetalle();

                    Info_NDC.CobroInfo = Info_Cobro;
                    Bus_NotaDB.GuardarDB(Info_NDC, ref d, ref mensajeDocumentoDupli, ref mensajeError);
                    foreach (var item in list_Cobro_EstadoCobro)
                    {
                        item.nt_IdNota = d;
                        item.observacion = ObservacionProtesta;
                        item.IdBanco = idBanco;
                    }
                    msg = "PROS";
                    if (BusCobroEstado.GuardarDB_Verifica_si_es_Protestado(list_Cobro_EstadoCobro, ref msg)) { MessageBox.Show("Guardado con exito", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); } else {
                        MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                }
                cargarGrid();
                }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ultraComboEditorEstado_ValueChanged(object sender, EventArgs e)
        {
            try
            {

                if (ultraComboEditorEstado.EditValue.ToString() == "COBR")
                {
                    btnCobrar.Enabled = false;

                }
                else { btnCobrar.Enabled = true; }
                if (ultraComboEditorEstado.EditValue.ToString() == "PRTS")
                {
                    btnProtestar.Enabled = false;

                }
                else { btnProtestar.Enabled = true; }
                cargarGrid();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ultraComboEditorTipoTransaccion_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (ultraComboEditorTipoTransaccion.EditValue.ToString() == "TARJ")
                {
                    btnProtestar.Enabled = false;
                }
                else
                {
                    btnProtestar.Enabled = true;
                }
                cargarGrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GetNotaDC()
        {
            try
            {

                Info_NDC = new fa_notaCreDeb_Info();
                Info_NDC.CodNota = "";

                Info_NDC.IdEmpresa = param.IdEmpresa;
                Info_NDC.IdSucursal = Info_Cobro.IdSucursal;
                Info_NDC.IdBodega = 1;
                Info_NDC.IdCliente = Info_Cobro.IdCliente;
                Info_NDC.IdVendedor = Info_Cobro.IdVendedorCliente;
                
                Info_NDC.ip = param.ip;
                Info_NDC.nom_pc = param.nom_pc;

                //NDCInfo.Serie1 = "";
                //NDCInfo.Serie2 = "";
                Info_NDC.NumNota_Impresa = "";
                //NDCInfo.NumAutorizacion = "";
                Info_NDC.NaturalezaNota = "INT";
                Info_NDC.no_dev_venta = "";
                Info_NDC.CreDeb = "D";
                Info_NDC.no_fecha = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                Info_NDC.no_fecha_venc = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                Info_NDC.no_dev_venta = "";

                Info_NDC.IdTipoNota = InfoParam_cxc.pa_tipoND_x_CheqProtestado;
                Info_NDC.sc_observacion = "NDEB Por Cheque Protestado # " + Info_Cobro.cr_NumDocumento.ToString() + " Del Banco " + Info_Cobro.cr_Banco.ToString() + " de la Cuenta # " + ((Info_Cobro.cr_cuenta == null) ? "" : Info_Cobro.cr_cuenta) +" ==> "+ ObservacionProtesta;
                Info_NDC.sc_usuario = param.IdUsuario;

                Info_NDC.IdUsuarioUltAnu = "";

                //NDCInfo.IdUsuario = param.IdUsuario;
                Info_NDC.Estado = "A";
                //NDCInfo.IdDevolucion = Convert.ToDecimal(txtidDev.Text);
                Info_NDC.nom_pc = param.nom_pc;
                Info_NDC.ip = param.ip;
                Info_NDC.IdCaja = Info_Cobro.IdCaja;
                Info_NDC.IdCtaCble_TipoNota = "";
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        
        private void GetNotaDCDetalle()
        {
            try
            {
                List_Info_NDC = new List<fa_notaCreDeb_det_Info>();

                cxc_Parametros_x_cheqProtesto_Info Info_Param_x_Cheq_Prost = InfoParam_cxc.LstParamProtesto.FirstOrDefault(v => v.IdEmpresa == param.IdEmpresa
                    && v.pa_IdSucursal_x_default_x_cheqProtes == Info_Cobro.IdSucursal);




                    fa_notaCreDeb_det_Info ListaNDCInfo = new fa_notaCreDeb_det_Info();
                    ListaNDCInfo.IdEmpresa = param.IdEmpresa;
                    ListaNDCInfo.IdSucursal = Info_Cobro.IdSucursal;
                    ListaNDCInfo.IdBodega = Convert.ToInt32(Info_Param_x_Cheq_Prost.pa_IdBodega_x_default_x_cheqProtes);
                    ListaNDCInfo.IdProducto = Convert.ToDecimal(Info_Param_x_Cheq_Prost.pa_IdProducto_x_ND_x_CheqProtes);
                    ListaNDCInfo.pr_descripcion = "";
                    ListaNDCInfo.sc_cantidad = 1;
                    ListaNDCInfo.sc_estado = "A";
                    ListaNDCInfo.sc_observacion = "Nota Debito por Cheque Protestado";
                    ListaNDCInfo.sc_iva = 0;
                    ListaNDCInfo.sc_descUni = 0;
                    ListaNDCInfo.sc_PordescUni = 0;
                    ListaNDCInfo.sc_Precio = (float)Info_Cobro.cr_TotalCobro + (float)multa;
                    ListaNDCInfo.sc_precioFinal = (float)Info_Cobro.cr_TotalCobro + (float)multa;
                    ListaNDCInfo.sc_subtotal = (float)Info_Cobro.cr_TotalCobro + (float)multa;
                    ListaNDCInfo.sc_total = (float)Info_Cobro.cr_TotalCobro+(float)multa;
                    ListaNDCInfo.Secuencia = 1;
                    List_Info_NDC.Add(ListaNDCInfo);
                    Info_NDC.ListaDetalles = List_Info_NDC;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
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

        private void ultraComboEditorEstado_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
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

        private void gridViewMant_Cheq_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                Info_Cobro = GetSelectedRow((DevExpress.XtraGrid.Views.Grid.GridView)sender);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
