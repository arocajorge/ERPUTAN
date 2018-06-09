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
using Core.Erp.Info.SeguridadAcceso;
using Core.Erp.Business.SeguridadAcceso;
using Core.Erp.Info.Facturacion_FJ;
using Core.Erp.Business.Facturacion_FJ;


namespace Core.Erp.Winform
{
    public partial class Form2 : Form
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        Cl_Enumeradores.eTipo_action Accion = new Cl_Enumeradores.eTipo_action();

        
                            
        public Form2()
        {
            InitializeComponent();

        }

        
        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {

                ucFa_Equipos_Graf1.Cargar_Combo();

            }
            catch (Exception ex)
            {
                
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                string mensaje = "";
                decimal IdCbteVta = 0;
                fa_liquidacion_gastos_Bus Bus_liqui_ga = new fa_liquidacion_gastos_Bus();
                List<fa_liquidacion_gastos_Info> lista = new List<fa_liquidacion_gastos_Info>();
                lista = Bus_liqui_ga.Get_List_Liquidacion_Gastos(1, DateTime.Now.AddMonths(-10), DateTime.Now.AddMonths(10), ref mensaje);


                foreach (fa_liquidacion_gastos_Info item in lista)
                {
                    Bus_liqui_ga.Convert_Liquidacion_a_Factura(item.IdEmpresa, item.IdLiquidacion, ref IdCbteVta, ref mensaje);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       

    }
}

       

       

       
    

