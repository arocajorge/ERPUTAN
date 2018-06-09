using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Info.ActivoFijo;
using Core.Erp.Data.ActivoFijo;


namespace Core.Erp.Business.ActivoFijo
{
   public  class Af_Departamento_Bus
    {
        string mensaje = "";

        Af_Departamento_Data Odata = new Af_Departamento_Data();


        public List<Af_Departamento_Info> Get_List_Departamento(int IdEmpresa)
        {
            List<Af_Departamento_Info> lM = new List<Af_Departamento_Info>();

          
            try
            {
                lM=Odata.Get_List_Departamento(IdEmpresa);
                return (lM);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Aca_Institucion_x_Sede_x_Jorn_x_Sec_Curso_x_Para", ex.Message), ex) { EntityType = typeof(Af_Activo_fijo_Categoria_Bus) };
            }
        }

        public Boolean ModificarDB(Af_Departamento_Info info, ref string msg)
        {
            try
            {

                return Odata.ModificarDB(info, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Aca_Institucion_x_Sede_x_Jorn_x_Sec_Curso_x_Para", ex.Message), ex) { EntityType = typeof(Af_Activo_fijo_Categoria_Bus) };
            }
        }

        public int GetId(int idempresa)
        {
            try
            {

                return Odata.GetId(idempresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Aca_Institucion_x_Sede_x_Jorn_x_Sec_Curso_x_Para", ex.Message), ex) { EntityType = typeof(Af_Activo_fijo_Categoria_Bus) };
            }

        }

        public Boolean GrabarDB(Af_Departamento_Info info, ref int id, ref string msg)
        {
            try
            {

                return Odata.GrabarDB(info, ref id, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Aca_Institucion_x_Sede_x_Jorn_x_Sec_Curso_x_Para", ex.Message), ex) { EntityType = typeof(Af_Activo_fijo_Categoria_Bus) };
            }
        }

        public Boolean AnularDB(Af_Departamento_Info info, ref  string msg)
        {
            try
            {
                
                    return Odata.AnularDB(info,ref msg);

                
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Aca_Institucion_x_Sede_x_Jorn_x_Sec_Curso_x_Para", ex.Message), ex) { EntityType = typeof(Af_Activo_fijo_Categoria_Bus) };
            }
        }


    }
}
