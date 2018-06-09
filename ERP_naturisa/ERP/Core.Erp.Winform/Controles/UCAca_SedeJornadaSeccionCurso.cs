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

namespace Core.Erp.Winform.Controles
{
    public partial class UCAca_SedeJornadaSeccionCurso : UserControl
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        public List<Aca_Curso_Info> Lista_Curso = new List<Aca_Curso_Info>();
        public delegate void delegate_cmbSeccion_EditValueChanged(object sender, EventArgs e);
        public event delegate_cmbSeccion_EditValueChanged event_cmbSeccion_EditValueChanged;

        public UCAca_SedeJornadaSeccionCurso()
        {
            InitializeComponent();
            event_cmbSeccion_EditValueChanged += UCAca_SedeJornadaSeccionCurso_event_cmbSeccion_EditValueChanged;
        }

        void UCAca_SedeJornadaSeccionCurso_event_cmbSeccion_EditValueChanged(object sender, EventArgs e)
        {
           
        }

        public void CargarCombos() {
            try
            {
                Aca_Sede_Bus negSede = new Aca_Sede_Bus();
                cmbSede.Properties.DataSource = negSede.Get_List_Sede(param.IdInstitucion);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void UCAca_SedeJornadaSeccionCurso_Load(object sender, EventArgs e)
        {
            CargarCombos();
        }

        public void cmbSede_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if ( cmbSede.EditValue!=null && cmbSede.EditValue!="")
                {
                   Aca_Jornada_Bus negJornada = new Aca_Jornada_Bus();
                   cmbJornada.Properties.DataSource = negJornada.Get_List_Jornada(param.IdInstitucion, Convert.ToInt16(cmbSede.EditValue));
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void cmbJornada_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbJornada.EditValue!=null && cmbJornada.EditValue!="")
                {
                    Aca_Seccion_Bus negSeccion = new Aca_Seccion_Bus();
                    cmbSeccion.Properties.DataSource = negSeccion.Get_List_Seccion(param.IdInstitucion, Convert.ToInt16(cmbJornada.EditValue));    
                }                
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void cmbSeccion_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbSeccion.EditValue!=null && cmbSeccion.EditValue!="")
                {
                    Aca_Curso_Bus negCurso = new Aca_Curso_Bus();
                    Lista_Curso = new List<Aca_Curso_Info>();
                    Lista_Curso = negCurso.Get_List_Curso(param.IdInstitucion,Convert.ToInt16(cmbSeccion.EditValue)); 
                    cmbCurso.Properties.DataSource = Lista_Curso;
                    this.event_cmbSeccion_EditValueChanged(sender, e); 
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void cmbCurso_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbCurso.EditValue!=null && cmbCurso.EditValue!="")
                {
                    Aca_Paralelo_Bus negParalelo = new Aca_Paralelo_Bus();
                    cmbParalelo.Properties.DataSource = negParalelo.Get_List_Paralelo(Convert.ToInt32(cmbCurso.EditValue));
                }
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
