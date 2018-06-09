using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Academico;
using Core.Erp.Data.Academico;
using Core.Erp.Business.General;
using Core.Erp.Info.Facturacion;
using Core.Erp.Business.Facturacion;
using Core.Erp.Info.General;
using Core.Erp.Data.General;
namespace Core.Erp.Business.Academico
{
  public  class Aca_Pre_Facturacion_Bus
    {

      Aca_Pre_Facturacion_Data data = new Aca_Pre_Facturacion_Data();
      cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
      fa_Cliente_Bus fa_cliente_data = new fa_Cliente_Bus();
      List<fa_Cliente_Info> lista_cliente = new List<fa_Cliente_Info>();
      fa_parametro_Bus fa_param = new fa_parametro_Bus();
      fa_parametro_info fa_param_info = new fa_parametro_info();
      Aca_Familiar_Data data_familiar = new Aca_Familiar_Data();


      List<tb_persona_Info> lista = new List<tb_persona_Info>();

      decimal Idcliente = 0;
      decimal IdPersona = 0;

        public Boolean GrabarDB(Aca_Pre_Facturacion_Info Info, ref string msg)
        {
            try
            {
                Get_convertir_perosno_x_estudiante_a_client();
                foreach (var item in lista_cliente)
                {
                    fa_cliente_data.GrabarDB(item, ref IdPersona, ref Idcliente, ref msg);

                }


                return data.GrabarDB(Info, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Rubro", ex.Message), ex) { EntityType = typeof(Aca_Rubro_Bus) };
      
            }
        }
        public Boolean Procesar_Pre_Fact(Aca_Pre_Facturacion_Info Info,int IdSede, ref string msg)
        {
            try
            {
                Get_convertir_perosno_x_estudiante_a_client();
                foreach (var item in lista_cliente)
                {
                    fa_cliente_data.GrabarDB(item, ref IdPersona, ref Idcliente, ref msg);

                }
                return data.Procesar_Pre_Fact(Info,IdSede, ref msg);

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Rubro", ex.Message), ex) { EntityType = typeof(Aca_Rubro_Bus) };

            }
        }
        public Boolean ModificarDB(Aca_Pre_Facturacion_Info Info, ref string msg)
        {
            try
            {
                Get_convertir_perosno_x_estudiante_a_client();
                foreach (var item in lista_cliente)
                {
                    fa_cliente_data.GrabarDB(item, ref IdPersona, ref Idcliente, ref msg);

                }
                return data.ModificarDB(Info, ref msg);

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Rubro", ex.Message), ex) { EntityType = typeof(Aca_Rubro_Bus) };
      
            }
        }
        public List<Aca_Pre_Facturacion_Info> Get_List(int IdInstitucion)
        {
            try
            {
                return data.Get_List(IdInstitucion);

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List", ex.Message), ex) { EntityType = typeof(Aca_Rubro_Bus) };

            }
        }

        private List<fa_Cliente_Info> Get_convertir_perosno_x_estudiante_a_client()
        {
            try
            {
                lista = data_familiar.Get_List_Persona_Por_Estudiante_();
                //string
                //data_familiar.GetFamiliar_x_Estudiante

               
                fa_param_info = fa_param.Get_Info_parametro(1); //idEmpresa

                 lista_cliente = new List<fa_Cliente_Info>();
                foreach (var item in lista)
                {
                    fa_Cliente_Info info_clie = new fa_Cliente_Info();
                    string IdCiudadFamiliar = "";

                    info_clie.IdEmpresa = param.IdEmpresa;
                    info_clie.IdCliente = 0;
                    info_clie.Codigo = item.IdPersona.ToString();
                    info_clie.IdPersona = item.IdPersona;
                    info_clie.IdSucursal = param.IdSucursal;
                    info_clie.IdVendedor = 1; // NO DISPONIBLE
                    info_clie.Idtipo_cliente = 1; //NO TIENE QUE VER CON LA FACTURA
                    info_clie.IdTipoCredito = "CON";
                    info_clie.cl_Cat_crediticia = "S";
                    info_clie.cl_plazo=0;
                    info_clie.cl_porcentaje_descuento = 0; //
                    info_clie.IdCtaCble_cxc = fa_param_info.IdCtaCble_CXC_Vtas_x_Default;//******************
                    info_clie.IdCtaCble_Anti = fa_param_info.IdCtaCble_x_anticipo_cliente;//******************
                    info_clie.cl_Cell_Garante = "S/N";
                    info_clie.cl_Cell_Garante = "S/N";
                    info_clie.cl_Garante = "S/N";
                    info_clie.cl_Mail_Garante = "S/N";
                    info_clie.cl_observacion = "S/N";
                    ////info_clie.IdCiudad = "1";

                    IdCiudadFamiliar = data_familiar.GetInfo_Familiar_x_IdPersona(item.IdPersona, item.pe_cedulaRuc).IdCiudad;
                    if (IdCiudadFamiliar != null)
                    {
                        info_clie.IdCiudad = IdCiudadFamiliar;
                    }
                    else
                    {
                        info_clie.IdCiudad = "09";
                    }
                    

                    //info_clie.IdCiudad = "09";
                   


                    //info_clie.IdCiudad = item.IdCi;

                    info_clie.cl_Cupo = 0; // SOLO POR RETAIL
                    info_clie.IdClienteRelacionado = null;
                    info_clie.cl_Rep_Legal= null;
                    info_clie.cl_Mail_Rep_Legal= null;
                    info_clie.cl_Cell_Rep_Legal= null;
                    info_clie.cl_Ger_Gen= null;
                    info_clie.cl_Mail_Ger_Gen= null;
                    info_clie.cl_Cell_Ger_Gen = null;
                    info_clie.cl_casilla = " ";
                    info_clie.cl_fax=" ";

                    info_clie.IdActividadComercial="NORM";

                    info_clie.IdUsuario="";
                    info_clie.Fecha_Transac=DateTime.Now;
                    info_clie.Estado = "A";
                    info_clie.Mail_Principal = ".";
                    info_clie.Mail_Secundario1= null;
                    info_clie.Mail_Secundario2= null;
                    info_clie.IdCentroCosto_CXC= null;
                    info_clie.IdCentroCosto_Anticipo= null;
                    info_clie.IdCentroCosto_CXC_Credito= null;
                    info_clie.IdCtaCble_cxc_Credito= null;
                    info_clie.IdParroquia= null;
                    info_clie.Persona_Info = item;
                    lista_cliente.Add(info_clie);

                }

                return lista_cliente;

            }
            catch (Exception ex)
            {
                
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List", ex.Message), ex) { EntityType = typeof(Aca_Rubro_Bus) };
            }
        }
        public int getId_pre_Facturacion(int IdAnioLectivo, int idPeriodo)
        {
            try
            {
                return data.getId_pre_Facturacion(IdAnioLectivo, idPeriodo);

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List", ex.Message), ex) { EntityType = typeof(Aca_Rubro_Bus) };

            }
        }
        public Boolean Modificar_Estado_Prefacturacion_DB(Aca_Pre_Facturacion_Info Info, ref string msg)
        {
            try
            {

                return data.Modificar_Estado_Prefacturacion_DB(Info,ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Catalogo", ex.Message), ex) { EntityType = typeof(Aca_Catalogo_Bus) };


            }
        }
    }
}
