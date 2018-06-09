using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Business.Roles;
using Core.Erp.Info.Roles;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Business.Roles_Fj;
using Core.Erp.Info.Roles_Fj;
namespace Core.Erp.Winform.Roles_Fj
{
    public partial class frm_Ro_parametro_Reporte : Form
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        BindingList<ro_parametros_reporte_Info> lista = new BindingList<ro_parametros_reporte_Info>();
        ro_parametros_reporte_Bus bus_parametro = new ro_parametros_reporte_Bus();
        List<ro_Nomina_Tipoliqui_Info> lista_nomina_tipo_liq = new List<ro_Nomina_Tipoliqui_Info>();
        List<ro_Nomina_Tipo_Info> lista_nomina_tipo = new List<ro_Nomina_Tipo_Info>();
        ro_Nomina_Tipo_Bus nomina_bus = new ro_Nomina_Tipo_Bus();
        ro_Nomina_Tipoliqui_Bus nominatipo_Bus = new ro_Nomina_Tipoliqui_Bus();
        List<ro_rubro_tipo_Info> lista_rubros = new List<ro_rubro_tipo_Info>();
        ro_rubro_tipo_Bus bus_rubro = new ro_rubro_tipo_Bus();

        List<ro_Catalogo_Info> lista_catalogo = new List<ro_Catalogo_Info>();
        ro_Catalogo_Bus bus_catalogo = new ro_Catalogo_Bus();
        List<ro_Catalogo_Info> lista_reporte = new List<ro_Catalogo_Info>();

        int IdNomina_tipo = 0;
        public frm_Ro_parametro_Reporte()
        {
            InitializeComponent();
        }

        private void frm_Ro_parametro_Reporte_Load(object sender, EventArgs e)
        {
            try
            {


                gridControl_parametros.DataSource = lista;


                cmb_catalogo.DisplayMember = "ca_descripcion";
                cmb_catalogo.ValueMember = "CodCatalogo";


                cmb_nomina.DisplayMember = "Descripcion";
                cmb_nomina.ValueMember = "IdNomina_Tipo";

                cmb_rubro.DisplayMember = "ru_descripcion";
                cmb_rubro.ValueMember = "IdRubro";



                cmb_nomina_tipo.DisplayMember = "DescripcionProcesoNomina";
                cmb_nomina_tipo.ValueMember = "IdNomina_TipoLiqui";



                lista_nomina_tipo = nomina_bus.Get_List_Nomina_Tipo(param.IdEmpresa);
                cmb_nomina.DataSource = lista_nomina_tipo;



                lista_rubros = bus_rubro.ConsultaGeneral(param.IdEmpresa);
                cmb_rubro.DataSource = lista_rubros;



                lista_catalogo = bus_catalogo.Get_List_Catalogo_x_Tipo(40);
                cmb_catalogo.DataSource = lista_catalogo;





               

                lista_reporte = bus_catalogo.Get_List_Catalogo_x_Tipo(41);
                cmb_reporte.Properties.DataSource = lista_reporte;


                lista = new BindingList<ro_parametros_reporte_Info>(bus_parametro.Get_list_parametro(param.IdEmpresa));
                gridControl_parametros.DataSource = lista;
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        private void cmb_nomina_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void cmb_nomina_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            try
            {

                IdNomina_tipo = Convert.ToInt32(e.NewValue);
                Get_nomina_tipo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }


        public void Get_nomina_tipo()
        {
            try
            {
                // cmb_nomina_tipo.DataSource = lista_nomina_tipo_liq.Where(v=>v.IdNomina_Tipo==IdNomina_tipo).ToList();



            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        private void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            Grabar();
        }

        private void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            if (Grabar())
                this.Close();
        }


        public bool Grabar()
        {
            try
            {
                foreach (var item in lista)
                {
                    item.IdEmpresa = param.IdEmpresa;
                    item.Id_catalogo_repor = cmb_reporte.EditValue.ToString();
                }


                if (bus_parametro.Guardar_DB(param.IdEmpresa, lista.ToList()))
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_guardo_correctamente), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {

                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.No_se_guardaron_los_datos), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

            }
            catch (Exception ex)
            {


                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
                return false;
            }
        }

        private void gridView_parametros_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                ro_parametros_reporte_Info inf = new ro_parametros_reporte_Info();
                inf = (ro_parametros_reporte_Info)gridView_parametros.GetFocusedRow();

                cmb_nomina_tipo.DataSource = lista_nomina_tipo_liq.Where(v => v.IdNomina_Tipo == inf.IdNomina_Tipo).ToList();
            }
            catch (Exception ex)
            {


                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        private void gridView_parametros_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (e.Column.Name == "Col_eliminar")
            {
                try
                {
                    DialogResult dialogResult = MessageBox.Show("¿Esta seguro de querer eliminar el registro?", param.Nombre_sistema, MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        gridView_parametros.DeleteSelectedRows();
                    }

                }
                catch (Exception ex)
                {

                    Log_Error_bus.Log_Error(ex.ToString());
                    MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void cmb_reporte_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                lista =new BindingList<ro_parametros_reporte_Info>( bus_parametro.Get_list_parametro(param.IdEmpresa, cmb_reporte.EditValue.ToString()));
                gridControl_parametros.DataSource = lista;

            }
            catch (Exception ex)
            {
                
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void gridView_parametros_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                ro_parametros_reporte_Info inf = new ro_parametros_reporte_Info();
                inf = (ro_parametros_reporte_Info)gridView_parametros.GetFocusedRow();
                
                if(inf!=null)
                {
                lista_nomina_tipo_liq = nominatipo_Bus.Get_List_Nomina_Tipoliqui(param.IdEmpresa, inf.IdNomina_Tipo);
                cmb_nomina_tipo.DataSource = lista_nomina_tipo_liq;
                }
            }
            catch (Exception ex)
            {
                
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
