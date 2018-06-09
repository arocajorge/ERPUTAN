using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.Roles;
using Core.Erp.Info.Roles;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using System.IO;
using System.Data.OleDb;
using Core.Erp.Winform.General;
using Core.Erp.Recursos.Properties;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Business.Produc_Cirdesus;
namespace Core.Erp.Winform.Produc_Cirdesus
{
    public partial class Frm_ProductividadSubgrupoTrabajo_Mantenimiento : Form
    {
        ro_periodo_x_ro_Nomina_TipoLiqui_Bus Bus_PerNomTipoliq = new ro_periodo_x_ro_Nomina_TipoLiqui_Bus();
        List< ro_periodo_x_ro_Nomina_TipoLiqui_Info >lista = new List<ro_periodo_x_ro_Nomina_TipoLiqui_Info>();
        ro_Nomina_Tipoliqui_Bus busProc = new ro_Nomina_Tipoliqui_Bus();
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        List<ro_Empleado_Novedad_Det_Info> LstEmp = new List<ro_Empleado_Novedad_Det_Info>();
        ro_rubro_tipo_Bus busRubro = new ro_rubro_tipo_Bus();
        ro_Nomina_Tipo_Bus busNominaTip = new ro_Nomina_Tipo_Bus();
        List<prd_Obra_Info> ListObra = new List<prd_Obra_Info>();
        prd_Obra_Bus BusObra = new prd_Obra_Bus();
        List<prd_OrdenTaller_Info> ListOrdenTaller= new List<prd_OrdenTaller_Info>();
        prd_OrdenTaller_Bus BusOrdenTaller = new prd_OrdenTaller_Bus();


        List<prd_GrupoTrabajo_Info> ListaGt = new List<prd_GrupoTrabajo_Info>();
        prd_GrupoTrabajo_Bus BusGt = new prd_GrupoTrabajo_Bus();

      List<  prd_SubGrupoTrabajo_Info >ListSubGrupoTrabajo = new List <prd_SubGrupoTrabajo_Info>(); //esta es para el get
        prd_SubGrupoTrabajo_Bus BusCabeceraGT = new prd_SubGrupoTrabajo_Bus();





        string Msg = "";

        public Frm_ProductividadSubgrupoTrabajo_Mantenimiento()
        {
            InitializeComponent();
        }

        private void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {

        }

        private void ucGe_Menu_event_btnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cmbTipoNomina_EditValueChanged(object sender, EventArgs e)
        {

            try
            {
                if (Convert.ToInt32(cmbTipoNomina.EditValue) != 0)
                {
                    var listadoprocesoliq = busProc.Get_List_Nomina_Tipoliqui_x_Nomina_Tipo(param.IdEmpresa, Convert.ToInt32(cmbTipoNomina.EditValue));
                    cmbProcesoLiqNomina.Properties.DataSource = listadoprocesoliq;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }





     public   void CargarCombos()
        {
            try
            {
                //                var lstRubro = busRubro.ConsultaGeneral();
                var lstRubro = (from a in busRubro.ConsultaGeneralPorEmpresa(param.IdEmpresa)
                                where a.rub_concep == true
                                select a).ToList();

                cmbNovedad.Properties.DataSource = lstRubro;

                var lstTipNomina = busNominaTip.Get_List_Nomina_Tipo(param.IdEmpresa);
                cmbTipoNomina.Properties.DataSource = lstTipNomina;
                // obras
                ListObra = BusObra.ObtenerListaObra(param.IdEmpresa);
                CmbObra.Properties.DataSource = ListObra;
                
               // grupos trabajos
                ListaGt = BusGt.ObtenerGrupoTrabajoCab(param.IdEmpresa);
                CmbGrupoTrabajo.Properties.DataSource = ListaGt;







            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

     private void Frm_ProductividadSubgrupoTrabajo_Mantenimiento_Load(object sender, EventArgs e)
     {
         try
         {
             CargarCombos();
         }
         catch (Exception ex)
         {
             MessageBox.Show(ex.Message);
            Log_Error_bus.Log_Error(ex.ToString());
         }
     }

     private void cmbProcesoLiqNomina_EditValueChanged(object sender, EventArgs e)
     {
         try
         {
                      lista = new List<ro_periodo_x_ro_Nomina_TipoLiqui_Info>();
                      lista = Bus_PerNomTipoliq.ConsultaPerNomTipLiq(param.IdEmpresa,Convert.ToInt32( cmbTipoNomina.EditValue),Convert.ToInt32( cmbProcesoLiqNomina.EditValue));
                      cmbPeriodos.Properties.DataSource = lista;

         }
         catch (Exception ex)
         {
             MessageBox.Show(ex.Message); 
           Log_Error_bus.Log_Error(ex.ToString());
         }
     }

     private void CmbObra_EditValueChanged(object sender, EventArgs e)
     {
         try
         {
             ListOrdenTaller = BusOrdenTaller.GetLisOrdenTaller(param.IdEmpresa, param.IdSucursal, Convert.ToString(CmbObra.EditValue));
             CmbOrdenTaller.Properties.DataSource = ListOrdenTaller;
         }
         catch (Exception ex)
         {
             MessageBox.Show(ex.Message);
              Log_Error_bus.Log_Error(ex.ToString());
         }
     }

     private void CmbGrupoTrabajo_EditValueChanged(object sender, EventArgs e)
     {
         try
         {
             ListSubGrupoTrabajo = BusCabeceraGT.GetListSubGruposTrabajo(param.IdEmpresa, param.IdSucursal, Convert.ToInt32(CmbGrupoTrabajo.EditValue));
             cmbSubGrupoTrabajo.Properties.DataSource = ListSubGrupoTrabajo;

         }
         catch (Exception ex)
         {
             
             MessageBox.Show(ex.Message);
             Log_Error_bus.Log_Error(ex.ToString());
         }
     }
    }
}
