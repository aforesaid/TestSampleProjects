using EFCore.BulkExtensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TestBulkExtension;

var serviceCollection = new ServiceCollection();
serviceCollection.AddDbContext<ApplicationDbContext>(x =>
    x.UseInMemoryDatabase("dbContext"));

var serviceProvider = serviceCollection.BuildServiceProvider();
var dbContext = serviceProvider.GetRequiredService<ApplicationDbContext>();
            
dbContext.SaveChanges();
