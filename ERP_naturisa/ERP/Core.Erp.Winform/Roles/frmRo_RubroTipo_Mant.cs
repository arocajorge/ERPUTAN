

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.Roles;
using Core.Erp.Business.General;
using Core.Erp.Info.Roles;
using Core.Erp.Info.General;
using Core.Erp.Recursos.Properties;

using DevExpress.XtraGrid.Columns;
using DevExpress.Utils;
using Core.Erp.Info.Contabilidad;


namespace Core.Erp.Winform.Roles
{   
    public partial class frmRo_RubroTipo_Mant : Form
    {
        #region Declaración de Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        Cl_Enumeradores.eTipo_action Accion = new Cl_Enumeradores.eTipo_action();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        ro_rubro_tipo_Bus Bus = new ro_rubro_tipo_Bus();
        public ro_rubro_tipo_Info _SetInfo { get; set; }
        ro_rubro_tipo_Info _Info = new ro_rubro_tipo_Info();
        ro_Catalogo_Bus tlB = new ro_Catalogo_Bus();
        List<ro_Catalogo_Info> listTL = new List<ro_Catalogo_Info>();
        List<ro_Catalogo_Info> listGP = new List<ro_Catalogo_Info>();
        List<ro_Catalogo_Info> oListRo_Catalogo_Info = new List<ro_Catalogo_Info>();


        public delegate void delegate_frmRo_RubroTipo_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmRo_RubroTipo_Mant_FormClosing event_frmRo_RubroTipo_Mant_FormClosing;
        #endregion

        public frmRo_RubroTipo_Mant()
        {
            InitializeComponent();
            ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
            ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
            ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
            ucGe_Menu.event_btnAnular_Click += ucGe_Menu_event_btnAnular_Click;
            event_frmRo_RubroTipo_Mant_FormClosing+=frmRo_RubroTipo_Mant_event_frmRo_RubroTipo_Mant_FormClosing;

            try
            {
                //Carga combo Tipo de Campo            

                listTL = tlB.Get_List_Catalogo_x_Tipo(13);
                this.comb_TC.DataSource = listTL;
                comb_TC.DisplayMember = "ca_descripcion";
                comb_TC.ValueMember = "IdCatalogo";

                //Carga combo Grupo            
                listGP = tlB.Get_List_Catalogo_x_Tipo(14);
                this.CmbGrupos.DataSource = listGP;
                CmbGrupos.DisplayMember = "ca_descripcion";
                CmbGrupos.ValueMember = "IdCatalogo";

                //Carga combo Tipo Rubro  
                
                oListRo_Catalogo_Info = tlB.Get_List_Catalogo_x_Tipo(22);
                this.cmbTipo.DataSource = oListRo_Catalogo_Info;
                cmbTipo.DisplayMember = "ca_descripcion";
                cmbTipo.ValueMember = "CodCatalogo";



                CmbTipoCampo.DataSource = tlB.Get_List_Catalogo_x_Tipo(13);
                CmbTipoCampo.DisplayMember = "ca_descripcion";
                CmbTipoCampo.ValueMember = "IdCatalogo";
             //  pu_CrearGrillaFormula();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }                     
        }

        void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                getInfo();
                if (MessageBox.Show("Está seguro que desea anular el rubro...?", " Anulacion", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    getparamanular();
                    if (Bus.AnularDB(_Info))
                    {
                        MessageBox.Show(Resources.msgConfirmaAnulacionOk, Resources.msgTituloAnular, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }        
        }   

        void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
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

        void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar())
                {
                    this.ucGe_Menu_event_btnGuardar_Click(sender, e);
                    Close();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            getInfo();

            try
            {
                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        if (Validar())
                        {
                            Guardar();
                        }
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        if (Validar())
                        {
                            Actualizar();
                        }
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:


                        break;
                    default:
                        break;

                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }        
        }
       
        public void set_Accion(Cl_Enumeradores.eTipo_action iAccion)
        {
            try
            {
               Accion = iAccion;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }          
        }

        void frmRo_RubroTipo_Mant_Event_frmRo_RubroTipo_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                event_frmRo_RubroTipo_Mant_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }
       
        void setInfo()
        {
            try
            {
                textID.Text = _SetInfo.IdRubro;
                txtIdRubro.Text = _SetInfo.rub_codigo;
                textDescripcion.Text = _SetInfo.ru_descripcion;
                textNombreC.Text = _SetInfo.NombreCorto;
                txtOrden.Value = _SetInfo.ru_orden;
                CmbTipoCampo.SelectedValue = _SetInfo.rub_tipcal;
                checkEditabelUsuario.Checked = (_SetInfo.ru_EditablexUser == "S") ? true : false;
                CheckEstado.Checked=(_SetInfo.ru_estado == "A") ? true : false;
                cmbTipo.SelectedValue = _SetInfo.ru_tipo;
                this.comb_TC.SelectedValue = _SetInfo.rub_tipcal;
                this.CmbGrupos.SelectedValue = _SetInfo.rub_grupo;

                checkConcept.Checked = Convert.ToBoolean(_SetInfo.rub_concep);
                checkAnticip.Checked = Convert.ToBoolean(_SetInfo.rub_antici);
                checkAplicaLiq.Checked = Convert.ToBoolean(_SetInfo.rub_liquida);
                checkProvisiones.Checked = Convert.ToBoolean(_SetInfo.rub_provision);
                checkAfectaRol.Checked = Convert.ToBoolean(_SetInfo.rub_noafecta);
                check_Acumula.Checked = Convert.ToBoolean(_SetInfo.rub_acumula);
//                checkProrra.Checked = Convert.ToBoolean(_SetInfo.rub_prorrateo);
                checkConsideraIESS.Checked = Convert.ToBoolean(_SetInfo.rub_aplica_IESS);

                checkGuardaRol.Checked = Convert.ToBoolean(_SetInfo.rub_guarda_rol);
                txtFormula.Text = _SetInfo.rub_formul.Trim();
                txtIdRolProceso.Text = _SetInfo.ru_codRolGen.Trim();

                checkContabiliza.Checked = Convert.ToBoolean(_SetInfo.rub_nocontab);

                cmbCuentaContable_.set_IdCtaCble(_SetInfo.rub_ctacon == null ? "" : _SetInfo.rub_ctacon);

                checkAfectaEmpleadoVac.Checked =Convert.ToBoolean( _SetInfo.rub_AplicaEmpleado_Vac);
                checkSubcidio.Checked = Convert.ToBoolean(_SetInfo.ru_aplica_empleado_Subsidio);
                check_rub_Contabiliza_x_empleado.Checked =Convert.ToBoolean(_SetInfo.rub_Contabiliza_x_empleado);
                check_aparece_liq_fact.Checked =Convert.ToBoolean( _SetInfo.rub_mustra_liquidacion_cliente);
                if(_SetInfo.rub_Acuerdo_Descuento!=null)
                txtAcuedro.Text = _SetInfo.rub_Acuerdo_Descuento;
             

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }                               
        }
       
        void getInfo()
        {
            try
            {
                _Info.IdEmpresa = param.IdEmpresa;
                _Info.IdRubro = textID.Text;
                _Info.rub_codigo = txtIdRubro.Text;
                _Info.NombreCorto = textNombreC.Text;
                _Info.ru_descripcion = textDescripcion.Text;
                _Info.ru_orden = Convert.ToInt32(txtOrden.Value);
                _Info.ru_estado = (CheckEstado.Checked == true) ? "A" : "I";
                _Info.ru_tipo = (cmbTipo.SelectedValue.ToString() == "") ? "I" : cmbTipo.SelectedValue.ToString();
                _Info.ru_EditablexUser = (checkBox1.Checked == true) ? "S" : "N";

              //  _Info.rub_tipcal = Convert.ToInt32(comb_TC.SelectedValue == null ? 0 : comb_TC.SelectedValue);
                _Info.rub_grupo = Convert.ToInt32(CmbGrupos.SelectedValue == null ? 0 : CmbGrupos.SelectedValue);
                _Info.rub_tipcal =(int) CmbTipoCampo.SelectedValue;
                _Info.rub_concep = checkConcept.Checked;
                _Info.rub_antici = checkAnticip.Checked;
                _Info.rub_liquida = checkLiqui.Checked;
                _Info.rub_provision =checkProvisiones.Checked;
                _Info.rub_noafecta = checkAfectaRol.Checked;
                _Info.rub_acumula = check_Acumula.Checked;
                //_Info.rub_prorrateo = checkProrra.Checked;
                _Info.rub_aplica_IESS = checkConsideraIESS.Checked;
                _Info.rub_guarda_rol = checkGuardaRol.Checked;
                _Info.rub_formul = txtFormula.Text.Trim();
                _Info.ru_codRolGen = txtIdRolProceso.Text.Trim();
                _Info.rub_nocontab = checkContabiliza.Checked;
                ct_Plancta_Info cuentaContableInfo = new ct_Plancta_Info();
                cuentaContableInfo = cmbCuentaContable_.get_CuentaInfo();
                if (cuentaContableInfo != null)
                {
                    _Info.rub_ctacon = cuentaContableInfo.IdCtaCble == null ? "" : cuentaContableInfo.IdCtaCble;

                }


                _Info.rub_AplicaEmpleado_Vac = checkAfectaEmpleadoVac.Checked;
                _Info.ru_aplica_empleado_Subsidio = checkSubcidio.Checked;
                _Info.rub_Contabiliza_x_empleado = check_rub_Contabiliza_x_empleado.Checked;
                _Info.rub_mustra_liquidacion_cliente = check_aparece_liq_fact.Checked;
                _Info.rub_Acuerdo_Descuento = txtAcuedro.Text;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }            
        }

        private void getparamingresa()
        {
            try
            {
                _Info.IdUsuario = param.IdUsuario;
                _Info.Fecha_Transac = param.Fecha_Transac;
                _Info.nom_pc = param.nom_pc;
                _Info.ip = param.ip;

//                _Info.ru_tipo =(CmbTipoCampo.SelectedValue  == "Ingreso") ? "E" : "I";

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        private void getparamactualiza()
        {
            try
            {
                _Info.Fecha_UltMod = param.Fecha_Transac;
                _Info.IdUsuarioUltMod = param.IdUsuario;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        private void getparamanular()
        {
            try
            {
                _Info.Fecha_UltAnu = param.Fecha_Transac;
                _Info.IdUsuarioUltAnu = param.IdUsuario;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }

        }

        void Guardar()
        {
            try
            {
                string msg = "";
                if (Validar())
                {
                    getInfo();
                    getparamingresa();
                    if (Bus.GuardarDB(ref _Info, ref msg))
                    {
                        txtIdRubro.Text = _Info.IdRubro;
                        MessageBox.Show(Resources.msgConfirmaGrabarOk, Resources.msgTituloGrabar, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show("Error: "+msg);
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }                      
        }

        void Actualizar()
        {

            try
            {
               
                getparamactualiza();
                if (Bus.ModificarDB(_Info))
                {
                    txtIdRubro.Text = _Info.IdRubro;
                    MessageBox.Show(Resources.msgConfirmaGrabarOk, Resources.msgTituloGrabar, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                else
                {
                    MessageBox.Show(Resources.msgError_Modificar, Resources.msgTituloGrabar, MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }                      
        }

        Boolean Validar()
        {
            try
            {

                if (textDescripcion.Text == null || textDescripcion.Text == "")
                {
                    MessageBox.Show("La Descripción es obligatoria, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return false;
                }

                if (String.IsNullOrWhiteSpace(textNombreC.Text) || String.IsNullOrEmpty(textNombreC.Text))
                {
                    MessageBox.Show("El nombre corto es obligatorio, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return false;
                }
              
                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
                return false;
            }
        }
      
        private void frmRo_RubroTipo_Mant_Load_1(object sender, EventArgs e)
        {
            try
            {
                if (param.IdCliente_Ven_x_Default == Cl_Enumeradores.eCliente_Vzen.TRANSGANDIA)
                    check_aparece_liq_fact.Visible = true;
                this.CmbTipoCampo.SelectedIndex = 0;
                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        ucGe_Menu.Visible_bntGuardar_y_Salir = true;
                        ucGe_Menu.Visible_btnGuardar = true;
                        ucGe_Menu.Enabled_bntSalir = true;
                        ucGe_Menu.Enabled_bntAnular = false;
                        CheckEstado.Checked = true;
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:

                        txtIdRubro.ReadOnly = true;
                        this.txtIdRubro.BackColor = System.Drawing.Color.White;

                     //   CmbTipoCampo.Enabled = false;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = true;
                        ucGe_Menu.Visible_btnGuardar = true;
                        ucGe_Menu.Enabled_bntAnular = false;
                        ucGe_Menu.Enabled_bntSalir = true;
                        setInfo();
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        ucGe_Menu.Enabled_bntAnular = false;
                        ucGe_Menu.Enabled_bntSalir = true;


                    this.txtIdRubro.ReadOnly = true;
                    this.txtIdRubro.BackColor = System.Drawing.Color.White;

                    this.textDescripcion.ReadOnly = true;
                    this.textDescripcion.BackColor = System.Drawing.Color.White;

                    this.textNombreC.ReadOnly = true;
                    this.textNombreC.BackColor = System.Drawing.Color.White;

                     
                    txtOrden.ReadOnly = true;
                    this.txtOrden.BackColor = System.Drawing.Color.White;

                    setInfo();
                        
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        setInfo();
                        ucGe_Menu.Enabled_bntAnular = true;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        ucGe_Menu.Enabled_bntSalir = true;
                        break;
                    default:
                        break;


                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
            
        }

        void frmRo_RubroTipo_Mant_event_frmRo_RubroTipo_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                //event_frmRo_RubroTipo_Mant_FormClosing(sender,e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }

        }

        private void txtIdRubro_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                string mensaje = "";

                if (Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    if (Bus.VericarCodigoExiste(param.IdEmpresa, txtIdRubro.Text.Trim(), ref mensaje) == true)
                    {
                        MessageBox.Show("Por favor cambie de código , Código asignado a: " + mensaje, "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtIdRubro.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }
    
        private void frmRo_RubroTipo_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                event_frmRo_RubroTipo_Mant_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }

        }

        private void abrirFormula() {
            try
            {
                frmRo_Formula_Mant ofrmRo_Formula_Mant = new frmRo_Formula_Mant();
                ofrmRo_Formula_Mant.ShowDialog();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        } 

        private void frmRo_RubroTipo_Mant_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textNombreC_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ultraExpandableGroupBoxPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pu_CrearGrillaFormula()
        {
            try
            {
                string idCatalogo = "";
                DataTable table = new DataTable();
                ro_rubro_tipo_Bus oRo_rubro_tipo_Bus = new ro_rubro_tipo_Bus();
                List<ro_rubro_tipo_Info> oListadoRubro = new List<ro_rubro_tipo_Info>();
                ro_Catalogo_Bus oCatalogoBus = new ro_Catalogo_Bus();


                view.Columns.Clear();
                table.Columns.Clear();
                table.Rows.Clear();

                oListadoRubro = oRo_rubro_tipo_Bus.ConsultaGeneralPorEmpresa(param.IdEmpresa);

                //CREAR COLUMNAS EN LA GRILLA PARA EL PROCESO DE FORMULAS               
                int cont = 0;
                foreach (ro_rubro_tipo_Info item in oListadoRubro)
                {
                    //  GridColumn column = view.Columns.Add();
                    GridColumn column = new GridColumn();
                    column.Name = item.ru_codRolGen.Trim();
                    column.FieldName = item.ru_codRolGen.Trim();
                    column.Caption = item.ru_codRolGen.Trim();
                    column.Visible = true;

                    column.DisplayFormat.FormatType = FormatType.Custom;
                    column.DisplayFormat.FormatString = "c2";


                    column.VisibleIndex = cont;
                    //column.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;

                    idCatalogo = (oCatalogoBus.Get_info_Catalogo((item.rub_tipcal == null ? 0 : Convert.ToInt32(item.rub_tipcal)))).CodCatalogo;

                    switch (idCatalogo)
                    {
                        //VARIABLE
                        case "TPC1":

                            break;
                        //CONSTANTE
                        case "TPC2":

                            break;
                        //FUNCION
                        case "TPC3":

                            break;

                        //FORMULA LOGICA
                        case "TPC4":

                            column.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
                            column.OptionsColumn.AllowEdit = false;
                            column.ShowUnboundExpressionMenu = true;
                            column.UnboundExpression = item.rub_formul.Trim();

                            break;
                        default:
                            break;
                    }


                    view.Columns.Add(column);

                    if (idCatalogo != "TPC4")
                    {
                        table.Columns.Add(item.ru_codRolGen.Trim(), typeof(Decimal));
                    }
                    cont += 1;
                }

                grid.DataSource = table;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }

        }

        private void cmdAbrirFormula_Click_1(object sender, EventArgs e)
        {
            try
            {
                getInfo();
                 if (_Info != null)
                 {
                     view.ShowUnboundExpressionEditor(view.Columns[_Info.ru_codRolGen.Trim()]);
                     txtFormula.Text = view.Columns[_Info.ru_codRolGen.Trim()].UnboundExpression;

                 }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }
        public void Limpiar()
        {
            try
            {   textID.Text = "";
                txtIdRubro.Text = "";
                textDescripcion.Text = "";
                textNombreC.Text = "";
                txtOrden.Value = 0;
                CmbTipoCampo.SelectedValue = 0;
                checkEditabelUsuario.Checked = false;
                CheckEstado.Checked=false;
                checkConcept.Checked = false;
                checkAnticip.Checked = false;
                checkAplicaLiq.Checked =false;
                checkProvisiones.Checked = false;
                checkAfectaRol.Checked = false;
                check_Acumula.Checked = false;
                checkConsideraIESS.Checked =false;
                checkGuardaRol.Checked = false;
                txtIdRolProceso.Text = "";
                checkContabiliza.Checked = false;
                cmbTipo.DataSource = oListRo_Catalogo_Info;
                CmbGrupos.DataSource = listGP;
                comb_TC.DataSource = listTL;
                CmbTipoCampo.DataSource = tlB.Get_List_Catalogo_x_Tipo(13);
                CheckEstado.Checked = true;
           }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        private void checkContabiliza_CheckedChanged(object sender, EventArgs e)
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
    }
}
