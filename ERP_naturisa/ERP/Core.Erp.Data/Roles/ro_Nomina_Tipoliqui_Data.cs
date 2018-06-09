using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Info.Roles;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Roles
{
    public class ro_Nomina_Tipoliqui_Data
    {
        string mensaje = "";
        public ro_Nomina_Tipoliqui_Info Get_Info_Nomina_Tipoliqui(int idempresa, int IdNomina_Tipo, int IdNomina_TipoLiqui)
        {
            try
            {
                EntitiesRoles oEnti = new EntitiesRoles();

                ro_Nomina_Tipoliqui_Info info = new ro_Nomina_Tipoliqui_Info();

                var tipo = oEnti.ro_Nomina_Tipoliqui.First(
                    var => var.IdEmpresa == idempresa
                        && var.IdNomina_Tipo == IdNomina_Tipo
                        && var.IdNomina_TipoLiqui == IdNomina_TipoLiqui
                        );

                info.IdEmpresa = tipo.IdEmpresa;
                info.IdNomina_Tipo = tipo.IdNomina_Tipo;
                info.DescripcionProcesoNomina = tipo.DescripcionProcesoNomina;
                info.Estado = tipo.Estado;
                info.FechaTransac = tipo.FechaTransac;
                info.MotivoAnu = tipo.MotivoAnu;

                return info;
            }
            catch (Exception ex)
            {
                string array = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }

        }
        public List<ro_Nomina_Tipoliqui_Info> Get_List_Nomina_Tipoliqui(int idempresa)
        {
            List<ro_Nomina_Tipoliqui_Info> Lista = new List<ro_Nomina_Tipoliqui_Info>();
            try
            {
                
                using (EntitiesRoles oEnti = new EntitiesRoles())
                {
                    var registros = from C in oEnti.ro_Nomina_Tipoliqui
                                    where idempresa == C.IdEmpresa
                                    select C;
                    foreach (var tipo in registros)
                    {
                        ro_Nomina_Tipoliqui_Info info = new ro_Nomina_Tipoliqui_Info();

                        info.IdEmpresa = tipo.IdEmpresa;
                        info.IdNomina_Tipo = tipo.IdNomina_Tipo;
                        info.IdNomina_TipoLiqui = tipo.IdNomina_TipoLiqui;
                        info.DescripcionProcesoNomina = tipo.DescripcionProcesoNomina;
                        info.Estado = tipo.Estado;
                        info.FechaTransac = tipo.FechaTransac;
                        info.IdUsuario = tipo.IdUsuario;
                        info.MotivoAnu = tipo.MotivoAnu;
                        Lista.Add(info);

                    }
                }
                return Lista;
            }
            catch (Exception ex)
            {
                string array = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }

        }


        public List<ro_Nomina_Tipoliqui_Info> Get_List_Nomina_Tipoliqui(int idempresa, int IdNominaTipo)
        {
            List<ro_Nomina_Tipoliqui_Info> Lista = new List<ro_Nomina_Tipoliqui_Info>();
            try
            {

                using (EntitiesRoles oEnti = new EntitiesRoles())
                {
                    var registros = from C in oEnti.ro_Nomina_Tipoliqui
                                    where idempresa == C.IdEmpresa
                                    && C.IdNomina_Tipo == IdNominaTipo
                                    select C;
                    foreach (var tipo in registros)
                    {
                        ro_Nomina_Tipoliqui_Info info = new ro_Nomina_Tipoliqui_Info();

                        info.IdEmpresa = tipo.IdEmpresa;
                        info.IdNomina_Tipo = tipo.IdNomina_Tipo;
                        info.IdNomina_TipoLiqui = tipo.IdNomina_TipoLiqui;
                        info.DescripcionProcesoNomina = tipo.DescripcionProcesoNomina;
                        info.Estado = tipo.Estado;
                        info.FechaTransac = tipo.FechaTransac;
                        info.IdUsuario = tipo.IdUsuario;
                        info.MotivoAnu = tipo.MotivoAnu;
                        Lista.Add(info);

                    }
                }
                return Lista;
            }
            catch (Exception ex)
            {
                string array = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }

        }
      
        public List<ro_Nomina_Tipoliqui_Info> Get_List_Nomina_Tipoliqui_x_Nomina_Tipo(int idempresa, int IdNomina_Tipo)
        {
                List<ro_Nomina_Tipoliqui_Info> lista = new List<ro_Nomina_Tipoliqui_Info>();
                EntitiesRoles oent = new EntitiesRoles();
            try
            {
                var listado = from C in oent.ro_Nomina_Tipoliqui
                              where C.IdEmpresa == idempresa
                              && C.IdNomina_Tipo == IdNomina_Tipo
                              select C;

                foreach (var item in listado)
                {
                    ro_Nomina_Tipoliqui_Info info = new ro_Nomina_Tipoliqui_Info();
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdNomina_Tipo = item.IdNomina_Tipo;
                    info.IdNomina_TipoLiqui = item.IdNomina_TipoLiqui;
                    info.DescripcionProcesoNomina = item.DescripcionProcesoNomina;
                    info.Estado = item.Estado;
                    info.MotivoAnu = item.MotivoAnu;
                    lista.Add(info);
                }

                return lista;
            }
            catch (Exception ex)
            {
                string array = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        
        }
        public Boolean GrabarDB(ro_Nomina_Tipoliqui_Info Info, ref int idtipo, ref  string msg)
        {
            try
            {
                using (EntitiesRoles context = new EntitiesRoles())
                {
                    var address = new ro_Nomina_Tipoliqui();

                    idtipo = getID(Info.IdEmpresa, Info.IdNomina_Tipo, ref msg);
                    address.IdEmpresa = Info.IdEmpresa;
                    address.IdNomina_Tipo = Info.IdNomina_Tipo;
                    address.IdNomina_TipoLiqui = Info.IdNomina_TipoLiqui = idtipo;
                    address.DescripcionProcesoNomina = Info.DescripcionProcesoNomina;
                    address.Estado = "A";
                    address.FechaTransac = Info.FechaTransac;
                    address.IdUsuario = Info.IdUsuario;

                    context.ro_Nomina_Tipoliqui.Add(address);
                    context.SaveChanges();

                    //GUARDA EL DETALLE
                    if (Info.oLstNominaRubroOrden.Count > 0){
                        ro_nomina_tipo_liqui_orden_Data oData = new ro_nomina_tipo_liqui_orden_Data();
                        foreach (ro_nomina_tipo_liqui_orden_Info item in Info.oLstNominaRubroOrden){
                                item.IdEmpresa = address.IdEmpresa;
                                item.IdNominaTipo = address.IdNomina_Tipo;
                                item.IdNominaTipoLiqui = address.IdNomina_TipoLiqui;

                                if (!oData.GrabarDB(item, ref mensaje)) return false;
                        }
                    }

                }
                msg = "Se ha grabado correctamente el registro#" + Info.IdNomina_TipoLiqui;
                return true;
            }
            catch (Exception ex)
            {
                string array = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }


        }
        public Boolean AnularDB(ro_Nomina_Tipoliqui_Info Info, ref  string msg)
        {
            try
            {
                using (EntitiesRoles context = new EntitiesRoles())
                {
                    var contact = context.ro_Nomina_Tipoliqui.First(
                        var => var.IdEmpresa == Info.IdEmpresa
                            && var.IdNomina_Tipo == Info.IdNomina_Tipo
                            && var.IdNomina_TipoLiqui == Info.IdNomina_TipoLiqui
                            );

                    contact.IdUsuarioAnu = Info.IdUsuarioAnu;
                    contact.FechaAnu = Info.FechaAnu;
                    contact.MotivoAnu = Info.MotivoAnu;
                    contact.Estado = "I";
                    contact.DescripcionProcesoNomina = Info.DescripcionProcesoNomina;
                    context.SaveChanges();


                } msg = "Se ha anulado correctamente el registro#" + Info.IdNomina_TipoLiqui ;
                return true;

            }
            catch (Exception ex)
            {
                string array = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }
        public Boolean ModificaDB(ro_Nomina_Tipoliqui_Info Info, ref  string msg)
        {
            try
            {

                using (EntitiesRoles context = new EntitiesRoles())
                {
                    var contact = context.ro_Nomina_Tipoliqui.First(
                        var => var.IdEmpresa == Info.IdEmpresa
                            && var.IdNomina_Tipo == Info.IdNomina_Tipo
                            && var.IdNomina_TipoLiqui == Info.IdNomina_TipoLiqui
                            );
                    contact.IdEmpresa = Info.IdEmpresa;
                    contact.IdNomina_Tipo = Info.IdNomina_Tipo;
                    contact.DescripcionProcesoNomina = Info.DescripcionProcesoNomina;
                    contact.Estado = Info.Estado;
                    contact.FechaUltModi = Info.FechaUltModi;
                    contact.IdUsuarioUltModi = Info.IdUsuarioUltModi;
                    contact.MotivoAnu = "";
                    context.SaveChanges();

                    //GUARDA EL DETALLE
                //   if (Info.oLstNominaRubroOrden.Count > 0) {
                        ro_nomina_tipo_liqui_orden_Data oData = new ro_nomina_tipo_liqui_orden_Data();

                        if(oData.EliminarDB(Info.IdEmpresa,Info.IdNomina_Tipo,Info.IdNomina_TipoLiqui)){
                            foreach (ro_nomina_tipo_liqui_orden_Info item in Info.oLstNominaRubroOrden)
                            {
                                if (!oData.GrabarDB(item, ref mensaje)) return false;                          
                            }
                        }                   
                  //  }



                } msg = "Se ha modificado correctamente el registro#" + Info.IdNomina_Tipo;
                return true;

            }
            catch (Exception ex)
            {
                string array = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }

        }
        public int getID(int idempresa, int IdNomina_Tipo, ref string msg)
        {
            try
            {

                EntitiesRoles oEnt = new EntitiesRoles();

                var select = (from C in oEnt.ro_Nomina_Tipoliqui
                              where C.IdEmpresa == idempresa && C.IdNomina_Tipo == IdNomina_Tipo
                              select C.IdNomina_TipoLiqui);
                if (select.Count() == 0)
                { return 1; }
                else
                {
                    return select.Count() + 1;

                }

            }
            catch (Exception ex)
            {
                string array = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }
    }
}
