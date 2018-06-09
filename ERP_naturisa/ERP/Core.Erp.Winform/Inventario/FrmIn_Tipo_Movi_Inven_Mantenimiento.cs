using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.General;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.Inventario;
using Core.Erp.Business.General;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.Contabilidad;

namespace Core.Erp.Winform.Inventario
{
    public partial class FrmIn_Tipo_Movi_Inven_Mantenimiento : Form
    {

        #region Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        DataTable dt = new DataTable();
        private Cl_Enumeradores.eTipo_action _Accion;
        public void set_Accion(Cl_Enumeradores.eTipo_action iAccion) { _Accion = iAccion; }
        List<in_movi_inven_tipo_x_tb_bodega_Info> listbxs = new List<in_movi_inven_tipo_x_tb_bodega_Info>();
        List<in_movi_inven_tipo_x_tb_bodega_Info> listbxsconsulta = new List<in_movi_inven_tipo_x_tb_bodega_Info>();
        public in_movi_inven_tipo_Info MoviInveI = new in_movi_inven_tipo_Info();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        in_movi_inven_tipo_Bus moviB = new in_movi_inven_tipo_Bus();

        in_movi_inven_tipo_x_tb_bodega_Info grid = new in_movi_inven_tipo_x_tb_bodega_Info();
        public int IdSucursal { get; set; }
        BindingList<in_movi_inven_tipo_x_tb_bodega_Info> DataSource;
        string MensajeError = "";
        ct_Cbtecble_tipo_Bus tpocbte = new ct_Cbtecble_tipo_Bus();
        public in_movi_inven_tipo_Info infoTemp { get; set; }
        public delegate void Delegate_FrmIn_Tipo_Movi_Inven_Mantenimiento_FormClosing(object sender, FormClosingEventArgs e);
        public event Delegate_FrmIn_Tipo_Movi_Inven_Mantenimiento_FormClosing Event_FrmIn_Tipo_Movi_Inven_Mantenimiento_FormClosing;
        
        #endregion

        private void cargarGrid()
        {
            try
            {
                in_movi_inven_tipo_x_tb_bodega_Bus BusMoviTipo = new in_movi_inven_tipo_x_tb_bodega_Bus();
                listbxs = BusMoviTipo.Get_list_movi_inven_tipo_x_tb_bodega(param.IdEmpresa);

                DataSource = new BindingList<in_movi_inven_tipo_x_tb_bodega_Info>(listbxs);

                gridControl.DataSource = DataSource;
                //foreach (in_movi_inven_tipo_x_tb_bodega_Info item in listbxs)
                //{

                //    DataRow filas;
                //    filas = dt.NewRow();
                //    filas["*"] = false;
                //    filas["Sucursal"] = item.Sucursal;
                //    filas[2] = item.IdSucucursal;
                //    filas["Bodega"] = item.Bodega;
                //    filas[4] = item.IdBodega;
                //    dt.Rows.Add(filas);
                //}
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
      
        public FrmIn_Tipo_Movi_Inven_Mantenimiento()
        {
            try
            {
                InitializeComponent();
                cmbCtaCble.EditValueChanged += cmbCtaCble_EditValueChanged;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        
        void cmbCtaCble_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                gridViewBodega.SetFocusedRowCellValue(colEstado, true);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
                
        private void cargar_grid_Ca()
        {
            try
            {
                in_movi_inven_tipo_x_tb_bodega_Bus BusMoviTipo = new in_movi_inven_tipo_x_tb_bodega_Bus();
                //in_movi_inven_tipo_Bus BusTipoMovi = new in_movi_inven_tipo_Bus();


                //listbxsconsulta = BusTipoMovi.consulta_movimiento_tipo_x_bodega(param.IdEmpresa, MoviInveI, IdSucursal);
                  listbxs = BusMoviTipo.Get_list_movi_inven_tipo_x_tb_bodega(param.IdEmpresa);


                foreach (var item in listbxs)
                {
                    DataRow filas;
                    filas = dt.NewRow();
                    filas["*"] = false;
                    filas["Sucursal"] = item.Sucursal;
                    filas[2] = item.IdSucucursal;
                    filas["Bodega"] = item.Bodega;
                    filas[4] = item.IdBodega;
                    if (_Accion == Cl_Enumeradores.eTipo_action.consultar)
                    {
                        foreach (var item1 in listbxsconsulta)
                        {
                            if (item.IdBodega == item1.IdBodega)
                            {
                                filas["*"] = true;
                                filas[5] = item1.IdCtaCble;
                                dt.Rows.Add(filas);
                            }
                        }

                    }
                    else
                    {
                        //foreach (var item1 in listbxsconsulta)
                        //{
                        //    if (item.IdBodega == item1.IdBodega)
                        //    {
                        //        filas["*"] = true;
                        //        filas[5] = item1.IdCtaCble;

                        //    }
                        //}
                        dt.Rows.Add(filas);
                    }



                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        
        private void FrmIn_Tipo_Movi_Inven_Mantenimiento_Load(object sender, EventArgs e)
        {


            try
            {
                Event_FrmIn_Tipo_Movi_Inven_Mantenimiento_FormClosing += FrmIn_Tipo_Movi_Inven_Mantenimiento_Event_FrmIn_Tipo_Movi_Inven_Mantenimiento_FormClosing;
                txtDescripcion.Focus();
                
                //cmbTipoCbte.Properties.DataSource = tpocbte.Get_list_Cbtecble_tipo(param.IdEmpresa,Cl_Enumeradores.eTipoFiltro.Normal, ref MensajeError);
                List<ct_Plancta_Info> _PlanCtaInfo = new List<ct_Plancta_Info>();
                ct_Plancta_Bus _PlanCtaBus = new ct_Plancta_Bus();
                cmbCtaCble.DataSource = _PlanCtaBus.Get_List_Plancta_x_ctas_Movimiento(param.IdEmpresa, ref MensajeError);
                cargarGrid();
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        ucGe_Menu.Enabled_bntAnular = false;
                        chek_Estado.Checked = true;
                        chek_Estado.Enabled = false;
                        chk_genera_mov_inv.Checked = true;

                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        ucGe_Menu.Enabled_bntAnular = false;
                        SetGrid();

                        if (MoviInveI.cm_interno == "S")
                        {
                            chk_Usadoporsistemas.Enabled = false;
                            if (MoviInveI.Estado == "I")
                            {
                                chek_Estado.Enabled = true;
                            }
                            else
                            {
                                chek_Estado.Enabled = false;
                            }
                        }
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
                        ucGe_Menu.Enabled_btnGuardar = false;
                        SetGrid();
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
                        ucGe_Menu.Enabled_btnGuardar = false;
                        ucGe_Menu.Enabled_bntAnular = false;
                        SetGrid();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        
        void FrmIn_Tipo_Movi_Inven_Mantenimiento_Event_FrmIn_Tipo_Movi_Inven_Mantenimiento_FormClosing(object sender, FormClosingEventArgs e) {}

        public void SetGrid()
        {
            try
            {
                in_movi_inven_tipo_x_tb_bodega_Bus BusMoviTipo = new in_movi_inven_tipo_x_tb_bodega_Bus();

                var Consulta = BusMoviTipo.Get_List_movi_inven_tipo_x_tb_bodega(param.IdEmpresa, infoTemp.IdMovi_inven_tipo);
              
                    foreach (in_movi_inven_tipo_x_tb_bodega_Info item in Consulta)
                        {
                        foreach (var Registro in DataSource)
                            {
                                if (item.IdSucucursal == Registro.IdSucucursal && item.IdBodega == Registro.IdBodega)
                                {
                                    Registro.Estado = true;
                                    Registro.IdCtaCble = item.IdCtaCble;
                                }
                            }
                        }
                    gridControl.DataSource = DataSource;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        public void set_Info(in_movi_inven_tipo_Info info)
        {
            try
            {
                if (info != null)
                {
                    txt_Id.Text = info.IdMovi_inven_tipo.ToString();
                    txtCodigo.Text = info.Codigo.ToString();
                    txtDescripcion.Text = info.tm_descripcion;
                    txtDescCorta.Text = info.cm_descripcionCorta;
                    rdb_Ingreso.Checked = (info.cm_tipo_movi == "+") ? true : false;
                    rdb_Egreso.Checked = (!(rdb_Ingreso.Checked));
                    chk_Usadoporsistemas.Checked = (info.cm_interno == "S") ? true : false;
                    chek_Estado.Checked = (info.Estado == "A") ? true : false;
                    cmbTipoCbte.set_TipoCbteCble((int)info.IdTipoCbte);
                    chk_genera_mov_inv.Checked = Convert.ToBoolean(info.Genera_Movi_Inven);
                    chkGenerar_Diario.Checked = Convert.ToBoolean(info.Genera_Diario_Contable);
                    

                    if (chek_Estado.Checked == false)
                    { lblAnulado.Visible = true; }
                    else { lblAnulado.Visible = false; }
                    MoviInveI = info;
                    infoTemp = info;
                }
                else
                {
                    MessageBox.Show("Seleccione un tipo de movimiento.", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public in_movi_inven_tipo_Info get_Info()
        {
            try
            {
                MoviInveI.IdEmpresa = param.IdEmpresa;
                if (txt_Id.Text != "")
                {
                    MoviInveI.IdMovi_inven_tipo =Convert.ToInt32( txt_Id.Text );
                }
                MoviInveI.Codigo = txtCodigo.Text.Trim();
                MoviInveI.tm_descripcion = txtDescripcion.Text.Trim();
                MoviInveI.cm_descripcionCorta = txtDescCorta.Text.Trim();
                MoviInveI.cm_tipo_movi = (rdb_Ingreso.Checked == true) ? "+" : "-";
                MoviInveI.cm_interno = (chk_Usadoporsistemas.Checked == true) ? "S" : "N";
                MoviInveI.Estado = (chek_Estado.Checked == true) ? "A" : "I";
                MoviInveI.IdTipoCbte =cmbTipoCbte.get_TipoCbteCble().IdTipoCbte;
                MoviInveI.Genera_Movi_Inven = chk_genera_mov_inv.Checked;
                MoviInveI.Genera_Diario_Contable=chkGenerar_Diario.Checked ;

                return MoviInveI;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new in_movi_inven_tipo_Info();
            }

        }
        
        public List<in_movi_inven_tipo_x_tb_bodega_Info> get_grid_guardar()
        {

            try
            {
                 return DataSource.ToList().FindAll(v => v.Estado == true); ;
            }
            catch (Exception)
            {

                return new List<in_movi_inven_tipo_x_tb_bodega_Info>(); ;
            }
        }
        
        public List<in_movi_inven_tipo_x_tb_bodega_Info> get_grid_Eliminar()
        {

            try
            {
               
                return DataSource.ToList();//;.FindAll(v=>v.Estado==true) ;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<in_movi_inven_tipo_x_tb_bodega_Info>();
            }
        }
        
        private bool grabar()
        {
            try
            {
                bool resultado = false;
                 if (txtDescripcion.Text == "")
                 {
                     MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_ingrese_la) + " descripción", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                     txtDescripcion.Focus();
                     return resultado;
                 }
                 if (cmbTipoCbte.get_TipoCbteCble() == null)
                 {
                     MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_el) + " tipo de cuenta contable", "Favor ingrese datos");
                     cmbTipoCbte.Focus();
                     return resultado;
                 }
                 if (chek_Estado.Checked == false)
                 {
                     MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_el) + " estado", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                     chek_Estado.Focus();
                     return resultado;
                 }
                 get_Info();
                 string msg = "";
                 string mensajeRecurso = "";
                 

                 if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                 {

                     in_movi_inven_tipo_x_tb_bodega_Bus BusMoviTipo = new in_movi_inven_tipo_x_tb_bodega_Bus();


                     if (moviB.Get_Codigo(MoviInveI, ref msg))
                     {
                         MessageBox.Show(msg);
                     }
                     else if (moviB.GrabarDB(MoviInveI, ref msg) && BusMoviTipo.GrabarDB(get_grid_guardar(), param.IdEmpresa, MoviInveI, ref msg) == true)
                     {
                         resultado = true;
                         mensajeRecurso = Core.Erp.Recursos.Properties.Resources.msgConfirmaGrabarOk;
                         MessageBox.Show(mensajeRecurso, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                         LimpiarDatos();
                     }
                     else
                     {
                         return resultado;
                         mensajeRecurso = Core.Erp.Recursos.Properties.Resources.msgError_Grabar;
                         MessageBox.Show(mensajeRecurso + "\n" + msg, param.Nombre_sistema);
                     }

                 }



                 if (_Accion == Cl_Enumeradores.eTipo_action.actualizar)
                 {
                     in_movi_inven_tipo_x_tb_bodega_Bus BusMoviTipo = new in_movi_inven_tipo_x_tb_bodega_Bus();

                     if (moviB.ModificarDB(MoviInveI, ref msg) && BusMoviTipo.ModificarDB(get_grid_guardar(), param.IdEmpresa, MoviInveI, ref msg))
                     {
                         resultado = true;
                         mensajeRecurso = Core.Erp.Recursos.Properties.Resources.msgConfirmaGrabarOk;
                         MessageBox.Show(mensajeRecurso, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                         _Accion = Cl_Enumeradores.eTipo_action.grabar;
                         LimpiarDatos();
                     }
                     else
                     {
                         mensajeRecurso = Core.Erp.Recursos.Properties.Resources.msgError_Modificar;
                         MessageBox.Show(mensajeRecurso + "\n" + msg, param.Nombre_sistema);
                         return resultado;
                     }

                 }
                 return resultado;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        void LimpiarDatos()
        {
            try
            {
                MoviInveI = new in_movi_inven_tipo_Info();
                DataSource = new BindingList<in_movi_inven_tipo_x_tb_bodega_Info>();
                txt_Id.Text = "";
                txtCodigo.Text = "";
                txtDescripcion.Text = "";
                txtDescCorta.Text = "";
                chk_genera_mov_inv.Checked = true;
                chkGenerar_Diario.Checked = true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void anular()
        {
            if (_Accion == Cl_Enumeradores.eTipo_action.Anular)
            {
                string mensajeRecurso = "";
                try
                {
                    if (MessageBox.Show("Esta Seguro que desea eliminar el Item", param.Nombre_sistema, MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        Core.Erp.Winform.General.FrmGe_MotivoAnulacion omot = new General.FrmGe_MotivoAnulacion();
                        omot.ShowDialog();
                        MoviInveI.MotiAnula = omot.motivoAnulacion;
                        if (moviB.AnularDB (MoviInveI))
                        {
                            ucGe_Menu.Enabled_bntAnular = false;
                            mensajeRecurso = Core.Erp.Recursos.Properties.Resources.msgConfirmaAnulacionOk;
                            MessageBox.Show(mensajeRecurso, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                       {
                            MessageBox.Show("No se Anulado", "Operación Fallida");
                       }
                    }
                }
                catch (Exception ex)
                {
                    Log_Error_bus.Log_Error(ex.ToString());
                    MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        
        //private void ultraGrid_Bodega_ClickCell(object sender, Infragistics.Win.UltraWinGrid.ClickCellEventArgs e) {}
              
        private void FrmIn_Tipo_Movi_Inven_Mantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
              Event_FrmIn_Tipo_Movi_Inven_Mantenimiento_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                anular();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 

        }

        private void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                txtDescripcion.Focus();
                txt_Id.Focus();
                grabar();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                txtDescripcion.Focus();
                txt_Id.Focus();
                if(grabar())
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 

        }

        private void chek_Estado_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chk_seleccionar_todo_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < gridViewBodega.RowCount; i++)
                {
                    gridViewBodega.SetRowCellValue(i, colEstado, chk_seleccionar_todo.Checked);
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }
        
       

  






















    }
}
