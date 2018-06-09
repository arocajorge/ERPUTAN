using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.Produc_Cirdesus;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Business.General;

namespace Core.Erp.Winform.Produc_Cirdesus
{
    public partial class FrmPrd_EtapaMantenimiento : Form
    {
        public FrmPrd_EtapaMantenimiento()
        {
            try
            {
                InitializeComponent();
               
                ucGe_Menu_Superior_Mant1.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
              
                ucGe_Menu_Superior_Mant1.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
                ucGe_Menu_Superior_Mant1.event_btnAnular_Click += ucGe_Menu_event_btnAnular_Click;

                listaEtapas = new List<prd_EtapaProduccion_Info>();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }


        }

        public int IdProcesoProductivo { get; set; }
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        public prd_EtapaProduccion_Info info = new prd_EtapaProduccion_Info(); //info es llenado desde el UC
        cl_parametrosGenerales_Bus param= cl_parametrosGenerales_Bus.Instance;
        //public List<prd_EtapaProduccion_Info> listaEtapas = new List<prd_EtapaProduccion_Info>(); // es llenado desde mantprocespproductivo

        public List<prd_EtapaProduccion_Info> listaEtapas { get; set; }


        prd_EtapaProduccion_Bus EtapaBus = new prd_EtapaProduccion_Bus();
        private void FrmPrd_EtapaMantenimiento_Load(object sender, EventArgs e)
        {
            try
            {
             switch (Accion)
                {
                    case Core.Erp.Info.General.Cl_Enumeradores.eTipo_action.grabar:
                      //  this.btn_guardarysalir.Text = "Grabar y Salir";
                        this.txt_idEtapa.Enabled = false; //el id debe ser secuencial
                        break;
                    case Core.Erp.Info.General.Cl_Enumeradores.eTipo_action.actualizar:
                       // this.btn_guardarysalir.Text = "Actualizar y Salir";
                       // this.btn_eliminar.Text = "Borrar y Salir";
                        this.txt_idEtapa.Enabled = false; //el id debe ser secuencial
                        break;
                    default:
                        break;
                }
                carga_combo();
                set_Etapa(info);
                event_FrmPrd_EtapaMantenimiento_FormClosing += FrmPrd_EtapaMantenimiento_event_FrmPrd_EtapaMantenimiento_FormClosing;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
            
        }

        void FrmPrd_EtapaMantenimiento_event_FrmPrd_EtapaMantenimiento_FormClosing(object sender, FormClosingEventArgs e){}

        private Core.Erp.Info.General.Cl_Enumeradores.eTipo_action Accion;

        public void Set_Accion(Core.Erp.Info.General.Cl_Enumeradores.eTipo_action _Accion)
        {
            try
            {
                Accion = _Accion;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }



        public void set_Etapa(prd_EtapaProduccion_Info info)
        {
            try
            {
                prd_EtapaProduccion_Bus EtapaBus = new prd_EtapaProduccion_Bus();
                    listaEtapas = EtapaBus.ObtenerListaEtapas(param.IdEmpresa, IdProcesoProductivo);
                    foreach (var item in listaEtapas)
                    {
                        if (item.IdEtapa == info.IdEtapa)
                        {
                            this.txt_idEtapa.Text = item.IdEtapa.ToString();
                            this.txt_NombreEtapa.Text = item.NombreEtapa;
                            this.txt_porcentaje.Text = item.PorcentajeEtapa.ToString();
                            this.cmb_Etapa.SelectedItem = item.Posicion;
                        }
                    }
            }
            catch ( Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
            


        }

        public prd_EtapaProduccion_Info get_Etapa()
        {
            try
            {
                if (Accion == Core.Erp.Info.General.Cl_Enumeradores.eTipo_action.actualizar)
                {
                    foreach (var item in listaEtapas)
                    {
                        if (item.IdEtapa == Convert.ToInt32(txt_idEtapa.Text))
                        {
                            info.IdEmpresa = item.IdEmpresa;
                            info.IdEtapa = (txt_idEtapa.Text == "") ? 0 : Convert.ToInt32(txt_idEtapa.Text);
                            info.IdProcesoProductivo = item.IdProcesoProductivo;
                            info.NombreEtapa = (this.txt_NombreEtapa.Text != "") ? this.txt_NombreEtapa.Text : ""; ;
                            info.PorcentajeEtapa = Convert.ToDouble(this.txt_porcentaje.Text);
                            info.Posicion = item.Posicion;


                        }
                    }
                }
                if (Accion == Core.Erp.Info.General.Cl_Enumeradores.eTipo_action.grabar)
                {
                    info.IdEmpresa = param.IdEmpresa;
                    info.IdEtapa = (txt_idEtapa.Text == "") ? 0 : Convert.ToInt32(txt_idEtapa.Text);
                    info.IdProcesoProductivo = IdProcesoProductivo;
                    info.NombreEtapa = (this.txt_NombreEtapa.Text != "") ? this.txt_NombreEtapa.Text : "";
                    info.PorcentajeEtapa = Convert.ToDouble((this.txt_porcentaje.Text != "") ? this.txt_porcentaje.Text :"0");
                    
                    info.Posicion = listaEtapas.Count(); //continua la secuencia

                }

                return info;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return new prd_EtapaProduccion_Info();
            }

        }

        //valida que el porcentaje no sea mayor a 100%
        private decimal valida_porcentaje()
        {
            try
            {
              decimal porc = 0;
              if (Accion == Core.Erp.Info.General.Cl_Enumeradores.eTipo_action.grabar)
                {
                    if (listaEtapas.Count() != 0)
                    {
                        foreach (var item in listaEtapas)
                            porc = porc + Convert.ToDecimal(item.PorcentajeEtapa);

                        porc = porc + Convert.ToDecimal(info.PorcentajeEtapa);
                    }
                    else
                    {
                        if (Accion == Core.Erp.Info.General.Cl_Enumeradores.eTipo_action.grabar) // si es uno nuevo
                            porc = porc + Convert.ToDecimal(info.PorcentajeEtapa);
                    }
                }
              else if (Accion == Core.Erp.Info.General.Cl_Enumeradores.eTipo_action.actualizar)
                {
                    foreach (var item in listaEtapas)
                    {
                        if (info.IdEtapa == item.IdEtapa)
                            porc = porc + Convert.ToDecimal(info.PorcentajeEtapa);
                        else
                            porc = porc + Convert.ToDecimal(item.PorcentajeEtapa);
                    }
                }
                return porc;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return 0;
            }
            

        }

        void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                this.txt_porcentaje.Focus();
                if (Convert.ToDecimal(this.txt_porcentaje.Text) > 0)
                {
                    get_Etapa();
                    FrmPrd_ProcesoProductivoMantenimiento frm = new FrmPrd_ProcesoProductivoMantenimiento();
                    string msg = "";
                    int a = 0;
                    decimal porc = valida_porcentaje();
                    switch (Accion)
                    {
                        case Core.Erp.Info.General.Cl_Enumeradores.eTipo_action.grabar:
                            if (txt_NombreEtapa.Text.Length > 0 || txt_porcentaje.Text.Length > 0)
                            {

                                if (porc <= 100)
                                {
                                    //llamar una funcion en la pantalla de mant del modelo que me agregue la etapa a la lista
                                    frm.listaEtapas = listaEtapas;
                                    if (frm.agregaEtapaLista(info, Convert.ToString(this.cmb_Etapa.SelectedItem)))
                                    {
                                        msg = "Agregado con éxito";
                                        MessageBox.Show(msg, "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        //frm.progresoBarra(porc);
                                    }
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Porcentaje excede al 100% acumulado , no se guardó! ", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                                MessageBox.Show("Ingrese los datos de la etapa", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        case Core.Erp.Info.General.Cl_Enumeradores.eTipo_action.actualizar:
                            if (txt_NombreEtapa.Text.Length > 0 || txt_porcentaje.Text.Length > 0)
                            {
                                if (porc <= 100)
                                {
                                    //funcion para actualizar una etapa de la lista
                                    frm.listaEtapas = listaEtapas;
                                    if (frm.modificaEtapaLista(info, Convert.ToInt32(this.cmb_Etapa.SelectedItem)))
                                    {
                                        msg = "Modificado con éxito";
                                        MessageBox.Show(msg, "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    //frm.progresoBarra(porc);
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Porcentaje excede al 100% acumulado , no se guardó! ", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                                MessageBox.Show("Ingrese los datos de la etapa", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        default:
                            break;
                    }
                }
                else
                    MessageBox.Show("Porcentaje no puede ser menor a 0% , no se guardó! ", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                string msg = "Ha ocurrido un error, consulte con sistemas: ";
                MessageBox.Show(msg,"Sistemas",MessageBoxButtons.OK,MessageBoxIcon.Error);
                
            }
            
        }

        void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

      

        private void txt_NombreEtapa_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
              e.KeyChar = char.ToUpper(e.KeyChar);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void carga_combo()
        {
            try
            {
                if (Accion == Core.Erp.Info.General.Cl_Enumeradores.eTipo_action.grabar)
                {
                    this.cmb_Etapa.Items.Add("Continuar secuencia");
                }
                foreach (var item in listaEtapas)
                {
                    this.cmb_Etapa.Items.Add(item.Posicion);
                }
                this.cmb_Etapa.SelectedIndex = 0;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                get_Etapa();
                FrmPrd_ProcesoProductivoMantenimiento frm = new FrmPrd_ProcesoProductivoMantenimiento();
                string msg = "Eliminado con éxito";
                int a = 0;

                //funcion para borrrar una etapa de la lista
                frm.listaEtapas = listaEtapas;
                if (frm.eliminarEtapaLista(info))
                {
                    MessageBox.Show(msg, "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                string msg = "Ha ocurrido un error, consulte con sistemas, error: " + ex.Message + "";
                MessageBox.Show(msg, "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }

        }

        private void txt_porcentaje_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                //string perc;
                //perc = txt_porcentaje.EditValue.ToString();
                //if (Convert.ToDecimal(txt_porcentaje.EditValue.ToString() )  < 0)
                //{
                //    txt_porcentaje.Text = "0"; this.txt_porcentaje.Focus();
                //    MessageBox.Show("El porcentaje no puede ser negativo");
                
            
                //}
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        public delegate void delegate_FrmPrd_EtapaMantenimiento_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_FrmPrd_EtapaMantenimiento_FormClosing event_FrmPrd_EtapaMantenimiento_FormClosing;

        private void FrmPrd_EtapaMantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
              event_FrmPrd_EtapaMantenimiento_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }
    }
}
