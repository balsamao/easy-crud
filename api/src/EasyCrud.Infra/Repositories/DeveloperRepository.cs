using EasyCrud.Domain.Entities;
using EasyCrud.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyCrud.Infra.Repositories
{
    public class DeveloperRepository : IDeveloperRepository
    {
        private readonly EasyDbContext _db;

        public DeveloperRepository(EasyDbContext db)
        {
            _db = db;
        }

        public async Task<List<Developer>> GetAll()
        {
            return await _db.Developers
                .Include(d => d.Preference)
                .Include(d => d.Skills)
                .ToListAsync();
        }

        public async Task<Developer> GetById(long id)
        {
            return await _db.Developers
                .Include(d => d.Preference)
                .Include(d => d.Skills)
                .FirstOrDefaultAsync(d => d.Id == id);
        }

        public async Task<long> Insert(Developer entity)
        {
            _db.Add(entity);
            await _db.SaveChangesAsync();
            return entity.Id;
        }

        public async Task Update(Developer obj)
        {
            var entity = await GetById(obj.Id);
            entity.ApplyEmail(obj.Email);
            entity.ApplyName(obj.Name);
            entity.ApplyPortfolio(obj.Portfolio);
            entity.ApplyHourlySalary(obj.HourlySalary);

            entity.Contact.ApplyPhone(obj.Contact.Phone);
            entity.Contact.ApplyLinkedin(obj.Contact.Linkedin);

            await _db.SaveChangesAsync();
        }

        public async Task UpdatePreference(DeveloperPreference obj)
        {
            var entity = await _db.Preferences.FindAsync(obj.Id);
            entity.ApplyWillingness(obj.Willingness);
            entity.ApplyWorkTime(obj.WorkTime);

            await _db.SaveChangesAsync();
        }

        public async Task UpdateSkills(DeveloperSkills obj)
        {
            var entity = await _db.Skills.FindAsync(obj.Id);
            entity.ApplyAditionalInformation(obj.AditionalInformation);
            entity.ApplyKnowledge(obj.Knowledge);
            entity.ApplyLinkCrud(obj.LinkCrud);

            await _db.SaveChangesAsync();
        }

        public async Task Remove(long id)
        {
            var entity = await _db.Developers.FindAsync(id);
            _db.Developers.Remove(entity);
            await _db.SaveChangesAsync();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
