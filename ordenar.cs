using System;
using System.Collections.Generic;

namespace ordenar;

class ordenar{


	public ordenar(){
		List<int> arr = new List<int> { 1, 6, 3, 9 ,89,7,2};

        ordenamiento(arr);
        foreach (var x in arr)
        {
           Console.WriteLine(x + "");
        }
	}

	public void ordenamiento(List<int> arr)
        {
            //sacamos el numero de elementos
            int num = arr.Count;
            int inicio = 0;
            int final = num - 1;
            bool cambiar = true;
            while (cambiar)
            {
                cambiar = false;
                for (int i = inicio; i < final; i++)
                {

                    Console.WriteLine("iz-der valor de la i: " + i);
                    Console.WriteLine("iz-der valor de final: " + final);
                    Console.WriteLine("iz-der valor de inicio: " + inicio);
                    if (arr[i] > arr[i + 1]){
                        cambio(arr, i, i + 1 );
                        cambiar = true;
                    }
                }
                //aqui validamos que sea el ultimo
                if (!cambiar)
                {
                    break;
                }
                //se va recorriendo
                final--;
                //desactivamos el booleano
                cambiar = false;
                for (int i = final - 1; i >= inicio; i--)
                {

                    Console.WriteLine("der-iz valor de la i: " + i);
                    Console.WriteLine("der-iz valor de final: " + final);
                    Console.WriteLine("der-iz valor de inicio: " + inicio);
                    if (arr[i] > arr[i + 1])
                    {
                        cambio(arr, i, i + 1);
                        cambiar = true;
                    }
                }

                inicio++;
            }
        }

        //aqui debemos cambiar los array
        //explanation
        public void cambio(List<int> arr, int posicion_1, int posicion_2)
        {
            int porsicion_1_temp = arr[posicion_1];
            arr[posicion_1] = arr[posicion_2];
            arr[posicion_2] = porsicion_1_temp;
        }

}