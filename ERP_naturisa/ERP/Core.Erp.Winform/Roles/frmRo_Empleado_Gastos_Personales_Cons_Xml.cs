using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.Roles;
using Core.Erp.Business.General;
//Gastos Personales
//Derek Mejía Soria
//ultima modificacion : 08/01/2014
namespace Core.Erp.Winform.Roles
{
    public partial class frmRo_Empleado_Gastos_Personales_Cons_Xml : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        public List<ro_empleado_gastos_perso_Info> SETINFO_{ get; set; }
        public frmRo_Empleado_Gastos_Personales_Cons_Xml()
        {
            try
            {
                 InitializeComponent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }

        private void frmRo_Empleado_Gastos_Personales_Cons_Xml_Load(object sender, EventArgs e)
        {
            try
            {
                BindingList<ro_empleado_gastos_perso_Info> bl = new BindingList<ro_empleado_gastos_perso_Info>(SETINFO_);
                gridControlXmlError.DataSource = bl;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }            
        }


    }
}
