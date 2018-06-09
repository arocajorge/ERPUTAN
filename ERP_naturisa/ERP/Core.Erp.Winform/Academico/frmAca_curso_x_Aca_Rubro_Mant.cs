using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using Core.Erp.Info.Academico;
using Core.Erp.Business.Academico;

namespace Core.Erp.Winform.Academico
{
    public partial class frmAca_curso_x_Aca_Rubro_Mant : Form
    {
        #region Variables
        string mensaje = "";
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        Aca_curso_x_Aca_Rubro_Info RubrosInfo = new Aca_curso_x_Aca_Rubro_Info();
        
        List<vwAca_curso_Info> Lista_Curso;
        List<Aca_Rubro_Info> listRubro = new List<Aca_Rubro_Info>();

        BindingList<Aca_curso_x_Aca_Rubro_Info> listaRubro_x_curso = new BindingList<Aca_curso_x_Aca_Rubro_Info>();

        #endregion

        public frmAca_curso_x_Aca_Rubro_Mant()
        {
            InitializeComponent();
            cmb_rubro.EditValueChanged += cmb_rubro_EditValueChanged;
        }

        #region Funciones


        #region "Funciones Get y Set"

        public List<Aca_curso_x_Aca_Rubro_Info> Get_list_Rubro_xCurso()
        {
            try
            {
                cmbCurso.Focus();
                List<Aca_curso_x_Aca_Rubro_Info> lista = new List<Aca_curso_x_Aca_Rubro_Info>();

                foreach (var item in listaRubro_x_curso)
                {
                    Aca_curso_x_Aca_Rubro_Info Info = new Aca_curso_x_Aca_Rubro_Info();
                    Info.IdCurso = Convert.ToInt32(cmbCurso.EditValue);
                    Info.IdRubro = item.IdRubro;
                    Info.observacion = item.observacion;
                    lista.Add(Info);
                }
                return lista;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                mensaje = ex.Message.ToString();
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return new List<Aca_curso_x_Aca_Rubro_Info>();
            }
        }

        public void Set(Aca_curso_x_Aca_Rubro_Info Info)
        {
            try
            {
                RubrosInfo = Info;
            }
            catch (Exception ex)
            {
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ":" + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(ex.ToString()); 
            }
        }
        #endregion

        public void Cargar_Combos()
        {
            try
            {
                vwAca_curso_Bus neg = new vwAca_curso_Bus();
                Lista_Curso = new List<vwAca_curso_Info>();
                Lista_Curso = neg.Get_List_Curso(ref mensaje);
                cmbCurso.Properties.DataSource = Lista_Curso;

                Aca_Rubro_Bus BusRubro = new Aca_Rubro_Bus();
                listRubro = BusRubro.Get_List_Rubro();

                cmb_rubro.DataSource = listRubro;
            }
            catch (Exception ex)
            {
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ":" + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void Limpiar()
        {
            try
            {
                cmbCurso.EditValue = null;
                listaRubro_x_curso = new BindingList<Aca_curso_x_Aca_Rubro_Info>();
                gridControlCurso_Rubros.DataSource = listaRubro_x_curso; 
            }
            catch (Exception ex)
            {
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ":" + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        Boolean Grabar()
        {
            bool resultado = false;
            try
            {
                List<Aca_curso_x_Aca_Rubro_Info> ListaInfo = new List<Aca_curso_x_Aca_Rubro_Info>();
                Aca_curso_x_Aca_Rubro_Bus Rubro_x_Curso_Bus = new Aca_curso_x_Aca_Rubro_Bus();
                ListaInfo = Get_list_Rubro_xCurso();
                if (Rubro_x_Curso_Bus.EliminarDB(Convert.ToInt32(cmbCurso.EditValue), ref mensaje))
                {
                    resultado = Rubro_x_Curso_Bus.GuardarDB(ListaInfo, ref mensaje);
                }
                if (resultado != false)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_guardaron_los_datos_correctamente), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.No_se_guardaron_los_datos), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                return resultado;
            }
            catch (Exception ex)
            {
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ":" + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(ex.ToString()); return false;
            }
        }

        #endregion

        private void frmAca_curso_x_Aca_Rubro_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                gridControlCurso_Rubros.DataSource = listaRubro_x_curso;
                Cargar_Combos();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_Superior_Mant1_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_Superior_Mant1_event_btnlimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                Limpiar();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_Superior_Mant1_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Grabar())
                    Limpiar();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_Superior_Mant1_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (Grabar())
                    Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbCurso_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                int IdCurso=0;

                if (cmbCurso.EditValue != null)
                {
                    if (cmbCurso.EditValue != "")
                    {
                        IdCurso = (int)cmbCurso.EditValue;

                        Aca_curso_x_Aca_Rubro_Bus BusRubro = new Aca_curso_x_Aca_Rubro_Bus();

                        listaRubro_x_curso = new BindingList<Aca_curso_x_Aca_Rubro_Info>();

                        listaRubro_x_curso = new BindingList<Aca_curso_x_Aca_Rubro_Info>(BusRubro.Get_List_Rubros_x_Curso(IdCurso, ref mensaje));

                        gridControlCurso_Rubros.DataSource = listaRubro_x_curso;
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewCurso_Rubros_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if(e.KeyCode==Keys.Delete)
                    gridViewCurso_Rubros.DeleteSelectedRows();
            }
            catch (Exception ex)
            {

                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void cmb_rubro_EditValueChanged(object sender, EventArgs e)
        {
            int cont = 0;
            try
            {
                foreach (var item in listaRubro_x_curso)
                {
                    Aca_curso_x_Aca_Rubro_Info row = new Aca_curso_x_Aca_Rubro_Info();
                    row = item;

                    if (row != null)
                    {
                        if (row.IdRubro != 0)
                        {
                            cont = listaRubro_x_curso.Where(q => q.IdRubro == row.IdRubro).Count();
                        }
                    }

                    if (cont > 1)
                    {
                        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.El_rubro_ya_se_encuentra_seleccionado_Se_procedera_a_eliminar), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        gridViewCurso_Rubros.DeleteSelectedRows();
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
