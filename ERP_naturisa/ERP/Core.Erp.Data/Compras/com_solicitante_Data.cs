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
   public class com_solicitante_Data
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

                var consulta = from q in Context.com_solicitante
                               where q.cedula == scedula
                               && q.IdEmpresa == IdEmpresa
                               select q;

                foreach (var item in consulta)
                {
                    mensaje = mensaje + " " + item.nom_solicitante + " ";
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
                mensaje = ex.ToString();
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

                var consulta = from q in Context.com_solicitante
                               where q.IdEmpresa == IdEmpresa
                               select q;
                foreach (var item in consulta)
                {
                    string valor = Funciones.cadena(item.nom_solicitante);

                    if (valor == Funciones.cadena(snombre))
                    {
                        mensaje = mensaje + " " + item.nom_solicitante + " ";
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
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public decimal GetIdSolicitante(int IdEmpresa, ref string mensaje)
        {
            decimal Id = 0;
            try
            {
                EntitiesCompras contex = new EntitiesCompras();
                var selecte = contex.com_solicitante.Count(q => q.IdEmpresa == IdEmpresa);

                if (selecte == 0)
                {
                    Id = 1;
                }
                else
                {
                    var select_em = (from q in contex.com_solicitante
                                     where q.IdEmpresa == IdEmpresa
                                     select q.IdSolicitante).Max();
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

        public Boolean GuardarDB(com_solicitante_Info info, ref string mensaje)
        {
            try
            {
                using (EntitiesCompras Context = new EntitiesCompras())
                {
                    com_solicitante Address = new com_solicitante();

                    Address.IdSolicitante = info.IdSolicitante = GetIdSolicitante(info.IdEmpresa, ref mensaje);
                    Address.IdEmpresa = info.IdEmpresa;
                    Address.nom_solicitante = info.nom_solicitante.Trim();
                    Address.estado = "A";
                    Address.IdPersona = (info.IdPersona == 0) ? null : info.IdPersona;
                    Address.cedula = info.cedula;
                    Address.IdUsuario = info.IdUsuario;
                    Address.Fecha_Transac = DateTime.Now;

                    Context.com_solicitante.Add(Address);
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
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ModificarDB(com_solicitante_Info info, ref string mensaje)
        {
            try
            {
                using (EntitiesCompras context = new EntitiesCompras())
                {
                    var contact = context.com_solicitante.FirstOrDefault(var => var.IdEmpresa == info.IdEmpresa && var.IdSolicitante == info.IdSolicitante);

                    if (contact != null)
                    {
                        contact.nom_solicitante = info.nom_solicitante;
                        contact.estado = info.estado;
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
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public Boolean AnularDB(com_solicitante_Info info, ref string mensaje)
        {
            try
            {
                using (EntitiesCompras context = new EntitiesCompras())
                {
                    var contact = context.com_solicitante.FirstOrDefault(var => var.IdEmpresa == info.IdEmpresa && var.IdSolicitante == info.IdSolicitante);

                    if (contact != null)
                    {
                        contact.IdUsuarioUltAnu = info.IdUsuarioUltAnu;
                        contact.MotiAnula = info.MotiAnula;
                        contact.Fecha_UltAnu = DateTime.Now;
                        contact.estado = "I";
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
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public List<com_solicitante_Info> Get_List_Solicitante(int IdEmpresa)
        {
            List<com_solicitante_Info> Lst = new List<com_solicitante_Info>();
            try
            {
                EntitiesCompras oEnti = new EntitiesCompras();
                var Query = from q in oEnti.com_solicitante
                            where q.IdEmpresa == IdEmpresa

                            select q;
                foreach (var item in Query)
                {
                    com_solicitante_Info Obj = new com_solicitante_Info();

                    Obj.IdEmpresa = item.IdEmpresa;
                    Obj.IdSolicitante = item.IdSolicitante;
                    Obj.nom_solicitante = item.nom_solicitante;
                    Obj.estado = item.estado;
                    Obj.SEstado = (item.estado.TrimEnd() == "A") ? "ACTIVO" : "*ANULADO*";
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
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }


        

    }
}
