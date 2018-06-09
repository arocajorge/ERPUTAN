using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Business.Produc_Cirdesus;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using Core.Erp.Winform.Controles;
using Core.Erp.Info.Roles;
using Core.Erp.Business.Roles;
using DevExpress.XtraEditors;


namespace Core.Erp.Winform.Produc_Cirdesus
{
    public partial class FrmPrd_AsignarGT_P_ProductivoMantenimiento : Form
    {
        public FrmPrd_AsignarGT_P_ProductivoMantenimiento()
        {
            InitializeComponent();
        }
        string MensajeError = "";
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        prd_ProcesoProductivo_Bus BusModeloxCC = new prd_ProcesoProductivo_Bus();
        prd_EtapaProduccion_Bus BusEtapasProduccion = new prd_EtapaProduccion_Bus();
        prd_SubGrupoTrabajo_Bus BusSubgrupos = new prd_SubGrupoTrabajo_Bus();
        prd_GruposTrabajo_PorPP_Bus busGruposProcesoP = new prd_GruposTrabajo_PorPP_Bus();
        BindingList<prd_SubGrupoTrabajo_Info> Lista = new BindingList<prd_SubGrupoTrabajo_Info>();
        List<prd_GruposTrabajo_PorPP_Info> ListaGrabar = new List<prd_GruposTrabajo_PorPP_Info>();
        private Cl_Enumeradores.eTipo_action Accion;
        private void cargaCmbE_ModeloProduccion()
        {
            try
            {
                CmbProcesoProductivo.Properties.DataSource = BusModeloxCC.ObtenerProcesProductivo(param.IdEmpresa);
                

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        private void cargaCmbE_EtapasProduccion(int IdModelo)
        {
            try
            {
                if (IdModelo != null)
                {

                    CmbEtapas.Properties.DataSource = BusEtapasProduccion.ObtenerListaEtapas(param.IdEmpresa, IdModelo);
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        private void FrmPrd_AsignarGT_P_ProductivoMantenimiento_Load(object sender, EventArgs e)
        {
            try
            {
                cargaCmbE_ModeloProduccion();

                if (Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    CargarSubGruposTrabajo();

                }
               
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
        }


        public void set_Accion(Cl_Enumeradores.eTipo_action iAccion)
        {
            try
            {
                Accion = iAccion;
                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:



                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                       
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:

                       
                        break;

                    case Cl_Enumeradores.eTipo_action.Anular:

                      

                        break;
                    default:
                        break;
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }

        }


        public void CargarSubGruposTrabajo()
        {
            try
            {
                Lista = new BindingList<prd_SubGrupoTrabajo_Info>(BusSubgrupos.GetListSubGruposTrabajo(param.IdEmpresa, param.IdSucursal));
                gridControlSubgrupos.DataSource = Lista;
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
        }

        public bool Get()
        {
            CmbEtapas.Focus();
            try
            {
                if (CmbProcesoProductivo.Text == "" || CmbProcesoProductivo.EditValue==null)
                {
                    MessageBox.Show("Seleccione un proceso productivo");
                    return false;
                }

                if (CmbEtapas.Text == "" || CmbEtapas.EditValue == null)
                {
                    MessageBox.Show("Seleccione etapa proceso productivo");
                    return false;
                }

                foreach (var item in Lista)
                {
                    if (item.check == true)
                    {

                        prd_GruposTrabajo_PorPP_Info Info = new prd_GruposTrabajo_PorPP_Info();
                        Info.IdEtapa =Convert.ToInt32( CmbEtapas.EditValue);
                        Info.IdProcesoProductivo =Convert.ToInt32(CmbProcesoProductivo.EditValue);
                        Info.IdGrupoTrabajo = item.idGrupo;
                        Info.IdSubgrupo =(int) item.IdGrupoTrabajo;
                        ListaGrabar.Add(Info);

                    }
                }


                if (ListaGrabar.Count == 0)
                {
                    MessageBox.Show("Error no ha seleccionado Ninguno Grupos para la Etapa" + CmbEtapas.Text);
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
                return false;
            }
        }


        public void Grabar()
        {
            try
            {
                switch (Accion)
                {
                   
                        
                     case   Cl_Enumeradores.eTipo_action.grabar:

                        if (busGruposProcesoP.GrabaDB(ListaGrabar, ref MensajeError))
                        {
                            MessageBox.Show("Se grabado con exito");
                            ListaGrabar = new List<prd_GruposTrabajo_PorPP_Info>();
                            CargarSubGruposTrabajo();
                        }
                            else
                            {
                                MessageBox.Show(MensajeError);
                            }
                        
                        break;
                }

            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
        }

        private void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
               if( Get())
                Grabar();

            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
        }

        private void CmbProcesoProductivo_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                cargaCmbE_EtapasProduccion(Convert.ToInt32( CmbProcesoProductivo.EditValue));
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
        }


        public void Set(prd_GruposTrabajo_PorPP_Info Info)
        {
            try
            {
                CmbEtapas.EditValue = Info.IdEtapa;
                CmbProcesoProductivo.EditValue = Info.IdProcesoProductivo;

                ListaGrabar = busGruposProcesoP.GetListaGruposTrabajosEtapas(Info);
                gridControlSubgrupos.DataSource = ListaGrabar;


            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
        }

        private void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (Get())
                    Grabar();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                
               MessageBox.Show(ex.Message);
            }
        }
    }
}
