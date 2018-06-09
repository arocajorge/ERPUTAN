using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.Roles;
using Core.Erp.Business.Roles;
using Core.Erp.Business.General;
using Core.Erp.Winform.General;
using Core.Erp.Info.General;
using Core.Erp.Recursos.Properties;
using DevExpress.XtraEditors.Controls;


namespace Core.Erp.Winform.Roles
{
    public partial class frmRo_Empleado_Novedad_Anulacion_Masiva : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        ro_Novedad_Subida_Bach_Bus BusNovedadBach = new ro_Novedad_Subida_Bach_Bus();
        ro_Empleado_Novedad_Bus BusNovedad = new ro_Empleado_Novedad_Bus();
        List<ro_Empleado_Novedad_Info> ListaNovedades = new List<ro_Empleado_Novedad_Info>();
        List<ro_Novedad_Subida_Bach_Info> ListNovedadBact = new List<ro_Novedad_Subida_Bach_Info>();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        ro_Novedad_Subida_Bach_Info InfoNovedadBac = new ro_Novedad_Subida_Bach_Info();
        ro_Empleado_Novedad_Det_Bus BusNovedad_Detalle = new ro_Empleado_Novedad_Det_Bus();


        public frmRo_Empleado_Novedad_Anulacion_Masiva()
        {
            InitializeComponent();
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
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
           // frmRo_WaitForm_Espera FrmEspera = new frmRo_WaitForm_Espera();

            try
            {

              //  FrmEspera.Show();
                bool Bandera_si_Anulo=false;
                if (InfoNovedadBac.IdCalendario != "" && InfoNovedadBac.IdCalendario!=null && ListaNovedades.Count()>0)
                {
                    FrmGe_MotivoAnulacion oFrm = new FrmGe_MotivoAnulacion();
                    if (MessageBox.Show("¿Está seguro que desea anular el reg #: " + InfoNovedadBac.IdCalendario + " ?", "Anulación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        oFrm.ShowDialog();
                            string MotivoAnulacion = oFrm.motivoAnulacion;
                           
                           foreach (var item in ListaNovedades)
                            {
                                item.MotiAnula = MotivoAnulacion;
                                item.IdUsuarioUltAnu = param.IdUsuario;
                                item.Fecha_UltAnu = DateTime.Now;
                                if (BusNovedad.AnularDB(item))
                                {
                                    Bandera_si_Anulo = true;
                                }
                                else
                                {
                                    Bandera_si_Anulo = false;
                                }

                               // anulo detaallle


                                if (BusNovedad_Detalle.AnularDB(Convert.ToDecimal(param.IdEmpresa), InfoNovedadBac.IdCalendario, InfoNovedadBac.IdRubro,item.IdEmpleado,item.IdNovedad,item.Secuencia))
                                {
                                    Bandera_si_Anulo = true;
                                }
                                else
                                {
                                    Bandera_si_Anulo = false;
                                }



                           }

                          
                           if (BusNovedadBach.AnularDB(InfoNovedadBac))
                           {
                               Bandera_si_Anulo = true;

                           }
                           else
                           {
                               Bandera_si_Anulo = false;

                           }

                           if (Bandera_si_Anulo == true)
                           {
                               MessageBox.Show("Anulado con éxito el reg #: " + InfoNovedadBac.IdCalendario);
                               CargarData();
                           }
                           else
                           {
                               MessageBox.Show("No se pudo anular el reg #: " + InfoNovedadBac.IdCalendario + " Debido a: "
                                 , "Anulación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                           }


                        }
                }
                else
                {
                    MessageBox.Show("¡No a Seleccionado ningun Registro!");
                }
                    

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
           
        }

        private void frmRo_Empleado_Novedad_Anulacion_Masiva_Load(object sender, EventArgs e)
        {
            try
            {
                ListNovedadBact = BusNovedadBach.ConsultaGeneral(param.IdEmpresa);
                cmbNovedades.Properties.DataSource = ListNovedadBact;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void cmbNovedades_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                CargarData();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }


        public void CargarData()
        {
            try
            {   InfoNovedadBac = (ro_Novedad_Subida_Bach_Info)cmbNovedades.Properties.View.GetFocusedRow();
                ListaNovedades = BusNovedad.Get_List_Empleado_Novedad_Cab(param.IdEmpresa, InfoNovedadBac.IdCalendario, InfoNovedadBac.IdRubro);
                if (ListaNovedades.Count() == 0)
                {
                    MessageBox.Show("No existe registros"
                                 , "Anulación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    grdListadoNovedades.DataSource = ListaNovedades;
                }


            }
            catch (Exception ex)
            {
                
               MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }


        
    }
}
