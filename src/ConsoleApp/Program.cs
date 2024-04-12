double lado1 = 5;
double lado2 = 5;
double lado3 = 5;
double altura = 10;
double perimetro = Application.triangular.CalcularPerimetro(lado1, lado2, lado3);
double area = Application.triangular.CalcularArea(lado3,altura);
double volumen = Application.Prismatriangular.CalcularVolumen(area, altura);

Console.WriteLine($"El perímetro de la base de un Prisma triangular de {lado1}cm por lado {lado2}cm por lado {lado3} es {perimetro}cm");
Console.WriteLine($"El área de la base de un Prisma triangulargular de {lado3}cm por {altura} entre 2 es {area}cm2");
Console.WriteLine($"El volumen un Prisma triangular con un área de la base de {area}cm2 y {altura}cm de altura es {volumen}cm3");
