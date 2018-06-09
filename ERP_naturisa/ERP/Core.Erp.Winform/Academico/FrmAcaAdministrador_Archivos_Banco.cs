using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Core.Erp.Winform.Bancos;
using Core.Erp.Business.Bancos;
using Core.Erp.Business.General;
using Core.Erp.Info.Bancos;
using Core.Erp.Info.General;
using Core.Erp.Winform.CuentasxPagar;
using Core.Erp.Info.General;
namespace Core.Erp.Winform.Academico
{
    public partial class FrmAcaAdministrador_Archivos_Banco : Form
    {

        #region Atributos y variables
            tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
            cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
            ba_Archivo_Transferencia_Bus bus_Archivo_Transferencia = new ba_Archivo_Transferencia_Bus();
            List<ba_Archivo_Transferencia_Info> lst_Archivo_Transferencia = new List<ba_Archivo_Transferencia_Info>();

            ba_Archivo_Transferencia_Det_Bus bus_Archivo_Transferencia_Det = new ba_Archivo_Transferencia_Det_Bus();
            List<ba_Archivo_Transferencia_Det_Info> lst_Archivo_Transferencia_Det = new List<ba_Archivo_Transferencia_Det_Info>();

            List<tb_banco_procesos_bancarios_x_empresa_Info> lst_procesos_bancarios = new List<tb_banco_procesos_bancarios_x_empresa_Info>();
            tb_banco_procesos_bancarios_x_empresa_Bus bus_procesos_bancarios = new tb_banco_procesos_bancarios_x_empresa_Bus();

            List<cl_Menu> list_menu = new List<cl_Menu>();
            string EstadoArchivo = string.Empty;
            List<ba_Banco_Cuenta_Info> lst_Cuenta = new List<ba_Banco_Cuenta_Info>();
            ba_Banco_Cuenta_Bus bus_Cuenta = new ba_Banco_Cuenta_Bus();
            ba_Banco_Cuenta_Info info_banco = new ba_Banco_Cuenta_Info();
            ba_Archivo_Transferencia_Info row = new ba_Archivo_Transferencia_Info();
        #endregion

        public FrmAcaAdministrador_Archivos_Banco()
        {
            InitializeComponent();
            ucGe_Menu_Superior_Mant1.event_btnGuardar_y_Salir_Click += ucGe_Menu_Superior_Mant1_event_btnGuardar_y_Salir_Click;
            ucGe_Menu_Superior_Mant1.event_btnSalir_Click += ucGe_Menu_Superior_Mant1_event_btnSalir_Click;
            ucGe_Menu_Superior_Mant1.event_btnActualizar_Click += ucGe_Menu_Superior_Mant1_event_btnActualizar_Click;
            ucGe_Menu_Superior_Mant1.event_btnImprimir_Click += ucGe_Menu_Superior_Mant1_event_btnImprimir_Click;
            ucGe_Menu_Superior_Mant1.btnGuardar_y_Salir.Text = "Nuevo Archivo";
            
        }

        void ucGe_Menu_Superior_Mant1_event_btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                if (tabControlArchivos.SelectedTab == tpCabecera)
                {
                    gridControlArchivos.ShowPrintPreview();
                }
                else
                    gridControlDetalle.ShowPrintPreview();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void ucGe_Menu_Superior_Mant1_event_btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                row = (ba_Archivo_Transferencia_Info)gridViewArchivos.GetFocusedRow();
                if (row != null)
                {
                    ba_Archivo_Transferencia_Info Info = new ba_Archivo_Transferencia_Info();
                    Info = bus_Archivo_Transferencia.Get_Info_Vista_Archivo_transferencia(row.IdEmpresa, row.IdArchivo, row.IdBanco, row.IdProceso_bancario);
                    if (Info != null)
                    {
                        FrmAca_Actualizar_Archivos_Wizard frm = new FrmAca_Actualizar_Archivos_Wizard();
                        frm.MdiParent = this.MdiParent;
                        frm.info_Archivo = Info;
                        frm.Show();
                    }
                }
                else
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_un_registro), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void frm_event_delegate_FrmBA_Actualizar_Archivos_Wizard_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                row = (ba_Archivo_Transferencia_Info)gridViewArchivos.GetFocusedRow();
                if (row == null)
                {
                    MessageBox.Show("Seleccione un registro", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (row.Contabilizado == true)
                {
                    MessageBox.Show("El archivo ya se encuentra contabilizado y no se puede modificar", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                /*
                     FrmAca_Conciliacion_ArchivosPlanos frm = new FrmAca_Conciliacion_ArchivosPlanos();
                        frm.Accion = Cl_Enumeradores.eTipo_action.actualizar;
                        frm.Set(row);
                        frm.MdiParent = this.MdiParent;
                        frm.Show();
               */
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void ucGe_Menu_Superior_Mant1_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Superior_Mant1_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                FrmAcaAdministrador_Archivos_Banco_Mant frm = new FrmAcaAdministrador_Archivos_Banco_Mant();
                frm.MdiParent = this.MdiParent;
                frm.Accion = Cl_Enumeradores.eTipo_action.grabar;
                frm.Show();
                frm.FormClosing += frm_FormClosing;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void frm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                loadDatos();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void FrmBA_Administrador_Archivos_Banco_Load(object sender, EventArgs e)
        {
            try
            {
                if (Cl_Enumeradores.eCliente_Vzen.FJ==param.IdCliente_Ven_x_Default)
                    ucGe_Menu_Superior_Mant1.btn_Actualizar.Visible = true;
                cargarListas();
                loadDatos();
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cargarListas()
        {
            try
            {

                dteDesde.EditValue = DateTime.Now.AddMonths(-1);
                dteHasta.EditValue = DateTime.Now.AddMonths(1);

                lst_Cuenta = bus_Cuenta.Get_list_Banco_Cuenta_Todos(param.IdEmpresa);
                cmb_Banco.Properties.DataSource = lst_Cuenta;
                cmb_Banco.Properties.ValueMember = "IdBanco";
                cmb_Banco.Properties.DisplayMember = "ba_descripcion2";

                lst_procesos_bancarios = bus_procesos_bancarios.Get_list_procesos_bancarios_x_empresa(param.IdEmpresa);
                cmb_Proceso.Properties.DataSource = lst_procesos_bancarios;
                cmb_Proceso.Properties.ValueMember = "IdProceso_bancario_tipo";
                cmb_Proceso.Properties.DisplayMember = "nom_proceso_bancario";

                
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void loadDatos()
        {
            try
            {
                int idBancoIni = 0;
                int idBancoFin = 0;
                string idProceso = string.Empty;
                
                DateTime fechaIni = dteDesde.EditValue==null ? DateTime.Now : (DateTime)dteDesde.EditValue;
                DateTime fechaFin = dteHasta.EditValue == null ? DateTime.Now : (DateTime)dteHasta.EditValue;
                idBancoIni = cmb_Banco.EditValue == null ? 0 : Convert.ToInt32(cmb_Banco.EditValue);
                idBancoFin = cmb_Banco.EditValue == null || Convert.ToInt32(cmb_Banco.EditValue)==0 ? 9999 : Convert.ToInt32(cmb_Banco.EditValue);
                idProceso = cmb_Proceso.EditValue == null ? "" : cmb_Proceso.EditValue.ToString();

                lst_Archivo_Transferencia = bus_Archivo_Transferencia.Get_Vista_Archivo_transferencia(param.IdEmpresa, fechaIni,fechaFin,idBancoIni,idBancoFin,idProceso);

                gridControlArchivos.DataSource = lst_Archivo_Transferencia;

                lst_Archivo_Transferencia_Det = bus_Archivo_Transferencia_Det.Get_List_Vista_Archivo_transferencia_Det(param.IdEmpresa, idBancoIni, idBancoFin, idProceso, fechaIni, fechaFin);

                gridControlDetalle.DataSource = lst_Archivo_Transferencia_Det;
                
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void tlMenu_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            try
            {
                DateTime fechaIni = dteDesde.EditValue == null ? DateTime.Now : (DateTime)dteDesde.EditValue;
                DateTime fechaFin = dteHasta.EditValue == null ? DateTime.Now : (DateTime)dteHasta.EditValue;

                switch (e.Node.Id)
                {
                    case 0:
                        EstadoArchivo = "";
                        loadDatos();
                        break;
                    case 1:
                        EstadoArchivo = "";
                        break;
                    case 2:
                        EstadoArchivo = "FIL_EMITID";
                        lst_Archivo_Transferencia = bus_Archivo_Transferencia.Get_Vista_Archivo_transferencia_x_Estado(EstadoArchivo,fechaIni,fechaFin);
                        break;
                    case 3:
                        EstadoArchivo = "FIL_ACTUA";
                        lst_Archivo_Transferencia = bus_Archivo_Transferencia.Get_Vista_Archivo_transferencia_x_Estado(EstadoArchivo,fechaIni,fechaFin);
                        break;
                    default:
                        break;
                }
                gridControlArchivos.DataSource = lst_Archivo_Transferencia;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void gridViewArchivos_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                row = (ba_Archivo_Transferencia_Info)gridViewArchivos.GetRow(e.FocusedRowHandle);                

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            try
            {
                if (row != null)
                {
                    row.Archivo = bus_Archivo_Transferencia.Get_Archivo(row.IdEmpresa, row.IdArchivo,row.IdProceso_bancario,row.IdBanco);

                    if (row.Archivo.Length != 0)
                    {
                        Funciones.Crear_y_abrir_Archivo_txt(row.Archivo, row.Nom_Archivo);
                    }
                    else
                        MessageBox.Show("El archivo seleccionado no existe", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void btnDescargar_Click(object sender, EventArgs e)
        {
            try
            {
                string ruta = string.Empty;

                if (row != null)
                {
                    row.Archivo = bus_Archivo_Transferencia.Get_Archivo(row.IdEmpresa, row.IdArchivo,row.IdProceso_bancario,row.IdBanco);

                    if (row.Archivo.Length != 0)
                    {
                        using (sfd = new SaveFileDialog())
                        {
                            sfd.FileName = row.Nom_Archivo;
                            sfd.Filter = "(*.txt)|*.txt|All Files (*.*)|*.*";
                            if (sfd.ShowDialog() == DialogResult.OK)
                            {
                                ruta = sfd.FileName;
                                Funciones.Crear_y_abrir_Archivo_txt(row.Archivo, ruta);
                            }
                        }

                    }
                    else
                        MessageBox.Show("El archivo seleccionado no existe", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                loadDatos();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void cmb_Banco_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                
                int IdCuenta = cmb_Banco.EditValue==null ? 0 : Convert.ToInt32(cmb_Banco.EditValue);
                info_banco = lst_Cuenta.FirstOrDefault(q => q.IdBanco == IdCuenta);

                if (info_banco != null)
                {
                    lst_procesos_bancarios = bus_procesos_bancarios.Get_list_procesos_bancarios_x_empresa(param.IdEmpresa, Convert.ToInt32(info_banco.IdBanco_Financiero));
                    cmb_Proceso.Properties.DataSource = lst_procesos_bancarios;
                    if (lst_procesos_bancarios.Count == 0)
                    {
                        cmb_Proceso.EditValue = null;
                    }
                    else
                        cmb_Proceso.EditValue = lst_procesos_bancarios.FirstOrDefault().IdProceso_bancario_tipo;
                }
                else
                {
                    cmb_Proceso.Properties.DataSource = bus_procesos_bancarios.Get_list_procesos_bancarios_x_empresa(param.IdEmpresa);
                    cmb_Proceso.EditValue = null;
                }
               
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void btnVerBloc_Click(object sender, EventArgs e)
        {
            try
            {
                FrmBA_Archivo_Transferencia_Det frm = new FrmBA_Archivo_Transferencia_Det();
                frm.Set_Info(row);
                frm.Show();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void ucGe_Menu_Superior_Mant1_event_btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                row = (ba_Archivo_Transferencia_Info)gridViewArchivos.GetFocusedRow();
                if (row == null)
                {
                    MessageBox.Show("Seleccione un registro", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (row.Contabilizado == true)
                {
                    MessageBox.Show("El archivo ya se encuentra contabilizado y no se puede modificar", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                
                switch (row.IdProceso_bancario)
                {
                    default:
                        FrmAcaAdministrador_Archivos_Banco_Mant frm = new FrmAcaAdministrador_Archivos_Banco_Mant();
                        frm.Accion = Cl_Enumeradores.eTipo_action.actualizar;
                        frm.Set(row);                        
                        frm.MdiParent = this.MdiParent;
                        frm.Show();
                        break;
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void gridViewArchivos_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            try
            {
                row = (ba_Archivo_Transferencia_Info)gridViewArchivos.GetRow(e.RowHandle);
                if (row == null) return;
                if (row.Contabilizado == true) e.Appearance.ForeColor = Color.Blue;                
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }        
    }

    public class cl_Menu
    {
        public int IdMenu { get; set; }
        public int IdMenu_Padre { get; set; }
        public string nom_menu { get; set; }
        public int posicion { get; set; }
        public int ImageIndex { get; set; }

        public cl_Menu(int _IdMenu, int _IdMenu_Padre, int _ImageIndex, string _nom_menu, int _posicion)
        {
            IdMenu = _IdMenu;
            IdMenu_Padre = _IdMenu_Padre;
            ImageIndex = _ImageIndex;
            nom_menu = _nom_menu;
            posicion = _posicion;
        }

    }   

}
