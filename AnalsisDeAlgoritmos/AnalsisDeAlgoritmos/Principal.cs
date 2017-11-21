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


        /*
         variables globales
             */

        //
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

        //Generar numeros aleatorios
        public List<int> entrada =new List<int>();

        private void GenerarNumeros_Click(object sender, EventArgs e)
        {
        int nElementos = int.Parse(cElementos.SelectedItem.ToString());
            if (nElementos == 0)
            {
                CirProgreso.MaxValue = 1;
            }
            else {
                CirProgreso.MaxValue = nElementos;
            }

            Random ran = new Random();
            try
            {
                for (int i = 0; i < nElementos; i++) {
                    entrada.Add(ran.Next(1,10000000));
                    //Console.WriteLine(entrada[i]);
                    CirProgreso.Value = i;
                    Aviso.Text = "El arreglo ha sido llenado";
                }
            }
            catch {
                Aviso.Text = "No se pudo llenar el arreglo";
            }

        }
        



    }
}
