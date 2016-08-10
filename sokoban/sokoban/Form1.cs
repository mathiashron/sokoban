using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sokoban
{
    public partial class Form1 : Form
    {

        int[,] n4 = new int[10, 10] {
                { 3,3,3,3,3,3,3,3,3,3},
                { 3,1,5,5,5,5,5,5,3,3},
                { 3,5,2,5,5,3,5,5,5,3},
                { 3,5,5,5,5,5,5,5,5,3},
                { 3,5,5,5,5,5,5,5,5,3},
                { 3,5,2,5,5,1,5,3,3,3},
                { 3,5,5,6,5,1,5,3,3,3},
                { 3,5,2,5,5,5,3,3,3,3},
                { 3,5,5,5,3,3,3,3,3,3},
                { 3,3,3,3,3,3,3,3,3,3} };
        int[,] n5 = new int[10, 10];






        int posX;
        int posY;
        int posXant;
        int posYant;
        int posXant2;
        int posYant2;
        int cont;

        int movimientos = 0;
        struct check
        {
            public int posxcheck;
            public int posycheck;

        };

        static check[] checks;

        public Form1()
        {
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

            InitializeComponent();
            

        }


        private void AKeyDown(object sender, KeyEventArgs e)
        {
            string result = e.KeyData.ToString();

            switch (result)
            {
                case "Up":
                    //MoveSokoban(MoveDirection.Up);
                    break;
                case "Down":
                    movimientos = movimientos + 1;


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
                        }
                    }
                    else
                    {
                        if (n4[posXM, posY] == 3)
                        {

                        }
                        else
                        {

                            n4[posXM, posY] = 61;
                            n4[posX, posY] = 5;
                            posX = posXM;
                        }
                    }



            
            break;
                case "Right":
                   // MoveSokoban(MoveDirection.Right);
                    break;
                case "Left":
                   // MoveSokoban(MoveDirection.Left);
                    break;
                case "U":
                   // DrawUndo();
                    break;
            }
        }

        //private void InitializeGame()
        //{

        //    Keys keyData;
        //    for (int x = 0; x < 10; x++)
        //    {
        //        for (int j = 0; j < 10; j++)
        //        {
        //            n5[x, j] = n4[x, j];
        //        }
        //    }

        //    for (int x = 0; x <= 2; x++)
        //    {
        //        if (n4[checks[x].posxcheck, checks[x].posycheck] == 2) { }
        //        else
        //        {
        //            n4[checks[x].posxcheck, checks[x].posycheck] = 1;
        //        }
        //    }
        //    if (keyData == Keys.Down)
        //    {
        //        movimientos = movimientos + 1;


        //        int posXM = posX + 1;


        //        if (n4[posXM, posY] == 2)
        //        {

        //            int sig = posXM + 1;
        //            if (n4[sig, posY] == 2 || n4[sig, posY] == 3)
        //            {

        //            }
        //            else
        //            {
        //                n4[posXM, posY] = 61;
        //                int ca = posXM + 1;
        //                n4[ca, posY] = 2;
        //                n4[posX, posY] = 5;
        //                posX = posXM;
        //            }
        //        }
        //        else
        //        {
        //            if (n4[posXM, posY] == 3)
        //            {

        //            }
        //            else
        //            {

        //                n4[posXM, posY] = 61;
        //                n4[posX, posY] = 5;
        //                posX = posXM;
        //            }
        //        }



        //    }

        //    if (keyData == Keys.Up)
        //    {
        //        movimientos = movimientos + 1;

        //        int posXM = posX - 1;
        //        if (n4[posXM, posY] == 2)
        //        {

        //            int ant = posXM - 1;
        //            if (n4[ant, posY] == 2 || n4[ant, posY] == 3)
        //            {

        //            }
        //            else
        //            {
        //                n4[posXM, posY] = 62;
        //                int ca = posXM - 1;
        //                n4[ca, posY] = 2;
        //                n4[posX, posY] = 5;
        //                posX = posXM;
        //            }
        //        }
        //        else
        //        {
        //            if (n4[posXM, posY] == 3)
        //            {

        //            }
        //            else
        //            {

        //                n4[posXM, posY] = 62;
        //                n4[posX, posY] = 5;
        //                posX = posXM;
        //            }

        //        }


        //    }

        //    if (keyData == Keys.Left)
        //    {
        //        movimientos = movimientos + 1;

        //        int posYM = posY - 1;

        //        if (n4[posX, posYM] == 2)
        //        {

        //            int ant = posYM - 1;
        //            if (n4[posX, ant] == 2 || n4[posX, ant] == 3)
        //            {

        //            }
        //            else
        //            {
        //                n4[posX, posYM] = 63;
        //                int ca = posYM - 1;
        //                n4[posX, ca] = 2;
        //                n4[posX, posY] = 5;
        //                posY = posYM;
        //            }
        //        }
        //        else
        //        {
        //            if (n4[posX, posYM] == 3)
        //            {

        //            }
        //            else
        //            {

        //                n4[posX, posYM] = 63;
        //                n4[posX, posY] = 5;
        //                posY = posYM;
        //            }

        //        }



        //    }
        //    if (keyData == Keys.Right)
        //    {
        //        movimientos = movimientos + 1;

        //        int posYM = posY + 1;
        //        if (n4[posX, posYM] == 2)
        //        {

        //            int sig = posYM + 1;
        //            if (n4[posX, sig] == 2 || n4[posX, sig] == 3)
        //            {

        //            }
        //            else
        //            {
        //                n4[posX, posYM] = 64;
        //                int ca = posYM + 1;
        //                n4[posX, ca] = 2;
        //                n4[posX, posY] = 5;
        //                posY = posYM;
        //            }
        //        }
        //        else
        //        {
        //            if (n4[posX, posYM] == 3)
        //            {

        //            }
        //            else
        //            {

        //                n4[posX, posYM] = 64;
        //                n4[posX, posY] = 5;
        //                posY = posYM;
        //            }


        //        }



        //    }

        //    textBox1.Text = movimientos.ToString();
        //    string currentPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName);
        //    currentPath += "\\imagen";

        //    string fullpath = currentPath + "\\";




        //    p00.Image = Image.FromFile(fullpath + n4[0, 0] + ".jpg");
        //    p01.Image = Image.FromFile(fullpath + n4[0, 1] + ".jpg");
        //    p02.Image = Image.FromFile(fullpath + n4[0, 2] + ".jpg");
        //    p03.Image = Image.FromFile(fullpath + n4[0, 3] + ".jpg");
        //    p04.Image = Image.FromFile(fullpath + n4[0, 4] + ".jpg");
        //    p05.Image = Image.FromFile(fullpath + n4[0, 5] + ".jpg");
        //    p06.Image = Image.FromFile(fullpath + n4[0, 6] + ".jpg");
        //    p07.Image = Image.FromFile(fullpath + n4[0, 7] + ".jpg");
        //    p08.Image = Image.FromFile(fullpath + n4[0, 8] + ".jpg");
        //    p09.Image = Image.FromFile(fullpath + n4[0, 9] + ".jpg");
        //    p10.Image = Image.FromFile(fullpath + n4[1, 0] + ".jpg");
        //    p11.Image = Image.FromFile(fullpath + n4[1, 1] + ".jpg");
        //    p12.Image = Image.FromFile(fullpath + n4[1, 2] + ".jpg");
        //    p13.Image = Image.FromFile(fullpath + n4[1, 3] + ".jpg");
        //    p14.Image = Image.FromFile(fullpath + n4[1, 4] + ".jpg");
        //    p15.Image = Image.FromFile(fullpath + n4[1, 5] + ".jpg");
        //    p16.Image = Image.FromFile(fullpath + n4[1, 6] + ".jpg");
        //    p17.Image = Image.FromFile(fullpath + n4[1, 7] + ".jpg");
        //    p18.Image = Image.FromFile(fullpath + n4[1, 8] + ".jpg");
        //    p19.Image = Image.FromFile(fullpath + n4[1, 9] + ".jpg");
        //    p20.Image = Image.FromFile(fullpath + n4[2, 0] + ".jpg");
        //    p21.Image = Image.FromFile(fullpath + n4[2, 1] + ".jpg");
        //    p22.Image = Image.FromFile(fullpath + n4[2, 2] + ".jpg");
        //    p23.Image = Image.FromFile(fullpath + n4[2, 3] + ".jpg");
        //    p24.Image = Image.FromFile(fullpath + n4[2, 4] + ".jpg");
        //    p25.Image = Image.FromFile(fullpath + n4[2, 5] + ".jpg");
        //    p26.Image = Image.FromFile(fullpath + n4[2, 6] + ".jpg");
        //    p27.Image = Image.FromFile(fullpath + n4[2, 7] + ".jpg");
        //    p28.Image = Image.FromFile(fullpath + n4[2, 8] + ".jpg");
        //    p29.Image = Image.FromFile(fullpath + n4[2, 9] + ".jpg");
        //    p30.Image = Image.FromFile(fullpath + n4[3, 0] + ".jpg");
        //    p31.Image = Image.FromFile(fullpath + n4[3, 1] + ".jpg");
        //    p32.Image = Image.FromFile(fullpath + n4[3, 2] + ".jpg");
        //    p33.Image = Image.FromFile(fullpath + n4[3, 3] + ".jpg");
        //    p34.Image = Image.FromFile(fullpath + n4[3, 4] + ".jpg");
        //    p35.Image = Image.FromFile(fullpath + n4[3, 5] + ".jpg");
        //    p36.Image = Image.FromFile(fullpath + n4[3, 6] + ".jpg");
        //    p37.Image = Image.FromFile(fullpath + n4[3, 7] + ".jpg");
        //    p38.Image = Image.FromFile(fullpath + n4[3, 8] + ".jpg");
        //    p39.Image = Image.FromFile(fullpath + n4[3, 9] + ".jpg");
        //    p40.Image = Image.FromFile(fullpath + n4[4, 0] + ".jpg");
        //    p41.Image = Image.FromFile(fullpath + n4[4, 1] + ".jpg");
        //    p42.Image = Image.FromFile(fullpath + n4[4, 2] + ".jpg");
        //    p43.Image = Image.FromFile(fullpath + n4[4, 3] + ".jpg");
        //    p44.Image = Image.FromFile(fullpath + n4[4, 4] + ".jpg");
        //    p45.Image = Image.FromFile(fullpath + n4[4, 5] + ".jpg");
        //    p46.Image = Image.FromFile(fullpath + n4[4, 6] + ".jpg");
        //    p47.Image = Image.FromFile(fullpath + n4[4, 7] + ".jpg");
        //    p48.Image = Image.FromFile(fullpath + n4[4, 8] + ".jpg");
        //    p49.Image = Image.FromFile(fullpath + n4[4, 9] + ".jpg");
        //    p50.Image = Image.FromFile(fullpath + n4[5, 0] + ".jpg");
        //    p51.Image = Image.FromFile(fullpath + n4[5, 1] + ".jpg");
        //    p52.Image = Image.FromFile(fullpath + n4[5, 2] + ".jpg");
        //    p53.Image = Image.FromFile(fullpath + n4[5, 3] + ".jpg");
        //    p54.Image = Image.FromFile(fullpath + n4[5, 4] + ".jpg");
        //    p55.Image = Image.FromFile(fullpath + n4[5, 5] + ".jpg");
        //    p56.Image = Image.FromFile(fullpath + n4[5, 6] + ".jpg");
        //    p57.Image = Image.FromFile(fullpath + n4[5, 7] + ".jpg");
        //    p58.Image = Image.FromFile(fullpath + n4[5, 8] + ".jpg");
        //    p59.Image = Image.FromFile(fullpath + n4[5, 9] + ".jpg");
        //    p60.Image = Image.FromFile(fullpath + n4[6, 0] + ".jpg");
        //    p61.Image = Image.FromFile(fullpath + n4[6, 1] + ".jpg");
        //    p62.Image = Image.FromFile(fullpath + n4[6, 2] + ".jpg");
        //    p63.Image = Image.FromFile(fullpath + n4[6, 3] + ".jpg");
        //    p64.Image = Image.FromFile(fullpath + n4[6, 4] + ".jpg");
        //    p65.Image = Image.FromFile(fullpath + n4[6, 5] + ".jpg");
        //    p66.Image = Image.FromFile(fullpath + n4[6, 6] + ".jpg");
        //    p67.Image = Image.FromFile(fullpath + n4[6, 7] + ".jpg");
        //    p68.Image = Image.FromFile(fullpath + n4[6, 8] + ".jpg");
        //    p69.Image = Image.FromFile(fullpath + n4[6, 9] + ".jpg");
        //    p70.Image = Image.FromFile(fullpath + n4[7, 0] + ".jpg");
        //    p71.Image = Image.FromFile(fullpath + n4[7, 1] + ".jpg");
        //    p72.Image = Image.FromFile(fullpath + n4[7, 2] + ".jpg");
        //    p73.Image = Image.FromFile(fullpath + n4[7, 3] + ".jpg");
        //    p74.Image = Image.FromFile(fullpath + n4[7, 4] + ".jpg");
        //    p75.Image = Image.FromFile(fullpath + n4[7, 5] + ".jpg");
        //    p76.Image = Image.FromFile(fullpath + n4[7, 6] + ".jpg");
        //    p77.Image = Image.FromFile(fullpath + n4[7, 7] + ".jpg");
        //    p78.Image = Image.FromFile(fullpath + n4[7, 8] + ".jpg");
        //    p79.Image = Image.FromFile(fullpath + n4[7, 9] + ".jpg");
        //    p80.Image = Image.FromFile(fullpath + n4[8, 0] + ".jpg");
        //    p81.Image = Image.FromFile(fullpath + n4[8, 1] + ".jpg");
        //    p82.Image = Image.FromFile(fullpath + n4[8, 2] + ".jpg");
        //    p83.Image = Image.FromFile(fullpath + n4[8, 3] + ".jpg");
        //    p84.Image = Image.FromFile(fullpath + n4[8, 4] + ".jpg");
        //    p85.Image = Image.FromFile(fullpath + n4[8, 5] + ".jpg");
        //    p86.Image = Image.FromFile(fullpath + n4[8, 6] + ".jpg");
        //    p87.Image = Image.FromFile(fullpath + n4[8, 7] + ".jpg");
        //    p88.Image = Image.FromFile(fullpath + n4[8, 8] + ".jpg");
        //    p89.Image = Image.FromFile(fullpath + n4[8, 9] + ".jpg");
        //    p90.Image = Image.FromFile(fullpath + n4[9, 0] + ".jpg");
        //    p91.Image = Image.FromFile(fullpath + n4[9, 1] + ".jpg");
        //    p92.Image = Image.FromFile(fullpath + n4[9, 2] + ".jpg");
        //    p93.Image = Image.FromFile(fullpath + n4[9, 3] + ".jpg");
        //    p94.Image = Image.FromFile(fullpath + n4[9, 4] + ".jpg");
        //    p95.Image = Image.FromFile(fullpath + n4[9, 5] + ".jpg");
        //    p96.Image = Image.FromFile(fullpath + n4[9, 6] + ".jpg");
        //    p97.Image = Image.FromFile(fullpath + n4[9, 7] + ".jpg");
        //    p98.Image = Image.FromFile(fullpath + n4[9, 8] + ".jpg");
        //    p99.Image = Image.FromFile(fullpath + n4[9, 9] + ".jpg");


        //    if (n4[checks[0].posxcheck, checks[0].posycheck] == 2 && n4[checks[1].posxcheck, checks[1].posycheck] == 2 && n4[checks[2].posxcheck, checks[2].posycheck] == 2)
        //    {
        //        MessageBox.Show("Gano");
        //    }



        //}





        private void Form1_Load_1(object sender, EventArgs e)
        {
            string currentPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName);
            currentPath += "\\imagen";
            //string nombrefile = n4[0, 0] + ".jpg";
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
            for (int x = 0; x < 10; x++)
            {
                for (int j = 0; j < 10; j++)
                {
                    n5[x, j] = n4[x, j];
                }
            }

            for (int x = 0; x <= 2; x++)
            {
                if (n4[checks[x].posxcheck, checks[x].posycheck] == 2) { }
                else
                {
                    n4[checks[x].posxcheck, checks[x].posycheck] = 1;
                }
            }

        }


    }

    }

    

