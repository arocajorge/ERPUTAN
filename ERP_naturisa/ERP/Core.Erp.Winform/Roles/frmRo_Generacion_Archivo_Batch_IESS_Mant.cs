using Core.Erp.Business.General;
using Core.Erp.Business.Roles;
using Core.Erp.Info.Roles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Core.Erp.Winform.Roles
{
    public partial class frmRo_Generacion_Archivo_Batch_IESS_Mant : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        List< ro_Archivo_IESS_Generacion_Info >Listadonovedades = new List< ro_Archivo_IESS_Generacion_Info>();

        ro_Nomina_Tipo_Bus oRo_Nomina_Tipo_Bus = new ro_Nomina_Tipo_Bus();
        ro_Nomina_Tipoliqui_Bus nominatipo_Bus = new ro_Nomina_Tipoliqui_Bus();
        ro_periodo_x_ro_Nomina_TipoLiqui_Bus periodo_nomina_bus = new ro_periodo_x_ro_Nomina_TipoLiqui_Bus();

        List<ro_Nomina_Tipo_Info> listadoNomina = new System.Collections.Generic.List<ro_Nomina_Tipo_Info>();
        List<ro_Nomina_Tipoliqui_Info> ListadoTipoLiquidacion = new System.Collections.Generic.List<ro_Nomina_Tipoliqui_Info>();
        List<ro_periodo_x_ro_Nomina_TipoLiqui_Info> listadoPeriodo = new System.Collections.Generic.List<ro_periodo_x_ro_Nomina_TipoLiqui_Info>();

        ro_periodo_x_ro_Nomina_TipoLiqui_Info infoPeriodo = new ro_periodo_x_ro_Nomina_TipoLiqui_Info();
        string mensaje = "";

        string _rutaArchivo = "";
        string _nombreArchivo = "";

        //BUS
        ro_Archivo_IESS_Generacion_Bus oRo_Archivo_IESS_Generacion_Bus = new ro_Archivo_IESS_Generacion_Bus();

        //INFO

        public frmRo_Generacion_Archivo_Batch_IESS_Mant()
        {
            InitializeComponent();

            ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;

        }

        void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private Boolean pu_Validar() {
            try
            {
                if(txtCodigoSucursal.Text.Length==0){
                    MessageBox.Show("El Código de la Sucursal es obligatorio, revise por favor","ATENCION", MessageBoxButtons.OK,MessageBoxIcon.Stop);
                    txtCodigoSucursal.Focus();
                    return false;
                }

                if (cmbTipoNovedad.EditValue == null)
                {
                    MessageBox.Show("El Tipo de Novedad es obligatorio, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    cmbTipoNovedad.Focus();
                    return false;
                }

                if (cmbPeriodos.EditValue=="" || cmbPeriodos.EditValue==null)
                {
                    MessageBox.Show("Seleccione un periodo", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return false;
                }
              

                if ( txtRutaArchivo.Text=="")
                {
                    MessageBox.Show("La Ruta del Archivo es obligatorio, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtRutaArchivo.Focus();
                    return false;
                }
                
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString()); return false;
            }
        
        
        }



        private Boolean getInfo() {
            try {
                  

                    _rutaArchivo = "C:/";
                    _nombreArchivo = param.InfoEmpresa.em_nombre + txtCodigoSucursal.Text +cmbPeriodos.EditValue.ToString()+".txt";
             
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString()); return false;
            }
        }


        private void pu_GenerarNovedad() 
        { 
            try{


                if (pu_Validar())
                {

                    if (getInfo())
                    {
                        string fileName = saveFileDialog1.FileName;

                        //BORRAR ARCHIVO PREVIO
                        if (File.Exists(fileName)) File.Delete(fileName);

                        foreach (var item in Listadonovedades)
                        {
                            if (oRo_Archivo_IESS_Generacion_Bus.GrabarBD(item, fileName, ";", ref mensaje))
                            {

                            }
                        }
                        if (MessageBox.Show("El Archivo ha sido generado con éxito, desea abrir el Archivo...?", "INFORMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            Process.Start(fileName);

                    }
                    else
                    {
                     MessageBox.Show(mensaje, "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }



        private void cmdGenerar_Click(object sender, EventArgs e)
        {
            pu_GenerarNovedad();
        }

        private void frmRo_Generacion_Archivo_Batch_IESS_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                listadoNomina = oRo_Nomina_Tipo_Bus.Get_List_Nomina_Tipo(param.IdEmpresa);
                cmbnomina.Properties.DataSource = listadoNomina;
            cmbPeriodos.Properties.DataSource = listadoPeriodo;
            txtCodigoSucursal.Text ="00"+ param.IdSucursal.ToString();
            pu_CargaInicial();

            }
            catch (Exception ex)
            {
                
                
            }
        }


        private void pu_CargaInicial() {
            try {
                List<ro_Catalogo_Info> oRo_TipoNovedad_Info = new List<ro_Catalogo_Info>();
                ro_Catalogo_Bus oRo_Catalogo_Bus = new ro_Catalogo_Bus();

                oRo_TipoNovedad_Info.AddRange(oRo_Catalogo_Bus.Get_List_Catalogo_x_Tipo(31).Where(v=>v.ca_estado=="A").ToList());
                cmbTipoNovedad.Properties.ValueMember = "CodCatalogo";
                cmbTipoNovedad.Properties.DisplayMember = "ca_descripcion";
                cmbTipoNovedad.Properties.DataSource = oRo_TipoNovedad_Info;

                saveFileDialog1.Filter = "(*.txt, *.dat)|*.txt;*.dat";   

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        
        }

        private void txtRutaArchivo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                if (getInfo())
                {
                    saveFileDialog1.FileName = _nombreArchivo;
                    saveFileDialog1.ShowDialog();
                    txtRutaArchivo.Text = saveFileDialog1.FileName;
                }
                else
                {
                    MessageBox.Show("Debe seleccionar todos los campos, es obligatorio", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
           
        }

        private void cmbTipoNovedad_EditValueChanged(object sender, EventArgs e)
        {
            txtRutaArchivo.Text = "";
        }

        

        private void ucGe_Menu_event_btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                gridViewNovedadesIESS.ShowRibbonPrintPreview();
            }
            catch (Exception ex)
            {
                
               MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void cmbnomina_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                ListadoTipoLiquidacion = nominatipo_Bus.Get_List_Nomina_Tipoliqui_x_Nomina_Tipo(param.IdEmpresa, Convert.ToInt32(cmbnomina.EditValue));
                cmbnominaTipo.Properties.DataSource = ListadoTipoLiquidacion;

            }
            catch (System.Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void cmbnominaTipo_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                listadoPeriodo = periodo_nomina_bus.ConsultaPerNomTipLiq(param.IdEmpresa, Convert.ToInt32(cmbnomina.EditValue), Convert.ToInt32(cmbnominaTipo.EditValue));
                cmbPeriodos.Properties.DataSource = listadoPeriodo;
            }
            catch (System.Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void cmbPeriodos_EditValueChanged_1(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    infoPeriodo = (ro_periodo_x_ro_Nomina_TipoLiqui_Info)cmbPeriodos.Properties.View.GetFocusedRow();
                    Listadonovedades = oRo_Archivo_IESS_Generacion_Bus.pu_GenerarBatch(param.IdEmpresa, infoPeriodo, Convert.ToString(cmbTipoNovedad.EditValue), txtCodigoSucursal.Text);
                    gridControlNovedadesIESS.DataSource = Listadonovedades;


                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                    Log_Error_bus.Log_Error(ex.ToString());
                }
            }
            catch (Exception ex)
            {
                
                 MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

    }
}
