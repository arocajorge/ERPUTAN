using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Info.Facturacion;
using Core.Erp.Business.Facturacion;
using Core.Erp.Business.General;
using Core.Erp.Info.General;

namespace Core.Erp.Winform.Facturacion
{
    public partial class frmFa_factura_NotaDeb_a_cruzar : Form
    {
        #region Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        fa_notaCreDeb_x_fa_factura_NotaDeb_Bus Bus_FactNotaDeb_x_cruzar = new fa_notaCreDeb_x_fa_factura_NotaDeb_Bus();
        List<fa_notaCreDeb_x_fa_factura_NotaDeb_Info> Lst_FactNotaDeb_x_cruzar = new List<fa_notaCreDeb_x_fa_factura_NotaDeb_Info>();
        fa_notaCreDeb_x_fa_factura_NotaDeb_Info Info_FactNotaDeb_x_cruzar = new fa_notaCreDeb_x_fa_factura_NotaDeb_Info();
        #endregion

        public frmFa_factura_NotaDeb_a_cruzar()
        {
            InitializeComponent();
        }

        public void Cargar_combos(decimal IdCliente)
        {
            try
            {
                Lst_FactNotaDeb_x_cruzar = Bus_FactNotaDeb_x_cruzar.Get_list_docs_x_cruzar(param.IdEmpresa, IdCliente);
                gridControlDocs.DataSource = Lst_FactNotaDeb_x_cruzar;
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

        public fa_notaCreDeb_x_fa_factura_NotaDeb_Info Get_Info()
        {
            try
            {
                return Info_FactNotaDeb_x_cruzar;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return null;
            }
        }

        private void gridViewDocs_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                Info_FactNotaDeb_x_cruzar = (fa_notaCreDeb_x_fa_factura_NotaDeb_Info)gridViewDocs.GetRow(e.FocusedRowHandle);
                if (Info_FactNotaDeb_x_cruzar!=null)
                {
                    Info_FactNotaDeb_x_cruzar.Valor_Aplicado = Info_FactNotaDeb_x_cruzar.saldo==null ? 0 : (double)Info_FactNotaDeb_x_cruzar.saldo;
                    Info_FactNotaDeb_x_cruzar.saldo = Info_FactNotaDeb_x_cruzar.saldo == null ? 0 : (double)Info_FactNotaDeb_x_cruzar.saldo;
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

        private void gridViewDocs_DoubleClick(object sender, EventArgs e)
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

        private void btnVaciar_Click(object sender, EventArgs e)
        {
            try
            {
                Info_FactNotaDeb_x_cruzar = null;
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

        private void gridViewDocs_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
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
    }
}
