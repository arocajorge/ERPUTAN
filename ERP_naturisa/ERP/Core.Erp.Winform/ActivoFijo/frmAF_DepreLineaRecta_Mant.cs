using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Info.ActivoFijo;
using Core.Erp.Business.ActivoFijo;
using Core.Erp.Winform.General;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Reportes.Contabilidad;
using Cus.Erp.Reports.Naturisa.Contabilidad;

namespace Core.Erp.Winform.ActivoFijo
{
    public partial class frmAF_DepreLineaRecta_Mant : Form
    {

        public delegate void delegate_FormClosed(object sender, FormClosingEventArgs e);
        public event delegate_FormClosed event_frmClosed;

        public cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        List<tb_sis_Log_Error_Vzen_Info> lstLogError = new List<tb_sis_Log_Error_Vzen_Info>();
        Cl_Enumeradores.eTipo_action _Accion;
        
        
        Af_Depreciacion_Info InfoDepre = new Af_Depreciacion_Info();

        Af_Tipo_Depreciacion_Bus busTipoDepre = new Af_Tipo_Depreciacion_Bus();
        Af_Depreciacion_Bus busDepre = new Af_Depreciacion_Bus();
        
        ct_Periodo_Bus busPeriodo = new ct_Periodo_Bus();
        List<ct_Periodo_Info> lstPeriodo = new List<ct_Periodo_Info>();
        ct_Cbtecble_Info CbteCbleInfo = new ct_Cbtecble_Info();
        ct_Cbtecble_Bus busCbteCble = new ct_Cbtecble_Bus();
        List<vwAf_Valores_Depre_Contabilizar_Info> lstValoresDepre = new List<vwAf_Valores_Depre_Contabilizar_Info>();
        Af_Parametros_Bus busParam = new Af_Parametros_Bus();
        Af_Parametros_Info infoParam = new Af_Parametros_Info();
        Af_Depreciacion_x_cta_cbtecble_Info infoDepreCble = new Af_Depreciacion_x_cta_cbtecble_Info();


        int IdTipoDepreciacion = 0;
        int IdTipoCbteDepre = 0;
        decimal IdCbteCle = 0;

        

        public frmAF_DepreLineaRecta_Mant()
        {
            InitializeComponent();
            ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
            ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
            ucGe_Menu.event_btnAnular_Click += ucGe_Menu_event_btnAnular_Click;
            ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
            ucGe_Menu.event_btnlimpiar_Click += ucGe_Menu_event_btnlimpiar_Click;
            event_frmClosed += new delegate_FormClosed(frmAF_DepreLineaRecta_Mant_event_frmClosed);
            ucGe_Menu.event_btnImprimir_Click += ucGe_Menu_event_btnImprimir_Click;
           
        }

        void ucGe_Menu_event_btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblContabilizado.Visible)
                {
                    ImprimirDiario();
                }
                else
                {
                    MessageBox.Show("No se encuentra Contabilizado", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ImprimirDiario()
        {
            try
            {
                switch (param.IdCliente_Ven_x_Default)
                {
                    case Cl_Enumeradores.eCliente_Vzen.NATURISA:
                        //Reporte agrupado por cuentas
                        XCONTA_NATU_Rpt003_Rpt rpt_natu = new XCONTA_NATU_Rpt003_Rpt();
                        rpt_natu.PIdEmpresa.Value = param.IdEmpresa;
                        rpt_natu.PIdEmpresa.Visible = false;
                        rpt_natu.PIdTipoCbte.Value = infoDepreCble.ct_IdTipoCbte;
                        rpt_natu.PIdTipoCbte.Visible = false;
                        rpt_natu.PIdCbteCble.Value = infoDepreCble.ct_IdCbteCble;
                        rpt_natu.PIdCbteCble.Visible = false;
                        rpt_natu.RequestParameters = true;
                        rpt_natu.ShowPreviewDialog();
                        break;                   
                    default:
                        XCONTA_Rpt003_rpt reporte = new XCONTA_Rpt003_rpt();
                        reporte.set_parametros(infoDepreCble.ct_IdEmpresa, infoDepreCble.ct_IdTipoCbte, infoDepreCble.ct_IdCbteCble);
                        reporte.RequestParameters = true;
                        reporte.ShowPreviewDialog();
                        break;
                }
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void frmAF_DepreLineaRecta_Mant_event_frmClosed(object sender, FormClosingEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                ct_Periodo_Info infoPeriodo = new ct_Periodo_Info();
                infoPeriodo = lstPeriodo.Where(q => q.IdPeriodo == Convert.ToInt32(cmbPeriodo.EditValue)).First();
                if (infoPeriodo.pe_cerrado == "S")
                {
                    MessageBox.Show("No puede Anular, El periodo ya se encuentra cerrado ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);                    
                    return;
                }

                //if (!lblContabilizado.Visible)
                    if (busDepre.VerificarUltDepre(InfoDepre.IdEmpresa, InfoDepre.IdDepreciacion, InfoDepre.IdTipoDepreciacion))
                        AnularDepreciacion();
                    else
                        MessageBox.Show("No puede Anular por que no es la ultima Depreciacion Realizada", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                //else

                  //  MessageBox.Show("No puede Anular porque ya se encuentra Contabilizado", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                cargarErroresGrid(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblContabilizado.Visible)
                    MessageBox.Show("No puede Guardar porque ya se encuentra Contabilizado", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    if (GuardarDepre())
                        this.Close();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblContabilizado.Visible)
                    MessageBox.Show("No puede Guardar porque ya se encuentra Contabilizado", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    GuardarDepre();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void setAccion_Controls()
        {
            try
            {

                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        ucGe_Menu.Enabled_bntAnular = false;
                        ucGe_Menu.Enabled_bntImprimir = false;
                        btnContabilizar.Enabled = false;
                        break;

                    case Cl_Enumeradores.eTipo_action.Anular:
                        ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
                        ucGe_Menu.Enabled_btnGuardar = false;
                        ucGe_Menu.Enabled_bntImprimir = false;
                        txtCodDepre.Properties.ReadOnly = true;
                        cmbPeriodo.Properties.ReadOnly = true;
                        dtpFecha.Enabled = false;
                        txtDescripcion.Properties.ReadOnly = true;
                        SetInfo_Depreciacion_x_Controls();
                        break;

                    case Cl_Enumeradores.eTipo_action.consultar:
                        ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
                        ucGe_Menu.Enabled_btnGuardar = false;
                        ucGe_Menu.Enabled_bntAnular = false;
                        SetInfo_Depreciacion_x_Controls();
                        break;

                    case Cl_Enumeradores.eTipo_action.actualizar:
                        ucGe_Menu.Enabled_bntAnular = false;
                        txtCodDepre.Properties.ReadOnly = true;
                        cmbPeriodo.Properties.ReadOnly = true;
                        SetInfo_Depreciacion_x_Controls();
                        break;

                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        Boolean GuardarDepre()
        {
            try
            {
                Boolean bolResult = false;
                decimal IdDepreciacion = 0;
                string msjError = "";
                if (ValidarData())
                {
                    getDepreciacion();
                    switch (_Accion)
                    {
                        case Cl_Enumeradores.eTipo_action.grabar:
                            if (busDepre.GuardarDB(InfoDepre, ref IdDepreciacion, ref msjError))
                            {
                                txtIdDepre.EditValue = IdDepreciacion;
                                //ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
                                //ucGe_Menu.Enabled_btnGuardar = false;
                                btnProcesarDepre.Enabled = false;
                                bolResult = true;
                                MessageBox.Show("Se Guardo Exitosamente la Depreciacion", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);

                                if (!lblContabilizado.Visible)
                                {
                                    if (MessageBox.Show("¿Desea Contabilizar la Depreciacion.", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                    {        
                                         ContabilizarDepreLineal();
                                    }
                                }else
                                     MessageBox.Show("La Depreciacion ya se encuentra Contabilizada", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);

                                if (lblContabilizado.Visible)
                                {
                                    cargarGridContable();
                                    if (MessageBox.Show("¿Desea Imprimir el Soporte ?" + "\n" + "Imprimir", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                    {
                                        ucGe_Menu_event_btnImprimir_Click(null, null);
                                    }
                                }

                                LimpiarDatos();
                            }
                            else
                                MessageBox.Show(msjError, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);

                            break;

                        case Cl_Enumeradores.eTipo_action.actualizar:
                            InfoDepre.Fecha_UltMod = DateTime.Now;
                            InfoDepre.IdUsuarioUltMod = param.IdUsuario;
                            if (busDepre.ModificarDB(InfoDepre, ref msjError))
                            {
                                btnProcesarDepre.Enabled = false;
                                bolResult = true;
                                MessageBox.Show("Se Modifico Exitosamente la Depreciacion", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                if (lblContabilizado.Visible)
                                {
                                    cargarGridContable();
                                    if (MessageBox.Show("¿Desea Imprimir el Soporte ?" + "\n" + "Imprimir", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                    {
                                        ucGe_Menu_event_btnImprimir_Click(null, null);
                                    }
                                }
                                LimpiarDatos();
                            }
                            else
                                MessageBox.Show(msjError, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);

                            break;               
                    }
                }
                return bolResult;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

         void LimpiarDatos()
        {
            try
            {
                _Accion = Cl_Enumeradores.eTipo_action.grabar;
                btnProcesarDepre.Enabled = true;
                btnContabilizar.Enabled = false;
                lblContabilizado.Visible = false;
                InfoDepre = new Af_Depreciacion_Info();                
                cmbPeriodo.EditValue = null;
                txtIdDepre.EditValue = "";
                
                txtCodDepre.EditValue = "";
                txtDescripcion.EditValue  = "";
                
                txtCantActDepre.EditValue = "";
                txtTotActivo.EditValue = "";
                txtTotDepre.EditValue = "" ;
                txtTotDepreAcum.EditValue = "";
                txtTotImpLibros.EditValue = "";     

                InfoDepre.ListDetalle = new List<Af_Depreciacion_Det_Info>();
                gridActivoDepre.DataSource = new List<vwAf_ActivoFijo_Info>();

                CbteCbleInfo = new ct_Cbtecble_Info();
                lstValoresDepre = new List<vwAf_Valores_Depre_Contabilizar_Info>();                
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



         public void SetInfo(Af_Depreciacion_Info InfoDeprec)
         {
             try
             {
                 InfoDepre = InfoDeprec;
             }
             catch (Exception ex)
             {
                 Log_Error_bus.Log_Error(ex.ToString());
                 MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
         }

        private void SetInfo_Depreciacion_x_Controls()
        {
            try
            {
                
                //btnProcesarDepre.Enabled = false;
                txtIdDepre.EditValue = InfoDepre.IdDepreciacion;
                cmbPeriodo.EditValue = InfoDepre.IdPeriodo;
                txtCodDepre.EditValue = InfoDepre.Cod_Depreciacion;
                txtDescripcion.EditValue = InfoDepre.Descripcion;
                dtpFecha.Value = InfoDepre.Fecha_Depreciacion;
                txtCantActDepre.EditValue = InfoDepre.Num_Act_Depre;
                txtTotActivo.EditValue = InfoDepre.Valor_Tot_Act;
                txtTotDepre.EditValue = InfoDepre.Valor_Tot_Depre;
                txtTotDepreAcum.EditValue = InfoDepre.Valor_Tot_DepreAcum;
                txtTotImpLibros.EditValue = InfoDepre.Valot_Tot_Importe;
                if (InfoDepre.Estado == "I")
                    lblAnulado.Visible = true;

                

                Af_Depreciacion_Det_Bus  BusDep_det = new Af_Depreciacion_Det_Bus();
                InfoDepre.lstGridDepre=BusDep_det.Get_List_DepreciacionDetalle(InfoDepre.IdEmpresa, InfoDepre.IdDepreciacion, InfoDepre.IdTipoDepreciacion);
                txtCantActDepre.Text = InfoDepre.lstGridDepre.Count.ToString();
                gridActivoDepre.DataSource = InfoDepre.lstGridDepre;

                cargarGridContable();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void getDepreciacion()
        {
            try
            {
                InfoDepre.IdEmpresa = param.IdEmpresa;
                InfoDepre.IdPeriodo = Convert.ToInt32(cmbPeriodo.EditValue);
                InfoDepre.IdDepreciacion = (txtIdDepre.EditValue == "" || txtIdDepre.EditValue  == null)? 0: Convert.ToDecimal(txtIdDepre.EditValue );
                InfoDepre.IdTipoDepreciacion = 1;
                InfoDepre.Cod_Depreciacion = (txtCodDepre.EditValue == "" || txtCodDepre.EditValue == null) ? "" : Convert.ToString(txtCodDepre.EditValue);
                InfoDepre.Descripcion = Convert.ToString(txtDescripcion.EditValue);
                InfoDepre.Fecha_Depreciacion = dtpFecha.Value;
                InfoDepre.Num_Act_Depre = (txtCantActDepre.EditValue == "" || txtCantActDepre.EditValue == null) ? 0 : Convert.ToInt32(txtCantActDepre.EditValue);
                InfoDepre.Valor_Tot_Act = (txtTotActivo.EditValue == "" || txtTotActivo.EditValue == null) ? 0 : Convert.ToDouble(txtTotActivo.EditValue);
                InfoDepre.Valor_Tot_Depre = (txtTotDepre.EditValue == "" || txtTotDepre.EditValue == null) ? 0 : Convert.ToDouble(txtTotDepre.EditValue);
                InfoDepre.Valor_Tot_DepreAcum = (txtTotDepreAcum.EditValue == "" || txtTotDepreAcum.EditValue == null) ? 0 : Convert.ToDouble(txtTotDepreAcum.EditValue);
                InfoDepre.Valot_Tot_Importe = (txtTotImpLibros.EditValue == "" || txtTotImpLibros.EditValue == null) ? 0 : Convert.ToDouble(txtTotImpLibros.EditValue);
                InfoDepre.IdUsuario = param.IdUsuario;
                InfoDepre.Fecha_Transac = DateTime.Now;
                InfoDepre.nom_pc = param.nom_pc;
                InfoDepre.ip = param.ip;
                InfoDepre.Estado = "A";

                InfoDepre.ListDetalle = new List<Af_Depreciacion_Det_Info>();
                InfoDepre.ListDetalle = getDetalleDepre();
            }
            catch (Exception ex)
            {
                cargarErroresGrid(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private List<Af_Depreciacion_Det_Info> getDetalleDepre()
        {
            try
            {
                List<Af_Depreciacion_Det_Info> lstDetalle = new List<Af_Depreciacion_Det_Info>();
                var grid = from q in (List<vwAf_ActivoFijo_Info>)gridActivoDepre.DataSource select q;
                foreach (var item in grid)
                {
                    Af_Depreciacion_Det_Info infoDet = new Af_Depreciacion_Det_Info();
                    infoDet.IdEmpresa = param.IdEmpresa;
                    infoDet.IdActivoFijo = item.IdActivoFijo;
                    infoDet.Ciclo = item.Ciclo;
                    infoDet.Concepto = item.Concepto_Depre;
                    infoDet.Valor_Compra = item.Af_costo_compra;
                    infoDet.Valor_Salvamento = item.Af_ValorSalvamento;
                    infoDet.Vida_Util = item.Af_Vida_Util;
                    infoDet.Porc_Depreciacion = item.Af_porcentaje_deprec;
                    infoDet.Valor_Depreciacion = item.Valor_Depre;
                    infoDet.Valor_Depre_Acum = item.Valor_Depreciacion_Acum;
                    infoDet.Valor_Importe = item.Valor_Importe;
                    infoDet.Es_Activo_x_Mejora = item.Es_Activo_x_Mejora;

                    lstDetalle.Add(infoDet);
                }

                return lstDetalle;
            }
            catch (Exception ex)
            {
                cargarErroresGrid(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<Af_Depreciacion_Det_Info>();
            }
        }

      

        Boolean AnularDepreciacion()
        {
            try
            {
                Boolean bolResult = false;
                decimal IdCbteCble_Rev = 0;
                string msjError = "";
                getDepreciacion();
                getCbtecbleAnulacion();
                if (busCbteCble.ValidarObjeto(CbteCbleInfo, ref msjError))
                {
                    FrmGe_MotivoAnulacion frm = new FrmGe_MotivoAnulacion();
                    frm.ShowDialog();
                    InfoDepre.MotivoAnula = frm.motivoAnulacion;
                    InfoDepre.Fecha_UltAnu = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                    InfoDepre.IdUsuarioUltAnu = param.IdUsuario;
                    InfoDepre.IdTipoCbte_Rev = infoParam.IdTipoCbteDep_Acum_Anulacion;

                    if (busDepre.AnularDB(InfoDepre, CbteCbleInfo, ref IdCbteCble_Rev, ref msjError))
                    {
                        ucGe_Menu.Enabled_bntAnular = false;
                        bolResult = true;
                        lblAnulado.Visible = true;
                        MessageBox.Show("Se Anulo Exitosamente la Depreciacion", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show(msjError, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cargarErroresGrid(msjError);
                    }

                }
                else
                {
                    MessageBox.Show(msjError, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return bolResult;
            }
            catch (Exception ex)
            {
                cargarErroresGrid(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        Boolean ValidarData()
        {
            try
            {
                ct_Periodo_Info infoPeriodo = new ct_Periodo_Info();
                infoPeriodo = lstPeriodo.Where(q => q.IdPeriodo == Convert.ToInt32(cmbPeriodo.EditValue)).First();

                if (cmbPeriodo.EditValue == "" || cmbPeriodo.EditValue == null)
                {
                    MessageBox.Show("Seleccione el Periodo de la Depreciación", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.cmbPeriodo.Focus();
                    return false;
                }

                if (dtpFecha.Value == null)
                {
                    MessageBox.Show("Seleccione el Fecha de la Depreciación", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.dtpFecha.Focus();
                    return false;
                }

                if (Convert.ToInt32(txtCantActDepre.EditValue) <= 0)
                {
                    MessageBox.Show("La cantdad de Activos a depreciar tiene que ser mayor a 0", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtCantActDepre.Focus();
                    return false;
                }

                if (txtDescripcion.EditValue == "" || txtDescripcion.EditValue == null)
                {
                    MessageBox.Show("Ingrese la descripción de la Depreciación", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtDescripcion.Focus();
                    return false;
                }
                /*
                if (Convert.ToInt32(txtTotActivo.EditValue) <= 0)
                {
                    MessageBox.Show("El valor total del Activo tiene que ser mayor a 0", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtTotActivo.Focus();
                    return false;
                }
                if (Convert.ToInt32(txtTotDepre.EditValue) <= 0)
                {
                    MessageBox.Show("El valor total de Depreciación tiene que ser mayor a 0", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtTotDepre.Focus();
                    return false;
                }

                
                if (Convert.ToInt32(txtTotImpLibros.EditValue) <= 0)
                {
                    MessageBox.Show("El valor total del Importe en Libros tiene que ser mayor a 0", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtTotImpLibros.Focus();
                    return false;
                }
                */
                if (infoPeriodo.pe_cerrado == "S")
                {
                    MessageBox.Show("El periodo ya se encuentra cerrado ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.cmbPeriodo.Focus();
                    return false;
                }
                if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    if (!(busDepre.VerificarPeriodoExistente(param.IdEmpresa, infoPeriodo.IdPeriodo, "A")))
                    {
                        MessageBox.Show(" Los activos ya fueron depreciados para este periodo ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.cmbPeriodo.Focus();
                        return false;
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                cargarErroresGrid(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void frmAF_DepreLineaRecta_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                
                IdTipoDepreciacion = busTipoDepre.Get_IdTipoDepre(Cl_Enumeradores.eTipoDepreciacion.DEP_LIN.ToString());                
                infoParam = busParam.Get_Info_Parametros(param.IdEmpresa);
                IdTipoCbteDepre = infoParam.IdTipoCbte;
                
                cargarCombos();
                setAccion_Controls();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void cargarCombos()
        {
            try
            {
                if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    lstPeriodo = busDepre.get_Periodos_No_Depreciados(param.IdEmpresa);
                }
                else
                {
                    lstPeriodo = busDepre.get_Periodos(param.IdEmpresa);
                }
                cmbPeriodo.Properties.DataSource = lstPeriodo;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbPeriodo_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbPeriodo.EditValue == null)                
                    return;
                
                var selectPeri = lstPeriodo.Where(q => q.IdPeriodo == Convert.ToInt32(cmbPeriodo.EditValue)).FirstOrDefault();
                dtpFecha.Value = Convert.ToDateTime(selectPeri.pe_FechaFin);
            }
            catch (Exception ex)
            {
                cargarErroresGrid(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void CalcularActivos_Depre()
        {
            try
            {
                vwAf_ActivoFijo_Bus busVwAf = new vwAf_ActivoFijo_Bus();
                List<vwAf_ActivoFijo_Info> lstVwaf = new List<vwAf_ActivoFijo_Info>();
                var selectPeri = lstPeriodo.Where(q => q.IdPeriodo == Convert.ToInt32(cmbPeriodo.EditValue)).FirstOrDefault();
                lstVwaf = busVwAf.Get_List_ActivoFijo_Depre(param.IdEmpresa, selectPeri.pe_FechaIni, selectPeri.pe_FechaFin,param.IdUsuario);
                gridActivoDepre.DataSource = lstVwaf;

                if (lstVwaf.Count > 0)
                {
                    txtCantActDepre.EditValue = lstVwaf.Count;
                    txtTotActivo.EditValue = lstVwaf.Sum(q => q.Af_costo_compra);
                    txtTotDepre.EditValue = lstVwaf.Sum(q => q.Valor_Depre);
                    txtTotDepreAcum.EditValue = lstVwaf.Sum(q => q.Valor_Depreciacion_Acum);
                    txtTotImpLibros.EditValue = lstVwaf.Sum(q => q.Valor_Importe);
                }
                else {
                    txtCantActDepre.EditValue = 0;
                    txtTotActivo.EditValue = 0;
                    txtTotDepre.EditValue = 0;
                    txtTotDepreAcum.EditValue = 0;
                    txtTotImpLibros.EditValue = 0;
                }
            }
            catch (Exception ex)
            {
                cargarErroresGrid(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnProcesarDepre_Click(object sender, EventArgs e)
        {
            try
            {
                CalcularActivos_Depre();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void frmAF_DepreLineaRecta_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                frmAF_DepreLineaRecta_Mant_event_frmClosed(sender, e);
                event_frmClosed(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnContabilizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblContabilizado.Visible)
                    MessageBox.Show("La Depreciacion ya se encuentra Contabilizada", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);            
                else
                     ContabilizarDepreLineal();
                    
            }
            catch (Exception ex)
            {
                   Log_Error_bus.Log_Error(ex.ToString());
                   MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        Boolean ContabilizarDepreLineal()
        {
            try
            {
                Boolean bolResult = false;
                decimal IdCbteCble = 0;
                string msjError = "";
                decimal id = (txtIdDepre.Text == "") ? 0 : Convert.ToDecimal(txtIdDepre.Text);
                int IdPeriodo=0;

                   
                    //infoDepreCble.IdTipoDepreciacion = InfoDepre.IdTipoDepreciacion;
                    Cl_Enumeradores.eForma_Contabilizar Forma_conta = (Cl_Enumeradores.eForma_Contabilizar)Enum.Parse(typeof(Cl_Enumeradores.eForma_Contabilizar), infoParam.FormaContabiliza);
                    IdPeriodo = Convert.ToInt32(cmbPeriodo.EditValue);

                    if (busDepre.ContabilizarDepreciacion(param.IdEmpresa,Convert.ToInt32(txtIdDepre.Text), IdPeriodo, Forma_conta, ref IdCbteCble, ref msjError))
                    {
                        bolResult = true;
                        btnContabilizar.Enabled = false;
                        lblContabilizado.Visible = true;
                        MessageBox.Show("Depreciacion Contabilizada Exitosamente", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cargarGridContable();
                    }
                    else {
                        MessageBox.Show(msjError, param.Nombre_sistema);
                        cargarErroresGrid(msjError);
                        btnContabilizar.Enabled = true;
                        lblContabilizado.Visible = false;
                    }                  
                
                

                return bolResult;
            }
            catch (Exception ex)
            {
                cargarErroresGrid(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        void cargarErroresGrid(string ErrorPantalla)
        {
            try
            {
                tb_sis_Log_Error_Vzen_Info infoLog = new tb_sis_Log_Error_Vzen_Info();
                infoLog.Detalle = ErrorPantalla;
                lstLogError.Add(infoLog);
                gridLogError.DataSource = lstLogError;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }

        public void cargarGridContable()
        {
            try
            {
                decimal IdDepreciacion = 0;
                Af_Depreciacion_x_cta_cbtecble_Bus busDepreCtaCble = new Af_Depreciacion_x_cta_cbtecble_Bus();

                if (txtIdDepre.Text != "")
                {
                    IdDepreciacion = Convert.ToDecimal(txtIdDepre.Text);
                }
                infoDepreCble = busDepreCtaCble.Get_Info_Af_Depreciacion_x_cta_cbtecble(param.IdEmpresa, IdDepreciacion, InfoDepre.IdTipoDepreciacion);
                    if (infoDepreCble.ct_IdCbteCble == null || infoDepreCble.ct_IdCbteCble == 0)
                    {
                        IdCbteCle = 0;
                        btnContabilizar.Enabled = true;
                        lblContabilizado.Visible = false;
                    }
                    else
                    {
                        IdCbteCle = infoDepreCble.ct_IdCbteCble;
                        ucCon_GridDiarioContable.setInfo(infoDepreCble.ct_IdEmpresa, infoDepreCble.ct_IdTipoCbte, infoDepreCble.ct_IdCbteCble);
                        btnContabilizar.Enabled = false;
                        lblContabilizado.Visible = true;
                    }
                }
            
            catch (Exception ex)
            {
                cargarErroresGrid(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void getCbtecbleAnulacion()
        {
            try
            {
                CbteCbleInfo.IdEmpresa = param.IdEmpresa;
                CbteCbleInfo.IdTipoCbte = (infoDepreCble.ct_IdTipoCbte == null || infoDepreCble.ct_IdTipoCbte == 0) ? IdTipoCbteDepre : infoDepreCble.ct_IdTipoCbte;
                CbteCbleInfo.CodCbteCble = "";
                CbteCbleInfo.IdPeriodo = Convert.ToInt32(cmbPeriodo.EditValue);

                CbteCbleInfo.cb_Fecha = Convert.ToDateTime(dtpFecha.Value);
                CbteCbleInfo.cb_Valor = ucCon_GridDiarioContable.Get_ValorCbteCble();
                CbteCbleInfo.cb_Observacion = "Contbilizacion " + Cl_Enumeradores.eTipoDepreciacion.DEP_LIN.ToString() + " Por " + infoParam.FormaContabiliza + " Periodo " + cmbPeriodo.EditValue;
                CbteCbleInfo.Secuencia = 0;
                CbteCbleInfo.Estado = "A";

                CbteCbleInfo.Anio = Convert.ToDateTime(dtpFecha.Value).Year;

                CbteCbleInfo.Mes = Convert.ToDateTime(dtpFecha.Value).Month;
                CbteCbleInfo.IdUsuario = param.IdUsuario;
                CbteCbleInfo.IdUsuarioUltModi = param.IdUsuario;
                CbteCbleInfo.cb_FechaTransac = param.Fecha_Transac;
                CbteCbleInfo.cb_FechaUltModi = param.Fecha_Transac;
                CbteCbleInfo.Mayorizado = "N";
                CbteCbleInfo.IdCbteCble = IdCbteCle;

                getCbteCble_Det_Anulacion();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private List<ct_Cbtecble_det_Info> getCbteCble_Det_Anulacion()
        {
            try
            {
                var lstDetalle = ucCon_GridDiarioContable.Get_Info_CbteCble()._cbteCble_det_lista_info;
                int i = 1;
                foreach (var dte in lstDetalle)
                {
                    dte.IdEmpresa = param.IdEmpresa;
                    dte.IdCbteCble = IdCbteCle;
                    dte.IdTipoCbte = (infoDepreCble.ct_IdTipoCbte == null || infoDepreCble.ct_IdTipoCbte == 0) ? IdTipoCbteDepre : infoDepreCble.ct_IdTipoCbte;

                    dte.secuencia = i++;
                }
                CbteCbleInfo._cbteCble_det_lista_info = lstDetalle;

                return lstDetalle;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<ct_Cbtecble_det_Info>();
            }
        }

        private void btn_imprimir_grilla_Click(object sender, EventArgs e)
        {
            try
            {
                gridActivoDepre.ShowPrintPreview();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
