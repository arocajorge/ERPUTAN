using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Business.CuentasxPagar;
using Core.Erp.Business.General;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Info.General;

namespace Core.Erp.Winform.Controles
{
    public partial class UCCp_Retencion : UserControl
    {
        Cl_Enumeradores.eTipo_action Accion;

        cp_codigo_SRI_Info Item = new cp_codigo_SRI_Info();

        cp_codigo_SRI_x_CtaCble_Bus bus = new cp_codigo_SRI_x_CtaCble_Bus();
        cp_codigo_SRI_x_CtaCble_Info info_SRIxCtaCble;

        cp_retencion_Info Info_Retencion = new cp_retencion_Info();
        List<cp_retencion_det_Info> List_Retencion_det = new List<cp_retencion_det_Info>();
        string _TieneRtIva;
        string _TieneRtFte;
        tb_sis_Documento_Tipo_Talonario_Info Info_Talonario = new tb_sis_Documento_Tipo_Talonario_Info();



        public void set_Info_Retencion(cp_retencion_Info _Info_Retencion)
        {
            Info_Retencion = _Info_Retencion;
        }


        


        //Bus
        cp_codigo_SRI_Bus dat_ti = new cp_codigo_SRI_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        //  Listas
        List<cp_codigo_SRI_Info> ListCodigoSRI = new List<cp_codigo_SRI_Info>();
        List<cp_codigo_SRI_Info> lm_codigo_sri = new List<cp_codigo_SRI_Info>();
        List<ct_Cbtecble_det_Info> ListDiarioRet = new List<ct_Cbtecble_det_Info>();

        BindingList<cp_codigo_SRI_Info> BindingList_codigoSRI;

        //Delegados

        public delegate void delegate_gridView_SRI_CellValueChanged(object sender, EventArgs e);
        public event delegate_gridView_SRI_CellValueChanged event_gridView_SRI_CellValueChanged;

        public delegate void delegate_gridView_SRI_KeyDown(object sender, EventArgs e);
        public event delegate_gridView_SRI_KeyDown event_gridView_SRI_KeyDown;

        double BaseImponible = 0;
        double iva = 0;

        string IdCtaCble_CXP = "";
        string nomProveedor = "";
        int IdTipoCbte_x_Retencion = 0;

        

        public UCCp_Retencion()
        {
            InitializeComponent();

            try
            {

                BindingList_codigoSRI = new BindingList<cp_codigo_SRI_Info>();
                gridControl_SRI.DataSource = BindingList_codigoSRI;

                event_gridView_SRI_CellValueChanged += UCCp_Retencion_event_gridView_SRI_CellValueChanged;
                event_gridView_SRI_KeyDown += UCCp_Retencion_event_gridView_SRI_KeyDown;

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        void UCCp_Retencion_event_gridView_SRI_KeyDown(object sender, EventArgs e)
        {

        }

        void UCCp_Retencion_event_gridView_SRI_CellValueChanged(object sender, EventArgs e)
        {

        }

        private void UCCp_Retencion_Load(object sender, EventArgs e)
        {
            try
            {
                string MensajeError = "";

                ListCodigoSRI = dat_ti.Get_List_codigo_SRI_(param.IdEmpresa);
                txtIdRetencion.Text = Info_Retencion.IdRetencion.ToString();
                cmb_CodigoSRI_grid.DataSource = ListCodigoSRI.FindAll(c => c.co_estado == "A" && (c.IdTipoSRI == "COD_RET_FUE" || c.IdTipoSRI == "COD_RET_IVA"));
                cmb_CodigoSRI_grid.DisplayMember = "descriConcate";
                cmb_CodigoSRI_grid.ValueMember = "IdCodigo_SRI";

                if (string.IsNullOrEmpty(Info_Retencion.NumRetencion) == false)
                {
                    
                    UC_numRetencion.rbt_doc_Electronico.Checked = (bool)Info_Retencion.EsDocumentoElectronico;
                    UC_numRetencion.rbt_pre_impresa.Checked = !(bool)Info_Retencion.EsDocumentoElectronico;

                    tb_sis_Documento_Tipo_Talonario_Info talonario_Info = new tb_sis_Documento_Tipo_Talonario_Info();
                    tb_sis_Documento_Tipo_Talonario_Bus BusTalonario = new tb_sis_Documento_Tipo_Talonario_Bus();
                    talonario_Info = BusTalonario.Verificar_DocumentoElectronico(Info_Retencion.IdEmpresa, Info_Retencion.CodDocumentoTipo, Info_Retencion.serie1, Info_Retencion.serie2, Info_Retencion.NumRetencion, talonario_Info, ref MensajeError);
                    Info_Retencion.EsDocumentoElectronico = talonario_Info.es_Documento_electronico;
                    UC_numRetencion.Set_Serie_Num_Documento(Info_Retencion.serie1, Info_Retencion.serie2, Info_Retencion.NumRetencion);
                    
                    
                    
                }
                
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void set_Valores(double baseImponible, double valorIva)
        {
            try
            {
                BaseImponible = baseImponible;
                iva = valorIva;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void Inhabilitar_Controles_numDocuRetencion()
        {
            try
            {
                UC_numRetencion.Inhabilitar_Controles();
            }
            catch (Exception ex)
            {

                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void Inhabilitar_Controles_Retencion(Boolean estado)
        {
            try
            {
                gridView_SRI.OptionsBehavior.ReadOnly = (estado != true) ? true : false;

                colBaseImponible.OptionsColumn.AllowEdit = false;
            }
            catch (Exception ex)
            {

                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void HabilitarGrid_Diario_retencion(Boolean estado)
        {
            try
            {
                UC_CbteCble_Retencion.HabilitarGrid(estado);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void Visible_GridRetencion(Boolean estado)
        {
            try
            {
                tabRetencion.Visible = estado;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void set_Valores_Documento(string serie1,string serie2, string numRetencion)
        {
            try
            {
                UC_numRetencion.Set_Serie_Num_Documento(serie1, serie2, numRetencion);
            }
            catch (Exception ex)
            {

                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        public tb_sis_Documento_Tipo_Talonario_Info Get_Documento_Tipo_Talonario()
        {
            try
            {
                return UC_numRetencion.Get_Info_Talonario();
            }
            catch (Exception ex)
            {

                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new tb_sis_Documento_Tipo_Talonario_Info();
            }

        }

        public Boolean valida()
        {
            Boolean res = false;

            try
            {
                if (UC_numRetencion.valida_numRetencion())
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

        public Boolean valida_ct_Cbtecble_det_Retencion()
        {
            Boolean res = false;

            try
            {
                if (UC_CbteCble_Retencion.valida_ct_Cbtecble_det())
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

        public Boolean ValidarAsientosContables()
        {
            Boolean res = false;

            try
            {
                if (UC_CbteCble_Retencion.ValidarAsientosContables())
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

        public void set_ListaCodigoSRI(List<cp_codigo_SRI_Info> lista)
        {
            try
            {
                BindingList_codigoSRI = new BindingList<cp_codigo_SRI_Info>(lista);
                gridControl_SRI.DataSource = BindingList_codigoSRI;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void set_Datos_Proveedor(string IdCtaCble, string Nombre, int IdTipoCbte_x_Reten)
        {
            try
            {
                IdCtaCble_CXP = IdCtaCble;
                nomProveedor = Nombre;
                IdTipoCbte_x_Retencion = IdTipoCbte_x_Reten;

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        public void set_Accion(Cl_Enumeradores.eTipo_action accion)
        {
            try
            {
                Accion = accion;

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        public void carga_codigoSRI_x_Proveedor(int IdEmpresa, decimal IdProveedor)
        {
            try
            {
                BindingList_codigoSRI = new BindingList<cp_codigo_SRI_Info>();

                List<cp_proveedor_codigo_SRI_Info> lista = new List<cp_proveedor_codigo_SRI_Info>();
                cp_proveedor_codigo_SRI_Bus bus = new cp_proveedor_codigo_SRI_Bus();
                lista = bus.Get_List_proveedor_codigo_SRI(IdEmpresa, IdProveedor);

                List<cp_codigo_SRI_Info> listaAux_codigoSRI_grid = new List<cp_codigo_SRI_Info>();

                if (lista.Count != 0)
                {
                    lm_codigo_sri = dat_ti.Get_List_codigo_SRI_IvaRet(param.IdEmpresa);


                    if (lm_codigo_sri.Count != 0)
                    {
                        foreach (var item in lista)
                        {
                            cp_codigo_SRI_Info info = new cp_codigo_SRI_Info();

                            var item2 = lm_codigo_sri.FirstOrDefault(c => c.IdCodigo_SRI == item.IdCodigo_SRI);

                            info.IdCodigo_SRI = item2.IdCodigo_SRI;
                            info.Tipo = item2.Tipo;
                            info.co_porRetencion = item2.co_porRetencion;
                            info.IdCtaCble = item2.IdCtaCble;
                            info.FechaVigente = item2.FechaVigente;

                            if (info.Tipo == "RTF")
                            {
                                info.BaseImponible = Convert.ToDouble(BaseImponible);
                                info.MontoRetencion = info.BaseImponible * (info.co_porRetencion / 100);
                            }
                            else
                            {
                                info.BaseImponible = Convert.ToDouble(iva);
                                info.MontoRetencion = info.BaseImponible * (info.co_porRetencion / 100);
                            }

                            info.codigoSRI = item2.codigoSRI;

                            listaAux_codigoSRI_grid.Add(info);
                        }

                    }

                    BindingList_codigoSRI = new BindingList<cp_codigo_SRI_Info>(listaAux_codigoSRI_grid);
                    gridControl_SRI.DataSource = BindingList_codigoSRI;

                    GeneraDiarioRetencion();

                }
                else
                {
                    if (BindingList_codigoSRI.Count == 0)
                    {
                        BindingList_codigoSRI = new BindingList<cp_codigo_SRI_Info>();
                        gridControl_SRI.DataSource = BindingList_codigoSRI;

                    }
                    else
                    {
                        foreach (var item in BindingList_codigoSRI)
                        {

                            if (item.Tipo == "RTF")
                            {
                                item.BaseImponible = Convert.ToDouble(BaseImponible);
                                item.MontoRetencion = item.BaseImponible * (item.co_porRetencion / 100);
                            }
                            else
                            {
                                item.BaseImponible = Convert.ToDouble(iva);
                                item.MontoRetencion = item.BaseImponible * (item.co_porRetencion / 100);
                            }

                        }

                        gridControl_SRI.RefreshDataSource();
                        GeneraDiarioRetencion();
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

        public void LimpiarGrid_Retencion()
        {
            try
            {
                BindingList_codigoSRI = new BindingList<cp_codigo_SRI_Info>();
                gridControl_SRI.DataSource = BindingList_codigoSRI;
                gridControl_SRI.Refresh();

                UC_CbteCble_Retencion.LimpiarGrid();
                UC_numRetencion.limpiarControles();

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void GeneraDiarioRetencion()
        {
            try
            {
                UC_CbteCble_Retencion.validaValores = false;
                UC_CbteCble_Retencion.setDetalle(new List<ct_Cbtecble_det_Info>());
                ListDiarioRet = new List<ct_Cbtecble_det_Info>();
                double Sum_Ret_valor = 0;

                // RETENCION

                foreach (var item in BindingList_codigoSRI)
                {
                    if (item.co_porRetencion > 0)
                    {
                        double valor = 0;

                        if (item.MontoRetencion > 0)
                        {
                            valor = Math.Round(item.MontoRetencion, 2);
                        }
                        else
                        {

                            if (item.BaseImponible != 0)
                            {
                                if (item.Tipo == "IVA")
                                {
                                    item.MontoRetencion = item.BaseImponible * (item.co_porRetencion / 100);
                                    valor = item.MontoRetencion;
                                }
                                else
                                {
                                    item.MontoRetencion = item.BaseImponible * (item.co_porRetencion / 100);
                                    valor = item.MontoRetencion;
                                }
                            }

                        }

                        ct_Cbtecble_det_Info regDebe = new ct_Cbtecble_det_Info();

                        string IdCtaCble_iva = "";
                        string IdCtaCble_ret = "";

                        if (String.IsNullOrEmpty(item.IdCtaCble))
                        {
                            // obtener ctacble retencion de parametros
                            cp_parametros_Bus bus_param = new cp_parametros_Bus();
                            cp_parametros_Info info_param = new cp_parametros_Info();
                            info_param = bus_param.Get_Info_parametros(param.IdEmpresa);

                            if (item.Tipo == "IVA")
                            {
                                if (String.IsNullOrEmpty(info_param.pa_ctacble_x_RetIva_default))
                                {
                                    IdCtaCble_iva = "";
                                }
                                else
                                {
                                    IdCtaCble_iva = info_param.pa_ctacble_x_RetIva_default;
                                }
                                regDebe.IdCtaCble = IdCtaCble_iva;
                            }
                            else
                            {
                                if (String.IsNullOrEmpty(info_param.pa_ctacble_x_RetFte_default))
                                {
                                    IdCtaCble_ret = "";
                                }
                                else
                                {
                                    IdCtaCble_ret = info_param.pa_ctacble_x_RetFte_default;
                                }
                                regDebe.IdCtaCble = IdCtaCble_ret;
                            }
                        }
                        else
                        {
                            regDebe.IdCtaCble = item.IdCtaCble == null ? "" : item.IdCtaCble.Trim();
                        }


                        regDebe.IdTipoCbte = IdTipoCbte_x_Retencion;
                        regDebe.dc_Valor = valor * -1;
                        regDebe.dc_Observacion = nomProveedor;
                        regDebe.tipo = item.Tipo;

                        ListDiarioRet.Add(regDebe);


                        Sum_Ret_valor = Sum_Ret_valor + valor;



                    }
                }// fin foreach



                // cta por pagar 1 sola vez acumulada
                ct_Cbtecble_det_Info regHaber = new ct_Cbtecble_det_Info();
                regHaber.IdCtaCble = IdCtaCble_CXP;
                regHaber.IdTipoCbte = IdTipoCbte_x_Retencion;
                regHaber.dc_Valor = Sum_Ret_valor;
                regHaber.dc_Observacion = "Ret cxp";
                regHaber.tipo = "IVA/RET";

                ListDiarioRet.Add(regHaber);


                UC_CbteCble_Retencion.setDetalle(ListDiarioRet);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public BindingList<cp_codigo_SRI_Info> Get_BindingList()
        {
            try
            {
                int focus = gridView_SRI.FocusedRowHandle;
                gridView_SRI.FocusedRowHandle = focus + 1;

                return BindingList_codigoSRI;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new BindingList<cp_codigo_SRI_Info>();
            }
        }

        public BindingList<ct_Cbtecble_det_Info> Get_BindList_ct_Cbtecble_det_Retencion()
        {
            try
            {
                return UC_CbteCble_Retencion.Get_BindingList_Cbtecble_det();
            }
            catch (Exception ex)
            {

                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new BindingList<ct_Cbtecble_det_Info>();
            }
        }

        public void Set_BindingList_codigo_SRI(BindingList<cp_codigo_SRI_Info> BindingList)
        {
            try
            {
                BindingList_codigoSRI = new BindingList<cp_codigo_SRI_Info>(BindingList);
                gridControl_SRI.DataSource = BindingList_codigoSRI;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        public List<ct_Cbtecble_det_Info> Get_BindingList_ct_Cbtecble_det()
        {
            try
            {

                return UC_CbteCble_Retencion.Get_List_Cbtecble_det();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new List<ct_Cbtecble_det_Info>();
            }

        }

        public void setInfo_DiarioRetencion(int IdEmpresa, int IdTipoCbte, decimal IdCbteCble)
        {
            try
            {
                UC_CbteCble_Retencion.setInfo(IdEmpresa, IdTipoCbte, IdCbteCble);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        public ct_Cbtecble_Info Get_Info_CbteCble_Retencion()
        {
            try
            {
                return UC_CbteCble_Retencion.Get_Info_CbteCble();
            }
            catch (Exception ex)
            {

                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new ct_Cbtecble_Info();
            }
        }

        public void Get_Ult_Documento_no_usado(int IdEmpresa, string IdEstablecimiento, string IdPuntoEmision)
        {
            try
            {
                UC_numRetencion.IdEstablecimiento = IdEstablecimiento;
                UC_numRetencion.IdPuntoEmision = IdPuntoEmision;
                UC_numRetencion.Get_Ult_Documento_no_usado();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void Get_Primer_Documento_no_usado(int IdEmpresa, string IdEstablecimiento, string IdPuntoEmision)
        {
            try
            {
                UC_numRetencion.IdEstablecimiento = IdEstablecimiento;
                UC_numRetencion.IdPuntoEmision = IdPuntoEmision;
                UC_numRetencion.Get_Primer_Documento_no_usado();

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public tb_sis_Documento_Tipo_Talonario_Info Get_Info_Talonario()
        {
            try
            {
                return UC_numRetencion.Get_Info_Talonario();
                
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new tb_sis_Documento_Tipo_Talonario_Info();
            }
        }

        public cp_retencion_Info Get_Info_Retencion(ref bool ValidaReten)
        {
            try
            {
                foreach (var item in BindingList_codigoSRI)
                {

                    if (item.Tipo == "IVA")
                    {
                        _TieneRtIva = "S";

                    }
                    else
                    {
                        _TieneRtFte = "S";
                    }


                }

                Info_Retencion.IdEmpresa = param.IdEmpresa;
                Info_Retencion.IdRetencion = 0;
                Info_Retencion.re_Tiene_RTiva = _TieneRtIva;
                Info_Retencion.re_Tiene_RFuente = _TieneRtFte;
                Info_Retencion.fecha = Convert.ToDateTime(dtp_fechaEmisionRetencion.Value.ToShortDateString());
                Info_Retencion.serie1 = UC_numRetencion.Get_Info_Talonario().Establecimiento;
                Info_Retencion.serie2 = UC_numRetencion.Get_Info_Talonario().PuntoEmision;
                Info_Retencion.NumRetencion = UC_numRetencion.Get_Info_Talonario().NumDocumento;
                Info_Retencion.re_EstaImpresa = "N";
                Info_Retencion.Estado = "A";
                Info_Retencion.IdUsuario = param.IdUsuario;
                Info_Retencion.Fecha_Transac = DateTime.Now;
                Info_Retencion.ip = param.ip;
                Info_Retencion.nom_pc = param.nom_pc;

                return Info_Retencion;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new cp_retencion_Info();
            }
        }

        public List<cp_retencion_det_Info> Get_list_det_Retencion(ref bool ValidaReten)
        {
            try
            {
                //cambiar es focus
                // ultraGrid_retencion.ActiveRow.Cells["Tipo"].Activate();

                ValidaReten = true;
                List_Retencion_det.Clear();
                dtp_fechaEmisionRetencion.Focus();
                double b_iva = 0, b_rtf = 0;
                int c = 0;
                //for (int i = 0; i < ultraGrid_retencion.Rows.Count; i++)
                foreach (var item in BindingList_codigoSRI)
                {
                    cp_retencion_det_Info ret_I = new cp_retencion_det_Info();

                    c = c + 1;

                    ret_I.IdEmpresa = param.IdEmpresa;
                    ret_I.IdRetencion = 0;
                    ret_I.Idsecuencia = c;

                    ret_I.re_tipoRet = item.Tipo;
                    ret_I.re_baseRetencion = item.BaseImponible;
                    ret_I.IdCodigo_SRI = Convert.ToInt32(Convert.ToString(item.IdCodigo_SRI) == "" ? "0" : Convert.ToString(item.IdCodigo_SRI));
                    ret_I.re_Codigo_impuesto = item.codigoSRI == null ? "" : Convert.ToString(item.codigoSRI);
                    ret_I.re_Porcen_retencion = Convert.ToDouble(Convert.ToString(item.co_porRetencion) == "" ? "0" : Convert.ToString(item.co_porRetencion));
                    ret_I.re_valor_retencion = Convert.ToDouble((Convert.ToString(item.MontoRetencion) == "") ? "0" : Convert.ToString(item.MontoRetencion));
                    ret_I.IdCtaCble = item.IdCtaCble;
                    ret_I.re_estado = "";
                    ret_I.IdUsuario = param.IdUsuario;
                    ret_I.Fecha_Transac = param.Fecha_Transac;
                    ret_I.IdUsuarioUltMod = param.IdUsuario;
                    ret_I.Fecha_UltMod = param.Fecha_Transac;
                    ret_I.IdUsuarioUltAnu = param.IdUsuario;
                    ret_I.Fecha_UltAnu = param.Fecha_Transac;
                    ret_I.nom_pc = param.nom_pc;
                    ret_I.ip = param.ip;

                    List_Retencion_det.Add(ret_I);

                    if (item.Tipo == "IVA")
                    {
                        b_iva = b_iva + Convert.ToDouble(item.BaseImponible);
                    }
                    else
                    {
                        b_rtf = b_rtf + Convert.ToDouble(item.BaseImponible);
                    }

                    if (b_iva > 0 && b_iva != Convert.ToDouble(iva))
                    {
                        MessageBox.Show("En Datos Retención Se estan realizando retenciones del IVA que no concuerdan con el total del IVA de la OG ", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ValidaReten = false;
                    }
                    if (b_rtf > 0 && b_rtf != Convert.ToDouble(BaseImponible))
                    {
                        MessageBox.Show("En Datos Retención Se estan realizando retenciones de a la fuente que no concuerdan con la base imponible de la OG", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ValidaReten = false;
                    }

                }
                return List_Retencion_det;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new List<cp_retencion_det_Info>();
            }
        }

        public double calcula_MontoRetencion()
        {
            double res = 0;
            try
            {

                foreach (var item in BindingList_codigoSRI)
                {
                    res = item.MontoRetencion + res;
                }
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

        private void gridView_SRI_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
                {
                if (e.Column.Name == "colIdCodigo_SRI")
                {
                    Item = ListCodigoSRI.FirstOrDefault(c => c.co_estado == "A" && (c.IdTipoSRI == "COD_RET_FUE" || c.IdTipoSRI == "COD_RET_IVA") && c.IdCodigo_SRI == Convert.ToDecimal(e.Value));
                    gridView_SRI.SetFocusedRowCellValue(colTipo, Item.IdTipoSRI == "COD_RET_IVA" ? "IVA" : "RTF");
                    gridView_SRI.SetFocusedRowCellValue(colco_porRetencion, Item.co_porRetencion);
                    gridView_SRI.SetFocusedRowCellValue(colIdCtaCble, Item.IdCtaCble);
                    gridView_SRI.SetFocusedRowCellValue(colcodigoSRI, Item.codigoSRI);
                    gridView_SRI.SetFocusedRowCellValue(colModificable, true);
                    string tipo = Convert.ToString(gridView_SRI.GetFocusedRowCellValue(colTipo));

                    if (tipo == "RTF")
                    {
                        decimal base_impo = 0;
                        base_impo = Math.Round(Convert.ToDecimal(BaseImponible), 2);
                        gridView_SRI.SetFocusedRowCellValue(colBaseImponible, base_impo);


                        info_SRIxCtaCble = new cp_codigo_SRI_x_CtaCble_Info();
                        info_SRIxCtaCble = bus.GetInfo_codigo_SRI_x_CtaCble(param.IdEmpresa, Item.IdCodigo_SRI);


                        if (info_SRIxCtaCble.idCodigo_SRI != 0)
                        {
                            gridView_SRI.SetFocusedRowCellValue(colIdCtaCble, info_SRIxCtaCble.IdCtaCble);
                        }
                    }
                    else
                    {
                        gridView_SRI.SetFocusedRowCellValue(colBaseImponible, Math.Round(Convert.ToDecimal(iva), 2));

                        info_SRIxCtaCble = new cp_codigo_SRI_x_CtaCble_Info();
                        info_SRIxCtaCble = bus.GetInfo_codigo_SRI_x_CtaCble(param.IdEmpresa, Item.IdCodigo_SRI);

                        if (info_SRIxCtaCble.idCodigo_SRI != 0)
                        {
                            gridView_SRI.SetFocusedRowCellValue(colIdCtaCble, info_SRIxCtaCble.IdCtaCble);
                        }


                    }
                    decimal prueba = 0;
                    prueba = Math.Round((Convert.ToDecimal(gridView_SRI.GetFocusedRowCellValue(colBaseImponible)) * (Convert.ToDecimal(gridView_SRI.GetFocusedRowCellValue(colco_porRetencion)) / 100)), 2);

                    gridView_SRI.SetFocusedRowCellValue(colMontoRetencion, prueba);

                    GeneraDiarioRetencion();

                }

                if (e.Column.Name == "colBaseImponible")
                {
                    gridView_SRI.SetFocusedRowCellValue(colMontoRetencion, 0);

                    GeneraDiarioRetencion();
                    // CalculoRetencion();

                }

                event_gridView_SRI_CellValueChanged(sender, e);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void gridView_SRI_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                event_gridView_SRI_KeyDown(sender, e);

                if (Accion == Cl_Enumeradores.eTipo_action.consultar || Accion == Cl_Enumeradores.eTipo_action.Anular)
                { return; }

                if (e.KeyValue.ToString() == "46")
                {
                    if (MessageBox.Show("Está seguro que desea eliminar el registro", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        gridView_SRI.DeleteSelectedRows();
                        gridControl_SRI.RefreshDataSource();

                        GeneraDiarioRetencion();
                        //  CalculoRetencion();
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

        private void gridControl_SRI_Click(object sender, EventArgs e)
        {

        }

        private void cmb_Generar_XML_Click(object sender, EventArgs e)
        {
            try
            {
                string MensajeError = "";

                

               int i= Info_Retencion.IdEmpresa;


                if (UC_numRetencion.rbt_doc_Electronico.Checked == true)
                {
                    if (BindingList_codigoSRI.Count == 0)
                    {
                        MessageBox.Show("La retencion no contiene detalle", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    cp_retencion_Bus bus_retenciones = new cp_retencion_Bus();
                    if (bus_retenciones.Generacion_xml_SRI(Info_Retencion.IdEmpresa, Info_Retencion.IdRetencion, ref MensajeError))
                    {
                        MessageBox.Show("Se genero correctamente el XML", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo generar el XML :\n\n" + MensajeError, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }
                else
                {
                    MessageBox.Show("No puede generar XML para documento PRE-IMPRESO", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void gridView_SRI_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                cp_codigo_SRI_Info row= (cp_codigo_SRI_Info)gridView_SRI.GetFocusedRow();
                if (row != null)
                {
                    if (row.Modificable != true)
                    {
                        colMontoRetencion.OptionsColumn.AllowEdit = false;
                    }
                    else
                    {
                        colMontoRetencion.OptionsColumn.AllowEdit = true;
                    }
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                throw;
            }
        }
    }
}
