/*CLASE: frmRo_Area_X_Departamento_Mant
 *CREADA POR: ALBERTO MENA
 *FECHA: 07-07-2015
 *DERECHOS RESERVADOS - INNOVATECORP
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Core.Erp.Info.Roles;
using Core.Erp.Business.Roles;
using Core.Erp.Business.General;
using Core.Erp.Winform.General;
using Core.Erp.Info.General;
using Core.Erp.Recursos.Properties;

namespace Core.Erp.Winform.Roles
{
    public partial class frmRo_Area_X_Departamento_Mant : Form
    {

        //VARIABLES
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        Cl_Enumeradores.eTipo_action _Accion;
        string mensaje = "";

        int _idEmpresa = 0;
        int _idDivision = 0;
        int _idArea= 0;
        int _idDepartamento= 0;



        //BUS
        ro_Area_X_Departamento_Bus oRro_Area_X_Departamento_Bus = new ro_Area_X_Departamento_Bus();
        ro_division_Bus oRo_division_Bus = new Business.Roles.ro_division_Bus();
        ro_area_Bus oRo_area_Bus = new Business.Roles.ro_area_Bus();
    

        //INFO
        List<ro_Area_X_Departamento_Info> oListRo_Area_X_Departamento_Info = new List<ro_Area_X_Departamento_Info>();

        List<ro_division_Info> oListRo_division_Info = new List<ro_division_Info>();
        List<ro_area_Info> oListRo_area_Info = new List<ro_area_Info>();
        List<ro_Departamento_Info> oListRo_Departamento_Info = new List<ro_Departamento_Info>();

        BindingList<ro_Area_X_Departamento_Info> oBindingListRo_Area_X_Departamento_Info = new BindingList<ro_Area_X_Departamento_Info>();


        public frmRo_Area_X_Departamento_Mant()
        {
            try
            { InitializeComponent();

            ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;

            ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;

            ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;

            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }

        void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            

            try
            {
                pu_Guardar();
                this.Close();
            }
            catch (Exception ex)
            {
                
                 MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }

        void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {pu_Guardar();

            }
            catch (Exception ex)
            {
                
                 MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }

        void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }


     
        private void pu_CargarCombos() {
            try
            {
                //LLENA EL COMBO - DIVISION
                oListRo_division_Info = oRo_division_Bus.ConsultaGeneral(_idEmpresa);
                cmbDivision.Properties.ValueMember = "IdDivision";
                cmbDivision.Properties.DisplayMember = "Descripcion";
                cmbDivision.Properties.DataSource = oListRo_division_Info;

                ////LLENA EL COMBO - AREA
                oListRo_area_Info = oRo_area_Bus.ConsultaGeneral(_idEmpresa);
                cmbArea.Properties.ValueMember = "IdArea";
                cmbArea.Properties.DisplayMember = "Descripcion";
                cmbArea.Properties.DataSource = oListRo_area_Info;

                ////LLENA EL COMBO - DEPARTAMENTO
                ro_Departamento_Bus oRo_Departamento_Bus = new Business.Roles.ro_Departamento_Bus();
                oListRo_Departamento_Info = oRo_Departamento_Bus.Get_List_Departamento(_idEmpresa);
                cmbDepartamento.Properties.ValueMember = "IdDepartamento";
                cmbDepartamento.Properties.DisplayMember = "de_descripcion";
                cmbDepartamento.Properties.DataSource = oListRo_Departamento_Info;


                //VARIOS
                cmbDivisionD.DataSource = oListRo_division_Info;
                cmbDivisionD.ValueMember = "IdDivision";
                cmbDivisionD.DisplayMember = "Descripcion";

                cmbAreaD.DataSource = oListRo_area_Info;
                cmbAreaD.ValueMember = "IdArea";
                cmbAreaD.DisplayMember = "Descripcion";

                cmbDepartamentoD.DataSource = oListRo_Departamento_Info;
                cmbDepartamentoD.ValueMember = "IdDepartamento";
                cmbDepartamentoD.DisplayMember = "de_descripcion";





            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            } 
        }



        private void pu_CargaInicial() {
            try
            {
                _idEmpresa = param.IdEmpresa;
                gridDepartamento.DataSource = oBindingListRo_Area_X_Departamento_Info;
                
                pu_CargarCombos();


                oBindingListRo_Area_X_Departamento_Info =new BindingList<ro_Area_X_Departamento_Info>( oRro_Area_X_Departamento_Bus.getListPorArea(_idEmpresa, ref mensaje));
                gridDepartamento.DataSource = oBindingListRo_Area_X_Departamento_Info;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }  
        
        }



        private void frmRo_Area_X_Departamento_Mant_Load(object sender, EventArgs e)
        {
            try
            { pu_CargaInicial();

            }
            catch (Exception ex)
            {
                
               MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                pu_Agregar();

            }
            catch (Exception ex)
            {
                
               MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }

        private void cmdQuitar_Click(object sender, EventArgs e)
        {
            try
            { 
                pu_Quitar();

            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }


        private void pu_Agregar() {
            try{

               
                    if (pu_ValidarRepetido())
                    {
                        ro_Area_X_Departamento_Info info = new ro_Area_X_Departamento_Info();

                        info.IdEmpresa = _idEmpresa;
                        info.IdDivision = _idDivision;
                        info.IdArea = _idArea;
                        info.IdDepartamento = _idDepartamento;

                        oBindingListRo_Area_X_Departamento_Info.Add(info);
                    }
                    else {
                        MessageBox.Show("El valor ingresado esta repetido, revise por favor","ATENCION",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                    }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);

            }              
        }

        private void pu_Quitar()
        {
            try
            {
                if (viewDepartamento.RowCount > 0)
                {
                    viewDepartamento.DeleteSelectedRows();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);

            }
        }

        private void cmbDivision_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
               if(cmbDivision.EditValue!=null){
                _idDivision = Convert.ToInt32(cmbDivision.EditValue);
                oListRo_area_Info = oRo_area_Bus.ConsultaPorDivision(param.IdEmpresa,_idDivision);
                cmbArea.Properties.DataSource = oListRo_area_Info;
            }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }

        }

        private void cmbArea_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                 if (cmbArea.EditValue != null)
            {
                _idArea = Convert.ToInt32(cmbArea.EditValue);
            }
            }
            catch (Exception ex)
            {
                
               MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }

        }

        private void cmbDepartamento_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                 if(cmbDepartamento.EditValue!=null){
                _idDepartamento = Convert.ToInt32(cmbDepartamento.EditValue);            
            }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }


        private void  pu_Guardar(){
            try {

                oRro_Area_X_Departamento_Bus.EliminarBD(_idEmpresa,ref mensaje);

                foreach (ro_Area_X_Departamento_Info item in oBindingListRo_Area_X_Departamento_Info)
                {
                    //ro_Area_X_Departamento_Info info = new ro_Area_X_Departamento_Info();
                    item.IdEmpresa = _idEmpresa;
                    oRro_Area_X_Departamento_Bus.GrabarBD(item, ref mensaje);

                }

                MessageBox.Show(Resources.msgConfirmaGrabarOk, Resources.msgTituloGrabar, MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }

        private void viewDepartamento_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {if (e.KeyCode.ToString() == "Delete")
            {
                if (viewDepartamento.RowCount > 0)
                {
                    viewDepartamento.DeleteSelectedRows();
                }
            }

            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }



        private Boolean pu_ValidarRepetido() { 
            try{

                foreach (ro_Area_X_Departamento_Info item in oBindingListRo_Area_X_Departamento_Info)
                {
                    if(item.IdDivision==_idDivision && item.IdArea==_idArea && item.IdDepartamento==_idDepartamento){
                        return false;
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
                return false;
            }        
        }




    }
}
