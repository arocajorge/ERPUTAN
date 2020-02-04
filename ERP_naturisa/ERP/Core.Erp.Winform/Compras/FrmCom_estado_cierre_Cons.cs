using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.Compras;
using Core.Erp.Info.Compras;
using Core.Erp.Business.General;
using Core.Erp.Info.General;

namespace Core.Erp.Winform.Compras
{
    public partial class FrmCom_estado_cierre_Cons : Form
    {
        #region Declaracion Variable

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        com_estado_cierre_Info Info = new com_estado_cierre_Info();
        FrmCom_estado_cierre_Cons frm;
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        Cl_Enumeradores.eTipo_action Accion;

        #endregion

        public FrmCom_estado_cierre_Cons()
        {
            InitializeComponent();
            ucGe_Menu.event_btnBuscar_Click += ucGe_Menu_event_btnBuscar_Click;
            ucGe_Menu.event_btnSalir_ItemClick += ucGe_Menu_event_btnSalir_ItemClick;
            ucGe_Menu.event_btnNuevo_ItemClick += ucGe_Menu_event_btnNuevo_ItemClick;
            ucGe_Menu.event_btnModificar_ItemClick += ucGe_Menu_event_btnModificar_ItemClick;
            ucGe_Menu.event_btnconsultar_ItemClick += ucGe_Menu_event_btnconsultar_ItemClick;
            ucGe_Menu.event_btnAnular_ItemClick += ucGe_Menu_event_btnAnular_ItemClick;
            ucGe_Menu.event_btnSalir_ItemClick+=ucGe_Menu_event_btnSalir_ItemClick;
            ucGe_Menu.event_btnImprimir_ItemClick += ucGe_Menu_event_btnImprimir_ItemClick;
        }
       
        void ucGe_Menu_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.gridControlEstado.ShowPrintPreview();
        }

        void ucGe_Menu_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                preparar_formulario(Cl_Enumeradores.eTipo_action.Anular);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void frm_event_FrmCom_estado_cierre_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {

                 cargarData(); 
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }          
        }

        void ucGe_Menu_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            preparar_formulario(Cl_Enumeradores.eTipo_action.consultar);
        }

        void ucGe_Menu_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            preparar_formulario(Cl_Enumeradores.eTipo_action.actualizar);
        }

        void ucGe_Menu_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                preparar_formulario(Cl_Enumeradores.eTipo_action.grabar);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_event_btnBuscar_Click(object sender, EventArgs e)
        {          
            cargarData();
        }

        private void FrmCom_estado_cierre_Cons_Load(object sender, EventArgs e)
        {
            try
            {
                cargarData();
            }
            catch (Exception  ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cargarData()
        {
            try
            {
                com_estado_cierre_Bus BusMotivo = new com_estado_cierre_Bus();
                List<com_estado_cierre_Info> lista = new List<com_estado_cierre_Info>();
                lista = BusMotivo.Get_List_estado_cierre();
                gridControlEstado.DataSource = lista;
                              
            }
            catch (Exception ex)
            {

               Log_Error_bus.Log_Error(ex.ToString());
               MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void preparar_formulario(Cl_Enumeradores.eTipo_action _Accion)
        {
            try
            {

                FrmCom_estado_cierre_Mant frm = new FrmCom_estado_cierre_Mant();

                Info = (com_estado_cierre_Info)gridViewEstado.GetFocusedRow();


                if (_Accion == Cl_Enumeradores.eTipo_action.actualizar)
                {
                    if (Info == null)
                    {
                        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_un_registro), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
                    }
                }

                if (_Accion == Cl_Enumeradores.eTipo_action.Anular)
                {
                    if (Info != null)
                    {
                        if (Info.estado == "I")
                        { MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.El_registro_se_encuentra_anulado), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; }
                        else
                        {
                            frm = new FrmCom_estado_cierre_Mant();
                            frm.set_Accion(Cl_Enumeradores.eTipo_action.Anular);

                            frm.Text = frm.Text + "***ANULAR REGISTRO***";
                        }
                    }
                    else
                    {
                        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_un_registro) +" a Anular", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
                    }
                }


                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        frm.set_Info(Info);
                        break;
                    case Cl_Enumeradores.eTipo_action.grabar:
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        frm.set_Info(Info);
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        frm.set_Info(Info);
                        break;
                }

                frm.set_Accion(_Accion);
                frm.MdiParent = this.MdiParent;
                frm.event_FrmCom_estado_cierre_Mant_FormClosing += frm_event_FrmCom_estado_cierre_Mant_FormClosing;
                frm.Show();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }

            

        }

        private void gridViewEstado_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {

            try
            {
                var data = gridViewEstado.GetRow(e.RowHandle) as com_estado_cierre_Info;
                if (data == null)
                    return;
                if (data.estado == "I")
                    e.Appearance.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ucGe_Menu_Load(object sender, EventArgs e)
        {

        }

        private void ucGe_BarraEstado_Load(object sender, EventArgs e)
        {

        }

        
    }
}
