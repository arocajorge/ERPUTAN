using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Business.General;
using Core.Erp.Business.Academico;
using Core.Erp.Info.Academico;
using Core.Erp.Winform.Academico;



namespace Core.Erp.Winform.Controles
{
    public partial class UCAca_Estudiante : UserControl
    {
        #region "Variables"
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        public delegate void delegate_UCAca_Estudiante_EditValueChanged(object sender, EventArgs e);
        public event delegate_UCAca_Estudiante_EditValueChanged event_UCAca_Estudiante_EditValueChanged;

        public delegate void delegadoUCAca_Estudiante_SelectionChanged(object sender, EventArgs e);
        public event delegadoUCAca_Estudiante_SelectionChanged Event_UCAca_Estudiante_SelectionChanged;

        public delegate void delegadoUCAca_Estudiante_Validating(object sender, CancelEventArgs e);
        public event delegadoUCAca_Estudiante_Validating Event_UCAca_Estudiante_Validating;

        public List<Aca_Familiar_Info> listaFamiliar;

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        List<Aca_Estudiante_Info> lista = new List<Aca_Estudiante_Info>();
        List<Aca_Estudiante_Info> listEstudiante = new List<Aca_Estudiante_Info>();
        Aca_Estudiante_Bus EstudianteBus = new Aca_Estudiante_Bus();
        Aca_Estudiante_Info Info_Estudiante = new Aca_Estudiante_Info();
        #endregion

        public UCAca_Estudiante()
        {
            try
            {
                InitializeComponent();
                listaFamiliar = new List<Aca_Familiar_Info>();
                event_UCAca_Estudiante_EditValueChanged += UCAca_Estudiante_event_UCAca_Estudiante_EditValueChanged;

                this.Event_UCAca_Estudiante_SelectionChanged += new delegadoUCAca_Estudiante_SelectionChanged(FuncAca_Estudiante_SelectionChanged);
                this.Event_UCAca_Estudiante_Validating += new delegadoUCAca_Estudiante_Validating(UCAca_Estudiante_Event_UCAca_Estudiante_Validating);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }     
        }

        void UCAca_Estudiante_event_UCAca_Estudiante_EditValueChanged(object sender, EventArgs e)
        {
            
        }
        void UCAca_Estudiante_Event_UCAca_Estudiante_Validating(object sender, CancelEventArgs e) { }

        void FuncAca_Estudiante_SelectionChanged(object sender, EventArgs e) { }
     


        public void CargarListEstudiante() {
            try
            {
                Aca_Estudiante_Bus neg = new Aca_Estudiante_Bus();
                lista = new List<Aca_Estudiante_Info>();
                lista = neg.Get_List_Estudiantes(param.IdInstitucion);
                cmbEstudiante.Properties.DataSource = lista;
            }
            catch (Exception ex)
            {
                
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                
            }        
        }
        public void CargaListEstudiante_x_RepresentateEconomico(decimal IdFamiliar)
        {
            try
            {
                Aca_Estudiante_Bus neg = new Aca_Estudiante_Bus();                
                lista = new List<Aca_Estudiante_Info>();

                lista = neg.GetListEstudiante_x_RepresentateEconomico(param.IdInstitucion, IdFamiliar);
                listEstudiante = lista;
                cmbEstudiante.Properties.DataSource = lista;
            }
            catch (Exception ex)
            {

                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());

            }
        }



        private void UCAca_Estudiante_Load(object sender, EventArgs e)
        {
            //CargarComboEstudiante();
        }


        public void set_Estudiante(decimal IdEstudiante)
        {
            try
            {
                cmbEstudiante.EditValue = IdEstudiante;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }
        public Aca_Estudiante_Info Get_Estudiante()
        {
            try
            {
                
                Info_Estudiante = new Aca_Estudiante_Info();
                if (cmbEstudiante.EditValue != null)
                {
                    Info_Estudiante = lista.FirstOrDefault(v => v.IdEstudiante == Convert.ToDecimal(cmbEstudiante.EditValue));
                }
                return Info_Estudiante;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new Aca_Estudiante_Info();
            }
        }

        private void cmbEstudiante_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                
                if (cmbEstudiante.EditValue != string.Empty && cmbEstudiante.EditValue != null && cmbEstudiante.Text != "")
                {
                    decimal IDEstudiante = Convert.ToDecimal(cmbEstudiante.EditValue);
                    BuscarFamiliar(IDEstudiante);

                    this.Event_UCAca_Estudiante_SelectionChanged(sender, e);

                    this.event_UCAca_Estudiante_EditValueChanged(sender, e);


                }              
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void BuscarFamiliar(decimal IdEstudiante) {
            try
            {
                Aca_Familiar_Bus neg = new Aca_Familiar_Bus();
                listaFamiliar = neg.Get_List_Familiar_x_Estudiante(param.IdInstitucion, IdEstudiante);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void UCAca_Estudiante_Leave(object sender, EventArgs e)
        {
        }
        public void CargarListEstudiante_sin_Matricula()
        {
            try
            {
                Aca_Estudiante_Bus neg = new Aca_Estudiante_Bus();                
                lista = new List<Aca_Estudiante_Info>();
                lista = neg.Get_List_Estudiantes_Sin_Matricula(param.IdInstitucion);
                cmbEstudiante.Properties.DataSource = lista;
            }
            catch (Exception ex)
            {

                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());

            }
        }
    }
}
