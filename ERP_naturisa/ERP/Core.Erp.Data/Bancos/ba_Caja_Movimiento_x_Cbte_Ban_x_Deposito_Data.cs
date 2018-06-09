using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Bancos;
using Core.Erp.Info.Caja;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
namespace Core.Erp.Data.Bancos
{
    public class ba_Caja_Movimiento_x_Cbte_Ban_x_Deposito_Data
    {
 
   string mensaje = "";
   ba_Cbte_Ban_Info info_deposito;
   ba_Cbte_Ban_Data Deposito_data = new ba_Cbte_Ban_Data();
   public List<ba_Caja_Movimiento_x_Cbte_Ban_x_Deposito_Info> Get_List_Caja_Movimiento_x_Cbte_Ban_x_Deposito(int IdEmpresa, decimal IdCbteCble, int IdTipoCbte)
        {
                List<ba_Caja_Movimiento_x_Cbte_Ban_x_Deposito_Info> lM = new List<ba_Caja_Movimiento_x_Cbte_Ban_x_Deposito_Info>();
                EntitiesBanco db = new EntitiesBanco();
            try
            {
                var select_ = from T in db.ba_Caja_Movimiento_x_Cbte_Ban_x_Deposito 
                              where T.mba_IdEmpresa==IdEmpresa && T.mba_IdCbteCble==IdCbteCble && T.mba_IdTipocbte==IdTipoCbte 
                              select T;

                foreach (var item in select_)
                {
                    ba_Caja_Movimiento_x_Cbte_Ban_x_Deposito_Info dat = new ba_Caja_Movimiento_x_Cbte_Ban_x_Deposito_Info();
                    dat.mba_IdCbteCble = item.mba_IdCbteCble;
                    dat.mba_IdEmpresa = item.mba_IdEmpresa;
                    dat.mba_IdTipocbte = item.mba_IdTipocbte;
                    dat.mcj_IdCbteCble = item.mcj_IdCbteCble;
                    dat.mcj_IdEmpresa = item.mcj_IdEmpresa;
                    dat.mcj_IdTipocbte = item.mcj_IdTipocbte;
                    dat.mcj_Secuencia = item.mcj_Secuencia; ;
                    lM.Add(dat);
                }
                return (lM);
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

   public Boolean GrabarDB(ba_Caja_Movimiento_x_Cbte_Ban_x_Deposito_Info Info)
	{
		try
		{
			List<ba_Caja_Movimiento_x_Cbte_Ban_x_Deposito_Info> Lst = new List<ba_Caja_Movimiento_x_Cbte_Ban_x_Deposito_Info>() ;
			using(EntitiesBanco Context= new EntitiesBanco())
			{
				var Address = new ba_Caja_Movimiento_x_Cbte_Ban_x_Deposito();

				Address.mcj_IdEmpresa= Info.mcj_IdEmpresa;
				Address.mcj_IdCbteCble= Info.mcj_IdCbteCble;
				Address.mcj_IdTipocbte= Info.mcj_IdTipocbte;
                Address.mcj_Secuencia = Info.mcj_Secuencia;
				Address.mba_IdEmpresa= Info.mba_IdEmpresa;
				Address.mba_IdCbteCble= Info.mba_IdCbteCble;
				Address.mba_IdTipocbte= Info.mba_IdTipocbte;
                Address.Observacion = (Info.Observacion == null) ? "" : Info.Observacion;
                //Address.ba_Cbte_Ban=Info.
                


                Context.ba_Caja_Movimiento_x_Cbte_Ban_x_Deposito.Add(Address);
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

    public Boolean GrabarListadoMovCaja_x_Deposito(List<caj_Caja_Movimiento_Info> Lst,int IdtipoCbteCble_Bco, decimal IdCbteCble_Bco)
    {   try
           {
                    using (EntitiesBanco Context = new EntitiesBanco())
                    {

                        foreach (var item in Lst)
                        {
                            ba_Caja_Movimiento_x_Cbte_Ban_x_Deposito Address = new ba_Caja_Movimiento_x_Cbte_Ban_x_Deposito();

                            Address.mcj_IdEmpresa = item.IdEmpresa;
                            Address.mcj_IdCbteCble = item.IdCbteCble;
                            Address.mcj_IdTipocbte = item.IdTipocbte;
                            Address.mba_IdEmpresa = item.IdEmpresa;
                            Address.mba_IdCbteCble = IdCbteCble_Bco;
                            Address.mba_IdTipocbte = IdtipoCbteCble_Bco;
                            Address.mcj_Secuencia = item.secuencial;

                            Context.ba_Caja_Movimiento_x_Cbte_Ban_x_Deposito.Add(Address);

                        } Context.SaveChanges(); return true;
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

     public Boolean GrabarDB(List<ba_Caja_Movimiento_x_Cbte_Ban_x_Deposito_Info> lista)
     {
         try
         {
             foreach (var item in lista)
             {
                 GrabarDB(item);
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

     public List<ba_Caja_Movimiento_x_Cbte_Ban_x_Deposito_Info> Get_List_Caja_Movimiento_x_Cbte_Ban_x_Deposito()
	{
			        List<ba_Caja_Movimiento_x_Cbte_Ban_x_Deposito_Info> Lst = new List<ba_Caja_Movimiento_x_Cbte_Ban_x_Deposito_Info>() ;
			        EntitiesBanco oEnti= new EntitiesBanco();
		try
		{
            var Query = from q in oEnti.ba_Caja_Movimiento_x_Cbte_Ban_x_Deposito
				        select q;
			         foreach (var item in Query)
			        {
				        ba_Caja_Movimiento_x_Cbte_Ban_x_Deposito_Info Obj = new ba_Caja_Movimiento_x_Cbte_Ban_x_Deposito_Info() ;
					        Obj.mcj_IdEmpresa= item.mcj_IdEmpresa;
					        Obj.mcj_IdCbteCble= item.mcj_IdCbteCble;
					        Obj.mcj_IdTipocbte= item.mcj_IdTipocbte;
					        Obj.mba_IdEmpresa= item.mba_IdEmpresa;
					        Obj.mba_IdCbteCble= item.mba_IdCbteCble;
					        Obj.mba_IdTipocbte= item.mba_IdTipocbte;
                            Obj.mcj_Secuencia = item.mcj_Secuencia;
                            Obj.Observacion = item.Observacion;


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

     public Boolean EliminarCobros_x_deposito(int IdEmpresa, int IdTipoCbte, decimal IdCbteCble)
     {
         try
         {
             string query = "delete from ba_Caja_Movimiento_x_Cbte_Ban_x_Deposito where mba_IdEmpresa = "+IdEmpresa+" and mba_IdTipocbte = "+IdTipoCbte+" and  mba_IdCbteCble = "+IdCbteCble;
             using (EntitiesBanco Context = new EntitiesBanco())
             {
                 Context.Database.ExecuteSqlCommand(query);   
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

    public ba_Caja_Movimiento_x_Cbte_Ban_x_Deposito_Data()
    {
        try
        {

        }
        catch (Exception ex)
        {
            string arreglo = ToString();
            tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
            tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
            oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
            mensaje = ex.InnerException + " " + ex.Message;
            throw new Exception(ex.InnerException.ToString());
        }
    }
  }
}
