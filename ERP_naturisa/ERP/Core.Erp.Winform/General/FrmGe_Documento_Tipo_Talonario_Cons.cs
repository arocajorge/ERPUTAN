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
    public partial class FrmGe_Documento_Tipo_Talonario_Cons : Form
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();


        tb_sis_Documento_Tipo_Talonario_Bus bus_Talonario = new tb_sis_Documento_Tipo_Talonario_Bus();
        List<tb_sis_Documento_Tipo_Talonario_Info> lista_talonarios = new List<tb_sis_Documento_Tipo_Talonario_Info>();
        tb_sis_Documento_Tipo_Talonario_Info Info_Doc_talonario = new tb_sis_Documento_Tipo_Talonario_Info();
        int conta = 0;
        string TipoDocumento = "";
        bool Es_Documento_Electronico = false;
       

        public FrmGe_Documento_Tipo_Talonario_Cons()
        {
            InitializeComponent();
        }

        

        public FrmGe_Documento_Tipo_Talonario_Cons(string _TipoDocumento, bool _Es_Documento_Electronico)
            : this()
        {
             try
              {
                  TipoDocumento = _TipoDocumento;
                  Es_Documento_Electronico = _Es_Documento_Electronico;
              }
              catch (Exception ex)
              {
                  Log_Error_bus.Log_Error(ex.ToString());
                  MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
              }
            
        }

        
         
        private void FrmGe_Documento_Tipo_Talonario_Cons_Load(object sender, EventArgs e)
        {
            try
            {
                

                lista_talonarios = bus_Talonario.Get_List_Docu_Tipo_Talonario_x_TipoDocu(param.IdEmpresa, TipoDocumento, Es_Documento_Electronico);
                gridControl_Docu_Talonario.DataSource = lista_talonarios;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
          
            }
        }

        public tb_sis_Documento_Tipo_Talonario_Info Get_Info_Talonario_Documentos()
        {
            try
            {
                return Info_Doc_talonario;
            }
            catch (Exception ex)
            {
                
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new tb_sis_Documento_Tipo_Talonario_Info();
            }
        
        
        }


        
        private void gridView_Docu_Talonario_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            
        }

        private void gridView_Docu_Talonario_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                   var data = gridView_Docu_Talonario.GetRow(e.RowHandle) as tb_sis_Documento_Tipo_Talonario_Info;
                if (data == null)
                    return;

                if (data.Usado == true)
                {
                    e.Appearance.ForeColor = Color.Blue;
                    return;
                }

                if (data.Estado == "I")
                {
                    e.Appearance.ForeColor = Color.Red;
                    return;
                }

            }
            catch (Exception ex)
            {
                 Log_Error_bus.Log_Error(ex.ToString());
                 MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridView_Docu_Talonario_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                   Info_Doc_talonario = new tb_sis_Documento_Tipo_Talonario_Info();
                    Info_Doc_talonario = (tb_sis_Documento_Tipo_Talonario_Info)gridView_Docu_Talonario.GetFocusedRow();

                    if (Info_Doc_talonario.Usado == true)
                    {
                        MessageBox.Show("El Documento #: " + Info_Doc_talonario.NumDocumento + " ya fue usado", param.Nombre_sistema);
                        Info_Doc_talonario = new tb_sis_Documento_Tipo_Talonario_Info();
                        return;
                    }


                    if (Info_Doc_talonario.Estado == "I")
                    {
                        MessageBox.Show("El Documento #: " + Info_Doc_talonario.NumDocumento + " esta INACTIVO no se puede Usar", param.Nombre_sistema );
                        Info_Doc_talonario = new tb_sis_Documento_Tipo_Talonario_Info();
                        return;
                    }
                    
                    
                    
                Get_Info_Talonario_Documentos();
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
