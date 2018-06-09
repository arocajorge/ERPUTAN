using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Winform.Controles;
using Core.Erp.Business.Inventario;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Reports.Inventario;
using Core.Erp.Winform.General;


namespace Core.Erp.Winform.Inventario
{
    public partial class FrmIn_Ingreso_x_Orden_compra_Mant : Form
    {

        public delegate void Delegate_FrmIn_Ingreso_x_Orden_compra_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event Delegate_FrmIn_Ingreso_x_Orden_compra_Mant_FormClosing Event_FrmIn_Ingreso_x_Orden_compra_Mant_FormClosing;

        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();


        public FrmIn_Ingreso_x_Orden_compra_Mant()
        {
            InitializeComponent();
        }

        public Cl_Enumeradores.eTipo_action _Accion { get; set; }



        public void set_Accion(Cl_Enumeradores.eTipo_action iAccion)
        {
            _Accion = iAccion;

        }

        public void set_Info(vwIn_Movi_Inven_x_Ing_x_OC_Info Info)
        { 
        
        
        }


        private void FrmIn_Ingreso_x_Orden_compra_Mant_Load(object sender, EventArgs e)
        {

        }

        private void FrmIn_Ingreso_x_Orden_compra_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Event_FrmIn_Ingreso_x_Orden_compra_Mant_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
    }
}
