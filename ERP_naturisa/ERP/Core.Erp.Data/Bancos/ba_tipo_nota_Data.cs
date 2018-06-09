using Core.Erp.Info.Bancos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.Bancos
{
    public class ba_tipo_nota_Data
    {
        string mensaje = "";

        public List<ba_tipo_nota_Info> Get_List_tipo_nota(int IdEmpresa)
        {
            try
            {
                List<ba_tipo_nota_Info> lista = new List<ba_tipo_nota_Info>();
                using (EntitiesBanco Entity = new EntitiesBanco())
                {
                    var query = from q in Entity.vwba_tipo_nota
                                where q.IdEmpresa == IdEmpresa
                                select q;
                    foreach (var item in query)
                    {
                        ba_tipo_nota_Info info = new ba_tipo_nota_Info();

                        info.IdEmpresa = item.IdEmpresa;
                        info.IdTipoNota = item.IdTipoNota;
                        info.Tipo = item.Tipo;
                        info.Descripcion = item.Descripcion;
                        info.IdCtaCble = item.IdCtaCble;
                        info.nom_CtaCble = item.nom_CtaCble;
                        info.IdCentroCosto = item.IdCentroCosto;
                        info.nom_CentroCosto = item.nom_CentroCosto;
                        info.Descripcion2 = "[" + item.IdTipoNota + "] " + item.Descripcion;
                        info.Estado = item.Estado;
                        lista.Add(info);
                    }
                }
                return lista;
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

        public List<ba_tipo_nota_Info> Get_List_tipo_nota(int IdEmpresa, string tipo)
        {
            try
            {
                List<ba_tipo_nota_Info> lista = new List<ba_tipo_nota_Info>();
                using (EntitiesBanco Entity = new EntitiesBanco())
                {
                    var query = from q in Entity.vwba_tipo_nota
                                where q.IdEmpresa == IdEmpresa
                                && q.Tipo == tipo
                                select q;
                    foreach (var item in query)
                    {
                        ba_tipo_nota_Info info = new ba_tipo_nota_Info();

                        info.IdEmpresa = item.IdEmpresa;
                        info.IdTipoNota = item.IdTipoNota;
                        info.Tipo = item.Tipo;
                        info.Descripcion = item.Descripcion;
                        info.IdCtaCble = item.IdCtaCble;
                        info.nom_CtaCble = item.nom_CtaCble;
                        info.IdCentroCosto = item.IdCentroCosto;
                        info.nom_CentroCosto = item.nom_CentroCosto;
                        info.Descripcion2 = "[" + item.IdTipoNota + "] " + item.Descripcion;
                        info.Estado = item.Estado;
                        lista.Add(info);
                    }
                }
                return lista;
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

        public int Get_IdTipoNota(int IdEmpresa)
        {
            try
            {
                int Id;
                EntitiesBanco ECXP = new EntitiesBanco();

                var select = ECXP.ba_tipo_nota.Count(q => q.IdEmpresa == IdEmpresa);
                if (select == 0)
                {
                    return Id = 1;
                }

                else
                {
                    var select_ = (from t in ECXP.ba_tipo_nota
                                   where t.IdEmpresa == IdEmpresa
                                   select t.IdTipoNota).Max();
                    Id = Convert.ToInt32(select_.ToString()) + 1;
                    return Id;
                }
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

        public ba_tipo_nota_Info Get_Info_tipo_nota(int IdEmpresa, int idTipoNota)
        {
            try
            {
                EntitiesBanco context = new EntitiesBanco();
                ba_tipo_nota_Info Info = new ba_tipo_nota_Info();

                var address = context.ba_tipo_nota.FirstOrDefault(var => var.IdEmpresa == IdEmpresa && var.IdTipoNota == idTipoNota);
                if (address != null)
                {
                    Info.IdEmpresa = address.IdEmpresa;
                    Info.IdTipoNota = address.IdTipoNota;
                    Info.Tipo = address.Tipo;
                    Info.Descripcion = address.Descripcion;
                    Info.IdCtaCble = address.IdCtaCble;
                    Info.IdCentroCosto = address.IdCentroCosto;
                    Info.Estado = address.Estado;
                }
                return Info;
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

        public Boolean ActualizarDB(ba_tipo_nota_Info Info)
        {
            try
            {
                EntitiesBanco context = new EntitiesBanco();
                var address = context.ba_tipo_nota.FirstOrDefault(var => var.IdEmpresa == Info.IdEmpresa && var.IdTipoNota==Info.IdTipoNota);
                if (address != null)
                {
                    address.Tipo = Info.Tipo;
                    address.Descripcion = Info.Descripcion;
                    address.IdCtaCble = Info.IdCtaCble;
                    address.IdCentroCosto = Info.IdCentroCosto;
                    address.Estado = Info.Estado;
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
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }   
        }

        public Boolean AnularDB(ba_tipo_nota_Info Info, ref string msg)
        {
            try
            {
                EntitiesBanco context = new EntitiesBanco();
                var address = context.ba_tipo_nota.FirstOrDefault(var => var.IdEmpresa == Info.IdEmpresa && var.IdTipoNota == Info.IdTipoNota);
                if (address != null)
                {
                    address.Tipo = Info.Tipo;
                    address.Descripcion = Info.Descripcion;
                    address.IdCtaCble = Info.IdCtaCble;
                    address.IdCentroCosto = Info.IdCentroCosto;
                    address.Estado = "I";
                    context.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                msg = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref msg);
                msg = "Se ha producido el siguiente error: " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean GuardarDB(ba_tipo_nota_Info Info)
        {
            try
            {
                EntitiesBanco context = new EntitiesBanco();
                var address = new ba_tipo_nota();
                address.IdEmpresa = Info.IdEmpresa;
                address.IdTipoNota = Info.IdTipoNota = GetId(Info.IdEmpresa);
                address.Tipo = Info.Tipo;
                address.Descripcion = Info.Descripcion;
                address.IdCtaCble = Info.IdCtaCble;
                address.IdCentroCosto = Info.IdCentroCosto;
                address.Estado = Info.Estado;
                context.ba_tipo_nota.Add(address);
                context.SaveChanges();
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

        private  Int32 GetId(int IdEmpresa)
        {
            try
            {
               
                Int32 secuencia;
                EntitiesBanco base_ = new EntitiesBanco();

                var q = from C in base_.ba_tipo_nota
                        where C.IdEmpresa==IdEmpresa
                        select C;

                if (q.ToList().Count < 1)
                    return 1;
                else
                {
                    base_ = new EntitiesBanco();
                    var select_ = (from T in base_.ba_tipo_nota
                                   where T.IdEmpresa==IdEmpresa
                                   select T.IdTipoNota).Max();
                    secuencia = Convert.ToInt32(select_.ToString()) + 1;
                    return secuencia;
                }

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
