using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Core.Erp.Business.Bancos;
using Core.Erp.Business.General;
using Core.Erp.Info.Bancos;
using Core.Erp.Info.General;
using Core.Erp.Winform.CuentasxPagar;

namespace Core.Erp.Winform.Bancos
{
    public partial class FrmBA_Administracion_Archivos_PreAvisoCheques : Form
    {

          #region Atributos y variables
            tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
            cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;


            ba_Archivo_Transferencia_x_PreAviso_Cheq_Bus bus_Archivo_Transferencia = new ba_Archivo_Transferencia_x_PreAviso_Cheq_Bus();
            List<ba_Archivo_Transferencia_x_PreAviso_Cheq_Info> lst_Archivo_Transferencia = new List<ba_Archivo_Transferencia_x_PreAviso_Cheq_Info>();
            ba_Archivo_Transferencia_x_PreAviso_Cheq_Info Info_Arch_x_Tran_PreChe = new ba_Archivo_Transferencia_x_PreAviso_Cheq_Info();


            ba_Archivo_Transferencia_x_PreAviso_Cheq_det_Bus bus_Archivo_Transferencia_Det = new ba_Archivo_Transferencia_x_PreAviso_Cheq_det_Bus();
            List<ba_Archivo_Transferencia_x_PreAviso_Cheq_det_Info> lst_Archivo_Transferencia_Det = new List<ba_Archivo_Transferencia_x_PreAviso_Cheq_det_Info>();

            string EstadoArchivo = string.Empty;
        

        #endregion

        public FrmBA_Administracion_Archivos_PreAvisoCheques()
        {
            InitializeComponent();
            ucGe_Menu.btnNuevo.Caption = "Nuevo Archivo";

        }


     

        void ucGe_Menu_Superior_Mant1_event_btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Info_Arch_x_Tran_PreChe != null)
                {
                    //ba_Archivo_Transferencia_Info Info = new ba_Archivo_Transferencia_Info();
                    //Info = bus_Archivo_Transferencia.Get_Info_Vista_Archivo_transferencia(row.IdEmpresa, row.IdArchivo, row.IdBanco, row.IdProceso_bancario);
                    //if (Info != null)
                    //{
                        
                    //    FrmBA_Actualizar_Archivos_Wizard frm = new FrmBA_Actualizar_Archivos_Wizard();
                    //    frm.event_delegate_FrmBA_Actualizar_Archivos_Wizard_FormClosing += frm_event_delegate_FrmBA_Actualizar_Archivos_Wizard_FormClosing;
                    //    frm.info_Archivo = Info;
                    //    frm.Show();
                    //}

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
                loadDatos();
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
                frmCP_GeneracionFile_Banco_x_cxp_Mant frm = new frmCP_GeneracionFile_Banco_x_cxp_Mant();
                frm.MdiParent = this.MdiParent;
                frm.Set_Accion(Cl_Enumeradores.eTipo_action.grabar);
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

                
                DateTime fechaIni = dteDesde.EditValue==null ? DateTime.Now : (DateTime)dteDesde.EditValue;
                DateTime fechaFin = dteHasta.EditValue == null ? DateTime.Now : (DateTime)dteHasta.EditValue;


               idBancoIni= ucBa_CuentaBanco.get_BaCuentaInfo().IdBanco;
                idBancoFin= ucBa_CuentaBanco.get_BaCuentaInfo().IdBanco;


                lst_Archivo_Transferencia = bus_Archivo_Transferencia.Get_List_Archivo_transferencia(param.IdEmpresa, fechaIni,fechaFin,idBancoIni,idBancoFin);
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

                Info_Arch_x_Tran_PreChe = (ba_Archivo_Transferencia_x_PreAviso_Cheq_Info)gridViewArchivos.GetRow(e.FocusedRowHandle);

                lst_Archivo_Transferencia_Det = bus_Archivo_Transferencia_Det.Get_List_Archivo_Transferencia_x_PreAviso_Cheq_det(param.IdEmpresa, Info_Arch_x_Tran_PreChe.IdArchivo_preaviso_cheq);
                gridControlDetalle.DataSource = lst_Archivo_Transferencia_Det;

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
                if (Info_Arch_x_Tran_PreChe != null)
                {
                    Info_Arch_x_Tran_PreChe.Archivo = bus_Archivo_Transferencia.Get_Archivo
                        (Info_Arch_x_Tran_PreChe.IdEmpresa, Info_Arch_x_Tran_PreChe.IdArchivo_preaviso_cheq);


                    if (Info_Arch_x_Tran_PreChe.Archivo.Length != 0)
                    {
                        Funciones.Crear_y_abrir_Archivo_txt(Info_Arch_x_Tran_PreChe.Archivo, Info_Arch_x_Tran_PreChe.Nom_Archivo);
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

                if (Info_Arch_x_Tran_PreChe != null)
                {
                    Info_Arch_x_Tran_PreChe.Archivo = bus_Archivo_Transferencia.Get_Archivo(Info_Arch_x_Tran_PreChe.IdEmpresa, Info_Arch_x_Tran_PreChe.IdArchivo_preaviso_cheq);

                    if (Info_Arch_x_Tran_PreChe.Archivo.Length != 0)
                    {
                        using (sfd = new SaveFileDialog())
                        {
                            sfd.FileName = Info_Arch_x_Tran_PreChe.Nom_Archivo;
                            sfd.Filter = "(*.txt)|*.txt|All Files (*.*)|*.*";
                            if (sfd.ShowDialog() == DialogResult.OK)
                            {
                                ruta = sfd.FileName;
                                Funciones.Crear_y_abrir_Archivo_txt(Info_Arch_x_Tran_PreChe.Archivo, ruta);
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
                //int idBanco = cmb_Banco.EditValue==null ? 0 : Convert.ToInt32(cmb_Banco.EditValue);
                //if (idBanco != 0)
                //{
                //    lst_Procesos = bus_Proceso.Get_List(idBanco);
                //    cmb_Proceso.Properties.DataSource = lst_Procesos;
                //    if (lst_Procesos.Count == 0)
                //    {
                //        cmb_Proceso.EditValue = null;
                //    }
                //    else
                //        cmb_Proceso.EditValue = lst_Procesos.FirstOrDefault(q => q.IdBanco==idBanco);
                //}
                //else
                //{
                //    cmb_Proceso.Properties.DataSource = bus_Proceso.Get_List();
                //    cmb_Proceso.EditValue = null;
                //}
               
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
            
                //FrmBA_Archivo_Transferencia_Det frm = new FrmBA_Archivo_Transferencia_Det();
                //frm.Set_Info(Info_Arch_x_Tran_PreChe);
                //frm.Show();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void FrmBA_Administracion_Archivos_PreAvisoCheques_Load(object sender, EventArgs e)
        {
            cargarListas();
        }

        private void ucGe_Menu_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                FrmBA_Administracion_Archivos_PreAvisoCheques_Mant frm = new FrmBA_Administracion_Archivos_PreAvisoCheques_Mant();
                frm.MdiParent = this.MdiParent;
                frm.set_Accion(Cl_Enumeradores.eTipo_action.grabar);
                //frm.FormClosing +=  ;
                frm.ShowDialog();
                


            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        private void ucGe_Menu_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {

            }
        }
        
    }
}

