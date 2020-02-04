using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.Inventario;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.General;
using Core.Erp.Info.General;



namespace Core.Erp.Winform.Inventario
{
    public partial class FrmIn_Motivo_Inven_borrar_Cons : Form
    {
        in_Motivo_Inven_Borrar_Info Info = new in_Motivo_Inven_Borrar_Info();
        FrmIn_Motivo_Inven_borrar_Mant frm;
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        Cl_Enumeradores.eTipo_action Accion;


        public FrmIn_Motivo_Inven_borrar_Cons()
        {
            InitializeComponent();

            ucGe_Menu.event_btnBuscar_Click += ucGe_Menu_event_btnBuscar_Click;
            ucGe_Menu.event_btnImprimir_ItemClick += ucGe_Menu_event_btnImprimir_ItemClick;
            ucGe_Menu.event_btnNuevo_ItemClick += ucGe_Menu_event_btnNuevo_ItemClick;
            ucGe_Menu.event_btnModificar_ItemClick += ucGe_Menu_event_btnModificar_ItemClick;
            ucGe_Menu.event_btnconsultar_ItemClick += ucGe_Menu_event_btnconsultar_ItemClick;
            ucGe_Menu.event_btnAnular_ItemClick += ucGe_Menu_event_btnAnular_ItemClick;
            ucGe_Menu.event_btnSalir_ItemClick += ucGe_Menu_event_btnSalir_ItemClick;
        }

        void ucGe_Menu_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        void ucGe_Menu_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            preparar_formulario(Cl_Enumeradores.eTipo_action.borrar);
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
                
                
            }
        }


        private void preparar_formulario(Cl_Enumeradores.eTipo_action _Accion)
        {



            frm = new FrmIn_Motivo_Inven_borrar_Mant();

            if (_Accion != Cl_Enumeradores.eTipo_action.grabar)
            { 

                        Info = (in_Motivo_Inven_Borrar_Info)gridViewTipoInve.GetFocusedRow();

                        if (Info != null)
                        {
                            if (Info.estado == "I")
                            { MessageBox.Show("No se pueden modificar registros inactivos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; }
             
                        }
                        else
                        {
                            MessageBox.Show("debe seleccionar un registro ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
             
                        }

            }

            if (_Accion == Cl_Enumeradores.eTipo_action.borrar)
            {
                Info = (in_Motivo_Inven_Borrar_Info)gridViewTipoInve.GetFocusedRow();
                if (Info != null)
                {
                    if (Info.estado == "I")
                    { MessageBox.Show("El registro ya se encuentra Anulado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; }
                    else
                    {


                        frm = new FrmIn_Motivo_Inven_borrar_Mant();
                        frm.set_Acccion(Cl_Enumeradores.eTipo_action.borrar);
                
                        frm.Text = frm.Text + "***ANULAR REGISTRO***";
                        frm.Show();
                        frm.MdiParent = this.MdiParent;
                        

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
                case Cl_Enumeradores.eTipo_action.borrar:
                    frm.set_Info(Info);
                    break;
            }


            frm.set_Acccion(_Accion);
            frm.MdiParent = this.MdiParent;
            frm.Show();

        }


        void ucGe_Menu_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.gridControlMovi_inve_tipo.ShowPrintPreview();
        }

        void ucGe_Menu_event_btnBuscar_Click(object sender, EventArgs e)
        {
            in_Motivo_Inven_Borrar_Bus BusMotivo = new in_Motivo_Inven_Borrar_Bus();
            List<in_Motivo_Inven_Borrar_Info> lista = new List<in_Motivo_Inven_Borrar_Info>();

            //lista = BusMotivo.consultar(param.IdEmpresa); 
            int V1, V2;
            V1 = Convert.ToInt32(txtRan_inicial.Text);
            V2 = Convert.ToInt32(txtRan_final.Text);

            lista = BusMotivo.consultar(param.IdEmpresa, V1, V2);

            gridControlMovi_inve_tipo.DataSource = lista;

        }

        
        private void ucGe_Menu_Load(object sender, EventArgs e)
        {

        }

        private void FrmIn_Motivo_Inven_borrar_Cons_Load(object sender, EventArgs e)
        {

        }

        
    }
}
