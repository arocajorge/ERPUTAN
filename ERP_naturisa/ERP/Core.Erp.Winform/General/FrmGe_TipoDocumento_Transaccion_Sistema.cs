using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.General;
using Core.Erp.Business.General;

namespace Core.Erp.Winform.General
{
    public partial class FrmGe_TipoDocumento_Transaccion_Sistema : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        //CJimenez 22.01.14
        tb_Empresa_Bus EmpresaBus = new tb_Empresa_Bus();
        tb_sis_Documento_Tipo_x_Empresa_Bus DocTipoxEmpresaBus = new tb_sis_Documento_Tipo_x_Empresa_Bus();
        tb_sis_tipoDocumento_Bus TipDocBus = new tb_sis_tipoDocumento_Bus();
        tb_sis_tipoDocumento_Info TipoDocInfo = new tb_sis_tipoDocumento_Info();
        tb_sis_Documento_Tipo_x_Empresa_Info TipoDocEmpresaInfo = new tb_sis_Documento_Tipo_x_Empresa_Info();
        BindingList<tb_sis_Documento_Tipo_x_Empresa_Info> DataSource2;
        BindingList<tb_sis_tipoDocumento_Info> DataSource;
        



        public FrmGe_TipoDocumento_Transaccion_Sistema()
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

        void TipoDocMant_Event_FrmGe_TipoDocumento_Mantenimiento_FormClosing(object sender, FormClosingEventArgs e)
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
                if (cmbEmpresa.Text != "" && cmbEmpresa.EditValue != null)
                {
                    gridControlTipoDocumento.DataSource = TipDocBus.Get_List_sis_tipoDocumento(Convert.ToInt32(cmbEmpresa.EditValue));
                    gridControlTipoDocEmpresa.DataSource = DocTipoxEmpresaBus.Get_List_sis_Documento_Tipo_x_Empresa(Convert.ToInt32(cmbEmpresa.EditValue));
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }
        

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbEmpresa.EditValue != null && cmbEmpresa.Text != "")
                {
                    FrmGe_TipoDocumento_Mantenimiento TipoDocMant = new FrmGe_TipoDocumento_Mantenimiento();
                    TipoDocMant._Accion = Cl_Enumeradores.eTipo_action.grabar;
                    TipoDocMant.Event_FrmGe_TipoDocumento_Mantenimiento_FormClosing += new FrmGe_TipoDocumento_Mantenimiento.delegate_FrmGe_TipoDocumento_Mantenimiento_FormClosing(TipoDocMant_Event_FrmGe_TipoDocumento_Mantenimiento_FormClosing);
                    TipoDocMant.Show();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbEmpresa.EditValue != null && cmbEmpresa.Text != "")
                {
                    Get();
                    FrmGe_TipoDocumento_Mantenimiento TipoDocMant = new FrmGe_TipoDocumento_Mantenimiento();
                    TipoDocMant._Accion = Cl_Enumeradores.eTipo_action.actualizar;
                    TipoDocMant.setInfo(TipoDocInfo);
                    TipoDocMant.Event_FrmGe_TipoDocumento_Mantenimiento_FormClosing += new FrmGe_TipoDocumento_Mantenimiento.delegate_FrmGe_TipoDocumento_Mantenimiento_FormClosing(TipoDocMant_Event_FrmGe_TipoDocumento_Mantenimiento_FormClosing);
                    TipoDocMant.Show();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbEmpresa.EditValue != null && cmbEmpresa.Text != "")
                {
                    var _Info = (tb_sis_tipoDocumento_Info)gridViewTipoDocumento.GetFocusedRow();
                    TipoDocEmpresaInfo.IdEmpresa = Convert.ToInt32(cmbEmpresa.EditValue);
                    TipoDocEmpresaInfo.codDocumentoTipo = _Info.IdTipoDocumento;
                    TipoDocEmpresaInfo.ApareceComboFac_Import = "N";
                    TipoDocEmpresaInfo.ApareceComboFac_TipoFact = "N";
                    TipoDocEmpresaInfo.ApareceTalonario = "N";
                    TipoDocEmpresaInfo.ApareceCombo_FileReporte = "N";
                    TipoDocEmpresaInfo.Descripcion = _Info.Descripcion;
                    TipoDocEmpresaInfo.Posicion = 0;
                    DocTipoxEmpresaBus.GuardarDB(TipoDocEmpresaInfo);
                    ActualizarGrid();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_All_Next_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbEmpresa.EditValue != null && cmbEmpresa.Text != "")
                {
                    List<tb_sis_Documento_Tipo_x_Empresa_Info> lst2 = new List<tb_sis_Documento_Tipo_x_Empresa_Info>();
                    int IdEmpresa = Convert.ToInt32(cmbEmpresa.EditValue);
                    List<tb_sis_tipoDocumento_Info> aaaa = (List<tb_sis_tipoDocumento_Info>)this.gridControlTipoDocumento.DataSource;
                    DataSource = new BindingList<tb_sis_tipoDocumento_Info>(aaaa);
                    foreach (var item in DataSource)
                    {
                        TipoDocEmpresaInfo = new tb_sis_Documento_Tipo_x_Empresa_Info();
                        TipoDocEmpresaInfo.IdEmpresa = IdEmpresa;
                        TipoDocEmpresaInfo.codDocumentoTipo = item.IdTipoDocumento;
                        TipoDocEmpresaInfo.ApareceComboFac_Import = "N";
                        TipoDocEmpresaInfo.ApareceComboFac_TipoFact = "N";
                        TipoDocEmpresaInfo.ApareceTalonario = "N";
                        TipoDocEmpresaInfo.ApareceCombo_FileReporte = "N";
                        TipoDocEmpresaInfo.Descripcion = item.Descripcion;
                        TipoDocEmpresaInfo.Posicion = item.Posicion;
                        lst2.Add(TipoDocEmpresaInfo);
                    }
                    DocTipoxEmpresaBus.GuardarDB(lst2);
                    ActualizarGrid();
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Previus_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbEmpresa.EditValue != null && cmbEmpresa.Text != "")
                {
                    var _Info = (tb_sis_Documento_Tipo_x_Empresa_Info)gridViewTipoDocEmpresa.GetFocusedRow();
                    TipoDocEmpresaInfo.IdEmpresa = Convert.ToInt32(cmbEmpresa.EditValue);
                    TipoDocEmpresaInfo.codDocumentoTipo = _Info.codDocumentoTipo;
                    DocTipoxEmpresaBus.EliminarDB(TipoDocEmpresaInfo);
                    ActualizarGrid();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_All_Previus_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbEmpresa.EditValue != null && cmbEmpresa.Text != "")
                {
                    List<tb_sis_Documento_Tipo_x_Empresa_Info> lst2 = new List<tb_sis_Documento_Tipo_x_Empresa_Info>();
                    List<tb_sis_Documento_Tipo_x_Empresa_Info> aaaa = (List<tb_sis_Documento_Tipo_x_Empresa_Info>)this.gridControlTipoDocEmpresa.DataSource;
                    DataSource2 = new BindingList<tb_sis_Documento_Tipo_x_Empresa_Info>(aaaa);
                    foreach (tb_sis_Documento_Tipo_x_Empresa_Info _Info in DataSource2)
                    {
                        TipoDocEmpresaInfo.IdEmpresa = Convert.ToInt32(cmbEmpresa.EditValue);
                        TipoDocEmpresaInfo.codDocumentoTipo = _Info.codDocumentoTipo;
                        TipoDocEmpresaInfo.ApareceComboFac_Import = _Info.ApareceComboFac_Import;
                        TipoDocEmpresaInfo.ApareceComboFac_TipoFact = _Info.ApareceComboFac_TipoFact;
                        TipoDocEmpresaInfo.ApareceTalonario = _Info.ApareceTalonario;
                        TipoDocEmpresaInfo.ApareceCombo_FileReporte = _Info.ApareceCombo_FileReporte;
                        TipoDocEmpresaInfo.Descripcion = _Info.Descripcion;
                        TipoDocEmpresaInfo.Posicion = _Info.Posicion;
                        lst2.Add(TipoDocEmpresaInfo);
                    }
                    DocTipoxEmpresaBus.EliminarDB(lst2);
                    ActualizarGrid();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void load()
        {
            try
            {
                cmbEmpresa.Properties.DataSource = EmpresaBus.Get_List_Empresa();
                cmbEmpresa.EditValue = (((List<tb_Empresa_Info>)cmbEmpresa.Properties.DataSource).First()).IdEmpresa;
                ActualizarGrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }

        private void FrmGe_TipoDocumento_Transaccion_Sistema_Load(object sender, EventArgs e)
        {
            try
            {
                load();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void cmbEmpresa_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbEmpresa.EditValue != null && cmbEmpresa.Text != "")
                {
                    gridControlTipoDocumento.DataSource = TipDocBus.Get_List_sis_tipoDocumento(Convert.ToInt32(cmbEmpresa.EditValue));
                    gridControlTipoDocEmpresa.DataSource = DocTipoxEmpresaBus.Get_List_sis_Documento_Tipo_x_Empresa(Convert.ToInt32(cmbEmpresa.EditValue));
                }
                else
                {
                    gridControlTipoDocumento.DataSource = null;
                    gridControlTipoDocEmpresa.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void Get()
        {
            try
            {
                var _info = (tb_sis_tipoDocumento_Info)gridViewTipoDocumento.GetFocusedRow();
                TipoDocInfo.IdTipoDocumento = _info.IdTipoDocumento;
                TipoDocInfo.Descripcion = _info.Descripcion;
                TipoDocInfo.Posicion = _info.Posicion;
                TipoDocInfo.Estado = _info.Estado;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        
        }

        private void gridViewTipoDocumento_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridViewTipoDocumento.GetRow(e.RowHandle) as tb_sis_tipoDocumento_Info;
                if (data == null)
                    return;
                if (data.Estado == "I")
                    e.Appearance.ForeColor = Color.Red;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewTipoDocEmpresa_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                tb_sis_Documento_Tipo_x_Empresa_Info item = (tb_sis_Documento_Tipo_x_Empresa_Info)gridViewTipoDocEmpresa.GetFocusedRow();
                DocTipoxEmpresaBus.ModificarDB(item);
                ActualizarGrid();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
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
    }
}
