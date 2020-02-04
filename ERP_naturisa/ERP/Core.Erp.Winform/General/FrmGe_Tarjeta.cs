using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.General;
using Core.Erp.Info.General;


namespace Core.Erp.Winform.General
{
    public partial class FrmGe_Tarjeta : Form
    {
        #region Declaración de Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        vwGe_tb_Tarjeta_tb_Parametro_Info Info = new vwGe_tb_Tarjeta_tb_Parametro_Info();
        tb_banco_Bus BanBus = new tb_banco_Bus();
        tb_tarjeta_parametro_Bus tarBus = new tb_tarjeta_parametro_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        #endregion
       
        public FrmGe_Tarjeta()
        {
            try
            {
                InitializeComponent();
                ucGe_Menu_Mantenimiento_x_usuario.event_btnAnular_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnconsultar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnModificar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnNuevo_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnSalir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick;
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
                Close();
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
                FrmGe_Tarjeta_Mantenimiento FrmTarjMant = new FrmGe_Tarjeta_Mantenimiento();
                FrmTarjMant._Accion = Cl_Enumeradores.eTipo_action.grabar;
                FrmTarjMant.Event_FrmGe_Tarjeta_Mantenimiento_FormClosing += new FrmGe_Tarjeta_Mantenimiento.delegate_FrmGe_Tarjeta_Mantenimiento_FormClosing(FrmTarjMant_Event_FrmGe_Tarjeta_Mantenimiento_FormClosing);
                FrmTarjMant.MdiParent = this.MdiParent;
                FrmTarjMant.Show();
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
                Get();
                FrmGe_Tarjeta_Mantenimiento FrmTarjMant = new FrmGe_Tarjeta_Mantenimiento();
                FrmTarjMant._Accion = Cl_Enumeradores.eTipo_action.actualizar;
                FrmTarjMant.Event_FrmGe_Tarjeta_Mantenimiento_FormClosing += new FrmGe_Tarjeta_Mantenimiento.delegate_FrmGe_Tarjeta_Mantenimiento_FormClosing(FrmTarjMant_Event_FrmGe_Tarjeta_Mantenimiento_FormClosing);
                FrmTarjMant._Info(Info);
                FrmTarjMant.MdiParent = this.MdiParent;
                FrmTarjMant.Show();

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
                Get();
                FrmGe_Tarjeta_Mantenimiento FrmTarjMant = new FrmGe_Tarjeta_Mantenimiento();
                FrmTarjMant._Accion = Cl_Enumeradores.eTipo_action.consultar;
                FrmTarjMant.Event_FrmGe_Tarjeta_Mantenimiento_FormClosing += new FrmGe_Tarjeta_Mantenimiento.delegate_FrmGe_Tarjeta_Mantenimiento_FormClosing(FrmTarjMant_Event_FrmGe_Tarjeta_Mantenimiento_FormClosing);
                FrmTarjMant._Info(Info);
                FrmTarjMant.MdiParent = this.MdiParent;
                FrmTarjMant.Show();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (validarEstado())
                {
                    Get();
                    FrmGe_Tarjeta_Mantenimiento FrmTarjMant = new FrmGe_Tarjeta_Mantenimiento();
                    FrmTarjMant._Accion = Cl_Enumeradores.eTipo_action.Anular;
                    FrmTarjMant.Event_FrmGe_Tarjeta_Mantenimiento_FormClosing += new FrmGe_Tarjeta_Mantenimiento.delegate_FrmGe_Tarjeta_Mantenimiento_FormClosing(FrmTarjMant_Event_FrmGe_Tarjeta_Mantenimiento_FormClosing);
                    FrmTarjMant._Info(Info);
                    FrmTarjMant.MdiParent = this.MdiParent;
                    FrmTarjMant.Show();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        void FrmTarjMant_Event_FrmGe_Tarjeta_Mantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                gridControlTarjeta.DataSource = tarBus.Get_list_tarjeta_parametro(param.IdEmpresa);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }

        private void FrmGe_Tarjeta_Load(object sender, EventArgs e)
        {
            try
            {
                load();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        void load()
        {
            try
            {
                gridControlTarjeta.DataSource = tarBus.Get_list_tarjeta_parametro(param.IdEmpresa);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }

        void Get()
        { 
            try 
	        {
                var item = (vwGe_tb_Tarjeta_tb_Parametro_Info)gridViewTarjeta.GetFocusedRow();
                Info.IdEmpresa = item.IdEmpresa;
                Info.IdTarjeta = item.IdTarjeta;
                Info.tr_Descripcion = item.tr_Descripcion;
                Info.Estado = item.Estado;
                Info.IdBanco = item.IdBanco;
                Info.IdCtaCble_Tarj = item.IdCtaCble_Tarj;
                Info.IdCobro_tipo_x_Tarj = item.IdCobro_tipo_x_Tarj;
                Info.IdCobro_tipo_x_RetFu = item.IdCobro_tipo_x_RetFu;
                Info.IdCobro_tipo_x_RetIva = item.IdCobro_tipo_x_RetIva;
                Info.IdCtaCble_Comision = item.IdCtaCble_Comision;
                Info.Porcetaje_Comision = Convert.ToDouble(item.Porcetaje_Comision);

	        }
	        catch (Exception ex)
	        {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
	        }
        }

        Boolean validarEstado()
        {
            try
            {
                var Info1 = (vwGe_tb_Tarjeta_tb_Parametro_Info)this.gridViewTarjeta.GetFocusedRow();
                if (Info1 == null)
                {
                    MessageBox.Show("Seleccione una fila", "sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
                else
                {
                    if (Info1.Estado == "I")
                    {
                        MessageBox.Show("No se pueden Modificar registros Inactivos ", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
        }

        private void gridViewTarjeta_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridViewTarjeta.GetRow(e.RowHandle) as vwGe_tb_Tarjeta_tb_Parametro_Info;
                if (data == null)
                    return;
                if (data.Estado == "I")
                    e.Appearance.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
