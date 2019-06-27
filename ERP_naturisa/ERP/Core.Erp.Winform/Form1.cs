using Core.Erp.Business.Contabilidad;
using System;
using System.Windows.Forms;
using Core.Erp.Business.General;
namespace Core.Erp.Winform
{
    using Core.Erp.Business.Compras;
    public partial class Form1 : Form
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                com_OrdenPedido_Bus bus_pedido = new com_OrdenPedido_Bus();

                bus_pedido.SubirDocumentos(1);
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
