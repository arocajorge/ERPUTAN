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
    public partial class frmCxc_Cobro_x_Anticipo : Form
    {

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        //CJimenez 24.01.14
        cxc_Cobro_Tipo_x_Anticipo_Bus cTipoAntiBus = new cxc_Cobro_Tipo_x_Anticipo_Bus();
        cxc_cobro_tipo_Bus cTipoBus = new cxc_cobro_tipo_Bus();
        public cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        cxc_Cobro_Tipo_x_Anticipo_Info Info = new cxc_Cobro_Tipo_x_Anticipo_Info();

        List<cxc_Cobro_Tipo_x_Anticipo_Info> lst = new List<cxc_Cobro_Tipo_x_Anticipo_Info>();


        public frmCxc_Cobro_x_Anticipo()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void frmCxc_Cobro_x_Anticipo_Load(object sender, EventArgs e)
        {
            try
            {
                ActualizarGrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                var item = (cxc_cobro_tipo_Info)gridViewTipoCobro.GetFocusedRow();
                Info.IdEmpresa = param.IdEmpresa;
                Info.IdCobro_tipo = item.IdCobro_tipo;
                Info.posicion = 0;
                cTipoAntiBus.GuardarDB(Info);
                ActualizarGrid();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnAllNext_Click(object sender, EventArgs e)
        {
            try
            {
                Transformar();
                cTipoAntiBus.GuardarDB(lst);
                ActualizarGrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnPrevius_Click(object sender, EventArgs e)
        {
            try
            {
                var item = (cxc_Cobro_Tipo_x_Anticipo_Info)gridViewCobroAnticipo.GetFocusedRow();
                Info.IdEmpresa = param.IdEmpresa;
                Info.IdCobro_tipo = item.IdCobro_tipo;
                
                cTipoAntiBus.EliminarDB(Info);
                ActualizarGrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }

        }

        void Transformar()
        {
            try
            {
                var item = (List<cxc_cobro_tipo_Info>)gridViewTipoCobro.DataSource;
                foreach (var a in item)
                {
                    Info = new cxc_Cobro_Tipo_x_Anticipo_Info();
                    Info.IdEmpresa = param.IdEmpresa;
                    Info.IdCobro_tipo = a.IdCobro_tipo;
                    Info.posicion = 0;
                    lst.Add(Info);
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAllPrevius_Click(object sender, EventArgs e)
        {
            try
            {
                Transformar();
                cTipoAntiBus.EliminarLista(param.IdEmpresa, lst.Count);
                ActualizarGrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void gridViewCobroAnticipo_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                cxc_Cobro_Tipo_x_Anticipo_Info item = (cxc_Cobro_Tipo_x_Anticipo_Info)gridViewCobroAnticipo.GetFocusedRow();
                cTipoAntiBus.ModificarDB(item);
                ActualizarGrid();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
