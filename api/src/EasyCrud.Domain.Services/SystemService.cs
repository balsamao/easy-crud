using EasyCrud.Domain.Entities;
using EasyCrud.Infra;
using EasyCrud.Shared.DomainObjects;
using System.Linq;
using System.Threading.Tasks;

namespace EasyCrud.Domain.Services
{
    public class SystemService : ISystemService
    {
        private readonly EasyDbContext _db;

        public SystemService(EasyDbContext db)
        {
            _db = db;
        }
        public async Task Seed()
        {
            _db.Database.EnsureCreated();

            if (_db.Developers.Any())
            {
                await Task.CompletedTask;
                return;
            }

            _db.Developers.AddRange(new[]
            {
                new Developer(0, "denysoliv@gmail.com", "Denys Balsamão", "", 100.00M,
                new Contact("37333333333", "https://www.linkedin.com/in/denys-balsamao/"), new Address("Divinópolis", "Minas Gerais"),
                new DeveloperPreference(0, 0, new Willingness(true, false, false, false, false), new WorkTime(false, true, false, false, false)),
                new DeveloperSkills(0, 0, "", "https://github.com/balsamao/easy-crud.git", 
                new Knowledge(Weight.LEVEL_ZERO,Weight.LEVEL_ONE,Weight.LEVEL_TWO, Weight.LEVEL_THREE, Weight.LEVEL_FOUR, Weight.LEVEL_FIVE,
                Weight.LEVEL_ZERO,Weight.LEVEL_ONE,Weight.LEVEL_TWO, Weight.LEVEL_THREE, Weight.LEVEL_FOUR, Weight.LEVEL_FIVE,
                Weight.LEVEL_ZERO,Weight.LEVEL_ONE,Weight.LEVEL_TWO, Weight.LEVEL_THREE, Weight.LEVEL_FOUR, Weight.LEVEL_FIVE,
                Weight.LEVEL_ZERO,Weight.LEVEL_ONE,Weight.LEVEL_TWO, Weight.LEVEL_THREE, Weight.LEVEL_FOUR, Weight.LEVEL_FIVE,
                Weight.LEVEL_ZERO,Weight.LEVEL_ONE,Weight.LEVEL_TWO, Weight.LEVEL_THREE, Weight.LEVEL_FOUR, Weight.LEVEL_FIVE,
                Weight.LEVEL_ZERO,Weight.LEVEL_ONE,Weight.LEVEL_TWO, Weight.LEVEL_THREE, Weight.LEVEL_FOUR, Weight.LEVEL_FIVE)))
            });

            await _db.SaveChangesAsync();
        }
    }
}
