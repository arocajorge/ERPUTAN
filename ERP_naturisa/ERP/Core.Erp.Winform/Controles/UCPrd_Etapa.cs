using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Winform.Produc_Cirdesus;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Business.Produc_Cirdesus;
using Core.Erp.Business.General;
using Core.Erp.Info.General;


namespace Core
{
    public partial class UCPrd_EtapaProduccion : UserControl
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        public string idEtapaAnterior;
        public int idEtapa;
        public int idProcesoProductivo;
        FrmPrd_EtapaMantenimiento frm = new FrmPrd_EtapaMantenimiento();
        prd_EtapaProduccion_Bus bus_Etapas = new prd_EtapaProduccion_Bus();
        prd_EtapaProduccion_Info infoEtapa = new prd_EtapaProduccion_Info();
        public cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        List<prd_EtapaProduccion_Info> ls = new List<prd_EtapaProduccion_Info>();
        

        public void set_ListaEtapas(List<prd_EtapaProduccion_Info> lss)
        {
            try
            {
                ls = lss;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        
        }

        public UCPrd_EtapaProduccion()
        {
            try
            {
                InitializeComponent();
                event_lblEtapa_DoubleClick += UCPrd_EtapaProduccion_event_lblEtapa_DoubleClick;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }


        }

        void UCPrd_EtapaProduccion_event_lblEtapa_DoubleClick(object sender, EventArgs e){}

        public void set_etapa(string cad)
        {
            try
            {
              this.lblEtapa.Text = cad;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        public void set_IdEtapa(int cad)
        {
            try
            {
               this.idEtapa = cad;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }


        public void set_idEtapaAntLabel(string cad)
        {
            try
            {
                  this.lbl_idEtapaAnt.Text = cad;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        public void set_idProcesoProductivo(int cad)
        {
            try
            {
                 this.idProcesoProductivo = cad;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        public void set_porcentaje(string cad)
        {
            try
            {
               this.lblporc.Text = cad;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        private void lblEtapa_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                get_Etapa();
                bus_Etapas = new prd_EtapaProduccion_Bus();

                        frm = new FrmPrd_EtapaMantenimiento();
                        frm.Set_Accion(Cl_Enumeradores.eTipo_action.actualizar);
                
                        frm.info.IdEtapa = Convert.ToInt32(idEtapa);
                        frm.IdProcesoProductivo = this.idProcesoProductivo;
                        frm.listaEtapas = ls;
                        frm.Show();

                        event_lblEtapa_DoubleClick(sender, e);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
                
        }

        public delegate void delegate_lblEtapa_DoubleClick(object sender, EventArgs e);
        public event delegate_lblEtapa_DoubleClick event_lblEtapa_DoubleClick;

    public prd_EtapaProduccion_Info get_Etapa()
        {
            try
            {
                infoEtapa.IdEmpresa = param.IdEmpresa;
                infoEtapa.IdProcesoProductivo = this.idProcesoProductivo;
                infoEtapa.IdEtapa = Convert.ToInt32(idEtapa);
                return infoEtapa;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new prd_EtapaProduccion_Info();
            }

        }
    }
}
