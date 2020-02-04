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
using System.Globalization;

namespace Core.Erp.Winform.General
{
    public partial class FrmGe_CalendarioFeriado_Mant : Form
    {
        #region Declaración de Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        tb_Calendario_Info Info = new tb_Calendario_Info();
        tb_Calendario_Bus BUS = new tb_Calendario_Bus();
        tb_Dia_Bus tb_Dia_Bus = new tb_Dia_Bus();
        tb_Mes_Bus tb_Mes_Bus = new tb_Mes_Bus();
        List<tb_Dia_Info> D = new List<tb_Dia_Info>();
        List<tb_Mes_info> M = new List<tb_Mes_info>();
        private Cl_Enumeradores.eTipo_action _Accion;
        public void set_Accion(Cl_Enumeradores.eTipo_action iAccion) { _Accion = iAccion; }
        public tb_Calendario_Info SETINFO_ { get; set; }
        public delegate void delegate_FrmGe_CalendarioFeriado_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_FrmGe_CalendarioFeriado_Mant_FormClosing event_FrmGe_CalendarioFeriado_Mant_FormClosing;
        string dia = "";
        string mes = "";
        string anio = "";
        int unido = 0;
        string mensaje = "";
        int contador = 0;
        #endregion
       
        public FrmGe_CalendarioFeriado_Mant()
        {
            try
            {
             InitializeComponent();
             event_FrmGe_CalendarioFeriado_Mant_FormClosing +=      FrmGe_CalendarioFeriado_Mant_event_FrmGe_CalendarioFeriado_Mant_FormClosing;            

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
        }

        void FrmGe_CalendarioFeriado_Mant_event_FrmGe_CalendarioFeriado_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            //throw new NotImplementedException();
        }
       
        public Boolean GETINFO() {
            try
            {
                //21112013
            
            D = tb_Dia_Bus.Get_List_Dia();
            M = tb_Mes_Bus.Get_List_Mes();            

            Info.IdCalendario = Convert.ToInt32(txtId.EditValue);
            Info.fecha	= Convert.ToDateTime(anio+"-"+mes+"-"+dia);

            foreach (var item in M)
	        {
                string letra = "";
		         if(Convert.ToInt32(mes) == item.idMes){
                    if(Convert.ToInt32(anio)> 2000){
                        letra = "del";
                        Info.NombreFecha =Convert.ToString(Convert.ToInt32(dia)+" "+"de"+" "+ item.smes +" "+ letra +" "+ Convert.ToInt32(anio));
                     }else{
                      letra = "de";
                        Info.NombreFecha =Convert.ToString(Convert.ToInt32(dia)+" "+"de"+" "+ item.smes +" "+ letra +" "+ Convert.ToInt32(anio));
                     }
                 }
	        }

            foreach (var item in M)
	        {             
		         if(Convert.ToInt32(mes) == item.idMes){
                    string A = anio.Remove(0,2);
                    Info.NombreCortoFecha =Convert.ToString(Convert.ToInt32(dia)+ " " + item.nemonico +" "+ A);
                 }
	        }

            //DIA POR SEMANA     
            foreach (var item in D)
	        {
		         DateTime Com = new DateTime(Convert.ToInt32(anio), Convert.ToInt32(mes), Convert.ToInt32(dia));
                    if ((Com.DayOfWeek).ToString() == item.sdiaIngles) {
                        Info.dia_x_semana =item.idDia;
                    }
	        }
            //22112013
            Info.dia_x_mes = Convert.ToInt32(dia);
            //INICIAL DEL DIA
            DateTime Inicio = new DateTime(Convert.ToInt32(anio), Convert.ToInt32(mes), Convert.ToInt32(dia));                    
            string f = Inicio.ToString("ddd", new CultureInfo("es-ES"));
            f = (f.Remove(1, 2)).ToUpper() + f.Remove(0, 1);
            f = f.Remove(2, 1);
            Info.Inicial_del_Dia = f;

            //NOMBRE DEL DIA
            string g = Inicio.ToString("dddd", new CultureInfo("es-ES"));            
            g = (g.Remove(1, g.Length - 1)).ToUpper() + g.Remove(0, 1);
            Info.NombreDia	=	g;

            //MES POR AÑO
            Info.Mes_x_anio	=	Convert.ToInt32(mes);

            //NOMBRE DEL MES
            foreach (var item in M)
	        {
		         if(Convert.ToInt32(mes) == item.idMes)
                     Info.NombreMes	= item.smes;
	        }
            //ID DEL MES
            Info.IdMes	=Convert.ToInt32(anio + mes);

            //NOMBRE CORTO DEL MES
            foreach (var item in M)
	        {
		         if(Convert.ToInt32(mes)== item.idMes)
                     Info.NombreCortoMes = item.nemonico + " " + anio;
	        }
            
            //AÑO FISCAL
            Info.AnioFiscal	= Convert.ToInt32(anio);

            //SEMANA POR AÑO
            Info.Semana_x_anio	=	 CultureInfo.CurrentUICulture.Calendar.GetWeekOfYear(Inicio, 
                CalendarWeekRule.FirstDay, Inicio.DayOfWeek);
            //NOMBRE SEMANA
            Info.NombreSemana	= Convert.ToString("Sem#:"+" "+Info.Semana_x_anio+" "+anio);

            //ID SEMANA
            string IDSEMANA = Convert.ToString(Info.Semana_x_anio);
            if( IDSEMANA.Length == 1)          
            {
                IDSEMANA = "0"+IDSEMANA;           
                Info.IdSemana = Convert.ToInt32(anio+IDSEMANA);
            }else
	            {
                    Info.IdSemana = Convert.ToInt32(anio + Convert.ToString(Info.Semana_x_anio));
	            }

            //TRIMESTRE POR AÑO
            int trimester = (Inicio.Month - 1) / 3 + 1;            
            Info.Trimestre_x_Anio	= trimester;

            //NOMBRE DEL TRIMESTRE            
            Info.NombreTrimestre	=	Convert.ToString("Tri#:"+" "+Info.Trimestre_x_Anio+" "+anio);

            //IDTRIMESTRE
            string trim = Convert.ToString(trimester);
            trim = (trim.Length == 1) ? ("0" + trim) : trim;
            Info.IdTrimestre	=Convert.ToInt32(anio+trim);

            //IDPERIODO
            Info.IdPeriodo = Convert.ToString(Info.IdMes);

            //ES FERIADO
            Info.EsFeriado	=	(cmbFeriado.SelectedItem == "Si") ? "S" : "N";

            return true;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
                return false;
            }

        }

        public void SETINFO()
        {
            try
            {
                         txtId.EditValue = SETINFO_.IdCalendario;
                    //MOVER CARACTERES
                    string ids = Convert.ToString(SETINFO_.IdCalendario);//IDFECHA
                    string fecha1 = "";
                    string fecha2 = "";
                    for (int i = 0; i < ids.Length; i++)
                    {
                        fecha2 = ids;
                        if (i == 4)
                        {
                            fecha1 = fecha2.Remove(i, 4);
                        }
                        else
                        {
                            if (i == 5)
                            {
                                fecha2 = fecha2.Remove(0, 4);
                                fecha1 = fecha1 + "/" + fecha2.Remove(2, 2);
                            }
                            else
                            {
                                if (i == 7)
                                {
                                    fecha2 = fecha2.Remove(0, 6);
                                    fecha1 = fecha1 + "/" + fecha2;
                                }
                            }
                        }
                    }
                    dtpFecha.DateTime = Convert.ToDateTime(fecha1);

                    //ES FERIADO
                    cmbFeriado.SelectedIndex = (SETINFO_.EsFeriado == "S") ? 1 : 0;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
        }

        public Boolean Grabar()
        {
            try
            {
                if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    if (GETINFO() == false)
                    {
                        MessageBox.Show("Problemas en la Actualización de los Datos.", "Operación Fallida");
                        return false;
                    }

                    if(BUS.ExisteIDCalendario(Info.IdCalendario)== true){
                        MessageBox.Show("La fecha"+" "+Info.fecha+" "+"ya se Encuentra Registrada,\n Por favor ingrese otra fecha.");
                        return false;
                    }

                    if (BUS.GrabarDB(Info) == false)
                    {
                        MessageBox.Show("Problemas al Actualizar el Valor Total del Sueldo.");
                        return false;
                    }
                    MessageBox.Show("Se ha procedido ha Guardar la Información Exitosamente.", "Operación Exitosa");
                    this.ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                    this.ucGe_Menu.Visible_btnGuardar = false;
                }

                //Accion para actualizar el registro
                if (_Accion == Cl_Enumeradores.eTipo_action.actualizar)
                {                    
                    if (GETINFO() == null)
                    {
                        MessageBox.Show("Problemas en la Actualización de los Datos", "Operación Fallida");
                        return false;
                    }

                    if (BUS.ModificarD(Info) == false)
                    {
                        MessageBox.Show("Problemas al Actualizar el valor Total del Sueldo");
                        return false;
                    }
                                       
                    MessageBox.Show("Se ha procedido ha Actualizar la Información Exitosamente.", "Operación Exitosa");
                    this.ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                    this.ucGe_Menu.Visible_btnGuardar = false;       
                }
                
                return true;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
                return false;
            }

        }

        private void FrmGe_CalendarioFeriado_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                 txtId.Enabled = false;
            switch (_Accion)
            {
                case Cl_Enumeradores.eTipo_action.grabar:
                    dtpFecha.DateTime = System.DateTime.Now;
                    cmbFeriado.SelectedIndex = 0;
                    break;
                case Cl_Enumeradores.eTipo_action.actualizar:
                    SETINFO();
                    txtId.Enabled = false;
                    dtpFecha.Enabled = false;
                    break;
                case Cl_Enumeradores.eTipo_action.Anular:
                    break;
                case Cl_Enumeradores.eTipo_action.consultar:
                    SETINFO();
                    this.ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                    this.ucGe_Menu.Visible_btnGuardar = false;                     
                    dtpFecha.Enabled = false;
                    break;
                default:
                    break;
            } 
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }  
        }

        private void dtpFecha_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
            TomarFecha();
            if (contador >= 1) 
              txtId.EditValue = unido;
              contador++;   
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
                                     
        }

        void TomarFecha() {

            try
            {
                  dia = Convert.ToString(dtpFecha.DateTime.Day);
                mes = Convert.ToString(dtpFecha.DateTime.Month);
                anio = Convert.ToString(dtpFecha.DateTime.Year);

            if (dia.Length == 1)
                dia = "0" + dia;

            if (mes.Length == 1)
                mes = "0" + mes;

            unido = Convert.ToInt32(anio + "" + mes + "" + dia);  
            }
            catch (Exception ex)
            {
                 Log_Error_bus.Log_Error(ex.ToString());
                 MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }          
        }

        private void FrmGe_CalendarioFeriado_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                event_FrmGe_CalendarioFeriado_Mant_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
           
        }
       
        private void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {

            try
            {
                Grabar();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
            
        }

        private void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                Grabar();
                Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
        }

        private void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
        }
    }
}
