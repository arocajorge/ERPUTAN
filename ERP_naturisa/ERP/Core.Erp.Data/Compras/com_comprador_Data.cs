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
        
        public Boolean VericarCedulaExiste(int IdEmpresa, string cedula, ref string mensaje)
        {
            try
            {
                Boolean Existe;
                string scedula;

                scedula = cedula.Trim();
                mensaje = "";
                Existe = false;

                EntitiesCompras Context = new EntitiesCompras();

                var consulta = from q in Context.com_comprador
                                     where q.cedula == scedula
                                     && q.IdEmpresa == IdEmpresa
                                     select q;

                foreach (var item in consulta)
                {
                    mensaje = mensaje + " " + item.Descripcion + " ";
                    Existe = true;
                }

                return Existe;
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

        public Boolean VerificarNombre(int IdEmpresa, string nombre, ref string mensaje)
        {
            try
            {                                          
                Boolean Existe;
                string snombre;

                snombre = nombre.Trim();
                mensaje = "";
                Existe = false;

                EntitiesCompras Context = new EntitiesCompras();

                var consulta = from q in Context.com_comprador                             
                               where q.IdEmpresa == IdEmpresa
                               select q;
                foreach (var item in consulta)
                {                   
                    string valor=Funciones.cadena(item.Descripcion);

                    if (valor == Funciones.cadena(snombre))
                    {
                        mensaje = mensaje + " " + item.Descripcion + " ";
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
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

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
                    com_comprador Address = new com_comprador();

                    Address.IdComprador = info.IdComprador = getIdComprador(info.IdEmpresa, ref mensaje);
                    Address.IdEmpresa = info.IdEmpresa;
                    Address.IdUsuario_com = info.IdUsuario_com;
                    Address.Descripcion = info.Descripcion.Trim();
                    Address.Estado = "A";
                    Address.IdPersona = (info.IdPersona == 0) ? null : info.IdPersona;
                    Address.cedula = info.cedula;
                    Address.IdUsuario = info.IdUsuario;
                    Address.Fecha_Transac = DateTime.Now;
                    
               
                    Context.com_comprador.Add(Address);
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
                EntitiesCompras oEnti = new EntitiesCompras();
                var Query = from q in oEnti.com_comprador
                            where q.IdEmpresa == IdEmpresa

                            select q;
                foreach (var item in Query)
                {
                    com_comprador_Info Obj = new com_comprador_Info();

                    Obj.IdEmpresa = item.IdEmpresa;
                    Obj.IdComprador = item.IdComprador;
                    Obj.IdUsuario_com = item.IdUsuario_com;
                    Obj.Descripcion = item.Descripcion;
                    Obj.Estado = item.Estado.TrimEnd();
                    Obj.SEstado = (item.Estado.TrimEnd() == "A") ? "ACTIVO" : "*ANULADO*";
                    Obj.IdPersona = Convert.ToDecimal(item.IdPersona);
                    Obj.cedula = item.cedula;
                
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
