using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.Produc_Cirdesus;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Info.General;
using Core.Erp.Business.General;

namespace Core.Erp.Winform.Produc_Cirdesus
{
    public partial class FrmPrd_EtapaModificar : Form
    {
        public FrmPrd_EtapaModificar()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }


        }
        public int IdProcesoProductivo;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        public cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        public prd_EtapaProduccion_Info infoEtapa = new prd_EtapaProduccion_Info();
        List<prd_EtapaProduccion_Info> listaEtapas = new List<prd_EtapaProduccion_Info>();
        prd_EtapaProduccion_Bus bus_Etapas;

        private Core.Erp.Info.General.Cl_Enumeradores.eTipo_action Accion;

        public void Set_Accion(Core.Erp.Info.General.Cl_Enumeradores.eTipo_action _Accion)
        {
            try
            {
               Accion = _Accion;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
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

        private void FrmPrd_EtapaModificar_Load(object sender, EventArgs e)
        {
            try
            {
                switch (Accion)
                {
                    case Core.Erp.Info.General.Cl_Enumeradores.eTipo_action.Anular:
                        this.btn_Siguiente.Text = "Anular Registro";
                        break;
                    default:
                        break;
                }
                carga_combo();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void carga_combo()
        {
            try
            {
                this.cmb_Etapa.DataSource = listaEtapas;
                this.cmb_Etapa.ValueMember = "IdEtapa";
                this.cmb_Etapa.DisplayMember = "NombreEtapa";
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public prd_EtapaProduccion_Info get_Etapa()
        {
            try
            {
                infoEtapa.IdEmpresa = param.IdEmpresa;
                infoEtapa.IdProcesoProductivo = IdProcesoProductivo;
                infoEtapa.IdEtapa = (this.cmb_Etapa.SelectedIndex == -1) ? 0 : Convert.ToInt32(this.cmb_Etapa.SelectedValue);
                infoEtapa.NombreEtapa = (this.cmb_Etapa.SelectedText != "") ? this.cmb_Etapa.SelectedText : "";
                //infoEtapa.PorcentajeEtapa = Convert.ToDouble(this.txt_porcentaje.Text);
                return infoEtapa;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());

                return new prd_EtapaProduccion_Info();
            }

        }


        private void btn_Siguiente_Click(object sender, EventArgs e)
        {
            try
            {
                 if (this.cmb_Etapa.SelectedIndex == -1)
                    {
                        MessageBox.Show("Seleccione una etapa para realizar la respectivo proceso del registro", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        get_Etapa();
                        bus_Etapas = new prd_EtapaProduccion_Bus();
                      
                        switch (Accion)
                        {
                            default:
                                FrmPrd_EtapaMantenimiento frm = new FrmPrd_EtapaMantenimiento();
                                frm.Set_Accion(Core.Erp.Info.General.Cl_Enumeradores.eTipo_action.actualizar);
                                frm.info.IdEtapa = Convert.ToInt32(this.cmb_Etapa.SelectedValue);
                                frm.IdProcesoProductivo = IdProcesoProductivo;
                                frm.Show();
                                this.Close();
                                break;
                        }
                    }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
            



        }
    }
}
