using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info;
using Core.Erp.Business;
using Core.Erp.Winform.Controles;
using Core.Erp.Business.General;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Info.General;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraTreeList.Columns;
using System.IO;
using System.Data.OleDb;


namespace Core.Erp.Winform.Contabilidad
{
    public partial class frmCon_PlanCuenta_Consulta : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        #region DATA
        ct_Plancta_Bus _PlanCtaBus = new ct_Plancta_Bus();
        ct_Plancta_Info _PlanCtaInfo = new ct_Plancta_Info();
        List<ct_Plancta_Info> _ListPlanCtaInfo = new List<ct_Plancta_Info>();
        ct_Plancta_Info _PlanCtaPadreInfo = new ct_Plancta_Info();
        #endregion
        #region frm
        frmCon_PlanCuenta_Mant frm;
        frmCon_PlanCuenta_ImportacionWizard impo;
        #endregion

        string MensajeError = "";

        public frmCon_PlanCuenta_Consulta()
        {
            try
            {
              InitializeComponent();

              ucGe_Menu_Mantenimiento_x_usuario.event_btnAnular_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick;
              ucGe_Menu_Mantenimiento_x_usuario.event_btnconsultar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick;
              ucGe_Menu_Mantenimiento_x_usuario.event_btnModificar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick;
              ucGe_Menu_Mantenimiento_x_usuario.event_btnNuevo_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick;
              ucGe_Menu_Mantenimiento_x_usuario.event_btnSalir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick;
              ucGe_Menu_Mantenimiento_x_usuario.event_btnImprimir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnImprimir_ItemClick;
              ucGe_Menu_Mantenimiento_x_usuario.event_btnImpExcel_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnImpExcel_ItemClick;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                gridControlPlancta.ShowPrintPreview();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                llamar_Formulario(Cl_Enumeradores.eTipo_action.grabar);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                llamar_Formulario(Cl_Enumeradores.eTipo_action.actualizar);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {


                llamar_Formulario(Cl_Enumeradores.eTipo_action.consultar);

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (_PlanCtaInfo.pc_Estado == "I") { MessageBox.Show("Cuenta está Anulada"); return; }

                llamar_Formulario(Cl_Enumeradores.eTipo_action.Anular);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCon_PlanCta_Load(object sender, EventArgs e)
        {
            
            try
            {

                Cargar_PlanCuenta();
            
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            try
            {
              this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_salir_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Cargar_PlanCuenta()
        {
            try
            {

                _ListPlanCtaInfo = _PlanCtaBus.Get_List_Plancta(param.IdEmpresa, ref MensajeError);

                this.gridControlPlancta.DataSource = _ListPlanCtaInfo;
                //treeListPlanCta.ExpandAll();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void llamar_Formulario(Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {
                _PlanCtaInfo = (ct_Plancta_Info)gridViewPlancta.GetFocusedRow();

                frm = new frmCon_PlanCuenta_Mant();

                frm.event_frmCon_PlanCuenta_Mant_FormClosing += new frmCon_PlanCuenta_Mant.delegate_frmCon_PlanCuenta_Mant_FormClosing(frm_event_frmCon_PlanCuenta_Mant_FormClosing);

                if (!(Accion == Cl_Enumeradores.eTipo_action.grabar))
                {
                    if (_PlanCtaInfo != null)
                    {
                        frm.InfoPlanCta = _PlanCtaInfo;
                        frm._Accion = Accion;
                        frm.Show();
                    }
                    else
                        MessageBox.Show("Seleccione un registro", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    frm._Accion = Accion;
                    frm.Show();
                }
                    

                
            }
            catch (Exception ex)
            {
                        Log_Error_bus.Log_Error(ex.ToString());
                        MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void frm_event_frmCon_PlanCuenta_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Cargar_PlanCuenta();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
        }

        //private void treeListPlanCta_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        //{
        //    try
        //    {

        //        TreeListNode childNode = (TreeListNode)e.Node;
        //        _PlanCtaInfo = (ct_Plancta_Info)treeListPlanCta.GetDataRecordByNode(childNode);
        //        _PlanCtaPadreInfo = _ListPlanCtaInfo.Find(delegate(ct_Plancta_Info ca) { return ca.IdCtaCble == _PlanCtaInfo.IdCtaCblePadre && ca.IdEmpresa == _PlanCtaInfo.IdEmpresa; });
        //    }
        //    catch (Exception ex)
        //    {
        //        Log_Error_bus.Log_Error(ex.ToString());
        //        MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //private void treeListPlanCta_NodeCellStyle(object sender, GetCustomNodeCellStyleEventArgs e)
        //{
        //    try
        //    {
        //        if (Convert.ToString(e.Node.GetValue(e.Column.AbsoluteIndex)) == "I")
        //        {
        //            e.Appearance.ForeColor = Color.Red;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Log_Error_bus.Log_Error(ex.ToString());
        //        MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        private void ucGe_Menu_Mantenimiento_x_usuario_event_btnImpExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {            
            try
            {
                    impo = new frmCon_PlanCuenta_ImportacionWizard();
                    impo.event_frmCon_PlanCuenta_ImportacionWizard_FormClosing += new frmCon_PlanCuenta_ImportacionWizard.delegate_frmCon_PlanCuenta_ImportacionWizard_FormClosing(frm_event_frmCon_PlanCuenta_ImportacionWizard_FormClosing);
                    impo.Show();                  
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void frm_event_frmCon_PlanCuenta_ImportacionWizard_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Cargar_PlanCuenta();
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
                if (ruta != "")
                {

                    if (PU_CARGA_EXCEL())
                    {
                        this.gridControlPlancta.DataSource = null;
                        this.gridControlPlancta.DataSource = _ListPlanCtaInfo;
                        //treeListPlanCta.ExpandAll();
                        return true;
                    }
                    else 
                    { MessageBox.Show("Archivo no cumple formato de plantilla", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop); return false; }
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
                    _ListPlanCtaInfo.Clear();
                    _ListPlanCtaInfo = _PlanCtaBus.ProcesarDataTableCt_Plancta_Info(ds, param.IdEmpresa, ref MensajeError);
                    return true; 
                }
                else return false;
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
                strconn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + ruta + ";Extended Properties=Excel 12.0;";
                OleDbConnection mconn = new OleDbConnection(strconn);
                //
                //El nombre de la hoja del archivo de marcaciones tiene que llamarse Marcaciones
                OleDbDataAdapter ad = new OleDbDataAdapter("Select * from [" + plantilla + "$]", mconn);
                //abre una conexion de tipo oledb
                mconn.Open();
                //Lo agrega a mi datatable
                ad.Fill(ds);
                //cierra una conexion de tipo oledb
                mconn.Close();
                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ds = new DataTable();
                return false;
            }
        }

    }
}
