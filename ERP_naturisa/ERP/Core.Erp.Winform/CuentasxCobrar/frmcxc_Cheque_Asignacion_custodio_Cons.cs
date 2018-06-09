using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Info.Roles;

namespace Core.Erp.Winform.CuentasxCobrar
{
    public partial class frmcxc_Cheque_Asignacion_custodio_Cons : Form
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        
        public frmcxc_Cheque_Asignacion_custodio_Cons()
        {
            InitializeComponent();
            frmMant.event_frmcxc_Cheque_Asignacion_custodio_Mant_FormClosing+=frmMant_event_frmcxc_Cheque_Asignacion_custodio_Mant_FormClosing;

        }

        frmCxc_Cheque_Asignacion_custodio_Mant frmMant = new frmCxc_Cheque_Asignacion_custodio_Mant();
        

        void frmMant_event_frmcxc_Cheque_Asignacion_custodio_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            //cargagrid();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                frmMant = new frmCxc_Cheque_Asignacion_custodio_Mant(Cl_Enumeradores.eTipo_action.grabar);
                frmMant.event_frmcxc_Cheque_Asignacion_custodio_Mant_FormClosing += frmMant_event_frmcxc_Cheque_Asignacion_custodio_Mant_FormClosing;
                frmMant.Text = frmMant.Text + " ***NUEVO REGISTRO***";
                frmMant.Show();
            }
            catch (Exception ex)
            {

            }      
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmcxc_Cheque_Asignacion_custodio_Cons_Load(object sender, EventArgs e)
        {

        }

    }
}
