﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class MSandovalPruebaTecnicaEntities : DbContext
    {
        public MSandovalPruebaTecnicaEntities()
            : base("name=MSandovalPruebaTecnicaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Disco> Discoes { get; set; }
    
        public virtual ObjectResult<DiscoGetAll_Result> DiscoGetAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<DiscoGetAll_Result>("DiscoGetAll");
        }
    
        public virtual int DiscoAdd(string titulo, string artista, string generoMusical, Nullable<decimal> duracion, string año, string distribuidora, Nullable<int> ventas, string disponibilidad)
        {
            var tituloParameter = titulo != null ?
                new ObjectParameter("Titulo", titulo) :
                new ObjectParameter("Titulo", typeof(string));
    
            var artistaParameter = artista != null ?
                new ObjectParameter("Artista", artista) :
                new ObjectParameter("Artista", typeof(string));
    
            var generoMusicalParameter = generoMusical != null ?
                new ObjectParameter("GeneroMusical", generoMusical) :
                new ObjectParameter("GeneroMusical", typeof(string));
    
            var duracionParameter = duracion.HasValue ?
                new ObjectParameter("Duracion", duracion) :
                new ObjectParameter("Duracion", typeof(decimal));
    
            var añoParameter = año != null ?
                new ObjectParameter("Año", año) :
                new ObjectParameter("Año", typeof(string));
    
            var distribuidoraParameter = distribuidora != null ?
                new ObjectParameter("Distribuidora", distribuidora) :
                new ObjectParameter("Distribuidora", typeof(string));
    
            var ventasParameter = ventas.HasValue ?
                new ObjectParameter("Ventas", ventas) :
                new ObjectParameter("Ventas", typeof(int));
    
            var disponibilidadParameter = disponibilidad != null ?
                new ObjectParameter("Disponibilidad", disponibilidad) :
                new ObjectParameter("Disponibilidad", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DiscoAdd", tituloParameter, artistaParameter, generoMusicalParameter, duracionParameter, añoParameter, distribuidoraParameter, ventasParameter, disponibilidadParameter);
        }
    
        public virtual int DiscoDelete(Nullable<int> idDisco)
        {
            var idDiscoParameter = idDisco.HasValue ?
                new ObjectParameter("IdDisco", idDisco) :
                new ObjectParameter("IdDisco", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DiscoDelete", idDiscoParameter);
        }
    
        public virtual ObjectResult<DiscoGetById_Result> DiscoGetById(Nullable<int> idDisco)
        {
            var idDiscoParameter = idDisco.HasValue ?
                new ObjectParameter("IdDisco", idDisco) :
                new ObjectParameter("IdDisco", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<DiscoGetById_Result>("DiscoGetById", idDiscoParameter);
        }
    
        public virtual int DiscoUpdate(Nullable<int> idDisco, string titulo, string artista, string generoMusical, Nullable<decimal> duracion, string año, string distribuidora, Nullable<int> ventas, string disponibilidad)
        {
            var idDiscoParameter = idDisco.HasValue ?
                new ObjectParameter("IdDisco", idDisco) :
                new ObjectParameter("IdDisco", typeof(int));
    
            var tituloParameter = titulo != null ?
                new ObjectParameter("Titulo", titulo) :
                new ObjectParameter("Titulo", typeof(string));
    
            var artistaParameter = artista != null ?
                new ObjectParameter("Artista", artista) :
                new ObjectParameter("Artista", typeof(string));
    
            var generoMusicalParameter = generoMusical != null ?
                new ObjectParameter("GeneroMusical", generoMusical) :
                new ObjectParameter("GeneroMusical", typeof(string));
    
            var duracionParameter = duracion.HasValue ?
                new ObjectParameter("Duracion", duracion) :
                new ObjectParameter("Duracion", typeof(decimal));
    
            var añoParameter = año != null ?
                new ObjectParameter("Año", año) :
                new ObjectParameter("Año", typeof(string));
    
            var distribuidoraParameter = distribuidora != null ?
                new ObjectParameter("Distribuidora", distribuidora) :
                new ObjectParameter("Distribuidora", typeof(string));
    
            var ventasParameter = ventas.HasValue ?
                new ObjectParameter("Ventas", ventas) :
                new ObjectParameter("Ventas", typeof(int));
    
            var disponibilidadParameter = disponibilidad != null ?
                new ObjectParameter("Disponibilidad", disponibilidad) :
                new ObjectParameter("Disponibilidad", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DiscoUpdate", idDiscoParameter, tituloParameter, artistaParameter, generoMusicalParameter, duracionParameter, añoParameter, distribuidoraParameter, ventasParameter, disponibilidadParameter);
        }
    }
}