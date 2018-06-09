using Core.Erp.Business.General;
using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.Roles;
using Core.Erp.Business.Roles;

//Tabla Impuestos a la renta
//Derek Mejía Soria
//ultima modificacion : 08/01/2014

namespace Core.Erp.Winform.Roles
{
    public partial class frmRo_Tabla_Impu_Renta_Mant : Form
    {
        #region Declaración de Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        private Cl_Enumeradores.eTipo_action _Accion;
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        List<tb_Calendario_Info> calendarioinfo = new List<tb_Calendario_Info>();
        tb_Calendario_Bus calendariobus = new tb_Calendario_Bus();
        ro_tabla_Impu_Renta_Info IRinfo = new ro_tabla_Impu_Renta_Info();
        ro_Tabla_Impu_Renta_Bus IRBus = new ro_Tabla_Impu_Renta_Bus();
        public ro_tabla_Impu_Renta_Info SETINFO_ { get; set; }

        //Delegados
        public delegate void delegate_frmRo_Tabla_Impu_Renta_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmRo_Tabla_Impu_Renta_Mant_FormClosing event_frmRo_Tabla_Impu_Renta_Mant_FormClosing;
        #endregion
        
        public void set_Accion(Cl_Enumeradores.eTipo_action iAccion)
        {
            try
            {
             _Accion = iAccion; 
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }

        }

        public frmRo_Tabla_Impu_Renta_Mant()
        {
            try
            {
             InitializeComponent();
             ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
             ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
             ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
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
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                Grabar();
                Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }

        }

        void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Grabar();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        public Boolean GETINFO() 
        {
            try
            {
                IRinfo = new ro_tabla_Impu_Renta_Info();
                IRinfo.	AnioFiscal	= Convert.ToInt32(cmbAnioFiscal.EditValue);
                IRinfo.	Secuencia	= (SETINFO_== null)?IRBus.GETSECUENCIA():SETINFO_.Secuencia;
                IRinfo.	FraccionBasica	=Convert.ToDouble(txtFraccion.EditValue);
                IRinfo.	ExcesoHasta	= Convert.ToDouble(txtExceso.EditValue);
                IRinfo.	ImpFraccionBasica	= Convert.ToDouble(txtImpuesto.EditValue);
                IRinfo.Por_ImpFraccion_Exce = Convert.ToDouble(txtPorcentaje.EditValue);
                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
                return false;
            }
        }

        public Boolean SETINFO() 
        {
            try
            {
                cmbAnioFiscal.EditValue	= SETINFO_.AnioFiscal;
                txtFraccion.EditValue	= SETINFO_.FraccionBasica;
                txtExceso.EditValue	=SETINFO_.ExcesoHasta;
                txtImpuesto.EditValue	=SETINFO_.ImpFraccionBasica;
                txtPorcentaje.EditValue = SETINFO_.Por_ImpFraccion_Exce;
                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
                return false;
            }
        }

        public void load()
        {
            try
            {
                //Cargar año fiscal
                calendarioinfo = new List<tb_Calendario_Info>();
                calendarioinfo.Add(new tb_Calendario_Info());
                calendarioinfo.AddRange(calendariobus.ConsultaGeneralGP());
                cmbAnioFiscal.Properties.DataSource = calendarioinfo;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }
       
        private void frmRo_Tabla_Impu_Renta_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                event_frmRo_Tabla_Impu_Renta_Mant_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void frmRo_Tabla_Impu_Renta_Mant_Load(object sender, EventArgs e)
        {
            load();
            try
            {
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        cmbAnioFiscal.EditValue = DateTime.Now.Year;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = true;
                        ucGe_Menu.Visible_btnGuardar = true;                     
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        SETINFO();                                                
                        ucGe_Menu.Visible_bntGuardar_y_Salir = true;
                        ucGe_Menu.Visible_btnGuardar = true;                         
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        SETINFO();                        
                       ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                       ucGe_Menu.Visible_btnGuardar = false;                        
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }       

        public Boolean Grabar() 
        {
            try
            {
                if (cmbAnioFiscal.EditValue == null || cmbAnioFiscal.EditValue == "")
                {
                    MessageBox.Show("Seleccione Año","Operación Fallida");
                    return false;
                }

                if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    if (GETINFO() == false)
                    {
                        MessageBox.Show("Problemas en la Actualización de los Datos.", "Operación Fallida");
                        return false;
                    }
                    //GASTOS PERSONALES
                    if (IRBus.GrabarTablaImpu(IRinfo)== false)
                    {
                        MessageBox.Show("Problemas al Grabar los Datos\nGASTOS PERSONALES.", "Operación Fallida");
                        return false;
                    }

                    MessageBox.Show("Se ha procedido ha Guardar con exito la información", "Operación Exitosa");
                    Limpiar();
                }

                if (_Accion == Cl_Enumeradores.eTipo_action.actualizar)
                {
                    if (GETINFO() == false)
                    {
                        MessageBox.Show("Problemas en la Actualización de los Datos.", "Operación Fallida");
                        return false;
                    }
                    //GASTOS PERSONALES
                    if (IRBus.GrabarTablaImpu(IRinfo) == false)
                    {
                        MessageBox.Show("Problemas al Grabar los Datos\nGASTOS PERSONALES.", "Operación Fallida");
                        return false;
                    }
                    MessageBox.Show("Se ha procedido ha Actualizar con exito la información", "Operación Exitosa");
                    _Accion = Cl_Enumeradores.eTipo_action.grabar;
                    Limpiar();
                }
                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
                return false;           
            }
        }

        private void frmRo_Tabla_Impu_Renta_Mant_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)(Keys.Escape))
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
            
        }

        //private void btn_guardarysalir_Click(object sender, EventArgs e)
        public void Limpiar()
        {
            txtExceso.Text = "";
            txtFraccion.Text = "";
            txtImpuesto.Text="";
            txtPorcentaje.Text="";
           
        }


    }
}
