using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Core.Erp.Business.General;
using Core.Erp.Business.Inventario;
using Core.Erp.Info.Inventario;
using Core.Erp.Info.General;

namespace Core.Erp.Winform.Inventario
{
    public partial class FrmIn_SubGrupo_Mant : Form
    {
        #region Variables
        //Bus

        in_categorias_bus bus_Categoria = new in_categorias_bus();
        in_linea_Bus bus_Linea = new in_linea_Bus();
        in_grupo_Bus bus_Grupo = new in_grupo_Bus();
        in_subgrupo_Bus bus_subGrupo = new in_subgrupo_Bus();
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        //Listas
        List<in_categorias_Info> listCategoria = new List<in_categorias_Info>();
        List<in_linea_info> listlinea = new List<in_linea_info>();
        List<in_grupo_info> listGrupo = new List<in_grupo_info>();
        //Infos
        in_subgrupo_info infoSubGrupo = new in_subgrupo_info();

        //Variables
        string mensaje = "";
        int IdSubGrupo = 0;
        Cl_Enumeradores.eTipo_action enu = new Cl_Enumeradores.eTipo_action();
        public in_subgrupo_info _SetInfo { get; set; }
        public delegate void Delegate_FrmIn_SubGrupo_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event Delegate_FrmIn_SubGrupo_Mant_FormClosing Event_FrmIn_SubGrupo_Mant_FormClosing;
        #endregion

        public FrmIn_SubGrupo_Mant()
        {
            InitializeComponent();
            //ucmb_CentroCostoInven.Event_cmbCentroCosto_EditValueChanged += ucmb_CentroCostoInven_Event_cmbCentroCosto_EditValueChanged;
            //ucmb_CentroCostoGastos.Event_cmbCentroCosto_EditValueChanged += ucmb_CentroCostoGastos_Event_cmbCentroCosto_EditValueChanged;
            //ucmb_CentroCosto_Costos.Event_cmbCentroCosto_EditValueChanged += ucmb_CentroCosto_Costos_Event_cmbCentroCosto_EditValueChanged;
            Event_FrmIn_SubGrupo_Mant_FormClosing += FrmIn_SubGrupo_Mant_Event_FrmIn_SubGrupo_Mant_FormClosing;
        }

        void FrmIn_SubGrupo_Mant_Event_FrmIn_SubGrupo_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        //void ucmb_CentroCosto_Costos_Event_cmbCentroCosto_EditValueChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        ucmb_CentroCosto_Costos.get_item();

        //        ucmb_SubCentroCosto_Costos.cargaCmb_SubcentroCostos_x_IdCentroCosto(param.IdEmpresa, ucmb_CentroCosto_Costos.get_item());
                
        //    }
        //    catch (Exception ex)
        //    {
        //        Log_Error_bus.Log_Error(ex.ToString());
        //        MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //void ucmb_CentroCostoGastos_Event_cmbCentroCosto_EditValueChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        ucmb_CentroCostoGastos.get_item();

        //        ucmb_SubCentroCostoGastos.cargaCmb_SubcentroCostos_x_IdCentroCosto(param.IdEmpresa, ucmb_CentroCostoGastos.get_item());

        //    }
        //    catch (Exception ex)
        //    {
        //         Log_Error_bus.Log_Error(ex.ToString());
        //         MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //void ucmb_CentroCostoInven_Event_cmbCentroCosto_EditValueChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        ucmb_CentroCostoInven.get_item();
         
        //        ucmb_SubCentroCostoInven.cargaCmb_SubcentroCostos_x_IdCentroCosto(param.IdEmpresa, ucmb_CentroCostoInven.get_item());
        //    }
        //    catch (Exception ex)
        //    {
                
        //        Log_Error_bus.Log_Error(ex.ToString());
        //        MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        

          public FrmIn_SubGrupo_Mant(Cl_Enumeradores.eTipo_action Numerador)
            : this()
          {
              try
              {
                   enu = Numerador;
              }
              catch (Exception ex)
              {
                  Log_Error_bus.Log_Error(ex.ToString());
                  MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
              }
          }
       
        void Carga_Combo()
        {
            try
            {
                listCategoria = bus_Categoria.Get_List_categorias(param.IdEmpresa);
                cmbCategoria.Properties.DataSource = listCategoria;
                cmbCategoria.Properties.DisplayMember = "ca_Categoria";
                cmbCategoria.Properties.ValueMember = "IdCategoria";
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void GetSubGrupo()
        {
            try
            {
                infoSubGrupo.IdEmpresa = param.IdEmpresa;           
                infoSubGrupo.IdSubgrupo = Convert.ToInt32((txtIdSubGrupo.Text == "") ? 0 : Convert.ToInt32(txtIdSubGrupo.Text));

                infoSubGrupo.cod_subgrupo = txtCodSubGrupo.Text;
                infoSubGrupo.nom_subgrupo= txtDescripcion.Text;
                infoSubGrupo.abreviatura = txtAbreviatura.Text;
                infoSubGrupo.observacion = "";

                infoSubGrupo.IdCategoria = Convert.ToString(cmbCategoria.EditValue);
                infoSubGrupo.IdLinea = Convert.ToInt32(cmbLinea.EditValue);
                infoSubGrupo.IdGrupo = Convert.ToInt32(cmbGrupo.EditValue);

                infoSubGrupo.IdUsuario = param.IdUsuario;
                infoSubGrupo.Fecha_Transac = param.Fecha_Transac;
                infoSubGrupo.nom_pc = param.nom_pc;
                infoSubGrupo.ip = param.ip;

                infoSubGrupo.IdCtaCtble_Inve = ucmb_CtaCbleInven.get_PlanCtaInfo() == null ? null : ucmb_CtaCbleInven.get_PlanCtaInfo().IdCtaCble;
                infoSubGrupo.IdCtaCtble_Costo = ucmb_CtaCbleCostos.get_PlanCtaInfo() == null ? null : ucmb_CtaCbleCostos.get_PlanCtaInfo().IdCtaCble;
                infoSubGrupo.IdCtaCtble_Gasto_x_cxp = ucmb_CtaCbleGastos.get_PlanCtaInfo() == null ? null : ucmb_CtaCbleGastos.get_PlanCtaInfo().IdCtaCble;

                infoSubGrupo.IdCentro_Costo_Inv = null;// String.IsNullOrEmpty(ucmb_CentroCostoInven.get_item()) ? null : ucmb_CentroCostoInven.get_item();
                infoSubGrupo.IdCentro_Costo_Cost = null;// String.IsNullOrEmpty(ucmb_CentroCosto_Costos.get_item()) ? null : ucmb_CentroCosto_Costos.get_item();
                infoSubGrupo.IdCentro_Costo_x_Gasto_x_cxp = null;// String.IsNullOrEmpty(ucmb_CentroCostoGastos.get_item()) ? null : ucmb_CentroCostoGastos.get_item();

                infoSubGrupo.IdCentroCosto_sub_centro_costo_inv = null;//String.IsNullOrEmpty(ucmb_SubCentroCostoInven.get_item()) ? null : ucmb_SubCentroCostoInven.get_item();
                infoSubGrupo.IdCentroCosto_sub_centro_costo_cost = null;//String.IsNullOrEmpty(ucmb_SubCentroCosto_Costos.get_item()) ? null : ucmb_SubCentroCosto_Costos.get_item();
                infoSubGrupo.IdCentroCosto_sub_centro_costo_cxp = null;//String.IsNullOrEmpty(ucmb_SubCentroCostoGastos.get_item()) ? null : ucmb_SubCentroCostoGastos.get_item();
                
                infoSubGrupo.IdCtaCble_Vta = ucCon_PlanCta_Venta.get_PlanCtaInfo() == null ? null : ucCon_PlanCta_Venta.get_PlanCtaInfo().IdCtaCble;
                infoSubGrupo.IdCtaCble_CosBaseIva = ucCon_PlanCta_CostoBaseIva.get_PlanCtaInfo() == null ? null : ucCon_PlanCta_CostoBaseIva.get_PlanCtaInfo().IdCtaCble;
                infoSubGrupo.IdCtaCble_CosBase0 = ucCon_PlanCta_CostoBase0.get_PlanCtaInfo() == null ? null : ucCon_PlanCta_CostoBase0.get_PlanCtaInfo().IdCtaCble;
                infoSubGrupo.IdCtaCble_VenIva = ucCon_PlanCta_VentaIva.get_PlanCtaInfo() == null ? null : ucCon_PlanCta_VentaIva.get_PlanCtaInfo().IdCtaCble;
                infoSubGrupo.IdCtaCble_Ven0 = ucCon_PlanCta_Venta0.get_PlanCtaInfo() == null ? null : ucCon_PlanCta_Venta0.get_PlanCtaInfo().IdCtaCble;
                infoSubGrupo.IdCtaCble_DesIva = ucCon_PlanCta_DescIva.get_PlanCtaInfo() == null ? null : ucCon_PlanCta_DescIva.get_PlanCtaInfo().IdCtaCble;
                infoSubGrupo.IdCtaCble_Des0 = ucCon_PlanCta_Desc0.get_PlanCtaInfo() == null ? null : ucCon_PlanCta_Desc0.get_PlanCtaInfo().IdCtaCble;
                infoSubGrupo.IdCtaCble_DevIva = ucCon_PlanCta_DevIva.get_PlanCtaInfo() == null ? null : ucCon_PlanCta_DevIva.get_PlanCtaInfo().IdCtaCble;
                infoSubGrupo.IdCtaCble_Dev0 = ucCon_PlanCta_Dev0.get_PlanCtaInfo() == null ? null : ucCon_PlanCta_Dev0.get_PlanCtaInfo().IdCtaCble;
                
            }
            catch (Exception ex)
            {
                
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        
        }

        void SetSubGrupo()
        {
            try
            {
                txtIdSubGrupo.Text = _SetInfo.IdSubgrupo.ToString();
                txtCodSubGrupo.Text = _SetInfo.cod_subgrupo;
                txtDescripcion.Text = _SetInfo.nom_subgrupo;
                txtAbreviatura.Text = _SetInfo.abreviatura;
                //txtObservacion.Text = _SetInfo.observacion;

                cmbCategoria.EditValue = _SetInfo.IdCategoria;
                cmbLinea.EditValue = _SetInfo.IdLinea;
                cmbGrupo.EditValue = _SetInfo.IdGrupo;

                if (_SetInfo.Estado.TrimEnd() == "I")
                {
                    this.checkActivo.Checked = false;
                    lblAnulado.Visible = true;
                }
                else
                {
                    checkActivo.Checked = true;
                }

               ucmb_CtaCbleInven.set_PlanCtarInfo(_SetInfo.IdCtaCtble_Inve);
               ucmb_CtaCbleCostos.set_PlanCtarInfo(_SetInfo.IdCtaCtble_Costo);
               ucmb_CtaCbleGastos.set_PlanCtarInfo(_SetInfo.IdCtaCtble_Gasto_x_cxp);

               //ucmb_CentroCostoInven.set_item(_SetInfo.IdCentro_Costo_Inv);
               //ucmb_CentroCosto_Costos.set_item(_SetInfo.IdCentro_Costo_Cost);
               //ucmb_CentroCostoGastos.set_item(_SetInfo.IdCentro_Costo_x_Gasto_x_cxp);

               //ucmb_SubCentroCostoInven.set_item(_SetInfo.IdCentroCosto_sub_centro_costo_inv);
               //ucmb_SubCentroCosto_Costos.set_item(_SetInfo.IdCentroCosto_sub_centro_costo_cost);
               //ucmb_SubCentroCostoGastos.set_item(_SetInfo.IdCentroCosto_sub_centro_costo_cxp);

               ucCon_PlanCta_Venta.set_PlanCtarInfo(_SetInfo.IdCtaCble_Vta);
               ucCon_PlanCta_CostoBaseIva.set_PlanCtarInfo(_SetInfo.IdCtaCble_CosBaseIva);
               ucCon_PlanCta_CostoBase0.set_PlanCtarInfo(_SetInfo.IdCtaCble_CosBase0);
               ucCon_PlanCta_VentaIva.set_PlanCtarInfo(_SetInfo.IdCtaCble_VenIva);
               ucCon_PlanCta_Venta0.set_PlanCtarInfo(_SetInfo.IdCtaCble_Ven0);
               ucCon_PlanCta_DescIva.set_PlanCtarInfo(_SetInfo.IdCtaCble_DesIva);
               ucCon_PlanCta_Desc0.set_PlanCtarInfo(_SetInfo.IdCtaCble_Des0);
               ucCon_PlanCta_DevIva.set_PlanCtarInfo(_SetInfo.IdCtaCble_DevIva);
               ucCon_PlanCta_Dev0.set_PlanCtarInfo(_SetInfo.IdCtaCble_Dev0);
                                                                              
            }
            catch (Exception ex)
            {
                
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }                      
        }

        Boolean grabar()
        {
            Boolean res = false;
            try
            {
                txtIdSubGrupo.Focus();
                GetSubGrupo();

                switch (enu)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        res = Guardar();
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        res=Actualizar();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        break;
                    default:
                        break;
                }
                return res;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return res;
            }
        }

        Boolean Guardar()
        {
            try
            {
                Boolean res = false;


                string mensajeRecurso = "";
                res=bus_subGrupo.GrabarDB(infoSubGrupo, ref IdSubGrupo, ref mensaje);
                if (res)
                {
                    mensajeRecurso = Core.Erp.Recursos.Properties.Resources.msgConfirmaGrabarOk;
                    MessageBox.Show(mensajeRecurso, param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Information);
                    txtIdSubGrupo.Text = IdSubGrupo.ToString();
                    this.checkActivo.Checked = true;
                    LimpiarDatos();
                }
                else
                {
                    mensajeRecurso = Core.Erp.Recursos.Properties.Resources.msgError_Grabar;
                    MessageBox.Show(mensajeRecurso +"\n"+ mensaje , param.Nombre_sistema);

                }

                return res;

            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        Boolean Actualizar()
        {
            try
            {
                Boolean res = false;

                infoSubGrupo.IdUsuarioUltMod = param.IdUsuario;
                infoSubGrupo.Fecha_UltMod = param.Fecha_Transac;
                string mensajeRecurso = "";
                res=bus_subGrupo.ModificarDB(infoSubGrupo, ref mensaje);
                if (res)
                {
                    mensajeRecurso = Core.Erp.Recursos.Properties.Resources.msgConfirmaGrabarOk;
                    MessageBox.Show(mensajeRecurso, param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Information);
                    LimpiarDatos();
                }
                else
                {
                    mensajeRecurso = Core.Erp.Recursos.Properties.Resources.msgError_Modificar;
                    MessageBox.Show(mensajeRecurso+"\n"+mensaje, param.Nombre_sistema);
                }
                return res;
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        Boolean Anular()
        {
            try
            {
                Boolean res = false;
                GetSubGrupo();
                
                infoSubGrupo.IdUsuarioUltAnu = param.IdUsuario;
                infoSubGrupo.Fecha_UltAnu = param.Fecha_Transac;

                string mensajeRecurso = "";
                res=bus_subGrupo.AnularDB(infoSubGrupo, ref mensaje);
                if (res)
                {
                    mensajeRecurso = Core.Erp.Recursos.Properties.Resources.msgConfirmaAnulacionOk;
                    MessageBox.Show(mensajeRecurso, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblAnulado.Visible = true;
                    ucGe_Menu.Visible_bntAnular = false;
                }
                else
                {
                    mensajeRecurso = Core.Erp.Recursos.Properties.Resources.msgError_Anular;
                    MessageBox.Show(mensajeRecurso + "\n" + mensaje, param.Nombre_sistema);
                }
                return res;
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void FrmIn_SubGrupo_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                Carga_Combo();

                switch (enu)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:

                        txtIdSubGrupo.Focus();

                        txtIdSubGrupo.Enabled = false;
                        txtIdSubGrupo.BackColor = System.Drawing.Color.White;
                        txtIdSubGrupo.ForeColor = System.Drawing.Color.Black;

                        ucGe_Menu.Visible_bntAnular = false;

                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:

                        ucGe_Menu.Visible_bntAnular = false;

                        txtIdSubGrupo.Enabled = false;
                        txtIdSubGrupo.BackColor = System.Drawing.Color.White;
                        txtIdSubGrupo.ForeColor = System.Drawing.Color.Black;

                        cmbCategoria.Enabled = false;
                        cmbCategoria.BackColor = System.Drawing.Color.White;
                        cmbCategoria.ForeColor = System.Drawing.Color.Black;

                        cmbLinea.Enabled = false;
                        cmbLinea.BackColor = System.Drawing.Color.White;
                        cmbLinea.ForeColor = System.Drawing.Color.Black;

                        cmbGrupo.Enabled = false;
                        cmbGrupo.BackColor = System.Drawing.Color.White;
                        cmbGrupo.ForeColor = System.Drawing.Color.Black;

                        checkActivo.Enabled = false;

                        SetSubGrupo();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;

                        Inhabilita_Campos();

                        SetSubGrupo();
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:

                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        ucGe_Menu.Visible_bntAnular = false;

                        Inhabilita_Campos();

                        SetSubGrupo();
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

        void Inhabilita_Campos()
        {
            try
            {
                txtIdSubGrupo.Enabled = false;
                txtIdSubGrupo.BackColor = System.Drawing.Color.White;
                txtIdSubGrupo.ForeColor = System.Drawing.Color.Black;

                cmbCategoria.Enabled = false;
                cmbCategoria.BackColor = System.Drawing.Color.White;
                cmbCategoria.ForeColor = System.Drawing.Color.Black;

                cmbLinea.Enabled = false;
                cmbLinea.BackColor = System.Drawing.Color.White;
                cmbLinea.ForeColor = System.Drawing.Color.Black;

                cmbGrupo.Enabled = false;
                cmbGrupo.BackColor = System.Drawing.Color.White;
                cmbGrupo.ForeColor = System.Drawing.Color.Black;

                txtCodSubGrupo.Enabled = false;
                txtCodSubGrupo.BackColor = System.Drawing.Color.White;
                txtCodSubGrupo.ForeColor = System.Drawing.Color.Black;

                txtDescripcion.Enabled = false;
                txtDescripcion.BackColor = System.Drawing.Color.White;
                txtDescripcion.ForeColor = System.Drawing.Color.Black;

                txtAbreviatura.Enabled = false;
                txtAbreviatura.BackColor = System.Drawing.Color.White;
                txtAbreviatura.ForeColor = System.Drawing.Color.Black;

                

                checkActivo.Enabled = false;

            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbCategoria_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                listlinea = bus_Linea.Get_List_Linea(param.IdEmpresa, Convert.ToString(cmbCategoria.EditValue));
                cmbLinea.Properties.DataSource = listlinea;
                cmbLinea.Properties.DisplayMember = "nom_linea";
                cmbLinea.Properties.ValueMember = "IdLinea";
            }
            catch (Exception ex)
            {
                
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbLinea_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                listGrupo = bus_Grupo.Get_List_Grupo(param.IdEmpresa, Convert.ToString(cmbCategoria.EditValue),Convert.ToInt32(cmbLinea.EditValue));
                cmbGrupo.Properties.DataSource = listGrupo;
                cmbGrupo.Properties.DisplayMember = "nom_grupo";
                cmbGrupo.Properties.ValueMember = "IdGrupo";
            }
            catch (Exception ex)
            {
                
               Log_Error_bus.Log_Error(ex.ToString());
               MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmIn_SubGrupo_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            Event_FrmIn_SubGrupo_Mant_FormClosing(sender, e);
        }

        private void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                grabar();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (grabar())
                { Close(); }
                
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                Anular();
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucmb_SubCentroCostoGastos_Load(object sender, EventArgs e)
        {

        }

        private void groupControl4_Paint(object sender, PaintEventArgs e)
        {

        }


        void LimpiarDatos()
        {
            try
            {
                enu = Cl_Enumeradores.eTipo_action.grabar;
                infoSubGrupo = new in_subgrupo_info();
                txtIdSubGrupo.Text = "";
                txtCodSubGrupo.Text = "";
                txtAbreviatura.Text = "";
                cmbCategoria.EditValue = null;
                cmbLinea.EditValue = null;
                cmbGrupo.EditValue = null;
                txtDescripcion.Text = "";               
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
