using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using Core.Erp.Info.CuentasxCobrar;
using Core.Erp.Business.CuentasxCobrar;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Info.Contabilidad;
/*haac 26022014 11.32*/


namespace Core.Erp.Winform.CuentasxCobrar
{
    public partial class frmCxc_cobro_tipo_Mant : Form
    {


        private Cl_Enumeradores.eTipo_action _Accion;
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        public cxc_cobro_tipo_Info info = new cxc_cobro_tipo_Info();
        cxc_cobro_tipo_Bus bus = new cxc_cobro_tipo_Bus();
        ct_Plancta_Bus busPlanCta = new ct_Plancta_Bus();
        cxc_cobro_tipo_Param_conta_x_sucursal_Bus busparam = new cxc_cobro_tipo_Param_conta_x_sucursal_Bus();

        List<cxc_cobro_tipo_Param_conta_x_sucursal_Info> lista = new List<cxc_cobro_tipo_Param_conta_x_sucursal_Info>();
        BindingList<cxc_cobro_tipo_Param_conta_x_sucursal_Info> DataSource = new BindingList<cxc_cobro_tipo_Param_conta_x_sucursal_Info>();

        public string IdTipoCobro { get; set; }

        string MensajeError = "";

        BindingList<cxc_cobro_tipo_Param_conta_x_sucursal_Info> ListaBind;
        //

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        
        public frmCxc_cobro_tipo_Mant()
        {
            InitializeComponent();

            ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
            ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
            ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
            ucGe_Menu.event_btnlimpiar_Click += ucGe_Menu_event_btnlimpiar_Click;

            try
            {   tb_Sucursal_Bus busSucu = new tb_Sucursal_Bus();
                List<tb_Sucursal_Info> listaSuc = new List<tb_Sucursal_Info>();
                listaSuc = busSucu.Get_List_Sucursal(param.IdEmpresa);
                GridLookUpEditSucursal.DataSource = listaSuc;
                //
                List<ct_Plancta_Info> listacta = new List<ct_Plancta_Info>();

                //string = "";

                listacta = busPlanCta.Get_List_Plancta_x_ctas_Movimiento(param.IdEmpresa, ref MensajeError);


                listacta.ForEach(x => x.pc_Cuenta = "[" + x.IdCtaCble + "] " + x.pc_Cuenta);
               // GridLookUpEditCtaCtble.DataSource = listacta;
                this.cmbCtaCble.DataSource = listacta;


                ListaBind = new BindingList<cxc_cobro_tipo_Param_conta_x_sucursal_Info>();
                gridConsulta.DataSource = ListaBind;
                
              //  gridConsulta.DataSource = ListaBind;

                repositoryCmbAnticipo.DataSource = listacta;
                event_frmCo_cxc_cobro_tipo_Mant_FormClosing += new delegate_frmCo_cxc_cobro_tipo_Mant_FormClosing(frmCo_cxc_cobro_tipo_Mant_event_frmCo_cxc_cobro_tipo_Mant_FormClosing);
       
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                if (guardarDatos())
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
                guardarDatos();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        void LimpiarDatos()
        {
            try
            {
                _Accion = Cl_Enumeradores.eTipo_action.grabar;
                info = new cxc_cobro_tipo_Info();
                txtId.Text = "";
                txtAbreviatura.Text = "";
                txtDescripcion.Text = "";         
                Orden.Value = 0;

                ListaBind = new BindingList<cxc_cobro_tipo_Param_conta_x_sucursal_Info>();
                gridConsulta.DataSource = ListaBind;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        Boolean guardarDatos()
        {
            try
            {
                Boolean bolResult = true;
                if (Validar())
                {

                    txtDescripcion.Focus();
                    switch (_Accion)
                    {
                        case Cl_Enumeradores.eTipo_action.grabar:
                            get();
                            if (bus.GuardarDB(info, ref MensajeError))
                            {
                                IdTipoCobro = info.IdCobro_tipo;
                                busparam.GuardarDB(getGrid());
                                MessageBox.Show(Core.Erp.Recursos.Properties.Resources.msgConfirmaGrabarOk, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                //ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                                //ucGe_Menu.Visible_btnGuardar = false;          
                                LimpiarDatos();
                            }
                            else {
                                MessageBox.Show(MensajeError, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                bolResult = false;
                            }
                            

                            break;
                        case Cl_Enumeradores.eTipo_action.actualizar:
                            get();
                            busparam.GuardarDB(getGrid());
                            if (!bus.ModificarDB(info, ref MensajeError)) { 
                                MessageBox.Show(MensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                bolResult = false;
                            }
                            MessageBox.Show(Core.Erp.Recursos.Properties.Resources.msgConfirmaGrabarOk,param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            //ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                            //ucGe_Menu.Visible_btnGuardar = false;
                            LimpiarDatos();
                            
                            break;
                        default:
                            break;
                    }
                }
                else
                    bolResult = false;

                return bolResult;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        void frmCo_cxc_cobro_tipo_Mant_event_frmCo_cxc_cobro_tipo_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
        
        public void setAccion(Cl_Enumeradores.eTipo_action iAccion)
        {
            try
            {
              _Accion = iAccion;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void set() {
            try
            {
                txtId.Text = info.IdCobro_tipo;
                txtAbreviatura.Text = info.tc_abreviatura;
                txtDescripcion.Text = info.tc_descripcion;
                chbAfecha.Checked=(info.tc_Afecha=="S")?true:false;
                chbDxC.Checked = (info.tc_docXCobrar == "S") ? true : false;
                chbEsCheque.Checked = (info.tc_EsCheque == "S") ? true : false;
                chbEstado.Checked = (info.Estado == "A") ? true : false;
                chbInterno.Checked = (info.tc_interno == "S") ? true : false;
                chbNCAuto.Checked = (info.tc_generaNCAuto == "S") ? true : false;
                Orden.Value = info.tc_Orden;

                this.chbRetenIVA.Checked = (info.ESRetenIVA=="S") ? true : false;
                this.chbRetenFTE.Checked = (info.ESRetenFTE == "S") ? true : false;
                this.chkSe_Puede_depositar.Checked = (info.tc_SePuede_Depositar == "S") ? true : false;
                this.cmbEstadoCobro.EditValue=info.IdEstadoCobro_Inicial;
                this.txtPorcReten.EditValue= info.PorcentajeRet;
                this.cmbTipoRegGene.set_CatalogosInfo(info.tc_Que_Tipo_Registro_Genera);

                cmb_motivo.EditValue = info.IdMotivo_tipo_cobro ; 

                this.cmbTomarCtaCble.EditValue = info.tc_Tomar_Cta_Cble_De;
                           
                List<cxc_cobro_tipo_Param_conta_x_sucursal_Info> LISTA = new List<cxc_cobro_tipo_Param_conta_x_sucursal_Info>();
                LISTA = busparam.Get_List_cobro_tipo_Param_conta_x_sucursal(param.IdEmpresa, info.IdCobro_tipo);
             

                ListaBind = new BindingList<cxc_cobro_tipo_Param_conta_x_sucursal_Info>(LISTA);
                gridConsulta.DataSource = ListaBind;


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void get() 
        {
            try
            {
                info.IdCobro_tipo=txtId.Text;
                info.tc_abreviatura=txtAbreviatura.Text;
                info.tc_descripcion =txtDescripcion.Text;
                info.tc_Afecha = (chbAfecha.Checked == true) ? "S" : "N";
                info.tc_docXCobrar = (chbDxC.Checked == true) ? "S" : "N";
                info.tc_EsCheque = (chbEsCheque.Checked == true) ? "S" : "N";
                info.Estado = (chbEstado.Checked == true) ? "A" : "I";
                info.tc_interno = (chbInterno.Checked == true) ? "S" : "N";
                info.tc_generaNCAuto=(chbNCAuto.Checked==true)?"S":"N";
                info.tc_Orden=Convert.ToInt32(Orden.Value);
                info.ESRetenIVA = (chbRetenIVA.Checked == true) ? "S" : "N";
                info.ESRetenFTE = (chbRetenFTE.Checked == true) ? "S" : "N";
                info.IdEstadoCobro_Inicial = Convert.ToString(this.cmbEstadoCobro.EditValue);
                info.PorcentajeRet = Convert.ToDouble(this.txtPorcReten.EditValue);
                info.IdMotivo_tipo_cobro = cmb_motivo.EditValue.ToString();

                info.IdUsuario = param.IdUsuario;
                info.ip = param.ip;
                info.nom_pc = param.nom_pc;
                info.Fecha_Transac=Convert.ToDateTime(DateTime.Now.ToShortDateString());
                info.Fecha_UltAnu = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                info.Fecha_UltMod = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                info.IdUsuarioUltAnu = param.IdUsuario;
                info.IdUsuarioUltMod = param.IdUsuario;

                info.tc_seMuestraManCheque = "N";
                info.tc_Que_Tipo_Registro_Genera = cmbTipoRegGene.get_CatalogosInfo().IdCatalogo;
                info.tc_seCobra = "N";
                info.tc_SePuede_Depositar = (chkSe_Puede_depositar.Checked == true) ? "S" : "N";
                info.tc_Tomar_Cta_Cble_De = Convert.ToString(cmbTomarCtaCble.EditValue);

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public List<cxc_cobro_tipo_Param_conta_x_sucursal_Info> getGrid()
        {
            try
            {
                List<cxc_cobro_tipo_Param_conta_x_sucursal_Info> cxc = new List<cxc_cobro_tipo_Param_conta_x_sucursal_Info>();
                for (int i = 0; i < gridView.RowCount-1; i++)
                {
                    cxc_cobro_tipo_Param_conta_x_sucursal_Info infocxc = new cxc_cobro_tipo_Param_conta_x_sucursal_Info();
                    infocxc.IdCobro_tipo =  txtId.Text;
                    infocxc.IdEmpresa = param.IdEmpresa;
                    infocxc.IdSucursal = Convert.ToInt32(gridView.GetRowCellValue(i, colSucursal));
                    //infocxc.IdCtaCble_Credito = Convert.ToString(gridView.GetRowCellValue(i, colIdCtaCble_Credito));
                    infocxc.IdCtaCble = Convert.ToString(gridView.GetRowCellValue(i, colIdCtaCble_Deudora));
                    infocxc.IdCtaCble_Anticipo = Convert.ToString(gridView.GetRowCellValue(i, colIdCtaCble_Anticipo));
                    cxc.Add(infocxc);
                }
                return cxc;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return new List<cxc_cobro_tipo_Param_conta_x_sucursal_Info>();
            }
        }

        cxc_EstadoCobro_Bus Bus_EstadoCobro = new cxc_EstadoCobro_Bus();
        cxc_catalogo_Bus Bus_Catalogo = new cxc_catalogo_Bus();
        void Carga_combos()
        {
            try
            {
                List<cxc_EstadoCobro_Info> listaEstadoCobro = new List<cxc_EstadoCobro_Info>();
                listaEstadoCobro = Bus_EstadoCobro.Get_List_EstadoCobro();
                this.cmbEstadoCobro.Properties.DataSource = listaEstadoCobro;

                foreach (var item in listaEstadoCobro)
                {
                    if (item.IdEstadoCobro == "COBR")
                    {
                        cmbEstadoCobro.EditValue = item.IdEstadoCobro;
                    }
                }
                
                cmbTipoRegGene.cargar_Catalogos("TRANS_GENERADA");

                cxc_cobro_tipo_motivo_Bus BusMotivo = new cxc_cobro_tipo_motivo_Bus();
                List<cxc_cobro_tipo_motivo_Info> listMotivo = new List<cxc_cobro_tipo_motivo_Info>();
                listMotivo=BusMotivo.Get_List_cobro_tipo_motivo();;

                cmb_motivo.Properties.DataSource = listMotivo;




            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }                               
        }

        private void frmCo_cxc_cobro_tipo_Mant_Load(object sender, EventArgs e)
        {
            try
            {             
               //
                ListaBind = new BindingList<cxc_cobro_tipo_Param_conta_x_sucursal_Info>();
               // gridConsulta.DataSource = ListaBind;
                //            
                this.Carga_combos();
                
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        chbEstado.Checked = true;
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        ucGe_Menu.Visible_btnGuardar = ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        bloquear_Controles();
                        set();
                        break;

                    case Cl_Enumeradores.eTipo_action.Anular:
                        ucGe_Menu.Visible_btnGuardar = ucGe_Menu.Visible_bntGuardar_y_Salir = false;        
                        break;

                    case Cl_Enumeradores.eTipo_action.actualizar:
                        txtId.Enabled = false;                     
                        set();
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
//

        void bloquear_Controles()
        {

            try
            {
                 this.gridView.OptionsBehavior.Editable = false;
            
                    this.txtId.Enabled = false;
                    this.txtId.BackColor = System.Drawing.Color.White;
                    this.txtId.ForeColor = System.Drawing.Color.Black;

                    this.txtAbreviatura.Enabled = false;
                    this.txtAbreviatura.BackColor = System.Drawing.Color.White;
                    this.txtAbreviatura.ForeColor = System.Drawing.Color.Black;

                    this.txtDescripcion.Enabled = false;
                    this.txtDescripcion.BackColor = System.Drawing.Color.White;
                    this.txtDescripcion.ForeColor = System.Drawing.Color.Black;

                    this.txtPorcReten.Enabled = false;
                    this.txtPorcReten.BackColor = System.Drawing.Color.White;
                    this.txtPorcReten.ForeColor = System.Drawing.Color.Black;

                    this.Orden.Enabled = false;
                    this.Orden.BackColor = System.Drawing.Color.White;
                    this.Orden.ForeColor = System.Drawing.Color.Black;
            
                    this.cmbEstadoCobro.Enabled = false;
                    this.cmbEstadoCobro.BackColor = System.Drawing.Color.White;
                    this.cmbEstadoCobro.ForeColor = System.Drawing.Color.Black;

                    this.chbEsCheque.Enabled = false;
                    this.chbEsCheque.BackColor = System.Drawing.Color.White;
                    this.chbEsCheque.ForeColor = System.Drawing.Color.Black;

                    this.chbAfecha.Enabled = false;
                    this.chbAfecha.BackColor = System.Drawing.Color.White;
                    this.chbAfecha.ForeColor = System.Drawing.Color.Black;

                    this.chbDxC.Enabled = false;
                    this.chbDxC.BackColor = System.Drawing.Color.White;
                    this.chbDxC.ForeColor = System.Drawing.Color.Black;

                    
                    this.chbNCAuto.Enabled = false;
                    this.chbNCAuto.BackColor = System.Drawing.Color.White;
                    this.chbNCAuto.ForeColor = System.Drawing.Color.Black;

                    this.chbInterno.Enabled = false;
                    this.chbInterno.BackColor = System.Drawing.Color.White;
                    this.chbInterno.ForeColor = System.Drawing.Color.Black;

                    this.chbRetenIVA.Enabled = false;
                    this.chbRetenIVA.BackColor = System.Drawing.Color.White;
                    this.chbRetenIVA.ForeColor = System.Drawing.Color.Black;

                    this.chbRetenFTE.Enabled = false;
                    this.chbRetenFTE.BackColor = System.Drawing.Color.White;
                    this.chbRetenFTE.ForeColor = System.Drawing.Color.Black;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
      
        }

        private Boolean verificarrepetidos(int IdSucursal, Boolean eliminar, int tipo, Cl_Enumeradores.eTipo_action _Accion)
        {
            try
            {            
                if (_Accion==Cl_Enumeradores.eTipo_action.grabar)
                {
                    ListaBind = new BindingList<cxc_cobro_tipo_Param_conta_x_sucursal_Info>(lista);               
                }
                               
               var cont = from C in ListaBind            
                           where C.IdSucursal == IdSucursal
                           select C;
                if (cont.Count() == tipo)
                {
                    return true;
                }
                else
                {
                    if (eliminar == true)
                    {
                        gridView.DeleteRow(gridView.FocusedRowHandle);
                        MessageBox.Show("La sucursal ya se encuentra ingresada. Se procederá con su eliminación.");
                    }
                    else
                    {

                        MessageBox.Show("El código ya se encuentra ingresado.");
                    }
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
//

        Boolean Validar()
        {
            try
            {
                if (this.txtId.Text == "")
                {
                    MessageBox.Show("Ingrese el código. Por favor", "Sistemas");
                    return false;
                }
                else
                {
                    cxc_catalogo_Info tiporeg = new cxc_catalogo_Info();
                    tiporeg=cmbTipoRegGene.get_CatalogosInfo() ;
                    if (tiporeg == null || tiporeg.IdCatalogo==null)
                    {
                        MessageBox.Show("Escoja el Tipo de registo q genera", "Sistemas");
                        return false;
                    }

                    if (cmb_motivo.EditValue==null )
                    {
                        MessageBox.Show("Escoja el Tipo de cobro", "Sistemas");
                        return false;
                    }
                    else
                    {

                        if (this.txtDescripcion.Text == "")
                        {
                            MessageBox.Show("Ingrese el nombre del tipo de cobro. Por favor", "Sistemas");
                            return false;
                        }

                        else
                        {

                            if (cmbTipoRegGene.get_CatalogosInfo()==null)
                        {
                            MessageBox.Show("Por favor ingrese el tipo de registro a generar.", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return false;
                               
                        }

                             else
                             {
                                 if ( this.cmbEstadoCobro.EditValue == null)
                                 {
                                     MessageBox.Show("Ingrese el estado del cobro. Por favor", "Sistemas");
                                     return false;
                                 }

                                 else
                                 {

                                     double porc = Convert.ToDouble(this.txtPorcReten.EditValue);

                                     if (this.chbRetenFTE.Checked == true || this.chbRetenFTE.Checked == true)
                                     {
                                        if ( porc == 0)
                                        {
                                            MessageBox.Show("Ingrese el porcentaje de retención. Por favor", "Sistemas");
                                            return false;
                                        }
                                     }
                                 }
                             }                     
                        }                     
                    }
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


        public delegate void delegate_frmCo_cxc_cobro_tipo_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmCo_cxc_cobro_tipo_Mant_FormClosing event_frmCo_cxc_cobro_tipo_Mant_FormClosing;
        private void frmCo_cxc_cobro_tipo_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
            
                event_frmCo_cxc_cobro_tipo_Mant_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void xtraTabPage1_Paint(object sender, PaintEventArgs e)
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

        private void gridView_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Delete)
                {
                    if (MessageBox.Show("¿Está seguro que desea Eliminar este registro ?", "Elimina", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        gridView.DeleteSelectedRows();
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        cxc_cobro_tipo_Param_conta_x_sucursal_Info row = new cxc_cobro_tipo_Param_conta_x_sucursal_Info();
                
        private void gridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                                            
                row = (cxc_cobro_tipo_Param_conta_x_sucursal_Info)gridView.GetRow(e.RowHandle);
              
                if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    lista.Add(row);
                }
                         
                if (row != null)
                {
                    if (e.Column.Name == "colSucursal")
                    {
                        if (verificarrepetidos(Convert.ToInt32(e.Value), true, 1, _Accion))
                        {

                        }
                    }
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chbRetenFTE_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chbRetenFTE.Checked == true)
                {
                    this.chbRetenIVA.Checked = false;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                              
        }

        private void chbRetenIVA_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chbRetenIVA.Checked == true)
                {
                    this.chbRetenFTE.Checked = false;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
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



    }
}
//640