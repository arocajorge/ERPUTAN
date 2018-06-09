using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Info.Academico;
using Core.Erp.Business.Academico;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
namespace Core.Erp.Winform.Academico
{
    public partial class FrmAca_Beca_Estudiante_x_rubros_Mant : Form
    {

        #region variables

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        Aca_contrato_x_estudiante_det_beca_Bus bus_beca_estudiante = new Aca_contrato_x_estudiante_det_beca_Bus();

        List<Aca_Beca_Info> lista_beca = new List<Aca_Beca_Info>();
        Aca_Beca_Bus bus_beca = new Aca_Beca_Bus();
        Aca_Contrato_x_Estudiante_Info info_estudiante;
        BindingList<Aca_contrato_x_estudiante_det_beca_Info> lista_detalle = new BindingList<Aca_contrato_x_estudiante_det_beca_Info>();
      
        #endregion 
  public FrmAca_Beca_Estudiante_x_rubros_Mant()
        {
            InitializeComponent();
            
        }

        private void FrmAca_Beca_Estudiante_x_rubros_Mant_Load(object sender, EventArgs e)
        {
            try
            {


                ucAca_Estudiante1.CargarListEstudiante();



                lista_beca = bus_beca.Get_List_Beca(param.IdInstitucion);
                cmb_beca.Properties.DataSource = lista_beca;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }


        public void Set(Aca_Contrato_x_Estudiante_Info info)
        {
            try
            {
                info_estudiante = new Aca_Contrato_x_Estudiante_Info();
                info_estudiante = info;
                ucAca_Estudiante1.set_Estudiante(info.IdEstudiante);
                ucAca_Estudiante1.cmbEstudiante.Properties.ReadOnly = true;
               

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }


        private void Get()
        {
            try
            {
                foreach (var item in lista_detalle)
                {
                    item.IdBeca =Convert.ToInt32( cmb_beca.EditValue);

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private bool Grabar()
        {
            cmb_beca.Focus();
            try
            {
                Get();
                if (bus_beca_estudiante.Grabar_DB(lista_detalle.Where(v => v.check == true).ToList()))
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_guardaron_los_datos_correctamente), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return true;
                }
                else
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.No_se_guardaron_los_datos), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return false;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                return false;
            }
        }

        private void ucAca_Estudiante1_event_UCAca_Estudiante_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                lista_detalle =new BindingList<Aca_contrato_x_estudiante_det_beca_Info>( bus_beca_estudiante.Get_lista(Convert.ToInt32( info_estudiante.IdInstitucion),Convert.ToInt32(   info_estudiante.IdEstudiante),Convert.ToInt32( info_estudiante.IdContrato), Convert.ToInt32( info_estudiante.IdAnioLectivo)));
                gridControl_rubros.DataSource = lista_detalle;
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.ToString());
            }
        }

        private void cmb_beca_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                Aca_Beca_Info info_beca=new Aca_Beca_Info();
                info_beca=(Aca_Beca_Info)cmb_beca.Properties.View.GetFocusedRow();

                foreach (var item in lista_detalle)
                {
                    if (item.check == true)
                    {
                        item.valor_beca = (item.Valor * info_beca.porcentaje)/100;
                        item.nom_beca = cmb_beca.Text;
                        item.porc_beca = info_beca.porcentaje;
                    }
                    else
                    {
                        item.valor_beca = 0;
                        item.nom_beca = "";
                        item.porc_beca = 0;
                    }
                }


                gridControl_rubros.RefreshDataSource();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.ToString());
            }
        }

        private void ucGe_Menu_Superior_Mant1_event_btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ucGe_Menu_Superior_Mant1_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Grabar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ucGe_Menu_Superior_Mant1_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {

            try
            {
                if (Grabar())
                    this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

    }
}
