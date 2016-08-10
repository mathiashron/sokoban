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
    public partial class Form1 : Form
    {
        
        int[,] n4;
        int posX;
        int posY;
        int nivel = 1;
        int inicio = 0;
        int movimientos = 0;
        int movimientosmaximo;
        int strellas = 3;
        /// <summary>
        ///  Aca guardo la posicion del jugador
        /// </summary>
        struct check
        {
            public int posxcheck;
            public int posycheck;

        };

        static check[] checks;


 
        public Form1()
        {
            /// <summary>
            ///  inicio los componentes del juego.
            /// </summary>

            InitializeComponent();
            datosusuarios();
            button5.Visible = false;
                    }


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            /// <summary>
            ///  aca se realiza la funcionalidad del juego se tomas las teclas y se verifica los movimientos
            /// </summary>

            if (keyData == Keys.A)
            {
                button5.Visible = true;
            }
            if (inicio == 1)
            {
                for (int x = 0; x <= 2; x++)
                {
                    if (n4[checks[x].posxcheck, checks[x].posycheck] == 2) { }
                    else
                    {
                        n4[checks[x].posxcheck, checks[x].posycheck] = 1;
                    }
                }
                if (keyData == Keys.Down)
                {
                    
                    int posXM = posX + 1;
                    if (n4[posXM, posY] == 2)
                    {
                        int sig = posXM + 1;
                        if (n4[sig, posY] == 2 || n4[sig, posY] == 3)
                        {

                        }
                        else
                        {
                            n4[posXM, posY] = 61;
                            int ca = posXM + 1;
                            n4[ca, posY] = 2;
                            n4[posX, posY] = 5;
                            posX = posXM;
                            movimientos = movimientos + 1;
                        }
                    }
                    else
                    {
                        if (n4[posXM, posY] == 3)
                        { }
                        else
                        {

                            n4[posXM, posY] = 61;
                            n4[posX, posY] = 5;
                            posX = posXM;
                            movimientos = movimientos + 1;
                        }
                    }
                }

                if (keyData == Keys.Up)
                {
                    
                    int posXM = posX - 1;
                    if (n4[posXM, posY] == 2)
                    {

                        int ant = posXM - 1;
                        if (n4[ant, posY] == 2 || n4[ant, posY] == 3)
                        {

                        }
                        else
                        {
                            n4[posXM, posY] = 62;
                            int ca = posXM - 1;
                            n4[ca, posY] = 2;
                            n4[posX, posY] = 5;
                            posX = posXM;
                            movimientos = movimientos + 1;
                        }
                    }
                    else
                    {
                        if (n4[posXM, posY] == 3)
                        { }
                        else
                        {
                            n4[posXM, posY] = 62;
                            n4[posX, posY] = 5;
                            posX = posXM;
                            movimientos = movimientos + 1;
                        }
                    }
                }

                if (keyData == Keys.Left)
                {
                   

                    int posYM = posY - 1;

                    if (n4[posX, posYM] == 2)
                    {

                        int ant = posYM - 1;
                        if (n4[posX, ant] == 2 || n4[posX, ant] == 3)
                        {

                        }
                        else
                        {
                            n4[posX, posYM] = 63;
                            int ca = posYM - 1;
                            n4[posX, ca] = 2;
                            n4[posX, posY] = 5;
                            posY = posYM;
                            movimientos = movimientos + 1;
                        }
                    }
                    else
                    {
                        if (n4[posX, posYM] == 3)
                        { }
                        else
                        {
                            n4[posX, posYM] = 63;
                            n4[posX, posY] = 5;
                            posY = posYM;
                            movimientos = movimientos + 1;
                        }
                    }
                }
                if (keyData == Keys.Right)
                {
                    

                    int posYM = posY + 1;
                    if (n4[posX, posYM] == 2)
                    {

                        int sig = posYM + 1;
                        if (n4[posX, sig] == 2 || n4[posX, sig] == 3)
                        {

                        }
                        else
                        {
                            n4[posX, posYM] = 64;
                            int ca = posYM + 1;
                            n4[posX, ca] = 2;
                            n4[posX, posY] = 5;
                            posY = posYM;
                            movimientos = movimientos + 1;
                        }
                    }
                    else
                    {
                        if (n4[posX, posYM] == 3)
                        { }
                        else
                        {
                            n4[posX, posYM] = 64;
                            n4[posX, posY] = 5;
                            posY = posYM;
                            movimientos = movimientos + 1;
                        }
                    }
                }

                /// <summary>
                ///  verifica las estrellas.
                /// </summary>

                label7.Text = movimientos.ToString();
                

                int strellamitad = movimientosmaximo / 2 +1;
                if (movimientos == strellamitad)
                {
                    e3.Visible = false;
                    strellas = strellas - 1;
                }
                if (movimientos == (movimientosmaximo +1))
                {
                    e2.Visible = false;
                    strellas = strellas - 1;
                }


                iniciartablero();


                if (n4[checks[0].posxcheck, checks[0].posycheck] == 2 && n4[checks[1].posxcheck, checks[1].posycheck] == 2 && n4[checks[2].posxcheck, checks[2].posycheck] == 2)
                {
                    /// <summary>
                    ///  verifico que los tres check esten correctos
                    /// </summary>
                    MessageBox.Show("      Gano");
                    nivel = nivel + 1;
                    //if (nivel == 11)
                    //{
                    //    MessageBox.Show("FIN DEL JUEGO");
                    //}

                    cambionivel();
                    guardar();
                    label8.Text = nivel.ToString();


                }

            }
                return base.ProcessCmdKey(ref msg, keyData);
            
        }

        

        public void iniciartablero()
        {
            /// <summary>
            ///  se inicializa el tablero del juego
            /// </summary>
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
            e1.Image = Image.FromFile(fullpath + "7.jpg");
            e2.Image = Image.FromFile(fullpath + "7.jpg");
            e3.Image = Image.FromFile(fullpath + "7.jpg");

        }
    
        public void cambionivel()
        {
            
            /// <summary>
            ///  carga los niveles de los juegos
            /// </summary>
            movimientos = 0;
            
            label7.Text = "";

                string sql;
                string mysqlconexion = "server=mysql3.gear.host;" +
                    "Port=3306;" +
                    "Database=sokoban;" +
                    "Uid=sokoban;" +
                    "Pwd=Ms0F9o19R-!0;";

                DataTable dt = new DataTable();
                dt = new DataTable();
                string datos = "";
                sql = "select " +
                    "matriz," +
                    "pasos" +
                    " from " +
                    "niveles" +
                    " where nivel = '" +nivel+ "'";
            
                MySqlConnection mysqlconn = new MySqlConnection(mysqlconexion);
                mysqlconn.Open();

                MySqlDataAdapter mysqlda = new MySqlDataAdapter(sql, mysqlconn);
                mysqlda.Fill(dt);
                mysqlconn.Close();
            try
            {
                datos = dt.Rows[0][0].ToString();
                label5.Text = dt.Rows[0][1].ToString();

                movimientosmaximo = int.Parse(label5.Text) * 2;

                e2.Visible = true;
                e3.Visible = true;
                n4 = new int[10, 10];
                int cont = 0;
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        string letra = datos.Substring(cont, 1);
                        cont = cont + 1;
                        n4[i, j] = int.Parse(letra);
                    }
                }


                int x = 0;
                checks = new check[3];
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {

                        if (n4[i, j] == 1)
                        {
                            checks[x].posxcheck = i;
                            checks[x].posycheck = j;


                            x++;
                        }
                        if (n4[i, j] == 6)
                        {
                            posX = i;
                            posY = j;
                        }
                    }
                }
                iniciartablero();
            }
            catch
            {
                MessageBox.Show("***Gano todos los niveles***");

            }
        }
       
        public void guardar() {
            /// <summary>
            ///  guarda los datos del jugador
            /// </summary>
            string sql;
            string mysqlconexion = "server=mysql3.gear.host;" +
                "Port=3306;" +
                "Database=sokoban;" +
                "Uid=sokoban;" +
                "Pwd=Ms0F9o19R-!0;";

            DataTable dt = new DataTable();
           
            sql = "update" +
            " persona " +
            "set " +
           // "nombre  = '" + textBox2.Text + "'," +
            "nivel = '" + nivel + "'," +
            "strellas = '" + strellas + "'," +
            "pasos = '" + movimientos + "'" +
            " where nombre = '" + textBox2.Text + "'";

            MySqlConnection mysqlconn = new MySqlConnection(mysqlconexion);
            mysqlconn.Open();

            MySqlDataAdapter mysqlda = new MySqlDataAdapter(sql, mysqlconn);
            mysqlda.Fill(dt);
            mysqlconn.Close();
            strellas = strellas + 3;
            dataGridView1.DataSource = dt;

        }
         public void Form1_Load_1(object sender, EventArgs e)
        {
           

        }
        public void datosusuarios()
        {
            /// <summary>
            ///  extrae los datos de los jugadores 
            /// </summary>
            string sql;
            string mysqlconexion = "server=mysql3.gear.host;" +
                "Port=3306;" +
                "Database=sokoban;" +
                "Uid=sokoban;" +
                "Pwd=Ms0F9o19R-!0;";

            DataTable dt = new DataTable();
            dt = new DataTable();
            sql = "select " +
                "nombre" + " as Nombre," +
                "apodo" + " as Apodo," +
                "nivel" + " as Nivel," +
                "strellas" + " as Estrellas" +
                " from " +
                "persona";
               

            MySqlConnection mysqlconn = new MySqlConnection(mysqlconexion);
            mysqlconn.Open();

            MySqlDataAdapter mysqlda = new MySqlDataAdapter(sql, mysqlconn);
            mysqlda.Fill(dt);
            mysqlconn.Close();

            dataGridView1.DataSource = dt;
            
        }
        private void button2_Click(object sender, EventArgs e)
        {

            /// <summary>
            ///  boton de inicio
            /// </summary>
            label7.Visible = true;
            label1.Visible = true;
            button1.Visible = true;
            label8.Visible = true;
            label3.Visible = true;
            button3.Visible = false;
            button2.Visible = false;
            button4.Visible = false;
            label5.Visible = true;
            label6.Visible = true;
            textBox2.Enabled = false;
            textBox4.Enabled = false;
            button5.Visible = false;
            pictureBox1.Visible = false;
            e1.Visible = true;
            e2.Visible = true;
            e3.Visible = true;
            
            
            
            inicio = 1;
            nivel = int.Parse(label8.Text);
            
            if(textBox2.Text == "") {
                nivel = 1;
                textBox2.Text = "Invitado";
                label8.Text = "1";
            }

            
            dataGridView1.Visible = false;
            cambionivel();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /// <summary>
            ///  guarda los datos del juego
            /// </summary>
            try
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

                sql = "insert into Persona (" +
                    "nombre," +
                    "nivel," +
                    "pasos," +
                    "apodo" +
                    ") values (" +
                    "'" + textBox2.Text + "'," +
                    "'" + 1 + "'," +
                    "'" + 0 + "'," +
                    "'" + textBox4.Text + "'" + ")";

                mysqlconn.Open();
                mysqlcomm.Connection = mysqlconn;
                mysqlcomm.CommandText = sql;
                mysqlcomm.CommandType = CommandType.Text;
                mysqlcomm.ExecuteNonQuery();

                dataGridView1.DataSource = dt;

                datosusuarios();
            }
            catch (MySqlException)
            {
                MessageBox.Show("      Error en guardar los datos");

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            


            
            cambionivel();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                textBox2.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                label8.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                textBox4.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                



            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            /// <summary>
            ///  borra al jugador seleccionado
            /// </summary>
            string sql;
            string mysqlconexion = "server=mysql3.gear.host;" +
                "Port=3306;" +
                "Database=sokoban;" +
                "Uid=sokoban;" +
                "Pwd=Ms0F9o19R-!0;";
            MySqlConnection mysqlconn = new MySqlConnection(mysqlconexion);
            MySqlCommand mysqlcomm = new MySqlCommand();
            DataTable dt = new DataTable();

            sql = "delete from" +
            " persona " +
            " where nombre = '" + textBox2.Text + "'";

            mysqlconn.Open();
            mysqlcomm.Connection = mysqlconn;
            mysqlcomm.CommandText = sql;
            mysqlcomm.CommandType = CommandType.Text;
            mysqlcomm.ExecuteNonQuery();

            dataGridView1.DataSource = dt;

            datosusuarios();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            /// <summary>
            ///  carga para agregar mas niveles
            /// </summary>

            Form2 frmcc = new Form2();
            
            frmcc.Show();

        }
        





    }

    }

    

