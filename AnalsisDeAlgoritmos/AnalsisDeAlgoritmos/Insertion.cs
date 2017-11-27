using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalsisDeAlgoritmos
{
    class Insertion
    {
        public void ordenarInsertion(int[] Numeros, int numeroElementos)
        {
            int temp, j, i;
            for (i=0;i<numeroElementos;++i) {
                j = i;
                temp = Numeros[i];
                while ((j>0)&&(temp<Numeros[j-1])) {
                    Numeros[j] = Numeros[j - 1];
                    j--;
                }
                Numeros[j] = temp;

            }
            
        }
    }
}
