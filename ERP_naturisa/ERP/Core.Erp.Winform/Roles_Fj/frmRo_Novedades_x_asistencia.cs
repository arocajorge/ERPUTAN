using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Business.Roles_Fj;
using Core.Erp.Info.Roles_Fj;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Info.Roles;
using Core.Erp.Business.Roles;
using Core.Erp.Winform.Roles;
namespace Core.Erp.Winform.Roles_Fj
{
    public partial class frmRo_Novedades_x_asistencia : Form
    {
        public frmRo_Novedades_x_asistencia()
        {
            InitializeComponent();
        }
        #region clases
        List<ro_marcaciones_x_empleado_x_incidentes_falt_Perm_Info> lista_empleado_novedad_x_ingreso = new List<ro_marcaciones_x_empleado_x_incidentes_falt_Perm_Info>();
        ro_marcaciones_x_empleado_x_incidentes_falt_Perm_Bus bus_novedades_x_ingreso = new ro_marcaciones_x_empleado_x_incidentes_falt_Perm_Bus();

        BindingList<ro_empleado_Novedad_x_horasExtras_Pendiente_Aprobar_Info> lista_horas_extras_pendiente_aprobar = new BindingList<ro_empleado_Novedad_x_horasExtras_Pendiente_Aprobar_Info>();
        ro_empleado_Novedad_x_horasExtras_Pendiente_Aprobar_Bus bus_hpras_extras_pendientes_aprobar = new ro_empleado_Novedad_x_horasExtras_Pendiente_Aprobar_Bus();

        List<ro_Catalogo_Info> lista_Catalogo = new List<ro_Catalogo_Info>();
        ro_Catalogo_Bus bus_catalo = new ro_Catalogo_Bus();
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;


        ro_Nomina_Tipo_Bus oRo_Nomina_Tipo_Bus = new ro_Nomina_Tipo_Bus();
        ro_Nomina_Tipoliqui_Bus nominatipo_Bus = new ro_Nomina_Tipoliqui_Bus();
        ro_periodo_x_ro_Nomina_TipoLiqui_Bus periodo_nomina_bus = new ro_periodo_x_ro_Nomina_TipoLiqui_Bus();

        List<ro_Nomina_Tipo_Info> listadoNomina = new System.Collections.Generic.List<ro_Nomina_Tipo_Info>();
        List<ro_Nomina_Tipoliqui_Info> ListadoTipoLiquidacion = new System.Collections.Generic.List<ro_Nomina_Tipoliqui_Info>();
        List<ro_periodo_x_ro_Nomina_TipoLiqui_Info> listadoPeriodo = new System.Collections.Generic.List<ro_periodo_x_ro_Nomina_TipoLiqui_Info>();

        ro_periodo_x_ro_Nomina_TipoLiqui_Info Info_Periodo =new ro_periodo_x_ro_Nomina_TipoLiqui_Info();

        #endregion

      
        private void frmRo_Novedades_x_asistencia_Load(object sender, EventArgs e)
        {
            try
            {
                Cargar_Datos();
                dtFechaInicio.EditValue = DateTime.Now.AddMonths(-1);
                dtFechaSalida.EditValue = DateTime.Now;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());

            }
        }

        public void Cargar_Datos()
        {
            try
            {
                lista_Catalogo = bus_catalo.Get_List_Catalogo_x_Tipo(37);
                cmb_catalogo.DataSource = lista_Catalogo;
                cmb_catalogo.ValueMember = "CodCatalogo";
                cmb_catalogo.DisplayMember = "ca_descripcion";


                listadoNomina = oRo_Nomina_Tipo_Bus.Get_List_Nomina_Tipo(param.IdEmpresa);
                cmbnomina.Properties.DataSource = listadoNomina;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
  
            }
        }

        private void Cmb_buscar_Click(object sender, EventArgs e)
        {

            try
            {
                lista_empleado_novedad_x_ingreso = bus_novedades_x_ingreso.lista_atrasos_faltas_x_empleado(param.IdEmpresa, Convert.ToDateTime(dtFechaInicio.EditValue), Convert.ToDateTime(dtFechaSalida.EditValue));
                gridControl_novedades_x_asistencia.DataSource = lista_empleado_novedad_x_ingreso;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());

            }
        }

        private void gridView__novedades_x_asistencia_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                if (e.Column.Name == "col_imagen")
                {
                    ro_marcaciones_x_empleado_x_incidentes_falt_Perm_Info info = new ro_marcaciones_x_empleado_x_incidentes_falt_Perm_Info();
                    info = (ro_marcaciones_x_empleado_x_incidentes_falt_Perm_Info)gridView__novedades_x_asistencia.GetFocusedRow();
                    if (info != null)
                    {
                        // SI ES PERMISO
                        if (info.Id_catalogo_Cat == "PER")
                        {
                            frmRo_Permisos_x_Empleado_Mant frm = new frmRo_Permisos_x_Empleado_Mant();
                            frm.setAccion(Cl_Enumeradores.eTipo_action.grabar);                           
                            frm.set_IdEmpleado(Convert.ToInt32(info.IdEmpleado));
                            frm.Show();
                        }

                        // SI ES ATRAZO


                        if (info.Id_catalogo_Cat == "ATRA")
                        {
                            frmRo_Empleado_Novedad_Mant frm = new frmRo_Empleado_Novedad_Mant();
                            frm.set_Accion(Cl_Enumeradores.eTipo_action.grabar);
                            frm.SetEmpleado(1, Convert.ToInt32(info.IdEmpleado));
                            frm.ShowDialog();

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                
               
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void cmb_buscar_novedads_x_HE_Click(object sender, EventArgs e)
        {
            try
            {
                Buscar_novedades_x_HE_pendientes();
             }
            catch (Exception ex)
            {
                
               
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void checkSeleccionar_CheckedChanged(object sender, EventArgs e)
        {
            try
            {

                foreach (var item in lista_horas_extras_pendiente_aprobar)
                {
                    if (checkSeleccionar.Checked == true)
                    {
                        item.Estado_aprobacion = true;
                    }
                    else
                    {
                        item.Estado_aprobacion = false;
                    }

                }
                gridControl_novedades_xHE.RefreshDataSource();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void cmb_aprobar_horasExtras_Click(object sender, EventArgs e)
        {
            try
            {
                Get();
                if (!Validar())
                    return;
                bus_hpras_extras_pendientes_aprobar.GuardarNovedad(lista_horas_extras_pendiente_aprobar.Where(v=>v.Estado_aprobacion==true).ToList());
                Buscar_novedades_x_HE_pendientes();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }



        public void Buscar_novedades_x_HE_pendientes()
        {
            try
            {
                lista_horas_extras_pendiente_aprobar = new BindingList<ro_empleado_Novedad_x_horasExtras_Pendiente_Aprobar_Info>( bus_hpras_extras_pendientes_aprobar.Get_lista_horas_extras_x_aproba(param.IdEmpresa,Convert.ToDateTime( dtp_Fecha_inicio_buscar_novedades.EditValue),Convert.ToDateTime( dtp_fecha_fin_buscar_novedades.EditValue)));
                gridControl_novedades_xHE.DataSource = lista_horas_extras_pendiente_aprobar;
     

            }
            catch (Exception ex)
            {


                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
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

        private void gridView__novedades_x_asistencia_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
              //Col_Id_catalogo_Cat

            try
            {
                var data = gridView__novedades_x_asistencia.GetRow(e.RowHandle) as ro_marcaciones_x_empleado_x_incidentes_falt_Perm_Info;
                if (data == null)
                    return;
                if (data.Id_catalogo_Cat == "ASIST")
                    e.Appearance.ForeColor = Color.Black;

                if (data.Id_catalogo_Cat == "FAL")
                    e.Appearance.ForeColor = Color.Red;

                if (data.Id_catalogo_Cat == "PER")
                    e.Appearance.ForeColor = Color.Blue;

                if (data.Id_catalogo_Cat == "VACA")
                    e.Appearance.ForeColor = Color.DarkOrange;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void cmbnomina_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                ListadoTipoLiquidacion = nominatipo_Bus.Get_List_Nomina_Tipoliqui_x_Nomina_Tipo(param.IdEmpresa, Convert.ToInt32(cmbnomina.EditValue));
                cmbnominaTipo.Properties.DataSource = ListadoTipoLiquidacion;

            }
            catch (System.Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void cmbnominaTipo_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                listadoPeriodo = periodo_nomina_bus.ConsultaPerNomTipLiq(param.IdEmpresa, Convert.ToInt32(cmbnomina.EditValue), Convert.ToInt32(cmbnominaTipo.EditValue));
                cmbPeriodos.Properties.DataSource = listadoPeriodo.Where(v => v.Cerrado == "N" && v.Contabilizado == "N").ToList();
            }
            catch (System.Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }


        private bool Validar()
        {
            try
            {
                bool bandera = true;
                if (cmbnomina.EditValue == null)
                {
                    MessageBox.Show("Selecciona Nomina", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                     bandera = true;

                }

                if (cmbnominaTipo.EditValue == null)
                {
                    MessageBox.Show("Selecciona el proceso", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bandera = true;

                }

                if (cmbPeriodos.EditValue == null)
                {
                    MessageBox.Show("Selecciona el periodo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bandera = true;

                }

                return bandera;
            }
            catch (System.Exception ex)
            {

                MessageBox.Show(ex.ToString());

                return false;
            }
        }

        private void cmbPeriodos_EditValueChanged(object sender, EventArgs e)
        {

            try
            {
                Info_Periodo = (ro_periodo_x_ro_Nomina_TipoLiqui_Info)cmbPeriodos.Properties.View.GetFocusedRow();
            }
            catch (System.Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }


        private void Get()
        {
            foreach (var item in lista_horas_extras_pendiente_aprobar)
            {
                if (item.Estado_aprobacion == true)
                {
                    item.IdNomina = Convert.ToInt32(cmbnominaTipo.EditValue);
                    item.IdNomina_tipo = Convert.ToInt32(cmbnominaTipo.EditValue);
                    item.IdPeriodo = Convert.ToInt32(cmbPeriodos.EditValue);
                    item.FechaPago = Info_Periodo.pe_FechaIni.AddDays(1);
                }
               
               

            }
        }
    }
}
