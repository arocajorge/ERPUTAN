
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Roles;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Roles
{
    public class ro_Catalogo_Data
    {
        string mensaje = "";


        public int getId()
        {

            int Id=0;

            try
            {
                EntitiesRoles OEEmpleado = new EntitiesRoles();
                var select = from q in OEEmpleado.ro_catalogo
                             //where q.IdTipoCatalogo == IdTipoCatalogo
                             select q;

                if (select.ToList().Count() == 0)
                {
                    Id = 1;
                }
                else
                {
                    var select_em = (from q in OEEmpleado.ro_catalogo
                                     //where q.IdTipoCatalogo == IdTipoCatalogo
                                     select q.IdCatalogo).Max();
                    Id = Convert.ToInt32(select_em.ToString()) + 1;
                }
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }          
            return Id;
        }

        
        public Boolean GuardarDB(ref ro_Catalogo_Info Info)
	    {
		try
		{
			List<ro_Catalogo_Info> Lst = new List<ro_Catalogo_Info>() ;
			using(EntitiesRoles Context= new EntitiesRoles())
			{
				var Address = new ro_catalogo();

				Address.IdCatalogo= Info.IdCatalogo = getId();
				Address.IdTipoCatalogo = Info.IdTipoCatalogo;
                if (Info.CodCatalogo == "" || Info.CodCatalogo == null) 
                {
                    Address.CodCatalogo = Info.IdCatalogo.ToString();
                }
                else
                {
                    Address.CodCatalogo = Info.CodCatalogo;
                }
				Address.ca_descripcion= Info.ca_descripcion;
				Address.ca_estado= "A";
				Address.ca_orden= Info.ca_orden;

				
				Context.ro_catalogo.Add(Address);
				Context.SaveChanges();
			}
		return true;
		}
		catch (Exception ex)
        {
            string arreglo = ToString();
            tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
            tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
            mensaje = ex.InnerException + " " + ex.Message;
            oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
            throw new Exception(ex.InnerException.ToString());
        }
	}

        public List<ro_Catalogo_Info> Get_List_Catalogo(int IdEmpresa)
        {
		    List<ro_Catalogo_Info> Lst = new List<ro_Catalogo_Info>() ;
		    try
		    {
	
			    EntitiesRoles oEnti= new EntitiesRoles();
			    var Query = from q in oEnti.ro_catalogo
				    select q;
			        foreach (var item in Query)
			    {
				    ro_Catalogo_Info Obj = new ro_Catalogo_Info() ;
					    Obj.IdCatalogo= item.IdCatalogo;
					    Obj.IdTipoCatalogo= item.IdTipoCatalogo;
					    Obj.CodCatalogo= item.CodCatalogo;
					    Obj.ca_descripcion= item.ca_descripcion;
					    Obj.ca_estado= item.ca_estado;
					    Obj.ca_orden= item.ca_orden;
				    Lst.Add(Obj);
		    }
			    return Lst;
			    }
		    catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
			}

        public List<ro_Catalogo_Info> Get_List_Catalogo_x_AnioFiscal(int IdEmpresa)
        {
            List<ro_Catalogo_Info> Lst = new List<ro_Catalogo_Info>();
            try
            {

                EntitiesRoles oEnti = new EntitiesRoles();
                var Query = from q in oEnti.ro_catalogo
                            where q.IdTipoCatalogo==35
                            select q;
                foreach (var item in Query)
                {
                    ro_Catalogo_Info Obj = new ro_Catalogo_Info();
                    Obj.IdCatalogo = item.IdCatalogo;
                    Obj.IdTipoCatalogo = item.IdTipoCatalogo;
                    Obj.CodCatalogo = item.CodCatalogo;
                    Obj.ca_descripcion = item.ca_descripcion;
                    Obj.ca_estado = item.ca_estado;
                    Obj.ca_orden = item.ca_orden;
                    Lst.Add(Obj);
                }
                return Lst;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public List<ro_Catalogo_Info> Get_List_Catalogo_x_DiasFalta(int IdEmpresa)
        {
            List<ro_Catalogo_Info> Lst = new List<ro_Catalogo_Info>();
            try
            {

                EntitiesRoles oEnti = new EntitiesRoles();
                var Query = from q in oEnti.ro_catalogo
                            where q.IdTipoCatalogo==1                                                      
                            select q;
                foreach (var item in Query)
                {
                    
                    ro_Catalogo_Info Obj = new ro_Catalogo_Info();
                    Obj.IdCatalogo = item.IdCatalogo;
                    Obj.IdTipoCatalogo = item.IdTipoCatalogo;
                    Obj.CodCatalogo = item.CodCatalogo;
                    Obj.ca_descripcion = item.ca_descripcion;
                    Obj.ca_estado = item.ca_estado;
                    Obj.ca_orden = item.ca_orden;
                    Lst.Add(Obj);
                
                }
                return Lst;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }

	    public ro_Catalogo_Info Get_info_Catalogo(int IdCatalogo)
	    {
			EntitiesRoles oEnti= new EntitiesRoles();
				ro_Catalogo_Info Info = new ro_Catalogo_Info() ;
		    try
		    {

			     var Objeto = oEnti.ro_catalogo.First(var => var.IdCatalogo == IdCatalogo);
					    Info.IdCatalogo= Objeto.IdCatalogo;
					    Info.IdTipoCatalogo= Objeto.IdTipoCatalogo;
					    Info.CodCatalogo= Objeto.CodCatalogo;
					    Info.ca_descripcion= Objeto.ca_descripcion;
					    Info.ca_estado= Objeto.ca_estado;
					    Info.ca_orden= Objeto.ca_orden;
				    return Info;
			    }
		    catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
	    }

        public List<ro_Catalogo_Info> Get_List_Catalogo_x_Tipo(int IdTipoCatalago)
    {
            List<ro_Catalogo_Info> Lst = new List<ro_Catalogo_Info>();
        try
        {

            EntitiesRoles oEnti = new EntitiesRoles();
            var Query = from q in oEnti.ro_catalogo
                        orderby q.ca_orden 
                        where q.IdTipoCatalogo == IdTipoCatalago
                        
                        select q;
            foreach (var item in Query)
            {
                ro_Catalogo_Info Obj = new ro_Catalogo_Info();
                Obj.IdCatalogo = item.IdCatalogo;
                Obj.IdTipoCatalogo = item.IdTipoCatalogo;
                Obj.CodCatalogo = item.CodCatalogo;
                Obj.ca_descripcion = item.ca_descripcion;
                Obj.ca_estado = item.ca_estado;
                Obj.ca_orden = item.ca_orden;
                Lst.Add(Obj);
            }
            return Lst;
        }
        catch (Exception ex)
        {
            string arreglo = ToString();
            tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
            tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
            mensaje = ex.InnerException + " " + ex.Message;
            oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
            throw new Exception(ex.InnerException.ToString());
        }
    }
        
        public List<ro_Catalogo_Info> Get_List_CatalogoMotivoPrestamo()
    {
            List<ro_Catalogo_Info> Lst = new List<ro_Catalogo_Info>();
        try
        {

            EntitiesRoles oEnti = new EntitiesRoles();

            var Query = from q in oEnti.ro_catalogo
                        join t in oEnti.ro_catalogoTipo
                        on q.IdTipoCatalogo equals t.IdTipoCatalogo
                         where (t.IdTipoCatalogo == 15)
                        select new {q.IdCatalogo,q.IdTipoCatalogo,q.CodCatalogo,q.ca_descripcion,q.ca_estado,q.ca_orden};


            foreach (var item in Query)
            {
                ro_Catalogo_Info Obj = new ro_Catalogo_Info();
                Obj.IdCatalogo = item.IdCatalogo;
                Obj.IdTipoCatalogo = item.IdTipoCatalogo;
                Obj.CodCatalogo = item.CodCatalogo;
                Obj.ca_descripcion = item.ca_descripcion;
                Obj.ca_estado = item.ca_estado;
                Obj.ca_orden = item.ca_orden;
                Lst.Add(Obj);
            }
            return Lst;
        }
        catch (Exception ex)
        {
            string arreglo = ToString();
            tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
            tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
            mensaje = ex.InnerException + " " + ex.Message;
            oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
            throw new Exception(ex.InnerException.ToString());
        }
    }
        
        public List<ro_Catalogo_Info> Get_List_CatalogoEstadoPrestamo()
    {
            List<ro_Catalogo_Info> Lst = new List<ro_Catalogo_Info>();
        try
        {

            EntitiesRoles oEnti = new EntitiesRoles();

            var Query = from q in oEnti.ro_catalogo
                        orderby q.ca_orden
                        where q.IdTipoCatalogo == 16
                        select q;


            foreach (var item in Query)
            {
                ro_Catalogo_Info Obj = new ro_Catalogo_Info();
                Obj.IdCatalogo = item.IdCatalogo;
                Obj.IdTipoCatalogo = item.IdTipoCatalogo;
                Obj.CodCatalogo = item.CodCatalogo;
                Obj.ca_descripcion = item.ca_descripcion;
                Obj.ca_estado = item.ca_estado;
                Obj.ca_orden = item.ca_orden;
                Lst.Add(Obj);
            }
            return Lst;
        }
        catch (Exception ex) 
        {
            string arreglo = ToString();
            tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
            tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
            mensaje = ex.InnerException + " " + ex.Message;
            oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
            throw new Exception(ex.InnerException.ToString());
        }
    }
        
        public List<ro_Catalogo_Info> Get_List_CatalogoDecimos()
   {
           List<ro_Catalogo_Info> Lst = new List<ro_Catalogo_Info>();
       try
       {

           EntitiesRoles oEnti = new EntitiesRoles();

           var Query = from q in oEnti.ro_catalogo
                       join t in oEnti.ro_catalogoTipo
                       on q.IdTipoCatalogo equals t.IdTipoCatalogo
                       where (t.IdTipoCatalogo == 21)
                       select new { q.IdCatalogo, q.IdTipoCatalogo, q.CodCatalogo, q.ca_descripcion, q.ca_estado, q.ca_orden };


           foreach (var item in Query)
           {
               ro_Catalogo_Info Obj = new ro_Catalogo_Info();
               Obj.IdCatalogo = item.IdCatalogo;
               Obj.IdTipoCatalogo = item.IdTipoCatalogo;
               Obj.CodCatalogo = item.CodCatalogo;
               Obj.ca_descripcion = item.ca_descripcion;
               Obj.ca_estado = item.ca_estado;
               Obj.ca_orden = item.ca_orden;
               Lst.Add(Obj);
           }
           return Lst;
       }
       catch (Exception ex)
       {
           string arreglo = ToString();
           tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
           tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
           mensaje = ex.InnerException + " " + ex.Message;
           oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
           throw new Exception(ex.InnerException.ToString());
       }
   }
   
        public List<ro_Catalogo_Info> Get_List_CatalogoEstadoCobro()
   {
           List<ro_Catalogo_Info> Lst = new List<ro_Catalogo_Info>();
       try
       {

           EntitiesRoles oEnti = new EntitiesRoles();

           var Query = from q in oEnti.ro_catalogo
                       join t in oEnti.ro_catalogoTipo
                       on q.IdTipoCatalogo equals t.IdTipoCatalogo
                       where (t.IdTipoCatalogo == 16 && q.IdCatalogo == 89 || q.IdCatalogo == 90)
                       select new { q.IdCatalogo, q.IdTipoCatalogo, q.CodCatalogo, q.ca_descripcion, q.ca_estado, q.ca_orden };


           foreach (var item in Query)
           {
               ro_Catalogo_Info Obj = new ro_Catalogo_Info();
               Obj.IdCatalogo = item.IdCatalogo;
               Obj.IdTipoCatalogo = item.IdTipoCatalogo;
               Obj.CodCatalogo = item.CodCatalogo;
               Obj.ca_descripcion = item.ca_descripcion;
               Obj.ca_estado = item.ca_estado;
               Obj.ca_orden = item.ca_orden;
               Lst.Add(Obj);
           }
           return Lst;
       }
       catch (Exception ex) 
       {
           string arreglo = ToString();
           tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
           tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
           mensaje = ex.InnerException + " " + ex.Message;
           oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
           throw new Exception(ex.InnerException.ToString());
       }
   }
        
        public List<ro_Catalogo_Info> Get_List_CatalogoBanco()
   {
           List<ro_Catalogo_Info> Lst = new List<ro_Catalogo_Info>();
       try
       {

           EntitiesRoles oEnti = new EntitiesRoles();

           var Query = from q in oEnti.ro_catalogo
                       join t in oEnti.ro_catalogoTipo
                       on q.IdTipoCatalogo equals t.IdTipoCatalogo
                       where (t.IdTipoCatalogo == 11)
                       select new { q.IdCatalogo, q.IdTipoCatalogo, q.CodCatalogo, q.ca_descripcion, q.ca_estado, q.ca_orden };


           foreach (var item in Query)
           {
               ro_Catalogo_Info Obj = new ro_Catalogo_Info();
               Obj.IdCatalogo = item.IdCatalogo;
               Obj.IdTipoCatalogo = item.IdTipoCatalogo;
               Obj.CodCatalogo = item.CodCatalogo;
               Obj.ca_descripcion = item.ca_descripcion;
               Obj.ca_estado = item.ca_estado;
               Obj.ca_orden = item.ca_orden;
               Lst.Add(Obj);
           }
           return Lst;
       }
       catch (Exception ex)
       {
           string arreglo = ToString();
           tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
           tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
           mensaje = ex.InnerException + " " + ex.Message;
           oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
           throw new Exception(ex.InnerException.ToString());
       }
   }
   
        public List<ro_Catalogo_Info> Get_List_CatalogoTipoPago()
    {
            List<ro_Catalogo_Info> Lst = new List<ro_Catalogo_Info>();
        try
        {

            EntitiesRoles oEnti = new EntitiesRoles();

            var Query = from q in oEnti.ro_catalogo
                        join t in oEnti.ro_catalogoTipo
                        on q.IdTipoCatalogo equals t.IdTipoCatalogo
                        where (t.IdTipoCatalogo == 17)
                        select new { q.IdCatalogo, q.IdTipoCatalogo, q.CodCatalogo, q.ca_descripcion, q.ca_estado, q.ca_orden };


            foreach (var item in Query)
            {
                ro_Catalogo_Info Obj = new ro_Catalogo_Info();
                Obj.IdCatalogo = item.IdCatalogo;
                Obj.IdTipoCatalogo = item.IdTipoCatalogo;
                Obj.CodCatalogo = item.CodCatalogo;
                Obj.ca_descripcion = item.ca_descripcion;
                Obj.ca_estado = item.ca_estado;
                Obj.ca_orden = item.ca_orden;
                Lst.Add(Obj);
            }
            return Lst;
        }
        catch (Exception ex)
        {
            string arreglo = ToString();
            tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
            tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
            mensaje = ex.InnerException + " " + ex.Message;
            oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
            throw new Exception(ex.InnerException.ToString());
        }
    }

        public Boolean ModificarDB( ro_Catalogo_Info Info, ref string msj ) 
        {
            try
            {
                using (EntitiesRoles context = new EntitiesRoles())
                {

                    var contact = context.ro_catalogo.First(var => var.IdCatalogo == Info.IdCatalogo && var.IdTipoCatalogo == Info.IdTipoCatalogo);

                    contact.ca_descripcion = Info.ca_descripcion;
                    contact.ca_orden = Info.ca_orden;
                    contact.ca_estado = Info.ca_estado;

                    context.SaveChanges();
                }            
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                msj = mensaje;
                return false;
            }
        }
       
        public Boolean AnularDB(ro_Catalogo_Info Info)
        {
            try
            {
                using (EntitiesRoles context = new EntitiesRoles())
                {

                    var contact = context.ro_catalogo.First(var => var.IdCatalogo == Info.IdCatalogo && var.IdTipoCatalogo == Info.IdTipoCatalogo);
                
                    contact.ca_estado = "I";

                    context.SaveChanges();
                }

                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public Boolean ValidarCodigoExiste(string Cod)
        {
            try
            {
                EntitiesRoles Ent = new EntitiesRoles();

                var Existe = from q in Ent.ro_catalogo
                             where q.CodCatalogo == Cod
                             select q;
                if (Existe.ToList().Count() > 0)
                {
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
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }

        }
  
    
    }
}

