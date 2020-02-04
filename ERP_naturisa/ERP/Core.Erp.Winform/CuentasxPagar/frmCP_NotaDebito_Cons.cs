using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Core.Erp.Info.General;
using Core.Erp.Business.General;
using Core.Erp.Business.CuentasxPagar;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Info.Bancos;
using Core.Erp.Business.Bancos;

namespace Core.Erp.Winform.CuentasxPagar
{
    public partial class frmCP_NotaDebito_Cons : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus;
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        cp_nota_DebCre_Info Info_NotaDeb = new cp_nota_DebCre_Info();
        cp_nota_DebCre_Bus notaCr_B = new cp_nota_DebCre_Bus();
        List<cp_nota_DebCre_Info> lista_Nota_DebCre = new List<cp_nota_DebCre_Info>();
        frmCP_NotaDebito_Mant frm;


        List<ba_TipoFlujo_Info> lst_tipo_flujo = new List<ba_TipoFlujo_Info>();
        ba_TipoFlujo_Bus bus_tipo_flujo = new ba_TipoFlujo_Bus();
                       
        public frmCP_NotaDebito_Cons()
        {
            InitializeComponent();

            ucGe_Menu.event_btnAnular_ItemClick += ucGe_Menu_Mantenimiento_x_usuario1_event_btnAnular_ItemClick;
            ucGe_Menu.event_btnconsultar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario1_event_btnconsultar_ItemClick;
            ucGe_Menu.event_btnModificar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario1_event_btnModificar_ItemClick;
            ucGe_Menu.event_btnNuevo_ItemClick += ucGe_Menu_Mantenimiento_x_usuario1_event_btnNuevo_ItemClick;
            ucGe_Menu.event_btnSalir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario1_event_btnSalir_ItemClick;
            ucGe_Menu.event_btnBuscar_Click += ucGe_Menu_Mantenimiento_x_usuario1_event_btnBuscar_Click;
            ucGe_Menu.event_btnImprimir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario1_event_btnImprimir_ItemClick;
        }

        void ucGe_Menu_Mantenimiento_x_usuario1_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                gridViewDebito.ShowPrintPreview();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
      
        

        private void llamaFRM(Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {

                string mensajeFrm = "";

                Info_NotaDeb = new cp_nota_DebCre_Info();

                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        mensajeFrm = "REGISTRO NUEVO";
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        mensajeFrm = "MODIFICAR REGISTRO";
                        Info_NotaDeb = (cp_nota_DebCre_Info)gridViewDebito.GetFocusedRow();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        mensajeFrm = "ANULAR REGISTRO";
                        Info_NotaDeb = (cp_nota_DebCre_Info)gridViewDebito.GetFocusedRow();
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        mensajeFrm = "CONSULTAR REGISTRO";
                        Info_NotaDeb = (cp_nota_DebCre_Info)gridViewDebito.GetFocusedRow();
                        break;
                    default:
                        break;
                }


                if (Info_NotaDeb != null)
                {
                    frm = new frmCP_NotaDebito_Mant();
                    frm.Text = frm.Text + "***" + mensajeFrm + "***";
                    frm.set_accion(Accion);
                    frm.set_Info_notaCr(Info_NotaDeb );
                    frm.Show();
                    frm.MdiParent = this.MdiParent;
                    frm.event_frmCP_NotaDebito_Mant_FormClosing+=frm_event_frmCP_NotaDebito_Mant_FormClosing;

                }
                else
                {
                    MessageBox.Show("Seleccione un Registro ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
                }

                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void frm_event_frmCP_NotaDebito_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                load_datos();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void load_datos()
        {
            try
            {
                DateTime FechaIni = ucGe_Menu.fecha_desde;
                DateTime FechaFin = ucGe_Menu.fecha_hasta;
                string DebCre = "D";

                lista_Nota_DebCre = notaCr_B.Get_List_nota_DebCre(param.IdEmpresa, FechaIni, FechaFin, DebCre);

                this.gridControlDebito.DataSource = lista_Nota_DebCre;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario1_event_btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                load_datos();

                if (lista_Nota_DebCre.Count == 0)
                {
                    MessageBox.Show("No existe Información a Consultar", "sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }       
        }

        void ucGe_Menu_Mantenimiento_x_usuario1_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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

        void ucGe_Menu_Mantenimiento_x_usuario1_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                llamaFRM(Cl_Enumeradores.eTipo_action.grabar);
            }
            catch (Exception ex)
            {
                //Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario1_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (lista_Nota_DebCre.Count != 0)
                {
                    if (Info_NotaDeb == null)
                    {
                        MessageBox.Show("Seleccione una fila", "sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        if (Info_NotaDeb.Estado == "I")
                        {
                            MessageBox.Show("No se pueden modificar Registros Inactivos...", "SISTEMAS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            llamaFRM(Cl_Enumeradores.eTipo_action.actualizar);
                        }
                    }  
                
                }
                else 
                {
                    MessageBox.Show("No existe Información a Modificar", "sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);               
                }
                                                                                         
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario1_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {

                if (lista_Nota_DebCre.Count != 0)
                {
                    if (Info_NotaDeb == null)
                    {
                        MessageBox.Show("Seleccione una fila", "sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        llamaFRM(Cl_Enumeradores.eTipo_action.consultar);
                    }
                
                }
                else
                {
                    MessageBox.Show("No existe Información a Consultar", "sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario1_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (lista_Nota_DebCre.Count != 0)
                {
                    if (Info_NotaDeb== null)
                    {
                        MessageBox.Show("Seleccione una fila", "sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        if (Info_NotaDeb.Estado == "I")
                        {
                            MessageBox.Show("No se pueden anular Registros Inactivos...", "SISTEMAS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            llamaFRM(Cl_Enumeradores.eTipo_action.Anular);
                        }
                    }  
                
                }
                else 
                {
                    MessageBox.Show("No existe Información a Anular", "sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);  
                
                }
                                                           
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCP_NotaDebito_Cons_Load(object sender, EventArgs e)
        {
            try
            {
                switch (param.IdCliente_Ven_x_Default)
                {
                    case Cl_Enumeradores.eCliente_Vzen.NATURISA:
                        colTipoFlujo.Visible = true;
                        Cargar_combos();
                        break;
                    case Cl_Enumeradores.eCliente_Vzen.FJ:
                        colTipoFlujo.Visible = true;
                        Cargar_combos();
                        break;
                    default:
                        break;
                }
               
                 load_datos();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewDebito_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                Info_NotaDeb = new cp_nota_DebCre_Info();
                Info_NotaDeb = this.gridViewDebito.GetFocusedRow() as cp_nota_DebCre_Info;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewDebito_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
             try
             {
                 var data = gridViewDebito.GetRow(e.RowHandle) as cp_nota_DebCre_Info;
                 if (data == null)
                     return;
                 if (data.Saldo == 0)
                 {
                     e.Appearance.ForeColor = Color.Blue;
                 }
                 if (data.Estado == "I")
                 {
                     e.Appearance.ForeColor = Color.Red;
                 }
                 
             }
             catch (Exception ex)
             {
                 Log_Error_bus.Log_Error(ex.ToString());
                 MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
        }

        private void ucGe_Menu_event_btnImpExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmCP_Saldo_inicial_ImportWizard frm = new frmCP_Saldo_inicial_ImportWizard();
                frm.event_delegate_FormClosing += frm_event_delegate_FormClosing;
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void frm_event_delegate_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                load_datos();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cargar_combos()
        {
            try
            {
                lst_tipo_flujo = bus_tipo_flujo.Get_List_TipoFlujo(param.IdEmpresa);
                cmb_tipo_flujo.DataSource = lst_tipo_flujo;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewDebito_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                Info_NotaDeb = (cp_nota_DebCre_Info)gridViewDebito.GetRow(e.RowHandle);
                if (Info_NotaDeb!= null)
                {
                    if (e.Column == colTipoFlujo)
                    {
                        if (MessageBox.Show("¿Está seguro que desea modificar el tipo de flujo de la nota # " + Info_NotaDeb.IdCbteCble_Nota.ToString() + "?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            if (Convert.ToInt32(e.Value) == 0) Info_NotaDeb.IdTipoFlujo = null; else Info_NotaDeb.IdTipoFlujo = Convert.ToInt32(e.Value);
                            notaCr_B.Modificar_tipo_flujo(Info_NotaDeb);
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

        private void gridViewDebito_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                if (e.Column == colCheck)
                {
                    gridViewDebito.SetRowCellValue(e.RowHandle, colCheck, e.Value);
                }
                if (e.Column == colTipoFlujo)
                {
                    gridViewDebito.SetRowCellValue(e.RowHandle, colTipoFlujo, e.Value);
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
