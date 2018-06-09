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
using Core.Erp.Info.Compras;
using Core.Erp.Business.Compras;

namespace Core.Erp.Winform.Compras
{
    public partial class FrmCom_SolicitudConsulta : Form
    {
        #region Declaración de Variables
        com_solicitud_compra_Bus Bus_SoliciCompra = new com_solicitud_compra_Bus();
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        tb_Sucursal_Bus Bus_Sucursal = new tb_Sucursal_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        List<tb_Sucursal_Info> ListSucursal = new List<tb_Sucursal_Info>();
        public int IdSucursal { get; set; }
        public DateTime FechaIni { get; set; }
        public DateTime FechaFin { get; set; }
        public int idSucursal { get; set; }
        public int IdSolicitud { get; set; }
        public decimal IdComprador { get; set; }
        public int IdDepartamento { get; set; }
        public List<com_solicitud_compra_Info> ListaGrid { get; set; }
        List<com_solicitud_compra_Info> ListaGrid2 = new List<com_solicitud_compra_Info>();
        #endregion
       
        
        public FrmCom_SolicitudConsulta()
        {
            InitializeComponent();
        }

        private void cargagrid()
        {
            try
            {

                List<com_solicitud_compra_Info> LstOC = new List<com_solicitud_compra_Info>();
                LstOC = Bus_SoliciCompra.Get_List_solicitud_compra(param.IdEmpresa, IdSucursal, FechaIni, FechaFin,"APR_SOL");
                gridControlConsulta.DataSource = LstOC;
               // gridViewConsulta.ExpandAllGroups();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        private void FrmCom_SolicitudConsulta_Load(object sender, EventArgs e)
        {
            try
            {
                ListSucursal = Bus_Sucursal.Get_List_Sucursal(param.IdEmpresa);
                cmbSucursal.Properties.DataSource = ListSucursal;
                cmbSucursal.Properties.DisplayMember = "Su_Descripcion";
                cmbSucursal.Properties.ValueMember = "IdSucursal";

                cmbSucursal.EditValue = IdSucursal;

                cargagrid();
            }
            catch (Exception ex)
            {
                
               Log_Error_bus.Log_Error(ex.ToString());
               MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            try
            {
                  IdSucursal= Convert.ToInt32(cmbSucursal.EditValue);
                  FechaIni=  dtpFechaIni.Value;
                  FechaFin = dtpFechaFin.Value;
                
                cargagrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        private void gridViewConsulta_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                //Id = gridViewConsulta.GetFocusedRowCellValue(ID).ToString();
                //if (TipoDoc == "FACT")
                //{
                    idSucursal = Convert.ToInt32(gridViewConsulta.GetFocusedRowCellValue(colIdSucursal));
                    IdSolicitud = Convert.ToInt32(gridViewConsulta.GetFocusedRowCellValue(colIdSolicitudCompra));
                    IdComprador = Convert.ToDecimal(gridViewConsulta.GetFocusedRowCellValue(colIdPersona_comprador));
                    IdDepartamento = Convert.ToInt32(gridViewConsulta.GetFocusedRowCellValue(colIdDepartamento));

               // }

                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        private void gridViewConsulta_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {



            }
            catch (Exception ex)
            {
                
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }
    }
}
