using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Merida_Gui
{

    public partial class Form1 : Form
    {
        public
            sbyte[,] cNegre = new sbyte[8, 8];
            bool FetOrigen = false;
            bool FetDesti = false;
            bool QuiJuga = true;

        private
            int OrigenX, OrigenY;
            int DestiX, DestiY;
            Posicio mainPos;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Bt_Sortir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitPos();
        }

       private void Form1_Paint(object sender, EventArgs e)
        {
           // DibuixaTauler();
        }

       public string figMouAPrint(sbyte pieza)
        {
            string surt = "";

            switch (pieza)
            {
                case 6:
                case -6:
                    surt = "R";
                    break;

                case 5:
                case -5:
                    surt = "D";
                    break;

                case 4:
                case -4:
                    surt = "T";
                    break;

                case 3:
                case -3:
                    surt = "A";
                    break;

                case 2:
                case -2:
                    surt = "C";
                    break;

                default:
                    surt = "";
                    break;

            }
            return surt;
        }
   

        public void InitPos()
        {
            int i, j;

            for (i = 0; i < 8; i++)
            {
                for (j = 0; j < 8; j++)
                {
                    cNegre[i, j] = (i + j) % 2 == 0 ? (sbyte)0 : (sbyte)1;
                }
            }
                
            mainPos.posicioInicial();
            Rb_Blanc.Checked = true;
            Rb_Negre.Checked = false;

        }

        private void DibuixaCassella(int row, int col)
        {
            Graphics meuBoard;
            int tamanyX;
            int tamanyY;
            int fila;
            int columna;

            fila = row;
            columna = col;

            meuBoard = Panel1.CreateGraphics();
            tamanyX = ImageList1.Images[0].Width;
            tamanyY = ImageList1.Images[0].Height;

            switch (tauler[fila, columna])
            {

                case Rb:
                    if (cNegre[fila, columna] == 1)
                        meuBoard.DrawImage(ImageList1.Images[1], columna * tamanyX, fila * tamanyY);
                    else
                        meuBoard.DrawImage(ImageList1.Images[0], columna * tamanyX, fila * tamanyY);

                    break;

                case Db:
                    if (cNegre[fila, columna] == 1)
                        meuBoard.DrawImage(ImageList1.Images[3], columna * tamanyX, fila * tamanyY);
                    else
                        meuBoard.DrawImage(ImageList1.Images[2], columna * tamanyX, fila * tamanyY);

                    break;

                case Tb:
                    if (cNegre[fila, columna] == 1)
                        meuBoard.DrawImage(ImageList1.Images[5], columna * tamanyX, fila * tamanyY);
                    else
                        meuBoard.DrawImage(ImageList1.Images[4], columna * tamanyX, fila * tamanyY);

                    break;

                case Ab:
                    if (cNegre[fila, columna] == 1)
                        meuBoard.DrawImage(ImageList1.Images[7], columna * tamanyX, fila * tamanyY);
                    else
                        meuBoard.DrawImage(ImageList1.Images[6], columna * tamanyX, fila * tamanyY);

                    break;

                case Cb:
                    if (cNegre[fila, columna] == 1)
                        meuBoard.DrawImage(ImageList1.Images[9], columna * tamanyX, fila * tamanyY);
                    else
                        meuBoard.DrawImage(ImageList1.Images[8], columna * tamanyX, fila * tamanyY);

                    break;

                case Pb:
                    if (cNegre[fila, columna] == 1)
                        meuBoard.DrawImage(ImageList1.Images[11], columna * tamanyX, fila * tamanyY);
                    else
                        meuBoard.DrawImage(ImageList1.Images[10], columna * tamanyX, fila * tamanyY);

                    break;

                case Rn:
                    if (cNegre[fila, columna] == 1)
                        meuBoard.DrawImage(ImageList1.Images[13], columna * tamanyX, fila * tamanyY);
                    else
                        meuBoard.DrawImage(ImageList1.Images[12], columna * tamanyX, fila * tamanyY);

                    break;

                case Dn:
                    if (cNegre[fila, columna] == 1)
                        meuBoard.DrawImage(ImageList1.Images[15], columna * tamanyX, fila * tamanyY);
                    else
                        meuBoard.DrawImage(ImageList1.Images[14], columna * tamanyX, fila * tamanyY);

                    break;

                case Tn:
                    if (cNegre[fila, columna] == 1)
                        meuBoard.DrawImage(ImageList1.Images[17], columna * tamanyX, fila * tamanyY);
                    else
                        meuBoard.DrawImage(ImageList1.Images[16], columna * tamanyX, fila * tamanyY);

                    break;

                case An:
                    if (cNegre[fila, columna] == 1)
                        meuBoard.DrawImage(ImageList1.Images[19], columna * tamanyX, fila * tamanyY);
                    else
                        meuBoard.DrawImage(ImageList1.Images[18], columna * tamanyX, fila * tamanyY);

                    break;

                case Cn:
                    if (cNegre[fila, columna] == 1)
                        meuBoard.DrawImage(ImageList1.Images[21], columna * tamanyX, fila * tamanyY);
                    else
                        meuBoard.DrawImage(ImageList1.Images[20], columna * tamanyX, fila * tamanyY);

                    break;

                case Pn:
                    if (cNegre[fila, columna] == 1)
                        meuBoard.DrawImage(ImageList1.Images[23], columna * tamanyX, fila * tamanyY);
                    else
                        meuBoard.DrawImage(ImageList1.Images[22], columna * tamanyX, fila * tamanyY);

                    break;

                default:
                    if (cNegre[fila, columna] == 1)
                        meuBoard.DrawImage(ImageList1.Images[25], columna * tamanyX, fila * tamanyY);
                    else
                        meuBoard.DrawImage(ImageList1.Images[24], columna * tamanyX, fila * tamanyY);

                    break;
            }

            meuBoard.Dispose();

        }


        private void DibuixaTauler()
        {
            Graphics meuBoard;
            int fila;
            int columna;
            int tamanyX;
            int tamanyY;

            meuBoard = Panel1.CreateGraphics();

            tamanyX = ImageList1.Images[0].Width;
            tamanyY = ImageList1.Images[0].Height;

            for (fila = 0; fila < 8; fila++)
            {
                for (columna = 0; columna < 8; columna++)
                {
                    DibuixaCassella(fila, columna);
                }
            }

            meuBoard.Dispose();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            DibuixaTauler();
        }

      
        private void Panel1_MouseClick_1(object sender, EventArgs e)
        {
            string fila = "";
            string columna = "";
            int SizeSquare = 36;
            int i, j;

            i = (Panel1.PointToClient(Cursor.Position).X) / SizeSquare;
            j = (Panel1.PointToClient(Cursor.Position).Y) / SizeSquare;

            fila = (8 - j).ToString();

            switch (i + 1)
            {

                case 1:
                    columna = "a";
                    break;
                case 2:
                    columna = "b";
                    break;
                case 3:
                    columna = "c";
                    break;
                case 4:
                    columna = "d";
                    break;
                case 5:
                    columna = "e";
                    break;
                case 6:
                    columna = "f";
                    break;
                case 7:
                    columna = "g";
                    break;
                case 8:
                    columna = "h";
                    break;

                default:
                    columna = "x";
                    break;
            }

            
            

            if (FetOrigen == false)
            {
                // un torn mes
                ply++;

                OrigenX = j;
                OrigenY = i;
                FetOrigen = true;
                DibuixaQuadrat(i, j);

                figMou = tauler[OrigenX, OrigenY];
                
                if ((ply+1)%2 != 0)
                    tb_PGN.Text = tb_PGN.Text + ((ply + 1) / 2) + "." + figMouAPrint(figMou);
                else
                    tb_PGN.Text = tb_PGN.Text + figMouAPrint(figMou);

            }
            else
            {
                
                DestiX = j;
                DestiY = i;
                FetOrigen = false;
                tauler[DestiX, DestiY] = tauler[OrigenX, OrigenY];
                tauler[OrigenX, OrigenY] = 0;
                DibuixaCassella(OrigenX, OrigenY);
                DibuixaCassella(DestiX, DestiY);

               tb_PGN.Text = tb_PGN.Text + columna + fila + " ";
            }

            
        }


        private void DibuixaQuadrat(int col, int row)
        {
            Graphics meuBoard;
            int tamanyX, tamanyY;
            int fila, columna;

            fila = row;
            columna = col;

            meuBoard = Panel1.CreateGraphics();
            tamanyX = ImageList1.Images[0].Width;
            tamanyY = ImageList1.Images[0].Height;
            meuBoard.DrawRectangle(Pens.Blue, columna * tamanyY + 1, fila * tamanyX + 1, 32, 32);
            meuBoard.Dispose();
        }

    }



}


