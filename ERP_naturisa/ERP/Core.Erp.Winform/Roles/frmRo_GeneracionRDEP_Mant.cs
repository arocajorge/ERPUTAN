/*CLASE: frmRo_GeneracionRDEP_Mant
 *CREADO POR: ALBERTO MENA
 *FECHA: 01-06-2015
 *DERECHOS RESERVADOS - INNOVATECORP
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Core.Erp.Info.Roles;
using Core.Erp.Info.General;

using Core.Erp.Business.Roles;
using Core.Erp.Business.Facturacion;
using Core.Erp.Info.Facturacion;

using Core.Erp.Business.General;
using Core.Erp.Winform.General;
using Core.Erp.Winform.Controles;
using Core.Erp.Recursos.Properties;
using Core.Erp.Info.class_sri.RDEP;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
namespace Core.Erp.Winform.Roles
{
    public partial class frmRo_GeneracionRDEP_Mant : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        ro_Empleado_Bus oRo_Empleado_Bus = new ro_Empleado_Bus();
        List<ro_Empleado_Info> oListRo_Empleado_Info = new List<ro_Empleado_Info>();
        Cl_Enumeradores.eTipo_action Accion;
        rdep oRdep = new rdep();
        tb_Empresa_Bus oTb_Empresa_Bus = new Business.General.tb_Empresa_Bus();
        tb_Empresa_Info oTb_Empresa_Info = new tb_Empresa_Info();
        string mensaje = "";

        public frmRo_GeneracionRDEP_Mant()
        {
            
            try
            {
                InitializeComponent();

                ucGe_Menu.event_btn_Generar_XML_Click += ucGe_Menu_Superior_Mant_event_btn_Generar_XML_Click;
            }
            catch (Exception ex)
            {
                
               MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }


      
        
        void ucGe_Menu_Superior_Mant_event_btn_Generar_XML_Click(object sender, EventArgs e)
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


        private void pu_CargarInicial()
        {
            try
            {

                int anioActual = 0;
                anioActual = param.Fecha_Transac.Year;

                for (int i = 5; i > 0; i--)
                {
                    cmbPeriodo.Items.Add(anioActual);
                    anioActual -= 1;
                }

                if (cmbPeriodo.Items.Count > 0)
                {
                    cmbPeriodo.SelectedIndex = 0;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void frmRo_GeneracionRDEP_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                pu_CargarInicial();
            }
            catch (Exception ex)
            {
                
               MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
            
        }

        private void pu_CargarEmpleados() {
            try {


                oListRo_Empleado_Info = oRo_Empleado_Bus.GetListConsultaPorPeriodoRDEP(param.IdEmpresa, Convert.ToInt32(cmbPeriodo.Text));
                gridDetalle.DataSource = oListRo_Empleado_Info;
                gridDetalle.RefreshDataSource();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }        
        }



        private void cmdCargarEmpleado_Click(object sender, EventArgs e)
        {
            try
            {
                pu_CargarEmpleados();

            }
            catch (Exception ex)
            {
                
               MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void cmdCalcular_Click(object sender, EventArgs e)
        {

        }

        private void ucGe_Menu_event_btn_Generar_XML_Click(object sender, EventArgs e)
        {
            try
            {
                
                oTb_Empresa_Info = oTb_Empresa_Bus.Get_Info_Empresa(param.IdEmpresa);
              

                if (oListRo_Empleado_Info != null)
                {
                    oRdep = oRo_Empleado_Bus.setInfoXML(oListRo_Empleado_Info, oTb_Empresa_Info.em_ruc,Convert.ToInt32(cmbPeriodo.Text));
                    if (oRdep != null)
                    {

                        XmlSerializerNamespaces NamespaceObject = new XmlSerializerNamespaces();
                        NamespaceObject.Add("", "");
                        XmlSerializer mySerializer = new XmlSerializer(typeof(rdep));
                        StreamWriter myWriter = new StreamWriter(txtRutaERDP.Text + oTb_Empresa_Info.em_ruc + ".xml");
                        mySerializer.Serialize(myWriter, oRdep, NamespaceObject);
                        myWriter.Close();
                    }
                    


                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void TxtRutaLocal_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                FolderBrowserDialog folder = new FolderBrowserDialog();
                folder.Reset();
                folder.Description = " Seleccionar una carpeta ";
               // folder.SelectedPath = txtRuta.Text;
                folder.ShowNewFolderButton = false;
                DialogResult ret = new DialogResult();
                ret = folder.ShowDialog();//' abre el diálogo   
                txtRutaERDP.Text = folder.SelectedPath + @"\";
                folder.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
    }
}
