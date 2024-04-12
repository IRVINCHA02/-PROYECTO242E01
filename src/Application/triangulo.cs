namespace Application;

public class triangular
{
    public static double CalcularPerimetro(double lado1, double lado2, double lado3)
    {
        double perimetro = lado1 + lado2 + lado3;
        return perimetro;
    }
    public static double CalcularArea(double lado3, double altura)
    {
        double area = (lado3 * altura)/2;
        return area;
    }
}