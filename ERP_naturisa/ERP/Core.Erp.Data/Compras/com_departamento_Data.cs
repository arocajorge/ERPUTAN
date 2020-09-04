using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Compras;
using Core.Erp.Data.General;
using Core.Erp.Info.General;


namespace Core.Erp.Data.Compras
{
   public class com_departamento_Data
    {
        string mensaje = "";
        public List<com_departamento_Info> Get_List_Departamento(int IdEmpresa)
        {

            List<com_departamento_Info> Lst;
            
            try
            {
                using (EntitiesCompras oEnti = new EntitiesCompras())
                {
                    Lst = oEnti.com_departamento.Where(q => q.IdEmpresa == IdEmpresa).Select(q => new com_departamento_Info
                    {
                        IdEmpresa = q.IdEmpresa,
                        IdDepartamento = q.IdDepartamento,
                        nom_departamento = q.nom_departamento,
                        Estado = q.Estado
                    }).ToList();    
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
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public List<com_departamento_Info> GetList(int IdEmpresa, decimal IdSolicitante)
        {
            try
            {
                List<com_departamento_Info> Lista = new List<com_departamento_Info>();

                using (EntitiesCompras db = new EntitiesCompras())
                {
                    var lst = db.com_solicitante_aprobador.Where(q => q.IdEmpresa == IdEmpresa && q.IdSolicitante == IdSolicitante && q.MontoMax > 0 && q.com_departamento.Estado == "A").GroupBy(q=> new {q.IdEmpresa, q.IdDepartamento, q.com_departamento.nom_departamento}).ToList();
                    foreach (var item in lst)
                    {
                        Lista.Add(new com_departamento_Info
                        {
                            IdEmpresa = item.Key.IdEmpresa,
                            IdDepartamento = item.Key.IdDepartamento,
                            nom_departamento = item.Key.nom_departamento,
                            Estado = "A"
                        });
                    }
                }

                return Lista;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public decimal GetId(int IdEmpresa)
        {
            try
            {
                decimal Id;
                EntitiesCompras OECompras = new EntitiesCompras();
                var select = from q in OECompras.com_departamento
                             where q.IdEmpresa==IdEmpresa
                             select q;

                if (select.ToList().Count < 1)
                {
                    Id = 1;
                }
                else
                {
                    var select_pv = (from q in OECompras.com_departamento
                                     where q.IdEmpresa == IdEmpresa
                                     select q.IdDepartamento
                                     ).Max();
                    Id = Convert.ToDecimal(select_pv.ToString()) + 1;
                    Id = (Id == 0) ? 1 : Id;
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
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.ToString());
            }

        }

        public Boolean GuardarDB(com_departamento_Info Info)
        {
            try
            {
                using (EntitiesCompras Context = new EntitiesCompras())
                {
                    var Address = new com_departamento();
                    
                    Address.IdEmpresa = Info.IdEmpresa;
                    Address.IdDepartamento = Info.IdDepartamento = GetId(Info.IdEmpresa);
                    Address.nom_departamento= Info.nom_departamento;
                    Address.Estado = "A";
                    Address.IdUsuario = Info.IdUsuario;
                    Address.Fecha_Transac = DateTime.Now;

                    Context.com_departamento.Add(Address);
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

        public bool ModificarDB(com_departamento_Info info)
        {
            try
            {
                EntitiesCompras context = new EntitiesCompras();
                var contenido = context.com_departamento.FirstOrDefault(var => var.IdEmpresa == info.IdEmpresa && var.IdDepartamento==info.IdDepartamento);
                if (contenido != null)
                {
                    contenido.nom_departamento = info.nom_departamento;
                    contenido.Estado = info.Estado;
                    contenido.IdUsuarioUltMod = info.IdUsuarioUltMod;
                    contenido.Fecha_UltMod = DateTime.Now;
                    context.SaveChanges();
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

        public Boolean AnularDB(com_departamento_Info Info)
        {
            try
            {
                using (EntitiesCompras context = new EntitiesCompras())
                {

                    var contact = context.com_departamento.FirstOrDefault(var => var.IdEmpresa == Info.IdEmpresa && var.IdDepartamento==Info.IdDepartamento );

                    if (contact != null)
                    {
                        contact.Estado = "I";
                        contact.IdUsuarioUltAnu = Info.IdUsuarioUltAnu;
                        contact.Fecha_UltAnu = Info.Fecha_UltAnu;
                        contact.MotiAnula = Info.MotiAnula;
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
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }
    }
}
