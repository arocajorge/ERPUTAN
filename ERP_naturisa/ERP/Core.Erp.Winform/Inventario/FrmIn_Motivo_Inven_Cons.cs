using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.Inventario;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using Core.Erp.Winform.General;






namespace Core.Erp.Winform.Inventario
{
    public partial class FrmIn_Motivo_Inven_Cons : Form
    { 
        #region Declaracion Variable
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        //FrmIn_Motivo_Inven_Mant frm;
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        in_Motivo_Inven_Info Info = new in_Motivo_Inven_Info();   
        //Cl_Enumeradores.eTipo_action Accion;


        #endregion

        public FrmIn_Motivo_Inven_Cons()
        {
            InitializeComponent();

            ucGe_Menu.event_btnBuscar_Click += ucGe_Menu_event_btnBuscar_Click;
            ucGe_Menu.event_btnImprimir_ItemClick += ucGe_Menu_event_btnImprimir_ItemClick;
            ucGe_Menu.event_btnNuevo_ItemClick += ucGe_Menu_event_btnNuevo_ItemClick;
            ucGe_Menu.event_btnModificar_ItemClick += ucGe_Menu_event_btnModificar_ItemClick;
            ucGe_Menu.event_btnAnular_ItemClick += ucGe_Menu_event_btnAnular_ItemClick;
            ucGe_Menu.event_btnSalir_ItemClick += ucGe_Menu_event_btnSalir_ItemClick;
            ucGe_Menu.event_btnconsultar_ItemClick += ucGe_Menu_event_btnconsultar_ItemClick;
        }

        void ucGe_Menu_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            preparar_formulario(Cl_Enumeradores.eTipo_action.consultar);
        }

        void ucGe_Menu_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        void ucGe_Menu_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            preparar_formulario(Cl_Enumeradores.eTipo_action.Anular);
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


            }
        }

        void ucGe_Menu_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.gridControlMovi_inve_tipo.ShowPrintPreview();
        }

        void ucGe_Menu_event_btnBuscar_Click(object sender, EventArgs e)
        {
            cargarData();

        }

        void frm_event_FrmIn_Motivo_Inven_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            cargarData();
        }

        private void cargarData()
        {
            try
            {
                in_Motivo_Inven_Bus BusMotivo = new in_Motivo_Inven_Bus();
                List<in_Motivo_Inven_Info> lista = new List<in_Motivo_Inven_Info>();
                lista = BusMotivo.Get_List_Motivo_Inven(param.IdEmpresa);
                gridControlMovi_inve_tipo.DataSource = lista;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void preparar_formulario(Cl_Enumeradores.eTipo_action _Accion)
        {
            FrmIn_Motivo_Inven_Mant frm = new FrmIn_Motivo_Inven_Mant();

            Info = (in_Motivo_Inven_Info)gridViewTipoInve.GetFocusedRow();

            if (_Accion == Cl_Enumeradores.eTipo_action.Anular)
            {
                // Info = (com_estado_cierre_Info)gridViewEstado.GetFocusedRow();
                if (Info != null)
                {
                    if (Info.estado == "I")
                    { MessageBox.Show("El registro ya se encuentra Anulado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; }
                    else
                    {
                        frm = new FrmIn_Motivo_Inven_Mant();
                        frm.set_Accion(Cl_Enumeradores.eTipo_action.Anular);

                        frm.Text = frm.Text + "***ANULAR REGISTRO***";
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione un Registro a Anular", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
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
            frm.event_FrmIn_Motivo_Inven_Mant_FormClosing += frm_event_FrmIn_Motivo_Inven_Mant_FormClosing;
            frm.Show();

        }
        private void ucGe_Menu_Load(object sender, EventArgs e)
        {
            cargarData();
        }

        private void FrmIn_Motivo_Inven_Cons_Load(object sender, EventArgs e)
        {

        }

        private void gridControlMovi_inve_tipo_Click(object sender, EventArgs e)
        {

        }

        private void gridViewTipoInve_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridViewTipoInve.GetRow(e.RowHandle) as in_Motivo_Inven_Info;
                if (data == null)
                    return;
                if (data.estado=="I")
                  e.Appearance.ForeColor = Color.Red;  
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
