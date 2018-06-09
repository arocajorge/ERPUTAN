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
using Core.Erp.Business.Bancos;
using Core.Erp.Info.Bancos;
using DevExpress.XtraPrinting;
using DevExpress.XtraGrid.Views.Grid;

using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace Core.Erp.Winform.Bancos
{
    public partial class FrmBA_InversionConsulta : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        public FrmBA_InversionConsulta()
        {
            try
            {
                InitializeComponent();
                ucGe_Menu_Mantenimiento_x_usuario.event_btnNuevo_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnconsultar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnModificar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnImprimir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnImprimir_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnSalir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnAnular_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

            
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                InfoInversion = (ba_Inversion_Info)gridViewCons.GetFocusedRow();
                if (InfoInversion == null)
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_un_registro), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else if (InfoInversion.Estado == "I")
                    MessageBox.Show("La Inversión: " + InfoInversion.IdInversion + " ya fue anulada", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    FrmBA_Inversion_Mant frm = new FrmBA_Inversion_Mant();
                    frm.setAccion(Cl_Enumeradores.eTipo_action.Anular);
                    frm.Text = frm.Text + " ***ANULAR REGISTRO***";
                    frm.Show(); frm.setinfo(InfoInversion);
                    frm.event_FrmBA_Inversion_Mant_FormClosing += frm_event_FrmBA_Inversion_Mant_FormClosing;

                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                gridControlCons.ShowPrintPreview();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                InfoInversion = (ba_Inversion_Info)gridViewCons.GetFocusedRow();
                if (InfoInversion == null)
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_un_registro), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    FrmBA_Inversion_Mant frm = new FrmBA_Inversion_Mant();
                    frm.setAccion(Cl_Enumeradores.eTipo_action.actualizar);
                    frm.setinfo(InfoInversion);
                    frm.Text = frm.Text + " ***MODIFICAR REGISTRO***"; frm.MdiParent = this.MdiParent;
                    frm.Show();
                    frm.event_FrmBA_Inversion_Mant_FormClosing += frm_event_FrmBA_Inversion_Mant_FormClosing;
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                InfoInversion = (ba_Inversion_Info)gridViewCons.GetFocusedRow();
                if (InfoInversion == null || InfoInversion.IdInversion == null)
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_un_registro), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    FrmBA_Inversion_Mant frm = new FrmBA_Inversion_Mant();
                    frm.setAccion(Cl_Enumeradores.eTipo_action.consultar); frm.MdiParent = this.MdiParent;
                    frm.setinfo(InfoInversion);
                    frm.Text = frm.Text + " ***CONSULTAR REGISTRO***";
                    frm.Show();

                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                FrmBA_Inversion_Mant frm = new FrmBA_Inversion_Mant();
                frm.setAccion(Cl_Enumeradores.eTipo_action.grabar);
                frm.Text = frm.Text + " ***NUEVO REGISTRO***"; frm.MdiParent = this.MdiParent;
                frm.Show();
                frm.event_FrmBA_Inversion_Mant_FormClosing += frm_event_FrmBA_Inversion_Mant_FormClosing;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        List<ba_Banco_Cuenta_Info> ListadoBanco = new List<ba_Banco_Cuenta_Info>();
        private void FrmBA_InversionConsulta_Load(object sender, EventArgs e)
        {
            try
            {
                ListadoBanco = busBanco.Get_list_Banco_Cuenta(param.IdEmpresa);
                cmbBanco.DataSource = ListadoBanco;
                cargaGrid();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        ba_Banco_Cuenta_Bus busBanco = new ba_Banco_Cuenta_Bus();
        ba_Inversion_Bus BusInversion = new ba_Inversion_Bus();
        ba_Inversion_Info InfoInversion = new ba_Inversion_Info();

        //Instancia de empresa
        public cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        string msg = "";
        private void cargaGrid()
        {
            try
            {
                ListadoBanco = busBanco.Get_list_Banco_Cuenta(param.IdEmpresa);
                cmbBanco.DataSource = ListadoBanco;

                List<ba_Inversion_Info> Listado = BusInversion.Get_List_Inversion(param.IdEmpresa, ref msg);
                foreach (var item in Listado)
                {
                    item.NomBanco = ListadoBanco.First(var => var.IdBanco == item.IdBanco).ba_descripcion;
                }
                gridControlCons.DataSource = Listado;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }


        private void gridViewCons_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridViewCons.GetRow(e.RowHandle) as ba_Inversion_Info;
                if (data == null)
                    return;
                if (data.Estado == "I")
                    e.Appearance.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }


        void frm_event_FrmBA_Inversion_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
              cargaGrid();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }


              
      
        /*
            //gridControlCons.ShowPrintPreview();
            string leftColumn = "Fecha: [Date Printed][Time Printed]";
            string middleColumn = "Página:[Page # of Pages #]";
            string rightColumn = "Usuario:" + param.IdUsuario;

            // Create a PageHeaderFooter object and initializing it with
            // the link's PageHeaderFooter.

            PageHeaderFooter phf = printableComponentLink1.PageHeaderFooter as PageHeaderFooter;

            // Clear the PageHeaderFooter's contents.
            phf.Header.Content.Clear();
            phf.Footer.Content.Clear();
            Font fte = new System.Drawing.Font("Tahoma", 8.5f, FontStyle.Bold, GraphicsUnit.Point);

            // Add custom information to the link's header.
            phf.Header.Font = fte;
            phf.Footer.Font = fte;
            phf.Header.Content.AddRange(new string[] { leftColumn, "", rightColumn, "hola" });
            phf.Header.LineAlignment = BrickAlignment.Center;
            phf.Footer.Content.AddRange(new string[] { "", "", middleColumn });
            phf.Footer.LineAlignment = BrickAlignment.Center;
            printableComponentLink1.Component = null;
            gridControlCons.RefreshDataSource();
            printableComponentLink1.Component = gridControlCons;
            printableComponentLink1.ShowPreview();*/

    }
}
