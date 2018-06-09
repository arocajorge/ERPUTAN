using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Recursos.Properties;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Winform.General;
using Core.Erp.Winform.Controles;
using Core.Erp.Business.Academico;
using Core.Erp.Info.Academico;
namespace Core.Erp.Winform.Academico
{
    public partial class FrmAca_Pre_Facturacion_Cons : Form
    {
        public FrmAca_Pre_Facturacion_Cons()
        {
            InitializeComponent();
        }
        Aca_Pre_Facturacion_Info info;
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        FrmAca_Pre_Facturacion_Mant frm;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        List<Aca_Pre_Facturacion_Info> lista = new List<Aca_Pre_Facturacion_Info>();
        Aca_Pre_Facturacion_Bus bus_pre = new Aca_Pre_Facturacion_Bus();
        private void ucGe_Menu_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
               

                frm = new FrmAca_Pre_Facturacion_Mant();
                frm.accion = Cl_Enumeradores.eTipo_action.consultar;
                frm.MdiParent = this.MdiParent;
                frm.Show();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }

        private void ucGe_Menu_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            try
            {
                info = new Aca_Pre_Facturacion_Info();
                info = (Aca_Pre_Facturacion_Info)gridView_pre_fac.GetFocusedRow();
                if (info == null)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_un_registro), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                frm = new FrmAca_Pre_Facturacion_Mant();
                frm.accion = Cl_Enumeradores.eTipo_action.consultar;
                frm.MdiParent = this.MdiParent;
                frm.Set(info);
                frm.Show();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }

        private void ucGe_Menu_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void ucGe_Menu_event_btnBuscar_Click(object sender, EventArgs e)
        {
            Cargar_data();
        }

        private void ucGe_Menu_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                info = new Aca_Pre_Facturacion_Info();
                info = (Aca_Pre_Facturacion_Info)gridView_pre_fac.GetFocusedRow();
                if (info == null)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_un_registro), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                frm = new FrmAca_Pre_Facturacion_Mant();
                frm.accion = Cl_Enumeradores.eTipo_action.consultar;
                frm.MdiParent = this.MdiParent;
                frm.Set(info);
                frm.Show();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }

        }
        private void Cargar_data()
        {
            try
            {

                lista = bus_pre.Get_List(param.IdInstitucion);
                gridContro_pre_fac.DataSource = lista;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }

        private void FrmAca_Pre_Facturacion_Cons_Load(object sender, EventArgs e)
        {
            try
            {
                Cargar_data();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }
    }
}
