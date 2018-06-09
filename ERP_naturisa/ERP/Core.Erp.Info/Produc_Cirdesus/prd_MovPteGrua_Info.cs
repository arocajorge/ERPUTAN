using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Produc_Cirdesus
{
    public class prd_MovPteGrua_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdPuenteGrua { get; set; }
        public int IdOperador { get; set; }
        public int IdGrupoTrabajo { get; set; }
        public int IdProcesoProductivo { get; set; }
        public int IdMovimiento { get; set; }
        public string CodigoBarra { get; set; }
        public string DescripcionPieza { get; set; }
        public int IdEtapaInicio { get; set; }
        public int IdEtapaSiguiente { get; set; }

        public Nullable<int> IdSubgrupoAnt { get; set; }
        public Nullable<int> IdSubgrupoSig { get; set; }

        public string Etapa_Ant { get; set; }
        public string Etapa_Sig { get; set; }


        public Int32 ToneladasMover { get; set; }
        public string Observacion { get; set; }
        public DateTime FechaTransaccion { get; set; }
        public string IdUsuario { get; set; }
        public string IdUsuarioAnu { get; set; }
        public string MotivoAnu { get; set; }
        public string IdUsuarioUltModi { get; set; }
        public DateTime FechaAnu { get; set; }
        public DateTime FechaUltModi { get; set; }
        public string Estado { get; set; }
        //** fdatos para la visata
        public string EtapaUbucacion { get; set; }
        public string EtapaSiguiente { get; set; }
        public TimeSpan TiempoEspera { get; set; }
        public string NomPuenteGrua { get; set; }
    }
}
