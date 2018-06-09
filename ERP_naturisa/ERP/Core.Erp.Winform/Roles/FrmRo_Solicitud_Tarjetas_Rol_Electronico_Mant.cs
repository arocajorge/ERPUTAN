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
using Core.Erp.Business.Roles;
using Core.Erp.Info.Roles;
using Core.Erp.Info.General;
using Core.Erp.Info.Bancos;
using Core.Erp.Business.Bancos;
using Core.Erp.Info.Roles.Archivos_para_Bancos;
using Core.Erp.Business.Roles.Archivos_para_Bancos;

namespace Core.Erp.Winform.Roles
{
    public partial class FrmRo_Solicitud_Tarjetas_Rol_Electronico_Mant : Form
    {
        #region Variables

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        private Cl_Enumeradores.eTipo_action Accion;

        //para llenar la grilla
        BindingList<ro_Empleado_Info> BindInfo = new BindingList<ro_Empleado_Info>();
        ro_Empleado_Bus BusInfo = new ro_Empleado_Bus();
        //para llenar el combo de departamento
        List<ro_Departamento_Info> ListDepar = new List<ro_Departamento_Info>();
        ro_Departamento_Bus Depar_Bus = new ro_Departamento_Bus();
        //para llenar el combo de nomina
        List<ro_Nomina_Tipo_Info> ListNomina = new List<ro_Nomina_Tipo_Info>();
        ro_Nomina_Tipo_Bus Bus_Nomina = new ro_Nomina_Tipo_Bus();
        //para llenar el combo de estado del empleado
        List<ro_Catalogo_Info> ListCatalogo = new List<ro_Catalogo_Info>();
        ro_Catalogo_Bus Bus_Catalogo = new ro_Catalogo_Bus();
        //para llenar los datos de transferencias de archivos cabecera y detalle
        ba_Archivo_Transferencia_Info Transfer = new ba_Archivo_Transferencia_Info();
        ba_Archivo_Transferencia_Bus BusTransfer = new ba_Archivo_Transferencia_Bus();
        List<ba_Archivo_Transferencia_Det_Info> Det_Transfer = new List<ba_Archivo_Transferencia_Det_Info>();
        ba_Archivo_Transferencia_Det_Bus ArchivoDeta_Bus = new ba_Archivo_Transferencia_Det_Bus();
        tb_Empresa_Bus BusEmpresa = new tb_Empresa_Bus();
        tb_Empresa_Info InfoEmpresa = new tb_Empresa_Info();
        //lista ro_Solicitud_Tarjeta_Guayaquil_Info para el archivo plano
        List<ro_Solicitud_Tarjeta_Guayaquil_Info> Lista_Tarjeta = new List<ro_Solicitud_Tarjeta_Guayaquil_Info>();
        ro_Solicitud_Tarjeta_Guayaquil_Bus TarjetaBus = new ro_Solicitud_Tarjeta_Guayaquil_Bus();

        string mensaje = "";
        public string patch = "";
        public string NombreArchivo = "";

        int IdTipoNominaIni = 0;
        int IdTipoNominaFin = 0;
        int IdDepartamentoIni = 0;
        int IdDepartamentoFin = 0;
        string em_status = "";

        #region Delegados
        public delegate void delegate_FrmRo_Solicitud_Tarjetas_Rol_Electronico_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_FrmRo_Solicitud_Tarjetas_Rol_Electronico_Mant_FormClosing event_FrmRo_Solicitud_Tarjetas_Rol_Electronico_Mant_FormClosing;
        #endregion

        #endregion

        public FrmRo_Solicitud_Tarjetas_Rol_Electronico_Mant()
        {
            InitializeComponent();
            event_FrmRo_Solicitud_Tarjetas_Rol_Electronico_Mant_FormClosing += FrmRo_Solicitud_Tarjetas_Rol_Electronico_Mant_event_FrmRo_Solicitud_Tarjetas_Rol_Electronico_Mant_FormClosing;
        }

        void FrmRo_Solicitud_Tarjetas_Rol_Electronico_Mant_event_FrmRo_Solicitud_Tarjetas_Rol_Electronico_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        #region Metodos Set y Get

        public void set_Accion(Cl_Enumeradores.eTipo_action iAccion)
        {
            try
            {
                Accion = iAccion;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error comunicarse con Sistemas " + ex.Message + " ", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Set_Archivo(ba_Archivo_Transferencia_Info Info)
        {
            try
            {
                Transfer = Info;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error comunicarse con Sistemas " + ex.Message + " ", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public ba_Archivo_Transferencia_Info Get_Archivo()
        {
            try
            {
                int Id = 0;
                Id = BusTransfer.GetId(param.IdEmpresa);
                Transfer = new ba_Archivo_Transferencia_Info();
                BusTransfer = new ba_Archivo_Transferencia_Bus();
                Transfer.IdEmpresa = param.IdEmpresa;
                Transfer.IdArchivo = 0;
                //Transfer.IdBanco = ucBa_Proceso_x_Banco.get_Proceso_Info().IdBanco;
                //Transfer.IdProceso_bancario = ucBa_Proceso_x_Banco.get_Proceso_Info().IdProceso_bancario;
                Transfer.Origen_Archivo = "RRHH";
                Transfer.Cod_Empresa = "B1E";
                Transfer.Fecha = dtFechaSubida.Value;
                Transfer.Fecha_Transac = param.Fecha_Transac;
                //Transfer.Nom_Archivo = ucBa_Proceso_x_Banco.get_Proceso_Info().IdProceso_bancario.ToString() + DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString().PadLeft(2, '0') + DateTime.Now.Day.ToString().PadLeft(2, '0') + Transfer.Cod_Empresa.ToString() + "_" + BusTransfer.GetId_codigoArchivo(param.IdEmpresa, dtFechaSubida.Value) + ".txt";
                Transfer.Estado = true;
                Transfer.IdEstadoArchivo_cat = "FIL_EMITID";
                Transfer.Observacion = txtObservacion.Text;
                NombreArchivo = Transfer.Nom_Archivo;
                return Transfer;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                mensaje = ex.Message.ToString();
                MessageBox.Show("Error " + mensaje, "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return new ba_Archivo_Transferencia_Info();
            }
        }

        public List<ba_Archivo_Transferencia_Det_Info> GetList_Archivo_Detalle(int IdArchivo)
        {
            try
            {
                int i=0;
                var Detalle = BindInfo.Where(v => v.check == true).ToList();
                List<ba_Archivo_Transferencia_Det_Info> ListDetalle = new List<ba_Archivo_Transferencia_Det_Info>();

                foreach (var item in Detalle)
                {
                    i++;
                    ba_Archivo_Transferencia_Det_Info Info = new ba_Archivo_Transferencia_Det_Info();
                    Info.IdEmpresa = Transfer.IdEmpresa;
                    Info.IdArchivo = IdArchivo;
                    Info.IdProceso_bancario = Transfer.IdProceso_bancario;
                    Info.Secuencia = i;
                    Info.IdEmpresaNomina = item.IdEmpresa;
                    Info.IdEmpleado = Convert.ToInt32(item.IdEmpleado);
                    Info.IdNominaTipo = item.IdNomina_Tipo;
                    Info.Valor = 0;
                    Info.IdEstadoRegistro_cat = "REG_EMITI";
                    Info.Estado = true;
                    ListDetalle.Add(Info);
                }

                return ListDetalle;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                mensaje = ex.Message.ToString();
                MessageBox.Show("Error " + mensaje, "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                throw new Exception();
            }
        }

        public void GetArchivoPlano()
        {
            try
            {
                Lista_Tarjeta = new List<ro_Solicitud_Tarjeta_Guayaquil_Info>();

                InfoEmpresa=BusEmpresa.Get_Info_Empresa(param.IdEmpresa);

                ro_Solicitud_Tarjeta_Guayaquil_Info Info_ = new ro_Solicitud_Tarjeta_Guayaquil_Info();
                if (InfoEmpresa.RazonSocial.Length > 38)
                    Info_.Nombre = InfoEmpresa.RazonSocial.Substring(0, 38).ToUpper().Replace('Ñ', 'N');
                else
                    Info_.Nombre = InfoEmpresa.RazonSocial.PadRight(38, ' ').ToUpper().Replace('Ñ', 'N');
                Info_.TipoRegistro = "C";
                Info_.Monto = "0000000000000";
                Info_.CodigoEmpresa = "1M";
                Info_.CodigoEmpleado = ucBa_Proceso_x_Banco.get_BaCuentaInfo().ba_Num_Cuenta.PadLeft(10, '0');
                Info_.CobroServicio = "C";
                Info_.Fecha = Convert.ToDateTime(dtFechaSubida.Value).Year.ToString() + Convert.ToDateTime(dtFechaSubida.Value).Month.ToString().PadLeft(2, '0') + Convert.ToDateTime(dtFechaSubida.Value).Day.ToString().PadLeft(2, '0') +Convert.ToString(BindInfo.Where(v=>v.check==true).Count().ToString().PadLeft(5,'0'));
                Lista_Tarjeta.Add(Info_);
                
                foreach (var item in BindInfo)
                {
                    ro_Solicitud_Tarjeta_Guayaquil_Info Info = new ro_Solicitud_Tarjeta_Guayaquil_Info();
                    if (item.InfoPersona.pe_nombreCompleto.Length > 17)
                        Info.Nombre = item.InfoPersona.pe_nombreCompleto.ToUpper().Replace('Ñ', 'N').Substring(0, 17);
                    else
                        Info.Nombre = item.InfoPersona.pe_nombreCompleto.ToUpper().Replace('Ñ', 'N').PadRight(17, ' ');
                    Info.TipoRegistro = "D";
                    Info.Monto = "0000000000000";
                    Info.CodigoEmpresa = "1M";
                    Info.CodigoEmpleado = item.InfoPersona.pe_cedulaRuc;
                    Info.CodigoProceso = "N";
                    Info.Email = item.em_mail;
                    Info.CobroServicio = "C";
                    Info.Filler = "                    ";
                    Info.Filler2 = "          ";
                    Lista_Tarjeta.Add(Info);
                }
                patch = btnRuta.Text;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                mensaje = ex.Message.ToString();
                MessageBox.Show("Error " + mensaje, "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                throw new Exception();
            }
        }

        #endregion

        public Boolean Grabar()
        {
            try
            {
                int archivo=0;
                bool resultado = false;
                ba_Archivo_Transferencia_Info ArchivoInfo = new ba_Archivo_Transferencia_Info();
                List<ba_Archivo_Transferencia_Det_Info> DetalleArchivoInfo = new List<ba_Archivo_Transferencia_Det_Info>();
                ArchivoInfo = Get_Archivo();
                if(BusTransfer.GrabarDB(ArchivoInfo, ref archivo))
                {
                    DetalleArchivoInfo = GetList_Archivo_Detalle(archivo);
                    if (ArchivoDeta_Bus.GrabarDB(DetalleArchivoInfo))
                    {
                        GetArchivoPlano();
                        TarjetaBus.Generar_Solicitud_Tarjeta_Banco_Guayaquil(Lista_Tarjeta, patch, NombreArchivo);
                        MessageBox.Show("Datos guardados exitosamente", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        resultado = true;
                    }
                }
                return resultado;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                mensaje = ex.Message.ToString();
                MessageBox.Show("Error " + mensaje, "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                throw new Exception();
            }
        }

        public void Cargar_Combos()
        {
            try
            {
                //cargo la nomina
                ListNomina = new List<ro_Nomina_Tipo_Info>();
                Bus_Nomina = new ro_Nomina_Tipo_Bus();
                ro_Nomina_Tipo_Info InfoNomina = new ro_Nomina_Tipo_Info();
                InfoNomina.IdNomina_Tipo = 0;
                InfoNomina.Descripcion = "TODOS";
                ListNomina = Bus_Nomina.Get_List_Nomina_Tipo(param.IdEmpresa);
                ListNomina.Add(InfoNomina);
                cmbNomina.Properties.DataSource = ListNomina;

                //cargo el departamento
                ListDepar = new List<ro_Departamento_Info>();
                Depar_Bus = new ro_Departamento_Bus();
                ro_Departamento_Info InfoDepar = new ro_Departamento_Info();
                InfoDepar.IdDepartamento = 0;
                InfoDepar.de_descripcion = "TODOS";
                ListDepar= Depar_Bus.Get_List_Departamento(param.IdEmpresa);
                ListDepar.Add(InfoDepar);
                cmbDepartamento.Properties.DataSource=ListDepar;

                //cargo el estado del empleado
                ListCatalogo = new List<ro_Catalogo_Info>();
                Bus_Catalogo = new ro_Catalogo_Bus();
                ro_Catalogo_Info InfoCatalogo = new ro_Catalogo_Info();
                InfoCatalogo.CodCatalogo = "";
                InfoCatalogo.ca_descripcion = "TODOS";
                ListCatalogo = Bus_Catalogo.Get_List_Catalogo_x_Tipo(33);
                ListCatalogo.Add(InfoCatalogo);
                cmbEstado_Empleado.Properties.DataSource = ListCatalogo;

                //control banco
                ucBa_Proceso_x_Banco.cargar_CuentaBanco();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        public void Cargar_Grid()
        {
            try
            {
                //Nomina
                IdTipoNominaIni = (Convert.ToInt32(cmbNomina.EditValue) == 0) ? 0 : Convert.ToInt32(cmbNomina.EditValue);
                IdTipoNominaFin = (Convert.ToInt32(cmbNomina.EditValue) == 0) ? 99999 : Convert.ToInt32(cmbNomina.EditValue);
                //Departamento
                IdDepartamentoIni = (Convert.ToInt32(cmbDepartamento.EditValue) == 0) ? 0 : Convert.ToInt32(cmbDepartamento.EditValue);
                IdDepartamentoFin = (Convert.ToInt32(cmbDepartamento.EditValue) == 0) ? 99999 : Convert.ToInt32(cmbDepartamento.EditValue);
                //Estado de Empleado
                em_status = (Convert.ToString(cmbEstado_Empleado.EditValue) == "") ? "" : Convert.ToString(cmbEstado_Empleado.EditValue);

                BindInfo = new BindingList<ro_Empleado_Info>();
                BusInfo = new ro_Empleado_Bus();
                BindInfo = new BindingList<ro_Empleado_Info>(BusInfo.Get_List_Solicitud_Tarjeta(param.IdEmpresa, IdTipoNominaIni, IdTipoNominaFin, IdDepartamentoIni, IdDepartamentoFin, em_status, ref mensaje));
                gridControlSol_Tarjetas_Rol.DataSource = BindInfo;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        public void Limpiar()
        {
            try
            {
                ucBa_Proceso_x_Banco.SetIdBanco(0);
                ucBa_Proceso_x_Banco.SetIdProceso("");
                cmbNomina.EditValue = "";
                cmbDepartamento.EditValue = "";
                cmbEstado_Empleado.EditValue = "";
                btnRuta.Text = "";
                gridControlSol_Tarjetas_Rol.DataSource = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        public Boolean Validar()
        {
            try
            {
                if (cmbNomina.EditValue == null)
                {
                    MessageBox.Show("Selecione un tipo de Nomina", "Operación Fallida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbNomina.Focus();
                    return false;
                }

                if (cmbDepartamento.EditValue == null)
                {
                    MessageBox.Show("Seleccione un Departamento", "Operación Fallida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbDepartamento.Focus();
                    return false;
                }

                if (cmbEstado_Empleado.EditValue == null)
                {
                    MessageBox.Show("Seleccione un estado", "Operación Fallida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbEstado_Empleado.Focus();
                    return false;
                }

                if (ucBa_Proceso_x_Banco.cmb_Banco.EditValue == null)
                {
                    MessageBox.Show("Seleccione un Banco", "Operación Fallida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ucBa_Proceso_x_Banco.cmbProceso.Focus();
                    return false;
                }

                if (ucBa_Proceso_x_Banco.cmbProceso.EditValue == null)
                {
                    MessageBox.Show("Seleccione un Proceso", "Operación Fallida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ucBa_Proceso_x_Banco.cmbProceso.Focus();
                    return false;
                }

                if (btnRuta.EditValue == null || btnRuta.Text == "")
                {
                    MessageBox.Show("Seleccione la ruta donde se va a guardar el archivo", "Operación Fallida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ucBa_Proceso_x_Banco.cmbProceso.Focus();
                    return false;
                }

                if (txtObservacion.Text == "")
                {
                    MessageBox.Show("Ingrese una Observación.", "Operación Fallida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ucBa_Proceso_x_Banco.cmbProceso.Focus();
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                mensaje = ex.Message.ToString();
                MessageBox.Show("Error " + mensaje, "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                throw new Exception();
            }
        }

        public Boolean Grabar_Datos()
        {
            try
            {
                if (Validar())
                    return Grabar();
                return false;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                mensaje = ex.Message.ToString();
                MessageBox.Show("Error " + mensaje, "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                throw new Exception();
            }
        }

        private void FrmRo_Solicitud_Tarjetas_Rol_Electronico_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                btnRuta.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\";
                Cargar_Combos();
                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        ucGe_Menu_Superior_Mant.Enabled_bntAnular = false;
                        ucGe_Menu_Superior_Mant.Enabled_bntImprimir = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        ucGe_Menu_Superior_Mant.Enabled_btnGuardar = false;
                        ucGe_Menu_Superior_Mant.Enabled_bntAnular = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        ucGe_Menu_Superior_Mant.Enabled_bntGuardar_y_Salir = false;
                        ucGe_Menu_Superior_Mant.Enabled_btnGuardar = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        ucGe_Menu_Superior_Mant.Enabled_bntGuardar_y_Salir = false;
                        ucGe_Menu_Superior_Mant.Enabled_btnGuardar = false;
                        ucGe_Menu_Superior_Mant.Enabled_bntAnular = false;
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void FrmRo_Solicitud_Tarjetas_Rol_Electronico_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                event_FrmRo_Solicitud_Tarjetas_Rol_Electronico_Mant_FormClosing(sender, e);
            }
            catch (Exception ex)
            {

            }
        }

        private void btnCargar_Datos_Click(object sender, EventArgs e)
        {
            try
            {
                Cargar_Grid();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void btnRuta_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                using (FolderBrowserDialog dlg = new FolderBrowserDialog())
                {
                    dlg.Description = "Seleccione la Ruta donde va a guardar";
                    if (dlg.ShowDialog() == DialogResult.OK)
                        btnRuta.Text = dlg.SelectedPath + @"\";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void ucGe_Menu_Superior_Mant_event_btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ucGe_Menu_Superior_Mant_event_btnlimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void ucGe_Menu_Superior_Mant_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            if (Grabar())
                Close();
        }

        private void btngenerar_Click(object sender, EventArgs e)
        {
            int archivo = 0;
            ba_Archivo_Transferencia_Info ArchivoInfo = new ba_Archivo_Transferencia_Info();
            List<ba_Archivo_Transferencia_Det_Info> DetalleArchivoInfo = new List<ba_Archivo_Transferencia_Det_Info>();
            ArchivoInfo = Get_Archivo();
            DetalleArchivoInfo = GetList_Archivo_Detalle(archivo);
            GetArchivoPlano();
            TarjetaBus.Generar_Solicitud_Tarjeta_Banco_Guayaquil(Lista_Tarjeta, patch, NombreArchivo);
        }

        private void ucGe_Menu_Superior_Mant_event_btnGuardar_Click(object sender, EventArgs e)
        {
            if (Grabar())
                Limpiar();
        }
    }
}
