using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Produccion_Talme;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Produccion_Talme
{
    public class prod_ProgramaProd_Data
    {
        string mensaje = "";
        public Boolean GuardarDB(ref prod_ProgramaProd_Info Info)
        {
            try
            {
                List<prod_ProgramaProd_Info> Lst = new List<prod_ProgramaProd_Info>();
                using (EntitiesProduccion Context = new EntitiesProduccion())
                {
                    var Address = new prod_ProgramaProd();

                    Address.IdEmpresa = Info.IdEmpresa;
                    Info.IdProgramaProd = Address.IdProgramaProd = getId(Info.IdEmpresa, Info.IdProgramaProd);
                    Address.IdTurno = Info.IdTurno;
                    Address.Fecha = Info.Fecha;
                    Address.IdProducto = Info.IdProducto;
                    Address.IdCategoria = Info.IdCategoria;
                    Address.Unidad = Info.Unidad;
                    Address.Peso = Info.Peso;
                    Address.Toneladas = Info.Toneladas;
                    Address.Pedidos = Info.Pedidos;
                    Address.Estado = "A";

                    Context.prod_ProgramaProd.Add(Address);
                    Context.SaveChanges();

                }
                return true;
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

        public List<prod_ProgramaProd_Info> ConsultaGeneral( int Idempresa)
        {
                List<prod_ProgramaProd_Info> Lst = new List<prod_ProgramaProd_Info>();
                EntitiesProduccion oEnti = new EntitiesProduccion();
            try
            {
                var Query = from q in oEnti.prod_ProgramaProd
                            where q.IdEmpresa == Idempresa

                            select q;

                foreach (var item in Query)
                {
                    prod_ProgramaProd_Info Obj = new prod_ProgramaProd_Info();
                    Obj.IdEmpresa = item.IdEmpresa;
                    Obj.IdProgramaProd = item.IdProgramaProd;

                    if (item.IdTurno != null)
                    { Obj.IdTurno = Convert.ToInt32(item.IdTurno); }
                    
                    if (item.Fecha != null)
                    {   Obj.Fecha = Convert.ToDateTime(item.Fecha);  }

                    if (item.IdProducto != null)
                    { Obj.IdProducto = Convert.ToDecimal(item.IdProducto); }

                    Obj.IdCategoria = item.IdCategoria;

                    if (item.Unidad != null)
                    { Obj.Unidad = Convert.ToDecimal(item.Unidad); }

                    if (item.Peso != null)
                    { Obj.Peso = Convert.ToDecimal(item.Peso); }

                    if (item.Toneladas != null)
                    { Obj.Toneladas = Convert.ToDecimal(item.Toneladas); }

                    if (item.Pedidos != null)
                    { Obj.Pedidos = Convert.ToInt32(item.Pedidos); }
                    Obj.Estado = item.Estado;

                    Lst.Add(Obj);
                }
                return Lst;
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

       public List<prod_ProgramaProd_Info> ConsultaGeneral( int Idempresa,DateTime desde, DateTime hasta)
       {
            List<prod_ProgramaProd_Info> Lista = new List<prod_ProgramaProd_Info>();
           try
           {   
               using( EntitiesProduccion oEnt = new EntitiesProduccion())
               {
                   var listado = from C in oEnt.vwProd_ProgramaProd
                                where C.IdEmpresa == Idempresa
                                 && C.Fecha <= hasta
                                 && C.Fecha >= desde
                                 select C;


               foreach (var item in listado)
               {
                   prod_ProgramaProd_Info Obj = new prod_ProgramaProd_Info();
                    Obj.IdEmpresa = item.IdEmpresa;
                    Obj.IdProgramaProd = item.IdProgramaProd;

                    if (item.IdTurno != null)
                    { Obj.IdTurno = Convert.ToInt32(item.IdTurno); }
                    
                    if (item.Fecha != null)
                    {   Obj.Fecha = Convert.ToDateTime(item.Fecha);  }

                    if (item.IdProducto != null)
                    { Obj.IdProducto = Convert.ToDecimal(item.IdProducto); }

                    Obj.IdCategoria = item.IdCategoria;

                    if (item.Unidad != null)
                    { Obj.Unidad = Convert.ToDecimal(item.Unidad); }

                    if (item.Peso != null)
                    { Obj.Peso = Convert.ToDecimal(item.Peso); }

                    if (item.Toneladas != null)
                    { Obj.Toneladas = Convert.ToDecimal(item.Toneladas); }

                    if (item.Pedidos != null)
                    { Obj.Pedidos = Convert.ToInt32(item.Pedidos); }
                    Obj.Estado = item.Estado;

                    Obj.Turno = item.Descripcion;
                    Obj.Producto = item.pr_descripcion;
                    Lista.Add(Obj);
               }}
               return Lista;
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.ToString() + " " + ex.Message;
               return new List<prod_ProgramaProd_Info>();               
           }
       
       
       }
        public prod_ProgramaProd_Info ObtenerObjeto(int Idempresa, int IdPrograma)
        {
            EntitiesProduccion oEnti = new EntitiesProduccion();
            try
            {
                prod_ProgramaProd_Info Info = new prod_ProgramaProd_Info();
                var Objeto = oEnti.prod_ProgramaProd.FirstOrDefault(var => var.IdEmpresa == Idempresa && var.IdProgramaProd == IdPrograma);
                if (Objeto != null)
                {
                    Info.IdEmpresa = Objeto.IdEmpresa;
                    Info.IdProgramaProd = Objeto.IdProgramaProd;

                    if (Objeto.IdTurno != null)
                    { Info.IdTurno = Convert.ToInt32(Objeto.IdTurno); }

                    if (Objeto.Fecha != null)
                    { Info.Fecha = Convert.ToDateTime(Objeto.Fecha); }

                    if (Objeto.IdProducto != null)
                    { Info.IdProducto = Convert.ToDecimal(Objeto.IdProducto); }

                    Info.IdCategoria = Objeto.IdCategoria;

                    if (Objeto.Unidad != null)
                    { Info.Unidad = Convert.ToDecimal(Objeto.Unidad); }

                    if (Objeto.Peso != null)
                    { Info.Peso = Convert.ToDecimal(Objeto.Peso); }

                    if (Objeto.Toneladas != null)
                    { Info.Toneladas = Convert.ToDecimal(Objeto.Toneladas); }

                    if (Objeto.Pedidos != null)
                        Info.Pedidos = Convert.ToInt32(Objeto.Pedidos);

                    Info.Estado = Objeto.Estado;
                }
                return Info;
            }
            catch (Exception  ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                return new prod_ProgramaProd_Info(); 
            }
        }

        public Boolean ModificarDB(prod_ProgramaProd_Info info)
        {
            try
            {
                using (EntitiesProduccion context = new EntitiesProduccion())
                {

                    var contact = context.prod_ProgramaProd.FirstOrDefault(minfo => minfo.IdEmpresa == info.IdEmpresa && minfo.IdProgramaProd == info.IdProgramaProd);
                    if (contact != null)
                    {
                        contact.IdTurno = info.IdTurno;
                        contact.Fecha = info.Fecha;
                        contact.IdProducto = info.IdProducto;
                        contact.IdCategoria = info.IdCategoria;
                        contact.Unidad = info.Unidad;
                        contact.Peso = info.Peso;
                        contact.Toneladas = info.Toneladas;
                        contact.Pedidos = info.Pedidos;
                        context.SaveChanges();
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
                return false;
            }
        }

        public Boolean AnularDB(prod_ProgramaProd_Info info)
        {
            try
            {
                using (EntitiesProduccion context = new EntitiesProduccion())
                {

                    var contact = context.prod_ProgramaProd.FirstOrDefault(minfo => minfo.IdEmpresa == info.IdEmpresa && minfo.IdProgramaProd == info.IdProgramaProd);
                    if (contact != null)
                    {
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
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                return false;
            }
        }

        public int getId(int IdEmpresa, int IdPrograma)
        {
            try
            {
                int Id;
                EntitiesProduccion OEProduccion = new EntitiesProduccion();
                var select = from q in OEProduccion.prod_ProgramaProd
                             where q.IdEmpresa == IdEmpresa && q.IdProgramaProd == IdPrograma
                             select q;

                if (select.ToList().Count() == 0)
                {
                    Id = 1;
                }
                else
                {
                    var select_em = (from q in OEProduccion.prod_ProgramaProd
                                     select q.IdProgramaProd).Max();
                    Id = Convert.ToInt32(select_em.ToString()) + 1;
                }
                return Id;
            }
            catch (Exception  ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                return 0;
            }

        }

        public Boolean VerificarExiste(prod_ProgramaProd_Info info, ref string msg)
        {
            try
            {
                using (EntitiesProduccion oEnt = new EntitiesProduccion())
                {
                    var reg = from C in oEnt.prod_ProgramaProd
                              where C.IdProducto == info.IdProducto
                              && C.IdTurno == info.IdTurno
                             select C;
                    foreach (var item in reg)
                    {
                        if (Convert.ToDateTime(item.Fecha).ToShortDateString() == Convert.ToDateTime(info.Fecha).ToShortDateString())
                        { msg = "Consulta correcta"; return true; }
                    }
                    msg = "Consulta correcta";
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
                msg = "Ocurrio un error"+ ex.ToString();
                return false;
            }
        
        
        }
    }
}
