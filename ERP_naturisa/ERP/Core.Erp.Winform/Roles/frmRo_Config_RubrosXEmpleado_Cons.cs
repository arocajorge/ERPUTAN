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

namespace Core.Erp.Winform.Roles
{
    public partial class frmRo_Config_RubrosXEmpleado_Cons : Form
    {
        #region Declaracion de Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        ro_rubro_tipo_Info InfoIzquir = new ro_rubro_tipo_Info();
        ro_rubro_tipo_Info InfoDerecha = new ro_rubro_tipo_Info();


        ro_Config_rubros_x_Prestamo_Bus Bus_ConfPrestamo = new ro_Config_rubros_x_Prestamo_Bus();

        List<ro_rubro_tipo_Info> LstInfoDerechane = new List<ro_rubro_tipo_Info>();
        List<ro_rubro_tipo_Info > LstInfoIzquir = new List<ro_rubro_tipo_Info>();

        #endregion

        private Cl_Enumeradores.eTipo_action Accion;
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        int focus;
        Dictionary<string, ro_rubro_tipo_Info> dicder = new Dictionary<string, ro_rubro_tipo_Info>();

        int focus2;
        Dictionary<string, ro_rubro_tipo_Info> dicderIzquei = new Dictionary<string, ro_rubro_tipo_Info>();
        public frmRo_Config_RubrosXEmpleado_Cons()
        {
            try
            {
                InitializeComponent();

                ucGe_Menu_Superior_Mant.event_btnGuardar_Click += ucGe_Menu_Superior_Mant_event_btnGuardar_Click;
                ucGe_Menu_Superior_Mant.event_btnGuardar_y_Salir_Click += ucGe_Menu_Superior_Mant_event_btnGuardar_y_Salir_Click;
                ucGe_Menu_Superior_Mant.event_btnSalir_Click += ucGe_Menu_Superior_Mant_event_btnSalir_Click;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
            }            
        }

        void ucGe_Menu_Superior_Mant_event_btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void ucGe_Menu_Superior_Mant_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            pu_Guardar();
            this.Close();
        }

        void ucGe_Menu_Superior_Mant_event_btnGuardar_Click(object sender, EventArgs e)
        {
            
            try
            {
                pu_Guardar();
            }
            catch (Exception ex)
            {
                
                 MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }



        private void frmRo_Config_RubrosXEmpleado_Cons_Load(object sender, EventArgs e)
        {
            try
            {
                ro_rubro_tipo_Bus Bus_Rubro = new ro_rubro_tipo_Bus();
                LstInfoIzquir = Bus_Rubro.ConsultaGeneral(param.IdEmpresa);

              //  var TxEmpre = Bus_ConfRu.ConsultaGeneral(param.IdEmpresa);
                var TxEmpre = Bus_ConfPrestamo.ConsultaGeneral(param.IdEmpresa);

                var ids = from q in TxEmpre 
                          select q.IdRubro;

                if (ids.Count() != null && ids.Count() != 0)
                {
                    var Derecha = from q in LstInfoIzquir
                                  where ids.Contains(q.IdRubro)
                                  select q;

                    int sec = 1;
                    Derecha.ToList().ForEach(v => { v.ru_orden = sec; sec++; });
                    gridControlRubroE.DataSource = Derecha.ToList();

                    foreach (var item in Derecha.ToList())
                    {
                        LstInfoIzquir.Remove(item);
                    }

                    gridControlRubroG.DataSource = LstInfoIzquir;

                    LstInfoDerechane = (List<ro_rubro_tipo_Info>)gridControlRubroE.DataSource;
                    foreach (var item in LstInfoDerechane)
                    {
                        dicder.Add(item.IdRubro, item);
                    }

                    LstInfoIzquir = (List<ro_rubro_tipo_Info>)gridControlRubroG.DataSource;
                    foreach (var item in LstInfoIzquir)
                    {
                        dicderIzquei.Add(item.IdRubro, item);
                    }
                }
                else
                {
                    gridControlRubroG.DataSource = LstInfoIzquir;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
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

      

        private void btnDerechaTodos_Click(object sender, EventArgs e)
        {
            try
            {
                int sec = 1;
                List<ro_rubro_tipo_Info> RubroLstxEmpre;
                List<ro_rubro_tipo_Info> CbtesLst = (List<ro_rubro_tipo_Info>)gridControlRubroG.DataSource;
                if (gridViewRubroE.RowCount == 0)
                {
                    RubroLstxEmpre = new List<ro_rubro_tipo_Info>();

                }
                else
                {
                    RubroLstxEmpre = (List<ro_rubro_tipo_Info>)gridControlRubroE.DataSource;
                }
                if (CbtesLst != null)
                {
                    foreach (var item in CbtesLst)
                    {
                        RubroLstxEmpre.Add(item);
                        gridControlRubroE.DataSource = null;

                        int secuencia = item.ru_orden;
                        RubroLstxEmpre.ToList().ForEach(v => { v.ru_orden = secuencia; secuencia++; });

                        gridControlRubroE.DataSource = RubroLstxEmpre;

                       // ro_Config_Rubros_x_empleado_Info Info = new ro_Config_Rubros_x_empleado_Info();

                        ro_Config_rubros_x_Prestamo_Info Info = new ro_Config_rubros_x_Prestamo_Info();

                        Info.IdEmpresa = param.IdEmpresa;
                        Info.IdRubro = item.IdRubro;
                       // Info.OrdenPres = item.ru_orden;
                        Info.orden = item.ru_orden;
                        var asd = Bus_ConfPrestamo.GuardarDB(Info);
                    }
                    gridControlRubroG.DataSource = null;
                    LstInfoIzquir.Clear();
                    dicderIzquei.Clear();
                    LstInfoDerechane = (List<ro_rubro_tipo_Info>)gridControlRubroE.DataSource;
                    dicder.Clear();
                    
                    foreach (var item in LstInfoDerechane)
                    {
                        dicder.Add(item.IdRubro, item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void BtnIzquierdaTodos_Click(object sender, EventArgs e)
        {
            try
            {
                List<ro_rubro_tipo_Info> CbtesLst; //= (List<ro_rubro_tipo_Info>)gridControlRubroE.DataSource;
                List<ro_rubro_tipo_Info> RubroLstxEmpre = (List<ro_rubro_tipo_Info>)gridControlRubroE.DataSource;
                if (gridViewRubroG.RowCount == 0)
                {
                    CbtesLst = new List<ro_rubro_tipo_Info>();

                }
                else
                {
                    CbtesLst = (List<ro_rubro_tipo_Info>)gridViewRubroG.DataSource;
                }
                if (RubroLstxEmpre != null)
                {

                    foreach (var item in RubroLstxEmpre)
                    {

                      //  ro_Config_Rubros_x_empleado_Info Info = new ro_Config_Rubros_x_empleado_Info();

                        ro_Config_rubros_x_Prestamo_Info Info = new ro_Config_rubros_x_Prestamo_Info();

                        Info.IdEmpresa = param.IdEmpresa;
                        Info.IdRubro = item.IdRubro;

                        if (Bus_ConfPrestamo.Borrar(Info))
                        {
                            CbtesLst.Add(item);
                            gridControlRubroG.DataSource = null;
                            gridControlRubroG.DataSource = CbtesLst;
                        }

                    }
                    gridControlRubroE.DataSource = null;
                    LstInfoDerechane.Clear();
                    dicder.Clear();
                    LstInfoIzquir = (List<ro_rubro_tipo_Info>)gridControlRubroG.DataSource;
                    dicderIzquei.Clear();
                    foreach (var item in LstInfoIzquir)
                    {
                        dicderIzquei.Add(item.IdRubro, item);
                    }
                }
                Recargar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        public void Recargar()
        {
            try
            {
                dicder.Clear();
                dicderIzquei.Clear();
                frmRo_Config_RubrosXEmpleado_Cons_Load(new Object(), new EventArgs());
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void btnIzquierdaUno_Click(object sender, EventArgs e)
        {
            try
            {
                

                ro_Config_rubros_x_Prestamo_Info Info = new ro_Config_rubros_x_Prestamo_Info();

                Info.IdEmpresa = param.IdEmpresa;
                Info.IdRubro = InfoDerecha.IdRubro;

                if (Bus_ConfPrestamo.Borrar(Info))
                {
                    dicderIzquei.Add(InfoDerecha.IdRubro, InfoDerecha);
                    dicder.Remove(InfoDerecha.IdRubro);

                    if (InfoDerecha != null)
                    {
                        LstInfoIzquir.Add(InfoDerecha);
                        gridControlRubroG.DataSource = null;
                        gridControlRubroG.DataSource = LstInfoIzquir;
                        focus2 = gridViewRubroE.FocusedRowHandle;

                        LstInfoDerechane.Remove(InfoDerecha);
                        gridControlRubroE.DataSource = null;
                        
                        int sec = 1;
                        LstInfoDerechane.ToList().ForEach(v => { v.ru_orden = sec; sec++; });

                        gridControlRubroE.DataSource = LstInfoDerechane;
                        gridViewRubroE.FocusedRowHandle = focus2 + 1;
                    }
                }
                else
                {
                    MessageBox.Show("Problemas al eliminar el registro", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(gridViewRubroE.GetFocusedRowCellValue(col1)) - 1 == 0)
                return;
                gridViewRubroE.SetFocusedRowCellValue(col1, Convert.ToInt32(gridViewRubroE.GetFocusedRowCellValue(col1)) - 1);
                gridViewRubroE.SetRowCellValue(gridViewRubroE.FocusedRowHandle - 1, col1, Convert.ToInt32(gridViewRubroE.GetFocusedRowCellValue(col1)) + 1);
                col1.SortOrder = DevExpress.Data.ColumnSortOrder.Descending;
                col1.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
                }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void btndown_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridViewRubroE.RowCount == Convert.ToInt32(gridViewRubroE.GetFocusedRowCellValue(col1)))
                    return;
                gridViewRubroE.SetFocusedRowCellValue(col1, Convert.ToInt32(gridViewRubroE.GetFocusedRowCellValue(col1)) + 1);

                gridViewRubroE.SetRowCellValue(gridViewRubroE.FocusedRowHandle + 1, col1, Convert.ToInt32(gridViewRubroE.GetFocusedRowCellValue(col1)) - 1);
                col1.SortOrder = DevExpress.Data.ColumnSortOrder.Descending;
                col1.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());               
            }           
        }



        private void pu_Guardar() {
            try
            {
                int msg = 0;
                int focus = gridViewRubroE.FocusedRowHandle;
                gridViewRubroE.FocusedRowHandle = focus + 1;

                if (LstInfoDerechane.Count == 0)
                {
                    MessageBox.Show("No existen rubros que guardar, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;
                }

                foreach (var item in LstInfoDerechane)
                {

                    ro_Config_rubros_x_Prestamo_Info Info_Conf = new ro_Config_rubros_x_Prestamo_Info();

                    Info_Conf.IdEmpresa = param.IdEmpresa;
                    Info_Conf.IdRubro = item.IdRubro;
                    Info_Conf.orden = item.ru_orden;

                    if (Bus_ConfPrestamo.ModificarDB(Info_Conf) == false)
                    {
                        MessageBox.Show("El registro no se pudo guardar, revise por favor", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    msg++;
                }
                if (msg > 0) MessageBox.Show("El registro ha sido guardado con éxito", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.InnerException.ToString());
            }                  
        
        }



        private void btn_guardar_Click(object sender, EventArgs e)
        {
 
        }

        private void gridViewRubroG_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                InfoIzquir = (ro_rubro_tipo_Info)gridViewRubroG.GetFocusedRow();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.InnerException.ToString());
            }
        }

        private void gridViewRubroE_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                InfoDerecha = (ro_rubro_tipo_Info)gridViewRubroE.GetFocusedRow();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.InnerException.ToString());
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e){}

        private void btnGuardarySalir_Click(object sender, EventArgs e)
        {
             
        }

        private void frmRo_Config_RubrosXEmpleado_Cons_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Escape))
            {
                this.Close();
            }
        }

        private void btnDerechaUno_Click(object sender, EventArgs e)
        {
            try
            {
                if (InfoIzquir.IdRubro != null)
                {
                    dicder.Add(InfoIzquir.IdRubro, InfoIzquir);
                    dicderIzquei.Remove(InfoIzquir.IdRubro);

                    //  ro_Config_Rubros_x_empleado_Info Info = new ro_Config_Rubros_x_empleado_Info();

                    ro_Config_rubros_x_Prestamo_Info Info = new ro_Config_rubros_x_Prestamo_Info();


                    Info.IdEmpresa = param.IdEmpresa;
                    Info.IdRubro = InfoIzquir.IdRubro;

                    LstInfoDerechane.Add(InfoIzquir);

                    var asd = Bus_ConfPrestamo.GuardarDB(Info);
                    gridControlRubroE.DataSource = null;

                    int sec = 1;
                    LstInfoDerechane.ToList().ForEach(v => { v.ru_orden = sec; sec++; });
                    gridControlRubroE.DataSource = LstInfoDerechane;

                    focus = gridViewRubroG.FocusedRowHandle;
                    LstInfoIzquir.Remove(InfoIzquir);

                    gridControlRubroG.DataSource = null;
                    gridControlRubroG.DataSource = LstInfoIzquir;
                    gridViewRubroG.FocusedRowHandle = focus + 1;
                }
                else
                {
                    MessageBox.Show("No hay rubro que pasar, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

       
    }
}
