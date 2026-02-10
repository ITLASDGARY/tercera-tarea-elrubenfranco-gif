using System;

namespace EjerciciosCSharp
{
    public class Ejercicios
    {
        /// <summary>
        /// Ejercicio 1: La Tabla de Multiplicar
        /// </summary>
        public static string TablaDeMultiplicar(int numero)
        {
            string resultado = "";

            for (int i = 1; i <= 12; i++)
            {
                resultado += $"{numero} x {i} = {numero * i}\n";
            }

            return resultado;
        }

        /// <summary>
        /// Ejercicio 2: Validador de Contraseña
        /// </summary>
        public static int ValidarContrasena(Func<string> obtenerInput)
        {
            string claveSecreta = "1234";
            int intentos = 0;
            string entrada;

            do
            {
                entrada = obtenerInput();
                intentos++;
            }
            while (entrada != claveSecreta);

            return intentos;
        }

        /// <summary>
        /// Ejercicio 3: Suma Acumulativa
        /// </summary>
        public static int SumaAcumulativa(int[] numeros)
        {
            int suma = 0;

            foreach (int numero in numeros)
            {
                if (numero == 0)
                    break;

                suma += numero;
            }

            return suma;
        }

        /// <summary>
        /// Ejercicio 4: El Contador de Pares
        /// </summary>
        public static string ContadorDePares()
        {
            string resultado = "";

            for (int i = 0; i <= 50; i += 2)
            {
                resultado += i;

                if (i < 50)
                    resultado += ", ";
            }

            return resultado;
        }
    }
}
