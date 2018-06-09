using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.General;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Business.Presupuesto;
using Core.Erp.Info.Presupuesto;
using Core.Erp.Business.CuentasxPagar;
using Core.Erp.Business.Facturacion;

namespace Core.Erp.Winform.Presupuesto
{
    public partial class frmpre_presupuesto_nuevo : Form
    {

        string MensajeError = "";

        public frmpre_presupuesto_nuevo()
        {
            try
            {
               InitializeComponent();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                
                ListaGrid = new List<pre_presupuesto_Info>();
                for (int i = 0; i < 1; i++)
                {
                    enviarInfoGrid.IdAnio = Convert.ToString(gridView.GetRowCellValue(i, PREIdAnio));
                    enviarInfoGrid.IdCentroCosto = Convert.ToString(gridView.GetRowCellValue(i, PREIdCentroCosto));
                    enviarInfoGrid.IdCtaCble = Convert.ToString(gridView.GetRowCellValue(i, PREIdCtaCble));
                    enviarInfoGrid.IdPresupuesto = Convert.ToDecimal(gridView.GetRowCellValue(i, PREIdPresupuesto));


                    enviarInfoGrid.IdTipoRubro = Convert.ToString(gridView.GetRowCellValue(i, PREIdTipoRubro));
                    enviarInfoGrid.CodRubro = Convert.ToString(gridView.GetRowCellValue(i, PRECodRubro));
                    enviarInfoGrid.NombreRubro = Convert.ToString(gridView.GetRowCellValue(i, PRENombreRubro));
                    ListaGrid.Add(enviarInfoGrid);
                }

                if (MessageBox.Show("¿Desea Agregar?", "Sistemas", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Guardar = true;
                    this.Close();
                }
                else { Guardar = false; }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        fa_Cliente_Bus busCliente = new fa_Cliente_Bus();
        cp_proveedor_Bus busProveedor = new cp_proveedor_Bus();
        pre_presupuesto_Bus bus = new pre_presupuesto_Bus();
        public pre_presupuesto_Info infoGrid = new pre_presupuesto_Info();
        public pre_presupuesto_Info enviarInfoGrid = new pre_presupuesto_Info();
        public List<pre_presupuesto_Info> ListaGrid = new List<pre_presupuesto_Info>();
        pre_presupuesto_tipoRubro_Bus bustipo = new pre_presupuesto_tipoRubro_Bus();
        ct_Plancta_Bus busPlanCta = new ct_Plancta_Bus();
        pre_presupuesto_tipoRubro_Info infoTipo = new pre_presupuesto_tipoRubro_Info();
        pre_NombreRubro_Info infoNombre = new pre_NombreRubro_Info();
        ct_Centro_costo_Bus busCC = new ct_Centro_costo_Bus();
        private void frmpre_presupuesto_nuevo_Load(object sender, EventArgs e)
        {
            try
            {
                string MensajeError = "";

                List<ct_Plancta_Info> listacta = new List<ct_Plancta_Info>();
                listacta = busPlanCta.Get_List_Plancta(param.IdEmpresa, ref MensajeError);
                listacta.ForEach(x => x.pc_Cuenta="["+x.IdCtaCble+"] "+x.pc_Cuenta);
                GridLookUpEditCtaCtble.DataSource = listacta;
                GridLookUpEditTipoRubro.DataSource = bustipo.Get_List_pre_presupuesto_tipoRubro();


                GridLookUpEditCentroCosto.DataSource = busCC.Get_list_Centro_Costo(param.IdEmpresa, ref MensajeError);
                ListaGrid.Add(infoGrid);
                gridControl.DataSource = ListaGrid;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
        private void gridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                List<pre_NombreRubro_Info> lista = new List<pre_NombreRubro_Info>();
                string tipo = Convert.ToString(gridView.GetFocusedRowCellValue(PREIdTipoRubro));
                if (tipo == "CLIENT")
                {
                    
                }

                
                if (tipo == "SINTIPO")
                {
                    GridLookUpEditNombreRubro.DataSource = lista;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }
        private void gridView_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                List<pre_NombreRubro_Info> lista = new List<pre_NombreRubro_Info>();
                string tipo = Convert.ToString(gridView.GetFocusedRowCellValue(PREIdTipoRubro));
                if (tipo == "CLIENT")
                {
                    
                }

                
                if (tipo == "SINTIPO")
                {
                    GridLookUpEditNombreRubro.DataSource = lista;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void gridTipoRubro_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                infoTipo = GetSelectedRowTIPO((DevExpress.XtraGrid.Views.Grid.GridView)sender);
                if (infoTipo.IdTipoRubro == "CLIENT")
                {
                 //   GridLookUpEditNombreRubro.DataSource = busCliente.ObtenerParaPresupuesto(param.IdEmpresa);
                }
                //if (infoTipo.IdTipoRubro == "PROVE")
                //{
                //    GridLookUpEditNombreRubro.DataSource = busProveedor.ObtenerListProveedorPresupuesto(param.IdEmpresa);
                //}
                if (infoTipo.IdTipoRubro == "SINTIPO")
                {
                    GridLookUpEditNombreRubro.DataSource = null;
                    gridView.SetFocusedRowCellValue(PREIdTipoRubro, infoTipo.IdTipoRubro);
                }
                gridView.SetFocusedRowCellValue(PREIdTipoRubro, infoTipo.IdTipoRubro);
                gridView.SetFocusedRowCellValue(PRECodRubro, "");
                gridView.SetFocusedRowCellValue(PRENombreRubro, "");
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }


        private pre_NombreRubro_Info GetSelectedRowNOMBRE(DevExpress.XtraGrid.Views.Grid.GridView view)
        {
            try
            {
                return (pre_NombreRubro_Info)view.GetRow(view.FocusedRowHandle);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return new pre_NombreRubro_Info();
            }
        }


        private void gridviewNombre_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                infoNombre = GetSelectedRowNOMBRE((DevExpress.XtraGrid.Views.Grid.GridView)sender);
                gridView.SetFocusedRowCellValue(PRECodRubro, infoNombre.Id);
                gridView.SetFocusedRowCellValue(PRENombreRubro, infoNombre.NombreCompleto);
                gridView.SetFocusedRowCellValue(NombreRubro, infoNombre.NombreCompleto);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
        private pre_presupuesto_tipoRubro_Info GetSelectedRowTIPO(DevExpress.XtraGrid.Views.Grid.GridView view)
        {
            try
            {
                return (pre_presupuesto_tipoRubro_Info)view.GetRow(view.FocusedRowHandle);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return new pre_presupuesto_tipoRubro_Info();
            }
        }
        public Boolean Guardar = false; 
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                Guardar = false;
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
    }
}
