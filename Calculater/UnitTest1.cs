using Calculater;
namespace CalculaterTesting;

public class UnitTestingOperaters
{
    Operators opTest = new Operators();
    [Fact]
    public void TestPlus()
    {
        //Arrange
        double expected = 3;
        
        //Act
        double actual = opTest.Plus(1, 2);
        
        //Assert
        Assert.Equal(expected, actual);
    }
    [Fact]
    public void TestMinus()
    {
        //Arrange
        double expected = 3;
        
        //Act
        double actual = opTest.Minus(8, 5);
        
        //Assert
        Assert.Equal(expected, actual);
    }
    [Fact]
    public void TestMultiply()
    {
        //Arrange
        double expected = 6;
        
        //Act
        double actual = opTest.Multiply(3, 2);
        
        //Assert
        Assert.Equal(expected, actual);
    }
    [Fact]
    public void TestDivide()
    {
        //Arrange
        double expected = 5;
        
        //Act
        double actual = opTest.Divide(25, 5);
        
        //Assert
        Assert.Equal(expected, actual);
    }
}