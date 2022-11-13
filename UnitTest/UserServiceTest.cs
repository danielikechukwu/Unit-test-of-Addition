

using UnitTesting.Controller;

namespace UnitTest;

public class UserServiceTest
{

    private UserService _userservice;
      

    [SetUp]
    public void Setup()
    { 
        _userservice = new UserService();   

    }

    [Test]
    public void Add_Works()
    {
        //Arrange


        //Act
        var result = _userservice.Add(3, 3);

        //Assert    
        Assert.That(result, Is.EqualTo(6));

    }
}