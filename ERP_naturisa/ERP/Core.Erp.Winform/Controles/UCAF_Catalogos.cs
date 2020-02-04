using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.ActivoFijo;
using Core.Erp.Info.ActivoFijo;
using Core.Erp.Business.General;
using Core.Erp.Winform.ActivoFijo;
using Core.Erp.Info.General;

namespace Core.Erp.Winform.Controles
{
    public partial class UCAF_Catalogos : DevExpress.XtraEditors.XtraUserControl
    {
        #region Variables
        List<Af_Catalogo_Info> listCatalogo = new List<Af_Catalogo_Info>();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        frmAF_Catalogo_Mantenimiento frm;
        Af_Catalogo_Bus CatalogoBus = new Af_Catalogo_Bus();
        BindingList<Af_Catalogo_Info> CatalogoInfo;
        Af_Catalogo_Info InfoCatalogo = new Af_Catalogo_Info();
        string IdTipoCatalago;

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        #endregion

        #region Propiedades
        public Boolean Visible_btn_Accion { get { return this.cmb_Acciones.Visible; } set { this.cmb_Acciones.Visible = value; } }
        public Boolean Enabled_btn_Accion { get { return this.cmb_Acciones.Enabled; } set { this.cmb_Acciones.Enabled = value; } }

        public Boolean ReadOnly_cmbCatalogo { get { return this.cmbCatalogo.Properties.ReadOnly; } set { this.cmbCatalogo.Properties.ReadOnly = value; } }
        #endregion

        public UCAF_Catalogos()
        {
                InitializeComponent();
        }

        public UCAF_Catalogos(string idTipoCatalogo)
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

        public void cargar_Catalogos(string codigo)
        {
            try
            {
                listCatalogo = new List<Af_Catalogo_Info>();
                listCatalogo = CatalogoBus.Get_List_Catalogo(codigo);
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

        private void llamar_Formulario(Cl_Enumeradores.eTipo_action Accion, string idTipoCatalogo)
        {
            try
            {
                CatalogoInfo = new BindingList<Af_Catalogo_Info>(CatalogoBus.Get_List_Catalogo(idTipoCatalogo));

                frm = new frmAF_Catalogo_Mantenimiento(idTipoCatalogo);               
                frm.Event_frmAF_Catalogo_Mantenimiento_FormClosing += frm_Event_frmAF_Catalogo_Mantenimiento_FormClosing;
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

        void frm_Event_frmAF_Catalogo_Mantenimiento_FormClosing(object sender, FormClosingEventArgs e)
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
                if (IdTipoCatalago != "")
                {
                    cmbCatalogo.EditValue = IdTipoCatalogo;
                }
                else
                    cmbCatalogo.EditValue = null;
                
            }
            catch (Exception ex)
            {

                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public Af_Catalogo_Info get_CatalogosInfo()
        {
            try
            {
                if (cmbCatalogo.EditValue != null)
                {
                    InfoCatalogo = listCatalogo.FirstOrDefault(v => v.IdCatalogo == Convert.ToString(cmbCatalogo.EditValue).Trim());

                }
                else
                {
                    InfoCatalogo = null;
                }
                return InfoCatalogo;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new Af_Catalogo_Info();
            }

        }      

        private void cmbCatalogo_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
