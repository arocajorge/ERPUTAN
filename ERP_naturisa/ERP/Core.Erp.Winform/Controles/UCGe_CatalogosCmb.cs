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
using Core.Erp.Winform.General;

namespace Core.Erp.Winform.Controles
{
    public partial class UCGe_CatalogosCmb : UserControl
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        FrmGe_CatalogoTipo_man frm;
        tb_Catalogo_Bus CatalogoBus = new tb_Catalogo_Bus();
        List<tb_Catalogo_Info> listCatalogo = new List<tb_Catalogo_Info>();
        BindingList<tb_Catalogo_Info> CatalogoInfo;
        tb_Catalogo_Info InfoCatalogo = new tb_Catalogo_Info();
        int IdTipoCatalago;

        public UCGe_CatalogosCmb()
        {
            InitializeComponent();
        }

        public UCGe_CatalogosCmb(int idTipoCatalogo)
        {
            InitializeComponent();
            IdTipoCatalago = idTipoCatalogo;
        }

        private void UCGe_CatalogosCmb_Load(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
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


        public void cargar_Catalogos(int IdTipoCatalogo_Cod)
        {
            try
            {
                listCatalogo = new List<tb_Catalogo_Info>();
                listCatalogo = CatalogoBus.Get_CatalogoPorTipo(IdTipoCatalogo_Cod);
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

        private void llamar_Formulario(Cl_Enumeradores.eTipo_action Accion, int idTipoCatalogo)
        {
            try
            {
                CatalogoInfo = new BindingList<tb_Catalogo_Info>(CatalogoBus.Get_CatalogoPorTipo(idTipoCatalogo));

                frm = new FrmGe_CatalogoTipo_man(idTipoCatalogo);
                frm.Event_frmGe_CatalogoTipo_man_FormClosing += frm_Event_frmGe_CatalogoTipo_man_FormClosing;
                if (!(Accion == Cl_Enumeradores.eTipo_action.grabar))
                {
                    frm.SetInfo = InfoCatalogo;
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

        void frm_Event_frmGe_CatalogoTipo_man_FormClosing(object sender, FormClosingEventArgs e)
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

        public tb_Catalogo_Info get_CatalogosInfo()
        {
            try
            {
                InfoCatalogo = listCatalogo.First(v => v.CodCatalogo == Convert.ToString(cmbCatalogo.EditValue));
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
