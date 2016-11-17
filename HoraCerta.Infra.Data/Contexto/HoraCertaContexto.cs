using HoraCerta.Dominio.Entidades;
using System.Data.Entity;

namespace HoraCerta.Infra.Data.Contexto
{
    public class HoraCertaContexto:DbContext
    {
        public HoraCertaContexto()
            :base("HoraCerta")
        {

        }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}
