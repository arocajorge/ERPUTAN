/*CLASE: frmRo_Nomina_Orden_Rubro_Cons
 *MODIFICADO POR: ALBERTO MENA
 *FECHA: 25-03-2015
 *DERECHOS RESERVADOS - INNOVATECORP
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using DevExpress.Utils;


using Core.Erp.Info.Roles;
using Core.Erp.Business.Roles;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Winform.General;
using Core.Erp.Recursos.Properties;

namespace Core.Erp.Winform.Roles
{
    public partial class frmRo_Nomina_Tipoliqui_Mant : Form
    {
        #region DEclaración de Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        ro_Nomina_Tipoliqui_Info Cab = new ro_Nomina_Tipoliqui_Info();
        Cl_Enumeradores.eTipo_action Accion = new Cl_Enumeradores.eTipo_action();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        ro_Nomina_Tipoliqui_Bus busTipo = new ro_Nomina_Tipoliqui_Bus();
        string msg = "";
        public delegate void delegate_frmRo_Nomina_Tipoliqui_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmRo_Nomina_Tipoliqui_Mant_FormClosing event_frmRo_Nomina_Tipoliqui_Mant_FormClosing;





        public int oIdNominaTipo { get; set; }
        public int oIdNominaTipoLiqui { get; set; }
        public int oIdEmpresa { get; set; }
       
        //BUS
        ro_nomina_tipo_liqui_orden_Bus oRo_nomina_tipo_liqui_orden_Bus = new ro_nomina_tipo_liqui_orden_Bus();
        ro_rubro_tipo_Bus oRo_rubro_tipo_Bus = new ro_rubro_tipo_Bus();

        //INFO
        //List<ro_nomina_tipo_liqui_orden_Info> oLstOrdenRubrosNomina_Info = new List<ro_nomina_tipo_liqui_orden_Info>();
        BindingList<ro_nomina_tipo_liqui_orden_Info> oLstOrdenRubrosNomina_Info = new BindingList<ro_nomina_tipo_liqui_orden_Info>();
        List<ro_rubro_tipo_Info> oListRo_rubro_tipo_Info=new List<ro_rubro_tipo_Info>();

        #endregion

        
        public frmRo_Nomina_Tipoliqui_Mant()
        {
            try
            {
                InitializeComponent();
                ucGe_Menu.event_btnAnular_Click += ucGe_Menu_event_btnAnular_Click;
                ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
                ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
                ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
                event_frmRo_Nomina_Tipoliqui_Mant_FormClosing+=frmRo_Nomina_Tipoliqui_Mant_event_frmRo_Nomina_Tipoliqui_Mant_FormClosing;

 //               this.cmdEditarFormula.ButtonClick += cmdEditarFormula_ButtonClick;
            
            
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
                if (this.grabar())
                    this.Close();
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
                this.grabar();
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
                anular();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        public void setCab(ro_Nomina_Tipoliqui_Info Info)
        {
            try
            {
                Cab = Info;

                oLstOrdenRubrosNomina_Info = new BindingList<ro_nomina_tipo_liqui_orden_Info>();

                if (Cab != null)
                {
                    txtId.Text = Convert.ToString(Info.IdNomina_Tipo);
                    txtDescripcion.Text = Info.DescripcionProcesoNomina;
                    cmbNomina.EditValue = Info.IdNomina_Tipo;
                    checkBoxEstado.Checked = (Info.Estado == "A") ? true : false;
                    if (Info.Estado == "I" && Accion == Cl_Enumeradores.eTipo_action.actualizar)
                        checkBoxEstado.Enabled = true;

                    if (Info.Estado == "I")
                    {
                        lblAnulado.Visible = true;

                    }
                    else
                    {
                        lblAnulado.Visible = false;
                    }


                    //CARGAR GRI
                    var oListado = oRo_nomina_tipo_liqui_orden_Bus.Get_List_nomina_tipo_liqui_orden(Cab.IdEmpresa, Cab.IdNomina_Tipo, Cab.IdNomina_TipoLiqui);
                    oLstOrdenRubrosNomina_Info = new BindingList<ro_nomina_tipo_liqui_orden_Info>(oListado);
                }
                else {//CREO EL OBJETO CABECERA
                    Cab = new ro_Nomina_Tipoliqui_Info();
                    }

                //SETEA EL DATASOURCE A LA GRILLA
                gridListado.DataSource = oLstOrdenRubrosNomina_Info;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private Boolean getInfo()
        {
            try
            {
                if (txtDescripcion.Text == "")
                { MessageBox.Show("Ingrese una descripción para grabar"); return false; }
                else if (Convert.ToInt32(cmbNomina.EditValue) == 0)
                { MessageBox.Show("Seleccione el tipo de nómina para grabar"); return false; }
                else
                {
                    Cab.IdEmpresa = param.IdEmpresa;
                    Cab.DescripcionProcesoNomina = txtDescripcion.Text;
                    Cab.IdNomina_Tipo = Convert.ToInt32(cmbNomina.EditValue);
                    Cab.Estado = (checkBoxEstado.Checked == true) ? "A" : "I";

                    //PERMITE ACTUALIZAR LOS DATOS DE LA GRILLA
                    if (oLstOrdenRubrosNomina_Info.Count>0){
                        Cab.oLstNominaRubroOrden.Clear();
                        foreach (var item in oLstOrdenRubrosNomina_Info)
                        {
                            ro_nomina_tipo_liqui_orden_Info oInfo = new ro_nomina_tipo_liqui_orden_Info();
                            oInfo.IdEmpresa = param.IdEmpresa;
                            oInfo.IdNominaTipo = Cab.IdNomina_Tipo;
                            oInfo.IdNominaTipoLiqui = Cab.IdNomina_TipoLiqui;
                            oInfo.Orden = item.Orden;
                            oInfo.IdRubro = item.IdRubro;
                            oInfo.Descripcion = item.Descripcion == null ? "" : item.Descripcion.Trim();
                            oInfo.Formula = item.Formula == null ? "" : item.Formula.Trim();
                            oInfo.EsVisible = item.EsVisible == null ? false : Convert.ToBoolean(item.EsVisible);
                            oInfo.UsuarioIngresa = param.IdUsuario;
                            oInfo.FechaIngresa = param.Fecha_Transac;
                            oInfo.FechaModifica = param.Fecha_Transac;
                            oInfo.UsuarioModifica = param.IdUsuario;
                            Cab.oLstNominaRubroOrden.Add(oInfo);
                        }                  
                    }

                    switch (Accion)
                    {
                        case Cl_Enumeradores.eTipo_action.actualizar:
                            Cab.FechaUltModi = param.Fecha_Transac;
                            Cab.IdUsuarioUltModi = param.IdUsuario;

                            return true;
                        case Cl_Enumeradores.eTipo_action.grabar:
                            Cab.FechaTransac = param.Fecha_Transac;
                            Cab.IdUsuario = param.IdUsuario;
                            return true;
                        default:
                            return false;
                    }                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString()); 
                return false;
            }

        }
     
        private Boolean grabar()
        {
            try
            {
                txtDescripcion.Focus();
                if (getInfo())
                {
                    switch (Accion)
                    {
                        case Cl_Enumeradores.eTipo_action.actualizar:
                            if (busTipo.ModificaDB(Cab, ref msg))
                            {
                               // txtId.Text = Convert.ToString(Cab.IdNomina_TipoLiqui );
                                MessageBox.Show(Resources.msgConfirmaGrabarOk, Resources.msgTituloGrabar, MessageBoxButtons.OK, MessageBoxIcon.Information);

                                setCab(Cab);
                                //btn_grabar.Visible = false;
                                //btn_grabarYSalir.Visible = false;
                                ucGe_Menu.Enabled_bntAnular = false;
                               // ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                                //ucGe_Menu.Visible_btnGuardar = false;
                                return true;
                            }
                            else return false;


                        case Cl_Enumeradores.eTipo_action.grabar:
                            int id = 0;
                            if (busTipo.GrabarDB(Cab, ref id, ref msg))
                            {
                                MessageBox.Show(Resources.msgConfirmaGrabarOk, Resources.msgTituloGrabar, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txtId.Text = Convert.ToString(id);
                                
                                ucGe_Menu.Enabled_bntAnular = false;
                                //ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                                //ucGe_Menu.Visible_btnGuardar = false;

                                return true;
                            }
                            else return false;

                        default:
                            return false;
                    }
                }
                else return false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
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
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }



        private void pu_CargaInicial() {
            try
            {
                event_frmRo_Nomina_Tipoliqui_Mant_FormClosing += frmRo_Nomina_Tipoliqui_Mant_event_frmRo_Nomina_Tipoliqui_Mant_FormClosing;

                ro_Nomina_Tipo_Bus busTipoNom = new ro_Nomina_Tipo_Bus();
                cmbNomina.Properties.DataSource = busTipoNom.Get_List_Nomina_Tipo(param.IdEmpresa);

                //CARGAR DATOS EN EL COMBO RUBROS
                oListRo_rubro_tipo_Info = oRo_rubro_tipo_Bus.Get_List_Formulas(param.IdEmpresa);
                cmbRubro.DataSource = oListRo_rubro_tipo_Info;



                //Carga combo Tipo de Campo            
                ro_Catalogo_Bus tlB = new ro_Catalogo_Bus();
                List<ro_Catalogo_Info> listTL = new List<ro_Catalogo_Info>();
                listTL = tlB.Get_List_Catalogo_x_Tipo(13);
                this.cmbTipoCalc.DataSource= listTL;
                cmbTipoCalc.DisplayMember = "ca_descripcion";
                cmbTipoCalc.ValueMember = "IdCatalogo";



                if (Accion == Cl_Enumeradores.eTipo_action.consultar)
                {
                    ucGe_Menu.Enabled_bntAnular = false;
                    ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                    ucGe_Menu.Visible_btnGuardar = false;
                    this.txtDescripcion.ReadOnly = true;
                    this.txtDescripcion.BackColor = System.Drawing.Color.White;

                    this.cmbNomina.Enabled = false;
                    this.cmbNomina.BackColor = System.Drawing.Color.White;
                    this.cmbNomina.ForeColor = System.Drawing.Color.Black;

                    viewListado.OptionsBehavior.ReadOnly = true;

                }
                else if (Accion == Cl_Enumeradores.eTipo_action.Anular)
                {
                    ucGe_Menu.Enabled_bntAnular = true;
                    ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                    ucGe_Menu.Visible_btnGuardar = false;

                    this.cmbNomina.Enabled = false;
                    this.cmbNomina.BackColor = System.Drawing.Color.White;
                    this.cmbNomina.ForeColor = System.Drawing.Color.Black;

                    this.txtDescripcion.ReadOnly = true;
                    this.txtDescripcion.BackColor = System.Drawing.Color.White;
                    viewListado.OptionsBehavior.ReadOnly = true;

                }
                else if (Accion == Cl_Enumeradores.eTipo_action.actualizar)
                {
                    ucGe_Menu.Enabled_bntAnular = true;
                    ucGe_Menu.Visible_bntGuardar_y_Salir = true;
                    ucGe_Menu.Visible_btnGuardar = true;

                    this.cmbNomina.Enabled = false;
                    this.cmbNomina.BackColor = System.Drawing.Color.White;
                    this.cmbNomina.ForeColor = System.Drawing.Color.Black;

                    this.txtDescripcion.ReadOnly = false;
                    this.txtDescripcion.BackColor = System.Drawing.Color.White;
                    viewListado.OptionsBehavior.ReadOnly = false;

                }
                else if (Accion == Cl_Enumeradores.eTipo_action.grabar) { 
                    
                    lblAnulado.Visible = false;
                    viewListado.OptionsBehavior.ReadOnly = false;

                }


                pu_CrearGrillaFormula();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        
        
        
        
        }



        private void frmRo_Nomina_Tipoliqui_Mant_Load(object sender, EventArgs e)
        {
            pu_CargaInicial();           
        }

        void frmRo_Nomina_Tipoliqui_Mant_event_frmRo_Nomina_Tipoliqui_Mant_FormClosing(object sender, FormClosingEventArgs e){}

        private void frmRo_Nomina_Tipoliqui_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                 event_frmRo_Nomina_Tipoliqui_Mant_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }
 
        void anular()
        {
            try
            {
                if (Cab != null)
                {
                    FrmGe_MotivoAnulacion oFrm = new FrmGe_MotivoAnulacion();
                    if (Cab.Estado == "A")
                    {
                        if (MessageBox.Show("¿Está seguro que desea anular el reg # : " + Cab.IdNomina_TipoLiqui + " ?", "Anulación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            string msg = "";
                            oFrm.ShowDialog();
                            Cab.MotivoAnu = oFrm.motivoAnulacion;
                            Cab.IdUsuarioAnu = param.IdUsuario;
                            Cab.FechaAnu = param.Fecha_Transac;
                            if (busTipo.AnularDB(Cab, ref msg))
                            {
                                MessageBox.Show(Resources.msgConfirmaAnulacionOk, Resources.msgTituloAnular, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                checkBoxEstado.Checked = false;
                                lblAnulado.Visible = true;
                                ucGe_Menu.Enabled_bntAnular = true;
                                ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                                ucGe_Menu.Visible_btnGuardar = false;
                            }
                            else MessageBox.Show("No se pudo anular el reg# : " + Cab.IdNomina_TipoLiqui + " debido a: "
                                + msg, "Anulación", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                    else
                    {
                        MessageBox.Show("No se pudo anular el Reg #: " + Cab.IdNomina_TipoLiqui, "Anulación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e){}

        private void frmRo_Nomina_Tipoliqui_Mant_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }



       



    

        private void gridListado_Click(object sender, EventArgs e)
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

                oListadoRubro = oRo_rubro_tipo_Bus.Get_List_Formulas(param.IdEmpresa);

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
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

            private void cmdEditarFormula_ButtonClick(object sender, ButtonPressedEventArgs e){
                try {

                    ro_nomina_tipo_liqui_orden_Info oRo_nomina_tipo_liqui_orden_Info = (ro_nomina_tipo_liqui_orden_Info)viewListado.GetFocusedRow();

                    if (oRo_nomina_tipo_liqui_orden_Info != null)
                    {
                        ro_rubro_tipo_Bus oRo_rubro_tipo_Bus = new ro_rubro_tipo_Bus();
                        ro_rubro_tipo_Info oRo_rubro_tipo_Info = oRo_rubro_tipo_Bus.GetInfoConsultaPorId(param.IdEmpresa, oRo_nomina_tipo_liqui_orden_Info.IdRubro);
                        ro_Catalogo_Bus oCatalogoBus = new ro_Catalogo_Bus();

                        string idCatalogo = (oCatalogoBus.Get_info_Catalogo((oRo_rubro_tipo_Info.rub_tipcal == null ? 0 : Convert.ToInt32(oRo_rubro_tipo_Info.rub_tipcal)))).CodCatalogo;

                        if (idCatalogo == "TPC4")
                        {
                            string valor = viewListado.GetRowCellValue(viewListado.FocusedRowHandle, viewListado.Columns["Formula"]).ToString();
                            
                            if (valor!="")
                            {
                                view.Columns[oRo_rubro_tipo_Info.ru_codRolGen.Trim()].UnboundExpression = valor;
                            }

                            view.ShowUnboundExpressionEditor(view.Columns[oRo_rubro_tipo_Info.ru_codRolGen.Trim()]);

                         valor = view.Columns[oRo_rubro_tipo_Info.ru_codRolGen.Trim()].UnboundExpression;

                         //SETEA LE VALOR DE LA CELDA ACTUAL
                         viewListado.SetRowCellValue(viewListado.FocusedRowHandle, viewListado.Columns["Formula"], valor);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    Log_Error_bus.Log_Error(ex.ToString());
                }

    
            }

            private void viewListado_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
            {
                ro_nomina_tipo_liqui_orden_Info oFila = new ro_nomina_tipo_liqui_orden_Info();

                try
                {

                    int cont = 0;
                    oFila = (ro_nomina_tipo_liqui_orden_Info)viewListado.GetRow(e.RowHandle);


                    if (oFila != null)
                    {
                        if (e.Column.Name == "colOrden")
                        {
                            cont = (from a in oLstOrdenRubrosNomina_Info
                                    where a.Orden == oFila.Orden
                                    select a).Count();
                            if (cont > 1)
                            {
                                MessageBox.Show("El Orden se encuentra repetido, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            }

                        }

                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    Log_Error_bus.Log_Error(ex.ToString());
                }

            }

            private void viewListado_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
            {
                e.ExceptionMode = ExceptionMode.NoAction;
            }

            private void viewListado_KeyDown(object sender, KeyEventArgs e)
            {
                if (e.KeyCode == Keys.Delete)
                {
                    if (MessageBox.Show("¿Está seguro que desea eliminar este registro ?", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        viewListado.DeleteSelectedRows();
                    }

                }

            }

            private void viewListado_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
            {
                try
                {
                    GridView view = sender as GridView;
                    GridColumn inOrdenCol = view.Columns["colOrden"];

                    ro_nomina_tipo_liqui_orden_Info oFila = new ro_nomina_tipo_liqui_orden_Info();
                    oFila = (ro_nomina_tipo_liqui_orden_Info)viewListado.GetRow(e.RowHandle);

                    int cont = 0;

                    cont = (from a in oLstOrdenRubrosNomina_Info
                            where a.Orden == oFila.Orden
                            select a).Count();

                    if (cont > 1)
                    {
                        e.Valid = false;
                        view.SetColumnError(inOrdenCol, "El Orden se encuentra repetido, revise por favor");
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                    Log_Error_bus.Log_Error(ex.ToString());
                }
            }

            private void viewListado_Click(object sender, EventArgs e)
            {

            }

          
    

       


            
       



    }
}
