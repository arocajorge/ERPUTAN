using Core.Erp.Business.General;
using Core.Erp.Business.Inventario_Fj;
using Core.Erp.Info.Inventario_Fj;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Core.Erp.Winform.Inventario_Fj
{
    public partial class FrmIn_Orden_servicio_x_Activo_fijo_Consulta : Form
    {
        List<in_Orden_servicio_x_Activo_fijo_Info> Lst_Orden_Servicio = new List<in_Orden_servicio_x_Activo_fijo_Info>();
        in_Orden_servicio_x_Activo_fijo_Info Orden_servicio_info = new in_Orden_servicio_x_Activo_fijo_Info();
        in_Orden_servicio_x_Activo_fijo_Bus Orden_Servicio_Bus = new in_Orden_servicio_x_Activo_fijo_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        string msg = "";

        public FrmIn_Orden_servicio_x_Activo_fijo_Consulta()
        {
            InitializeComponent();
            
        }

        private void FrmIn_Orden_servicio_x_Activo_fijo_Consulta_Load(object sender, EventArgs e)
        {
            try
            {
                CargarGrilla();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarGrilla()
        {
            try
            {
                Lst_Orden_Servicio = new List<in_Orden_servicio_x_Activo_fijo_Info>();
                Lst_Orden_Servicio = Orden_Servicio_Bus.Get_Lista_Vista(param.IdEmpresa, ref msg);
                gridControlConsulta.DataSource = Lst_Orden_Servicio;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_Mantenimiento_x_usuario1_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            try
            {
                Orden_servicio_info = (in_Orden_servicio_x_Activo_fijo_Info)gridViewConsulta.GetFocusedRow();
                if (Orden_servicio_info != null)
                {
                    if (Orden_servicio_info.Estado != "I")
                    {
                        FrmIn_Orden_servicio_x_Activo_fijo_Mantenimiento frm = new FrmIn_Orden_servicio_x_Activo_fijo_Mantenimiento(Info.General.Cl_Enumeradores.eTipo_action.Anular);
                        frm.Show(); frm.MdiParent = this.MdiParent;
                        frm.OS_Info = this.Orden_servicio_info;
                        frm.set_Accion(Info.General.Cl_Enumeradores.eTipo_action.Anular);
                        frm.Text = frm.Text + " ***ANULAR REGISTRO***";
                        frm.event_delegate_FrmIn_Orden_servicio_x_Activo_fijo_Mantenimiento_FormClosing += frm_event_delegate_FrmIn_Orden_servicio_x_Activo_fijo_Mantenimiento_FormClosing;
                    }
                    else
                        MessageBox.Show("El registro se encuentra anulado ", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else
                    MessageBox.Show("Seleccione un registro de la lista para continuar. ", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void ucGe_Menu_Mantenimiento_x_usuario1_event_btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                int idBodega = 0;
                int idSucursal = 0;
                int idBodegaFin = 0;
                int idSucursalFin = 0;
                DateTime FechaIni = DateTime.Now;
                DateTime FechaFin = DateTime.Now;
                in_Orden_servicio_x_Activo_fijo_Bus Bus = new in_Orden_servicio_x_Activo_fijo_Bus();


                idSucursal = ucGe_Menu_Mantenimiento_x_usuario1.getIdSucursal;
                idSucursalFin = ucGe_Menu_Mantenimiento_x_usuario1.getIdSucursal == 0 ? 9999 : ucGe_Menu_Mantenimiento_x_usuario1.getIdSucursal;
                idBodega = ucGe_Menu_Mantenimiento_x_usuario1.getIdBodega;
                idBodegaFin = ucGe_Menu_Mantenimiento_x_usuario1.getIdBodega == 0 ? 9999 : ucGe_Menu_Mantenimiento_x_usuario1.getIdBodega;
                FechaIni = ucGe_Menu_Mantenimiento_x_usuario1.fecha_desde;
                FechaFin = ucGe_Menu_Mantenimiento_x_usuario1.fecha_hasta;

                Lst_Orden_Servicio = Bus.Get_Lista_Vista_x_sucursal_x_bodega(param.IdEmpresa, idSucursal,idSucursalFin, idBodega,idBodegaFin,FechaIni,FechaFin, ref msg);
                gridControlConsulta.DataSource = Lst_Orden_Servicio;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_Mantenimiento_x_usuario1_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Orden_servicio_info = (in_Orden_servicio_x_Activo_fijo_Info)gridViewConsulta.GetFocusedRow();
                if (Orden_servicio_info != null)
                {
                    if (Orden_servicio_info.Estado != "I")
                    {
                        FrmIn_Orden_servicio_x_Activo_fijo_Mantenimiento frm = new FrmIn_Orden_servicio_x_Activo_fijo_Mantenimiento(Info.General.Cl_Enumeradores.eTipo_action.actualizar);
                        frm.Show(); frm.MdiParent = this.MdiParent;
                        frm.OS_Info = this.Orden_servicio_info;
                        frm.set_Accion(Info.General.Cl_Enumeradores.eTipo_action.actualizar);
                        frm.Text = frm.Text + " ***MODIFICAR REGISTRO***";
                        frm.event_delegate_FrmIn_Orden_servicio_x_Activo_fijo_Mantenimiento_FormClosing += frm_event_delegate_FrmIn_Orden_servicio_x_Activo_fijo_Mantenimiento_FormClosing;
                    }
                    else
                        MessageBox.Show("El registro se encuentra anulado y no puede ser modificado. ", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else
                    MessageBox.Show("Seleccione un registro de la lista para continuar. ", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

       }

        private void ucGe_Menu_Mantenimiento_x_usuario1_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                FrmIn_Orden_servicio_x_Activo_fijo_Mantenimiento frm = new FrmIn_Orden_servicio_x_Activo_fijo_Mantenimiento(Info.General.Cl_Enumeradores.eTipo_action.grabar);
                frm.Show(); frm.MdiParent = this.MdiParent;
                frm.set_Accion(Info.General.Cl_Enumeradores.eTipo_action.grabar);
                frm.Text = frm.Text + " ***NUEVO REGISTRO***";
                frm.event_delegate_FrmIn_Orden_servicio_x_Activo_fijo_Mantenimiento_FormClosing += frm_event_delegate_FrmIn_Orden_servicio_x_Activo_fijo_Mantenimiento_FormClosing;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void frm_event_delegate_FrmIn_Orden_servicio_x_Activo_fijo_Mantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                CargarGrilla();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }

        

        private void ucGe_Menu_Mantenimiento_x_usuario1_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                gridViewConsulta.ShowPrintPreview();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_Mantenimiento_x_usuario1_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Orden_servicio_info = (in_Orden_servicio_x_Activo_fijo_Info)gridViewConsulta.GetFocusedRow();
                if (Orden_servicio_info != null)
                {

                    FrmIn_Orden_servicio_x_Activo_fijo_Mantenimiento frm = new FrmIn_Orden_servicio_x_Activo_fijo_Mantenimiento(Info.General.Cl_Enumeradores.eTipo_action.consultar);
                    frm.Show(); frm.MdiParent = this.MdiParent;
                    frm.OS_Info = this.Orden_servicio_info;
                    frm.set_Accion(Info.General.Cl_Enumeradores.eTipo_action.consultar);
                    frm.Text = frm.Text + " ***CONSULTAR REGISTRO***";
                    frm.event_delegate_FrmIn_Orden_servicio_x_Activo_fijo_Mantenimiento_FormClosing += frm_event_delegate_FrmIn_Orden_servicio_x_Activo_fijo_Mantenimiento_FormClosing;

                }
                else
                    MessageBox.Show("Seleccione un registro de la lista para continuar. ", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewConsulta_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridViewConsulta.GetRow(e.RowHandle) as in_Orden_servicio_x_Activo_fijo_Info;
                if (data == null)
                    return;
                if (data.Estado == "I" )
                    e.Appearance.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
