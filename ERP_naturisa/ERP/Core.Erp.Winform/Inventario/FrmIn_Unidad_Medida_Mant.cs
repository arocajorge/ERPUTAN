using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.Inventario;
using Core.Erp.Winform.General;



namespace Core.Erp.Winform.Inventario
{
    public partial class FrmIn_Unidad_Medida_Mant : Form
    {
        #region Variables
        string mensaje = "";
        public delegate void delegate_FrmIn_Unidad_Medida_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_FrmIn_Unidad_Medida_Mant_FormClosing event_FrmIn_Unidad_Medida_Mant_FormClosing;        
        public Cl_Enumeradores.eTipo_action _Accion { get; set; }
        public in_UnidadMedida_Info _InfoUni_Med { get; set; }
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        in_UnidadMedida_Bus UniMedBus = new in_UnidadMedida_Bus();
        in_UnidadMedida_Equiv_conversion_Bus UniMed_Eq_Bus = new in_UnidadMedida_Equiv_conversion_Bus();
        public BindingList<in_UnidadMedida_Equiv_conversion_Info> listUnidadMedida_Equiv_conversion_Info { get; set; }

        #endregion

        private Boolean ExisteIdUnidadMedida(string IdUnidadMedida)
        {
            try
            {
                in_UnidadMedida_Bus UniBus = new in_UnidadMedida_Bus();

              return   UniBus.Existe_IdUnidadMedida(IdUnidadMedida);
                                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private Boolean validar()
        {
            try
            {

                if (txtdescripcion.Text == "")
                {
                    MessageBox.Show("No tiene el nombre la unidad de medida", param.nom_pc, MessageBoxButtons.OK);
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

        public void LimpiarDatos()
        {
            try
            {
                txtIdUniMed.Text = "";
                txtCodAlterno.Text = "";
                txtdescripcion.Text = "";
                chkestado.Checked = false;
                chkUsado_x_Movimiento.Checked = false;

                listUnidadMedida_Equiv_conversion_Info = new BindingList<in_UnidadMedida_Equiv_conversion_Info>();
                gridControl_conversion.DataSource = listUnidadMedida_Equiv_conversion_Info;
                _InfoUni_Med = new in_UnidadMedida_Info();
                _InfoUni_Med.listUnidadMedida_Equiv_conversion = new List<in_UnidadMedida_Equiv_conversion_Info>();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public FrmIn_Unidad_Medida_Mant()
        {
            try
            {
                InitializeComponent();

                if (_InfoUni_Med == null)
                {
                    _InfoUni_Med = new in_UnidadMedida_Info();
                }

                    listUnidadMedida_Equiv_conversion_Info = new BindingList<in_UnidadMedida_Equiv_conversion_Info>();
                   gridControl_conversion.DataSource = listUnidadMedida_Equiv_conversion_Info;
                

                ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
                ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
                ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
                ucGe_Menu.event_btnAnular_Click += ucGe_Menu_event_btnAnular_Click;

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
                anular();
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
                if (Acciongrabar())
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Acciongrabar();
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

        private void set_accion()
        {

            try
            {

                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:

                        chkestado.Enabled = false;
                        chkestado.Checked = true;

                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:

                        ucGe_Menu.Enabled_bntAnular = false;
                        ucGe_Menu.Enabled_bntLimpiar = false;


                        this.txtIdUniMed.Enabled = false;
                        this.txtIdUniMed.BackColor = System.Drawing.Color.White;
                        this.txtIdUniMed.ForeColor = System.Drawing.Color.Black;


                        set_Info();

                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:

                        ucGe_Menu.Enabled_bntLimpiar = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;

                        this.txtIdUniMed.Enabled = false;
                        this.txtIdUniMed.BackColor = System.Drawing.Color.White;
                        this.txtIdUniMed.ForeColor = System.Drawing.Color.Black;

                        gridView_conversion.OptionsBehavior.Editable = false;

                        set_Info();

                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:

                        ucGe_Menu.Enabled_bntLimpiar = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Enabled_bntAnular = false;


                        this.txtIdUniMed.Enabled = false;
                        this.txtIdUniMed.BackColor = System.Drawing.Color.White;
                        this.txtIdUniMed.ForeColor = System.Drawing.Color.Black;



                        gridView_conversion.OptionsBehavior.Editable = false;


                        set_Info();


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
        
        private void set_Info()
        {
            try
            {


                if (_InfoUni_Med != null)
                {

                    txtIdUniMed.Text = _InfoUni_Med.IdUnidadMedida;
                    txtCodAlterno.Text = _InfoUni_Med.cod_alterno;
                    txtdescripcion.Text = _InfoUni_Med.Descripcion;
                    chkestado.Checked = (_InfoUni_Med.Estado == "A") ? true : false;
                    lblAnulado.Visible = (_InfoUni_Med.Estado == "I") ? true : false;
                    chkUsado_x_Movimiento.Checked = (_InfoUni_Med.Usado_en_Movimiento == "S") ? true : false;

                    listUnidadMedida_Equiv_conversion_Info = new BindingList<in_UnidadMedida_Equiv_conversion_Info>(UniMed_Eq_Bus.Get_List_in_UnidadMedida_Equiv_conversion(_InfoUni_Med.IdUnidadMedida));
                    gridControl_conversion.DataSource = listUnidadMedida_Equiv_conversion_Info;

                }

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
                _InfoUni_Med.IdUnidadMedida = txtIdUniMed.Text.Trim();
                _InfoUni_Med.cod_alterno = txtCodAlterno.Text.Trim();
                _InfoUni_Med.Descripcion = txtdescripcion.Text.Trim();
                _InfoUni_Med.Estado = (chkestado.Checked) ? "A" : "I";
                _InfoUni_Med.Usado_en_Movimiento = (chkUsado_x_Movimiento.Checked) ? "S" : "N";

                _InfoUni_Med.listUnidadMedida_Equiv_conversion = new List<in_UnidadMedida_Equiv_conversion_Info>();

                foreach (var item in listUnidadMedida_Equiv_conversion_Info)
                {
                    _InfoUni_Med.listUnidadMedida_Equiv_conversion.Add(item);
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }

        private void cargar_combo()
        {

            try
            {

                in_UnidadMedida_Bus UniMedBus = new in_UnidadMedida_Bus();
                cmbUnidadMedida_Equiv.DataSource = UniMedBus.Get_list_UnidadMedida();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }

        private Boolean Guardar()
        {
            try
            {
                string IdUnidadMedida = "";

                _InfoUni_Med.Fecha_UltMod = param.Fecha_Transac;
                _InfoUni_Med.IdUsuarioUltMod = param.IdUsuario;

                


                if (UniMedBus.GrabarDB(_InfoUni_Med,ref IdUnidadMedida, ref  mensaje))
                {
                    string smensaje = Core.Erp.Recursos.Properties.Resources.msgConfirmaGrabarOk;
                    MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //MessageBox.Show("Guardado con éxito Unidad de Medidad" , param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Information);
                    txtIdUniMed.Text = IdUnidadMedida;
                    //_Accion = Cl_Enumeradores.eTipo_action.consultar;
                    //set_accion();
                    LimpiarDatos();
                    return true;
                }
                else
                {
                    MessageBox.Show(mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private Boolean Actualizar()
       {
           try
           {
               _InfoUni_Med.Fecha_UltMod = param.Fecha_Transac;
               _InfoUni_Med.IdUsuarioUltMod = param.IdUsuario;

               string IdUnidadMedida = "";

               if (UniMedBus.ModificarDB(_InfoUni_Med,ref  mensaje))
               {
                   MessageBox.Show("Actualizacion con éxito Unidad de Medidad", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                   txtIdUniMed.Text = IdUnidadMedida;
                   //_Accion = Cl_Enumeradores.eTipo_action.consultar;
                   //set_accion();
                   LimpiarDatos();
                   return true;
               }
               else
               {
                   MessageBox.Show(mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private Boolean Acciongrabar()
        {
            try
            {
                Boolean Res = false;

                if (validar())
                {
                    txtIdUniMed.Focus();
                    get_Info();


                    switch (_Accion)
                    {
                        case Cl_Enumeradores.eTipo_action.grabar:
                            Res = Guardar();
                            break;
                        case Cl_Enumeradores.eTipo_action.actualizar:
                            Res = Actualizar();
                            break;
                        case Cl_Enumeradores.eTipo_action.Anular:
                             
                            break;
                        default:
                            break;
                    }
                }

                return Res;


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public void anular()
       {
           try
           {
               if (_InfoUni_Med != null)
               {
                   FrmGe_MotivoAnulacion oFrm = new FrmGe_MotivoAnulacion();

                   if (_InfoUni_Med.Estado == "A")
                   {
                       if (MessageBox.Show("¿Está seguro que desea anular : ?", "Anulación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                       {
                           string msg = "";
                           oFrm.ShowDialog();

                           
                           _InfoUni_Med.Fecha_UltAnu = param.Fecha_Transac;
                           _InfoUni_Med.IdUsuarioUltAnu = param.IdUsuario;



                           if (UniMedBus.AnularDB(_InfoUni_Med, ref msg))
                           {
                               string smensaje = Core.Erp.Recursos.Properties.Resources.msgConfirmaAnulacionOk;
                               MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                               //MessageBox.Show("Anulado con exito # " );
                               _InfoUni_Med.Estado = "I";

                               lblAnulado.Visible = true;

                               _Accion = Cl_Enumeradores.eTipo_action.consultar;

                           }
                       }
                   }
                   else if (_InfoUni_Med.Estado == "I")
                   {
                       MessageBox.Show("No se puede anular la devolucion de Compra N#: ", "Anulación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   }

               }
           }
           catch (Exception ex)
           {
               Log_Error_bus.Log_Error(ex.ToString());
               MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
       }

        private void FrmIn_Unidad_Medida_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                cargar_combo();
                set_accion();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private Boolean verificarrepetidos(string IdUnidadMedida_Equiva, Boolean eliminar, int tipo)
        {
            try
            {

                var cont = from C in listUnidadMedida_Equiv_conversion_Info
                           where C.IdUnidadMedida_equiva == IdUnidadMedida_Equiva
                           select C;

                if (cont.Count() == tipo)
                {
                    return true;
                }
                else
                {
                    if (eliminar == true)
                    {
                        gridView_conversion.DeleteRow(gridView_conversion.FocusedRowHandle);
                        MessageBox.Show("El código ya se encuentra ingresado. Se procederá con su eliminación.");
                    }
                    else
                    {

                        MessageBox.Show("El código ya se encuentra ingresado.");
                    }
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

        private void gridView_conversion_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {

                in_UnidadMedida_Equiv_conversion_Info rowUniMed = new in_UnidadMedida_Equiv_conversion_Info();

                rowUniMed = (in_UnidadMedida_Equiv_conversion_Info)gridView_conversion.GetRow(e.RowHandle);

                if (rowUniMed != null)
                {

                    if (e.Column.Name == "colIdUnidadMedida_equiva")
                    {
                        verificarrepetidos(e.Value.ToString(), true, 1);

                        //rowUniMed.interpretacion = "1 " + ;

                        
                    }
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        private void FrmIn_Unidad_Medida_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                event_FrmIn_Unidad_Medida_Mant_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void gridView_conversion_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyValue.ToString() == "46")
                {

                    gridView_conversion.DeleteSelectedRows();

                   
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
