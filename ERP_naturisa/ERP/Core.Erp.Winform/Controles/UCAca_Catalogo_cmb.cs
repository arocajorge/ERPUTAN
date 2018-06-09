using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Info.Academico;
using Core.Erp.Business.Academico;
using Core.Erp.Business.General;
using Core.Erp.Winform.Academico;
using Core.Erp.Info.General;

namespace Core.Erp.Winform.Controles
{
    public partial class UCAca_Catalogo_cmb : UserControl
    {
        #region Variables
        List<Aca_Catalogo_Info> list_catalogo = new List<Aca_Catalogo_Info>();
        Aca_Catalogo_Bus bus_catalogo = new Aca_Catalogo_Bus();
        Aca_Catalogo_Info info_catalogo = new Aca_Catalogo_Info();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        string IdCatalogoTipo = "";
        #endregion

        public UCAca_Catalogo_cmb()
        {
            InitializeComponent();
        }

        public void Set_info_catalogo(string IdCatalogo)
        {
            try
            {
                cmb_catalogo_aca.EditValue = IdCatalogo == "" ? null : IdCatalogo;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }    
        }

        public Aca_Catalogo_Info Get_info_catalogo()
        {
            try
            {
                if (cmb_catalogo_aca.EditValue == null) 
                    return null;
                else
                {
                    Get_catalogo_info();
                    return info_catalogo;
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return null;
            }   
        }

        public void cargar_combos(string _IdCatalogoTipo)
        {
            try
            {
                IdCatalogoTipo = _IdCatalogoTipo;
                list_catalogo = bus_catalogo.Get_List_CatalogoXtipo(IdCatalogoTipo);
                cmb_catalogo_aca.Properties.DataSource = list_catalogo;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }      
        }

        private void ddb_Menu_Click(object sender, EventArgs e)
        {
            try
            {
                Menu.Show(ddb_Menu,new Point(ddb_Menu.Height));
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }      
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            try
            {
                Llamar_pantalla(Cl_Enumeradores.eTipo_action.grabar);  
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }   
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_catalogo_aca.EditValue == "")
                {
                    MessageBox.Show("Seleccione un registro", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                Llamar_pantalla(Cl_Enumeradores.eTipo_action.actualizar);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }  
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_catalogo_aca.EditValue == "")
                {
                    MessageBox.Show("Seleccione un registro",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    return;
                }
                Llamar_pantalla(Cl_Enumeradores.eTipo_action.consultar);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }  
        }

        private void Llamar_pantalla(Cl_Enumeradores.eTipo_action _Accion)
        {
            try
            {
                FrmAcaCatalogo_Mant frm = new FrmAcaCatalogo_Mant();
                frm.Set_Accion(_Accion);
                if (_Accion != Cl_Enumeradores.eTipo_action.grabar)
                {
                    Get_catalogo_info();
                    frm.Set_Info(info_catalogo);
                }
                frm.ShowDialog();
                cargar_combos(IdCatalogoTipo);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }  
        }

        private void Get_catalogo_info()
        {
            try
            {
                info_catalogo = list_catalogo.FirstOrDefault(q => q.IdCatalogo == cmb_catalogo_aca.EditValue.ToString());
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
