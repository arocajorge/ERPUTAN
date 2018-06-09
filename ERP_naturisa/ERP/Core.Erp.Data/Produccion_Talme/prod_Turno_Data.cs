using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Produccion_Talme;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Produccion_Talme
{
    public class prod_Turno_Data
    {
        string mensaje = "";
        public List<prod_Turno_Info> ConsultaGeneral(int IdEmpresa)
	    {
			    List<prod_Turno_Info> Lst = new List<prod_Turno_Info>() ;
			    EntitiesProduccion oEnti= new EntitiesProduccion();
		    try
		    {
			    var Query = from q in oEnti.prod_Turno
                            where q.IdEmpresa == IdEmpresa
				    select q;
			     foreach (var item in Query)
			    {
				    prod_Turno_Info Obj = new prod_Turno_Info() ;
					    Obj.IdEmpresa= item.IdEmpresa;
					    Obj.IdTurno= item.IdTurno;
					    Obj.HoraInicio= item.HoraInicio;
					    Obj.HoraFin= item.HoraFin;
					    Obj.Descripcion= item.Descripcion;
				    Lst.Add(Obj);
		    }
			    return Lst;
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
