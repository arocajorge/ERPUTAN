using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.Importacion;
using Core.Erp.Business.General;
using Core.Erp.Business.Importacion;
using Core.Erp.Info.General;


namespace Core.Erp.Winform.Importacion
{
    public partial class frmImp_ParametrosGastosMant : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();


        imp_gastosxImport_Bus Bus = new imp_gastosxImport_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        private Cl_Enumeradores.eTipo_action _Accion;
        public frmImp_ParametrosGastosMant()
        {
            try
            {

                InitializeComponent();
                Event_frmImp_ParametrosGastosMant_FormClosing += new Delegate_frmImp_ParametrosGastosMant_FormClosing(frmImp_ParametrosGastosMant_Event_frmImp_ParametrosGastosMant_FormClosing);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        void frmImp_ParametrosGastosMant_Event_frmImp_ParametrosGastosMant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                 Log_Error_bus.Log_Error(ex.ToString());
            }
        }
        public void setAccion(Cl_Enumeradores.eTipo_action iAccion)
        {
            try
            {
                _Accion = iAccion;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }
        imp_gastosxImport_Info _Info = new imp_gastosxImport_Info();
        void get()
        {
            try
            {

                _Info.CodGastoImp = txtCodigo.Text;
                _Info.IdGastoImp = Convert.ToInt16((txtIdGasto.Text == "") ? "0" : txtIdGasto.Text);
                _Info.ga_decripcion = txtDescripcion.Text;
                _Info.ga_estado = "A";
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
                MessageBox.Show(ex.ToString());
            }
        }
        public imp_gastosxImport_Info _SetInfo { get; set; }
        void Set() 
        {
            try
            {
                txtCodigo.Text = _SetInfo.CodGastoImp;
                txtDescripcion.Text = _SetInfo.ga_decripcion;
                txtIdGasto.Text = _SetInfo.IdGastoImp.ToString();

                if (_SetInfo.ga_estado=="I")
                { lblAnulado.Visible = true; }
                else
                { lblAnulado.Visible = false; }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
                MessageBox.Show(ex.ToString());
            }
        
        }

        private void frmImp_ParametrosGastosMant_Load(object sender, EventArgs e)
        {
            try
            {
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        btnGuardar.Text = "Guardar";
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        Set();
                        btnGuardar.Text = "Actualizar";

                        txtCodigo.Enabled = false;
                        txtCodigo.BackColor = System.Drawing.Color.White;
                        txtCodigo.ForeColor = System.Drawing.Color.Black;
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        Set();
                        btnGuardar.Enabled = false;
                        btnGuardarYsalir.Enabled = false;
                        btnGuardar.Text = "Guardar";
                    
                        txtCodigo.Enabled = false;
                        txtCodigo.BackColor = System.Drawing.Color.White;
                        txtCodigo.ForeColor = System.Drawing.Color.Black;

                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        Set();
                        btnGuardar.Enabled = false;
                        btnGuardarYsalir.Enabled = false;
                        btnGuardar.Text = "Guardar";
                        break;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
                MessageBox.Show(ex.ToString());
            }
        }
        void guardar()
        {
            try
            {
                if (!Bus.ValidarCodigo(txtCodigo.Text))
                {
                    if (Bus.GuardarDB(ref _Info))
                    {
                        MessageBox.Show("Registros # " + _Info.IdGastoImp + "Ingresado Con Exito ");

                    }

                }
                else
                {

                    MessageBox.Show("El Codigo Ingresado Ya existe Por favor \n Ingrese Uno diferente");
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
                MessageBox.Show(ex.ToString());
            }
        
        }
        void actualizar() 
        {

            try
            {
                if (Bus.ModificarDB(_Info))
                {
                    MessageBox.Show("Registro # " + _Info.IdGastoImp + " Actualizado Con Exito ");
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                get();

                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        guardar();
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        actualizar();
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        break;

                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
                MessageBox.Show(ex.ToString());
            }
          
        }

        public delegate void Delegate_frmImp_ParametrosGastosMant_FormClosing(object sender, FormClosingEventArgs e);
        public event Delegate_frmImp_ParametrosGastosMant_FormClosing Event_frmImp_ParametrosGastosMant_FormClosing;
        private void frmImp_ParametrosGastosMant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                 Event_frmImp_ParametrosGastosMant_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void btnGuardarYsalir_Click(object sender, EventArgs e)
        {
            try
            {
                btnGuardar_Click(sender, e);
                Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
