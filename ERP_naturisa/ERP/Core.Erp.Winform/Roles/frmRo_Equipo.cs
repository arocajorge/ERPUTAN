using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.Roles;
using Core.Erp.Business.Roles;
using Core.Erp.Info.General;
using Core.Erp.Business.General;

namespace Core.Erp.Winform.Roles
{
    public partial class frmRo_Equipo : Form
    {

        #region Declaración de Variables
        ro_marcaciones_Equipo_Info Info = new ro_marcaciones_Equipo_Info();
        ro_marcaciones_Equipo_Bus ro_MarEquipoBus = new ro_marcaciones_Equipo_Bus();
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        frmRo_Equipos_Mantenimiento frm;
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        #endregion

        public frmRo_Equipo()
        {
            try
            {
                InitializeComponent();
                gridControlMarcacionesEquipos.DataSource = ro_MarEquipoBus.Get_List_marcaciones_Equipo(param.IdEmpresa,param.IdSucursal);
                ucGe_Menu_Mantenimiento_x_usuario.event_btnNuevo_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnModificar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnconsultar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnAnular_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnSalir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
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
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                preparar_formulario(Cl_Enumeradores.eTipo_action.Anular);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                preparar_formulario(Cl_Enumeradores.eTipo_action.consultar);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                preparar_formulario(Cl_Enumeradores.eTipo_action.actualizar);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
            
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                preparar_formulario(Cl_Enumeradores.eTipo_action.grabar);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void frmMarcacionesEquiMant_Event_frmRo_Marcaciones_Equipos_Mantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
               
                gridControlMarcacionesEquipos.DataSource = ro_MarEquipoBus.Get_List_marcaciones_Equipo(param.IdSucursal,param.IdSucursal);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void cargarInfo()
        {
            try
            {
                var info = (ro_marcaciones_Equipo_Info)gridViewEquipos.GetFocusedRow();
                if (info != null)
                {
                    Info.IdEquipoMar = info.IdEquipoMar;
                    Info.Nombre_Equipo = info.Nombre_Equipo;
                    Info.Modelo_Equipo = info.Modelo_Equipo;
                    Info.CadenaConexion = info.CadenaConexion;
                    Info.Tabla_Vista = info.Tabla_Vista;
                    Info.FormatoFecha = info.FormatoFecha;
                    Info.FormatoHora = info.FormatoHora;
                    Info.TipoBd = info.TipoBd;
                    Info.FechaUltimaImportacionMarcaiones = info.FechaUltimaImportacionMarcaiones;
                    Info.Estado = info.Estado;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void gridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridViewEquipos.GetRow(e.RowHandle) as ro_marcaciones_Equipo_Info;
                if (data == null)
                    return;
                if (data.Estado == "I")
                    e.Appearance.ForeColor = Color.Red;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void preparar_formulario(Cl_Enumeradores.eTipo_action _Accion)
        {
            try
            {
                Info = (ro_marcaciones_Equipo_Info)gridViewEquipos.GetFocusedRow();
                frm = new frmRo_Equipos_Mantenimiento();
                if (_Accion == Cl_Enumeradores.eTipo_action.actualizar || _Accion == Cl_Enumeradores.eTipo_action.consultar || _Accion == Cl_Enumeradores.eTipo_action.Anular)
                {
                    if (Info.IdEquipoMar == 0)
                    {
                        MessageBox.Show("Seleccione una fila", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    frm.set_Info(Info);
                }
                if (_Accion == Cl_Enumeradores.eTipo_action.Anular)
                {
                    if (Info.Estado == "I")
                    {
                        MessageBox.Show("El departamento ya fue anulado", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;

                    }
                    frm.set_Info(Info);
                }
                frm.set_Accion(_Accion);
                frm.Event_frmRo_Marcaciones_Equipos_Mantenimiento_FormClosing += frm_Event_frmRo_Marcaciones_Equipos_Mantenimiento_FormClosing;
                frm.ShowDialog();

            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
            
        }

        void frm_Event_frmRo_Marcaciones_Equipos_Mantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                gridControlMarcacionesEquipos.DataSource = ro_MarEquipoBus.Get_List_marcaciones_Equipo(param.IdEmpresa,param.IdSucursal);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void ucGe_Menu_Mantenimiento_x_usuario_Load(object sender, EventArgs e)
        {
            try
            {
               cargarInfo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
    }
}

