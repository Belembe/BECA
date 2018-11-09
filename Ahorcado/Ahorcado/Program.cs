using System;

namespace Ahorcado
{
    class Ahorcadito
    {
        //static void Main()
        //{
        //    string[,] matriz = new string[8, 6];
        //    string palabra = "null";
        //    bool jugar = true;
        //    int intentos = 0;
        //    string letra = " ";
        //    char Letrachar = ' ';
        //    string volverjugar = " ";
        //    int Gano = 0;
        //    int contador = 0; // para saber si la letra que se escrivio si estaba en la palabra
        //    while (jugar == true)
        //    {
        //        palabra = escojerPalabra(palabra);
        //        char[] palabravector = palabra.ToCharArray();
        //        char[] espaciosEnBlanco = new char[palabra.Length];
        //        for (int i = 0; i < palabra.Length; i++) espaciosEnBlanco[i] = '_';
        //        Gano = 0;
        //        while (intentos <= 6)
        //        {
        //            bool letraMayorQueUno = true; // para saber si la letra ingresadda fue solo una y si se puede convertir en char
        //            tablero(matriz, intentos);
        //            MostrarMatriz(matriz);
        //            Console.WriteLine();
        //            MostrarEpaciosEnBlanco(espaciosEnBlanco);
        //            Console.WriteLine();
        //            while (letraMayorQueUno == true)
        //            {
        //                Console.Write("dijite la letra: ");
        //                letra = Console.ReadLine();
        //                if (letra.Length == 1)
        //                {
        //                    Letrachar = Convert.ToChar(letra);
        //                    letraMayorQueUno = false;
        //                }
        //            }

        //            for (int i = 0; i < espaciosEnBlanco.Length; i++)
        //            {
        //                if (Letrachar == espaciosEnBlanco[i])
        //                {
        //                    Console.WriteLine("esa letra ya estaba escrivir otra");
        //                    Console.ReadKey();
        //                    contador++;
        //                }
        //                else
        //                {
        //                    if (Letrachar == palabravector[i])
        //                    {
        //                        espaciosEnBlanco[i] = Letrachar;
        //                        contador++;
        //                        Gano++;
        //                    }
        //                }
        //            }
        //            if (contador == 0)
        //            {
        //                intentos++;
        //            }
        //            if (Gano == palabra.Length) break;
        //            else contador = 0;
        //        }
        //        if (Gano == palabra.Length)
        //        {
        //            tablero(matriz, intentos);
        //            MostrarMatriz(matriz);
        //            Console.WriteLine();
        //            MostrarEpaciosEnBlanco(espaciosEnBlanco);
        //            Console.WriteLine();
        //            Console.WriteLine("Si la palabra era {0} ganaste!! quieres volver a jugar : S / N", palabra);
        //            volverjugar = Console.ReadLine();
        //            if (volverjugar == "n") jugar = false;
        //            else intentos = 0;

        //        }
        //        else
        //        {
        //            Console.WriteLine("se te acabaron los intentos la palabra era {0} quieres juegar de nuevo : S /  N", palabra);
        //            volverjugar = Console.ReadLine();
        //            if (volverjugar == "n") jugar = false;

        //            else intentos = 0;
        //        }

        //    }
        //}
        //static void MostrarEpaciosEnBlanco(char[] Espacios)
        //{
        //    for (int i = 0; i < Espacios.Length; i++)
        //    {
        //        Console.Write(Espacios[i] + " ");
        //    }
        //}
        //static string[,] tablero(string[,] matriz, int intentos)
        //{
        //    Console.Clear();
        //    for (int i = 0; i < matriz.GetLength(0); i++)
        //    {
        //        for (int k = 0; k < matriz.GetLength(1); k++)
        //        {
        //            matriz[i, k] = " ";
        //        }
        //    }
        //    for (int i = 0; i < 6; i++) matriz[0, i] = "_";
        //    for (int k = 1; k < 7; k++) matriz[k, 1] = "|";
        //    for (int j = 0; j < 6; j++) matriz[7, j] = "_";
        //    if (intentos >= 1) matriz[3, 4] = "O";
        //    if (intentos >= 2) matriz[4, 4] = "|";
        //    if (intentos >= 3) matriz[5, 3] = "/";
        //    if (intentos >= 4) matriz[5, 5] = "l";
        //    if (intentos >= 5) matriz[4, 3] = "-";
        //    if (intentos >= 6) matriz[4, 5] = "-";
        //    matriz[1, 4] = "|";
        //    matriz[2, 4] = "|";
        //    return matriz;
        //}
        //static void MostrarMatriz(string[,] matriz)
        //{
        //    int pasarcolumnna = 0;
        //    int pasarfila = 0;
        //    while (pasarfila <= 7)
        //    {
        //        while (pasarcolumnna <= 5)
        //        {
        //            Console.Write(matriz[pasarfila, pasarcolumnna]);
        //            pasarcolumnna++;
        //            if (pasarcolumnna > 5) Console.WriteLine();
        //        }
        //        pasarcolumnna = 0;
        //        pasarfila++;
        //    }

        //}
        //static string escojerPalabra(string palabra)
        //{
        //    string[] palabras = new string[16] { "camion", "computador", "leche", "vino", "vaca", "mula", "lis", "quiero", "hermoza", "novia", "tarro", "perro", "uva", "internet", "codigo", "programacion" };
        //    Random nroaleatorio = new Random();
        //    palabra = palabras[nroaleatorio.Next(10)];
        //    return palabra;
        //}

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public static void Main(string[] args)
        {
            string[] ahorcado = new string[6];
            string[] palabra = new string[7];

            ahorcado[0] = " \\";
            ahorcado[1] = "/";
            ahorcado[2] = "\\";
            ahorcado[3] = "/";
            ahorcado[4] = "|";
            ahorcado[5] = "\n O"; // el simbolo \n provoca un salto de línea

            Console.WriteLine(ahorcado[5]);
            Console.Write(ahorcado[3]);
            Console.Write(ahorcado[4]);
            Console.WriteLine(ahorcado[2]);
            Console.Write(ahorcado[1]);
            Console.WriteLine(ahorcado[0]);

            palabra[0] = "canada";
            palabra[1] = "francia";
            palabra[2] = "alemania";
            palabra[3] = "italia";
            palabra[4] = "japon";
            palabra[5] = "estados unidos de america";
            palabra[6] = "reino unido";

            Console.WriteLine("\nLa lista de palabras corresponde a los países que conforman el G8");

            Console.WriteLine("\nINSTRUCCIONES");
            Console.WriteLine("1. No usar mayúsculas");
            Console.WriteLine("2. No usar números");
            Console.WriteLine("3. No usar mas de dos caracteres");
            Console.WriteLine("FIN INSTRUCCIONES");

            Console.WriteLine("");

            Random r1 = new Random();

            int al = r1.Next(1, 7);

            string p2 = palabra[al]; // palabra escogida

            string p2Aux = ""; // nos servira para esconder la palabra(es un modo de concatenación)

            for (int i = 0; i <= p2.Length - 1; i++)
            {

                if (p2.Substring(i, 1) != " ")
                {

                    p2Aux = p2Aux + "*";
                }
                else
                {

                    p2Aux = p2Aux + " ";
                }
            }

            Console.WriteLine(p2Aux);

            Console.WriteLine("");

            int intento = 0;

            string lt = ""; string ltAux = "";

            bool exito;
            bool win; // retorna un valor verdadero si la palabra es la correcta
            do
            {

                exito = false;
                win = false;
                Console.Write("\nLetra o Palabra: ");
                lt = Console.ReadLine();
                for (int i = 0; i <= p2.Length - 1; i++)
                {

                    ltAux = p2.Substring(i, 1);
                    if (lt == ltAux)
                    {

                        p2Aux = p2Aux.Remove(i, 1); // remueve el valor anterior(*)
                        p2Aux = p2Aux.Insert(i, lt); // inserta una letra al valor removido
                        exito = true;
                    }
                    /** esta condición me permite comparar si la palabra que ingreso 
					 * es la correcta, si es así la variable "win" pasara a ser verdadera */
                    if (lt == p2)
                    {

                        win = true;
                    }
                }
                if (exito)
                {

                    Console.WriteLine("\nCorrecto!");
                    Console.WriteLine(p2Aux);
                }
                else if (win == false)
                {

                    intento++;
                    /** por cada intento fallido el contador sobreescribe la casilla
					 * con un caracter de espacio */
                    for (int i = 0; i < intento; i++)
                    {

                        ahorcado[i] = " ";
                    }
                    Console.WriteLine(ahorcado[5]);
                    Console.Write(ahorcado[3]);
                    Console.Write(ahorcado[4]);
                    Console.WriteLine(ahorcado[2]);
                    Console.Write(ahorcado[1]);
                    Console.WriteLine(ahorcado[0]);
                }
                /** la primera condición pregunta si las palabras que se ingresaron corresponden
				 * a la palabra oculta, y la segunda condición pregunta si la palabra que escribimos
				 * era correcta, de ser así se procede a mostrar un mensaje de felicitaciones para luego
				 * hacer un "break" */
                if (p2Aux == p2 || win == true)
                {

                    Console.WriteLine("\nFelicitaciones!, la palabra era " + p2);
                    break;
                }
                if (intento == 6)
                {

                    Console.WriteLine("\nHas fallado los " + intento + " intentos, juego terminado ...");
                    break;
                }
            } while (intento < 6);
        }
    }
}
