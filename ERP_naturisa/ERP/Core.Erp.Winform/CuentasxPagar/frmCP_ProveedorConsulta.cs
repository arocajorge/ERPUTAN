using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.CuentasxPagar;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using Core.Erp.Winform.Controles;
using Core.Erp.Winform.General;


namespace Core.Erp.Winform.CuentasxPagar
{
    public partial class frmCP_ProveedorConsulta : Form
    {
        #region Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();      
        cp_proveedor_Info Info_Proveedor = new cp_proveedor_Info();        
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        cp_proveedor_Bus proveeB = new cp_proveedor_Bus();
        public Boolean cerrarPantalla { get; set; }
        public Boolean ocultaBotones { get; set; }
        frmCP_Proveedor_Mant frm = new frmCP_Proveedor_Mant();        
        #endregion

        public frmCP_ProveedorConsulta()
        {
            try
            {
            InitializeComponent();
            ucGe_Menu_Mantenimiento_x_usuario.event_btnAnular_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick;
            ucGe_Menu_Mantenimiento_x_usuario.event_btnconsultar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick;
            ucGe_Menu_Mantenimiento_x_usuario.event_btnModificar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick;
            ucGe_Menu_Mantenimiento_x_usuario.event_btnNuevo_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick;
            ucGe_Menu_Mantenimiento_x_usuario.event_btnSalir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick;
            ucGe_Menu_Mantenimiento_x_usuario.event_btnImpExcel_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnImpExcel_ItemClick;
            ucGe_Menu_Mantenimiento_x_usuario.event_btnImprimir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnImprimir_ItemClick;
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
                this.UltraGridProveedor.ShowPrintPreview();
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
       
        void ucGe_Menu_Mantenimiento_x_usuario_event_btnImpExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmCP_Proveedor_ImportWizard frmImp = new frmCP_Proveedor_ImportWizard();
                frmImp.event_frmCP_Proveedor_ImportacionWizard_FormClosing += frm_event_frmCP_Proveedor_ImportacionWizard_FormClosing;
                frmImp.Show();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frm_event_frmCP_Proveedor_ImportacionWizard_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                load_datos();
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
                llamaFRM(Cl_Enumeradores.eTipo_action.grabar);
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
                Info_Proveedor = (cp_proveedor_Info)this.UltraGridProveedor.GetFocusedRow();
                if (Info_Proveedor != null)
                {
                    if (Info_Proveedor.pr_estado == "I")
                    {
                        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.No_se_puede_modif_regis_Inac), param.Nombre_sistema, MessageBoxButtons.OK);
                        return;
                    }

                    llamaFRM(Cl_Enumeradores.eTipo_action.actualizar);
                }
                else
                {
                    MessageBox.Show("Seleccione un registro para continuar", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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

                Info_Proveedor = (cp_proveedor_Info)this.UltraGridProveedor.GetFocusedRow();
                if (Info_Proveedor == null)
                {

                    MessageBox.Show("Seleccione un Registro para continuar","Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                llamaFRM(Cl_Enumeradores.eTipo_action.consultar);

              
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
                Info_Proveedor = (cp_proveedor_Info)this.UltraGridProveedor.GetFocusedRow();
                if (Info_Proveedor.pr_estado == "I")
                {
                    MessageBox.Show("El proveedor: " + Info_Proveedor.pr_nombre + " , ya fue anulado ", "Sistemas");
                    return;
                }

                FrmGe_MotivoAnulacion ofrm = new FrmGe_MotivoAnulacion();

                if (Info_Proveedor.IdEmpresa == 0)
                {
                    MessageBox.Show("Selecciones una fila", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else if (MessageBox.Show("¿Está seguro que desea anular dicho Proveedor?", "Anulación de Proveedor", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ofrm.ShowDialog();
                    Info_Proveedor.MotivoAnulacion = ofrm.motivoAnulacion;
                    Info_Proveedor.ip = param.ip;
                    Info_Proveedor.nom_pc = param.nom_pc;
                    Info_Proveedor.IdUsuarioUltAnu = param.IdUsuario;
                    Info_Proveedor.Fecha_UltAnu = param.Fecha_Transac;
                    if (ofrm.cerrado == "N")
                    {
                        proveeB.AnularDB(Info_Proveedor);
                        MessageBox.Show("Se procedio anular el Proveedor " + Info_Proveedor.IdProveedor.ToString() + " Exitosamente", "Sistema Erp");
                    }
                    load_datos();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void set_usuario(int id, string cta, string des, string est, double xim)
        {
            try
            {
                Info_Proveedor.IdCtaCble_CXP = cta;
                Info_Proveedor.pr_codigo = des;
                Info_Proveedor.pr_estado = est;
                Info_Proveedor.pr_nombre = xim.ToString();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void llamaFRM(Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {
                frm = new frmCP_Proveedor_Mant();

                frm.event_frmCP_MantProveedor_FormClosing += new frmCP_Proveedor_Mant.delegate_frmCP_MantProveedor_FormClosing(frm_event_frmCP_MantProveedor_FormClosing);            
                frm.MdiParent = this.MdiParent;

                if (Accion != Cl_Enumeradores.eTipo_action.grabar)
                {

                    Info_Proveedor = (cp_proveedor_Info)UltraGridProveedor.GetRow(UltraGridProveedor.FocusedRowHandle);
                    frm.set_ProveedorInfo(Info_Proveedor);
                    frm.set_Accion(Accion);
                }
                else
                    frm.set_Accion(Cl_Enumeradores.eTipo_action.grabar);

                frm.Show();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void frm_event_frmCP_MantProveedor_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
               load_datos();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void frmCP_ProveedorConsulta_Load(object sender, EventArgs e)
        {
            try
            {
                if (ocultaBotones == true)
                {
                }
                load_datos();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void load_datos()
        {
            try
            {
                proveeB = new cp_proveedor_Bus();
                List<cp_proveedor_Info> listaProveedor = new List<cp_proveedor_Info>();
                listaProveedor = proveeB.Get_List_proveedor(param.IdEmpresa);
                gridControlProveedor.DataSource = listaProveedor;


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    
        

        

        private void UltraGridProveedor_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = UltraGridProveedor.GetRow(e.RowHandle) as cp_proveedor_Info;

                if (data == null)
                    return;
                if (data.pr_estado == "I")
                    e.Appearance.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UltraGridProveedor_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (cerrarPantalla == true)
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_Mantenimiento_x_usuario_event_btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                load_datos();   
            }
            catch (Exception ex)
            {
                
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
