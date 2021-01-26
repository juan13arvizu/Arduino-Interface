using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace WindowsFormsApp7
{
    public partial class Arduino_Interface : Form
    {
        private SerialPort myport;
        private string in_data;
        public int progressbar;
        public Arduino_Interface()
        {
            InitializeComponent();
        }

        private void Conectar_Click(object sender, EventArgs e)
        {
            myport = new SerialPort();
            myport.BaudRate = 9600;
            myport.PortName = textBox1.Text;
            myport.Parity = Parity.None;
            myport.DataBits = 8;
            myport.StopBits = StopBits.One;
            myport.DataReceived += myport_DataReceived;
            //Linea de escritura -> Siguiente clase :B
            try
            {
                myport.Open();
                MessageBox.Show("Conexion Establecida! :D");
                progressbar = int.Parse(in_data);
                progressBar1.Increment(progressbar);
                progressBar1.PerformStep();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void myport_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            in_data = myport.ReadLine();
            this.Invoke(new EventHandler(displayDataEvent));
        }
        private void displayDataEvent(object sender, EventArgs e)
        {
            datosTxt_Box.Text = in_data;
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void datosTxt_Box_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void progressBar1_Click(object sender, EventArgs e)
        {
            progressbar = int.Parse(in_data);
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void Barbuttom_Click(object sender, EventArgs e)
        {
           
        }
    }
}
