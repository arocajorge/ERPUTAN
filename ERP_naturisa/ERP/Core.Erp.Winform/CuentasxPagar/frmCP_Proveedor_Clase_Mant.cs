using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Business.CuentasxPagar;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Winform.General;

namespace Core.Erp.Winform.CuentasxPagar
{
    public partial class frmCP_Proveedor_Clase_Mant : Form
    {
        #region Variables
         string MensajeError = "";
        public cp_proveedor_clase_Info InfoProveedor_clase { get; set; }

        public Cl_Enumeradores.eTipo_action Accion { get; set; }
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        public delegate void delegate_frmCP_Proveedor_Clase_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmCP_Proveedor_Clase_Mant_FormClosing event_frmCP_Proveedor_Clase_Mant_FormClosing;
        ct_Plancta_Bus Bus_Plancta = new ct_Plancta_Bus();
        ct_Centro_costo_Bus Bus_centro_costo = new ct_Centro_costo_Bus();
        ct_centro_costo_sub_centro_costo_Bus Bus_sub_centro_costo = new ct_centro_costo_sub_centro_costo_Bus();
   
        List<ct_centro_costo_sub_centro_costo_Info> listSubCentroCosto = new List<ct_centro_costo_sub_centro_costo_Info>();
        cp_proveedor_clase_Bus Bus_Prove_clase = new cp_proveedor_clase_Bus();
        #endregion

        public frmCP_Proveedor_Clase_Mant()
        {
            InitializeComponent();
            ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
            ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
            ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
            ucGe_Menu.event_btnAnular_Click += ucGe_Menu_event_btnAnular_Click;
            ucGe_Menu.event_btnlimpiar_Click += ucGe_Menu_event_btnlimpiar_Click;


            ucCon_CentroCosto_ctas_Movi1.Event_cmbCentroCosto_EditValueChanged += ucCon_CentroCosto_ctas_Movi1_Event_cmbCentroCosto_EditValueChanged;
            
        }

        void ucCon_CentroCosto_ctas_Movi1_Event_cmbCentroCosto_EditValueChanged(object sender, EventArgs e)
        {
            try
           {
                string IdCentroCosto = "";

             
                IdCentroCosto = ucCon_CentroCosto_ctas_Movi1.get_item();
                listSubCentroCosto = Bus_sub_centro_costo.Get_list_centro_costo_sub_centro_costo(param.IdEmpresa, IdCentroCosto);

                if (listSubCentroCosto.Count !=0)
                {
                    cmb_sub_centro_costo.Properties.DataSource = listSubCentroCosto;
                    cmb_sub_centro_costo.EditValue = listSubCentroCosto.First().IdCentroCosto_sub_centro_costo;
                }
                

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
                limpiar();
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
                if (Anular())
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
                if (validar())
                {
                    if(grabar())
                        this.Close();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }     
        }

        private Boolean validar()
        {
            try
            {
                Boolean res = true;


                if (txtdescripcion.Text == "")
                {
                    MessageBox.Show("Debe ingresar el nombre de la clase de proveedor ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    res = false;
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

        void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (validar())
                {
                    if (grabar())
                        limpiar();
                }
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

        public Boolean Guardar()
        {
            bool resultado = false;
            try
            {
                InfoProveedor_clase.FechaTransac = param.Fecha_Transac;
                InfoProveedor_clase.IdUsuario = param.IdUsuario;
                int Id=0;
                if (Bus_Prove_clase.GuardarDB(InfoProveedor_clase, ref Id,ref MensajeError))
                {
                    string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Grabar, "La Clase de Proveedor", InfoProveedor_clase.IdClaseProveedor);
                    MessageBox.Show(smensaje, param.Nombre_sistema); 
                    txtId.Text = InfoProveedor_clase.IdClaseProveedor.ToString();
                    //ucGe_Menu.Visible_btnGuardar = false;
                    //ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                    limpiar();
                    resultado = true;
                }
                else
                {
                    MessageBox.Show(MensajeError, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    resultado = false;
                }
                return resultado;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        public Boolean Anular()
        {
            bool resultado = false;
            try
            {
                if (InfoProveedor_clase != null)
                {
                    FrmGe_MotivoAnulacion oFrm = new FrmGe_MotivoAnulacion();
                    if (InfoProveedor_clase.Estado == "A")
                    {
                        if (MessageBox.Show("¿Está seguro que desea anular el registro #: " + InfoProveedor_clase.IdClaseProveedor + " ?", "Anulación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            string msg = "";
                            oFrm.ShowDialog();
                            InfoProveedor_clase.MotivoAnu = oFrm.motivoAnulacion;
                            InfoProveedor_clase.FechaAnu = param.Fecha_Transac;
                            InfoProveedor_clase.IdUsuarioAnu = param.IdUsuario;
                            if (Bus_Prove_clase.AnularDB(InfoProveedor_clase, ref msg))
                            {
                                string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Anular, "La Clase de Proveedor", InfoProveedor_clase.IdClaseProveedor);
                                MessageBox.Show(smensaje, param.Nombre_sistema);
                                InfoProveedor_clase.Estado = "I";
                                lblanulado.Visible = true;
                                Accion = Cl_Enumeradores.eTipo_action.consultar;
                                resultado = true;
                            }
                            else
                                resultado = false;
                        }
                        else
                            resultado = false;
                    }
                    else if (InfoProveedor_clase.Estado == "I")
                    {
                        MessageBox.Show("No se puede anular el registro N#: " + InfoProveedor_clase.IdClaseProveedor +
                             ", ya se encuentra anulado", "Anulación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        resultado = false;
                    }
                    return resultado;
                }
                return resultado;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


        }

        public Boolean Actualizar()
        {
            bool resultado = false;
            try
            {
                InfoProveedor_clase.FechaTransac = param.Fecha_Transac;
                InfoProveedor_clase.IdUsuario = param.IdUsuario;


                if (Bus_Prove_clase.ModificarDB(InfoProveedor_clase, ref  MensajeError))
                {     
                    string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Modificar, "La Clase de Proveedor", InfoProveedor_clase.IdClaseProveedor);
                    MessageBox.Show(smensaje, param.Nombre_sistema);
                    //ucGe_Menu.Visible_btnGuardar = false;
                    //ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                    limpiar();
                    resultado = true;
                }
                else
                {
                    MessageBox.Show(MensajeError, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    resultado = false;
                }
                return resultado;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public Boolean grabar()
        {
            try
            {
                txtId.Focus();
                get_Info();

                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        if (Guardar())
                            return true;
                        else
                            return false;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        if (Actualizar())
                            return true;
                        else
                            return false;
                    default:
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

        private void limpiar()
        {
            try
            {
                Accion = Cl_Enumeradores.eTipo_action.grabar;
                InfoProveedor_clase = new cp_proveedor_clase_Info();
                txtId.Text = "0";
                txtcodigo.Text = "";
                txtdescripcion.Text = "";

                chkEstado.Checked = true;

                ucCon_CentroCosto_ctas_Movi1.Inicializar_cmbCentroCosto();

                cmb_ctacble_anticipo.Inicializar_cmbPlanCta();
                cmb_ctacble_gastos.Inicializar_cmbPlanCta();
                cmb_sub_centro_costo.EditValue = "";

                cmb_CtaCble_CXP.Inicializar_cmbPlanCta();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void set_accion()
        {

            try
            {

                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        this.txtId.Enabled = false;
                        this.txtId.BackColor = System.Drawing.Color.White;
                        this.txtId.ForeColor = System.Drawing.Color.Black;
                       limpiar();
                       ucGe_Menu.Visible_bntAnular = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:

                        ucGe_Menu.Visible_bntGuardar_y_Salir = true;
                        ucGe_Menu.Visible_bntAnular = false;
                        ucGe_Menu.Visible_btnGuardar = true;


                        this.txtId.Enabled = false;
                        this.txtId.BackColor = System.Drawing.Color.White;
                        this.txtId.ForeColor = System.Drawing.Color.Black;


                        set_info();

                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:

                        ucGe_Menu.Enabled_bntLimpiar = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;

                        this.txtId.Enabled = false;
                        this.txtId.BackColor = System.Drawing.Color.White;
                        this.txtId.ForeColor = System.Drawing.Color.Black;

                        set_info();

                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:

                        ucGe_Menu.Visible_bntLimpiar = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_bntAnular = false;


                        this.txtId.Enabled = false;
                        this.txtId.BackColor = System.Drawing.Color.White;
                        this.txtId.ForeColor = System.Drawing.Color.Black;


                        set_info();
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

        private void frmCP_Proveedor_Clase_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                set_accion();               
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void frmCP_Proveedor_Clase_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                event_frmCP_Proveedor_Clase_Mant_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }

      

        private void get_Info()
        {

            try
            {
                InfoProveedor_clase = new cp_proveedor_clase_Info();

                InfoProveedor_clase.IdEmpresa = param.IdEmpresa;

                InfoProveedor_clase.IdClaseProveedor =Convert.ToInt32(txtId.Text);
                InfoProveedor_clase.descripcion_clas_prove = txtdescripcion.Text;
                InfoProveedor_clase.cod_clase_proveedor = txtcodigo.Text;
                InfoProveedor_clase.Estado= (chkEstado.Checked==true)?"A":"I";

                InfoProveedor_clase.IdCtaCble_Anticipo = String.IsNullOrEmpty(cmb_ctacble_anticipo.get_PlanCtaInfo().IdCtaCble)? null:Convert.ToString(cmb_ctacble_anticipo.get_PlanCtaInfo().IdCtaCble).Trim();
                InfoProveedor_clase.IdCtaCble_gasto = String.IsNullOrEmpty(cmb_ctacble_gastos.get_PlanCtaInfo().IdCtaCble) ?null: Convert.ToString(cmb_ctacble_gastos.get_PlanCtaInfo().IdCtaCble).Trim();


                InfoProveedor_clase.IdCentroCosto = String.IsNullOrEmpty(ucCon_CentroCosto_ctas_Movi1.get_item()) ? null : ucCon_CentroCosto_ctas_Movi1.get_item();


                InfoProveedor_clase.IdCentroCosto_sub_centro_costo = String.IsNullOrEmpty(Convert.ToString(cmb_sub_centro_costo.EditValue)) ? null : Convert.ToString(cmb_sub_centro_costo.EditValue).Trim();

                InfoProveedor_clase.IdCtaCble_CXP = String.IsNullOrEmpty(cmb_CtaCble_CXP.get_PlanCtaInfo().IdCtaCble) ? null : Convert.ToString(cmb_CtaCble_CXP.get_PlanCtaInfo().IdCtaCble).Trim();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
            }
        
        }

        private void set_info()
        {

            try
            {
              
                txtId.Text = InfoProveedor_clase.IdClaseProveedor.ToString();
                txtcodigo.Text = InfoProveedor_clase.cod_clase_proveedor.ToString();
                txtdescripcion.Text = InfoProveedor_clase.descripcion_clas_prove;             

                if (InfoProveedor_clase.Estado.Trim() == "I")
                {
                    chkEstado.Checked = false;
                    lblanulado.Visible = true;
                }
                else
                {
                    chkEstado.Checked = true;
                    lblanulado.Visible = false;
                }


                cmb_ctacble_anticipo.set_PlanCtarInfo(InfoProveedor_clase.IdCtaCble_Anticipo);
                cmb_ctacble_gastos.set_PlanCtarInfo(InfoProveedor_clase.IdCtaCble_gasto);

             

                ucCon_CentroCosto_ctas_Movi1.set_item(InfoProveedor_clase.IdCentroCosto);


                cmb_sub_centro_costo.EditValue = InfoProveedor_clase.IdCentroCosto_sub_centro_costo;

                cmb_CtaCble_CXP.set_PlanCtarInfo(InfoProveedor_clase.IdCtaCble_CXP);
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());

            }

        }

   

    }
}
