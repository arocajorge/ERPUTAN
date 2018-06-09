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
using Core.Erp.Business.General;
namespace Core.Erp.Winform.Bancos
{
    public partial class FrnBA_entrega_cheque : Form
    {
        public FrnBA_entrega_cheque()
        {
            InitializeComponent();
        }
        string msg="";
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        ba_Cbte_Ban_Info infoCbte = new ba_Cbte_Ban_Info();
        ba_Cbte_Ban_Datos_Entrega_cheq_Info info = new ba_Cbte_Ban_Datos_Entrega_cheq_Info();
        ba_Cbte_Ban_Datos_Entrega_cheq_Bus bus=new ba_Cbte_Ban_Datos_Entrega_cheq_Bus();
        ba_Catalogo_Bus bus_catalogo = new ba_Catalogo_Bus();
        List<ba_Catalogo_Info> lista_catalogo = new List<ba_Catalogo_Info>();
        
        ba_Cbte_Ban_Bus comprobante_bus = new ba_Cbte_Ban_Bus();
        private void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if(Validar())
                   if( Grabar())
                       this.Close();
            }
            catch (Exception ex)
            {
                
            }
        }

        public void Set(ba_Cbte_Ban_Info infoCbte_)
        {
            try
            {
                infoCbte = infoCbte_;
                txt_banco.EditValue = infoCbte.Banco;
                txt_beneficiario.EditValue = infoCbte.Beneficiario;
                txt_observacion.EditValue = infoCbte.cb_Observacion;
                txt_valor.EditValue = infoCbte.cb_Valor;
                txt_num_comp.EditValue = infoCbte.IdCbteCble;
                txt_nom_cheq.EditValue = infoCbte.cb_Cheque;
                cmb_estado.EditValue = "ESTCBENT";

               


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());

            }
        }
        public void Get()
        {
            try
            {
                info.IdEmpresa = infoCbte.IdEmpresa;
                info.IdCbteCble = infoCbte.IdCbteCble;
                info.IdTipocbte = infoCbte.IdTipocbte;
                info.IdPersona_Entrega = ucGe_Beneficiario1.Get_Info_Persona().IdPersona;
                info.Nota_entrega = txt_observacion.EditValue.ToString();
                info.fecha_hora_entrega = dtp_Fecha_Inicio.Value;
                info.fecha_trans = DateTime.Now;
                info.IdEstado_cheque_cat = cmb_estado.EditValue.ToString();
                info.usuario=param.IdUsuario;

            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.ToString());
            }
        }

        private bool Validar()
        {
            try
            {
                bool ba = true;
                if (cmb_estado.EditValue == null)
                {
                  MessageBox.Show(param.Get_Mensaje_sys(Info.General.enum_Mensajes_sys.Seleccione_el)+" Estado cheq.", param.Nombre_sistema, MessageBoxButtons.OK,MessageBoxIcon.Information);
                  ba = false;
                }
                if (ucGe_Beneficiario1.Get_Info_Persona() == null)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(Info.General.enum_Mensajes_sys.Seleccione_el) + " el beneficiario", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ba = false;
                }


                if (txt_banco.Text == "")
                {
                    MessageBox.Show(param.Get_Mensaje_sys(Info.General.enum_Mensajes_sys.Por_Favor_ingrese_la) + " observaciòn", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ba = false;
                }

                return ba;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                return false;
            }
        }

        private bool Grabar()
        {
            bool bandera = false;
            try
            {
                Get();

                if (bus.GrabarDB(info, ref msg))
                {
                    bandera = comprobante_bus.Modificar_estado_Cheq(infoCbte, eEstado_Cheque.ESTCBENT, ref msg);
                }

                if (bandera)
                    MessageBox.Show(param.Get_Mensaje_sys(Info.General.enum_Mensajes_sys.Se_guardaron_los_datos_correctamente), param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Information);
                  else
                    MessageBox.Show(param.Get_Mensaje_sys(Info.General.enum_Mensajes_sys.No_se_guardaron_los_datos), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return bandera;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
          }

        private void FrnBA_entrega_cheque_Load(object sender, EventArgs e)
        {
            try
            {
                lista_catalogo = bus_catalogo.Get_List_Catalogo("EST_CB_BA");
                cmb_estado.Properties.DataSource = lista_catalogo;
            }
            catch (Exception ex)
            {
                
            }
        }

        void ucGe_Persona_cmb1_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        }
    }

