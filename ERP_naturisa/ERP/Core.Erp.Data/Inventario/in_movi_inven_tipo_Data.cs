using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Inventario;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Inventario
{
    public class in_movi_inven_tipo_Data
    {
        string mensaje = "";
        public List<in_movi_inven_tipo_Info> Get_list_movi_inven_tipo(int IdEmpresa, string tipoMovi, string Interno,string Todos)
        {

            try
            {
                List<in_movi_inven_tipo_Info> lM = new List<in_movi_inven_tipo_Info>();
                EntitiesInventario OECbtecble_Info = new EntitiesInventario();
                
                var selectCbtecble = from C in OECbtecble_Info.in_movi_inven_tipo
                                     where C.IdEmpresa == IdEmpresa
                                     && C.cm_tipo_movi.Contains(tipoMovi)
                                     && C.cm_interno.Contains(Interno)
                                     select C;


                in_movi_inven_tipo_Info prd = new in_movi_inven_tipo_Info();
                if (Todos == "Todos")
                {

                    prd.IdEmpresa = IdEmpresa;
                    prd.Estado = "A";
                    prd.cm_descripcionCorta = "Todos";
                    prd.cm_interno = "N";
                    prd.cm_tipo_movi = "+";
                    prd.Codigo = "Todos";
                    prd.IdMovi_inven_tipo = 0;
                    prd.tm_descripcion = "Todos";

                    lM.Add(prd);

                }
                foreach (var item in selectCbtecble)
                {
                    prd = new in_movi_inven_tipo_Info();
                    prd.IdEmpresa = item.IdEmpresa;
                    prd.Estado = item.Estado.Trim();
                    prd.cm_descripcionCorta = item.cm_descripcionCorta;
                    prd.cm_interno = item.cm_interno;
                    prd.cm_tipo_movi = item.cm_tipo_movi;
                    prd.Codigo = item.Codigo;
                    prd.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
                    prd.tm_descripcion = item.tm_descripcion;
                    prd.tm_descripcion2 = "["+ item.IdMovi_inven_tipo +  "]"+ item.tm_descripcion;
                    prd.IdTipoCbte = Convert.ToInt32(item.IdTipoCbte);
                    prd.Genera_Movi_Inven = (item.Genera_Movi_Inven == null) ? true : item.Genera_Movi_Inven;
                    prd.Genera_Diario_Contable = (item.Genera_Diario_Contable == null) ? true : Convert.ToBoolean(item.Genera_Diario_Contable);


                    lM.Add(prd);
                }
                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(mensaje);
            }
        }

        public List<in_movi_inven_tipo_Info> Get_list_movi_inven_tipo(int IdEmpresa, string tipoMovi)
        {

            try
            {
                List<in_movi_inven_tipo_Info> lM = new List<in_movi_inven_tipo_Info>();
                EntitiesInventario OECbtecble_Info = new EntitiesInventario();
                var selectCbtecble = from C in OECbtecble_Info.in_movi_inven_tipo
                                     where C.IdEmpresa == IdEmpresa
                                     && C.cm_tipo_movi.Contains(tipoMovi)
                                     select C;


                in_movi_inven_tipo_Info prd = new in_movi_inven_tipo_Info();
                
                foreach (var item in selectCbtecble)
                {
                    prd = new in_movi_inven_tipo_Info();
                    prd.IdEmpresa = item.IdEmpresa;
                    prd.Estado = item.Estado.Trim();
                    prd.cm_descripcionCorta = item.cm_descripcionCorta;
                    prd.cm_interno = item.cm_interno;
                    prd.cm_tipo_movi = item.cm_tipo_movi;
                    prd.Codigo = item.Codigo;
                    prd.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
                    prd.tm_descripcion = item.tm_descripcion;
                    prd.tm_descripcion2 = "[" + item.IdMovi_inven_tipo + "]" + item.tm_descripcion;
                    prd.IdTipoCbte = Convert.ToInt32(item.IdTipoCbte);
                    prd.IdUsuario = item.IdUsuario;
                    prd.Fecha_Transac = item.Fecha_Transac;
                    prd.nom_pc = item.nom_pc;
                    prd.ip = item.ip;
                    
                    prd.Genera_Movi_Inven = (item.Genera_Movi_Inven == null) ? true : item.Genera_Movi_Inven;
                    prd.Genera_Diario_Contable = (item.Genera_Diario_Contable == null) ? true : Convert.ToBoolean(item.Genera_Diario_Contable);

                    lM.Add(prd);
                }
                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(mensaje);
            }
        }

        public List<in_movi_inven_tipo_Info> Get_list_movi_inven_tipo_x_bodega(int IdEmpresa,int IdSucursal,
            int IdBodega, string tipoMovi, string Interno)
        {
            try
            {

               IQueryable<in_movi_inven_tipo> selectCbtecble;
                List<in_movi_inven_tipo_Info> lM = new List<in_movi_inven_tipo_Info>();
                EntitiesInventario OECbtecble_Info = new EntitiesInventario();
                if(IdBodega == 0) IdBodega = 1;
                selectCbtecble = from C in OECbtecble_Info.in_movi_inven_tipo
                                     join D in OECbtecble_Info.in_movi_inven_tipo_x_tb_bodega
                                     on new { C.IdEmpresa, C.IdMovi_inven_tipo } equals new { D.IdEmpresa, D.IdMovi_inven_tipo }
                                     where C.IdEmpresa == IdEmpresa
                                     && C.cm_tipo_movi.Contains(tipoMovi)
                                     && C.cm_interno.Contains(Interno)
                                     && D.IdBodega == IdBodega
                                     && D.IdSucucursal==IdSucursal
                                     select C;

                foreach (var item in selectCbtecble)
                {
                    in_movi_inven_tipo_Info prd = new in_movi_inven_tipo_Info();
                    prd.IdEmpresa = item.IdEmpresa;
                    prd.Estado = item.Estado.Trim();
                    prd.cm_descripcionCorta =item.cm_descripcionCorta;
                    prd.cm_interno = item.cm_interno;
                    prd.cm_tipo_movi = item.cm_tipo_movi;
                    prd.Codigo = item.Codigo;
                    prd.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
                    prd.tm_descripcion2 = "[" + item.IdMovi_inven_tipo + "]" + item.tm_descripcion;
                    prd.tm_descripcion = item.tm_descripcion;
                    prd.IdTipoCbte = Convert.ToInt32(item.IdTipoCbte);

                    prd.Genera_Movi_Inven = (item.Genera_Movi_Inven == null) ? true : item.Genera_Movi_Inven;
                    prd.Genera_Diario_Contable = (item.Genera_Diario_Contable == null) ? true : Convert.ToBoolean(item.Genera_Diario_Contable);

                    lM.Add(prd);
                }
                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(mensaje);
            }
        }

       public Boolean ModificarDB(in_movi_inven_tipo_Info MoviI, ref string mensaje)
        {
            try
            {
                using (EntitiesInventario contex = new EntitiesInventario())
                {
                    var contac = contex.in_movi_inven_tipo.FirstOrDefault(VMovi => VMovi.IdEmpresa == MoviI.IdEmpresa && VMovi.IdMovi_inven_tipo == MoviI.IdMovi_inven_tipo);
                    if (contac != null)
                    {
                        contac.tm_descripcion = MoviI.tm_descripcion;
                        contac.cm_descripcionCorta = MoviI.cm_descripcionCorta;
                        contac.Codigo = MoviI.Codigo;
                        contac.cm_tipo_movi = MoviI.cm_tipo_movi;
                        contac.Estado = MoviI.Estado;
                        contac.cm_interno = MoviI.cm_interno;
                        contac.IdTipoCbte = MoviI.IdTipoCbte;
                        contac.IdUsuarioUltMod = MoviI.IdUsuario;
                        contac.Fecha_UltMod = MoviI.Fecha_Transac;
                        contac.Fecha_UltMod = MoviI.Fecha_UltMod;
                        contac.nom_pc = MoviI.nom_pc;
                        contac.ip = MoviI.ip;
                        contac.Genera_Movi_Inven = (MoviI.Genera_Movi_Inven == null) ? false : MoviI.Genera_Movi_Inven;
                        contac.Genera_Diario_Contable = (MoviI.Genera_Diario_Contable == null) ? false : MoviI.Genera_Diario_Contable;  
                        
                        contex.SaveChanges();
                        mensaje = "Grabacion Exitosa";
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
                mensaje = "Error al Grabar" + ex.ToString().ToString();
                throw new Exception(mensaje);
            }
        }

        public Boolean AnularDB(in_movi_inven_tipo_Info MoviI)
        {
            try
            {
                using (EntitiesInventario contex = new EntitiesInventario())
                {
                    var contac = contex.in_movi_inven_tipo.FirstOrDefault(VMovi => VMovi.IdEmpresa == MoviI.IdEmpresa && VMovi.IdMovi_inven_tipo == MoviI.IdMovi_inven_tipo);
                    if (contac != null)
                    {
                        contac.Estado = "I";
                        contac.tm_descripcion = "**Anulado **" + MoviI.tm_descripcion;
                        contac.nom_pc = MoviI.nom_pc;
                        contac.ip = MoviI.ip;
                        contac.IdUsuarioUltAnu = MoviI.IdUsuarioUltAnu;
                        contac.Fecha_UltAnu = MoviI.Fecha_UltAnu;
                        contac.MotiAnula = MoviI.MotiAnula;
                        contex.SaveChanges();
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
                throw new Exception(mensaje);
            }
        }
        
        public int GetIdMoviInvent(int IdEmpresa)
        {
            try
            {
                int id;
                EntitiesInventario OECTable = new EntitiesInventario();

                var q = from c in OECTable.in_movi_inven_tipo
                        where c.IdEmpresa == IdEmpresa
                        select c;
                if (q.ToList().Count == 0)
                    return 1;
                else
                {
                    var select_ = (from t in OECTable.in_movi_inven_tipo
                                   where t.IdEmpresa == IdEmpresa
                                   select t.IdMovi_inven_tipo).Max();
                    id = Convert.ToInt32(select_.ToString()) + 1;
                    return id;
                }
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(mensaje);
            }

        }

        public Boolean GrabarDB(in_movi_inven_tipo_Info MoviI, ref string mensaje)
        {
            try
            {
                int idMavi;
                using (EntitiesInventario contex = new EntitiesInventario())
                {
                    EntitiesInventario EDB = new EntitiesInventario();
                    idMavi = GetIdMoviInvent(MoviI.IdEmpresa);
                    MoviI.IdMovi_inven_tipo = idMavi;
                    var address = new in_movi_inven_tipo();

                    address.IdEmpresa = MoviI.IdEmpresa;
                    address.IdMovi_inven_tipo = MoviI.IdMovi_inven_tipo;
                    address.tm_descripcion = MoviI.tm_descripcion;
                    address.cm_descripcionCorta = (MoviI.cm_descripcionCorta != "") ? MoviI.cm_descripcionCorta : MoviI.IdMovi_inven_tipo.ToString();
                    address.Codigo = (MoviI.Codigo == "") ? MoviI.IdMovi_inven_tipo.ToString() : MoviI.Codigo;
                    address.cm_tipo_movi = MoviI.cm_tipo_movi;
                    address.Estado = MoviI.Estado;
                    address.cm_interno = MoviI.cm_interno;
                    address.IdTipoCbte = MoviI.IdTipoCbte;
                    address.IdUsuario = MoviI.IdUsuario;
                    address.Fecha_Transac = MoviI.Fecha_Transac;
                    address.IdUsuarioUltMod = MoviI.IdUsuarioUltMod;
                    address.Fecha_UltMod = MoviI.Fecha_UltMod;
                    address.nom_pc = MoviI.nom_pc;
                    address.ip = MoviI.ip;

                    address.Genera_Movi_Inven = (MoviI.Genera_Movi_Inven == null) ? false : MoviI.Genera_Movi_Inven;
                    address.Genera_Diario_Contable = (MoviI.Genera_Diario_Contable == null) ? false : MoviI.Genera_Diario_Contable;  

                    
                    contex.in_movi_inven_tipo.Add(address);
                    contex.SaveChanges();
                    mensaje = "Grabacion Ok..";
                    return true;
                }
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(mensaje);
            }
        }

        public Boolean Get_Codigo(in_movi_inven_tipo_Info MoviI, ref string mensaje)
        {
            try
            {
                EntitiesInventario OECODIGO = new EntitiesInventario();

                var codigo = from t in OECODIGO.in_movi_inven_tipo
                             where t.Codigo == MoviI.Codigo
                             && t.IdEmpresa == MoviI.IdEmpresa 
                             select new { t.Codigo };
                foreach (var item in codigo)
                {
                    if (item.Codigo == MoviI.Codigo)
                    {
                        mensaje = "Codigo ya existe para esta empresa .. por favor ingrese un codigo distino";
                        return true;
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(mensaje);
            }
        }

        public Boolean Cons_MovimientoInventario(in_movi_inven_tipo_Info MoviI, ref string mensaje)
        {
            try
            {
                EntitiesInventario OEMOVIMIENTO = new EntitiesInventario();
                var c = from t in OEMOVIMIENTO.in_movi_inve
                        where t.IdEmpresa == MoviI.IdEmpresa && t.IdMovi_inven_tipo == MoviI.IdMovi_inven_tipo
                        select t;

                if (c.ToList().Count > 0)
                {
                    mensaje = "No se puede anular por que tiene un Movimiento de Inventario";
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
             {
                 string arreglo = ToString();
                 tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                 tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                 oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                 mensaje = ex.ToString() + " " + ex.Message;
                 throw new Exception(mensaje);
            }
        }

        public List<in_movi_inven_tipo_Info> Get_List_movi_inven_tipo(int IdEmpresa) 
        {
            try
            {
                List<in_movi_inven_tipo_Info> lista = new List<in_movi_inven_tipo_Info>();

                using (EntitiesInventario Oen = new EntitiesInventario()) 
                {
                    string Query = "select * from in_movi_inven_tipo where idempresa ="+IdEmpresa;
                    var Consulta = Oen.Database.SqlQuery<in_movi_inven_tipo_Info>(Query);
                    lista = Consulta.ToList();
                }

                return lista ;
            }
            catch (Exception ex)
            {
                string mensaje = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;

                throw new Exception(mensaje);
            }
        }

        public in_movi_inven_tipo_Info Get_Info_movi_inven_tipo(int IdEmpresa, string Codigo)
        {
            try
            {
                EntitiesInventario OEInventario = new EntitiesInventario();

                var select = from C in OEInventario.in_movi_inven_tipo
                             where C.IdEmpresa == IdEmpresa && C.Codigo == Codigo
                             select C;
                in_movi_inven_tipo_Info info = new in_movi_inven_tipo_Info();

                foreach (var item in select)
                {
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
                    info.Codigo = item.Codigo;
                    info.tm_descripcion = item.tm_descripcion;
                    info.cm_tipo_movi = item.cm_tipo_movi;
                    info.cm_interno = item.cm_interno;
                    info.cm_descripcionCorta = item.cm_descripcionCorta;
                    info.Estado = item.Estado;
                    info.IdTipoCbte = Convert.ToInt32(item.IdTipoCbte);
                    info.Genera_Movi_Inven = item.Genera_Movi_Inven;
                    info.Genera_Diario_Contable = item.Genera_Diario_Contable;
                }
                return info;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(mensaje);
            }
        }

        public in_movi_inven_tipo_Info Get_Info_movi_inven_tipo(int IdEmpresa, int Idtipo)
        {
            try
            {
                EntitiesInventario OEInventario = new EntitiesInventario();

                var select = from C in OEInventario.in_movi_inven_tipo
                             where C.IdEmpresa == IdEmpresa 
                             && C.IdMovi_inven_tipo == Idtipo 
                             select C;
                in_movi_inven_tipo_Info info = new in_movi_inven_tipo_Info();

                foreach (var item in select)
                {
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
                    info.Codigo = item.Codigo;
                    info.tm_descripcion = item.tm_descripcion;
                    info.cm_tipo_movi = item.cm_tipo_movi;
                    info.cm_interno = item.cm_interno;
                    info.cm_descripcionCorta = item.cm_descripcionCorta;
                    info.tm_descripcion2 = "[" + item.IdMovi_inven_tipo + "]" + item.tm_descripcion;
                    info.Estado = item.Estado;
                    info.IdTipoCbte = Convert.ToInt32(item.IdTipoCbte);
                    info.Genera_Movi_Inven = (item.Genera_Movi_Inven == null) ? true : item.Genera_Movi_Inven;
                    info.Genera_Diario_Contable = (item.Genera_Diario_Contable == null) ? true : item.Genera_Diario_Contable;  
                }
                return info;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(mensaje);
            }
        }
    }
}
