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

namespace arduino_deneme
{
    public partial class Form1 : Form
    {
        private string data;   //data değişkenini oluştur
        public Form1()
        {
            InitializeComponent();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();  //Seri portları diziye ekleme
            foreach (string port in ports)
                comboBox1.Items.Add(port);               //Seri portları comboBox1'e ekleme


            serialPort1.DataReceived += new SerialDataReceivedEventHandler(SerialPort1_DataReceived); //DataReceived eventini oluşturma
        }

        private void buttonBaglan_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = comboBox1.Text;       //Port ismini comboBox1'in text'i olarak belirle
                serialPort1.Open();                          //Seri portu aç
                kes.Enabled = true;                          //"Kes" butonunu tıklanabilir yap
                baglan.Enabled = false;                      //"Bağlan" butonunu tıklanamaz yap
                label3.Text = "Bağlantı sağlandı";
                label3.ForeColor = Color.Green;              //Label3 yazı rengini yeşil yap
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata");  //Hata mesajı
            }
        }

        private void buttonKes_Click(object sender, EventArgs e)
        {

            try
            {
                serialPort1.Close();              //Seri portu kapa
                kes.Enabled = false;              //"Kes" butonunu tıklanamaz yap
                baglan.Enabled = true;            //"BağlanKes" butonunu tıklanabilir yap
                label3.Text = "Bağlantı kesildi";
                label3.ForeColor = Color.Red;     //Label3 yazı rengini kırmızı yap
            }
            catch (Exception ex2)
            {
                MessageBox.Show(ex2.Message); //Hata mesajı
            }

        }
    }
}
