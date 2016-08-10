using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;


namespace sokoban
{
    public partial class Form2 : Form
    {
        Form1 from1 = new Form1();
        
        int cursor = 3;
        int fondo = 5;
        int[,] n4 = new int[10, 10];


        public Form2()
        {
            InitializeComponent();
            
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            matriz();
            tablero();
        }

        public void tablero() {
            /// <summary>
            ///  muestro las opciones de cajas, jugador, check
            /// </summary>
            string currentPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName);
            currentPath += "\\imagen";
            string fullpath = currentPath + "\\";
            pictureBox1.Image = Image.FromFile(fullpath +  "3.jpg");
            pictureBox2.Image = Image.FromFile(fullpath + "2.jpg");
            pictureBox3.Image = Image.FromFile(fullpath + "1.jpg");
            pictureBox4.Image = Image.FromFile(fullpath + "6.jpg");
            pictureBox5.Image = Image.FromFile(fullpath + "5.jpg");
            matriz();
        }

        public void matriz() {
            /// <summary>
            ///  genero la matriz
            /// </summary>
            for (int x = 0; x < 10; x++)
            {
                for (int j = 0; j < 10; j++)
                {
                    n4[x, j] = fondo;
                }
            }

            iniciartablero();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            cursor = 3;
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            cursor = 2;
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            cursor = 1;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            cursor = 6;
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            cursor = 5;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string sql;
            string mysqlconexion = "server=mysql3.gear.host;" +
                "Port=3306;" +
                "Database=sokoban;" +
                "Uid=sokoban;" +
                "Pwd=Ms0F9o19R-!0;";
            MySqlConnection mysqlconn = new MySqlConnection(mysqlconexion);
            MySqlCommand mysqlcomm = new MySqlCommand();
            DataTable dt = new DataTable();
            string datos = "";
            for (int x = 0; x < 10; x++)
            {
                for (int j = 0; j < 10; j++)
                {
                    datos = datos +  n4[x,j];
                    
                }
            }
            sql = "insert into niveles (" +
                "nivel," +
                "matriz," +
                "pasos" +
                ") values (" +
                "'" + int.Parse(textBox1.Text) + "'," +
                "'" + datos + "'," +
                "'" + int.Parse(textBox2.Text) +
                "'" +")";
            
            mysqlconn.Open();
            mysqlcomm.Connection = mysqlconn;
            mysqlcomm.CommandText = sql;
            mysqlcomm.CommandType = CommandType.Text;
            mysqlcomm.ExecuteNonQuery();

            


        }

        //desde aca el tablero//
        public void iniciartablero()
        {

            string currentPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName);
            currentPath += "\\imagen";
            string fullpath = currentPath + "\\";
            p00.Image = Image.FromFile(fullpath + n4[0, 0] + ".jpg");
            p01.Image = Image.FromFile(fullpath + n4[0, 1] + ".jpg");
            p02.Image = Image.FromFile(fullpath + n4[0, 2] + ".jpg");
            p03.Image = Image.FromFile(fullpath + n4[0, 3] + ".jpg");
            p04.Image = Image.FromFile(fullpath + n4[0, 4] + ".jpg");
            p05.Image = Image.FromFile(fullpath + n4[0, 5] + ".jpg");
            p06.Image = Image.FromFile(fullpath + n4[0, 6] + ".jpg");
            p07.Image = Image.FromFile(fullpath + n4[0, 7] + ".jpg");
            p08.Image = Image.FromFile(fullpath + n4[0, 8] + ".jpg");
            p09.Image = Image.FromFile(fullpath + n4[0, 9] + ".jpg");
            p10.Image = Image.FromFile(fullpath + n4[1, 0] + ".jpg");
            p11.Image = Image.FromFile(fullpath + n4[1, 1] + ".jpg");
            p12.Image = Image.FromFile(fullpath + n4[1, 2] + ".jpg");
            p13.Image = Image.FromFile(fullpath + n4[1, 3] + ".jpg");
            p14.Image = Image.FromFile(fullpath + n4[1, 4] + ".jpg");
            p15.Image = Image.FromFile(fullpath + n4[1, 5] + ".jpg");
            p16.Image = Image.FromFile(fullpath + n4[1, 6] + ".jpg");
            p17.Image = Image.FromFile(fullpath + n4[1, 7] + ".jpg");
            p18.Image = Image.FromFile(fullpath + n4[1, 8] + ".jpg");
            p19.Image = Image.FromFile(fullpath + n4[1, 9] + ".jpg");
            p20.Image = Image.FromFile(fullpath + n4[2, 0] + ".jpg");
            p21.Image = Image.FromFile(fullpath + n4[2, 1] + ".jpg");
            p22.Image = Image.FromFile(fullpath + n4[2, 2] + ".jpg");
            p23.Image = Image.FromFile(fullpath + n4[2, 3] + ".jpg");
            p24.Image = Image.FromFile(fullpath + n4[2, 4] + ".jpg");
            p25.Image = Image.FromFile(fullpath + n4[2, 5] + ".jpg");
            p26.Image = Image.FromFile(fullpath + n4[2, 6] + ".jpg");
            p27.Image = Image.FromFile(fullpath + n4[2, 7] + ".jpg");
            p28.Image = Image.FromFile(fullpath + n4[2, 8] + ".jpg");
            p29.Image = Image.FromFile(fullpath + n4[2, 9] + ".jpg");
            p30.Image = Image.FromFile(fullpath + n4[3, 0] + ".jpg");
            p31.Image = Image.FromFile(fullpath + n4[3, 1] + ".jpg");
            p32.Image = Image.FromFile(fullpath + n4[3, 2] + ".jpg");
            p33.Image = Image.FromFile(fullpath + n4[3, 3] + ".jpg");
            p34.Image = Image.FromFile(fullpath + n4[3, 4] + ".jpg");
            p35.Image = Image.FromFile(fullpath + n4[3, 5] + ".jpg");
            p36.Image = Image.FromFile(fullpath + n4[3, 6] + ".jpg");
            p37.Image = Image.FromFile(fullpath + n4[3, 7] + ".jpg");
            p38.Image = Image.FromFile(fullpath + n4[3, 8] + ".jpg");
            p39.Image = Image.FromFile(fullpath + n4[3, 9] + ".jpg");
            p40.Image = Image.FromFile(fullpath + n4[4, 0] + ".jpg");
            p41.Image = Image.FromFile(fullpath + n4[4, 1] + ".jpg");
            p42.Image = Image.FromFile(fullpath + n4[4, 2] + ".jpg");
            p43.Image = Image.FromFile(fullpath + n4[4, 3] + ".jpg");
            p44.Image = Image.FromFile(fullpath + n4[4, 4] + ".jpg");
            p45.Image = Image.FromFile(fullpath + n4[4, 5] + ".jpg");
            p46.Image = Image.FromFile(fullpath + n4[4, 6] + ".jpg");
            p47.Image = Image.FromFile(fullpath + n4[4, 7] + ".jpg");
            p48.Image = Image.FromFile(fullpath + n4[4, 8] + ".jpg");
            p49.Image = Image.FromFile(fullpath + n4[4, 9] + ".jpg");
            p50.Image = Image.FromFile(fullpath + n4[5, 0] + ".jpg");
            p51.Image = Image.FromFile(fullpath + n4[5, 1] + ".jpg");
            p52.Image = Image.FromFile(fullpath + n4[5, 2] + ".jpg");
            p53.Image = Image.FromFile(fullpath + n4[5, 3] + ".jpg");
            p54.Image = Image.FromFile(fullpath + n4[5, 4] + ".jpg");
            p55.Image = Image.FromFile(fullpath + n4[5, 5] + ".jpg");
            p56.Image = Image.FromFile(fullpath + n4[5, 6] + ".jpg");
            p57.Image = Image.FromFile(fullpath + n4[5, 7] + ".jpg");
            p58.Image = Image.FromFile(fullpath + n4[5, 8] + ".jpg");
            p59.Image = Image.FromFile(fullpath + n4[5, 9] + ".jpg");
            p60.Image = Image.FromFile(fullpath + n4[6, 0] + ".jpg");
            p61.Image = Image.FromFile(fullpath + n4[6, 1] + ".jpg");
            p62.Image = Image.FromFile(fullpath + n4[6, 2] + ".jpg");
            p63.Image = Image.FromFile(fullpath + n4[6, 3] + ".jpg");
            p64.Image = Image.FromFile(fullpath + n4[6, 4] + ".jpg");
            p65.Image = Image.FromFile(fullpath + n4[6, 5] + ".jpg");
            p66.Image = Image.FromFile(fullpath + n4[6, 6] + ".jpg");
            p67.Image = Image.FromFile(fullpath + n4[6, 7] + ".jpg");
            p68.Image = Image.FromFile(fullpath + n4[6, 8] + ".jpg");
            p69.Image = Image.FromFile(fullpath + n4[6, 9] + ".jpg");
            p70.Image = Image.FromFile(fullpath + n4[7, 0] + ".jpg");
            p71.Image = Image.FromFile(fullpath + n4[7, 1] + ".jpg");
            p72.Image = Image.FromFile(fullpath + n4[7, 2] + ".jpg");
            p73.Image = Image.FromFile(fullpath + n4[7, 3] + ".jpg");
            p74.Image = Image.FromFile(fullpath + n4[7, 4] + ".jpg");
            p75.Image = Image.FromFile(fullpath + n4[7, 5] + ".jpg");
            p76.Image = Image.FromFile(fullpath + n4[7, 6] + ".jpg");
            p77.Image = Image.FromFile(fullpath + n4[7, 7] + ".jpg");
            p78.Image = Image.FromFile(fullpath + n4[7, 8] + ".jpg");
            p79.Image = Image.FromFile(fullpath + n4[7, 9] + ".jpg");
            p80.Image = Image.FromFile(fullpath + n4[8, 0] + ".jpg");
            p81.Image = Image.FromFile(fullpath + n4[8, 1] + ".jpg");
            p82.Image = Image.FromFile(fullpath + n4[8, 2] + ".jpg");
            p83.Image = Image.FromFile(fullpath + n4[8, 3] + ".jpg");
            p84.Image = Image.FromFile(fullpath + n4[8, 4] + ".jpg");
            p85.Image = Image.FromFile(fullpath + n4[8, 5] + ".jpg");
            p86.Image = Image.FromFile(fullpath + n4[8, 6] + ".jpg");
            p87.Image = Image.FromFile(fullpath + n4[8, 7] + ".jpg");
            p88.Image = Image.FromFile(fullpath + n4[8, 8] + ".jpg");
            p89.Image = Image.FromFile(fullpath + n4[8, 9] + ".jpg");
            p90.Image = Image.FromFile(fullpath + n4[9, 0] + ".jpg");
            p91.Image = Image.FromFile(fullpath + n4[9, 1] + ".jpg");
            p92.Image = Image.FromFile(fullpath + n4[9, 2] + ".jpg");
            p93.Image = Image.FromFile(fullpath + n4[9, 3] + ".jpg");
            p94.Image = Image.FromFile(fullpath + n4[9, 4] + ".jpg");
            p95.Image = Image.FromFile(fullpath + n4[9, 5] + ".jpg");
            p96.Image = Image.FromFile(fullpath + n4[9, 6] + ".jpg");
            p97.Image = Image.FromFile(fullpath + n4[9, 7] + ".jpg");
            p98.Image = Image.FromFile(fullpath + n4[9, 8] + ".jpg");
            p99.Image = Image.FromFile(fullpath + n4[9, 9] + ".jpg");

        }

        private void p00_Click(object sender, EventArgs e)
        {
            string currentPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName);
            currentPath += "\\imagen";
            string fullpath = currentPath + "\\";
            p00.Image = Image.FromFile(fullpath + cursor + ".jpg");
            n4[0, 0] = cursor;

        }

        private void p01_Click(object sender, EventArgs e)
        {
            string currentPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName);
            currentPath += "\\imagen";
            string fullpath = currentPath + "\\";
            p01.Image = Image.FromFile(fullpath + cursor + ".jpg");
            n4[0, 1] = cursor;

        }

        private void p02_Click(object sender, EventArgs e)
        {
            string currentPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName);
            currentPath += "\\imagen";
            string fullpath = currentPath + "\\";
            p02.Image = Image.FromFile(fullpath + cursor + ".jpg");
            n4[0, 2] = cursor;
        }

        private void p03_Click(object sender, EventArgs e)
        {
            string currentPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName);
            currentPath += "\\imagen";
            string fullpath = currentPath + "\\";
            p03.Image = Image.FromFile(fullpath + cursor + ".jpg");
            n4[0, 3] = cursor;
        }

        private void p04_Click(object sender, EventArgs e)
        {
            string currentPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName);
            currentPath += "\\imagen";
            string fullpath = currentPath + "\\";
            p04.Image = Image.FromFile(fullpath + cursor + ".jpg");
            n4[0, 4] = cursor;
        }

        private void p05_Click(object sender, EventArgs e)
        {
            string currentPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName);
            currentPath += "\\imagen";
            string fullpath = currentPath + "\\";
            p05.Image = Image.FromFile(fullpath + cursor + ".jpg");
            n4[0, 5] = cursor;
        }

        private void p06_Click(object sender, EventArgs e)
        {
            string currentPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName);
            currentPath += "\\imagen";
            string fullpath = currentPath + "\\";
            p06.Image = Image.FromFile(fullpath + cursor + ".jpg");
            n4[0, 6] = cursor;
        }

        private void p07_Click(object sender, EventArgs e)
        {
            string currentPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName);
            currentPath += "\\imagen";
            string fullpath = currentPath + "\\";
            p07.Image = Image.FromFile(fullpath + cursor + ".jpg");
            n4[0, 7] = cursor;
        }

        private void p08_Click(object sender, EventArgs e)
        {
            string currentPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName);
            currentPath += "\\imagen";
            string fullpath = currentPath + "\\";
            p08.Image = Image.FromFile(fullpath + cursor + ".jpg");
            n4[0, 8] = cursor;
        }

        private void p09_Click(object sender, EventArgs e)
        {
            string currentPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName);
            currentPath += "\\imagen";
            string fullpath = currentPath + "\\";
            p09.Image = Image.FromFile(fullpath + cursor + ".jpg");
            n4[0, 9] = cursor;
        }

        private void p10_Click(object sender, EventArgs e)
        {
            string currentPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName);
            currentPath += "\\imagen";
            string fullpath = currentPath + "\\";
            p10.Image = Image.FromFile(fullpath + cursor + ".jpg");
            n4[1, 0] = cursor;
        }

        private void p11_Click(object sender, EventArgs e)
        {
            string currentPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName);
            currentPath += "\\imagen";
            string fullpath = currentPath + "\\";
            p11.Image = Image.FromFile(fullpath + cursor + ".jpg");
            n4[1, 1] = cursor;
        }

        private void p12_Click(object sender, EventArgs e)
        {
            string currentPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName);
            currentPath += "\\imagen";
            string fullpath = currentPath + "\\";
            p12.Image = Image.FromFile(fullpath + cursor + ".jpg");
            n4[1, 2] = cursor;
        }

        private void p13_Click(object sender, EventArgs e)
        {
            string currentPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName);
            currentPath += "\\imagen";
            string fullpath = currentPath + "\\";
            p13.Image = Image.FromFile(fullpath + cursor + ".jpg");
            n4[1, 3] = cursor;
        }

        private void p14_Click(object sender, EventArgs e)
        {
            string currentPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName);
            currentPath += "\\imagen";
            string fullpath = currentPath + "\\";
            p14.Image = Image.FromFile(fullpath + cursor + ".jpg");
            n4[1, 4] = cursor;
        }

        private void p15_Click(object sender, EventArgs e)
        {
            string currentPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName);
            currentPath += "\\imagen";
            string fullpath = currentPath + "\\";
            p15.Image = Image.FromFile(fullpath + cursor + ".jpg");
            n4[1, 5] = cursor;
        }

        private void p16_Click(object sender, EventArgs e)
        {
            string currentPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName);
            currentPath += "\\imagen";
            string fullpath = currentPath + "\\";
            p16.Image = Image.FromFile(fullpath + cursor + ".jpg");
            n4[1, 6] = cursor;
        }

        private void p17_Click(object sender, EventArgs e)
        {
            string currentPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName);
            currentPath += "\\imagen";
            string fullpath = currentPath + "\\";
            p17.Image = Image.FromFile(fullpath + cursor + ".jpg");
            n4[1, 7] = cursor;
        }

        private void p18_Click(object sender, EventArgs e)
        {
            string currentPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName);
            currentPath += "\\imagen";
            string fullpath = currentPath + "\\";
            p18.Image = Image.FromFile(fullpath + cursor + ".jpg");
            n4[1, 8] = cursor;
        }

        private void p19_Click(object sender, EventArgs e)
        {
            string currentPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName);
            currentPath += "\\imagen";
            string fullpath = currentPath + "\\";
            p19.Image = Image.FromFile(fullpath + cursor + ".jpg");
            n4[1, 9] = cursor;
        }

        private void p20_Click(object sender, EventArgs e)
        {
            string currentPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName);
            currentPath += "\\imagen";
            string fullpath = currentPath + "\\";
            p20.Image = Image.FromFile(fullpath + cursor + ".jpg");
            n4[2, 0] = cursor;
        }

        private void p21_Click(object sender, EventArgs e)
        {
            string currentPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName);
            currentPath += "\\imagen";
            string fullpath = currentPath + "\\";
            p21.Image = Image.FromFile(fullpath + cursor + ".jpg");
            n4[2, 1] = cursor;
        }

        private void p22_Click(object sender, EventArgs e)
        {
            string currentPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName);
            currentPath += "\\imagen";
            string fullpath = currentPath + "\\";
            p22.Image = Image.FromFile(fullpath + cursor + ".jpg");
            n4[2, 2] = cursor;
        }

        private void p23_Click(object sender, EventArgs e)
        {
            string currentPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName);
            currentPath += "\\imagen";
            string fullpath = currentPath + "\\";
            p23.Image = Image.FromFile(fullpath + cursor + ".jpg");
            n4[2, 3] = cursor;
        }

        private void p24_Click(object sender, EventArgs e)
        {
            string currentPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName);
            currentPath += "\\imagen";
            string fullpath = currentPath + "\\";
            p24.Image = Image.FromFile(fullpath + cursor + ".jpg");
            n4[2, 4] = cursor;
        }

        private void p25_Click(object sender, EventArgs e)
        {
            string currentPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName);
            currentPath += "\\imagen";
            string fullpath = currentPath + "\\";
            p25.Image = Image.FromFile(fullpath + cursor + ".jpg");
            n4[2, 5] = cursor;
        }

        private void p26_Click(object sender, EventArgs e)
        {
            string currentPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName);
            currentPath += "\\imagen";
            string fullpath = currentPath + "\\";
            p26.Image = Image.FromFile(fullpath + cursor + ".jpg");
            n4[2, 6] = cursor;
        }

        private void p27_Click(object sender, EventArgs e)
        {
            string currentPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName);
            currentPath += "\\imagen";
            string fullpath = currentPath + "\\";
            p27.Image = Image.FromFile(fullpath + cursor + ".jpg");
            n4[2, 7] = cursor;
        }

        private void p28_Click(object sender, EventArgs e)
        {
            string currentPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName);
            currentPath += "\\imagen";
            string fullpath = currentPath + "\\";
            p28.Image = Image.FromFile(fullpath + cursor + ".jpg");
            n4[2, 8] = cursor;
        }

        private void p29_Click(object sender, EventArgs e)
        {
            string currentPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName);
            currentPath += "\\imagen";
            string fullpath = currentPath + "\\";
            p29.Image = Image.FromFile(fullpath + cursor + ".jpg");
            n4[2, 9] = cursor;
        }

        private void p30_Click(object sender, EventArgs e)
        {
            string currentPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName);
            currentPath += "\\imagen";
            string fullpath = currentPath + "\\";
            p30.Image = Image.FromFile(fullpath + cursor + ".jpg");
            n4[3, 0] = cursor;
        }

        private void p31_Click(object sender, EventArgs e)
        {
            string currentPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName);
            currentPath += "\\imagen";
            string fullpath = currentPath + "\\";
            p31.Image = Image.FromFile(fullpath + cursor + ".jpg");
            n4[3, 1] = cursor;
        }

        private void p32_Click(object sender, EventArgs e)
        {
            string currentPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName);
            currentPath += "\\imagen";
            string fullpath = currentPath + "\\";
            p32.Image = Image.FromFile(fullpath + cursor + ".jpg");
            n4[3, 2] = cursor;
        }

        private void p33_Click(object sender, EventArgs e)
        {
            string currentPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName);
            currentPath += "\\imagen";
            string fullpath = currentPath + "\\";
            p33.Image = Image.FromFile(fullpath + cursor + ".jpg");
            n4[3, 3] = cursor;
        }

        private void p34_Click(object sender, EventArgs e)
        {
            string currentPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName);
            currentPath += "\\imagen";
            string fullpath = currentPath + "\\";
            p34.Image = Image.FromFile(fullpath + cursor + ".jpg");
            n4[3, 4] = cursor;
        }

        private void p35_Click(object sender, EventArgs e)
        {
            string currentPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName);
            currentPath += "\\imagen";
            string fullpath = currentPath + "\\";
            p35.Image = Image.FromFile(fullpath + cursor + ".jpg");
            n4[3, 5] = cursor;
        }

        private void p36_Click(object sender, EventArgs e)
        {
            string currentPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName);
            currentPath += "\\imagen";
            string fullpath = currentPath + "\\";
            p36.Image = Image.FromFile(fullpath + cursor + ".jpg");
            n4[3, 6] = cursor;
        }

        private void p37_Click(object sender, EventArgs e)
        {
            string currentPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName);
            currentPath += "\\imagen";
            string fullpath = currentPath + "\\";
            p37.Image = Image.FromFile(fullpath + cursor + ".jpg");
            n4[3, 7] = cursor;
        }

        private void p38_Click(object sender, EventArgs e)
        {
            string currentPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName);
            currentPath += "\\imagen";
            string fullpath = currentPath + "\\";
            p38.Image = Image.FromFile(fullpath + cursor + ".jpg");
            n4[3, 8] = cursor;
        }

        private void p39_Click(object sender, EventArgs e)
        {
            string currentPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName);
            currentPath += "\\imagen";
            string fullpath = currentPath + "\\";
            p39.Image = Image.FromFile(fullpath + cursor + ".jpg");
            n4[3, 9] = cursor;
        }

        private void p40_Click(object sender, EventArgs e)
        {
            string currentPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName);
            currentPath += "\\imagen";
            string fullpath = currentPath + "\\";
            p40.Image = Image.FromFile(fullpath + cursor + ".jpg");
            n4[4, 0] = cursor;
        }

        private void p41_Click(object sender, EventArgs e)
        {
            string currentPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName);
            currentPath += "\\imagen";
            string fullpath = currentPath + "\\";
            p41.Image = Image.FromFile(fullpath + cursor + ".jpg");
            n4[4, 1] = cursor;
        }

        private void p42_Click(object sender, EventArgs e)
        {
            string currentPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName);
            currentPath += "\\imagen";
            string fullpath = currentPath + "\\";
            p42.Image = Image.FromFile(fullpath + cursor + ".jpg");
            n4[4, 2] = cursor;
        }

        private void p43_Click(object sender, EventArgs e)
        {
            string currentPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName);
            currentPath += "\\imagen";
            string fullpath = currentPath + "\\";
            p43.Image = Image.FromFile(fullpath + cursor + ".jpg");
            n4[4, 3] = cursor;
        }

        private void p44_Click(object sender, EventArgs e)
        {
            string currentPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName);
            currentPath += "\\imagen";
            string fullpath = currentPath + "\\";
            p44.Image = Image.FromFile(fullpath + cursor + ".jpg");
            n4[4, 4] = cursor;
        }

        private void p45_Click(object sender, EventArgs e)
        {
            string currentPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName);
            currentPath += "\\imagen";
            string fullpath = currentPath + "\\";
            p45.Image = Image.FromFile(fullpath + cursor + ".jpg");
            n4[4, 5] = cursor;
        }

        private void p46_Click(object sender, EventArgs e)
        {
            string currentPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName);
            currentPath += "\\imagen";
            string fullpath = currentPath + "\\";
            p46.Image = Image.FromFile(fullpath + cursor + ".jpg");
            n4[4, 6] = cursor;
        }

        private void p47_Click(object sender, EventArgs e)
        {
            string currentPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName);
            currentPath += "\\imagen";
            string fullpath = currentPath + "\\";
            p47.Image = Image.FromFile(fullpath + cursor + ".jpg");
            n4[4, 7] = cursor;
        }

        private void p48_Click(object sender, EventArgs e)
        {
            string currentPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName);
            currentPath += "\\imagen";
            string fullpath = currentPath + "\\";
            p48.Image = Image.FromFile(fullpath + cursor + ".jpg");
            n4[4, 8] = cursor;
        }

        private void p49_Click(object sender, EventArgs e)
        {
            string currentPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName);
            currentPath += "\\imagen";
            string fullpath = currentPath + "\\";
            p49.Image = Image.FromFile(fullpath + cursor + ".jpg");
            n4[4, 9] = cursor;
        }

        private void p50_Click(object sender, EventArgs e)
        {
            string currentPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName);
            currentPath += "\\imagen";
            string fullpath = currentPath + "\\";
            p50.Image = Image.FromFile(fullpath + cursor + ".jpg");
            n4[5, 0] = cursor;
        }

        private void p51_Click(object sender, EventArgs e)
        {
            string currentPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName);
            currentPath += "\\imagen";
            string fullpath = currentPath + "\\";
            p51.Image = Image.FromFile(fullpath + cursor + ".jpg");
            n4[5, 1] = cursor;
        }

        private void p52_Click(object sender, EventArgs e)
        {
            string currentPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName);
            currentPath += "\\imagen";
            string fullpath = currentPath + "\\";
            p52.Image = Image.FromFile(fullpath + cursor + ".jpg");
            n4[5, 2] = cursor;
        }

        private void p53_Click(object sender, EventArgs e)
        {
            string currentPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName);
            currentPath += "\\imagen";
            string fullpath = currentPath + "\\";
            p53.Image = Image.FromFile(fullpath + cursor + ".jpg");
            n4[5, 3] = cursor;
        }

        private void p54_Click(object sender, EventArgs e)
        {
            string currentPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName);
            currentPath += "\\imagen";
            string fullpath = currentPath + "\\";
            p54.Image = Image.FromFile(fullpath + cursor + ".jpg");
            n4[5, 5] = cursor;
        }

        private void p55_Click(object sender, EventArgs e)
        {
            string currentPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName);
            currentPath += "\\imagen";
            string fullpath = currentPath + "\\";
            p55.Image = Image.FromFile(fullpath + cursor + ".jpg");
            n4[5, 5] = cursor;
        }

        private void p56_Click(object sender, EventArgs e)
        {
            string currentPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName);
            currentPath += "\\imagen";
            string fullpath = currentPath + "\\";
            p56.Image = Image.FromFile(fullpath + cursor + ".jpg");
            n4[5, 6] = cursor;
        }

        private void p57_Click(object sender, EventArgs e)
        {
            string currentPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName);
            currentPath += "\\imagen";
            string fullpath = currentPath + "\\";
            p57.Image = Image.FromFile(fullpath + cursor + ".jpg");
            n4[5, 7] = cursor;
        }

        private void p58_Click(object sender, EventArgs e)
        {
            string currentPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName);
            currentPath += "\\imagen";
            string fullpath = currentPath + "\\";
            p58.Image = Image.FromFile(fullpath + cursor + ".jpg");
            n4[5, 8] = cursor;
        }

        private void p59_Click(object sender, EventArgs e)
        {
            string currentPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName);
            currentPath += "\\imagen";
            string fullpath = currentPath + "\\";
            p59.Image = Image.FromFile(fullpath + cursor + ".jpg");
            n4[5, 9] = cursor;
        }

        private void p60_Click(object sender, EventArgs e)
        {
            string currentPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName);
            currentPath += "\\imagen";
            string fullpath = currentPath + "\\";
            p60.Image = Image.FromFile(fullpath + cursor + ".jpg");
            n4[6, 0] = cursor;
        }

        private void p61_Click(object sender, EventArgs e)
        {
            string currentPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName);
            currentPath += "\\imagen";
            string fullpath = currentPath + "\\";
            p61.Image = Image.FromFile(fullpath + cursor + ".jpg");
            n4[6, 1] = cursor;
        }

        private void p62_Click(object sender, EventArgs e)
        {
            string currentPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName);
            currentPath += "\\imagen";
            string fullpath = currentPath + "\\";
            p62.Image = Image.FromFile(fullpath + cursor + ".jpg");
            n4[6, 2] = cursor;
        }

        private void p63_Click(object sender, EventArgs e)
        {
            string currentPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName);
            currentPath += "\\imagen";
            string fullpath = currentPath + "\\";
            p63.Image = Image.FromFile(fullpath + cursor + ".jpg");
            n4[6, 3] = cursor;
        }

        private void p64_Click(object sender, EventArgs e)
        {
            string currentPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName);
            currentPath += "\\imagen";
            string fullpath = currentPath + "\\";
            p64.Image = Image.FromFile(fullpath + cursor + ".jpg");
            n4[6, 4] = cursor;
        }

        private void p65_Click(object sender, EventArgs e)
        {
            string currentPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName);
            currentPath += "\\imagen";
            string fullpath = currentPath + "\\";
            p65.Image = Image.FromFile(fullpath + cursor + ".jpg");
            n4[6, 5] = cursor;
        }

        private void p66_Click(object sender, EventArgs e)
        {
            string currentPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName);
            currentPath += "\\imagen";
            string fullpath = currentPath + "\\";
            p66.Image = Image.FromFile(fullpath + cursor + ".jpg");
            n4[6, 6] = cursor;
        }

        private void p67_Click(object sender, EventArgs e)
        {
            string currentPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName);
            currentPath += "\\imagen";
            string fullpath = currentPath + "\\";
            p67.Image = Image.FromFile(fullpath + cursor + ".jpg");
            n4[6, 7] = cursor;
        }

        private void p68_Click(object sender, EventArgs e)
        {
            string currentPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName);
            currentPath += "\\imagen";
            string fullpath = currentPath + "\\";
            p68.Image = Image.FromFile(fullpath + cursor + ".jpg");
            n4[6, 8] = cursor;
        }

        private void p69_Click(object sender, EventArgs e)
        {
            string currentPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName);
            currentPath += "\\imagen";
            string fullpath = currentPath + "\\";
            p69.Image = Image.FromFile(fullpath + cursor + ".jpg");
            n4[6, 9] = cursor;
        }

        private void p70_Click(object sender, EventArgs e)
        {
            string currentPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName);
            currentPath += "\\imagen";
            string fullpath = currentPath + "\\";
            p70.Image = Image.FromFile(fullpath + cursor + ".jpg");
            n4[7, 0] = cursor;
        }

        private void p71_Click(object sender, EventArgs e)
        {
            string currentPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName);
            currentPath += "\\imagen";
            string fullpath = currentPath + "\\";
            p71.Image = Image.FromFile(fullpath + cursor + ".jpg");
            n4[7, 1] = cursor;
        }

        private void p72_Click(object sender, EventArgs e)
        {
            string currentPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName);
            currentPath += "\\imagen";
            string fullpath = currentPath + "\\";
            p72.Image = Image.FromFile(fullpath + cursor + ".jpg");
            n4[7, 2] = cursor;
        }

        private void p73_Click(object sender, EventArgs e)
        {
            string currentPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName);
            currentPath += "\\imagen";
            string fullpath = currentPath + "\\";
            p73.Image = Image.FromFile(fullpath + cursor + ".jpg");
            n4[7, 3] = cursor;
        }

        private void p74_Click(object sender, EventArgs e)
        {
            string currentPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName);
            currentPath += "\\imagen";
            string fullpath = currentPath + "\\";
            p74.Image = Image.FromFile(fullpath + cursor + ".jpg");
            n4[7, 4] = cursor;
        }

        private void p75_Click(object sender, EventArgs e)
        {
            string currentPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName);
            currentPath += "\\imagen";
            string fullpath = currentPath + "\\";
            p75.Image = Image.FromFile(fullpath + cursor + ".jpg");
            n4[7, 5] = cursor;
        }

        private void p76_Click(object sender, EventArgs e)
        {
            string currentPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName);
            currentPath += "\\imagen";
            string fullpath = currentPath + "\\";
            p76.Image = Image.FromFile(fullpath + cursor + ".jpg");
            n4[7, 6] = cursor;
        }

        private void p77_Click(object sender, EventArgs e)
        {
            string currentPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName);
            currentPath += "\\imagen";
            string fullpath = currentPath + "\\";
            p77.Image = Image.FromFile(fullpath + cursor + ".jpg");
            n4[7, 7] = cursor;
        }

        private void p78_Click(object sender, EventArgs e)
        {
            string currentPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName);
            currentPath += "\\imagen";
            string fullpath = currentPath + "\\";
            p78.Image = Image.FromFile(fullpath + cursor + ".jpg");
            n4[7, 8] = cursor;
        }

        private void p79_Click(object sender, EventArgs e)
        {
            string currentPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName);
            currentPath += "\\imagen";
            string fullpath = currentPath + "\\";
            p79.Image = Image.FromFile(fullpath + cursor + ".jpg");
            n4[7, 9] = cursor;
        }

        private void p80_Click(object sender, EventArgs e)
        {
            string currentPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName);
            currentPath += "\\imagen";
            string fullpath = currentPath + "\\";
            p80.Image = Image.FromFile(fullpath + cursor + ".jpg");
            n4[8, 0] = cursor;
        }

        private void p81_Click(object sender, EventArgs e)
        {
            string currentPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName);
            currentPath += "\\imagen";
            string fullpath = currentPath + "\\";
            p81.Image = Image.FromFile(fullpath + cursor + ".jpg");
            n4[8, 1] = cursor;
        }

        private void p82_Click(object sender, EventArgs e)
        {
            string currentPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName);
            currentPath += "\\imagen";
            string fullpath = currentPath + "\\";
            p82.Image = Image.FromFile(fullpath + cursor + ".jpg");
            n4[8, 2] = cursor;
        }

        private void p83_Click(object sender, EventArgs e)
        {
            string currentPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName);
            currentPath += "\\imagen";
            string fullpath = currentPath + "\\";
            p83.Image = Image.FromFile(fullpath + cursor + ".jpg");
            n4[8, 3] = cursor;
        }

        private void p84_Click(object sender, EventArgs e)
        {
            string currentPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName);
            currentPath += "\\imagen";
            string fullpath = currentPath + "\\";
            p84.Image = Image.FromFile(fullpath + cursor + ".jpg");
            n4[8, 4] = cursor;
        }

        private void p85_Click(object sender, EventArgs e)
        {
            string currentPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName);
            currentPath += "\\imagen";
            string fullpath = currentPath + "\\";
            p85.Image = Image.FromFile(fullpath + cursor + ".jpg");
            n4[8, 5] = cursor;
        }

        private void p86_Click(object sender, EventArgs e)
        {
            string currentPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName);
            currentPath += "\\imagen";
            string fullpath = currentPath + "\\";
            p86.Image = Image.FromFile(fullpath + cursor + ".jpg");
            n4[8, 6] = cursor;
        }

        private void p87_Click(object sender, EventArgs e)
        {
            string currentPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName);
            currentPath += "\\imagen";
            string fullpath = currentPath + "\\";
            p87.Image = Image.FromFile(fullpath + cursor + ".jpg");
            n4[8, 7] = cursor;
        }

        private void p88_Click(object sender, EventArgs e)
        {
            string currentPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName);
            currentPath += "\\imagen";
            string fullpath = currentPath + "\\";
            p88.Image = Image.FromFile(fullpath + cursor + ".jpg");
            n4[8, 8] = cursor;
        }

        private void p89_Click(object sender, EventArgs e)
        {
            string currentPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName);
            currentPath += "\\imagen";
            string fullpath = currentPath + "\\";
            p89.Image = Image.FromFile(fullpath + cursor + ".jpg");
            n4[8, 9] = cursor;
        }

        private void p90_Click(object sender, EventArgs e)
        {
            string currentPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName);
            currentPath += "\\imagen";
            string fullpath = currentPath + "\\";
            p90.Image = Image.FromFile(fullpath + cursor + ".jpg");
            n4[9, 0] = cursor;
        }

        private void p91_Click(object sender, EventArgs e)
        {
            string currentPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName);
            currentPath += "\\imagen";
            string fullpath = currentPath + "\\";
            p91.Image = Image.FromFile(fullpath + cursor + ".jpg");
            n4[9, 1] = cursor;
        }

        private void p92_Click(object sender, EventArgs e)
        {
            string currentPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName);
            currentPath += "\\imagen";
            string fullpath = currentPath + "\\";
            p92.Image = Image.FromFile(fullpath + cursor + ".jpg");
            n4[9, 2] = cursor;
        }

        private void p93_Click(object sender, EventArgs e)
        {
            string currentPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName);
            currentPath += "\\imagen";
            string fullpath = currentPath + "\\";
            p93.Image = Image.FromFile(fullpath + cursor + ".jpg");
            n4[9, 3] = cursor;
        }

        private void p94_Click(object sender, EventArgs e)
        {
            string currentPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName);
            currentPath += "\\imagen";
            string fullpath = currentPath + "\\";
            p94.Image = Image.FromFile(fullpath + cursor + ".jpg");
            n4[9, 4] = cursor;
        }

        private void p95_Click(object sender, EventArgs e)
        {
            string currentPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName);
            currentPath += "\\imagen";
            string fullpath = currentPath + "\\";
            p95.Image = Image.FromFile(fullpath + cursor + ".jpg");
            n4[9, 5] = cursor;
        }

        private void p96_Click(object sender, EventArgs e)
        {
            string currentPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName);
            currentPath += "\\imagen";
            string fullpath = currentPath + "\\";
            p96.Image = Image.FromFile(fullpath + cursor + ".jpg");
            n4[9, 6] = cursor;
        }

        private void p97_Click(object sender, EventArgs e)
        {
            string currentPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName);
            currentPath += "\\imagen";
            string fullpath = currentPath + "\\";
            p97.Image = Image.FromFile(fullpath + cursor + ".jpg");
            n4[9, 7] = cursor;
        }

        private void p98_Click(object sender, EventArgs e)
        {
            string currentPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName);
            currentPath += "\\imagen";
            string fullpath = currentPath + "\\";
            p98.Image = Image.FromFile(fullpath + cursor + ".jpg");
            n4[9, 8] = cursor;
        }

        private void p99_Click(object sender, EventArgs e)
        {
            string currentPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName);
            currentPath += "\\imagen";
            string fullpath = currentPath + "\\";
            p99.Image = Image.FromFile(fullpath + cursor + ".jpg");
            n4[9, 9] = cursor;
        }

      
    }
}
