
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
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using Core.Erp.Winform.Roles;
using Core.Erp.Winform.General;
using Core.Erp.Recursos.Properties;

using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using DevExpress.Utils;

//v2

namespace Core.Erp.Winform.Roles
{
    public partial class frmRo_Act_SueldoXEmpleado_Mant : Form
    {

        #region VARIABLES
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        ro_Departamento_Bus BusDep = new ro_Departamento_Bus();
        List<ro_Departamento_Info> LstInfoDep = new List<ro_Departamento_Info>();

        ro_Empleado_Bus OEmplBus = new ro_Empleado_Bus();
        ro_Empleado_Info Info_Empleado = new ro_Empleado_Info();
        ro_HistoricoSueldo_Info Info_HistSueldo = new ro_HistoricoSueldo_Info();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        public ro_HistoricoSueldo_Info InfoHistoricoSueldo = new ro_HistoricoSueldo_Info();
        ro_Empleado_Info Info_Empl = new ro_Empleado_Info();
        decimal x = 0;
        int Bandera = 0;

        List<ro_HistoricoSueldo_Info> ListHistSueldo = new List<ro_HistoricoSueldo_Info>();
        frmRo_HistoricoSueldo_Cons frm ;

         #endregion

        public frmRo_Act_SueldoXEmpleado_Mant()
        {
            try
            {
                InitializeComponent();

                ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
                ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;

            }
            catch (Exception ex)
            {
                 MessageBox.Show(ex.Message);
                 Log_Error_bus.Log_Error(ex.Message);

            }           
          
        }

        public frmRo_Act_SueldoXEmpleado_Mant(ro_Empleado_Info oRo_Empleado_Info)
        {
            try
            {
                InitializeComponent();

                ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
                ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
                Info_Empleado = oRo_Empleado_Info;
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

        void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                this.txeIncremento.Focus();
                pu_Grabar();
            }
            catch (Exception ex)
            {
                 MessageBox.Show(ex.Message);
                 Log_Error_bus.Log_Error(ex.Message);
            }
        
        }




        private void frm_HistoricoSueldo_Consu_Load(object sender, EventArgs e)
        {
            try
            {

                LstInfoDep = BusDep.Get_List_Departamento(param.IdEmpresa);
                CmbDepartamento.Properties.DataSource = LstInfoDep;


                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }

        }

        public void pu_CargaInicial()
        {
            try
            {
                if (Info_Empleado.IdEmpleado!=0)
                {
                    List<ro_Empleado_Info> List = new List<ro_Empleado_Info>();
                    List = OEmplBus.Get_Lis_Empleado(param.IdEmpresa,Info_Empleado);
                    this.grdLista.DataSource = List;
                }
                else{
                    List<ro_Empleado_Info> List = new List<ro_Empleado_Info>();
                    List = OEmplBus.Get_Lis_Empleado_x_Departamento(param.IdEmpresa,Convert.ToInt32( CmbDepartamento.EditValue));
                    this.grdLista.DataSource = List;
                }
        

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }

        private void mnu_salir_Click(object sender, EventArgs e)
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
        
        private void mnuNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                //if (Info_Empleado.IdEmpleado == 0)
                if (Info_Empleado == null)
                {
                    MessageBox.Show("Seleccione un registro", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {

                    //varios empleados
                    List<ro_Empleado_Info> List = (List<ro_Empleado_Info>)grdLista.DataSource;

                    List<ro_Empleado_Info> listaEmpleado = new List<ro_Empleado_Info>();
                    foreach (var item in List)
                    {
                        if (item.check == true)
                        {
                            listaEmpleado.Add(item);
                        }
                    }

                    frm = new frmRo_HistoricoSueldo_Cons();
                    frm.Event_frmRo_HistoricoSueldo_Mant_FormClosing += new frmRo_HistoricoSueldo_Cons.delegate_frmRo_HistoricoSueldo_Mant_FormClosing(frm_Event_frmRo_HistoricoSueldo_Mant_FormClosing);
                    // frm.set_Info(Info_Empleado);
                    frm.set_Info(listaEmpleado);
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);            
            }                      
        }

        void frm_Event_frmRo_HistoricoSueldo_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }

        }

        //PERMITE OBTENER EL REGISTRO ACTUALMENTE SELECCIONADO EN LA GRILLA
        private ro_Empleado_Info GetSelectedRow(DevExpress.XtraGrid.Views.Grid.GridView view)
        {

            try
            {
                return (ro_Empleado_Info)view.GetRow(view.FocusedRowHandle);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
                return new ro_Empleado_Info();
            }
        }
      

       private void pu_Grabar()
        {
            try
            {

                if (MessageBox.Show("Está seguro que desea guardar los cambios, tenga en cuenta que quedará registrado el cambio realizado","ATENCION",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes){

                    if (txtObservacion.Text.Length == 0 || txtObservacion.Text == "" || txtObservacion.Text == null)
                        {
                            MessageBox.Show("Debe ingresar la Observación, es obligatorio", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            txtObservacion.Focus();
                            return;
                        }

                        string msg="";

                        //Controlar los datos
                        if (pu_Validar() == false)
                        {
                            //MessageBox.Show("Error en el Sistema");
                            return;
                        }

                        getinfo(ref msg);
                        //MessageBox.Show(msg, "Operación Exitosa");
                        MessageBox.Show(Resources.msgConfirmaGrabarOk, Resources.msgTituloGrabar, MessageBoxButtons.OK, MessageBoxIcon.Information);


                        pu_CargaInicial();
                        txeIncremento.Text = "";
                        txtObservacion.Text = "";
                      // tbcIncremento.Value = 0;
                        ChkAll.Checked = false;
                }

            }
            catch (Exception ex)
            {
               
                 MessageBox.Show(ex.Message);
                 Log_Error_bus.Log_Error(ex.Message);
            }
        }

       private Boolean pu_Validar()
        {
            try
            {
                List<ro_Empleado_Info> List = (List<ro_Empleado_Info>)grdLista.DataSource;
                int cuenta = 0;

                if (txtObservacion.Text == "" || txtObservacion.Text == null)
                {
                    MessageBox.Show("Es obligatorio registrar el motivo del aumento de sueldo, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtObservacion.Focus();
                    return false;
                }
                  
                foreach (var item in List)
                {
                    if (item.check == true )
                    {

                        // this.ChkAll.Checked                       
                        cuenta++;

                        
                        /////////////////******************************OJO REVISAR ESTA VALIDACION**********************************
                        if (item.em_sueldoBasicoMen > item.SueldoActual)
                        {
                            MessageBox.Show("No puede bajarle el sueldo al Empleado, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            return false;
                        }
                        
                       }
                    }

                if (cuenta <= 0)
                {
                    MessageBox.Show("No ha seleccionado ningún Empleado, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return false;
                }
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
                return false;
            }         
        }

       public void getinfo( ref  string mensaje)
        {
            try
            {
                string msg = "";
                int valor = 100;
                ro_HistoricoSueldo_Bus HistoricoBus = new ro_HistoricoSueldo_Bus();
                ro_Empleado_Bus empBus = new ro_Empleado_Bus();

                // asignando el datasource de la lista
                List<ro_Empleado_Info> List = (List<ro_Empleado_Info>)grdLista.DataSource;
                foreach (var item in List)
                {

                    if (item.check == true)
                    {
                                             
                        InfoHistoricoSueldo.IdEmpresa = param.IdEmpresa;
                        InfoHistoricoSueldo.IdEmpleado = item.IdEmpleado;

                        
                        if (item.em_sueldoBasicoMen > 0 && item.SueldoActual > 0)
                        {
                            InfoHistoricoSueldo.SueldoAnterior = item.em_sueldoBasicoMen;
                            InfoHistoricoSueldo.SueldoActual = item.SueldoActual;

                            InfoHistoricoSueldo.ValorIncrementoSueldo = (InfoHistoricoSueldo.SueldoActual - InfoHistoricoSueldo.SueldoAnterior);
                            InfoHistoricoSueldo.PorIncrementoSueldo = (((InfoHistoricoSueldo.SueldoActual - InfoHistoricoSueldo.SueldoAnterior) / InfoHistoricoSueldo.SueldoAnterior) * valor);

                        }
                        else
                        {

                            if (item.em_sueldoBasicoMen == 0 && item.SueldoActual > 0)
                            {
                                InfoHistoricoSueldo.SueldoAnterior = item.SueldoActual;
                                InfoHistoricoSueldo.SueldoActual = item.SueldoActual;

                                InfoHistoricoSueldo.ValorIncrementoSueldo = (InfoHistoricoSueldo.SueldoActual);
                                InfoHistoricoSueldo.PorIncrementoSueldo = ((InfoHistoricoSueldo.SueldoActual / InfoHistoricoSueldo.SueldoAnterior) * valor);


                            }
                        }


                        InfoHistoricoSueldo.Motivo = txtObservacion.Text;
                        InfoHistoricoSueldo.Fecha = DateTime.Now;
                        InfoHistoricoSueldo.Fecha_Transac = DateTime.Now;
                        InfoHistoricoSueldo.idUsuario = param.IdUsuario;
                        InfoHistoricoSueldo.nom_pc = param.nom_pc;
                        InfoHistoricoSueldo.ip = param.ip;
                        InfoHistoricoSueldo.ca_descripcion = item.cargo_Descripcion;
                        InfoHistoricoSueldo.de_descripcion = item.de_descripcion;

                        if (HistoricoBus.GrabarDB(InfoHistoricoSueldo, ref msg))
                        {
                            Info_Empleado.IdEmpresa = InfoHistoricoSueldo.IdEmpresa;
                            Info_Empleado.IdEmpleado = InfoHistoricoSueldo.IdEmpleado;
                           
                            
                         
                        }
                        else return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }

        private void rbtValor_CheckedChanged(object sender, EventArgs e)
        {

            try
            {
                if (rbtValor.Checked == true)
                {
                    for (int i = 0; i < gridView.RowCount; i++)
                    {
                        gridView.SetRowCellValue(i, colcheck, false);

                        gridView.SetRowCellValue(i, colSueldoActual, 0);
                    }
                }
            }
            catch (Exception ex)
            {
                 MessageBox.Show(ex.Message);
                 Log_Error_bus.Log_Error(ex.Message);
            }                             
        }

      
        private void gridView_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        { 
            try
            {
                ro_Empleado_Info oFila = new ro_Empleado_Info();
                oFila = (ro_Empleado_Info)gridView.GetRow(e.RowHandle);

                //VALIDA QUE EL VALOR SEA MAYOR QUE CERO
                if (oFila.SueldoActual > 0 && (oFila.SueldoActual>=oFila.em_sueldoBasicoMen))
                {
                    if ((bool)gridView.GetFocusedRowCellValue(colcheck))
                    {
                        // gridView.SetFocusedRowCellValue(colSueldoActual, 0);
                        gridView.SetFocusedRowCellValue(colcheck, false);
                    }
                    else
                    {
                        gridView.SetFocusedRowCellValue(colcheck, true);
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }

   
        private void ChkAll_CheckedChanged(object sender, EventArgs e)
        {

            try
            {
                if (ChkAll.Checked)
                {
                    for (int i = 0; i < gridView.RowCount; i++)
                    {
                        gridView.SetRowCellValue(i, colcheck, true);
                    }
                }
                else
                {
                    for (int i = 0; i < gridView.RowCount; i++)
                    {
                        gridView.SetRowCellValue(i, colcheck, false);
                        gridView.SetRowCellValue(i, colSueldoActual, 0);
                    }
                }         
            }
            catch (Exception ex)
            {
                 MessageBox.Show(ex.Message);
                 Log_Error_bus.Log_Error(ex.Message);
            }                               
        }

  

       public void calcular()
        {
            try
            {
                double valor = 0;
                int cuenta = 0;
                List<ro_Empleado_Info> List = (List<ro_Empleado_Info>)grdLista.DataSource;

                if (rbtValor.Checked == true)
                {
                    valor = Convert.ToDouble(txeIncremento.EditValue);

                }
                if (rbtPorcentaje.Checked == true)
                {
                    valor = Convert.ToDouble(txeIncremento.EditValue);
                }
                if (valor > 0)
                {
                    foreach (var item in List)
                    {
                        if (item.check == true)
                        {
                            if (rbtValor.Checked == true) 
                                item.SueldoActual = (item.em_sueldoBasicoMen + valor);
                            else                                                             
                               item.SueldoActual = (item.em_sueldoBasicoMen + (item.em_sueldoBasicoMen * valor) / 100);                               
                            cuenta++;
                        }                      
                    }
                }
                else
                {
                    foreach (var item in List)
                    {
                        if (item.check == true)
                        {
                            if (rbtValor.Checked == true)
                            {
                                item.SueldoActual = Convert.ToDouble(0);
                                // txtIncremento.Text = Convert.ToString(tbcIncremento.Value);
                            }
                            else
                            {
                                item.SueldoActual = Convert.ToDouble(0);
                            }
                        }

                       else
                        {
                            if (rbtValor.Checked == true)
                            {
                               
                                item.SueldoActual = Convert.ToDouble(0);                               
                            }
                            else
                            {
                                
                                item.SueldoActual = Convert.ToDouble(0);
                            }                      
                        }                     
                    }
                }

               
                grdLista.DataSource = null;
                grdLista.DataSource = List;

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }

      
        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                
                    if (txeIncremento.Text.Length==0 || txeIncremento.Text == "" || txeIncremento.Text == null){
                        MessageBox.Show("Debe ingresar el porcentaje del incremento, es obligatorio","ATENCION",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                        txeIncremento.Focus();
                        return;
                    }

                    if (decimal.Parse(txeIncremento.Text)<=0)
                    {
                        MessageBox.Show("El porcentaje del incremento debe ser mayor que cero, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        txeIncremento.Focus();
                        return;
                    }

                    
                    this.calcular();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }           
        }

   
        private void groupBox1_Enter(object sender, EventArgs e){}

        private void frmRo_Act_SueldoXEmpleado_Mant_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void gridView_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            try
            {
                GridView view = sender as GridView;
            GridColumn inOrdenCol = view.Columns["colSueldoActual"];

            ro_Empleado_Info oFila = new ro_Empleado_Info();
            oFila = (ro_Empleado_Info)gridView.GetRow(e.RowHandle);

            if (rbtValor.Checked)
            {
         
            if (oFila.SueldoActual<oFila.em_sueldoBasicoMen  && oFila.check==true)
            {
                e.Valid = false;
                view.SetColumnError(inOrdenCol, "El Sueldo Nuevo debe ser mayor o igual que el Sueldo Anterior, revise por favor");
            }

            if (oFila.SueldoActual==0 && oFila.check == true)
            {
                e.Valid = false;
                view.SetColumnError(inOrdenCol, "El Sueldo Nuevo debe ser mayor a cero, revise por favor");
            }

        }
        
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }    
        }

        private void gridView_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }

        private void gridView_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {

                    ro_Empleado_Info oFila = new ro_Empleado_Info();
                    oFila = (ro_Empleado_Info)gridView.GetFocusedRow();                  
                    if (oFila.SueldoActual > 0 && (oFila.SueldoActual >= oFila.em_sueldoBasicoMen))
                    {
                        gridView.SetFocusedRowCellValue(colcheck, true);
                    }
                    else
                    {
                        gridView.SetFocusedRowCellValue(colcheck, false);
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }






        }

        private void gridView_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                ro_Empleado_Info oFila = new ro_Empleado_Info();
            oFila = (ro_Empleado_Info)gridView.GetFocusedRow();
            if (oFila.SueldoActual > 0 && (oFila.SueldoActual >= oFila.em_sueldoBasicoMen))
            {
                gridView.SetFocusedRowCellValue(colcheck, true);
            }
            else
            {
                gridView.SetFocusedRowCellValue(colcheck, false);
            }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }

        }

     

        private void CmbDepartamento_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                pu_CargaInicial();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }          
    }
}
