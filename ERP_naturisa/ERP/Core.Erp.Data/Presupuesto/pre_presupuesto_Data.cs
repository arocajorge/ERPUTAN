using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using Core.Erp.Info.Presupuesto;
using Core.Erp.Info.General;
using Core.Erp.Data.General;


namespace Core.Erp.Data.Presupuesto
{
    public class pre_presupuesto_Data
    {
        string mensaje = "";
        public List<pre_presupuesto_Info> Get_List_pre_presupuesto(int IdEmpresa, string IdAnio, decimal IdPresupuesto)
        {
            try
            {
                List<pre_presupuesto_Info> lista = new List<pre_presupuesto_Info>();
                EntitiesPresupuesto pre = new EntitiesPresupuesto();
                var select = from q in pre.pre_presupuesto where q.IdEmpresa==IdEmpresa &&q.IdPresupuesto==IdPresupuesto && q.IdAnio==IdAnio select q;
                foreach (var item in select)
                {
                    pre_presupuesto_Info Obj = new pre_presupuesto_Info();
                    Obj.IdEmpresa = item.IdEmpresa;
                    Obj.IdPresupuesto = item.IdPresupuesto;
                    Obj.IdAnio = item.IdAnio;
                    Obj.Secuencia = item.Secuencia;
                    Obj.CodigoPresupuesto = item.CodigoPresupuesto;
                    Obj.IdCtaCble = item.IdCtaCble;
                    Obj.IdCentroCosto = item.IdCentroCosto;
                    Obj.IdTipoRubro = item.IdTipoRubro;
                    Obj.CodRubro = item.CodRubro;
                    Obj.NombreRubro = item.NombreRubro;
                    Obj.Enero = item.Enero;
                    Obj.febrero = item.febrero;
                    Obj.Marzo = item.Marzo;
                    Obj.Abril = item.Abril;
                    Obj.Mayo = item.Mayo;
                    Obj.Junio = item.Junio;
                    Obj.Julio = item.Julio;
                    Obj.Agosto = item.Agosto;
                    Obj.Septiembre = item.Septiembre;
                    Obj.Octubre = item.Octubre;
                    Obj.Noviembre = item.Noviembre;
                    Obj.Diciembre = item.Diciembre;
                    Obj.Total = item.Total;
                    lista.Add(Obj);
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

        public List<pre_presupuesto_Info> Get_List_pre_presupuesto(int IdEmpresa)
        {
            try
            {
                List<pre_presupuesto_Info> lista = new List<pre_presupuesto_Info>();
                EntitiesPresupuesto pre = new EntitiesPresupuesto();
                var select = from q in pre.pre_presupuesto where q.IdEmpresa == IdEmpresa select q;
                foreach (var item in select)
                {
                    pre_presupuesto_Info Obj = new pre_presupuesto_Info();
                    Obj.IdEmpresa = item.IdEmpresa;
                    Obj.IdPresupuesto = item.IdPresupuesto;
                    Obj.IdAnio = item.IdAnio;
                    Obj.Secuencia = item.Secuencia;
                    Obj.CodigoPresupuesto = item.CodigoPresupuesto;
                    Obj.IdCtaCble = item.IdCtaCble;
                    Obj.IdCentroCosto = item.IdCentroCosto;
                    Obj.IdTipoRubro = item.IdTipoRubro;
                    Obj.CodRubro = item.CodRubro;
                    Obj.NombreRubro = item.NombreRubro;
                    Obj.Enero = item.Enero;
                    Obj.febrero = item.febrero;
                    Obj.Marzo = item.Marzo;
                    Obj.Abril = item.Abril;
                    Obj.Mayo = item.Mayo;
                    Obj.Junio = item.Junio;
                    Obj.Julio = item.Julio;
                    Obj.Agosto = item.Agosto;
                    Obj.Septiembre = item.Septiembre;
                    Obj.Octubre = item.Octubre;
                    Obj.Noviembre = item.Noviembre;
                    Obj.Diciembre = item.Diciembre;
                    Obj.Total = item.Total;

                    lista.Add(Obj);
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

        public List<pre_presupuesto_Info> Get_List_pre_presupuesto_x_cta(int IdEmpresa, string IdAnio, decimal IdPresupuesto)
        {
            try
            {
                List<pre_presupuesto_Info> lista = new List<pre_presupuesto_Info>();
                EntitiesPresupuesto pre = new EntitiesPresupuesto();
                EntitiesDBConta cont = new EntitiesDBConta();
                var select = from q in pre.pre_presupuesto
                             where q.IdEmpresa == IdEmpresa
                             && q.IdAnio == IdAnio && q.IdPresupuesto==IdPresupuesto
                             select q;

                var selectplan = from q in cont.vwct_Plancta_UltimoNivel
                             where q.IdEmpresa == IdEmpresa
                             select q;

                //var select = pre.Database.SqlQuery<pre_prueba>("select * from vwPre_PresupuestoxCta where idempresa= " + IdEmpresa+"and ").ToList();

                #region for select
                foreach (var item in select)
                {
                    pre_presupuesto_Info Obj = new pre_presupuesto_Info();
                    Obj.IdEmpresa = Convert.ToInt32(item.IdEmpresa);
                    Obj.IdPresupuesto = Convert.ToDecimal(item.IdPresupuesto);
                    Obj.IdAnio = Convert.ToString(item.IdAnio);
                    Obj.Secuencia = Convert.ToInt32(item.Secuencia);
                    Obj.CodigoPresupuesto = Convert.ToString(item.CodigoPresupuesto);
                    Obj.IdCtaCble = Convert.ToString(item.IdCtaCble);
                    Obj.IdCentroCosto = Convert.ToString(item.IdCentroCosto);
                    Obj.IdTipoRubro = Convert.ToString(item.IdTipoRubro);
                    Obj.CodRubro = Convert.ToString(item.CodRubro);
                    Obj.NombreRubro = Convert.ToString(item.NombreRubro);
                    Obj.Enero = Convert.ToDouble(item.Enero);
                    Obj.febrero = Convert.ToDouble(item.febrero);
                    Obj.Marzo = Convert.ToDouble(item.Marzo);
                    Obj.Abril = Convert.ToDouble(item.Abril);
                    Obj.Mayo = Convert.ToDouble(item.Mayo);
                    Obj.Junio = Convert.ToDouble(item.Junio);
                    Obj.Julio = Convert.ToDouble(item.Julio);
                    Obj.Agosto = Convert.ToDouble(item.Agosto);
                    Obj.Septiembre = Convert.ToDouble(item.Septiembre);
                    Obj.Octubre = Convert.ToDouble(item.Octubre);
                    Obj.Noviembre = Convert.ToDouble(item.Noviembre);
                    Obj.Diciembre = Convert.ToDouble(item.Diciembre);
                    Obj.Total = Convert.ToDouble(item.Total);
                    lista.Add(Obj);
                }
                #endregion
                foreach (var item in selectplan)
                {
                    pre_presupuesto_Info Obj = new pre_presupuesto_Info();
                    if (lista.Where(x => x.IdCtaCble == item.IdCtaCble).Count()==0) {
                        Obj.IdEmpresa = Convert.ToInt32(item.IdEmpresa);
                        Obj.IdCtaCble = Convert.ToString(item.IdCtaCble);
                        Obj.IdPresupuesto = IdPresupuesto;
                        Obj.IdAnio = IdAnio;
                      //  Obj.IdCentroCosto = "101007";
                        Obj.IdTipoRubro = "SINTIPO";
                        lista.Add(Obj);
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

        public List<pre_presupuesto_Info> Get_List_pre_presupuest(int IdEmpresa, string IdAnio)
        {
            try
            {
                List<pre_presupuesto_Info> lista = new List<pre_presupuesto_Info>();
                EntitiesPresupuesto pre = new EntitiesPresupuesto();
                
                var select = from q in pre.pre_presupuesto where q.IdEmpresa==IdEmpresa &&q.IdAnio==IdAnio
                             group q by new {q.IdEmpresa, q.IdAnio,q.IdPresupuesto } into g
                             select new { g.Key }; ;
                foreach (var item in select)
                {
                    pre_presupuesto_Info Obj = new pre_presupuesto_Info();
                    Obj.IdEmpresa = item.Key.IdEmpresa;
                    Obj.IdPresupuesto = item.Key.IdPresupuesto;
                    Obj.IdAnio = item.Key.IdAnio;
                    lista.Add(Obj);
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

        public int getSecuencia(int IdEmpresa, string IdAnio, decimal IdPresupuesto)
        {
            try
            {
                List<pre_presupuesto_Info> lista = new List<pre_presupuesto_Info>();
                EntitiesPresupuesto pre = new EntitiesPresupuesto();
                //var select = (from q in pre.pre_presupuesto select q);
                int select;
               var sel= (from q in pre.pre_presupuesto
                             where q.IdEmpresa == IdEmpresa && q.IdPresupuesto==IdPresupuesto 
                             && q.IdAnio==IdAnio select q);

                if (sel.ToList().Count==0)
                    select= 1;
                else
                {
                     select = (from q in pre.pre_presupuesto
                                  where q.IdEmpresa == IdEmpresa && q.IdPresupuesto == IdPresupuesto
                                  && q.IdAnio == IdAnio
                                  select q.Secuencia).Max() + 1;
                }
                
                return select;
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

        public Boolean ModificarDB(int IdEmpresa,List<pre_presupuesto_Info> lista) {
            try
            {
                /////////////////////////////////////////////////////////////////////////
                        EntitiesPresupuesto pre = new EntitiesPresupuesto();
                        var listaux = from q in pre.pre_presupuesto
                                     where q.IdEmpresa == IdEmpresa
                                     select q;
                        //if (listaux.Count() != 0)
                        //{
                            lista.ForEach(x => x.IdAnio = x.IdAnio.Trim());
                            try
                            {
                                foreach (var item in lista)
                                {
                                    using (EntitiesPresupuesto context = new EntitiesPresupuesto())
                                    {

                                        if ((from w in listaux.ToList()
                                             where w.IdEmpresa == item.IdEmpresa && w.IdPresupuesto == item.IdPresupuesto && w.IdAnio == item.IdAnio && w.Secuencia == item.Secuencia
                                             select w).Count() == 0)
                                        {
                                          
                                            var Obj = new pre_presupuesto();
                                            Obj.IdEmpresa = item.IdEmpresa;
                                            Obj.IdPresupuesto = item.IdPresupuesto;
                                            Obj.IdAnio = item.IdAnio;
                                            if (item.Secuencia == 0)
                                            {
                                                Obj.Secuencia = getSecuencia(IdEmpresa, item.IdAnio, item.IdPresupuesto);
                                            }
                                            else { Obj.Secuencia = item.Secuencia; }
                                            Obj.CodigoPresupuesto = item.CodigoPresupuesto;
                                            Obj.IdCtaCble = item.IdCtaCble;
                                            Obj.IdCentroCosto = (item.IdCentroCosto == "") ? null : item.IdCentroCosto;
                                            Obj.IdTipoRubro = item.IdTipoRubro;
                                            Obj.CodRubro = item.CodRubro;
                                            Obj.NombreRubro = item.NombreRubro;
                                            Obj.Enero = item.Enero;
                                            Obj.febrero = item.febrero;
                                            Obj.Marzo = item.Marzo;
                                            Obj.Abril = item.Abril;
                                            Obj.Mayo = item.Mayo;
                                            Obj.Junio = item.Junio;
                                            Obj.Julio = item.Julio;
                                            Obj.Agosto = item.Agosto;
                                            Obj.Septiembre = item.Septiembre;
                                            Obj.Octubre = item.Octubre;
                                            Obj.Noviembre = item.Noviembre;
                                            Obj.Diciembre = item.Diciembre;
                                            Obj.Total = item.Total;
                                            context.pre_presupuesto.Add(Obj);
                                            try
                                            {
                                                context.SaveChanges();
                                            }
                                            catch (Exception ex) {
                                                string arreglo = ToString();
                                                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                                                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                                                    "", "", "", "", DateTime.Now);
                                                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                                                mensaje = ex.ToString() + " " + ex.Message;
                                            
                                            }
                                        }

                                    }
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
                                return false;
                            }




                            using (EntitiesPresupuesto context = new EntitiesPresupuesto())
                            {
                                foreach (var item in lista)
                                {
                                    if (((from w in listaux.ToList()
                                          where w.IdEmpresa == item.IdEmpresa && w.IdPresupuesto == item.IdPresupuesto && w.IdAnio == item.IdAnio && w.Secuencia == item.Secuencia
                                          select w).Count()) > 0)
                                    {
                                        var Obj = context.pre_presupuesto.First(x => x.IdEmpresa == IdEmpresa && x.IdPresupuesto == item.IdPresupuesto && x.IdAnio == item.IdAnio && x.Secuencia == item.Secuencia);
                                        Obj.CodigoPresupuesto = item.CodigoPresupuesto;
                                        Obj.IdCtaCble = item.IdCtaCble;
                                        Obj.IdCentroCosto = item.IdCentroCosto;
                                        Obj.IdTipoRubro = item.IdTipoRubro;
                                        Obj.CodRubro = item.CodRubro;
                                        Obj.NombreRubro = item.NombreRubro;
                                        Obj.Enero = item.Enero;
                                        Obj.febrero = item.febrero;
                                        Obj.Marzo = item.Marzo;
                                        Obj.Abril = item.Abril;
                                        Obj.Mayo = item.Mayo;
                                        Obj.Junio = item.Junio;
                                        Obj.Julio = item.Julio;
                                        Obj.Agosto = item.Agosto;
                                        Obj.Septiembre = item.Septiembre;
                                        Obj.Octubre = item.Octubre;
                                        Obj.Noviembre = item.Noviembre;
                                        Obj.Diciembre = item.Diciembre;
                                        Obj.Total = item.Total;
                                        context.SaveChanges();
                                    }
                                }
                            }
                     //   }
                //veroo el if
                        //else
                        //{
                        //    Guardar(IdEmpresa, lista);
                        //}
                ////////////////////////////////////////////////////////////////////////
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
        
        public Boolean GuardarDB(int IdEmpresa, List<pre_presupuesto_Info> lista)
        {
            try
            {
                EntitiesPresupuesto pre = new EntitiesPresupuesto();
                var listaux = from q in pre.pre_presupuesto
                              where q.IdEmpresa == IdEmpresa
                              select q;
                lista.ForEach(x => x.IdAnio = x.IdAnio.Trim());
                    foreach (var item in lista)
                    {
                        using (EntitiesPresupuesto context = new EntitiesPresupuesto())
                        {
                            if ((from w in listaux.ToList()
                                 where w.IdEmpresa == item.IdEmpresa && w.IdPresupuesto == item.IdPresupuesto && w.IdAnio == item.IdAnio && w.IdTipoRubro == item.IdTipoRubro
                                 select w).Count() == 0)
                            {
                               
                                var Obj = new pre_presupuesto();
                                Obj.IdEmpresa = IdEmpresa;
                                Obj.IdPresupuesto = item.IdPresupuesto;
                                Obj.IdAnio = item.IdAnio;
                                if (item.Secuencia == 0)
                                {
                                    Obj.Secuencia = getSecuencia(IdEmpresa, item.IdAnio, item.IdPresupuesto);
                                }
                                else { Obj.Secuencia = item.Secuencia; }
                                Obj.CodigoPresupuesto = Convert.ToString(item.IdPresupuesto)+"-"+item.IdCtaCble+"-"+item.IdCentroCosto+"-"+item.IdTipoRubro;
                                Obj.IdCtaCble = item.IdCtaCble;
                                Obj.IdCentroCosto = item.IdCentroCosto;
                                Obj.IdTipoRubro = item.IdTipoRubro;
                                Obj.CodRubro = item.CodRubro;
                                Obj.NombreRubro = Convert.ToString(item.NombreRubro.Trim());
                                Obj.Enero = item.Enero;
                                Obj.febrero = item.febrero;
                                Obj.Marzo = item.Marzo;
                                Obj.Abril = item.Abril;
                                Obj.Mayo = item.Mayo;
                                Obj.Junio = item.Junio;
                                Obj.Julio = item.Julio;
                                Obj.Agosto = item.Agosto;
                                Obj.Septiembre = item.Septiembre;
                                Obj.Octubre = item.Octubre;
                                Obj.Noviembre = item.Noviembre;
                                Obj.Diciembre = item.Diciembre;
                                Obj.Total = item.Total;
                                context.pre_presupuesto.Add(Obj);
                                try
                                {
                                    context.SaveChanges();
                                }
                                catch (Exception ex) {
                                    string arreglo = ToString();
                                    tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                                    tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                                    oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                                    mensaje = ex.ToString() + " " + ex.Message;
                                }
                            }
                            else { return false; }
                        }
                    }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",  "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }
    }
}
