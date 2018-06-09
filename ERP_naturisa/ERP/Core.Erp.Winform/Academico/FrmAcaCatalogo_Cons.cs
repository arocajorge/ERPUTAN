using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Info.Academico;
using Core.Erp.Business.Academico;
using Core.Erp.Info.General;
using Core.Erp.Business.General;

namespace Core.Erp.Winform.Academico
{
    public partial class FrmAcaCatalogo_Cons : Form
    {

        Aca_Catalogo_Bus BusCatalogo = new Aca_Catalogo_Bus();
        List<Aca_Catalogo_Info> lista = new List<Aca_Catalogo_Info>();
        FrmAcaCatalogo_Mant frm = new FrmAcaCatalogo_Mant();
        Aca_Catalogo_Info infoSelecionado = new Aca_Catalogo_Info();
        BindingList<Aca_Catalogo_Info> CatalogoInfo = new BindingList<Aca_Catalogo_Info>();
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        public FrmAcaCatalogo_Cons()
        {
            InitializeComponent();
        }

        private void FrmAcaCatalogo_Cons_Load(object sender, EventArgs e)
        {
            try
            {
                CargarListaCatalogoTipo();

            }
            catch (Exception ex)
            {
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ":" + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        public void CargarGridCatalogo()
        {
            try
            {
                Aca_Catalogo_Bus neg = new Aca_Catalogo_Bus();
                CatalogoInfo = new BindingList<Aca_Catalogo_Info>(neg.Get_List_CatalogoXtipo(Convert.ToString(lstbox_TipoCatalogo.SelectedValue)));
                gridControlCatalogo.DataSource = CatalogoInfo;
                infoSelecionado.IdTipoCatalogo = lstbox_TipoCatalogo.SelectedValue.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ":" + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        public void CargarListaCatalogoTipo()
        {
            try
            {
                Aca_CatalogoTipo_Bus neg = new Aca_CatalogoTipo_Bus();
                List<Aca_CatalogoTipo_Info> lista = new List<Aca_CatalogoTipo_Info>();
                lista = neg.Get_List_CatalogoTipo();
                lstbox_TipoCatalogo.DataSource = lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ":" + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }



        private void ucGe_Menu_Mantenimiento_x_usuario1_Load(object sender, EventArgs e)
        {

        }

        private void ucGe_Menu_Mantenimiento_x_usuario1_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridControlCatalogo.ShowPrintPreview();
        }

        private void ucGe_Menu_Mantenimiento_x_usuario1_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Prepara_Formulario(Cl_Enumeradores.eTipo_action.grabar);
            }
            catch (Exception ex)
            {
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ":" + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void ucGe_Menu_Mantenimiento_x_usuario1_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                //llenar variables
                infoSelecionado = (Aca_Catalogo_Info)gridViewCatalogo.GetFocusedRow();
                //valido que se haya seleccionado una fila
                if (infoSelecionado == null)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_favor_seleccione_item_a_modi), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    Prepara_Formulario(Cl_Enumeradores.eTipo_action.actualizar);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ":" + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void ucGe_Menu_Mantenimiento_x_usuario1_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                //llenar variables
                infoSelecionado = (Aca_Catalogo_Info)gridViewCatalogo.GetFocusedRow();
                //valido que se haya seleccionado una fila
                if (infoSelecionado == null)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_favor_seleccione_item_a_anular), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                    if (infoSelecionado.Estado == "I")
                    {
                        MessageBox.Show("El catalogo "+ infoSelecionado.IdCatalogo + param.Get_Mensaje_sys(enum_Mensajes_sys.Ya_se_encuentra_anulado), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        Prepara_Formulario(Cl_Enumeradores.eTipo_action.Anular);
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ":" + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void ucGe_Menu_Mantenimiento_x_usuario1_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                //llenar variables
                infoSelecionado = (Aca_Catalogo_Info)gridViewCatalogo.GetFocusedRow();
                //valido que se haya seleccionado una fila
                if (infoSelecionado == null)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_favor_seleccione_item_a_consul), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    Prepara_Formulario(Cl_Enumeradores.eTipo_action.consultar);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ":" + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void ucGe_Menu_Mantenimiento_x_usuario1_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        void Prepara_Formulario(Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {


                frm = new FrmAcaCatalogo_Mant();
                frm.MdiParent = this.MdiParent;
                frm.event_FrmAcaCatalogo_Mant_FormClosing += frm_event_FrmAcaCatalogo_Mant_FormClosing;
                if (Accion != Cl_Enumeradores.eTipo_action.grabar)
                {
                    frm.Set_Info(infoSelecionado);
                }
                frm.Set_Accion(Accion);
                frm.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ":" + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void frm_event_FrmAcaCatalogo_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                CargarGridCatalogo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ":" + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void lstbox_TipoCatalogo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CargarGridCatalogo();
                infoSelecionado.IdTipoCatalogo = lstbox_TipoCatalogo.SelectedValue.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ":" + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void gridViewCatalogo_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            try
            {
                var data = gridViewCatalogo.GetRow(e.RowHandle) as Aca_Catalogo_Info;
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
    }
}
