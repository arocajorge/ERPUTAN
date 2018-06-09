using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Info.Roles_Fj;
using Core.Erp.Info.Roles;
using Core.Erp.Business.Roles_Fj;
using Core.Erp.Business.Roles;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Winform.General;
namespace Core.Erp.Winform.Roles_Fj
{
    public partial class frmRo_Grupo_empleado_Mant : Form
    {
        #region varibales
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        ro_Grupo_empleado_Info info_grupo = new ro_Grupo_empleado_Info();
        ro_Grupo_empleado_Bus bus_grupo = new ro_Grupo_empleado_Bus();
        List<ro_parametro_x_pago_variable_tipo_Info> lista_tipo_variable = new List<ro_parametro_x_pago_variable_tipo_Info>();
        ro_parametro_x_pago_variable_tipo_Bus bus_tipo_variable = new ro_parametro_x_pago_variable_tipo_Bus();


        ro_rubro_tipo_Bus bus_rubro = new ro_rubro_tipo_Bus();
        List<ro_rubro_tipo_Info> lista_rubros = new List<ro_rubro_tipo_Info>();



        public Cl_Enumeradores.eTipo_action accion { get; set; }
        BindingList<ro_Grupo_empleado_det_Info> lista_grupo_det = new BindingList<ro_Grupo_empleado_det_Info>();
        ro_Grupo_empleado_det_Bus bus_detalle = new ro_Grupo_empleado_det_Bus();
        public delegate void delegate_frmRo_Grupo_empleado_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmRo_Grupo_empleado_Mant_FormClosing event_frmRo_Grupo_empleado_Mant_FormClosing;
        #endregion

        public frmRo_Grupo_empleado_Mant()
        {
            InitializeComponent();
            event_frmRo_Grupo_empleado_Mant_FormClosing += frmRo_Grupo_empleado_Mant_event_frmRo_Grupo_empleado_Mant_FormClosing;
            Cargar_datos();
        }

        void frmRo_Grupo_empleado_Mant_event_frmRo_Grupo_empleado_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
                
        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }
        
        public void Get()
        {
            try
            {
                info_grupo.detalle = new List<ro_Grupo_empleado_det_Info>();
                info_grupo.IdEmpresa = param.IdEmpresa;
                info_grupo.Nombre_Grupo = txtnombre.Text;
                if(txtId.EditValue!=null)
                info_grupo.IdGrupo =Convert.ToInt32( txtId.EditValue);
                info_grupo.Calculo_Horas_extras_Sobre =Convert.ToInt32( txt_num_calculo_horas_extras.EditValue);
                info_grupo.Max_num_horas_sab_dom = Convert.ToInt32(txt_num_horas_sab_dom.EditValue);
                info_grupo.Valor_Alimen =Convert.ToDouble( txt_Valor_alime.EditValue);
                info_grupo.Valor_Transp =Convert.ToDouble( txt_Valor_trans.EditValue);
                info_grupo.IdRubro_Alim = cmb_rubros_aliment.EditValue.ToString();
                info_grupo.IdRubro_Trans = cmb_rubros_transp.EditValue.ToString();
                if (txt_valor_bono.EditValue != "")
                    info_grupo.Valor_bono = Convert.ToDouble(txt_valor_bono.EditValue);
                else
                    info_grupo.Valor_bono = 0;
                info_grupo.detalle = lista_grupo_det.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        
        public void set(ro_Grupo_empleado_Info info)
        {
            try
            {
                info_grupo = info;
                txtId.EditValue = info.IdGrupo;
                txtnombre.EditValue = info.Nombre_Grupo;
                txt_num_horas_sab_dom.EditValue = info.Max_num_horas_sab_dom;
                txt_num_calculo_horas_extras.EditValue = info.Calculo_Horas_extras_Sobre;
                dtFechaSalida.EditValue = info.Fecha_Transac;
                txt_Valor_trans.EditValue = info.Valor_Transp;
                txt_Valor_alime.EditValue = info.Valor_Alimen;
                cmb_rubros_transp.EditValue = info.IdRubro_Trans;
                cmb_rubros_aliment.EditValue = info.IdRubro_Alim;
                txt_valor_bono.EditValue = info_grupo.Valor_bono;
                lista_grupo_det =new BindingList<ro_Grupo_empleado_det_Info>( bus_detalle.Get_lista(info_grupo.IdEmpresa, info_grupo.IdGrupo));
                gridControl_parametro_Variable.DataSource = lista_grupo_det;
            }
            catch (Exception ex)
            {
                
             MessageBox.Show(ex.ToString());
            }
        }

        public void Cargar_datos()
        {
            try
            {
                lista_rubros = bus_rubro.Get_list_rubros_concepto(param.IdEmpresa);
                cmb_rubros_aliment.Properties.DataSource = lista_rubros;
                cmb_rubros_transp.Properties.DataSource = lista_rubros;


                lista_tipo_variable = bus_tipo_variable.Get_lista_tipo_pago_variable(param.IdEmpresa);
                cmb_rubro_pago_variable.ValueMember = "cod_Pago_Variable";
                cmb_rubro_pago_variable.DisplayMember = "nom_Pago_Variable";
                cmb_rubro_pago_variable.DataSource = lista_tipo_variable;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {  if(Grabar())
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            { if(validar())
                Grabar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (validar())
                {
                    if (Grabar())
                        this.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        
        public bool Grabar()
        {
            int IdGrupo=0;
            try
            {
                Get();
                switch (accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        info_grupo.IdUsuario = param.IdUsuario;
                        if (bus_grupo.Guardar_DB(info_grupo))
                        {
                             MessageBox.Show( param.Get_Mensaje_sys(enum_Mensajes_sys.Grabado_satisfactoriamente),param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Information);
                            return true;
                        }
                        else
                        {
                            MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.No_se_guardaron_los_datos), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return true;
                        }
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        info_grupo.IdUsuarioUltMod = param.IdUsuario;
                        info_grupo.Fecha_UltMod = DateTime.Now;
                        if (bus_grupo.Modificar_DB(info_grupo))
                        {
                            MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_modifico_corrrectamente), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                           
                            return true;
                        }
                        else
                        {
                            MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.No_se_modificaron_los_datos), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return true;
                        }
                    case Cl_Enumeradores.eTipo_action.Anular:

                         FrmGe_MotivoAnulacion oFrm = new FrmGe_MotivoAnulacion();

                         if (MessageBox.Show("¿Está seguro que desea anular el reg #: " + txtId.Text + " ?", "Anulación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                         {
                             oFrm.ShowDialog();
                             info_grupo.IdUsuarioUltAnu = param.IdUsuario;
                             info_grupo.Fecha_UltAnu = DateTime.Now;
                             info_grupo.MotiAnula = oFrm.motivoAnulacion;
                             if (bus_grupo.Anular_DB(info_grupo))
                             {
                                 MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Anulada_corectamente), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                 return true;
                             }
                             else
                             {
                                 MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.No_se_puede_anular_registro), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                 return true;
                             }
                         }
                         else
                         {
                             return false;
                         }
                    case Cl_Enumeradores.eTipo_action.consultar:
                        return false;
                    case Cl_Enumeradores.eTipo_action.duplicar:
                        return false;
                    default:
                        return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }

        private void frmRo_Grupo_empleado_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                switch (accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                       
                        dtFechaSalida.EditValue = DateTime.Now;
                        ucGe_Menu.Visible_bntAnular = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        ucGe_Menu.Visible_bntAnular = false;

                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        ucGe_Menu.Visible_bntAnular = true;
                        ucGe_Menu.btnGuardar.Visible = false;
                        ucGe_Menu.btnGuardar_y_Salir.Visible = false;

                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        ucGe_Menu.Visible_bntAnular = false;
                         ucGe_Menu.btnGuardar.Visible = false;
                        ucGe_Menu.btnGuardar_y_Salir.Visible = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.duplicar:
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.ToString());
            }
        }

        public bool validar()
        {
            try
            {
                if (txtnombre.Text == "")
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Ingrese_el) + " el nombre del grupo",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Information);
                    return false;
                }

                



                if (txt_num_calculo_horas_extras.EditValue==null || txt_num_calculo_horas_extras.EditValue=="")
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Ingrese_el) + " sobre que numero se realizara el calculo de horas extras [160/240]", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }


                if (txt_num_horas_sab_dom.EditValue == null || txt_num_horas_sab_dom.EditValue == "")
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Ingrese_el) + " el numero de horas para feriados y fines de semana [8/10]", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                
              MessageBox.Show(ex.ToString());
              return false;
            }
        }

        private void txt_num_calculo_horas_extras_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void labelControl4_Click(object sender, EventArgs e)
        {

        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void gridControl_detalle_Click(object sender, EventArgs e)
        {

        }

        private void gridView_detalle_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmRo_Grupo_empleado_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                this.event_frmRo_Grupo_empleado_Mant_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridView_parametro_Variable_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (e.Column.Name == "Col_icono_eliminar")
            {
                try
                {
                    DialogResult dialogResult = MessageBox.Show("¿Esta seguro de querer eliminar el registro?", param.Nombre_sistema, MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        gridView_parametro_Variable.DeleteSelectedRows();
                    }

                }
                catch (Exception ex)
                {

                    Log_Error_bus.Log_Error(ex.ToString());
                    MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
    }
}
