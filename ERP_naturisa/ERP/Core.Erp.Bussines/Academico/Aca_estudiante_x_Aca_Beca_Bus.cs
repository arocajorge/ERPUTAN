using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Info.Academico;
using Core.Erp.Data.Academico;
using Core.Erp.Business.General;



namespace Core.Erp.Business.Academico
{
   public class Aca_estudiante_x_Aca_Beca_Bus
    {


        #region "Get"

       Aca_estudiante_x_Aca_Beca_Data Odata = new Aca_estudiante_x_Aca_Beca_Data();

       public Aca_estudiante_x_Aca_Beca_Bus()
       {

       }

       //public List<Aca_estudiante_x_Aca_Beca_Info> Get_List_estudiante_x_Aca_Beca(int IdInstitucion)
       // {
       //     List<Aca_estudiante_x_Aca_Beca_Info> listEstudia_x_Beca = new List<Aca_estudiante_x_Aca_Beca_Info>();
       //     try
       //     {
       //         listEstudia_x_Beca = Odata.Get_List_estudiante_x_Aca_Beca(IdInstitucion);
       //         return listEstudia_x_Beca;
       //     }
       //     catch (Exception ex)
       //     {
       //         Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
       //         throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Aspirante", ex.Message), ex) { EntityType = typeof(Aca_Aspirante_Bus) };
       //     }

       // }
        #endregion

        #region "Insert,update, delete"
        //public bool GrabarDB(Aca_estudiante_x_Aca_Beca_Info info, ref string msj)
        //{
        //    try
        //    {

        //        return Odata.GrabarDB(info, ref msj);
        //    }
        //    catch (Exception ex)
        //    {
        //        Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
        //        throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Aspirante", ex.Message), ex) { EntityType = typeof(Aca_Aspirante_Bus) };
        //    }
        //}

        //public Boolean ActualizarDB(Aca_estudiante_x_Aca_Beca_Info info, ref string msj)
        //{
        //    try
        //    {
        //        return Odata.ActualizarDB(info, ref msj);
                
        //    }
        //    catch (Exception ex)
        //    {
        //        Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
        //        throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Aspirante", ex.Message), ex) { EntityType = typeof(Aca_Aspirante_Bus) };
        //    }
        //}



        #endregion



    }
}
