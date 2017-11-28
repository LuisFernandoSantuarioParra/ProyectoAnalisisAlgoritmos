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
        private int nElementos=100;
       

        //Generar numeros aleatorios

        private void GenerarNumeros_Click(object sender, EventArgs e)
        {
            
            CirProgreso.MaxValue = nElementos;
            Console.WriteLine(nElementos);

            Random rn = new Random();

            try
            {
                if (numeros.Count == 0)
                {
                    for (int i = 0; i < nElementos; i++)
                    {
                        numeros.Add(rn.Next(1, 65000));
                        CirProgreso.Value = i;
                        //Console.WriteLine(texto[i]);
                    }

                    //aviso
                    if (numeros.Count == nElementos)
                    {
                        Aviso.Text = "Numeros generados y listos";
                        Ordenar.Visible = true;
                        Ordenar.Enabled = true;
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
                        CirProgreso.Value = i;
                        //Console.WriteLine(texto[i]);
                    }

                    //aviso
                    if (numeros.Count == nElementos)
                    {
                        Aviso.Text = "Numeros generados y listos";
                        Ordenar.Visible = true;
                        Ordenar.Enabled = true;
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
            ntodos = new int[numeros.Count];

            for (int i=0;i<numeros.Count;i++) {
                ntodos[i]=ntodos[i]+=1;

            }
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
                                    Thread.Sleep(10);
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
            ntodos = new int[numeros.Count];

            for (int i = 0; i < numeros.Count; i++)
            {
                ntodos[i] = ntodos[i] += 1;

            }
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
                                Thread.Sleep(10);
                            }
                            k /= 2;
                        }

                    }
                    else
                    {
                        //...
                    }
                    Thread.Sleep(10000);
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
            ntodos = new int[numeros.Count];

            for (int i = 0; i < numeros.Count; i++)
            {
                ntodos[i] = ntodos[i] += 1;

            }
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
                            Thread.Sleep(10);
                        }

                    }
                    else
                    {
                        //...
                    }
                    Thread.Sleep(10000);
                }

            }
            catch
            {
                Aviso.Text = "No se pudieron ordenar los elementos";
            }



        }
        private void UpdateChartB()
        {

            GBubble.Series["Burbuja"].Points.Clear();
            for (int i = 0; i < nBurbuja.Length; i++)
            {
                GBubble.Series["Burbuja"].Points.AddXY(0, nBurbuja[i]);

            }
        }
        private void UpdateChartI()
        {
            GInsertion.Series["Insertion"].Points.Clear();
            for (int i = 0; i < nInsertion.Length; i++)
            {
                GInsertion.Series["Insertion"].Points.AddXY(0, nInsertion[i]);
            }

        }
        private void UpdateChartS()
        {
            GShell.Series["Shell"].Points.Clear();
            for (int i = 0; i < nShell.Length; i++)
            {
                GShell.Series["Shell"].Points.AddXY(0, nShell[i]);
            }
           
        }
        private void Ordenar_Click(object sender, EventArgs e)
        {
            charThread=new Thread(new ThreadStart(this.iniciarOrdenarBurbuja));
            charThread.IsBackground = true;
            
            charThreadS = new Thread(new ThreadStart(this.iniciarOrdenarShell));
            charThreadS.IsBackground = true;

            charThreadI = new Thread(new ThreadStart(this.iniciarOrdenarInsertion));
            charThreadI.IsBackground = true;

            charThread.Start();
            charThreadS.Start();
            charThreadI.Start();
        }

    }
}