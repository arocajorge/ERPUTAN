using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.General;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Business.CuentasxPagar;
using Core.Erp.Business.General;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Info.Contabilidad;
 
namespace Core.Erp.Winform.Controles
{
    
    public partial class UCCp_Mant_codigo_SRI : UserControl
    {
        #region Variables
        public List<ct_Plancta_Info> listaPlan = new List<ct_Plancta_Info>();
        ct_Plancta_Bus _PlanCta_bus1 = new ct_Plancta_Bus();
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        string MensajeError = "";
        UCCp_Tipo_codigo_SRI UCTC = new UCCp_Tipo_codigo_SRI();
        cp_codigo_SRI_Info codSRI_inf = new cp_codigo_SRI_Info();
        private Cl_Enumeradores.eTipo_action _Accion;
        cp_codigo_SRI_tipo_Info tipoCodSRI = new cp_codigo_SRI_tipo_Info();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        List<ct_Plancta_Info> lmCuenta = new List<ct_Plancta_Info>();
        List<tb_Empresa_Info> listaEmp;
        BindingList<tb_Empresa_Info> ListaBind = new BindingList<tb_Empresa_Info>();
        #endregion

        public UCCp_Mant_codigo_SRI()
        {
            try
            {
                InitializeComponent();
                load_tipo_plan_cta();
                cargar_Combo();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void Grabar()
        {

            try
            {
                int codigoSRI = Convert.ToInt32(txt_id.Text);
                txt_descripcion.Focus();
                List<cp_codigo_SRI_x_CtaCble_Info> lista = getGrid();
                if (lista == null)
                { MessageBox.Show("Una de las Cuentas no la ingresó Correctamente");
                    return; 
                }
                if( dtp_valiDesde.Value>  dtp_valiHasta.Value){
                  MessageBox.Show("La fecha Válido Desde no debe ser mayor a la fecha Válido Hasta","Datos erróneos");
                  return;
                }
                if(txt_descripcion.Text=="")
                {
                    MessageBox.Show("Descripción sin dato..", "Favor ingrese dato");
                    return;
                }

                if (txt_cod_SRI.Text == "")
                {
                    MessageBox.Show("Código SRI sin dato..", "Favor ingrese dato");
                    return;
                }


                 tipoCodSRI = UCTC.get_Dato();
                 get_Info();
 
              int id=0;

                cp_codigo_SRI_Bus codSRI_Bus = new cp_codigo_SRI_Bus();


                if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    codSRI_inf.IdUsuario = param.IdUsuario;
                    codSRI_inf.Fecha_Transac = param.Fecha_Transac;
                    codSRI_inf.nom_pc = param.nom_pc;
                    codSRI_inf.ip = param.ip;
    
                    if (codSRI_Bus.GrabarDB(codSRI_inf, ref id))
                    {
                        txt_id.Text = id.ToString();
                        codigoSRI = id;
                        MessageBox.Show("Grabado Exitosamente ok","Operación Exitosa");
                        this.Parent.Parent.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Error al Grabar", "Operación Fallida");
                    }
                }

                if (_Accion == Cl_Enumeradores.eTipo_action.actualizar)
                {
                    codSRI_inf.IdUsuarioUltMod = param.IdUsuario;
                    codSRI_inf.Fecha_UltMod  = param.Fecha_Transac;

                    if(codSRI_Bus.ModificarDB(codSRI_inf))
                    {
                        MessageBox.Show("Actualizado Exitosamente ok", "Operación Exitosa");
                        this.Parent.Parent.Dispose();

                    }
                    else
                    {
                        MessageBox.Show("Error al Actualizar", "Operación Fallida");
                    }
                }


                if (_Accion == Cl_Enumeradores.eTipo_action.Anular)
                {
                    codSRI_inf.IdUsuarioUltAnu = param.IdUsuario;
                    codSRI_inf.Fecha_UltAnu = param.Fecha_Transac;

                    if(codSRI_Bus.AnularDB(codSRI_inf))
                    {
                        MessageBox.Show("Anulado Exitosamente ok", "Operación Exitosa");
                        this.Parent.Parent.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Error al Anular", "Operación Fallida");
                    }
                }

                codSRI_Bus.ModificarDB(lista, Convert.ToInt32(codigoSRI));
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void load_tipo_plan_cta()
        {
            try
            {
                listaPlan = _PlanCta_bus1.Get_List_Plancta_x_ctas_Movimiento(param.IdEmpresa, ref MensajeError);
               
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void cargar_Combo()
        {
            try
            {

                cp_codigo_SRI_tipo_Bus CatBus = new cp_codigo_SRI_tipo_Bus();
                List<cp_codigo_SRI_tipo_Info> tipo_Codigo_SRI = new List<cp_codigo_SRI_tipo_Info>();


                tipo_Codigo_SRI = CatBus.Get_List_codigo_SRI_tipo();

                this.cmb_tipCodSRI.DataSource = tipo_Codigo_SRI;
                this.cmb_tipCodSRI.DisplayMember = "descripcion";
                this.cmb_tipCodSRI.ValueMember = "IdTipoSRI";
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }


        TextBox txt_retencion = new TextBox();

        public void set_accion(Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {
                _Accion = Accion;


                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        chk_estado.Enabled = false;
                        chk_estado.Checked = true;
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        txt_cod_base.Enabled = false;
                        txt_cod_SRI.Enabled = false;
                        txt_descripcion.Enabled = false;
                        txt_retencion.Enabled = false;
                        chk_estado.Enabled = false;
                        dtp_valiDesde.Enabled = false;
                        dtp_valiHasta.Enabled = false;
                        cmb_tipCodSRI.Enabled = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        txt_cod_base.Enabled = false;
                        txt_cod_SRI.Enabled = false;
                        txt_descripcion.Enabled = false;
                        txt_retencion.Enabled = false;
                        chk_estado.Enabled = false;
                        dtp_valiDesde.Enabled = false;
                        dtp_valiHasta.Enabled = false;
                        cmb_tipCodSRI.Enabled = false;

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

        public void set_Info(cp_codigo_SRI_Info  info)
        {
            try
            {
                   txt_id.Text = info.IdCodigo_SRI.ToString();
                   txt_cod_base.Text=info.co_codigoBase.Trim();
                   txt_cod_SRI.Text = info.codigoSRI.Trim();
                   txt_descripcion.Text = info.co_descripcion.Trim();
                   txt_retencion.Text = info.co_porRetencion.ToString();
                   dtp_valiDesde.Value = info.co_f_vigente_desde;
                   dtp_valiHasta.Value = info.co_f_vigente_hasta;
                 //  cmb_ctacbleCxp.EditValue= Convert.ToString(info.IdCtaCble) ;
                   if (info.co_estado == "I")
                   {
                       lblAnulado.Visible = true;
                   }
                   else { lblAnulado.Visible = false; }
                              
                   cmb_tipCodSRI.SelectedValue   = info.IdTipoSRI;
               
                   chk_estado.Checked = (info.co_estado == "A") ? true : false;
                 //  this.UCTC.set_Tipo(info.id_codigo_tipo.Trim());

                codSRI_inf = info;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }             
        }

        public cp_codigo_SRI_Info get_Info()
        {

            try
            {

                tipoCodSRI = UCTC.get_Dato();

                codSRI_inf.co_codigoBase = txt_cod_base.Text.Trim();
                codSRI_inf.co_descripcion = txt_descripcion.Text.Trim();
                codSRI_inf.co_estado = (chk_estado.Checked == true) ? "A" : "I";
                codSRI_inf.co_f_vigente_desde= dtp_valiDesde.Value;
                codSRI_inf.co_f_vigente_hasta=dtp_valiHasta.Value;
                codSRI_inf.co_porRetencion = Convert.ToDouble(txt_retencion.Text);
                codSRI_inf.codigoSRI = txt_cod_SRI.Text;
                codSRI_inf.IdCodigo_SRI = Convert.ToInt16(txt_id.Text);
                codSRI_inf.IdTipoSRI = cmb_tipCodSRI.SelectedValue.ToString();
                    //tipoCodSRI.codigo;
               // codSRI_inf.IdCtaCble = Convert.ToString(cmb_ctacbleCxp.EditValue);
        
                return codSRI_inf;

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new cp_codigo_SRI_Info();
            }

        }
       
        private void txt_descripcion_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (txt_descripcion.Text == "")
                {

                    errorP.SetError(txt_descripcion, "Campo Obligatorio");
                }
                else
                {
                    errorP.Clear();
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
         
        }

        private void txt_cod_SRI_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (txt_cod_SRI.Text == "")
                {
                    errorP.SetError(txt_cod_SRI, "Campo Obligatorio");
                }
                else
                {
                    errorP.Clear();
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void txt_retencion_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Funciones val = new Funciones();
                e.Handled = val.Validanumero_decimal(e.KeyChar);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
           
        }

        private void dtp_valiDesde_Validating(object sender, CancelEventArgs e)
        {
            try
            {
            if (dtp_valiDesde.Value > dtp_valiHasta.Value)
                {
                    MessageBox.Show("La fecha Válido Desde no debe ser mayor a la fecha Válido Hasta", "Datos erróneos");
                    dtp_valiDesde.Focus();
                    return;
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
           
        }

        private void dtp_valiHasta_Validating(object sender, CancelEventArgs e)
        {
            try
            {
            if (dtp_valiDesde.Value > dtp_valiHasta.Value)
                {
                    MessageBox.Show("La fecha Válido Hasta no debe ser Menor a la fecha Válido Desde", "Datos erróneos");
                    dtp_valiHasta.Focus();
                    return;
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
            
        }

        private void cmb_ctacbleCxp_Validating(object sender, CancelEventArgs e)
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

        private void UCCp_Mant_codigo_SRI_Load(object sender, EventArgs e)
        {
            try
            {
               
                
                tb_Empresa_Bus busemp = new tb_Empresa_Bus();
                listaEmp = new List<tb_Empresa_Info>();
                listaEmp = busemp.Get_List_Empresa();


              //  List<cp_codigo_SRI_x_CtaCble_Info> ObtenerLista()

                cp_codigo_SRI_x_CtaCble_Bus bus_SRI_cta = new cp_codigo_SRI_x_CtaCble_Bus();
                List<cp_codigo_SRI_x_CtaCble_Info> lista_SRI_cta = new List<cp_codigo_SRI_x_CtaCble_Info>();
                lista_SRI_cta = bus_SRI_cta.Get_codigo_SRI_x_CtaCble();



                ListaBind = new BindingList<tb_Empresa_Info>(listaEmp);

                //gridControlSRI.DataSource = ListaBind;

                if (_Accion == Cl_Enumeradores.eTipo_action.actualizar || _Accion == Cl_Enumeradores.eTipo_action.consultar || _Accion == Cl_Enumeradores.eTipo_action.Anular)
                {
                    foreach (var item in ListaBind)
                    {
                        var item2 = lista_SRI_cta.FirstOrDefault(q=>q.IdEmpresa==item.IdEmpresa && q.idCodigo_SRI==codSRI_inf.IdCodigo_SRI);
                        if (item2 !=null)
                        {
                            item.IdCtaCble = item2.IdCtaCble.Trim();
                            item.nomCuenta = "[" + item2.IdCtaCble.Trim() + "] - " + item2.pc_Cuenta.Trim();
                        }                                             
                    }

                }

                //gridControlSRI.DataSource = ListaBind;


                                                     
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
       
        public List<cp_codigo_SRI_x_CtaCble_Info> getGrid()
        {
            try
            {
                int i = 0;
                List<cp_codigo_SRI_x_CtaCble_Info> lista = new List<cp_codigo_SRI_x_CtaCble_Info>();

                foreach (var item in ListaBind)
                {
                     cp_codigo_SRI_x_CtaCble_Info info = new cp_codigo_SRI_x_CtaCble_Info();
                    var con = from c in listaEmp
                              where c.IdEmpresa == item.IdEmpresa
                              select c;
                    foreach (var item2 in con)
                    {
                        info.IdEmpresa = item2.IdEmpresa;
                    }
                    info.IdCtaCble = Convert.ToString(item.IdCtaCble);
                    info.idCodigo_SRI = Convert.ToInt32(txt_id.Text);
                    info.idUsuario = param.IdUsuario;
                    info.fecha_UltMod = param.Fecha_Transac;
                    info.nom_pc = param.nom_pc;
                    info.ip = param.ip;
                    lista.Add(info);
                }
                                                        
                return lista;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new List<cp_codigo_SRI_x_CtaCble_Info>();
            }
        
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}