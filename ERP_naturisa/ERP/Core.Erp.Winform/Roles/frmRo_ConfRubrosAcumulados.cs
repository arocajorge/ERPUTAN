using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.Roles;
using Core.Erp.Info.General;
using Core.Erp.Business.Roles;
using Core.Erp.Business.General;
using Core.Erp.Recursos;


namespace Core.Erp.Winform.Roles
{
    public partial class frmRo_ConfRubrosAcumulados : Form
    {

        #region Declaracion Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        ro_ConfRubrosAcumulados_Bus OCBus = new ro_ConfRubrosAcumulados_Bus();
        ro_rubro_tipo_Bus OCBUS2 = new ro_rubro_tipo_Bus();
        BindingList<ro_ConfRubrosAcumulado_Info> DataSourcce1;
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        public ro_ConfRubrosAcumulado_Info InfoConfRubro = new ro_ConfRubrosAcumulado_Info();
        
        #endregion

        public frmRo_ConfRubrosAcumulados()
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
                Log_Error_bus.Log_Error(ex.ToString());
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
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Grabar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }      

        private void frmRo_ConfRubrosAcumulados_Load(object sender, EventArgs e)
        {
            try
            {
              load_datos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void load_datos()
        {
            try
            {
                var Lista = OCBus.ConsultaGeneral(param.IdEmpresa);

                DataSourcce1 = new BindingList<ro_ConfRubrosAcumulado_Info>(Lista);

                this.grdLista.DataSource = DataSourcce1;



                var Rubros = OCBUS2.ConsultaGeneral(param.IdEmpresa);
                repositoryItemSearchLookUpEdit1.DataSource = Rubros;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.InnerException.ToString());
            }
        }       

        public void Grabar()
        {
            try
            {
                get_Info();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.InnerException.ToString());
            }           
        }

        public ro_ConfRubrosAcumulado_Info get_Info()
        {

            try
            {
                string msg = "";
                int mensaje = 0;

                if (OCBus.EliminarDB(param.IdEmpresa))
                {
                    foreach (var item in DataSourcce1)
                    {
                        InfoConfRubro.IdEmpresa = param.IdEmpresa;
                        InfoConfRubro.IdRubro = item.IdRubro;
                 
                        InfoConfRubro.FechaInicio = item.FechaInicio;
                        InfoConfRubro.FechaFin = item.FechaFin;
                        InfoConfRubro.Configurable = item.Configurable;


                        if (Control_Info() == false)
                        {
                           // MessageBox.Show("No se pudo grabar consulte con el Administrador", "Operación Fallida");
                            return new ro_ConfRubrosAcumulado_Info();
                        }

                        int focus = gridView.FocusedRowHandle;
                        gridView.FocusedRowHandle = focus + 1; 

                        if (OCBus.GrabarDB(InfoConfRubro, ref msg))
                        {
                            mensaje++;
                            
                        }                    
                    }

                    if (mensaje > 0)
                    { 
                        MessageBox.Show(Core.Erp.Recursos.Properties.Resources.msgConfirmaGrabarOk,Core.Erp.Recursos.Properties.Resources.msgTituloGrabar, MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                   
                }
                return InfoConfRubro;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
                return new ro_ConfRubrosAcumulado_Info();
            }
        }

        public Boolean Control_Info()
        {
            try
            {
                if (OCBus.ExisteRubro(param.IdEmpresa, InfoConfRubro.IdRubro))
                {
                    MessageBox.Show("No pueden existir rubros repetidos", "Sistemas");
                    gridView.DeleteSelectedRows();
                    return false;
                }

                if (InfoConfRubro.FechaInicio == Convert.ToDateTime("01-01-0001") || InfoConfRubro.FechaFin == Convert.ToDateTime("01-01-0001"))
                {
                    MessageBox.Show("La fecha de inicio o fin del rubro están en un formato inconsistente... \r Por favor verifique", "Operación Fallida");
                    return false;
                }

                if (InfoConfRubro.FechaInicio > InfoConfRubro.FechaFin)
                {
                    MessageBox.Show("La fecha de inicio : " + InfoConfRubro.FechaInicio + " no puede ser mayor a la fecha final: " + InfoConfRubro.FechaFin + " del rubro. \r Por favor verifique", "Operación Fallida");
                    return false; 
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }                   
        }

        private void gridView_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Delete)
                {
                    if (MessageBox.Show("¿Está seguro que desea eliminar este registro ?", "Elimina", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        gridView.DeleteSelectedRows();

                  }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.InnerException.ToString());
            }

        }

        private void gridView_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e){}

        private void gridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                        //for (int i = 0; i < gridView.RowCount ; i++)
                    //{

                    //    ro_ConfRubrosAcumulado_Info info1 = (ro_ConfRubrosAcumulado_Info)gridView.GetRow(i);

                    //    ro_ConfRubrosAcumulado_Info info2 = (ro_ConfRubrosAcumulado_Info)gridView.GetRow(i + 1);

                    //    if (info2.IdRubro == info1.IdRubro)
                    //    {
                    //        //MessageBox.Show("La fecha : " + info2.FechaPago + "  de la cuota # " + info2.NumCuota + " , no puede ser menor a la fecha de pago de la cuota  #  " + info1.NumCuota + " . Por favor ingrese una fecha válida..... ", " Sistemas");
                    //        MessageBox.Show("iguales");
                    //       // return false;
                    //    }

                    //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
            }


        }

        private void ucGe_Menu_Load(object sender, EventArgs e)
        {

        }

       


    }
}
