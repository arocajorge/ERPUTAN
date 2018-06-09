using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.Produccion_Talme;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using System.Diagnostics;
using Core.Erp.Info.Produccion_Talme;
using Core.Erp.Business;
namespace Core.Erp.Winform.Produccion_Talme
{
    public partial class frmProd_GeneracionClavesAutorizacion : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        public frmProd_GeneracionClavesAutorizacion()
        {
            InitializeComponent();
            try
            {
                prod_ModeloProduccion_CusTalme_Bus BusModeloProduccion = new prod_ModeloProduccion_CusTalme_Bus();
                cmbModeloProduccion.Properties.DataSource = BusModeloProduccion.ConsultaGeneral().FindAll(v => v.Tipo.Trim() == "CHA");
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());               
            }

        }


        BindingList<prod_Clave_Autorizacion_Info> DataSource;
        private void simpleButton1_Click(object sender, EventArgs e)
        {

            try
            {
                List<string> Claves = new List<string>();
                GeneradorDeClaves InFoGenerador = new GeneradorDeClaves();
                Claves = InFoGenerador.GenerarPass(5, 5, Convert.ToInt32(txtCantidad.Value));
                             
                DataSource = new BindingList<prod_Clave_Autorizacion_Info>();
                DataSource.Clear();
                int sec = 1;
                DateTime fechaTra = param.Fecha_Transac;
              
                foreach (var item in Claves)
                {
                    prod_Clave_Autorizacion_Info obje = new prod_Clave_Autorizacion_Info();
                    obje.Clave = item.ToUpper();
                    obje.IdEmpresa = param.IdEmpresa;
                    obje.IdModeloProduccion = Convert.ToInt32(cmbModeloProduccion.EditValue);
                    obje.IdUsuarioGeneracion = param.IdUsuario;
                    obje.Secuencia = sec;
                    sec++;
                    obje.FechaGeneracion = fechaTra;
                    DataSource.Add(obje);
                }


                gridControl.DataSource = DataSource;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());              
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                prod_Clave_Autorizacion_Bus busPrd_Clave = new prod_Clave_Autorizacion_Bus();
                string Clavessss = string.Empty;

                if (busPrd_Clave.GuardarDB(DataSource.ToList(), param.IdEmpresa) == true)
                {
                    foreach (var item in DataSource)
                    {
                        Clavessss += "\n" + item.Clave.ToUpper();
                    }
                    
                    string Correos = "";
                    
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());               
            }
        }

        private void frmProd_GeneracionClavesAutorizacion_Load(object sender, EventArgs e){}

    }
}
