using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.Inventario;

namespace Core.Erp.Winform.Inventario
{
    public partial class FrmIn_Catalogo_Cons : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        private Cl_Enumeradores.eTipo_action _Accion;

        in_Catalogo_Tipo_Bus BusTipo = new in_Catalogo_Tipo_Bus();
        in_CatalogoTipo_Info InfoTipo = new in_CatalogoTipo_Info();

        in_Catalogo_Bus BusCata = new in_Catalogo_Bus();
        in_Catalogo_Info InfoCata = new in_Catalogo_Info();

        List<in_Catalogo_Info> listCata = new List<in_Catalogo_Info>();

        FrmIn_Catalogo_Mant frmCata = new FrmIn_Catalogo_Mant();

        public FrmIn_Catalogo_Cons()
        {
            InitializeComponent();
            CargarCatalogo();
            CargaListaTipo();

            ucGe_Menu.event_btnNuevo_ItemClick += ucGe_Menu_event_btnNuevo_ItemClick;
            ucGe_Menu.event_btnModificar_ItemClick += ucGe_Menu_event_btnModificar_ItemClick;
            ucGe_Menu.event_btnconsultar_ItemClick += ucGe_Menu_event_btnconsultar_ItemClick;
            ucGe_Menu.event_btnImprimir_ItemClick += ucGe_Menu_event_btnImprimir_ItemClick;
            ucGe_Menu.event_btnSalir_ItemClick += ucGe_Menu_event_btnSalir_ItemClick;
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

        void ucGe_Menu_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                gridViewCatalogo.ShowPrintPreview();
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
                if (InfoCata != null)
                {

                    frmCata = new FrmIn_Catalogo_Mant(Cl_Enumeradores.eTipo_action.consultar);
                    frmCata.Text = frmCata.Text + "***CONSULTAR REGISTRO***";
                    frmCata._SetInfo = InfoCata;
                    frmCata.Show();
                    frmCata.MdiParent = this.MdiParent;
                    frmCata.event_FrmIn_Catalogo_Mant_FormClosing += frmCata_event_FrmIn_Catalogo_Mant_FormClosing;

                }
                else
                {
                    MessageBox.Show("Seleccione un Registro a Mostrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
                }
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

                if (InfoCata != null)
                {
                    frmCata = new FrmIn_Catalogo_Mant(Cl_Enumeradores.eTipo_action.actualizar);
                    frmCata.Text = frmCata.Text + "***ACTUALIZAR REGISTRO***";
                    frmCata._SetInfo = InfoCata;
                    frmCata.Show();
                    frmCata.MdiParent = this.MdiParent;
                    frmCata.event_FrmIn_Catalogo_Mant_FormClosing += frmCata_event_FrmIn_Catalogo_Mant_FormClosing;

                }
                else
                {
                    MessageBox.Show("Seleccione un Registro a Modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
                }
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
                frmCata = new FrmIn_Catalogo_Mant(Cl_Enumeradores.eTipo_action.grabar);
                frmCata.Text = frmCata.Text + " ***NUEVO REGISTRO***";
                frmCata.txtIdCatalogo_tipo.Text = InfoTipo.IdCatalogo_tipo.ToString();
                frmCata.Show();
                frmCata.MdiParent = this.MdiParent;
                frmCata.event_FrmIn_Catalogo_Mant_FormClosing += frmCata_event_FrmIn_Catalogo_Mant_FormClosing;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void frmCata_event_FrmIn_Catalogo_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                CargarCatalogo();
                CargaListaTipo();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargaListaTipo()
        {
            try
            {
                this.lstbox_TipoCatalogo.DataSource = BusTipo.Get_List_CatalogoTipo(); 
                this.lstbox_TipoCatalogo.DisplayMember = "Descripcion";
                this.lstbox_TipoCatalogo.ValueMember = "IdCatalogo_tipo";
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarCatalogo()
        {
            try
            {
                listCata = BusCata.Get_List_Catalogo();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private in_Catalogo_Info GetSelectedRow(DevExpress.XtraGrid.Views.Grid.GridView view)
        {
            try
            {
                return (in_Catalogo_Info)view.GetRow(view.FocusedRowHandle);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new in_Catalogo_Info();
            }
        }

        private void gridViewCatalogo_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                InfoCata = GetSelectedRow((DevExpress.XtraGrid.Views.Grid.GridView)sender);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewCatalogo_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            try
            {
                var data = gridViewCatalogo.GetRow(e.RowHandle) as in_Catalogo_Info;
                if (data == null)
                    return;

                if (data.Estado == "I")
                    e.Appearance.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cargarGridConCatalogo(int idTipoCatalogo)
        {

            try
            {

                this.gridCatalogo.DataSource = BusCata.Get_List_Catalogo(idTipoCatalogo).ToList();
 
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void lstbox_TipoCatalogo_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                InfoTipo = (in_CatalogoTipo_Info)lstbox_TipoCatalogo.SelectedItem;


                cargarGridConCatalogo(InfoTipo.IdCatalogo_tipo);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lstbox_TipoCatalogo_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right)
                {
                    Point p = new Point(e.X, e.Y);
                    if (InfoTipo != null)
                    {
                        menuTipo.Show(lstbox_TipoCatalogo, p);
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                FrmIn_Catalogo_Tipo_Mant frmtipo = new FrmIn_Catalogo_Tipo_Mant();
                frmtipo = new FrmIn_Catalogo_Tipo_Mant(Cl_Enumeradores.eTipo_action.grabar);
                frmtipo.Text = frmtipo.Text + " ***NUEVO REGISTRO***";
                frmtipo.Show();
                frmtipo.MdiParent = this.MdiParent;
                frmtipo.event_FrmIn_Catalogo_Tipo_Mant_FormClosing += frmtipo_event_FrmIn_Catalogo_Tipo_Mant_FormClosing;
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void frmtipo_event_FrmIn_Catalogo_Tipo_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                CargarCatalogo();
                CargaListaTipo();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                FrmIn_Catalogo_Tipo_Mant frmtipo = new FrmIn_Catalogo_Tipo_Mant();
                frmtipo = new FrmIn_Catalogo_Tipo_Mant(Cl_Enumeradores.eTipo_action.actualizar);
                frmtipo.Text = frmtipo.Text + "***ACTUALIZAR REGISTRO***";
                frmtipo._SetInfo = InfoTipo;
                frmtipo.Show();
                frmtipo.MdiParent = this.MdiParent;
                frmtipo.event_FrmIn_Catalogo_Tipo_Mant_FormClosing +=frmtipo_event_FrmIn_Catalogo_Tipo_Mant_FormClosing;
                 
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmIn_Catalogo_Cons_Load(object sender, EventArgs e)
        {

        }




    }
}
