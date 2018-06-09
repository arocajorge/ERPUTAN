using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Info.Bancos;
using Core.Erp.Business.Bancos;
using Core.Erp.Info.General;
using Core.Erp.Business.General;


namespace Core.Erp.Winform.Bancos
{
    public partial class FrmBA_Administracion_Archivos_PreAvisoCheques_Mant : Form
    {
        string MensajeError = "";

        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        
        ba_parametros_Bus BusParamBan = new ba_parametros_Bus();

        ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Bus BusTipoCbte_x_CbteCble = new ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Bus();
        ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Info InfoTipoCbte_x_CbteCble = new ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Info();


        public delegate void delegate_FrmBA_Administracion_Archivos_PreAvisoCheques_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_FrmBA_Administracion_Archivos_PreAvisoCheques_Mant_FormClosing event_FrmBA_Administracion_Archivos_PreAvisoCheques_Mant_FormClosing;


        private Cl_Enumeradores.eTipo_action _Accion;


        public void set_Accion(Cl_Enumeradores.eTipo_action iAccion)
        {
            try
            {
                _Accion = iAccion;
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


        public FrmBA_Administracion_Archivos_PreAvisoCheques_Mant()
        {
            InitializeComponent();
            event_FrmBA_Administracion_Archivos_PreAvisoCheques_Mant_FormClosing += FrmBA_Administracion_Archivos_PreAvisoCheques_Mant_event_FrmBA_Administracion_Archivos_PreAvisoCheques_Mant_FormClosing;
        }

        void FrmBA_Administracion_Archivos_PreAvisoCheques_Mant_event_FrmBA_Administracion_Archivos_PreAvisoCheques_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void cmbBuscar_Click(object sender, EventArgs e)
        {
            Cargar_Cheques();
        }

        private void Cargar_Cheques()
        {
            try
            {

                ba_Cbte_Ban_Bus BusCbteBan = new ba_Cbte_Ban_Bus();
                List<ba_Cbte_Ban_Info> ListCbteBan = new List<ba_Cbte_Ban_Info>();
                string sIdEstadoPreavisoCheq = "";
                DateTime FechaIni=dtpFechadesde.Value;
                DateTime FechaFin=dtpFechaHasta.Value;

                sIdEstadoPreavisoCheq = (chkMostar_che_Preavisados.Checked == true) ? "" : eEstado_Preaviso_Cheque.ES_CH_XPREAVISO_CH.ToString();


                ListCbteBan = BusCbteBan.Get_List_Cbte_Ban(param.IdEmpresa, InfoTipoCbte_x_CbteCble.IdTipoCbteCble, FechaIni, FechaFin, sIdEstadoPreavisoCheq, ref MensajeError);
                gridControlDetalleCheques.DataSource = ListCbteBan;


            }
            catch (Exception ex)
            {
                
                
            }

        }

        private void FrmBA_Administracion_Archivos_PreAvisoCheques_Mant_Load(object sender, EventArgs e)
        {
            InfoTipoCbte_x_CbteCble = BusTipoCbte_x_CbteCble.Get_List_Cbte_Ban_tipo_x_ct_CbteCble_tipo(param.IdEmpresa).FirstOrDefault(v => v.CodTipoCbteBan == "CHEQ");
            dtpFechadesde.Value = DateTime.Now.AddMonths(-1);
            dtpFechaHasta.Value = DateTime.Now.AddMonths(1);


        }

        private void FrmBA_Administracion_Archivos_PreAvisoCheques_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            event_FrmBA_Administracion_Archivos_PreAvisoCheques_Mant_FormClosing(sender, e);
        }
    }
}
