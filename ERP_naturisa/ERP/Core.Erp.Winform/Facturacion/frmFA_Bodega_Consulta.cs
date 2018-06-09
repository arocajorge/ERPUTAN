using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.General;
using Core.Erp.Info.General;

namespace Core.Erp.Winform.Facturacion
{
    public partial class frmFa_Bodega_Consulta : Form
    {
        #region Declaración de variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        public tb_Bodega_Info Bodega_I { get; set; }
        tb_Bodega_Info Bodega = new tb_Bodega_Info();
        tb_Bodega_Bus Bus = new tb_Bodega_Bus();
        frmFa_Bodega ofrm = new frmFa_Bodega();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        #endregion

        public frmFa_Bodega_Consulta()
        {
            try
            {
                InitializeComponent();
                ofrm.Event_frmFA_Bodega_FormClosing += ofrm_Event_frmFA_Bodega_FormClosing;
                ucGe_Menu.event_btnAnular_ItemClick += ucGe_Menu_event_btnAnular_ItemClick;
                ucGe_Menu.event_btnconsultar_ItemClick += ucGe_Menu_event_btnconsultar_ItemClick;
                ucGe_Menu.event_btnModificar_ItemClick += ucGe_Menu_event_btnModificar_ItemClick;
                ucGe_Menu.event_btnNuevo_ItemClick += ucGe_Menu_event_btnNuevo_ItemClick;
                ucGe_Menu.event_btnSalir_ItemClick += ucGe_Menu_event_btnSalir_ItemClick;
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
                Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ofrm_Event_frmFA_Bodega_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                CargarGrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                ofrm = new frmFa_Bodega();
                ofrm.Event_frmFA_Bodega_FormClosing += new frmFa_Bodega.delegate_frmFA_Bodega_FormClosing(ofrm_Event_frmFA_Bodega_FormClosing);  
                ofrm.set_Accion(Erp.Info.General.Cl_Enumeradores.eTipo_action.grabar);
                ofrm.Show();
                ofrm.MdiParent = this.MdiParent;
                CargarGrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                ofrm = new frmFa_Bodega();
                ofrm.Event_frmFA_Bodega_FormClosing += new frmFa_Bodega.delegate_frmFA_Bodega_FormClosing(ofrm_Event_frmFA_Bodega_FormClosing);  
                ofrm.set_Accion(Erp.Info.General.Cl_Enumeradores.eTipo_action.actualizar);
                ofrm.set_Bodega(Bodega);
                ofrm.ShowDialog();
                ofrm.Show();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                ofrm = new frmFa_Bodega();
                ofrm.Event_frmFA_Bodega_FormClosing += new frmFa_Bodega.delegate_frmFA_Bodega_FormClosing(ofrm_Event_frmFA_Bodega_FormClosing);  
                ofrm.set_Accion(Erp.Info.General.Cl_Enumeradores.eTipo_action.consultar);
                ofrm.set_Bodega(Bodega);
                ofrm.MdiParent = this.MdiParent;
                ofrm.Show();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                ofrm = new frmFa_Bodega();
                ofrm.Event_frmFA_Bodega_FormClosing += new frmFa_Bodega.delegate_frmFA_Bodega_FormClosing(ofrm_Event_frmFA_Bodega_FormClosing);  
                ofrm.set_Accion(Erp.Info.General.Cl_Enumeradores.eTipo_action.Anular);
                ofrm.set_Bodega(Bodega);
                ofrm.MdiParent = this.MdiParent;
                ofrm.Show();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public frmFa_Bodega_Consulta(int IdEmpresa, int IdSucursal)  : this()
        {
            try
            {
                tb_Bodega_Bus _Bodegas_b = new tb_Bodega_Bus();
                gridControlBodega.DataSource = _Bodegas_b.Get_List_Bodega(IdEmpresa, IdSucursal).FindAll(c=> c.Estado==true);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewBodega_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                Bodega = (tb_Bodega_Info)gridViewBodega.GetFocusedRow();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewBodega_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                Bodega_I = Bodega;
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewBodega_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {

                if (e.KeyValue == 13)
                {
                    Bodega_I = Bodega;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void CargarGrid()
        {
            try
            {
                gridControlBodega.DataSource = Bus.Get_List_Bodega(param.IdEmpresa,param.IdSucursal);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmFA_Bodega_Consulta_Load(object sender, EventArgs e)
        {
            try
            {
                CargarGrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void gridViewBodega_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                Bodega = (tb_Bodega_Info)gridViewBodega.GetFocusedRow();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
                MessageBox.Show(ex.ToString());
            }


            try
            {
                var data = gridViewBodega.GetRow(e.RowHandle) as tb_Bodega_Info;
                if (data == null)
                    return;
                if (data.Estado == false)
                    e.Appearance.ForeColor = Color.Red;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
