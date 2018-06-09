using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.Inventario;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.General;
using Core.Erp.Info.General;

namespace Core.Erp.Winform.Inventario
{
    public partial class FrmIn_Egresos_Inv_Multi_Bodega_Cons : Form
    {
        List<in_Ing_Egr_Inven_Info> listEgresos ;
        in_Ing_Egr_Inven_Bus bus_IngEgr ;
        in_Ing_Egr_Inven_Info Info ;
        FrmIn_Egresos_Inv_Multi_Bodega_Mant frm ;      
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus ;
       
        public FrmIn_Egresos_Inv_Multi_Bodega_Cons()
        {
            InitializeComponent();

            ucGe_Menu.event_btnNuevo_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick;
            ucGe_Menu.event_btnModificar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick;
            ucGe_Menu.event_btnconsultar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick;
            ucGe_Menu.event_btnAnular_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick;
            ucGe_Menu.event_btnBuscar_Click += ucGe_Menu_Mantenimiento_x_usuario_event_btnBuscar_Click;
            ucGe_Menu.event_btnSalir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick;
            ucGe_Menu.event_btnImprimir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnImprimir_ItemClick;
        }
                     
        void ucGe_Menu_Mantenimiento_x_usuario_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                gridControlMovi_Inv_Egre.ShowPrintPreview();
            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
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
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                cargar_grid();
            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Info = new in_Ing_Egr_Inven_Info();
                Info = (in_Ing_Egr_Inven_Info)gridViewMovi_Inv_Egre.GetFocusedRow();

                if (Info != null)
                {
                    if (Info.Estado == "I")
                    { MessageBox.Show("El registro ya se encuentra Anulado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; }
                    else
                    {
                        if (Info.IdEstadoAproba == "APRO")
                        {
                            MessageBox.Show("El registro no se puede anular ya se encuentra Aprobado", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }

                        frm = new FrmIn_Egresos_Inv_Multi_Bodega_Mant();
                        frm.Text = frm.Text + "***ANULAR REGISTRO***";
                        frm.info_IngEgr = Info;
                        frm.set_Accion(Cl_Enumeradores.eTipo_action.Anular);
                        frm.Show();
                        frm.MdiParent = this.MdiParent;
                        frm.event_FrmIn_Egresos_Inv_Multi_Bodega_Mant_FormClosing += frm_event_FrmIn_Egresos_Inv_Multi_Bodega_Mant_FormClosing;
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione un Registro a Anular", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Info = new in_Ing_Egr_Inven_Info();
                Info = (in_Ing_Egr_Inven_Info)gridViewMovi_Inv_Egre.GetFocusedRow();

                if (Info != null)
                {
                    frm = new FrmIn_Egresos_Inv_Multi_Bodega_Mant();
                    frm.Text = frm.Text + "***CONSULTAR REGISTRO***";
                    frm.info_IngEgr = Info;
                    frm.set_Accion(Cl_Enumeradores.eTipo_action.consultar);
                    frm.Show();
                    frm.MdiParent = this.MdiParent;
                    frm.event_FrmIn_Egresos_Inv_Multi_Bodega_Mant_FormClosing+=frm_event_FrmIn_Egresos_Inv_Multi_Bodega_Mant_FormClosing;
                }
                else
                {
                    MessageBox.Show("Seleccione un Registro a Mostrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Info = new in_Ing_Egr_Inven_Info();
                Info = (in_Ing_Egr_Inven_Info)gridViewMovi_Inv_Egre.GetFocusedRow();

                if (Info != null)
                {
                    if (Info.Estado == "I")
                    { MessageBox.Show("No se pueden modificar registros inactivos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; }
                    else
                    {
                        if (Info.IdEstadoAproba == "APRO")
                        { MessageBox.Show("El registro ya se encuentra Aprobado y no se puede modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; }

                        frm = new FrmIn_Egresos_Inv_Multi_Bodega_Mant();
                        frm.Text = frm.Text + "***ACTUALIZAR REGISTRO***";
                        frm.set_Accion(Cl_Enumeradores.eTipo_action.actualizar);
                        frm.info_IngEgr = Info;
                        frm.Show();
                        frm.MdiParent = this.MdiParent;
                        frm.event_FrmIn_Egresos_Inv_Multi_Bodega_Mant_FormClosing += frm_event_FrmIn_Egresos_Inv_Multi_Bodega_Mant_FormClosing;
                    }             
                }
                else
                {
                    MessageBox.Show("Seleccione un Registro a Modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }          
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frm = new FrmIn_Egresos_Inv_Multi_Bodega_Mant();
                frm.set_Accion(Cl_Enumeradores.eTipo_action.grabar);
                frm.Text = frm.Text + "*** NUEVO REGISTRO ***";
                frm.Show();
                frm.MdiParent = this.MdiParent;
                frm.event_FrmIn_Egresos_Inv_Multi_Bodega_Mant_FormClosing += frm_event_FrmIn_Egresos_Inv_Multi_Bodega_Mant_FormClosing;
                
            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
        }

        void frm_event_FrmIn_Egresos_Inv_Multi_Bodega_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                cargar_grid();
            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }
    
        private void cargar_grid()
        {
            try
            {
                DateTime fecha_desde;
                DateTime fecha_hasta;
                int IdSucursalIni = 0;
                int IdSucursalFin = 0;
                
                fecha_desde= ucGe_Menu.fecha_desde;
                fecha_hasta = ucGe_Menu.fecha_hasta;
                IdSucursalIni = (ucGe_Menu.getIdSucursal == 0) ? 0 : ucGe_Menu.getIdSucursal;
                IdSucursalFin = (ucGe_Menu.getIdSucursal == 0) ? 99999 : ucGe_Menu.getIdSucursal;
                
                listEgresos = new List<in_Ing_Egr_Inven_Info>();
                bus_IngEgr = new in_Ing_Egr_Inven_Bus();
                listEgresos = bus_IngEgr.Get_List_Ing_Egr_Inven_multi_bodega(param.IdEmpresa, IdSucursalIni, IdSucursalFin, fecha_desde, fecha_hasta, "-");
               
                gridControlMovi_Inv_Egre.DataSource = listEgresos.ToList().OrderByDescending(x=> x.IdNumMovi);               
            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewMovi_Inv_Egre_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
           
        }

        private void FrmIn_Egresos_Inv_Multi_Bodega_Cons_Load(object sender, EventArgs e)
        {
            try
            {
                cargar_grid();
            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewMovi_Inv_Egre_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            try
            {
                var data = gridViewMovi_Inv_Egre.GetRow(e.RowHandle) as in_Ing_Egr_Inven_Info;
                if (data == null)
                    return;
                if (data.Estado == "I")
                    e.Appearance.ForeColor = Color.Red;
                else
                    if (data.IdEstadoAproba == "APRO")
                        e.Appearance.ForeColor = Color.Blue;

            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
