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


namespace Core.Erp.Winform.Produc_Cirdesus
{
    public partial class FrmPrd_ProveedorConsulta : Form
    {

        FrmPrd_ProveedorMantenimiento frm = new FrmPrd_ProveedorMantenimiento();

        public FrmPrd_ProveedorConsulta()
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
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                FrmPrd_ProveedorMantenimiento frm = new FrmPrd_ProveedorMantenimiento();
                frm.set_accion(Cl_Enumeradores.eTipo_action.grabar);
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {

                llamaFRM(Cl_Enumeradores.eTipo_action.actualizar);

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {

                llamaFRM(Cl_Enumeradores.eTipo_action.consultar);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                cp_proveedor_Info proveedo_Gri_I = new cp_proveedor_Info();
                proveedo_Gri_I = (cp_proveedor_Info)UltraGridProveedor.GetFocusedRow();
                if (proveedo_Gri_I != null)
                {
                    proveeI = proveedo_Gri_I;
                }
                if (proveeI == null)
                {
                    MessageBox.Show("Selecciones una fila", "sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else if (MessageBox.Show("¿Está seguro que desea anular dicho Proveedor?", "Anulación de Proveedor", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    proveeI.IdUsuarioUltAnu = param.IdUsuario;
                    proveeI.Fecha_UltAnu = param.Fecha_Transac;
                    Bus_Proveedor.AnularDB(proveeI);

                    load_datos();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        #region variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        public cp_proveedor_Info proveeI = new cp_proveedor_Info();
        public tb_persona_Info persoI = new tb_persona_Info();
        public cp_proveedor_Info info_user = new cp_proveedor_Info();
        public tb_persona_bus Bus_Persona = new tb_persona_bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        public cp_proveedor_Bus Bus_Proveedor = new cp_proveedor_Bus();


        BindingList<cp_proveedor_Info> listado_Procedores = new BindingList<cp_proveedor_Info>();

        //propiedad para pasarla a orden de compra
        public cp_proveedor_Info InfoProvee { get; set; }
        //variable que uso para cerrar despues del doble clic, es seteada desde otro form
        public Boolean cerrarPantalla { get; set; }
        //Var que oculta botones
        public Boolean ocultaBotones { get; set; }
        #endregion

        private void set_usuario(int id, string cta, string des, string est, double xim)
        {
            try
            {
                //info_user.idCredito_Predeter = cta;
                info_user.IdCtaCble_CXP = cta;
                info_user.pr_codigo = des;
                info_user.pr_estado = est;
                info_user.pr_nombre  = xim.ToString();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        

        private void llamaFRM(Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {
                cp_proveedor_Info proveedo_Gri_I = new cp_proveedor_Info();
                proveedo_Gri_I = (cp_proveedor_Info)UltraGridProveedor.GetFocusedRow();
                if (proveedo_Gri_I != null)
                {
                    proveeI = proveedo_Gri_I;

                    frm = new FrmPrd_ProveedorMantenimiento();
                    frm.IdProveedorModificar(proveedo_Gri_I.IdProveedor);
                    frm.event_FrmPrd_ProveedorMantenimiento_FormClosing += new FrmPrd_ProveedorMantenimiento.delegate_FrmPrd_ProveedorMantenimiento_FormClosing(frm_event_FrmPrd_ProveedorMantenimiento_FormClosing);
                    frm.set_accion(Accion);
                    frm.MdiParent = this.MdiParent;

                    if (!(Accion == Cl_Enumeradores.eTipo_action.grabar))
                    {

                        frm.set_ProveedorInfo(proveeI);
                        persoI = Bus_Persona.Get_Info_Persona(proveeI.IdPersona);
                        frm.set_PersonaInfo(persoI);
                        frm.set_accion(Cl_Enumeradores.eTipo_action.actualizar);
                        frm.Show();
                    }
                    else
                    {
                        frm.set_accion(Cl_Enumeradores.eTipo_action.grabar);
                        frm.IdProveedor(Bus_Proveedor.GetId(param.IdEmpresa));
                        frm.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void frm_event_FrmPrd_ProveedorMantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                 load_datos();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void frmCP_ProveedorConsulta_Load(object sender, EventArgs e)
        {
            try
            {
               
                load_datos();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void load_datos()
        {
            try
            {

                listado_Procedores = new BindingList<cp_proveedor_Info>(Bus_Proveedor.Get_List_proveedor(param.IdEmpresa));
                this.gridControlProveedor.DataSource = listado_Procedores;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
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
            }
        }

        private void ucGe_Menu_Mantenimiento_x_usuario_Load(object sender, EventArgs e)
        {

        }
    
    }

}
