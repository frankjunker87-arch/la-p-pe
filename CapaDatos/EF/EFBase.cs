using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Linq.Expressions;

namespace CapaDatos.EF
{
    public class EFBase<TEntidad> where TEntidad : class
    {
        public DbContext Contexto { get; set; }
        public TEntidad Agregar(TEntidad entidad)
        {
            Contexto.Set<TEntidad>().Add(entidad);
            Contexto.SaveChanges();
            return entidad;
        }

        public TEntidad Modificar(TEntidad entidad)
        {
            Contexto.Set<TEntidad>().Attach(entidad);
            Contexto.Entry(entidad).State=EntityState.Modified;
            Contexto.SaveChanges();
            return entidad;
        }

        public int Eliminar(TEntidad entidad)
        {
            Contexto.Set<TEntidad>().Attach(entidad);
            Contexto.Set<TEntidad>().Remove(entidad);
            return Contexto.SaveChanges();
        }

        public TEntidad BuscarUnico(Expression<Func<TEntidad,bool>> criterio)
        {
            return Contexto.Set<TEntidad>().SingleOrDefault(criterio);
        }

        public ICollection<TEntidad> Listar()
        {
            return Contexto.Set<TEntidad>().ToList();
        }

        public ICollection<TEntidad> Buscar(Expression<Func<TEntidad, bool>> criterio)
        {
            return Contexto.Set<TEntidad>().Where(criterio).ToList();
        }
    }
}
