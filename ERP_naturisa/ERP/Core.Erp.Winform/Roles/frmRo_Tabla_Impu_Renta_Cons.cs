using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.Roles;
using Core.Erp.Business.Roles;
using Core.Erp.Info.General;
using Core.Erp.Business.General;

//Tabla Impuestos a la renta
//Derek Mejía Soria
//ultima modificacion : 08/01/2014
namespace Core.Erp.Winform.Roles
{
    public partial class frmRo_Tabla_Impu_Renta_Cons : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        BindingList<ro_tabla_Impu_Renta_Info> BLtablaImpuRenta = new BindingList<ro_tabla_Impu_Renta_Info>();
        ro_Tabla_Impu_Renta_Bus TablaImpuRentaBus = new ro_Tabla_Impu_Renta_Bus();
        frmRo_Tabla_Impu_Renta_Mant IRMant = new frmRo_Tabla_Impu_Renta_Mant();

        ro_tabla_Impu_Renta_Info IRInfo = new ro_tabla_Impu_Renta_Info();


        public frmRo_Tabla_Impu_Renta_Cons()
        {
            try
            {
              InitializeComponent();
              ucGe_Menu_Mantenimiento_x_usuario.event_btnconsultar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick;
              ucGe_Menu_Mantenimiento_x_usuario.event_btnImprimir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnImprimir_ItemClick;
              ucGe_Menu_Mantenimiento_x_usuario.event_btnModificar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick;
              ucGe_Menu_Mantenimiento_x_usuario.event_btnNuevo_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick;
              ucGe_Menu_Mantenimiento_x_usuario.event_btnSalir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
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
                MessageBox.Show(ex.ToString());
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
                MessageBox.Show(ex.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                llama_frm(Cl_Enumeradores.eTipo_action.actualizar);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                gridViewTablaIR.ShowPrintPreview();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                llama_frm(Cl_Enumeradores.eTipo_action.consultar);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmRo_Tabla_Impu_Renta_Cons_Load(object sender, EventArgs e)
        {
            try
            {        
                load();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }

        }

        void load()
        {
            try
            {
                BLtablaImpuRenta = new BindingList<ro_tabla_Impu_Renta_Info>(TablaImpuRentaBus.ConsultaTablaImpu());
                gridControlTablaIR.DataSource = BLtablaImpuRenta;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }

        }

        private void llama_frm(Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {
                IRMant = new frmRo_Tabla_Impu_Renta_Mant();
                IRMant.event_frmRo_Tabla_Impu_Renta_Mant_FormClosing += new frmRo_Tabla_Impu_Renta_Mant.delegate_frmRo_Tabla_Impu_Renta_Mant_FormClosing(frm_event_frmRo_Tabla_Impu_Renta_Mant_FormClosing);
                IRMant.MdiParent = this.MdiParent;

                if (Accion != Cl_Enumeradores.eTipo_action.grabar)
                {
                    IRMant.SETINFO_ = IRInfo;
                }
                IRMant.set_Accion(Accion);
                IRMant.Show();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        private void frm_event_frmRo_Tabla_Impu_Renta_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                //throw new NotImplementedException();            
                int focus = gridViewTablaIR.FocusedRowHandle;
                gridViewTablaIR.FocusedRowHandle = focus + 1;
                gridViewTablaIR.FocusedRowHandle = focus - 1;           
                load();     
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
                  
        }

        private void gridViewTablaIR_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                IRInfo = new ro_tabla_Impu_Renta_Info();
                IRInfo = gridViewTablaIR.GetFocusedRow() as ro_tabla_Impu_Renta_Info;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
