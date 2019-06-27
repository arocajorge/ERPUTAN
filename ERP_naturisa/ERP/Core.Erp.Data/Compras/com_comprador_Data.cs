using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Info.Compras;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
using Core.Erp.Info.SeguridadAcceso;


namespace Core.Erp.Data.Compras
{
    public class com_comprador_Data
    {
        string mensaje = "";
        
        public decimal getIdComprador(int IdEmpresa, ref string mensaje)
        {
           decimal Id = 0;
            try
            {
                EntitiesCompras contex = new EntitiesCompras();
                var selecte = contex.com_comprador.Count(q => q.IdEmpresa == IdEmpresa);

                if (selecte == 0)
                {
                    Id = 1;              
                }                
                else
                {
                    var select_em = (from q in contex.com_comprador
                                     where q.IdEmpresa == IdEmpresa 
                                     select q.IdComprador).Max();
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

        public Boolean GuardarDB(com_comprador_Info info, ref string mensaje)
        {
            try
            {
                using (EntitiesCompras Context = new EntitiesCompras())
                {
                    com_comprador Address = new com_comprador
                    {
                        IdComprador = info.IdComprador = getIdComprador(info.IdEmpresa, ref mensaje),
                        IdEmpresa = info.IdEmpresa,
                        IdUsuario_com = info.IdUsuario_com,
                        Descripcion = info.Descripcion,
                        Estado = "A",
                        IdUsuario = info.IdUsuario,
                        Correo = info.Correo,
                        Fecha_Transac = DateTime.Now
                    };
                    Context.com_comprador.Add(Address);
                    int Secuencia = 1;
                    foreach (var item in info.ListaDetalle)
                    {
                        Context.com_comprador_familia.Add(new com_comprador_familia
                        {
                            IdEmpresa = info.IdEmpresa,
                            IdComprador = info.IdComprador,
                            Secuencia = Secuencia++,
                            IdFamilia = item.IdFamilia
                        });
                    }
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
                throw new Exception(ex.ToString());
            }              
        }

        public Boolean ModificarDB(com_comprador_Info info, ref string mensaje)
        {
            try
            {
                using (EntitiesCompras context = new EntitiesCompras())
                {
                   var contact = context.com_comprador.First(var => var.IdEmpresa == info.IdEmpresa && var.IdComprador == info.IdComprador);

                    contact.IdUsuario_com = info.IdUsuario_com;
                    contact.Descripcion = info.Descripcion;
                    contact.Correo = info.Correo;
                    
                    var lst = context.com_comprador_familia.Where(q => q.IdEmpresa == info.IdEmpresa && q.IdComprador == info.IdComprador).ToList();
                    foreach (var item in lst)
                    {
                        context.com_comprador_familia.Remove(item);
                    }

                    int Secuencia = 1;
                    foreach (var item in info.ListaDetalle)
                    {
                        context.com_comprador_familia.Add(new com_comprador_familia
                        {
                            IdEmpresa = info.IdEmpresa,
                            IdComprador = info.IdComprador,
                            Secuencia = Secuencia++,
                            IdFamilia = item.IdFamilia
                        });
                    }

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

        public Boolean AnularDB(com_comprador_Info info, ref string mensaje)
        {
            try
            {
                using (EntitiesCompras context = new EntitiesCompras())
                {
                    var contact = context.com_comprador.FirstOrDefault(var => var.IdEmpresa == info.IdEmpresa && var.IdComprador == info.IdComprador);

                    if (contact != null)
                    {
                        contact.IdUsuarioUltAnu = info.IdUsuarioUltAnu;
                        contact.MotiAnula = info.MotiAnula;
                        contact.Fecha_UltAnu = DateTime.Now;
                        contact.Estado = "I";
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

        public List<com_comprador_Info> Get_List_comprador(int IdEmpresa)
        {
            List<com_comprador_Info> Lst = new List<com_comprador_Info>();
            try
            {
                using (EntitiesCompras db = new EntitiesCompras())
                {
                    Lst = db.com_comprador.Where(q => q.IdEmpresa == IdEmpresa).Select(q => new com_comprador_Info
                    {
                        IdEmpresa = q.IdEmpresa,
                        IdComprador = q.IdComprador,
                        IdUsuario_com = q.IdUsuario_com,
                        Descripcion = q.Descripcion,
                        Estado = q.Estado,
                        Correo = q.Correo,
                        SEstado = q.Estado == "A" ? "ACTIVO" : "**ANULADO**",

                    }).ToList();
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
