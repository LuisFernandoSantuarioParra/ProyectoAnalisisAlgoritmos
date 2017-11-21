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
        public List<int> numeros =new List<int>();

        private void GenerarNumeros_Click(object sender, EventArgs e)
        {
            
            int nElementos = int.Parse(cElementos.SelectedItem.ToString());
            Console.WriteLine(nElementos);

            Random rn = new Random();

            for (int i=0; i<nElementos;i++) {
                numeros.Add(rn.Next(1,65000));
                CirProgreso.Value = i ;
                //Console.WriteLine(texto[i]);
            }
            foreach (int numero in numeros) {
                Console.WriteLine(numero);
            }
          

        }
        



    }
}
