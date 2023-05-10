
// Actividad 4A

/*

Escribe una tabla de multiplicar del 1 al 10 para un número entero
que recibe por consola. Es decir, un programa que presente para el 1:

1 x 1 = 1
1 x 2 = 2
…
1 x 10 = 10

*/


Console.WriteLine("Introduzca un número entero:");
int num = Convert.ToInt32(Console.ReadLine());
int i = 0;

while (i <= 10)
{
    Console.WriteLine($"{num} x {i} ");
    i++;
}


// Actividad 4B

/*

Escribe un programa que realice estos pasos:

Reciba al menos un número por consola

Determine si el número es positivo o negativo

Presente un contador para cada tipo (positivo y negativo).

Nota: el cero se puede abordar en una clase adicional ya que no es ni
positivo ni negativo. Tienes completa libertad para elegir el formato
de la salida.

*/


int num;
int contadorPositivos = 0;
int contadorNegativos = 0;

do
{
    Console.Write("Ingrese un número: ");
    num = Convert.ToInt32(Console.ReadLine());

    if (num > 0)
    {
        contadorPositivos++;
        Console.WriteLine("{0} es positivo.", num);
    }
    else if (num < 0)
    {
        contadorNegativos++;
        Console.WriteLine("{0} es negativo.", num);
    }
    else
    {
        Console.WriteLine("El número es cero.");
    }

} while (num != 0);

Console.WriteLine("\nCantidad de números positivos: {0}",
    contadorPositivos);
Console.WriteLine("Cantidad de números negativos: {0}",
    contadorNegativos);


// Actividad 4C

/*
 
Escribe un programa que realice estos pasos:

Reciba 3 datos:

ancho

alto

relleno o no

Dibuje en consola con un mismo caracter, por ejemplo *, un rectángulo
de las dimensiones introducidas y use el tercer dato para discernir si
el rectángulo está relleno (tiene más * dentro) o no.

En caso de recibir el mismo número n dos veces debe dibujar un cuadrado
de lado n.

*/


Console.Write("Ingrese el ancho: ");
int ancho = int.Parse(Console.ReadLine());

Console.Write("Ingrese el alto: ");
int alto = int.Parse(Console.ReadLine());

Console.Write("¿Desea el rectángulo relleno? (s/n): ");
bool relleno = Console.ReadLine().ToLower() == "s";

if (ancho == alto)
{
    // Dibujar un cuadrado
    for (int i = 0; i < alto; i++)
    {
        for (int j = 0; j < ancho; j++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
}
else
{
    // Dibujar un rectángulo
    for (int i = 0; i < alto; i++)
    {
        for (int j = 0; j < ancho; j++)
        {
            if (relleno || i == 0 || j == 0 || i == alto - 1 ||
                j == ancho - 1)
            {
                Console.Write("*");
            }
            else
            {
                Console.Write(" ");
            }
        }
        Console.WriteLine();
    }
}


/* 

El programa recibe el ancho, alto y si se desea un rectángulo rellen o no
por medio de la entrada de consola. Luego, verifica si el ancho y alto
son iguales para dibujar un cuadrado o si son diferentes para dibujar un
rectángulo.

En el caso de un cuadrado, simplemente dibuja un rectángulo donde el
ancho y el alto son iguales. En el caso de un rectángulo, se verifica si
se desea un rectángulo relleno o no, y se dibuja el rectángulo con
asteriscos (*) en las posiciones necesarias.

*/

/*
 
Reto: Extiende el programa anterior para recibir otro número que sea
el número de cuadrados o rectángulos que se deben dibujar en la
pantalla. Ejemplos:

Input: 2,2,2, relleno = true

Output:

****

****

Input: 3, 4, 1, relleno = false

Output:

***

**

**

***

*/


Console.Write("Ingrese el ancho: ");
int ancho = int.Parse(Console.ReadLine());

Console.Write("Ingrese el alto: ");
int alto = int.Parse(Console.ReadLine());

Console.Write("¿Desea el rectángulo o el cuadrado rellenos? (s/n): ");
bool relleno = Console.ReadLine().ToLower() == "s";

Console.Write("Ingrese el número de cuadrados o rectángulos a dibujar: "
    );
int cantidad = int.Parse(Console.ReadLine());

for (int k = 0; k < cantidad; k++)
{
    if (ancho == alto)
    {
        // Dibujar un cuadrado
        for (int i = 0; i < alto; i++)
        {
            for (int j = 0; j < ancho; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
    else
    {
        // Dibujar un rectángulo
        for (int i = 0; i < alto; i++)
        {
            for (int j = 0; j < ancho; j++)
            {
                if (relleno || i == 0 || j == 0 || i == alto - 1 ||
                    j == ancho - 1)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }

    // Dejar una línea en blanco entre cada cuadrado o rectángulo
    Console.WriteLine();
}

/*

El programa ahora también recibe un número adicional para indicar
cuántoscuadrados o rectángulos deben ser dibujados. Luego, simplemente se
itera elnúmero de veces indicado, dibujando un cuadrado o rectángulo en
cada iteración.

Además, se deja una línea en blanco entre cada cuadrado o rectángulo para
que se vean separados en la pantalla.

*/