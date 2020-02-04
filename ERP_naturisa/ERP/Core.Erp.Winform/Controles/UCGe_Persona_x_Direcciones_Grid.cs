using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using Core.Erp.Winform.General;


namespace Core.Erp.Winform.Controles
{
    public partial class UCGe_Persona_x_Direcciones_Grid : UserControl
    {

        BindingList<tb_persona_direccion_Info> List_direcciones_x_persona = new BindingList<tb_persona_direccion_Info>();
        List<tb_persona_direccion_tipo_Info> list_dir_tipo = new List<tb_persona_direccion_tipo_Info>();
        tb_persona_direccion_tipo_Bus Bus_dir_tipo = new tb_persona_direccion_tipo_Bus();
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();        
        
        public void Set_direcciones_x_persona(List<tb_persona_direccion_Info> lista)
        {
            try
            {
                List_direcciones_x_persona = new BindingList<tb_persona_direccion_Info>(lista);
                gridControl_Direcciones_x_Persona.DataSource = List_direcciones_x_persona;

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void Set_direcciones_x_persona(decimal IdPersona)
        {
            try
            {
                tb_persona_direccion_Bus BusPers = new tb_persona_direccion_Bus();
                List<tb_persona_direccion_Info> lista = new List<tb_persona_direccion_Info>();
                lista = BusPers.Get_List_persona_direccion(IdPersona);
                List_direcciones_x_persona = new BindingList<tb_persona_direccion_Info>(lista);
                gridControl_Direcciones_x_Persona.DataSource = List_direcciones_x_persona;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public List<tb_persona_direccion_Info> Get_list_direcciones_x_persona()
        {
            try
            {
                return new List<tb_persona_direccion_Info>(List_direcciones_x_persona);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new List<tb_persona_direccion_Info>();
            }
        }

        public UCGe_Persona_x_Direcciones_Grid()
        {
            InitializeComponent();
            gridControl_Direcciones_x_Persona.DataSource = List_direcciones_x_persona;
        }

        private void gridControl_Direcciones_x_Persona_Click(object sender, EventArgs e)
        {

        }

        private void Cargar_combo()
        {
            try
            {
                list_dir_tipo= Bus_dir_tipo.Get_List_persona_direccion();
                list_dir_tipo.Add(new tb_persona_direccion_tipo_Info(-9999, "**NUEVO**"));

                cmb_tipo_direccion.DataSource = list_dir_tipo.OrderBy(x => x.IdTipoDireccion).ToList();


            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void UCGe_Persona_x_Direcciones_Grid_Load(object sender, EventArgs e)
        {
            try
            {
                Cargar_combo();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            
            }

        }

        private void gridView_Direcciones_x_Persona_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {

                if (e.Column.Name == gridColumnColTipo.Name)
                {
                    int IdTipoDireccion = Convert.ToInt32(e.Value);
                    if (IdTipoDireccion == -9999)
                    {
                        FrmGe_Persona_Direccion_Tipo_Mant frm = new FrmGe_Persona_Direccion_Tipo_Mant();
                        frm.Set_Accion(Cl_Enumeradores.eTipo_action.grabar);
                        frm.event_FrmGe_Persona_Direccion_Tipo_Mant_FormClosing += frm_event_FrmGe_Persona_Direccion_Tipo_Mant_FormClosing;
                        frm.ShowDialog();
                        gridView_Direcciones_x_Persona.SetFocusedRowCellValue(e.Column, 1);
                        return;
                    }


                    

            
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void frm_event_FrmGe_Persona_Direccion_Tipo_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Cargar_combo();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridView_Direcciones_x_Persona_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {

                tb_persona_direccion_Info row = new tb_persona_direccion_Info();
                row = (tb_persona_direccion_Info)gridView_Direcciones_x_Persona.GetFocusedRow();

                int cont = 0;
                if (row != null)
                {
                    cont = List_direcciones_x_persona.Where(q => q.IdTipoDireccion == row.IdTipoDireccion).Count();
                    if (cont > 1)
                    {
                        gridView_Direcciones_x_Persona.DeleteSelectedRows();
                    }
                }


            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Limpiar_persona_x_direccion()
        {
            try
            {
                List<tb_persona_direccion_Info> Lista = new List<tb_persona_direccion_Info>();
                gridControl_Direcciones_x_Persona.DataSource = Lista;
            }
            catch (Exception ex)
            {
                 Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
