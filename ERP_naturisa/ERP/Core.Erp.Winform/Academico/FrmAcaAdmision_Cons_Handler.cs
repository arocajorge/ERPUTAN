using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Business.Academico;
using Core.Erp.Info.Academico;
using Core.Erp.Business.General;
using Core.Erp.Info.General;

namespace Core.Erp.Winform.Academico
{
   public class FrmAcaAdmision_Cons_Handler
   {
            #region 

               public Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu;
               public Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms;
               public DevExpress.XtraGrid.GridControl gridControlAdmision;
               public DevExpress.XtraGrid.Views.Grid.GridView gvAdmision;
               public System.Windows.Forms.BindingSource acaAdmisionInfoBindingSource;
               public DevExpress.XtraGrid.Columns.GridColumn colIdAdmision;
               public DevExpress.XtraGrid.Columns.GridColumn colCodAdmision;
               public DevExpress.XtraGrid.Columns.GridColumn colpersonaInfo;
               public DevExpress.XtraGrid.Columns.GridColumn colNombres;
               public DevExpress.XtraGrid.Columns.GridColumn colApellidos;
               public DevExpress.XtraGrid.Columns.GridColumn colaspiranteInfo;
               public DevExpress.XtraGrid.Columns.GridColumn colPoseeDiscapacidad;
               public DevExpress.XtraGrid.Columns.GridColumn colTelefonoEmergente;
               public DevExpress.XtraGrid.Columns.GridColumn colEstado;


            #endregion



        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        FrmAcaAdmision_Mant frm;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        Aca_Admision_Info admisionInfo = new Aca_Admision_Info();
        public  Form FrmParent;


        public FrmAcaAdmision_Cons_Handler()
        {
            
        }

        
        public void llenar_grid()
        {
            try
            {
                List<Aca_Admision_Info> lstAdmision = new List<Aca_Admision_Info>();
                Aca_Admision_Bus neg = new Aca_Admision_Bus();
                lstAdmision = neg.Get_List_Admision(param.IdInstitucion);
                gridControlAdmision.DataSource = lstAdmision;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ":" + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);       
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

            
        }

        public void FrmAcaAdmision_Cons_Load(object sender, EventArgs e)
        {
            llenar_grid();
        }

        public void llama_frm(Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {
                frm = new FrmAcaAdmision_Mant();
                frm.event_FrmAcaAdmision_Mant_FormClosing += frm_event_FrmAcaAdmision_Mant_FormClosing;

                if (FrmParent != null)
                {
                    frm.MdiParent = FrmParent;
                }

                if (Accion != Cl_Enumeradores.eTipo_action.grabar)
                {
                    frm.set_Admision(admisionInfo);
                }

                frm.set_Accion(Accion);
                frm.Show();

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ":" + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);       
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void ucGe_Menu_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                llama_frm(Cl_Enumeradores.eTipo_action.grabar);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ":" + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);       
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());

            }
        }

        public void frm_event_FrmAcaAdmision_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                llenar_grid();
            }
            catch (Exception ex)
            {

                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ":" + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);       
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void ucGe_Menu_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Close();
        }

        public void ucGe_Menu_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                admisionInfo = (Aca_Admision_Info)this.gvAdmision.GetFocusedRow();

                if (admisionInfo == null)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_favor_seleccione_item_a_modi), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    llama_frm(Cl_Enumeradores.eTipo_action.actualizar);
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ":" + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);       
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        public void ucGe_Menu_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                admisionInfo = (Aca_Admision_Info)this.gvAdmision.GetFocusedRow();

                if (admisionInfo == null)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_favor_seleccione_item_a_consul), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    llama_frm(Cl_Enumeradores.eTipo_action.consultar);
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ":" + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);       
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void ucGe_Menu_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                admisionInfo = (Aca_Admision_Info)this.gvAdmision.GetFocusedRow();

                if (admisionInfo == null)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_favor_seleccione_item_a_anular), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    llama_frm(Cl_Enumeradores.eTipo_action.Anular);
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ":" + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);       
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        public void ucGe_Menu_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.gridControlAdmision.ShowPrintPreview();
            }
            catch (Exception ex)
            {
                
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ":" + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);       
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

            
        }

        public void gvAdmision_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            try
            {
                var data = gvAdmision.GetRow(e.RowHandle) as Aca_Admision_Info;
                if (data == null)
                    return;
                if (data.Estado == "I")
                    e.Appearance.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ":" + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);       
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }


    }
}
