using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.General;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Info.Facturacion;
using Core.Erp.Business.Facturacion;
using Core.Erp.Info.General;
namespace Core.Erp.Winform.Facturacion
{
    public partial class frmFa_TipoNotaPorSucursal : Form
    {
        #region " Variables y Propiedades "
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        tb_Sucursal_Bus Sucursal_B = new tb_Sucursal_Bus();
        ct_Plancta_Bus PlnCta_B = new ct_Plancta_Bus();
        BindingList<fa_TipoNota_x_Empresa_x_Sucursal_Info> List_Det= new BindingList<fa_TipoNota_x_Empresa_x_Sucursal_Info>();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        fa_TipoNota_Bus TipoNota_B = new fa_TipoNota_Bus();
        fa_TipoNota_x_Empresa_x_Sucursal_Bus Bus = new fa_TipoNota_x_Empresa_x_Sucursal_Bus();
        string MensajeError = "";
        string VerificarBase;
        #endregion

        #region " Constructor "
        public frmFa_TipoNotaPorSucursal()
        {
            try
            {
                InitializeComponent();
                ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
                ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
                ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;

                
                LoadGrid();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }
        #endregion

        #region " Eventos "
        void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (GuardarDatos())
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                GuardarDatos();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
        #endregion

        #region " Guardar Datos "
        Boolean GuardarDatos()
        {
            try
            {
                Boolean bolResult = false;
                if (ValidarDatos())
                {
                    List<fa_TipoNota_x_Empresa_x_Sucursal_Info> lstInfo = new List<fa_TipoNota_x_Empresa_x_Sucursal_Info>();                    
                    foreach (var item in List_Det)
                    {
                        VerificarBase = item.EstaEnBase;
                        if (item.Chek == true)
                            lstInfo.Add(item);
                          
                    }
                    if (lstInfo.Count() != 0)
                    {
                        
                        if (VerificarBase == "N")
                        {
                            if (Bus.GuardarDB(lstInfo, ref MensajeError))
                            {
                                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_guardaron_los_datos_correctamente), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LimpiarDatos();
                            }
                            else
                            {
                                MessageBox.Show(MensajeError, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            if (Bus.ModificarDB(lstInfo, ref MensajeError))
                            {
                                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_modifico_corrrectamente), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LimpiarDatos();
                            }
                            else
                            {
                                MessageBox.Show(MensajeError, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                return bolResult;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
        }
        #endregion

        #region " Validacion "
        Boolean ValidarDatos()
        {
            try
            {
                if (cmbTipoNota.EditValue == null || cmbTipoNota.EditValue == "[Vacío]")
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_) +" " + param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_el) +" Tipo de Nota.", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cmbTipoNota.Focus();
                    return false;
                }
                foreach (var item in List_Det)
                {
                    if (item.Chek == true)
                    {
                        if (item.IdCtaCble == null || item.IdCtaCble== "")
                        {
                            MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_) + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_la) + " Cta. Cble. para la Sucursal " + item.Sucursal, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            gridView.Columns.View.Focus();
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_) + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_la) + " Cta. Cble. para la Sucursal " + item.Sucursal, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        gridView.Columns.View.Focus();
                        return false;
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
        }
        #endregion

        #region " Limpiar "
        void LimpiarDatos()
        {
            try
            {
                List_Det = new BindingList<fa_TipoNota_x_Empresa_x_Sucursal_Info>();
                gridControl.DataSource = List_Det;
                cmbTipoNota.Text = "[Vacío]";
                LoadGrid();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
        #endregion

        #region " Cargar Grid"
        void LoadGrid() 
        {
            try
            {
                var Sucursales = Sucursal_B.Get_List_Sucursal(param.IdEmpresa);
                foreach (var item in Sucursales)
                {
                    fa_TipoNota_x_Empresa_x_Sucursal_Info Info = new fa_TipoNota_x_Empresa_x_Sucursal_Info();
                    Info.IdSucursal = item.IdSucursal;
                    Info.Sucursal = item.Su_Descripcion;
                    Info.IdEmpresa = param.IdEmpresa;
                    List_Det.Add(Info);
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }        
        }
        #endregion

        #region " Eventos Personalizados "
        private void searchLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbTipoNota.EditValue != "[Vacío]")
                {
                    var Consulta = Bus.Get_List_TipoNota_x_Empresa_x_Sucursal_x_TipoNota(param.IdEmpresa, Convert.ToInt32(cmbTipoNota.EditValue));

                    foreach (var item in List_Det)
                    {
                        item.EstaEnBase = "N";
                        item.Chek = false;
                        item.IdCtaCble = null;
                        item.IdTipoNota = Convert.ToInt32(cmbTipoNota.EditValue);
                        foreach (var item1 in Consulta)
                        {
                            if (item.IdSucursal == item1.IdSucursal)
                            {
                                item1.Chek = true;
                                item.Chek = item1.Chek;
                                item.IdCtaCble = item1.IdCtaCble;
                                item.EstaEnBase = item1.EstaEnBase;
                            }

                        }


                    }

                    for (int i = 0; i < gridView.RowCount; i++)
                    {
                        if (gridView.GetRowCellValue(i, colIdCtaCble) != null)
                            gridView.SetFocusedRowCellValue(colEstaEnBase, "S");
                    }
                    gridView.RefreshData();
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
      
      
        private void gridView_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                if (e.Column.Caption == "Cta. Contable")
                {
                    gridView.SetFocusedRowCellValue(colChek, true);
                        foreach (var item in List_Det)
                        { 
                            item.Chek = true;
                            item.IdCtaCble = Convert.ToString(e.Value);
                        }
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
        #endregion

        #region " Evento Load"
        private void frmFa_TipoNotaPorSucursal_Load(object sender, EventArgs e)
        {
            try
            {
                List_Det = new BindingList<fa_TipoNota_x_Empresa_x_Sucursal_Info>();
                gridControl.DataSource = List_Det;
                cmbTipoNota.Properties.DataSource = TipoNota_B.Get_List_TipoNota(param.IdEmpresa);
                cmbCuentaContable.DataSource = PlnCta_B.Get_List_Plancta_x_ctas_Movimiento(param.IdEmpresa, ref MensajeError);
                LoadGrid();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
        #endregion

    }
}
