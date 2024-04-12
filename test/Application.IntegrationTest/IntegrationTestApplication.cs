namespace Application.IntegrationTest;

public class IntegrationTestApplication
{
    [Theory]
    [InlineData(5, 10, 250)]
    [InlineData(4, 10, 200)]
    [InlineData(12, 7, 294)]
    [InlineData(20, 8, 640)]
    [InlineData(14, 7, 343)]
    public void TestVolumen(double lado3, double altura, double volumen)
    {
        // Arrange – Set up            
        double area = Application.triangular.CalcularArea(lado3, altura); 

        // Act – Perform
        double resultado = Application.Prismatriangular.CalcularVolumen(area, altura);

        // Assert – Verify
        Assert.Equal(resultado, volumen);
    }
}