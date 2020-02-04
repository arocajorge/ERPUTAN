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
using Core.Erp.Business.Inventario;
using Core.Erp.Info.Inventario;
using Core.Erp.Winform.Inventario;

namespace Core.Erp.Winform.Controles
{
    public partial class UCIn_Catalogos_Cmb : UserControl
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        FrmIn_Catalogo_Mant frm;
        in_Catalogo_Bus CatalogoBus = new in_Catalogo_Bus();
        List<in_Catalogo_Info> listCatalogo = new List<in_Catalogo_Info>();
        BindingList<in_Catalogo_Info> CatalogoInfo;
        in_Catalogo_Info InfoCatalogo = new in_Catalogo_Info();

        int IdTipoCatalago;

        public delegate void delegate_cmbCatalogo_EditValueChanged(object sender, EventArgs e);
        public event delegate_cmbCatalogo_EditValueChanged event_delegate_cmbCatalogo_EditValueChanged;

        public Boolean Visible_btn_acciones
        {
            get { return this.cmb_Acciones.Visible; }
            set { this.cmb_Acciones.Visible = value; }
        }


        

        public UCIn_Catalogos_Cmb()
        {
            InitializeComponent();
            event_delegate_cmbCatalogo_EditValueChanged += UCIn_Catalogos_Cmb_event_delegate_cmbCatalogo_EditValueChanged;
        }

        void UCIn_Catalogos_Cmb_event_delegate_cmbCatalogo_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        public UCIn_Catalogos_Cmb(int IdTipo_Catalago)
        {
            InitializeComponent();
            IdTipoCatalago = IdTipo_Catalago;
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
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Get_CatalogosInfo();
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
                Get_CatalogosInfo();
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
                listCatalogo = new List<in_Catalogo_Info>();
                listCatalogo = CatalogoBus.Get_List_Catalogo(IdTipoCatalogo_Cod);
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
                CatalogoInfo = new BindingList<in_Catalogo_Info>(CatalogoBus.Get_List_Catalogo(idTipoCatalogo));

                frm = new FrmIn_Catalogo_Mant(Accion);
                frm.txtIdCatalogo_tipo.Text = Convert.ToString(idTipoCatalogo);
                frm.event_FrmIn_Catalogo_Mant_FormClosing += frm_event_FrmIn_Catalogo_Mant_FormClosing;
                if (Accion != Cl_Enumeradores.eTipo_action.grabar)
                {
                    if (InfoCatalogo != null)
                    {
                        frm._SetInfo = InfoCatalogo;
                        frm.Show();
                    }
                    else
                        MessageBox.Show("Seleccione un registro antes de proceder", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                    frm.Show();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void frm_event_FrmIn_Catalogo_Mant_FormClosing(object sender, FormClosingEventArgs e)
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

        public void set_CatalogosInfo(string IdCatalogo)
        {
            try
            {
                cmbCatalogo.EditValue = IdCatalogo;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public in_Catalogo_Info Get_CatalogosInfo()
        {
            try
            {
                InfoCatalogo = listCatalogo.FirstOrDefault(v => v.IdCatalogo == Convert.ToString(cmbCatalogo.EditValue));
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
            event_delegate_cmbCatalogo_EditValueChanged(sender, e);
        }
    }
}
