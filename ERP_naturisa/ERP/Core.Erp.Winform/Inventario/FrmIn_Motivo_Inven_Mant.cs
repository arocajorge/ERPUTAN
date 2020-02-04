using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.Inventario;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using Core.Erp.Winform.General;


namespace Core.Erp.Winform.Inventario
{
    public partial class FrmIn_Motivo_Inven_Mant : Form
    {
        #region

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        in_Motivo_Inven_Info Info = new in_Motivo_Inven_Info();
        in_Motivo_Inven_Bus Bus_Tip_movi = new in_Motivo_Inven_Bus();
        Cl_Enumeradores.eTipo_action Accion;

        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        public delegate void delegate_FrmIn_Motivo_Inven_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_FrmIn_Motivo_Inven_Mant_FormClosing event_FrmIn_Motivo_Inven_Mant_FormClosing;
        #endregion



        private void set_Info_in_controls()
        {
            try
            {
        
                if (Info != null)
                {
                    txt_id.Text = Info.IdMotivo_Inv.ToString();
                    txt_codigo.Text = Info.Cod_Motivo_Inv;
                    txt_descripcion.Text = Info.Desc_mov_inv;
                    chk_estado.Checked = (Info.estado == "A") ? true : false;
                    chk_gen_movi_inv.Checked = (Info.Genera_Movi_Inven == "S") ? true : false;
                    chk_generacxp.Checked = (Info.Genera_CXP == "S") ? true : false;
                    chk_puntocargo.Checked = (Info.Exigir_Punto_Cargo == "S") ? true : false;
                    Anulado.Visible = (Info.estado == "I") ? true : false;
                    ucCon_CtaCble_Inven.set_PlanCtarInfo(Info.IdCtaCble_Inven);
                    ucCon_CtaCbleCosto.set_PlanCtarInfo(Info.IdCtaCble_Costo);
                    ucIn_Catalogos_Ing_Egr.set_CatalogosInfo(Info.Tipo_Ing_Egr.ToString());
                    ucIn_Catalogos_Inv_Consu.set_CatalogosInfo(Info.es_Inven_o_Consumo.ToString());

                }
                else
                {
                    MessageBox.Show("No ha seleccionado ningún registro.\nPor favor escoja un motivo de Inventrio", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Close();
                }
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        
        }

        public void set_Info(in_Motivo_Inven_Info _Info)
        {
            try
            {
                Info = _Info;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public in_Motivo_Inven_Info get_Info()
        {
            try
            {


                Info.IdEmpresa = param.IdEmpresa;
                if (txt_id.Text != "")
                {
                    Info.IdMotivo_Inv = Convert.ToInt32(txt_id.Text);
                }
                Info.Cod_Motivo_Inv = txt_codigo.Text;
                Info.Desc_mov_inv = txt_descripcion.Text;
                Info.estado  = (chk_estado.Checked ==true) ? "A": "I";
                Info.Genera_Movi_Inven  = (chk_gen_movi_inv.Checked ==true) ? "S": "N";
                Info.Genera_CXP = (chk_generacxp.Checked == true) ? "S" : "N";
                Info.Exigir_Punto_Cargo = (chk_puntocargo.Checked == true) ? "S" : "N";
                Info.IdCtaCble_Inven = ucCon_CtaCble_Inven.get_PlanCtaInfo().IdCtaCble;
                Info.IdCtaCble_Costo = ucCon_CtaCbleCosto.get_PlanCtaInfo().IdCtaCble;

                Info.es_Inven_o_Consumo = (ein_Inventario_O_Consumo)Enum.Parse(typeof(ein_Inventario_O_Consumo), ucIn_Catalogos_Inv_Consu.Get_CatalogosInfo().IdCatalogo);
                Info.Tipo_Ing_Egr = (ein_Tipo_Ing_Egr)Enum.Parse(typeof(ein_Tipo_Ing_Egr), ucIn_Catalogos_Ing_Egr.Get_CatalogosInfo().IdCatalogo);

                return Info;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new in_Motivo_Inven_Info();
            }
        }
        
        private Boolean Validar()
        {
            try
            {
                if (txt_descripcion.Text.Length == 0)
                {
                    MessageBox.Show("El  nombre de tipo no puede ser blanco", "sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
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

        private void LimpiarDatos()
        {
            try
            {
                txt_id.Text = "";
                txt_descripcion.Text = "";
                txt_codigo.Text = "";
                chk_gen_movi_inv.Checked = false;
                chk_generacxp.Checked = false;
                chk_puntocargo.Checked = false;
                chk_estado.Checked = true;
                ucCon_CtaCble_Inven.set_PlanCtarInfo("");
                ucCon_CtaCbleCosto.set_PlanCtarInfo("");
                Info = new in_Motivo_Inven_Info();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void set_Accion(Cl_Enumeradores.eTipo_action _Accion)
        {
            try
            {

                Accion = _Accion;

            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void set_Accion_in_controls()
        {
            try
            {


                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        ucGe_Menu.Enabled_bntAnular = false;
                        ucGe_Menu.Enabled_bntLimpiar = true;
                        chk_estado.Checked = true;
                        chk_estado.Enabled = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        ucGe_Menu.Enabled_bntAnular = false;
                        ucGe_Menu.Enabled_bntLimpiar = false;
                        set_Info_in_controls();
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        ucGe_Menu.Visible_bntAnular = false;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        ucGe_Menu.Visible_bntLimpiar = false;
                        chk_estado.Enabled = false;
                        chk_gen_movi_inv.Enabled = false;
                        set_Info_in_controls();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        ucGe_Menu.Enabled_bntAnular = true;
                        ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
                        ucGe_Menu.Enabled_btnGuardar = false;
                        ucGe_Menu.Enabled_bntLimpiar = false;
                        set_Info_in_controls();
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

        private Boolean Grabar()
        {
            try
            {
                int id = 0;
                string msg = "";

                if (Validar())
                {
                    string mensajeRecurso = "";
                    get_Info();
                    if (Bus_Tip_movi.GuardarDB(Info, ref id, ref msg))
                    {                        
                        mensajeRecurso = Core.Erp.Recursos.Properties.Resources.msgConfirmaGrabarOk;
                        MessageBox.Show(mensajeRecurso, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Accion = Cl_Enumeradores.eTipo_action.grabar;
                        LimpiarDatos();
                    }
                    else
                    {
                        mensajeRecurso = Core.Erp.Recursos.Properties.Resources.msgError_Grabar;
                        MessageBox.Show(mensajeRecurso+"\n"+msg, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }

                }
                else
                {
                    return false;
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

        private Boolean Modificar()
        {

            try
            {
                int id = 0;
                string msg = "";

                if (Validar())
                {
                    string mensajeRecurso = "";
                    get_Info();
                    if (Bus_Tip_movi.ModificarDB(Info, ref id, ref msg))
                    {
                        mensajeRecurso = Core.Erp.Recursos.Properties.Resources.msgConfirmaGrabarOk;
                        //ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
                        //ucGe_Menu.Enabled_btnGuardar = false;
                        MessageBox.Show(mensajeRecurso,param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Information);
                        Accion = Cl_Enumeradores.eTipo_action.grabar;
                        LimpiarDatos();
                    }
                    else
                    {
                        mensajeRecurso = Core.Erp.Recursos.Properties.Resources.msgError_Modificar;
                        MessageBox.Show(mensajeRecurso +"\n"+ msg,param.Nombre_sistema);
                        return false;
                    }

                }
                else
                {
                    return false;
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

        private Boolean Anular()
        {
            try
            {
                Boolean resultB = false;
                string msg = "";
                int id = 0;


                if (MessageBox.Show("¿Está seguro que desea anular el Estado  ?", "Anulación de Estado de Cierre  " + param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    FrmGe_MotivoAnulacion ofrm = new FrmGe_MotivoAnulacion();
                    ofrm.ShowDialog();

                    Info.IdUsuarioUltAnu = param.IdUsuario;
                    Info.FechaHoraAnul = param.Fecha_Transac;
                    Info.MotivoAnulacion = ofrm.motivoAnulacion;
                    string mensajeRecurso = "";
                    if (Bus_Tip_movi.AnularDB(Info, ref id, ref msg))
                    {
                        ucGe_Menu.Enabled_bntAnular = false;
                        mensajeRecurso = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Anular, "Estado ", Info.IdEmpresa.ToString());
                        MessageBox.Show(mensajeRecurso, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //MessageBox.Show("Estado # " + Info.IdEmpresa + " ANULADO Satisfactoriamente", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        resultB = true;
                    }
                    else
                    {
                        MessageBox.Show(" Error al ANULAR Ajuste verifique con sistemas ...: " + msg, "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        resultB = false;
                    }
                }
                return resultB;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        
        public FrmIn_Motivo_Inven_Mant()
        {
            InitializeComponent();
            ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
            ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
            ucGe_Menu.event_btnlimpiar_Click += ucGe_Menu_event_btnlimpiar_Click;
            ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
            ucGe_Menu.event_btnAnular_Click += ucGe_Menu_event_btnAnular_Click;

            event_FrmIn_Motivo_Inven_Mant_FormClosing += FrmIn_Motivo_Inven_Mant_event_FrmIn_Motivo_Inven_Mant_FormClosing;

            ucIn_Catalogos_Ing_Egr.cargar_Catalogos(8);
            ucIn_Catalogos_Inv_Consu.cargar_Catalogos(7);
                 
        }

        void FrmIn_Motivo_Inven_Mant_event_FrmIn_Motivo_Inven_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
        
        void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                if (Anular())
                    Close();
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

        void ucGe_Menu_event_btnlimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                txt_codigo.Text = "";
                txt_descripcion.Text = "";
                chk_estado.Checked = true;
                //chk_gen_movi_inv = true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            if (Accion == Cl_Enumeradores.eTipo_action.grabar)
            {
                if (Grabar())
                {
                    this.Close();
                }
            }

            if (Accion == Cl_Enumeradores.eTipo_action.actualizar)
            {
                if (Modificar())
                {
                    this.Close();
                }
            }


            if (Accion == Cl_Enumeradores.eTipo_action.Anular)
            {
                Anular();
            }



        }
                        
        void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            if (Accion == Cl_Enumeradores.eTipo_action.grabar)
            {
                Grabar();
            }

            if (Accion == Cl_Enumeradores.eTipo_action.actualizar)
            {
                Modificar();
            }


            if (Accion == Cl_Enumeradores.eTipo_action.Anular)
            {
                Anular();
            }

        }

        private void FrmIn_estado_cierre_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            event_FrmIn_Motivo_Inven_Mant_FormClosing(sender, e);
        }
        
        void ucGe_Menu_event_btnModificar_Click(object sender, EventArgs e)
        {
            if (Accion == Cl_Enumeradores.eTipo_action.actualizar)
            {
                Modificar();
            }

        }

        private void FrmIn_Motivo_Inven_Mant_Load(object sender, EventArgs e)
        {
            if (Accion == 0) { Accion = Cl_Enumeradores.eTipo_action.grabar; }
            set_Accion_in_controls();

        }

        private void ucGe_Menu_Load(object sender, EventArgs e)
        {

        }

        private void FrmIn_Motivo_Inven_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                event_FrmIn_Motivo_Inven_Mant_FormClosing(sender,e);
            }
            catch (Exception ex)
            {                
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucIn_Catalogos_Cmb1_Load(object sender, EventArgs e)
        {

        }


    }
}
