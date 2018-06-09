using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.Roles;
using Core.Erp.Info.Roles;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Info.Roles.AGP;

using System.Xml;
using System.Xml.Schema;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;
using System.Xml.Serialization;
using System.IO;
using Core.Erp.Business.Roles;
using refere = Microsoft.VisualBasic.Devices;

//Consulta de Gastos Personales
//Derek 14/12/2013
//ultima modificacion : 08/01/2014
namespace Core.Erp.Winform.Roles
{
    public partial class frmRo_Empleado_Gastos_Personales_Cons : Form
    {

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        SaveFileDialog saveFileDialog1;
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        BindingList<ro_empleado_gastos_perso_Info> DSEmpleadoGP = new BindingList<ro_empleado_gastos_perso_Info>();
        ro_empleado_gastos_perso_Bus EmpleadoGPBus = new ro_empleado_gastos_perso_Bus();
        ro_empleado_gastos_perso_Info infoGastosPersonales = new ro_empleado_gastos_perso_Info();
        List<ro_empleado_gastos_perso_Info> xmlinfoGastosPersonales = new List<ro_empleado_gastos_perso_Info>();
        refere.ServerComputer Cp = new refere.ServerComputer();
        //Derek 28/12/2013
        ro_Config_Rubros_ParametrosGenerales_Bus parambus = new ro_Config_Rubros_ParametrosGenerales_Bus();
        List<ro_Config_Rubros_ParametrosGenerales_Info> paraminfo = new List<ro_Config_Rubros_ParametrosGenerales_Info>();

        ro_Empleado_Bus empBus = new ro_Empleado_Bus();
        byte[] XSD;
        string direcDoc = "";

        frmRo_Empleado_Gastos_Personales_Mant GPMant = new frmRo_Empleado_Gastos_Personales_Mant();
        int i;//bandera para controlar check
        int j;//bandera para validar si se esta selccionando un check

        string mensaje = "";

        private void llama_frm(Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {
                GPMant = new frmRo_Empleado_Gastos_Personales_Mant();
                GPMant.event_frmRo_Empleado_Gastos_Personales_Mant_FormClosing += new frmRo_Empleado_Gastos_Personales_Mant.delegate_frmRo_Empleado_Gastos_Personales_Mant_FormClosing(frm_event_frmRo_Empleado_Gastos_Personales_Mant_FormClosing);
                GPMant.MdiParent = this.MdiParent;

                if (Accion != Cl_Enumeradores.eTipo_action.grabar)
                {
                    //GPMant.SETINFO_ = infoGastosPersonales;
                    GPMant.setInfo(infoGastosPersonales);
                }
                GPMant.set_Accion(Accion);
                GPMant.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }

        private void frm_event_frmRo_Empleado_Gastos_Personales_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                //throw new NotImplementedException();
                load();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }

        }

        public frmRo_Empleado_Gastos_Personales_Cons()
        {
            try
            {
                 InitializeComponent();
                 ucGe_Menu_Mantenimiento_x_usuario.event_btnAnular_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick;
                 ucGe_Menu_Mantenimiento_x_usuario.event_btnconsultar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick;
                 //ucGe_Menu_Mantenimiento_x_usuario.event_btnGenerarXml_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnGenerarXml_ItemClick;
                 ucGe_Menu_Mantenimiento_x_usuario.event_btnGenerarXml_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnGenerarXml_ItemClick;
                 ucGe_Menu_Mantenimiento_x_usuario.event_btnModificar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick;
                 ucGe_Menu_Mantenimiento_x_usuario.event_btnNuevo_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick;
                 ucGe_Menu_Mantenimiento_x_usuario.event_btnSalir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick;
                 ucGe_Menu_Mantenimiento_x_usuario.event_btnImprimir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnImprimir_ItemClick;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }

        }

        
        
        void ucGe_Menu_Mantenimiento_x_usuario_event_btnGenerarXml_ItemClick(object sender, EventArgs e)
        {
            
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                gridViewGastosPersonales.ShowPrintPreview();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Dispose();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                llama_frm(Cl_Enumeradores.eTipo_action.grabar);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                llama_frm(Cl_Enumeradores.eTipo_action.actualizar);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnGenerarXml_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                int existeNumero = 0;
              

                int focus = gridViewGastosPersonales.FocusedRowHandle;
                gridViewGastosPersonales.FocusedRowHandle = focus + 1;
                xmlinfoGastosPersonales = new List<ro_empleado_gastos_perso_Info>(DSEmpleadoGP);

                foreach (var item in xmlinfoGastosPersonales)
                {
                    if (item.check == true)
                    {
                        existeNumero++;
                        break;
                    }
                }

                if (existeNumero == 0)
                {
                    MessageBox.Show("Seleccione por lo menos un empleado si \ndesea continuar.", "Error en la Operación");
                    return;
                }

                if (GuardarXml() == true)
                {
                    MessageBox.Show("Los archivos se guardaron", "Operación Correcta");
                    load();
                }
                else
                {
                    MessageBox.Show("Los archivos no se guardaron", "Operacion Cancelada");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                llama_frm(Cl_Enumeradores.eTipo_action.consultar);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (infoGastosPersonales != null)
                {
                    infoGastosPersonales.Estado = "I";
                    if (EmpleadoGPBus.GuardarBD(infoGastosPersonales, ref mensaje))
                    {
                        MessageBox.Show("Se ha anulado con exito el registro", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se ha anulado con exito el registro", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }

        private void frmRo_Empleado_Gastos_Personales_Cons_Load(object sender, EventArgs e)
        {
            try
            {
                 load();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }

        }

        public void load()
        {
            try
            {
                DSEmpleadoGP = new BindingList<ro_empleado_gastos_perso_Info>(EmpleadoGPBus.Get_List_empleado_gastos_perso(param.IdEmpresa));
                gridControlGastosPersonales.DataSource = DSEmpleadoGP;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }           
        }


        private void gridViewGastosPersonales_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                infoGastosPersonales = new ro_empleado_gastos_perso_Info();
                infoGastosPersonales = gridViewGastosPersonales.GetFocusedRow() as ro_empleado_gastos_perso_Info;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }

        private void gridViewGastosPersonales_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                //if (e.Column == colcheck && Convert.ToBoolean(e.Value) == false)
                //{
                //    //i = 1;
                //    //checkTodos.Checked = false;

                //}

                //if (e.Column == colcheck && Convert.ToBoolean(e.Value) == true)
                //{
                //    //xmlinfoGastosPersonales = new ro_empleado_gastos_perso_Info();
                //    xmlinfoGastosPersonales = gridViewGastosPersonales.GetFocusedRow() as ro_empleado_gastos_perso_Info;
                //} 
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }        
        }

        public Boolean GuardarXml()
        {
            try
            {
                int controlaRuta = 1;
                int secuencia = 0;
                string rut = "";
                int error = 0;//lo uso para ver si encontro algun error al momento de comparacion del xsd y el xml
                Boolean retorna = true;

                gastosPersonales DataGastos = new gastosPersonales();
                List<ro_empleado_gastos_perso_Info> EGPError = new List<ro_empleado_gastos_perso_Info>();

                //pasa el archivo de la base de datos hacia una variable con el mismo tipo
                paraminfo = new List<ro_Config_Rubros_ParametrosGenerales_Info>(parambus.ObtenerParamGenerales());
                foreach (var item2 in paraminfo)
                {
                    if (item2.IdTipoParametro == "FILEXSD107")
                    {
                        XSD = item2.File;
                    }
                }

            
                foreach (var item in xmlinfoGastosPersonales)
                {
                    if (item.check == true)
                    {
                        //DataGastos = CargaDatos();
                        string ruta = "";
                        DataGastos = empBus.Get_GastosPersonales_x_Empleado(param.IdEmpresa, item.IdEmpleado, item.Anio_fiscal);
                        string Nombre = "AGP" + item.Anio_fiscal + item.Num_Identificacion + ".xml";
                        saveFileDialog1 = new SaveFileDialog();
                        //saveFileDialog1.FileName = Nombre;
                        saveFileDialog1.FileName = "Archivos";
                        saveFileDialog1.Filter = "Todos los archivos (*.xml)|*.xml";
                        saveFileDialog1.InitialDirectory = @direcDoc;

                        //Obtener Ruta de Carpetas
                        if (controlaRuta == 1)
                        {
                            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                            {
                                retorna = false;
                                break;
                            }

                            System.IO.DirectoryInfo s = new DirectoryInfo(saveFileDialog1.FileName);
                            rut = s.Parent.FullName;
                            controlaRuta++;
                        }

                        ruta = rut + "\\" + Nombre;

                        if (File.Exists(ruta))
                            File.Delete(ruta);

                        if (SerializeToXML(DataGastos, ruta))
                        {
                            ////progressBar1.Value = 100;                            

                            if (XSD != null)
                            {
                                string msg = "";
                                if (XSD == null)
                                {
                                    MessageBox.Show("No puede realizar la validacón del xml con el XSD, debido a que el archivo XSD no se ha ingresado.. \nIngréselos desde la pantalla de parámetros Cuentas por Pagar,o comuníquese con sistemas", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else {
                                    if (!validaXmlConXsd(ruta, XSD, ref msg)) {
                                        secuencia++;
                                        ro_empleado_gastos_perso_Info infoError = new ro_empleado_gastos_perso_Info();
                                        infoError.Secuencia = secuencia;
                                        infoError.RutaArchivo = ruta;
                                        infoError.Error = msg;
                                        EGPError.Add(infoError);
                                        error++;
                                    }
                                        //MessageBox.Show("Archivo AGP XML generado en la ruta:" + ruta + ", pero tiene los Siguientes errores:\n " + msg, "Errores en Validación con XSD", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    //else
                                    //    MessageBox.Show("Archivo AGP XML generado correctamente en la ruta:" + ruta, "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Archivo AGP XML generado en la ruta:" + ruta + "\n No se realizo la validación XSD no ingresado", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            //progressBar1.Value = 0;
                            MessageBox.Show("Ocurrio un inconveniente al guardar el archivo AGP XML", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        //StreamReader sr = new StreamReader(saveFileDialog1.FileName, System.Text.Encoding.Default);
                        //this.richTextBox1.Text = sr.ReadToEnd();
                    }
                }
                if (error>=1)
                {
                    MessageBox.Show("Se han detectado errores", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    frmRo_Empleado_Gastos_Personales_Cons_Xml errorForm = new frmRo_Empleado_Gastos_Personales_Cons_Xml();
                    errorForm.SETINFO_ = EGPError;
                    errorForm.Show();
                }
                //else
                //{
                //    MessageBox.Show("Archivos Almacenados Correctamente", "Operación Correcta");
                //}
                return retorna;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message); return false; 
            }
        }

        static public Boolean SerializeToXML(gastosPersonales data, string ruta)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(gastosPersonales));
                TextWriter textWriter = new StreamWriter(@ruta);
                serializer.Serialize(textWriter, data);
                textWriter.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
              
                return false;
            }
        }

        public bool validaXmlConXsd(string rutaXML, byte[] xsd, ref string mgs)
        {
            try
            {
                Boolean val;

                //string archiTem = direcDoc + @"\ValidadorXml.xsd";
                string archiTem = (Environment.GetFolderPath(
            Environment.SpecialFolder.MyDocuments)) + @"\ValidadorXml.xsd";

                if (Cp.FileSystem.FileExists(archiTem))
                {
                    Cp.FileSystem.DeleteFile(archiTem);
                }
                FileStream fs = new FileStream(archiTem, FileMode.Create);
                BinaryWriter bw = new BinaryWriter(fs);

                bw.Write(xsd);
                bw.Close();


                return val = Valido(archiTem, rutaXML, ref  mgs);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message); return false;
            }
        }

        public Boolean Valido(String patchxsd, string pathXML, ref string MensajeOut)
        {
            Boolean isValid = true;

            try
            {
                XmlReaderSettings settings = new XmlReaderSettings();
                settings.Schemas.Add(null, patchxsd);

                settings.ValidationType = ValidationType.Schema;
                //--------------
                XmlDocument document = new XmlDocument();
                document.Load(pathXML);
                XmlReader rdr = XmlReader.Create(new StringReader
                    (document.InnerXml), settings);
                while (rdr.Read()) { }

                MensajeOut = "Archivo Valido";

                return isValid;
            }
            catch (XmlSchemaException ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
               
                return isValid;
            }
        }

        private void gridViewGastosPersonales_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridViewGastosPersonales.GetRow(e.RowHandle) as ro_empleado_gastos_perso_Info;
                if (data == null)
                    return;
                if (data.Estado == "I")
                    e.Appearance.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }

        //Check todos
       private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            try
            {
                List<ro_empleado_gastos_perso_Info> lst = new List<ro_empleado_gastos_perso_Info>();
                if (checkBox1.Checked == true)
                {
                    foreach (var item in DSEmpleadoGP)
                    {
                        item.check = true;
                        lst.Add(item);
                    }
                    DSEmpleadoGP = new BindingList<ro_empleado_gastos_perso_Info>();
                    DSEmpleadoGP = new BindingList<ro_empleado_gastos_perso_Info>(lst);
                    gridControlGastosPersonales.DataSource = DSEmpleadoGP;
                }
                else
                {
                    foreach (var item in DSEmpleadoGP)
                    {
                        item.check = false;
                        lst.Add(item);
                    }
                    DSEmpleadoGP = new BindingList<ro_empleado_gastos_perso_Info>();
                    DSEmpleadoGP = new BindingList<ro_empleado_gastos_perso_Info>(lst);
                    gridControlGastosPersonales.DataSource = DSEmpleadoGP;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }
    }
}
