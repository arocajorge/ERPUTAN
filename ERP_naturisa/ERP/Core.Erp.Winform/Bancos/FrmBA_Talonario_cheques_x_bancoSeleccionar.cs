using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Winform.Controles;
using Core.Erp.Business.General;
using Core.Erp.Info.Bancos;
using Core.Erp.Business.Bancos;
using Core.Erp.Business.General;
using Core.Erp.Winform.General;
using Core.Erp.Info.General;

namespace Core.Erp.Winform.Bancos
{
    public partial class FrmBA_Talonario_cheques_x_bancoSeleccionar : Form
    {
        #region Declaración de Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        ba_Talonario_cheques_x_banco_Info Info = new ba_Talonario_cheques_x_banco_Info();
        ba_Talonario_cheques_x_banco_Bus bus = new ba_Talonario_cheques_x_banco_Bus();
        BindingList<ba_Talonario_cheques_x_banco_Info> lista = new BindingList<ba_Talonario_cheques_x_banco_Info>();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        public string num_cheque{ get; set; }
        public int IdBanco;
        #endregion

        public FrmBA_Talonario_cheques_x_bancoSeleccionar(int idBanco)
        {
            IdBanco = idBanco;
            InitializeComponent();


        }


                
        private void gridViewClaveCont_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            
            try
            {
                Info = (ba_Talonario_cheques_x_banco_Info)gridViewtalonario.GetFocusedRow();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void cargardata()
        {
            try
            {
                string msg = "";

                lista = new BindingList<ba_Talonario_cheques_x_banco_Info>(bus.Get_List_Talonario_cheques_x_banco(param.IdEmpresa,IdBanco, ref msg));
                
                if (lista.Count > 0)
                {
                                     
                    gridControltalonario.DataSource = lista;
                }
                else
                {
                    MessageBox.Show("No registros que mostrar" + msg, "Efirm", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    gridControltalonario.DataSource = null;
                    gridControltalonario.RefreshDataSource();
                }


            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
                    

        private void FrmBA_Talonario_cheques_x_bancoConsulta_Load(object sender, EventArgs e)
        {
            try
            {
                cargardata();

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }



        private ba_Talonario_cheques_x_banco_Info GetSelectedRow(DevExpress.XtraGrid.Views.Grid.GridView view)
        {

            try
            {
                return (ba_Talonario_cheques_x_banco_Info)view.GetRow(view.FocusedRowHandle);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new ba_Talonario_cheques_x_banco_Info();
            }
        }

        private void gridViewtalonario_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                Info = GetSelectedRow((DevExpress.XtraGrid.Views.Grid.GridView)sender);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void gridViewtalonario_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridViewtalonario.GetRow(e.RowHandle) as ba_Talonario_cheques_x_banco_Info;
                if (data == null)
                    return;
                if (data.Usado== true || data.Estado=="I")
                    e.Appearance.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void gridViewtalonario_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                Info = (ba_Talonario_cheques_x_banco_Info)gridViewtalonario.GetFocusedRow();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void gridControltalonario_DoubleClick(object sender, EventArgs e)
        {
            if (Info.Usado == false)
            {
                this.num_cheque = Info.Num_cheque;
            }
            else
            {
                this.num_cheque = "";
                MessageBox.Show("Cheque en uso, Valor de numero de cheque que obtendra sera: (vacio)", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Close();

        }



        private void btnSeleccionar_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {

        }

        private void gridControltalonario_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (Info.Usado == false)
            {
                this.num_cheque = Info.Num_cheque;
            }
            else
            {
                this.num_cheque = "";
                MessageBox.Show("Cheque en uso, Valor de numero de cheque que obtendra sera: (vacio)", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Close();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.num_cheque = "";
            MessageBox.Show("No ha seleccionado cheque, Valor de numero de cheque que obtendra sera: (vacio)", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Close();
        }


    }
}
