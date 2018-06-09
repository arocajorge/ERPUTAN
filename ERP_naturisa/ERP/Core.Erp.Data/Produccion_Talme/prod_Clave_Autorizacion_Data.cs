using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Core.Erp.Info.Produccion_Talme;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.Produccion_Talme
{
    public class prod_Clave_Autorizacion_Data
    {
        string mensaje = "";

        public decimal GetId(int IdEmpresa)
        {
            try
            {
                decimal Id;
                EntitiesProduccion Oenti = new EntitiesProduccion();


                var q = from C in Oenti.prod_Clave_Autorizacion
                        where C.IdEmpresa == IdEmpresa
                        select C;
                if (q.ToList().Count == 0)
                    return 1;
                else
                {

                    var select_ = (from t in Oenti.prod_Clave_Autorizacion
                                   where t.IdEmpresa == IdEmpresa
                                   select t.IdGeneracion).Max();
                    Id = Convert.ToInt32(select_.ToString()) + 1;
                    return Id;
                }              
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }


    public Boolean GuardarDB(List<prod_Clave_Autorizacion_Info> Lst, int IdEMpresa)
	{
		try
		{
            int Secuencia = 1;
            decimal IdGenerado = GetId(IdEMpresa) ;
            foreach (var Info in Lst)
            {
                using (EntitiesProduccion Context = new EntitiesProduccion())
                {
                    var Address = new prod_Clave_Autorizacion();

                    Address.IdEmpresa = Info.IdEmpresa;
                    Address.IdGeneracion = IdGenerado;
                    Address.Secuencia = Secuencia;
                    Address.IdModeloProduccion = Info.IdModeloProduccion;
                    Address.Clave = Info.Clave;
                    Address.IdUsuarioUsoDeClave = Info.IdUsuarioUsoDeClave;
                    Address.FechaUsoDeClave = Info.FechaUsoDeClave;
                    Address.IdUsuarioGeneracion = Info.IdUsuarioGeneracion;
                    Address.FechaGeneracion = Info.FechaGeneracion;
                    Address.IdTransaccion = Info.IdTransaccion;
                    Address.Activo = "A";
                    Secuencia++;
                    Context.prod_Clave_Autorizacion.Add(Address);
                    Context.SaveChanges();
                }
            }
			
		return true;
		}
		catch (Exception ex)
        {
            string arreglo = ToString();
            tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
            tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
            mensaje = ex.ToString() + " " + ex.Message;
            oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
            throw new Exception(ex.ToString());
        }
	}


    public prod_Clave_Autorizacion_Info Get_Info_Clave_Autorizacion(int IdEmpresa, decimal IdGeneracion, int Secuencia)
	{
			EntitiesProduccion oEnti= new EntitiesProduccion();
			prod_Clave_Autorizacion_Info Info = new prod_Clave_Autorizacion_Info() ;
		try
		{

			        var Objeto = oEnti.prod_Clave_Autorizacion.First();
					Info.IdEmpresa= Objeto.IdEmpresa;
					Info.IdGeneracion= Objeto.IdGeneracion;
					Info.Secuencia= Objeto.Secuencia;
					Info.IdModeloProduccion= Objeto.IdModeloProduccion;
					Info.Clave= Objeto.Clave;
					Info.IdUsuarioUsoDeClave= Objeto.IdUsuarioUsoDeClave;
					Info.FechaUsoDeClave= Objeto.FechaUsoDeClave;
					Info.IdUsuarioGeneracion= Objeto.IdUsuarioGeneracion;
					Info.FechaGeneracion= Objeto.FechaGeneracion;
					Info.IdTransaccion= Objeto.IdTransaccion;
					Info.Activo= Objeto.Activo;
				return Info;
			}
		catch (Exception ex)
        {
            string arreglo = ToString();
            tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
            tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
            mensaje = ex.ToString() + " " + ex.Message;
            oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
            throw new Exception(ex.ToString());
        }
		
	}


        public Boolean ValidarClave(int IdEmpresa, string Clave, int IdModeloProduccion) 
        {
            try
            {
                using (EntitiesProduccion entities = new EntitiesProduccion())
                {
                    string Query = "select * from prod_Clave_Autorizacion where IdEmpresa ="+IdEmpresa+" and IdModeloProduccion = "+IdModeloProduccion+" and Clave = '" + Clave + "' and Activo = 'A'";
                    var Consulta = entities.Database.SqlQuery<prod_Clave_Autorizacion_Info>(Query).ToList().First();
                    if (Consulta.Activo == "A") 
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }
    }
}
