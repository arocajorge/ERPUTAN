using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/*
CREADA POR:     ALBERTO MENA S.
FECHA CREACION: 05/MARZO/2015
*/


namespace Core.Erp.Winform.Roles
{
    public partial class frmRo_Formula_Mant : Form
    {
        public frmRo_Formula_Mant()
        {
            InitializeComponent();
        }

        private void frmRo_Formula_Mant_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Escape))
            {
                this.Close();
            }
        }
    }
}
