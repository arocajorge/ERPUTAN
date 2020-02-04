using Core.Erp.Business.Facturacion;
using Core.Erp.Business.General;
using Core.Erp.Info.Facturacion;
using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Core.Erp.Winform.General
{
    public partial class FrmGe_DocuAnuladosConsulta : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        public FrmGe_DocuAnuladosConsulta()
        {
            try
            {
                
            InitializeComponent();
            ucGe_Menu_Mantenimiento_x_usuario.event_btnNuevo_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick;
            ucGe_Menu_Mantenimiento_x_usuario.event_btnconsultar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick;
            ucGe_Menu_Mantenimiento_x_usuario.event_btnSalir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick;
            ucGe_Menu_Mantenimiento_x_usuario.event_btnModificar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick;
            ucGe_Menu_Mantenimiento_x_usuario.event_btnAnular_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick;
                try
            {
                fa_Secuencia_Documento_Talonario_Bus busTipoDocFac = new fa_Secuencia_Documento_Talonario_Bus();
                List<tb_sis_tipoDocumento_Info> lst = new List<tb_sis_tipoDocumento_Info>();
                tb_sis_tipoDocumento_Bus b = new tb_sis_tipoDocumento_Bus();
                lst = b.Get_List_sis_tipoDocumento();

                //List<fa_Documento_Tipo_info> lst_docXem = new List<fa_Documento_Tipo_info>();
                //lst_docXem = busTipoDocFac.Get_List_Documento_Tipo_x_Empresa(param.IdEmpresa);
                
                //foreach(var item in lst_docXem)
                //{
                //    foreach(var item2 in lst)
                //    {
                //        if(item2.IdTipoDocumento == item.codDocumentoTipo)
                //            item.descripcion = item2.Descripcion ;
                //    }
                //}

                //repositoryItemGridLookUpEdit_tipo.DataSource = lst_docXem;
                //repositoryItemGridLookUpEdit_tipo.ValueMember = "codDocumentoTipo";
                //repositoryItemGridLookUpEdit_tipo.DisplayMember = "descripcion";

                //tb_Catalogo_Bus C_B = new tb_Catalogo_Bus();
                //repositoryItemGridLookUpEdit_motivo.DataSource = C_B.Get_List_MotivoAnulacion();
                //repositoryItemGridLookUpEdit_motivo.DisplayMember = "ca_descripcion";
                //repositoryItemGridLookUpEdit_motivo.ValueMember = "IdCatalogo";

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            load_data();
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
                LlamaFRM(Cl_Enumeradores.eTipo_action.Anular, Info);
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
                LlamaFRM(Cl_Enumeradores.eTipo_action.actualizar, Info);
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

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                LlamaFRM(Cl_Enumeradores.eTipo_action.consultar, Info);
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
                LlamaFRM(Cl_Enumeradores.eTipo_action.grabar, Info);
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        tb_sis_Documento_Tipo_x_Empresa_Anulados_Bus DocAnu_B = new tb_sis_Documento_Tipo_x_Empresa_Anulados_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        FrmGe_DocuAnulados frm;
         tb_sis_Documento_Tipo_x_Empresa_Anulados_Info Info=new tb_sis_Documento_Tipo_x_Empresa_Anulados_Info();

        private void load_data()
        {
            try
            {
                this.gridControl_DocAnu.DataSource = DocAnu_B.ConsultaGeneral(param.IdEmpresa);
            }
            catch (Exception ex) { Log_Error_bus.Log_Error(ex.ToString());
            MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void LlamaFRM(Cl_Enumeradores.eTipo_action Accion, tb_sis_Documento_Tipo_x_Empresa_Anulados_Info Info)
        {
            try
            {
                frm = new FrmGe_DocuAnulados();
                frm.event_FrmGe_DocuAnulados_FormClosing += frm_event_FrmGe_DocuAnulados_FormClosing;
                frm.MdiParent = this.MdiParent;
                frm.set_accion(Accion);

                if(!(Accion == Cl_Enumeradores.eTipo_action.grabar))
                {
                   // frm.set_Info(Info);

                    frm.set=Info;
                }

                frm.Show();
            }
            catch (Exception ex) { Log_Error_bus.Log_Error(ex.ToString());
            MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void frm_event_FrmGe_DocuAnulados_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
              load_data();
            }
            catch (Exception ex)
            {
                 Log_Error_bus.Log_Error(ex.ToString());
                 MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         
        }



        private void UltraGrid_DocAnu_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                Info = (tb_sis_Documento_Tipo_x_Empresa_Anulados_Info)UltraGrid_DocAnu.GetFocusedRow();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



    }
}
