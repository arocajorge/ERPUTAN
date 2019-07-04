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
    using System.Net.Mail;
    using System.IO;
    using Cus.Erp.Reports.Naturisa.Compras;
    using System.Net;

    public partial class Service1 : ServiceBase
    {
        com_ordencompra_local_correo_Bus bus_correo;
        com_parametro_Bus bus_param;

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
            var oc = bus_correo.GetOC();
            if (oc == null)
                return;

            try
            {
                bus_correo.Modificar(new com_ordencompra_local_correo_Info { IdEmpresa = oc.IdEmpresa, IdSucursal = oc.IdSucursal, IdOrdenCompra = oc.IdOrdenCompra, Mensaje = "Validando parametros"});

                var param = bus_param.Get_Info_parametro(oc.IdEmpresa);
                if (string.IsNullOrEmpty(param.Correo) || string.IsNullOrEmpty(param.Asunto) || string.IsNullOrEmpty(param.Contrasenia) || string.IsNullOrEmpty(param.Dominio) || string.IsNullOrEmpty(param.CuerpoCorreo) || string.IsNullOrEmpty(oc.CorreoProveedor))
                    return;

                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(param.Correo);//Correo de envio
                mail.Subject = param.Asunto + " " + "OC #" + oc.Codigo;

                string[] CorreosProveedor = oc.CorreoProveedor.Split(';');
                foreach (var item in CorreosProveedor)
                {
                    if (!string.IsNullOrEmpty(item))
                        mail.To.Add(item);
                }

                if (!string.IsNullOrEmpty(oc.CorreoComprador))
                {
                    string[] CorreosComprador = oc.CorreoComprador.Split(';');
                    foreach (var item in CorreosComprador)
                    {
                        if (!string.IsNullOrEmpty(item))
                            mail.CC.Add(item);
                    }
                }

                if (!string.IsNullOrEmpty(param.CorreosCopia))
                {
                    string[] CorreosCopia = param.CorreosCopia.Split(';');
                    foreach (var item in CorreosCopia)
                    {
                        if (!string.IsNullOrEmpty(item))
                            mail.CC.Add(item);
                    }
                }

                string Body = "";
                Body += param.CuerpoCorreo;

                MemoryStream mem = new MemoryStream();
                XCOMP_NATU_Rpt007_Rpt rpt = new XCOMP_NATU_Rpt007_Rpt();
                rpt.RequestParameters = false;
                rpt.PIdEmpresa.Value = param.IdEmpresa;
                rpt.PIdEmpresa.Visible = false;
                rpt.PIdSucursal.Value = oc.IdSucursal;
                rpt.PIdSucursal.Visible = false;
                rpt.PIdOrdenCompra.Value = oc.IdOrdenCompra;
                rpt.PIdOrdenCompra.Visible = false;
                rpt.ExportToPdf(mem);

                bus_correo.Modificar(new com_ordencompra_local_correo_Info { IdEmpresa = oc.IdEmpresa, IdSucursal = oc.IdSucursal, IdOrdenCompra = oc.IdOrdenCompra, Mensaje = "Agregando adjunto" });
                // Create a new attachment and put the PDF report into it.
                mem.Seek(0, System.IO.SeekOrigin.Begin);
                Attachment att = new Attachment(mem, "OC #" + oc.Codigo + ".pdf", "application/pdf");
                mail.Attachments.Add(att);
                AlternateView htmlView = AlternateView.CreateAlternateViewFromString(Body, null, "text/html");
                mail.AlternateViews.Add(htmlView);


                try
                {
                    #region smtp
                    SmtpClient smtp = new SmtpClient();
                    smtp.UseDefaultCredentials = false;
                    smtp.Host = param.Dominio;
                    smtp.EnableSsl = param.PemitirSSL;
                    smtp.Port = 0;
                    smtp.Credentials = new NetworkCredential(param.Correo, param.Contrasenia);
                    smtp.Send(mail);

                    bus_correo.Modificar(new com_ordencompra_local_correo_Info { IdEmpresa = oc.IdEmpresa, IdSucursal = oc.IdSucursal, IdOrdenCompra = oc.IdOrdenCompra, Mensaje = "Enviado" });
                    #endregion
                }
                catch (Exception ex)
                {
                    bus_correo.Modificar(new com_ordencompra_local_correo_Info { IdEmpresa = oc.IdEmpresa, IdSucursal = oc.IdSucursal, IdOrdenCompra = oc.IdOrdenCompra, Mensaje = ex.Message });
                }
                mem.Close();
                mem.Flush();
            }
            catch (Exception ex)
            {
                bus_correo.Modificar(new com_ordencompra_local_correo_Info { IdEmpresa = oc.IdEmpresa, IdSucursal = oc.IdSucursal, IdOrdenCompra = oc.IdOrdenCompra, Mensaje = ex.Message });
            }
        }

        protected override void OnStop()
        {
        }
    }
}
