using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Core.Erp.Info.Bancos;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using Core.Erp.Business.Bancos;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Reportes.Bancos;
using System.IO;

using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;

namespace Core.Erp.Winform.Bancos
{
    public partial class FrmBA_Cheque_Imprimir : Form
    {
        #region Variables
        public string cb_Cheque;

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        string MensajeError = "";
       
        ba_Cbte_Ban_Info CbteBan_I = new ba_Cbte_Ban_Info();
        ba_Cbte_Ban_Bus CbteBan_B = new ba_Cbte_Ban_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        ct_Cbtecble_Bus busCont = new ct_Cbtecble_Bus();
        ct_Cbtecble_Info cbtecble = new ct_Cbtecble_Info();
        ct_Cbtecble_det_Bus busDetCbte = new ct_Cbtecble_det_Bus();
        List<ct_Cbtecble_det_Info> DetCbteCble = new List<ct_Cbtecble_det_Info>();
        ba_Banco_Cuenta_Info Info_Banco_Cta = new ba_Banco_Cuenta_Info();
        #endregion
       
        public FrmBA_Cheque_Imprimir()
        {
            try
            {
              InitializeComponent();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        private Boolean imprimir() 
        {
            try
            {
                
                string RootReporte = System.IO.Path.GetTempPath() + "Rpt_Cheque.repx";
               
                ba_Cbte_Ban_Bus CbteBan_B = new ba_Cbte_Ban_Bus();
                List<ba_Cbte_Ban_Info> lCbtBan = new List<ba_Cbte_Ban_Info>();
                CbteBan_I.IdUsuarioUltMod = param.IdUsuario;
                CbteBan_I.Fecha_UltMod = param.Fecha_Transac;
                CbteBan_I.cb_ChequeImpreso = "S";
                CbteBan_I.cb_Cheque = txt_NCheque.Text;
                CbteBan_B.ModificarDB(CbteBan_I, ref MensajeError);


                if (Info_Banco_Cta == null)
                {    MessageBox.Show("setear property :Info_Banco_Cta");
                    return false; 
                }
                if (Info_Banco_Cta.Imprimir_Solo_el_cheque == true)
                {
                    XBAN_Rpt006_rpt reporte = new XBAN_Rpt006_rpt();
                    XBAN_Rpt006_Bus BusReporte = new XBAN_Rpt006_Bus();

                    if (Info_Banco_Cta.ReporteSolo_Cheque != null)
                    {
                        File.WriteAllBytes(RootReporte, Info_Banco_Cta.ReporteSolo_Cheque);
                        reporte.LoadLayout(RootReporte);
                    }

                    reporte.RequestParameters = false;
                    ReportPrintTool pt = new ReportPrintTool(reporte);
                    pt.AutoShowParametersPanel = false;
                    reporte.Parameters["PIdEmpresa"].Value = CbteBan_I.IdEmpresa;
                    reporte.Parameters["PIdCbteCble"].Value = CbteBan_I.IdCbteCble;
                    reporte.Parameters["PIdTipoCbte"].Value = CbteBan_I.IdTipocbte;
                    //pregunta si se imprime una vista previa o no, esto se pergunta en la información del cheque
                    if (Info_Banco_Cta.MostrarVistaPreviaCheque == true)
                        reporte.ShowPreview();
                    else
                        reporte.ShowPreview();
                }
                else// cheq + cbte bancario
                {
                    XBAN_Rpt005_rpt reporte = new XBAN_Rpt005_rpt();
                    if (Info_Banco_Cta.Reporte != null)
                    {
                        File.WriteAllBytes(RootReporte, Info_Banco_Cta.Reporte);
                        reporte.LoadLayout(RootReporte);
                    }

                    reporte.RequestParameters = false;
                    ReportPrintTool pt = new ReportPrintTool(reporte);
                    pt.AutoShowParametersPanel = false;

                    reporte.PIdEmpresa.Value = CbteBan_I.IdEmpresa;
                    reporte.PIdCbteCble.Value = CbteBan_I.IdCbteCble;
                    reporte.PIdTipo.Value = CbteBan_I.IdTipocbte;

                    if (Info_Banco_Cta.MostrarVistaPreviaCheque == true)
                        reporte.ShowPreview();
                    else
                        reporte.Print();
                }
                return true;
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
                if (CbteBan_I.Estado == "I")
                    imprimir();
                else
                if (validaCheque())
                {
                    if (imprimir())
                    {
                        if (txt_NCheque.Text.Trim().Length != 0)
                        {
                            string mesg2 = "";
                            ba_Talonario_cheques_x_banco_Bus busTalChe = new ba_Talonario_cheques_x_banco_Bus();
                            busTalChe.Usar(CbteBan_I, txt_NCheque.Text, ref mesg2);
                        }
                        cbtecble.cb_Observacion = "Ch/" + CbteBan_I.cb_Cheque + " " + cbtecble.cb_Observacion;
                        DetCbteCble.ForEach(var => var.dc_Observacion = "Ch/" + CbteBan_I.cb_Cheque + var.dc_Observacion);
                        string msg = "";
                        busCont.ModificarDB(cbtecble,ref msg);
                               
                        this.Close();
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
        
        public void set_CbteBan_I(ba_Cbte_Ban_Info info)
        {
            try
            {
                this.txt_NCheque.Text = info.cb_Cheque;
                this.txt_NCheque.MaxLength = info.cb_Cheque.Length;
                cb_Cheque = info.cb_Cheque;
                CbteBan_I = info;

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
        
        public void set_CbteCble(ct_Cbtecble_Info  cbtecbleI )
        {
            try
            {
                string MensajeError = "";
                cbtecble = cbtecbleI;
                DetCbteCble = busDetCbte.Get_list_Cbtecble_det(param.IdEmpresa, cbtecble.IdTipoCbte, cbtecble.IdCbteCble, ref MensajeError);
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

        public void set_Banco_Cuenta(ba_Banco_Cuenta_Info _Info_Banco_Cuenta)
        {
            try
            {
                Info_Banco_Cta = _Info_Banco_Cuenta;
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

        private void FrmBA_Cheque_Imprimir_Load(object sender, EventArgs e)
        {
            if (CbteBan_I.Estado == "I")
                this.txt_NCheque.ReadOnly = true;
        }

        private void txt_NCheque_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Funciones val = new Funciones();
                e.Handled = val.ValidaNumero(e.KeyChar);
            }
            catch(Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
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

        public Boolean validaCheque()
        {
            try
            {
                string mensaje = "";
                if ((txt_NCheque.Text.Trim().Length != 0))
                {
                    if ((CbteBan_B.VericarChequeExiste(this.txt_NCheque.Text, param.IdEmpresa, CbteBan_I.IdCbteCble, Convert.ToInt32(CbteBan_I.IdTipocbte), CbteBan_I.IdBanco, ref mensaje) == true) && (this.txt_NCheque.Text != cb_Cheque))
                    {
                        MessageBox.Show("Por favor cambie el numero de cheque, porque ya fue girado a: " + mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_NCheque.Text = "";
                        txt_NCheque.Focus(); return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                else
                {
                    MessageBox.Show("No puede imprimir un cheque en blanco", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_NCheque.Text = "";
                    txt_NCheque.Focus(); return false;
                }

            }
            catch(Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
        }

        private void txt_NCheque_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                validaCheque();
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
                if (CbteBan_I.IdBanco != null)
                {
                    FrmBA_Talonario_cheques_x_bancoSeleccionar frm;
                    int idBanco = CbteBan_I.IdBanco;
                    frm = new FrmBA_Talonario_cheques_x_bancoSeleccionar(idBanco);
                    frm.MdiParent = this.MdiParent;
                    frm.ShowDialog();
                    txt_NCheque.Text = frm.num_cheque;
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
    }
}
