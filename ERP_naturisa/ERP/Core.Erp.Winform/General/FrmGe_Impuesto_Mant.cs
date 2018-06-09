using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Business.CuentasxPagar;


namespace Core.Erp.Winform.General
{
    public partial class FrmGe_Impuesto_Mant : Form
    {
        public FrmGe_Impuesto_Mant()
        {
            InitializeComponent();
            Event_FrmGe_Impuesto_Mant_FormClosing += FrmGe_Impuesto_Mant_Event_FrmGe_Impuesto_Mant_FormClosing;
           
        }

        void FrmGe_Impuesto_Mant_Event_FrmGe_Impuesto_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void FrmGe_Impuesto_Mant_Load(object sender, EventArgs e)
        {
            if (_Accion == 0) { _Accion = Cl_Enumeradores.eTipo_action.grabar; }
            cargar_combo();
            setAccion_in_control();
        }
    

        #region Declaración de Variables


        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        tb_sis_impuesto_Bus BusImpuesto_Tipo = new tb_sis_impuesto_Bus();        

        private Cl_Enumeradores.eTipo_action _Accion;
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        
        tb_sis_impuesto_Info Info_Impuesto = new tb_sis_impuesto_Info();

        public delegate void Delegate_FrmGe_Impuesto_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event Delegate_FrmGe_Impuesto_Mant_FormClosing Event_FrmGe_Impuesto_Mant_FormClosing;

        #endregion

        public void SetInfo(tb_sis_impuesto_Info _Info_Impuesto)
        {
            try
            {
                Info_Impuesto = _Info_Impuesto;
            }
            catch (Exception ex)
            {
                                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
        
        }

        public void SetAccion(Cl_Enumeradores.eTipo_action iAccion)
        {
            try
            {
                _Accion = iAccion;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }

        }

        private void setAccion_in_control()
        {
            try
            {
                        switch (_Accion)
                    {
                        case Cl_Enumeradores.eTipo_action.grabar:
                            break;
                        case Cl_Enumeradores.eTipo_action.actualizar:
                            txt_codigo.ReadOnly = true;
                            SetInfo();
                            break;
                        case Cl_Enumeradores.eTipo_action.Anular:
                            txt_codigo.ReadOnly = true;
                            ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                            ucGe_Menu.Visible_btnGuardar = false;
                            SetInfo();
                            break;
                        case Cl_Enumeradores.eTipo_action.consultar:
                           ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                            ucGe_Menu.Visible_btnGuardar = false;
                            SetInfo();
                            break;
                        default:
                            break;
                    }
            }
            catch (Exception ex)
            {
                   Log_Error_bus.Log_Error(ex.ToString());
                   MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
        }

        private void SetInfo()
        {
            try
            {
                txt_codigo.Text = Info_Impuesto.IdCod_Impuesto;
                txt_nombre.Text = Info_Impuesto.nom_impuesto;
                cmb_tipo_impuesto.EditValue = Info_Impuesto.IdTipoImpuesto;
                chk_usado_vta.Checked = Info_Impuesto.Usado_en_Ventas;
                chk_usado_compra.Checked = Info_Impuesto.Usado_en_Compras;
                txt_porcentaje.Text = Info_Impuesto.porcentaje.ToString();
                cmb_codigo_sri.EditValue = Info_Impuesto.IdCodigo_SRI;


                tb_sis_Impuesto_x_ctacble_Bus Bus_imp_x_cta = new tb_sis_Impuesto_x_ctacble_Bus();
                Info_Impuesto.Info_sis_Impuesto_x_ctacble = Bus_imp_x_cta.Get_Info_impuesto(param.IdEmpresa, Info_Impuesto.IdCod_Impuesto);
                cmb_plan_cta.set_PlanCtarInfo(Info_Impuesto.Info_sis_Impuesto_x_ctacble.IdCtaCble);
            
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
            
        }

        private tb_sis_impuesto_Info GetInfo()
        {
            try
            {
                Info_Impuesto.IdCod_Impuesto = txt_codigo.Text;
                Info_Impuesto.nom_impuesto = txt_nombre.Text;
                Info_Impuesto.IdTipoImpuesto = cmb_tipo_impuesto.EditValue.ToString();
                Info_Impuesto.Usado_en_Ventas = chk_usado_vta.Checked;
                Info_Impuesto.Usado_en_Compras = chk_usado_compra.Checked;
                Info_Impuesto.porcentaje = Convert.ToDouble(txt_porcentaje.Text);
                Info_Impuesto.IdCodigo_SRI = Convert.ToInt32(cmb_codigo_sri.EditValue);

                tb_sis_Impuesto_x_ctacble_Info Info_Impuesto_x_ctacble= new tb_sis_Impuesto_x_ctacble_Info();
                Info_Impuesto_x_ctacble.IdEmpresa_cta = param.IdEmpresa;
                Info_Impuesto_x_ctacble.IdCtaCble = cmb_plan_cta.get_PlanCtaInfo().IdCtaCble;
                Info_Impuesto_x_ctacble.IdCod_Impuesto = Info_Impuesto.IdCod_Impuesto;

                Info_Impuesto.Info_sis_Impuesto_x_ctacble = Info_Impuesto_x_ctacble;


                

                return Info_Impuesto;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return Info_Impuesto;
            }
        }
       
        void Guardar() 
        {
            try
            {
                string Mensaje ="";
                if (BusImpuesto_Tipo.GrabarDB(Info_Impuesto, ref Mensaje))
                {
                    LimpiarDatos();
                }
                MessageBox.Show(Mensaje);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
        }
        
        void Actualizar()
        {
            try
            {
                string Mensaje = "";
            if (BusImpuesto_Tipo.ActualizarDB(Info_Impuesto, ref Mensaje))
            {
                LimpiarDatos();
            }
            MessageBox.Show(Mensaje);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
        }
        
        private void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
        }

        private void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarDatos())
                {
                    GetInfo();
                    switch (_Accion)
                    {
                        case Cl_Enumeradores.eTipo_action.grabar:
                            Guardar();
                            break;
                        case Cl_Enumeradores.eTipo_action.actualizar:
                            Actualizar();
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
        }

        Boolean ValidarDatos()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt_nombre.Text))
                {
                    MessageBox.Show("Ingrese Descripcion");
                    return false;
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

        private void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                this.ucGe_Menu_event_btnGuardar_Click(sender,e);
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
        }

        private void ucGe_Menu_event_btnlimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                LimpiarDatos();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
        }

        void LimpiarDatos()
        {
            try
            {
                _Accion = Cl_Enumeradores.eTipo_action.grabar;
                Info_Impuesto = new tb_sis_impuesto_Info();
                txt_codigo.Text = "";
                txt_nombre.Text = "";
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
        }

        private void FrmGe_Impuesto_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            Event_FrmGe_Impuesto_Mant_FormClosing(sender, e);
        }


        private void cargar_combo()
        {
            try
            {
                tb_sis_Impuesto_Tipo_Bus BusImpuesto_Tipo = new tb_sis_Impuesto_Tipo_Bus();
                List<tb_sis_Impuesto_Tipo_Info> ListImpuesto_tipo = new List<tb_sis_Impuesto_Tipo_Info>();
                ListImpuesto_tipo =BusImpuesto_Tipo.Get_List_impuesto();
                cmb_tipo_impuesto.Properties.DataSource = ListImpuesto_tipo;

                
                cp_codigo_SRI_Bus BusCod_Sri= new cp_codigo_SRI_Bus();
                List<cp_codigo_SRI_Info> listCod_SRI= new List<cp_codigo_SRI_Info>();
                listCod_SRI = BusCod_Sri.Get_List_codigo_SRI_(param.IdEmpresa);
                cmb_codigo_sri.Properties.DataSource = listCod_SRI;



            }
            catch (Exception ex)
            {

            }
        }

    }
}
