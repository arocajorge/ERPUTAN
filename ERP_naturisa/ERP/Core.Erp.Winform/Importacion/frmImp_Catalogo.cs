using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.Importacion;
using Core.Erp.Info.Importacion;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
namespace Core.Erp.Winform.Importacion
{
    public partial class frmImp_Catalogo : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        private Cl_Enumeradores.eTipo_action _Accion;
        imp_Catalogo_tipo_Bus busTipo = new imp_Catalogo_tipo_Bus();
        imp_Catalogo_tipo_info infoTipo = new imp_Catalogo_tipo_info();
        imp_catalogo_Bus busCata = new imp_catalogo_Bus();
        imp_catalogo_Info infoCata = new imp_catalogo_Info();
        frmImp_Catalogo_mantenimiento frm;

        List<imp_catalogo_Info> listCatalogos = new List<imp_catalogo_Info>();

        public frmImp_Catalogo()
        {
            try
            {
                InitializeComponent();
                CargarCatalogo();
                CargaListaTipo();
                ucGe_Menu_Mantenimiento_x_usuario.event_btnAnular_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnconsultar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnModificar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnNuevo_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnSalir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());

            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Llamar_formulario(Cl_Enumeradores.eTipo_action.grabar);
                //frmImp_Catalogo_mantenimiento frmtipo = new frmImp_Catalogo_mantenimiento();
                //frmtipo.setAccion(Cl_Enumeradores.eTipo_action.grabar);
                ////frmtipo.setTipo(infoTipo);
                //frmtipo.txtCatTipo.Text = infoTipo.IdCatalogoImport_tipo.ToString();
                //frmtipo.ShowDialog();
                //CargarCatalogo();
                //CargaListaTipo();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());

            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Llamar_formulario(Cl_Enumeradores.eTipo_action.actualizar);
                //frm = new frmImp_Catalogo_mantenimiento();
                //frm.setAccion(Cl_Enumeradores.eTipo_action.actualizar);
                //frm.txtIdCat.Enabled = false;
                //frm.setTipo(infoCata);
                //frm.ShowDialog();
                //CargarCatalogo();
                //CargaListaTipo();
                ////cargarGridConCatalogo();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());

            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Llamar_formulario(Cl_Enumeradores.eTipo_action.consultar);
                //frmImp_Catalogo_mantenimiento frm = new frmImp_Catalogo_mantenimiento();
                //frm.setAccion(Cl_Enumeradores.eTipo_action.consultar);
                //frm.setTipo(infoCata);
                //frm.ShowDialog();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (infoCata.Estado == "I")
                {
                    MessageBox.Show("Catalogo ya se encuentra Anulado");
                    return;
                }
                else
                    Llamar_formulario(Cl_Enumeradores.eTipo_action.Anular);

                //frmImp_Catalogo_mantenimiento frm = new frmImp_Catalogo_mantenimiento();
                //frm.setAccion(Cl_Enumeradores.eTipo_action.Anular);
                //frm.setTipo(infoCata);
                //frm.ShowDialog();
                //CargarCatalogo();
                //CargaListaTipo();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void Llamar_formulario(Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {
                frm = new frmImp_Catalogo_mantenimiento();
                //frm.event_delegate_frmfa_liquidacion_gastos_Mant_FormClosing += frm_event_delegate_frmfa_liquidacion_gastos_Mant_FormClosing;
                frm.setAccion(Accion);
                if (Accion != Cl_Enumeradores.eTipo_action.grabar)
                {
                    if (infoCata != null)
                    {
                        frm.setTipo(infoCata);
                        frm.MdiParent = this.MdiParent;
                        frm.Show();
                    }
                    else
                        MessageBox.Show("Por Favor seleccione un registro para continuar", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void CargaListaTipo()
        {
            try
            {
                this.lstbox_TipoCatalogo.DataSource = busTipo.Get_List_Catalogo_tipo(); //DataTipoCat.ObtenerList_Tipo();
                this.lstbox_TipoCatalogo.DisplayMember = "Descripcion";
                this.lstbox_TipoCatalogo.ValueMember = "IdCatalogoImport_tipo";
                //MessageBox.Show(Convert.ToString(lstbox_TipoCatalogo.SelectedValue));
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void CargarCatalogo()
        {
            try
            {
                 listCatalogos = busCata.Get_List_catalogo();
            }
            catch (Exception ex)
            {
                  Log_Error_bus.Log_Error(ex.ToString());

            }

        }

        //private void lstbox_TipoCatalogo_SelectedValueChanged(object sender, EventArgs e)
        //{
        //    try 
                //{	        
                //    CargarGridCatalogo();
                //    gridCatalogo.DataSource = busCata.listaCatalogo(Convert.ToInt32(lstbox_TipoCatalogo.SelectedValue));
                //    string x = Convert.ToString( lstbox_TipoCatalogo.SelectedValue);
                //    x = "([IdCatalogoImport_tipo] =" + x + ")";
                //    gridViewCatalogo.ActiveFilterString = "([IdCatalogoImport_tipo] ="+x+")";
                //}
                //catch (Exception ex)
                //{
                //    Log_Error_bus.Log_Error(ex.ToString());
                //}
  
        //}

        private imp_catalogo_Info GetSelectedRow(DevExpress.XtraGrid.Views.Grid.GridView view)
        {
            try
            {
                return (imp_catalogo_Info)view.GetRow(view.FocusedRowHandle);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return new imp_catalogo_Info();
            }
        }

        private void gridViewCatalogo_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                infoCata = GetSelectedRow((DevExpress.XtraGrid.Views.Grid.GridView)sender);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void gridViewCatalogo_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                 var data = gridViewCatalogo.GetRow(e.RowHandle) as imp_catalogo_Info;
                    if (data == null)
                        return;

                    if (data.Estado == "I")
                        e.Appearance.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
           
        }

        private void frmImp_Catalogo_Load(object sender, EventArgs e)
        {
            try
            {
                 //cargarGridConCatalogo();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());               
            }


        }

        private void mnuNuevo_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                  Log_Error_bus.Log_Error(ex.ToString());

            }
        }

        private void lstbox_TipoCatalogo_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {

            }
            catch (Exception ex)
            {
                  Log_Error_bus.Log_Error(ex.ToString());

            }



        }

        private void cargarGridConCatalogo(int idTipoCatalogo)
        {
            try
            {
                var ListCata = from cat in listCatalogos
                               where cat.IdCatalogoImport_tipo == idTipoCatalogo
                               select cat;

                this.gridCatalogo.DataSource = ListCata.ToList();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void lstbox_TipoCatalogo_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                infoTipo = (imp_Catalogo_tipo_info)lstbox_TipoCatalogo.SelectedItem;


                cargarGridConCatalogo(infoTipo.IdCatalogoImport_tipo);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());

            }


        }

        private void lstbox_TipoCatalogo_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
               if (e.Button == MouseButtons.Right)
                {
                    Point p = new Point(e.X, e.Y);
                    if (infoTipo != null)
                    {
                        menuTipo.Show(lstbox_TipoCatalogo, p);
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());

            }
            
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                    frmImp_Catalogo_Tipo_mantenimiento frmtipo = new frmImp_Catalogo_Tipo_mantenimiento();
                    frmtipo.setAccion(Cl_Enumeradores.eTipo_action.grabar);
                    frmtipo.ShowDialog();
                    CargarCatalogo();
                    CargaListaTipo();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());

            }


        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                      frmImp_Catalogo_Tipo_mantenimiento frmtipo = new frmImp_Catalogo_Tipo_mantenimiento();
                    frmtipo.setAccion(Cl_Enumeradores.eTipo_action.actualizar);
                    infoTipo.Estado = "A";
                    frmtipo.setTipo(infoTipo);
                    frmtipo.ShowDialog();
                    CargarCatalogo();
                    CargaListaTipo();
            }
            catch (Exception ex)
            {
                  Log_Error_bus.Log_Error(ex.ToString());

            }
    
        } 

        private void lstbox_TipoCatalogo_Click(object sender, EventArgs e)
        {
            try
            {
                  //toolStripMain.Enabled = false;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());

            }

        }

        private void ucGe_Menu_Mantenimiento_x_usuario_Load(object sender, EventArgs e)
        {

        }
    }
}
