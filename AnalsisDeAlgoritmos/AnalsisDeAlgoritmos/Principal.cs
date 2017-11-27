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

namespace AnalsisDeAlgoritmos
{
    public partial class principal : Form
    {

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
       

        //Generar numeros aleatorios

        private void GenerarNumeros_Click(object sender, EventArgs e)
        {
            
            nElementos = int.Parse(cElementos.SelectedItem.ToString());
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

        private void Ordenar_Click(object sender, EventArgs e)
        {
            int[] nBurbuja = new int[numeros.Count];
            int[] nShell = new int[numeros.Count];
            int[] nInsertion = new int[numeros.Count];
            numeros.CopyTo(nBurbuja);
            numeros.CopyTo(nShell);
            numeros.CopyTo(nInsertion);

            Console.WriteLine(nBurbuja[2]);
            Console.WriteLine(nShell[2]);
            Console.WriteLine(nInsertion[2]);

            try
            {
                Shell shell = new Shell();
                Bubble bubble = new Bubble();
                Insertion insertion = new Insertion();
                insertion.ordenarInsertion(nInsertion, nInsertion.Length);
                shell.ordenarShell(nShell,nShell.Length);
                bubble.ordenarBurbuja(nBurbuja,nBurbuja.Length);
                
                /*
                for (int i=0;i<nShell.Length;i++) {

                    Console.WriteLine(nShell[i]);

                }
                //s.ordenarShell(nShell, nBurbuja.Length);
              */  
            }
            catch {
                Aviso.Text = "No se pudieron ordenar los elementos";
            }
        }
       
    }
}