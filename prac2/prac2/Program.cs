/*
 * Created by SharpDevelop.
 * User: ALUMNOS
 * Date: 06/10/2014
 * Time: 04:31 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace prac2
{
	class Program
	{
		public static void Main(string[] args)
		{
			/*Aqui pide los datos del primer producto*/
                Console.WriteLine("Dame la cantidad de productos #1");
                 
                 float cantidad_prod1 = float.Parse(Console.ReadLine());
                 Console.WriteLine("Dame la descripcion del producto #1");
                 String desc_prod1;
                 desc_prod1 = Console.ReadLine();
                 Console.WriteLine("Dame el precio unitario del producto #1");
 
                 float Precio_prod1 = float.Parse(Console.ReadLine());
                  /*Aqui pide los datos del segundo producto*/
                 Console.WriteLine("Dame la cantidad de productos #2");

                 float cantidad_prod2 = float.Parse(Console.ReadLine());
                 Console.WriteLine("Dame la descripcion del producto #2");
                 String desc_prod2;
                 desc_prod2 = Console.ReadLine();
                 Console.WriteLine("Dame el precio unitario del producto #2");
 
                 float Precio_prod2 = float.Parse(Console.ReadLine());
                 /*Aqui pide los datos del tercer producto*/
                 Console.WriteLine("Dame la cantidad de productos #3");
 
                 float cantidad_prod3 = float.Parse(Console.ReadLine());
                 Console.WriteLine("Dame la descripcion del producto #3");
                 String desc_prod3;
                 desc_prod3 = Console.ReadLine();
                 Console.WriteLine("Dame el precio unitario del producto #3");
 
                 float Precio_prod3 = float.Parse(Console.ReadLine());

                 /*Aqui da la lista de los productos*/
                 Console.WriteLine("Esta es la cantidad de productos: " +" "+ cantidad_prod1 +" "+
                 cantidad_prod2 +" "+ cantidad_prod3);

                /*Aqui da la lista de los productos*/
                Console.WriteLine("Esta es la descripcion de los productos: " +" "+ desc_prod1 +" "+
                desc_prod2 +" "+ desc_prod3);

                /*Aqui da la lista de los productos*/
                Console.WriteLine("Estos son los precios de los productos: " +" "+ Precio_prod1 +" "+
                Precio_prod2 +" "+ Precio_prod3);

                float subtotal = cantidad_prod1 * Precio_prod1 + cantidad_prod2 * Precio_prod2 + cantidad_prod3 * Precio_prod3;
                Console.WriteLine("El subtotal es: " +subtotal);

                /*Aqui nos da el iva*/
                double iva = subtotal * 0.16;
                Console.WriteLine("Este es el I.V.A: " +iva);
                Console.ReadKey(true);

                /*Aqui nos da el total de la operacion*/
                double total = subtotal + iva;
                Console.WriteLine("Este es el total: " +total);
 
                Console.ReadKey(true);
		}
	}
}