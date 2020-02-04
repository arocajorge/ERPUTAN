using Core.Erp.Business.General;
using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Core.Erp.Winform.General
{
    public partial class FrmGe_Contacto_Cons : Form
    {
        #region "Variables"
        private Cl_Enumeradores.eTipo_action Accion;
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        tb_contacto_Bus Bus_contacto = new tb_contacto_Bus();
        tb_contacto_Info info_contacto = new tb_contacto_Info();
        List<tb_contacto_Info> Lista = new List<tb_contacto_Info>();

        public delegate void delegate_FrmGe_Contacto_Cons_FormClosing(object sender, FormClosingEventArgs e, tb_contacto_Info InfoContacto_out);
        public event delegate_FrmGe_Contacto_Cons_FormClosing event_FrmGe_Contacto_Cons_FormClosing;     
        #endregion

        #region "Constructor"
        public FrmGe_Contacto_Cons()
        {
            InitializeComponent();
            event_FrmGe_Contacto_Cons_FormClosing += FrmGe_Contacto_Cons_event_FrmGe_Contacto_Cons_FormClosing;
        }

        void FrmGe_Contacto_Cons_event_FrmGe_Contacto_Cons_FormClosing(object sender, FormClosingEventArgs e, tb_contacto_Info InfoContacto_out)
        {
            
        }

        public void set_Accion(Cl_Enumeradores.eTipo_action iAccion)
        {
            try
            {
                Accion = iAccion;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
        
       
        #endregion

        #region "CargarGrid"
        public void llenagrid()
        {
            Bus_contacto = new tb_contacto_Bus();
            Lista = new List<tb_contacto_Info>();
            Lista = Bus_contacto.Get_List_Contacto(param.IdEmpresa);
            gridControlContactos.DataSource = Lista;
        }
        #endregion


        #region " LLamar formulario"
        private void llama_frm(Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {

                FrmGe_Contacto_Mant frm = new FrmGe_Contacto_Mant();
                frm.MdiParent = this.MdiParent;
                frm.event_FormGe_Contacto_Mant_FormClosing += frm_event_FormGe_Contacto_Mant_FormClosing;
                if (Accion != Cl_Enumeradores.eTipo_action.grabar)
                {
                    frm.set_Contacto(info_contacto);
                }
                frm.set_Accion(Accion);
                frm.Show();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error comunicarse con Sistemas " + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion      

        #region "Eventos"
        void frm_event_FormGe_Contacto_Mant_FormClosing(object sender, FormClosingEventArgs e, tb_contacto_Info InfoContacto_out)
        {
            llenagrid();
        }

        private void ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                llama_frm(Cl_Enumeradores.eTipo_action.grabar);
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                info_contacto = (tb_contacto_Info)this.gridViewContacto.GetFocusedRow();

                if (info_contacto == null)
                {
                    MessageBox.Show("Seleccione un registro", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    llama_frm(Cl_Enumeradores.eTipo_action.actualizar);
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error comunicarse con Sistemas " + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                info_contacto = (tb_contacto_Info)this.gridViewContacto.GetFocusedRow();

                if (info_contacto == null)
                {
                    MessageBox.Show("Seleccione un registro", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    llama_frm(Cl_Enumeradores.eTipo_action.consultar);
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error comunicarse con Sistemas " + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                info_contacto = (tb_contacto_Info)this.gridViewContacto.GetFocusedRow();

                if (info_contacto == null)
                {
                    MessageBox.Show("Seleccione un registro", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    llama_frm(Cl_Enumeradores.eTipo_action.Anular);
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error comunicarse con Sistemas " + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_Mantenimiento_x_usuario_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.gridControlContactos.ShowPrintPreview();
        }

        private void ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void gridViewContacto_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            try
            {
                var data = gridViewContacto.GetRow(e.RowHandle) as tb_contacto_Info;
                if (data == null)
                    return;
                if (data.Estado == "I")
                    e.Appearance.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void FormGe_Contacto_Cons_Load(object sender, EventArgs e)
        {
            try
            {
                llenagrid();
                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.consultar:
                        ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Transacciones = false;
                        ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Cancelaciones = false;
                        ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Impresion = false;
                        break;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error comunicarse con Sistemas " + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }        
       
        #endregion
       
        

        private void ucGe_Menu_Mantenimiento_x_usuario_event_btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                info_contacto = (tb_contacto_Info)this.gridViewContacto.GetFocusedRow();
                {

                    if (info_contacto == null)
                    {
                        MessageBox.Show("Seleccione un registro", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        this.Close();
                    }                   
                    
                }
            }
            catch (Exception ex)
            {
                  Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error " + ex.Message.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        public void LLamaControl(ref string mensaje)
        {
            try
            {
                
                tb_contacto_Bus bus_contacto = new tb_contacto_Bus();
                Lista = new List<tb_contacto_Info>();
                //Lista = bus_contacto.Get_Contanto_x_cedula(param.IdEmpresa, Convert.ToString(txtCedulaRuc.Text));
                this.gridControlContactos.DataSource = Lista;
                info_contacto = new tb_contacto_Info();
                //info_contacto = Lista.FirstOrDefault(q => q.IdEmpresa == param.IdEmpresa && q.Persona_Info.pe_cedulaRuc == Convert.ToString(txtCedulaRuc.Text)); 
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error " + ex.Message.ToString(), "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FrmGe_Contacto_Cons_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                event_FrmGe_Contacto_Cons_FormClosing(sender, e, info_contacto);
            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void gridViewContacto_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                info_contacto = (tb_contacto_Info )this.gridViewContacto.GetFocusedRow();
                this.Close();
            }
            catch (Exception ex)
            {
                 MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        

       

    }
}
