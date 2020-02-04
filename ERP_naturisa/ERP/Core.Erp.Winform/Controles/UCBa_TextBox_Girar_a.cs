using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Business.General;
using Core.Erp.Info.General;



namespace Core.Erp.Winform.Controles
{
    public partial class UCBa_TextBox_Girar_a : UserControl
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        List<tb_persona_Info> listPersonas = new List<tb_persona_Info>();
        tb_persona_bus BusPersona = new tb_persona_bus();
        tb_persona_Info _InfoPersona = new tb_persona_Info();
        decimal id_per = 0;


        public decimal Get_Id_Persona()
        {
            return id_per;
        }

        public tb_persona_Info Get_InfoPersona()
        {                      
            return _InfoPersona;
        }
      
        public void set_InfoPersona(tb_persona_Info Info)
        {                      
            _InfoPersona = Info;
        }

        public string get_NomBeneficiario()
        {          
            return txt_girar_a.Text;
        }

        public void set_NomBeneficiario(string nom_Beneficiario,decimal IdPersonaGira)
        {
            txt_girar_a.Text = nom_Beneficiario;
            id_per = IdPersonaGira;
        }

        public void Inhabilitar_Beneficiario(bool valor)
        {
            try
            {
                txt_girar_a.Properties.ReadOnly = valor;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

            
        
        }

        public void Limpiar_Beneficiario()
        {
            try
            {
                txt_girar_a.Text = "";
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
           

        }

      

        public string valida()
        {
            try
            {
                string beneficiario = "";

                beneficiario = txt_girar_a.Text;

                return beneficiario;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return "";
            }

            
        }


        public UCBa_TextBox_Girar_a()
        {
            InitializeComponent();
            _InfoPersona = new tb_persona_Info();
        }

        private void UCBa_TextBox_Girar_a_Load(object sender, EventArgs e)
        {
            try
            {


               

                listPersonas = BusPersona.Get_List_Persona();
               cmb_persona.Properties.DataSource = listPersonas;

               cmb_persona.Hide();



            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        private void txt_girar_a_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                if (!txt_girar_a.Properties.ReadOnly == true)
                {
                    Mostrar_combo_persona();

                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
            
            
            
        }

        private void Mostrar_combo_persona()
        {
            try
            {
                cmb_persona.Width = txt_girar_a.Width;
                cmb_persona.Height = txt_girar_a.Height;
                cmb_persona.Top = txt_girar_a.Top;
                cmb_persona.Left = txt_girar_a.Left;



                cmb_persona.Show();
                cmb_persona.ShowPopup();

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }



        private void txt_girar_a_EditValueChanged(object sender, EventArgs e)
        {
            id_per = 0;
        }

        private void cmb_persona_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                _InfoPersona = listPersonas.FirstOrDefault(v => v.IdPersona == Convert.ToDecimal(cmb_persona.EditValue));

                //string gira=_InfoPersona.
                if (_InfoPersona != null)
                {
                    txt_girar_a.Text = (String.IsNullOrEmpty(_InfoPersona.pe_razonSocial)) ? _InfoPersona.pe_apellido + " " + _InfoPersona.pe_nombre : _InfoPersona.pe_razonSocial;

                    id_per = _InfoPersona.IdPersona;
                }


                cmb_persona.Hide();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                
            }
            
        }
    }
}
