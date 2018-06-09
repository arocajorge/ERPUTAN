using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Info.Academico;
using Core.Erp.Business.Academico;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraTreeList;
using Core.Erp.Winform.General;


namespace Core.Erp.Winform.Academico
{
    public partial class FrmAcaInstitucion_Mant : Form
    {
        #region "Variables"
        private Cl_Enumeradores.eTipo_action Accion;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        Aca_Institucion_Info infoInstitucion = new Aca_Institucion_Info();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        List<vwAca_Institucion_x_Sede_x_Jorn_x_Sec_Curso_x_Para_Info> listaInstitucion;
        vwAca_Institucion_x_Sede_x_Jorn_x_Sec_Curso_x_Para_Info infoVistaTree;

        public delegate void delegate_FrmAcInstitucion_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_FrmAcInstitucion_Mant_FormClosing event_FrmInstitucion_Mant_FormClosing;                  
        
        #endregion

        public FrmAcaInstitucion_Mant()
        {
            InitializeComponent();
            event_FrmInstitucion_Mant_FormClosing += FrmAcaInstitucion_Mant_event_FrmInstitucion_Mant_FormClosing;

        }

        void FrmAcaInstitucion_Mant_event_FrmInstitucion_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
                throw;
            }
        }
     
        #region "Set"
        public void set_Accion(Cl_Enumeradores.eTipo_action iAccion)
        {
            try
            {
                Accion = iAccion;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        public void set_Institucion(Aca_Institucion_Info info)
        {
            try
            {
                infoInstitucion = info;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region "Get"
        public Aca_Institucion_Info GetInstitucion(ref string mensaje) {
            Aca_Institucion_Info info = new Aca_Institucion_Info();
            try
            {
                info.IdEmpresa = param.IdEmpresa;
                info.IdInstitucion = string.IsNullOrEmpty(txtIdInstitucion.Text.Trim())?0:Convert.ToInt32( txtIdInstitucion.Text.Trim());
                info.CodInstitucion = string.IsNullOrEmpty(txtCodigoInstitucion.Text.Trim()) ? txtIdInstitucion.Text.Trim() : txtCodigoInstitucion.Text.Trim();
                info.Ruc = txtruc.Text.Trim();
                info.Nombre = txtNombre.Text.Trim();
                info.Rector = txtRector.Text.Trim();
                info.Resolucion_Academica = txtResolucionAcademica.Text.Trim();
                info.Secretario = txtSecretario.Text.Trim();
                info.Direccion = txtDireccion.Text.Trim();
                info.Coordinador = txtCoordinador.Text.Trim();
                info.SitioWeb = txtSitioWeb.Text.Trim();
                info.Telefono = txtTelefono.Text.Trim();
                info.Fax = txtFax.Text.Trim();
                info.Estado = chkEstado.Checked == true ? "A" : "I";
                info.paisInfo.IdPais = ucGe_Paprovciu.cmbPais.EditValue.ToString();
                info.provinciaInfo.IdProvincia = ucGe_Paprovciu.cmbProvincia.EditValue.ToString();
                info.ciudadInfo.IdCiudad = ucGe_Paprovciu.cmbCiudad.EditValue.ToString();
                info.UsuarioModificacion = param.IdUsuario;


                if (Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    chkEstado.Checked = true;
                }

                info.Estado = (chkEstado.Checked == true) ? "A" : "I";
                if (chkEstado.Checked)
                {
                    lblAnulado.Visible = false;
                }
                else { lblAnulado.Visible = true; }
                
                return info;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
                throw;
            }
        }
        #endregion

        #region "CargarDatos"
        public void CargarInstitucion() {
            try
            {
                txtIdInstitucion.Text = infoInstitucion.IdInstitucion.ToString();
                txtCodigoInstitucion.Text = infoInstitucion.CodInstitucion;
                txtruc.Text = infoInstitucion.Ruc;
                txtNombre.Text = infoInstitucion.Nombre;
                txtTelefono.Text = infoInstitucion.Telefono;
                txtFax.Text = infoInstitucion.Fax;
                txtRector.Text = infoInstitucion.Rector;
                txtCoordinador.Text = infoInstitucion.Coordinador;
                txtSecretario.Text = infoInstitucion.Secretario;
                txtDireccion.Text = infoInstitucion.Direccion;
                txtResolucionAcademica.Text = infoInstitucion.Resolucion_Academica;                
                txtSitioWeb.Text = infoInstitucion.SitioWeb;
                ucGe_Paprovciu.cmbPais.EditValue = infoInstitucion.paisInfo.IdPais;
                ucGe_Paprovciu.cmbProvincia.EditValue = infoInstitucion.provinciaInfo.IdProvincia;
                ucGe_Paprovciu.cmbCiudad.EditValue = infoInstitucion.ciudadInfo.IdCiudad;

                chkEstado.Checked = (infoInstitucion.Estado == "A") ? true : false;
                if (infoInstitucion.Estado == "A")
                {
                    lblAnulado.Visible = false;
                }
                else
                {
                    if (infoInstitucion.Estado != null)
                    {
                        lblAnulado.Visible = true;
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        public void LlenarTreeInstitucion() {
            try
            {
                vwAca_Institucion_x_Sede_x_Jorn_x_Sec_Curso_x_Para_Bus neg = new vwAca_Institucion_x_Sede_x_Jorn_x_Sec_Curso_x_Para_Bus();
                listaInstitucion=new List<vwAca_Institucion_x_Sede_x_Jorn_x_Sec_Curso_x_Para_Info>();
                listaInstitucion = neg.Get_List_Aca_Institucion_x_Sede_x_Jorn_x_Sec_Curso_x_Para(param.IdEmpresa,Convert.ToInt16( txtIdInstitucion.Text.Trim()));
                this.treeListSede.DataSource = listaInstitucion;
                this.treeListSede.ExpandAll();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }        
        }

      
        #endregion

        #region "Grabar,Actualizar,Eliminar"
        public void guardarDatos()
        {
            try
            {
                if (validaciones())
                {
                    switch (Accion)
                    {
                        case Cl_Enumeradores.eTipo_action.grabar:
                            Grabar();
                            break;

                        case Cl_Enumeradores.eTipo_action.actualizar:
                            Actualizar();
                            break;
                    }
                }
            }

            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        public void Grabar() {
            try
            {
                Aca_Institucion_Info infoInst = new Aca_Institucion_Info();
                Aca_Institucion_Bus busInstitucion = new Aca_Institucion_Bus();                
                
                string mensaje = string.Empty;
                int idInstitucion = 0;

                infoInst = GetInstitucion(ref mensaje);
                
                if (mensaje != "")
                {
                    return;
                }
                
                infoInst.UsuarioCreacion = param.IdUsuario;

                bool resultado = busInstitucion.GrabarDB(infoInst, ref idInstitucion, ref mensaje);
                txtIdInstitucion.Text = idInstitucion.ToString();

                if (resultado == true)
                {
                    MessageBox.Show(mensaje, " Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                    this.ucGe_Menu.Visible_btnGuardar = false;
                }
                else
                {
                    Log_Error_bus.Log_Error(mensaje.ToString());
                    MessageBox.Show("Error " + mensaje, "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message);
            }        
        }

        private void Actualizar()
        {
            try
            {
                Aca_Institucion_Bus busInstitucion = new Aca_Institucion_Bus();
                Aca_Institucion_Info infoInstitucion = new Aca_Institucion_Info();
                string mensaje = string.Empty;

                infoInstitucion = GetInstitucion(ref mensaje);
                if (mensaje != "")
                {
                    MessageBox.Show(mensaje);
                    return;
                }
                bool resultado = busInstitucion.ActualizarDB(infoInstitucion, ref mensaje);
                if (resultado)
                {
                    MessageBox.Show("Se ha actualizado correctamente la Institucion # : " + txtIdInstitucion.Text, "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                    this.ucGe_Menu.Visible_btnGuardar = false;
                }
                else
                {
                    Log_Error_bus.Log_Error(mensaje.ToString());
                    MessageBox.Show("Error " + mensaje, "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error " + ex.Message.ToString(), "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Anular()
        {
            try
            {
                if (infoInstitucion.Estado != "I")
                {
                    if (MessageBox.Show("¿Está seguro que desea anular la Institución # " + txtIdInstitucion.Text.Trim() + " ?", "Anulación de Mantenimiento Institución", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                        FrmGe_MotivoAnulacion fr = new FrmGe_MotivoAnulacion();
                        fr.ShowDialog();                       

                        Aca_Institucion_Bus busInstitucion = new Aca_Institucion_Bus();
                        Aca_Institucion_Info infoInst = new Aca_Institucion_Info();
                        string mensaje = string.Empty;

                        infoInst = GetInstitucion(ref mensaje);
                        if (mensaje != "")
                        {
                            MessageBox.Show("Error " + mensaje, "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        infoInst.MotivoAnulacion = fr.motivoAnulacion;
                        infoInst.UsuarioAnulacion = param.IdUsuario;
                        bool resultado = busInstitucion.EliminarDB(infoInst, ref mensaje);
                        if (resultado)
                        {
                            MessageBox.Show("Se ha anulado correctamente la Institución # : " + txtIdInstitucion.Text, "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                            this.ucGe_Menu.Visible_btnGuardar = false;
                        }
                        else
                        {
                            Log_Error_bus.Log_Error(mensaje.ToString());
                            MessageBox.Show("Error " + mensaje, "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }                    
                    }
                }
                else { MessageBox.Show("La Institución #: "+ txtIdInstitucion.Text.Trim()+" ya se encuentra anulado.", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information); }               
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error " + ex.Message.ToString(), "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        #region "Validaciones"
        private void LimpiarControles() {
            txtIdInstitucion.Text = string.Empty;
            txtCodigoInstitucion.Text = string.Empty;
            txtCoordinador.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtFax.Text = string.Empty;
            txtruc.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtRector.Text = string.Empty;
            txtResolucionAcademica.Text = string.Empty;
            txtSecretario.Text = string.Empty;
            txtSitioWeb.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            chkEstado.Checked = true;
        
        }
        private Boolean validaciones()
        {
            try
            {
              
                if ( string.IsNullOrEmpty(txtNombre.EditValue.ToString()))
                {
                    MessageBox.Show("Digite el Nombre de la Institución", "Operación Fallida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNombre.Focus();
                    return false;
                }

                if ( string.IsNullOrEmpty(txtDireccion.EditValue.ToString()))
                {
                    MessageBox.Show("Digite la dirección de la Institución", "Operación Fallida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDireccion.Focus();
                    return false;
                }

                if (string.IsNullOrEmpty(ucGe_Paprovciu.cmbPais.EditValue.ToString()))
                {
                    MessageBox.Show("Digite campo Pais", "Operación Fallida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ucGe_Paprovciu.cmbPais.Focus();
                    return false;
                }

                if (string.IsNullOrEmpty(ucGe_Paprovciu.cmbProvincia.EditValue.ToString()))
                {
                    MessageBox.Show("Digite campo Provincia", "Operación Fallida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ucGe_Paprovciu.cmbProvincia.Focus();
                    return false;
                }

                if (string.IsNullOrEmpty(ucGe_Paprovciu.cmbCiudad.EditValue.ToString()))
                {
                    MessageBox.Show("Digite campo Ciudad", "Operación Fallida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ucGe_Paprovciu.cmbCiudad.Focus();
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }
        }
        private void llama_frm(Cl_Enumeradores.eTipo_action Accion, string menu)
        {
            try
            {
                switch (menu)
                {

                    case "Sede": // Sede 
                        if (infoVistaTree.Nivel == 2)
                        {
                            FormaSede(Accion);
                        }
                        else { MessageBox.Show("Ubiquese en el nivel Sede", "Operación Fallida", MessageBoxButtons.OK, MessageBoxIcon.Information); }


                        break;
                    case "Jornada": //Jornada
                        if (infoVistaTree.Nivel == 3)
                        {
                            FormaJornada(Accion);
                        }
                        else { MessageBox.Show("Ubiquese en el nivel Jornada", "Operación Fallida", MessageBoxButtons.OK, MessageBoxIcon.Information); }

                        break;
                    case "Seccion": // Seccion
                        if (infoVistaTree.Nivel == 4)
                        {
                            FormaSeccion(Accion);
                        }
                        else { MessageBox.Show("Ubiquese en el nivel Sección", "Operación Fallida", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                        break;

                    case "Curso": // Curso
                        if (infoVistaTree.Nivel == 5)
                        {
                            FormaCurso(Accion);
                        }
                        else { MessageBox.Show("Ubiquese en el nivel Curso", "Operación Fallida", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                        break;

                    case "Paralelo": // Paralelo
                        if (infoVistaTree.Nivel == 6)
                        {
                            FormaParalelo(Accion);
                        }
                        else { MessageBox.Show("Ubiquese en el nivel Paralelo", "Operación Fallida", MessageBoxButtons.OK, MessageBoxIcon.Information); }

                        break;
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error comunicarse con Sistemas " + ex.Message + " ", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region "Formas"
        void FormaSede(Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {
                FrmAcaSede_Mant frm = new FrmAcaSede_Mant();
                Aca_Sede_Info infoSede = new Aca_Sede_Info();
                infoSede.IdInstitucion = infoVistaTree.IdInstitucion == null ? 0 : Convert.ToInt16(infoVistaTree.IdInstitucion);

                if (Accion != Cl_Enumeradores.eTipo_action.grabar)
                {
                    infoSede.IdSede = infoVistaTree.IdSede == null ? 0 : Convert.ToInt16(infoVistaTree.IdSede);
                    //infoSede.IdSucursal = listSucursal.FirstOrDefault(v => v.IdSucursal == Convert.ToInt32(cmbsucursal.EditValue));
                    infoSede.DescripcionSede = infoVistaTree.Nombre;
                    infoSede.Estado = infoVistaTree.Estado;
                }

                frm.set_Sede(infoSede);
                frm.set_Accion(Accion);
                frm.Show();
                frm.event_FrmAcaSede_Mant_FormClosing += new FrmAcaSede_Mant.delegate_FrmAcaSede_Mant_FormClosing(frm_event_FrmAcaSede_Mant_FormClosing);            

            }
            catch (Exception)
            {

                throw;
            }
        }

        void FormaJornada(Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {
                FrmAcaJornada_Mant frm = new FrmAcaJornada_Mant();
                Aca_Jornada_Info infoJornada = new Aca_Jornada_Info();                
                infoJornada.IdInstitucion = infoVistaTree.IdInstitucion == null ? 0 : Convert.ToInt16(infoVistaTree.IdInstitucion);
                infoJornada.IdSede = infoVistaTree.IdSede;

                if (Accion != Cl_Enumeradores.eTipo_action.grabar)
                {
                    infoJornada.IdJornada = infoVistaTree.IdJornada == null ? 0 : Convert.ToInt16(infoVistaTree.IdJornada);
                    infoJornada.DescripcionJornada = infoVistaTree.Nombre;
                    infoJornada.Estado = infoVistaTree.Estado.Trim();
                }
                
                frm.set_Jornada(infoJornada);
                frm.set_Accion(Accion);
                frm.Show();
                frm.event_FrmAcaJornada_Mant_FormClosing += new FrmAcaJornada_Mant.delegate_FrmAcaJornada_Mant_FormClosing(frm_event_FrmAcaJornada_Mant_FormClosing);
                
            }
            catch (Exception)
            {
                throw;
            }
        }

        void FormaSeccion(Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {
                FrmAcaSeccion_Mant frm = new FrmAcaSeccion_Mant();
                Aca_Seccion_Info SeccionInfo = new Aca_Seccion_Info();

                SeccionInfo.IdInstitucion = param.IdInstitucion;
                SeccionInfo.IdInstitucion = infoVistaTree.IdInstitucion == null ? 0 : Convert.ToInt16(infoVistaTree.IdInstitucion);
                SeccionInfo.IdSede = infoVistaTree.IdSede == null ? 0 : Convert.ToInt16(infoVistaTree.IdSede);
                SeccionInfo.IdJornada = infoVistaTree.IdJornada == null ? 0 : Convert.ToInt16(infoVistaTree.IdJornada);
                SeccionInfo.IdSeccion = infoVistaTree.IdSeccion == null ? 0 : Convert.ToInt16(infoVistaTree.IdSeccion);

                if (Accion != Cl_Enumeradores.eTipo_action.grabar)
                {
                    SeccionInfo.IdSeccion = infoVistaTree.IdSeccion == null ? 0 : Convert.ToInt16(infoVistaTree.IdSeccion);
                    SeccionInfo.DescripcionSeccion = infoVistaTree.Nombre;
                    SeccionInfo.Estado = infoVistaTree.Estado.Trim();
                }
                               
                frm.set_Seccion(SeccionInfo);
                frm.set_Accion(Accion);
                frm.Show();
                frm.event_FrmAcaSeccion_Mant_FormClosing+=frm_event_FrmAcaSeccion_Mant_FormClosing;
            }
            catch (Exception)
            {
                throw;
            }
        }

        void FormaCurso(Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {
                FrmAcaCurso_Mant frm = new FrmAcaCurso_Mant();

                Aca_Curso_Info cursoInfo = new Aca_Curso_Info();                
                cursoInfo.IdInstitucion = infoVistaTree.IdInstitucion == null ? 0 : Convert.ToInt16(infoVistaTree.IdInstitucion);
                cursoInfo.IdSede = infoVistaTree.IdSede == null ? 0 : Convert.ToInt16(infoVistaTree.IdSede);
                cursoInfo.IdJornada = infoVistaTree.IdJornada == null ? 0 : Convert.ToInt16(infoVistaTree.IdJornada);
                cursoInfo.IdSeccion = infoVistaTree.IdSeccion == null ? 0 : Convert.ToInt16(infoVistaTree.IdSeccion);
                if (Accion != Cl_Enumeradores.eTipo_action.grabar)
                {
                    cursoInfo.IdCurso = infoVistaTree.IdCurso == null ? 0 : Convert.ToInt16(infoVistaTree.IdCurso);
                    cursoInfo.DescripcionCurso = infoVistaTree.Nombre;
                    cursoInfo.Estado = infoVistaTree.Estado;
                }

                frm.set_curso(cursoInfo);
                frm.set_Accion(Accion);                
                frm.Show();
                frm.event_FrmAca_Curso_Mant_FormClosing += frm_event_FrmAca_Curso_Mant_FormClosing;
                

            }
            catch (Exception)
            {

                throw;
            }
        }

     

        void FormaParalelo(Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {
                FrmAcaParalelo_Mant frm = new FrmAcaParalelo_Mant();
                Aca_Paralelo_Info paraleloInf = new Aca_Paralelo_Info();                
                
                paraleloInf.IdInstitucion = infoVistaTree.IdInstitucion == null ? 0 : Convert.ToInt16(infoVistaTree.IdInstitucion);
                paraleloInf.IdSede = infoVistaTree.IdSede == null ? 0 : Convert.ToInt16(infoVistaTree.IdSede);
                paraleloInf.IdJornada = infoVistaTree.IdJornada == null ? 0 : Convert.ToInt16(infoVistaTree.IdJornada);
                paraleloInf.IdSeccion = infoVistaTree.IdSeccion == null ? 0 : Convert.ToInt16(infoVistaTree.IdSeccion);
                paraleloInf.IdCurso = infoVistaTree.IdCurso == null ? 0 : Convert.ToInt16(infoVistaTree.IdCurso);

                if (Accion != Cl_Enumeradores.eTipo_action.grabar)
                {
                    paraleloInf.IdParalelo = infoVistaTree.IdParalelo == null ? 0 : Convert.ToInt16(infoVistaTree.IdParalelo);
                    paraleloInf.DescripcionParalelo = infoVistaTree.Nombre;
                    paraleloInf.Estado = infoVistaTree.Estado;
                }

                frm.set_Accion(Accion);
                frm.set_Paralelo(paraleloInf);
                frm.Show();
                frm.event_FrmAca_Paralelo_Mant_FormClosing += frm_event_FrmAca_Paralelo_Mant_FormClosing;

            }
            catch (Exception)
            {

                throw;
            }
        }

    

        #endregion
        
        #region "Eventos"
        private void FrmAcaInstitucion_Mant_Load(object sender, EventArgs e)
        {
            CargarInstitucion();
            LlenarTreeInstitucion();

            switch (Accion)
            {
                case Cl_Enumeradores.eTipo_action.grabar:
                    ucGe_Menu.Enabled_bntAnular = false;
                    ucGe_Menu.Enabled_bntImprimir = false;
                    LimpiarControles();
                    break;
                case Cl_Enumeradores.eTipo_action.actualizar:
                    ucGe_Menu.Enabled_bntAnular = false;
                    break;

                case Cl_Enumeradores.eTipo_action.Anular:
                    ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
                    ucGe_Menu.Enabled_btnGuardar = false;

                    break;
                case Cl_Enumeradores.eTipo_action.consultar:
                    ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
                    ucGe_Menu.Enabled_btnGuardar = false;
                    ucGe_Menu.Enabled_bntAnular = false;
                    break;
            }
        }      

        private void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            guardarDatos();
            this.Close();
        }

        private void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            guardarDatos();
        }

        private void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            Anular();
        }

        private void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }     

        private void treeListSede_AfterFocusNode(object sender, DevExpress.XtraTreeList.NodeEventArgs e)
        {
            try
            {
                TreeListNode nodeSeleccionado = (TreeListNode)e.Node;
                infoVistaTree = new vwAca_Institucion_x_Sede_x_Jorn_x_Sec_Curso_x_Para_Info();

                infoVistaTree = (vwAca_Institucion_x_Sede_x_Jorn_x_Sec_Curso_x_Para_Info)this.treeListSede.GetDataRecordByNode(nodeSeleccionado);             
            }
            catch (Exception)
            {
                
                throw;
            }
        }

       
        private void nuevaSedeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAcaSede_Mant frm = new FrmAcaSede_Mant();
            Aca_Sede_Info infoSede = new Aca_Sede_Info();

            infoSede.IdInstitucion = 
            infoSede.IdSede = infoVistaTree.IdSede == null ? 0 : Convert.ToInt16(infoVistaTree.IdSede);
            infoSede.IdInstitucion = infoVistaTree.IdInstitucion == null ? 0 : Convert.ToInt16(infoVistaTree.IdInstitucion);          
            
            frm.set_Sede(infoSede);
            frm.set_Accion(Cl_Enumeradores.eTipo_action.grabar);
            frm.Show();
            frm.event_FrmAcaSede_Mant_FormClosing += new FrmAcaSede_Mant.delegate_FrmAcaSede_Mant_FormClosing(frm_event_FrmAcaSede_Mant_FormClosing);            
        }

        void frm_event_FrmAcaSede_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            LlenarTreeInstitucion();
        }
        
        void frm_event_FrmAcaSeccion_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            LlenarTreeInstitucion();
        }

        void frm_event_FrmAca_Curso_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            LlenarTreeInstitucion();
        }

        void frm_event_FrmAca_Paralelo_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            LlenarTreeInstitucion();
        }
    
        void frm_event_FrmAcaJornada_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            LlenarTreeInstitucion();
        }
        

        private void nuevaJornada_Click(object sender, EventArgs e)
        {
            try
            {
                FormaJornada(Cl_Enumeradores.eTipo_action.grabar);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error comunicarse con Sistemas " + ex.Message + " ", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void modificarJornada_Click(object sender, EventArgs e)
        {
            try
            {
                llama_frm(Cl_Enumeradores.eTipo_action.actualizar, "Jornada");
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error comunicarse con Sistemas " + ex.Message + " ", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void nuevaSecciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
               FormaSeccion(Cl_Enumeradores.eTipo_action.grabar);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error comunicarse con Sistemas " + ex.Message + " ", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void modificarSecciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                llama_frm(Cl_Enumeradores.eTipo_action.actualizar, "Seccion");
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error comunicarse con Sistemas " + ex.Message + " ", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void nuevoCursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FormaCurso(Cl_Enumeradores.eTipo_action.grabar);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error comunicarse con Sistemas " + ex.Message + " ", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void modificarCursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                llama_frm(Cl_Enumeradores.eTipo_action.actualizar, "Curso");
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error comunicarse con Sistemas " + ex.Message + " ", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void nuevToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Accion = Cl_Enumeradores.eTipo_action.grabar;
            switch (infoVistaTree.Tipo)
            {
                case "Institucion": FormaSede(Accion); break;
                case "Sede": FormaJornada(Accion); break;
                case "Jornada": FormaSeccion(Accion); break;
                case "Seccion": FormaCurso(Accion); break;
                case "Curso": FormaParalelo(Accion); break;
                
            }
        }

        private void treeListSede_MouseUp(object sender, MouseEventArgs e)
        {

            TreeList tree= sender as TreeList;

            if (e.Button == MouseButtons.Right && ModifierKeys == Keys.None && tree.State == TreeListState.Regular)
            {
                Point pt = new Point(e.X, e.Y);
                tree.PointToClient(pt);

                TreeListHitInfo info = tree.CalcHitInfo(pt);

                if (info.HitInfoType == HitInfoType.Cell)
                {      
                    tree.FocusedNode = info.Node;
                }
            }
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            Accion = Cl_Enumeradores.eTipo_action.actualizar;
            switch (infoVistaTree.Tipo)
            {
                case "Sede": FormaSede(Accion); break;
                case "Jornada": FormaJornada(Accion); break;
                case "Seccion": FormaSeccion(Accion); break;
                case "Curso": FormaCurso(Accion); break;
                case "Paralelo": FormaParalelo(Accion); break;
            }
        }

        private void modificarSedeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                llama_frm(Cl_Enumeradores.eTipo_action.actualizar, "Sede");
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error comunicarse con Sistemas " + ex.Message + " ", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void anularSedeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                llama_frm(Cl_Enumeradores.eTipo_action.Anular, "Sede");
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error comunicarse con Sistemas " + ex.Message + " ", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void anularJornadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                llama_frm(Cl_Enumeradores.eTipo_action.Anular, "Jornada");
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error comunicarse con Sistemas " + ex.Message + " ", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void anularSecciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                llama_frm(Cl_Enumeradores.eTipo_action.Anular, "Seccion");
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error comunicarse con Sistemas " + ex.Message + " ", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void anularCursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                llama_frm(Cl_Enumeradores.eTipo_action.Anular, "Curso");
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error comunicarse con Sistemas " + ex.Message + " ", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void anularParaleloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                llama_frm(Cl_Enumeradores.eTipo_action.Anular, "Paralelo");
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error comunicarse con Sistemas " + ex.Message + " ", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void anularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Accion = Cl_Enumeradores.eTipo_action.Anular;
            switch (infoVistaTree.Tipo)
            {
                case "Sede": FormaSede(Accion); break;
                case "Jornada": FormaJornada(Accion); break;
                case "Seccion": FormaSeccion(Accion); break;
                case "Curso": FormaCurso(Accion); break;
                case "Paralelo": FormaParalelo(Accion); break;
            }
        }

        private void nuevoParaleloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FormaParalelo(Cl_Enumeradores.eTipo_action.grabar);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error comunicarse con Sistemas " + ex.Message + " ", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void modificarParaleloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                llama_frm(Cl_Enumeradores.eTipo_action.actualizar, "Paralelo");
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error comunicarse con Sistemas " + ex.Message + " ", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        private void FrmAcaInstitucion_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                event_FrmInstitucion_Mant_FormClosing(sender, e);
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
