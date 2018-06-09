using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Core.Erp.Business.Roles;
using Core.Erp.Info.Roles;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.Contabilidad;

using Core.Erp.Business.General;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraBars;

namespace Core.Erp.Reportes.Controles
{
    public partial class UCRo_Menu_Reportes : UserControl
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        string mensaje = "";

        int _idEmpresa = 0;
        int _idNominaTipo = 0;
        int _idNominaTipoLiqui = 0;
        int _idPeriodo = 0;
        int _idDivision = 0;
        int _idArea = 0;
        int _idDepartamento = 0;

        string _DescripcionDivision = "";
        string _DescripcionCentroCosto = "";
        string _DescripcionRubro = "";
        string _DescripcionEmpleado = "";
        string _DescripcionArea = "";
        string _DescripcionDepartamento = "";
       

        //INFO
        List<ro_Nomina_Tipo_Info> oListRo_Nomina_Tipo_Info = new List<ro_Nomina_Tipo_Info>();
        List<ro_Nomina_Tipoliqui_Info> oListRo_Nomina_Tipoliqui_Info = new List<ro_Nomina_Tipoliqui_Info>();
        List<ro_periodo_x_ro_Nomina_TipoLiqui_Info> oListRo_periodo_x_ro_Nomina_TipoLiqui_Info = new List<ro_periodo_x_ro_Nomina_TipoLiqui_Info>();
        List<ro_division_Info> oListRo_division_Info = new List<ro_division_Info>();
        List<ct_Centro_costo_Info> oListCt_Centro_costo_Info = new List<ct_Centro_costo_Info>();
        List<ro_Empleado_Info> oListRo_Empleado_Info = new List<ro_Empleado_Info>();
        List<ro_rubro_tipo_Info> oListRo_rubro_tipo_Info = new List<ro_rubro_tipo_Info>();
        List<ro_area_Info> oListRo_Area_Info = new List<ro_area_Info>();
        List<ro_Departamento_Info> oListRo_Departamento_Info = new List<ro_Departamento_Info>();
        List<ro_Departamento_Info> LisDepartamento = new List< ro_Departamento_Info>();
 
        //BUS
        ro_Nomina_Tipo_Bus oRo_Nomina_Tipo_Bus = new ro_Nomina_Tipo_Bus();
        ro_Nomina_Tipoliqui_Bus oRo_Nomina_Tipoliqui_Bus = new ro_Nomina_Tipoliqui_Bus();
        ro_periodo_x_ro_Nomina_TipoLiqui_Bus oRo_periodo_x_ro_Nomina_TipoLiqui_Bus = new ro_periodo_x_ro_Nomina_TipoLiqui_Bus();
        ro_division_Bus oRo_division_Bus = new ro_division_Bus();
        ct_Centro_costo_Bus oCt_Centro_costo_Bus = new ct_Centro_costo_Bus();
        ro_Empleado_Bus oRo_Empleado_Bus = new ro_Empleado_Bus();
        ro_rubro_tipo_Bus oRo_rubro_tipo_Bus = new ro_rubro_tipo_Bus();
        ro_area_Bus oRo_area_Bus = new ro_area_Bus();
        ro_Departamento_Bus oRo_Departamento_Bus = new ro_Departamento_Bus();
        ro_Departamento_Bus BusDepartamento = new ro_Departamento_Bus();
        
        //DELEGADOS
        public delegate void delegate_cmbPeriodo_EditValueChanged(object sender, EventArgs e);
        public event delegate_cmbPeriodo_EditValueChanged event_cmbPeriodo_EditValueChanged;

        public delegate void delegate_cmdCargar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e);
        public event delegate_cmdCargar_ItemClick event_cmdCargar_ItemClick;

        public delegate void delegate_btnsalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e);
        public event delegate_btnsalir_ItemClick event_btnsalir_ItemClick;

        public delegate void delegate_cmdImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e);
        public event delegate_cmdImprimir_ItemClick event_cmdImprimir_ItemClick;

        #region visible_enable
        public Boolean VisibleGrupoFecha
        {
            get { return this.ribbPageFiltroFechas.Visible; }
            set { this.ribbPageFiltroFechas.Visible = value; }
        }

        public Boolean VisibleGrupoFiltro1
        {
            get { return this.ribPageFiltro1.Visible; }
            set { this.ribPageFiltro1.Visible = value; }
        }

        public Boolean VisibleGrupoFiltro2
        {
            get { return this.ribPageFiltro2.Visible; }
            set { this.ribPageFiltro2.Visible = value; }
        }

        public Boolean EnableBotonImprimir
        {
            get { return this.cmdImprimir.Enabled; }
            set { this.cmdImprimir.Enabled = value; }
        }


        public DevExpress.XtraBars.BarItemVisibility VisibleCmbEmpleado
        {
            get { return this.barEmpleado.Visibility; }
            set { this.barEmpleado.Visibility = value; }
        }

        public DevExpress.XtraBars.BarItemVisibility VisibleCmbDivision
        {
            get { return this.barDivision.Visibility; }
            set { this.barDivision.Visibility = value; }
        }


        public DevExpress.XtraBars.BarItemVisibility VisibleCmbCentroCosto
        {
            get { return this.barCentroCosto.Visibility; }
            set { this.barCentroCosto.Visibility = value; }
        }

        public DevExpress.XtraBars.BarItemVisibility VisibleCmbPeriodo
        {
            get { return this.barPeriodo.Visibility; }
            set { this.barPeriodo.Visibility = value; }
        }

        public DevExpress.XtraBars.BarItemVisibility VisibleCmbNominaTipo
        {
            get { return this.barNominaTipo.Visibility; }
            set { this.barNominaTipo.Visibility = value; }
        }

        public DevExpress.XtraBars.BarItemVisibility VisibleCmbNominaTipoLiqui
        {
            get { return this.barNominaTipoLiqui.Visibility; }
            set { this.barNominaTipoLiqui.Visibility = value; }
        }

        public DevExpress.XtraBars.BarItemVisibility VisibleCmbRubro
        {
            get { return this.barRubro.Visibility; }
            set { this.barRubro.Visibility = value; }
        }
        #endregion

        public UCRo_Menu_Reportes()
        {
            InitializeComponent();
            event_cmbPeriodo_EditValueChanged += UCRo_Menu_Reportes_event_cmbPeriodo_EditValueChanged;
            event_cmdCargar_ItemClick += UCRo_Menu_Reportes_event_cmdCargar_ItemClick;
            event_btnsalir_ItemClick += UCRo_Menu_Reportes_event_btnsalir_ItemClick;

            event_cmdImprimir_ItemClick += UCRo_Menu_Reportes_event_cmdImprimir_ItemClick;
        
        }

        void UCRo_Menu_Reportes_event_cmdImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e){}
    
        void UCRo_Menu_Reportes_event_btnsalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e){}

        void UCRo_Menu_Reportes_event_cmdCargar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e){}

        void UCRo_Menu_Reportes_event_cmbPeriodo_EditValueChanged(object sender, EventArgs e){}

     

        private void UCRo_Menu_Reportes_Load(object sender, EventArgs e)
        {
            pu_CargaInicial();
        }

     

        void pu_CargaInicial()
        {
            try
            {
                _idEmpresa = param.IdEmpresa;

                cmbNominaTipo.View.Columns.AddField("Descripcion").Visible = true;
                cmbNominaTipoLiqui.View.Columns.AddField("DescripcionProcesoNomina").Visible = true;
                cmbPeriodo.View.Columns.AddField("pe_Descripcion").Visible = true;
                cmbDivision.View.Columns.AddField("Descripcion").Visible = true;
                cmbCentroCosto.View.Columns.AddField("Centro_costo").Visible = true;
                cmbEmpleado.View.Columns.AddField("InfoPersona.pe_nombreCompleto").Visible = true;
                cmbRubro.View.Columns.AddField("ru_descripcion").Visible = true;
                cmbArea.View.Columns.AddField("Descripcion").Visible = true;
                cmbDepartamento.View.Columns.AddField("de_descripcion").Visible = true;

                //CARGA COMBO NOMINA_TIPO               
                oListRo_Nomina_Tipo_Info = oRo_Nomina_Tipo_Bus.Get_List_Nomina_Tipo(_idEmpresa);
                cmbNominaTipo.DataSource = oListRo_Nomina_Tipo_Info;

                //CARGA COMBO DIVISION
                oListRo_division_Info = oRo_division_Bus.ConsultaGeneral(_idEmpresa);
                cmbDivision.DataSource = oListRo_division_Info;

                //CARGA COMBO CENTRO_COSTO
                oListCt_Centro_costo_Info = oCt_Centro_costo_Bus.Get_list_Centro_Costo(_idEmpresa, ref mensaje);
                cmbCentroCosto.DataSource = oListCt_Centro_costo_Info;
                              
                //CARGA RUBRO                
                if (barRubro.Visibility == BarItemVisibility.Always)
                {
                    oListRo_rubro_tipo_Info = oRo_rubro_tipo_Bus.ConsultaGeneralPorEmpresa(_idEmpresa).Where(v => v.ru_estado == "A").ToList();
                    cmbRubro.DataSource = oListRo_rubro_tipo_Info;
                }

                //CARGAR EMPLEADOS
                oListRo_Empleado_Info = oRo_Empleado_Bus.Get_List_Empleado_(_idEmpresa);
                cmbEmpleado.DataSource = oListRo_Empleado_Info;

                //CARGAR AREAS
                oListRo_Area_Info = oRo_area_Bus.ConsultaGeneral(_idEmpresa);
                cmbArea.DataSource = oListRo_Area_Info;                
                

                //CARGAR DEPARTAMENTOS
                LisDepartamento = BusDepartamento.Get_List_Departamento(_idEmpresa);
                cmbDepartamento.DataSource = LisDepartamento;

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
     

        private void cmbPeriodo_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                event_cmbPeriodo_EditValueChanged(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        public string getIdPeriodo()
        {
            try
            {
                return barPeriodo.EditValue.ToString();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return "";
            }
        }

        public string getIdNominaTipo()
        {
            try
            {
                return barNominaTipo.EditValue.ToString();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return "";
            }
        }

        public string getIdNominaTipoLiqui()
        {
            try
            {
                return barNominaTipoLiqui.EditValue.ToString();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return "";
            }
        }

        public string getIdDivision()
        {
            try
            {
                return barDivision.EditValue.ToString();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return "";
            }
        }

        public string getIdCentroCosto()
        {
            try
            {
                return barCentroCosto.EditValue.ToString();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return "";
            }
        }

        public string getIdArea()
        {
            try
            {
                ro_area_Info info = (ro_area_Info)barArea.EditValue;

                return info.IdArea.ToString();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return "";
            }
        }

        public string getIdDepartamento()
        {
            try
            {
                ro_Departamento_Info infoD = (ro_Departamento_Info)barDepartamento.EditValue;
                if (infoD != null)
                {
                    return infoD.IdDepartamento.ToString();
                }
                else
                {
                    return "";
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return "";
            }
        }




        public string getDescripcionDivision()
        {
            try
            {
                return _DescripcionDivision;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return "";
            }
        }

        public string getDescripcionCentroCosto()
        {
            try
            {
                return _DescripcionCentroCosto;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return "";
            }
        }

        public string getDescripcionRubro()
        {
            try
            {
                return _DescripcionRubro;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return "";
            }
        }

        public string getDescripcionEmpleado()
        {
            try
            {
                return _DescripcionEmpleado;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return "";
            }
        }

        public string getDescripcionArea()
        {
            try
            {
                return _DescripcionArea;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return "";
            }
        }

        public string getDescripcionDepartamento()
        {
            try
            {
                return _DescripcionDepartamento;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return "";
            }
        }

        public string getFechaInicial()
        {
            try
            {
                return barFechaIni.EditValue.ToString();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return "";
            }
        }

        public string getFechaFinal()
        {
            try
            {
                return barFechaFin.EditValue.ToString();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return "";
            }
        }


        public int getIdEmpleado()
        {
            int IdEmpleado = 0;
            try
            {
               
                if (barEmpleado.EditValue != null)
                {
                    IdEmpleado= Convert.ToInt32( barEmpleado.EditValue);
                }
                else
                {
                    IdEmpleado = 0;


                }
                return IdEmpleado;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return IdEmpleado ;
                
            }
        }

        public string getIdRubro()
        {
            try
            {
                return barRubro.EditValue.ToString();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return "";
            }
        }

       
       
     
        public void setIdEmpleado(decimal value)
        {
            try
            {
                barEmpleado.EditValue = value;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        public void setIdDivision(int value)
        {
            try
            {
                barDivision.EditValue = value;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        public void setIdCentroCosto(string value)
        {
            try
            {
                barCentroCosto.EditValue = value;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        public void setIdNominaTipo(int value)
        {
            try
            {
                barNominaTipo.EditValue = value;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        public void setIdNominaTipoLiqui(int value)
        {
            try
            {
                barNominaTipoLiqui.EditValue = value;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        public void setIdPeriodo(int value)
        {
            try
            {
                barPeriodo.EditValue = value;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        public void setFechaInicial(string value)
        {
            try
            {
                barFechaIni.EditValue = value;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        public void setFechaFinal(string value)
        {
            try
            {
                barFechaFin.EditValue = value;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        public void setIdRubro(string value)
        {
            try
            {
                barRubro.EditValue = value;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }


        public void setIdArea(string value)
        {
            try
            {
                barArea.EditValue = value;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        public void setIdDepartamento(string value)
        {
            try
            {
                barDepartamento.EditValue = value;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }


        public void setInfo(int idNominaTipo, int idNominaTipoLiqui, int idPeriodo)
        {
            try
            {
                barNominaTipo.EditValue = idNominaTipo;
                barNominaTipoLiqui.EditValue = idNominaTipoLiqui;
                barPeriodo.EditValue = idPeriodo;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());               
            }
        }

        public void setInfo(int idNominaTipo, int idNominaTipoLiqui, int idPeriodo, decimal idDivision, string idCentroCosto, decimal idEmpleado)
        {
            try
            {
                barNominaTipo.EditValue = idNominaTipo;
                barNominaTipoLiqui.EditValue = idNominaTipoLiqui;
                barPeriodo.EditValue = idPeriodo;
                barDivision.EditValue = idDivision;
                barCentroCosto.EditValue = idCentroCosto;
                barEmpleado.EditValue = idEmpleado;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }




        private void cmbNominaTipo_EditValueChanged(object sender, EventArgs e)
        {
             try
             {
                 SearchLookUpEdit lookup = sender as SearchLookUpEdit;
                 BindingManagerBase bm = BindingContext[lookup.Properties.DataSource];
              
                 if (lookup.EditValue != null)
                 {
                     _idNominaTipo = Convert.ToInt32(lookup.EditValue);
                     oListRo_Nomina_Tipoliqui_Info = oRo_Nomina_Tipoliqui_Bus.Get_List_Nomina_Tipoliqui_x_Nomina_Tipo(param.IdEmpresa, _idNominaTipo);
                     cmbNominaTipoLiqui.DataSource = oListRo_Nomina_Tipoliqui_Info;


                     //CARGA LOS EMPLEADOS DE LA NOMINA SELECCIONADA
                     if (barEmpleado.Visibility == BarItemVisibility.Always)
                     {
                         oListRo_Empleado_Info = oRo_Empleado_Bus.Get_List_Empleado_x_Nomina(_idEmpresa, _idNominaTipo);
                         cmbEmpleado.DataSource = oListRo_Empleado_Info;
                     
                     }
                 }


             }
             catch (Exception ex)
             {
                 string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                 MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 Log_Error_bus.Log_Error(ex.ToString());
             }
        }

        private void cmbNominaTipoLiqui_EditValueChanged(object sender, EventArgs e)
        {
             try
             {
                 SearchLookUpEdit lookup = sender as SearchLookUpEdit;
                 BindingManagerBase bm = BindingContext[lookup.Properties.DataSource];

                 if ((lookup.EditValue != null))
                 {
                     _idNominaTipoLiqui = Convert.ToInt32(lookup.EditValue);
 
                     oListRo_periodo_x_ro_Nomina_TipoLiqui_Info = oRo_periodo_x_ro_Nomina_TipoLiqui_Bus.ConsultaPerNomTipLiq(_idEmpresa, _idNominaTipo, _idNominaTipoLiqui);
                     cmbPeriodo.DataSource = oListRo_periodo_x_ro_Nomina_TipoLiqui_Info;
                 }

             }
             catch (Exception ex)
             {
                 string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                 MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 Log_Error_bus.Log_Error(ex.ToString());
             }
        }

        private void cmdCargar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {         
            try
            {
                event_cmdCargar_ItemClick(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void btnsalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           try
            {
                event_btnsalir_ItemClick(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

      

        private void cmdImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                event_cmdImprimir_ItemClick(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void cmbDivision_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                SearchLookUpEdit edit = sender as SearchLookUpEdit;
                int rowHandle = edit.Properties.GetIndexByKeyValue(edit.EditValue);
                object row = edit.Properties.View.GetRow(rowHandle);
                ro_division_Info info = (ro_division_Info)row;
                _DescripcionDivision = info.Descripcion;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(ex.ToString());
            }   
        }

        private void cmbCentroCosto_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                SearchLookUpEdit edit = sender as SearchLookUpEdit;
                int rowHandle = edit.Properties.GetIndexByKeyValue(edit.EditValue);
                object row = edit.Properties.View.GetRow(rowHandle);
                ct_Centro_costo_Info info = (ct_Centro_costo_Info)row;
                _DescripcionCentroCosto = info.Centro_costo;
    
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(ex.ToString());
            }   
        }

        private void cmbRubro_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                SearchLookUpEdit edit = sender as SearchLookUpEdit;
                int rowHandle = edit.Properties.GetIndexByKeyValue(edit.EditValue);
                object row = edit.Properties.View.GetRow(rowHandle);
                ro_rubro_tipo_Info info = (ro_rubro_tipo_Info)row;
                _DescripcionRubro = info.ru_descripcion.Trim();

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(ex.ToString());
            }   
    
        }

        private void cmbEmpleado_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                SearchLookUpEdit edit = sender as SearchLookUpEdit;
                int rowHandle = edit.Properties.GetIndexByKeyValue(edit.EditValue);
                object row = edit.Properties.View.GetRow(rowHandle);
                ro_Empleado_Info info = (ro_Empleado_Info)row;
                _DescripcionEmpleado = info.InfoPersona.pe_nombreCompleto.Trim();

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(ex.ToString());
            }  
        }

        private void cmbArea_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                SearchLookUpEdit edit = sender as SearchLookUpEdit;
                int rowHandle = edit.Properties.GetIndexByKeyValue(edit.EditValue);
                object row = edit.Properties.View.GetRow(rowHandle);

                ro_area_Info info = (ro_area_Info)row;
                _DescripcionArea = info.Descripcion;

             
                _idArea = info.IdArea;

              
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(ex.ToString());
            }  
        }

        private void cmbDepartamento_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                SearchLookUpEdit edit = sender as SearchLookUpEdit;
                int rowHandle = edit.Properties.GetIndexByKeyValue(edit.EditValue);
                object row = edit.Properties.View.GetRow(rowHandle);

                ro_Departamento_Info info = (ro_Departamento_Info)row;
                _DescripcionDepartamento = info.de_descripcion;

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(ex.ToString());
            }  
        }

        private void barArea_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barCentroCosto_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void check_HorasAutorizadas_CheckedChanged(object sender, ItemClickEventArgs e)
        {

        }

        private void check_HorasAutorizadas_CheckedChanged_1(object sender, ItemClickEventArgs e)
        {

        }

        public ro_periodo_x_ro_Nomina_TipoLiqui_Info Get_Info_Periodo()
        {
            try
            {
                ro_periodo_x_ro_Nomina_TipoLiqui_Info info = new ro_periodo_x_ro_Nomina_TipoLiqui_Info();
                info = oListRo_periodo_x_ro_Nomina_TipoLiqui_Info.Where(v => v.IdPeriodo ==Convert.ToInt32(barPeriodo.EditValue.ToString())).FirstOrDefault();
                return info;
            }
            catch (Exception ex)
            {
                
               string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
            MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Log_Error_bus.Log_Error(ex.ToString());
            return new ro_periodo_x_ro_Nomina_TipoLiqui_Info();
            }
        }
    }
}
