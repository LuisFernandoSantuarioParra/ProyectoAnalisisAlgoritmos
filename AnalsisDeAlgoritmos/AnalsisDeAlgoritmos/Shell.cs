using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace AnalsisDeAlgoritmos
{
    class Shell
    {
        public void ordenarShell(int[] Numeros, int numeroElementos, Thread thread) {
            int k,i,temp,j ;
            k = numeroElementos / 2;
            while (k>0) {
                for (i=k; i<numeroElementos;i++) {
                    j = i;
                    temp = Numeros[i];
                    while ((j>=k)&&(Numeros[j-k]>temp))
                    {
                        Numeros[j] = Numeros[j - k] ;
                        j = j - k;

                    }
                    Numeros[j] = temp;
                    Thread.Sleep(10);
                }
                k /= 2;
            }
        }
    }
}
