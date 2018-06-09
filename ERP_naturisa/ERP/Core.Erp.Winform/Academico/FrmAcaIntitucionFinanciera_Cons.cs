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
    public partial class FrmAcaIntitucionFinanciera_Cons : Form
    {
        #region "Variables"
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        FrmAcaInstitucionFinanciera_Mant frm;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus;
        Aca_InstitucionFinanciera_Info institucionFiInfo;
        #endregion

        public FrmAcaIntitucionFinanciera_Cons()
        {
            InitializeComponent();
            institucionFiInfo = new Aca_InstitucionFinanciera_Info();
            Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        }

        private void llama_frm(Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {
                frm = new FrmAcaInstitucionFinanciera_Mant();
                frm.MdiParent = this.MdiParent;
                frm.event_FrmAcaInstitucionFinanciera_Mant_FormClosing+=frm_event_FrmAcaInstitucionFinanciera_Mant_FormClosing;
                if (Accion != Cl_Enumeradores.eTipo_action.grabar)
                {
                    frm.Set_InstitucionFinanciera(institucionFiInfo);
                }
                frm.Set_Accion(Accion);
                frm.Show();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ":" + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void llenar_grid()
        {
            List<Aca_InstitucionFinanciera_Info> lstInstitucionFi = new List<Aca_InstitucionFinanciera_Info>();
            Aca_InstitucionFinanciera_Bus neg = new Aca_InstitucionFinanciera_Bus();
            lstInstitucionFi = neg.Get_List_InstitucionFinanciera();
            gridControlInstitucionFinanciera.DataSource = lstInstitucionFi;
        }

        #region "Evento"
        private void FrmAca_IntitucionFinanciera_Cons_Load(object sender, EventArgs e)
        {
            try
            {
                llenar_grid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ":" + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void ucGe_Menu_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void ucGe_Menu_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                llama_frm(Cl_Enumeradores.eTipo_action.grabar);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ":" + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void frm_event_FrmAcaInstitucionFinanciera_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                llenar_grid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ":" + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                institucionFiInfo = (Aca_InstitucionFinanciera_Info)this.gridViewInstitucionFinanciera.GetFocusedRow();

                if (institucionFiInfo == null)
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
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ":" + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                institucionFiInfo = (Aca_InstitucionFinanciera_Info)this.gridViewInstitucionFinanciera.GetFocusedRow();

                if (institucionFiInfo == null)
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
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ":" + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                institucionFiInfo = (Aca_InstitucionFinanciera_Info)this.gridViewInstitucionFinanciera.GetFocusedRow();

                if (institucionFiInfo == null)
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
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ":" + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ucGe_Menu_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.gridControlInstitucionFinanciera.ShowPrintPreview();
        }
        #endregion

        private void gridViewInstitucionFinanciera_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            try
            {
                var data = gridViewInstitucionFinanciera.GetRow(e.RowHandle) as Aca_InstitucionFinanciera_Info;
                if (data == null)
                    return;
                if (data.Estado == "I")
                    e.Appearance.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

    }


}
