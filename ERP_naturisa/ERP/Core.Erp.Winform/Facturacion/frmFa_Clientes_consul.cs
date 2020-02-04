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
using Core.Erp.Business.Facturacion;
using Core.Erp.Info.Facturacion;


namespace Core.Erp.Winform.Facturacion
{
    public partial class frmFa_Clientes_consul : Form
    {
        #region DEclaración de variables

        int fila = -1;
    
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        public Boolean llamadoFuera { get; set; }
        List<fa_Cliente_Info> lista_clientes = new List<fa_Cliente_Info>();
        fa_Cliente_Info Info_Cliente = new fa_Cliente_Info();
        fa_Cliente_Bus bus_client = new fa_Cliente_Bus();
        private cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        frmFa_Clientes_ImportacionWizard frmwiz;
        frmFa_Clientes_Mant frm = new frmFa_Clientes_Mant();

        #endregion

        public frmFa_Clientes_consul()
        {
            try
            {
                InitializeComponent();
                ucGe_Menu_Mantenimiento_x_usuario.event_btnNuevo_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnconsultar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnModificar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnSalir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnAnular_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnImprimir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnImprimir_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnImpExcel_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnImpExcel_ItemClick;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.gridView_Clientes.ShowPrintPreview();
            }
            catch (Exception ex)
            {
                 Log_Error_bus.Log_Error(ex.ToString());
                 MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        void ucGe_Menu_Mantenimiento_x_usuario_event_btnImpExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmwiz = new frmFa_Clientes_ImportacionWizard();                
                frmwiz.Show();
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
                if (Info_Cliente != null)
                {
                    if (Info_Cliente.Estado == "A")
                    {

                        Preparar_Formulario(Cl_Enumeradores.eTipo_action.Anular);
                        
                     }
                    else
                        MessageBox.Show("No se pudo anular el Cliente: " + Info_Cliente.Persona_Info.pe_nombreCompleto + " debido a que ya se encuentra anulado", "Anulación de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
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
                this.Close();
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
                if (Info_Cliente != null)
                {
                    Preparar_Formulario(Cl_Enumeradores.eTipo_action.actualizar);
                    
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
                if (Info_Cliente != null)
                {
                    Preparar_Formulario(Cl_Enumeradores.eTipo_action.consultar);

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
                Preparar_Formulario(Cl_Enumeradores.eTipo_action.grabar);

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cargar_Cliente()
        {
            try
            {
             
                lista_clientes = bus_client.Get_List_Cliente(param.IdEmpresa);
                gridControl_Clientes.DataSource = lista_clientes;
               
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
     
        void frm_event_frmFa_Clientes_ImportacionWizard_FormClosing(object sender, FormClosingEventArgs e)
       {
           try
           {
               Cargar_Cliente();
           }
           catch (Exception ex)
           {
               Log_Error_bus.Log_Error(ex.ToString());
               MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }

       }
       
        void frm_event_frmFA_Clientes_Mant_FormClosing()
       {
           try
           {
                Cargar_Cliente();
           }
           catch (Exception ex)
           {
               Log_Error_bus.Log_Error(ex.ToString());
               MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
      
       }
     
       private void frmFA_Clientes_General_Load(object sender, EventArgs e)
       {

           try
           {
               Cargar_Cliente();
           }
           catch (Exception ex)
           {

           }          
       }

       private void gridView_Clientes_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
       {
           try
           {
               var data = gridView_Clientes.GetRow(e.RowHandle) as fa_Cliente_Info ;
               if (data == null)
                   return;
               if (data.Estado == "I")
                   e.Appearance.ForeColor = Color.Red;
           }
           catch (Exception ex)
           {
               Log_Error_bus.Log_Error(ex.ToString());
               MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
       }

       private fa_Cliente_Info GetSelectedRow(DevExpress.XtraGrid.Views.Grid.GridView view)
       {
           try
           {
               return (fa_Cliente_Info)view.GetRow(view.FocusedRowHandle);
           }
           catch (Exception ex)
           {
               Log_Error_bus.Log_Error(ex.ToString());
               MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               return new fa_Cliente_Info();
           }
       }
  
       private void gridView_Clientes_DoubleClick(object sender, EventArgs e)
       {
           try
           {
               if (llamadoFuera == true)
               {                   
                   this.Close();
               }
           }
           catch (Exception ex)
           {
               Log_Error_bus.Log_Error(ex.ToString());
               MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }

       }

       private void toolStripButtonSeleccionar_Click(object sender, EventArgs e)
       {
           try
           {
               if (llamadoFuera == true)
               {
                   
                   this.Close();
               }
           }
           catch (Exception ex)
           {
               Log_Error_bus.Log_Error(ex.ToString());
               MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }

       }
       
       private void btnImprimir_Click(object sender, EventArgs e)
       {
           try
           {
                gridControl_Clientes.ShowRibbonPrintPreview();
           }
           catch (Exception ex)
           {
               Log_Error_bus.Log_Error(ex.ToString());
               MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }

       }

       private void gridView_Clientes_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
       {
           try
           {
               Info_Cliente = new fa_Cliente_Info();
               Info_Cliente = GetSelectedRow((DevExpress.XtraGrid.Views.Grid.GridView)sender);
           }
           catch (Exception ex)
           {
               Log_Error_bus.Log_Error(ex.ToString());
               MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
       }

       private void ucGe_Menu_Mantenimiento_x_usuario_event_btnBuscar_Click(object sender, EventArgs e)
       {
           try
           {
               Cargar_Cliente();
           }
           catch (Exception ex)
           {
                Log_Error_bus.Log_Error(ex.ToString());
               MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
       }

       private void Preparar_Formulario(Cl_Enumeradores.eTipo_action iAccion)
       {
           try
           {
               string mensajeFrm = "";
               Info_Cliente = new fa_Cliente_Info();

               switch (iAccion)
               {
                   case Cl_Enumeradores.eTipo_action.grabar:
                       mensajeFrm = "REGISTRO NUEVO";
                       break;
                   case Cl_Enumeradores.eTipo_action.actualizar :
                       mensajeFrm = "MODIFICAR REGISTRO";
                       Info_Cliente = (fa_Cliente_Info)gridView_Clientes.GetFocusedRow();
                       break;
                   case Cl_Enumeradores.eTipo_action.Anular:
                       mensajeFrm = "ANULAR REGISTRO";
                       Info_Cliente = (fa_Cliente_Info)gridView_Clientes.GetFocusedRow();
                       break;
                   case Cl_Enumeradores.eTipo_action.consultar:
                       mensajeFrm = "CONSULTAR REGISTRO";
                       Info_Cliente = (fa_Cliente_Info)gridView_Clientes.GetFocusedRow();
                       break;
                   default:
                       break;
               }

               if (Info_Cliente != null)
               {
                   frm  = new frmFa_Clientes_Mant();
                   frm.Text = frm .Text + "***" + mensajeFrm + "***";
                   frm.set_Accion(iAccion);
                   frm.MdiParent = this.MdiParent;
                   frm.set_Cliente(Info_Cliente);
                   frm.Show();                  
                   
                   frm.event_frmFA_Clientes_Mant_FormClosing+=frm_event_frmFA_Clientes_Mant_FormClosing;
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

    }
}
