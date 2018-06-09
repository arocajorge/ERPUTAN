using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Winform.Controles;
using Core.Erp.Business.Produc_Cirdesus;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.Contabilidad;
using Cus.Erp.Reports.Cidersus;

//version 240620113 13:31
namespace Core.Erp.Winform.Produc_Cirdesus
{
    public partial class FrmPrd_ProcesoProductivoMantenimiento : Form
    {
       
        public FrmPrd_ProcesoProductivoMantenimiento()
        {
            try
            {
                InitializeComponent();
                IniciarControles();
                this.event_FrmPrd_ProcesoProductivoMantenimiento_FormClosing += new delegate_FrmPrd_ProcesoProductivoMantenimiento_FormClosing(FrmPrd_ProcesoProductivoMantenimiento_event_FrmPrd_ProcesoProductivoMantenimiento_FormClosing);
                UCetapa.event_lblEtapa_DoubleClick +=UCetapa_event_lblEtapa_DoubleClick;
                ucGe_Menu_Superior_Mant1.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
                ucGe_Menu_Superior_Mant1.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
                ucGe_Menu_Superior_Mant1.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
                ucGe_Menu_Superior_Mant1.event_btnAnular_Click += ucGe_Menu_event_btnAnular_Click;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        void FrmPrd_ProcesoProductivoMantenimiento_event_FrmPrd_ProcesoProductivoMantenimiento_FormClosing(object sender, FormClosingEventArgs e){}

        public int IdPP { get; set; }
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        UCPrd_EtapaFlecha UCflecha = new UCPrd_EtapaFlecha();
        
        UCPrd_EtapaProduccion UCetapa = new UCPrd_EtapaProduccion();
        
        public prd_ProcesoProductivo_Info info = new prd_ProcesoProductivo_Info();

        public prd_EtapaProduccion_Info infoEtapa = new prd_EtapaProduccion_Info();

        public List<prd_EtapaProduccion_Info> List = new List<prd_EtapaProduccion_Info>();

        public List<prd_EtapaProduccion_Info> listaEtapas = new List<prd_EtapaProduccion_Info>();

        prd_ProcesoProductivo_Bus ProcesoProductivo_bus = new prd_ProcesoProductivo_Bus();

        prd_EtapaProduccion_Bus BusEtapas = new prd_EtapaProduccion_Bus();

        FrmPrd_EtapaMantenimiento fr;
    
        public delegate void delegate_FrmPrd_ProcesoProductivoMantenimiento_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_FrmPrd_ProcesoProductivoMantenimiento_FormClosing event_FrmPrd_ProcesoProductivoMantenimiento_FormClosing;
        private void FrmPrd_ProcesoProductivoMantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                  event_FrmPrd_ProcesoProductivoMantenimiento_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        private Cl_Enumeradores.eTipo_action Accion;

        //instancia de centro de costo
     
        UCPrd_Obra UCObra = new UCPrd_Obra();

        prd_Obra_Bus BusObra = new prd_Obra_Bus();

        public void Set_Accion(Cl_Enumeradores.eTipo_action _Accion)
        {
            try
            {
                Accion = _Accion;
                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:

                        ucGe_Menu_Superior_Mant1.Enabled_bntAnular = false;
                        ucGe_Menu_Superior_Mant1.Enabled_bntLimpiar = true;
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        ucGe_Menu_Superior_Mant1.Enabled_bntAnular = false;
                        ucGe_Menu_Superior_Mant1.Enabled_bntLimpiar = false;


                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        ucGe_Menu_Superior_Mant1.Enabled_bntAnular = false;
                        ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu_Superior_Mant1.Visible_btnGuardar = false;
                        ucGe_Menu_Superior_Mant1.Enabled_bntLimpiar = false;

                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        ucGe_Menu_Superior_Mant1.Enabled_bntAnular = true;
                        ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu_Superior_Mant1.Visible_btnGuardar = false;
                        ucGe_Menu_Superior_Mant1.Enabled_bntLimpiar = false;


                        break;
                    default:
                        break;

                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
  
        }

        private void IniciarControles()
        {
            try
            {

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        public void set_ProcesoProductivo(prd_ProcesoProductivo_Info objeto_info)
        {
            try
            {
                info = objeto_info;
                this.txt_id.Text = objeto_info.IdProcesoProductivo.ToString();
                this.txt_id.Enabled = false;
                this.txt_descripcion.Text = objeto_info.Nombre;
                this.chk_estado.Checked = objeto_info.Estado;
                if (info.Estado == false)
                    lblAnulado.Visible = true;
                ///*******
           
                UCObra.set_item(objeto_info.CodObra);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }           
        }

        public prd_ProcesoProductivo_Info get_ProcesoProductivo()
        {
            try
            {
                info.IdEmpresa = param.IdEmpresa;
                info.IdProcesoProductivo = (this.txt_id.Text != "") ? Convert.ToInt32(this.txt_id.Text) : 0;
                info.Nombre = (this.txt_descripcion.Text != "") ? this.txt_descripcion.Text : "";
                info.Estado = this.chk_estado.Checked;
                return info;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return new prd_ProcesoProductivo_Info();
            }

        }

        private void FrmPrd_MantProcesoProductivo_Load(object sender, EventArgs e)
        {
            try
            {
              LoadForm();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void UCetapa_event_lblEtapa_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                  carga_modelo();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void LoadForm()
        {
            try
            {
                 if (Accion == Cl_Enumeradores.eTipo_action.grabar)
                    UCObra.cargaCmb_ObraxProcProd();
                else
                    UCObra.cargaCmb_Obra();

                if (txt_descripcion.Text.Trim() == "")
                {
                    btn_Nuevo.Enabled = false;
                }
                else
                {
                    btn_Nuevo.Enabled = true;
                }
                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:

                        chk_estado.Enabled = false;
                        chk_estado.Checked = true;
                        this.txt_id.Text = "0";
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        chk_estado.Enabled = false;
                        chk_estado.Checked = true;
                        this.btn_Nuevo.Enabled = true;
                      
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        chk_estado.Enabled = false;
                        chk_estado.Checked = true;
                        this.btn_Nuevo.Enabled = false; ;
                        this.txt_descripcion.Enabled = false;
                        this.PanelControlEt.Enabled = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.duplicar:
                        this.chk_estado.Checked = true;
                        this.chk_estado.Enabled = false;
                        this.txt_id.Text = IdPP.ToString();
                        this.btn_Nuevo.Enabled = true;

                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
 
                        this.btn_Nuevo.Enabled = false ;
                        this.txt_descripcion.Enabled = false;
                       
                        this.PanelControlEt.Enabled = false;
                    //    this.Btn_Anular.Visible = true;
                    //    sep1.Visible = true;
                        break;
                    default:
                        break;
                }
                prd_EtapaProduccion_Bus bus_Etapa = new prd_EtapaProduccion_Bus();
                listaEtapas = bus_Etapa.ObtenerListaEtapas(param.IdEmpresa, Convert.ToInt32(this.txt_id.Text));
                this.lbl_porcTotal.Text = " 0 %";
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void btn_Salir_Click(object sender, EventArgs e)
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

        private void grabar()
        {
            try
            {
                        get_ProcesoProductivo();
                        int id_ProcesoProductivo = 0;
                        string mensaje = "";
                        switch (Accion)
                        {
                            case Cl_Enumeradores.eTipo_action.grabar:
                                
                                if (ProcesoProductivo_bus.GrabarItem(info, ref id_ProcesoProductivo, ref mensaje))
                                {
                                    txt_id.Text = id_ProcesoProductivo.ToString();
                                    info.IdProcesoProductivo = id_ProcesoProductivo;
                                    btn_Nuevo.Visible = true;
                                    btn_Nuevo.Enabled = true;
                                    
                                    bloquear();
                                    MessageBox.Show(mensaje, "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                break;
                     
                            case Cl_Enumeradores.eTipo_action.actualizar:

                                ProcesoProductivo_bus.ModificarItem(info, ref mensaje);

                                MessageBox.Show(mensaje, "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;

                            case Cl_Enumeradores.eTipo_action.duplicar:
                                ProcesoProductivo_bus.GrabarItem(info, ref id_ProcesoProductivo, ref mensaje);
                                List<prd_EtapaProduccion_Info> lisTemporal = new List<prd_EtapaProduccion_Info>();
                                foreach (var item in listaEtapas)
                                {
                                    item.IdProcesoProductivo = id_ProcesoProductivo;
                                    lisTemporal.Add(item);
                                }
                                BusEtapas.GrabarListaEtapas(lisTemporal, param.IdEmpresa, id_ProcesoProductivo, ref mensaje);
                                MessageBox.Show("Duplicado con éxito", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                                break;
                            default:
                                break;
                        }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }                       
        }

        private void btn_Ok_Click(object sender, EventArgs e){}

        private Boolean validar()
        {
            try
            {
                if (txt_descripcion.Text == string.Empty)
                {
                    MessageBox.Show("Debe Ingresar la descripción","SISTEMA",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return false;
                }
                else if (UCObra.get_item_info() == null)
                {
                    MessageBox.Show("Seleccione una Obra", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                    return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }
        }

        public Boolean  agregaEtapaLista(prd_EtapaProduccion_Info info, string pos)
        {
            try
            {
             List<prd_EtapaProduccion_Info> lisTemporal = new List<prd_EtapaProduccion_Info>();


                    if (pos == "Continuar secuencia")
                    {
                        info.IdEtapa = listaEtapas.Count + 1;

                        lisTemporal.Add(info);

                        if (listaEtapas.Count() != 0)
                        {
                            foreach (var item in listaEtapas)
                            {
                                lisTemporal.Add(item);
                            }
                        }
                    }

                    else if(info.Posicion > Convert.ToInt32(pos))
                        {
                            //lisTemporal = new List<prd_EtapaProduccion_Info>();
                            listaEtapas.Add(info); //primero lo agrego a la lista
                            foreach (var item in listaEtapas)
                            {
                        
                                if (Convert.ToInt32(pos) > item.Posicion)
                                {
                                    lisTemporal.Add(item);
                                }
                                else if (item.IdEtapa==0) //busco el nuevo q agregue
                                {
                                    item.Posicion = Convert.ToInt32(pos); // le cambio la posicion deseada
                                    lisTemporal.Add(item);
                                    //break; //para que ya no corra llegue a la ultima que quiero modificar
                                }
                                else if (info.Posicion > item.Posicion)
                                {
                                    item.Posicion++; //cambio de posicion
                                    lisTemporal.Add(item);
                                }
                                else
                                {
                                    lisTemporal.Add(item);
                                }
                            }
                        }

                    listaEtapas.Remove(info); //saco el info para que no de problemas al eliminar la lista
                    string msg = "";
                    prd_EtapaProduccion_Bus BusEtapas = new prd_EtapaProduccion_Bus();
                    if (BusEtapas.eliminarLisEtapas(listaEtapas, Convert.ToInt32(param.IdEmpresa), Convert.ToInt32(info.IdProcesoProductivo), ref msg))
                    {
                        if (!(BusEtapas.GrabarListaEtapas(lisTemporal, param.IdEmpresa, Convert.ToInt32(info.IdProcesoProductivo), ref msg)))
                        { return false; }
                        else
                        {
                            carga_modelo();
                            return true;
                        }
                    }
                    else {
                        MessageBox.Show("No se puede modificar las etapas porque la obra ya esta en producción"); return false;
                    }
            }
            catch ( Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }
            
            
        }

        //elimina un item de la lista y ordena las posiciones
        public Boolean eliminarEtapaLista(prd_EtapaProduccion_Info info)
        {
            try
            {
                List<prd_EtapaProduccion_Info> lisTemporal = new List<prd_EtapaProduccion_Info>();
                lisTemporal = new List<prd_EtapaProduccion_Info>();
                foreach (var item in listaEtapas)
                {
                        
                    if (info.Posicion < item.Posicion)
                    {
                        item.Posicion--;
                        lisTemporal.Add(item);
                    }
                    else if (info.IdEtapa == item.IdEtapa)
                    {
                        //lisTemporal.Remove(item);
                        //no la agrego ya que es la que borrare
                    }
                    else
                    {
                        lisTemporal.Add(item);
                    }
                }
                string msg = "";
                prd_EtapaProduccion_Bus BusEtapas = new prd_EtapaProduccion_Bus();
                if (BusEtapas.eliminarLisEtapas(listaEtapas, Convert.ToInt32(param.IdEmpresa), Convert.ToInt32(info.IdProcesoProductivo), ref msg))
                {
                    if (
                        BusEtapas.GrabarListaEtapas(lisTemporal, param.IdEmpresa, Convert.ToInt32(info.IdProcesoProductivo), ref msg))
                       
                    {
                        carga_modelo();
                        return true;
                    }
                    else return false;
                }
                else
                {
                    MessageBox.Show("No se puede eliminar las etapas porque la obra ya esta en producción"); return false;
                }

                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }
        }

        public void progresoBarra(decimal porc)
        {
            try
            {
                this.pbar_porcentaje.Value = 0;
                this.pbar_porcentaje.Increment(Convert.ToInt32(porc));
                this.lbl_porcTotal.ForeColor = Color.Red;
                if (Convert.ToInt32(porc) == 100)
                {
                    this.pbar_porcentaje.ForeColor = Color.Red;
                    this.pbar_porcentaje.BackColor = Color.Blue;
                    this.lbl_porcTotal.ForeColor = Color.Black;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        //modifica la lista
        public Boolean  modificaEtapaLista(prd_EtapaProduccion_Info info, int pos)
        {
            try
            {
                List<prd_EtapaProduccion_Info> lisTemporal = new List<prd_EtapaProduccion_Info>();
                //validar si la lista se recorrera de arriba para abajo
                if (info.Posicion > pos)
                {
                    lisTemporal = new List<prd_EtapaProduccion_Info>();
                    foreach (var item in listaEtapas)
                    {
                        
                        if (pos > item.Posicion)
                        {
                            lisTemporal.Add(item);
                        }
                        else if (item.IdEtapa == info.IdEtapa)
                        {
                            item.Posicion = pos;
                            item.NombreEtapa = info.NombreEtapa;
                            item.PorcentajeEtapa = info.PorcentajeEtapa;
                            lisTemporal.Add(item);
                            break; //para que ya no corra llegue a la ultima que quiero modificar
                        }
                        else if (info.Posicion > item.Posicion)
                        {
                            item.Posicion++; //cambio de posicion
                            lisTemporal.Add(item);
                        }
                        else
                        {
                            lisTemporal.Add(item);
                        }
                    }
                }

                    //validar si la lista se recorrera de abajo para arriba
                else if (info.Posicion < pos)
                {
                    lisTemporal = new List<prd_EtapaProduccion_Info>();
                    foreach (var item in listaEtapas)
                    {
                        if (pos < item.Posicion)
                        {
                            lisTemporal.Add(item);
                        }

                        else if (item.IdEtapa == info.IdEtapa)
                        {
                            item.Posicion = pos;
                            item.NombreEtapa = info.NombreEtapa;
                            item.PorcentajeEtapa = info.PorcentajeEtapa;
                            lisTemporal.Add(item);
                            break;
                        }
                        else if (info.Posicion < item.Posicion)
                        {
                            item.Posicion--;
                            lisTemporal.Add(item);
                        }
                        else
                        {
                            lisTemporal.Add(item);
                        }
                    }
                }
                    //ppreguntar si no movió pposicion y grabar datos de modificacion como porcentaje y descripcion
                else if (info.Posicion == pos)
                {
                    lisTemporal = new List<prd_EtapaProduccion_Info>();
                    foreach (var item in listaEtapas)
                    {
                        if (item.IdEtapa == info.IdEtapa)
                        {
                            item.NombreEtapa = info.NombreEtapa;
                            item.PorcentajeEtapa = info.PorcentajeEtapa;
                            lisTemporal.Add(item);
                        }
                        else
                        {
                            lisTemporal.Add(item);
                        }
                    }
                }
                
                string msg = "";
                prd_EtapaProduccion_Bus BusEtapas = new prd_EtapaProduccion_Bus();
                if (BusEtapas.eliminarLisEtapas(listaEtapas, Convert.ToInt32(param.IdEmpresa), Convert.ToInt32(info.IdProcesoProductivo), ref msg))
                {
                    if (!(BusEtapas.GrabarListaEtapas(lisTemporal, param.IdEmpresa, Convert.ToInt32(info.IdProcesoProductivo), ref msg)))
                        //MessageBox.Show("No se puede modificar las etapas porque la obra ya esta en producción" + msg);
                        return false;
                    else
                    {
                        carga_modelo();
                        return true;
                    }
                }
                else { MessageBox.Show("No se puede modificar las etapas porque la obra ya esta en producción"); return false; } 
                


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }


        }

        public void carga_modelo()
        {
            try
            {
                prd_EtapaProduccion_Bus BusEtapas = new prd_EtapaProduccion_Bus();
                this.PanelControlEt.Controls.Clear();
                int IdModelo = 0;
                IdModelo = (info.IdProcesoProductivo == 0) ? Convert.ToInt32(txt_id.Text) : info.IdProcesoProductivo;
                listaEtapas = BusEtapas.ObtenerListaEtapas(param.IdEmpresa, IdModelo);
                Carga_ListaControl(listaEtapas);

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                //MessageBox.Show("Error consulte con Sistemas : " + e.Message + "", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void Carga_ListaControl(List<prd_EtapaProduccion_Info> ListEtapaInfo)
        {
            try
            {
             int c = 0; //contador para posiciones
                decimal porc = 0;
                foreach (var item in ListEtapaInfo)
                {
                    UCetapa = new UCPrd_EtapaProduccion();
                    UCetapa.set_ListaEtapas(ListEtapaInfo);
                    UCetapa.set_etapa(item.NombreEtapa);
                    UCetapa.set_porcentaje(item.PorcentajeEtapa.ToString() + " %");
                    porc = porc + Convert.ToDecimal(item.PorcentajeEtapa);
                    this.lbl_porcTotal.Text = porc + " %";
                
                
                    UCetapa.Left = c * 130 + 10;
                    if (c == 0)
                        UCetapa.Left = 10;
                    UCetapa.Top = 20;
                    UCetapa.set_IdEtapa(item.IdEtapa);
                    UCetapa.set_idProcesoProductivo(item.IdProcesoProductivo);
                    this.PanelControlEt.Controls.Add(UCetapa);
                    c++;
                }

                //para que no ponga flecha si solo hay una etapa o sea la ultima etapa
                for (int i = 0; i < c - 1; i++)
                {
                    if (ListEtapaInfo.Count() != 1)
                    {
                        UCflecha = new UCPrd_EtapaFlecha();

                        UCflecha.Left = (i * 130) + UCetapa.Width+10; 
                        if (i == 0)
                            UCflecha.Left = 10 + UCetapa.Width;
                        UCflecha.Top = 40;
                        this.PanelControlEt.Controls.Add(UCflecha);
                    }
                }

                //

                List = ListEtapaInfo;
                progresoBarra(porc);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
            

        }

        public List<prd_EtapaProduccion_Info> pasoListaUC()
        {
            try
            {
                return List;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return new List<prd_EtapaProduccion_Info>();
            }

        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            try
            {
                fr = new FrmPrd_EtapaMantenimiento();
                fr.Set_Accion(Cl_Enumeradores.eTipo_action.grabar);
                fr.IdProcesoProductivo = Convert.ToInt32(this.txt_id.Text);
                fr.listaEtapas = List;
                fr.Show();
                fr.event_FrmPrd_EtapaMantenimiento_FormClosing += fr_event_FrmPrd_EtapaMantenimiento_FormClosing;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());

            }
           
        }

        void fr_event_FrmPrd_EtapaMantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                    carga_modelo();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void FrmPrd_MantProcesoProductivo_Activated(object sender, EventArgs e)
        {
            try
            {
             carga_modelo();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void txt_descripcion_KeyPress(object sender, KeyPressEventArgs e)
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

        private void bloquear()
        {
            try
            {
                ucGe_Menu_Superior_Mant1.Enabled_btnGuardar = false;
                ucGe_Menu_Superior_Mant1.Enabled_bntGuardar_y_Salir = false;
                txt_descripcion.ReadOnly = true;
              
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
               this.txt_descripcion.Focus();
               if (validar() == false)
                   MessageBox.Show("No se guardó", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
               else
               {
                   grabar();
               }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                this.txt_descripcion.Focus();
                if (validar() == false)
                    MessageBox.Show("No se guardó", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    grabar();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                  anular();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
               
        }

        void anular()
        {
            try
            {
                string msg = "";
                prd_ProcesoProductivo_Bus bus_prodesoproductivo = new prd_ProcesoProductivo_Bus();
                bus_prodesoproductivo.AnularItem(info, ref msg);
                MessageBox.Show(msg, "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Set_Accion(Cl_Enumeradores.eTipo_action.consultar);
                LoadForm();
        
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
           
        }


        private void gridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
              carga_modelo();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void ucGe_Menu_Superior_Mant1_event_btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {

                //-- CARLOS ACTALIZACION

                XPRO_CUS_CID_Rpt010 XReport = new XPRO_CUS_CID_Rpt010();
                List<tbPRO_CUS_CID_Rpt010_Info> data = new List<tbPRO_CUS_CID_Rpt010_Info>();
                prd_ObtenerReporte_Bus busSpRpt = new prd_ObtenerReporte_Bus();

                //data = busSpRpt.OptenerData_spPRD_Rpt_RPRD010(param.IdEmpresa, info.IdProcesoProductivo, param.IdUsuario, param.nom_pc);
                //XReport.loadData(data.ToArray());
                //XReport.ShowPreviewDialog();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());

            }
        }

      
























    }
}