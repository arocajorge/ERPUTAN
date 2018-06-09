using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Info.Inventario;
using Core.Erp.Info.General;
using Core.Erp.Data.General;


namespace Core.Erp.Data.Inventario
{
   public  class in_subgrupo_data
    {

        string mensaje = "";

        public int GetIdSubGrupo(int IdEmpresa, string IdCategoria, int IdLinea,int IdGrupo)
        {
            try
            {
                int IdSubGrupo = 0;
                EntitiesInventario OESubGrupo = new EntitiesInventario();

                var selecte = OESubGrupo.in_subgrupo.Count(q => q.IdEmpresa == IdEmpresa && q.IdCategoria == IdCategoria && q.IdLinea == IdLinea && q.IdGrupo == IdGrupo);

                if (selecte == 0)
                {
                    IdSubGrupo = 1;
                }
                else
                {
                    OESubGrupo = new EntitiesInventario();
                    var selectSubGrupo = (from Subgrupo in OESubGrupo.in_subgrupo
                                          where Subgrupo.IdEmpresa == IdEmpresa
                                          && Subgrupo.IdCategoria == IdCategoria
                                          && Subgrupo.IdLinea == IdLinea
                                          && Subgrupo.IdGrupo == IdGrupo

                                          select Subgrupo.IdSubgrupo).Max();
                    IdSubGrupo = Convert.ToInt32(selectSubGrupo.ToString()) + 1;
                }
                return IdSubGrupo;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(mensaje);
            }
        }

        public Boolean GrabarDB(in_subgrupo_info info, ref int IdSubGrupo, ref string msg)
        {
            try
            {
                using (EntitiesInventario context = new EntitiesInventario())
                {
                    var lst = from q in context.in_subgrupo
                              where q.IdEmpresa == info.IdEmpresa
                              && q.IdCategoria == info.IdCategoria
                              && q.IdLinea == info.IdLinea
                              && q.IdGrupo == info.IdGrupo
                              && q.IdSubgrupo == info.IdSubgrupo
                              select q;

                    if (lst.Count()==0)
                    {
                        in_subgrupo objSubGrupo = new in_subgrupo();

                        objSubGrupo.IdEmpresa = info.IdEmpresa;
                        objSubGrupo.IdCategoria = info.IdCategoria;
                        objSubGrupo.IdLinea = info.IdLinea;
                        objSubGrupo.IdGrupo = info.IdGrupo;

                        objSubGrupo.IdSubgrupo = IdSubGrupo = (info.IdSubgrupo == null || info.IdSubgrupo == 0) ? GetIdSubGrupo(info.IdEmpresa, info.IdCategoria, info.IdLinea, info.IdGrupo) : info.IdSubgrupo;

                        if (info.cod_subgrupo == null || info.cod_subgrupo == "")
                        {
                            info.cod_subgrupo = objSubGrupo.IdSubgrupo.ToString();
                        }

                        objSubGrupo.cod_subgrupo = info.cod_subgrupo.Trim();


                        objSubGrupo.nom_subgrupo = info.nom_subgrupo.Trim();

                        if (info.abreviatura == null || info.abreviatura == "")
                        {
                            info.abreviatura = info.cod_subgrupo.Trim();
                        }

                        objSubGrupo.abreviatura = info.abreviatura;
                        objSubGrupo.Estado = "A";

                        if (info.observacion == "" || info.observacion == null)
                        {
                            info.observacion = "";
                        }

                        objSubGrupo.observacion = info.observacion;
                        objSubGrupo.IdUsuario = (info.IdUsuario == null) ? "" : info.IdUsuario;
                        objSubGrupo.Fecha_Transac = DateTime.Now;
                        objSubGrupo.nom_pc = info.nom_pc;
                        objSubGrupo.ip = info.ip;

                        objSubGrupo.IdCtaCtble_Inve = info.IdCtaCtble_Inve;
                        objSubGrupo.IdCtaCtble_Costo = info.IdCtaCtble_Costo;
                        
                        objSubGrupo.IdCtaCtble_Gasto_x_cxp = info.IdCtaCtble_Gasto_x_cxp;
                        objSubGrupo.IdCtaCble_Vta = info.IdCtaCble_Vta;


                        //objSubGrupo.IdCentro_Costo_Inv = info.IdCentro_Costo_Inv;
                        //objSubGrupo.IdCentro_Costo_Cost = info.IdCentro_Costo_Cost;
                        //objSubGrupo.IdCentro_Costo_x_Gasto_x_cxp = info.IdCentro_Costo_x_Gasto_x_cxp;
                        //objSubGrupo.IdCentroCosto_sub_centro_costo_inv = info.IdCentroCosto_sub_centro_costo_inv;
                        //objSubGrupo.IdCentroCosto_sub_centro_costo_cost = info.IdCentroCosto_sub_centro_costo_cost;
                        //objSubGrupo.IdCentroCosto_sub_centro_costo_cxp = info.IdCentroCosto_sub_centro_costo_cxp;
                        //objSubGrupo.IdCtaCble_CosBaseIva = info.IdCtaCble_CosBaseIva;
                        //objSubGrupo.IdCtaCble_CosBase0 = info.IdCtaCble_CosBase0;
                        //objSubGrupo.IdCtaCble_VenIva = info.IdCtaCble_VenIva;
                        //objSubGrupo.IdCtaCble_Ven0 = info.IdCtaCble_Ven0;
                        //objSubGrupo.IdCtaCble_DesIva = info.IdCtaCble_DesIva;
                        //objSubGrupo.IdCtaCble_DevIva = info.IdCtaCble_DevIva;

                        objSubGrupo.IdCtaCble_Des0 = info.IdCtaCble_Des0;
                        objSubGrupo.IdCtaCble_Dev0 = info.IdCtaCble_Dev0;

                       
                        context.in_subgrupo.Add(objSubGrupo);
                        context.SaveChanges();    
                    }
                    msg = "Grabación ok..";
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(mensaje);
            }

        }

        public Boolean ModificarDB(in_subgrupo_info info, ref string msg)
        {
            try
            {
                using (EntitiesInventario context = new EntitiesInventario())
                {
                    var contact = context.in_subgrupo.FirstOrDefault(var => var.IdEmpresa == info.IdEmpresa && var.IdLinea == info.IdLinea && var.IdGrupo == info.IdGrupo && var.IdCategoria == info.IdCategoria && var.IdSubgrupo==info.IdSubgrupo);
                    if (contact != null)
                    {
                        contact.cod_subgrupo = info.cod_subgrupo;
                        contact.nom_subgrupo = info.nom_subgrupo;
                        contact.abreviatura = info.abreviatura;
                        contact.observacion = info.observacion;
                        contact.IdUsuarioUltMod = info.IdUsuarioUltMod;
                        contact.Fecha_UltMod = info.Fecha_UltMod;
                        contact.IdCtaCtble_Inve = info.IdCtaCtble_Inve;
                        contact.IdCtaCtble_Costo = info.IdCtaCtble_Costo;

                        contact.IdCtaCtble_Gasto_x_cxp = info.IdCtaCtble_Gasto_x_cxp;
                        contact.IdCtaCble_Vta = info.IdCtaCble_Vta;
                        contact.IdCtaCble_Des0 = info.IdCtaCble_Des0;
                        contact.IdCtaCble_Dev0 = info.IdCtaCble_Dev0;


                        //contact.IdCentro_Costo_Inv = info.IdCentro_Costo_Inv;
                        //contact.IdCentro_Costo_Cost = info.IdCentro_Costo_Cost;
                        //contact.IdCentro_Costo_x_Gasto_x_cxp = info.IdCentro_Costo_x_Gasto_x_cxp;
                        //contact.IdCentroCosto_sub_centro_costo_inv = info.IdCentroCosto_sub_centro_costo_inv;
                        //contact.IdCentroCosto_sub_centro_costo_cost = info.IdCentroCosto_sub_centro_costo_cost;
                        //contact.IdCentroCosto_sub_centro_costo_cxp = info.IdCentroCosto_sub_centro_costo_cxp;
                        //contact.IdCtaCble_CosBaseIva = info.IdCtaCble_CosBaseIva;
                        //contact.IdCtaCble_CosBase0 = info.IdCtaCble_CosBase0;
                        //contact.IdCtaCble_VenIva = info.IdCtaCble_VenIva;
                        //contact.IdCtaCble_Ven0 = info.IdCtaCble_Ven0;
                        //contact.IdCtaCble_DesIva = info.IdCtaCble_DesIva;
                        //contact.IdCtaCble_DevIva = info.IdCtaCble_DevIva;


                        
                        context.SaveChanges();
                        msg = "Grabación ok..";
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(mensaje);
            }
        }

        public Boolean AnularDB(in_subgrupo_info info, ref string msg)
        {
            try
            {
                using (EntitiesInventario context = new EntitiesInventario())
                {
                    var contact = context.in_subgrupo.FirstOrDefault(var => var.IdEmpresa == info.IdEmpresa && var.IdLinea == info.IdLinea && var.IdGrupo == info.IdGrupo && var.IdCategoria == info.IdCategoria && var.IdSubgrupo==info.IdSubgrupo);
                    if (contact != null)
                    {
                        contact.Estado = "I";
                        contact.IdUsuarioUltAnu = info.IdUsuarioUltAnu;
                        contact.Fecha_UltAnu = info.Fecha_UltAnu;
                        contact.MotiAnula = info.MotiAnula;
                        context.SaveChanges();
                        msg = "Anulación ok..";
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(mensaje);
            }
        }

        public List<in_subgrupo_info> Get_List_in_subgrupo(int IdEmpresa, string IdCategoria, int IdLinea, int IdGrupo)
        {
            try
            {
                List<in_subgrupo_info> lM = new List<in_subgrupo_info>();

                EntitiesInventario OEUser = new EntitiesInventario();

                var select_ = from TI in OEUser.in_subgrupo
                              where TI.IdEmpresa == IdEmpresa
                               && TI.IdCategoria == IdCategoria
                               && TI.IdLinea == IdLinea
                               && TI.IdGrupo == IdGrupo
                              select TI;


                foreach (var item in select_)
                {
                    in_subgrupo_info dat_ = new in_subgrupo_info();
                    dat_.IdEmpresa = item.IdEmpresa;
                    dat_.IdCategoria = item.IdCategoria;
                    dat_.IdLinea = item.IdLinea;
                    dat_.IdGrupo = item.IdGrupo;
                    dat_.IdSubgrupo = item.IdSubgrupo;
                    dat_.nom_subgrupo = item.nom_subgrupo;
                    dat_.observacion = item.observacion;
                    dat_.cod_subgrupo = item.cod_subgrupo;
                    dat_.abreviatura = item.abreviatura;
                    dat_.Estado = item.Estado;
                    dat_.IdCtaCtble_Inve = item.IdCtaCtble_Inve;
                    dat_.IdCtaCtble_Costo = item.IdCtaCtble_Costo;
                    dat_.IdCtaCtble_Gasto_x_cxp = item.IdCtaCtble_Gasto_x_cxp;
                    dat_.IdCtaCble_Vta = item.IdCtaCble_Vta;
                    dat_.IdCtaCble_Des0 = item.IdCtaCble_Des0;
                    dat_.IdCtaCble_Dev0 = item.IdCtaCble_Dev0;


                    //dat_.IdCentro_Costo_Inv = item.IdCentro_Costo_Inv;
                    //dat_.IdCentro_Costo_Cost = item.IdCentro_Costo_Cost;
                    //dat_.IdCentro_Costo_x_Gasto_x_cxp = item.IdCentro_Costo_x_Gasto_x_cxp;
                    //dat_.IdCentroCosto_sub_centro_costo_inv = item.IdCentroCosto_sub_centro_costo_inv;
                    //dat_.IdCentroCosto_sub_centro_costo_cost = item.IdCentroCosto_sub_centro_costo_cost;
                    //dat_.IdCentroCosto_sub_centro_costo_cxp = item.IdCentroCosto_sub_centro_costo_cxp;
                    //dat_.IdCtaCble_CosBaseIva = item.IdCtaCble_CosBaseIva;
                    //dat_.IdCtaCble_CosBase0 = item.IdCtaCble_CosBase0;
                    //dat_.IdCtaCble_VenIva = item.IdCtaCble_VenIva;
                    //dat_.IdCtaCble_Ven0 = item.IdCtaCble_Ven0;
                    //dat_.IdCtaCble_DesIva = item.IdCtaCble_DesIva;
                    //dat_.IdCtaCble_DevIva = item.IdCtaCble_DevIva;
                    
                    lM.Add(dat_);
                }
                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(mensaje);
            }
        }

        public in_subgrupo_info Get_Info_in_subgrupo(int IdEmpresa, string IdCategoria, int IdLinea, int IdGrupo, int IdSubGrupo)
       {
           try
           {
               in_subgrupo_info dat_ = new in_subgrupo_info();

               EntitiesInventario OEUser = new EntitiesInventario();

               var select_ = from TI in OEUser.in_subgrupo
                             where TI.IdEmpresa == IdEmpresa
                              && TI.IdCategoria == IdCategoria
                              && TI.IdLinea == IdLinea
                              && TI.IdGrupo == IdGrupo
                              && TI.IdSubgrupo == IdSubGrupo
                             select TI;

               foreach (var item in select_)
               {
                 //  in_subgrupo_info dat_ = new in_subgrupo_info();
                   dat_.IdEmpresa = item.IdEmpresa;
                   dat_.IdCategoria = item.IdCategoria;
                   dat_.IdLinea = item.IdLinea;
                   dat_.IdGrupo = item.IdGrupo;
                   dat_.IdSubgrupo = item.IdSubgrupo;
                   dat_.nom_subgrupo = item.nom_subgrupo;
                   dat_.observacion = item.observacion;
                   dat_.cod_subgrupo = item.cod_subgrupo;
                   dat_.abreviatura = item.abreviatura;
                   dat_.Estado = item.Estado;
                   dat_.IdCtaCtble_Inve = item.IdCtaCtble_Inve;
                   dat_.IdCtaCtble_Costo = item.IdCtaCtble_Costo;
                   dat_.IdCtaCble_Vta = item.IdCtaCble_Vta;
                   dat_.IdCtaCble_Des0 = item.IdCtaCble_Des0;
                   dat_.IdCtaCble_Dev0 = item.IdCtaCble_Dev0;
                   dat_.IdCtaCtble_Gasto_x_cxp = item.IdCtaCtble_Gasto_x_cxp;

                   //dat_.IdCentro_Costo_Inv = item.IdCentro_Costo_Inv;
                   //dat_.IdCentro_Costo_Cost = item.IdCentro_Costo_Cost;
                   //dat_.IdCentro_Costo_x_Gasto_x_cxp = item.IdCentro_Costo_x_Gasto_x_cxp;
                   //dat_.IdCentroCosto_sub_centro_costo_inv = item.IdCentroCosto_sub_centro_costo_inv;
                   //dat_.IdCentroCosto_sub_centro_costo_cost = item.IdCentroCosto_sub_centro_costo_cost;
                   //dat_.IdCentroCosto_sub_centro_costo_cxp = item.IdCentroCosto_sub_centro_costo_cxp;
                   //dat_.IdCtaCble_CosBaseIva = item.IdCtaCble_CosBaseIva;
                   //dat_.IdCtaCble_CosBase0 = item.IdCtaCble_CosBase0;
                   //dat_.IdCtaCble_VenIva = item.IdCtaCble_VenIva;
                   //dat_.IdCtaCble_Ven0 = item.IdCtaCble_Ven0;
                   //dat_.IdCtaCble_DesIva = item.IdCtaCble_DesIva;
                   //dat_.IdCtaCble_DevIva = item.IdCtaCble_DevIva;

               }
               return (dat_);
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.ToString() + " " + ex.Message;
               throw new Exception(mensaje);
           }
       }

        public List<in_subgrupo_info> Get_List_in_subgrupo(int IdEmpresa)
       {
           try
           {
               List<in_subgrupo_info> lM = new List<in_subgrupo_info>();

               EntitiesInventario OEUser = new EntitiesInventario();

               var select_ = from TI in OEUser.in_subgrupo
                             where TI.IdEmpresa == IdEmpresa
                          
                             select TI;

               foreach (var item in select_)
               {
                   in_subgrupo_info dat_ = new in_subgrupo_info();
                   dat_.IdEmpresa = item.IdEmpresa;
                   dat_.IdCategoria = item.IdCategoria;
                   dat_.IdLinea = item.IdLinea;
                   dat_.IdGrupo = item.IdGrupo;
                   dat_.IdSubgrupo = item.IdSubgrupo;
                   dat_.nom_subgrupo = item.nom_subgrupo;
                   dat_.observacion = item.observacion;
                   dat_.cod_subgrupo = item.cod_subgrupo;
                   dat_.abreviatura = item.abreviatura;
                   dat_.Estado = item.Estado;
                   dat_.IdCtaCtble_Inve = item.IdCtaCtble_Inve;
                   dat_.IdCtaCtble_Costo = item.IdCtaCtble_Costo;
                   dat_.IdCtaCtble_Gasto_x_cxp = item.IdCtaCtble_Gasto_x_cxp;
                   dat_.IdCtaCble_Vta = item.IdCtaCble_Vta;
                   dat_.IdCtaCble_Des0 = item.IdCtaCble_Des0;
                   dat_.IdCtaCble_Dev0 = item.IdCtaCble_Dev0;


                   //dat_.IdCentro_Costo_Inv = item.IdCentro_Costo_Inv;
                   //dat_.IdCentro_Costo_Cost = item.IdCentro_Costo_Cost;
                   //dat_.IdCentro_Costo_x_Gasto_x_cxp = item.IdCentro_Costo_x_Gasto_x_cxp;
                   //dat_.IdCentroCosto_sub_centro_costo_inv = item.IdCentroCosto_sub_centro_costo_inv;
                   //dat_.IdCentroCosto_sub_centro_costo_cost = item.IdCentroCosto_sub_centro_costo_cost;
                   //dat_.IdCentroCosto_sub_centro_costo_cxp = item.IdCentroCosto_sub_centro_costo_cxp;
                   //dat_.IdCtaCble_CosBaseIva = item.IdCtaCble_CosBaseIva;
                   //dat_.IdCtaCble_CosBase0 = item.IdCtaCble_CosBase0;
                   //dat_.IdCtaCble_VenIva = item.IdCtaCble_VenIva;
                   //dat_.IdCtaCble_Ven0 = item.IdCtaCble_Ven0;
                   //dat_.IdCtaCble_DesIva = item.IdCtaCble_DesIva;
                   //dat_.IdCtaCble_DevIva = item.IdCtaCble_DevIva;
                   
                   lM.Add(dat_);
               }
               return (lM);
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.ToString() + " " + ex.Message;
               throw new Exception(mensaje);
           }
       }
    }
}
