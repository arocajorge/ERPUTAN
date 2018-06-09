using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Core.Erp.Info.Facturacion;
using Core.Erp.Business.Facturacion;


using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Business.CuentasxPagar;

using Core.Erp.Business.General;

using Core.Erp.Info.General;

using Core.Erp.Winform.General;

namespace Core.Erp.Winform.Controles
{
    public partial class UCGe_NumeroDocTrans : UserControl
    {

        public string IdEstablecimiento { get; set; }
        public string IdPuntoEmision { get; set; }


        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        List<tb_sis_Documento_Tipo_Talonario_Info> listaTalonario = new List<tb_sis_Documento_Tipo_Talonario_Info>();
        tb_sis_Documento_Tipo_Talonario_Bus busTipoDoc = new tb_sis_Documento_Tipo_Talonario_Bus();

        fa_parametro_Bus Bus_Param_fac = new fa_parametro_Bus();
        fa_parametro_info Info_Param_fac = new fa_parametro_info();

        cp_parametros_Bus Bus_Param_cxp = new cp_parametros_Bus();
        cp_parametros_Info Info_Param_cxp = new cp_parametros_Info();

        tb_sis_Documento_Tipo_Talonario_Info Info_Documento_talonario_Actual = new tb_sis_Documento_Tipo_Talonario_Info();
        public Cl_Enumeradores.eTipoDocumento_Talonario IdTipoDocumento 
         {
             get { return _IdTipoDocumento; }
             set { 
                 
                 _IdTipoDocumento = value;

                 switch (_IdTipoDocumento)
                 {
                     case Cl_Enumeradores.eTipoDocumento_Talonario.FACT:
                         lblFactura.Text = "Factura#: ";
                         break;
                     case Cl_Enumeradores.eTipoDocumento_Talonario.GUIA:
                         lblFactura.Text = "Guia #: ";
                         break;
                     case Cl_Enumeradores.eTipoDocumento_Talonario.NTCR:
                         lblFactura.Text = "Nota Cre#: ";
                         break;
                     case Cl_Enumeradores.eTipoDocumento_Talonario.NTDB:
                         lblFactura.Text = "Nota Deb #: ";
                         break;
                     case Cl_Enumeradores.eTipoDocumento_Talonario.RETEN:
                         lblFactura.Text = "Reten. #: ";
                         break;
                 }
             
             }
         
         }
         Cl_Enumeradores.eTipoDocumento_Talonario _IdTipoDocumento = new Cl_Enumeradores.eTipoDocumento_Talonario();
       
        public UCGe_NumeroDocTrans()
        {
            try
            {
              InitializeComponent();

              if (_IdTipoDocumento == 0) { _IdTipoDocumento = Cl_Enumeradores.eTipoDocumento_Talonario.FACT; }
             
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        private void Set_Check_electronico(bool Check)
        {
            try
            {
                rbt_doc_Electronico.Checked = Check;
                rbt_pre_impresa.Checked = !Check; 
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void Cargar_parametros()
        {
            try
            {
                Info_Param_fac = Bus_Param_fac.Get_Info_parametro(param.IdEmpresa);
                Info_Param_cxp = Bus_Param_cxp.Get_Info_parametros(param.IdEmpresa);

                switch (IdTipoDocumento)
                {
                    case Cl_Enumeradores.eTipoDocumento_Talonario.FACT:
                        Set_Check_electronico(Info_Param_fac.pa_X_Defecto_la_factura_es_cbte_elect == null ? false : (bool)Info_Param_fac.pa_X_Defecto_la_factura_es_cbte_elect);
                        break;
                    case Cl_Enumeradores.eTipoDocumento_Talonario.NTCR:
                        Set_Check_electronico(Info_Param_fac.pa_X_Defecto_la_NC_es_cbte_elect == null ? false : (bool)Info_Param_fac.pa_X_Defecto_la_NC_es_cbte_elect);
                        break;
                    case Cl_Enumeradores.eTipoDocumento_Talonario.NTDB:
                        Set_Check_electronico(Info_Param_fac.pa_X_Defecto_la_ND_es_cbte_elect == null ? false : (bool)Info_Param_fac.pa_X_Defecto_la_ND_es_cbte_elect);
                        break;
                    case Cl_Enumeradores.eTipoDocumento_Talonario.GUIA:
                        Set_Check_electronico(Info_Param_fac.pa_X_Defecto_la_guia_es_cbte_elect == null ? false : (bool)Info_Param_fac.pa_X_Defecto_la_guia_es_cbte_elect);
                        break;

                    case Cl_Enumeradores.eTipoDocumento_Talonario.RETEN:
                        Set_Check_electronico(Info_Param_cxp.pa_X_Defecto_la_Retencion_es_cbte_elect == null ? false : (bool)Info_Param_cxp.pa_X_Defecto_la_Retencion_es_cbte_elect);
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public UCGe_NumeroDocTrans(Boolean fechaNAu)
        {
            try
            {
                InitializeComponent();
                
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        public tb_sis_Documento_Tipo_Talonario_Info Get_Info_Talonario()
        {
            try
            {
                Info_Documento_talonario_Actual = new tb_sis_Documento_Tipo_Talonario_Info();
                
                if (txtNumDoc.EditValue != "")
                {
                    if (txtNumDoc.EditValue != "")
                    {
                        string[] serie = Convert.ToString(txe_Serie.EditValue).Split('-');

                        Info_Documento_talonario_Actual.CodDocumentoTipo = _IdTipoDocumento.ToString();
                        Info_Documento_talonario_Actual.Establecimiento = serie[0];
                        Info_Documento_talonario_Actual.PuntoEmision = serie[1];
                        Info_Documento_talonario_Actual.NumDocumento = Convert.ToString(txtNumDoc.EditValue);
                        Info_Documento_talonario_Actual.es_Documento_electronico = (rbt_doc_Electronico.Checked == true)?rbt_doc_Electronico.Checked : rbt_pre_impresa.Checked;
                        
                    }
                }
                else
                    MessageBox.Show("Escoja un número de documento", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information); 

                        return Info_Documento_talonario_Actual;

                
                
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new tb_sis_Documento_Tipo_Talonario_Info();
            }             
        }


        public void Set_Serie_Num_Documento(string IdEstablecimiento, string IdPuntoVenta, string Num_Documento)
        {
            try
            {
                
                txe_Serie.EditValue = IdEstablecimiento + "-" + IdPuntoVenta;
                txtNumDoc.Text = Num_Documento;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
               
            }
        }

        public void Get_Ult_Documento_no_usado()
        {
            try
            {
                tb_sis_Documento_Tipo_Talonario_Info InfoTalonario = new tb_sis_Documento_Tipo_Talonario_Info();

                Boolean Es_doc_Electronico = false;

                Es_doc_Electronico = rbt_doc_Electronico.Checked;
                        
                InfoTalonario = busTipoDoc.Get_Info_Ult_Documento_no_usado(param.IdEmpresa, IdEstablecimiento,
                    IdPuntoEmision, _IdTipoDocumento.ToString(), Es_doc_Electronico);
                Info_Documento_talonario_Actual = InfoTalonario;                  
                txtNumDoc.Text = InfoTalonario.NumDocumento;                                        
                txe_Serie.EditValue = InfoTalonario.Establecimiento + "-" + InfoTalonario.PuntoEmision;
                           
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void Set_Perfil_solo_lectura(bool Mostrar)
        {
            try
            {
                rbt_doc_Electronico.Enabled = !Mostrar;
                rbt_pre_impresa.Enabled = !Mostrar;
                btnBuscar.Visible = !Mostrar;
                txtNumDoc.Properties.ReadOnly = Mostrar;
                txe_Serie.Properties.ReadOnly = Mostrar;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void Get_Primer_Documento_no_usado()
        {
            try
            {
                tb_sis_Documento_Tipo_Talonario_Info InfoTalonario = new tb_sis_Documento_Tipo_Talonario_Info();

                Boolean Es_doc_Electronico = false;

                Es_doc_Electronico = rbt_doc_Electronico.Checked;


                InfoTalonario = busTipoDoc.Get_Info_Primer_Documento_no_usado
                    (param.IdEmpresa, IdEstablecimiento, IdPuntoEmision, _IdTipoDocumento.ToString(), Es_doc_Electronico);
                Info_Documento_talonario_Actual = InfoTalonario;
                txtNumDoc.Text = InfoTalonario.NumDocumento;
                txe_Serie.EditValue = InfoTalonario.Establecimiento + "-" + InfoTalonario.PuntoEmision;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
  
        private void UCFA_NumeroDocTrans_Load(object sender, EventArgs e)
        {
            try
            {
                Cargar_parametros();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
             
        public void Set_Ocultar_LabelFactura()
        {
            lblFactura.Visible = false;      
        }

        public void limpiarControles()
        {
            txtNumDoc.EditValue = "";                      
            txe_Serie.EditValue = "";
        }

        public void Inhabilitar_Controles()
        {
            btnBuscar.Enabled = false;
            txe_Serie.Properties.ReadOnly = true;
            txtNumDoc.Properties.ReadOnly = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                Boolean Es_doc_Electronico = false;

                Es_doc_Electronico = rbt_doc_Electronico.Checked;


                FrmGe_Documento_Tipo_Talonario_Cons frm = new FrmGe_Documento_Tipo_Talonario_Cons(_IdTipoDocumento.ToString(), Es_doc_Electronico);
                Info_Documento_talonario_Actual = new tb_sis_Documento_Tipo_Talonario_Info();
                frm.ShowDialog();
                Info_Documento_talonario_Actual = frm.Get_Info_Talonario_Documentos();


                if (Info_Documento_talonario_Actual != null)
                {
                    txtNumDoc.EditValue = Info_Documento_talonario_Actual.NumDocumento;
                    txe_Serie.EditValue = Info_Documento_talonario_Actual.Establecimiento + "-" + Info_Documento_talonario_Actual.PuntoEmision;               
                }            
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
      
        public Boolean valida_numRetencion()
        {

            Boolean res = false;
            try
            {                           
                if (txtNumRetencion_Validating())
                {
                    res= true;
                }

                return res;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return res;
            }
        
        }

        private Boolean txtNumRetencion_Validating()
        {
            try
            {
                string msg = "";

                busTipoDoc = new tb_sis_Documento_Tipo_Talonario_Bus();

                 string[] serie = Convert.ToString(txe_Serie.EditValue).Split('-');

                 string Establecimiento = serie[0];
                 string PuntoEmision = serie[1];

                 if (Establecimiento == "" && PuntoEmision == "" && (txtNumDoc.EditValue == null || txtNumDoc.EditValue == ""))
                {
                    return true;
                
                }

                              
                if (busTipoDoc.Verificar_NumTalonario(param.IdEmpresa, _IdTipoDocumento.ToString(),
                   Establecimiento, PuntoEmision,Convert.ToString(txtNumDoc.EditValue), ref msg) == false)
                {
                    MessageBox.Show(msg);

                    txtNumDoc.Focus();

                    IdEstablecimiento = "001";
                    IdPuntoEmision = "001";
                    Get_Ult_Documento_no_usado();
                    return false;
                }
                else
                {
                    return true;

                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
        }

        private void rbt_doc_Electronico_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                txtNumDoc.Text = "";
                txe_Serie.Text = "";
                Get_Primer_Documento_no_usado();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void txe_Serie_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
