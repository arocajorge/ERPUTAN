using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Handlers.Inventario;
using Core.Erp.Winform.Controles;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.Inventario;
using Core.Erp.Info.General;
using Core.Erp.Business.General;

namespace Core.Erp.Winform.Inventario
{
    public partial class frmIn_CategoriaMantenimiento : Form
    {

        //Instancias de Categoria
        public in_categorias_Info _categorioInfo { get; set; }
        public in_categorias_Info _categoriaInfoPadre { get; set; }
        in_categorias_Info infoCat = new in_categorias_Info();
        in_categorias_Info infoCatPadre = new in_categorias_Info();
        in_categorias_bus BusCat = new in_categorias_bus();

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        //User Controls
        UCIN_Categorias UCI = new UCIN_Categorias();

        //Instancias generales del sistema
        private Cl_Enumeradores.eTipo_action Accion;
        private Cl_Enumeradores.eTipo_action _Accion;
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        public void set_Accion(Cl_Enumeradores.eTipo_action iAccion)
        {
            try
            {
                    Accion = iAccion;
                    switch (Accion)
                    {
                        case Cl_Enumeradores.eTipo_action.grabar:
                            this.btn_guardar.Text = "Grabar Registro";
                            break;
                        case Cl_Enumeradores.eTipo_action.actualizar:
                            this.btn_guardar.Text = "Actualizar Registro";
                  

                            break;
                        case Cl_Enumeradores.eTipo_action.consultar:
                

                            this.btn_guardar.Visible = false;
                            break;
                        default:
                            break;
                    }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
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
            }

        }

        public void set_categoria(in_categorias_Info categoriaInfo)
        {
            try
            {
                _categorioInfo = categoriaInfo;
                txt_nombre.Text = _categorioInfo.ca_Categoria;
                txt_posicion.Value = _categorioInfo.ca_Posicion;
                chk_estado.Checked = (_categorioInfo.Estado == "S") ? true : false;

                infoCat = categoriaInfo;
              
                

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
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
            }

        }

        public frmIn_CategoriaMantenimiento()
        {
            try
            {
                InitializeComponent();
                    ReloadGrid+=frmIn_CategoriaMantenimiento_ReloadGrid;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        void frmIn_CategoriaMantenimiento_ReloadGrid(){}


        UCIN_CtsContablesParaContabilizar ctrl_ctasContables;
        in_Parametro_Bus bus = new in_Parametro_Bus();
        private void frmIn_CategoriaMantenimiento_Load(object sender, EventArgs e)
        {
            try
            {
                var info = bus.ObtenerParametros(param.IdEmpresa);
                UCI.set_Treelist_SelectMultiple(false);
                UCI.set_Treelist_ShowCheckBoxes(true);
                UCI.set_Solo_chequea_unItem(true);
                this.groupBox1.Controls.Add(UCI);
                UCI.Dock = DockStyle.Fill;
                UCI.set_CategoriaCheckedSelection(_categoriaInfoPadre);

                ctrl_ctasContables = new UCIN_CtsContablesParaContabilizar(info.IdCtaCble_Inven, info.IdCentro_Costo_Inventario, info.IdCtaCble_CostoInven, info.IdCentro_Costo_Costo);
                ctrl_ctasContables.Dock = DockStyle.Fill;
                tabPage2.Controls.Add(ctrl_ctasContables);



                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        ctrl_ctasContables.setValores(infoCat.IdCtaCtble_Inve, infoCat.IdCentro_Costo_Inventario, infoCat.IdCtaCtble_Costo, infoCat.IdCentro_Costo_Costo);
                        break;
                    case Cl_Enumeradores.eTipo_action.borrar:
                        ctrl_ctasContables.setValores(infoCat.IdCtaCtble_Inve, infoCat.IdCentro_Costo_Inventario, infoCat.IdCtaCtble_Costo, infoCat.IdCentro_Costo_Costo);
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        ctrl_ctasContables.setValores(infoCat.IdCtaCtble_Inve, infoCat.IdCentro_Costo_Inventario, infoCat.IdCtaCtble_Costo, infoCat.IdCentro_Costo_Costo);
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
           

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            try
            {
               this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                grabar();
                UCI.cargar_treelist();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }


            
        }

        private void grabar()
        {
            try
            {
                if (validaciones() == false)
                    MessageBox.Show("No se grabó");
                else
                {
                    get_categoria();
                    string msg = "";
                    switch (Accion)
                    {
                        case Cl_Enumeradores.eTipo_action.grabar:
                            BusCat.GrabarDB(param.IdEmpresa, infoCat, ref msg);
                            MessageBox.Show(msg,"SISTEMA",MessageBoxButtons.OK,MessageBoxIcon.Information);
                            set_Accion(Cl_Enumeradores.eTipo_action.actualizar);
                            break;
                        case Cl_Enumeradores.eTipo_action.actualizar:
                            BusCat.ModificarDB(param.IdEmpresa, infoCat, ref msg);
                            MessageBox.Show(msg,"SISTEMA",MessageBoxButtons.OK,MessageBoxIcon.Information);
                            break;
                        default:
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
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

                infoCat.IdCtaCtble_Costo= ctrl_ctasContables.Obtener_CbtCbleCosto();
                infoCat.IdCtaCtble_Inve = ctrl_ctasContables.Obtener_CtaCbleInventario();

                infoCat.IdCentro_Costo_Costo = ctrl_ctasContables.Obtener_CentroDeCosotoCosto();
                infoCat.IdCentro_Costo_Inventario = ctrl_ctasContables.Obtener_CentroCostoInventario();
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void get_categoria_padre()
        {
            try
            {
                infoCatPadre = UCI.get_categoriainfo();

                if (infoCatPadre == null)
                { infoCatPadre = new in_categorias_Info(); }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private Boolean validaciones()
        {
            try
            {
                if (txt_nombre.Text == string.Empty)
                {
                    MessageBox.Show("Debe ingresarm el nombre de la categoría");
                    return false;
                }
                else
                    return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }
        }

        public delegate void DelegadoRefrescar();
        public event DelegadoRefrescar ReloadGrid;
        private void frmIn_CategoriaMantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
               ReloadGrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void btnGuardarySAlie_Click(object sender, EventArgs e)
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
            }

        }
    }
}
