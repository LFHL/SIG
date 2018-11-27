using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SIG.CORE.Comun.Dominio.Entidades.Base
{
    public enum TipoModificacion
    {
        alta,
        baja,
        modicacion
    }

    internal abstract class EntidadAuditable : EntidadBase
    {

        public DateTime FechaCreacion { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public TipoModificacion Modificacion { get; set; }

        internal bool EsEliminado
        {
            get
            {
                return Modificacion == TipoModificacion.baja;
            }
        }

        public virtual void PrepararParaGuardar( TipoModificacion estado )
        {
            var identityName = Thread.CurrentPrincipal.Identity.Name;
            var now = DateTime.UtcNow;

            if (estado == TipoModificacion.alta)
            {
                UsuarioCreacion = identityName ?? "unknown";
                FechaCreacion = now;
                GuidRegistro = Guid.NewGuid();
            }

            UsuarioModificacion = identityName ?? "unknown";
            FechaModificacion = now;
        }


    }
}
