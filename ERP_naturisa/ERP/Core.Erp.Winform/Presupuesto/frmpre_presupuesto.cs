using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.Presupuesto;
using Core.Erp.Business.General;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Business.Facturacion;
using Core.Erp.Business.CuentasxPagar;
using Core.Erp.Info.Presupuesto;
using Core.Erp.Info.Contabilidad;

namespace Core.Erp.Winform.Presupuesto
{
    public partial class frmpre_presupuesto : Form
    {//08052013

        string MensajeError = "";
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        fa_Cliente_Bus busCliente = new fa_Cliente_Bus();
        cp_proveedor_Bus busProveedor = new cp_proveedor_Bus();
        pre_presupuesto_Bus bus = new pre_presupuesto_Bus();
        pre_presupuesto_Info infoGrid = new pre_presupuesto_Info();
        pre_presupuesto_tipoRubro_Bus bustipo = new pre_presupuesto_tipoRubro_Bus();
        ct_Plancta_Bus busPlanCta = new ct_Plancta_Bus();
        pre_presupuesto_tipoRubro_Info infoTipo = new pre_presupuesto_tipoRubro_Info();
        pre_NombreRubro_Info infoNombre = new pre_NombreRubro_Info();
        ct_Centro_costo_Bus busCC = new ct_Centro_costo_Bus();
        List<ct_Centro_costo_Info> LstCentroCosto = new List<ct_Centro_costo_Info>();
        

        public frmpre_presupuesto()
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
        

        private void frmpre_presupuesto_Load(object sender, EventArgs e)
        {
            try
            {
                ct_Periodo_Bus busperiodo = new ct_Periodo_Bus();
                ultraCmb_Ano.Properties.DataSource = busperiodo.Get_List_Periodo(param.IdEmpresa, ref   MensajeError);
                ultraCmb_Ano.Properties.DisplayMember = "IdanioFiscal";
                ultraCmb_Ano.Properties.ValueMember = "IdanioFiscal";
                ultraCmb_Ano.EditValue = DateTime.Now.Year;
                ultraCmb_Presupuesto.Properties.DataSource = bus.Get_List_pre_presupuest(param.IdEmpresa, Convert.ToString(ultraCmb_Ano.EditValue));
                ultraCmb_Presupuesto.Properties.DisplayMember = "IdPresupuesto";
                ultraCmb_Presupuesto.Properties.ValueMember = "IdPresupuesto";
                ultraCmb_Presupuesto.EditValue = DateTime.Now.Year * 100 + 1;
                txtIdPresupuesto.Text=Convert.ToString(DateTime.Now.Year * 100 + 1);
                List<ct_Plancta_Info> listacta = new List<ct_Plancta_Info>();


                listacta = busPlanCta.Get_List_Plancta(param.IdEmpresa, ref MensajeError);
                listacta.ForEach(x => x.pc_Cuenta="["+x.IdCtaCble+"] "+x.pc_Cuenta);



                LstCentroCosto = busCC.Get_list_Centro_Costo(param.IdEmpresa, ref MensajeError);
                
                if(LstCentroCosto.Count==0)
                    MessageBox.Show("Se le informa que no podra Grabar debido a que no tiene ingresado Centro de Costo.. \nIngréselos desde el modulo de Contabilidad, o comuníquese con sistemas", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                GridLookUpEditCtaCtble.DataSource = listacta;
                GridLookUpEditTipoRubro.DataSource = bustipo.Get_List_pre_presupuesto_tipoRubro();
                GridLookUpEditCentroCosto.DataSource = LstCentroCosto;

                btnCargar_Click(new object(), new EventArgs());
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                chConValores.Checked = false;
                gridControl.DataSource = bus.Get_List_pre_presupuesto_x_cta(param.IdEmpresa, Convert.ToString(ultraCmb_Ano.EditValue), Convert.ToDecimal(txtIdPresupuesto.Text));//Convert.ToDecimal(ultraCmb_Presupuesto.Value));
                getGrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void GridLookUpEditTipoRubro_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                
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
                    
                }
                
                gridView.SetFocusedRowCellValue(PREIdTipoRubro, infoTipo.IdTipoRubro);
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
        private pre_presupuesto_Info GetSelectedRow(DevExpress.XtraGrid.Views.Grid.GridView view)
        {
            try
            {
                return (pre_presupuesto_Info)view.GetRow(view.FocusedRowHandle);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return new pre_presupuesto_Info();
            }
        }

        private void gridviewNombre_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                infoNombre = GetSelectedRowNOMBRE((DevExpress.XtraGrid.Views.Grid.GridView)sender);
                gridView.SetFocusedRowCellValue(PRECodRubro, infoNombre.Id);
                gridView.SetFocusedRowCellValue(PRENombreRubro, infoNombre.NombreCompleto);

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
                List<pre_NombreRubro_Info>  lista = new List<pre_NombreRubro_Info>();
                string tipo =Convert.ToString(gridView.GetFocusedRowCellValue(PREIdTipoRubro));
                if (tipo == "CLIENT") 
                {
                    //GridLookUpEditNombreRubro.DataSource = busCliente.ObtenerParaPresupuesto(param.IdEmpresa); 
                }
                
                if (tipo == "SINTIPO")
                {
                    GridLookUpEditNombreRubro.DataSource = lista;
                }
                infoGrid = GetSelectedRow((DevExpress.XtraGrid.Views.Grid.GridView)sender);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        public List<pre_presupuesto_Info> getGrid(){
            try
            {
                List<pre_presupuesto_Info> lista = new List<pre_presupuesto_Info>();
                string COD="";
                for (int i = 0; i < gridView.RowCount; i++)
                {
                    pre_presupuesto_Info info = new pre_presupuesto_Info();

                    
                    COD=txtIdPresupuesto.Text+"-"+Convert.ToString(gridView.GetRowCellValue(i, PREIdCtaCble))+"-"+Convert.ToString(gridView.GetRowCellValue(i, PREIdCentroCosto))+"-"+Convert.ToString(gridView.GetRowCellValue(i, PREIdTipoRubro));
                    info.CodRubro = Convert.ToString(gridView.GetRowCellValue(i, PRECodRubro));

                    info.CodigoPresupuesto = (Convert.ToString(gridView.GetRowCellValue(i, PRECodigoPresupuesto))== "") ? COD : Convert.ToString(gridView.GetRowCellValue(i, PRECodigoPresupuesto));

                    info.IdAnio = Convert.ToString(ultraCmb_Ano.EditValue);
                    info.IdCentroCosto = Convert.ToString(gridView.GetRowCellValue(i, PREIdCentroCosto));
                    info.IdCtaCble = Convert.ToString(gridView.GetRowCellValue(i, PREIdCtaCble));
                    info.IdEmpresa = param.IdEmpresa;
                    //info.IdPresupuesto = Convert.ToDecimal(ultraCmb_Presupuesto.Value);
                    info.IdPresupuesto = Convert.ToDecimal(txtIdPresupuesto.Text);
                    info.IdTipoRubro = Convert.ToString(gridView.GetRowCellValue(i, PREIdTipoRubro));
                    info.NombreRubro = Convert.ToString(gridView.GetRowCellValue(i, PRENombreRubro));

                    info.Enero = Convert.ToDouble(gridView.GetRowCellValue(i, colEnero));
                    info.febrero= Convert.ToDouble(gridView.GetRowCellValue(i, colfebrero));
                    info.Marzo = Convert.ToDouble(gridView.GetRowCellValue(i, colMarzo));
                    info.Abril = Convert.ToDouble(gridView.GetRowCellValue(i, colAbril));
                    info.Mayo = Convert.ToDouble(gridView.GetRowCellValue(i, colMayo));
                    info.Junio = Convert.ToDouble(gridView.GetRowCellValue(i, colJunio));
                    info.Julio = Convert.ToDouble(gridView.GetRowCellValue(i, colJulio));
                    info.Agosto = Convert.ToDouble(gridView.GetRowCellValue(i, colAgosto));
                    info.Septiembre = Convert.ToDouble(gridView.GetRowCellValue(i, colSeptiembre));
                    info.Octubre = Convert.ToDouble(gridView.GetRowCellValue(i, colOctubre));
                    info.Noviembre = Convert.ToDouble(gridView.GetRowCellValue(i, colNoviembre));
                    info.Diciembre = Convert.ToDouble(gridView.GetRowCellValue(i, colDiciembre));
                    info.Secuencia = Convert.ToInt32(gridView.GetRowCellValue(i, PRESecuencia));
                    info.Total= info.Enero+info.febrero + info.Marzo+info.Abril +info.Mayo+ info.Junio + info.Julio+ info.Agosto+info.Septiembre+ info.Octubre+info.Noviembre+info.Diciembre;
                    //
                    gridView.SetRowCellValue(i, colTotal,info.Total);
                    //
                  //if (Convert.ToBoolean(gridView.GetRowCellValue(i, check)) && info.IdCentroCosto != "" && info.IdCtaCble != "" && info.IdTipoRubro != "")
                    if (Convert.ToBoolean(gridView.GetRowCellValue(i, check)) &&  info.IdCtaCble != "" && info.IdTipoRubro!="")
                    {
                        lista.Add(info);
                        gridView.SetRowCellValue(i, check, false);
                    }
                }
                return lista;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return new List<pre_presupuesto_Info>();
            }
        }

        private void btn_grabar_Click(object sender, EventArgs e)
        {
            try
            {
                txtFocus.Focus();
                if (LstCentroCosto.Count != 0)
                {
                    if (bus.ModificarDB(param.IdEmpresa, getGrid()))
                    {
                        MessageBox.Show("Guardado OK", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                    MessageBox.Show("No se puede Grabar debido a que no tiene ingresado Centro de Costo.. \nIngréselos desde el modulo de Contabilidad, o comuníquese con sistemas", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void gridView_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
               gridView.SetFocusedRowCellValue( check,true);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void gridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                //if (!Convert.ToBoolean(gridView.GetFocusedRowCellValue(check)))
                //{
                //gridView.SetFocusedRowCellValue(check, true);}
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
        
        private void gridControl_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right)
            {
                Point p = new Point(e.X, e.Y);
                if (infoGrid != null)
                {
                    menuTipo.Show(gridControl, p);
                }
            }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void gridView_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                //if (e.Button == MouseButtons.Right)
                //{
                //    Point p = new Point(e.X, e.Y);
                //    if (infoGrid != null)
                //    {
                //        menuTipo.Show(gridControl, p);
                        
                //    }
                //}
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
        int focus = 0;

        private void nuevoRubroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmpre_presupuesto_nuevo frm = new frmpre_presupuesto_nuevo();
                infoGrid.CodRubro = "";
                infoGrid.NombreRubro = "";
                frm.infoGrid = infoGrid;
                frm.ShowDialog();
                focus=gridView.FocusedRowHandle;
                foreach (var item in frm.ListaGrid)
                {
                    item.IdAnio = Convert.ToString(ultraCmb_Ano.EditValue);
                    //item.IdPresupuesto = Convert.ToDecimal(ultraCmb_Presupuesto.Value);
                    item.IdPresupuesto = Convert.ToDecimal(txtIdPresupuesto.Text);
                }
                if(frm.Guardar){
                guardar(frm.ListaGrid);}
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void guardar(List<pre_presupuesto_Info> lista)
        {
            try
            {
                bus.GuardarDB(param.IdEmpresa, lista);
                //btnCargar_Click(new object(),new EventArgs());
                gridView.FocusedRowHandle = focus+2;
                gridView.FocusedRowHandle = focus + 1;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void chConValores_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chConValores.Checked)
                {
                gridControl.DataSource = ((List<pre_presupuesto_Info>)gridControl.DataSource).Where(q => q.Total > 0);}else{
                    btnCargar_Click(new object(), new EventArgs());
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        //private void ultraCmb_Ano_Validating(object sender, CancelEventArgs e)
        //{
        //    try
        //    {
        //        if (this.ultraCmb_Ano.SelectedItem == null)
        //        {
        //            ultraCmb_Ano.Value = DateTime.Now.Year;
        //            return;
        //        } txtIdPresupuesto.Text = ultraCmb_Ano.Value.ToString() + "01";
        //        ultraCmb_Presupuesto.Text = "";
        //        ultraCmb_Presupuesto.DataSource = bus.obtenerParaCombo(param.IdEmpresa, Convert.ToString(ultraCmb_Ano.Value));
        //        ultraCmb_Presupuesto.DisplayMember = "IdPresupuesto";
        //        ultraCmb_Presupuesto.ValueMember = "IdPresupuesto";
        //        ultraCmb_Presupuesto.SelectedIndex = 0;
        //    }
        //    catch (Exception ex)
        //    {
        //        Log_Error_bus.Log_Error(ex.ToString());
        //    }
        //}

        //private void ultraCmb_Presupuesto_Validating(object sender, CancelEventArgs e)
        //{
        //    try
        //    {
        //        if (this.ultraCmb_Presupuesto.SelectedItem == null)
        //        {
        //            ultraCmb_Presupuesto.Value = "";
        //            return;
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        Log_Error_bus.Log_Error(ex.ToString());
        //    }
        //}

        private void btn_grabarysalir_Click(object sender, EventArgs e)
        {
            try
            {
                btn_grabar_Click(sender,e);
                if(MessageBox.Show("¿Desea Salir?","Sistema",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation)==DialogResult.Yes){
                this.Close();
                }
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
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        //private void ultraCmb_Ano_SelectionChangeCommitted(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        ultraCmb_Presupuesto.Text = "";
        //        btnCargar_Click(sender, e);
        //    }
        //    catch (Exception ex)
        //    {
        //        Log_Error_bus.Log_Error(ex.ToString());
        //    }
        //}

        private void ultraCmb_Ano_Validating_1(object sender, CancelEventArgs e)
        {
            try
            {
                if (this.ultraCmb_Ano.EditValue == null)
                {
                    ultraCmb_Ano.EditValue = DateTime.Now.Year;
                    return;
                } txtIdPresupuesto.Text = ultraCmb_Ano.EditValue.ToString() + "01";
                ultraCmb_Presupuesto.Text = "";
                ultraCmb_Presupuesto.Properties.DataSource = bus.Get_List_pre_presupuest(param.IdEmpresa, Convert.ToString(ultraCmb_Ano.EditValue));
                ultraCmb_Presupuesto.Properties.DisplayMember = "IdPresupuesto";
                ultraCmb_Presupuesto.Properties.ValueMember = "IdPresupuesto";
                ultraCmb_Presupuesto.EditValue = 0;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void ultraCmb_Ano_EditValueChanged(object sender, EventArgs e)
        {

            try
            {
                ultraCmb_Presupuesto.Text = "";
                btnCargar_Click(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void ultraCmb_Presupuesto_Validating_1(object sender, CancelEventArgs e)
        {
            try
            {
                if (this.ultraCmb_Presupuesto.EditValue == null)
                {
                    ultraCmb_Presupuesto.EditValue = "";
                    return;
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

    }
}
