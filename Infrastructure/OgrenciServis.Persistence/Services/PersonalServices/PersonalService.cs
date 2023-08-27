using Microsoft.EntityFrameworkCore;
using OgrenciServis.Business.Abstracts;
using OgrenciServis.Business.ServicesAbstract;
using OgrenciServis.Domain.Entities;
using OgrenciServis.Domain.ViewModel.Personal;
using OgrenciServis.Persistence.Contexts;
using OgrenciServis.Persistence.Repositories;

namespace OgrenciServis.Persistence.Services.PersonalServices
{
    public class PersonalService : IPersonalService
    {
        readonly private OgrenciServisDbContext _context;
        IPersonalWriteRepository _personalWriteRepository;
        IPersonalReadRepository _personalReadRepository;
        public PersonalService()
        {
            var option = new DbContextOptionsBuilder<OgrenciServisDbContext>().UseNpgsql(Configurations.ConnectionString).Options;
            var ctx = new OgrenciServisDbContext(option);
            _context = ctx;
        }

        public async Task AddPersonalAsync(VM_PersonalAdd vM_PersonalAdd)
        {
            _personalWriteRepository = new PersonalWriteRepository(_context);
            Personel prsnl = new Personel();
            prsnl.FirstName = vM_PersonalAdd.PersonalAdi;
            prsnl.LastName = vM_PersonalAdd.PersonalSoyadi;
            prsnl.BirthDate = vM_PersonalAdd.PersonalDogumTarihi;

            Adress adress = new Adress();
            adress.Id = vM_PersonalAdd.PersonalAdresId;

            prsnl.Adresses.Add(adress);

            await _personalWriteRepository.AddAsync(prsnl);
            await _context.SaveChangesAsync();
            _personalWriteRepository = null;
        }

        public IQueryable<Personel> GetAllPersonal()
        {
            _personalReadRepository = new PersonalReadRepository(_context);
            var query = _personalReadRepository.GetAll();
            return query;
            _personalReadRepository=null;
        }

        public IQueryable<Personel> GetAllPersonalById(int PersonalId)
        {
            _personalReadRepository = new PersonalReadRepository(_context);
            var query = _personalReadRepository.GetAll().Where(a => a.Id == PersonalId);
            return query;
            _personalReadRepository = null;

        }

        public Task RemovePersonelAsync(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
