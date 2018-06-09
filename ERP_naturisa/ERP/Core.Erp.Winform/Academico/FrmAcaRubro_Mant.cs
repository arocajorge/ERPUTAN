using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Core.Erp.Info.Academico;
using Core.Erp.Business.Academico;
using Core.Erp.Business.General;
using Core.Erp.Winform.General;
using Core.Erp.Info.Contabilidad;

namespace Core.Erp.Winform.Academico
{
    public partial class FrmAcaRubro_Mant : Form
    {
        #region "Variables"
        private Cl_Enumeradores.eTipo_action Accion;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        Aca_Rubro_Info rubroInfo = new Aca_Rubro_Info();

        public delegate void delegate_FrmAcaRubro_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_FrmAcaRubro_Mant_FormClosing event_FrmAcaRubro_Mant_FormClosing;

        BindingList<Aca_Rubro_x_Aca_Periodo_Lectivo_Info> Lista_Periodo_x_Rubro = new BindingList<Aca_Rubro_x_Aca_Periodo_Lectivo_Info>();
        Aca_Rubro_x_Aca_Periodo_Lectivo_Bus Periodo_x_Rubro_Bus = new Aca_Rubro_x_Aca_Periodo_Lectivo_Bus();
        List<Aca_Rubro_x_Aca_Periodo_Lectivo_Info> BLista_Periodo_x_rubro = new List<Aca_Rubro_x_Aca_Periodo_Lectivo_Info>();
        Aca_Rubro_x_Aca_Periodo_Lectivo_Info InfoRubroPeriodo = new Aca_Rubro_x_Aca_Periodo_Lectivo_Info();

        Aca_RubroTipo_Bus BusTipoRubro = new Aca_RubroTipo_Bus();
        List<Aca_RubroTipo_Info> Lista_TipoRubro = new List<Aca_RubroTipo_Info>();

        Aca_Periodo_Bus BusPeriodo = new Aca_Periodo_Bus();
        Aca_Periodo_Info Info_Periodo = new Aca_Periodo_Info();
        List<Aca_Periodo_Info> List_Periodo = new List<Aca_Periodo_Info>();
        ct_Centro_costo_Info Centro_cos_info = new ct_Centro_costo_Info();




        #endregion

        #region "Constructor"
        public FrmAcaRubro_Mant()
        {
            InitializeComponent();
            event_FrmAcaRubro_Mant_FormClosing += FrmAcaRubro_Mant_event_FrmAcaRubro_Mant_FormClosing;
            ucCon_CentroCosto_ctas_Movi1.Event_cmbCentroCosto_EditValueChanged += ucCon_CentroCosto_ctas_Movi1_Event_cmbCentroCosto_EditValueChanged;
        }

        public void ucCon_CentroCosto_ctas_Movi1_Event_cmbCentroCosto_EditValueChanged(object sender, EventArgs e)
        {
            Centro_cos_info = ucCon_CentroCosto_ctas_Movi1.InfoCentroCosto;
        }

        void FrmAcaRubro_Mant_event_FrmAcaRubro_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
        #endregion

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
        public void set_Rubro(Aca_Rubro_Info info)
        {
            try
            {
                rubroInfo = info;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region"Get"
        public Aca_Rubro_Info GetRubro(ref string mensaje)
        {
            Aca_Rubro_Info rInfo = new Aca_Rubro_Info();
            try
            {

                rInfo.IdInstitucion = param.IdInstitucion;
                rInfo.IdRubro = (txtIdRubro.Text != "") ? Convert.ToInt32(txtIdRubro.Text) : 0;
                rInfo.Descripcion_rubro = txtDescripcionRubro.Text;
                rInfo.Deb_cred = cmbDebeHaber.EditValue.ToString();
                rInfo.CodRubro = txtCodigoRubro.Text;
                rInfo.IdGrupoFE = Convert.ToInt16(cmbFEE.EditValue.ToString());
                rInfo.CodAlterno = string.Empty;
                rInfo.IdTipoServicio = cmbTipoServicio.EditValue.ToString();
                rInfo.IdTipoRubro = Convert.ToInt16(cmbTipoRubro.EditValue.ToString());
                rInfo.NumeroCoutas = 0;
                rInfo.UsuarioCreacion = param.IdUsuario;
                rInfo.UsuarioModificacion = param.IdUsuario;
                rInfo.IdCtaCble = ucCon_Plan_de_Cuenta_x_Movimiento1.get_CuentaInfo().IdCtaCble;
                rInfo.IdProducto_inv = ucIn_ProductoCmb1.get_ProductoInfo().IdProducto;
                rInfo.IdEmpresa_inv = ucIn_ProductoCmb1.get_ProductoInfo().IdEmpresa;
                rInfo.IdCentroCosto_ct = ucCon_CentroCosto_ctas_Movi1.Get_IdCentroCosto();
                //rInfo.IdCentroCosto_ct = ucCon_CentroCosto_ctas_Movi1.Get_IdCentroCosto();
                rInfo.IdEmpresa_ct = param.IdEmpresa;

                if (Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    chkActivo.Checked = true;
                }

                rInfo.estado = (chkActivo.Checked == true) ? "A" : "I";
                if (chkActivo.Checked)
                {
                    lblAnulado.Visible = false;
                }
                else { lblAnulado.Visible = true; }

                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                mensaje = ex.Message.ToString();
                MessageBox.Show("Error " + mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return rInfo;
        }
       

        #endregion

        #region "CargarDatos"
        public void CargarCombos()
        {
            try
            {
                Aca_Catalogo_Bus negc = new Aca_Catalogo_Bus();
                Aca_RubroGrupoFE_Bus BusFEE = new Aca_RubroGrupoFE_Bus();

                ucAca_Anio_Lectivo1.cargaCmb_Anio_Lectivo_Activo();

                this.cmbDebeHaber.Properties.DataSource = negc.Get_List_CatalogoXtipo("CUENTA");
                this.cmbTipoServicio.Properties.DataSource = negc.Get_List_CatalogoXtipo("TIPOSERV");
                this.cmbFEE.Properties.DataSource = BusFEE.Get_List_Rubro_Grupo_FE();
                this.cmbFEE.Properties.DisplayMember = "nom_GrupoFe";
                this.cmbFEE.Properties.ValueMember = "IdGrupoFE";

                this.cmbTipoRubro.Properties.DataSource = BusTipoRubro.Get_List_RubroTipo();
                this.cmbTipoRubro.Properties.DisplayMember = "DescripcionTipoRubro";
                this.cmbTipoRubro.Properties.ValueMember = "IdTipoRubro";

                List_Periodo = BusPeriodo.Get_List_Periodo_x_AnioLectivo(param.IdInstitucion, ucAca_Anio_Lectivo1.get_item());
                this.cmb_Periodo.DataSource = List_Periodo;
                this.cmb_Periodo.ValueMember = "IdPeriodo";
                //this.cmb_Periodo.DisplayMember = "pe_Descripcion";
                this.cmb_Periodo.DisplayMember = "IdPeriodo";




            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message);
            }

        }

        public void CargarDatos()
        {
            try
            {
                txtIdRubro.Text = "0";
                txtIdRubro.Text = rubroInfo.IdRubro.ToString();
                txtDescripcionRubro.Text = rubroInfo.Descripcion_rubro;
                txtCodigoRubro.Text = rubroInfo.CodRubro;

                cmbDebeHaber.EditValue = rubroInfo.Deb_cred;
                cmbTipoServicio.EditValue = rubroInfo.IdTipoServicio;
                ucCon_Plan_de_Cuenta_x_Movimiento1.set_IdCtaCble(rubroInfo.IdCtaCble);
                chkActivo.Checked = (rubroInfo.estado == "A") ? true : false;
                lblAnulado.Visible = (rubroInfo.estado == "I") ? true : false;
                cmbFEE.EditValue = rubroInfo.IdGrupoFE;
                cmbTipoRubro.EditValue = rubroInfo.IdTipoRubro;
                ucCon_Plan_de_Cuenta_x_Movimiento1.set_IdCtaCble(rubroInfo.IdCtaCble);
                ucIn_ProductoCmb1.set_ProductoInfo((decimal)rubroInfo.IdProducto_inv);
                ucCon_CentroCosto_ctas_Movi1.set_IdCentroCosto(rubroInfo.IdCentroCosto_ct);
                Lista_Periodo_x_Rubro = Periodo_x_Rubro_Bus.Get_List_rubro_x_periodo(rubroInfo.IdInstitucion, rubroInfo.IdRubro);
                gridControlValores_x_Periodo.DataSource = Lista_Periodo_x_Rubro;               
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region "Proceso"
        public bool Grabar()
        {
            bool resultado = false;
            try
            {
                              
                string mensaje = string.Empty;
                int id = 0;
                rubroInfo = GetRubro(ref mensaje);
                if (mensaje != "")
                {
                    MessageBox.Show(mensaje);
                    return false;
                }

                Aca_Rubro_Bus neg = new Aca_Rubro_Bus();
                if (neg.GrabarDB(rubroInfo, ref id, ref mensaje))
                {
                    txtIdRubro.Text = id.ToString();
                    
                    if (Lista_Periodo_x_Rubro.Count() != 0)
                    {
                        if (Lista_Periodo_x_Rubro.Where(v => v.chequeo == true).Any())
                        {
                            foreach (var item in Lista_Periodo_x_Rubro)
                            {
                                item.IdInstitucion_rub = param.IdInstitucion;
                                item.IdInstitucion_per = param.IdInstitucion;
                                item.IdRubro = (Convert.ToInt16(txtIdRubro.Text) == null) ? id : Convert.ToInt16(txtIdRubro.Text);
                                item.IdAnioLectivo = ucAca_Anio_Lectivo1.get_item();
                                item.UsuarioCreacion = param.IdUsuario;
                                item.UsuarioModificacion = param.IdUsuario;                                
                                item.Estado = "A";                                 
                            }
                            if (Periodo_x_Rubro_Bus.EliminarDB(param.IdInstitucion, id, ref mensaje))
                            {
                                resultado = Periodo_x_Rubro_Bus.GrabarDB(Lista_Periodo_x_Rubro, ref mensaje);
                            }
                        }


                    }
                   
                }


                if (resultado == true)
                {
                    MessageBox.Show(mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    Log_Error_bus.Log_Error(mensaje.ToString());
                    MessageBox.Show("Error " + mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message);
            }
            return resultado;
        }

        public bool Actualizar()
        {
            bool resultado = false;
            try
            {
                Aca_Rubro_Bus neg = new Aca_Rubro_Bus();
                Aca_Rubro_Info ruInfo = new Aca_Rubro_Info();
                string mensaje = string.Empty;

                ruInfo = GetRubro(ref mensaje);
                if (mensaje != "")
                {
                    MessageBox.Show(mensaje);
                    return false;
                }

                if (neg.ActualizarDB(ruInfo, ref mensaje))
                {
                     if (Lista_Periodo_x_Rubro.Count() != 0)
                    {
                        if (Lista_Periodo_x_Rubro.Where(v => v.chequeo == true).Any())
                        {
                            foreach (var item in Lista_Periodo_x_Rubro)
                            {
                                item.IdInstitucion_rub = param.IdInstitucion;
                                item.IdInstitucion_per = param.IdInstitucion;
                                item.IdRubro = (Convert.ToInt16(txtIdRubro.Text) == null) ? rubroInfo.IdRubro : Convert.ToInt16(txtIdRubro.Text);
                                item.IdAnioLectivo = ucAca_Anio_Lectivo1.get_item();
                                item.UsuarioCreacion = param.IdUsuario;
                                item.UsuarioModificacion = param.IdUsuario;                                
                                item.Estado = "A";                                 
                            }
                            if (Periodo_x_Rubro_Bus.EliminarDB(rubroInfo.IdInstitucion, rubroInfo.IdRubro, ref mensaje))
                            {
                                resultado = Periodo_x_Rubro_Bus.GrabarDB(Lista_Periodo_x_Rubro, ref mensaje);
                            }
                        }


                    }
                }
                if (resultado)
                {
                    MessageBox.Show(mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                else
                {
                    Log_Error_bus.Log_Error(mensaje.ToString());
                    MessageBox.Show("Error " + mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message);
            }
            return resultado;
        }

        private bool Anular()
        {
            try
            {
                bool resultado = false;
                if (rubroInfo.estado != "I")
                {
                    if (MessageBox.Show("¿Está seguro que desea anular el Rubro #:" + txtIdRubro.Text.Trim() + " ?", "Anulación de Mantenimiento Rubro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        FrmGe_MotivoAnulacion fr = new FrmGe_MotivoAnulacion();
                        fr.ShowDialog();

                        Aca_Rubro_Bus neg = new Aca_Rubro_Bus();
                        Aca_Rubro_Info ruInfo = new Aca_Rubro_Info();
                        string mensaje = string.Empty;

                        ruInfo = GetRubro(ref mensaje);
                        if (mensaje != "")
                        {
                            MessageBox.Show("Error " + mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        ruInfo.UsuarioAnulacion = param.IdUsuario;
                        ruInfo.MotivoAnulacion = fr.motivoAnulacion;
                        resultado = neg.EliminarDB(ruInfo, ref mensaje);
                        if (resultado)
                        {
                            MessageBox.Show(mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                            this.ucGe_Menu.Visible_btnGuardar = false;
                        }
                        else
                        {
                            Log_Error_bus.Log_Error(mensaje.ToString());
                            MessageBox.Show("Error " + mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("El rubro #:" + txtIdRubro.Text.Trim() + " ya se encuentra anulado", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                return resultado;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error " + ex.Message.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }

        public bool GuardarDatos()
        {
            bool resultado = false;
            try
            {
                if (validaciones())
                {
                    txtIdRubro.Focus();
                    switch (Accion)
                    {
                        case Cl_Enumeradores.eTipo_action.grabar:
                            resultado = Grabar();
                            break;

                        case Cl_Enumeradores.eTipo_action.actualizar:
                            resultado = Actualizar();
                            break;
                    }
                }
            }

            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message);
                return false;
            }
            return resultado;
        }

        public bool validaciones()
        {
            try
            {
                if (string.IsNullOrEmpty(txtDescripcionRubro.Text))
                {
                    MessageBox.Show("Digite Descripción", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDescripcionRubro.Focus();
                    return false;
                }

                if (cmbDebeHaber.EditValue == null || cmbDebeHaber.EditValue == "[Vacio]")
                {
                    MessageBox.Show("Seleccione Debe/Haber", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbDebeHaber.Focus();
                    return false;
                }

                if (cmbTipoServicio.EditValue == null || cmbTipoServicio.EditValue == "[Vacio]")
                {
                    MessageBox.Show("Seleccione Tipo de Servicio", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbTipoServicio.Focus();
                    return false;
                }
                if (ucIn_ProductoCmb1.get_ProductoInfo() == null)
                {
                    MessageBox.Show("Seleccione el producto", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ucIn_ProductoCmb1.Focus();
                    return false;
                }

                if (ucCon_Plan_de_Cuenta_x_Movimiento1.get_CuentaInfo().IdCtaCble == null)
                {
                    MessageBox.Show("Seleccione la cuenta contable", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ucCon_Plan_de_Cuenta_x_Movimiento1.Focus();
                    return false;
                }
                if (cmbFEE.EditValue == null || cmbFEE.EditValue == "[Vacio]")
                {
                    MessageBox.Show("Seleccione Grupo FE", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbFEE.Focus();
                    return false;
                }

                if (cmbTipoRubro.EditValue == null || cmbTipoRubro.EditValue == "[Vacio]")
                {
                    MessageBox.Show("Seleccione el tipo de rubro", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbTipoRubro.Focus();
                    return false;
                }
                if (ucCon_CentroCosto_ctas_Movi1.Get_IdCentroCosto().Count() == 0)
                {
                    MessageBox.Show("Seleccione el Centro de Costo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ucCon_CentroCosto_ctas_Movi1.Focus();
                    return false;
                }

                //if (Lista_Periodo_x_Rubro.Count() != 0)
                //{
                //    if (Lista_Periodo_x_Rubro.Where(v => v.chequeo == true).Any())
                //    {
                //        foreach (var item in Lista_Periodo_x_Rubro)
                //        {
                //            if (item.Valor == 0)
                //            {
                //                MessageBox.Show("Ingrese un Valor", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                //            }
                //        }
                //    }
                //    else
                //    {
                //        MessageBox.Show("No tiene selecciona la columna de asignación de valores", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    }
                //}

                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void Limpiar()
        {
            Accion = Cl_Enumeradores.eTipo_action.grabar;
            txtCodigoRubro.Text = string.Empty;
            txtIdRubro.Text = string.Empty;
            txtDescripcionRubro.Text = string.Empty;
            ucIn_ProductoCmb1.Inicializar_cmbProducto();
            cmbDebeHaber.EditValue = "[Vacio]";
            cmbFEE.EditValue = "[Vacio]";
            cmbTipoRubro.EditValue = "[Vacio]";
            cmbTipoServicio.EditValue = "[Vacio]";
            ucCon_Plan_de_Cuenta_x_Movimiento1.Inicializar_cmb_cuentas();
            ucCon_CentroCosto_ctas_Movi1.Inicializar_cmbCentroCosto();
            Lista_Periodo_x_Rubro = new BindingList<Aca_Rubro_x_Aca_Periodo_Lectivo_Info>();
        }
        #endregion

        #region "Eventos"

        private void FrmAcaRubro_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                CargarCombos();
                gridControlValores_x_Periodo.DataSource = Lista_Periodo_x_Rubro;
                txtCodigoRubro.Properties.ReadOnly = true;
                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        ucGe_Menu.Visible_bntAnular = false;
                        ucGe_Menu.Visible_bntImprimir = false;
                        chkActivo.Checked = true;
                        break;

                    case Cl_Enumeradores.eTipo_action.actualizar:
                        ucGe_Menu.Visible_bntAnular = false;
                        ucGe_Menu.Visible_bntImprimir = false;
                        CargarDatos();
                        break;

                    case Cl_Enumeradores.eTipo_action.Anular:
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        ucGe_Menu.Visible_bntImprimir = false;
                        ucGe_Menu.Visible_bntLimpiar = false;
                        CargarDatos();
                        break;

                    case Cl_Enumeradores.eTipo_action.consultar:
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        ucGe_Menu.Visible_bntAnular = false;
                        ucGe_Menu.Visible_bntImprimir = false;
                        ucGe_Menu.Visible_bntLimpiar = false;
                        CargarDatos();
                        break;
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message);
            }


        }

        private void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            if (GuardarDatos())
                Limpiar();

        }

        private void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            bool resultado = GuardarDatos();
            if (resultado)
            {
                Close();
            }
        }

        private void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            if (Anular())
                this.Close();
        }

        private void FrmAcaRubro_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                event_FrmAcaRubro_Mant_FormClosing(sender, e);
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void txtNumeroCuotas_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Funciones val = new Funciones();
                e.Handled = val.ValidaNumero(e.KeyChar);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void gridView_Valores_x_Periodo_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            Aca_Rubro_x_Aca_Periodo_Lectivo_Info InfoDet = new Aca_Rubro_x_Aca_Periodo_Lectivo_Info();
            InfoDet = (Aca_Rubro_x_Aca_Periodo_Lectivo_Info)this.gridView_Valores_x_Periodo.GetFocusedRow();
            BindingList<Aca_Rubro_x_Aca_Periodo_Lectivo_Info> ListaBind = new BindingList<Aca_Rubro_x_Aca_Periodo_Lectivo_Info>();

            if (e.Column.Name == "col_IdPeriodo" || e.Column.Name == "IdPeriodo")
            {
                foreach (var item in Lista_Periodo_x_Rubro)
                {
                    var itemProd = List_Periodo.FirstOrDefault(p => p.IdPeriodo == InfoDet.IdPeriodo);

                    if (item.IdPeriodo == InfoDet.IdPeriodo)
                    {
                        item.FechaInicio = itemProd.pe_FechaIni;
                        item.FechaFin = itemProd.pe_FechaFin;
                        break;
                    }
                }
            }
        }
        #endregion



        public List<Aca_Rubro_x_Aca_Periodo_Lectivo_Info> Lista_Per_Rubro { get; set; }
    }
}
