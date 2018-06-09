using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Facturacion;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Facturacion
{
   public  class fa_cliente_tipo_Data
    {
       string mensaje = "";

       public Boolean GuardarDB(fa_cliente_tipo_Info Info, ref int IdTipoCliente, ref string msjError)
        {
            try
            {
                using (EntitiesFacturacion Context = new EntitiesFacturacion())
                {
                    var Address = new fa_cliente_tipo();
                    Address.IdEmpresa = Info.IdEmpresa;
                    Address.Idtipo_cliente = Info.Idtipo_cliente = IdTipoCliente = GetId(Info.IdEmpresa);
                    Address.Cod_cliente_tipo = (Info.Cod_cliente_tipo == null || Info.Cod_cliente_tipo == "") ? Info.Cod_cliente_tipo : Address.Idtipo_cliente.ToString();
                    Address.Descripcion_tip_cliente = Info.Descripcion_tip_cliente;
                    Address.estado = Info.estado;
                    Address.IdCtaCble_CXC_Con = Info.IdCtaCble_CXC_Con;
                    Address.IdCtaCble_CXC_Cred = Info.IdCtaCble_CXC_Cred;
                    Address.IdCtaCble_CXC_Anticipo = Info.IdCtaCble_CXC_Anticipo;

                    Address.IdUsuario = Info.IdUsuario;
                    Address.Fecha_Transac = DateTime.Now;
                    Address.nom_pc = Info.nom_pc;
                    Address.ip = Info.ip;

                    Context.fa_cliente_tipo.Add(Address);
                    Context.SaveChanges();
                }

                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString();
                msjError = mensaje;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }

       public int GetId(int IdEmpresa)
        {
            try
            {
                int Id;
                EntitiesFacturacion ocxc = new EntitiesFacturacion();
                var select = (from q in ocxc.fa_cliente_tipo
                              where q.IdEmpresa == IdEmpresa 
                              select q.Idtipo_cliente).Count();

                if (select == 0)
                {
                    Id = 1;
                }
                else
                {
                    var select_IdCXC = (from q in ocxc.fa_cliente_tipo
                                        where q.IdEmpresa == IdEmpresa 
                                        select q.Idtipo_cliente).Max();
                    Id = Convert.ToInt32(select_IdCXC.ToString()) + 1;
                }
                return Id;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                mensaje = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }

        }
        
       public Boolean ModificarDB(fa_cliente_tipo_Info Info, ref string msjError)
        {
            try
            {
                using (EntitiesFacturacion Context = new EntitiesFacturacion())
                {
                    var contact = Context.fa_cliente_tipo.FirstOrDefault(af => af.IdEmpresa == Info.IdEmpresa && af.Idtipo_cliente == Info.Idtipo_cliente);

                    if (contact != null)
                    {
                        contact.Cod_cliente_tipo = (Info.Cod_cliente_tipo == null || Info.Cod_cliente_tipo == "") ? Info.Cod_cliente_tipo : Info.Idtipo_cliente.ToString();

                        contact.Descripcion_tip_cliente = Info.Descripcion_tip_cliente;
                        contact.IdCtaCble_CXC_Con = Info.IdCtaCble_CXC_Con;
                        contact.IdCtaCble_CXC_Cred = Info.IdCtaCble_CXC_Cred;
                        contact.IdCtaCble_CXC_Anticipo = Info.IdCtaCble_CXC_Anticipo;
                        contact.IdUsuarioUltMod = Info.IdUsuarioUltMod;
                        contact.Fecha_UltMod = Info.Fecha_UltMod;
                        contact.estado = Info.estado;

                        Context.SaveChanges();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString();
                msjError = mensaje;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }

       public Boolean AnularDB(fa_cliente_tipo_Info Info, ref string msjError)
        {
            try
            {
                using (EntitiesFacturacion Context = new EntitiesFacturacion())
                {
                    var contact = Context.fa_cliente_tipo.FirstOrDefault(af => af.IdEmpresa == Info.IdEmpresa && af.Idtipo_cliente == Info.Idtipo_cliente);
                    if (contact != null)
                    {
                        contact.IdUsuarioUltAnu = Info.IdUsuarioUltAnu;
                        contact.Fecha_UltAnu = Info.Fecha_UltAnu;
                        contact.MotivoAnula = Info.MotivoAnula;
                        contact.estado = "I";
                        Context.SaveChanges();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString();
                msjError = mensaje;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }
       
       public List<fa_cliente_tipo_Info> Get_List_fa_cliente_tipo(int IdEmpresa)
       {           
           try
           {
               List<fa_cliente_tipo_Info> lista = new List<fa_cliente_tipo_Info>();
               using (EntitiesFacturacion listado = new EntitiesFacturacion())
               {
                   var select = from q in listado.fa_cliente_tipo
                                where q.IdEmpresa == IdEmpresa
                                select q;

                   foreach (var item in select)
                   {
                       fa_cliente_tipo_Info Info = new fa_cliente_tipo_Info();
                       Info.IdEmpresa = item.IdEmpresa;
                       Info.Idtipo_cliente = item.Idtipo_cliente;
                       Info.Descripcion_tip_cliente = item.Descripcion_tip_cliente;
                       Info.estado = item.estado;
                       Info.IdCtaCble_CXC_Con = item.IdCtaCble_CXC_Con;
                       Info.IdCtaCble_CXC_Cred = item.IdCtaCble_CXC_Cred;
                       Info.IdCtaCble_CXC_Anticipo = item.IdCtaCble_CXC_Anticipo;
                       Info.IdUsuario = item.IdUsuario;
                       Info.Fecha_Transac = Convert.ToDateTime(item.Fecha_Transac);
                       Info.nom_pc = item.nom_pc;
                       Info.ip = item.ip;

                       lista.Add(Info);
                   }
               }

               return lista;
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               mensaje = ex.ToString();
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               throw new Exception(ex.ToString());
           }
       }
    
   }
}
