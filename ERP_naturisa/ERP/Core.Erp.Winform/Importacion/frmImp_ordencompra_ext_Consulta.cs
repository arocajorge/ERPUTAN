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
using Core.Erp.Business.General;
using Core.Erp.Info.General;

namespace Core.Erp.Winform.Importacion
{    //VERSION:13052013
    public partial class frmImp_ordencompra_ext_Consulta : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        public frmImp_ordencompra_ext_Consulta()
        {
            try
            {
                InitializeComponent();
                frm.Envet_frmImp_ordencompra_ext_Mantenimiento_FormClosing += new frmImp_ordencompra_ext_Mantenimiento.delegate_frmImp_ordencompra_ext_Mantenimiento_FormClosing(frm_Envet_frmImp_ordencompra_ext_Mantenimiento_FormClosing);
                ListCatalogo = ObusCatalogo.Get_List_catalogo();
                ucGe_Menu_Mantenimiento_x_usuario.event_btnAnular_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnBuscar_Click += ucGe_Menu_Mantenimiento_x_usuario_event_btnBuscar_Click;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnconsultar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnImprimir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnImprimir_ItemClick;
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
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frm = new frmImp_ordencompra_ext_Mantenimiento();
                frm.Envet_frmImp_ordencompra_ext_Mantenimiento_FormClosing += new frmImp_ordencompra_ext_Mantenimiento.delegate_frmImp_ordencompra_ext_Mantenimiento_FormClosing(frm_Envet_frmImp_ordencompra_ext_Mantenimiento_FormClosing);
                frm.setAccion(Info.General.Cl_Enumeradores.eTipo_action.grabar);
                frm.MdiParent = this.MdiParent;
                frm.Show();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
                MessageBox.Show(ex.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (info == null)
                    MessageBox.Show("Seleccione un registro", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else if (info.Estado == "I")
                    MessageBox.Show("No se pueden modificar registros inactivos", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    frm = new frmImp_ordencompra_ext_Mantenimiento();
                    frm.Envet_frmImp_ordencompra_ext_Mantenimiento_FormClosing += new frmImp_ordencompra_ext_Mantenimiento.delegate_frmImp_ordencompra_ext_Mantenimiento_FormClosing(frm_Envet_frmImp_ordencompra_ext_Mantenimiento_FormClosing);
                    frm._infoset = info;
                    frm.MdiParent = this.MdiParent;
                    frm.setAccion(Info.General.Cl_Enumeradores.eTipo_action.actualizar);
                    frm.Show();
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                gridViewPedidos.ShowPrintPreview();
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
                frm = new frmImp_ordencompra_ext_Mantenimiento();
                frm.Envet_frmImp_ordencompra_ext_Mantenimiento_FormClosing += new frmImp_ordencompra_ext_Mantenimiento.delegate_frmImp_ordencompra_ext_Mantenimiento_FormClosing(frm_Envet_frmImp_ordencompra_ext_Mantenimiento_FormClosing);
                frm._infoset = info;
                frm.setAccion(Info.General.Cl_Enumeradores.eTipo_action.consultar);
                frm.MdiParent = this.MdiParent;
                frm.Show();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                gridControlOrdeCompra.DataSource = bus.Get_List_ordencompra_ext(param.IdEmpresa
                    , ucGe_Menu_Mantenimiento_x_usuario.getIdSucursal
                    , ucGe_Menu_Mantenimiento_x_usuario.fecha_desde
                    ,ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
                MessageBox.Show(ex.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frm = new frmImp_ordencompra_ext_Mantenimiento();
                frm.Envet_frmImp_ordencompra_ext_Mantenimiento_FormClosing += new frmImp_ordencompra_ext_Mantenimiento.delegate_frmImp_ordencompra_ext_Mantenimiento_FormClosing(frm_Envet_frmImp_ordencompra_ext_Mantenimiento_FormClosing);
                frm._infoset = info;
                frm.setAccion(Info.General.Cl_Enumeradores.eTipo_action.Anular);
                frm.MdiParent = this.MdiParent;
                frm.Show();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void frm_Envet_frmImp_ordencompra_ext_Mantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                 CargarGrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }
        imp_ordencompra_ext_Info info = new imp_ordencompra_ext_Info();
        imp_ordencompra_ext_Bus bus = new imp_ordencompra_ext_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_Sucursal_Bus BusSucursal = new tb_Sucursal_Bus();
        imp_catalogo_Bus ObusCatalogo = new imp_catalogo_Bus();
        frmImp_ordencompra_ext_Mantenimiento frm = new frmImp_ordencompra_ext_Mantenimiento();
        List<imp_catalogo_Info> ListCatalogo;
        
        private void frmImp_ordencompra_ext_Consulta_Load(object sender, EventArgs e)
        {
            try
            {
                
                CargarGrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
                MessageBox.Show(ex.ToString());
            }
        
        }
        public void CargarGrid()
        {

            try
            {
                var DataSource = bus.Get_List_ordencompra_ext(param.IdEmpresa
                    , ucGe_Menu_Mantenimiento_x_usuario.getIdSucursal
                    , ucGe_Menu_Mantenimiento_x_usuario.fecha_desde
                    , ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta);
                DataSource.ForEach(var => var.IdCicloImportacion = DescripcionCiclo(var.IdCicloImportacion));
                gridControlOrdeCompra.DataSource = DataSource;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
                MessageBox.Show(ex.ToString());
            }

        }
        string DescripcionCiclo(string IdCatalog) 
        {
            try
            {
                  return ListCatalogo.First(var => var.IdCatalogoImport == IdCatalog).Nombre;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return "";
                
                MessageBox.Show(ex.ToString());
            }
        
        }

        private imp_ordencompra_ext_Info GetSelectedRow(DevExpress.XtraGrid.Views.Grid.GridView view)
        {

            try
            {
                return (imp_ordencompra_ext_Info)view.GetRow(view.FocusedRowHandle);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return new imp_ordencompra_ext_Info();
            }
        }
        private void gridViewPedidos_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                info = GetSelectedRow((DevExpress.XtraGrid.Views.Grid.GridView)sender);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());

            }

        }



        private void gridViewPedidos_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridViewPedidos.GetRow(e.RowHandle) as imp_ordencompra_ext_Info;
                if (data == null)
                    return;
                if (data.Tipo_Importacion == "PROYECTADA")
                    e.Appearance.ForeColor = Color.LightSkyBlue;
                if (data.Estado == "I")
                    e.Appearance.ForeColor = Color.Red;
               
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

    }
}
