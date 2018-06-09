using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Data.Academico;
using Core.Erp.Info.Academico;
using Core.Erp.Business.General;


namespace Core.Erp.Business.Academico
{
    public class Aca_Contrato_x_Estudiante_Bus
    {
      private Aca_Contrato_x_Estudiante_Data da;
      tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();

      public Aca_Contrato_x_Estudiante_Bus() {
          da = new Aca_Contrato_x_Estudiante_Data();
      }

        public List<Aca_Contrato_x_Estudiante_Info> Get_Lista_Contrato_x_Estudiante(int IdInstitucion)
        {
            List<Aca_Contrato_x_Estudiante_Info> lista = new List<Aca_Contrato_x_Estudiante_Info>();
            try
            {
                lista = da.Get_Lista_Contrato_x_Estudiante(IdInstitucion);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Contrato_x_Estudiante", ex.Message), ex) { EntityType = typeof(Aca_Contrato_x_Estudiante_Bus) };
            }
            return lista;
        }


        public List<Aca_Contrato_x_Estudiante_Info> Get_List_Contrato_x_Estudiante(int IdInstitucion, int IdSede)
        {
            List<Aca_Contrato_x_Estudiante_Info> lista = new List<Aca_Contrato_x_Estudiante_Info>();
            try
            {
                lista = da.Get_List_Contrato_x_Estudiante(IdInstitucion, IdSede);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Contrato_x_Estudiante", ex.Message), ex) { EntityType = typeof(Aca_Contrato_x_Estudiante_Bus) };
            }
            return lista;
        }


        public List<Aca_Contrato_x_Estudiante_Info> Get_List_Estudiante_con_Contrato(int IdInstitucion, int IdSede)
        {
            List<Aca_Contrato_x_Estudiante_Info> lista = new List<Aca_Contrato_x_Estudiante_Info>();
            try
            {
                lista = da.Get_List_Estudiante_con_Contrato(IdInstitucion, IdSede);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Contrato_x_Estudiante", ex.Message), ex) { EntityType = typeof(Aca_Contrato_x_Estudiante_Bus) };
            }
            return lista;
        }
        public List<Aca_Contrato_x_Estudiante_Info> Get_List_Contrato_Preparacion_x_Estudiante(int IdInstitucion, int IdSede)
        {
            List<Aca_Contrato_x_Estudiante_Info> lista = new List<Aca_Contrato_x_Estudiante_Info>();
            try
            {
                lista = da.Get_List_Contrato_Preparacion_x_Estudiante(IdInstitucion, IdSede);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Contrato_x_Estudiante", ex.Message), ex) { EntityType = typeof(Aca_Contrato_x_Estudiante_Bus) };
            }
            return lista;
        }
        
        public List<Aca_Contrato_x_Estudiante_Info> Get_List_Estudiante_con_Contrato_x_Periodo(int IdInstitucion, int IdSede, int IdPeriodo)
        {
            List<Aca_Contrato_x_Estudiante_Info> lista = new List<Aca_Contrato_x_Estudiante_Info>();
            try
            {
                lista = da.Get_List_Estudiante_con_Contrato_x_Periodo(IdInstitucion, IdSede, IdPeriodo);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Contrato_x_Estudiante", ex.Message), ex) { EntityType = typeof(Aca_Contrato_x_Estudiante_Bus) };
            }
            return lista;
        }


        public bool GrabarDB(Aca_Contrato_x_Estudiante_Info info, ref int IdContrato_x_Estudiante, ref string mensaje)
        {
            bool resultado = false;
            try
            {
                resultado = da.GrabarDB(info, ref IdContrato_x_Estudiante, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(Aca_Contrato_x_Estudiante_Bus) };
            }
            return resultado;
        }
        public bool AnularDB(Aca_Contrato_x_Estudiante_Info info, ref string mensaje)
        {
            bool resultado = false;
            try
            {
                resultado = da.AnularDB(info, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarDB", ex.Message), ex) { EntityType = typeof(Aca_Contrato_x_Estudiante_Bus) };
            }
            return resultado;
        }
    }
}
