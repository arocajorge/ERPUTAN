using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Contabilidad
{
    public class ct_Plancta_nivel_Data
    {
        string mensaje = "";

        public int getId_Plancta_nivel()
        {
            int Id = 0;
            try
            {
                using (EntitiesDBConta Base = new EntitiesDBConta())
                {
                    int select = (from q in Base.ct_plancta_nivel
                                  select q).Count();

                    if (select == 0)
                    {
                        Id = 1;
                    }
                    else
                    {
                        var select_as = (from q in Base.ct_plancta_nivel
                                         select q.IdNivelCta).Max();
                        Id = Convert.ToInt32(select_as.ToString()) + 1;
                    }
                }
                return Id;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                string MensajeError = string.Empty;
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                MensajeError = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                throw new Exception(ex.ToString());
            }
        }
        
        public List<ct_Plancta_nivel_Info> Get_list_Plancta_nivel(int IdEmpresa)
        {
            try
            {

                List<ct_Plancta_nivel_Info> lM = new List<ct_Plancta_nivel_Info>();
                using (EntitiesDBConta OEselectPlancta_nivel = new EntitiesDBConta())
                {
                    var selectPlancta_nivel = from C in OEselectPlancta_nivel.ct_plancta_nivel
                                              where C.IdEmpresa == IdEmpresa
                                              select C;

                    ct_Plancta_nivel_Info _PlantaCtaNivelInfo;
                    foreach (var item in selectPlancta_nivel)
                    {   
                        _PlantaCtaNivelInfo = new ct_Plancta_nivel_Info();
                        _PlantaCtaNivelInfo.IdEmpresa = item.IdEmpresa;
                        _PlantaCtaNivelInfo.IdNivelCta = item.IdNivelCta;
                        _PlantaCtaNivelInfo.nv_NumDigitos = item.nv_NumDigitos;
                        _PlantaCtaNivelInfo.nv_Descripcion = item.nv_Descripcion;
                        _PlantaCtaNivelInfo.Estado = item.Estado;

                        lM.Add(_PlantaCtaNivelInfo);
                    }

                    return (lM);
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

        public ct_Plancta_nivel_Info Get_info_plancta_nivel(int IdEmpresa, int IdNivelCta)
        {
            try
            {
                ct_Plancta_nivel_Info info = new ct_Plancta_nivel_Info();

                using (EntitiesDBConta OEselectPlancta_nivel = new EntitiesDBConta())
                {
                    var selectPlancta_nivel = from C in OEselectPlancta_nivel.vwct_plancta_nivel
                                              where C.IdEmpresa == IdEmpresa
                                              && C.IdNivelCta == IdNivelCta
                                              select C;


                    foreach (var item in selectPlancta_nivel)
                    {
                        info = new ct_Plancta_nivel_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdNivelCta = item.IdNivelCta;
                        info.nv_NumDigitos = item.nv_NumDigitos;
                        info.nv_Descripcion = item.nv_Descripcion;
                        info.nv_NumDigitos_total = item.nv_NumDigitos_total;
                        info.Estado = item.Estado;
                    }
                }

                return info;
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

        public Boolean Valida_Nivel(ct_Plancta_nivel_Info _PCninfo)
        {
            try
            {
                using (EntitiesDBConta context = new EntitiesDBConta())
                {
                     var Q = from PCta_info in context.ct_plancta
                             where PCta_info.IdEmpresa == _PCninfo.IdEmpresa && PCta_info.IdNivelCta == _PCninfo.IdNivelCta
                             select PCta_info;
                     return (Q.ToList().Count > 0) ? true : false;
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

        public Boolean ModificarDB(ct_Plancta_nivel_Info _PCninfo)
        {
            try
            {
                using (EntitiesDBConta context = new EntitiesDBConta())
                {
                    var contact = context.ct_plancta_nivel.FirstOrDefault(Pcta_info => Pcta_info.IdNivelCta == _PCninfo.IdNivelCta && Pcta_info.IdEmpresa==_PCninfo.IdEmpresa);
                    if (contact != null)
                    {
                        contact.IdEmpresa = _PCninfo.IdEmpresa;
                        contact.IdNivelCta = Convert.ToByte(_PCninfo.IdNivelCta);
                        contact.nv_NumDigitos = Convert.ToByte(_PCninfo.nv_NumDigitos);
                        contact.nv_Descripcion = _PCninfo.nv_Descripcion;
                        contact.Estado = _PCninfo.Estado;                        
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

        public Boolean GrabarDB(ct_Plancta_nivel_Info _PCninfo)
        {
            try
            {
                using (EntitiesDBConta context = new EntitiesDBConta())
                {
                    EntitiesDBConta EDB = new EntitiesDBConta();
                    var Q = from per in EDB.ct_plancta_nivel
                            where per.IdNivelCta == _PCninfo.IdNivelCta 
                            && per.IdEmpresa == _PCninfo.IdEmpresa
                            select per;
                    if (Q.ToList().Count == 0)
                    {
                        var address = new ct_plancta_nivel();
                        int IdNivel = 0;
                        IdNivel = (_PCninfo.IdNivelCta != 0) ? _PCninfo.IdNivelCta : getId_Plancta_nivel();
                        address.IdEmpresa = _PCninfo.IdEmpresa;
                        address.IdNivelCta = IdNivel;
                        address.nv_NumDigitos = _PCninfo.nv_NumDigitos;
                        address.nv_Descripcion = _PCninfo.nv_Descripcion;
                        address.Estado = "A";
                        context.ct_plancta_nivel.Add(address);
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

        public Boolean GrabarDB(List<ct_Plancta_nivel_Info> _ListPCninfo)
        {
            try
            {
                foreach (var item in _ListPCninfo)
                {
                    GrabarDB(item);
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

        public Boolean AnularDB(ct_Plancta_nivel_Info _PCninfo)
        {
            try
            {
                using (EntitiesDBConta context = new EntitiesDBConta())
                {
                    var contact = context.ct_plancta_nivel.FirstOrDefault(Pcta_info => Pcta_info.IdEmpresa == _PCninfo.IdEmpresa && Pcta_info.IdNivelCta == _PCninfo.IdNivelCta);

                    if (contact != null)
                    {
                        contact.IdUsuarioUltAnu = _PCninfo.IdUsuarioUltAnu;
                        contact.Fecha_UltAnu = DateTime.Now;
                        contact.MotivoAnulacion = _PCninfo.MotivoAnulacion;
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

        public Boolean EliminarDB(int IdEmpresa)
        {
            try
            {
                using (EntitiesDBConta Entity = new EntitiesDBConta())
                {
                    int numeroElimindo = Entity.Database.ExecuteSqlCommand("delete ct_plancta_nivel where IdEmpresa = " + IdEmpresa);
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

        public ct_Plancta_nivel_Data()
        {
           
        }
    }
}
