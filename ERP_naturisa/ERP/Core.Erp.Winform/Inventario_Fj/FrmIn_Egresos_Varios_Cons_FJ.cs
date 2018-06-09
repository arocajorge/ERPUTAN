using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.Inventario;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using Core.Erp.Winform.Inventario_Fj;
using Core.Erp.Winform.Inventario;

namespace Core.Erp.Winform.Inventario_Fj
{
    public partial class FrmIn_Egresos_Varios_Cons_FJ : Form
    {     
        List<in_Ing_Egr_Inven_Info> listEgresos;    
        in_Ing_Egr_Inven_Bus bus_IngEgr;   
        in_Ing_Egr_Inven_Info Info;
        FrmIn_Egresos_Varios_Mant_FJ frm;
       // Cl_Enumeradores.eTipo_action eAccion = new Cl_Enumeradores.eTipo_action();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus;

        DateTime fecha_desde;
        DateTime fecha_hasta;
        int IdSucursalIni = 0;
        int IdSucursalFin = 0;
        int IdBodegaIni = 0;
        int IdBodegaFin = 0;

        public FrmIn_Egresos_Varios_Cons_FJ()
        {
            InitializeComponent();

            ucGe_Menu_Mantenimiento_x_usuario.event_btnNuevo_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick;
            ucGe_Menu_Mantenimiento_x_usuario.event_btnModificar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick;
            ucGe_Menu_Mantenimiento_x_usuario.event_btnconsultar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick;
            ucGe_Menu_Mantenimiento_x_usuario.event_btnAnular_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick;
            ucGe_Menu_Mantenimiento_x_usuario.event_btnBuscar_Click += ucGe_Menu_Mantenimiento_x_usuario_event_btnBuscar_Click;
            ucGe_Menu_Mantenimiento_x_usuario.event_btnSalir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick;
            ucGe_Menu_Mantenimiento_x_usuario.event_btnImprimir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnImprimir_ItemClick;
        }

        private void FrmIn_Egresos_Varios_Cons_Load(object sender, EventArgs e)
        {
            try
            {
                IdSucursalIni = ucGe_Menu_Mantenimiento_x_usuario.getIdSucursal;
                if (IdSucursalIni == 0)
                {
                    IdSucursalIni = 1;
                    IdSucursalFin = 9999;
                    IdBodegaIni = 1;
                    IdBodegaFin = 9999;
                }
                else
                {
                    IdSucursalIni = ucGe_Menu_Mantenimiento_x_usuario.getIdSucursal;
                    IdSucursalFin = ucGe_Menu_Mantenimiento_x_usuario.getIdSucursal;
                    IdBodegaIni = ucGe_Menu_Mantenimiento_x_usuario.getIdBodega;
                    IdBodegaFin = ucGe_Menu_Mantenimiento_x_usuario.getIdBodega;
                }
                cargar_grid();
            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                gridControl_Egresos_Varios.ShowPrintPreview();
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
                IdSucursalIni = ucGe_Menu_Mantenimiento_x_usuario.getIdSucursal;
                if (IdSucursalIni == 0)
                {
                    IdSucursalIni = 1;
                    IdSucursalFin = 9999;
                    IdBodegaIni = 1;
                    IdBodegaFin = 9999;
                }
                else
                {
                    IdSucursalIni = ucGe_Menu_Mantenimiento_x_usuario.getIdSucursal;
                    IdSucursalFin = ucGe_Menu_Mantenimiento_x_usuario.getIdSucursal;
                    IdBodegaIni = ucGe_Menu_Mantenimiento_x_usuario.getIdBodega == 0 ? 1 : ucGe_Menu_Mantenimiento_x_usuario.getIdBodega;
                    IdBodegaFin = ucGe_Menu_Mantenimiento_x_usuario.getIdBodega == 0 ? 9999 : ucGe_Menu_Mantenimiento_x_usuario.getIdBodega;
                }                                      

                
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
                Info = (in_Ing_Egr_Inven_Info)gridView_Egreso_varios.GetFocusedRow();

                if (Info != null)
                {
                    if (Info.Estado == "I")
                    { MessageBox.Show("El registro ya se encuentra Anulado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; }
                    else
                    {

                        frm = new FrmIn_Egresos_Varios_Mant_FJ();
                        frm.Text = frm.Text + "***ANULAR REGISTRO***";
                        frm.setInfo_(Info);
                        frm.set_Accion(Cl_Enumeradores.eTipo_action.Anular);
                        frm.Show();
                        frm.MdiParent = this.MdiParent;
                     
                        frm.event_FrmIn_Egreso_varios_Mant_FormClosing += frm_event_FrmIn_Egreso_varios_Mant_FormClosing;
                        
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

        void frm_event_FrmIn_Egreso_varios_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                IdSucursalIni = ucGe_Menu_Mantenimiento_x_usuario.getIdSucursal;
                if (IdSucursalIni == 0)
                {
                    IdSucursalIni = 1;
                    IdSucursalFin = 9999;
                    IdBodegaIni = 1;
                    IdBodegaFin = 9999;
                }
                else
                {
                    IdSucursalIni = ucGe_Menu_Mantenimiento_x_usuario.getIdSucursal;
                    IdSucursalFin = ucGe_Menu_Mantenimiento_x_usuario.getIdSucursal;
                    IdBodegaIni = ucGe_Menu_Mantenimiento_x_usuario.getIdBodega;
                    IdBodegaFin = ucGe_Menu_Mantenimiento_x_usuario.getIdBodega;
                }

                cargar_grid();
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
                Info = (in_Ing_Egr_Inven_Info)gridView_Egreso_varios.GetFocusedRow();

                if (Info != null)
                {
                    frm= new FrmIn_Egresos_Varios_Mant_FJ();
                    frm.Text = frm.Text + "***CONSULTAR REGISTRO***";
                    frm.setInfo_(Info);
                    frm.set_Accion(Cl_Enumeradores.eTipo_action.consultar);
                    frm.Show();
                    frm.MdiParent = this.MdiParent;
                    frm.event_FrmIn_Egreso_varios_Mant_FormClosing += frm_event_FrmIn_Egreso_varios_Mant_FormClosing;

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
                Info = (in_Ing_Egr_Inven_Info)gridView_Egreso_varios.GetFocusedRow();

                if (Info != null)
                {
                    if (Info.Estado == "I")
                    { MessageBox.Show("No se pueden modificar registros inactivos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; }
                    else
                    {
                        if (Info.IdEstadoAproba == "PEND" || Info.IdEstadoAproba == null)
                        {
                            frm = new FrmIn_Egresos_Varios_Mant_FJ();
                            frm.Text = frm.Text + "***ACTUALIZAR REGISTRO***";
                            frm.set_Accion(Cl_Enumeradores.eTipo_action.actualizar);
                            frm.setInfo_(Info);
                            frm.Show();
                            frm.MdiParent = this.MdiParent;
                            frm.event_FrmIn_Egreso_varios_Mant_FormClosing += frm_event_FrmIn_Egreso_varios_Mant_FormClosing;
                        }
                        else
                            if (Info.IdEstadoAproba == "APRO")
                            { MessageBox.Show("No se pueden modificar registros aprobados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; }
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
                frm = new FrmIn_Egresos_Varios_Mant_FJ();
                frm.set_Accion(Cl_Enumeradores.eTipo_action.grabar);
                frm.Text = frm.Text + "*** NUEVO REGISTRO ***";
                frm.Show();
                frm.MdiParent = this.MdiParent;
                frm.event_FrmIn_Egreso_varios_Mant_FormClosing += frm_event_FrmIn_Egreso_varios_Mant_FormClosing;
                
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
                fecha_desde= ucGe_Menu_Mantenimiento_x_usuario.fecha_desde;
                fecha_hasta= ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta;
                listEgresos = new List<in_Ing_Egr_Inven_Info>();
                bus_IngEgr = new in_Ing_Egr_Inven_Bus();
                listEgresos = bus_IngEgr.Get_List_Ing_Egr_Inven(param.IdEmpresa, IdSucursalIni, IdSucursalFin, IdBodegaIni, IdBodegaFin, fecha_desde, fecha_hasta);

                var listaEgr = listEgresos.Where(q => q.signo == "-").ToList();
                gridControl_Egresos_Varios.DataSource = null;
                gridControl_Egresos_Varios.DataSource = listaEgr.ToList().OrderByDescending(x=> x.IdNumMovi);
            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridView_Egreso_varios_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridView_Egreso_varios.GetRow(e.RowHandle) as in_Ing_Egr_Inven_Info;
                if (data == null)
                    return;
                if (data.Estado == "I")
                    e.Appearance.ForeColor = Color.Red;
                else
                {
                    if (data.IdEstadoDespacho_cat == "EST_DES_DES")
                    {
                        e.Appearance.ForeColor = Color.DarkGreen;
                        return;
                    }

                    if (data.IdEstadoAproba == "APRO")
                        e.Appearance.ForeColor = Color.Blue;
                }
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
