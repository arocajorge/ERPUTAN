using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Inventario;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Inventario
{
   public class in_marca_data
    {
       string mensaje = "";
       public List<in_Marca_Info> Get_List_Marca()
       {
           try
           {
               List<in_Marca_Info> lM = new List<in_Marca_Info>();
               EntitiesInventario OEUser = new EntitiesInventario();

               var select_ = from TI in OEUser.in_Marca
                             select TI;


               foreach (var item in select_)
               {
                   in_Marca_Info dat_ = new in_Marca_Info();
                   dat_.IdEmpresa = item.IdEmpresa;
                   dat_.IdMarca = item.IdMarca;
                   dat_.Descripcion = item.Descripcion;
                   dat_.Estado = item.Estado;

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
               throw new Exception(ex.ToString());
           }
       }

       public in_Marca_Info Get_Info_Marca(int IdMarca, int IdEmpresa)
       {
           try
           {
               in_Marca_Info marca = new in_Marca_Info();
               EntitiesInventario OEt = new EntitiesInventario();
               var marc = OEt.in_Marca.First(var =>
                   var.IdMarca == IdMarca && var.IdEmpresa == IdEmpresa);

               marca.Descripcion = marc.Descripcion;
               marca.IdEmpresa = marc.IdEmpresa;
               marca.IdMarca = marc.IdMarca;
               marca.Estado = marc.Estado;

               return marca;
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.ToString() + " " + ex.Message;
               throw new Exception(ex.ToString());
           }
       }

       public List<in_Marca_Info> Get_list_Marca(int idEmpresa)
        {
            try
            {
                List<in_Marca_Info> lM = new List<in_Marca_Info>();
                EntitiesInventario OECbtecble_Info = new EntitiesInventario();
                var selectCbtecble = from C in OECbtecble_Info.in_Marca
                                     where C.IdEmpresa == idEmpresa
                                     select C;

                foreach (var item in selectCbtecble)
                {
                    in_Marca_Info prd = new in_Marca_Info();
                    prd.Estado = item.Estado;
                    prd.IdEmpresa = item.IdEmpresa;
                    prd.Descripcion = item.Descripcion;
                    prd.IdMarca = item.IdMarca;
                    prd.Sestado = (item.Estado == "A") ? "ACTIVO" : "*ANULADO*";

                    lM.Add(prd);
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
                throw new Exception(ex.ToString());
            }
        }

        public Boolean GrabarDB(in_Marca_Info prI, ref string mensaje)
        {


            try
            {
                int idMarca;


                using (EntitiesInventario context = new EntitiesInventario())
                {
                    EntitiesInventario EDB = new EntitiesInventario();

                    idMarca = GetIdMarca(prI.IdEmpresa);

                    prI.IdMarca = idMarca;

                    var Q = from per in EDB.in_Marca
                            where per.IdMarca == prI.IdMarca && per.IdEmpresa==prI.IdEmpresa
                            select per;

                    if (Q.ToList().Count == 0)
                    {

                        var address = new in_Marca();

                        address.IdEmpresa = prI.IdEmpresa;
                        address.IdMarca = prI.IdMarca;
                        address.Descripcion = prI.Descripcion.Trim();
                        address.Estado = prI.Estado;
                        address.IdUsuario = prI.IdUsuario;
                        address.Fecha_Transac = prI.Fecha_Transac;
                        address.nom_pc = prI.nom_pc;
                        address.ip = prI.ip;
                        context.in_Marca.Add(address);
                        context.SaveChanges();
                        mensaje = "Grabacion ok..";
                    }
                    else
                        return false;
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
                throw new Exception(ex.ToString());
            }
        }

       public Boolean ModificarDB(in_Marca_Info prI, ref string mensaje)
        {
            try
            {


                using (EntitiesInventario context = new EntitiesInventario())
                {
                    var contact = context.in_Marca.FirstOrDefault(VProdu => VProdu.IdEmpresa == prI.IdEmpresa && VProdu.IdMarca == prI.IdMarca);
                    if (contact != null)
                    {
                        contact.Estado = prI.Estado;
                        contact.IdMarca = prI.IdMarca;
                        contact.Descripcion = prI.Descripcion;
                        contact.IdUsuarioUltMod = prI.IdUsuarioUltMod;
                        contact.Fecha_UltMod = prI.Fecha_UltMod;
                        contact.nom_pc = prI.nom_pc;
                        contact.ip = prI.ip;
                        context.SaveChanges();
                        mensaje = "Grabacion ok...";
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
                throw new Exception(ex.ToString());
            }
        }

        public int GetIdMarca(int idempresa)
        {
            try
            {
                int Id;
                EntitiesInventario OECbtecble = new EntitiesInventario();
                
                var q = from C in OECbtecble.in_Marca
                        where C.IdEmpresa == idempresa
                        select C;
                if (q.ToList().Count == 0)
                    return 1;
                else
                {
                    var select_ = (from t in OECbtecble.in_Marca
                                   where t.IdEmpresa == idempresa
                                   select t.IdMarca).Max();
                    Id = Convert.ToInt32(select_.ToString()) + 1;
                    return Id;
                }
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }          
        }

        public Boolean AnularDB(in_Marca_Info info)
        {
            try
            {
                using (EntitiesInventario context = new EntitiesInventario())
                {
                    var contact = context.in_Marca.FirstOrDefault(minfo => minfo.IdEmpresa == info.IdEmpresa && minfo.IdMarca == info.IdMarca);
                    if (contact != null)
                    {
                        contact.Estado = "I";
                        contact.IdUsuarioUltAnu = info.IdUsuarioUltAnu;
                        contact.Fecha_UltAnu = info.Fecha_UltAnu;
                        contact.MotiAnula = info.MotiAnula;
                        contact.nom_pc = info.nom_pc;
                        contact.ip = info.ip;
                        context.SaveChanges();
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
                throw new Exception(ex.ToString());
            }
        }
    }
}
