using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using DevExpress.XtraEditors;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
 

namespace Core.Erp.Winform.General
{
    public partial class frmGe_Provinvia_Mant : DevExpress.XtraEditors.XtraForm
    {
        public cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        tb_pais_Bus busPais = new tb_pais_Bus();
        List<tb_pais_Info> lstPais = new List<tb_pais_Info>();
        tb_Provincia_Bus busProvincia = new tb_Provincia_Bus();
        tb_provincia_Info InfoPro = new tb_provincia_Info();

        tb_region_Bus bus_region = new tb_region_Bus();
        List<tb_region_Info> lista_region = new List<tb_region_Info>();
        Cl_Enumeradores.eTipo_action _Accion;
        public delegate void delegate_frmGe_Provinvia_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmGe_Provinvia_Mant_FormClosing event_frmGe_Provinvia_Mant_FormClosing;
        public string IdPais { get; set; }

        public frmGe_Provinvia_Mant()
        {
            InitializeComponent();
            ucGe_Menu.event_btnAnular_Click += ucGe_Menu_event_btnAnular_Click;
            ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
            ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
            ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
            ucGe_Menu.event_btnlimpiar_Click += ucGe_Menu_event_btnlimpiar_Click;
            event_frmGe_Provinvia_Mant_FormClosing += frmGe_Provinvia_Mant_event_frmGe_Provinvia_Mant_FormClosing;

            CargarCombo();
        }

        void ucGe_Menu_event_btnlimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                LimpiarDatos();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void frmGe_Provinvia_Mant_event_frmGe_Provinvia_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (GuardarData())
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                GuardarData();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblAnulado.Visible)
                {
                    MessageBox.Show("El registro ya se encuentra anulado", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ucGe_Menu.Enabled_bntAnular = false;
                }
                else                
                    AnularDatos();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void frmGe_Provinvia_Mant_Load(object sender, EventArgs e)
        {
            try
            {
               
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        if (IdPais != null)
                            cmbPais.EditValue = IdPais;
                        ucGe_Menu.Enabled_bntAnular = false;
                        ucGe_Menu.Enabled_bntImprimir = false;
                        break;

                    case Cl_Enumeradores.eTipo_action.actualizar:
                        ucGe_Menu.Enabled_bntAnular = false;
                        ucGe_Menu.Enabled_bntImprimir = false;
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
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        void CargarCombo()
        {
            try
            {
                lstPais = busPais.Get_List_pais();

                lista_region = bus_region.Get_List_Region();
                cmbPais.Properties.DataSource = lstPais;

                cmb_region.Properties.DataSource = lista_region;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        Boolean GuardarData()
        {
            try
            {
                Boolean bolResult = false;
                string IdProvincia = "";
                string msjError = "";
                if (ValidarDatos())
                {
                    GetInfo();
                    switch (_Accion)
                    {
                        case Cl_Enumeradores.eTipo_action.grabar:
                            if (busProvincia.Guardar_DB(InfoPro, ref IdProvincia, ref msjError))
                            {
                                txtIdProvincia.EditValue = IdProvincia;
                                //ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
                                //ucGe_Menu.Enabled_btnGuardar = false;
                                bolResult = true;
                                MessageBox.Show("Se Guardo Exitosamente la Provincia # " + IdProvincia, "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LimpiarDatos();
                            }
                            else
                                MessageBox.Show(msjError, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            break;
                        case Cl_Enumeradores.eTipo_action.actualizar:
                           
                            InfoPro.Fecha_UltMod = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                            InfoPro.IdUsuarioUltMod = param.IdUsuario;

                            if (busProvincia.Modificar_DB(InfoPro, ref msjError))
                            {
                                //ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
                                //ucGe_Menu.Enabled_btnGuardar = false;
                                bolResult = true;
                                MessageBox.Show("Se Modifico Exitosamente la Provincia", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LimpiarDatos();
                            }
                            else
                                MessageBox.Show(msjError, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            break;
                    }
                }
                return bolResult;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        void LimpiarDatos()
        {
            try
            {
                _Accion = Cl_Enumeradores.eTipo_action.grabar;
                InfoPro = new tb_provincia_Info();
                cmbPais.EditValue = null;
                txtIdProvincia.EditValue = "";
                txtCodProvincia.EditValue = "";
                txtDescripcion.EditValue = "";

                
            }
            catch (Exception ex)
            { 
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        Boolean ValidarDatos()
        {
            try
            {
                if (cmbPais.EditValue == null || cmbPais.EditValue == "")
                {
                    MessageBox.Show("Seleccione el País", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbPais.Focus();
                    return false;
                }

                if (txtDescripcion.EditValue == null || txtDescripcion.EditValue == "")
                {
                    MessageBox.Show("Ingrese el Nombre de la Provincia", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDescripcion.Focus();
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

        Boolean AnularDatos()
        {
            try
            {
                Boolean bolResult = false;
                string msjError = "";
                if (ValidarDatos())
                {
                    GetInfo();
                    FrmGe_MotivoAnulacion frm = new FrmGe_MotivoAnulacion();
                    frm.ShowDialog();
                    InfoPro.MotivoAnula = frm.motivoAnulacion;
                    InfoPro.Fecha_UltAnu = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                    InfoPro.IdUsuarioUltAnu = param.IdUsuario;

                    if (busProvincia.Anular_DB(InfoPro,  ref msjError))
                    {
                        ucGe_Menu.Enabled_bntAnular = false;
                        bolResult = true;
                        lblAnulado.Visible = true;
                        MessageBox.Show("Se Anulo Exitosamente la Provincia", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                        MessageBox.Show(msjError, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                return bolResult;
            }
            catch (Exception ex)
            {
                                Log_Error_bus.Log_Error(ex.ToString());
                                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        void GetInfo()
        {
            try
            {
                InfoPro.IdPais = Convert.ToString(cmbPais.EditValue);
                InfoPro.IdProvincia = (txtIdProvincia.EditValue == "") ? null : Convert.ToString(txtIdProvincia.EditValue);
                InfoPro.CodProvincia = (txtCodProvincia.EditValue == "") ? null : Convert.ToString(txtCodProvincia.EditValue);
                InfoPro.Descripcion = Convert.ToString(txtDescripcion.EditValue);

                InfoPro.IdUsuario = param.IdUsuario;
                InfoPro.Fecha_Transac = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                InfoPro.nom_pc = param.nom_pc;
                InfoPro.ip = param.ip;
                InfoPro.IdUsuarioUltMod = param.IdUsuario;
                InfoPro.Fecha_UltMod = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                if( cmb_region.EditValue!=null)
                InfoPro.Cod_Region =Convert.ToString( cmb_region.EditValue);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void SeInfo(tb_provincia_Info Info_Provi)
        {
            try
            {
                cmbPais.EditValue = Info_Provi.IdPais;
                txtIdProvincia.EditValue = Info_Provi.IdProvincia;
                txtCodProvincia.EditValue = Info_Provi.CodProvincia;
                txtDescripcion.EditValue = Info_Provi.Descripcion;
                cmb_region.EditValue = Info_Provi.Cod_Region;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void setAccion(Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {
                _Accion = Accion;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmGe_Provinvia_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                frmGe_Provinvia_Mant_event_frmGe_Provinvia_Mant_FormClosing(sender, e);
                event_frmGe_Provinvia_Mant_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void searchLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void labelControl5_Click(object sender, EventArgs e)
        {

        }   

    }
}