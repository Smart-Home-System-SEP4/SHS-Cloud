using EfcDataAccess.DAOs;
using Microsoft.EntityFrameworkCore;

namespace TestProject1;

using Contracts;
using EfcDataAccess;
using Entities;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;
using System.Threading.Tasks;

[TestFixture]
public class HomeServiceTests
{
    private SmartHomeSystemContext _dbContext;
    private HomeDao _homeDao;

    [SetUp]
    public void Setup()
    {
        //var options = new DbContextOptionsBuilder<SmartHomeSystemContext>()
           // .UseInMemoryDatabase(databaseName: "TestDatabase")
          //  .Options;

        //_dbContext = new SmartHomeSystemContext(options);
        _homeDao = new HomeDao(_dbContext);
    }

    [Test]
    public async Task AddNewHome_Should_Add_Home_For_User()
    {
        // Arrange
        var user = new User { Id = 3, Username = "TestUser"};
        //var home = new Home { HomeId = 1, UserId = 1};

        await _dbContext.Users.AddAsync(user);
        await _dbContext.SaveChangesAsync();

        // Act
        //var addedHome = await _homeDao.AddNewHome(user.Id, home);

        // Assert
        //Assert.NotNull(addedHome);
        //Assert.AreEqual(home.Address, addedHome.Address);
        // Add more assertions as per your logic
    }
}