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



namespace Core.Erp.Winform.Inventario
{
    public partial class FrmIn_Motivo_Inven_borrar_Mant : Form
    {

        in_Motivo_Inven_Borrar_Info Info = new in_Motivo_Inven_Borrar_Info();
        in_Motivo_Inven_Borrar_Bus Bus_Tip_movi = new in_Motivo_Inven_Borrar_Bus();
        Cl_Enumeradores.eTipo_action Accion;

       

        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;


        public void set_Info(in_Motivo_Inven_Borrar_Info _Info)
        {
            try
            {

                Info = _Info;
                
                txt_id.Text = Info.IdMotivo_Inv.ToString();
                txt_codigo.Text = Info.Cod_Motivo_Inv;
                txt_descripcion.Text = Info.Desc_mov_inv;
                chk_estado.Checked = (Info.estado == "A") ? true : false;
                chk_gen_movi_inv.Checked = (Info.Genera_Movi_Inven == "S") ? true : false;


            }
            catch (Exception ex)
            {
                
                
            }
        }

        public in_Motivo_Inven_Borrar_Info get_Info()
        {
            try
            {


                Info.IdEmpresa = param.IdEmpresa;
                Info.IdMotivo_Inv =Convert.ToInt32( txt_id.Text);
                Info.Cod_Motivo_Inv = txt_codigo.Text;
                Info.Desc_mov_inv = txt_descripcion.Text;
                Info.estado  = (chk_estado.Checked ==true) ? "A": "I";
                Info.Genera_Movi_Inven  = (chk_gen_movi_inv.Checked ==true) ? "S": "N";
                Info.Genera_CXP = "S";

                return Info;

            }
            catch (Exception ex)
            {

                return new in_Motivo_Inven_Borrar_Info();
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

                return false;
            }
        
        }


        private void Limpiar()
        {
            try
            {
                txt_id.Text = "0";
                txt_descripcion.Text = "";
                txt_codigo.Text = "";
                chk_gen_movi_inv.Checked = false;
                chk_estado.Checked = true;
            }
            catch (Exception ex)
            {
                
                
            }
        }

        public void set_Acccion(Cl_Enumeradores.eTipo_action _Accion)
        {
            try
            {

                Accion = _Accion;


                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        Limpiar();
                        ucGe_Menu.Enabled_bntAnular = false;
                        ucGe_Menu.Enabled_bntLimpiar = true;
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        ucGe_Menu.Enabled_bntAnular = false;
                        ucGe_Menu.Enabled_bntLimpiar = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        ucGe_Menu.Enabled_bntAnular = false;
                        ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
                        ucGe_Menu.Enabled_btnGuardar = false;
                        ucGe_Menu.Enabled_bntLimpiar = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.borrar:
                        ucGe_Menu.Enabled_bntAnular = true;
                        ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
                        ucGe_Menu.Enabled_btnGuardar = false;
                        ucGe_Menu.Enabled_bntLimpiar = false;

                        break;
                    default:
                        break;
                }

               

            }
            catch (Exception ex)
            {
                
                
            }
        
        }

        private Boolean Grabar()
        {
            try
            {
                int id=0;
                string msg="";

                if (Validar())
                {

                    get_Info();
                    if (Bus_Tip_movi.GrabarDB(Info, ref id, ref msg))
                    {
                        MessageBox.Show("Grabado OK..");
                    }
                    else
                    {
                        MessageBox.Show("error l grabar " + msg);
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

                return false;
            }
        }

        private Boolean Modificar()
        {

            try
            {
                
                string msg = "";

                if (Validar())
                {

                    get_Info();
                    if (Bus_Tip_movi.ModificarDB(Info, ref msg))
                    {
                        MessageBox.Show("Modificar OK..");
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("error l grabar " + msg);
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
                return false;

            }
        }

        private Boolean Anular()
        {
            try
            {

                string msg = "";

                if (Validar())
                {

                    get_Info();
                    if (Bus_Tip_movi.AnularDB(Info, ref msg))
                    {
                        MessageBox.Show("Anulado OK..");
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Error al Anular " + msg);
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
                return false;

            }
        }

        public FrmIn_Motivo_Inven_borrar_Mant()
        {
            InitializeComponent();
            ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
            ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
            ucGe_Menu.event_btnlimpiar_Click += ucGe_Menu_event_btnlimpiar_Click;
            ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
            ucGe_Menu.event_btnAnular_Click += ucGe_Menu_event_btnAnular_Click;

        }

        void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            if (Accion == Cl_Enumeradores.eTipo_action.borrar)
            {
                Anular();
            }
        }

        void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            
        }

        void ucGe_Menu_event_btnlimpiar_Click(object sender, EventArgs e)
        {
            
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


            if (Accion == Cl_Enumeradores.eTipo_action.borrar)
            {
                //Modificar();
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


            if (Accion == Cl_Enumeradores.eTipo_action.borrar)
            {
                Anular();
            }
            


        }

        private void FrmIn_Motivo_Inven_borrar_Mant_Load(object sender, EventArgs e)
        {

        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
