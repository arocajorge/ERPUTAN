using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using DevExpress.XtraEditors;
using DevExpress.XtraBars;
using System.IO;
using System.Reflection;

namespace Core.Erp.Winform.Controles
{
    public partial class UCGe_Administrador_Reporte : UserControl
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        private Assembly Ensamblado;
        string RutaPantalla;

        public delegate void delegate_ucGe_Menu_event_btnSalir_ItemClick(object sender, ItemClickEventArgs e);
        public event delegate_ucGe_Menu_event_btnSalir_ItemClick event_ucGe_Menu_event_btnSalir_ItemClick;


        public Form FormMain { get; set; }
        Point p = new Point();

        public UCGe_Administrador_Reporte()
        {
            try
            {
              InitializeComponent();
              event_ucGe_Menu_event_btnSalir_ItemClick += UCGe_Administrador_Reporte_event_ucGe_Menu_event_btnSalir_ItemClick;
              
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());   
            }

        }

        void UCGe_Administrador_Reporte_event_ucGe_Menu_event_btnSalir_ItemClick(object sender, ItemClickEventArgs e)
        {
            
        }

        public void set_UCGe_Administrador_Reporte(List<tb_modulo_Info> lstModulo)
        {
            try
            {
                LstRpt = rpt_B.Get_list_sis_reporte(lstModulo);


                (from q in LstRpt select q).ToList().ForEach(tb =>
                {
                    if (tb.imgByt == null)
                    {
                        tb.imagen = global::Core.Erp.Winform.Properties.Resources.Reporte_1;
                    }
                });

                gridControl_Report.DataSource = LstRpt;

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());   
            }

        }


        List<tb_sis_reporte_Info> LstRpt = new List<tb_sis_reporte_Info>();
        tb_sis_reporte_Bus rpt_B = new tb_sis_reporte_Bus();
        tb_sis_reporte_Info rpt_I=new tb_sis_reporte_Info();
        tb_modulo_Bus Modulo_B = new tb_modulo_Bus();

        private void BuscaDBFrm()
        {
            try 
	        {
                
                string nombre_dll = "";
                string Nom_asambly = "";
                string NombreFormulario = "";
                string RutaPantalla = "";

                Nom_asambly = rpt_I.nom_Asembly;
                NombreFormulario = rpt_I.Formulario;
                nombre_dll = Nom_asambly + ".dll";
               
                //cargando la dll
                Ensamblado = Assembly.LoadFrom(nombre_dll);

                // Load the object
                string nAsambly2 = rpt_I.nom_Asembly;

                Object ObjFrm;
                Type tipo = Ensamblado.GetType(Nom_asambly + "." + NombreFormulario);

                RutaPantalla = Nom_asambly + "." + NombreFormulario;


                if (tipo == null)
                {
                    MessageBox.Show("No se encontró el formulario Emsamblado:" + Nom_asambly + "  Formulario:" + NombreFormulario, "Error de ubicación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ObjFrm = Activator.CreateInstance(tipo);
                    Form Formulario = (Form)ObjFrm;

                    if (FormMain != null)
                        Formulario.MdiParent = FormMain;
                    Formulario.Show();
                }
	        }
	        catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());   
	        }
        }

        private void gridControl_Report_Click(object sender, EventArgs e)
        {

        }

        private void gridViewReport_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                rpt_I = rpt_B.Get_Info_sis_reporte(Convert.ToString(gridViewReport.GetFocusedRowCellValue(colCodReporte1)));
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void gridViewReport_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            
        }

        private void ucGe_Menu_Load(object sender, EventArgs e)
        {

        }
       

        private void gridViewReport_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                    BuscaDBFrm();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            event_ucGe_Menu_event_btnSalir_ItemClick(sender, null);
        }
    }
}
