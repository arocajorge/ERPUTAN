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



namespace Core.Erp.Winform.Bancos
{
    public partial class FrmBA_Config_Diseno_Cheque : Form
    {
        #region Declaración de Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        double px = 0.264583;
        decimal x;
        private Cl_Enumeradores.eTipo_action _Accion;
        public void set_Accion(Cl_Enumeradores.eTipo_action iAccion) { _Accion = iAccion; }
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        public ba_Config_Diseno_Cheque_Info DiseñoI = new ba_Config_Diseno_Cheque_Info();
        ba_Config_Diseno_Cheque_Bus DiseñoB = new ba_Config_Diseno_Cheque_Bus();
        ba_Banco_Cuenta_Bus busbanco = new Business.Bancos.ba_Banco_Cuenta_Bus();
        public int IdBanco { get; set; }
        int TamanoCheqAlto_Scroll = 0;




        #endregion
    
        public FrmBA_Config_Diseno_Cheque()
        {
            try
            {
                InitializeComponent();
                cmb_CtaBanco.Properties.DataSource = busbanco.Get_list_Banco_Cuenta(param.IdEmpresa);
                ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
                ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
                ucGe_Menu.event_btnImprimir_Click += ucGe_Menu_event_btnImprimir_Click;
                ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void ucGe_Menu_event_btnImprimir_Click(object sender, EventArgs e)
        {

            try
            {
                //XRptBa_ChequeImpreso rep = new XRptBa_ChequeImpreso();
                //// rep.RedisenoCheque();
                //rep.ShowPreviewDialog();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar())
                {
                    guardar();
                    Close(); 
                }
                
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {

            try
            {
                if (Validar())
                {
                    guardar();
                }
               
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        public void set_Info(ba_Config_Diseno_Cheque_Info Info) 
        {
            try
            {
                txtAlto.Value = Info.Tama_Cheque_Y;
                txtAncho.Value = Info.Tama_Cheque_X;
                txtFechaX.Value = Info.Fecha_X;
                txtFechaY.Value = Info.Fecha_Y;
                txtInicioChequeX.Value = Info.Area_Imprimir_X;
                txtInicioChequeY.Value = Info.Area_Imprimir_Y;
                txtPagueseX.Value = Info.PagueseA_X;
                txtPagueseY.Value = Info.PagueseA_Y;
                txtValorLetrasX.Value = Info.ValorLetra_Cheque_X;
                txtValorLetrasY.Value = Info.ValorLetra_Cheque_Y;
                txtValorNumeroX.Value = Info.ValorCheque_X;
                txtValorNumeroY.Value = Info.ValorCheque_Y;
                cmb_CtaBanco.EditValue = Info.idBanco;
                txtNom_Impresora.Text = Info.Nom_Impresora;
                txtPto_Impresora.Text = Info.Pto_Impresora;

                DiseñoI = Info;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void setPosicionInicial()
        {
            try
            {
                ba_Config_Diseno_Cheque_Info Info = new ba_Config_Diseno_Cheque_Info();
                txtAlto.Value = Info.Tama_Cheque_Y= 60;
                txtAncho.Value = Info.Tama_Cheque_X= 140;
                txtFechaX.Value = Info.Fecha_X= 10;
                txtFechaY.Value = Info.Fecha_Y= 40;
                txtInicioChequeX.Value = Info.Area_Imprimir_X = 5;
                txtInicioChequeY.Value = Info.Area_Imprimir_Y= 5;
                txtPagueseX.Value = Info.PagueseA_X=10;
                txtPagueseY.Value = Info.PagueseA_Y= 15;
                txtValorLetrasX.Value = Info.ValorLetra_Cheque_X= 10;
                txtValorLetrasY.Value = Info.ValorLetra_Cheque_Y= 20;
                txtValorNumeroX.Value = Info.ValorCheque_X =110;
                txtValorNumeroY.Value = Info.ValorCheque_Y=10;
                txtPto_Impresora.Text = "";
                txtNom_Impresora.Text = "";
                
                DiseñoI = Info;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
        
        private Boolean Validar()
        {
            try
            {
                Boolean resul = false;
                    try
                    {
                        if (IdBanco == 0 || IdBanco == null)
                        {
                            MessageBox.Show("Seleccione un Banco",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);

                        }
                        else
                        {

                            resul = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                        resul = false;
                    }
                    return resul;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
        }

        public ba_Config_Diseno_Cheque_Info Get_Info() 
        {
            try
            {
                DiseñoI.idBanco = IdBanco;
                DiseñoI.idEmpresa = param.IdEmpresa;
                DiseñoI.Tama_Cheque_X = Convert.ToInt32(txtAncho.Value);
                DiseñoI.Tama_Cheque_Y = Convert.ToInt32(txtAlto.Value);
                DiseñoI.Fecha_X = Convert.ToInt32(txtFechaX.Value);
                DiseñoI.Fecha_Y = Convert.ToInt32(txtFechaY.Value);
                DiseñoI.Area_Imprimir_X = Convert.ToInt32(txtInicioChequeX.Value);
                DiseñoI.Area_Imprimir_Y = Convert.ToInt32(txtInicioChequeY.Value);
                DiseñoI.PagueseA_X = Convert.ToInt32(txtPagueseX.Value);
                DiseñoI.PagueseA_Y = Convert.ToInt32(txtPagueseY.Value);
                DiseñoI.ValorCheque_X = Convert.ToInt32(txtValorNumeroX.Value);
                DiseñoI.ValorCheque_Y = Convert.ToInt32(txtValorNumeroY.Value);
                DiseñoI.ValorLetra_Cheque_X = Convert.ToInt32(txtValorLetrasX.Value);
                DiseñoI.ValorLetra_Cheque_Y = Convert.ToInt32(txtValorLetrasY.Value);
                DiseñoI.idEmpresa = param.IdEmpresa;
                DiseñoI.Nom_Impresora = txtNom_Impresora.Text;
                DiseñoI.Pto_Impresora = txtPto_Impresora.Text;
                return DiseñoI;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                DiseñoI = new Info.Bancos.ba_Config_Diseno_Cheque_Info();
                return DiseñoI;
            }
            
        }

        private void frmBA_Config_Diseno_Cheque_Load(object sender, EventArgs e)
        {
            try
            {
                switch (_Accion)
            {
                case Cl_Enumeradores.eTipo_action.grabar:
                    ucGe_Menu.Visible_btnGuardar = true;
                    ucGe_Menu.Visible_bntGuardar_y_Salir = true;

                    break;
                case Cl_Enumeradores.eTipo_action.actualizar:
                   ucGe_Menu.Visible_btnGuardar = true;
                   ucGe_Menu.Visible_bntGuardar_y_Salir = true;
                 
                    break;
                default:
                    break;
            }

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
            
        }
        //*********************ALTO DEL CHEQUE*************************//
        private void trbTamañoAlto_Scroll(object sender, EventArgs e)
        {
            try
            {



                this.pnlMargenCheque.Height = trbTamañoAlto.Value;

                //TamanoCheqAlto_Scroll = trbTamañoAlto.Value;

                x = Convert.ToDecimal(trbTamañoAlto.Value * px);

                txtAlto.Value = decimal.Round(x);


               // DibujarCheque();

           
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void txtAlto_ValueChanged(object sender, EventArgs e)
        {
            try
            {
            x = txtAlto.Value;
            trbTamañoAlto.Value = Convert.ToInt32(Convert.ToInt32(x) / px);
            this.pnlMargenCheque.Height = trbTamañoAlto.Value;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
        //**************************************************************//
       
        //*********************ANCHO DEL CHEQUE*************************//
        private void trbTamañoAncho_Scroll(object sender, EventArgs e)
        {
            try
            {
                 x = Convert.ToDecimal(trbTamañoAncho.Value * px);
                this.pnlMargenCheque.Width = trbTamañoAncho.Value;
                txtAncho.Value = x;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void txtAncho_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                x = txtAncho.Value;
                trbTamañoAncho.Value = Convert.ToInt32(Convert.ToInt32(x) / px);
                this.pnlMargenCheque.Width = trbTamañoAncho.Value;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        //*************************************************************//

        //*********************POSICION DEL CHEQUE EN X*****************//
        private void trbInicioCheX_Scroll(object sender, EventArgs e)
        {
            try
            {
                x = Convert.ToDecimal(trbInicioCheX.Value * px);
                this.pnlMargenCheque.Left = trbInicioCheX.Value;
                txtInicioChequeX.Value = x;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }
        private void txtInicioChequeX_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                x = txtInicioChequeX.Value;
                trbInicioCheX.Value = Convert.ToInt32(Convert.ToInt32(x) / px);
                this.pnlMargenCheque.Left = trbInicioCheX.Value;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }
        //*************************************************************//

        //*********************POSICION DEL CHEQUE EN Y*****************//
        private void trbInicioCheY_Scroll(object sender, EventArgs e)
        {
            try
            {
                x = Convert.ToDecimal(trbInicioCheY.Value * px);
                this.pnlMargenCheque.Top = trbInicioCheY.Value;
                txtInicioChequeY.Value = decimal.Round(x);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }
        private void txtInicioChequeY_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                 x = txtInicioChequeY.Value;
            trbInicioCheY.Value = Convert.ToInt32(Convert.ToInt32(x) / px);
            this.pnlMargenCheque.Top = trbInicioCheY.Value;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
       //*************************************************************//

        //*********************PAGUESE A ORDE DE Y*****************//
        private void trbPagueseY_Scroll(object sender, EventArgs e)
        {
            try
            {
                x = Convert.ToDecimal(trbPagueseY.Value * px);
                this.lblPaguese.Top = trbPagueseY.Value;
                txtPagueseY.Value = decimal.Round(x);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

           
        }
        private void txtPagueseY_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                x = txtPagueseY.Value;
                trbPagueseY.Value = Convert.ToInt32(Convert.ToInt32(x) / px);
                this.lblPaguese.Top = trbPagueseY.Value;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }
        //*************************************************************//

        //*********************PAGUESE A ORDE DE X*****************//
        private void trbPagueseX_Scroll(object sender, EventArgs e)
        {
            try
            {
                x = Convert.ToDecimal(trbPagueseX.Value * px);
                this.lblPaguese.Left = trbPagueseX.Value;
                txtPagueseX.Value = decimal.Round(x);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }
        private void txtPagueseX_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                 x = txtPagueseX.Value;
                trbPagueseX.Value = Convert.ToInt32(Convert.ToInt32(x) / px);
                this.lblPaguese.Left = trbPagueseX.Value;       }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }
        //*************************************************************//

        //*********************Valor NumeroY*****************//
        private void trbValorNumeroY_Scroll(object sender, EventArgs e)
        {
            try
            {
                x = Convert.ToDecimal(trbValorNumeroY.Value * px);
                this.lblValorNum.Top = trbValorNumeroY.Value;
                txtValorNumeroY.Value = decimal.Round(x);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }
        private void txtValorNumeroY_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                x = txtValorNumeroY.Value;
                trbValorNumeroY.Value = Convert.ToInt32(Convert.ToInt32(x) / px);
                this.lblValorNum.Top = trbValorNumeroY.Value;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }


        }
        //*************************************************************//

        //*********************Valor Numerox*****************//
        private void trbValorNumeroX_Scroll(object sender, EventArgs e)
        {
            try
            {
                x = Convert.ToDecimal(trbValorNumeroX.Value * px);
                this.lblValorNum.Left = trbValorNumeroX.Value;
                txtValorNumeroX.Value = decimal.Round(x); 
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }
        private void txtValorNumeroX_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                x = txtValorNumeroX.Value;
               trbValorNumeroX.Value = Convert.ToInt32(Convert.ToInt32(x) / px);
                this.lblValorNum.Left = trbValorNumeroX.Value;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }


        }
        //*************************************************************//

        //*********************Valor Letras Y*****************//
        private void trbValorLetrasY_Scroll(object sender, EventArgs e)
        {
            try
            {
                x = Convert.ToDecimal(trbValorLetrasY.Value * px);
                this.lblValorLetr.Top = trbValorLetrasY.Value;
                txtValorLetrasY.Value = decimal.Round(x);
           //    MessageBox.Show(x.ToString());
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }
        private void txtValorLetrasY_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                x = txtValorLetrasY.Value;
                trbValorLetrasY.Value = Convert.ToInt32(Convert.ToInt32(x) / px);
                this.lblValorLetr.Top = trbValorLetrasY.Value;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }


        }
        //*************************************************************//

        //*********************Valor Letras X*****************//
        private void trbValorLetrasX_Scroll(object sender, EventArgs e)
        {
            try
            {
                x = Convert.ToDecimal(trbValorLetrasX.Value * px);
                this.lblValorLetr.Left = trbValorLetrasX.Value;
                txtValorLetrasX.Value = x;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

            
        }
        private void txtValorLetrasX_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                x = txtValorLetrasX.Value;
                trbValorLetrasX.Value = Convert.ToInt32(Convert.ToInt32(x) / px);
                this.lblValorLetr.Left = trbValorLetrasX.Value;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }
        //*************************************************************//

        //*********************Fecha X*****************//
        private void trbFechaX_Scroll(object sender, EventArgs e)
        {
            try
            {
                x = Convert.ToDecimal(trbFechaX.Value * px);
                this.lblFecha.Left = trbFechaX.Value;
                txtFechaX.Value = decimal.Round(x);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }
        private void txtFechaX_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                x = txtFechaX.Value;
                trbFechaX.Value = Convert.ToInt32(Convert.ToInt32(x) / px);
                this.lblFecha.Left = trbFechaX.Value;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

            
        }
       

        //*********************Fecha Y*****************//
        private void trbFechaY_Scroll(object sender, EventArgs e)
        {
            try
            {
                x = Convert.ToDecimal(trbFechaY.Value * px);
                this.lblFecha.Top = trbFechaY.Value;
                txtFechaY.Value = decimal.Round(x);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }
        private void txtFechaY_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                x = txtFechaY.Value;
                trbFechaY.Value = Convert.ToInt32(Convert.ToInt32(x) / px);
                this.lblFecha.Top = trbFechaY.Value;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }
        //*************************************************************//

        private void DibujarCheque()
        {
            try
            {
             // alto del cheque

                trbTamañoAlto.Value = TamanoCheqAlto_Scroll;
                this.pnlMargenCheque.Height = TamanoCheqAlto_Scroll;

                x = Convert.ToDecimal(TamanoCheqAlto_Scroll * px);
                txtAlto.Value = decimal.Round(x);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void guardar()
        {
            try
            {
                 Get_Info();
                string mensaje = ".....";
                    if (Validar())
                    {
                            if (DiseñoB.GrabarDB(DiseñoI, ref mensaje))
                            {
                                string smensaje = string.Format("El Diseño del Cheque se guardó con Exito");
                                MessageBox.Show(smensaje, param.Nombre_sistema);
                                label6.Visible = false;
                            }
                            else
                            {
                                string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgError_Grabar);
                                MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);  

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

        private void cmb_CtaBanco_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                IdBanco = Convert.ToInt32(cmb_CtaBanco.EditValue);
                if (IdBanco != 0 && IdBanco != null)
                { 
                    ba_Banco_Cuenta_Info rr = new Info.Bancos.ba_Banco_Cuenta_Info();
                    rr.IdEmpresa = param.IdEmpresa; rr.IdBanco = IdBanco;
                    var Info = DiseñoB.Get_List_Config_Diseno_Cheque(rr);
                    if (Info.idBanco == 0)
                    {
                        label6.Visible = true;
                        setPosicionInicial();
                    }
                    else
                    {
                        label6.Visible = false;
                        set_Info(Info);
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
       
    }
}

/// <summary>
/// Prog: Katiuska Franco
/// Ult Mod: 26/02/2014  12:09
/// LIN539
/// </summary>