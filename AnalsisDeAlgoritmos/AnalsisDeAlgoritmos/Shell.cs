﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalsisDeAlgoritmos
{
    class Shell
    {
        public void ordenarShell(int[]Numeros, int numeroElementos) {
            int k,i,temp,j = 0;
            k = numeroElementos / 2;
            while (k>0) {
                for (i=k; i<numeroElementos;i++) {
                    j = i;
                    temp = Numeros[i];
                    while ((j>=k)&&(Numeros[j-k]>temp))
                    {
                        Numeros[j] = temp;

                    }
                    k /= 2;
                }
            }
        }
    }
}
