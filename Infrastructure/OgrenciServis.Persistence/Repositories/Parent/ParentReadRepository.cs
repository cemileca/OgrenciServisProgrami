﻿using OgrenciServis.Business.Abstracts;
using OgrenciServis.Domain.Entities;
using OgrenciServis.Persistence.Contexts;

namespace OgrenciServis.Persistence.Repositories
{
    public class ParentReadRepository : ReadRepository<Parent>, IParentReadRepository
    {
        public ParentReadRepository(OgrenciServisDbContext context) : base(context)
        {
        }
    }
}
