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

namespace Core.Erp.Winform.Academico
{
    public partial class FrmAca_Rubro_x_Aca_Periodo_Lectivo_Mant : Form
    {
        #region "Variables"
        private Cl_Enumeradores.eTipo_action Accion;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        Aca_Rubro_Info rubroInfo = new Aca_Rubro_Info();

        public delegate void delegate_FrmAca_Rubro_x_Aca_Periodo_Lectivo_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_FrmAca_Rubro_x_Aca_Periodo_Lectivo_Mant_FormClosing event_FrmAca_Rubro_x_Aca_Periodo_Lectivo_Mant_FormClosing;

        BindingList<Aca_Rubro_x_Aca_Periodo_Lectivo_Info> Lista_Periodo_x_Rubro = new BindingList<Aca_Rubro_x_Aca_Periodo_Lectivo_Info>();
        Aca_Rubro_x_Aca_Periodo_Lectivo_Bus Periodo_x_Rubro_Bus = new Aca_Rubro_x_Aca_Periodo_Lectivo_Bus();
        List<Aca_Rubro_x_Aca_Periodo_Lectivo_Info> BLista_Periodo_x_rubro = new List<Aca_Rubro_x_Aca_Periodo_Lectivo_Info>();
        Aca_Rubro_x_Aca_Periodo_Lectivo_Info InfoRubroPeriodo = new Aca_Rubro_x_Aca_Periodo_Lectivo_Info();

        Aca_RubroTipo_Bus BusTipoRubro = new Aca_RubroTipo_Bus();
        List<Aca_RubroTipo_Info> Lista_TipoRubro = new List<Aca_RubroTipo_Info>();

        Aca_Periodo_Bus BusPeriodo = new Aca_Periodo_Bus();
        Aca_Periodo_Info Info_Periodo = new Aca_Periodo_Info();
        List<Aca_Periodo_Info> List_Periodo = new List<Aca_Periodo_Info>();

        BindingList<Aca_Rubro_x_Aca_Periodo_Lectivo_Info> Lista_Rubro_x_Periodo;


        #endregion

        public FrmAca_Rubro_x_Aca_Periodo_Lectivo_Mant()
        {
            InitializeComponent();
            event_FrmAca_Rubro_x_Aca_Periodo_Lectivo_Mant_FormClosing += FrmAca_Rubro_x_Aca_Periodo_Lectivo_Mant_event_FrmAca_Rubro_x_Aca_Periodo_Lectivo_Mant_FormClosing;
        }

        void FrmAca_Rubro_x_Aca_Periodo_Lectivo_Mant_event_FrmAca_Rubro_x_Aca_Periodo_Lectivo_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            
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
                rInfo = ucAca_Rubro1.get_item_info();
                //rInfo.IdInstitucion = param.IdInstitucion;
                //rInfo.IdRubro = (txtIdRubro.Text != "") ? Convert.ToInt32(txtIdRubro.Text) : 0;
                //rInfo.IdRubro = (txtIdRubro.Text != "") ? Convert.ToInt32(txtIdRubro.Text) : 0;

                //rInfo.Descripcion_rubro = txtDescripcionRubro.Text;
                //rInfo.Deb_cred =  cmbDebeHaber.EditValue.ToString();
                //rInfo.CodRubro = txtCodigoRubro.Text;
                //rInfo.IdGrupoFE = Convert.ToInt16(cmbFEE.EditValue.ToString());
                //rInfo.CodAlterno = string.Empty;
                //rInfo.IdTipoServicio = cmbTipoServicio.EditValue.ToString();
                //rInfo.IdTipoRubro = Convert.ToInt16(cmbTipoRubro.EditValue.ToString());
                //rInfo.NumeroCoutas = 0;
                //rInfo.UsuarioCreacion = param.IdUsuario;
                //rInfo.UsuarioModificacion = param.IdUsuario;
                //rInfo.IdCtaCble = ucCon_Plan_de_Cuenta_x_Movimiento1.get_CuentaInfo().IdCtaCble;
                //if (Accion == Cl_Enumeradores.eTipo_action.grabar)
                //{
                //    chkActivo.Checked = true;
                //}

                //rInfo.estado = (chkActivo.Checked == true) ? "A" : "I";
                //if (chkActivo.Checked)
                //{
                //    lblAnulado.Visible = false;
                //}
                //else { lblAnulado.Visible = true; }

                //Get_List_Rubro_x_Periodo();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                mensaje = ex.Message.ToString();
                MessageBox.Show("Error " + mensaje, "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return rInfo;
        }

        public BindingList<Aca_Rubro_x_Aca_Periodo_Lectivo_Info> Get_List_Rubro_x_Periodo()
        {
            try
            {
                BindingList<Aca_Rubro_x_Aca_Periodo_Lectivo_Info> lsttemp = new BindingList<Aca_Rubro_x_Aca_Periodo_Lectivo_Info>();

                for (int i = 0; i < gridView_Valores_x_Periodo.RowCount; i++)
                {
                    var ass = (Aca_Rubro_x_Aca_Periodo_Lectivo_Info)gridView_Valores_x_Periodo.GetRow(i);
                    if (ass != null && ass.chequeo == true)
                    {
                        Aca_Rubro_x_Aca_Periodo_Lectivo_Info row = new Aca_Rubro_x_Aca_Periodo_Lectivo_Info();
                        row.IdInstitucion_rub = param.IdInstitucion;

                        row.IdRubro = Convert.ToInt16(ucAca_Rubro1.get_item());
                        //row.IdRubro = rubroInfo.IdRubro;

                        row.IdInstitucion_per = ass.IdInstitucion_per;
                        row.IdAnioLectivo = ass.IdAnioLectivo;
                        row.IdPeriodo = ass.IdPeriodo;
                        row.Valor = ass.Valor;
                        row.Estado = "A";

                        if (row.Valor > 0)
                            lsttemp.Add(row);
                        else
                        {
                            MessageBox.Show("Ingrese un Valor", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }

                       // lsttemp.Add(row);
                    }
                }

                Lista_Periodo_x_Rubro = lsttemp;
                //Lista_Periodo_x_Rubro  = (List<com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det_Info>)gridvwDetListMaterialesDisponibles_PreAsignado_a_Obra.DataSource;
                if (Lista_Periodo_x_Rubro.Count < 1)
                {
                    MessageBox.Show("Debe Seleccionar el Periodo y su Valor", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    return lsttemp;
                }
                return Lista_Periodo_x_Rubro;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message);
                return new BindingList<Aca_Rubro_x_Aca_Periodo_Lectivo_Info>();
            }
        }
        #endregion

        #region "CargarDatos"
        public void CargarCombos() {
            try
            {
                ucAca_Anio_Lectivo1.cargaCmb_Anio_Lectivo_Activo();
                ucAca_Rubro1.cargaCmb_Rubro();
                ucAca_Rubro1.set_item(rubroInfo.IdRubro);
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
               
                lblAnulado.Visible = (rubroInfo.estado == "I") ? true : false;
                
              

                Cargar_Periodos(param.IdInstitucion, rubroInfo.IdRubro);
                //CargarCombos();
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        private void Cargar_Periodos(int IdInstitucion,int IdRubro)
        {
            try
            {
                //lleno el gridcontrol mediante un BindingList
                List_Periodo = new List<Aca_Periodo_Info>();
                List_Periodo = BusPeriodo.Get_List_Periodo_x_AnioLectivo(param.IdInstitucion, ucAca_Anio_Lectivo1.get_item());
                

                foreach (var item in List_Periodo)
                {
                    InfoRubroPeriodo = new Aca_Rubro_x_Aca_Periodo_Lectivo_Info();


                    InfoRubroPeriodo.IdInstitucion_per = param.IdInstitucion;
                    InfoRubroPeriodo.IdPeriodo = item.IdPeriodo;
                    InfoRubroPeriodo.IdRubro = 0;
                    InfoRubroPeriodo.IdAnioLectivo = item.IdAnioLectivo;
                    //InfoRubroPeriodo.Valor = item.ValorRubro;
                    //InfoRubroPeriodo.Estado = item.pe_estado;
                    //InfoRubroPeriodo.Existe_en_Base = item.IdPeriodo;
                    InfoRubroPeriodo.FechaInicio = item.pe_FechaIni;
                    InfoRubroPeriodo.FechaFin = item.pe_FechaFin;

                    Lista_Periodo_x_Rubro.Add(InfoRubroPeriodo);
                }


                //BLista_Periodo_x_rubro = new BindingList<Aca_Rubro_x_Aca_Periodo_Lectivo_Info>(Periodo_x_Rubro_Bus.Get_List_rubro_x_periodo(IdInstitucion, IdRubro));
                gridControlValores_x_Periodo.DataSource = Lista_Periodo_x_Rubro;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }

        private void Cargar_Datos_a_Modificar(int IdInstitucion, int IdRubro)
        {
            try
            {
                Lista_Periodo_x_Rubro = new BindingList<Aca_Rubro_x_Aca_Periodo_Lectivo_Info>();
                Lista_Rubro_x_Periodo = new BindingList<Aca_Rubro_x_Aca_Periodo_Lectivo_Info>();
                lblAnulado.Visible = (rubroInfo.estado == "I") ? true : false;
                //lleno el gridcontrol mediante un BindingList
                List_Periodo = new List<Aca_Periodo_Info>();
                List_Periodo = BusPeriodo.Get_List_Periodo_x_AnioLectivo(param.IdInstitucion, ucAca_Anio_Lectivo1.get_item());

                Lista_Periodo_x_Rubro = Periodo_x_Rubro_Bus.Get_List_rubro_x_periodo(param.IdInstitucion, IdRubro);
                //Lista_Rubro_x_Periodo = Lista_Periodo_x_Rubro;

                foreach (var item in Lista_Periodo_x_Rubro)
                {
                    InfoRubroPeriodo = new Aca_Rubro_x_Aca_Periodo_Lectivo_Info();
                    InfoRubroPeriodo.IdInstitucion_per = param.IdInstitucion;
                    InfoRubroPeriodo.IdPeriodo = item.IdPeriodo;
                    InfoRubroPeriodo.IdRubro = item.IdRubro;
                    InfoRubroPeriodo.IdAnioLectivo = item.IdAnioLectivo;
                    InfoRubroPeriodo.Valor = item.Valor;
                    InfoRubroPeriodo.Estado = item.Estado;
                    //InfoRubroPeriodo.Existe_en_Base = item.IdPeriodo;
                    InfoRubroPeriodo.FechaInicio = item.FechaInicio;
                    InfoRubroPeriodo.FechaFin = item.FechaFin;
                    InfoRubroPeriodo.chequeo = true;
                    Lista_Rubro_x_Periodo.Add(InfoRubroPeriodo);
                }

                foreach (var item in List_Periodo)
                {
                    foreach (var itemPerxRubro in Lista_Periodo_x_Rubro)
                    {
                        
                        if (itemPerxRubro.IdPeriodo != item.IdPeriodo)
                        {
                            InfoRubroPeriodo = new Aca_Rubro_x_Aca_Periodo_Lectivo_Info();


                            InfoRubroPeriodo.IdInstitucion_per = param.IdInstitucion;
                            InfoRubroPeriodo.IdPeriodo = item.IdPeriodo;
                            InfoRubroPeriodo.IdRubro = 0;
                            InfoRubroPeriodo.IdAnioLectivo = item.IdAnioLectivo;
                            //InfoRubroPeriodo.Valor = item.ValorRubro;
                            //InfoRubroPeriodo.Estado = item.pe_estado;
                            //InfoRubroPeriodo.Existe_en_Base = item.IdPeriodo;
                            InfoRubroPeriodo.FechaInicio = item.pe_FechaIni;
                            InfoRubroPeriodo.FechaFin = item.pe_FechaFin;

                            Lista_Rubro_x_Periodo.Add(InfoRubroPeriodo);
                            break;
                        }
                    }

                    
                }
                Lista_Periodo_x_Rubro = new BindingList<Aca_Rubro_x_Aca_Periodo_Lectivo_Info>();

                if (Lista_Rubro_x_Periodo.Count == 0)
                {
                    Cargar_Periodos(IdInstitucion, IdRubro);
                }
                else
                {
                    Lista_Periodo_x_Rubro = Lista_Rubro_x_Periodo;
                    //BLista_Periodo_x_rubro = new BindingList<Aca_Rubro_x_Aca_Periodo_Lectivo_Info>(Periodo_x_Rubro_Bus.Get_List_rubro_x_periodo(IdInstitucion, IdRubro));
                    gridControlValores_x_Periodo.DataSource = Lista_Periodo_x_Rubro;
                }

                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }
        #region "Proceso"
        public bool Grabar()
        {
            bool resultado = false;
            try
            {
                Aca_Rubro_Info ruInfo = new Aca_Rubro_Info();
                Lista_Periodo_x_Rubro = new BindingList<Aca_Rubro_x_Aca_Periodo_Lectivo_Info>();
               

                string mensaje = string.Empty;
                int id = 0;

                ruInfo = GetRubro(ref mensaje);
                if (mensaje != "")
                {
                    MessageBox.Show(mensaje);
                    return false;
                }

              
                    //txtIdRubro.Text = id.ToString();

                    Lista_Periodo_x_Rubro = Get_List_Rubro_x_Periodo();
                    if (Periodo_x_Rubro_Bus.EliminarDB(param.IdInstitucion, ruInfo.IdRubro, ref mensaje))
                    {

                        resultado = Periodo_x_Rubro_Bus.GrabarDB(Lista_Periodo_x_Rubro, ref mensaje);
                    }
                
                

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
            return resultado;
        }

        public bool Actualizar()
        {  bool resultado=false;
            try
            {
                Aca_Rubro_Bus neg = new Aca_Rubro_Bus();
                Aca_Rubro_Info ruInfo = new Aca_Rubro_Info();
                string mensaje = string.Empty;

                Lista_Periodo_x_Rubro = new BindingList<Aca_Rubro_x_Aca_Periodo_Lectivo_Info>();

                Lista_Periodo_x_Rubro = Get_List_Rubro_x_Periodo();

                //ruInfo = GetRubro(ref mensaje);
                //if (mensaje != "")
                //{
                //    MessageBox.Show(mensaje);
                //    return false;
                //}

                //if (neg.ActualizarDB(ruInfo, ref mensaje))
                //{
                    if(Periodo_x_Rubro_Bus.EliminarDB(rubroInfo.IdInstitucion, rubroInfo.IdRubro, ref mensaje))
                    {
                        resultado = Periodo_x_Rubro_Bus.GrabarDB(Lista_Periodo_x_Rubro, ref mensaje);
                    }
                //}
                if (resultado)
                {
                    MessageBox.Show(mensaje, "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            return resultado;
        }

        private void Anular()
        {
            try
            {
                //if (rubroInfo.estado != "I")
                //{
                //    if (MessageBox.Show("¿Está seguro que desea anular el Rubro #:" + txtIdRubro.Text.Trim() + " ?", "Anulación de Mantenimiento Rubro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                //    {
                //        FrmGe_MotivoAnulacion fr = new FrmGe_MotivoAnulacion();
                //        fr.ShowDialog();   

                //        Aca_Rubro_Bus neg = new Aca_Rubro_Bus();
                //        Aca_Rubro_Info ruInfo = new Aca_Rubro_Info();
                //        string mensaje = string.Empty;

                //        ruInfo = GetRubro(ref mensaje);
                //        if (mensaje != "")
                //        {
                //            MessageBox.Show("Error " + mensaje, "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //        }
                //        ruInfo.UsuarioAnulacion = param.IdUsuario;
                //        ruInfo.MotivoAnulacion = fr.motivoAnulacion;
                //        bool resultado = neg.EliminarDB(ruInfo, ref mensaje);
                //        if (resultado)
                //        {
                //            MessageBox.Show(mensaje, "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //            this.ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                //            this.ucGe_Menu.Visible_btnGuardar = false;
                //        }
                //        else
                //        {
                //            Log_Error_bus.Log_Error(mensaje.ToString());
                //            MessageBox.Show("Error " + mensaje, "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //        }
                //    }
                //}
                //else {
                //    MessageBox.Show("El rubro #:"+txtIdRubro.Text.Trim() +" ya se encuentra anulado", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}

             
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error " + ex.Message.ToString(), "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public bool GuardarDatos()
        {
            bool resultado = false;
            try
            {
                if (validaciones())
                {
                    //txtIdRubro.Focus();
                    switch (Accion)
                    {
                        case Cl_Enumeradores.eTipo_action.grabar:
                            resultado =  Grabar();
                            break;

                        case Cl_Enumeradores.eTipo_action.actualizar:
                            //CargarCombos();
                            ucAca_Rubro1.Enabled(false);
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
                
                
             
                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message);
                return false;
            }
        }        
        #endregion

        #region "Eventos"

        private void FrmAca_Rubro_x_Aca_Periodo_Lectivo_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                gridControlValores_x_Periodo.DataSource = Lista_Periodo_x_Rubro;
                CargarCombos();
                

                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        ucGe_Menu.Enabled_bntAnular = false;
                        ucGe_Menu.Enabled_bntImprimir = false;
                        //chkActivo.Checked = true;
                        Cargar_Periodos(param.IdInstitucion, Convert.ToInt16(ucAca_Rubro1.get_item()));
                        break;

                    case Cl_Enumeradores.eTipo_action.actualizar:
                        ucGe_Menu.Enabled_bntAnular = false;
                        ucAca_Rubro1.Enabled(false);
                        //CargarDatos();
                        Cargar_Datos_a_Modificar(param.IdInstitucion, Convert.ToInt16(ucAca_Rubro1.get_item()));
                        break;

                    case Cl_Enumeradores.eTipo_action.Anular:
                        ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
                        ucGe_Menu.Enabled_btnGuardar = false;
                        CargarDatos();
                        break;

                    case Cl_Enumeradores.eTipo_action.consultar:
                        Cargar_Datos_a_Modificar(param.IdInstitucion, Convert.ToInt16(ucAca_Rubro1.get_item()));
                        ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
                        ucGe_Menu.Enabled_btnGuardar = false;
                        ucGe_Menu.Enabled_bntAnular = false;
                        txtValorRubro.Enabled = false;
                        chkSeleccionarTodos.Enabled = false;
                        //CargarDatos();
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
            GuardarDatos();
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
            Anular();
        }       

        private void FrmAca_Rubro_x_Aca_Periodo_Lectivo_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                event_FrmAca_Rubro_x_Aca_Periodo_Lectivo_Mant_FormClosing(sender, e);
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
        #endregion

        private void chkSeleccionarTodos_CheckedChanged(object sender, EventArgs e)
        {
            InfoRubroPeriodo = new Aca_Rubro_x_Aca_Periodo_Lectivo_Info();
            InfoRubroPeriodo = (Aca_Rubro_x_Aca_Periodo_Lectivo_Info)this.gridView_Valores_x_Periodo.GetFocusedRow();
           

            foreach (var item in Lista_Periodo_x_Rubro)
            {
                item.chequeo = chkSeleccionarTodos.Checked;
            }
            gridControlValores_x_Periodo.RefreshDataSource();
        }

        private void txtValorRubro_Leave(object sender, EventArgs e)
        {
            InfoRubroPeriodo = new Aca_Rubro_x_Aca_Periodo_Lectivo_Info();
            InfoRubroPeriodo = (Aca_Rubro_x_Aca_Periodo_Lectivo_Info)this.gridView_Valores_x_Periodo.GetFocusedRow();


            foreach (var item in Lista_Periodo_x_Rubro)
            {
                if(item.chequeo == true)
                {
                    item.Valor = Convert.ToDouble(txtValorRubro.Text);
                }
            }
            gridControlValores_x_Periodo.RefreshDataSource();
        }
    }
}
