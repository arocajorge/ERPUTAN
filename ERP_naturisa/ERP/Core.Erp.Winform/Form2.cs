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

            }
            catch (Exception ex)
            {
                
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       

    }
}

       

       

       
    

