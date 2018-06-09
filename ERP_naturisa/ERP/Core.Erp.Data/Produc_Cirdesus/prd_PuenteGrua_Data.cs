using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.Produc_Cirdesus
{
    public   class prd_PuenteGrua_Data
    {
        tb_sis_Log_Error_Vzen_Data oLog = new tb_sis_Log_Error_Vzen_Data();
        string mensaje = "";
        prd_Obra_Data data = new prd_Obra_Data();


        public Boolean GuardarDB(prd_PuenteGrua_Info info, ref string msg)
        {
            try
            {
                using (EntitiesProduccion Context = new EntitiesProduccion())
                {
                    prod_PuenteGrua Address = new prod_PuenteGrua();
                    Address.idEmpresa = info.idEmpresa;
                    Address.Idsucural = info.Idsucural;
                    Address.idPuenteGrua = info.idPuenteGrua;
                    Address.nombre = info.nombre;
                    Address.marca = info.marca;
                    Address.tonelada_Soporta = info.tonelada_Soporta;
                    Address.IdUsuario = info.IdUsuario;
                    Address.ip = info.ip;
                    Address.nom_pc = info.nom_pc;
                    Address.Fecha_Transac=info.Fecha_Transac;
                    Address.estado = info.estado;
                    Address.IdOperador = info.IdOperador;
                    Context.prod_PuenteGrua.Add(Address);
                    Context.SaveChanges();

                }
                msg = "Grabación exitosa..";
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                msg = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref msg);
                throw new Exception(ex.ToString());
            }
        }

        public List<prd_PuenteGrua_Info> ListadoPuenteGrua(int IdEmpresa)
        {
            try
            {
                List<prd_PuenteGrua_Info> L_PuentesGruas = new List<prd_PuenteGrua_Info>();
                EntitiesProduccion OEEtapa = new EntitiesProduccion();
                var registros = from A in OEEtapa.prod_PuenteGrua
                                where A.idEmpresa == IdEmpresa
                                orderby A.idPuenteGrua
                                select A;
                prd_PuenteGrua_Info info = new prd_PuenteGrua_Info();
                foreach (var item in registros)
                {
                    info = new prd_PuenteGrua_Info();
                    info.idEmpresa = item.idEmpresa;
                    info.Idsucural = item.Idsucural;
                    info.idPuenteGrua = item.idPuenteGrua;
                    info.nombre = item.nombre;
                    info.marca = item.marca;
                    info.tonelada_Soporta =Convert.ToInt32( item.tonelada_Soporta);
                    info.IdUsuario = item.IdUsuario;
                    info.IdOperador =Convert.ToInt32( item.IdOperador);
                    info.Fecha_Transac = item.Fecha_Transac;
                    info.IdUsuarioUltMod = item.IdUsuarioUltMod;
                    info.Fecha_UltMod =Convert.ToDateTime( item.Fecha_UltMod);
                    info.IdUsuarioUltAnu = item.IdUsuarioUltAnu;
                    info.Fecha_UltAnu =Convert.ToDateTime( item.Fecha_UltAnu);
                    info.nom_pc = item.nom_pc;
                    info.ip = item.ip;
                    info.MotiAnula = item.MotiAnula;
                    info.estado = item.estado;
                    L_PuentesGruas.Add(info);
                }
                return L_PuentesGruas;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ModificarDB( prd_PuenteGrua_Info info, ref string msg)
        {
            try
            {
                using (EntitiesProduccion context = new EntitiesProduccion())
                {

                    var contact = context.prod_PuenteGrua.FirstOrDefault(A => A.idEmpresa == info.idEmpresa && A.Idsucural == info.Idsucural && A.idPuenteGrua == info.idPuenteGrua);
                    if (contact != null)
                    {
                        //prod_PuenteGrua Address = new prod_PuenteGrua();
                        contact.idEmpresa = info.idEmpresa;
                        contact.Idsucural = info.Idsucural;
                        contact.idPuenteGrua = info.idPuenteGrua;
                        contact.nombre = info.nombre;
                        contact.marca = info.marca;
                        contact.tonelada_Soporta = info.tonelada_Soporta;
                        contact.IdUsuario = info.IdUsuario;
                        contact.ip = info.ip;
                        contact.nom_pc = info.nom_pc;
                        contact.Fecha_Transac = info.Fecha_Transac;
                        contact.estado = info.estado;
                        contact.IdUsuarioUltMod = info.IdUsuario;
                        contact.IdOperador = info.IdOperador;
                        contact.Fecha_UltMod = DateTime.Now;
                        // Context.prod_PuenteGrua.Add(Address);
                        context.SaveChanges();
                    }
                }
                  // msg = "Se ha procedido actualizar el registro de la Orden de Taller #: " + info.Codigo + " exitosamente";
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                msg = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref msg);
                throw new Exception(ex.ToString());
            }
        }
        
        public int GedId(ref string mensaje)
        {
            int Id = 0;

            try
            {

                EntitiesProduccion OEProduccion = new EntitiesProduccion();
                var select = from q in OEProduccion.prod_PuenteGrua
                             select q;

                if (select.ToList().Count < 1)
                {
                    Id = 1;
                }
                else
                {
                    var select_pv = (from q in OEProduccion.prod_PuenteGrua

                                     select q.idPuenteGrua).Max();
                    Id = Convert.ToInt32(select_pv.ToString()) + 1;
                }
                return Id;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }
    }
}
