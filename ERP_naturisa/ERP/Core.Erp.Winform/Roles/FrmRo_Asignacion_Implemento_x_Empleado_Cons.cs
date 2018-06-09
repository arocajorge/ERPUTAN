using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Info.Roles;
using Core.Erp.Business.Roles;
using Core.Erp.Business.General;
using Core.Erp.Info.General;

namespace Core.Erp.Winform.Roles
{
    public partial class FrmRo_Asignacion_Implemento_x_Empleado_Cons : Form
    {
        #region Atributos y variables
        List<ro_Asignacion_Implemento_x_Empleado_Info> Lst_Asignacion = new List<ro_Asignacion_Implemento_x_Empleado_Info>();
        ro_Asignacion_Implemento_x_Empleado_Info Asignacion_Info = new ro_Asignacion_Implemento_x_Empleado_Info();
        ro_Asignacion_Implemento_x_Empleado_Bus Asignacion_Bus = new ro_Asignacion_Implemento_x_Empleado_Bus();
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        
        #endregion

        public FrmRo_Asignacion_Implemento_x_Empleado_Cons()
        {
            InitializeComponent();
            ucGe_Menu_Mantenimiento_x_usuario1.event_btnAnular_ItemClick += ucGe_Menu_Mantenimiento_x_usuario1_event_btnAnular_ItemClick;
            ucGe_Menu_Mantenimiento_x_usuario1.event_btnBuscar_Click += ucGe_Menu_Mantenimiento_x_usuario1_event_btnBuscar_Click;
            ucGe_Menu_Mantenimiento_x_usuario1.event_btnImprimir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario1_event_btnImprimir_ItemClick;
            ucGe_Menu_Mantenimiento_x_usuario1.event_btnNuevo_ItemClick += ucGe_Menu_Mantenimiento_x_usuario1_event_btnNuevo_ItemClick;
            ucGe_Menu_Mantenimiento_x_usuario1.event_btnModificar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario1_event_btnModificar_ItemClick;
            ucGe_Menu_Mantenimiento_x_usuario1.event_btnconsultar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario1_event_btnconsultar_ItemClick;
            
        }

        void ucGe_Menu_Mantenimiento_x_usuario1_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Cargar_Formulario(Cl_Enumeradores.eTipo_action.consultar);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario1_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Cargar_Formulario(Cl_Enumeradores.eTipo_action.actualizar);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario1_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Cargar_Formulario(Cl_Enumeradores.eTipo_action.grabar);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario1_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                gridControlAsignacion.ShowPrintPreview();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario1_event_btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime FechaIni = DateTime.Now;
                DateTime FechaFin = DateTime.Now;

                FechaIni = ucGe_Menu_Mantenimiento_x_usuario1.fecha_desde;
                FechaFin = ucGe_Menu_Mantenimiento_x_usuario1.fecha_hasta;

                Lst_Asignacion = Asignacion_Bus.Get_Lista_Vista_x_Fecha(param.IdEmpresa, FechaIni, FechaFin);
                gridControlAsignacion.DataSource = Lst_Asignacion;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario1_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Cargar_Formulario(Cl_Enumeradores.eTipo_action.Anular);
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
                Lst_Asignacion = Asignacion_Bus.Get_Lista_Vista_x_Fecha(param.IdEmpresa,ucGe_Menu_Mantenimiento_x_usuario1.fecha_desde,ucGe_Menu_Mantenimiento_x_usuario1.fecha_hasta);
                gridControlAsignacion.DataSource = Lst_Asignacion;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmRo_Asignacion_Implemento_x_Empleado_Cons_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void Cargar_Formulario(Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {
                FrmRo_Asignacion_Implemento_x_Empleado_Mant frm = new FrmRo_Asignacion_Implemento_x_Empleado_Mant();

                if (Accion != Cl_Enumeradores.eTipo_action.grabar)
                {
                    if (Asignacion_Info != null)
                    {
                        frm.SetAccion(Accion);
                        frm.Show();
                        frm.Set_Info(Asignacion_Info);
                        frm.event_FrmRo_Asignacion_Implemento_x_Empleado_FormClosing += frm_event_FrmRo_Asignacion_Implemento_x_Empleado_FormClosing;
                    }
                    else
                    {
                        MessageBox.Show("Seleccione un registro de la lista",param.Nombre_sistema,MessageBoxButtons.OK);
                    }
                    
                }
                else
                {
                    frm.SetAccion(Accion);
                    frm.Show();
                    frm.event_FrmRo_Asignacion_Implemento_x_Empleado_FormClosing += frm_event_FrmRo_Asignacion_Implemento_x_Empleado_FormClosing;
                }
                

                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void frm_event_FrmRo_Asignacion_Implemento_x_Empleado_FormClosing(object sender, FormClosingEventArgs e)
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

        private void gridViewAsignacion_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                Asignacion_Info = (ro_Asignacion_Implemento_x_Empleado_Info)gridViewAsignacion.GetFocusedRow();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewAsignacion_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridViewAsignacion.GetRow(e.RowHandle) as ro_Asignacion_Implemento_x_Empleado_Info;
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

        private void ucGe_Menu_Mantenimiento_x_usuario1_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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
    }
}
