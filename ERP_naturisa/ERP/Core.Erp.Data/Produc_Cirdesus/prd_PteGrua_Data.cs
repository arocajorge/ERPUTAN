using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.Produc_Cirdesus
{
    public class prd_PteGrua_Data
    {
        string mensaje = "";
        public int getId(int idempresa, int idsucursal)
        {
            try
            {
                Int32 Id;
                EntitiesProduccion_Cidersus OEProduccion = new EntitiesProduccion_Cidersus();
                var select = from q in OEProduccion.prd_PteGrua 
                             where q.IdEmpresa == idempresa && q.IdSucursal == idsucursal
                             select q;

                if (select.ToList().Count < 1)
                {
                    Id = 1;
                }
                else
                {
                    var select_pv = (from q in OEProduccion.prd_PteGrua
                                     where q.IdEmpresa == idempresa && q.IdSucursal == idsucursal
                                     select q.IdPteGrua).Max();
                    Id = Convert.ToInt32 (select_pv.ToString()) + 1;
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
        public Boolean GuardarDB(prd_PuenteGruaMovimiento Info, ref int idptegrua ,ref string msg)
        {
            try
            {
               // List<prd_PteGrua_Info> Lst = new List<prd_PteGrua_Info>();
                using (EntitiesProduccion_Cidersus Context = new EntitiesProduccion_Cidersus())
                {
                   // var contact = prd_PteGrua.Createprd_PteGrua(0,0,0,"","",DateTime.Now,"");
                    prd_PteGrua Address = new prd_PteGrua();

                    idptegrua = getId(Info.IdEmpresa, Info.IdSucursal);
                    Address.IdEmpresa = Info.IdEmpresa;
                    Address.IdSucursal = Info.IdSucursal;
                    Address.IdPteGrua = idptegrua;
                    Info.IdPteGrua = idptegrua;
                   // Address.Descripcion = Info.Descripcion;
                    Address.Observacion = Info.Observacion;
                    //Address.IdUsuario = Info.idu;
                    //Address.IdUsuarioAnu = Info.IdUsuarioAnu;
                    //Address.MotivoAnu = Info.MotivoAnu;
                    //Address.IdUsuarioUltModi = Info.IdUsuarioUltModi;
                    //Address.FechaAnu = Info.FechaAnu;
                    //Address.FechaTransac = Info.FechaTransac;
                    //Address.FechaUltModi = Info.FechaUltModi;
                    Address.Estado = Info.Estado;

                    //contact = Address;
                    Context.prd_PteGrua.Add(Address);
                    Context.SaveChanges();
                }
                msg = "Grabación exitosa...";
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

        public List<prd_PuenteGruaMovimiento> ConsultaGeneral(int idempresa, int idsucursal, ref string msg)
        {
            try
            {
                List<prd_PuenteGruaMovimiento> Lst = new List<prd_PuenteGruaMovimiento>();
                EntitiesProduccion_Cidersus oEnti = new EntitiesProduccion_Cidersus();
                var Query = from q in oEnti.prd_PteGrua
                            where q.IdEmpresa == idempresa 
                            && q.IdSucursal == idsucursal 
                            select q;
                foreach (var item in Query)
                {
                    prd_PuenteGruaMovimiento Obj = new prd_PuenteGruaMovimiento();
                    Obj.IdEmpresa = item.IdEmpresa;
                    Obj.IdSucursal = item.IdSucursal;
                    Obj.IdPteGrua = item.IdPteGrua;
                  //  Obj.Descripcion = item.Descripcion;
                    Obj.Observacion = item.Observacion;
                    //Obj.IdUsuario = item.IdUsuario;
                    //Obj.IdUsuarioAnu = item.IdUsuarioAnu;
                    //Obj.MotivoAnu = item.MotivoAnu;
                    //Obj.IdUsuarioUltModi = item.IdUsuarioUltModi;
                    //Obj.FechaAnu = Convert.ToDateTime(item.FechaAnu);
                    //Obj.FechaTransac = item.FechaTransac;
                    //Obj.FechaUltModi = Convert.ToDateTime(item.FechaUltModi);
                    Obj.Estado = item.Estado;
                    Lst.Add(Obj);
                }
                msg = "Busqueda exitosa...";
                return Lst;
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

        
	    public prd_PuenteGruaMovimiento ObtenerObjeto(int IdEmpresa,int IdSucursal,int IdPteGrua, ref string msg)
	    {
			    EntitiesProduccion_Cidersus  oEnti= new EntitiesProduccion_Cidersus();
		    try
		    {
			    prd_PuenteGruaMovimiento Info = new prd_PuenteGruaMovimiento() ;
			    var Objeto = oEnti.prd_PteGrua.FirstOrDefault(var => var.IdEmpresa== IdEmpresa && var.IdSucursal == IdSucursal && var.IdPteGrua == IdPteGrua);
                if (Objeto != null)
                {
                    Info.IdEmpresa = Objeto.IdEmpresa;
                    Info.IdSucursal = Objeto.IdSucursal;
                    Info.IdPteGrua = Objeto.IdPteGrua;
                    //Info.Descripcion= Objeto.Descripcion;
                    Info.Observacion = Objeto.Observacion;
                    //Info.IdUsuario= Objeto.IdUsuario;
                    //Info.IdUsuarioAnu= Objeto.IdUsuarioAnu;
                    //Info.MotivoAnu= Objeto.MotivoAnu;
                    //Info.IdUsuarioUltModi= Objeto.IdUsuarioUltModi;
                    //Info.FechaAnu=Convert.ToDateTime(Objeto.FechaAnu);
                    //Info.FechaTransac= Objeto.FechaTransac;
                    //Info.FechaUltModi=Convert.ToDateTime(Objeto.FechaUltModi);
                    Info.Estado = Objeto.Estado;

                    msg = "Busqueda exitosa...";
                }
			    return Info;
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
    }
}
