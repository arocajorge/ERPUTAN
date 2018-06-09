using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Bancos;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Bancos 
{
    public class ba_Banco_Cuenta_Data
    {
        string mensaje = "";
        public List<ba_Banco_Cuenta_Info> Get_list_Banco_Cuenta(int IdEmpres)
        {
                List<ba_Banco_Cuenta_Info> lM = new List<ba_Banco_Cuenta_Info>();
                EntitiesBanco b = new EntitiesBanco();
            try
            {        

                var select_ = from T in b.vwba_ba_Banco_Cuenta 
                                        where T.IdEmpresa==IdEmpres 
                                        select T;

                foreach (var item in select_)
                {
                    ba_Banco_Cuenta_Info dat_ = new ba_Banco_Cuenta_Info();
                    dat_.ba_descripcion = item.ba_descripcion;
                    dat_.ba_descripcion2 = "[" + item.IdBanco + "]-" + item.ba_descripcion + "  (" + item.IdCtaCble+ ")";
                    dat_.ba_num_digito_cheq = item.ba_num_digito_cheq;
                    dat_.ba_Moneda = item.ba_Moneda;
                    dat_.ba_Num_Cuenta = item.ba_Num_Cuenta;
                    dat_.ba_Tipo = item.ba_Tipo;
                    dat_.ba_Ultimo_Cheque = item.ba_Ultimo_Cheque;
                    dat_.Estado = item.Estado;
                    dat_.Fecha_Transac = item.Fecha_Transac;
                    dat_.Fecha_UltMod = item.Fecha_UltMod;
                    dat_.IdBanco = item.IdBanco;
                    dat_.IdCtaCble = item.IdCtaCble;
                    dat_.IdEmpresa = item.IdEmpresa;
                    dat_.IdUsuario = item.IdUsuario;
                    dat_.IdUsuarioUltMod = item.IdUsuarioUltMod;
                    dat_.ip = item.ip;
                    dat_.MostrarVistaPreviaCheque = item.MostrarVistaPreviaCheque;
                    dat_.Imprimir_Solo_el_cheque = item.Imprimir_Solo_el_cheque;
                    dat_.nom_pc = item.nom_pc;
                    dat_.Reporte=  item.Reporte;
                    dat_.ReporteSolo_Cheque = item.ReporteSolo_Cheque;
                    dat_.IdBanco_Financiero = item.IdBanco_Financiero;
                    dat_.CodigoLegal = item.CodigoLegal;
                    
                    lM.Add(dat_);
                }
                return (lM);
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

        public List<ba_Banco_Cuenta_Info> Get_list_Banco_Cuenta_Todos(int IdEmpres)
        {
            List<ba_Banco_Cuenta_Info> lM = new List<ba_Banco_Cuenta_Info>();
            EntitiesBanco b = new EntitiesBanco();
            try
            {
                var select_ = from T in b.vwba_ba_Banco_Cuenta
                              where T.IdEmpresa == IdEmpres
                              select T;

                ba_Banco_Cuenta_Info Info = new ba_Banco_Cuenta_Info();
                Info.IdBanco = 0;
                Info.ba_descripcion = "Todos";
                Info.ba_descripcion2 = "Todos";
                lM.Add(Info);
                foreach (var item in select_)
                {
                    ba_Banco_Cuenta_Info dat_ = new ba_Banco_Cuenta_Info();
                    dat_.ba_descripcion = item.ba_descripcion;
                    dat_.ba_descripcion2 = "[" + item.IdBanco + "]-" + item.ba_descripcion + "  (" + item.IdCtaCble + ")";
                    dat_.ba_num_digito_cheq = item.ba_num_digito_cheq;
                    dat_.ba_Moneda = item.ba_Moneda;
                    dat_.ba_Num_Cuenta = item.ba_Num_Cuenta;
                    dat_.ba_Tipo = item.ba_Tipo;
                    dat_.ba_Ultimo_Cheque = item.ba_Ultimo_Cheque;
                    dat_.Estado = item.Estado;
                    dat_.Fecha_Transac = item.Fecha_Transac;
                    dat_.Fecha_UltMod = item.Fecha_UltMod;
                    dat_.IdBanco = item.IdBanco;
                    dat_.IdCtaCble = item.IdCtaCble;
                    dat_.IdEmpresa = item.IdEmpresa;
                    dat_.IdUsuario = item.IdUsuario;
                    dat_.IdUsuarioUltMod = item.IdUsuarioUltMod;
                    dat_.ip = item.ip;
                    dat_.MostrarVistaPreviaCheque = item.MostrarVistaPreviaCheque;
                    dat_.Imprimir_Solo_el_cheque = item.Imprimir_Solo_el_cheque;
                    dat_.nom_pc = item.nom_pc;
                    dat_.Reporte = item.Reporte;
                    dat_.ReporteSolo_Cheque = item.ReporteSolo_Cheque;
                    dat_.IdBanco_Financiero = item.IdBanco_Financiero;
                    dat_.CodigoLegal = item.CodigoLegal;

                    lM.Add(dat_);
                }
                return (lM);
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

        public int getId(int IdEmpresa)
        {
            try
            {
                int Id;
                EntitiesBanco base_ = new EntitiesBanco();

                var q = from C in base_.ba_Banco_Cuenta 
                        where C.IdEmpresa == IdEmpresa
                        select C;
               
                if (q.ToList().Count == 0)
                    return 1;
                else
                {
                    var select_ = (from T in base_.ba_Banco_Cuenta 
                                   where T.IdEmpresa == IdEmpresa
                                   select T.IdBanco).Max();
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
                return -1;
            }
          
        }

        public Boolean GrabarDB(ba_Banco_Cuenta_Info info, ref int idBan)
        {
            try
            {
                int idBanco;

                using (EntitiesBanco context = new EntitiesBanco())
                {
                    EntitiesBanco EDB = new EntitiesBanco();
                    var Q = from reg in EDB.ba_Banco_Cuenta 
                            where reg.IdEmpresa == info.IdEmpresa
                            && reg.IdBanco  == info.IdBanco 
                            select reg;
                    if (Q.ToList().Count == 0)
                    {
                        idBanco = getId(info.IdEmpresa);
                        ba_Banco_Cuenta address = new ba_Banco_Cuenta();
                        address.IdEmpresa = info.IdEmpresa;
                        address.IdBanco = idBanco;
                        address.ba_descripcion = info.ba_descripcion;
                        address.ba_num_digito_cheq = Convert.ToInt32(info.ba_num_digito_cheq);
                        address.ba_Moneda = info.ba_Moneda;
                        address.ba_Num_Cuenta = info.ba_Num_Cuenta;
                        address.ba_Tipo = info.ba_Tipo;
                        address.ba_Ultimo_Cheque = "0";
                        address.Estado = info.Estado;
                        address.IdCtaCble = info.IdCtaCble;
                        address.Fecha_Transac = info.Fecha_Transac;
                        address.IdUsuario = info.IdUsuario;
                        address.nom_pc = info.nom_pc;
                        address.ip = info.ip;
                        address.Reporte = info.Reporte;
                        address.ReporteSolo_Cheque  = info.ReporteSolo_Cheque ;
                        address.MostrarVistaPreviaCheque = info.MostrarVistaPreviaCheque;
                        address.Imprimir_Solo_el_cheque = info.Imprimir_Solo_el_cheque;
                        address.IdBanco_Financiero = info.IdBanco_Financiero;
                        context.ba_Banco_Cuenta.Add(address);
                        context.SaveChanges();
                        idBan = idBanco;
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
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ActualizarEstado(ba_Banco_Cuenta_Info info)
        {
            try
            {
                using (EntitiesBanco context = new EntitiesBanco())
                {
                    var contact = context.ba_Banco_Cuenta.FirstOrDefault(minfo => minfo.IdEmpresa == info.IdEmpresa && minfo.IdBanco == info.IdBanco);
                    if (contact != null)
                    {
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
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ModificarDB(ba_Banco_Cuenta_Info info)
        {
            try
            {
                using (EntitiesBanco context = new EntitiesBanco())
                {
                    var contact = context.ba_Banco_Cuenta.First(minfo => minfo.IdEmpresa == info.IdEmpresa && minfo.IdBanco == info.IdBanco);

                    contact.ba_descripcion = info.ba_descripcion;
                    contact.ba_num_digito_cheq = info.ba_num_digito_cheq;
                    contact.ba_Moneda = info.ba_Moneda;
                    contact.ba_Num_Cuenta = info.ba_Num_Cuenta;
                    contact.ba_Tipo = info.ba_Tipo;
                    contact.ba_Ultimo_Cheque = info.ba_Ultimo_Cheque;
                    contact.Estado = info.Estado;
                    contact.IdCtaCble = info.IdCtaCble;
                    contact.nom_pc = info.nom_pc;
                    contact.ip = info.ip;
                    contact.Reporte = info.Reporte;
                    contact.ReporteSolo_Cheque = info.ReporteSolo_Cheque;
                    contact.Fecha_UltMod = info.Fecha_UltMod;
                    contact.IdUsuarioUltMod = info.IdUsuarioUltMod;
                    contact.MostrarVistaPreviaCheque = info.MostrarVistaPreviaCheque;
                    contact.Imprimir_Solo_el_cheque = info.Imprimir_Solo_el_cheque;
                    contact.IdBanco_Financiero = info.IdBanco_Financiero;
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
                throw new Exception(ex.InnerException.ToString());
            }
        }

        //función que revisa si la cuenta contable existe o no.
        public Boolean Get_Cuenta_Existe(int IdEmpresa, string NumCtaCble, ref string Mensaje)
        {
            try
            {
                EntitiesBanco OEBanco = new EntitiesBanco();

                var select = from q in OEBanco.ba_Banco_Cuenta
                             where q.IdEmpresa == IdEmpresa
                             && q.IdCtaCble==NumCtaCble
                             select q;
                if (select.Count() > 0)
                {
                    return false;
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

        public ba_Banco_Cuenta_Info Get_Info_Banco_Cuenta(int IdEmpresa, int Idbanco) 
        {
            try
            {
                using (EntitiesBanco Entity = new EntitiesBanco())
                {
                    ba_Banco_Cuenta banco = Entity.ba_Banco_Cuenta.FirstOrDefault(v=>v.IdEmpresa == IdEmpresa && v.IdBanco == Idbanco);
                    if (banco != null)
                    {
                        return new ba_Banco_Cuenta_Info()
                        {
                            IdCtaCble = banco.IdCtaCble,
                            ba_descripcion = banco.ba_descripcion,
                            ba_Moneda = banco.ba_Moneda
                            ,
                            ba_Num_Cuenta = banco.ba_Num_Cuenta,
                            IdEmpresa = banco.IdEmpresa,
                            IdBanco = banco.IdBanco,
                            ba_Tipo = banco.ba_Tipo,
                            ba_num_digito_cheq = banco.ba_num_digito_cheq,
                            Reporte = banco.Reporte,
                            ReporteSolo_Cheque = banco.ReporteSolo_Cheque,
                            Imprimir_Solo_el_cheque = banco.Imprimir_Solo_el_cheque,
                            MostrarVistaPreviaCheque = banco.MostrarVistaPreviaCheque,
                            IdBanco_Financiero=banco.IdBanco_Financiero
                        };
                    }
                    else
                        return new ba_Banco_Cuenta_Info();
                }
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

        public List<ba_Banco_Cuenta_Info> Get_List_Banco_Cuenta(ref string error_out)
        {
            try
            {
                List<ba_Banco_Cuenta_Info> Lista = new List<ba_Banco_Cuenta_Info>();

                EntitiesBanco oEntities = new EntitiesBanco();

                var select = from q in oEntities.ba_Banco_Cuenta
                             select q;

                foreach (var item in select)
                {
                    ba_Banco_Cuenta_Info info = new ba_Banco_Cuenta_Info();
                    info.IdBanco = item.IdBanco;
                    info.ba_descripcion = item.ba_descripcion;
                    info.IdCtaCble = item.IdCtaCble;
                    info.IdEmpresa = item.IdEmpresa;
                    info.ba_num_digito_cheq = item.ba_num_digito_cheq;
                    info.ReporteSolo_Cheque = item.ReporteSolo_Cheque;
                    info.Reporte = item.Reporte;
                    info.MostrarVistaPreviaCheque = item.MostrarVistaPreviaCheque;
                    info.Imprimir_Solo_el_cheque = item.Imprimir_Solo_el_cheque;
                    info.IdBanco_Financiero = item.IdBanco_Financiero;
                    Lista.Add(info);
                }
                return Lista;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                error_out = mensaje;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public Boolean Verificar_Si_Existe_Cuenta_x_CtaCble(int IdEmpresa,string IdCtaCble )
        {
            try
            {
                Boolean Si_Existe = false;

                List<ba_Banco_Cuenta_Info> Lista = new List<ba_Banco_Cuenta_Info>();

                EntitiesBanco oEntities = new EntitiesBanco();

                var select = from q in oEntities.ba_Banco_Cuenta
                             where q.IdEmpresa == IdEmpresa && q.IdCtaCble == IdCtaCble
                             select q;

                if (select.ToList().Count > 0)
                { return Si_Existe; }

                return Si_Existe;
                
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                //error_out = mensaje;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public ba_Banco_Cuenta_Data() 
        {
            try
            {

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
   }
}
