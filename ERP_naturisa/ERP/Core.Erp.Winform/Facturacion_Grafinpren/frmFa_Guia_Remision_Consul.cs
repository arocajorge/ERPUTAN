using Core.Erp.Business.General;
using Core.Erp.Info.Facturacion;
using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Core.Erp.Winform.Facturacion_Grafinpren
{
    public partial class frmFa_Guia_Remision_Consul : Form
    {

        #region Declaraciones
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        tb_Sucursal_Info _SucursalInfo = new tb_Sucursal_Info();
        tb_Bodega_Info _BodegaInfo = new tb_Bodega_Info();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        fa_guia_remision_Info Info = new fa_guia_remision_Info();
        Cl_Enumeradores.eTipo_action Accion;
        Core.Erp.Business.Facturacion_Grafinpren.fa_guia_remision_graf_Bus Bus_guia = new Business.Facturacion_Grafinpren.fa_guia_remision_graf_Bus();
        List<fa_guia_remision_Info> Lst_guia = new List<fa_guia_remision_Info>();
        #endregion

        #region "Constructor"
        public frmFa_Guia_Remision_Consul()
        {
            InitializeComponent();
            ucGe_Menu_Mantenimiento_x_usuario.event_btnconsultar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick;
            ucGe_Menu_Mantenimiento_x_usuario.event_btnModificar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick;
            ucGe_Menu_Mantenimiento_x_usuario.event_btnNuevo_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick;
            ucGe_Menu_Mantenimiento_x_usuario.event_btnAnular_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick;
            ucGe_Menu_Mantenimiento_x_usuario.event_btnSalir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick;
            ucGe_Menu_Mantenimiento_x_usuario.event_btnImprimir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnImprimir_ItemClick;
            ucGe_Menu_Mantenimiento_x_usuario.event_btnfiltro_fecha_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnfiltro_fecha_ItemClick;
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnfiltro_fecha_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LlenarGrid();
        }
        #endregion

        #region "Eventos"
        void ucGe_Menu_Mantenimiento_x_usuario_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.gridControlGuiaRemision.ShowPrintPreview();
        }
        
        void ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Info = (fa_guia_remision_Info)this.gridViewGuiaRemision.GetFocusedRow();
            if (Info == null)
            {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_favor_seleccione_item_a_anular), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                     llama_frm(Cl_Enumeradores.eTipo_action.Anular);
                }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            llama_frm(Cl_Enumeradores.eTipo_action.grabar);
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Info = (fa_guia_remision_Info)this.gridViewGuiaRemision.GetFocusedRow();
            if (Info == null)
            {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_favor_seleccione_item_a_modi), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                     llama_frm(Cl_Enumeradores.eTipo_action.actualizar);
                }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Info = (fa_guia_remision_Info)this.gridViewGuiaRemision.GetFocusedRow();
            if (Info == null)
            {
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_favor_seleccione_item_a_consul), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                llama_frm(Cl_Enumeradores.eTipo_action.consultar);
            }
        }
       
        private void frmFa_Guia_Remision_Consul_Load(object sender, EventArgs e)
        {
            try
            {
                LlenarGrid();
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

        private void gridViewGuiaRemision_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridViewGuiaRemision.GetRow(e.RowHandle) as fa_guia_remision_Info;
                if (data == null)
                    return;

                if (data.Estado == "I")
                e.Appearance.ForeColor = Color.Red;
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

        void frm_Event_frmFA_Guia_Remision_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                LlenarGrid();
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

        #region" Llamar Formulario"
        private void llama_frm(Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {

                frmFa_Guia_Remision_Mant frm = new frmFa_Guia_Remision_Mant();
                frm.MdiParent = this.MdiParent;
                if (Accion != Cl_Enumeradores.eTipo_action.grabar)
                {
                    frm.SetInfo(Info);
                }
                frm.Event_frmFA_Guia_Remision_Mant_FormClosing += frm_Event_frmFA_Guia_Remision_Mant_FormClosing;
                frm.setAccion(Accion);
                frm.Show();

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
        private void LlenarGrid()
        {
            try
            {
               
                Lst_guia = Bus_guia.Get_List_guia_remision(param.IdEmpresa, ucGe_Menu_Mantenimiento_x_usuario.getIdSucursal, ucGe_Menu_Mantenimiento_x_usuario.getIdSucursal
                                                            , ucGe_Menu_Mantenimiento_x_usuario.getIdBodega, ucGe_Menu_Mantenimiento_x_usuario.getIdBodega
                                                            , ucGe_Menu_Mantenimiento_x_usuario.fecha_desde, ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta);
                gridControlGuiaRemision.DataSource = Lst_guia;
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
