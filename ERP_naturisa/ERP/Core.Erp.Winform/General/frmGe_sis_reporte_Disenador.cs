using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;
using System.Runtime.InteropServices;
using Core.Erp.Info.General;
using System.Reflection;
using Core.Erp.Business.General;
using System.IO;

namespace Core.Erp.Winform.General
{
    public partial class frmGe_sis_reporte_Disenador : Form
    {

        private Assembly Ensamblado;
        tb_sis_reporte_Info InfoReporte = new tb_sis_reporte_Info();
        tb_sis_reporte_Bus BusReporte = new tb_sis_reporte_Bus();
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        static string result = Path.GetTempPath();
        String RootReporte = result + @"Disenio_report.repx";

        public void set_reporte(tb_sis_reporte_Info _InfoReporte)
        {
            InfoReporte = _InfoReporte;

        }

        public frmGe_sis_reporte_Disenador()
        {
            InitializeComponent();
        }

        private void frmGe_sis_reporte_Disenador_Load(object sender, EventArgs e)
        {
            try
            {
                string Rpt = "";
                string asambly = "";
                string nombreAsambly = "";
                if (InfoReporte != null)
                {
                    if (InfoReporte.CodReporte != null)
                    {
                        Rpt = InfoReporte.Class_NomReporte;
                        asambly = InfoReporte.nom_Asembly;
                        nombreAsambly = asambly + ".dll";

                        Ensamblado = Assembly.LoadFrom(nombreAsambly);

                        Object ObjFrm;
                        Type tipo = Ensamblado.GetType(asambly + "." + Rpt);

                        if (tipo == null)
                        {
                            MessageBox.Show("No se encontró el Reporte Emsamblado:" + asambly + "  Reporte:" + Rpt, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            ObjFrm = Activator.CreateInstance(tipo);
                            DevExpress.XtraReports.UI.XtraReport Reporte_Para_diseño = (DevExpress.XtraReports.UI.XtraReport)ObjFrm;
                            if (Reporte_Para_diseño != null)
                            {
                                if (InfoReporte.Disenio_reporte != null)
                                    File.WriteAllBytes(RootReporte, InfoReporte.Disenio_reporte);

                                commandBarItem31.PerformClick();

                                if (InfoReporte.Disenio_reporte != null)
                                    Reporte_Para_diseño.LoadLayout(RootReporte);

                                xrDesignDockManager1.XRDesignPanel.OpenReport(Reporte_Para_diseño);

                            }

                        }
                    }
                }
                commandBarItem31.Enabled = false;
                commandBarItem32.Enabled = false; 
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        private Boolean Guardar()
        {
            try
            {
                Boolean resultado = false;
                string reportruta = result + "save_reporte_disenio.repx";
                xrDesignDockManager1.XRDesignPanel.SaveReport(reportruta);
                Byte[] data;
                using (System.IO.FileStream FL = new System.IO.FileStream(reportruta, System.IO.FileMode.Open))
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        FL.CopyTo(ms);
                        data = ms.ToArray();
                    }
                }
                InfoReporte.Disenio_reporte = data;
                resultado = BusReporte.ModificarDB_Disenio(InfoReporte);
                if (resultado == true)
                {
                    data = null;
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_modifico_corrrectamente) + " el Reporte: " + InfoReporte.Class_NomReporte, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return resultado;
                }
                else
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.No_se_modificaron_los_datos) + " del Reporte ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return resultado;
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void barButtonItem_Guardar_Disenio_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Guardar();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void barButtonItem_Guardar_Salir_Disenio_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (Guardar())
                    Close();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmGe_sis_reporte_Disenador_FormClosing(object sender, FormClosingEventArgs e)
        {

        }  
    }
}
