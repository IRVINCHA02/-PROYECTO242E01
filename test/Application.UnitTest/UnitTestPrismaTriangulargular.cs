namespace Application.UnitTest;

public class UnitTestPrismatriangular
{        
    [Theory]
    [InlineData(25,10 ,250 )]
    [InlineData(20, 10, 200)]
    [InlineData(12, 7, 84)]
    [InlineData(20, 8, 160)]
    [InlineData(14, 7, 98)]
    public void TestVolumen(double area, double altura, double volumen)
    {
        // Arrange – Set up

        // Act – Perform
        double resultado = Application.Prismatriangular.CalcularVolumen(area, altura);

        // Assert – Verify
        Assert.Equal(resultado, volumen);
    }
}