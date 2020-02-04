using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Info.Compras;
using Core.Erp.Business.Compras;

using Core.Erp.Info.CuentasxPagar;

namespace Core.Erp.Winform.Compras
{
    public partial class FrmCom_OrdenCompra_x_Detalle_Cons : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        com_ordencompra_local_det_Bus Bus_OCdetalle = new com_ordencompra_local_det_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        List<com_ordencompra_local_det_Info> Lst_OCdetalle = new List<com_ordencompra_local_det_Info>();
        public List<cp_orden_giro_x_com_ordencompra_local_det_Info> List_OG_x_OCdet { get; set; }

        List<cp_orden_giro_x_com_ordencompra_local_det_Info> List_OG_x_OCdet_AUX = new List<cp_orden_giro_x_com_ordencompra_local_det_Info>();

       
        public DateTime FechaIni { get; set; }
        public DateTime FechaFin { get; set; }
        
        
        public FrmCom_OrdenCompra_x_Detalle_Cons()
        {
            InitializeComponent();

            List_OG_x_OCdet = new List<cp_orden_giro_x_com_ordencompra_local_det_Info>();

            ucGe_Menu.event_btnAceptar_Click += ucGe_Menu_event_btnAceptar_Click;
            ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
        }

        void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
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

        void ucGe_Menu_event_btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
               
                List_OG_x_OCdet = List_OG_x_OCdet_AUX;

                Close();               
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);    
            }
        }


        private void cargagrid()
        {
            try
            {
                Lst_OCdetalle = Bus_OCdetalle.Get_List_ordencompra_local_det(param.IdEmpresa);

                if (Lst_OCdetalle.Count !=0)
                {
                    gridControl_OC.DataSource = Lst_OCdetalle;
                }
                gridControl_OC.DataSource = Lst_OCdetalle;
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);    
            }
        }

        private void FrmCom_OrdenCompra_x_Detalle_Cons_Load(object sender, EventArgs e)
        {
            try
            {
                cargagrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);    
              
            }
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            try
            {
               
                FechaIni = dtpFechaIni.Value;
                FechaFin = dtpFechaFin.Value;

                cargagrid();

                if (Lst_OCdetalle.Count() == 0)
                {
                    MessageBox.Show("No existe información para estos filtros", "Sistemas");
                    return;
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);    
            }
        }

        com_ordencompra_local_det_Info Info;

        cp_orden_giro_x_com_ordencompra_local_det_Info info;
        private void gridView_OC_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                  Info = (com_ordencompra_local_det_Info)this.gridView_OC.GetFocusedRow();

                  e.HitInfo.Column.FieldName = gridView_OC.FocusedColumn.FieldName;

                  if (e.HitInfo.Column.FieldName == "Checked")
                  {
                      if ((Boolean)gridView_OC.GetFocusedRowCellValue(colChecked))
                      {
                          gridView_OC.SetFocusedRowCellValue(colChecked, false);

                          var item = List_OG_x_OCdet_AUX.FirstOrDefault(q => q.IdEmpresa_OC == Info.IdEmpresa && q.IdOrdenCompra == Info.IdOrdenCompra && q.IdSucursal_OC == Info.IdSucursal && q.Secuencia_OC == Info.Secuencia);

                          List_OG_x_OCdet_AUX.Remove(item);                                     
                      }
                      else
                      {
                          gridView_OC.SetFocusedRowCellValue(colChecked, true);

                          info= new cp_orden_giro_x_com_ordencompra_local_det_Info();

                          info.IdOrdenCompra=Convert.ToDecimal(gridView_OC.GetFocusedRowCellValue(colIdOrdenCompra));
                          info.IdEmpresa_OC=Convert.ToInt32(gridView_OC.GetFocusedRowCellValue(colIdEmpresa_oc));
                          info.IdSucursal_OC=Convert.ToInt32(gridView_OC.GetFocusedRowCellValue(colIdSucursal_oc));
                          info.Secuencia_OC=Convert.ToInt32(gridView_OC.GetFocusedRowCellValue(colSecuencia_oc));
                          info.IdProducto=Convert.ToDecimal(gridView_OC.GetFocusedRowCellValue(colIdProducto));
                          info.do_Cantidad=Convert.ToDouble(gridView_OC.GetFocusedRowCellValue(coldo_Cantidad));
                          info.do_precioCompra=Convert.ToDouble(gridView_OC.GetFocusedRowCellValue(coldo_precioCompra));
                          info.do_porc_des=Convert.ToDouble(gridView_OC.GetFocusedRowCellValue(coldo_porc_des));
                          info.do_descuento=Convert.ToDouble(gridView_OC.GetFocusedRowCellValue(coldo_descuento));
                          info.do_subtotal=Convert.ToDouble(gridView_OC.GetFocusedRowCellValue(coldo_subtotal));
                          info.do_iva=Convert.ToDouble(gridView_OC.GetFocusedRowCellValue(coldo_iva));
                          info.do_total=Convert.ToDouble(gridView_OC.GetFocusedRowCellValue(coldo_total));
                          info.Observacion=Convert.ToString(gridView_OC.GetFocusedRowCellValue(coldo_observacion));
                          info.IdUnidadMedida=Convert.ToString(gridView_OC.GetFocusedRowCellValue(colIdUnidadMedida));
                          info.producto=Convert.ToString(gridView_OC.GetFocusedRowCellValue(colproducto));
                          info.nom_medida=Convert.ToString(gridView_OC.GetFocusedRowCellValue(colnom_medida));

                          List_OG_x_OCdet_AUX.Add(info);
                      }                                
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
