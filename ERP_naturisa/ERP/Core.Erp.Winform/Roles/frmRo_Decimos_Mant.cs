using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
// haac
using Core.Erp.Info.Roles;
using Core.Erp.Business.Roles;
using Core.Erp.Business.General;
using Core.Erp.Winform.General;
using Core.Erp.Info.General;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.Contabilidad;


namespace Core.Erp.Winform.Roles
{
    public partial class frmRo_Decimos_Mant : Form
    {

        #region Declaraciones
        string fileName = "";
        string path = "";
        string tipofile = "";
        string ruta = "";
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();     
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        ct_AnioFiscal_Bus Bus_Anio = new ct_AnioFiscal_Bus();
        ro_Catalogo_Bus Bus_CatalogoDecimos = new ro_Catalogo_Bus();
        ro_Config_Rubros_ParametrosGenerales_Bus Bus_ParamGenerales = new ro_Config_Rubros_ParametrosGenerales_Bus();
        List<ro_Empleado_Info> List = new List<ro_Empleado_Info>();
        List<ro_Config_Rubros_ParametrosGenerales_Info> Info_ParamGenerales = new List<ro_Config_Rubros_ParametrosGenerales_Info>();
        ro_Empleado_Bus OEmplBus = new ro_Empleado_Bus();
        ro_Config_Rubros_ParametrosGenerales_Info Info_XIII = new ro_Config_Rubros_ParametrosGenerales_Info();
        ro_Config_Rubros_ParametrosGenerales_Info Info_XIV = new ro_Config_Rubros_ParametrosGenerales_Info();
        BindingList<ro_Pago_decimos_x_Empleado_Info> ListaDecimos = new BindingList<ro_Pago_decimos_x_Empleado_Info>();
        ro_Pago_decimos_x_Empleado_Bus BusPagoDecimos = new ro_Pago_decimos_x_Empleado_Bus();

        ro_Nomina_Tipo_Bus oRo_Nomina_Tipo_Bus = new ro_Nomina_Tipo_Bus();
        ro_Nomina_Tipoliqui_Bus nominatipo_Bus = new ro_Nomina_Tipoliqui_Bus();
        ro_periodo_x_ro_Nomina_TipoLiqui_Bus periodo_nomina_bus = new ro_periodo_x_ro_Nomina_TipoLiqui_Bus();

        List<ro_Nomina_Tipo_Info> listadoNomina = new System.Collections.Generic.List<ro_Nomina_Tipo_Info>();
        List<ro_Nomina_Tipoliqui_Info> ListadoTipoLiquidacion = new System.Collections.Generic.List<ro_Nomina_Tipoliqui_Info>();
        List<ro_periodo_x_ro_Nomina_TipoLiqui_Info> listadoPeriodo = new System.Collections.Generic.List<ro_periodo_x_ro_Nomina_TipoLiqui_Info>();
  

           
    #endregion 
  
        public frmRo_Decimos_Mant()
        {
                try
                {
                   InitializeComponent();
                   ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Log_Error_bus.Log_Error(ex.Message);
                }
        }


        void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }


        private void frmRo_Decimos_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                listadoNomina = oRo_Nomina_Tipo_Bus.Get_List_Nomina_Tipo(param.IdEmpresa);
                cmbnomina.Properties.DataSource = listadoNomina;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }

        }

    
             
       

      



      

        private void CmbGenerar_Click(object sender, EventArgs e)
        {
            try
            {

                if (cmbnominaTipo.Text == "DECIMO TERCER SUELDO")
                {
                    GenerarArchivo("DEC3");
                }
                if (cmbnominaTipo.Text == "DECIMO CUARTO SUELDO")
                {

                    GenerarArchivo("DEC4");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
           

                
            
        }

        private void cmbPeriodo_Load(object sender, EventArgs e)
        {

        }

        private void gridControlDecimos_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            

        }

    
     

     

        private void cmbRuta_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                //Te Declaras un Objeto de Tipo OpenFileDialog
                OpenFileDialog dialogo = new OpenFileDialog();
                dialogo.Filter = "All files (*.csv*)|*.csv*";
                dialogo.InitialDirectory = @"C:\";
                //para mostrar el cuadro de seleccion de archivo hacemos asi:
                if (dialogo.ShowDialog() == DialogResult.OK)
                {
                    fileName = System.IO.Path.GetFileName(dialogo.FileName);
                    path = Path.GetDirectoryName(dialogo.FileName);
                    tipofile = System.IO.Path.GetExtension(dialogo.FileName);
                    ruta = path + "\\" + fileName;
                    cmbRuta.Text = ruta;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }



          
        }



        public void GenerarArchivo(string TipoArchivo)
        {
            try
            {
                // generar archivo plano de decimo tercer sueldo para el mte

                switch (TipoArchivo)
                {

                    case "DEC3":

                           foreach (var item in ListaDecimos)
                           {


                               string linea = "";





                            linea += item.cedula + ";";
                            linea += item.nombres + ";";
                            linea += item.apellidos + ";";
                            linea += item.genero + ";";
                            linea += item.codigoIESS + ";";
                            linea += item.Total_ganado + ";";
                            linea += item.diasLaborados + ";";
                            linea += "P" + ";";//Tipo de Deposito
                            linea += item.TipoContrato + ";";// aqui definir que se pone en este campo


                            using (System.IO.StreamWriter file = new System.IO.StreamWriter(cmbRuta.Text , true))
                             {
                         

                               file.WriteLine(linea);                                
                               file.Close();
                            }
                        }

                        MessageBox.Show("El Rachivo fue generado correctamenete en :" + cmbRuta.Text);
                        break;
                    case "DEC4":

                        foreach (var item in ListaDecimos)
                        {
                            string linea = "";
                            linea = "";
                            linea += item.cedula + ";";
                            linea += item.nombres + ";";
                            linea += item.apellidos + ";";
                            linea += item.genero + ";";
                            linea += item.codigoIESS + ";";
                            linea += item.diasLaborados + ";";
                            linea += "P" + ";";//Tipo de Deposito
                            linea += item.TipoContrato + ";";// aqui definir que se pone en este campo


                            using (System.IO.StreamWriter file = new System.IO.StreamWriter(cmbRuta.Text , true))
                             {
                         

                               file.WriteLine(linea);                                
                               file.Close();
                            }
                        }

                        MessageBox.Show("El Rachivo fue generado correctamenete en :" + cmbRuta.Text);


                        break;
                    default:
                        break;
                }

            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void cmbnomina_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                ListadoTipoLiquidacion = nominatipo_Bus.Get_List_Nomina_Tipoliqui_x_Nomina_Tipo(param.IdEmpresa, Convert.ToInt32(cmbnomina.EditValue));
                cmbnominaTipo.Properties.DataSource = ListadoTipoLiquidacion;

            }
            catch (System.Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void cmbnominaTipo_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                listadoPeriodo = periodo_nomina_bus.ConsultaPerNomTipLiq(param.IdEmpresa, Convert.ToInt32(cmbnomina.EditValue), Convert.ToInt32(cmbnominaTipo.EditValue));
                cmbPeriodos.Properties.DataSource = listadoPeriodo.Where(v => v.Cerrado == "N" && v.Contabilizado == "N").ToList();
            }
            catch (System.Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void cmbPeriodos_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                ro_periodo_x_ro_Nomina_TipoLiqui_Info periodo_info = new ro_periodo_x_ro_Nomina_TipoLiqui_Info();
                periodo_info = (ro_periodo_x_ro_Nomina_TipoLiqui_Info)cmbPeriodos.Properties.View.GetFocusedRow();
                ListaDecimos = new BindingList<ro_Pago_decimos_x_Empleado_Info>(BusPagoDecimos.GetLisDecimo(param.IdEmpresa, 200, periodo_info.pe_FechaIni, periodo_info.pe_FechaFin));
                gridControlDecimos.DataSource = ListaDecimos;
            }
            catch (System.Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
      

    }
}
