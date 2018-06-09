using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Core.Erp.Info.Inventario;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using Core.Erp.Business.Inventario;
using Core.Erp.Winform.Controles;


namespace Core.Erp.Winform.Inventario
{
    public partial class FrmIn_Ajuste_Inventario_Cons : Form
    {

        #region Declaracion Variable

            tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
            cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
            UCIn_Sucursal_Bodega UCSucu = new UCIn_Sucursal_Bodega();
            in_movi_inven_tipo_Bus MoviTipoB = new in_movi_inven_tipo_Bus();
            in_movi_inve_Bus MoviInven = new in_movi_inve_Bus();
            tb_Sucursal_Info _sucuI = new tb_Sucursal_Info();
            tb_Bodega_Info _bodegaI = new tb_Bodega_Info();
            List<in_Ing_Egr_Inven_Info> listMoviInve = new List<in_Ing_Egr_Inven_Info>();
            List<in_movi_inve_detalle_Info> listMoviInve_detalle = new List<in_movi_inve_detalle_Info>();
            in_Ing_Egr_Inven_Info _MoviInvenInfo = new in_Ing_Egr_Inven_Info();
            in_Ing_Egr_Inven_Bus bus_IngEgr = new in_Ing_Egr_Inven_Bus();
            DevExpress.XtraGrid.Views.Grid.GridView Gview = new DevExpress.XtraGrid.Views.Grid.GridView();

            int idTipoMoviIni = 0;
            int idTipoMoviFin = 0;
        
        #endregion      

        public FrmIn_Ajuste_Inventario_Cons()
        {
            try
            {
                InitializeComponent();
                UCSucu.TipoCarga = Cl_Enumeradores.eTipoFiltro.Normal;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnSalir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnNuevo_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnModificar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnImprimir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnImprimir_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnconsultar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnBuscar_Click += ucGe_Menu_Mantenimiento_x_usuario_event_btnBuscar_Click;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnAnular_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        FrmIn_Ajuste_Inventario_Mant fAjus;

        private void Preparar_formulario(Cl_Enumeradores.eTipo_action _Accion)
        {
            try
            {
                fAjus = new FrmIn_Ajuste_Inventario_Mant();
                _MoviInvenInfo = (in_Ing_Egr_Inven_Info)gvAjustes_Cabecera.GetFocusedRow();
                fAjus.event_frmIn_AjustesInven_Mant_FormClosing += fAjus_event_frmIn_AjustesInven_Mant_FormClosing;
                fAjus.set_Accion(_Accion);

                if (_Accion != Cl_Enumeradores.eTipo_action.grabar)
                {
                    if (_MoviInvenInfo != null)
                    {
                        fAjus.set_info(_MoviInvenInfo);
                        fAjus.MdiParent = this.MdiParent;
                        fAjus.Show();
                    }
                    else
                        MessageBox.Show("Debe seleccionar un registro ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    fAjus.MdiParent = this.MdiParent;
                    fAjus.Show();
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (_MoviInvenInfo != null)
                {
                    if (_MoviInvenInfo.Estado == "I")
                    {
                        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.El_registro_se_encuentra_anulado), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                        Preparar_formulario(Cl_Enumeradores.eTipo_action.Anular);
                }
                else
                    MessageBox.Show("Debe seleccionar un registro ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                cargarData();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Preparar_formulario(Cl_Enumeradores.eTipo_action.consultar);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {

                this.gvAjustes_Cabecera.ShowPrintPreview();
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (_MoviInvenInfo.Estado == "I")
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.El_registro_se_encuentra_anulado), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                    Preparar_formulario(Cl_Enumeradores.eTipo_action.actualizar);
              
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Preparar_formulario(Cl_Enumeradores.eTipo_action.grabar);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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

       private void cargarCombos()
        {

            try
            {
                cmbTipoMoviInven.DataSource = MoviTipoB.Get_list_movi_inven_tipo(param.IdEmpresa, "", "N", "Todos");
                cmbTipoMoviInven.DisplayMember = "tm_descripcion2";
                cmbTipoMoviInven.ValueMember = "IdMovi_inven_tipo";


            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       private void cargarData()
        {
            try
            {

                int idSucursalIni = 0;
                int idSucursalFin = 0;
                int idBodegaFin = 0;
                int idBodegaIni = 0;

                idSucursalIni = ucGe_Menu_Mantenimiento_x_usuario.getIdSucursal == 0 ? 1 : ucGe_Menu_Mantenimiento_x_usuario.getIdSucursal;
                idSucursalFin = ucGe_Menu_Mantenimiento_x_usuario.getIdSucursal == 0 ? 9999 : ucGe_Menu_Mantenimiento_x_usuario.getIdSucursal;

                idBodegaIni = ucGe_Menu_Mantenimiento_x_usuario.getIdBodega == 0 ? 1 : ucGe_Menu_Mantenimiento_x_usuario.getIdBodega;
                idBodegaFin = ucGe_Menu_Mantenimiento_x_usuario.getIdBodega == 0 ? 9999 : ucGe_Menu_Mantenimiento_x_usuario.getIdBodega;

                idTipoMoviIni = Convert.ToInt32(cmbTipoMoviInven.SelectedValue);
                idTipoMoviFin = idTipoMoviIni;
                listMoviInve = new List<in_Ing_Egr_Inven_Info>();
                listMoviInve = bus_IngEgr.Get_List_Ing_Egr_Inven(param.IdEmpresa
                    , idSucursalIni, idSucursalFin, idBodegaIni, idBodegaFin
                    , ucGe_Menu_Mantenimiento_x_usuario.fecha_desde, ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta);

                gridControl.DataSource = listMoviInve;

            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       private  void setear_cabecera_grid()
        { 
            try 
            {
                gvAjustes_Cabecera.ViewCaption = "Movimientos desde:" + ucGe_Menu_Mantenimiento_x_usuario.fecha_desde +
                                                            " Hasta:" + ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta;
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       private void frmIn_AjustesInven_Cosulta_Load(object sender, EventArgs e)
        {
            try
            {
                cargarCombos();
                cargarData();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       void fAjus_event_frmIn_AjustesInven_Mant_FormClosing()
        {
            try
            {
                   cargarData();
            }
            catch (Exception ex)
            {
                 Log_Error_bus.Log_Error(ex.ToString());
                 MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

       private void gvAjustes_Cabecera_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                Gview = (DevExpress.XtraGrid.Views.Grid.GridView)sender;
                _MoviInvenInfo = (in_Ing_Egr_Inven_Info)Gview.GetRow(Gview.FocusedRowHandle);

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

       private void gridControl_Click(object sender, EventArgs e) {}

       private void cmbTipoMoviInven_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                limpiar_grilla();

                List<in_Ing_Egr_Inven_Info> info = new List<in_Ing_Egr_Inven_Info>();
                gridControl.DataSource = info;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       private void dtpDesde_ValueChanged(object sender, EventArgs e)
        {
            setear_cabecera_grid();
            limpiar_grilla();
        }

       private void dtpHasta_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                setear_cabecera_grid();
                limpiar_grilla();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

       private void limpiar_grilla()
        {
            try
            {
                gridControl.DataSource = null;

            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       private void panelSucursal_Paint(object sender, PaintEventArgs e)
         {

         }

       private void gvAjustes_Cabecera_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
         {
             try
             {
                 in_Ing_Egr_Inven_Info data = (in_Ing_Egr_Inven_Info)gvAjustes_Cabecera.GetRow(e.RowHandle);

                 if (data == null)
                 { return; }

                 if (data.Estado == "I")
                 {
                     e.Appearance.ForeColor = Color.Red;
                 }
             }
             catch (Exception ex)
             {
                 Log_Error_bus.Log_Error(ex.ToString());
                 MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }                        
         }

       private void ucGe_Menu_Mantenimiento_x_usuario_Load(object sender, EventArgs e)
         {
         }

       private void gvAjustes_Cabecera_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
       {

       }

    }
}

/// <summary>
/// Prog: Katiuska Franco
/// Ult Mod: 26/02/2014  12:09
/// LIN 365
/// </summary>