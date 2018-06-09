
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.Roles;
using Core.Erp.Info.Roles;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Winform.General;
using Core.Erp.Recursos.Properties;

namespace Core.Erp.Winform.Roles
{
    public partial class frmRo_Solicitud_Vacaciones_Cons : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        ro_SolicitudVacaciones_Info info = new ro_SolicitudVacaciones_Info();
        BindingList<ro_SolicitudVacaciones_Info> DataSource = new BindingList<ro_SolicitudVacaciones_Info>();

        frmRo_Solicitud_Vacaciones_Mant vacacionesMant = new frmRo_Solicitud_Vacaciones_Mant();

        ro_SolicitudVacaciones_Bus solicitudBus = new ro_SolicitudVacaciones_Bus();

        ro_historico_vacaciones_x_empleado_Bus oRo_historico_vacaciones_x_empleado_Bus = new ro_historico_vacaciones_x_empleado_Bus();
        BindingList<ro_historico_vacaciones_x_empleado_Info> RoHistoricoVacaInfoLst = new BindingList<ro_historico_vacaciones_x_empleado_Info>();


        string mensaje = "";

        public frmRo_Solicitud_Vacaciones_Cons()
        {
            try
            {
               InitializeComponent();
               ucGe_Menu_Mantenimiento_x_usuario.event_btnAnular_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick;
               ucGe_Menu_Mantenimiento_x_usuario.event_btnconsultar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick;
             //  ucGe_Menu_Mantenimiento_x_usuario.event_btnImprimir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnImprimir_ItemClick;
               ucGe_Menu_Mantenimiento_x_usuario.event_btnModificar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick;
               ucGe_Menu_Mantenimiento_x_usuario.event_btnNuevo_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick;
               ucGe_Menu_Mantenimiento_x_usuario.event_btnSalir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
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
                MessageBox.Show(ex.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                llama_frm(Cl_Enumeradores.eTipo_action.grabar);
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
                if (info.Estado == "I")
                {
                    MessageBox.Show("El Registro Seleccionado Esta anulado y No Puede ser Modificado", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                else
                {
                    llama_frm(Cl_Enumeradores.eTipo_action.actualizar);
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

       

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                llama_frm(Cl_Enumeradores.eTipo_action.consultar);
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
                if (info.IdSolicitudVaca == 0)
                {
                    MessageBox.Show("Debe seleccionar una fila, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                if (info.Estado == "I")
                {
                    MessageBox.Show("La Solicitud No. " + info.IdSolicitudVaca + " ya se encuentra ANULADA:", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                else
                {
                    if (info.IdEstadoAprobacion == "Aprobado")
                    {
                        MessageBox.Show("La Solicitud No. " + info.IdSolicitudVaca + " se encuentra en estado APROBADO,\n por lo tanto no se puede anular", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {


                        if (MessageBox.Show("¿Está seguro que desea anular la Solicitud No. " + info.IdSolicitudVaca + " ? ", "Anulación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            pu_AnularSolicitud();
                            int id = 0;

                            if (solicitudBus.GrabarBD(info,ref id, ref mensaje))
                            {
                                MessageBox.Show(Resources.msgConfirmaAnulacionOk, Resources.msgTituloAnular, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                pu_Cargar();
                            }
                            else
                                MessageBox.Show("El registro no ha sido anulado, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                       
                    }
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        private void llama_frm(Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {
                vacacionesMant = new frmRo_Solicitud_Vacaciones_Mant();
                vacacionesMant.event_frmRo_Solicitud_Vacaciones_Mant_FormClosing += new frmRo_Solicitud_Vacaciones_Mant.delegate_frmRo_Solicitud_Vacaciones_Mant_FormClosing(frm_event_frmRo_Solicitud_Vacaciones_Mant_FormClosing);

                if (Accion != Cl_Enumeradores.eTipo_action.grabar)
                {
                    vacacionesMant.setInfo(info);
                }

                vacacionesMant.set_Accion(Accion);
                vacacionesMant.ShowDialog();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        private void frm_event_frmRo_Solicitud_Vacaciones_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                pu_Cargar();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }

        }

        private void frmRo_Solicitud_Vacaciones_Cons_Load(object sender, EventArgs e)
        {
            try
            {
                pu_Cargar();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }

        }

        void pu_Cargar() 
        {
            try
            {
                DataSource = new BindingList<ro_SolicitudVacaciones_Info>(solicitudBus.ConsultaPermisosVacaciones(param.IdEmpresa,ucGe_Menu_Mantenimiento_x_usuario.fecha_desde,ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta));
                gridControlVacaciones.DataSource = DataSource;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
            
        }

       


        private Boolean pu_AnularSolicitud()
        {
            try
            {
                Boolean valorRetornar=false;
                int id = 0;

                if (info != null)
                {
                    // Motivo por Anulación
                    string motiAnulacion = "";
                    FrmGe_MotivoAnulacion fr = new FrmGe_MotivoAnulacion();
                    fr.ShowDialog();
                    motiAnulacion = fr.motivoAnulacion;
                    info.MotivoAnulacion = motiAnulacion;
                    info.Observacion = motiAnulacion;
                    info.FechaAnulacion = param.Fecha_Transac;
                    info.IdUsuario_Anu = param.IdUsuario;
                    info.ip = param.ip;
                    info.nom_pc = param.nom_pc;
                    info.IdEstadoAprobacion = "Negado";
                    info.Estado = "I";

                    //REVERTIR EL SALDO DE DIAS TOMADOS
                    RoHistoricoVacaInfoLst = new BindingList<ro_historico_vacaciones_x_empleado_Info>(oRo_historico_vacaciones_x_empleado_Bus.pu_RevertirVacaciones(info.IdEmpresa,info.IdEmpleado, Convert.ToInt32(info.Dias_a_disfrutar)));

                    //GRABA LA SOLICITUD 
                    if(solicitudBus.GrabarBD(info,ref id, ref mensaje)){
                        foreach (ro_historico_vacaciones_x_empleado_Info item in RoHistoricoVacaInfoLst)
                        {
                            if(!oRo_historico_vacaciones_x_empleado_Bus.GrabarBD(item, ref id, ref mensaje)){
                            valorRetornar=false; break;
                            }
                        }

                    }
                }

                return valorRetornar;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
                return false;
            }
        }

  

       

        private void ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        private void ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void gridViewVacaciones_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        private void gridViewVacaciones_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {

                var data = gridViewVacaciones.GetRow(e.RowHandle) as ro_SolicitudVacaciones_Info;
                if (data == null)
                    return;
                if (data.Estado == "I")
                    e.Appearance.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }



        }

        private void gridViewVacaciones_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                info = new ro_SolicitudVacaciones_Info();
                info = (ro_SolicitudVacaciones_Info)gridViewVacaciones.GetFocusedRow();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        private void ucGe_Menu_Mantenimiento_x_usuario_event_btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                pu_Cargar();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
