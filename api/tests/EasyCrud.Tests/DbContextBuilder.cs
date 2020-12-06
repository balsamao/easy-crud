using EasyCrud.Infra;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;

namespace EasyCrud.Tests
{
    public class DbContextBuilder
    {
        public static EasyDbContext Make(IServiceProvider provider)
        {
            var options = new DbContextOptionsBuilder<EasyDbContext>()
                    .UseInMemoryDatabase(Guid.NewGuid().ToString())
                    .UseInternalServiceProvider(provider)
                    .ConfigureWarnings(x => x.Ignore(InMemoryEventId.TransactionIgnoredWarning))
                    .Options;

            var db = new EasyDbContext(options);

            db.Database.EnsureCreated();

            db.Developers.Add(DeveloperFake.New().Build());

            db.SaveChanges();

            return db;
        }
    }
}
