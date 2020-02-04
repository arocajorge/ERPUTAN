using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.CuentasxCobrar;
using Core.Erp.Business.CuentasxCobrar;
using Core.Erp.Business.General;
using Core.Erp.Info.General;

namespace Core.Erp.Winform.CuentasxCobrar
{
    public partial class frmCxc_Confi_Cobro_Tipo_Pantalla : Form
    {
        # region 'Declaracion de Variables'
        

        cxc_Cobro_Tipo_x_Anticipo_Bus cTipoAntiBus = new cxc_Cobro_Tipo_x_Anticipo_Bus();
        cxc_cobro_tipo_Bus cTipoBus = new cxc_cobro_tipo_Bus();
        public cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        cxc_Cobro_Tipo_x_Anticipo_Info InfoAnti = new cxc_Cobro_Tipo_x_Anticipo_Info();
        cxc_cobro_tipo_x_cobros_Docxc_Info InfoDoc = new cxc_cobro_tipo_x_cobros_Docxc_Info();

        List<cxc_Cobro_Tipo_x_Anticipo_Info> lstAnt = new List<cxc_Cobro_Tipo_x_Anticipo_Info>();
        List<cxc_cobro_tipo_x_cobros_Docxc_Info> lstDoc = new List<cxc_cobro_tipo_x_cobros_Docxc_Info>();

        cxc_cobro_tipo_x_cobros_Docxc_Bus cTipoDocBus = new cxc_cobro_tipo_x_cobros_Docxc_Bus();
        BindingList<cxc_cobro_tipo_x_cobros_Docxc_Info> bindDoc;

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje;
        #endregion

        public frmCxc_Confi_Cobro_Tipo_Pantalla()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        

        void ActualizarGrid()
        {
            try
            {
                gridControlTipoCobro.DataSource = cTipoBus.Get_List_Cobro_Tipo_x_Anticipo(param.IdEmpresa);
                gridControlCobroAnticipo.DataSource = cTipoAntiBus.Get_List_Cobro_Tipo_x_Anticipo(param.IdEmpresa);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        void ActualizarGridDoc()
        {
            try
            {
                bindDoc = new BindingList<cxc_cobro_tipo_x_cobros_Docxc_Info>(cTipoDocBus.ObtenerLista(ref mensaje));
                gridControlTipoCobro2.DataSource = cTipoBus.Get_List_Cobro_Tipo_Documento();
                gridControlTipoCobroDoc.DataSource = bindDoc;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                var item = (cxc_cobro_tipo_Info)gridViewTipoCobro.GetFocusedRow();
                InfoAnti.IdEmpresa = param.IdEmpresa;
                InfoAnti.IdCobro_tipo = item.IdCobro_tipo;
                InfoAnti.posicion = 0;
                cTipoAntiBus.GuardarDB(InfoAnti);
                ActualizarGrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnAllNext_Click(object sender, EventArgs e)
        {
            try
            {
                Transformar();
                cTipoAntiBus.GuardarDB(lstAnt);
                ActualizarGrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnPrevius_Click(object sender, EventArgs e)
        {
            try
            {
                var item = (cxc_Cobro_Tipo_x_Anticipo_Info)gridViewCobroAnticipo.GetFocusedRow();
                InfoAnti.IdEmpresa = param.IdEmpresa;
                InfoAnti.IdCobro_tipo = item.IdCobro_tipo;
                
                cTipoAntiBus.EliminarDB(InfoAnti);
                ActualizarGrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }

        }

        void Transformar()
        {
            try
            {
                var item = (List<cxc_cobro_tipo_Info>)gridViewTipoCobro.DataSource;
                foreach (var a in item)
                {
                    InfoAnti = new cxc_Cobro_Tipo_x_Anticipo_Info();
                    InfoAnti.IdEmpresa = param.IdEmpresa;
                    InfoAnti.IdCobro_tipo = a.IdCobro_tipo;
                    InfoAnti.posicion = 0;
                    lstAnt.Add(InfoAnti);
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAllPrevius_Click(object sender, EventArgs e)
        {
            try
            {
                cTipoAntiBus.EliminarLista(param.IdEmpresa, lstAnt.Count);
                ActualizarGrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void gridViewCobroAnticipo_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                if (colposicion == gridViewCobroAnticipo.FocusedColumn)
                {
                    cxc_Cobro_Tipo_x_Anticipo_Info item = (cxc_Cobro_Tipo_x_Anticipo_Info)gridViewCobroAnticipo.GetFocusedRow();
                    cTipoAntiBus.ModificarDB(item);
                    ActualizarGrid();
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmCxc_Confi_Cobro_Tipo_Pantalla_Load(object sender, EventArgs e)
        {
            try
            {
                ActualizarGrid();
                ActualizarGridDoc();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #region Asignacion de documento por cobrar

        void TransformarDOC()
        {
            try
            {
                var item = (List<cxc_cobro_tipo_Info>)gridViewTipoCobro2.DataSource;
                foreach (var a in item)
                {
                    InfoDoc = new cxc_cobro_tipo_x_cobros_Docxc_Info();
                    InfoDoc.IdCobro_tipo = a.IdCobro_tipo;
                    InfoDoc.Posicion = 0;
                    lstDoc.Add(InfoDoc);
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnNextDoc_Click(object sender, EventArgs e)
        {
            try
            {
                var item = (cxc_cobro_tipo_Info)gridViewTipoCobro2.GetFocusedRow();
                InfoDoc.IdCobro_tipo = item.IdCobro_tipo;
                InfoDoc.Posicion = 0;
                cTipoDocBus.Guardar(InfoDoc);
                ActualizarGridDoc();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAllNextDoc_Click(object sender, EventArgs e)
        {
            try
            {
                TransformarDOC();
                cTipoDocBus.GuardarLista(lstDoc);
                ActualizarGridDoc();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnPreviusDoc_Click(object sender, EventArgs e)
        {
            try
            {
                var item = (cxc_cobro_tipo_x_cobros_Docxc_Info)gridViewTipoCobroDoc.GetFocusedRow();
                InfoDoc.IdCobro_tipo = item.IdCobro_tipo;
                cTipoDocBus.Eliminar(InfoDoc);

                ActualizarGridDoc();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnAllPreviusDoc_Click(object sender, EventArgs e)
        {
            try
            {
                cTipoDocBus.EliminarLista(new List<cxc_cobro_tipo_x_cobros_Docxc_Info>(bindDoc));
                ActualizarGridDoc();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void gridViewTipoCobroDoc_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                if (colPosicionDoc == gridViewTipoCobroDoc.FocusedColumn)
                {
                    cxc_cobro_tipo_x_cobros_Docxc_Info item = (cxc_cobro_tipo_x_cobros_Docxc_Info)gridViewTipoCobroDoc.GetFocusedRow();
                    cTipoDocBus.Modificar(item);
                    ActualizarGridDoc();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        

    }
}
