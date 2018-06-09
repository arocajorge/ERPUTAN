using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Academico;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Academico
{
    public class Aca_Catalogo_Data
    {
        string mensaje = "";
        
        public List<Aca_Catalogo_Info> Get_List_CatalogoXtipo(string IdTipoCatalogo)
        {
            List<Aca_Catalogo_Info> lstCatalogo = new List<Aca_Catalogo_Info>();
            Aca_Catalogo_Info catalogoInfo;
            try {
                Entities_Academico Base = new Entities_Academico();
                var catalogo = from c in Base.Aca_Catalogo
                               where c.IdTipoCatalogo == IdTipoCatalogo
                               select c;

                foreach (var item in catalogo)
                {
                     catalogoInfo = new Aca_Catalogo_Info();
                     catalogoInfo.IdCatalogo = item.IdCatalogo;
                     catalogoInfo.Descripcion = item.Descripcion;
                     catalogoInfo.IdTipoCatalogo = item.IdTipoCatalogo;
                     catalogoInfo.Descripcion2 = "[" + item.IdCatalogo + "] " + item.Descripcion;
                     var vTipoCatalogo = Base.Aca_CatalogoTipo.FirstOrDefault(t => t.IdTipoCatalogo == item.IdTipoCatalogo);
                     catalogoInfo.catalogoTipo_Info.IdTipoCatalogo = item.IdTipoCatalogo;
                     catalogoInfo.catalogoTipo_Info.Descripcion = vTipoCatalogo.Descripcion;

                     catalogoInfo.Orden = item.Orden;
                     catalogoInfo.Estado = item.Estado;
                    lstCatalogo.Add(catalogoInfo);
                }
                return lstCatalogo;
            }
            catch(Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                //saca la exceopción controlada a la proxima capa
                throw new Exception(ex.ToString());
            }
            
        }

        public List<Aca_Catalogo_Info> Get_List_Catalogo()
        {
            //Declaro una variable de tipo lista
            List<Aca_Catalogo_Info> lista = new List<Aca_Catalogo_Info>();
            try
            {
                //Creo un Entitie de conexión del modelo que deseo, en este caso el academico
                Entities_Academico Base = new Entities_Academico();
                //Sentencia del sql realizada a una clase (como realizar un select a una tabla), en este caso la clase Aca_Catalogo
                var q= from C in Base.Aca_Catalogo
                       orderby C.Orden, C.IdCatalogo
                       select C;
                //con este foreach recorro todas las lineas que me vota la anterior sentencia
                foreach (var item in q)
                {
                    //defino la variable por cada vez que recorra el foreach
                    Aca_Catalogo_Info Info = new Aca_Catalogo_Info();
                    //lleno los campos de la tabla
                    Info.IdCatalogo = item.IdCatalogo;
                    Info.IdTipoCatalogo = item.IdTipoCatalogo;
                    Info.Descripcion2 = "[" + item.IdCatalogo + "] " + item.Descripcion;
                    var vTipoCatalogo = Base.Aca_CatalogoTipo.FirstOrDefault(t=>t.IdTipoCatalogo==item.IdTipoCatalogo);
                    Info.catalogoTipo_Info.IdTipoCatalogo=Info.IdTipoCatalogo;
                    Info.catalogoTipo_Info.Descripcion = vTipoCatalogo.Descripcion;

                    Info.Descripcion = item.Descripcion;
                    Info.Estado = item.Estado;
                    Info.Orden = item.Orden;
                    Info.IdUsuario = item.IdUsuario;
                    Info.nom_pc = item.nom_pc;
                    Info.ip = item.ip;
                    Info.IdUsuarioUltMod = item.IdUsuarioUltMod;
                    Info.FechaUltMod = item.FechaUltMod;
                    Info.IdUsuarioUltAnu = item.IdUsuarioUltAnu;
                    Info.Fecha_UltAnu = item.Fecha_UltAnu;
                    Info.MotiAnula = item.MotiAnula;
                    //Añado lo antes ingresado a mi variable tipo lista
                    lista.Add(Info);
                }
                return lista;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                //saca la exceopción controlada a la proxima capa
                throw new Exception(ex.ToString());
            }
        }

        public bool GrabarDB(Aca_Catalogo_Info info,ref string mensaje) {
            try
            {
                using (Entities_Academico Base=new Entities_Academico())
                {
                    Aca_Catalogo addressCatal = new Aca_Catalogo();
                    addressCatal.IdCatalogo = info.IdCatalogo;
                    addressCatal.IdTipoCatalogo = info.IdTipoCatalogo;
                    addressCatal.Descripcion = info.Descripcion;
                    addressCatal.Orden = info.Orden;
                    addressCatal.Estado = info.Estado;
                    addressCatal.FechaUltMod = DateTime.Now;
                    addressCatal.IdUsuarioUltMod = info.IdUsuarioUltMod;
                    Base.Aca_Catalogo.Add(addressCatal);
                    Base.SaveChanges();
                    mensaje = "Se ha procedido a grabar el Catálogo #: " + info.IdCatalogo.ToString() + " exitosamente.";
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
                mensaje = "Error no se grabó ";
                throw new Exception(ex.ToString());
            }
        }

        public bool ActualizarDB(Aca_Catalogo_Info info,ref string mensaje) {
            try
            {
                using (Entities_Academico Base=new Entities_Academico())
                {
                    var vcatalogo = Base.Aca_Catalogo.FirstOrDefault(c=>c.IdCatalogo==info.IdCatalogo);
                    if (vcatalogo != null)
                    {
                        vcatalogo.IdTipoCatalogo = info.IdTipoCatalogo;
                        vcatalogo.Descripcion = info.Descripcion;
                        vcatalogo.Orden = info.Orden;
                        vcatalogo.FechaUltMod = info.FechaUltMod;
                        vcatalogo.IdUsuarioUltMod = info.IdUsuarioUltMod;
                        vcatalogo.Estado = info.Estado;
                        Base.SaveChanges();
                        mensaje = "Se ha procedido actualizar el Catálogo #: " + info.IdTipoCatalogo.ToString() + " exitosamente.";
                    }
                    return true;
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
                mensaje = "Error no se grabó ";
                throw new Exception(ex.ToString());
            }
        }

        public bool AnularDB(Aca_Catalogo_Info info,ref string mensaje) {
            try
            {
                using (Entities_Academico Base=new Entities_Academico())
                {
                    var address = Base.Aca_Catalogo.FirstOrDefault(a => a.IdCatalogo==info.IdCatalogo);
                    if (address != null)
                    {
                        address.Estado = "I";
                        address.Fecha_UltAnu = DateTime.Now;
                        address.IdUsuarioUltAnu = info.IdUsuarioUltAnu;
                        address.MotiAnula = info.MotiAnula;
                        Base.SaveChanges();
                        mensaje = "Se ha procedido anular Catálogo #: " + info.IdCatalogo.ToString() + " exitosamente.";
                    }
                    return true;
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
                mensaje = "Error no se anulo ";
                throw new Exception(ex.ToString());
            }
        }
    }
}
