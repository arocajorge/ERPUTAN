using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Core.Erp.Winform.Controles;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.Inventario;
using Core.Erp.Info.General;
using Core.Erp.Business.General;

namespace Core.Erp.Winform.Inventario
{
    public partial class FrmIn_Categoria_Mant : Form
    {
        #region Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        //Instancias de Categoria
        public in_categorias_Info _categorioInfo { get; set; }
        public in_categorias_Info _categoriaInfoPadre { get; set; }
        in_categorias_Info infoCat = new in_categorias_Info();
        in_categorias_Info infoCatPadre = new in_categorias_Info();
        in_categorias_bus BusCat = new in_categorias_bus();

        //User Controls
      //  UCIN_CategoriaGeneral UCI = new UCIN_CategoriaGeneral();
        
        //Instancias generales del sistema
        private Cl_Enumeradores.eTipo_action Accion;
        private Cl_Enumeradores.eTipo_action _Accion;
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        public delegate void DelegadoRefrescar();
        public event DelegadoRefrescar ReloadGrid;
      //  UCIn_CtsContablesParaContabilizar ctrl_ctasContables;
        in_Parametro_Bus bus = new in_Parametro_Bus();
        #endregion
       
        public void set_Accion(Cl_Enumeradores.eTipo_action iAccion)
        {
            Accion = iAccion;
            switch (Accion)
            {
                case Cl_Enumeradores.eTipo_action.grabar:
                    ucGe_Menu.Visible_bntAnular = false;
                    break;
                case Cl_Enumeradores.eTipo_action.actualizar:
                    ucGe_Menu.Visible_bntAnular = false;
                 
                    break;
                case Cl_Enumeradores.eTipo_action.consultar:
                   ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                   ucGe_Menu.Visible_btnGuardar = false;

                   ucGe_Menu.Visible_bntAnular = false;
                    txt_nombre.Enabled = false;
                    txt_nombre.BackColor = System.Drawing.Color.White;
                    txt_nombre.ForeColor = System.Drawing.Color.Black;

                    txt_posicion.Enabled = false;
                    txt_posicion.BackColor = System.Drawing.Color.White;
                    txt_posicion.ForeColor = System.Drawing.Color.Black;

                    chk_estado.Enabled = false;
                    chk_estado.BackColor = System.Drawing.Color.White;
                    chk_estado.ForeColor = System.Drawing.Color.Black;
                                                 
                    break;
                case Cl_Enumeradores.eTipo_action.Anular:
                    ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                    ucGe_Menu.Visible_btnGuardar = false;

                     txt_nombre.Enabled = false;
                    txt_nombre.BackColor = System.Drawing.Color.White;
                    txt_nombre.ForeColor = System.Drawing.Color.Black;

                    txt_posicion.Enabled = false;
                    txt_posicion.BackColor = System.Drawing.Color.White;
                    txt_posicion.ForeColor = System.Drawing.Color.Black;

                    chk_estado.Enabled = false;
                    chk_estado.BackColor = System.Drawing.Color.White;
                    chk_estado.ForeColor = System.Drawing.Color.Black;

                    break;
                default:
                    break;
            }
        }

        public void iniciar()
        {
            try
            {
                _Accion = Cl_Enumeradores.eTipo_action.actualizar;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void set_CategoriaCheckedSelection(in_categorias_Info CategorioInfo)
        {

            try
            {
               // UCI.set_CategoriaCheckedSelection(CategorioInfo);                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void set_categoria(in_categorias_Info categoriaInfo)
        {
            try
            {
                _categorioInfo = categoriaInfo;
                txt_nombre.Text = _categorioInfo.ca_Categoria;
                txt_posicion.Value = _categorioInfo.ca_Posicion;
                chk_estado.Checked = (_categorioInfo.Estado == "A") ? true : false;
                
                infoCat = categoriaInfo;

                if (categoriaInfo.Estado == "I")
                {
                    this.chk_estado.Checked = false;
                    lblAnulado.Visible = true;
                }
                else
                {
                    chk_estado.Checked = true;               
                }                                            
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        string mensaje = "";
        
        void Anular()
        {
            try
            {
                get_categoria();

                infoCat.IdUsuarioUltAnu = param.IdUsuario;
                infoCat.Fecha_UltAnu = param.Fecha_Transac;
                Core.Erp.Winform.General.FrmGe_MotivoAnulacion ofrm = new General.FrmGe_MotivoAnulacion();
                ofrm.ShowDialog();
                infoCat.MotiAnula = ofrm.motivoAnulacion;

                if (BusCat.AnularDB(infoCat, ref mensaje))
                {
                    string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Anular, "La Categoria", infoCat.IdCategoria);
                    MessageBox.Show(smensaje, param.Nombre_sistema);
                    lblAnulado.Visible = true;
                    ucGe_Menu.Visible_bntAnular = false;
                }
                else
                {
                    string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgError_Anular);
                    MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);   
                }
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void set_categoriaPadre(in_categorias_Info categoriaInfo)
        {
            try
            {
                _categoriaInfoPadre = categoriaInfo;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public FrmIn_Categoria_Mant()
        {
            InitializeComponent();
                ReloadGrid+=frmIn_CategoriaMantenimiento_ReloadGrid;
        }

        void frmIn_CategoriaMantenimiento_ReloadGrid()
        {
        }
       
        private void frmIn_CategoriaMantenimiento_Load(object sender, EventArgs e)
        {

            var info = bus.Get_Info_Parametro(param.IdEmpresa);

          //  UCI.set_Treelist_SelectMultiple(false);
          //  UCI.set_Treelist_ShowCheckBoxes(true);
          //  UCI.set_Solo_chequea_unItem(true);
           // this.groupBox1.Controls.Add(UCI);
         //   UCI.Dock = DockStyle.Fill;
         //   UCI.set_CategoriaCheckedSelection(_categoriaInfoPadre);

        //    ctrl_ctasContables = new UCIn_CtsContablesParaContabilizar(info.IdCtaCble_Inven, info.IdCentro_Costo_Inventario, info.IdCtaCble_CostoInven, info.IdCentro_Costo_Costo);
         //   ctrl_ctasContables.Dock = DockStyle.Fill;
        //    tabPage2.Controls.Add(ctrl_ctasContables);


            switch (Accion)
            {
                case Cl_Enumeradores.eTipo_action.grabar:
                    break;
                case Cl_Enumeradores.eTipo_action.actualizar:
                 //   ctrl_ctasContables.setValores(infoCat.IdCtaCtble_Inve, infoCat.IdCentro_Costo_Inventario, infoCat.IdCtaCtble_Costo, infoCat.IdCentro_Costo_Costo);
                    break;
                case Cl_Enumeradores.eTipo_action.Anular:
                //    ctrl_ctasContables.setValores(infoCat.IdCtaCtble_Inve, infoCat.IdCentro_Costo_Inventario, infoCat.IdCtaCtble_Costo, infoCat.IdCentro_Costo_Costo);
                //    ctrl_ctasContables.Inhabilita_Combos();
                    break;
                case Cl_Enumeradores.eTipo_action.consultar:
                //    ctrl_ctasContables.setValores(infoCat.IdCtaCtble_Inve, infoCat.IdCentro_Costo_Inventario, infoCat.IdCtaCtble_Costo, infoCat.IdCentro_Costo_Costo);
                //    ctrl_ctasContables.Inhabilita_Combos();

                    break;
                default:
                    break;
            }
        }

        private void grabar()
        {
            try
            {
                if (validaciones() == false)
                    MessageBox.Show("Por favor Revise debe completar los campos");
                else
                {
                    get_categoria();
                    string msg = "";
                    switch (Accion)
                    {
                        case Cl_Enumeradores.eTipo_action.grabar:
                            if (BusCat.GrabarDB(param.IdEmpresa, infoCat, ref msg))
                            {
                                string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Grabar, "La Categoria", infoCat.IdCategoria);
                                MessageBox.Show(smensaje, param.Nombre_sistema); 
                                set_Accion(Cl_Enumeradores.eTipo_action.actualizar);
                            }
                            else
                            {
                                string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgError_Grabar);
                                MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);       
                            }
                          
                            
                            break;
                        case Cl_Enumeradores.eTipo_action.actualizar:
                            if (BusCat.ModificarDB(param.IdEmpresa, infoCat, ref msg))
                            {
                                string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Modificar, "La Categoria", infoCat.IdCategoria);
                                MessageBox.Show(smensaje, param.Nombre_sistema);
                                Accion = Cl_Enumeradores.eTipo_action.grabar;
                                Limpiar();
                            }
                            else
                            {
                                string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgError_Modificar);
                                MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);       
                            }
                            
                          
                            break;
                        default:
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void get_categoria()
        {
            try
            {
                get_categoria_padre();

                infoCat.IdEmpresa = param.IdEmpresa;
                infoCat.IdCategoria = (infoCat.IdCategoria != null) ? infoCat.IdCategoria : "0";
                infoCat.IdCategoriaPadre = infoCatPadre.IdCategoria;
                infoCat.ca_nivel = infoCatPadre.ca_nivel +1;

                infoCat.IdUsuario = param.IdUsuario;
                infoCat.Fecha_Transac = param.Fecha_Transac;

                if (infoCat.ca_nivel==1)
                {
                    infoCat.RutaPadre = "";
                }
                else
                {
                    infoCat.RutaPadre = infoCatPadre.RutaPadre + @"\"+ infoCatPadre.ca_Categoria ;
                }
                infoCat.ca_indexIcono = infoCat.ca_nivel;
                infoCat.ca_Categoria = txt_nombre.Text.Trim();
                infoCat.ca_Posicion = Convert.ToInt32(txt_posicion.Value);
                infoCat.Estado = (chk_estado.Checked) ? "A" : "I";
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void get_categoria_padre()
        {
            try
            {
                //infoCatPadre = UCI.get_categoriainfo();

                //if (infoCatPadre == null)
                //{ infoCatPadre = new in_categorias_Info(); }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Boolean validaciones()
        {
            try
            {
                Boolean res = true;

                if (txt_nombre.Text == string.Empty)
                {
                    MessageBox.Show("Debe Ingresar el nombre de la categoría");
                    txt_nombre.Focus();
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
       
        private void frmIn_CategoriaMantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            ReloadGrid();
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

        private void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                grabar();
              //  UCI.cargar_treelist();
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
                if (validaciones())
                {
                    grabar();
                    Close();
                }
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

        public void Limpiar()
        {
            try
            {
                txt_nombre.Text = "";
                txt_posicion.ResetText();

            }
            catch (Exception ex)
            {
                
               Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
