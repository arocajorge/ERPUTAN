using Core.Erp.Info.Bancos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Bancos
{
    public class ba_TipoFlujo_Data
    {
        string mensaje = "";

        public Boolean GuardarDB(ba_TipoFlujo_Info Info, ref decimal  IdTipoFlujo)
	    {
		try
		{
			List<ba_TipoFlujo_Info> Lst = new List<ba_TipoFlujo_Info>() ;
			using(EntitiesBanco Context= new EntitiesBanco())
			{
				var Address = new ba_TipoFlujo();

				Address.IdEmpresa= Info.IdEmpresa;
                IdTipoFlujo = Address.IdTipoFlujo = GetIdTipoFlujo(Info.IdEmpresa);
				Address.IdTipoFlujoPadre= Info.IdTipoFlujoPadre;
                Address.cod_flujo = (Info.cod_flujo == "" || Info.cod_flujo == null) ? IdTipoFlujo.ToString() : Info.cod_flujo;
				Address.Descricion= Info.Descricion;
				Address.Estado= Info.Estado;
                Address.Tipo = Info.Tipo;
                Address.cod_flujo = Info.cod_flujo;

                

                Context.ba_TipoFlujo.Add(Address);
				Context.SaveChanges();
			}
		return true;
		}
		catch (Exception ex)
        {
            string arreglo = ToString();
            tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
            tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                "", "", "", "", DateTime.Now);
            oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
            mensaje = ex.InnerException + " " + ex.Message;
            throw new Exception(ex.InnerException.ToString());
        }
	}

        public List<ba_TipoFlujo_Info> Get_List_TipoFlujo(int IdEmpresa)
        {
            try
            {
                List<ba_TipoFlujo_Info> Lst = new List<ba_TipoFlujo_Info>();
                        try
                        {
                            EntitiesBanco oEnti = new EntitiesBanco();

                            var Query = from q in oEnti.vwba_TipoFlujo
                                        where q.IdEmpresa == IdEmpresa
                                        select q;

                            foreach (var item in Query)
                            {
                                ba_TipoFlujo_Info Obj = new ba_TipoFlujo_Info();
                                Obj.IdEmpresa = item.IdEmpresa;
                                Obj.IdTipoFlujo = item.IdTipoFlujo;
                                Obj.cod_flujo = item.cod_flujo == null ? "0" : item.cod_flujo;
                                Obj.IdTipoFlujoPadre = item.IdTipoFlujoPadre;
                                Obj.Descricion = item.Descricion;
                                Obj.Descricion2 = "[" + Obj.cod_flujo.Trim() + "]-" + item.Descricion;
                                Obj.DescricionPadre = item.DescricionPadre;
                                Obj.Estado = item.Estado;
                                Obj.Tipo = item.Tipo;
                                


                                Lst.Add(Obj);
                            }
                            return Lst;
                        }
                        catch (Exception ex)
                        {
                            string arreglo = ToString();
                            tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                            tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                                "", "", "", "", DateTime.Now);
                            oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                            mensaje = ex.InnerException + " " + ex.Message;
                            throw new Exception(ex.InnerException.ToString());
                        }
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public int GetIdTipoFlujo(int idempresa)
        {
            try
            {
                int IdTipoFlujo;
                EntitiesBanco OECbtecble = new EntitiesBanco();
                var q = from A in OECbtecble.ba_TipoFlujo
                        where A.IdEmpresa == idempresa
                        select A;


                if (q.ToList().Count < 1)
                {
                    IdTipoFlujo = 1;
                }
                else
                {

                    var selectCbtecble = (from CbtCble in OECbtecble.ba_TipoFlujo
                                          where CbtCble.IdEmpresa == idempresa
                                          select CbtCble.IdTipoFlujo).Max();

                    IdTipoFlujo = Convert.ToInt32(selectCbtecble.ToString()) + 1;
                }
                return IdTipoFlujo;

            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());

            }

        }

        public Boolean ModificarDB(ba_TipoFlujo_Info Infoo) 
        {
            try
            {
                using (EntitiesBanco entity = new EntitiesBanco())
                {
                    ba_TipoFlujo ObjAMOdificar = entity.ba_TipoFlujo.FirstOrDefault(delegate(ba_TipoFlujo va) { return va.IdTipoFlujo == Infoo.IdTipoFlujo && va.IdEmpresa == Infoo.IdEmpresa; });
                    if (ObjAMOdificar != null)
                    {
                        ObjAMOdificar.cod_flujo = (Infoo.cod_flujo == "" || Infoo.cod_flujo == null) ? Infoo.IdTipoFlujo.ToString() : Infoo.cod_flujo;
                        ObjAMOdificar.Descricion = Infoo.Descricion;
                        ObjAMOdificar.Estado = Infoo.Estado;
                        ObjAMOdificar.IdTipoFlujoPadre = Infoo.IdTipoFlujoPadre;
                        ObjAMOdificar.Descricion = Infoo.Descricion;
                        ObjAMOdificar.Tipo = Infoo.Tipo;
                        
                        
                        entity.SaveChanges();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean AnularDB(ba_TipoFlujo_Info Infoo)
        {
            try
            {
                using (EntitiesBanco entity = new EntitiesBanco())
                {
                    ba_TipoFlujo ObjAMOdificar = entity.ba_TipoFlujo.FirstOrDefault(delegate(ba_TipoFlujo va) { return va.IdTipoFlujo == Infoo.IdTipoFlujo && va.IdEmpresa == Infoo.IdEmpresa; });
                    if (ObjAMOdificar != null)
                    {
                        ObjAMOdificar.Estado = "I";
                        entity.SaveChanges();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public ba_TipoFlujo_Data()
        {
           
        }
    }
}
