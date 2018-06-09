using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Business.Facturacion;
using Core.Erp.Info.Facturacion;
using Core.Erp.Business.General;
using Core.Erp.Winform.Facturacion;
using Core.Erp.Info.General;

namespace Core.Erp.Winform.Controles
{
    public partial class UCFa_CatalogosCmb : UserControl
    {
        #region Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        List<fa_catalogo_Info> listCatalogo = new List<fa_catalogo_Info>();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        frmFa_Catalogo_Mant frm;
        fa_catalogo_Bus CatalogoBus = new fa_catalogo_Bus();
        BindingList<fa_catalogo_Info> CatalogoInfo;
        fa_catalogo_Info InfoCatalogo = new fa_catalogo_Info();
        int IdTipoCatalago;
        #endregion

        #region Propiedades

        public Boolean Visible_cmb_Accion
        {
            get { return this.cmb_Acciones.Visible; }
            set { this.cmb_Acciones.Visible = value; }
        }

        #endregion

        public UCFa_CatalogosCmb()
        {
            InitializeComponent();
        }

        public UCFa_CatalogosCmb(int idTipoCatalogo)
        {
            try
            {
                InitializeComponent();
                IdTipoCatalago = idTipoCatalogo;
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

        public void cargar_Catalogos(int codigo)
        {
            try
            {
                listCatalogo = new List<fa_catalogo_Info>();
                listCatalogo = CatalogoBus.Get_List_catalogo(codigo);
                cmbCatalogo.Properties.DataSource = listCatalogo;
                IdTipoCatalago = codigo;
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
                CatalogoInfo = new BindingList<fa_catalogo_Info>(CatalogoBus.Get_List_catalogo(idTipoCatalogo));

                frm = new frmFa_Catalogo_Mant(idTipoCatalogo);
                frm.event_frmFA_Catalogo_Mant_FormClosing += frm_event_frmFA_Catalogo_Mant_FormClosing;
                if (Accion != Cl_Enumeradores.eTipo_action.grabar)
                {
                    if (InfoCatalogo != null)
                    {
                        if (InfoCatalogo.IdCatalogo_tipo != 0)
                        {
                            frm.setInfo = InfoCatalogo;
                            frm.setAccion(Accion);
                            frm.Show();
                        }
                        else
                            MessageBox.Show("No ha seleccionado ningún registro.\nEscoja un registro para continuar", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    frm.setAccion(Accion);
                    frm.Show();
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());   
            }
        }

        void frm_event_frmFA_Catalogo_Mant_FormClosing(object sender, FormClosingEventArgs e)
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
                cmb_Acciones.Visible = false;
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

        public fa_catalogo_Info get_CatalogosInfo()
        {
            try
            {

                if (cmbCatalogo.EditValue != null)
                {
                    InfoCatalogo = listCatalogo.Where(v => v.IdCatalogo == Convert.ToString(cmbCatalogo.EditValue)).FirstOrDefault();
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
