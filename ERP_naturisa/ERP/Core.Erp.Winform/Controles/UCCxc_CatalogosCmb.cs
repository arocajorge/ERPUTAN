using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Business.CuentasxCobrar;
using Core.Erp.Info.CuentasxCobrar;
using Core.Erp.Winform.CuentasxCobrar;

namespace Core.Erp.Winform.Controles
{
    public partial class UCCxc_CatalogosCmb : UserControl
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        frmCxc_Catalogo_Mantenimiento frm;
        cxc_catalogo_Bus CatalogoBus = new cxc_catalogo_Bus();
        List<cxc_catalogo_Info> listCatalogo = new List<cxc_catalogo_Info>();
        BindingList<cxc_catalogo_Info> CatalogoInfo;
        cxc_catalogo_Info InfoCatalogo = new cxc_catalogo_Info();
        string IdTipoCatalago;

        public UCCxc_CatalogosCmb()
        {
            InitializeComponent();
        }

        public UCCxc_CatalogosCmb(string idTipoCatalogo)
        {
            InitializeComponent();
            IdTipoCatalago = idTipoCatalogo;
        }

        private void cmb_Acciones_Click(object sender, EventArgs e)
        {
            try
            {
                MenuAcciones.Show(cmb_Acciones, new Point(0, cmb_Acciones.Height));
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());   
            }
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                llamar_Formulario(Cl_Enumeradores.eTipo_action.grabar, IdTipoCatalago);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());   
            }
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                get_CatalogosInfo();
                llamar_Formulario(Cl_Enumeradores.eTipo_action.consultar, IdTipoCatalago);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());   
            }
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                get_CatalogosInfo();
                llamar_Formulario(Cl_Enumeradores.eTipo_action.actualizar, IdTipoCatalago);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());   
            }
        }


        public void cargar_Catalogos(string IdTipoCatalogo_Cod)
        {
            try
            {
                listCatalogo = new List<cxc_catalogo_Info>();
                listCatalogo = CatalogoBus.Get_List_catalogo(IdTipoCatalogo_Cod);
                cmbCatalogo.Properties.DataSource = listCatalogo;
                IdTipoCatalago = IdTipoCatalogo_Cod;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());   
            }
        }

        private void llamar_Formulario(Cl_Enumeradores.eTipo_action Accion, string idTipoCatalogo)
        {
            try
            {
                CatalogoInfo = new BindingList<cxc_catalogo_Info>(CatalogoBus.Get_List_catalogo(idTipoCatalogo));

                frm = new frmCxc_Catalogo_Mantenimiento(idTipoCatalogo);
                frm.Event_frmCxc_Catalogo_Mantenimiento_FormClosing += frm_Event_frmCxc_Catalogo_Mantenimiento_FormClosing;
                if (!(Accion == Cl_Enumeradores.eTipo_action.grabar))
                {
                    frm.setInfo = InfoCatalogo;
                    frm.setAccion(Accion);

                }
                else
                    frm.setAccion(Accion);

                frm.Show();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());   
            }
        }

        void frm_Event_frmCxc_Catalogo_Mantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                cargar_Catalogos(IdTipoCatalago);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());   
            }
        }

        public void Perfil_Lectura()
        {
            try
            {
                cmb_Acciones.Enabled = false;
                cmbCatalogo.Properties.ReadOnly = true;

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());   
            }
        }

        public void Inicializar_Catalogos()
        {
            try
            {
                cmbCatalogo.EditValue = null;

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());   
            }
        }

        public void set_CatalogosInfo(string IdTipoCatalogo)
        {
            try
            {
                cmbCatalogo.EditValue = IdTipoCatalogo;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());   
            }
        }

       public cxc_catalogo_Info get_CatalogosInfo()
        {
            try
            {
                if (cmbCatalogo.EditValue != null)
                {
                   InfoCatalogo = listCatalogo.First(v => v.IdCatalogo == Convert.ToString(cmbCatalogo.EditValue));
                }

                return InfoCatalogo;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return null;
            }

        }

        private void cmbCatalogo_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
