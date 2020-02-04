using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info;
using Core.Erp.Business;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Business.General;
using System.IO;
using System.Reflection;
using System.Data.OleDb;
using Core.Erp.Info.General;

namespace Core.Erp.Winform.Contabilidad
{
    public partial class frmCon_PlanCuenta_ImportacionWizard : Form
    {
        string MensajeError = "";
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        #region DATA
        ct_Plancta_Bus _PlanCtaBus = new ct_Plancta_Bus();
        ct_Plancta_Info _PlanCtaInfo = new ct_Plancta_Info();
        List<ct_Plancta_Info> _ListPlanCtaInfo = new List<ct_Plancta_Info>();
        #endregion
        #region Delegados

        public delegate void delegate_frmCon_PlanCuenta_ImportacionWizard_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmCon_PlanCuenta_ImportacionWizard_FormClosing event_frmCon_PlanCuenta_ImportacionWizard_FormClosing;

        #endregion
        public frmCon_PlanCuenta_ImportacionWizard()
        {
            InitializeComponent();            
        }
        void frmCon_PlanCuenta_ImportacionWizard_event_frmCon_PlanCuenta_ImportacionWizard_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
        private void btnSeleccion_Click(object sender, EventArgs e)
        {
            try
            {
                lblMsg1.Visible = true;
                PU_OBTENER_RUTA();
                if (!CargarHojasCombo())
                    MessageBox.Show("Archivo de excel no válido", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                lblMsg1.Visible = false;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }            
        }

        #region Variables Para Carga de Excel
        string fileName = "";
        string path = "";
        string tipofile = "";
        string ruta = "";
        string plantilla = "Plantilla";
        DataTable ds = new DataTable();
        DataTable dt = new DataTable();
        #endregion

        void PU_OBTENER_RUTA()
        {
            try
            {
                //Te Declaras un Objeto de Tipo OpenFileDialog
                OpenFileDialog dialogo = new OpenFileDialog();
                dialogo.Filter = "All files (*.*)|*.*";
                dialogo.InitialDirectory = @"C:\";
                //para mostrar el cuadro de seleccion de archivo hacemos asi:
                if (dialogo.ShowDialog() == DialogResult.OK)
                {
                    fileName = System.IO.Path.GetFileName(dialogo.FileName);
                    path = Path.GetDirectoryName(dialogo.FileName);
                    tipofile = System.IO.Path.GetExtension(dialogo.FileName);
                    ruta = path + "\\" + fileName;
                    txtSeleccion.Text = ruta;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }

        }

        public bool PU_CARGAR_EXCEL_GRILLA()
        {
            try
            {
                ruta = txtSeleccion.Text;
                plantilla = cmbHoja.Text;
                this.treeListPlanCta.DataSource = null;
                _ListPlanCtaInfo.Clear();
                if (ruta != "")
                {
                    if (PU_CARGA_EXCEL())
                    {
                        this.treeListPlanCta.DataSource = _ListPlanCtaInfo;
                        treeListPlanCta.ExpandAll();
                        return true;
                    }
                    else
                    { MessageBox.Show("Archivo no cumple formato de plantilla. "+MensajeError, "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop); return false; }
                }
                else
                { MessageBox.Show("Por favor seleccione archivo de plantilla válida.", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop); return false; }

            }
            catch (Exception ex)
            {                
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                return false;
            }
        }

        public bool PU_CARGA_EXCEL()
        {
            try
            {
                if (CargarArchivoExcelADataTable())
                {
                    MensajeError = "";
                    _ListPlanCtaInfo = _PlanCtaBus.ProcesarDataTableCt_Plancta_Info(ds, param.IdEmpresa, ref MensajeError);
                    if (MensajeError=="")
                    return true;
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    MensajeError = "Archivo Incorrecto o Inexistente.";
                    return false;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                return false;
            }
        }

        bool CargarArchivoExcelADataTable()
        {
            try
            {
                ds.Clear();
                String strconn = "";
                bool flag=false;

                OleDbConnectionStringBuilder cb = new OleDbConnectionStringBuilder();
                cb.DataSource = ruta;

                if (Path.GetExtension(cb.DataSource).ToUpper() == ".XLS")
                {
                    cb.Provider = "Microsoft.Jet.OLEDB.4.0";
                    cb.Add("Extended Properties", "Excel 8.0;HDR=YES;IMEX=0;");
                }
                else if (Path.GetExtension(cb.DataSource).ToUpper() == ".XLSX")
                {
                    cb.Provider = "Microsoft.ACE.OLEDB.12.0";
                    cb.Add("Extended Properties", "Excel 12.0 Xml;HDR=YES;IMEX=0;");
                }


               // strconn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + ruta + ";Extended Properties=Excel 12.0;";
              //  OleDbConnection mconn = new OleDbConnection(strconn);
                OleDbConnection mconn = new OleDbConnection(cb.ConnectionString);
                //El nombre de la hoja del archivo de marcaciones tiene que llamarse Marcaciones
                OleDbDataAdapter ad = new OleDbDataAdapter("Select * from [" + plantilla + "$]", mconn);
                //abre una conexion de tipo oledb
                mconn.Open();
                //Lo agrega a mi datatable
                ad.Fill(ds);
                if (ds != null)
                    flag = true;
                else
                    flag = false;
                    //cierra una conexion de tipo oledb
                mconn.Close();
                return flag;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                ds = new DataTable();
                return false;
            }
        }

        bool CargarHojasCombo()
        {
            try
            {
                OleDbConnectionStringBuilder cb = new OleDbConnectionStringBuilder();
                cb.DataSource = ruta;

                if (Path.GetExtension(cb.DataSource).ToUpper() == ".XLS")
                {
                    cb.Provider = "Microsoft.Jet.OLEDB.4.0";
                    cb.Add("Extended Properties", "Excel 8.0;HDR=YES;IMEX=0;");
                }
                else if (Path.GetExtension(cb.DataSource).ToUpper() == ".XLSX")
                {
                    cb.Provider = "Microsoft.ACE.OLEDB.12.0";
                    cb.Add("Extended Properties", "Excel 12.0 Xml;HDR=YES;IMEX=0;");
                }
                          
                dt.Clear();
                bool flag = false;
             //   String strconn2 = "";
              //  strconn2 = "Provider=Microsoft.ACE.OLEDB.8.0;Data Source=" + ruta + ";Extended Properties=Excel 8.0;";
               // OleDbConnection mconn2 = new OleDbConnection(strconn2);
                OleDbConnection mconn2 = new OleDbConnection(cb.ConnectionString);
                //abre una conexion de tipo oledb
                mconn2.Open();
                dt = mconn2.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                //Lo agrega a mi datatable
                if (dt != null)
                {
                    String[] excelSheets = new String[dt.Rows.Count];
                    int i = 0;

                    // Add the sheet name to the string array.
                    cmbHoja.Items.Clear();
                    foreach (DataRow row in dt.Rows)
                    {
                        excelSheets[i] = row["TABLE_NAME"].ToString();
                        cmbHoja.Items.Add(excelSheets[i].Substring(0,excelSheets[i].Length-1)); //$
                        i++;
                    }
                    cmbHoja.SelectedIndex=0;
                    //cierra una conexion de tipo oledb                
                    flag= true;
                }
                else
                {
                    flag= false;
                }
                mconn2.Close();
                return flag;
            }
            catch (Exception ex)
            {                
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                dt = new DataTable();
                return false;
            }
        }

        private void wizardControl1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("dio click");
        }

        private void wizardPage1_Click(object sender, EventArgs e)
        {
        }

        private void wizardControl1_CancelClick(object sender, CancelEventArgs e)
        {
            try
            {
                    this.Dispose();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        private void wizardControl1_NextClick(object sender, DevExpress.XtraWizard.WizardCommandButtonClickEventArgs e)
        {
            try
            {
                e.Page.AllowNext = true;    
                
                if (e.Page.Name == wizardPageSeleccionExcel.Name)
                {
                    PU_CARGAR_EXCEL_GRILLA();
                }

                if (e.Page.Name == wizardPageTipoDeIngresoDatos.Name)
                {
                    wizardPageEstadoGrabacion.AllowNext = false;
                }


            }
            catch (Exception ex)
            {
                splashScreenManager.CloseWaitForm();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }          
        }


        private Boolean Proceso_Grabacion()
        {
            Boolean respuesta = false;
            int c = 1;
            int Total_Reg = 0;
            string IdCta = "";
            string IdCta_Padre = "";
            string Nom_cta = "";

            BindingList<cl_estado_grabacion> ListEstadoGrabacion = new BindingList<cl_estado_grabacion>();

            try
            {
                
                string MensajeLog = "Ingreso Exitoso.";
                string MensajeWarning = "";
                string listaLog = "";
                this.rtbLog.Text = "";
                bool B_Proceso_anulacion = true;
                lblMensaje.Text = "";
                lblMensaje.Visible = false;
                
                gridControlProceGrabado.DataSource = ListEstadoGrabacion;


                if (treeListPlanCta.DataSource != null)
                {
                    if (rgImportar.SelectedIndex == 0)
                        MensajeWarning = "Atención esta a punto de eliminar toda la información actual, y reemplazarla con la nueva. Está seguro de continuar?";
                    else
                        MensajeWarning = "Atención esta a punto de proceder. Está seguro de continuar?";
                    lblmsg3.Visible = true;


                    if (MessageBox.Show(MensajeWarning, "SISTEMAS", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {

                        if (rgImportar.SelectedIndex == 0)
                        {

                            splashScreenManager.ShowWaitForm();
                            

                            B_Proceso_anulacion=_PlanCtaBus.EliminarDB(param.IdEmpresa, ref MensajeError);

                            if (B_Proceso_anulacion)
                            {
                                ListEstadoGrabacion.Add(new cl_estado_grabacion(0,"", "Eliminado Plan de cuenta","", "OK", "Eliminado Ok"));
                                gridControlProceGrabado.Refresh();
                            }
                            

                            splashScreenManager.CloseWaitForm();
                        }


                        if (B_Proceso_anulacion == true)
                        {
                            splashScreenManager.ShowWaitForm();

                            
                            Total_Reg=_ListPlanCtaInfo.Count();
                            progressBar.Maximum = Total_Reg;
                            progressBar.Minimum = 1;
                            progressBar.Step = 1;
                            lblNumRegistros.Text = "0 registros de " + Total_Reg;
                            c = 1;

                            ct_Plancta_nivel_Bus BusPlan_nivel = new ct_Plancta_nivel_Bus();
                            List<ct_Plancta_nivel_Info> list_niveles = new List<ct_Plancta_nivel_Info>();
                            List<ct_Plancta_nivel_Info> list_niveles_Aux = new List<ct_Plancta_nivel_Info>();



                            var QNiveles = from Cb in _ListPlanCtaInfo
                                               orderby Cb.IdNivelCta descending
                                               group Cb by new { Cb.IdEmpresa, Cb.IdNivelCta,Cb.IdCtaCble.Length }
                                                   into grouping 
                                                   select new { grouping.Key};

                            if (QNiveles.Count() > 0)
                            {
                                    foreach (var item in QNiveles)
                                    {
                                        ct_Plancta_nivel_Info InfoPlan_nivel = new ct_Plancta_nivel_Info();
                                        InfoPlan_nivel.IdEmpresa = item.Key.IdEmpresa;
                                        InfoPlan_nivel.IdNivelCta = item.Key.IdNivelCta;
                                        InfoPlan_nivel.nv_Descripcion = "Nivel " + item.Key.IdNivelCta; ;
                                        InfoPlan_nivel.nv_NumDigitos = item.Key.Length;
                                        InfoPlan_nivel.Estado = "A";
                                        list_niveles_Aux.Add(InfoPlan_nivel);
                                    }
                            }

                            // recorre desde el nivel mas grande hasta el nivel mas pequeño
                            foreach (var item in list_niveles_Aux)
                            {
                                int num_Digito_x_Nivel_Actual = 0;
                                int num_Digito_x_Nivel_Anterior = 0;

                                ct_Plancta_nivel_Info InfoPlan_nivel_Anterior = list_niveles_Aux.FirstOrDefault(v => v.IdNivelCta == item.IdNivelCta-1);

                                num_Digito_x_Nivel_Anterior = (InfoPlan_nivel_Anterior == null) ? 0 : InfoPlan_nivel_Anterior.nv_NumDigitos;
                                num_Digito_x_Nivel_Actual = item.nv_NumDigitos - num_Digito_x_Nivel_Anterior;

                                ct_Plancta_nivel_Info InfoPlan_nivel = new ct_Plancta_nivel_Info();
                                InfoPlan_nivel.IdEmpresa = item.IdEmpresa;
                                InfoPlan_nivel.IdNivelCta = item.IdNivelCta;
                                InfoPlan_nivel.nv_Descripcion = item.nv_Descripcion;
                                InfoPlan_nivel.nv_NumDigitos = num_Digito_x_Nivel_Actual;
                                InfoPlan_nivel.Estado = "A";
                                list_niveles.Add(InfoPlan_nivel);
                            }

                             //BusPlan_nivel.EliminarDB(param.IdEmpresa);
                             BusPlan_nivel.GrabarDB(list_niveles);


                            foreach (ct_Plancta_Info item in _ListPlanCtaInfo)
                            {
                               
                                IdCta = item.IdCtaCble;
                                Nom_cta = item.pc_Cuenta;
                                IdCta_Padre = item.IdCtaCblePadre;
                                item.IdUsuario = "migrado2";

                                respuesta=_PlanCtaBus.GrabarDB(item, ref MensajeError);
                                if (respuesta)
                                {
                                    ListEstadoGrabacion.Add(new cl_estado_grabacion(c,item.IdCtaCble, item.pc_Cuenta, IdCta_Padre,"OK", "Migrado Ok"));
                                    gridControlProceGrabado.Refresh();
                                    progressBar.Value = c;
                                    lblNumRegistros.Text = c + " registros de " + Total_Reg;
                                    progressBar.Refresh();
                                    Application.DoEvents();
                                }

                                c++;
                            }

                            if (listaLog != "")
                                MensajeLog += " pero con errores:" + "\n" + listaLog + MensajeError;
                        }
                    }
                    else
                    {
                        MensajeLog = "No se efectuó la operación. Operación cancelada por el usuario.";
                    }
                    lblmsg3.Visible = false;
                }
                else
                {
                    MensajeLog = "No existen Datos para importación.";
                }
                this.rtbLog.Text = MensajeLog;


                splashScreenManager.CloseWaitForm();

                return respuesta;

            }
            catch (Exception ex)
            {
                splashScreenManager.CloseWaitForm();
                ListEstadoGrabacion.Add(new cl_estado_grabacion(c++, IdCta, Nom_cta,IdCta_Padre, "ERROR", "No Migrado:" + ex.ToString() ));
                gridControlProceGrabado.Refresh();
                lblMensaje.Text = "Error al cargar " + ex.ToString();
                lblMensaje.Visible = true;
                return respuesta;
                
            }

        }


        private Boolean Grabacion_Niveles(List<ct_Plancta_Info> lista )
        {
            Boolean respuesta = false;
            try
            {
                ct_Plancta_nivel_Bus BusNivel = new ct_Plancta_nivel_Bus();
                List<ct_Plancta_nivel_Info> ListNiveles= new List<ct_Plancta_nivel_Info>();


                var results = from p in lista
                              group new { p.IdEmpresa, p.IdNivelCta, num_digitos = p.IdCtaCble.Length } by p into grupo
                              orderby grupo.Key
                              select grupo;

                foreach (var item in results)
                {
                    

                    ct_Plancta_nivel_Info Info=new ct_Plancta_nivel_Info();
                    Info.IdEmpresa = item.Key.IdEmpresa;
                    Info.IdNivelCta = item.Key.IdNivelCta;
                    Info.nv_Descripcion = "Nivel " + item.Key.IdNivelCta;
                    Info.nv_NumDigitos = 0;

                    //ListNiveles.Add(Info);
                }



                for (int i = ListNiveles.Count(); i < 0; i--)
                {
                    
                }


               respuesta= BusNivel.GrabarDB(ListNiveles);

               return respuesta;
            
            }
            catch (Exception ex)
            {
                lblMensaje.Text = "Error al cargar " + ex.ToString();
                lblMensaje.Visible = true;
                return respuesta;

            }

        }

        private void frmCon_PlanCuenta_ImportacionWizard_Load(object sender, EventArgs e)
        {
            cmbHoja.SelectedIndex = 0;
        }

        private void rgImportar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void wizardControl1_FinishClick(object sender, CancelEventArgs e)
        {
            try
            {
                this.Dispose();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        private void frmCon_PlanCuenta_ImportacionWizard_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                event_frmCon_PlanCuenta_ImportacionWizard_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }            
        }

        
        private void lblLink_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = null;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    filePath = saveFileDialog1.FileName;
                    File.WriteAllBytes(@filePath, Properties.Resources.Plantilla_Plan_de_Ctas_itCorp);
                    MessageBox.Show("Archivo descargado con éxito.\r\n\r\n" + filePath, "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }           
        }

        private void btn_procesar_Click(object sender, EventArgs e)
        {
            try
            {

                Proceso_Grabacion();
                wizardPageEstadoGrabacion.AllowNext = true;

            }
            catch (Exception ex)
            {
                
                
            }
        }

        

    }


    class cl_estado_grabacion
    {
        public string IdCuenta { get; set; }
        public string Nom_cuenta { get; set; }
        public string Estado_grabado { get; set; }
        public string Observacion { get; set; }
        public int Secuencia { get; set; }
        public string IdCuentaPadre { get; set; }





        public cl_estado_grabacion()
        {
        }



        public cl_estado_grabacion(int _Secuencia,string _IdCuenta, string _Nom_cuenta,string _IdCuentaPadre, string _Estado_grabado, string _Observacion)
        {
            IdCuenta = _IdCuenta;
            Nom_cuenta = _Nom_cuenta;
            IdCuentaPadre = _IdCuentaPadre;
            Estado_grabado = _Estado_grabado;
            Observacion = _Observacion;
            Secuencia = _Secuencia;

        }

    }


}
