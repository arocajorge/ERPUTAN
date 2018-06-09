using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Core.Erp.Info.General;
using Core.Erp.Business.General;

using Core.Erp.Info.Roles;
using Core.Erp.Business.Roles;

using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;
using DevExpress.XtraBars;

namespace Core.Erp.Reportes.Roles
{
    public partial class XROL_Rpt002_frm : Form
    {
        //BUS
        ro_Nomina_Tipo_Bus Bus_TipoNo = new ro_Nomina_Tipo_Bus();
        ro_periodo_Bus Bus_Periodo = new ro_periodo_Bus();
        ro_Nomina_Tipoliqui_Bus Bus_TipoL = new ro_Nomina_Tipoliqui_Bus();

        //INFO
        List<ro_periodo_Info> oLst_InfoPeriodo = new List<ro_periodo_Info>();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        List<ro_Nomina_Tipoliqui_Info> InfoTipoLiqui = new List<ro_Nomina_Tipoliqui_Info>();        

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();


        int _idEmpresa=0;
        int _idNominaTipo=0;
        int _idNominaTipoLiqui=0;
        int _idPeriodo=0;
        int _idArea = 0;
        int _idDepartamento = 0;
        decimal _idDivision = 0;
        string _idCentroCosto = "";


        public XROL_Rpt002_frm()
        {
            InitializeComponent();
        }

        private void XROL_Rpt002_frm_Load(object sender, EventArgs e)
        {
            ucRo_Menu_Reportes.VisibleGrupoFiltro1 = true;
            ucRo_Menu_Reportes.VisibleGrupoFiltro2 = true;
            ucRo_Menu_Reportes.VisibleGrupoFecha = false;
            ucRo_Menu_Reportes.VisibleCmbEmpleado = BarItemVisibility.Never;
              
          _idEmpresa = param.IdEmpresa;


            if(_idEmpresa>0 && _idNominaTipo>0 && _idNominaTipoLiqui>0 && _idPeriodo>0){

               
                ucRo_Menu_Reportes.setInfo(_idNominaTipo, _idNominaTipoLiqui, _idPeriodo);

                pu_CrearReporte();
            }

        }

        public void setInfo(int idEmpresa, int idNominaTipo, int idNominaTipoLiqui, int idPeriodo)
        {
            try {
                _idEmpresa = idEmpresa;
                _idNominaTipo = idNominaTipo;
                _idNominaTipoLiqui = idNominaTipoLiqui;
                _idPeriodo = idPeriodo;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }




        private void printControl1_Load(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        private Boolean pu_Validar() {
            try
            {

                if (ucRo_Menu_Reportes.getIdNominaTipo()=="") {
                    MessageBox.Show("Debe seleccionar la Nómina, es obligatorio","ATENCION", MessageBoxButtons.OK,MessageBoxIcon.Stop);
                    return false;
                }
                if (ucRo_Menu_Reportes.getIdNominaTipoLiqui() == "")
                {
                    MessageBox.Show("Debe seleccionar el Proceso de Liquidación, es obligatorio", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return false;
                }

                if (ucRo_Menu_Reportes.getIdPeriodo() == "")
                {
                    MessageBox.Show("Debe seleccionar el Período, es obligatorio", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }
        
        }



        private void getInfo() {
            try
            {
                if (pu_Validar())
                {
                    _idEmpresa = param.IdEmpresa;
                    _idNominaTipo = Convert.ToInt32(ucRo_Menu_Reportes.getIdNominaTipo());
                    _idNominaTipoLiqui = Convert.ToInt32(ucRo_Menu_Reportes.getIdNominaTipoLiqui());
                    _idPeriodo = Convert.ToInt32(ucRo_Menu_Reportes.getIdPeriodo());
                    _idDivision = Convert.ToDecimal(ucRo_Menu_Reportes.getIdDivision() == "" ? 0 : Convert.ToDecimal(ucRo_Menu_Reportes.getIdDivision()));
                    _idCentroCosto = ucRo_Menu_Reportes.getIdCentroCosto();

                    _idArea = Convert.ToInt32(ucRo_Menu_Reportes.getIdArea() == "" ? 0 : Convert.ToInt32(ucRo_Menu_Reportes.getIdArea()));
                    _idDepartamento = Convert.ToInt32(ucRo_Menu_Reportes.getIdDepartamento() == "" ? 0 : Convert.ToInt32(ucRo_Menu_Reportes.getIdDepartamento()));
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        
        }


        private void pu_CrearReporte()
        {
            try
            {
                XROL_Rpt002_rpt Reporte = new XROL_Rpt002_rpt();

                Reporte.RequestParameters = false;
                ReportPrintTool pt = new ReportPrintTool(Reporte);

                pt.AutoShowParametersPanel = false;

                getInfo();

                if (_idNominaTipo > 0 && _idNominaTipoLiqui > 0 && _idPeriodo>0) { 

                    Reporte.Parameters["s_idEmpresa"].Value = _idEmpresa;
                    Reporte.Parameters["s_idNominaTipo"].Value = _idNominaTipo;
                    Reporte.Parameters["s_idNominaTipoLiqui"].Value = _idNominaTipoLiqui;
                    Reporte.Parameters["s_idPeriodo"].Value = _idPeriodo;
                    Reporte.Parameters["s_fechaImpresion"].Value = param.Fecha_Transac;
                    Reporte.Parameters["s_idUsuario"].Value = param.IdUsuario;

                    Reporte.Parameters["p_IdDivision"].Value = _idDivision;
                    Reporte.Parameters["p_IdCentroCosto"].Value = _idCentroCosto;
          
                    Reporte.Parameters["s_CentroCosto"].Value = ucRo_Menu_Reportes.getDescripcionCentroCosto();
                    Reporte.Parameters["s_Division"].Value = ucRo_Menu_Reportes.getDescripcionDivision();

                    Reporte.Parameters["p_IdArea"].Value = _idArea;
                    Reporte.Parameters["p_IdDepartamento"].Value = _idDepartamento;
                    


                    printControlReporte.PrintingSystem = Reporte.PrintingSystem;

                  //  printControlReporte.PrintingSystem.Document.AutoFitToPagesWidth = 1;

                    Reporte.CreateDocument();

                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }




        private void cmdImprimir_Click(object sender, EventArgs e)
        {

            //pivotGridRol.ShowPrintPreview();

            //pu_Imprimir();
        }

       

      

        private void cmbTipoLiq_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void ucRo_Menu_Reportes_event_cmdImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            pu_CrearReporte();
        }

        private void ucRo_Menu_Reportes_event_btnsalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void ucRo_Menu_Reportes_event_cmdCargar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            pu_CrearReporte();
        }

  
    
 
        
      }
}
