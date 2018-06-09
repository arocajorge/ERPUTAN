using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;
using Core.Erp.Info.General;
using Core.Erp.Data.General;
using Core.Erp.Business.General;
using Core.Erp.Info.Academico;
using Core.Erp.Business.Academico;
using Core.Erp.Info.SeguridadAcceso;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Business.Inventario;
using Core.Erp.Info.Inventario;

namespace Core.Erp.Business.General
{

    public sealed class cl_parametrosGenerales_Bus
    {

        static readonly cl_parametrosGenerales_Bus instance = new cl_parametrosGenerales_Bus();
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        tb_sis_Grupo_empresarial_Cliente_Bus OGrupo_Empresa_para_Reglas_Negocio = new tb_sis_Grupo_empresarial_Cliente_Bus();
        
        List<tb_sis_Mensajes_sys_Info> listaMensaje = new List<tb_sis_Mensajes_sys_Info>();
        tb_sis_Mensajes_sys_Bus BusMensaje = new tb_sis_Mensajes_sys_Bus();


        List<tb_parametro_Info> listParametros = new List<tb_parametro_Info>();
        tb_parametro_Bus BusParametros = new tb_parametro_Bus();

        List<in_Producto_Info> List_Producto = new List<in_Producto_Info>();
        in_producto_Bus Bus_Producto = new in_producto_Bus();


        public Cl_Enumeradores.eCliente_Vzen IdCliente_Ven_x_Default { get; set; }
        

        string mensaje = "";

        public int IdEmpresa { get; set; }
        public String NombreEmpresa { get; set; }
        public string Nombre_sistema { get; set; }
        public String IdUsuario { get; set; }
        public String nom_pc { get; set; }
        public String ip { get; set; }
        public int IdInstitucion { get; set; }
        public tb_sis_impuesto_Info iva { get; set; }
        public int IdSucursal { get; set; }
        public tb_Empresa_Info InfoEmpresa = new tb_Empresa_Info();
        public Aca_Institucion_Info InfoInstitucion = new Aca_Institucion_Info();
        public tb_Sucursal_Info InfoSucursal = new tb_Sucursal_Info();
        public seg_usuario_info InfoUsuario = new seg_usuario_info();
        public string em_Email { get; set; }
        


        IPHostEntry host;

        public List<tb_sis_Grupo_empresarial_Cliente_Info>   Grupo_Empresarial_Clientes_Vzen_para_reglas_negocio_list 
        { 
                get{
                    return OGrupo_Empresa_para_Reglas_Negocio.Get_List_Grupo_empresarial_Cliente(ref mensaje);
                   }
        }
        
        public DateTime Fecha_Transac 
        {
            get { return GetDateServer(); }
        }


        public bool Validar_periodo_cerrado_x_modulo(int IdEmpresa, Cl_Enumeradores.eModulos IdModulo, DateTime Fecha)
        {
            try
            {
                string MensajeError = "";
                ct_Periodo_Info info_periodo = new ct_Periodo_Info();
                ct_Periodo_Bus bus_periodo = new ct_Periodo_Bus();

                info_periodo = bus_periodo.Get_Info_Periodo(IdEmpresa, Fecha, ref MensajeError);
                if (info_periodo == null)
                {
                    MessageBox.Show("El periodo no se encuentra registrado en el sistema.",Nombre_sistema,  MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                ct_periodo_x_tb_modulo_Bus bus_periodo_x_modulo = new ct_periodo_x_tb_modulo_Bus();
                if (bus_periodo_x_modulo.Esta_modulo_cerrado_x_periodo(IdEmpresa, IdModulo , info_periodo.IdPeriodo))
                {
                    MessageBox.Show("El periodo se encuentra cerrado para el Modulo:." + IdModulo.ToString(), Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                //Valido contabilidad ya que las pantallas estan atadas a contabilidad
                if (bus_periodo_x_modulo.Esta_modulo_cerrado_x_periodo(IdEmpresa, Cl_Enumeradores.eModulos.CONTA , info_periodo.IdPeriodo))
                {
                    MessageBox.Show("El periodo en el modulo Contabilidad en el que intenta realizar la transacción se encuentra cerrado.", Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
                return true;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public bool Validar_periodo_cerrado_x_modulo(int IdEmpresa, Cl_Enumeradores.eModulos IdModulo, int IdPeriodo)
        {
            try
            {
                ct_periodo_x_tb_modulo_Bus bus_periodo_x_modulo = new ct_periodo_x_tb_modulo_Bus();
                if (bus_periodo_x_modulo.Esta_modulo_cerrado_x_periodo(IdEmpresa, IdModulo, IdPeriodo))
                {
                    MessageBox.Show("El periodo en el que intenta realizar la transacción se encuentra cerrado.", Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
        

        static cl_parametrosGenerales_Bus() { }

        cl_parametrosGenerales_Bus()
        {
            try
            {
                try
                {
                    nom_pc = Dns.GetHostName();  //Obtengo el nombre de la PC solo aplica cuando el sistema corre dentro de la PC no para web
                    host = Dns.GetHostEntry(Dns.GetHostName());
                    foreach (IPAddress ip_pc in host.AddressList)
                    {
                        if (ip_pc.AddressFamily.ToString() == "InterNetwork")
                        {
                            ip = ip_pc.ToString();
                        }
                    }   
                }
                catch (Exception ex)
                {//continuar
                }


                BusMensaje.CompararEnum_vs_DB();

                listaMensaje = BusMensaje.Get_List_sis_Mensajes_sys();
                listParametros = BusParametros.Get_List_parametro();

                Nombre_sistema = Get_Mensaje_sys(enum_Mensajes_sys.Nombre_sistema);
                string sIdIva = "";

                 sIdIva = Convert.ToString(Get_Parametro_Info(tb_parametro_enum.P_IVA).Valor);


                 tb_sis_impuesto_Bus BusTipoImp = new tb_sis_impuesto_Bus();
                 tb_sis_impuesto_Info Info_TipoImp = new tb_sis_impuesto_Info();

                 Info_TipoImp = BusTipoImp.Get_Info_impuesto(sIdIva);

                 iva = Info_TipoImp;

                 string SIdCliente_Vzen = "";


                 try
                 {
                     SIdCliente_Vzen = Convert.ToString(Get_Parametro_Info(tb_parametro_enum.P_CLIENTE_VZEN).Valor);
                 }
                 catch (Exception ex)
                 {
                     BusParametros.GuardarDB(new tb_parametro_Info(tb_parametro_enum.P_CLIENTE_VZEN.ToString(), "string", Cl_Enumeradores.eCliente_Vzen.GENERAL.ToString()), ref mensaje);
                 }
                 
                 if (SIdCliente_Vzen == null || SIdCliente_Vzen == "")
                 { IdCliente_Ven_x_Default = Cl_Enumeradores.eCliente_Vzen.GENERAL; }
                 else
                 { IdCliente_Ven_x_Default = (Cl_Enumeradores.eCliente_Vzen)Enum.Parse(typeof(Cl_Enumeradores.eCliente_Vzen), SIdCliente_Vzen); }



                

            }
            catch (Exception ex)
            {
                // si se cae solo continuar 
                //Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                //throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "no se puede acceder a la base o ", ex.Message), ex) { EntityType = typeof(cl_parametrosGenerales_Bus) };
               
            }
        }

        public string Get_Mensaje_sys(enum_Mensajes_sys IdMensaje)
        {
            try
            {
               tb_sis_Mensajes_sys_Info InfoMensaje=  listaMensaje.FirstOrDefault(v => v.IdMensaje == IdMensaje.ToString());
               return InfoMensaje.Mensaje_Esp;
            }
            catch (Exception ex)
            {
                throw;
            }
        }



     

        public tb_parametro_Info Get_Parametro_Info(tb_parametro_enum IdParametro)
        {
            try
            {
                tb_parametro_Info InfoMensaje = listParametros.FirstOrDefault(v => v.IdParametro == IdParametro.ToString());
                return InfoMensaje;
            }
            catch (Exception ex)
            {
                return new tb_parametro_Info();
            }
        }

        public DateTime GetDateServer()
        {
            try
            {

                Cl_Parametros_data ParD = new Cl_Parametros_data();
                return ParD.GetDateServer();

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Obtener_Bodegas", ex.Message), ex) { EntityType = typeof(cl_parametrosGenerales_Bus) };
         
            }

        }

        public static cl_parametrosGenerales_Bus Instance
        {
            get { return instance; }
        }
    }
}

