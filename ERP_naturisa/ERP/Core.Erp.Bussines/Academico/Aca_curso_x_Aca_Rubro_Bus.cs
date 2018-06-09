using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Academico;
using Core.Erp.Data.Academico;


namespace Core.Erp.Business.Academico
{
    public class Aca_curso_x_Aca_Rubro_Bus
    {
        Aca_curso_x_Aca_Rubro_Data oData = new Aca_curso_x_Aca_Rubro_Data();

        public List<Aca_curso_x_Aca_Rubro_Info> Get_List_Rubros_x_Curso(int IdCurso, ref string mensaje)
        {
            try
            {
                List<Aca_curso_x_Aca_Rubro_Info> lista = new List<Aca_curso_x_Aca_Rubro_Info>();
                lista = oData.Get_List_Rubros_x_Curso(IdCurso, ref mensaje);
                return lista;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format(mensaje, "GrabarDB", ex.Message), ex) { EntityType = typeof(Aca_Curso_Bus) };
            }
        }

        public Boolean GuardarDB(Aca_curso_x_Aca_Rubro_Info Info, ref string mensaje)
        {
            try
            {
                return oData.GuardarDB(Info, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format(mensaje, "GrabarDB", ex.Message), ex) { EntityType = typeof(Aca_Curso_Bus) };
            }
        }

        public Boolean GuardarDB(List<Aca_curso_x_Aca_Rubro_Info> List_Info, ref string mensaje)
        {
            try
            {
                return oData.GuardarDB(List_Info, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format(mensaje, "GrabarDB", ex.Message), ex) { EntityType = typeof(Aca_Curso_Bus) };
            }
        }


        public bool EliminarDB(int IdCurso, ref string mensaje)
        {
            try
            {
                return oData.EliminarDB(IdCurso, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format(mensaje, "GrabarDB", ex.Message), ex) { EntityType = typeof(Aca_Curso_Bus) };
            }
        }

    }
}
