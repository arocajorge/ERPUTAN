using Core.Erp.Business.Contabilidad;
using System;
using System.Windows.Forms;
using Core.Erp.Business.General;
namespace Core.Erp.Winform
{

    public partial class Form1 : Form
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                string mensaje = string.Empty;
                ct_Cbtecble_Bus bus_diario = new ct_Cbtecble_Bus();
                ct_Centro_costo_Bus bus_centros = new ct_Centro_costo_Bus();
                var lst_subcentros = bus_centros.Get_list_Centro_Costo(param.IdEmpresa,ref mensaje);
                
            }
            catch (Exception)
            {
                
                throw;
            }    
        }



        
        public Form1()
        {
            InitializeComponent();

           
           
        }


     


        
    }


}
