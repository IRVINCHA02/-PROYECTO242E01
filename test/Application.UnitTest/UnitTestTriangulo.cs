namespace Application.UnitTest;

public class UnitTestTriangulo
{
    [Theory]
    [InlineData(5, 5, 5, 15)]
    [InlineData(4, 4, 4, 12)]
    [InlineData(6, 2, 9, 17)]
    [InlineData(17, 25, 38, 80)]
    [InlineData(45, 66, 90, 201)]
    public void TestPerimetro(double lado1, double lado2, double lado3, double perimetro)
    {
        // Arrange – Set up

        // Act – Perform
        double resultado = Application.triangular.CalcularPerimetro(lado1, lado2, lado3); 

        // Assert – Verify
        Assert.Equal(resultado, perimetro);
    }

    [Theory]
    [InlineData(5, 10, 25)]
    [InlineData(4, 10, 20)]
    [InlineData(7, 10, 35)]
    [InlineData(6, 10, 30)]
    [InlineData(10, 10, 50)]
    public void TestArea(double lado3, double altura, double area)
    {
        // Arrange – Set up

        // Act – Perform
        double resultado = Application.triangular.CalcularArea(lado3,altura); 

        // Assert – Verify
        Assert.Equal(resultado, area);
    }        
}