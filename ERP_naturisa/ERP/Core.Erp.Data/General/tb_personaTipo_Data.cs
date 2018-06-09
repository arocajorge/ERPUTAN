using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.General
{

    public class tb_personaTipo_Data
    {

        //string mensaje = "";
        //public List<tb_personaTipo_Info> Get_List_personaTipo(decimal IdPersona)
        //{

        //    try
        //    {

        //        List<tb_personaTipo_Info> lM = new List<tb_personaTipo_Info>();
        //        //EntitiesGeneral OEselecEmpresa = new EntitiesGeneral();

        //        //var selectPersona = from C in OEselecEmpresa.tb_PersonaTipo
        //        //                    join Per in OEselecEmpresa.tb_personaxPersonaTipo
        //        //                    on C.IdTipoPersona equals Per.IdPersonaTipo
        //        //                    where Per.IdPersona == IdPersona
        //        //                    select C;

        //        //foreach (var item in selectPersona)
        //        //{

        //        //    tb_personaTipo_Info Cbt = new tb_personaTipo_Info();

        //        //    Cbt.idTipoPersona = item.IdTipoPersona;
        //        //    Cbt.tp_descripcion = item.tp_descripcion;
        //        //    lM.Add(Cbt);
        //        //}

        //        return (lM);
        //    }

        //    catch (Exception ex)
        //    {
        //        string arreglo = ToString();
        //        tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
        //        tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
        //                            "", "", "", "", DateTime.Now);
        //        oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
        //        mensaje = ex.ToString() + " " + ex.Message;
        //        throw new Exception(ex.ToString());
        //    }
        //}

        //public List<tb_personaTipo_Info> Get_List_personaTipo()
        //{
        //    try
        //    {
        //        List<tb_personaTipo_Info> lM = new List<tb_personaTipo_Info>();
        //        //EntitiesGeneral OEselecEmpresa = new EntitiesGeneral();
        //        //var selectPersona = from C in OEselecEmpresa.tb_PersonaTipo
        //        //                    select C;

        //        //foreach (var item in selectPersona)
        //        //{

        //        //    tb_personaTipo_Info Cbt = new tb_personaTipo_Info();

        //        //    Cbt.idTipoPersona = item.IdTipoPersona;
        //        //    Cbt.tp_descripcion = item.tp_descripcion;
        //        //    lM.Add(Cbt);
        //        //}

        //        return (lM);
        //    }

        //    catch (Exception ex)
        //    {
        //        string arreglo = ToString();
        //        tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
        //        tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
        //                            "", "", "", "", DateTime.Now);
        //        oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
        //        mensaje = ex.ToString() + " " + ex.Message;
        //        throw new Exception(ex.ToString());
        //    }
        //}

        //public tb_personaTipo_Info Get_Info_personaTipo(int idTipoPersona)
        //{
        //    try
        //    {


        //        //EntitiesGeneral OEselecEmpresa = new EntitiesGeneral();
        //        //var selectEmpresa = from C in OEselecEmpresa.tb_PersonaTipo
        //        //                    where C.IdTipoPersona == idTipoPersona
        //        //                    select C;


        //        tb_personaTipo_Info Cbt = new tb_personaTipo_Info();

        //        //foreach (var item in selectEmpresa)
        //        //{
        //        //    Cbt.idTipoPersona = item.IdTipoPersona;
        //        //    Cbt.tp_descripcion = item.tp_descripcion;
        //        //}

        //        return (Cbt);
        //    }
        //    catch (Exception ex)
        //    {
        //        string arreglo = ToString();
        //        tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
        //        tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
        //                            "", "", "", "", DateTime.Now);
        //        oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
        //        mensaje = ex.ToString() + " " + ex.Message;
        //        throw new Exception(ex.ToString());
        //    }
        //}

        public tb_personaTipo_Data() { }

    }
}
