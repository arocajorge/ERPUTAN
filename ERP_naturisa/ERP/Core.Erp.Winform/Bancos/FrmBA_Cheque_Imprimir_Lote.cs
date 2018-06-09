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
using Core.Erp.Business.General;

using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Info.General;
using Core.Erp.Reportes.Bancos;

namespace Core.Erp.Winform.Bancos
{
    public partial class FrmBA_Cheque_Imprimir_Lote : Form
    {
        #region Declaración de Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        ba_Cbte_Ban_Bus CbtBan_b = new ba_Cbte_Ban_Bus();
        ba_Banco_Cuenta_Bus ba_b = new ba_Banco_Cuenta_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        BindingList<ba_Cbte_Ban_Info> LstBin = new BindingList<ba_Cbte_Ban_Info>();
        ba_Banco_Cuenta_Info InfoCuenta = new ba_Banco_Cuenta_Info();
        List<ct_Cbtecble_det_Info> DetCbteCble = new List<ct_Cbtecble_det_Info>();
        ct_Cbtecble_Bus busCont = new ct_Cbtecble_Bus();
        ct_Cbtecble_Info cbtecble = new ct_Cbtecble_Info();
        ct_Cbtecble_det_Bus busDetCbte = new ct_Cbtecble_det_Bus();
        Dictionary<string, decimal> LstDicProd = new Dictionary<string, decimal>();
        FrmBA_Talonario_cheques_x_bancoSeleccionar frm;
        List<XBAN_Rpt005_Info> ReporteListado = new List<XBAN_Rpt005_Info>();

        string MensajeError = "";

        #endregion

        public FrmBA_Cheque_Imprimir_Lote()
        {
            try
            {
                InitializeComponent();
                ucGe_Menu.event_btnImprimir_Click += ucGe_Menu_event_btnImprimir_Click;
                ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        void ucGe_Menu_event_btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                imprimir();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        private void FrmBA_Cheque_Imprimir_Lote_Load(object sender, EventArgs e)
        {
            try
            {
                dp_desde.Value = dp_desde.Value.AddDays(-30);


                var ListaBanco = ba_b.Get_list_Banco_Cuenta(param.IdEmpresa);
                gridLookUpEdit_banco.Properties.DataSource = ListaBanco;
                gridLookUpEdit_banco.EditValue = 0;
                if (ListaBanco != null && ListaBanco.Count > 0)
                {
                    //gridLookUpEdit_banco.EditValue = ListaBanco[0].IdBanco;
                    txtdigito.EditValue = ListaBanco[0].ba_num_digito_cheq;
                }
                string micadena = "1";
                int d = Convert.ToInt32(txtdigito.EditValue);
                this.txtEjemplo.Text = micadena.PadLeft(d, '0');


                gridControl_cbt_ban.DataSource = LstBin;


                cmb_estado.SelectedIndex = 2;
                load();

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void load()
        {
            try
            {
                if (gridLookUpEdit_banco.EditValue == null || gridLookUpEdit_banco.EditValue == "")
                {
                    MessageBox.Show("Debe seleccionar banco para poder continuar", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    int i = 2;//2 es tipo de cbt_ban cheque
                    int f = 2;

                    List<ba_Cbte_Ban_Info> Lst = new List<ba_Cbte_Ban_Info>();

                    if (cmb_estado.Text == "Todos")
                        Lst = CbtBan_b.Get_List_Cbte_Ban(param.IdEmpresa, i, f, dp_desde.Value, dp_hasta.Value, ref MensajeError).FindAll(c => c.Estado == "A" && c.IdBanco == Convert.ToInt32(gridLookUpEdit_banco.EditValue));
                    else
                        Lst = CbtBan_b.Get_List_Cbte_Ban(param.IdEmpresa, i, f, dp_desde.Value, dp_hasta.Value, ref MensajeError).FindAll(c => c.Estado == "A" && c.cb_ChequeImpreso == ((cmb_estado.Text == "Impresos") ? "S" : "N") && c.IdBanco == Convert.ToInt32(gridLookUpEdit_banco.EditValue));

                    LstBin = new BindingList<ba_Cbte_Ban_Info>(Lst);
                    foreach (var item in LstBin)
                    {
                        item.cb_ChequeAux = item.cb_Cheque;
                    }
                    gridControl_cbt_ban.DataSource = LstBin;
                    ChkChequeSec.EditValue = false;
                    gridLookUpEdit_banco.Focus();

                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void gridView_cbt_ban_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                var item = (ba_Cbte_Ban_Info)gridView_cbt_ban.GetRow(e.FocusedRowHandle);
                if (item.cb_ChequeImpreso == "S")
                    colcb_Cheque.OptionsColumn.AllowEdit = false;
                else
                    colcb_Cheque.OptionsColumn.AllowEdit = true;



            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private List<ba_Cbte_Ban_Info> LitaParaImprimir()
        {
            try
            {
                int focus = gridView_cbt_ban.FocusedRowHandle;
                gridView_cbt_ban.FocusedRowHandle = focus + 1;
                Funciones fxG = new Funciones();
                List<ba_Cbte_Ban_Info> ls = new List<ba_Cbte_Ban_Info>();
                XBAN_Rpt005_Bus reporteBus = new XBAN_Rpt005_Bus();

                foreach (var item in LstBin)
                {
                    if (item.chek == true)
                    {
                        item.MotivoAnulacion = fxG.NumeroALetras(item.cb_Valor.ToString());
                        item.cb_ChequeImpreso = "S";
                        ls.Add(item);

                        ReporteListado.AddRange(reporteBus.GetData(param.IdEmpresa, item.IdCbteCble, item.IdTipocbte,ref MensajeError));
                    }
                }
                return ls;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new List<ba_Cbte_Ban_Info>();
            }
        }

        private void imprimir()
        {
            try
            {
                if (MessageBox.Show("Se procedera a Imprimir los cheques seleccionados \n¿ Desea Continuar ?", "Imprimir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //XRptBa_ChequeImpreso rptCheq = new XRptBa_ChequeImpreso();
                    var rptCheq = new DevExpress.XtraReports.UI.XtraReport();
                    //Reporte Solo Cheque

                    List<ba_Cbte_Ban_Info> lCbtBan = new List<ba_Cbte_Ban_Info>();
                    if (!validarepetidos()) return;
                    else
                    {
                        lCbtBan = LitaParaImprimir();
                        ba_Config_Diseno_Cheque_Info diseno_i = new ba_Config_Diseno_Cheque_Info();
                        ba_Config_Diseno_Cheque_Bus diseno_b = new ba_Config_Diseno_Cheque_Bus();

                        ba_Banco_Cuenta_Info t = (ba_Banco_Cuenta_Info)gridLookUpEdit_banco.Properties.GetRowByKeyValue(gridLookUpEdit_banco.EditValue);
                        var banco = ba_b.Get_Info_Banco_Cuenta(param.IdEmpresa, t.IdBanco);

                        string Ruta = System.IO.Path.GetTempPath() + "savesolochequeLote.repx";


                        if (Convert.ToBoolean(banco.Imprimir_Solo_el_cheque))
                        {
                            rptCheq = new XBAN_Rpt006_rpt();
                            if (banco.ReporteSolo_Cheque != null)
                                System.IO.File.WriteAllBytes(Ruta, banco.ReporteSolo_Cheque);
                        }
                        else
                        {
                            rptCheq = new XBAN_Rpt005_rpt();
                            if (banco.ReporteSolo_Cheque != null)
                                System.IO.File.WriteAllBytes(Ruta, banco.Reporte);
                        }


                        if (banco.ReporteSolo_Cheque != null)
                            rptCheq.LoadLayout(Ruta);
                        diseno_i = diseno_b.Get_List_Config_Diseno_Cheque(t);

                        if (diseno_i == null)
                        {

                            MessageBox.Show("No se puede imprimir el cheque porque no está ingresada la configuración para la impresión del cheque /n Ingresela desde la pantalla de Configuracion del diseño del cheque", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        if (ActualizarCheqImpreso())
                        {
                            rptCheq.DataSource = lCbtBan;
                            if (MessageBox.Show("¿ Desea ver vista Previa ?", "Imprimir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                rptCheq.ShowPreview();
                            else
                                rptCheq.Print();
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void actualizarObservCbteCble(string cb_Cheque, decimal IdCbteCble, int IdTipocbte)
        {
            try
            {
                string MensajeError = "";
                cbtecble.IdEmpresa = param.IdEmpresa; cbtecble.IdTipoCbte = IdTipocbte; cbtecble.IdCbteCble = IdCbteCble;
                DetCbteCble = busDetCbte.Get_list_Cbtecble_det(param.IdEmpresa, cbtecble.IdTipoCbte, cbtecble.IdCbteCble, ref MensajeError);
                cbtecble.cb_Observacion = "Ch/" + cb_Cheque + " " + cbtecble.cb_Observacion;
                DetCbteCble.ForEach(var => var.dc_Observacion = "Ch/" + cb_Cheque + " " + var.dc_Observacion);
                string msg = "";
                busCont.ModificarDB(cbtecble, ref msg);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        private Boolean ActualizarCheqImpreso()
        {
            try
            {
                Boolean resul = true;
                try
                {

                    List<ba_Cbte_Ban_Info> LitaCheqImpreso = new List<ba_Cbte_Ban_Info>();
                    LitaCheqImpreso = LitaParaImprimir();

                    foreach (ba_Cbte_Ban_Info item in LitaCheqImpreso)
                    {
                        //if (item.cb_ChequeImpreso == "S") item.cb_Cheque = item.cb_ChequeAux; //aqui para que no se pasen de shabidosh
                        item.IdUsuarioUltMod = param.IdUsuario;
                        item.Fecha_UltMod = param.Fecha_Transac;
                        string mesg2 = "";
                        ba_Talonario_cheques_x_banco_Bus busTalChe = new ba_Talonario_cheques_x_banco_Bus();
                        busTalChe.Usar(item, item.cb_Cheque, ref mesg2);
                        CbtBan_b.ModificarDB(item, ref MensajeError);
                        actualizarObservCbteCble(item.cb_Cheque, item.IdCbteCble, item.IdTipocbte);
                    }



                }
                catch (Exception ex)
                {
                    string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                    NameMetodo = NameMetodo + " - " + ex.ToString();
                    MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                        , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                    resul = false;
                }
                return resul;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                imprimir();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        private void gridView_cbt_ban_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                InfoCuenta = (ba_Banco_Cuenta_Info)gridLookUpEdit_banco.GetSelectedDataRow();

                string mensaje = "";
                if (e.Column.Name == "colcb_Cheque")
                {
                    ba_Cbte_Ban_Info c = (ba_Cbte_Ban_Info)gridView_cbt_ban.GetFocusedRow();
                    if (CbtBan_b.VericarChequeExiste(c.cb_Cheque, c.IdEmpresa, c.IdCbteCble, Convert.ToInt32(c.IdTipocbte), c.IdBanco, ref mensaje) == true)
                    {

                        // bandedGridColumn1.OptionsColumn.AllowEdit = false;
                        MessageBox.Show("Por favor cambie el numero de cheque, porque ya fue girado a: " + mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        // gridView_cbt_ban.SetFocusedRowCellValue(colcb_Cheque, 0);

                        //  gridView_cbt_ban.SetFocusedRowCellValue(bandedGridColumn1, false);
                        //  gridView_cbt_ban.SetFocusedRowCellValue(bandedGridColumn1, "X");

                    }
                    else
                    {
                        int g = 0;
                        foreach (var item in LstBin)
                        {

                            if (item.cb_ChequeImpreso != "S" && item.chek == true)
                            {
                                item.cb_Cheque = Convert.ToString(Convert.ToInt32(e.Value) + g);
                                while (item.cb_Cheque.Length < InfoCuenta.ba_num_digito_cheq)
                                {
                                    item.cb_Cheque = "0" + item.cb_Cheque;

                                }
                                g++;

                                item.chek = true;
                            }

                            //if (item.cb_Cheque == "0")
                            //{
                            //    g++;
                            //    item.cb_Cheque = Convert.ToString(Convert.ToInt32(e.Value) + g);
                            //    item.chek = true;
                            //}
                        }

                        gridControl_cbt_ban.RefreshDataSource();
                        //  gridView_cbt_ban.SetFocusedRowCellValue(bandedGridColumn1, true);
                        //  gridView_cbt_ban.SetFocusedRowCellValue(bandedGridColumn1, "");
                    }
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {

                bool CHE;
                if (chek_todos.Checked == true)
                    CHE = true;
                else
                    CHE = false;
                if (textBox1.Text == "")
                {
                    foreach (var item in LstBin)
                    {
                        if (item.cb_ChequeImpreso == "N")
                        {
                            item.chek = CHE;
                        }
                    }
                    gridControl_cbt_ban.DataSource = LstBin;
                    gridControl_cbt_ban.RefreshDataSource();
                }
                else
                    chektrue(chek_todos.Checked);


            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private Boolean validarepetidos()
        {
            try
            {
                Boolean resul = false;

                try
                {
                    foreach (var item in LstBin)
                    {
                        if (item.chek == true)
                        {
                            if (String.IsNullOrEmpty(item.cb_Cheque) || String.IsNullOrWhiteSpace(item.cb_Cheque) || item.cb_Cheque == "0")
                            {
                                MessageBox.Show("Por favor cambie el numero de cheque, no puede ser 0 ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return false;
                            }


                        }
                    }




                    resul = true;
                }
                catch (Exception ex)
                {
                    Log_Error_bus.Log_Error(ex.ToString());
                    MessageBox.Show("Hay números de cheques repetido. Por favor verifique!", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    resul = false;
                }
                return resul;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
        }

        void chektrue(Boolean check)
        {
            try
            {
                InfoCuenta = (ba_Banco_Cuenta_Info)gridLookUpEdit_banco.GetSelectedDataRow();

                if (String.IsNullOrEmpty(textBox1.Text) || string.IsNullOrWhiteSpace(textBox1.Text)) { }
                else
                {
                    try
                    {
                        string mensaje = ""; int g = 0;
                        string NumCheque = "";
                        if (check)
                        {
                            foreach (var item in LstBin)
                            {
                                if (item.cb_ChequeImpreso == "N")
                                {
                                    Boolean flag = false;
                                    g++;
                                    if (g == 1)
                                    {
                                        item.cb_Cheque = NumCheque = (Convert.ToInt32(textBox1.Text) + g).ToString();

                                        while (flag != true)
                                        {
                                            if (CbtBan_b.VericarChequeExiste(item.cb_Cheque, item.IdEmpresa, item.IdCbteCble, Convert.ToInt32(item.IdTipocbte), item.IdBanco, ref mensaje) == false)
                                            {
                                                flag = true;
                                            }
                                            else
                                            {
                                                g++;
                                                item.cb_Cheque = Convert.ToString(Convert.ToInt32(NumCheque) + g);

                                            } while (item.cb_Cheque.Length < InfoCuenta.ba_num_digito_cheq)
                                            {
                                                item.cb_Cheque = "0" + item.cb_Cheque;

                                            }
                                        }
                                    }
                                    else
                                    {
                                        flag = false;
                                        while (flag != true)
                                        {
                                            item.cb_Cheque = Convert.ToString(Convert.ToInt32(NumCheque) + g - 1);
                                            if (CbtBan_b.VericarChequeExiste(item.cb_Cheque, item.IdEmpresa, item.IdCbteCble, Convert.ToInt32(item.IdTipocbte), item.IdBanco, ref mensaje) == false)
                                            {
                                                flag = true;
                                            }
                                            else
                                            {
                                                g++; item.cb_Cheque = Convert.ToString(Convert.ToInt32(NumCheque) + g);

                                            }
                                            while (item.cb_Cheque.Length < InfoCuenta.ba_num_digito_cheq)
                                            {
                                                item.cb_Cheque = "0" + item.cb_Cheque;

                                            }

                                        }
                                    }
                                    item.chek = true;
                                }

                            }
                            gridControl_cbt_ban.DataSource = LstBin;
                            gridControl_cbt_ban.RefreshDataSource();
                        }
                        else textBox1.Text = "";
                    }
                    catch (Exception ex)
                    {
                        Log_Error_bus.Log_Error(ex.ToString());
                    }

                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        private void ChkChequeSec_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                chektrue(ChkChequeSec.Checked);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void gridView_cbt_ban_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {

        }

        private void gridView_cbt_ban_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {

        }

        private void gridView_cbt_ban_RowCellClick_1(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {


                if (e.Column.Name == "colchek" || e.Column.Name == "bandedGridColumn1")
                {

                    ba_Cbte_Ban_Info row = (ba_Cbte_Ban_Info)gridView_cbt_ban.GetFocusedRow();

                    if (row != null)
                        if (row.chek == true)
                        {

                            gridView_cbt_ban.SetFocusedRowCellValue(colchek, false);
                        }
                        else
                        {

                            gridView_cbt_ban.SetFocusedRowCellValue(colchek, true);
                        }

                }


            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());

            }
        }

        private void btn_Refres_Click_1(object sender, EventArgs e)
        {
            try
            {
                load();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void ChkChequeSec_CheckedChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(textBox1.Text.Length) != Convert.ToInt32(txtdigito.Text))
                {
                    MessageBox.Show("Error: Debe ingresar el número de dígitos correspondiente", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (ChkChequeSec.Checked == true)
                    {
                        string mensaje = "";
                        int conta = Convert.ToInt32(textBox1.EditValue);
                        int r = 0;
                        decimal c = 0;
                        string micadena;
                        int d = Convert.ToInt32(txtdigito.EditValue);
                        int i = 0;
                        foreach (var item in LstBin)
                        {
                            if ((item.chek == true) && (item.cb_ChequeImpreso == "N"))
                            {
                                r = i + Convert.ToInt32(textBox1.EditValue);
                                micadena = r.ToString();
                                micadena = micadena.PadLeft(d, '0');
                                while (CbtBan_b.VericarChequeExiste(micadena, item.IdEmpresa, item.IdCbteCble, Convert.ToInt32(item.IdTipocbte), item.IdBanco, ref mensaje) == true)
                                {
                                    i++;
                                    r = i + Convert.ToInt32(textBox1.EditValue);
                                    micadena = r.ToString();
                                    micadena = micadena.PadLeft(d, '0');
                                }
                                item.cb_Cheque = micadena;
                                i++;
                            }
                        }
                        if (i == 0)
                        {
                            MessageBox.Show("No ha seleccionado ningun item con status N", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        foreach (var item in LstBin)
                        {
                            item.cb_Cheque = item.cb_ChequeAux;
                        }
                    }
                    gridControl_cbt_ban.DataSource = null;
                    gridControl_cbt_ban.DataSource = LstBin;
                    gridControl_cbt_ban.Refresh();
                }

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void gridLookUpEdit_banco_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                int d = 0;

                ba_Banco_Cuenta_Info obj_cmbProve = (ba_Banco_Cuenta_Info)gridLookUpEdit_banco.Properties.View.GetFocusedRow();

                if (obj_cmbProve != null)
                {
                    txtdigito.EditValue = obj_cmbProve.ba_num_digito_cheq;
                    string micadena = "1";
                    d = Convert.ToInt32(txtdigito.EditValue);
                    this.txtEjemplo.Text = micadena.PadLeft(d, '0');
                    load();
                }

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void gridView_cbt_ban_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {

                var data = gridView_cbt_ban.GetRow(e.RowHandle) as ba_Cbte_Ban_Info;
                if (data == null)
                    return;
                if (data.cb_ChequeImpreso == "S")
                    e.Appearance.ForeColor = Color.Blue;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void btnSeleccionarChequeTalonario_Click(object sender, EventArgs e)
        {
            try
            {
                ba_Banco_Cuenta_Info obj_cmbProve = (ba_Banco_Cuenta_Info)gridLookUpEdit_banco.Properties.View.GetFocusedRow();
                if (obj_cmbProve != null)
                {
                    int idBanco = obj_cmbProve.IdBanco;
                    frm = new FrmBA_Talonario_cheques_x_bancoSeleccionar(idBanco);


                    frm.ShowDialog();
                    textBox1.EditValue = frm.num_cheque;
                }
                else
                {
                    MessageBox.Show("Favor seleccionar un Banco antes de proceder", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());

            }


        }

        private void chek_todos_CheckedChanged(object sender, EventArgs e)
        {
            try
            {

                bool chek_Todos = true;
                if (chek_todos.Checked == false) chek_Todos = false;
                foreach (var item in LstBin)
                {
                    item.chek = chek_Todos;
                }
                gridControl_cbt_ban.DataSource = null;
                gridControl_cbt_ban.DataSource = LstBin;
                gridControl_cbt_ban.Refresh();

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());

            }



        }
    }
}
