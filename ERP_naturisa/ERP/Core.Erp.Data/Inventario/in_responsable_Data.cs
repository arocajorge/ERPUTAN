using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
using Core.Erp.Info.Inventario;

namespace Core.Erp.Data.Inventario
{
    public class in_responsable_Data
    {
        string mensaje = "";

        //public Boolean VericarCedulaExiste(int IdEmpresa, string cedula, ref string mensaje)
        //{
        //    try
        //    {
        //        Boolean Existe;
        //        string scedula;

        //        scedula = cedula.Trim();
        //        mensaje = "";
        //        Existe = false;

        //        EntitiesCompras Context = new EntitiesCompras();

        //        var consulta = from q in Context.com_comprador
        //                       where q.cedula == scedula
        //                       && q.IdEmpresa == IdEmpresa
        //                       select q;

        //        foreach (var item in consulta)
        //        {
        //            mensaje = mensaje + " " + item.Descripcion + " ";
        //            Existe = true;
        //        }

        //        return Existe;
        //    }
        //    catch (Exception ex)
        //    {
        //        string arreglo = ToString();
        //        tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
        //        tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
        //        oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
        //        mensaje = ex.InnerException + " " + ex.Message;
        //        throw new Exception(ex.ToString());
        //    }
        //}

        public Boolean VerificarNombre(int IdEmpresa, string nombre, ref string mensaje)
        {
            try
            {
                Boolean Existe;
                string snombre;

                snombre = nombre.Trim().ToLower();
                mensaje = "";
                Existe = false;

                EntitiesInventario Context = new EntitiesInventario();

                var consulta = from q in Context.in_responsable
                               where q.IdEmpresa == IdEmpresa
                               select q;
                foreach (var item in consulta)
                {
                    string valor = Funciones.cadena(item.Nom_responsable);

                    if (valor == Funciones.cadena(snombre))
                    {
                        mensaje = mensaje + " " + item.Nom_responsable + " ";
                        Existe = true;
                        break;
                    }
                }
                return Existe;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public decimal getIdResponsable(int IdEmpresa, ref string mensaje)
        {
            decimal Id = 0;
            try
            {
                EntitiesInventario contex = new EntitiesInventario();
                var selecte = contex.in_responsable.Count(q => q.IdEmpresa == IdEmpresa);

                if (selecte == 0)
                {
                    Id = 1;
                }
                else
                {
                    var select_em = (from q in contex.in_responsable
                                     where q.IdEmpresa == IdEmpresa
                                     select q.IdResponsable).Max();
                    Id = Convert.ToDecimal(select_em.ToString()) + 1;
                }

                return Id;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean GuardarDB(in_responsable_Info info, ref string mensaje)
        {
            try
            {
                using (EntitiesInventario Context = new EntitiesInventario())
                {
                    in_responsable Address = new in_responsable();

                    Address.IdEmpresa = info.IdEmpresa;
                    Address.IdResponsable = info.IdResponsable = getIdResponsable(info.IdEmpresa, ref mensaje);
                    Address.Nom_responsable = info.Nom_responsable.Trim();
                    Address.Estado = true;
                    Address.IdPersona = (info.IdPersona == 0) ? null : info.IdPersona;
                    Address.IdUsuario = info.IdUsuario;
                    Address.Fecha_Transac = DateTime.Now;

                    Context.in_responsable.Add(Address);
                    Context.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ModificarDB(in_responsable_Info info, ref string mensaje)
        {
            try
            {
                using (EntitiesInventario context = new EntitiesInventario())
                {
                    var contact = context.in_responsable.First(var => var.IdEmpresa == info.IdEmpresa && var.IdResponsable == info.IdResponsable);

                    contact.Nom_responsable = info.Nom_responsable;
                    contact.Estado = info.Estado;
                    context.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean AnularDB(in_responsable_Info info, ref string mensaje)
        {
            try
            {
                using (EntitiesInventario context = new EntitiesInventario())
                {
                    var contact = context.in_responsable.FirstOrDefault(var => var.IdEmpresa == info.IdEmpresa && var.IdResponsable == info.IdResponsable);

                    if (contact != null)
                    {
                        contact.IdUsuarioUltAnu = info.IdUsuarioUltAnu;
                        contact.MotiAnula = info.MotiAnula;
                        contact.Fecha_UltAnu = DateTime.Now;
                        contact.Estado = false;
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
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public List<in_responsable_Info> Get_List_Responsable(int IdEmpresa)
        {
            List<in_responsable_Info> Lst = new List<in_responsable_Info>();
            try
            {
                EntitiesInventario oEnti = new EntitiesInventario();
                var Query = from q in oEnti.in_responsable
                            where q.IdEmpresa == IdEmpresa

                            select q;
                foreach (var item in Query)
                {
                    in_responsable_Info Obj = new in_responsable_Info();

                    Obj.IdEmpresa = item.IdEmpresa;
                    Obj.IdResponsable = item.IdResponsable;
                    Obj.Nom_responsable = item.Nom_responsable;
                    Obj.Estado = item.Estado;
                    Obj.IdPersona = Convert.ToDecimal(item.IdPersona);
                    
                    Lst.Add(Obj);
                }
                return Lst;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }     
    }
}
