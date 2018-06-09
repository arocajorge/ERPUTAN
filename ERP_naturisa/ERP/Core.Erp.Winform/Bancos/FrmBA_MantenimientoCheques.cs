using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Core.Erp.Info.Bancos;
using Core.Erp.Info.General;

using Core.Erp.Business.Bancos;
using Core.Erp.Business.General;
using Core.Erp.Reportes.Bancos;


namespace Core.Erp.Winform.Bancos
{
    public partial class FrmBA_MantenimientoCheques : Form
    {
        #region Variables y atributos
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        string MensajeError = string.Empty;

        BindingList<ba_Cbte_Ban_Info> BList_cbte_ban = new BindingList<ba_Cbte_Ban_Info>();
        List<ba_Cbte_Ban_Info> List_cbte_ban = new List<ba_Cbte_Ban_Info>();
        ba_Cbte_Ban_Bus Bus_cbte_ban = new ba_Cbte_Ban_Bus();
        
        List<tb_Sucursal_Info> List_Sucursal = new List<tb_Sucursal_Info>();
        tb_Sucursal_Bus Bus_Sucursal = new tb_Sucursal_Bus();

        List<ba_Cbte_Ban_tipo_Info> List_Tipo_cbte = new List<ba_Cbte_Ban_tipo_Info>();
        ba_Cbte_Ban_tipo_Bus Bus_Tipo_cbte = new ba_Cbte_Ban_tipo_Bus();

        List<ba_Banco_Cuenta_Info> List_cta_ban = new List<ba_Banco_Cuenta_Info>();
        ba_Banco_Cuenta_Bus Bus_cta_ban = new ba_Banco_Cuenta_Bus();

        List<vwba_Estado_cbte_ban_Info> List_Estado_cbte_ban = new List<vwba_Estado_cbte_ban_Info>();
        vwba_Estado_cbte_ban_Bus Bus_Estado_cbte_ban = new vwba_Estado_cbte_ban_Bus();
        
        
        #endregion

        public FrmBA_MantenimientoCheques()
        {
            InitializeComponent();
            ucGe_Menu_Superior_Mant1.event_btnGuardar_y_Salir_Click += ucGe_Menu_Superior_Mant1_event_btnGuardar_y_Salir_Click;
            ucGe_Menu_Superior_Mant1.event_btnImprimir_Click += ucGe_Menu_Superior_Mant1_event_btnImprimir_Click;
            ucGe_Menu_Superior_Mant1.event_btnSalir_Click += ucGe_Menu_Superior_Mant1_event_btnSalir_Click;
        }

        void ucGe_Menu_Superior_Mant1_event_btnSalir_Click(object sender, EventArgs e)
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

        void ucGe_Menu_Superior_Mant1_event_btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                List<ba_Cbte_Ban_Info> Lista = new List<ba_Cbte_Ban_Info>();
                Lista = new List<ba_Cbte_Ban_Info>(BList_cbte_ban);
                XBAN_Rpt017_Rpt rpt = new XBAN_Rpt017_Rpt();
                rpt.Parameters["pNom_Sucursal"].Value = cmb_Sucursal.Properties.GetDisplayText(cmb_Sucursal.EditValue);
                rpt.Parameters["pFecha_Desde"].Value = dteDesde.EditValue == null ? DateTime.Now : Convert.ToDateTime(dteDesde.EditValue);
                rpt.Parameters["pFecha_Hasta"].Value = dteHasta.EditValue == null ? DateTime.Now : Convert.ToDateTime(dteHasta.EditValue);
                rpt.Parameters["pNom_TipoCbte"].Value = cmb_cbte_tipo.Properties.GetDisplayText(cmb_cbte_tipo.EditValue);
                rpt.Parameters["pNom_Banco"].Value = cmb_cta_ban.Properties.GetDisplayText(cmb_cta_ban.EditValue);
                rpt.Parameters["pNom_Estado"].Value = cmb_Estado.Properties.GetDisplayText(cmb_Estado.EditValue);
                rpt.AsignarLista(Lista);
                rpt.ShowPreviewDialog();


            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void ucGe_Menu_Superior_Mant1_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                GetChequesModificados();
                if (List_cbte_ban.Count>0)
                {
                    if (Bus_cbte_ban.Modificar_Estado_cbte_ban(List_cbte_ban,ref MensajeError))
                    {
                        MessageBox.Show("Comprobantes contables actualizados exitosamente",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Asterisk);

                        if (MessageBox.Show("¿Desea imprimir el comprobante de la transacción...?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            Imprimir();
                        }
                        LoadDatos();
                    }
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void GetChequesModificados()
        {
            try
            {
                List_cbte_ban = new List<ba_Cbte_Ban_Info>(BList_cbte_ban.Where(q => q.Modificado == true).ToList());
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void llenarCombos()
        {
            try
            {
                List_Sucursal = Bus_Sucursal.Get_List_Sucursal_Todos(param.IdEmpresa);
                cmb_Sucursal.Properties.DataSource = List_Sucursal;
                cmb_Sucursal.Properties.ValueMember = "IdSucursal";
                cmb_Sucursal.Properties.DisplayMember = "Su_Descripcion2";

                List_Tipo_cbte = Bus_Tipo_cbte.Get_List_Cbte_Ban_tipo_Todos();
                cmb_cbte_tipo.Properties.DataSource = List_Tipo_cbte;
                cmb_cbte_tipo.Properties.ValueMember = "CodTipoCbteBan";
                cmb_cbte_tipo.Properties.DisplayMember = "Descripcion";
                cmb_cbte_tipo.EditValue = "CHEQ";

                List_cta_ban = Bus_cta_ban.Get_list_Banco_Cuenta_Todos(param.IdEmpresa);
                cmb_cta_ban.Properties.DataSource = List_cta_ban;
                cmb_cta_ban.Properties.ValueMember = "IdBanco";
                cmb_cta_ban.Properties.DisplayMember = "ba_descripcion2";

                List_Estado_cbte_ban = Bus_Estado_cbte_ban.Get_Lista_Estado_cbte_ban_Todos();

                cmb_Estado.Properties.DataSource = List_Estado_cbte_ban;
                cmb_Estado.Properties.ValueMember = "IdEstado_cbte_ban";
                cmb_Estado.Properties.DisplayMember = "ca_descripcion";

                List_Estado_cbte_ban = Bus_Estado_cbte_ban.Get_Lista_Estado_cbte_ban();

                cmb_Estado_cbt_ban.DataSource = List_Estado_cbte_ban;
                cmb_Estado_cbt_ban.ValueMember = "IdEstado_cbte_ban";
                cmb_Estado_cbt_ban.DisplayMember = "ca_descripcion";

                dteDesde.EditValue = DateTime.Now.AddMonths(-1);
                dteHasta.EditValue = DateTime.Now.AddDays(1);

                ucGe_Menu_Superior_Mant1.btnGuardar_y_Salir.Text = "Guardar";
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void LoadDatos()
        {
            try
            {
                int idEmpresa = 0;
                int idSucursalIni = 0;
                int idSucursalFin = 0;
                int idBancoIni = 0;
                int idBancoFin = 0;
                DateTime fechaIni = DateTime.Now;
                DateTime fechaFin = DateTime.Now;
                string Estado_cbte_ban = string.Empty;
                string cod_cbte_ban_tipo = string.Empty;

                idEmpresa = param.IdEmpresa;
                idSucursalIni = cmb_Sucursal.EditValue == null ? 0 : Convert.ToInt32(cmb_Sucursal.EditValue);
                idSucursalFin = (cmb_Sucursal.EditValue == null || Convert.ToInt32(cmb_Sucursal.EditValue) == 0) ? 9999 : Convert.ToInt32(cmb_Sucursal.EditValue);
                idBancoIni = cmb_cta_ban.EditValue == null ? 0 : Convert.ToInt32(cmb_cta_ban.EditValue);
                idBancoFin = cmb_cta_ban.EditValue == null || Convert.ToInt32(cmb_cta_ban.EditValue) == 0 ? 9999 : Convert.ToInt32(cmb_cta_ban.EditValue);
                fechaIni = dteDesde.EditValue == null ? DateTime.Now : Convert.ToDateTime(dteDesde.EditValue);
                fechaFin = dteHasta.EditValue == null ? DateTime.Now : Convert.ToDateTime(dteHasta.EditValue);
                Estado_cbte_ban = cmb_Estado.EditValue == null ? "" : cmb_Estado.EditValue.ToString();
                cod_cbte_ban_tipo = cmb_cbte_tipo.EditValue == null ? "" : Convert.ToString(cmb_cbte_tipo.EditValue);

                BList_cbte_ban = new BindingList<ba_Cbte_Ban_Info>(Bus_cbte_ban.Get_List_Cbte_Ban(idEmpresa,idSucursalIni,idSucursalFin,fechaIni,fechaFin,cod_cbte_ban_tipo,idBancoIni,idBancoFin,Estado_cbte_ban,ref MensajeError));
                gridControlMantenimientoCheques.DataSource = BList_cbte_ban;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void FrmBA_MantenimientoCheques_Load(object sender, EventArgs e)
        {
            try
            {
                llenarCombos();
                LoadDatos();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                LoadDatos();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void gridViewMantenimientoCheques_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                ba_Cbte_Ban_Info row = new ba_Cbte_Ban_Info();
                row = (ba_Cbte_Ban_Info)gridViewMantenimientoCheques.GetRow(e.RowHandle);

                if (row!=null)
                {
                    if (e.Column==colIdEstado_cbte_ban)
                    {
                        gridViewMantenimientoCheques.SetFocusedRowCellValue(colModificado, true);
                    }
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void Imprimir()
        {
            try
            {
                XBAN_Rpt017_Rpt rpt = new XBAN_Rpt017_Rpt();
                rpt.Parameters["pNom_Sucursal"].Value = cmb_Sucursal.Properties.GetDisplayText(cmb_Sucursal.EditValue);
                rpt.Parameters["pFecha_Desde"].Value = dteDesde.EditValue==null ? DateTime.Now : Convert.ToDateTime(dteDesde.EditValue);
                rpt.Parameters["pFecha_Hasta"].Value = dteHasta.EditValue == null ? DateTime.Now : Convert.ToDateTime(dteHasta.EditValue);
                rpt.Parameters["pNom_TipoCbte"].Value = cmb_cbte_tipo.Properties.GetDisplayText(cmb_cbte_tipo.EditValue);
                rpt.Parameters["pNom_Banco"].Value = cmb_cta_ban.Properties.GetDisplayText(cmb_cta_ban.EditValue);
                rpt.Parameters["pNom_Estado"].Value = cmb_Estado.Properties.GetDisplayText(cmb_Estado.EditValue);
                rpt.AsignarLista(List_cbte_ban);
                rpt.ShowPreviewDialog();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
    }

    
}
