using Core.Erp.Data.General;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Data.CuentasxPagar
{
    public class cp_archivos_para_banco_x_cxp_Data
    {


        string mensaje = "";

        public decimal Get_IdArchivo(int IdEmpresa)
        {
            try
            {
                decimal Id;
                EntitiesCuentasxPagar ECXP = new EntitiesCuentasxPagar();

                var select = ECXP.cp_archivos_para_banco_x_cxp.Count(q => q.IdEmpresa == IdEmpresa);
                if (select == 0)
                {
                    return Id = 1;
                }

                else
                {
                    var select_ = (from t in ECXP.cp_archivos_para_banco_x_cxp
                                   where t.IdEmpresa == IdEmpresa
                                   select t.IdArchivo).Max();
                    Id = Convert.ToDecimal(select_.ToString()) + 1;
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
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean GuardaDB(cp_archivos_para_banco_x_cxp_Info info, ref decimal Id, ref string mensaje)
        {
            try
            {
                using (EntitiesCuentasxPagar Context = new EntitiesCuentasxPagar())
                {
                    cp_archivos_para_banco_x_cxp data = new cp_archivos_para_banco_x_cxp();

                    data.IdEmpresa = info.IdEmpresa;
                    data.IdArchivo = Get_IdArchivo(info.IdEmpresa);
                    data.IdBanco = info.IdBanco;
                    data.Fecha = info.Fecha;
                    data.Cod_Empresa = info.Cod_Empresa;
                    data.Tipo = info.Tipo;
                    data.Nom_Archivo = info.Nom_Archivo;
                    data.archivo = info.archivo;
                    data.estado = info.estado;
                    data.IdUsuario = info.IdUsuario;
                    data.Fecha_Transac = info.Fecha_Transac;
                    data.observacion = info.observacion;
                    Id = data.IdArchivo;
                    Context.cp_archivos_para_banco_x_cxp.Add(data);
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
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ModificarDB(cp_archivos_para_banco_x_cxp_Info info, ref string msg)
        {
            try
            {
                using (EntitiesCuentasxPagar context = new EntitiesCuentasxPagar())
                {
                    var contact = context.cp_archivos_para_banco_x_cxp.FirstOrDefault(obj => obj.IdEmpresa == info.IdEmpresa  && info.IdArchivo==obj.IdArchivo);
                    if (contact != null)
                    {

                        contact.IdEmpresa = info.IdEmpresa;
                        contact.IdBanco = info.IdBanco;
                        contact.Fecha = info.Fecha;
                        contact.Cod_Empresa = info.Cod_Empresa;
                        contact.Tipo = info.Tipo;
                        contact.archivo = info.archivo;
                        contact.observacion = info.observacion;
                        contact.IdUsuarioUltMod = info.IdUsuarioUltMod;
                        contact.Fecha_UltMod = info.Fecha_UltMod;
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

        public Boolean AnularDB(cp_archivos_para_banco_x_cxp_Info Info)
        {
            try
            {
                using (EntitiesCuentasxPagar Entity = new EntitiesCuentasxPagar())
                {
                    cp_archivos_para_banco_x_cxp info_archivo = Entity.cp_archivos_para_banco_x_cxp.FirstOrDefault(v => v.IdEmpresa == Info.IdEmpresa && v.IdArchivo== Info.IdArchivo);
                    if (info_archivo != null)
                    {
                        info_archivo.IdUsuarioUltAnu = Info.IdUsuarioUltAnu;
                        info_archivo.Fecha_UltAnu = Info.Fecha_UltAnu;
                        info_archivo.estado = "I";
                        info_archivo.Motivo_anulacion = Info.Motivo_anulacion;
                        Entity.SaveChanges();
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

        public List<cp_archivos_para_banco_x_cxp_Info> Get_List_Pagos_x_Archivos(int IdEmpresa, DateTime FechaIni, DateTime FechaFin, ref string mensaje)
        {
            try
            {

                FechaIni = Convert.ToDateTime(FechaIni.ToShortDateString());

                FechaFin = Convert.ToDateTime(FechaFin.ToShortDateString());


                List<cp_archivos_para_banco_x_cxp_Info> lM = new List<cp_archivos_para_banco_x_cxp_Info>();
                EntitiesCuentasxPagar ECXP = new EntitiesCuentasxPagar();

                var Listado_File = from selec in ECXP.cp_archivos_para_banco_x_cxp
                                 where selec.IdEmpresa == IdEmpresa
                                        && selec.Fecha >= FechaIni && selec.Fecha <= FechaFin
                                 select selec;

                foreach (var item in Listado_File)
                {
                    cp_archivos_para_banco_x_cxp_Info info = new cp_archivos_para_banco_x_cxp_Info();
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdArchivo = item.IdArchivo;
                    info.observacion = item.observacion;
                    info.Tipo = item.Tipo;
                    info.Fecha = item.Fecha;
                    info.Fecha_Transac = item.Fecha_Transac;
                    info.archivo = item.archivo;
                    info.Nom_Archivo = item.Nom_Archivo;
                    info.IdBanco=(int)item.IdBanco;
                    info.estado = item.estado;
                    lM.Add(info);
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
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

    }
}
