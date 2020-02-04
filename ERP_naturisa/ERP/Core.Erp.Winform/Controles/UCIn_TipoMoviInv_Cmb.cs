using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Core.Erp.Business.Inventario;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.General;
using Core.Erp.Winform.Inventario;
using Core.Erp.Info.General;


namespace Core.Erp.Winform.Controles
{
    public partial class UCIn_TipoMoviInv_Cmb : DevExpress.XtraEditors.XtraUserControl
    {

        public Boolean Visible_buton_Acciones 
        {
            get { return cmb_Acciones.Visible; }
            set { cmb_Acciones.Visible = value; }
        }

        #region Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        List<in_movi_inven_tipo_Info> lstMoviTipo = new List<in_movi_inven_tipo_Info>();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        FrmIn_Tipo_Movi_Inven_Mantenimiento frm;
        BindingList<in_movi_inven_tipo_Info> MoviTipoInfo;
        in_movi_inven_tipo_Bus MoviTipoBus = new in_movi_inven_tipo_Bus();        
        in_movi_inven_tipo_Info InfoTipoMovi = new in_movi_inven_tipo_Info();
        public delegate void delegate_cmbCatalogo_EditValueChanged(object sender, EventArgs e);
        public event delegate_cmbCatalogo_EditValueChanged event_cmbCatalogo_EditValueChanged;


        int IdSucursal = 0;
        int IdBodega = 0;
        string TipoMovi = "";
        string Interno = "";
        #endregion

        public UCIn_TipoMoviInv_Cmb()
        {
            InitializeComponent();
            event_cmbCatalogo_EditValueChanged += UCIn_TipoMoviInv_Cmb_event_cmbCatalogo_EditValueChanged;        
        }

        void UCIn_TipoMoviInv_Cmb_event_cmbCatalogo_EditValueChanged(object sender, EventArgs e)
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

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                get_TipoMoviInvInfo();
                llamar_Formulario(Cl_Enumeradores.eTipo_action.consultar);
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
                get_TipoMoviInvInfo();
                llamar_Formulario(Cl_Enumeradores.eTipo_action.actualizar);
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
                llamar_Formulario(Cl_Enumeradores.eTipo_action.grabar);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void cargar_TipoMotivo(int Id_Sucursal, int Id_Bodega, string Tipo_Movi, string Interno_ )
        {
            try
            {
                IdSucursal = Id_Sucursal;
                IdBodega = Id_Bodega;
                TipoMovi = Tipo_Movi;
                Interno = Interno_;
                lstMoviTipo = new List<in_movi_inven_tipo_Info>();
                if (IdSucursal == 0 && IdBodega == 0)
                    lstMoviTipo = MoviTipoBus.Get_list_movi_inven_tipo(param.IdEmpresa, Tipo_Movi, Interno_, ""); 
                else
                    lstMoviTipo = MoviTipoBus.Get_list_movi_inven_tipo_x_bodega(param.IdEmpresa, Id_Sucursal, Id_Bodega, Tipo_Movi, Interno_);
                if (lstMoviTipo.Count() != 0)
                {
                    cmbCatalogo.Properties.DataSource = lstMoviTipo;
                    cmbCatalogo.EditValue = lstMoviTipo.First().IdMovi_inven_tipo;
                }

                if (lstMoviTipo.Count() == 0)
                {
                    cmbCatalogo.Properties.DataSource = null;
                    //cmbCatalogo.EditValue = lstMoviTipo.First().IdMovi_inven_tipo;
                    MessageBox.Show("No Hay Asignados Tipo de Movimiento de Inventario para esta Sucursal y Bodega... Consulte con sistemas .", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void llamar_Formulario(Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {
                MoviTipoInfo = new BindingList<in_movi_inven_tipo_Info>(MoviTipoBus.Get_list_movi_inven_tipo_x_bodega(param.IdEmpresa, IdSucursal, IdBodega, TipoMovi, Interno));

                frm = new FrmIn_Tipo_Movi_Inven_Mantenimiento();
                frm.Event_FrmIn_Tipo_Movi_Inven_Mantenimiento_FormClosing += frm_Event_FrmIn_Tipo_Movi_Inven_Mantenimiento_FormClosing;

                if (Accion != Cl_Enumeradores.eTipo_action.grabar)
                {
                    if (InfoTipoMovi != null)
                    {
                        frm.set_Info(InfoTipoMovi);
                        frm.set_Accion(Accion);
                        frm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Seleccione un tipo de movimiento.", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    frm.set_Accion(Accion);
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

        void frm_Event_FrmIn_Tipo_Movi_Inven_Mantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                cargar_TipoMotivo(IdSucursal, IdBodega, TipoMovi, Interno);
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

        public void set_TipoMoviInvInfo(int IdTipoMoviInve)
        {
            try
            {
                if (IdTipoMoviInve != 0)
                    cmbCatalogo.EditValue = IdTipoMoviInve;
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

        public in_movi_inven_tipo_Info get_TipoMoviInvInfo()
        {
            try
            {
                InfoTipoMovi = lstMoviTipo.Find(v => v.IdMovi_inven_tipo == Convert.ToInt32(cmbCatalogo.EditValue));
                return InfoTipoMovi;

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

    }
}
