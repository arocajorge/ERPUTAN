using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;
using DevExpress.ExpressApp.Win;


namespace Core.Erp.Winform
{
    public partial class SplashScreenVZEN_Main_V10 :  SplashScreen
    {
 static private SplashScreenVZEN_Main_V10 form;
        private static bool isStarted = false;

        public SplashScreenVZEN_Main_V10()
        {
            InitializeComponent();
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum SplashScreenCommand
        {
        }

        public void Start()
        {
            isStarted = true;
            //form = new  SplashScreenVZEN_Main_V10();
            //form.Show();
            this.Show();
           // System.Windows.Forms.Application.DoEvents();
        }


        public void Stop()
        {
            if (form != null)
            {
              //  form.Hide();
                //form.Close();
                //form = null;
                this.Hide();
                this.Close();
            }
            isStarted = false;
        }


        private void SplashScreenVZEN_Main_V10_Load(object sender, EventArgs e)
        {

        }

        private void pictureEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}