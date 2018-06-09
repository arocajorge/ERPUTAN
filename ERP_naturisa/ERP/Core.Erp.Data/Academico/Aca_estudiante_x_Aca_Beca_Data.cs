using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Core.Erp.Info.Academico;
using Core.Erp.Info.General;
using Core.Erp.Data.General;


namespace Core.Erp.Data.Academico
{
   public class Aca_estudiante_x_Aca_Beca_Data
    {


        #region "Get"



       //public List<Aca_estudiante_x_Aca_Beca_Info> Get_List_estudiante_x_Aca_Beca(int IdInstitucion)
       // {
       //     List<Aca_estudiante_x_Aca_Beca_Info> listEstudia_x_Beca = new List<Aca_estudiante_x_Aca_Beca_Info>();
       //     try
       //     {
       //         using (Entities_Academico Base = new Entities_Academico())
       //         {
       //             var vaspirante = from a in Base.vwAca_estudiante_x_Aca_Beca
       //                              where a.IdInstitucion == IdInstitucion
       //                              select a;

       //             foreach (var item in vaspirante)
       //             {
       //                 Aca_estudiante_x_Aca_Beca_Info info = new Aca_estudiante_x_Aca_Beca_Info();
       //                 info.IdInstitucion = item.IdInstitucion;
       //                 info.IdBeca1=item.IdBeca1;
       //                 info.IdBeca2=item.IdBeca2;
       //                 info.IdBeca3=item.IdBeca3;
       //                 info.IdEstudiante=item.IdEstudiante;
       //                 info.FechaEmisionBeca1=item.FechaEmisionBeca1;
       //                 info.FechaEmisionBeca2=item.FechaEmisionBeca2;
       //                 info.FechaEmisionBeca3=item.FechaEmisionBeca3;
                        

       //                 listEstudia_x_Beca.Add(info);
       //             }

       //         }
       //         return listEstudia_x_Beca;
       //     }
       //     catch (Exception ex)
       //     {
       //         string arreglo = ToString();
       //         string MensajeError = string.Empty;
       //         tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
       //         tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
       //         MensajeError = ex.InnerException + " " + ex.Message;
       //         oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);

       //         throw new Exception(ex.InnerException.ToString());
       //     }

       // }
        #endregion

        #region "Insert,update, delete"
        //public bool GrabarDB(Aca_estudiante_x_Aca_Beca_Info info, ref string msj)
        //{
        //    try
        //    {
        //        using (Entities_Academico context = new Entities_Academico())
        //        {

        //            Aca_estudiante_x_Aca_Beca address_Est_x_Beca = new Aca_estudiante_x_Aca_Beca();

        //            address_Est_x_Beca.IdInstitucion = info.IdInstitucion;
        //            address_Est_x_Beca.IdBeca1 = info.IdBeca1;
        //            address_Est_x_Beca.IdBeca2 = info.IdBeca2;
        //            address_Est_x_Beca.IdBeca3 = info.IdBeca3;
        //            address_Est_x_Beca.IdEstudiante = info.IdEstudiante;
        //            address_Est_x_Beca.FechaEmisionBeca1 = info.FechaEmisionBeca1;
        //            address_Est_x_Beca.FechaEmisionBeca2 = info.FechaEmisionBeca2;
        //            address_Est_x_Beca.FechaEmisionBeca3 = info.FechaEmisionBeca3;
 
        //            context.Aca_estudiante_x_Aca_Beca.Add(address_Est_x_Beca);
        //            context.SaveChanges();
        //            msj = "Se ha procedido a grabar exitosamente.";
        //        }
        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        string arreglo = ToString();
        //        tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
        //        tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
        //                            "", "", "", "", DateTime.Now);
        //        oDataLog.Guardar_Log_Error(Log_Error_sis, ref msj);
        //        msj = ex.InnerException + " " + ex.Message;
        //        throw new Exception(ex.InnerException.ToString());
        //    }
        //}

        //public Boolean ActualizarDB(Aca_estudiante_x_Aca_Beca_Info info, ref string msj)
        //{
        //    try
        //    {

        //        using (Entities_Academico context = new Entities_Academico())
        //        {
        //            var estudiante = context.Aca_estudiante_x_Aca_Beca.FirstOrDefault(obj => obj.IdInstitucion == info.IdInstitucion 
        //                && obj.IdEstudiante == info.IdEstudiante);

        //            if (estudiante != null)
        //            {

        //                estudiante.IdBeca1 = info.IdBeca1;
        //                estudiante.IdBeca2 = info.IdBeca2;
        //                estudiante.IdBeca3 = info.IdBeca3;
        //                estudiante.FechaEmisionBeca1 = info.FechaEmisionBeca1;
        //                estudiante.FechaEmisionBeca2 = info.FechaEmisionBeca2;
        //                estudiante.FechaEmisionBeca3 = info.FechaEmisionBeca3;


        //                context.SaveChanges();

        //                msj = "Se ha procedido actualizar Beca x Est #: exitosamente.";
        //            }
        //            return true;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        string arreglo = ToString();
        //        tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
        //        tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
        //        msj = ex.InnerException + " " + ex.Message;
        //        oDataLog.Guardar_Log_Error(Log_Error_sis, ref msj);
        //        msj = "Se ha producido el siguiente error: " + ex.Message;
        //        throw new Exception(ex.InnerException.ToString());
        //    }
        //}


        
        #endregion


        

    }
}
