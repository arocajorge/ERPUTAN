using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Winform.Contabilidad;

using Core.Erp.Reportes.Contabilidad;

using Cus.Erp.Reports.Naturisa.Contabilidad;
//Campos para obtener location de una celda en la grilla
using System.Reflection;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;


namespace Core.Erp.Winform.Controles
{
    public partial class UCCon_GridDiarioContable : UserControl
    {
        #region declaracion de variable
        string MensajeError = "";
        int rowHandle = 0;
        ct_punto_cargo_Info info_punto_cargo = new ct_punto_cargo_Info();
        ct_punto_cargo_Bus bus_punto_cargo = new ct_punto_cargo_Bus();

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        ct_Cbtecble_tipo_Bus busTipo = new ct_Cbtecble_tipo_Bus();
        List<ct_Cbtecble_tipo_Info> listaTipoCbteCble = new List<ct_Cbtecble_tipo_Info>();

        ct_Centro_costo_Bus BusCostos = new ct_Centro_costo_Bus();
        List<ct_Centro_costo_Info> ListCostos = new List<ct_Centro_costo_Info>();
        ct_centro_costo_sub_centro_costo_Bus busSubCen = new ct_centro_costo_sub_centro_costo_Bus();
        List<ct_centro_costo_sub_centro_costo_Info> Lista_SubCentro = new List<ct_centro_costo_sub_centro_costo_Info>();
        ct_centro_costo_sub_centro_costo_Info Info_subCentro_costo = new ct_centro_costo_sub_centro_costo_Info();
        List<ct_centro_costo_sub_centro_costo_Info> Lista_SubCentroCombo = new List<ct_centro_costo_sub_centro_costo_Info>();


        ct_Cbtecble_Bus BusCbteCble = new ct_Cbtecble_Bus();
        ct_Cbtecble_Info Info_CbteCble = new ct_Cbtecble_Info();
        ct_Cbtecble_det_Bus BusDet = new ct_Cbtecble_det_Bus();
        BindingList<ct_Cbtecble_det_Info> BindingList_cbtecble_det = new BindingList<ct_Cbtecble_det_Info>();
      

        ct_Plancta_Bus BusPlanCta = new ct_Plancta_Bus();
        List<ct_Plancta_Info> listaPlan = new List<ct_Plancta_Info>();
        ct_Plancta_Info Info_cuenta_validar = new ct_Plancta_Info();

        ct_punto_cargo_Bus BusPunto_Cargo = new ct_punto_cargo_Bus();
        List<ct_punto_cargo_Info> listaPuntoCargo = new List<ct_punto_cargo_Info>();
        ct_punto_cargo_Info Info_punto_cargo = new ct_punto_cargo_Info();

        ct_punto_cargo_grupo_Bus BusPunto_Cargo_grupo = new ct_punto_cargo_grupo_Bus();
        List<ct_punto_cargo_grupo_Info> listaPuntoCargo_grupo = new List<ct_punto_cargo_grupo_Info>();

        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        Cl_Enumeradores.eTipo_action _Accion;

        public Boolean validaValores = true;
        public Boolean validaCuenta = false;


        public string IdCtaCble_x_Banco { get; set; }

        frmCon_CbteCble_Mant ofrm;
        

       void UCCon_GridDiarioContable_event_btnImprimir_Click(object sender, EventArgs e) { }

        
        #endregion

        public delegate void delegate_btnImprimir_Click(object sender, EventArgs e);
        public event delegate_btnImprimir_Click event_btnImprimir_Click;
        
        #region propiedades visible

        public Boolean Visible_Botones { get { return this.toolBotones.Visible; } set { this.toolBotones.Visible = value; } }
        public Boolean Visible_columna_PuntoCargo { get { return this.ColIdPunto_Cargo.Visible; } set { this.ColIdPunto_Cargo.Visible = value; } }
        public Boolean Visible_columna_GrupoPuntoCargo { get { return this.colGrupo_punto_cargo.Visible; } set { this.colGrupo_punto_cargo.Visible = value; } }
        public Boolean Visible_Cabecera
        {
            get { return panelCabecera.Visible; }
            set
            {
                this.panelCabecera.Visible = value;
                panelCabecera.Visible = value;
                if (value == false)
                {
                    panelCabecera.Dock = DockStyle.None;
                    panelDetalle.Dock = DockStyle.Fill;
                }

                if (value == true)
                {
                    panelCabecera.Dock = DockStyle.Top;
                    panelDetalle.Dock = DockStyle.Fill;
                }


            }
        }
        #endregion 

        public UCCon_GridDiarioContable()
        {
            try
            {
                InitializeComponent();                
                event_btnImprimir_Click += UCCon_GridDiarioContable_event_btnImprimir_Click;                
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public ct_Cbtecble_Info Get_Info_CbteCble()
        {
            Boolean res = true;
            try
            {
                Info_CbteCble.IdEmpresa = param.IdEmpresa;
                Info_CbteCble.IdCbteCble = Convert.ToInt32(txtIdCbte.Text);
                Info_CbteCble.IdTipoCbte = Convert.ToInt32(cmbTipoComp.EditValue);
                Info_CbteCble.cb_Fecha = dtpFecha.Value;
                Info_CbteCble.cb_Valor = 0;
                Info_CbteCble.cb_Observacion = txtObservacion.Text;
                Info_CbteCble.Secuencia = 0;
                Info_CbteCble.Anio = dtpFecha.Value.Year;
                Info_CbteCble.Mes = dtpFecha.Value.Month;
                Info_CbteCble.IdUsuario = param.IdUsuario;
                Info_CbteCble.IdUsuarioUltModi = param.IdUsuario;
                Info_CbteCble.cb_FechaTransac = param.Fecha_Transac;
                Info_CbteCble.cb_FechaUltModi = param.Fecha_Transac;
                Info_CbteCble._cbteCble_det_lista_info = new List<ct_Cbtecble_det_Info>();
                

                Info_CbteCble._cbteCble_det_lista_info = new List<ct_Cbtecble_det_Info>(BindingList_cbtecble_det);
                res = Validar(Info_CbteCble, ref MensajeError);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                res = false;
            }
            return Info_CbteCble;
        }

        public Boolean Validar(ct_Cbtecble_Info Info, ref string msgerror)
        {
            Boolean res = true;
            try
            {
                if (Info.cb_Fecha == null )
                {
                    msgerror = "Fecha del comprobante inválida .";
                    res=false;
                }
                else if (Info.IdPeriodo == 0)
                {
                    msgerror = "Periodo del comprobante inválido.";
                    res = false;
                }
                else if ( Info.cb_Valor == 0)
                {
                    msgerror = "Valor Total del comprobante inválido.";
                    res = false;
                }
                else if (Info.IdTipoCbte == 0)
                {
                    msgerror = "Tipo del comprobante inválido.";
                    res = false;
                }

                                        
                int focus = gridViewDiario.FocusedRowHandle;
                gridViewDiario.FocusedRowHandle = focus + 1;
                
                foreach (var item in BindingList_cbtecble_det)
                {
                    if (item.IdCtaCble == null || item.IdCtaCble == "")
                    {
                        //MessageBox.Show("No ha ingresado Cuenta Contable ");
                        res = false;
                    }
                }

                return res;

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return res;
            }
           

        }

        public Boolean Grabar(Cl_Enumeradores.eTipo_action Accion, ct_Cbtecble_Info Info, ref string cod_CbteCble, ref decimal idCbteCble, ref string msjGrabado)
        {
            Boolean res = true;
            try
            {
                _Accion = Accion;
                Get_Info_CbteCble();

                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        if (BusCbteCble.GrabarDB(Info_CbteCble, ref idCbteCble, ref msjGrabado))
                        {
                            Info_CbteCble.IdCbteCble = idCbteCble;
                            Info_CbteCble.CodCbteCble = cod_CbteCble;
                            msjGrabado = msjGrabado + " IdCbteCble: " + idCbteCble;
                            setAccion(Cl_Enumeradores.eTipo_action.consultar);
                            return true;
                        }
                        else
                        {

                            return false;
                        }
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        if (BusCbteCble.ModificarDB(Info_CbteCble, ref msjGrabado))
                        {
                            msjGrabado = "Actualizado correctamente el Cbte. Cble. : " + idCbteCble;
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    default:
                        break;
                }

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());

                res = false;
            }
            return res;
        }

        public Boolean GrabarConta(int _IdTipoCbte, ref decimal IdCbteCble, int IdPeriodo, DateTime dt_fechaCbte, double ValorCbt,
        string ObservacionCbt, string Estado, string Mayorizado, String Codigo, ref string msg_error)
        {
            try
            {
                decimal idCbteCble = 0;
                //se realizo asi para no cambiar el formato del metodo
                Info_CbteCble.IdTipoCbte = _IdTipoCbte;
                Info_CbteCble.IdCbteCble = IdCbteCble;
                Info_CbteCble.IdPeriodo = IdPeriodo;
                Info_CbteCble.cb_Fecha = dt_fechaCbte;
                Info_CbteCble.cb_FechaTransac = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                var a = BindingList_cbtecble_det.ToList();
                if (a != null)
                    Info_CbteCble.cb_Valor = a.FindAll(q => q.dc_Valor > 0).Sum(q => q.dc_Valor);
                Info_CbteCble.cb_Observacion = ObservacionCbt;
                Info_CbteCble.Estado = Estado;
                Info_CbteCble.Mayorizado = Mayorizado;
                Info_CbteCble.CodCbteCble = Codigo;

                Info_CbteCble = Get_Info_CbteCble();


                if (BusCbteCble.GrabarDB(Info_CbteCble, ref idCbteCble, ref msg_error))
                {
                    IdCbteCble = idCbteCble;
                    MessageBox.Show(msg_error);
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());

                return false;
            }
        }

        public Boolean Reverso( int IdTipoCbteRev, ref decimal IdCbteCbleRev, ref string msjGrabado, string MotivoAnulacion)
        {
            string msg = ""; decimal idCbteCble = 0;
            Boolean res = true;
            try
            {
                Get_Info_CbteCble();
                
                    if (BusCbteCble.ReversoCbteCble(param.IdEmpresa, Info_CbteCble.IdCbteCble, Info_CbteCble.IdTipoCbte, IdTipoCbteRev,
                        ref IdCbteCbleRev, ref msg, param.IdUsuario, MotivoAnulacion))
                    {
                        msjGrabado = "La Reversión se realizó correctamente con el Cbte. Cble. : " + IdCbteCbleRev;
                        return true;
                    }
                    else
                    {
                        msjGrabado = "Error en la Reversión del Cbte. Cble. : " + idCbteCble;
                        return false;
                    }
                
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                res = false;
            }
            return res;
        }
        
        public void LimpiarGrid()
        {
            try
            {
                BindingList_cbtecble_det = new BindingList<ct_Cbtecble_det_Info>();
                gridControlDiario.DataSource = BindingList_cbtecble_det;
                gridControlDiario.Refresh();
                Inicializar_diario();
                
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
        
        public void setAccion(Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {
                _Accion = Accion;
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        HabilitarCampos(true);
                        HabilitarGrid(true);
                        LimpiarGrid();
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        HabilitarCampos(true);
                        HabilitarGrid(true);
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        HabilitarCampos(false);
                        HabilitarGrid(false);
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        private void loadCombos()
        {
            try
            {
                
                ///
                listaPlan = BusPlanCta.Get_List_Plancta_x_ctas_Movimiento(param.IdEmpresa, ref MensajeError);
                cmb_planCta.DataSource = listaPlan;

                ///Plan de Centro de Costos
                ///
                ListCostos = BusCostos.Get_list_Centro_Costo_cuentas_de_movimiento(param.IdEmpresa, ref MensajeError);
                cmbCentroCosto.DataSource = ListCostos;
                /////////
                busTipo.Get_list_Cbtecble_tipo(param.IdEmpresa,Cl_Enumeradores.eTipoFiltro.Normal, ref MensajeError);
                cmbTipoComp.Properties.DataSource = listaTipoCbteCble;
                //////
                switch (param.IdCliente_Ven_x_Default)
                {
                    case Cl_Enumeradores.eCliente_Vzen.FJ:
                        listaPuntoCargo=BusPunto_Cargo.Get_List_punto_Cargo_con_subcentro(param.IdEmpresa);
                        cmb_punto_cargo.DataSource = listaPuntoCargo;
                        break;
                    default:
                        listaPuntoCargo=BusPunto_Cargo.Get_List_PuntoCargo(param.IdEmpresa);
                        cmb_punto_cargo.DataSource = listaPuntoCargo;
                        break;
                }
                


                cmb_punto_cargo_val_fj.DataSource = listaPuntoCargo;
                cmb_punto_cargo_val_fj.ValueMember = "IdPunto_cargo";
                cmb_punto_cargo_val_fj.DisplayMember = "nom_punto_cargo";

                Lista_SubCentroCombo = busSubCen.Get_list_centro_costo_sub_centro_costo(param.IdEmpresa);
                col_sub_centro_costo.DataSource = Lista_SubCentroCombo;

                listaPuntoCargo_grupo = BusPunto_Cargo_grupo.Get_List_punto_cargo_grupo(param.IdEmpresa, ref MensajeError);
                cmb_Grupo.DataSource = listaPuntoCargo_grupo;
                cmb_Grupo.ValueMember = "IdPunto_cargo_grupo";
                cmb_Grupo.DisplayMember = "nom_punto_cargo_grupo";
                
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public  void carga_Combo_x_Empresa(int IdEmpresa)
        {
            try
            {
                ///Cargamos en combos
                ///Plan de cuentas de movimientos
                ///
                listaPlan = BusPlanCta.Get_List_Plancta_x_ctas_Movimiento(IdEmpresa, ref MensajeError);
                cmb_planCta.DataSource = listaPlan;

                ///Plan de Centro de Costos
                ///
                ListCostos = BusCostos.Get_list_Centro_Costo_cuentas_de_movimiento(IdEmpresa, ref MensajeError);
                cmbCentroCosto.DataSource = ListCostos;

                ct_Cbtecble_tipo_Bus busTipo = new ct_Cbtecble_tipo_Bus();
                List<ct_Cbtecble_tipo_Info> listaTipoCbteCble =
                busTipo.Get_list_Cbtecble_tipo(param.IdEmpresa,Cl_Enumeradores.eTipoFiltro.Normal, ref MensajeError);

                cmbTipoComp.Properties.DataSource = listaTipoCbteCble;

                listaPuntoCargo_grupo = BusPunto_Cargo_grupo.Get_List_punto_cargo_grupo(param.IdEmpresa, ref MensajeError);
                cmb_Grupo.DataSource = listaPuntoCargo_grupo;
                cmb_Grupo.ValueMember = "IdPunto_cargo_grupo";
                cmb_Grupo.DisplayMember = "nom_punto_cargo_grupo";
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public double Get_ValorCbteCble()
        {
            double res = 0;
            try
            {
                res = BindingList_cbtecble_det.ToList().FindAll(var => var.dc_Valor > 0).Sum(var => var.dc_Valor);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                res = 0;
            }
            return res;
        }

        public double Get_Diferencia()
        {
            double res = 0;
            try
            {
                double SDebe= 0;
                double SHaber = 0;
               // res = BindingList_cbtecble_det.Sum(var => var.dc_Valor);

                foreach (var item in BindingList_cbtecble_det)
                {
                    if (item.dc_Valor > 0)
                    {
                        SDebe =SDebe+ item.dc_Valor;
                    }
                    else
                    {
                        SHaber =SHaber+ item.dc_Valor;
                    }
                }
                SHaber = SHaber * -1;
                res = SDebe - SHaber;




                lblDiferencia.Text = "(" + Math.Round(res, 2) + ")";
                return res;

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                res = 0;
            }
            return res;
        }

        public void setInfo(int idempresa, int IdTipoCbte, decimal IdCbteCble)
        {
            try
            {
                if (idempresa != 0)
                {
                    string MensajeError = "";

                    Info_CbteCble = new ct_Cbtecble_Info();
                    Info_CbteCble = BusCbteCble.Get_Info_CbteCble(idempresa, IdTipoCbte, IdCbteCble, ref MensajeError);
                    txtIdCbte.Text = Info_CbteCble.IdCbteCble.ToString();
                    txtCod.Text = Info_CbteCble.CodCbteCble;
                    dtpFecha.Value = Info_CbteCble.cb_Fecha;
                    cmbTipoComp.EditValue = Info_CbteCble.IdTipoCbte;
                    txtObservacion.Text = Info_CbteCble.cb_Observacion;
                    //opteniendo detalle
                    Info_CbteCble._cbteCble_det_lista_info = BusDet.Get_list_Cbtecble_det(idempresa, IdTipoCbte, IdCbteCble, ref MensajeError);
                    BindingList_cbtecble_det = new BindingList<ct_Cbtecble_det_Info>(Info_CbteCble._cbteCble_det_lista_info);

                    foreach (ct_Cbtecble_det_Info item in BindingList_cbtecble_det)
                    {
                        if (item.dc_Valor > 0)
                            item.dc_Valor_D = Math.Round(item.dc_Valor, 2);
                        else if (item.dc_Valor < 0)
                            item.dc_Valor_H = Math.Round(item.dc_Valor, 2) * -1;


                        //BindListaSubCentro = new BindingList<ct_centro_costo_sub_centro_costo_Info>(busSubCen.Get_list_centro_costo_sub_centro_costo(idempresa, Convert.ToString(item.IdCentroCosto)));

                        Lista_SubCentro = busSubCen.Get_list_centro_costo_sub_centro_costo(idempresa, Convert.ToString(item.IdCentroCosto));

                        if (Lista_SubCentro.Count != 0)
                        {
                            ct_centro_costo_sub_centro_costo_Info idSubcentro = new ct_centro_costo_sub_centro_costo_Info();
                            try
                            {

                                idSubcentro = Lista_SubCentro.FirstOrDefault(q => (q.IdCentroCosto == item.IdCentroCosto &&
                                   q.IdCentroCosto_sub_centro_costo == item.IdCentroCosto_sub_centro_costo));
                                item.NomSubCentroCosto = "[" + idSubcentro.IdCentroCosto_sub_centro_costo.Trim() + "] - " + idSubcentro.Centro_costo.Trim();

                            }
                            catch (Exception ex)
                            {
                                // no guardar en el log esto no es error sino controlamos el null
                                //Log_Error_bus.Log_Error(ex.ToString());
                                idSubcentro = new ct_centro_costo_sub_centro_costo_Info();
                            }
                        }
                    }
                    gridControlDiario.DataSource = BindingList_cbtecble_det;
                }
               
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void setDetalle(List<ct_Cbtecble_det_Info> ListDet)
        {
            try
            {
                foreach (var item in ListDet)
                {
                    if (item.dc_Valor > 0)
                    {
                        item.dc_Valor_D = Math.Round(item.dc_Valor, 2);
                        item.dc_Valor_H = 0;
                    }
                    if (item.dc_Valor < 0)
                    {
                        item.dc_Valor_H = Math.Round(item.dc_Valor, 2) * -1;
                        item.dc_Valor_D = 0;
                    }
                }

                Info_CbteCble._cbteCble_det_lista_info = ListDet;
                BindingList_cbtecble_det = new BindingList<ct_Cbtecble_det_Info>(Info_CbteCble._cbteCble_det_lista_info);
                gridControlDiario.DataSource = BindingList_cbtecble_det;
                Get_Diferencia();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
        
        public List<ct_Cbtecble_det_Info> Get_List_Cbtecble_det()
        {
            try
            {
                List<ct_Cbtecble_det_Info> lista = new List<ct_Cbtecble_det_Info>();
                
                int i = 0;
                
                foreach (var item in BindingList_cbtecble_det)
                {
                    item.IdEmpresa = param.IdEmpresa;
                    item.IdTipoCbte = Info_CbteCble.IdTipoCbte;
                    item.IdCbteCble = Info_CbteCble.IdCbteCble;
                    item.secuencia = ++i;

                    if (item.dc_Valor_D > 0)
                    {
                        item.dc_Valor = item.dc_Valor_D;

                    }
                    else
                    {
                        item.dc_Valor = item.dc_Valor_H * -1;

                    }

                    lista.Add(item);

                }
                return lista;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new List<ct_Cbtecble_det_Info>();
            }

        }

        public BindingList<ct_Cbtecble_det_Info> Get_BindingList_Cbtecble_det()
        {
            try
            {
                
                return BindingList_cbtecble_det;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new BindingList<ct_Cbtecble_det_Info>();
            }

        }

        public Boolean valida_ct_Cbtecble_det()
         {

             Boolean res = false;
             int conta = 0;
             try
             {
             
                 int focus = gridViewDiario.FocusedRowHandle;
                 gridViewDiario.FocusedRowHandle = focus + 1;

                 foreach (var item in BindingList_cbtecble_det)
                 {
                     if (item.IdCtaCble == null || item.IdCtaCble == "")
                     {
                         conta = conta + 1;                    
                     }
                 
                 }

                 if (conta >= 1)
                 {
                     MessageBox.Show("Por favor, verifique todas las cuentas contables");
                     res = false;
                 }
                 else
                 {
                     res = true;
                 }

                 return res;
             }
             catch (Exception ex)
             {
                 string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                 MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                 return res;
             }

         }

        public void HabilitarGrid(Boolean estado)
        {
            try
            {
                gridViewDiario.OptionsBehavior.ReadOnly = (estado!= true)?true:false;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public Boolean ValidarAsientosContables()
        {
            Boolean res = false;
            try
            {
                var detalle = Info_CbteCble._cbteCble_det_lista_info;

                foreach (var item in detalle)
                {
                    if(item.dc_Valor==0 && item.dc_Valor_D==0 && item.dc_Valor_H==0)
                    {                      
                        MessageBox.Show("No se puede grabar Comprobante,  verifique que los valores del debe y haber, " +
                                               " que se están enviando no se encuentren en 0..\nPor favor verifique los valores del debe y haber...",
                                               "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    
                    }
                    
                }



                if (detalle.FindAll(q => q.dc_Valor == 0 ).Count > 0)
                {
                    MessageBox.Show("No se puede grabar Comprobante,  verifique los saldos del debe y haber, " +
                        " que se están enviando con la Cuenta contable en blanco..\nPor favor verifique las Cuentas Contable del Comprobante...",
                        "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (detalle.Count < 2)
                {
                    MessageBox.Show("No se puede grabar Comprobante,  verifique que haya los registros necesarios en el Diario Contable...",
                           "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                double verifica = 0;

                int focus = gridViewDiario.FocusedRowHandle;
                gridViewDiario.FocusedRowHandle = focus + 1;
                
                foreach (var item in BindingList_cbtecble_det)
                {
                    verifica = verifica + item.dc_Valor_D - item.dc_Valor_H;
                    if (String.IsNullOrEmpty(item.IdCtaCble))
                    {
                        MessageBox.Show("Por favor, verifique todas las cuentas contables"); 
                        return false;
                    }
                }
                if (Math.Round(verifica, 6) != 0)
                { 
                    MessageBox.Show("Por favor, verifique el asiento esta descuadrado!"); 
                    return false; 
                }
                
                res = true;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
            return res;
        }
        
        public void ColDebeHaberLectura(Boolean estado)
        {
            try
            {
                colDebe.OptionsColumn.ReadOnly = estado;
                colHaber.OptionsColumn.ReadOnly = estado;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
        
        public void HabilitarCampos(Boolean var)
        {
            try
            {
                Boolean ReadOnly = (var == true) ? false : true;
                txtCod.ReadOnly = ReadOnly;
                txtObservacion.ReadOnly = ReadOnly;
                dtpFecha.Enabled = var;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void gridViewDiario_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                ct_Cbtecble_det_Info row = new ct_Cbtecble_det_Info();
                row = (ct_Cbtecble_det_Info)gridViewDiario.GetFocusedRow();
                
                Lista_SubCentro = new List<ct_centro_costo_sub_centro_costo_Info>();
                rowHandle = e.FocusedRowHandle;
                if (row != null)
                {
                    if (!String.IsNullOrEmpty(row.IdCentroCosto))
                    {
                
                        Lista_SubCentro = busSubCen.Get_list_centro_costo_sub_centro_costo(param.IdEmpresa, Convert.ToString(row.IdCentroCosto));
                    }
                }
                cmbSubCentro.Items.Clear();
                foreach (ct_centro_costo_sub_centro_costo_Info item in Lista_SubCentro)
                {
                    item.NomSubCentroCosto = "[" + item.IdCentroCosto_sub_centro_costo.Trim() + "] - " + item.Centro_costo.Trim();
                }
                foreach (var item in Lista_SubCentro)
                {
                    cmbSubCentro.Items.Add(item.NomSubCentroCosto);
                }

               

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
        
        private void gridViewDiario_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                
                ct_Cbtecble_det_Info row = new ct_Cbtecble_det_Info();
                row = (ct_Cbtecble_det_Info)gridViewDiario.GetFocusedRow();
                if (row != null)
                {
                    if (e.Column == colIdCtaCble)
                    {
                        Info_cuenta_validar = new ct_Plancta_Info();
                        Info_cuenta_validar = listaPlan.FirstOrDefault(q => q.IdCtaCble == row.IdCtaCble);
                        if (Info_cuenta_validar != null)
                        {
                            if (Info_cuenta_validar.pc_EsMovimiento == "N")
                            {
                                MessageBox.Show("La cuenta seleccionada no es de movimiento. \nSe va a proceder a eliminar la cuenta del diario contable.", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                gridViewDiario.SetFocusedRowCellValue(colIdCtaCble, null);
                            }
                        }
                    }

                    if (e.Column == colDebe)
                    {
                        if (Convert.ToDouble(e.Value) != 0) row.dc_Valor = Math.Round(Convert.ToDouble(e.Value), 2, MidpointRounding.AwayFromZero);
                        if (row.dc_Valor_D != 0) gridViewDiario.SetFocusedRowCellValue(colHaber, 0);
                        
                    }

                    else if (e.Column == colHaber)
                    {
                        if (Convert.ToDouble(e.Value)!=0) row.dc_Valor = Math.Round(Convert.ToDouble(e.Value), 2, MidpointRounding.AwayFromZero) * -1;
                        if(row.dc_Valor_H!=0) gridViewDiario.SetFocusedRowCellValue(colDebe, 0);
                    }
                                       
                    if (e.Column == colGrupo_punto_cargo)
                    {
                        gridViewDiario.SetFocusedRowCellValue(ColIdPunto_Cargo, null);
                    }
                    if (row.dc_Valor_H == 0 && row.dc_Valor_D == 0) row.dc_Valor = 0;


                    if (e.Column == colIdCtaCble && string.IsNullOrWhiteSpace(IdCtaCble_x_Banco)==false)
                    {
                        if (IdCtaCble_x_Banco == row.IdCtaCble)
                        {
                            gridViewDiario.SetFocusedRowCellValue(colPara_conciliar, true);
                        }
                    }





                    if (e.Column == col_IdPunto_cargo_val_FJ)
                    {
                        switch (param.IdCliente_Ven_x_Default)
                        {
                            case Cl_Enumeradores.eCliente_Vzen.FJ:
                                if (row.IdPunto_cargo != 0 && row.IdPunto_cargo != null)
                                {
                                    info_punto_cargo = bus_punto_cargo.Get_info_punto_Cargo_con_subcentro(param.IdEmpresa, Convert.ToInt32(row.IdPunto_cargo));
                                    row.IdPunto_cargo_grupo = info_punto_cargo.IdPunto_cargo_grupo;
                                    row.IdCentroCosto = info_punto_cargo.IdCentroCosto_Scc;
                                    row.IdCentroCosto_sub_centro_costo = info_punto_cargo.IdCentroCosto_sub_centro_costo_Scc;
                                    row.IdRegistro = info_punto_cargo.IdCentroCosto_Scc + '-' + info_punto_cargo.IdCentroCosto_sub_centro_costo_Scc;
                                }
                                else
                                {
                                    row.IdPunto_cargo_grupo = null;
                                    row.IdCentroCosto = null;
                                    row.IdCentroCosto_sub_centro_costo = null;
                                }
                                break;
                            default:
                                break;
                        }
                    }


                }

                Get_Diferencia();
                gridControlDiario.RefreshDataSource();
              
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public Boolean EliminarRegistros = true;

        private void gridViewDiario_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                /*
                if (EliminarRegistros == true)
                {
                    if (e.KeyCode.ToString() == "Delete")
                    {

                        gridViewDiario.DeleteSelectedRows();

                    }
                }*/
                if (e.KeyCode == Keys.V && e.Control == true)
                {
                    Pegar_Data();
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        string ClipboardData
        {
            get
            {
                IDataObject iData = Clipboard.GetDataObject();
                if (iData == null) return "";

                if (iData.GetDataPresent(DataFormats.Text))
                    return (string)iData.GetData(DataFormats.Text);
                return "";
            }
            set { Clipboard.SetDataObject(value); }
        }

        private void Pegar_Data()
        {
            try
            {
                string[] data = ClipboardData.Split('\n');
                if (data.Length < 1) return;
                foreach (string row in data)
                {
                    switch (param.IdCliente_Ven_x_Default)
                    {
                       case Cl_Enumeradores.eCliente_Vzen.FJ:
                            if (!Agregar_fila_copiada_FJ(row))
                                break;
                            break;
                         default:
                            if (!Agregar_fila_copiada(row))
                                break;
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

       private void validarCuentaCont()
        {
            try
            {
                int i = 0;
                int cont = 0; int contD_S = 0;
                foreach (var item in BindingList_cbtecble_det)
                {
                    item.secuencia = ++i;
                    if (item.IdCtaCble == null)
                    {
                        cont = ++cont;
                        if (cont == 1)
                        {                           
                            BindingList_cbtecble_det.Remove(item); break;
                        }
                    }
                    if (item.dc_Valor_D == 0 && item.dc_Valor_H == 0)
                    {
                        contD_S = ++contD_S;
                        if (contD_S == 1 && validaValores == true)
                        { MessageBox.Show("Ingrese los valores."); BindingList_cbtecble_det.Remove(item); break; }
                    }
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void gridViewDiario_RowCountChanged(object sender, EventArgs e)
        {
            try
            {
                if (validaCuenta == true)
                {
                    validarCuentaCont();
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        private Boolean Agregar_fila_copiada(string data)        
        {
            try
            {
                if (string.IsNullOrWhiteSpace(data)) return false;
                string[] rowData = data.Split(new char[] { '\r', '\x09' });

                //posicion de la ata pegada
               // IdCbtaCble | pc_clave_corta | pc_cuenta | observacion | Debe | Haber

                ct_Cbtecble_det_Info newRow = new ct_Cbtecble_det_Info();
                if (rowData.Count() >= 3) //return false;          
                {
                    string IdCtaCble = Convert.ToString(rowData[0]);
                    string pc_clave_corta = Convert.ToString(rowData[1]);

                    if (string.IsNullOrEmpty(pc_clave_corta)  && string.IsNullOrEmpty(IdCtaCble))
                    {
                        MessageBox.Show("Debe ingresar la clave o el código que hace referencia a la cuenta que desea ingresar", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }
                    ct_Plancta_Info info_cuenta = new ct_Plancta_Info();
                    if (!string.IsNullOrEmpty(pc_clave_corta))
                        info_cuenta = listaPlan.FirstOrDefault(q => q.IdEmpresa == param.IdEmpresa && q.pc_clave_corta == pc_clave_corta);
                    if (!string.IsNullOrEmpty(IdCtaCble))
                        info_cuenta = listaPlan.FirstOrDefault(q => q.IdEmpresa == param.IdEmpresa && q.IdCtaCble == IdCtaCble);

                    if (info_cuenta == null)
                    {
                        MessageBox.Show("No existe una cuenta " + (pc_clave_corta == "" ? "con el código: [" + IdCtaCble + "]" : "con la clave: [" + pc_clave_corta + "]"), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }

                    if (info_cuenta.pc_EsMovimiento == "N")
                    {
                        MessageBox.Show("La cuenta [" + info_cuenta.IdCtaCble + "] " + info_cuenta.pc_Cuenta + " no es de movimiento, esto afectará luego la presentación de los balances.", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }

                    string observacion = Convert.ToString(rowData[3]);
                    double Debe = Convert.ToDouble(rowData[4] == "" ? "0" : rowData[4]);
                    double Haber = Convert.ToDouble(rowData[5] == "" ? "0" : rowData[5]);

                    newRow.IdCtaCble = info_cuenta.IdCtaCble;
                    newRow.dc_Valor_D = Debe;
                    newRow.dc_Valor_H = Haber;
                    newRow.dc_Observacion = observacion;
                    if (info_cuenta != null)
                    {
                        if (Debe > 0)
                            newRow.dc_Valor = Debe;
                        else
                            newRow.dc_Valor = Haber * -1;
                        BindingList_cbtecble_det.Add(newRow);
                        
                    }
                    return true;
                }
                else
                {
                    MessageBox.Show("No hay las columnas necesarias para insertar al registros");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + "El formato debe ser el siguiente\n" + "|codigo Producto|nombre producto|unidad med.|cantidad|costo|observacion det|centros cos|", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }
        }

        public void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                int IdEmpresa = 0;
                int IdTipoCbte = 0;
                decimal IdCbteCble = 0;

                switch (param.IdCliente_Ven_x_Default)
                {
                    case Cl_Enumeradores.eCliente_Vzen.NATURISA:
                        
                        XCONTA_NATU_Rpt002_Rpt reporte_personalizado = new XCONTA_NATU_Rpt002_Rpt();
                        
                        IdEmpresa = param.IdEmpresa;
                        IdTipoCbte = Convert.ToInt32(Info_CbteCble.IdTipoCbte);
                        IdCbteCble = Convert.ToDecimal(Info_CbteCble.IdCbteCble);

                        reporte_personalizado.PIdEmpresa.Value = param.IdEmpresa;
                        reporte_personalizado.PIdEmpresa.Visible = false;
                        reporte_personalizado.PIdTipoCbte.Value = IdTipoCbte;
                        reporte_personalizado.PIdTipoCbte.Visible = false;
                        reporte_personalizado.PIdCbteCble.Value = IdCbteCble;
                        reporte_personalizado.PIdCbteCble.Visible = false;
                        reporte_personalizado.RequestParameters = false;
                        reporte_personalizado.ShowPreviewDialog();
                        break;

                    default:

                        XCONTA_Rpt003_rpt reporte = new XCONTA_Rpt003_rpt();

                        IdEmpresa = param.IdEmpresa;
                        IdTipoCbte = Convert.ToInt32(Info_CbteCble.IdTipoCbte);
                        IdCbteCble = Convert.ToDecimal(Info_CbteCble.IdCbteCble);

                        reporte.set_parametros(IdEmpresa, IdTipoCbte, IdCbteCble);
                        reporte.RequestParameters = false;
                        reporte.ShowPreviewDialog();
                        break;
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (_Accion != Cl_Enumeradores.eTipo_action.grabar)
                {
                    ofrm = new frmCon_CbteCble_Mant();
                    ofrm.event_frmCon_CbteCble_Mant_FormClosing += ofrm_event_frmCon_CbteCble_Mant_FormClosing;
                    ofrm.setAccion(Cl_Enumeradores.eTipo_action.actualizar);
                    ofrm.set_Info(Info_CbteCble);
                    ofrm.Show();
                }

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void ofrm_event_frmCon_CbteCble_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Info_CbteCble = ofrm.Get_Info_FormClosing();
                setDetalle(Info_CbteCble._cbteCble_det_lista_info);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void toolBotones_ItemClicked(object sender, ToolStripItemClickedEventArgs e) { }

        private void gridControlDiario_Click(object sender, EventArgs e)
        {

        }

        private void gridControlDiario_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {             
                if (e.KeyValue.ToString() == "46")
                {                   
                    if (MessageBox.Show("Está seguro que desea eliminar el registro", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        gridViewDiario.DeleteRow(gridViewDiario.FocusedRowHandle);
                        //gridControlDiario.RefreshDataSource();                      
                    }
                }

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void Inicializar_diario()
        {
            if (BindingList_cbtecble_det == null || BindingList_cbtecble_det.Count == 0)
            {
                BindingList_cbtecble_det = new BindingList<ct_Cbtecble_det_Info>();
                for (int i = 0; i < 2; i++)
                {
                    ct_Cbtecble_det_Info item = new ct_Cbtecble_det_Info();
                    BindingList_cbtecble_det.Add(item);
                }
                gridControlDiario.DataSource = BindingList_cbtecble_det;
                gridControlDiario.Refresh();
            }
        }

        private void UCCon_GridDiarioContable_Load(object sender, EventArgs e)
        {
            try
            {
                Inicializar_diario();
                gridControlDiario.DataSource = BindingList_cbtecble_det;
                loadCombos();

                switch (param.IdCliente_Ven_x_Default)
                {
                    case Cl_Enumeradores.eCliente_Vzen.NATURISA:
                        ColIdPunto_Cargo.Visible = true;
                        col_IdPunto_cargo_val_FJ.Visible = false;
                        break;
                    case Cl_Enumeradores.eCliente_Vzen.FJ:
                        ColIdPunto_Cargo.Visible = false;

                        col_IdPunto_cargo_val_FJ.Visible = true;
                        break;
                    case Cl_Enumeradores.eCliente_Vzen.GRAFINPRENT:
                        ColIdPunto_Cargo.Visible = true;

                        col_IdPunto_cargo_val_FJ.Visible = false;
                        break;
                    default:
                        ColIdPunto_Cargo.Visible = true;

                        col_IdPunto_cargo_val_FJ.Visible = false;
                        break;
                }

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
        
        private void gridViewDiario_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                ct_Cbtecble_det_Info row = (ct_Cbtecble_det_Info)gridViewDiario.GetRow(e.RowHandle);
                if (e.Column == ColIdPunto_Cargo)
                {
                    if (row.IdPunto_cargo_grupo != null)
                    {
                        frmCon_Punto_Cargo_Cons frm_cons = new frmCon_Punto_Cargo_Cons();
                        frm_cons.Cargar_grid_x_grupo((int)row.IdPunto_cargo_grupo);
                        frm_cons.ShowDialog();
                        Info_punto_cargo = frm_cons.Get_Info();

                        if (Info_punto_cargo!=null)
                        {
                            gridViewDiario.SetRowCellValue(e.RowHandle, ColIdPunto_Cargo, Info_punto_cargo.IdPunto_cargo);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
       
        private void cmb_punto_cargo_Click(object sender, EventArgs e)
        {
            try
            {
                ct_Cbtecble_det_Info row = (ct_Cbtecble_det_Info)gridViewDiario.GetFocusedRow();
                if (row!=null)
                {
                    if (row.IdPunto_cargo_grupo!=null)
                    {
                        loadCombos();

                        frmCon_Punto_Cargo_Cons frm_cons = new frmCon_Punto_Cargo_Cons();

                        GridViewInfo info = gridViewDiario.GetViewInfo() as GridViewInfo;
                        GridCellInfo info_cell = info.GetGridCellInfo(rowHandle,ColIdPunto_Cargo);

                        frm_cons.Cargar_grid_x_grupo((int)row.IdPunto_cargo_grupo);

                        //frm_cons.Location = new Point(this.Right, gridControlDiario.Top);                        
                        
                        frm_cons.ShowDialog();
                        Info_punto_cargo = frm_cons.Get_Info();
                        if (Info_punto_cargo != null)
                        {
                            gridViewDiario.SetFocusedRowCellValue(ColIdPunto_Cargo, Info_punto_cargo.IdPunto_cargo);
                        }else
                            gridViewDiario.SetFocusedRowCellValue(ColIdPunto_Cargo, null);
                    }
                }
                        
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        GridViewInfo GetGridViewInfo(GridView view)
        {

            FieldInfo fi;

            fi = typeof(GridView).GetField("fViewInfo", BindingFlags.NonPublic | BindingFlags.Instance);

            return fi.GetValue(view) as GridViewInfo;

        }

        private void col_sub_centro_costo_Click(object sender, EventArgs e)
        {
            try
            {
                ct_centro_costo_sub_centro_costo_Info Info_subCentro = new ct_centro_costo_sub_centro_costo_Info();
                ct_Cbtecble_det_Info row = (ct_Cbtecble_det_Info)gridViewDiario.GetRow(rowHandle);
                if (row!=null)
                {
                    if (row.IdCentroCosto != null)
                    {
                        List<ct_centro_costo_sub_centro_costo_Info> Lista_subcentro_consulta = new List<ct_centro_costo_sub_centro_costo_Info>();
                        Lista_subcentro_consulta = Lista_SubCentroCombo.Where(q => q.IdEmpresa == param.IdEmpresa && q.IdCentroCosto == row.IdCentroCosto).ToList();
                        if (Lista_subcentro_consulta != null && Lista_subcentro_consulta.Count != 0)
                        {
                            frmCon_ct_centro_costo_sub_centro_costo_Cons frm_combo = new frmCon_ct_centro_costo_sub_centro_costo_Cons();
                            frm_combo.Set_config_combo(Lista_subcentro_consulta);
                            frm_combo.ShowDialog();
                            Info_subCentro = frm_combo.Get_info_centro_sub_centro_costo();
                            gridViewDiario.SetRowCellValue(rowHandle, ColIdRegistro_subcentro, Info_subCentro == null ? null : Info_subCentro.IdRegistro);
                            gridViewDiario.SetRowCellValue(rowHandle, col_IdCentroCosto_sub_centro_costo, Info_subCentro == null ? null : Info_subCentro.IdCentroCosto_sub_centro_costo);                        
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void gridViewDiario_RowCountChanged_1(object sender, EventArgs e)
        {
            try
            {
                Get_Diferencia();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void gridViewDiario_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private Boolean Agregar_fila_copiada_FJ(string data)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(data)) return false;
                string[] rowData = data.Split(new char[] { '\r', '\x09' });

                //posicion de la ata pegada
                // IdCbtaCble | pc_clave_corta | pc_cuenta | observacion | Debe | Haber

                ct_Cbtecble_det_Info newRow = new ct_Cbtecble_det_Info();
                if (rowData.Count() >= 3) //return false;          
                {
                    string IdCtaCble = Convert.ToString(rowData[0]);
                    string pc_clave_corta = Convert.ToString(rowData[1]);

                    if (string.IsNullOrEmpty(pc_clave_corta) && string.IsNullOrEmpty(IdCtaCble))
                    {
                        MessageBox.Show("Debe ingresar la clave o el código que hace referencia a la cuenta que desea ingresar", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }
                    ct_Plancta_Info info_cuenta = new ct_Plancta_Info();
                    if (!string.IsNullOrEmpty(pc_clave_corta))
                        info_cuenta = listaPlan.FirstOrDefault(q => q.IdEmpresa == param.IdEmpresa && q.pc_clave_corta == pc_clave_corta);
                    if (!string.IsNullOrEmpty(IdCtaCble))
                        info_cuenta = listaPlan.FirstOrDefault(q => q.IdEmpresa == param.IdEmpresa && q.IdCtaCble == IdCtaCble);

                    if (info_cuenta == null)
                    {
                        MessageBox.Show("No existe una cuenta " + (pc_clave_corta == "" ? "con el código: [" + IdCtaCble + "]" : "con la clave: [" + pc_clave_corta + "]"), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }

                    if (info_cuenta.pc_EsMovimiento == "N")
                    {
                        MessageBox.Show("La cuenta [" + info_cuenta.IdCtaCble + "] " + info_cuenta.pc_Cuenta + " no es de movimiento, esto afectará luego la presentación de los balances.", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }

                    string observacion = Convert.ToString(rowData[3]);
                    double Debe = Convert.ToDouble(rowData[4] == "" ? "0" : rowData[4]);
                    double Haber = Convert.ToDouble(rowData[5] == "" ? "0" : rowData[5]);
                    string CodigoPuntoCargo= Convert.ToString(rowData[6] == "" ? "0" : rowData[6]);
                    info_punto_cargo = bus_punto_cargo.Get_info_punto_Cargo_con_subcentro(param.IdEmpresa, CodigoPuntoCargo);

                    newRow.IdCtaCble = info_cuenta.IdCtaCble;
                    newRow.dc_Valor_D = Debe;
                    newRow.dc_Valor_H = Haber;
                    newRow.dc_Observacion = observacion;
                    newRow.IdPunto_cargo = info_punto_cargo.IdPunto_cargo;

                    newRow.IdPunto_cargo_grupo = info_punto_cargo.IdPunto_cargo_grupo;
                    newRow.IdCentroCosto = info_punto_cargo.IdCentroCosto_Scc;
                    newRow.IdCentroCosto_sub_centro_costo = info_punto_cargo.IdCentroCosto_sub_centro_costo_Scc;
                    newRow.IdRegistro = info_punto_cargo.IdCentroCosto_Scc + '-' + info_punto_cargo.IdCentroCosto_sub_centro_costo_Scc.ToString();



                    if (info_cuenta != null)
                    {
                        if (Debe > 0)
                            newRow.dc_Valor = Debe;
                        else
                            newRow.dc_Valor = Haber * -1;
                        BindingList_cbtecble_det.Add(newRow);

                    }
                    return true;
                }
                else
                {
                    MessageBox.Show("No hay las columnas necesarias para insertar al registros");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + "El formato debe ser el siguiente\n" + "|codigo Producto|nombre producto|unidad med.|cantidad|costo|observacion det|centros cos|", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }
        }

    }
}

