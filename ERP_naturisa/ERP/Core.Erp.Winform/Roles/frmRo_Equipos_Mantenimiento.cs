using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.General;
using Core.Erp.Info.Roles;
using Core.Erp.Business.Roles;
using Core.Erp.Winform.General;
using Core.Erp.Business.General;
using Core.Erp.Recursos.Properties;



namespace Core.Erp.Winform.Roles
{
    public partial class frmRo_Equipos_Mantenimiento : Form
    {
        #region Declaración de Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        public Cl_Enumeradores.eTipo_action _Accion { get; set; }
        //public ro_marcaciones_Equipo_Info _Info = new ro_marcaciones_Equipo_Info();
        public ro_marcaciones_Equipo_Info Info = new ro_marcaciones_Equipo_Info();
        Cl_Enumeradores.eTipo_action Accion;
           ro_marcaciones_Equipo_x_TipoMarcacion_Info MarcEquipoInfo;
        private ro_marcaciones_Equipo_Bus roMarcaEqui_Bus = new ro_marcaciones_Equipo_Bus();

        //DELEGADO
        public delegate void delegate_frmRo_Marcaciones_Equipos_Mantenimiento_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmRo_Marcaciones_Equipos_Mantenimiento_FormClosing Event_frmRo_Marcaciones_Equipos_Mantenimiento_FormClosing;

        ro_marcaciones_Equipo_x_TipoMarcacion_Bus bus = new ro_marcaciones_Equipo_x_TipoMarcacion_Bus();
        BindingList<ro_marcaciones_Equipo_x_TipoMarcacion_Info> DataSource;
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        #endregion

        public frmRo_Equipos_Mantenimiento()
        {
            try
            {
                InitializeComponent();
                ucGe_Menu.event_btnAnular_Click += ucGe_Menu_event_btnAnular_Click;
                ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
                ucGe_Menu.event_btnlimpiar_Click += ucGe_Menu_event_btnlimpiar_Click;
                ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
                ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
                Event_frmRo_Marcaciones_Equipos_Mantenimiento_FormClosing += frmRo_Equipos_Mantenimiento_Event_frmRo_Marcaciones_Equipos_Mantenimiento_FormClosing;  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
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

        void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                Grabar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void ucGe_Menu_event_btnlimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                Limpiar();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Grabar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                Grabar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void frmRo_Equipos_Mantenimiento_Event_frmRo_Marcaciones_Equipos_Mantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void frmRo_Marcaciones_Equipos_Mantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Event_frmRo_Marcaciones_Equipos_Mantenimiento_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
        
        private void Grabar()
        {
            try
            {
                
                    get_Info();


                    switch (Accion)
                    {
                        case Cl_Enumeradores.eTipo_action.grabar:


                            if (roMarcaEqui_Bus.ValidarIdMarcEqui(Info.IdEquipoMar))
                            {
                                DataSource = (BindingList<ro_marcaciones_Equipo_x_TipoMarcacion_Info>)this.gridControlMarcacionesEquipo.DataSource;


                                if (roMarcaEqui_Bus.GrabarDB(Info))
                                {
                                    gridViewEquipoMarcaciones.FocusedRowHandle = gridViewEquipoMarcaciones.FocusedRowHandle + 1;
                                    foreach (var item in DataSource)
                                    {
                                        if (item.IdTipoMarcaciones_Biometrico != "" && item.IdTipoMarcaciones_Biometrico != null)
                                        {
                                            MarcEquipoInfo = new ro_marcaciones_Equipo_x_TipoMarcacion_Info();
                                            MarcEquipoInfo.IdEquipoMar = Info.IdEquipoMar;
                                            MarcEquipoInfo.IdTipoMarcaciones_sys = item.IdTipoMarcaciones_sys;
                                            MarcEquipoInfo.IdTipoMarcaciones_Biometrico = item.IdTipoMarcaciones_Biometrico;
                                            bus.GuardarDB(MarcEquipoInfo);
                                        }
                                    }
                                    MessageBox.Show(Resources.msgConfirmaGrabarOk, Resources.msgTituloGrabar, MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    Bloquear_Datos();
                                }
                            }


                            break;
                        case Cl_Enumeradores.eTipo_action.actualizar:

                            Info.IdEquipoMar = Info.IdEquipoMar;
                            DataSource = (BindingList<ro_marcaciones_Equipo_x_TipoMarcacion_Info>)this.gridControlMarcacionesEquipo.DataSource;
                            if (roMarcaEqui_Bus.ModificarDB(Info))
                            {
                                gridViewEquipoMarcaciones.FocusedRowHandle = gridViewEquipoMarcaciones.FocusedRowHandle + 1;

                                foreach (var item in DataSource)
                                {
                                    MarcEquipoInfo = new ro_marcaciones_Equipo_x_TipoMarcacion_Info();
                                    MarcEquipoInfo.IdEquipoMar = Info.IdEquipoMar;
                                    MarcEquipoInfo.IdTipoMarcaciones_sys = item.IdTipoMarcaciones_sys;
                                    MarcEquipoInfo.IdTipoMarcaciones_Biometrico = item.IdTipoMarcaciones_Biometrico;

                                    if (bus.ValidarExiste(item.IdEquipoMar, item.IdTipoMarcaciones_sys))
                                    {
                                        bus.ModificarDB(MarcEquipoInfo);
                                    }
                                    else
                                    {
                                        if (item.IdTipoMarcaciones_Biometrico != "" && item.IdTipoMarcaciones_Biometrico != null)
                                        {
                                            bus.GuardarDB(MarcEquipoInfo);
                                        }
                                    }
                                }
                                MessageBox.Show(Resources.msgConfirmaGrabarOk, Resources.msgTituloGrabar, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Bloquear_Datos();
                            }

                            break;
                        case Cl_Enumeradores.eTipo_action.Anular:



                            if (MessageBox.Show("Está seguro que desea anular el registro...?", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                string motiAnulacion = "";

                                FrmGe_MotivoAnulacion fr = new FrmGe_MotivoAnulacion();
                                fr.ShowDialog();
                                motiAnulacion = fr.motivoAnulacion;


                                if (roMarcaEqui_Bus.AnularDB(Info))
                                {
                                    MessageBox.Show(Resources.msgTituloAnular, Resources.msgTituloAnular, MessageBoxButtons.OK, MessageBoxIcon.Information);

                                }
                                else
                                {
                                    MessageBox.Show("Error al tratar de anular el registro ", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                }
                            }


                            break;




                        default:
                            break;
                    }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
               
            }

        }




        bool validar()
        {
            try
            {
                if (txtNombreEquipo.Text == "" || txtNombreEquipo.EditValue == null)
                {
                    MessageBox.Show("Debe Ingresar El Nombre Del Equipo", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
               
                if (txtModeloEquipo.Text == "" || txtModeloEquipo.EditValue == null)
                {
                    MessageBox.Show("Debe Ingresar El Modelo De Equipo", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
            return true;
        }

        private void Limpiar()
        {
            try
            {
                txtid.Text = "";
                txtNombreEquipo.Text = "";
                txtModeloEquipo.Text = "";

                cBoxEstado.Checked = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }


        void Bloquear_Datos()
        {
            try
            {
                if (Info.Estado == "I")
                {
                    lbl_Estado.Visible = true;
                }
                else
                {
                    lbl_Estado.Visible = false;
                }
                //btn_guardar.Visible = false;
                //btn_guardarysalir.Visible = false;

                txtNombreEquipo.Enabled = false;
                txtNombreEquipo.BackColor = System.Drawing.Color.White;
                txtNombreEquipo.ForeColor = System.Drawing.Color.Black;



                txtModeloEquipo.Enabled = false;
                txtModeloEquipo.BackColor = Color.White;
                txtModeloEquipo.ForeColor = Color.Black;



                cBoxEstado.Enabled = false;

                //toolStripSeparator6.Visible = false;
                //toolStripSeparator5.Visible = false;
                colIdTipoMarcaciones_Biometrico.OptionsColumn.AllowEdit = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void frmRo_Equipos_Mantenimiento_Load(object sender, EventArgs e)
        {
            
        }

        void cargarTipoMarcaciones()
        {
            try
            {
                DataSource = new BindingList<ro_marcaciones_Equipo_x_TipoMarcacion_Info>(bus.Get_List_marcaciones_Equipo_x_TipoMarcacion(Info.IdEquipoMar));
                gridControlMarcacionesEquipo.DataSource = DataSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void ucGe_Menu_Load(object sender, EventArgs e)
        {

        }

        public void set_Accion(Cl_Enumeradores.eTipo_action _Accion)
        {
            try
            {

                Accion = _Accion;

                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        Limpiar();
                        ucGe_Menu.Enabled_bntAnular = false;
                        ucGe_Menu.Enabled_bntLimpiar = true;
                        txtid.Enabled = false;
                        txtNombreEquipo.Enabled = true;
                       // txtFabricante.Enabled = true;
                        txtModeloEquipo.Enabled = true;
                      //  txtProveedor.Enabled = true;
                       // txtObservaciones.Enabled = true;
                        cBoxEstado.Enabled = true;
                        Info.IdEquipoMar = 0;
                        colIdTipoMarcaciones_Biometrico.OptionsColumn.AllowEdit = true;
                        cargarTipoMarcaciones();
                        cBoxEstado.Checked = true;
                        lbl_Estado.Visible = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        ucGe_Menu.Enabled_bntAnular = false;
                        ucGe_Menu.Enabled_bntLimpiar = false;
                        txtid.Enabled = false;
                        txtNombreEquipo.Enabled = true;
                        txtModeloEquipo.Enabled = true;
                        cBoxEstado.Enabled = true;
                        colIdTipoMarcaciones_Biometrico.OptionsColumn.AllowEdit = true;
                        lbl_Estado.Visible = false;
                        cargarTipoMarcaciones();
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        ucGe_Menu.Enabled_bntAnular = false;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        ucGe_Menu.Enabled_bntLimpiar = false;
                        txtid.Enabled = false;
                        txtNombreEquipo.Enabled = false;
                       // txtFabricante.Enabled = false;
                        txtModeloEquipo.Enabled = false;
                        //txtProveedor.Enabled = false;
                       // txtObservaciones.Enabled = false;
                        cBoxEstado.Enabled = false;
                        Bloquear_Datos();
                        cargarTipoMarcaciones();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        ucGe_Menu.Enabled_bntAnular = true;
                        ucGe_Menu.Visible_bntAnular = true;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        ucGe_Menu.Enabled_bntLimpiar = false;
                        txtid.Enabled = false;
                        txtNombreEquipo.Enabled = false;

                        txtModeloEquipo.Enabled = false;

                        cBoxEstado.Enabled = true;
                        cBoxEstado.Checked = true;
                        Bloquear_Datos();
                        cargarTipoMarcaciones();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        public void set_Info(ro_marcaciones_Equipo_Info _Info)
        {
            try
            {
                txtid.Text = (_Info.IdEquipoMar.ToString());
                txtNombreEquipo.Text = (_Info.Nombre_Equipo);
                txtModeloEquipo.Text = (_Info.Modelo_Equipo);
                txtTabla.Text = _Info.Tabla_Vista;
                txt_cadena_conexion.Text = _Info.CadenaConexion;
                cmb_formato_fecha.Text = _Info.FormatoFecha;
                cmb_formato_hora.Text = _Info.FormatoHora;
                dateTimeFechaUltProceso.Value = _Info.FechaUltimaImportacionMarcaiones;
                cmb_tipo_base.Text = _Info.TipoBd;
                cBoxEstado.Checked = (_Info.Estado == "A") ? true : false;
                Info = _Info;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        public ro_marcaciones_Equipo_Info get_Info()
        {
            try
            {
                if (Cl_Enumeradores.eTipo_action.actualizar == Accion)
                {
                    Info.IdEquipoMar = Convert.ToInt32(txtid.Text);
                }
                Info.IdEmpresa = param.IdEmpresa;
                Info.IdSucursal = param.IdSucursal;
                Info.Nombre_Equipo = txtNombreEquipo.Text;
                Info.Modelo_Equipo = txtModeloEquipo.Text;
                Info.Tabla_Vista = txtTabla.Text;
                Info.CadenaConexion = txt_cadena_conexion.Text;
                Info.TipoBd = cmb_tipo_base.Text;
                Info.FormatoFecha = cmb_formato_fecha.Text;
                Info.FormatoHora = cmb_formato_hora.Text;
                Info.FechaUltimaImportacionMarcaiones = dateTimeFechaUltProceso.Value;
                return Info;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
                return new ro_marcaciones_Equipo_Info();
            }
        }

        private void frmRo_Equipos_Mantenimiento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Escape))
            {
                this.Close();
            }
        }

        private void txt_cadena_conexion_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

            //MSDASC.DataLinks dataLinks = new MSDASC.DataLinks();

            //ADODB._Connection connection;

            //try
            //{

            //    connection = (ADODB._Connection)dataLinks.PromptNew();


            //    txt_cadena_conexion.Text = connection.ConnectionString.ToString();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //}
			
        }

    }
}



