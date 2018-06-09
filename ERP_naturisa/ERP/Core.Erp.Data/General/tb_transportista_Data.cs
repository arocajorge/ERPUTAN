using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.General
{
    public class tb_transportista_Data
    {
        string mensaje = "";
        public List<tb_transportista_Info> Get_List_transportista(int IdEmpresa) {
            try
            {
                List<tb_transportista_Info> lista = new List<tb_transportista_Info>();
                using (EntitiesGeneral context=new EntitiesGeneral())
                {
                    
                    EntitiesGeneral ListTrans = new EntitiesGeneral();
                    var datos=from T in ListTrans.tb_transportista
                        where T.IdEmpresa==IdEmpresa
                                  select T;
                    foreach(var item in datos)
                    {
                        tb_transportista_Info info = new tb_transportista_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdTransportista = item.IdTransportista;
                        info.Cedula = item.Cedula;
                        info.Nombre = item.Nombre;
                        info.Estado = item.Estado;
                        info.Placa = item.Placa;
                        info.pe_nombreCompleto = item.Nombre;
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
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
            
        }

        public Boolean GuardarDB(tb_transportista_Info Info, ref decimal IdTransportista)
        {
            try
            {
                using (EntitiesGeneral oEnti = new EntitiesGeneral())
                {
                    var consulta = from q in oEnti.tb_transportista 
                                   where q.IdEmpresa == Info.IdEmpresa && q.Cedula == Info.Cedula
                                   select q;
                    if (consulta.ToList().Count == 0)
                    {
                        var registo = new tb_transportista();

                        registo.IdEmpresa = Info.IdEmpresa;
                        registo.IdTransportista = Info.IdTransportista = IdTransportista = GetIdTransportista(Info.IdEmpresa);
                        registo.Nombre = Info.Nombre;
                        registo.Cedula = Info.Cedula;
                        registo.Estado = Info.Estado;
                        registo.Placa = Info.Placa;
                        oEnti.tb_transportista.Add(registo);
                        oEnti.SaveChanges();
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

        public int GetIdTransportista(int IdEmpresa)
        {
            int Id = 0;
            try
            {
                EntitiesGeneral oEnti = new EntitiesGeneral();

                var consulta = (from C in oEnti.tb_transportista
                                where C.IdEmpresa == IdEmpresa
                                select C.IdTransportista);
                if (consulta.Count() == 0)
                {

                    Id = 1;
                }
                else
                {
                    var consulta_ = (from C in oEnti.tb_transportista
                                    where C.IdEmpresa == IdEmpresa
                                    select C.IdTransportista).Count()+1;
                    Id = consulta_;
                }

                return Id;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ModificarDB(tb_transportista_Info Info)
        {
            try
            {
                using (EntitiesGeneral oEnti = new EntitiesGeneral())
                {
                    var registro = oEnti.tb_transportista.FirstOrDefault(A => A.IdEmpresa == Info.IdEmpresa && A.IdTransportista == Info.IdTransportista);
                    if (registro != null)
                    {
                        registro.Nombre = Info.Nombre;
                        registro.Cedula = Info.Cedula;
                        registro.Placa = Info.Placa;
                        registro.Fecha_UltMod = DateTime.Now;
                        registro.IdUsuarioUltModi = Info.IdUsuarioUltModi;
                        registro.Estado = Info.Estado;
                        oEnti.SaveChanges();
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
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean AnularDB(tb_transportista_Info Info)
        {
            try
            {
                using (EntitiesGeneral oEnti = new EntitiesGeneral())
                {
                    var registro = oEnti.tb_transportista.FirstOrDefault(A => A.IdEmpresa == Info.IdEmpresa && A.IdTransportista == Info.IdTransportista);
                    if (registro != null)
                    {
                        registro.IdUsuarioUltAnu = Info.IdUsuarioUltAnu;
                        registro.Fecha_UltAnu = Info.Fecha_UltAnu;
                        registro.MotivoAnulacion = Info.MotivoAnulacion;
                        registro.Estado = "I";
                        oEnti.SaveChanges();
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
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public tb_transportista_Info Get_Info_Transportista(int IdEmpresa, string Cedula) 
        {
            try
            {
                using (EntitiesGeneral conexion = new  EntitiesGeneral())
                {

                    var item = (from q in conexion.tb_transportista
                                where q.IdEmpresa == IdEmpresa && q.Cedula == Cedula
                                select new tb_transportista_Info() { IdEmpresa = q.IdEmpresa, Nombre = q.Nombre, Cedula = q.Cedula, Estado = q.Estado , IdTransportista = q.IdTransportista, Placa = q.Placa  }).FirstOrDefault();
                    return item;

                }
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }
    }
}
