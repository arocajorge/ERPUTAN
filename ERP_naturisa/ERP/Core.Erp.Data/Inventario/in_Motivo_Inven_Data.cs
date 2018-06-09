using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Inventario;
using Core.Erp.Data.Inventario;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.Inventario
{
   public  class in_Motivo_Inven_Data
    {
        string mensaje = "";

        public List<in_Motivo_Inven_Info> Get_List_Motivo_Inven(int IdEmpresa, string Tipo_Ing_Egr="")
        {
            try
            {
                int Id=0;
                string msg="";

                List<in_Motivo_Inven_Info> Lst = new List<in_Motivo_Inven_Info>();
                EntitiesInventario oEnti = new EntitiesInventario();

                var Query = from q in oEnti.in_Motivo_Inven
                            where q.IdEmpresa == IdEmpresa
                            && q.Tipo_Ing_Egr.Contains(Tipo_Ing_Egr)
                            select q;


                // si no hay en la base creo uno por lo menos 
                if (Query.Count() == 0)
                {
                    in_Motivo_Inven_Info Info_a_Grabar= new in_Motivo_Inven_Info();
                    

                    Info_a_Grabar.IdEmpresa = IdEmpresa;
                    Info_a_Grabar.IdMotivo_Inv = 0;
                    Info_a_Grabar.Tipo_Ing_Egr = (Tipo_Ing_Egr == "ING") ? ein_Tipo_Ing_Egr.ING : ein_Tipo_Ing_Egr.EGR;
                    Info_a_Grabar.Genera_CXP = "N";
                    Info_a_Grabar.Exigir_Punto_Cargo = "N";
                    Info_a_Grabar.Genera_Movi_Inven = "N";
                    Info_a_Grabar.Cod_Motivo_Inv = "";
                    Info_a_Grabar.Desc_mov_inv = "Inventario";

                    GuardarDB(Info_a_Grabar, ref Id, ref msg);

                    Lst.Add(Info_a_Grabar);
                    return Lst;
                }

                foreach (var item in Query)
                {
                    in_Motivo_Inven_Info Obj = new in_Motivo_Inven_Info();

                    Obj.IdEmpresa = item.IdEmpresa;
                    Obj.IdMotivo_Inv = item.IdMotivo_Inv;
                    Obj.Cod_Motivo_Inv = item.Cod_Motivo_Inv;
                    Obj.Desc_mov_inv = item.Desc_mov_inv;
                    Obj.Genera_Movi_Inven = item.Genera_Movi_Inven;
                    Obj.Genera_CXP = item.Genera_CXP;
                    Obj.estado = item.estado;
                    Obj.SEstado = (item.estado == "A") ? "ACTIVO" : "*ANULADO*";
                    Obj.IdCtaCble_Inven = item.IdCtaCble_Inven;
                    Obj.IdCtaCble_Costo = item.IdCtaCble_Costo;
                    Obj.IdUsuarioUltMod = item.IdUsuarioUltMod;
                    Obj.Exigir_Punto_Cargo = item.Exigir_Punto_Cargo;
                    Obj.es_Inven_o_Consumo = (item.es_Inven_o_Consumo == null) ? ein_Inventario_O_Consumo.TIC_INVEN : (ein_Inventario_O_Consumo)Enum.Parse(typeof(ein_Inventario_O_Consumo), item.es_Inven_o_Consumo);
                    Obj.Tipo_Ing_Egr = (item.Tipo_Ing_Egr == null || item.Tipo_Ing_Egr == "") ? ein_Tipo_Ing_Egr.ING : (ein_Tipo_Ing_Egr)Enum.Parse(typeof(ein_Tipo_Ing_Egr), item.Tipo_Ing_Egr); 
                    
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
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public in_Motivo_Inven_Info Get_Info_Motivo_Inven(int IdEmpresa, int IdMotivo_Inv)
        {
            try
            {
                in_Motivo_Inven_Info Obj = new in_Motivo_Inven_Info();
                EntitiesInventario oEnti = new EntitiesInventario();
                var Query = from q in oEnti.in_Motivo_Inven
                            where q.IdEmpresa == IdEmpresa 
                            && q.IdMotivo_Inv == IdMotivo_Inv
                            select q;

                foreach (var item in Query)
                {                   
                    Obj.IdEmpresa = item.IdEmpresa;
                    Obj.IdMotivo_Inv = item.IdMotivo_Inv;
                    Obj.Cod_Motivo_Inv = item.Cod_Motivo_Inv;
                    Obj.Desc_mov_inv = item.Desc_mov_inv;
                    Obj.Genera_Movi_Inven = item.Genera_Movi_Inven;
                    Obj.Genera_CXP = item.Genera_CXP;
                    Obj.estado = item.estado;
                    Obj.Exigir_Punto_Cargo = item.Exigir_Punto_Cargo;
                    Obj.IdCtaCble_Inven = item.IdCtaCble_Inven;
                    Obj.IdCtaCble_Costo = item.IdCtaCble_Costo;
                    Obj.IdUsuarioUltMod = item.IdUsuarioUltMod;
                    Obj.es_Inven_o_Consumo = (item.es_Inven_o_Consumo == null) ? ein_Inventario_O_Consumo.TIC_INVEN : (ein_Inventario_O_Consumo)Enum.Parse(typeof(ein_Inventario_O_Consumo), item.es_Inven_o_Consumo);
                    Obj.Tipo_Ing_Egr = (item.Tipo_Ing_Egr == null) ? ein_Tipo_Ing_Egr.ING : (ein_Tipo_Ing_Egr)Enum.Parse(typeof(ein_Tipo_Ing_Egr), item.Tipo_Ing_Egr); 


                }
                return Obj;
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

        public Boolean GuardarDB(in_Motivo_Inven_Info Info, ref int Id, ref string msg)
        {
            try
            {
                using (EntitiesInventario DBInven = new EntitiesInventario())
                {

                    var que = from C in DBInven.in_Motivo_Inven
                              where C.IdEmpresa == Info.IdEmpresa
                              && C.IdMotivo_Inv == Info.IdMotivo_Inv
                              select C;

                    if (que.Count() == 0)
                    {

                        var TablaDb = new in_Motivo_Inven();

                        TablaDb.IdEmpresa = Info.IdEmpresa;
                        TablaDb.IdMotivo_Inv = Info.IdMotivo_Inv = Id = getId(Info.IdEmpresa);
                        TablaDb.Cod_Motivo_Inv = (Info.Cod_Motivo_Inv == "") ? TablaDb.IdMotivo_Inv.ToString() : Info.Cod_Motivo_Inv;
                        TablaDb.Desc_mov_inv = Info.Desc_mov_inv;
                        TablaDb.Genera_Movi_Inven = Info.Genera_Movi_Inven;
                        TablaDb.estado = "A";
                        TablaDb.Genera_CXP = Info.Genera_CXP;
                        TablaDb.Exigir_Punto_Cargo = Info.Exigir_Punto_Cargo;
                        TablaDb.IdCtaCble_Costo = Info.IdCtaCble_Costo;
                        TablaDb.IdCtaCble_Inven = Info.IdCtaCble_Inven;
                        TablaDb.IdUsuarioUltMod = Info.IdUsuarioUltMod;
                        TablaDb.Fecha_Transac = DateTime.Now;
                        TablaDb.es_Inven_o_Consumo =  Info.es_Inven_o_Consumo.ToString();
                        TablaDb.Tipo_Ing_Egr = Info.Tipo_Ing_Egr.ToString();                      
                        DBInven.in_Motivo_Inven.Add(TablaDb);
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
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public Boolean ModificarDB(in_Motivo_Inven_Info Info, ref int Id, ref string msg)
        {
            try
            {

                using (EntitiesInventario context = new EntitiesInventario())
                {
                    var contact = context.in_Motivo_Inven.FirstOrDefault(v => v.IdEmpresa == Info.IdEmpresa && v.IdMotivo_Inv == Info.IdMotivo_Inv);
                    if (contact != null)
                    {
                        contact.Cod_Motivo_Inv = Info.Cod_Motivo_Inv;
                        contact.Desc_mov_inv = Info.Desc_mov_inv;
                        contact.estado = Info.estado;
                        contact.Genera_Movi_Inven = Info.Genera_Movi_Inven;
                        contact.Exigir_Punto_Cargo = Info.Exigir_Punto_Cargo;
                        contact.Fecha_UltMod = DateTime.Now;
                        contact.IdUsuarioUltMod = Info.IdUsuarioUltMod;
                        contact.IdCtaCble_Inven = Info.IdCtaCble_Inven;
                        contact.IdCtaCble_Costo = Info.IdCtaCble_Costo;
                        contact.IdUsuarioUltMod = Info.IdUsuarioUltMod;
                        contact.es_Inven_o_Consumo =  Info.es_Inven_o_Consumo.ToString();
                        contact.Tipo_Ing_Egr = Info.Tipo_Ing_Egr.ToString();


                        context.SaveChanges();
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

        public Boolean AnularDB(in_Motivo_Inven_Info Info, ref int Id, ref string msg)
        {
            try
            {
                using (EntitiesInventario context = new EntitiesInventario())
                {
                    var contact = context.in_Motivo_Inven.FirstOrDefault(v => v.IdEmpresa == Info.IdEmpresa && v.IdMotivo_Inv == Info.IdMotivo_Inv);
                    if (contact != null)
                    {
                        contact.estado = "I";
                        contact.FechaHoraAnul = DateTime.Now;
                        contact.MotivoAnulacion = Info.MotivoAnulacion;
                        contact.IdUsuarioUltAnu = Info.IdUsuarioUltAnu;
                        context.SaveChanges();
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

        public int getId(int IdEmpresa)
        {
            int Id = 0;
            try
            {

                EntitiesInventario contex = new EntitiesInventario();
                var selecte = contex.in_Motivo_Inven.Count(q => q.IdEmpresa == IdEmpresa);

                if (selecte == 0)
                {
                    Id = 1;
                }
                else
                {
                    var select_em = (from q in contex.in_Motivo_Inven
                                     where q.IdEmpresa == IdEmpresa
                                     select q.IdMotivo_Inv).Max();
                    Id = Convert.ToInt32(select_em.ToString()) + 1;
                }

                return Id;
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
    }
}
