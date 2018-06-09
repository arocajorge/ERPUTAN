using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Info.General;
using Core.Erp.Business.General;



namespace Core.Erp.Winform.Contabilidad
{
    public partial class frmCon_Cierre_Periodo_x_Modulo : Form
    {
        #region Variables
        string MensajeError = "";
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        ct_Periodo_Bus BusPeriodo = new ct_Periodo_Bus();
        List<ct_Periodo_Info> ListPeriodo = new List<ct_Periodo_Info>();
        ct_Periodo_Info InfoPeriodo = new ct_Periodo_Info();
        tb_modulo_Bus bus_modulo = new tb_modulo_Bus();
        List<tb_modulo_Info> lst_modulo = new List<tb_modulo_Info>();
        ct_periodo_x_tb_modulo_Bus bus_periodo_x_modulo = new ct_periodo_x_tb_modulo_Bus();
        List<ct_periodo_x_tb_modulo_Info> lst_periodo_x_modulo = new List<ct_periodo_x_tb_modulo_Info>();
        #endregion

        public frmCon_Cierre_Periodo_x_Modulo()
        {
            InitializeComponent();
        }

        private void frmCon_Cierre_Periodo_x_Modulo_Load(object sender, EventArgs e)
        {
            cargar_combos();
        }

        private void cargar_combos()
        {
            try
            {
                ListPeriodo = BusPeriodo.Get_List_Periodo(param.IdEmpresa, ref MensajeError);
                cmb_periodo.Properties.DataSource = ListPeriodo;

                lst_modulo = bus_modulo.Get_list_Modulo(true);

                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


       

       private void cmb_periodo_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmb_periodo.EditValue != null)
                {
                    InfoPeriodo = BusPeriodo.Get_Info_Periodo(param.IdEmpresa, Convert.ToInt32(cmb_periodo.EditValue), ref MensajeError);

                    lblFechaIni.Text = InfoPeriodo.pe_FechaIni.Date.ToShortDateString();
                    lblfechaFin.Text = InfoPeriodo.pe_FechaFin.Date.ToShortDateString();
                    chk_periodo_cerrado.Checked = (InfoPeriodo.pe_cerrado == "S") ? true : false;

                    int Anio_a_buscar = 0;
                    if (InfoPeriodo.pe_mes == 12) //es fin de año
                    {
                        Anio_a_buscar = InfoPeriodo.IdanioFiscal;
                        btn_cierre_anual.Enabled = true;
                    }
                    else
                    {
                        Anio_a_buscar = InfoPeriodo.IdanioFiscal-1;
                        btn_cierre_anual.Enabled = false;


                    }


                    ct_anio_fiscal_x_cuenta_utilidad_Bus BusAnioF = new ct_anio_fiscal_x_cuenta_utilidad_Bus();
                    ct_anio_fiscal_x_cuenta_utilidad_Info InfoAnioF = new ct_anio_fiscal_x_cuenta_utilidad_Info();
                    InfoAnioF = BusAnioF.Get_Info_anioF_x_Cta(InfoPeriodo.IdEmpresa, Anio_a_buscar, ref MensajeError);

                    if (InfoAnioF.IdCbteCble_cbte_cierre == null)
                    {

                        ct_AnioFiscal_Info Info_AnioFiscal = new ct_AnioFiscal_Info();
                        ct_AnioFiscal_Bus Bus_AnioFiscal = new ct_AnioFiscal_Bus();
                        Info_AnioFiscal = Bus_AnioFiscal.Get_Info_Anio_fiscal(Anio_a_buscar);

                        if (Info_AnioFiscal.IdanioFiscal > 0 && Info_AnioFiscal.af_estado == "A")
                        {
                            lblmensaje_no_cierra.Text = "El año " + Anio_a_buscar + " no esta cerrado.. verifique o cierrelo";
                            lblmensaje_no_cierra.ForeColor = Color.Red;
                        }
                        else
                        {
                            lblmensaje_no_cierra.Text = "";
                            lblmensaje_no_cierra.ForeColor = Color.Red;
                        }
                        
                    }
                    else
                    {
                        lblmensaje_no_cierra.Text = "El año " + Anio_a_buscar + " ESTA CERRADO..";
                        lblmensaje_no_cierra.ForeColor = Color.Blue;
                        
                    }




                    cargar_modulo_X_periodo();

                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Get_periodo_x_modulo()
        {
            try
            {
                lst_periodo_x_modulo = new List<ct_periodo_x_tb_modulo_Info>();
                foreach (tb_modulo_Info item_chk in chk_modulos.Items.GetCheckedValues())
                {
                    ct_periodo_x_tb_modulo_Info info = new ct_periodo_x_tb_modulo_Info();
                    info.IdEmpresa = param.IdEmpresa;
                    info.IdModulo = item_chk.CodModulo;
                    info.IdPeriodo = Convert.ToInt32(cmb_periodo.EditValue);
                    info.Cerrado = true;
                    info.IdUsuario = param.IdUsuario;
                    info.FechaTransac = param.Fecha_Transac;
                    lst_periodo_x_modulo.Add(info);
                }
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
                if (!Validar()) return false;

                Boolean respuesta = false;
                
                Get_periodo_x_modulo();

                if (bus_periodo_x_modulo.EliminarDB(param.IdEmpresa, Convert.ToInt32(cmb_periodo.EditValue), ref MensajeError))
                {
                    respuesta = bus_periodo_x_modulo.GrabarDB(lst_periodo_x_modulo, ref MensajeError);

                    string SPeriodoCerrado=  (chk_periodo_cerrado.Checked ==true)?"S":"N";
                    BusPeriodo.Modificar_Estado_CierreDB(param.IdEmpresa, InfoPeriodo.IdPeriodo, SPeriodoCerrado, ref MensajeError);

                }


               
                if (respuesta)
                {
                    MessageBox.Show("Transacción realizada exitosamente", param.Nombre_sistema, MessageBoxButtons.OK);
                }
                return respuesta;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }        

        private bool Validar()
        {
            try
            {
                if (cmb_periodo.EditValue == null )
                {
                    MessageBox.Show("Seleccione el periodo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void ucGe_Menu_Superior_Mant1_event_btnSalir_Click(object sender, EventArgs e)
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

        private void ucGe_Menu_Superior_Mant1_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Guardar())
                {
                    cmb_periodo.EditValue = null;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_Superior_Mant1_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (Guardar())
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

        private void cargar_modulo_X_periodo()
        {

            try
            {
                lst_periodo_x_modulo = new List<ct_periodo_x_tb_modulo_Info>();
                lst_periodo_x_modulo = bus_periodo_x_modulo.Get_List_Periodo(param.IdEmpresa, Convert.ToInt32(cmb_periodo.EditValue), ref MensajeError);

                CheckState EstadoCheck;

                chk_modulos.Items.Clear();
                foreach (tb_modulo_Info itemModulo in lst_modulo)
                {
                    EstadoCheck = CheckState.Unchecked;

                    foreach (ct_periodo_x_tb_modulo_Info itemModulo2 in lst_periodo_x_modulo)
                    {
                        if (itemModulo2.IdModulo == itemModulo.CodModulo && itemModulo2.Cerrado == true)
                        {
                            EstadoCheck = CheckState.Checked;
                        }
                    }
                    chk_modulos.Items.Add(itemModulo, itemModulo.Descripcion, EstadoCheck, true);
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btn_cierre_anual_Click(object sender, EventArgs e)
        {
            try
            {
                string MensajeError="";

                ct_ProcesosContables_Bus BusProcesosContables = new ct_ProcesosContables_Bus(InfoPeriodo);
                if (BusProcesosContables.ProcesoCierreAnual(InfoPeriodo, ref MensajeError))
                {
                    MessageBox.Show("Diario por cierre fue creado Correctamente..." + MensajeError, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al Generar el diario por cierre Anual Consulte con sistemas " + MensajeError, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
