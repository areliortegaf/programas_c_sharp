using System;
using System.Collections.Generic;

namespace palindromo;

public class palindromo
{
    Dictionary<int, String> coincidencias = new Dictionary<int, string>();
    public palindromo() {
        String cadena = "bxxklyyxxosoanayy"; //17
        //String alrevez = revez(cadena);
        //Console.WriteLine(alrevez);
        int num_datos = cadena.Count();


        int miconta = 0;
        for (int i = 0; i < num_datos; i++) {
            //sumatoria del numero del indice mas los datos a extraer
            

                for (int num_datos_a_extraer = 0; num_datos_a_extraer <= num_datos; num_datos_a_extraer++) {
                    int sumatoria = num_datos_a_extraer + i;
                    if (sumatoria <= num_datos) {
                        if (num_datos_a_extraer > 2) {
                            String x = cadena.Substring(i, num_datos_a_extraer);
                        //Console.WriteLine("x "+x);
                            String y = revez(x);
                            

                        //comparacion
                        if (x.Equals(y)) {
                            //Console.WriteLine("x: "+x + "       y: "+ y);
                            coincidencias[miconta] = x;
                            miconta++;
                        }
                    }
                        
                    }
                }


        }
        //imprimimos las coincidencias 
        foreach (var x in coincidencias) {
            Console.WriteLine(x);
        }
    }

    public string revez(String cadena) {
        int num_datos = cadena.Count();
        String cadena_revez = "";
        for (int i= num_datos-1; i>=0; i--) {
            cadena_revez += cadena[i];
        }
        return cadena_revez;
    }

    static void Main(String[] args) {
        palindromo x = new palindromo();
    }
}