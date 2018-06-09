using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.General;
using Core.Erp.Winform.Contabilidad;
using Core.Erp.Business.General;

namespace Core.Erp.Winform.General
{
    public partial class FrmGE_EmpresaCons : Form
    {
        #region Declaración de Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_Empresa_Bus BusEmp = new tb_Empresa_Bus();
        tb_Empresa_Info InfoEmp = new tb_Empresa_Info();
        List<tb_Empresa_Info> listEm = new List<tb_Empresa_Info>();
        BindingList<tb_Empresa_Info> ListaBin;
        FrmGe_EmpresaMant frm = new FrmGe_EmpresaMant();
        #endregion
        
        public FrmGE_EmpresaCons()
        {
            InitializeComponent();
            ucGe_Menu.event_btnImprimir_ItemClick += ucGe_Menu_event_btnImprimir_ItemClick;
            ucGe_Menu.event_btnModificar_ItemClick += ucGe_Menu_event_btnModificar_ItemClick;
            ucGe_Menu.event_btnNuevo_ItemClick += ucGe_Menu_event_btnNuevo_ItemClick;
            ucGe_Menu.event_btnSalir_ItemClick += ucGe_Menu_event_btnSalir_ItemClick;
            ucGe_Menu.event_btnconsultar_ItemClick += ucGe_Menu_event_btnconsultar_ItemClick;
        }

        void ucGe_Menu_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                InfoEmp = (tb_Empresa_Info)gridViewEmpresa.GetFocusedRow();
                frm = new FrmGe_EmpresaMant(Cl_Enumeradores.eTipo_action.consultar);
                frm.event_FrmGe_EmpresaMant_FormClosing += frm_event_FrmGe_EmpresaMant_FormClosing;
                frm.Text = frm.Text + " ***CONSULTAR REGISTRO***";
                frm.set_empresa(InfoEmp);
                frm.MdiParent = this.MdiParent;
                frm.Show(); 
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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

        void ucGe_Menu_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            frm = new FrmGe_EmpresaMant(Cl_Enumeradores.eTipo_action.grabar);
            frm.event_FrmGe_EmpresaMant_FormClosing += frm_event_FrmGe_EmpresaMant_FormClosing; 
            frm.Text = frm.Text + " ***NUEVO REGISTRO***";           
            frm.MdiParent = this.MdiParent;
            frm.Show();          
        }

        void frm_event_FrmGe_EmpresaMant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                cargar_empresas();
            }
            catch (Exception ex )
            {
                 Log_Error_bus.Log_Error(ex.ToString());
                 MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                InfoEmp = (tb_Empresa_Info)gridViewEmpresa.GetFocusedRow();
                frm = new FrmGe_EmpresaMant(Cl_Enumeradores.eTipo_action.actualizar);
                frm.event_FrmGe_EmpresaMant_FormClosing += frm_event_FrmGe_EmpresaMant_FormClosing;
                frm.Text = frm.Text + " ***ACTUALIZAR REGISTRO***";
                frm.set_empresa(InfoEmp);
                frm.MdiParent = this.MdiParent;
                frm.Show(); 
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {                 
                 gridViewEmpresa.ShowRibbonPrintPreview();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmGE_EmpresaCons_Load(object sender, EventArgs e)
        {
            try
            {
                cargar_empresas();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cargar_empresas()
        {
            try
            {
               
                listEm = BusEmp.Get_List_Empresa();
                foreach (var item in listEm)
                {
                    if (item.em_logo != null)
                    {
                        item.em_logo_Image = Funciones.ArrayAImage(item.em_logo);
                    }
                }

                ListaBin = new BindingList<tb_Empresa_Info>(listEm);

                gridControlEmpresa.DataSource = ListaBin.OrderByDescending(x => x.IdEmpresa);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
