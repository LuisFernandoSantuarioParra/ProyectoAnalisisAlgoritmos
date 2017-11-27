using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalsisDeAlgoritmos
{
    class Bubble
    {
        public void ordenarBurbuja(int[] Numeros, int numeroElementos) {
            int temp, i, j;
            int cambios = 0;

            for (i=0;i<numeroElementos;++i) {
                for (j=0;j<numeroElementos-1;++j) {
                    if (Numeros[i]<Numeros[j]) {
                        temp = Numeros[j];
                        Numeros[j] = Numeros[i];
                        Numeros[i] = temp;
                        cambios = 1;
                    }
                }

            }
        }
    }
}
