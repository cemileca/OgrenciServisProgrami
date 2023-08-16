﻿using Microsoft.EntityFrameworkCore;
using OgrenciServis.Business.Abstracts;
using OgrenciServis.Domain.Entities;
using OgrenciServis.Persistence.Contexts;

namespace OgrenciServis.Persistence.Repositories
{
    public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity
    {
        readonly private OgrenciServisDbContext _context;

        public ReadRepository(OgrenciServisDbContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public  IQueryable<T> GetAll() => Table.AsNoTracking();
        
        
    }
}
