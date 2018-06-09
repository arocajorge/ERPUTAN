using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.Contabilidad
{
    public class ct_Centro_costo_nivel_Data
    {
        string mensaje = "";

        public List<ct_Centro_costo_nivel_Info> Get_Info_Centro_Costo_nivel(int IdEmpresa)
        {
            try
            {
                List<ct_Centro_costo_nivel_Info> lM = new List<ct_Centro_costo_nivel_Info>();
                EntitiesDBConta OECCostoN = new EntitiesDBConta();
                var selectCCostoN = from C in OECCostoN.ct_centro_costo_nivel
                                    where C.IdEmpresa == IdEmpresa
                                    select C;

                foreach (var item in selectCCostoN)
                {
                    ct_Centro_costo_nivel_Info Cbt = new ct_Centro_costo_nivel_Info();
                    Cbt.IdEmpresa = item.IdEmpresa;
                    Cbt.IdNivel = item.IdNivel;
                    Cbt.ni_descripcion = item.ni_descripcion;
                    Cbt.ni_digitos=item.ni_digitos;
                    Cbt.Estado = item.Estado;
                    lM.Add(Cbt);
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
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ModificarDB(ct_Centro_costo_nivel_Info info)
        {
            try
            {
                using (EntitiesDBConta context = new EntitiesDBConta())
                {
                    var contact = context.ct_centro_costo_nivel.FirstOrDefault(minfo => minfo.IdNivel == info.IdNivel && minfo.IdEmpresa == info.IdEmpresa);
                    if (contact != null)
                    {
                        contact.IdEmpresa = info.IdEmpresa;
                        contact.IdNivel = Convert.ToByte(info.IdNivel);
                        contact.ni_descripcion = info.ni_descripcion;
                        contact.ni_digitos = Convert.ToByte(info.ni_digitos);
                        contact.Estado = info.Estado;
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

        public Boolean GrabarDB(ct_Centro_costo_nivel_Info info)
        {
            try
            {
                using (EntitiesDBConta context = new EntitiesDBConta())
                {
                    EntitiesDBConta EDB = new EntitiesDBConta();
                    var Q = from per in EDB.ct_centro_costo_nivel
                            where per.IdNivel == info.IdNivel && per.IdEmpresa== info.IdEmpresa
                            select per;
                    if (Q.ToList().Count == 0)
                    {
                        var address = new ct_centro_costo_nivel();
                        address.IdEmpresa = info.IdEmpresa;
                        address.IdNivel = Convert.ToByte(info.IdNivel);
                        address.ni_descripcion = info.ni_descripcion;
                        address.ni_digitos = Convert.ToByte(info.ni_digitos);
                        address.Estado = "A";
                        context.ct_centro_costo_nivel.Add(address);
                        context.SaveChanges();
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
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }
        
        public Boolean EliminarDB(ct_Centro_costo_nivel_Info info)
        {
            try
            {
                using (EntitiesDBConta context = new EntitiesDBConta())
                {
                    var contact = context.ct_centro_costo_nivel.FirstOrDefault(dinfo => dinfo.IdEmpresa== info.IdEmpresa && dinfo.IdNivel==info.IdNivel);

                    if (contact != null)
                    {
                        contact.IdUsuarioUltAnu = info.IdUsuarioUltAnu;
                        contact.Fecha_UltAnu = info.Fecha_UltAnu;
                        contact.MotivoAnulacion = info.MotivoAnulacion;
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
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public int Get_Id(int IdEmpresa)
        {
            int Id;
            try
            {
                EntitiesDBConta tabla = new EntitiesDBConta();
                var q = (from reg in tabla.ct_centro_costo_nivel
                         where reg.IdEmpresa == IdEmpresa
                         select reg);
                if (q.ToList().Count == 0)
                    return 1;
                else
                {
                    var p2 = (from reg in tabla.ct_centro_costo_nivel
                              where reg.IdEmpresa == IdEmpresa
                              select reg.IdNivel).Max();
                    Id = Convert.ToInt32(p2.ToString()) + 1;
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
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public ct_Centro_costo_nivel_Data()
        {
           
        }
    }
}
