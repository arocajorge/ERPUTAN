using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Core.Erp.Service
{
    using Core.Erp.Info.Compras;
    using Core.Erp.Business.Compras;

    public partial class Service1 : ServiceBase
    {
        com_ordencompra_local_correo_Bus bus_correo;

        public Service1()
        {
            bus_correo = new com_ordencompra_local_correo_Bus();
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            Timer aTimer = new System.Timers.Timer();
            aTimer.Elapsed += new ElapsedEventHandler(Tiempo_Elapsed);
            aTimer.Interval = TimeSpan.FromSeconds(10).TotalMilliseconds;
            aTimer.Enabled = true;
        }

        private void Tiempo_Elapsed(object sender, ElapsedEventArgs e)
        {
            try
            {
                var oc = bus_correo.GetOC();

            }
            catch (Exception)
            {

            }
        }

        protected override void OnStop()
        {
        }
    }
}
