

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Roles;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.Roles
{
    public  class ro_rubro_tipo_Data
    {
        string mensaje = "";
        public Boolean GuardarDB(ref ro_rubro_tipo_Info Info, ref string msg)
        {  
            List<ro_rubro_tipo_Info> Lst = new List<ro_rubro_tipo_Info>();
            try
            {
                //

                using (EntitiesRoles Context = new EntitiesRoles())
                {
                   // var contact = ro_rubro_tipo.Createro_rubro_tipo("" ,"", "", "", "", "", "", 0, "", "", DateTime.Now, "", "");
                    var Address = new ro_rubro_tipo();

                    Address.IdEmpresa = Info.IdEmpresa;
                    Info.IdRubro = Convert.ToString(getId(Info.IdEmpresa));
                    Info.rub_codigo = (Info.rub_codigo == ""? Info.IdRubro : Info.rub_codigo);                   
                    Address.IdRubro = Info.IdRubro;
                    Address.rub_codigo = Info.rub_codigo;
                    Address.ru_codRolGen = (Info.ru_codRolGen == null) ? Info.rub_codigo : Info.ru_codRolGen;
                    Address.ru_descripcion = Info.ru_descripcion;
                    Address.NombreCorto = Info.NombreCorto;
                    Address.ru_tipo = Info.ru_tipo;
                    Address.ru_estado = Info.ru_estado;
                    Address.ru_orden = Info.ru_orden;
                    Address.ru_EditablexUser = Info.ru_EditablexUser;
                    Address.IdUsuario = Info.IdUsuario;
                    Address.Fecha_Transac = DateTime.Now;
                    Address.nom_pc = Info.nom_pc;
                    Address.ip = Info.ip;
                    
                    Address.rub_concep = Info.rub_concep;
                    Address.rub_tipcal = Info.rub_tipcal;
                    Address.rub_formul = Info.rub_formul;
                    Address.rub_valfij = Convert.ToDecimal(Info.rub_valfij);
                    Address.rub_legal = Info.rub_legal;
                    Address.rub_foract = Info.rub_foract;
                    Address.rub_fornom = Info.rub_fornom;
                    Address.rub_gencon = Info.rub_gencon;
                    Address.rub_antici = Info.rub_antici;
                    Address.rub_ctacon = Info.rub_ctacon;
                    Address.rub_grupo = Info.rub_grupo;
                    Address.rub_liquida = Info.rub_liquida;
                    Address.rub_provision = Info.rub_provision;
                    Address.rub_noafecta = Info.rub_noafecta;
                    Address.rub_acumula = Info.rub_acumula;
                    Address.rub_prorrateo = Info.rub_prorrateo;
                    Address.rub_nocontab = Info.rub_nocontab;
                    Address.rub_utilid = Info.rub_utilid;
                    Address.rub_guarda_rol = Info.rub_guarda_rol;
                    Address.rub_aplica_IESS = Info.rub_aplica_IESS;
                    Address.rub_mustra_liquidacion_cliente = Info.rub_mustra_liquidacion_cliente;
                    Address.rub_AplicaEmpleado_Vac = Convert.ToBoolean(Info.rub_AplicaEmpleado_Vac);
                    Address.ru_aplica_empleado_Subsidio = Convert.ToBoolean(Info.ru_aplica_empleado_Subsidio);
                    Address.rub_Contabiliza_x_empleado = Info.rub_Contabiliza_x_empleado;
                    Address.rub_Acuerdo_Descuento = Info.rub_Acuerdo_Descuento;
                    Context.ro_rubro_tipo.Add(Address);
                    
                    Context.SaveChanges();
                }
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

        public List<ro_rubro_tipo_Info> ConsultaGeneral(int IdEmpresa)
        {  
                List<ro_rubro_tipo_Info> Lst = new List<ro_rubro_tipo_Info>();
            try
            {


                EntitiesRoles oEnti = new EntitiesRoles();
                var Query = from q in oEnti.ro_rubro_tipo
                            where q.IdEmpresa==IdEmpresa 
                            select q;

                foreach (var item in Query)
                {
                    ro_rubro_tipo_Info Obj = new ro_rubro_tipo_Info();
                    Obj.IdEmpresa = item.IdEmpresa;
                    Obj.IdRubro = item.IdRubro;
                    Obj.ru_descripcion = item.ru_descripcion;
                    Obj.NombreCorto = item.NombreCorto;
                    Obj.ru_tipo = item.ru_tipo;
                    Obj.ru_estado = item.ru_estado;
                    Obj.ru_orden = item.ru_orden;
                    Obj.ru_EditablexUser = item.ru_EditablexUser;
                    Obj.IdUsuario = item.IdUsuario;
                    Obj.Fecha_Transac = item.Fecha_Transac;
                    Obj.IdUsuarioUltMod = item.IdUsuarioUltMod;
                    Obj.rub_codigo = item.rub_codigo;

                    Obj.rub_concep = Convert.ToBoolean(item.rub_concep);
                    Obj.rub_tipcal = Convert.ToInt32(item.rub_tipcal);
                    Obj.rub_formul = item.rub_formul;
                    Obj.rub_valfij = Convert.ToInt32(item.rub_valfij);
                    Obj.rub_legal = item.rub_legal;
                    Obj.rub_foract = item.rub_foract;
                    Obj.rub_fornom = item.rub_fornom;
                    Obj.rub_gencon = item.rub_gencon;
                    Obj.rub_antici = Convert.ToBoolean(item.rub_antici);
                    Obj.rub_ctacon = item.rub_ctacon;
                    Obj.rub_grupo = Convert.ToInt32(item.rub_grupo);
                    Obj.rub_liquida = Convert.ToBoolean(item.rub_liquida);
                    Obj.rub_provision = Convert.ToBoolean(item.rub_provision);
                    Obj.rub_noafecta = Convert.ToBoolean(item.rub_noafecta);
                    Obj.rub_acumula = Convert.ToBoolean(item.rub_acumula);
                    Obj.rub_prorrateo = Convert.ToBoolean(item.rub_prorrateo);
                    Obj.rub_nocontab = Convert.ToBoolean(item.rub_nocontab);
                    Obj.rub_utilid = Convert.ToBoolean(item.rub_utilid);
                    Obj.rub_guarda_rol = Convert.ToBoolean(item.rub_guarda_rol);
                    Obj.ru_codRolGen = item.ru_codRolGen;
                    Obj.rub_aplica_IESS = Convert.ToBoolean(item.rub_aplica_IESS);
                    Obj.ru_aplica_empleado_Subsidio = item.ru_aplica_empleado_Subsidio;
                    Obj.rub_AplicaEmpleado_Vac = item.rub_AplicaEmpleado_Vac;
                    Obj.rub_Contabiliza_x_empleado = item.rub_Contabiliza_x_empleado;
                    if (item.rub_mustra_liquidacion_cliente != null)
                        Obj.rub_mustra_liquidacion_cliente = item.rub_mustra_liquidacion_cliente;
                    else
                        Obj.rub_mustra_liquidacion_cliente = false;
                    Obj.rub_Acuerdo_Descuento = item.rub_Acuerdo_Descuento;
                    Lst.Add(Obj);

                }
                return Lst;
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

        public List<ro_rubro_tipo_Info> Get_List_Formulas(int idEmpresa)
        {

            List<ro_rubro_tipo_Info> Lst = new List<ro_rubro_tipo_Info>();
            try
            {


                EntitiesRoles db = new EntitiesRoles();
                var datos = from a in db.ro_rubro_tipo
                            where a.IdEmpresa == idEmpresa

                            select a;

                foreach (var item in datos)
                {
                    ro_rubro_tipo_Info Obj = new ro_rubro_tipo_Info();
                    Obj.IdEmpresa = item.IdEmpresa;
                    Obj.IdRubro = item.IdRubro;
                    Obj.ru_codRolGen = item.ru_codRolGen;
                    Obj.ru_descripcion = item.ru_descripcion;
                    Obj.NombreCorto = item.NombreCorto;
                    Obj.ru_tipo = item.ru_tipo;
                    Obj.ru_estado = item.ru_estado;
                    Obj.ru_orden = item.ru_orden;
                    Obj.ru_EditablexUser = item.ru_EditablexUser;
                    Obj.IdUsuario = item.IdUsuario;
                    Obj.Fecha_Transac = item.Fecha_Transac;
                    Obj.IdUsuarioUltMod = item.IdUsuarioUltMod;
                    Obj.rub_codigo = item.rub_codigo;

                    Obj.rub_concep = Convert.ToBoolean(item.rub_concep);
                    Obj.rub_tipcal = Convert.ToInt32(item.rub_tipcal);
                    Obj.rub_formul = item.rub_formul;
                    Obj.rub_valfij = item.rub_valfij;
                    Obj.rub_legal = item.rub_legal;
                    Obj.rub_foract = item.rub_foract;
                    Obj.rub_fornom = item.rub_fornom;
                    Obj.rub_gencon = item.rub_gencon;
                    Obj.rub_antici = Convert.ToBoolean(item.rub_antici);
                    Obj.rub_ctacon = item.rub_ctacon;
                    Obj.rub_grupo = Convert.ToInt32(item.rub_grupo);
                    Obj.rub_liquida = Convert.ToBoolean(item.rub_liquida);
                    Obj.rub_provision = Convert.ToBoolean(item.rub_provision);
                    Obj.rub_noafecta = Convert.ToBoolean(item.rub_noafecta);
                    Obj.rub_acumula = Convert.ToBoolean(item.rub_acumula);
                    Obj.rub_prorrateo = Convert.ToBoolean(item.rub_prorrateo);
                    Obj.rub_nocontab = Convert.ToBoolean(item.rub_nocontab);
                    Obj.rub_utilid = Convert.ToBoolean(item.rub_utilid);
                    Obj.rub_guarda_rol = Convert.ToBoolean(item.rub_guarda_rol);
                    Obj.rub_aplica_IESS = Convert.ToBoolean(item.rub_aplica_IESS);

                    Obj.rub_AplicaEmpleado_Vac = Convert.ToBoolean(item.rub_AplicaEmpleado_Vac);
                    Obj.ru_aplica_empleado_Subsidio = Convert.ToBoolean(item.ru_aplica_empleado_Subsidio);
                    Obj.rub_Contabiliza_x_empleado = item.rub_Contabiliza_x_empleado;
                    if (item.rub_mustra_liquidacion_cliente != null)
                        Obj.rub_mustra_liquidacion_cliente = item.rub_mustra_liquidacion_cliente;

                    Lst.Add(Obj);

                }
                return Lst;
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



        public List<ro_rubro_tipo_Info> ConsultaGeneralPorEmpresa(int idEmpresa)
        {
            List<ro_rubro_tipo_Info> Lst = new List<ro_rubro_tipo_Info>();
            try
            {


                EntitiesRoles db = new EntitiesRoles();
                var datos = from a in db.ro_rubro_tipo
                           where a.IdEmpresa==idEmpresa
                           && a.rub_provision==true

                            select a;

                foreach (var item in datos)
                {
                    ro_rubro_tipo_Info Obj = new ro_rubro_tipo_Info();
                    Obj.IdEmpresa = item.IdEmpresa;
                    Obj.IdRubro = item.IdRubro;
                    Obj.ru_codRolGen = item.ru_codRolGen;
                    Obj.ru_descripcion = item.ru_descripcion;
                    Obj.NombreCorto = item.NombreCorto;
                    Obj.ru_tipo = item.ru_tipo;
                    Obj.ru_estado = item.ru_estado;
                    Obj.ru_orden = item.ru_orden;
                    Obj.ru_EditablexUser = item.ru_EditablexUser;
                    Obj.IdUsuario = item.IdUsuario;
                    Obj.Fecha_Transac = item.Fecha_Transac;
                    Obj.IdUsuarioUltMod = item.IdUsuarioUltMod;
                    Obj.rub_codigo = item.rub_codigo;

                    Obj.rub_concep = Convert.ToBoolean(item.rub_concep);
                    Obj.rub_tipcal = Convert.ToInt32(item.rub_tipcal);
                    Obj.rub_formul = item.rub_formul;
                    Obj.rub_valfij = item.rub_valfij;
                    Obj.rub_legal = item.rub_legal;
                    Obj.rub_foract = item.rub_foract;
                    Obj.rub_fornom = item.rub_fornom;
                    Obj.rub_gencon = item.rub_gencon;
                    Obj.rub_antici = Convert.ToBoolean(item.rub_antici);
                    Obj.rub_ctacon = item.rub_ctacon;
                    Obj.rub_grupo = Convert.ToInt32(item.rub_grupo);
                    Obj.rub_liquida = Convert.ToBoolean(item.rub_liquida);
                    Obj.rub_provision = Convert.ToBoolean(item.rub_provision);
                    Obj.rub_noafecta = Convert.ToBoolean(item.rub_noafecta);
                    Obj.rub_acumula = Convert.ToBoolean(item.rub_acumula);
                    Obj.rub_prorrateo = Convert.ToBoolean(item.rub_prorrateo);
                    Obj.rub_nocontab = Convert.ToBoolean(item.rub_nocontab);
                    Obj.rub_utilid = Convert.ToBoolean(item.rub_utilid);
                    Obj.rub_guarda_rol = Convert.ToBoolean(item.rub_guarda_rol);
                    Obj.rub_aplica_IESS = Convert.ToBoolean(item.rub_aplica_IESS);

                    Obj.rub_AplicaEmpleado_Vac = Convert.ToBoolean(item.rub_AplicaEmpleado_Vac);
                    Obj.ru_aplica_empleado_Subsidio = Convert.ToBoolean(item.ru_aplica_empleado_Subsidio);
                    Obj.rub_Contabiliza_x_empleado = item.rub_Contabiliza_x_empleado;
                    if (item.rub_mustra_liquidacion_cliente != null)
                        Obj.rub_mustra_liquidacion_cliente = item.rub_mustra_liquidacion_cliente;

                    Lst.Add(Obj);

                }
                return Lst;
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


        public List<ro_rubro_tipo_Info> Get_lista_rubros_x_nomina_tipo_liq(int idEmpresa, int IdNominaTipo, int IdNominaTipoLiqui)
        {
            List<ro_rubro_tipo_Info> Lst = new List<ro_rubro_tipo_Info>();
            try
            {


                EntitiesRoles db = new EntitiesRoles();
                var datos = from a in db.ro_rubro_tipo
                           
                            join f in db.ro_nomina_tipo_liqui_orden
                            on a.IdRubro equals f.IdRubro
                            where a.IdEmpresa == idEmpresa
                            && f.IdEmpresa == a.IdEmpresa
                            && f.IdRubro == a.IdRubro
                            && f.IdNominaTipo == IdNominaTipo
                            && f.IdNominaTipoLiqui == IdNominaTipoLiqui
                            select a;

                foreach (var item in datos)
                {
                    ro_rubro_tipo_Info Obj = new ro_rubro_tipo_Info();
                    Obj.IdEmpresa = item.IdEmpresa;
                    Obj.IdRubro = item.IdRubro;
                    Obj.ru_codRolGen = item.ru_codRolGen;
                    Obj.ru_descripcion = item.ru_descripcion;
                    Obj.NombreCorto = item.NombreCorto;
                    Obj.ru_tipo = item.ru_tipo;
                    Obj.ru_estado = item.ru_estado;
                    Obj.ru_orden = item.ru_orden;
                    Obj.ru_EditablexUser = item.ru_EditablexUser;
                    Obj.IdUsuario = item.IdUsuario;
                    Obj.Fecha_Transac = item.Fecha_Transac;
                    Obj.IdUsuarioUltMod = item.IdUsuarioUltMod;
                    Obj.rub_codigo = item.rub_codigo;

                    Obj.rub_concep = Convert.ToBoolean(item.rub_concep);
                    Obj.rub_tipcal = Convert.ToInt32(item.rub_tipcal);
                    Obj.rub_formul = item.rub_formul;
                    Obj.rub_valfij = item.rub_valfij;
                    Obj.rub_legal = item.rub_legal;
                    Obj.rub_foract = item.rub_foract;
                    Obj.rub_fornom = item.rub_fornom;
                    Obj.rub_gencon = item.rub_gencon;
                    Obj.rub_antici = Convert.ToBoolean(item.rub_antici);
                    Obj.rub_ctacon = item.rub_ctacon;
                    Obj.rub_grupo = Convert.ToInt32(item.rub_grupo);
                    Obj.rub_liquida = Convert.ToBoolean(item.rub_liquida);
                    Obj.rub_provision = Convert.ToBoolean(item.rub_provision);
                    Obj.rub_noafecta = Convert.ToBoolean(item.rub_noafecta);
                    Obj.rub_acumula = Convert.ToBoolean(item.rub_acumula);
                    Obj.rub_prorrateo = Convert.ToBoolean(item.rub_prorrateo);
                    Obj.rub_nocontab = Convert.ToBoolean(item.rub_nocontab);
                    Obj.rub_utilid = Convert.ToBoolean(item.rub_utilid);
                    Obj.rub_guarda_rol = Convert.ToBoolean(item.rub_guarda_rol);
                    Obj.rub_aplica_IESS = Convert.ToBoolean(item.rub_aplica_IESS);

                    Obj.rub_AplicaEmpleado_Vac = Convert.ToBoolean(item.rub_AplicaEmpleado_Vac);
                    Obj.ru_aplica_empleado_Subsidio = Convert.ToBoolean(item.ru_aplica_empleado_Subsidio);
                    Obj.rub_Contabiliza_x_empleado = item.rub_Contabiliza_x_empleado;


                    Lst.Add(Obj);

                }
                return Lst;
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

        public List<ro_rubro_tipo_Info> ConsultaRubrosPrestamo(int IdEmpresa)
        {
                List<ro_rubro_tipo_Info> Lst = new List<ro_rubro_tipo_Info>();
            try
            {


                EntitiesRoles oEnti = new EntitiesRoles();
                var Query = from q in oEnti.vwRo_Config_rubros_x_Prestamo
                            where q.IdEmpresa == IdEmpresa 
                            select q;

                foreach (var item in Query)
                {
                    ro_rubro_tipo_Info Obj = new ro_rubro_tipo_Info();
                    Obj.IdEmpresa = IdEmpresa;
                    Obj.IdRubro_prest= item.IdRubro_prest;
                    Obj.ru_descripcion_prest = item.ru_descripcion_prest;
                    Obj.ru_tipo_prest= item.ru_tipo_prest;
                    Obj.ru_estado_prest = item.ru_estado_prest;

                    Lst.Add(Obj);

                }
                return Lst;
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

        public List<ro_rubro_tipo_Info> ConsultaEspecifica(string IdRubro)
        {
            List<ro_rubro_tipo_Info> Lst = new List<ro_rubro_tipo_Info>();
            try
            {

                EntitiesRoles oEnti = new EntitiesRoles();
                var Query = from q in oEnti.ro_rubro_tipo
                            where q.IdRubro==IdRubro
                            select q;

                foreach (var item in Query)
                {
                    ro_rubro_tipo_Info Obj = new ro_rubro_tipo_Info();
                    Obj.IdEmpresa = item.IdEmpresa;
                    Obj.IdRubro = item.IdRubro;
                    Obj.ru_descripcion = item.ru_descripcion;
                    Obj.NombreCorto = item.NombreCorto;
                    Obj.ru_tipo = item.ru_tipo;
                    Obj.ru_estado = item.ru_estado;
                    Obj.ru_orden = item.ru_orden;
                    Obj.ru_EditablexUser = item.ru_EditablexUser;
                    Obj.IdUsuario = item.IdUsuario;
                    Obj.Fecha_Transac = item.Fecha_Transac;
                    Obj.IdUsuarioUltMod = item.IdUsuarioUltMod;
                    Obj.rub_codigo = item.rub_codigo;

                    Obj.rub_concep = Convert.ToBoolean(item.rub_concep);
                    Obj.rub_tipcal = Convert.ToInt32(item.rub_tipcal);
                    Obj.rub_formul = item.rub_formul;
                    Obj.rub_valfij = Convert.ToInt32(item.rub_valfij);
                    Obj.rub_legal = item.rub_legal;
                    Obj.rub_foract = item.rub_foract;
                    Obj.rub_fornom = item.rub_fornom;
                    Obj.rub_gencon = item.rub_gencon;
                    Obj.rub_antici = Convert.ToBoolean(item.rub_antici);
                    Obj.rub_ctacon = item.rub_ctacon;
                    Obj.rub_grupo = Convert.ToInt32(item.rub_grupo);
                    Obj.rub_liquida = Convert.ToBoolean(item.rub_liquida);
                    Obj.rub_provision = Convert.ToBoolean(item.rub_provision);
                    Obj.rub_noafecta = Convert.ToBoolean(item.rub_noafecta);
                    Obj.rub_acumula = Convert.ToBoolean(item.rub_acumula);
                    Obj.rub_prorrateo = Convert.ToBoolean(item.rub_prorrateo);
                    Obj.rub_nocontab = Convert.ToBoolean(item.rub_nocontab);
                    Obj.rub_utilid = Convert.ToBoolean(item.rub_utilid);
                    Obj.rub_guarda_rol = Convert.ToBoolean(item.rub_guarda_rol);
                    Obj.rub_aplica_IESS = Convert.ToBoolean(item.rub_aplica_IESS);
                    Obj.rub_Contabiliza_x_empleado = item.rub_Contabiliza_x_empleado;

                    Lst.Add(Obj);
                }
                return Lst;
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

        public ro_rubro_tipo_Info GetInfoConsultaPorId(int IdEmpresa, string IdRubro)
        {
            EntitiesRoles oEnti = new EntitiesRoles();
             ro_rubro_tipo_Info Info = new ro_rubro_tipo_Info();
            try
            {

                var item = oEnti.ro_rubro_tipo.First(var => var.IdRubro == IdRubro && var.IdEmpresa==IdEmpresa);
                   Info.IdEmpresa = item.IdEmpresa;
                    Info.ru_descripcion = item.ru_descripcion;
                    Info.NombreCorto = item.NombreCorto;
                    Info.ru_tipo = item.ru_tipo;
                    Info.ru_estado = item.ru_estado;
                    Info.ru_orden = item.ru_orden;
                    Info.rub_codigo = item.rub_codigo;
                    Info.ru_codRolGen = item.ru_codRolGen;

                    Info.rub_concep = Convert.ToBoolean(item.rub_concep);
                    Info.rub_tipcal = Convert.ToInt32(item.rub_tipcal);
                    Info.rub_formul = item.rub_formul;
                    Info.rub_valfij = item.rub_valfij;
                    Info.rub_legal = item.rub_legal;
                    Info.rub_foract = item.rub_foract;
                    Info.rub_fornom = item.rub_fornom;
                    Info.rub_gencon = item.rub_gencon;
                    Info.rub_antici = Convert.ToBoolean(item.rub_antici);
                    Info.rub_ctacon = item.rub_ctacon;
                    Info.rub_grupo = Convert.ToInt32(item.rub_grupo);
                    Info.rub_liquida = Convert.ToBoolean(item.rub_liquida);
                    Info.rub_provision = Convert.ToBoolean(item.rub_provision);
                    Info.rub_noafecta = Convert.ToBoolean(item.rub_noafecta);
                    Info.rub_acumula = Convert.ToBoolean(item.rub_acumula);
                    Info.rub_prorrateo = Convert.ToBoolean(item.rub_prorrateo);
                    Info.rub_nocontab = Convert.ToBoolean(item.rub_nocontab);
                    Info.rub_utilid = Convert.ToBoolean(item.rub_utilid);
                    Info.rub_guarda_rol = Convert.ToBoolean(item.rub_guarda_rol);
                    Info.rub_aplica_IESS = Convert.ToBoolean(item.rub_aplica_IESS);
                    Info.rub_Contabiliza_x_empleado = item.rub_Contabiliza_x_empleado;

                return Info;
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


        public ro_rubro_tipo_Info GetInfoConsultaPorCodigoRol(int IdEmpresa, string id)
        {
            EntitiesRoles oEnti = new EntitiesRoles();
            ro_rubro_tipo_Info Info = new ro_rubro_tipo_Info();
            try
            {

                var Objeto = oEnti.ro_rubro_tipo.First(var => var.ru_codRolGen.Trim() == id.Trim() && var.IdEmpresa == IdEmpresa);
                Info.IdEmpresa = Objeto.IdEmpresa;

                Info.IdRubro = Objeto.IdRubro;
                Info.ru_descripcion = Objeto.ru_descripcion;
                Info.NombreCorto = Objeto.NombreCorto;
                Info.ru_tipo = Objeto.ru_tipo;
                Info.ru_estado = Objeto.ru_estado;
                Info.ru_orden = Objeto.ru_orden;
                Info.rub_codigo = Objeto.rub_codigo;

                Info.rub_concep = Convert.ToBoolean(Objeto.rub_concep);
                Info.rub_tipcal = Convert.ToInt32(Objeto.rub_tipcal);
                Info.rub_formul = Objeto.rub_formul;
                Info.rub_valfij = Convert.ToInt32(Objeto.rub_valfij);
                Info.rub_legal = Objeto.rub_legal;
                Info.rub_foract = Objeto.rub_foract;
                Info.rub_fornom = Objeto.rub_fornom;
                Info.rub_gencon = Objeto.rub_gencon;
                Info.rub_antici = Convert.ToBoolean(Objeto.rub_antici);
                Info.rub_ctacon = Objeto.rub_ctacon;
                Info.rub_grupo = Convert.ToInt32(Objeto.rub_grupo);
                Info.rub_liquida = Convert.ToBoolean(Objeto.rub_liquida);
                Info.rub_provision = Convert.ToBoolean(Objeto.rub_provision);
                Info.rub_noafecta = Convert.ToBoolean(Objeto.rub_noafecta);
                Info.rub_acumula = Convert.ToBoolean(Objeto.rub_acumula);
                Info.rub_prorrateo = Convert.ToBoolean(Objeto.rub_prorrateo);
                Info.rub_nocontab = Convert.ToBoolean(Objeto.rub_nocontab);
                Info.rub_utilid = Convert.ToBoolean(Objeto.rub_utilid);
                Info.rub_guarda_rol = Convert.ToBoolean(Objeto.rub_guarda_rol);
                Info.rub_aplica_IESS = Convert.ToBoolean(Objeto.rub_aplica_IESS);
                Info.rub_Contabiliza_x_empleado = Objeto.rub_Contabiliza_x_empleado;


                return Info;
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



        public Boolean ModificarDB(ro_rubro_tipo_Info info)
        {
            try
            {
                using (EntitiesRoles context = new EntitiesRoles())
                {

                    var contact = context.ro_rubro_tipo.First(minfo => minfo.IdRubro == info.IdRubro && minfo.IdEmpresa==info.IdEmpresa);
                    contact.IdEmpresa = info.IdEmpresa;
                    contact.ru_descripcion = info.ru_descripcion;
                    contact.NombreCorto = info.NombreCorto;
                    contact.ru_estado = info.ru_estado;
                    contact.ru_tipo = (info.ru_tipo == null) ? "I" : info.ru_tipo;
                    contact.ru_orden = info.ru_orden;
                    contact.ru_EditablexUser = info.ru_EditablexUser;
                    contact.IdUsuarioUltMod = info.IdUsuarioUltMod;
                    contact.Fecha_UltMod = info.Fecha_UltMod;
                    contact.rub_codigo = info.rub_codigo;
                    contact.ru_codRolGen = info.ru_codRolGen;

                    contact.rub_concep = info.rub_concep;
                    contact.rub_tipcal = info.rub_tipcal;
                    contact.rub_formul = info.rub_formul;
                    contact.rub_valfij = Convert.ToDecimal(info.rub_valfij);
                    contact.rub_legal = info.rub_legal;
                    contact.rub_foract = info.rub_foract;
                    contact.rub_fornom = info.rub_fornom;
                    contact.rub_gencon = info.rub_gencon;
                    contact.rub_antici = info.rub_antici;
                    contact.rub_ctacon = info.rub_ctacon;
                    contact.rub_grupo = info.rub_grupo;
                    contact.rub_liquida = info.rub_liquida;
                    contact.rub_provision = info.rub_provision;
                    contact.rub_noafecta = info.rub_noafecta;
                    contact.rub_acumula = info.rub_acumula;
                    contact.rub_prorrateo = info.rub_prorrateo;
                    contact.rub_nocontab = info.rub_nocontab;
                    contact.rub_utilid = info.rub_utilid;
                    contact.rub_utilid = info.rub_utilid;
                    contact.rub_guarda_rol = info.rub_guarda_rol;
                    contact.rub_aplica_IESS = info.rub_aplica_IESS;


                    contact.rub_AplicaEmpleado_Vac = Convert.ToBoolean(info.rub_AplicaEmpleado_Vac);
                    contact.ru_aplica_empleado_Subsidio = Convert.ToBoolean(info.ru_aplica_empleado_Subsidio);
                    contact.rub_Contabiliza_x_empleado = info.rub_Contabiliza_x_empleado;
                    contact.rub_Acuerdo_Descuento = info.rub_Acuerdo_Descuento;
                    context.SaveChanges();


                }
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

        public Boolean AnularDB(ro_rubro_tipo_Info info)
        {
            try
            {
                using (EntitiesRoles context = new EntitiesRoles())
                {

                    var contact = context.ro_rubro_tipo.First(minfo => minfo.IdRubro == info.IdRubro && minfo.IdEmpresa==info.IdEmpresa);
                    contact.ru_estado = "I";
                    contact.Fecha_UltAnu = info.Fecha_UltAnu;
                    contact.IdUsuarioUltAnu = info.IdUsuarioUltAnu;
                    context.SaveChanges();

                }
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

        public Boolean VericarCodigoExiste(int IdEmpresa, string codigo, ref string mensaje)
        {

            try
            {
                Boolean Existe;

                string scodigo;

                scodigo = codigo.Trim();
                mensaje = "";
                Existe = false;


                EntitiesRoles B = new EntitiesRoles();

                var select_ = from t in B.ro_rubro_tipo
                              where t.IdRubro == scodigo
                              && t.IdEmpresa == IdEmpresa
                              select t;

                foreach (var item in select_)
                {

                    mensaje = mensaje + " " + item.ru_descripcion;
                    Existe = true;
                }

                return Existe;
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

        public int getId(int IdEmpresa)
        {
            try
            {
                int Id;
                EntitiesRoles OEEmpleado = new EntitiesRoles();
                var select = from q in OEEmpleado.vwro_rubro_tipo
                             where q.IdEmpresa==IdEmpresa
                             select q;

                if (select.ToList().Count() == 0)
                {
                    Id = 1;
                }
                else
                {
                    var select_em = (from q in OEEmpleado.vwro_rubro_tipo
                                     where q.IdEmpresa == IdEmpresa
                                     select q.IdRubro).Max();
                   
                    Id = Convert.ToInt32(select_em)+1;
                }
                return Id;
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

        public List<ro_rubro_tipo_Info> ConsultaIngreso( int IdEmpres)
        {           
            List<ro_rubro_tipo_Info> Lst = new List<ro_rubro_tipo_Info>();
            try{

                EntitiesRoles oEnti = new EntitiesRoles();
                var Query = from q in oEnti.ro_rubro_tipo
                            where q.ru_tipo == "I" && q.ru_estado == "A" 
                            && q.IdEmpresa==IdEmpres
                            select q;

                foreach (var item in Query)
                {
                    ro_rubro_tipo_Info Obj = new ro_rubro_tipo_Info();
                    Obj.IdRubro = item.IdRubro;
                    Obj.ru_descripcion = (item.ru_descripcion).Trim();
                    Obj.NombreCorto = item.NombreCorto;
                    Obj.ru_tipo = item.ru_tipo;
                    Obj.ru_estado = item.ru_estado;
                    Obj.ru_orden = item.ru_orden;
                    Obj.ru_EditablexUser = item.ru_EditablexUser;
                    Obj.IdUsuario = item.IdUsuario;
                    Obj.Fecha_Transac = item.Fecha_Transac;
                    Obj.IdUsuarioUltMod = item.IdUsuarioUltMod;
                    Obj.rub_codigo = item.rub_codigo;

                    Obj.rub_concep = Convert.ToBoolean(item.rub_concep);
                    Obj.rub_tipcal = Convert.ToInt32(item.rub_tipcal);
                    Obj.rub_formul = item.rub_formul;
                    Obj.rub_valfij = Convert.ToInt32(item.rub_valfij);
                    Obj.rub_legal = item.rub_legal;
                    Obj.rub_foract = item.rub_foract;
                    Obj.rub_fornom = item.rub_fornom;
                    Obj.rub_gencon = item.rub_gencon;
                    Obj.rub_antici = Convert.ToBoolean(item.rub_antici);
                    Obj.rub_ctacon = item.rub_ctacon;
                    Obj.rub_grupo = Convert.ToInt32(item.rub_grupo);
                    Obj.rub_liquida = Convert.ToBoolean(item.rub_liquida);
                    Obj.rub_provision = Convert.ToBoolean(item.rub_provision);
                    Obj.rub_noafecta = Convert.ToBoolean(item.rub_noafecta);
                    Obj.rub_acumula = Convert.ToBoolean(item.rub_acumula);
                    Obj.rub_prorrateo = Convert.ToBoolean(item.rub_prorrateo);
                    Obj.rub_nocontab = Convert.ToBoolean(item.rub_nocontab);
                    Obj.rub_utilid = Convert.ToBoolean(item.rub_utilid);
                    Obj.rub_guarda_rol = Convert.ToBoolean(item.rub_guarda_rol);
                    Obj.rub_aplica_IESS = Convert.ToBoolean(item.rub_aplica_IESS);
                    Obj.rub_Contabiliza_x_empleado = item.rub_Contabiliza_x_empleado;
                    Lst.Add(Obj);

                }
                return Lst;
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

        public List<ro_rubro_tipo_Info> ConsultaEgreso(int IdEmpresa)
        {
                List<ro_rubro_tipo_Info> Lst = new List<ro_rubro_tipo_Info>();
            try
            {

                EntitiesRoles oEnti = new EntitiesRoles();
                var Query = from q in oEnti.ro_rubro_tipo
                            where q.ru_tipo == "E" && q.ru_estado == "A"
                                                        && q.IdEmpresa == IdEmpresa

                            select q;

                foreach (var item in Query)
                {
                    ro_rubro_tipo_Info Obj = new ro_rubro_tipo_Info();
                    Obj.IdRubro = item.IdRubro;//
                    Obj.ru_descripcion = (item.ru_descripcion).Trim();
                    Obj.NombreCorto = item.NombreCorto;
                    Obj.ru_tipo = item.ru_tipo;
                    Obj.ru_estado = item.ru_estado;
                    Obj.ru_orden = item.ru_orden;
                    Obj.ru_EditablexUser = item.ru_EditablexUser;
                    Obj.IdUsuario = item.IdUsuario;
                    Obj.Fecha_Transac = item.Fecha_Transac;
                    Obj.IdUsuarioUltMod = item.IdUsuarioUltMod;
                    Obj.rub_codigo = item.rub_codigo;

                    Obj.rub_concep = Convert.ToBoolean(item.rub_concep);
                    Obj.rub_tipcal = Convert.ToInt32(item.rub_tipcal);
                    Obj.rub_formul = item.rub_formul;
                    Obj.rub_valfij = Convert.ToInt32(item.rub_valfij);
                    Obj.rub_legal = item.rub_legal;
                    Obj.rub_foract = item.rub_foract;
                    Obj.rub_fornom = item.rub_fornom;
                    Obj.rub_gencon = item.rub_gencon;
                    Obj.rub_antici = Convert.ToBoolean(item.rub_antici);
                    Obj.rub_ctacon = item.rub_ctacon;
                    Obj.rub_grupo = Convert.ToInt32(item.rub_grupo);
                    Obj.rub_liquida = Convert.ToBoolean(item.rub_liquida);
                    Obj.rub_provision = Convert.ToBoolean(item.rub_provision);
                    Obj.rub_noafecta = Convert.ToBoolean(item.rub_noafecta);
                    Obj.rub_acumula = Convert.ToBoolean(item.rub_acumula);
                    Obj.rub_prorrateo = Convert.ToBoolean(item.rub_prorrateo);
                    Obj.rub_nocontab = Convert.ToBoolean(item.rub_nocontab);
                    Obj.rub_utilid = Convert.ToBoolean(item.rub_utilid);
                    Obj.rub_guarda_rol = Convert.ToBoolean(item.rub_guarda_rol);
                    Obj.rub_aplica_IESS = Convert.ToBoolean(item.rub_aplica_IESS);
                    Obj.rub_Contabiliza_x_empleado = item.rub_Contabiliza_x_empleado;

                    Lst.Add(Obj);

                }
                return Lst;
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


        public List<ro_rubro_tipo_Info> Get_List_Rubros_Acumulados(int idEmpresa)
        {
            List<ro_rubro_tipo_Info> Lst = new List<ro_rubro_tipo_Info>();
            try
            {


                EntitiesRoles db = new EntitiesRoles();
                var datos = from a in db.ro_rubro_tipo
                           
                            where a.IdEmpresa == idEmpresa
                            && a.rub_provision==true
                            && a.IdRubro != "982"
                            && a.IdRubro != "983"
                            && a.IdRubro != "493"
                            select a;

                foreach (var item in datos)
                {
                    ro_rubro_tipo_Info Obj = new ro_rubro_tipo_Info();
                    Obj.IdRubro = item.IdRubro;
                    Obj.ru_codRolGen = item.ru_codRolGen;
                    Obj.ru_descripcion = item.ru_descripcion;
                    Obj.NombreCorto = item.NombreCorto;
                    Obj.ru_tipo = item.ru_tipo;
                    Obj.ru_estado = item.ru_estado;
                    Obj.ru_orden = item.ru_orden;
                    Obj.ru_EditablexUser = item.ru_EditablexUser;
                    Obj.IdUsuario = item.IdUsuario;
                    Obj.Fecha_Transac = item.Fecha_Transac;
                    Obj.IdUsuarioUltMod = item.IdUsuarioUltMod;
                    Obj.rub_codigo = item.rub_codigo;

                    Obj.rub_concep = Convert.ToBoolean(item.rub_concep);
                    Obj.rub_tipcal = Convert.ToInt32(item.rub_tipcal);
                    Obj.rub_formul = item.rub_formul;
                    Obj.rub_valfij = item.rub_valfij;
                    Obj.rub_legal = item.rub_legal;
                    Obj.rub_foract = item.rub_foract;
                    Obj.rub_fornom = item.rub_fornom;
                    Obj.rub_gencon = item.rub_gencon;
                    Obj.rub_antici = Convert.ToBoolean(item.rub_antici);
                    Obj.rub_ctacon = item.rub_ctacon;
                    Obj.rub_grupo = Convert.ToInt32(item.rub_grupo);
                    Obj.rub_liquida = Convert.ToBoolean(item.rub_liquida);
                    Obj.rub_provision = Convert.ToBoolean(item.rub_provision);
                    Obj.rub_noafecta = Convert.ToBoolean(item.rub_noafecta);
                    Obj.rub_acumula = Convert.ToBoolean(item.rub_acumula);
                    Obj.rub_prorrateo = Convert.ToBoolean(item.rub_prorrateo);
                    Obj.rub_nocontab = Convert.ToBoolean(item.rub_nocontab);
                    Obj.rub_utilid = Convert.ToBoolean(item.rub_utilid);
                    Obj.rub_guarda_rol = Convert.ToBoolean(item.rub_guarda_rol);
                    Obj.rub_aplica_IESS = Convert.ToBoolean(item.rub_aplica_IESS);

                    Obj.rub_AplicaEmpleado_Vac = Convert.ToBoolean(item.rub_AplicaEmpleado_Vac);
                    Obj.ru_aplica_empleado_Subsidio = Convert.ToBoolean(item.ru_aplica_empleado_Subsidio);
                    Obj.rub_Contabiliza_x_empleado = item.rub_Contabiliza_x_empleado;


                    Lst.Add(Obj);

                }
                return Lst;
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



        public List<ro_rubro_tipo_Info> Get_List_rubros_Ing_Egr(int idEmpresa,string ingr,string egr)
        {
            List<ro_rubro_tipo_Info> Lst = new List<ro_rubro_tipo_Info>();
            try
            {


                EntitiesRoles db = new EntitiesRoles();
                var datos = from a in db.ro_rubro_tipo
                            
                            where a.IdEmpresa == idEmpresa
                            && (a.ru_tipo == ingr || a.ru_tipo == egr || a.rub_guarda_rol == true)
                            
                            select a;

                foreach (var item in datos)
                {
                    ro_rubro_tipo_Info Obj = new ro_rubro_tipo_Info();
                    Obj.IdRubro = item.IdRubro;
                    Obj.ru_codRolGen = item.ru_codRolGen;
                    Obj.ru_descripcion = item.ru_descripcion;
                    Obj.NombreCorto = item.NombreCorto;
                    Obj.ru_tipo = item.ru_tipo;
                    Obj.ru_estado = item.ru_estado;
                    Obj.ru_orden = item.ru_orden;
                    Obj.ru_EditablexUser = item.ru_EditablexUser;
                    Obj.IdUsuario = item.IdUsuario;
                    Obj.Fecha_Transac = item.Fecha_Transac;
                    Obj.IdUsuarioUltMod = item.IdUsuarioUltMod;
                    Obj.rub_codigo = item.rub_codigo;

                    Obj.rub_concep = Convert.ToBoolean(item.rub_concep);
                    Obj.rub_tipcal = Convert.ToInt32(item.rub_tipcal);
                    Obj.rub_formul = item.rub_formul;
                    Obj.rub_valfij = item.rub_valfij;
                    Obj.rub_legal = item.rub_legal;
                    Obj.rub_foract = item.rub_foract;
                    Obj.rub_fornom = item.rub_fornom;
                    Obj.rub_gencon = item.rub_gencon;
                    Obj.rub_antici = Convert.ToBoolean(item.rub_antici);
                    Obj.rub_ctacon = item.rub_ctacon;
                    Obj.rub_grupo = Convert.ToInt32(item.rub_grupo);
                    Obj.rub_liquida = Convert.ToBoolean(item.rub_liquida);
                    Obj.rub_provision = Convert.ToBoolean(item.rub_provision);
                    Obj.rub_noafecta = Convert.ToBoolean(item.rub_noafecta);
                    Obj.rub_acumula = Convert.ToBoolean(item.rub_acumula);
                    Obj.rub_prorrateo = Convert.ToBoolean(item.rub_prorrateo);
                    Obj.rub_nocontab = Convert.ToBoolean(item.rub_nocontab);
                    Obj.rub_utilid = Convert.ToBoolean(item.rub_utilid);
                    Obj.rub_guarda_rol = Convert.ToBoolean(item.rub_guarda_rol);
                    Obj.rub_aplica_IESS = Convert.ToBoolean(item.rub_aplica_IESS);
                     
                    Obj.rub_AplicaEmpleado_Vac = Convert.ToBoolean(item.rub_AplicaEmpleado_Vac);
                    Obj.ru_aplica_empleado_Subsidio = Convert.ToBoolean(item.ru_aplica_empleado_Subsidio);
                    Obj.rub_Contabiliza_x_empleado = item.rub_Contabiliza_x_empleado;
                    Obj.rub_Contabiliza_x_empleado = item.rub_Contabiliza_x_empleado;
                    Lst.Add(Obj);

                }
                return Lst;
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

        public List<ro_rubro_tipo_Info> Get_List_Rubros_Horas_Extras(int idEmpresa)
        {
            List<ro_rubro_tipo_Info> Lst = new List<ro_rubro_tipo_Info>();
            try
            {


                EntitiesRoles db = new EntitiesRoles();
                var datos = from a in db.ro_rubro_tipo
                            
                            where a.IdEmpresa == idEmpresa
                            &&
                            ( a.IdRubro == "7"
                            || a.IdRubro == "8"
                            || a.IdRubro == "9"
                            )
                            select a;

                foreach (var item in datos)
                {
                    ro_rubro_tipo_Info Obj = new ro_rubro_tipo_Info();
                    Obj.IdRubro = item.IdRubro;
                    Obj.ru_codRolGen = item.ru_codRolGen;
                    Obj.ru_descripcion = item.ru_descripcion;
                    Obj.NombreCorto = item.NombreCorto;
                    Obj.ru_tipo = item.ru_tipo;
                    Obj.ru_estado = item.ru_estado;
                    Obj.ru_orden = item.ru_orden;
                    Obj.ru_EditablexUser = item.ru_EditablexUser;
                    Obj.IdUsuario = item.IdUsuario;
                    Obj.Fecha_Transac = item.Fecha_Transac;
                    Obj.IdUsuarioUltMod = item.IdUsuarioUltMod;
                    Obj.rub_codigo = item.rub_codigo;

                    Obj.rub_concep = Convert.ToBoolean(item.rub_concep);
                    Obj.rub_tipcal = Convert.ToInt32(item.rub_tipcal);
                    Obj.rub_formul = item.rub_formul;
                    Obj.rub_valfij = item.rub_valfij;
                    Obj.rub_legal = item.rub_legal;
                    Obj.rub_foract = item.rub_foract;
                    Obj.rub_fornom = item.rub_fornom;
                    Obj.rub_gencon = item.rub_gencon;
                    Obj.rub_antici = Convert.ToBoolean(item.rub_antici);
                    Obj.rub_ctacon = item.rub_ctacon;
                    Obj.rub_grupo = Convert.ToInt32(item.rub_grupo);
                    Obj.rub_liquida = Convert.ToBoolean(item.rub_liquida);
                    Obj.rub_provision = Convert.ToBoolean(item.rub_provision);
                    Obj.rub_noafecta = Convert.ToBoolean(item.rub_noafecta);
                    Obj.rub_acumula = Convert.ToBoolean(item.rub_acumula);
                    Obj.rub_prorrateo = Convert.ToBoolean(item.rub_prorrateo);
                    Obj.rub_nocontab = Convert.ToBoolean(item.rub_nocontab);
                    Obj.rub_utilid = Convert.ToBoolean(item.rub_utilid);
                    Obj.rub_guarda_rol = Convert.ToBoolean(item.rub_guarda_rol);
                    Obj.rub_aplica_IESS = Convert.ToBoolean(item.rub_aplica_IESS);

                    Obj.rub_AplicaEmpleado_Vac = Convert.ToBoolean(item.rub_AplicaEmpleado_Vac);
                    Obj.ru_aplica_empleado_Subsidio = Convert.ToBoolean(item.ru_aplica_empleado_Subsidio);
                    Obj.rub_Contabiliza_x_empleado = item.rub_Contabiliza_x_empleado;


                    Lst.Add(Obj);

                }
                return Lst;
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



        public List<ro_rubro_tipo_Info> Get_list_rubros_concepto(int idEmpresa)
        {
            List<ro_rubro_tipo_Info> Lst = new List<ro_rubro_tipo_Info>();
            try
            {


                EntitiesRoles db = new EntitiesRoles();
                var datos = from a in db.ro_rubro_tipo
                           
                            where a.IdEmpresa == idEmpresa
                            && a.rub_concep==true
                            select a;

                foreach (var item in datos)
                {
                    ro_rubro_tipo_Info Obj = new ro_rubro_tipo_Info();
                    Obj.IdRubro = item.IdRubro;
                    Obj.ru_codRolGen = item.ru_codRolGen;
                    Obj.ru_descripcion = item.ru_descripcion;
                    Obj.NombreCorto = item.NombreCorto;
                    Obj.ru_tipo = item.ru_tipo;
                    Obj.ru_estado = item.ru_estado;
                    Obj.ru_orden = item.ru_orden;
                    Obj.ru_EditablexUser = item.ru_EditablexUser;
                    Obj.IdUsuario = item.IdUsuario;
                    Obj.Fecha_Transac = item.Fecha_Transac;
                    Obj.IdUsuarioUltMod = item.IdUsuarioUltMod;
                    Obj.rub_codigo = item.rub_codigo;

                    Obj.rub_concep = Convert.ToBoolean(item.rub_concep);
                    Obj.rub_tipcal = Convert.ToInt32(item.rub_tipcal);
                    Obj.rub_formul = item.rub_formul;
                    Obj.rub_valfij = item.rub_valfij;
                    Obj.rub_legal = item.rub_legal;
                    Obj.rub_foract = item.rub_foract;
                    Obj.rub_fornom = item.rub_fornom;
                    Obj.rub_gencon = item.rub_gencon;
                    Obj.rub_antici = Convert.ToBoolean(item.rub_antici);
                    Obj.rub_ctacon = item.rub_ctacon;
                    Obj.rub_grupo = Convert.ToInt32(item.rub_grupo);
                    Obj.rub_liquida = Convert.ToBoolean(item.rub_liquida);
                    Obj.rub_provision = Convert.ToBoolean(item.rub_provision);
                    Obj.rub_noafecta = Convert.ToBoolean(item.rub_noafecta);
                    Obj.rub_acumula = Convert.ToBoolean(item.rub_acumula);
                    Obj.rub_prorrateo = Convert.ToBoolean(item.rub_prorrateo);
                    Obj.rub_nocontab = Convert.ToBoolean(item.rub_nocontab);
                    Obj.rub_utilid = Convert.ToBoolean(item.rub_utilid);
                    Obj.rub_guarda_rol = Convert.ToBoolean(item.rub_guarda_rol);
                    Obj.rub_aplica_IESS = Convert.ToBoolean(item.rub_aplica_IESS);

                    Obj.rub_AplicaEmpleado_Vac = Convert.ToBoolean(item.rub_AplicaEmpleado_Vac);
                    Obj.ru_aplica_empleado_Subsidio = Convert.ToBoolean(item.ru_aplica_empleado_Subsidio);
                    Obj.rub_Contabiliza_x_empleado = item.rub_Contabiliza_x_empleado;


                    Lst.Add(Obj);

                }
                return Lst;
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


        public List<ro_rubro_tipo_Info> Get_listarubro_provisiones(int idEmpresa)
        {
            List<ro_rubro_tipo_Info> Lst = new List<ro_rubro_tipo_Info>();
            try
            {


                EntitiesRoles db = new EntitiesRoles();
                var datos = from a in db.ro_rubro_tipo
                            where a.IdEmpresa == idEmpresa
                            && a.rub_provision == true

                            select a;

                foreach (var item in datos)
                {
                    ro_rubro_tipo_Info Obj = new ro_rubro_tipo_Info();
                    Obj.IdEmpresa = item.IdEmpresa;
                    Obj.IdRubro = item.IdRubro;
                    Obj.ru_codRolGen = item.ru_codRolGen;
                    Obj.ru_descripcion = item.ru_descripcion;
                    Obj.NombreCorto = item.NombreCorto;
                    Obj.ru_tipo = item.ru_tipo;
                    Obj.ru_estado = item.ru_estado;
                    Obj.ru_orden = item.ru_orden;
                    Obj.ru_EditablexUser = item.ru_EditablexUser;
                    Obj.IdUsuario = item.IdUsuario;
                    Obj.Fecha_Transac = item.Fecha_Transac;
                    Obj.IdUsuarioUltMod = item.IdUsuarioUltMod;
                    Obj.rub_codigo = item.rub_codigo;

                    Obj.rub_concep = Convert.ToBoolean(item.rub_concep);
                    Obj.rub_tipcal = Convert.ToInt32(item.rub_tipcal);
                    Obj.rub_formul = item.rub_formul;
                    Obj.rub_valfij = item.rub_valfij;
                    Obj.rub_legal = item.rub_legal;
                    Obj.rub_foract = item.rub_foract;
                    Obj.rub_fornom = item.rub_fornom;
                    Obj.rub_gencon = item.rub_gencon;
                    Obj.rub_antici = Convert.ToBoolean(item.rub_antici);
                    Obj.rub_ctacon = item.rub_ctacon;
                    Obj.rub_grupo = Convert.ToInt32(item.rub_grupo);
                    Obj.rub_liquida = Convert.ToBoolean(item.rub_liquida);
                    Obj.rub_provision = Convert.ToBoolean(item.rub_provision);
                    Obj.rub_noafecta = Convert.ToBoolean(item.rub_noafecta);
                    Obj.rub_acumula = Convert.ToBoolean(item.rub_acumula);
                    Obj.rub_prorrateo = Convert.ToBoolean(item.rub_prorrateo);
                    Obj.rub_nocontab = Convert.ToBoolean(item.rub_nocontab);
                    Obj.rub_utilid = Convert.ToBoolean(item.rub_utilid);
                    Obj.rub_guarda_rol = Convert.ToBoolean(item.rub_guarda_rol);
                    Obj.rub_aplica_IESS = Convert.ToBoolean(item.rub_aplica_IESS);

                    Obj.rub_AplicaEmpleado_Vac = Convert.ToBoolean(item.rub_AplicaEmpleado_Vac);
                    Obj.ru_aplica_empleado_Subsidio = Convert.ToBoolean(item.ru_aplica_empleado_Subsidio);
                    Obj.rub_Contabiliza_x_empleado = item.rub_Contabiliza_x_empleado;
                    if (item.rub_mustra_liquidacion_cliente != null)
                        Obj.rub_mustra_liquidacion_cliente = item.rub_mustra_liquidacion_cliente;

                    Lst.Add(Obj);

                }
                return Lst;
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
