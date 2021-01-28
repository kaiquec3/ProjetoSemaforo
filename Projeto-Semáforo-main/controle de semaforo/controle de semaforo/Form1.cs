using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace controle_de_semaforo
{
    public partial class Form1 : Form
    {
        private Semaforo sem=new Semaforo();
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int tipo, tipo2;
            tipo = sem.getEstado(1);
            tipo2 = sem.getEstado(2);

            switch (tipo)
            {
                case 1:
                    sem.setVermelho(1);
                    picRua1.Image = controle_de_semaforo.Properties.Resources.sinal_vermelho;
                    rdbA1.Checked = true;
                    break;
                case 2:
                    sem.setVerde(1);
                    picRua1.Image = controle_de_semaforo.Properties.Resources.sinal_verde;
                    rdbA3.Checked = true;
                    break;
                case 3:
                    sem.setAmarelo(1);
                    picRua1.Image = controle_de_semaforo.Properties.Resources.sinal_amarelo;
                    rdbA2.Checked = true;
                    break;
            }

            switch (tipo2)
            {
                case 1:
                    sem.setVermelho(2);
                    picRua2.Image = controle_de_semaforo.Properties.Resources.sinal_vermelho;
                    rdbB1.Checked = true;
                    break;
                case 2:
                    sem.setVerde(2);
                    picRua2.Image = controle_de_semaforo.Properties.Resources.sinal_verde;
                    rdbB3.Checked = true;
                    break;
                case 3:
                    sem.setAmarelo(2);
                    picRua2.Image = controle_de_semaforo.Properties.Resources.sinal_amarelo;
                    rdbB2.Checked = true;
                    break;
            }

        }

        private void ChangedEstado(object sender, EventArgs e)
        {
            int tag;
            RadioButton remetente = (RadioButton)sender;
            tag = int.Parse(remetente.Tag.ToString());
            if (tag == 1)
            {
                sem.setVermelho(1);
                picRua1.Image = controle_de_semaforo.Properties.Resources.sinal_vermelho;
            }

            if (tag == 2)
            {
                sem.setAmarelo(1);
                picRua1.Image = controle_de_semaforo.Properties.Resources.sinal_amarelo;
            }

            if (tag == 3) { 
            sem.setVerde(1);
                picRua1.Image = controle_de_semaforo.Properties.Resources.sinal_verde;
        }

            if (tag == 4)
            {
                sem.setVermelho(2);
                picRua2.Image = controle_de_semaforo.Properties.Resources.sinal_vermelho;
            }

            if (tag == 5)
            {
                sem.setAmarelo(2);
                picRua2.Image = controle_de_semaforo.Properties.Resources.sinal_amarelo;
            }

            if (tag == 6)
            {
                sem.setVerde(2);
                picRua2.Image = controle_de_semaforo.Properties.Resources.sinal_verde;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled) 
            {
            timer1.Enabled = false;
            }
            else 
            {
            timer1.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sem.setVermelho(1);
            sem.setVerde(2);
            picRua1.Image = controle_de_semaforo.Properties.Resources.sinal_vermelho;
            picRua2.Image = controle_de_semaforo.Properties.Resources.sinal_verde;
        }
    }
    }

