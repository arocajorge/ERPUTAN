using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Academico;
using Core.Erp.Info.General;
using Core.Erp.Data.General;


namespace Core.Erp.Data.Academico
{
    public class Aca_RubroGrupoFE_Data
    {
        #region "Get"
        public int GetIdRubro_Grupo_Fe()
        {
            int Id = 0;
            try
            {
                Entities_Academico Base = new Entities_Academico();
                int select = (from q in Base.Aca_Rubro_Grupo_FE
                              select q).Count();

                if (select == 0)
                {
                    Id = 1;
                }
                else
                {
                    var select_as = (from q in Base.Aca_Rubro_Grupo_FE
                                     select q.IdGrupoFE).Max();
                    Id = Convert.ToInt32(select_as.ToString()) + 1;
                }
                return Id;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                string MensajeError = string.Empty;
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                MensajeError = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                throw new Exception(ex.ToString());
            }
        }

        public List<Aca_RubroGrupoFE_Info> Get_List_Rubro_Grupo_FE()
        {
            List<Aca_RubroGrupoFE_Info> lista = new List<Aca_RubroGrupoFE_Info>();
            try
            {
                using (Entities_Academico Base = new Entities_Academico())
                {
                    var rubro = from r in Base.Aca_Rubro_Grupo_FE
                                orderby r.IdGrupoFE
                                select r;
                    foreach (var item in rubro)
                    {
                        Aca_RubroGrupoFE_Info rubroGrupoInfo = new Aca_RubroGrupoFE_Info();
                        rubroGrupoInfo.IdInstitucion = item.IdInstitucion;
                        rubroGrupoInfo.IdGrupoFE = item.IdGrupoFE;
                        rubroGrupoInfo.CodGrupoFE = item.CodGrupoFE;
                        rubroGrupoInfo.nom_GrupoFe = item.nom_GrupoFe;
                        rubroGrupoInfo.estado = item.estado;
                        rubroGrupoInfo.FechaModificacion =Convert.ToDateTime(item.FechaModificacion);
                        rubroGrupoInfo.FechaCreacion = Convert.ToDateTime(item.FechaCreacion);
                        rubroGrupoInfo.UsuarioCreacion= item.UsuarioCreacion;
                        rubroGrupoInfo.FechaAnulacion=Convert.ToDateTime(item.FechaAnulacion);
                        rubroGrupoInfo.MotivoAnulacion=item.MotivoAnulacion;
                        lista.Add(rubroGrupoInfo);
                    }
                }
                return lista;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                string MensajeError = string.Empty;
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                MensajeError = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                throw new Exception(ex.ToString());
            }
        }

        public Boolean Get_List_Rubro_Grupo_FE_Existe(Aca_RubroGrupoFE_Info Info, ref string mensaje)
        {
            try
            {
                using (Entities_Academico context = new Entities_Academico())
                {
                    var select = from q in context.Aca_Rubro_Grupo_FE
                                 where q.CodGrupoFE == Info.CodGrupoFE
                                 select q;
                    if (select.Count() > 0)
                    {
                        return false;
                    }
                    return true;
                }
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                string MensajeError = string.Empty;
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                MensajeError = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                throw new Exception(ex.ToString());
            }
        }
        #endregion

        public Boolean AnularDB(Aca_RubroGrupoFE_Info Info, ref string msg)
        {
            try
            {
                using (Entities_Academico context = new Entities_Academico())
                {
                    var address = context.Aca_Rubro_Grupo_FE.FirstOrDefault(a => a.IdGrupoFE == Info.IdGrupoFE);
                    if (address != null)
                    {
                        address.estado = "I";
                        address.UsuarioAnulacion = Info.UsuarioAnulacion;
                        address.FechaAnulacion = DateTime.Now;
                        address.MotivoAnulacion = Info.MotivoAnulacion;
                        context.SaveChanges();
                        msg = "Se ha anulado el registro: " + Info.IdGrupoFE.ToString() + " satisfactoriamente";
                    }
                    return true;
                }
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                msg = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref msg);
                msg = "Se ha producido el siguiente error: " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ActualizarDB(Aca_RubroGrupoFE_Info Info, ref string msg)
        {
            try
            {
                using (Entities_Academico contexto = new Entities_Academico())
                {
                    var rubros = contexto.Aca_Rubro_Grupo_FE.FirstOrDefault(a => a.IdGrupoFE == Info.IdGrupoFE);

                    if (rubros != null)
                    {
                        rubros.CodGrupoFE = string.IsNullOrEmpty(Info.CodGrupoFE) ? Info.IdGrupoFE.ToString() : Info.CodGrupoFE == "0" ? Info.IdGrupoFE.ToString() : Info.CodGrupoFE;
                        rubros.nom_GrupoFe = Info.nom_GrupoFe;
                        rubros.FechaModificacion = DateTime.Now;
                        rubros.UsuarioModificacion = Info.UsuarioModificacion;
                        rubros.estado = Info.estado;
                        contexto.SaveChanges();
                        msg = "Se ha modificado el registro: " + Info.IdGrupoFE.ToString() + " exitosamente";
                    }
                    return true;
                }
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                msg = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref msg);
                msg = "Se ha producido el siguiente error: " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public Boolean GrabarDB(Aca_RubroGrupoFE_Info Info, ref int IdRubroGrupo, ref string msg)
        {
            try
            {
                using (Entities_Academico Base = new Entities_Academico())
                {
                    Aca_Rubro_Grupo_FE addressRubro = new Aca_Rubro_Grupo_FE();
                    
                    IdRubroGrupo = GetIdRubro_Grupo_Fe();
                    addressRubro.IdInstitucion = Info.IdInstitucion;
                    addressRubro.IdGrupoFE = IdRubroGrupo;
                    addressRubro.CodGrupoFE = string.IsNullOrEmpty(Info.CodGrupoFE) ? IdRubroGrupo.ToString() : Info.CodGrupoFE;
                    addressRubro.nom_GrupoFe = Info.nom_GrupoFe;
                    addressRubro.estado = Info.estado;
                    addressRubro.FechaCreacion = DateTime.Now;
                    addressRubro.UsuarioCreacion = Info.UsuarioCreacion;
                    Base.Aca_Rubro_Grupo_FE.Add(addressRubro);
                    Base.SaveChanges();
                    msg = "El nuevo registro se guardo sin problema y se guargo con el número: " + IdRubroGrupo.ToString();
                    return true;
                }
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                msg = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref msg);
                msg = "Se ha producido el siguiente error: " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

    }
}
