using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.General;
using Core.Erp.Info.General;

//26112013 Derek
namespace Core.Erp.Winform.General
{
    public partial class FrmGe_CalendarioFeriado_Cons : Form
    {
        #region Declaración de Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        BindingList<tb_Calendario_Info> DataSource = new BindingList<tb_Calendario_Info>();
        BindingList<tb_Calendario_Info> DataSource1 = new BindingList<tb_Calendario_Info>();
        BindingList<tb_Calendario_Info> DataSource2 = new BindingList<tb_Calendario_Info>();
        BindingList<tb_Calendario_Info> DataSource3 = new BindingList<tb_Calendario_Info>();
        tb_Calendario_Info Calendario_Info = new tb_Calendario_Info();
        tb_Calendario_Bus tb_Calendario_Bus = new tb_Calendario_Bus();
        FrmGe_CalendarioFeriado_Mant frm;
        #endregion
       
        public FrmGe_CalendarioFeriado_Cons()
        {
            try
            {
                InitializeComponent();
                ucGe_Menu_Mantenimiento_x_usuario.event_btnNuevo_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnModificar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnconsultar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnAnular_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnSalir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
                    
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (Calendario_Info.IdCalendario == 0)
                {
                    MessageBox.Show("Seleccione una fila.", "sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else
                {
                    if (tb_Calendario_Bus.Get_ExisteFeriad(Calendario_Info.IdCalendario))
                    {
                        MessageBox.Show("La fecha no es Feriado,\n Por favor Selecciones otra fecha.");
                        return;
                    }
                    else
                    {
                        if (MessageBox.Show("¿Está seguro que desea anular dicha Fecha?.", "Anulación de Rubro por Empleado", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            if (tb_Calendario_Bus.AnularFeriado(Calendario_Info))
                            {
                                MessageBox.Show("Operación Exitosa");
                                load();
                            }
                            else
                                MessageBox.Show("No se Anulado.", "Operación Fallida");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (Calendario_Info.IdCalendario == 0)
                {
                    MessageBox.Show("Seleccione una fila.", "sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    llama_frm(Cl_Enumeradores.eTipo_action.consultar);
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (Calendario_Info.IdCalendario == 0)
                {
                    MessageBox.Show("Selecciones una fila.", "sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    llama_frm(Cl_Enumeradores.eTipo_action.actualizar);
                    load();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }      
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                llama_frm(Cl_Enumeradores.eTipo_action.grabar);
            }
            catch (Exception ex)
            {               
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
        }

        private void llama_frm(Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {
                frm = new FrmGe_CalendarioFeriado_Mant();
                frm.event_FrmGe_CalendarioFeriado_Mant_FormClosing += new FrmGe_CalendarioFeriado_Mant.delegate_FrmGe_CalendarioFeriado_Mant_FormClosing(frm_event_FrmGe_CalendarioFeriado_Mant_FormClosing);
                frm.MdiParent = this.MdiParent;

                if (Accion != Cl_Enumeradores.eTipo_action.grabar)
                {
                    frm.SETINFO_ = Calendario_Info;
                }
                frm.set_Accion(Accion);
                frm.Show();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
        }

        private void frm_event_FrmGe_CalendarioFeriado_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                load();
            }
            catch (Exception ex)
            {
             Log_Error_bus.Log_Error(ex.ToString());
             MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
        
        }

        void load() {

            try
            {
                //se modifico el Get_List_Calendario_Feriado por el Get_List_Calendario
                DataSource = new BindingList<tb_Calendario_Info>(tb_Calendario_Bus.Get_List_Calendario());
                gridControlCalendario.DataSource = DataSource;
                //se modifico el Get_List_Calendario_Feriado por el Get_List_Calendario
                DataSource1 = new BindingList<tb_Calendario_Info>(tb_Calendario_Bus.Get_List_Calendario_Feriado());
                gridControlFeriado.DataSource = DataSource1;

                loadMAXMIN();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void loadMAXMIN() {
            try
            {
                int a = tb_Calendario_Bus.ConsultaMaxMin(1);
                 int b = tb_Calendario_Bus.ConsultaMaxMin(2);

                cbxCalendario.Properties.Items.Add("Todos");
            for (int i = b; i <= a; i++)
            {
                cbxCalendario.Properties.Items.Add(i);
            }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
        }

        private void FrmGe_CalendarioFeriado_Cons_Load(object sender, EventArgs e)
        {
            try
            {
                load();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
          
        }

        private void FrmGe_CalendarioFeriado_Cons_FormClosing(object sender, FormClosingEventArgs e)
        {           
        }

        private void gridViewCalendario_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
               Calendario_Info = new tb_Calendario_Info();
                Calendario_Info = gridViewCalendario.GetFocusedRow() as tb_Calendario_Info;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
        
        }

        private void cbxCalendario_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
            string a = cbxCalendario.SelectedItem.ToString();

            if (a != "Todos") {
                DataSource1 = new BindingList<tb_Calendario_Info>(tb_Calendario_Bus.Get_List_Calendario_Feriado_x_ani(Convert.ToInt32(a)));
                gridControlFeriado.DataSource = DataSource1;
            }
            else
            {
                DataSource1 = new BindingList<tb_Calendario_Info>(tb_Calendario_Bus.Get_List_Calendario_Feriado());
                gridControlFeriado.DataSource = DataSource1;
            }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                guardarFeriadoDescripcion();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
          
        }

        void guardarFeriadoDescripcion() 
        {
            try
            {
                List<tb_Calendario_Info> list = new List<tb_Calendario_Info>(DataSource1);

            if (tb_Calendario_Bus.GrabarFeriadoDescripcion(list) == false) {
                MessageBox.Show("No se Grabó Exitosamente.", "No se Almacenó");
            }
            else
            {
                MessageBox.Show("Se Grabó Exitosamente.", "Almacenado");
            } 
            }
            catch (Exception ex)
            {
                 Log_Error_bus.Log_Error(ex.ToString());
                 MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }               
        }

        private void gridViewFeriado_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
            if (e.KeyCode == Keys.Delete)
            {
                //if (MessageBox.Show("¿Está seguro que desea Eliminar este registro ?", "Elimina", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                //{
                    gridViewFeriado.DeleteSelectedRows();
                //}
            }
            }
           catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
        }

        private void gridViewFeriado_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                Calendario_Info = new tb_Calendario_Info();
                Calendario_Info = (tb_Calendario_Info)gridViewFeriado.GetFocusedRow();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
            
        }

        private void gridViewFeriado_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
           
        }

        private void gridControlCalendario_Click(object sender, EventArgs e)
        {

        }       
    }
}
