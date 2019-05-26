using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Core.Erp.Winform.Compras
{
    using Core.Erp.Info.General;
    using Core.Erp.Business.General;
    using Core.Erp.Business.Compras;
    using Core.Erp.Info.Compras;

    public partial class FrmCom_Solicitante_Cons : Form
    {
        #region Variables
        com_solicitante_Bus bus_solicitante;
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        #endregion

        public FrmCom_Solicitante_Cons()
        {
            InitializeComponent();
            bus_solicitante = new com_solicitante_Bus();
        }

        private void FrmCom_Solicitante_Cons_Load(object sender, EventArgs e)
        {
            try
            {
                Buscar();
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void Buscar()
        {
            try
            {
                gc_consulta.DataSource = null;
                gc_consulta.DataSource = bus_solicitante.Get_List_Solicitante(param.IdEmpresa);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void LlamarFormulario(Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {
                var row = (com_solicitante_Info)gv_consulta.GetFocusedRow();
                if (Accion != Cl_Enumeradores.eTipo_action.grabar && row == null)
                {
                    MessageBox.Show("Seleccione un registo",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    return;
                }

                FrmCom_Solicitante_Mant frm = new FrmCom_Solicitante_Mant();
                frm.Set_Info(row ?? new com_solicitante_Info());
                frm.Set_Accion(Accion);
                frm.MdiParent = this.MdiParent;
                frm.event_FrmCom_Solicitante_Mant_FormClosing += frm_event_FrmCom_Solicitante_Mant_FormClosing;
                frm.Show();
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        void frm_event_FrmCom_Solicitante_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            Buscar();
        }

        private void ucGe_Menu_Mantenimiento_x_usuario1_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void ucGe_Menu_Mantenimiento_x_usuario1_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LlamarFormulario(Cl_Enumeradores.eTipo_action.grabar);
        }

        private void ucGe_Menu_Mantenimiento_x_usuario1_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LlamarFormulario(Cl_Enumeradores.eTipo_action.actualizar);
        }

        private void ucGe_Menu_Mantenimiento_x_usuario1_event_btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void ucGe_Menu_Mantenimiento_x_usuario1_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LlamarFormulario(Cl_Enumeradores.eTipo_action.Anular);
        }

        private void ucGe_Menu_Mantenimiento_x_usuario1_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LlamarFormulario(Cl_Enumeradores.eTipo_action.consultar);
        }

    }
}
