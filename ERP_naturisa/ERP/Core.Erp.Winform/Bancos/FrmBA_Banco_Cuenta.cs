using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.Bancos;
using Core.Erp.Business.Bancos;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Winform.Bancos;
using Core.Erp.Reportes.Bancos;
using Core.Erp.Info.General;


namespace Core.Erp.Winform.Bancos
{
    public partial class FrmBA_Banco_Cuenta : Form
    {

        #region Declaración de Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        private Cl_Enumeradores.eTipo_action _Accion;
        FrmBA_Banco_Cuenta_Mant ofrm = new FrmBA_Banco_Cuenta_Mant();
        List<ba_Banco_Cuenta_Info> listBancoCuenta = new List<ba_Banco_Cuenta_Info>();
        
        ba_Banco_Cuenta_Bus BancoB = new ba_Banco_Cuenta_Bus();
        ba_Banco_Cuenta_Info BancoI = new ba_Banco_Cuenta_Info();
        #endregion

        public void set_Accion(Cl_Enumeradores.eTipo_action iAccion)
        {
            try
            {
                _Accion = iAccion;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        public FrmBA_Banco_Cuenta()
        {
            try
            {
               InitializeComponent();
               ucGe_Menu_Mantenimiento_x_usuario.event_btnAnular_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick;
               ucGe_Menu_Mantenimiento_x_usuario.event_btnconsultar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick;
               ucGe_Menu_Mantenimiento_x_usuario.event_btnDiseñoCheque_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnDiseñoCheque_ItemClick;
                //ucGe_Menu_Mantenimiento_x_usuario.event_BtnDisChqCbte_Click +=ucGe_Menu_Mantenimiento_x_usuario_event_BtnDisChqCbte_Click;
               ucGe_Menu_Mantenimiento_x_usuario.event_btnModificar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick;
               ucGe_Menu_Mantenimiento_x_usuario.event_btnNuevo_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick;
               ucGe_Menu_Mantenimiento_x_usuario.event_btnSalir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick;
                
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
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
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                FrmBA_Banco_Cuenta_Mant frm = new FrmBA_Banco_Cuenta_Mant();
                frm.set_Accion(Cl_Enumeradores.eTipo_action.grabar);
                frm.event_FrmBA_Banco_Cuenta_Mantenimiento_FormClosing += new FrmBA_Banco_Cuenta_Mant.delegate_FrmBA_Banco_Cuenta_Mantenimiento_FormClosing(frm_event_FrmBA_Banco_Cuenta_Mantenimiento_FormClosing);
                frm.Show();                    

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (BancoI.IdBanco == 0)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_un_registro), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                else
                {
                    FrmBA_Banco_Cuenta_Mant frm = new FrmBA_Banco_Cuenta_Mant();

                    frm.set_Accion(Cl_Enumeradores.eTipo_action.actualizar);
                    frm.set_Info(BancoI);
                    frm.event_FrmBA_Banco_Cuenta_Mantenimiento_FormClosing+= new FrmBA_Banco_Cuenta_Mant.delegate_FrmBA_Banco_Cuenta_Mantenimiento_FormClosing(frm_event_FrmBA_Banco_Cuenta_Mantenimiento_FormClosing);
                    frm.Show();                    
//                    cargar_grid();
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnDiseñoCheque_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                XBAN_Rpt006_frm ofrm = new XBAN_Rpt006_frm(BancoI);
                ofrm.Show();
                

                return;

                
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());

            }
        }

        void reporte_SaveComponents(object sender, DevExpress.XtraReports.UI.SaveComponentsEventArgs e)
        {
            MessageBox.Show("Guardar");
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (BancoI.IdBanco == 0)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_un_registro), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    FrmBA_Banco_Cuenta_Mant frm = new FrmBA_Banco_Cuenta_Mant();

                    frm.set_Accion(Cl_Enumeradores.eTipo_action.consultar);
                    frm.set_Info(BancoI);
                    frm.Show();
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            #region Anterior
            //try
            //{
            //    if (MessageBox.Show("¿Está seguro que desea anular la Cuenta Bancaria ?", "Anulación de Cuenta Bancaria", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //    {
            //        if (BancoB.ActualizarEstado(BancoI))
            //        {
            //            MessageBox.Show("Anulado ok", "Operación Exitosa");
            //        }
            //        else
            //        {
            //            MessageBox.Show("No se Anulado", "Operación Fallida");
            //        }
            //        cargar_grid();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Log_Error_bus.Log_Error(ex.ToString());
            //}
            #endregion
           
            try
            {
                ofrm = new FrmBA_Banco_Cuenta_Mant();   
                ofrm.set_Accion(Erp.Info.General.Cl_Enumeradores.eTipo_action.Anular);
                ofrm.set_Info(BancoI);
                ofrm.MdiParent = this.MdiParent;
                ofrm.event_FrmBA_Banco_Cuenta_Mantenimiento_FormClosing += new FrmBA_Banco_Cuenta_Mant.delegate_FrmBA_Banco_Cuenta_Mantenimiento_FormClosing(frm_event_FrmBA_Banco_Cuenta_Mantenimiento_FormClosing);
                //cargar_grid();
                ofrm.Show();
                
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void ofrm_event_FrmBA_Banco_Cuenta_Mantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void FrmBA_Banco_Cuenta_Load(object sender, EventArgs e)
        {
            try
            {
                  cargar_grid();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        

        private void cargar_grid()
        {
            try
            {
                listBancoCuenta = BancoB.Get_list_Banco_Cuenta(param.IdEmpresa);
                gridControl_Banco.DataSource = listBancoCuenta;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void frm_event_FrmBA_Banco_Cuenta_Mantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                  cargar_grid();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        private void gridView_Banco_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                BancoI = (ba_Banco_Cuenta_Info)gridView_Banco.GetFocusedRow();
            }
            catch(Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void gridView_Banco_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridView_Banco.GetRow(e.RowHandle) as ba_Banco_Cuenta_Info;
                if (data == null)
                    return;
                if (data.Estado == "I")
                    e.Appearance.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void ucGe_Menu_Mantenimiento_x_usuario_event_BtnDisChqCbte_Click(object sender, EventArgs e)
        {
            XBAN_Rpt005_frm ofrm = new XBAN_Rpt005_frm(BancoI);
            ofrm.Show();
        }
   
   
    }
}
