using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Threading;

namespace AnalsisDeAlgoritmos
{
    public partial class principal : Form
    {
        private Thread charThread;
        private Thread charThreadS;
        private Thread charThreadI;
        private Thread charThreadQ;

        //Importando dll para mover ventana sin borde
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        //fin de importacion
        public principal()
        {
            InitializeComponent();
        }

        //Controlador mover ventana
        private void BarraSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void CloseWindow_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinWindow_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //Fin de controlador mover ventana

        //variables globales

        public List<int> numeros = new List<int>();
        private int nElementos;
        private String serie;
       

        //Generar numeros aleatorios

        private void GenerarNumeros_Click(object sender, EventArgs e)
        {
            serie = CSerie.SelectedItem.ToString();
            switch (serie) {
                case "Puntos":
                    GBubble.Series["Burbuja"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
                    GInsertion.Series["Insertion"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
                    GShell.Series["Shell"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
                    GQuick.Series["Quick"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
                    break;
                case "Barras":
                    GBubble.Series["Burbuja"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
                    GInsertion.Series["Insertion"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
                    GShell.Series["Shell"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
                    GQuick.Series["Quick"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
                    break;
                case "Candy":
                    GBubble.Series["Burbuja"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Candlestick;
                    GInsertion.Series["Insertion"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Candlestick;
                    GShell.Series["Shell"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Candlestick;
                    GQuick.Series["Quick"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Candlestick;

                    break;
                case "Pastel":
                    GBubble.Series["Burbuja"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
                    GInsertion.Series["Insertion"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
                    GShell.Series["Shell"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
                    GQuick.Series["Quick"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

                    break;
                case "Area":
                    GBubble.Series["Burbuja"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
                    GInsertion.Series["Insertion"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
                    GShell.Series["Shell"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
                    GQuick.Series["Quick"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;

                    break;
                default:
                    GBubble.Series["Burbuja"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
                    GInsertion.Series["Insertion"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
                    GShell.Series["Shell"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
                    GQuick.Series["Quick"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;

                    break;
            }
            

            nElementos = int.Parse(Valores.SelectedItem.ToString());
            Console.WriteLine(nElementos);

            Random rn = new Random();

            try
            {
                if (numeros.Count == 0)
                {
                    for (int i = 0; i < nElementos; i++)
                    {
                        numeros.Add(rn.Next(1, 65000));
                       
                        //Console.WriteLine(texto[i]);
                    }

                    //aviso
                    if (numeros.Count == nElementos)
                    {
                        Aviso.Text = "Numeros generados y listos";
                        Ordenar.Visible = true;
                        Ordenar.Enabled = true;
                        LNgenerado.Visible = true;
                    }
                    else
                    {
                        Aviso.Text = "NO SE PUDO LLENAR EL ARREGLO";
                    }
                    //fin aviso
                }
                else
                {
                    numeros.Clear();

                    for (int i = 0; i < nElementos; i++)
                    {
                        numeros.Add(rn.Next(1, 65000));
                       
                        //Console.WriteLine(texto[i]);
                    }

                    //aviso
                    if (numeros.Count == nElementos)
                    {
                        Aviso.Text = "Numeros generados";
                        Ordenar.Visible = true;
                        Ordenar.Enabled = true;
                        LNgenerado.Visible = true;
                    }
                    else
                    {
                        Aviso.Text = "NO SE PUDO LLENAR EL ARREGLO";
                    }
                    //fin aviso
                }
            }
            catch
            {
                Aviso.Text = "A ocurrido un error, reinicie el programa";
            }




        }

        int[] nBurbuja;
        int[] nShell ;
        int[] nInsertion;
        int[] ntodos;
        
             
        private void iniciarOrdenarBurbuja() {
            nBurbuja = new int[numeros.Count];
            

            numeros.CopyTo(nBurbuja);
            
            try
            {
                while (true)
                {
                    if (GBubble.IsHandleCreated)
                    {
                        

                        this.Invoke((MethodInvoker)delegate { UpdateChartB(); });

                        
                        int temp, i, j, cambios;
                        for (i = 0; i < nBurbuja.Length; ++i)
                        {
                            cambios = 0;
                            for (j = 0; j < nBurbuja.Length - 1; ++j)
                            {
                                if (nBurbuja[i] < nBurbuja[j])
                                {
                                    temp = nBurbuja[j];
                                    nBurbuja[j] = nBurbuja[i];
                                    nBurbuja[i] = temp;
                                    cambios = 1;
                                    this.Invoke((MethodInvoker)delegate { UpdateChartB(); });
                                    Thread.Sleep(50);
                                }
                            }
                            if (cambios == 0)
                            {
                                break;
                            }

                        }
                }
                    else
                    {
                        //...
                    }
                    Thread.Sleep(10000) ;
                    charThread.Suspend();
                }

            }
            catch
            {
                Aviso.Text = "No se pudieron ordenar los elementos";
            }

           

        }

        private void iniciarOrdenarShell()
        {
           
            nShell = new int[numeros.Count];
            
            numeros.CopyTo(nShell);
            try
            {


                while (true)
                {
                    if (GShell.IsHandleCreated)
                    {
                        this.Invoke((MethodInvoker)delegate { UpdateChartS(); });

                        int k, i, temp, j;
                        k = nShell.Length / 2;
                        while (k > 0)
                        {
                            for (i = k; i < nShell.Length; i++)
                            {
                                j = i;
                                temp = nShell[i];
                                while ((j >= k) && (nShell[j - k] > temp))
                                {
                                    nShell[j] = nShell[j - k];
                                    j = j - k;

                                }
                                nShell[j] = temp;
                                this.Invoke((MethodInvoker)delegate { UpdateChartS(); });
                                Thread.Sleep(100);
                            }
                            k /= 2;
                        }

                    }
                    else
                    {
                        //...
                    }
                    Thread.Sleep(10000);
                    charThreadS.Suspend();
                }

            }
            catch
            {
                Aviso.Text = "No se pudieron ordenar los elementos";
            }



        }

        private void iniciarOrdenarInsertion()
        {
            nInsertion = new int[numeros.Count];
          
            numeros.CopyTo(nInsertion);

            try
            {


                while (true)
                {
                    if (GInsertion.IsHandleCreated)
                    {
                        this.Invoke((MethodInvoker)delegate { UpdateChartI(); });

                        int temp, j, i;
                        for (i = 0; i < nInsertion.Length; ++i)
                        {
                            j = i;
                            temp = nInsertion[i];
                            while ((j > 0) && (temp < nInsertion[j - 1]))
                            {
                                nInsertion[j] = nInsertion[j - 1];
                                j--;
                                
                            }
                           nInsertion[j] = temp;
                            
                            this.Invoke((MethodInvoker)delegate { UpdateChartI(); });
                            Thread.Sleep(100);
                        }

                    }
                    else
                    {
                        //...
                    }
                    Thread.Sleep(10000);
                    charThreadI.Suspend();
                }

            }
            catch
            {
                Console.WriteLine( "No se pudieron ordenar los elementos");
            }



        }

        private void iniciarOrdenarQuick()
        {
            ntodos = new int[numeros.Count];

            numeros.CopyTo(ntodos);
            try
            {


                while (true)
                {
                    if (GQuick.IsHandleCreated)
                    {
                        this.Invoke((MethodInvoker)delegate { UpdateChartQ(); });

                        int piv, i = 0, L, R;
                        int [] beg=new int[ntodos.Length];
                        int [] end=new int[ntodos.Length];

                        beg[0] = 0; end[0] = ntodos.Length;
                        while (i >= 0)
                        {
                            
                            L = beg[i]; R = end[i] - 1;
                            if (L < R)
                            {
                                piv = ntodos[L];
                                while (L < R)
                                {
                                    while (ntodos[R] >= piv && L < R) R--; if (L < R) ntodos[L++] = ntodos[R];
                                    while (ntodos[L] <= piv && L < R) L++; if (L < R) ntodos[R--] = ntodos[L];
                                    this.Invoke((MethodInvoker)delegate { UpdateChartQ(); });
                                    Thread.Sleep(100);
                                }
                                ntodos[L] = piv; beg[i + 1] = L + 1; end[i + 1] = end[i]; end[i++] = L;
                                
                            }
                            else
                            {
                                i--;
                            }
                        }

                        

                    }
                    else
                    {
                        //...
                    }
                    Thread.Sleep(10000);
                    charThreadQ.Suspend();
                }

            }
            catch
            {
                Console.WriteLine("No se pudieron ordenar los elementos");
            }



        }

       
        
        private void UpdateChartB()
        {
            ABubble.Items.Clear();
            GBubble.Series["Burbuja"].Points.Clear();
            for (int i = 0; i < nBurbuja.Length; i++)
            {
                GBubble.Series["Burbuja"].Points.AddXY(0, nBurbuja[i]);
                ABubble.Items.Add(nBurbuja[i]);
            }
        }
        private void UpdateChartI()
        {
            GInsertion.Series["Insertion"].Points.Clear();
            AInsertion.Items.Clear();
            for (int i = 0; i < nInsertion.Length; i++)
            {
                GInsertion.Series["Insertion"].Points.AddXY(0, nInsertion[i]);
                AInsertion.Items.Add(nInsertion[i]);
            }

        }
        private void UpdateChartS()
        {
            AShell.Items.Clear();
            GShell.Series["Shell"].Points.Clear();
            for (int i = 0; i < nShell.Length; i++)
            {
                GShell.Series["Shell"].Points.AddXY(0, nShell[i]);
                AShell.Items.Add(nShell[i]);
            }
           
        }
        private void UpdateChartQ()
        {
            LNgenerado.Items.Clear();
            GQuick.Series["Quick"].Points.Clear();
            for (int i = 0; i < ntodos.Length; i++)
            {
                GQuick.Series["Quick"].Points.AddXY(0, ntodos[i]);
                LNgenerado.Items.Add(ntodos[i]);
            }

        }
        private void Ordenar_Click(object sender, EventArgs e)
        {
            
            charThread=new Thread(new ThreadStart(this.iniciarOrdenarBurbuja));
            charThread.IsBackground = true;

            charThreadQ = new Thread(new ThreadStart(this.iniciarOrdenarQuick));
            charThreadQ.IsBackground = true;

            charThreadS = new Thread(new ThreadStart(this.iniciarOrdenarShell));
            charThreadS.IsBackground = true;

            charThreadI = new Thread(new ThreadStart(this.iniciarOrdenarInsertion));
            charThreadI.IsBackground = true;

            charThread.Start();
            charThreadS.Start();
            charThreadI.Start();
            charThreadQ.Start();
        }
       

        private void label1_Click(object sender, EventArgs e)
        {
            

            MessageBox.Show("Este método consiste en acomodar el vector moviendo " +
                "el mayor hasta la última casilla comenzando desde la casilla " +
                "cero del vector hasta haber acomodado el número más grande el la última posición" +
                ", una vez acomodado el más grande, prosigue a encontrar  y acomodar el siguiente más grande" +
                " comparando de nuevo los numeros desde el inicio del vector, y así sigue hasta ordenar todo " +
                "los elementos el arreglo. Este algoritmo es muy deficiente ya que al ir comparando las casillas " +
                "para buscar el siguiente más grande, éste vuelve a comparar las ya ordenadas. \n" +
                "Su complejidad es O( N^2) \n " +
                "El Algoritmo es: \n" +
                 "for(j=0; j < n-1; j++){  \n" +
                 "if(vec[j] > vec[j+1]){  \n" +
                 "aux=vec[j];  \n" +
                 "vec[j]=vec[j+1];\n" +
                 "vec[j+1]=aux;} \n" +
                 " }\n" +
                 "} \n", "Bubble Sort",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El ordenamiento por inserción es una manera muy natural de ordenar para un ser humano, y puede usarse fácilmente para ordenar un mazo de cartas numeradas en forma arbitraria." +
                "La idea de este algoritmo de ordenación consiste en ir insertando un elemento de la lista ó un arreglo en la parte ordenada de la misma, asumiendo que el primer elemento es la parte ordenada, " +
                "el algoritmo ira comparando un elemento de la parte desordenada de la lista con los elementos de la parte ordenada, insertando el elemento en la posición correcta dentro de la parte ordenada, y " +
                "así sucesivamente hasta obtener la lista ordenada." +
               "Su complejidad es O( N^2) \n " +
               "El Algoritmo es: \n" +
                "int i, key, j;\n" +
                "for (i = 1; i < n; i++)\n" +
                "{\n" +
                "key = arr[i];\n" +
                "j = i - 1;\n" +
                " while (j >= 0 && arr[j] > key)\n" +
                "{\n" +
                "arr[j + 1] = arr[j];\n" +
                " j = j - 1;\n" +
                " }\n" +
                "arr[j + 1] = key;\n" +
                "}\n", "Insertion Sort",
           MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El método se denomina así en honor de su inventor Donald Shell. " +
                "Su implementación original, requiere O(n2) comparaciones e intercambios en el peor caso," +
                " aunque un cambio menor presentado en el libro de V. Pratt produce una implementación con un rendimiento de O(n log2 n)" +
                " en el peor caso. Esto es mejor que las O(n2) comparaciones requeridas por algoritmos simples pero peor que el óptimo O(n log n)."+
                " El Shell sort es una generalización del ordenamiento por inserción, teniendo en cuenta dos observaciones: El ordenamiento por inserción" +
                " es eficiente si la entrada está casi ordenada.El ordenamiento por inserción es ineficiente, en general, porque mueve los valores sólo una " +
                "posición cada vez." +
               "Su complejidad es O(n log n) \n " +
               "El Algoritmo es: \n" +
                "for ( int increment = a.length / 2;\n" +
                "increment > 0; \n" +
                "increment = (increment == 2 ? 1 : (int) Math.round(increment / 2.2))) { \n" +
                "for (int i = increment; i <> \n" +
                "for (int j = i; j >= increment && a[j - increment] > a[j]; j -= increment) {  \n" +
                "int temp = a[j]; \n" +
                " a[j] = a[j - increment]; \n" +
                "a[j - increment] = temp; \n" +
                "   } \n" +
                "  } \n" +
                " } \n" +
                "}", "Shell Sort",
           MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El algoritmo QuickSort se basa en la técnica de divide y vencerás " +
                "por la que en cada recursión, el problema se divide en subproblemas de menor tamaño" +
                " y se resuelven por separado (aplicando la misma técnica) para ser unidos de nuevo una" +
                " vez resueltos." +
                "En la práctica, es el algoritmo de ordenación más rápido conocido, " +
                "su tiempo de ejecución promedio es O(n log (n))," +
                " siendo en el peor de los casos O(n2), caso altamente improbable. " +
                "El hecho de que sea más rápido que otros algoritmos de ordenación " +
                "con tiempo promedio de O(n log (n)) ( como SmoothSort o HeapSort )" +
                " viene dado por que QuickSort realiza menos operaciones ya que el método utilizado es " +
                "el de partición." +
               "Su complejidad es O(n log n) \n " +
               "El Algoritmo es: \n" +
                "quickSort(arr[], low, high)\n" +
                "{\n" +
                "if (low < high)\n" +
                "{ /* pi is partitioning index, arr[p] is now at right place *\n" +
                "pi = partition(arr, low, high);\n" +
                "quickSort(arr, low, pi - 1);  // Before pi\n" +
                "quickSort(arr, pi + 1, high); // After pi\n" +
                "  }\n" +
                "}\n", "Quick Sort",
           MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }
    }
}