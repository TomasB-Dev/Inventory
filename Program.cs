using System;
using System.Linq.Expressions;
using System.Collections.Generic;
class Inventory
{
    static void Main(string[] args) {
        Console.WriteLine("Bienvenido al sistema de inventario.");
        Console.WriteLine("¿Que desea realizar?");
        List<string> inventory = new List<string>();
        byte opcion = 0;
        
        try { 
        
        while (opcion == 0 || opcion > 4)
        {
                WriteMenu();
                opcion = Convert.ToByte(Console.ReadLine());
            Console.Clear();
             if (opcion == 0 || opcion > 4)
                {
                    Console.WriteLine("Por favor Ingresa una opcion valida.");
                    WriteMenu();
                    opcion = Convert.ToByte(Console.ReadLine());
                }
             if (opcion == 1)
                {
                  Console.Clear();
                  Console.WriteLine("Usted a elegido cargar un producto.");
                  Cargar(inventory);
                  Console.WriteLine("Producto cargado con exito.");
                  Console.WriteLine("\nPresione cualquier tecla para continuar...");
                  Console.ReadKey(true);
                  opcion = 0;
                }
             if (opcion == 3)
                {
                    Listar(inventory);
                    
                    Console.WriteLine("\nPresione cualquier tecla para continuar...");
                    Console.ReadKey(true);
                    opcion = 0;
                }


        }
    }
        catch(FormatException){
            Console.WriteLine("Error, debes ingresar numeros.");
        }
        catch(Exception e)
        {
            Console.WriteLine("Error inesperado, la aplicacion va a cerrarse." + e);
        }
      
    }
    public static void WriteMenu()
    {
        Console.WriteLine("1- Cargar Producto. \n2- Eliminar Producto.\n3- Listar Productos.\n4- Salir.");
    }

    public static void Cargar(List<string>inventory)
    {
        string producto;
        Console.WriteLine("¿Cual es el producto que quieres agregar?");
        try
        {
            producto = Console.ReadLine();
            inventory.Add(producto);
            
        }
        catch(Exception e)
        {
            Console.WriteLine("Error inesperado" + e);
        }
       

        
    }

    public static void Listar(List<string> inventory)
    {
        foreach (string producto in inventory) {
            Console.Write(" " + producto);
        
        }

        
    }
}