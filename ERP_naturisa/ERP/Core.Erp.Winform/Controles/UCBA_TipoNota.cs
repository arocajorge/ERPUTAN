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
using Core.Erp.Business.Bancos;
using Core.Erp.Winform.Bancos;
using Core.Erp.Info.Bancos;
using Core.Erp.Info.General;

namespace Core.Erp.Winform.Controles
{
    public partial class UCBA_TipoNota : UserControl
    {

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        ba_tipo_nota_Bus busTipNota = new ba_tipo_nota_Bus();


        List<ba_tipo_nota_Info> list_TipoNota = new List<ba_tipo_nota_Info>();

        ba_tipo_nota_Info InfoTipoNota = new ba_tipo_nota_Info();

        FrmBA_Tipo_Nota_Mantenimiento frm;

        public Cl_Enumeradores.eTipoNotaBanco tipoNota { get; set; }


        public delegate void delegate_cmb_TipoNota_EditValueChanged(object sender, EventArgs e);
        public event delegate_cmb_TipoNota_EditValueChanged event_cmb_TipoNota_EditValueChanged;

        public delegate void delegate_cmb_TipoNota_Validating(object sender, EventArgs e);
        public event delegate_cmb_TipoNota_Validating event_cmb_TipoNota_Validating;

        public delegate void delegate_cmb_TipoNota_Validated(object sender, EventArgs e);
        public event delegate_cmb_TipoNota_Validated event_cmb_TipoNota_Validated;


        public UCBA_TipoNota()
        {
            InitializeComponent();
            event_cmb_TipoNota_EditValueChanged += UCBA_TipoNota_event_cmb_TipoNota_EditValueChanged;
            event_cmb_TipoNota_Validating += UCBA_TipoNota_event_cmb_TipoNota_Validating;
            event_cmb_TipoNota_Validated += UCBA_TipoNota_event_cmb_TipoNota_Validated;
        }

        void UCBA_TipoNota_event_cmb_TipoNota_Validated(object sender, EventArgs e)
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

        void UCBA_TipoNota_event_cmb_TipoNota_Validating(object sender, EventArgs e)
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

        void UCBA_TipoNota_event_cmb_TipoNota_EditValueChanged(object sender, EventArgs e)
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

        void cargar_TipoNota()
        {
            try
            {

                list_TipoNota = busTipNota.Get_List_tipo_nota(param.IdEmpresa, tipoNota.ToString());

                cmb_TipoNota.Properties.DataSource = list_TipoNota;
                cmb_TipoNota.Properties.DisplayMember = "Descripcion";
                cmb_TipoNota.Properties.ValueMember = "IdTipoNota";
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void UCBA_TipoNota_Load(object sender, EventArgs e)
        {
            try
            {
                cargar_TipoNota();
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
                             
                frm = new FrmBA_Tipo_Nota_Mantenimiento();
                frm.Event_FrmBA_Catalogo_Mantenimiento_FormClosing+=frm_Event_FrmBA_Catalogo_Mantenimiento_FormClosing;

                frm.set_combo_tipo_nota(tipoNota);

                if (!(Accion == Cl_Enumeradores.eTipo_action.grabar))
                {
                    frm._Info(InfoTipoNota);
                    frm._Accion=Accion;

                }
                else
                    frm._Accion=Accion;

                frm.Show();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void frm_Event_FrmBA_Catalogo_Mantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                cargar_TipoNota();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
               
            }
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
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

        private void MenuAcciones_Opening(object sender, CancelEventArgs e)
        {
           
        }


        public void Perfil_Lectura()
        {
            try
            {
                cmb_Acciones.Enabled = false;
                cmb_TipoNota.Properties.ReadOnly = true;

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void Inicializar_cmbPlanCta()
        {
            try
            {
                cmb_TipoNota.EditValue = null;

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void set_primer_TipoNota()
        {
            try
            {
                if (list_TipoNota.Count != 0)
                    cmb_TipoNota.EditValue = list_TipoNota.FirstOrDefault().IdTipoNota;
                else
                    cmb_TipoNota.EditValue = null;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void set_TipoNotaInfo(int IdTipoNota)
        {
            try
            {
                if (cmb_TipoNota.EditValue ==null)
                {
                    cmb_TipoNota.EditValue = IdTipoNota;
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public ba_tipo_nota_Info get_TipoNotaInfo()
        {
            try
            {
                if (cmb_TipoNota.EditValue!=null)
               {
                   if (Convert.ToInt32(cmb_TipoNota.EditValue) != 0)
                   {
                       if (list_TipoNota.Count() > 0)
                       {
                           InfoTipoNota = list_TipoNota.First(v => v.IdTipoNota == Convert.ToInt32(cmb_TipoNota.EditValue));
                       }
                   }
                
                }

                return InfoTipoNota;
               
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new ba_tipo_nota_Info();
            }

        }

        public void cmb_TipoNota_Enable(Boolean valor)
        {
            try
            {
                cmb_TipoNota.Properties.ReadOnly = valor;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());

            }
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                get_TipoNotaInfo();
                llamar_Formulario(Cl_Enumeradores.eTipo_action.actualizar);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void btn_Consultar_Click(object sender, EventArgs e)
        {
            try
            {
                get_TipoNotaInfo();
                llamar_Formulario(Cl_Enumeradores.eTipo_action.consultar);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void cmb_TipoNota_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                event_cmb_TipoNota_EditValueChanged(sender,e);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
               
            }
        }

        private void cmb_TipoNota_Validated(object sender, EventArgs e)
        {
            try
            {
                event_cmb_TipoNota_Validated(sender,e);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());

            }
        }

        private void cmb_TipoNota_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                event_cmb_TipoNota_Validating(sender,e);
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
    }
}
