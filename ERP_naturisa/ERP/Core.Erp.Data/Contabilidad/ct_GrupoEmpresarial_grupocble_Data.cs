using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.Contabilidad
{
    public class ct_GrupoEmpresarial_grupocble_Data
    {
        string mensaje = "";

        public Boolean GuardarDB(ct_GrupoEmpresarial_grupocble_Info Info)
        {
            try
            {
                List<ct_GrupoEmpresarial_grupocble_Info> Lst = new List<ct_GrupoEmpresarial_grupocble_Info>();
                using (EntitiesDBConta Context = new EntitiesDBConta())
                {
                    
                    var Address = new ct_GrupoEmpresarial_grupocble();

                    Address.IdGrupoCble_gr = Info.IdGrupoCble_gr;
                    Address.gc_GrupoCble_gr = Info.gc_GrupoCble_gr;
                    Address.gc_Orden = Info.gc_Orden;
                    Address.gc_estado_financiero = Info.gc_estado_financiero;
                    Address.gc_signo_operacion = Info.gc_signo_operacion;

                    Context.ct_GrupoEmpresarial_grupocble.Add(Address);
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

        public List<ct_GrupoEmpresarial_grupocble_Info> Get_list_GrupoEmpresarial_grupocble()
        {
            try
            {
                List<ct_GrupoEmpresarial_grupocble_Info> Lst = new List<ct_GrupoEmpresarial_grupocble_Info>();
                EntitiesDBConta oEnti = new EntitiesDBConta();
                var Query = from q in oEnti.ct_GrupoEmpresarial_grupocble
                            select q;
                foreach (var item in Query)
                {
                    ct_GrupoEmpresarial_grupocble_Info Obj = new ct_GrupoEmpresarial_grupocble_Info();
                    Obj.IdGrupoCble_gr = item.IdGrupoCble_gr;
                    Obj.gc_GrupoCble_gr = item.gc_GrupoCble_gr;
                    Obj.gc_Orden = item.gc_Orden;
                    Obj.gc_estado_financiero = item.gc_estado_financiero;
                    Obj.gc_signo_operacion = item.gc_signo_operacion;
                    Lst.Add(Obj);
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

        public Boolean VericarExisteIdString(string codigo, ref string mensaje)
        {
            try
            {
                Boolean Existe;
                        string scodigo;

                        scodigo = codigo.Trim();
                        mensaje = "";
                        Existe = false;

                        EntitiesDBConta B = new EntitiesDBConta();

                        var select_ = from t in B.ct_GrupoEmpresarial_grupocble
                                      where t.gc_GrupoCble_gr == scodigo
                                      select t;

                        foreach (var item in select_)
                        {
                            mensaje = mensaje + " " + item.gc_GrupoCble_gr;
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

        public Boolean ModificarDB(ct_GrupoEmpresarial_grupocble_Info info)
        {
            try
            {
                using (EntitiesDBConta context = new EntitiesDBConta())
                {
                    var contact = context.ct_GrupoEmpresarial_grupocble.FirstOrDefault(minfo => minfo.IdGrupoCble_gr == info.IdGrupoCble_gr);
                    if (contact != null)
                    {
                        contact.IdGrupoCble_gr = info.IdGrupoCble_gr;
                        contact.gc_GrupoCble_gr = info.gc_GrupoCble_gr;
                        contact.gc_Orden = info.gc_Orden;
                        contact.gc_estado_financiero = info.gc_estado_financiero;
                        contact.gc_signo_operacion = info.gc_signo_operacion;
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
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public ct_GrupoEmpresarial_grupocble_Data()
        {
            
        }
    }
}
