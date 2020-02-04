using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.General;
using Core.Erp.Info.General;


namespace Core.Erp.Winform.Controles
{
    public partial class UCGe_EmpresaListChecked : UserControl
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        public UCGe_EmpresaListChecked()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        private List<tb_Empresa_Info> _listEmpresaSelected ;



        public List<tb_Empresa_Info> getListEmpresaSelected()
        {

            try
            {
                _listEmpresaSelected = new List<tb_Empresa_Info>();


                foreach (var item in this.checkListEmpresas.CheckedItems)
                {
                    tb_Empresa_Info itemxPer = (tb_Empresa_Info)item;

                    _listEmpresaSelected.Add(itemxPer);
                }



                return _listEmpresaSelected;

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new List<tb_Empresa_Info>();  
            }
        }

      

        private void CheckedList_Empresa(Boolean valor)
        {
            try
            {
                
            for (int i = 0; i < checkListEmpresas.Items.Count; i++)
            {
                checkListEmpresas.SetItemChecked(i, valor);
            }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }


        private void LoadEmpresa()
        {
            try
            {
                CheckedList_Empresa(false);

                tb_Empresa_Bus EmpreBu = new tb_Empresa_Bus();
                List<tb_Empresa_Info> lEmpresa = new List<tb_Empresa_Info>();

                lEmpresa = EmpreBu.Get_List_Empresa();

                checkListEmpresas.DataSource = lEmpresa;
                checkListEmpresas.DisplayMember = "em_nombre";
                checkListEmpresas.ValueMember = "idempresa";

                selectIdEmpresa(param.IdEmpresa);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }


        private void selectIdEmpresa(int idEmpresa)
        {
            try
            {
              for (int i = 0; i < this.checkListEmpresas.Items.Count; i++)
                {


                    tb_Empresa_Info itemxPer = (tb_Empresa_Info)checkListEmpresas.Items[i];

                    if (itemxPer.IdEmpresa == idEmpresa)
                    {
                        checkListEmpresas.SetItemChecked(i, true);
                    }

                }

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
     

        }

        private void chkTodos_Click(object sender, EventArgs e)
        {
            try
            {
                if (chkTodos.Checked == true)
                {
                    CheckedList_Empresa(true);
                }
                else
                {
                    CheckedList_Empresa(false);
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }


        }

        private void checkListEmpresas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UCGe_EmpresaListChecked_Load(object sender, EventArgs e)
        {

            try
            {
                LoadEmpresa();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }



    }
}
