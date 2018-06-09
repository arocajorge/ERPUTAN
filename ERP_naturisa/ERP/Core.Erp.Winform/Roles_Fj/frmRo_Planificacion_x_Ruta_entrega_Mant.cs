using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Info.Roles_Fj;
using Core.Erp.Business.Roles_Fj;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Business.Roles;
using Core.Erp.Info.Roles;
namespace Core.Erp.Winform.Roles_Fj
{
    public partial class frmRo_Planificacion_x_Ruta_entrega_Mant : Form
    {
        public frmRo_Planificacion_x_Ruta_entrega_Mant()
        {
            InitializeComponent();
            cargar_dato();
        }

        #region variable
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        public Cl_Enumeradores.eTipo_action Accion { get; set; }

        List<ro_placa_Info> lista_placa = new List<ro_placa_Info>();
        List<ro_fuerza_Info> lista_fuerza = new List<ro_fuerza_Info>();
        List<ro_disco_Info> lista_disco = new List<ro_disco_Info>();
        List<ro_zona_Info> lista_zona = new List<ro_zona_Info>();
        List<ro_ruta_Info> lista_ruta = new List<ro_ruta_Info>();



        

        ro_placa_Bus bus_placa = new ro_placa_Bus();
        ro_fuerza_Bus bus_fuerza = new ro_fuerza_Bus();
        ro_disco_Bus bus_disco = new ro_disco_Bus();
        ro_zona_Bus bus_zona = new ro_zona_Bus();
        ro_ruta_Bus bus_ruta = new ro_ruta_Bus();




        ro_Nomina_Tipoliqui_Bus Bus_TipoL = new ro_Nomina_Tipoliqui_Bus();
        List<ro_Nomina_Tipoliqui_Info> InfoTipoLiqui = new List<ro_Nomina_Tipoliqui_Info>();
        ro_Nomina_Tipo_Bus oRo_Nomina_Tipo_Bus = new ro_Nomina_Tipo_Bus();
        ro_Nomina_Tipoliqui_Bus nominatipo_Bus = new ro_Nomina_Tipoliqui_Bus();
        ro_periodo_x_ro_Nomina_TipoLiqui_Bus periodo_nomina_bus = new ro_periodo_x_ro_Nomina_TipoLiqui_Bus();

        List<ro_Nomina_Tipo_Info> listadoNomina = new System.Collections.Generic.List<ro_Nomina_Tipo_Info>();
        List<ro_Nomina_Tipoliqui_Info> ListadoTipoLiquidacion = new System.Collections.Generic.List<ro_Nomina_Tipoliqui_Info>();
        List<ro_periodo_x_ro_Nomina_TipoLiqui_Info> listadoPeriodo = new System.Collections.Generic.List<ro_periodo_x_ro_Nomina_TipoLiqui_Info>();




        ro_planificacion_x_ruta_x_empleado_Info info_planificacion = new ro_planificacion_x_ruta_x_empleado_Info();
        ro_planificacion_x_ruta_x_empleado_Bus bus_planificacion = new ro_planificacion_x_ruta_x_empleado_Bus();
        BindingList<ro_planificacion_x_ruta_x_empleado_det_Info> lista_planificada = new BindingList<ro_planificacion_x_ruta_x_empleado_det_Info>();
        ro_planificacion_x_ruta_x_empleado_det_Bus bus_planificacion_detalle = new ro_planificacion_x_ruta_x_empleado_det_Bus();
        #endregion
        private void frmRo_Planificacion_x_Ruta_entrega_Mant_Load(object sender, EventArgs e)
        {
            try
            {
            gridControl_planificacion.DataSource = lista_planificada;
            listadoNomina = oRo_Nomina_Tipo_Bus.Get_List_Nomina_Tipo(param.IdEmpresa);
            cmbnomina.Properties.DataSource = listadoNomina;

            switch (Accion)
            {
                case Cl_Enumeradores.eTipo_action.grabar:
                    break;
                case Cl_Enumeradores.eTipo_action.actualizar:
                    cmbnomina.Enabled = false;
                    cmbnominaTipo.Enabled = false;
                    cmbPeriodos.Enabled = false;
                    break;
                case Cl_Enumeradores.eTipo_action.Anular:
                    break;
                case Cl_Enumeradores.eTipo_action.consultar:
                    ucGe_Menu.Visible_btnGuardar = false;
                    ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                    break;
                case Cl_Enumeradores.eTipo_action.duplicar:
                    break;
                
                default:
                    break;
            }
            }
            catch (Exception ex)
            {
                
               Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        public void cargar_dato()
        {
            try
            {
            cmb_disco.ValueMember = "IdDisco";
            cmb_disco.DisplayMember = "Disco";

            cmb_fuerza.ValueMember = "IdFuerza";
            cmb_fuerza.DisplayMember = "fu_descripcion";

            cmb_placa.ValueMember = "IdPlaca";
            cmb_placa.DisplayMember = "Placa";

            cmb_ruta.ValueMember = "IdRuta";
            cmb_ruta.DisplayMember = "ru_descripcion";

            cmb_zona.ValueMember = "IdZona";
            cmb_zona.DisplayMember = "zo_descripcion";
// lista de disco
            lista_disco = bus_disco.Get_List_Disco(param.IdEmpresa);           
            cmb_disco.DataSource = lista_disco;


// lista de fuerza
            lista_fuerza = bus_fuerza.Get_List_Fuerza(param.IdEmpresa);          
            cmb_fuerza.DataSource = lista_fuerza;
// lista de placa
            lista_placa = bus_placa.Get_List_Placa(param.IdEmpresa);           
            cmb_placa.DataSource = lista_placa;            
// lista de rutas 
            lista_ruta = bus_ruta.Get_List_Ruta(param.IdEmpresa);           
            cmb_ruta.DataSource = lista_ruta;

// lista de zonas
            lista_zona = bus_zona.Get_List_Zona(param.IdEmpresa);            
            cmb_zona.DataSource = lista_zona;

            }
            catch (Exception ex)
            {
                
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cmbnomina_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                ListadoTipoLiquidacion = nominatipo_Bus.Get_List_Nomina_Tipoliqui_x_Nomina_Tipo(param.IdEmpresa, Convert.ToInt32(cmbnomina.EditValue));
                cmbnominaTipo.Properties.DataSource = ListadoTipoLiquidacion;


            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cmbnominaTipo_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                listadoPeriodo = periodo_nomina_bus.ConsultaPerNomTipLiq(param.IdEmpresa, Convert.ToInt32(cmbnomina.EditValue), Convert.ToInt32(cmbnominaTipo.EditValue));
                cmbPeriodos.Properties.DataSource = listadoPeriodo.Where(v => v.Cerrado == "N" && v.Contabilizado == "N").ToList();
          

            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbPeriodos_EditValueChanged(object sender, EventArgs e)
        {
            try
            {

                lista_planificada = new BindingList<ro_planificacion_x_ruta_x_empleado_det_Info>(bus_planificacion_detalle.get_lista_planificacion(param.IdEmpresa, Convert.ToInt32(cmbnomina.EditValue),Convert.ToInt32( cmbPeriodos.EditValue)));
                gridControl_planificacion.DataSource = lista_planificada;
           

            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Validar())
                    return;
                if (Grabar())
                    this.Close();

            }
            catch (Exception ex)
            {
                
               Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if(Validar())
                Grabar();
            }
            catch (Exception ex)
            {
                
                 Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        void Get()
        {
            try
            {
                info_planificacion = new ro_planificacion_x_ruta_x_empleado_Info();
                info_planificacion.lista = new List<ro_planificacion_x_ruta_x_empleado_det_Info>();
                info_planificacion.IdEmpresa = param.IdEmpresa;
                info_planificacion.IdNomina_Tipo = Convert.ToInt32(cmbnomina.EditValue);
                info_planificacion.IdNomina_tipo_Liq = Convert.ToInt32(cmbnominaTipo.EditValue);
                info_planificacion.IdPeriodo = Convert.ToInt32(cmbPeriodos.EditValue);
                info_planificacion.Observacion = txtobservacion.Text;
                info_planificacion.IdUsuario = param.IdUsuario;
                info_planificacion.Fecha_Transaccion = DateTime.Now;
                info_planificacion.IdUsuarioUltModi = param.IdUsuario;
                info_planificacion.Fecha_UltMod = DateTime.Now;

                foreach (var item in lista_planificada)
                {
                    item.IdEmpresa = param.IdEmpresa;
                    item.IdPeriodo = Convert.ToInt32(cmbPeriodos.EditValue);
                    item.IdNomina_Tipo = Convert.ToInt32(cmbnomina.EditValue);
                    item.IdNomina_Tipo_Liq = Convert.ToInt32(cmbnominaTipo.EditValue);
                }

                info_planificacion.lista = lista_planificada.ToList();
            }
            catch (Exception ex)
            {
                
               Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        bool Validar()
        {
            try
            {
                if (cmbnomina.EditValue == null || cmbnomina.EditValue == "")
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_la) + " nomina",param.Nombre_sistema,  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (cmbnominaTipo.EditValue == null || cmbnominaTipo.EditValue == "")
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_la) + " Proceso", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (cmbPeriodos.EditValue == null || cmbPeriodos.EditValue == "")
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_la) + " Seleccione el periodo para la planificación", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (txtobservacion.Text == "")
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_la) + " Ingrese una observación", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        bool Grabar()
        {
            try
            {
                Get();
                if (bus_planificacion.Guardar_DB(info_planificacion))
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_guardaron_los_datos_correctamente), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }

                else
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.No_se_guardaron_los_datos), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
            }
            catch (Exception ex)
            {
                
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        public void Set(ro_planificacion_x_ruta_x_empleado_Info info)
        {
            try
            {
                txtobservacion.Text = info.Observacion;
                cmbnomina.EditValue = info.IdNomina_Tipo;
                cmbnominaTipo.EditValue = info.IdNomina_tipo_Liq;
                cmbPeriodos.EditValue = info.IdPeriodo;

                lista_planificada = new BindingList<ro_planificacion_x_ruta_x_empleado_det_Info>( bus_planificacion_detalle.lista_planificacion(param.IdEmpresa, info.IdNomina_Tipo, info.IdPeriodo));
                gridControl_planificacion.DataSource = lista_planificada;
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       

        private void cmb_fuerza_EditValueChanged(object sender, EventArgs e)
        {
           
                try
                {

                    if (cmb_fuerza.ValueMember == "0")
                    {
                        frmRo_fuerza_mant frm = new frmRo_fuerza_mant();
                        frm.Set_Accion(Cl_Enumeradores.eTipo_action.grabar);
                        frm.ShowDialog();
                    }

                }
                catch (Exception ex)
                {

                    Log_Error_bus.Log_Error(ex.ToString());
                    MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            
        }

        private void nuevaFuerzaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmRo_fuerza_mant frm = new frmRo_fuerza_mant();
                frm.Set_Accion(Cl_Enumeradores.eTipo_action.grabar);
                frm.ShowDialog();
                lista_fuerza = bus_fuerza.Get_List_Fuerza(param.IdEmpresa);
                cmb_fuerza.DataSource = lista_fuerza;
            }
            catch (Exception ex)
            {
                
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void nuevaZonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmRo_zona_mant frm = new frmRo_zona_mant();
                frm.Set_Accion(Cl_Enumeradores.eTipo_action.grabar);
                frm.ShowDialog();
                lista_zona = bus_zona.Get_List_Zona(param.IdEmpresa);
                cmb_zona.DataSource = lista_zona;
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void nuevoDiscoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmRo_disco_mant frm = new frmRo_disco_mant();
                frm.Set_Accion(Cl_Enumeradores.eTipo_action.grabar);
                frm.ShowDialog();
                lista_disco = bus_disco.Get_List_Disco(param.IdEmpresa);
                cmb_disco.DataSource = lista_disco;
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void nuevaRutaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmRo_ruta_mant frm = new frmRo_ruta_mant();
                frm.Set_Accion(Cl_Enumeradores.eTipo_action.grabar);
                frm.ShowDialog();
                lista_ruta = bus_ruta.Get_List_Ruta(param.IdEmpresa);
                cmb_ruta.DataSource = lista_ruta;
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void nuevaPlacaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmRo_placa_mant frm = new frmRo_placa_mant();
                frm.Set_Accion(Cl_Enumeradores.eTipo_action.grabar);
                frm.ShowDialog();
                lista_placa = bus_placa.Get_List_Placa(param.IdEmpresa);
                cmb_placa.DataSource = lista_placa;
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void gridView_planificacion_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (e.Column.Name == "Col_imagen")
            {
                try
                {
                    DialogResult dialogResult = MessageBox.Show("¿Esta seguro de querer eliminar el registro?", param.Nombre_sistema, MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        gridView_planificacion.DeleteSelectedRows();
                    }

                }
                catch (Exception ex)
                {

                    Log_Error_bus.Log_Error(ex.ToString());
                    MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        
    }
}
