using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Inventario;

using Core.Erp.Data.General;
using Core.Erp.Info.General;




namespace Core.Erp.Data.Inventario
{
   public  class in_Motivo_Inven_Borrar_Data
    {
       string mensaje = "";

       public List<in_Motivo_Inven_Borrar_Info > consultar(int IdEmpresa)
       {
           try
           {
               List<in_Motivo_Inven_Borrar_Info> lista = new List<in_Motivo_Inven_Borrar_Info>();

               EntitiesInventario DBEnties = new EntitiesInventario();

               var QuerryResult = from C in DBEnties.in_Motivo_Inven_Borrar
                                  where C.IdEmpresa == IdEmpresa
                                  select C;

               foreach (var item in QuerryResult)
               {
                   in_Motivo_Inven_Borrar_Info Info= new in_Motivo_Inven_Borrar_Info();



                   Info.IdEmpresa = item.IdEmpresa;
                   Info.IdMotivo_Inv = item.IdMotivo_Inv;
                   Info.Cod_Motivo_Inv = item.Cod_Motivo_Inv;
                   Info.Desc_mov_inv = item.Desc_mov_inv;
                   Info.Genera_Movi_Inven = item.Genera_Movi_Inven;
                   Info.Fecha_Transac = item.Fecha_Transac;
                   Info.estado = item.estado;


                   lista.Add(Info);
               }




               return lista;

           }
           catch (Exception ex)
           {
                 string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.InnerException + " " + ex.Message;
               return new List<in_Motivo_Inven_Borrar_Info>();
               
           }
       }

       public List<in_Motivo_Inven_Borrar_Info> consultar(int IdEmpresa, int Ran_inicial, int Ran_final)
       {
           try
           {
               List<in_Motivo_Inven_Borrar_Info> lista = new List<in_Motivo_Inven_Borrar_Info>();

               EntitiesInventario DBEnties = new EntitiesInventario();

               var QuerryResult = from C in DBEnties.in_Motivo_Inven_Borrar
                                  where C.IdMotivo_Inv >= Ran_inicial && C.IdMotivo_Inv <= Ran_final
                                  && C.IdEmpresa == IdEmpresa
                                  select C;

               foreach (var item in QuerryResult)
               {
                   in_Motivo_Inven_Borrar_Info Info = new in_Motivo_Inven_Borrar_Info();



                   Info.IdEmpresa = item.IdEmpresa;
                   Info.IdMotivo_Inv = item.IdMotivo_Inv;
                   Info.Cod_Motivo_Inv = item.Cod_Motivo_Inv;
                   Info.Desc_mov_inv = item.Desc_mov_inv;
                   Info.Genera_Movi_Inven = item.Genera_Movi_Inven;
                   Info.Fecha_Transac = item.Fecha_Transac;
                   Info.estado = item.estado;


                   lista.Add(Info);
               }

               return lista;

           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.InnerException + " " + ex.Message;
               return new List<in_Motivo_Inven_Borrar_Info>();

           }
       }

       public Boolean GrabarDB(in_Motivo_Inven_Borrar_Info Info, ref int Id,ref string msg)
       {
            try 
            {
                using (EntitiesInventario DBInven = new EntitiesInventario())
                {

                    var que = from C in DBInven.in_Motivo_Inven_Borrar
                              where C.IdEmpresa == Info.IdEmpresa
                              && C.IdMotivo_Inv == Info.IdMotivo_Inv
                              select C;

                    if (que.Count() == 0)
                    {

                        var TablaDb = new  in_Motivo_Inven_Borrar();

                        TablaDb.IdEmpresa = Info.IdEmpresa;
                        TablaDb.IdMotivo_Inv = Info.IdMotivo_Inv =Id= getId(Info.IdEmpresa);
                        TablaDb.Cod_Motivo_Inv= Info.Cod_Motivo_Inv;
                        TablaDb.Desc_mov_inv= Info.Desc_mov_inv;
                        TablaDb.Genera_Movi_Inven= Info.Genera_Movi_Inven;
                        TablaDb.estado = Info.estado;
                        TablaDb.Genera_CXP = Info.Genera_CXP;
                        TablaDb.IdUsuarioUltMod = "sys";
                        TablaDb.Fecha_Transac = DateTime.Now;

                        DBInven.in_Motivo_Inven_Borrar.AddObject(TablaDb);
                        DBInven.SaveChanges();



                    }
                    else
                    {
                        msg = "";
                        return false;
                    }

                }
		
                return true;
            }
            catch (Exception ex)
            {
                msg = ex.ToString();
		
		        return false;
            }
       }



       public Boolean ModificarDB(in_Motivo_Inven_Borrar_Info Info,  ref string msg)
       {
           try
           {

               using (EntitiesInventario context = new EntitiesInventario())
               {
                   var contact = context.in_Motivo_Inven_Borrar.FirstOrDefault(v => v.IdEmpresa == Info.IdEmpresa && v.IdMotivo_Inv == Info.IdMotivo_Inv);

                   contact.Cod_Motivo_Inv = Info.Cod_Motivo_Inv;
                   contact.Desc_mov_inv = Info.Desc_mov_inv;
                   contact.estado = Info.estado;
                   contact.Genera_Movi_Inven = Info.Genera_Movi_Inven;

                   contact.Fecha_UltMod = DateTime.Now;
                   contact.IdUsuarioUltMod = "sys";
                                      
                   

                   context.SaveChanges();
               }
               return true;
              
           }
           catch (Exception ex)
           {
               msg = ex.ToString();

               return false;
           }
       }



       public Boolean AnularDB(in_Motivo_Inven_Borrar_Info Info,  ref string msg)
       {
           try
           {

               using (EntitiesInventario context = new EntitiesInventario())
               {
                   var contact = context.in_Motivo_Inven_Borrar.FirstOrDefault(v => v.IdEmpresa == Info.IdEmpresa && v.IdMotivo_Inv == Info.IdMotivo_Inv);

                   contact.estado = Info.estado;

                   contact.FechaHoraAnul = DateTime.Now;
                   contact.MotivoAnulacion = "anulado";
                   contact.IdUsuarioUltAnu = "sys";

                   context.SaveChanges();
               }
               return true;

           }
           catch (Exception ex)
           {
               msg = ex.ToString();

               return false;
           }
       }

       public int  getId(int IdEmpresa)
       {
           int Id = 0;
           try
           {

               EntitiesInventario contex = new EntitiesInventario();
               var selecte = contex.in_Motivo_Inven_Borrar.Count(q => q.IdEmpresa == IdEmpresa );

               if (selecte == 0)
               {
                   Id = 1;
               }
               else
               {
                   var select_em = (from q in contex.in_Motivo_Inven_Borrar
                                    where q.IdEmpresa == IdEmpresa
                                    select q.IdMotivo_Inv).Max();
                   Id = Convert.ToInt32(select_em.ToString()) + 1;
               }

               return Id;
           }
           catch (Exception ex)
           {
               
               return 0;
           }
       }

    }
}
