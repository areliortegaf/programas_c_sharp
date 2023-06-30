using System;
using System.Collections.Generic;

namespace fibonashi
{
    public class lefibonashi
    {
        Dictionary<int, long> lista = new Dictionary<int, long>();
        public lefibonashi()
        {
            int n_datos = 10;
            for (int j = 0; j < n_datos; j++)
            {
                Console.WriteLine(fibonacci(j) + " ");
            }
        }

        public long fibonacci(int n)
        {
            if (lista.ContainsKey(n))
            {                                       
                return lista[n];
            }
            long resultado;
            if (n <= 1)
            {
                resultado = n;
                return resultado;
            }
            else
            {
                resultado = fibonacci(n - 1) + fibonacci(n - 2);

            }

            lista[n] = resultado;
            return resultado;
        }
    }
}