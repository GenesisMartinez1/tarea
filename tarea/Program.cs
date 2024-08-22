using System;

class Compras
{
    static void Main()
    {
        Console.WriteLine("Ingrese su nombre:");
        string Nombre = Console.ReadLine();

        Console.WriteLine("Ingrese su edad:");
        int Edad = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Elija la categoría del producto que desea comprar:");
        Console.WriteLine("1. Frutas");
        Console.WriteLine("2. Verduras");
        Console.WriteLine("3. Dulces");
        string Categoria = Console.ReadLine();


        if (Categoria == "1")
        {
            Console.WriteLine("Seleccione el producto:");
            Console.WriteLine("1. Manzana");
            Console.WriteLine("2. Plátano");
            Console.WriteLine("3. Naranja");
            Console.WriteLine("4. Fresa");
            Console.WriteLine("5. Uvas");
            string Producto = Console.ReadLine();
            if (Producto == "1")
            {
                Console.WriteLine("Ingrese la cantidad de Manzanas a comprar");
                int Cantidad = Convert.ToInt32(Console.ReadLine());
                int total = Cantidad * 15;
                Console.WriteLine($"Total {total:F2}");
            }
            else if(Producto == "2")
            {
                Console.WriteLine("Ingrese la cantidad de Plátano a comprar");
                int Cantidad = Convert.ToInt32(Console.ReadLine());
                int total = Cantidad * 12;
                Console.WriteLine($"Total {total:F2}");
            }
            else if (Producto == "3")
            {
                Console.WriteLine("Ingrese la cantidad de Naranja a comprar");
                int Cantidad = Convert.ToInt32(Console.ReadLine());
                int total = Cantidad * 7;
                Console.WriteLine($"Total {total:F2}");
            }
            else if (Producto == "4")
            {
                Console.WriteLine("Ingrese la cantidad de Fresa a comprar");
                int Cantidad = Convert.ToInt32(Console.ReadLine());
                int total = Cantidad * 6;
                Console.WriteLine($"Total {total:F2}");
            }
            else if (Producto == "4")
            {
                Console.WriteLine("Ingrese la cantidad de Uvas a comprar");
                int Cantidad = Convert.ToInt32(Console.ReadLine());
                int total = Cantidad * 4;
                Console.WriteLine($"Total {total:F2}");
            }


        }
        else if (Categoria == "2")
        {
            Console.WriteLine("Seleccione el producto:");
            Console.WriteLine("1. Zanahoria");
            Console.WriteLine("2. Brócoli");
            Console.WriteLine("3. Lechuga");
            Console.WriteLine("4. Tomate");
            Console.WriteLine("5. Pepino");
            string Producto = Console.ReadLine();
            if (Producto == "1")
            {
                Console.WriteLine("Ingrese la cantidad de Zanahoria a comprar");
                int Cantidad = Convert.ToInt32(Console.ReadLine());
                int total = Cantidad * 8;
                Console.WriteLine($"Total {total:F2}");
            }
            else if (Producto == "2")
            {
                Console.WriteLine("Ingrese la cantidad de Brócoli a comprar");
                int Cantidad = Convert.ToInt32(Console.ReadLine());
                int total = Cantidad * 21;
                Console.WriteLine($"Total {total:F2}");
            }
            else if (Producto == "3")
            {
                Console.WriteLine("Ingrese la cantidad de Lechuga a comprar");
                int Cantidad = Convert.ToInt32(Console.ReadLine());
                int total = Cantidad * 18;
                Console.WriteLine($"Total {total:F2}");
            }
            else if (Producto == "4")
            {
                Console.WriteLine("Ingrese la cantidad de Tomate a comprar");
                int Cantidad = Convert.ToInt32(Console.ReadLine());
                int total = Cantidad * 6;
                Console.WriteLine($"Total {total:F2}");
            }
            else if (Producto == "4")
            {
                Console.WriteLine("Ingrese la cantidad de Pepino a comprar");
                int Cantidad = Convert.ToInt32(Console.ReadLine());
                int total = Cantidad * 14;
                Console.WriteLine($"Total {total:F2}");
            }

        }
        else if (Categoria == "3")
        {
            Console.WriteLine("Seleccione el producto:");
            Console.WriteLine("1. Chocolates");
            Console.WriteLine("2. Caramelos");
            Console.WriteLine("3. Galletas");
            Console.WriteLine("4. Pasteles");
            Console.WriteLine("5. Chicles");
            string Producto = Console.ReadLine();
            if (Producto == "1")
            {
                Console.WriteLine("Ingrese la cantidad de Chocolates a comprar");
                int Cantidad = Convert.ToInt32(Console.ReadLine());
                int total = Cantidad * 5;
                Console.WriteLine($"Total {total:F2}");
            }
            else if (Producto == "2")
            {
                Console.WriteLine("Ingrese la cantidad de Caramelos a comprar");
                int Cantidad = Convert.ToInt32(Console.ReadLine());
                int total = Cantidad * 3;
                Console.WriteLine($"Total {total:F2}");
            }
            else if (Producto == "3")
            {
                Console.WriteLine("Ingrese la cantidad de Galletas a comprar");
                int Cantidad = Convert.ToInt32(Console.ReadLine());
                int total = Cantidad * 2;
                Console.WriteLine($"Total {total:F2}");
            }
            else if (Producto == "4")
            {
                Console.WriteLine("Ingrese la cantidad de Pasteles a comprar");
                int Cantidad = Convert.ToInt32(Console.ReadLine());
                int total = Cantidad * 150;
                Console.WriteLine($"Total {total:F2}");
            }
            else if (Producto == "4")
            {
                Console.WriteLine("Ingrese la cantidad de Chicles a comprar");
                int Cantidad = Convert.ToInt32(Console.ReadLine());
                int total = Cantidad * 8;
                Console.WriteLine($"Total {total:F2}");
            }



        }
        else
        {
            Console.WriteLine("Categoría no válida");
            return;
        }

        Console.ReadKey();
    }
}
