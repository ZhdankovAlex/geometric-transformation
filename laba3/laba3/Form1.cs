using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba3
{
    public partial class Form1 : Form
    {
        Pen p = new Pen(Color.Black, 2);
        
        Graphics drawArea;

        List<string> redCards = new List<string> { "1Heart", "2Heart", "3Heart", "4Heart", "5Heart", "6Heart", "7Heart",
                                              "8Heart", "9Heart", "10Heart", "JHeart", "QHeart", "KHeart", "THeart",
                                              "1Diamond", "2Diamond", "3Diamond", "4Diamond", "5Diamond", "6Diamond",
                                              "7Diamond", "8Diamond", "9Diamond", "10Diamond", "JDiamond", "QDiamond",
                                              "KDiamond", "TDiamond"};
        List<string> blackCards = new List<string> { "1Club", "2Club", "3Club", "4Club", "5Club", "6Club", "7Club",
                                                "8Club", "9Club", "10Club", "JClub", "QClub", "KClub", "TClub",
                                                "1Spade", "2Spade", "3Spade", "4Spade", "5Spade", "6Spade",
                                                "7Spade", "8Spade", "9Spade", "10Spade", "JSpade", "QSpade",
                                                "KSpade", "TSpade"};

        public Form1()
        {
            InitializeComponent();
            drawArea = pictureBox1.CreateGraphics();
        }
        private void DrawFrontCard(int x, int y)
        {
            Rectangle rect = new Rectangle(x, y, 100, 150);
            SolidBrush greenBrush = new SolidBrush(Color.Green);
            drawArea.FillRectangle(greenBrush, rect);
            p = new Pen(Color.Black, 1);
            drawArea.DrawLine(p, x, y, x + 100, y);
            drawArea.DrawLine(p, x + 100, y, x + 100, y + 150);
            drawArea.DrawLine(p, x + 100, y + 150, x, y + 150);
            drawArea.DrawLine(p, x, y + 150, x, y);
        }
        private void DrawBackCard(int x, int y)
        {
            Rectangle rect = new Rectangle(x, y, 100, 150);
            SolidBrush greenBrush = new SolidBrush(Color.DarkOliveGreen);
            drawArea.FillRectangle(greenBrush, rect);
            p = new Pen(Color.Black, 1);

            drawArea.DrawLine(p, x, y, x + 100, y);
            drawArea.DrawLine(p, x + 100, y, x + 100, y + 150);
            drawArea.DrawLine(p, x + 100, y + 150, x, y + 150);
            drawArea.DrawLine(p, x, y + 150, x, y);

            drawArea.DrawLine(p, x, y + 125, x + 25, y + 150);
            drawArea.DrawLine(p, x, y + 100, x + 50, y + 150);
            drawArea.DrawLine(p, x, y + 75, x + 75, y + 150);
            drawArea.DrawLine(p, x, y + 50, x + 100, y + 150);
            drawArea.DrawLine(p, x, y + 25, x + 100, y + 125);
            drawArea.DrawLine(p, x, y, x + 100, y + 100);
            drawArea.DrawLine(p, x + 25, y, x + 100, y + 75);
            drawArea.DrawLine(p, x + 50, y, x + 100, y + 50);
            drawArea.DrawLine(p, x + 75, y, x + 100, y + 25);
        }
        private void DrawClub(int x, int y)
        {
            Pen p = new Pen(Color.Black, 3);
            drawArea.DrawLine(p, x + 20, y + 85, x + 20, y + 75);
            drawArea.DrawLine(p, x + 20, y + 75, x + 30, y + 65);
            drawArea.DrawLine(p, x + 30, y + 65, x + 35, y + 65);
            drawArea.DrawLine(p, x + 35, y + 65, x + 35, y + 55);
            drawArea.DrawLine(p, x + 35, y + 55, x + 45, y + 45);
            drawArea.DrawLine(p, x + 45, y + 45, x + 55, y + 45);
            drawArea.DrawLine(p, x + 55, y + 45, x + 65, y + 55);
            drawArea.DrawLine(p, x + 65, y + 55, x + 65, y + 65);
            drawArea.DrawLine(p, x + 65, y + 65, x + 70, y + 65);
            drawArea.DrawLine(p, x + 70, y + 65, x + 80, y + 75);
            drawArea.DrawLine(p, x + 80, y + 75, x + 80, y + 85);
            drawArea.DrawLine(p, x + 80, y + 85, x + 70, y + 95);
            drawArea.DrawLine(p, x + 70, y + 95, x + 60, y + 95);
            drawArea.DrawLine(p, x + 60, y + 95, x + 50, y + 85);
            drawArea.DrawLine(p, x + 50, y + 85, x + 40, y + 95);
            drawArea.DrawLine(p, x + 40, y + 95, x + 30, y + 95);
            drawArea.DrawLine(p, x + 30, y + 95, x + 20, y + 85);

            drawArea.DrawLine(p, x + 30, y + 105, x + 50, y + 95);
            drawArea.DrawLine(p, x + 50, y + 95, x + 70, y + 105);
            drawArea.DrawLine(p, x + 70, y + 105, x + 30, y + 105);
        }
        private void DrawSpade(int x, int y)
        {
            Pen p = new Pen(Color.Black, 3);
            drawArea.DrawLine(p, x + 20, y + 85, x + 20, y + 75);
            drawArea.DrawLine(p, x + 20, y + 75, x + 50, y + 45);
            drawArea.DrawLine(p, x + 50, y + 45, x + 80, y + 75);
            drawArea.DrawLine(p, x + 80, y + 75, x + 80, y + 85);
            drawArea.DrawLine(p, x + 80, y + 85, x + 70, y + 95);
            drawArea.DrawLine(p, x + 70, y + 95, x + 60, y + 95);
            drawArea.DrawLine(p, x + 60, y + 95, x + 50, y + 85);
            drawArea.DrawLine(p, x + 50, y + 85, x + 40, y + 95);
            drawArea.DrawLine(p, x + 40, y + 95, x + 30, y + 95);
            drawArea.DrawLine(p, x + 30, y + 95, x + 20, y + 85);

            drawArea.DrawLine(p, x + 30, y + 105, x + 50, y + 95);
            drawArea.DrawLine(p, x + 50, y + 95, x + 70, y + 105);
            drawArea.DrawLine(p, x + 70, y + 105, x + 30, y + 105);
        }
        private void DrawHeart(int x, int y)
        {
            Pen p = new Pen(Color.Red, 3);
            drawArea.DrawLine(p, x + 20, y + 75, x + 20, y + 65);
            drawArea.DrawLine(p, x + 20, y + 65, x + 30, y + 55);
            drawArea.DrawLine(p, x + 30, y + 55, x + 40, y + 55);
            drawArea.DrawLine(p, x + 40, y + 55, x + 40, y + 55);
            drawArea.DrawLine(p, x + 40, y + 55, x + 50, y + 65);
            drawArea.DrawLine(p, x + 50, y + 65, x + 60, y + 55);
            drawArea.DrawLine(p, x + 60, y + 55, x + 70, y + 55);
            drawArea.DrawLine(p, x + 70, y + 55, x + 80, y + 65);
            drawArea.DrawLine(p, x + 80, y + 65, x + 80, y + 75);
            drawArea.DrawLine(p, x + 80, y + 75, x + 50, y + 105);
            drawArea.DrawLine(p, x + 50, y + 105, x + 20, y + 75);
        }
        private void DrawDiamond(int x, int y)
        {
            Pen p = new Pen(Color.Red, 3);
            drawArea.DrawLine(p, x + 30, y + 75, x + 50, y + 45);
            drawArea.DrawLine(p, x + 50, y + 45, x + 70, y + 75);
            drawArea.DrawLine(p, x + 70, y + 75, x + 50, y + 105);
            drawArea.DrawLine(p, x + 50, y + 105, x + 30, y + 75);
        }
        private void Draw1(int x, int y)
        {
            Pen p = new Pen(Color.DarkBlue, 3);
            drawArea.DrawLine(p, x + 10, y + 10, x + 15, y + 5);
            drawArea.DrawLine(p, x + 15, y + 5, x + 15, y + 20);
        }
        private void Draw2(int x, int y)
        {
            Pen p = new Pen(Color.DarkBlue, 3);
            drawArea.DrawLine(p, x + 10, y + 5, x + 15, y + 5);
            drawArea.DrawLine(p, x + 15, y + 5, x + 15, y + 10);
            drawArea.DrawLine(p, x + 15, y + 10, x + 10, y + 10);
            drawArea.DrawLine(p, x + 10, y + 10, x + 10, y + 20);
            drawArea.DrawLine(p, x + 10, y + 20, x + 15, y + 20);
        }
        private void Draw3(int x, int y)
        {
            Pen p = new Pen(Color.DarkBlue, 3);
            drawArea.DrawLine(p, x + 10, y + 5, x + 15, y + 5);
            drawArea.DrawLine(p, x + 15, y + 5, x + 10, y + 10);
            drawArea.DrawLine(p, x + 10, y + 10, x + 15, y + 10);
            drawArea.DrawLine(p, x + 15, y + 10, x + 10, y + 20);
        }
        private void Draw4(int x, int y)
        {
            Pen p = new Pen(Color.DarkBlue, 3);
            drawArea.DrawLine(p, x + 10, y + 15, x + 15, y + 5);
            drawArea.DrawLine(p, x + 15, y + 5, x + 15, y + 20);
            drawArea.DrawLine(p, x + 10, y + 15, x + 15, y + 15);
        }
        private void Draw5(int x, int y)
        {
            Pen p = new Pen(Color.DarkBlue, 3);
            drawArea.DrawLine(p, x + 10, y + 5, x + 15, y + 5);
            drawArea.DrawLine(p, x + 15, y + 5, x + 10, y + 10);
            drawArea.DrawLine(p, x + 10, y + 10, x + 15, y + 10);
            drawArea.DrawLine(p, x + 15, y + 10, x + 15, y + 20);
            drawArea.DrawLine(p, x + 15, y + 20, x + 10, y + 20);
        }
        private void Draw6(int x, int y)
        {
            Pen p = new Pen(Color.DarkBlue, 3);
            drawArea.DrawLine(p, x + 15, y + 5, x + 10, y + 10);
            drawArea.DrawLine(p, x + 10, y + 10, x + 15, y + 10);
            drawArea.DrawLine(p, x + 15, y + 10, x + 15, y + 20);
            drawArea.DrawLine(p, x + 15, y + 20, x + 10, y + 20);
            drawArea.DrawLine(p, x + 10, y + 20, x + 10, y + 10);
        }
        private void Draw7(int x, int y)
        {
            Pen p = new Pen(Color.DarkBlue, 3);
            drawArea.DrawLine(p, x + 10, y + 5, x + 15, y + 5);
            drawArea.DrawLine(p, x + 15, y + 5, x + 10, y + 20);
        }
        private void Draw8(int x, int y)
        {
            Pen p = new Pen(Color.DarkBlue, 3);
            drawArea.DrawLine(p, x + 10, y + 5, x + 15, y + 5);
            drawArea.DrawLine(p, x + 15, y + 5, x + 15, y + 20);
            drawArea.DrawLine(p, x + 15, y + 20, x + 10, y + 20);
            drawArea.DrawLine(p, x + 10, y + 20, x + 10, y + 5);
            drawArea.DrawLine(p, x + 10, y + 10, x + 15, y + 10);
        }
        private void Draw9(int x, int y)
        {
            Pen p = new Pen(Color.DarkBlue, 3);
            drawArea.DrawLine(p, x + 10, y + 5, x + 15, y + 5);
            drawArea.DrawLine(p, x + 15, y + 5, x + 15, y + 15);
            drawArea.DrawLine(p, x + 15, y + 15, x + 10, y + 15);
            drawArea.DrawLine(p, x + 10, y + 15, x + 10, y + 5);
            drawArea.DrawLine(p, x + 15, y + 15, x + 10, y + 20);
        }
        private void Draw10(int x, int y)
        {
            Pen p = new Pen(Color.DarkBlue, 3);
            drawArea.DrawLine(p, x + 5, y + 10, x + 10, y + 5);
            drawArea.DrawLine(p, x + 10, y + 5, x + 10, y + 20);

            drawArea.DrawLine(p, x + 15, y + 5, x + 20, y + 5);
            drawArea.DrawLine(p, x + 20, y + 5, x + 20, y + 20);
            drawArea.DrawLine(p, x + 20, y + 20, x + 15, y + 20);
            drawArea.DrawLine(p, x + 15, y + 20, x + 15, y + 5);
        }
        private void DrawJ(int x, int y)
        {
            Pen p = new Pen(Color.DarkBlue, 3);
            drawArea.DrawLine(p, x + 5, y + 15, x + 5, y + 20);
            drawArea.DrawLine(p, x + 5, y + 20, x + 15, y + 15);
            drawArea.DrawLine(p, x + 15, y + 15, x + 15, y + 5);
        }
        private void DrawQ(int x, int y)
        {
            Pen p = new Pen(Color.DarkBlue, 3);
            drawArea.DrawLine(p, x + 10, y + 5, x + 15, y + 5);
            drawArea.DrawLine(p, x + 15, y + 5, x + 15, y + 15);
            drawArea.DrawLine(p, x + 15, y + 15, x + 10, y + 15);
            drawArea.DrawLine(p, x + 10, y + 15, x + 10, y + 5);
            drawArea.DrawLine(p, x + 15, y + 15, x + 20, y + 20);
        }
        private void DrawK(int x, int y)
        {
            Pen p = new Pen(Color.DarkBlue, 3);
            drawArea.DrawLine(p, x + 10, y + 5, x + 10, y + 20);
            drawArea.DrawLine(p, x + 10, y + 10, x + 15, y + 5);
            drawArea.DrawLine(p, x + 10, y + 10, x + 15, y + 20);
        }
        private void DrawT(int x, int y)
        {
            Pen p = new Pen(Color.DarkBlue, 3);
            drawArea.DrawLine(p, x + 5, y + 5, x + 15, y + 5);
            drawArea.DrawLine(p, x + 10, y + 5, x + 10, y + 20);
        }
        string RandomCard()
        {
            Random rnd = new Random();
            if(rnd.Next(1, 3) == 1) return redCards[rnd.Next(0, redCards.Count())];
            else return blackCards[rnd.Next(0, blackCards.Count())];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            drawArea.FillRectangle(Brushes.White, 0, 0, pictureBox1.Width, pictureBox1.Height);

            HashSet<string> usedCards = new HashSet<string>();              
           
            for (int i = 50; i<350; i+=50)
            {
                DrawFrontCard(i, i);
                string currentCard = RandomCard();
                while (usedCards.Contains(currentCard))
                {
                    currentCard = RandomCard();
                }
                switch (currentCard)
                {
                    case ("1Heart"):
                        DrawHeart(i,i);
                        Draw1(i,i);
                        usedCards.Add("1Heart");
                        break;
                    case ("2Heart"):
                        DrawHeart(i, i);
                        Draw2(i, i);
                        usedCards.Add("2Heart");
                        break;
                    case ("3Heart"):
                        DrawHeart(i, i);
                        Draw3(i, i);
                        usedCards.Add("3Heart");
                        break;
                    case ("4Heart"):
                        DrawHeart(i, i);
                        Draw4(i, i);
                        usedCards.Add("4Heart");
                        break;
                    case ("5Heart"):
                        DrawHeart(i, i);
                        Draw5(i, i);
                        usedCards.Add("5Heart");
                        break;
                    case ("6Heart"):
                        DrawHeart(i, i);
                        Draw6(i, i);
                        usedCards.Add("6Heart");
                        break;
                    case ("7Heart"):
                        DrawHeart(i, i);
                        Draw7(i, i);
                        usedCards.Add("7Heart");
                        break;
                    case ("8Heart"):
                        DrawHeart(i, i);
                        Draw8(i, i);
                        usedCards.Add("8Heart");
                        break;
                    case ("9Heart"):
                        DrawHeart(i, i);
                        Draw9(i, i);
                        usedCards.Add("9Heart");
                        break;
                    case ("10Heart"):
                        DrawHeart(i, i);
                        Draw10(i, i);
                        usedCards.Add("10Heart");
                        break;
                    case ("JHeart"):
                        DrawHeart(i, i);
                        DrawJ(i, i);
                        usedCards.Add("JHeart");
                        break;
                    case ("QHeart"):
                        DrawHeart(i, i);
                        DrawQ(i, i);
                        usedCards.Add("QHeart");
                        break;
                    case ("KHeart"):
                        DrawHeart(i, i);
                        DrawK(i, i);
                        usedCards.Add("KHeart");
                        break;
                    case ("THeart"):
                        DrawHeart(i, i);
                        DrawT(i, i);
                        usedCards.Add("THeart");
                        break;
                    case ("1Diamond"):
                        DrawDiamond(i, i);
                        Draw1(i, i);
                        usedCards.Add("1Diamond");
                        break;
                    case ("2Diamond"):
                        DrawDiamond(i, i);
                        Draw2(i, i);
                        usedCards.Add("2Diamond");
                        break;
                    case ("3Diamond"):
                        DrawDiamond(i, i);
                        Draw3(i, i);
                        usedCards.Add("3Diamond");
                        break;
                    case ("4Diamond"):
                        DrawDiamond(i, i);
                        Draw4(i, i);
                        usedCards.Add("4Diamond");
                        break;
                    case ("5Diamond"):
                        DrawDiamond(i, i);
                        Draw5(i, i);
                        usedCards.Add("5Diamond");
                        break;
                    case ("6Diamond"):
                        DrawDiamond(i, i);
                        Draw6(i, i);
                        usedCards.Add("6Diamond");
                        break;
                    case ("7Diamond"):
                        DrawDiamond(i, i);
                        Draw7(i, i);
                        usedCards.Add("7Diamond");
                        break;
                    case ("8Diamond"):
                        DrawDiamond(i, i);
                        Draw8(i, i);
                        usedCards.Add("8Diamond");
                        break;
                    case ("9Diamond"):
                        DrawDiamond(i, i);
                        Draw9(i, i);
                        usedCards.Add("9Diamond");
                        break;
                    case ("10Diamond"):
                        DrawDiamond(i, i);
                        Draw10(i, i);
                        usedCards.Add("10Diamond");
                        break;
                    case ("JDiamond"):
                        DrawDiamond(i, i);
                        DrawJ(i, i);
                        usedCards.Add("JDiamond");
                        break;
                    case ("QDiamond"):
                        DrawDiamond(i, i);
                        DrawQ(i, i);
                        usedCards.Add("QDiamond");
                        break;
                    case ("KDiamond"):
                        DrawDiamond(i, i);
                        DrawK(i, i);
                        usedCards.Add("KDiamond");
                        break;
                    case ("TDiamond"):
                        DrawDiamond(i, i);
                        DrawT(i, i);
                        usedCards.Add("TDiamond");
                        break;
                    case ("1Club"):
                        DrawClub(i, i);
                        Draw1(i, i);
                        usedCards.Add("1Club");
                        break;
                    case ("2Club"):
                        DrawClub(i, i);
                        Draw2(i, i);
                        usedCards.Add("2Club");
                        break;
                    case ("3Club"):
                        DrawClub(i, i);
                        Draw3(i, i);
                        usedCards.Add("3Club");
                        break;
                    case ("4Club"):
                        DrawClub(i, i);
                        Draw4(i, i);
                        usedCards.Add("4Club");
                        break;
                    case ("5Club"):
                        DrawClub(i, i);
                        Draw5(i, i);
                        usedCards.Add("5Club");
                        break;
                    case ("6Club"):
                        DrawClub(i, i);
                        Draw6(i, i);
                        usedCards.Add("6Club");
                        break;
                    case ("7Club"):
                        DrawClub(i, i);
                        Draw7(i, i);
                        usedCards.Add("7Club");
                        break;
                    case ("8Club"):
                        DrawClub(i, i);
                        Draw8(i, i);
                        usedCards.Add("8Club");
                        break;
                    case ("9Club"):
                        DrawClub(i, i);
                        Draw9(i, i);
                        usedCards.Add("9Club");
                        break;
                    case ("10Club"):
                        DrawClub(i, i);
                        Draw10(i, i);
                        usedCards.Add("10Club");
                        break;
                    case ("JClub"):
                        DrawClub(i, i);
                        DrawJ(i, i);
                        usedCards.Add("JClub");
                        break;
                    case ("QClub"):
                        DrawClub(i, i);
                        DrawQ(i, i);
                        usedCards.Add("QClub");
                        break;
                    case ("KClub"):
                        DrawClub(i, i);
                        DrawK(i, i);
                        usedCards.Add("KClub");
                        break;
                    case ("TClub"):
                        DrawClub(i, i);
                        DrawT(i, i);
                        usedCards.Add("TClub");
                        break;
                    case ("1Spade"):
                        DrawSpade(i, i);
                        Draw1(i, i);
                        usedCards.Add("1Spade");
                        break;
                    case ("2Spade"):
                        DrawSpade(i, i);
                        Draw2(i, i);
                        usedCards.Add("2Spade");
                        break;
                    case ("3Spade"):
                        DrawSpade(i, i);
                        Draw3(i, i);
                        usedCards.Add("3Spade");
                        break;
                    case ("4Spade"):
                        DrawSpade(i, i);
                        Draw4(i, i);
                        usedCards.Add("4Spade");
                        break;
                    case ("5Spade"):
                        DrawSpade(i, i);
                        Draw5(i, i);
                        usedCards.Add("5Spade");
                        break;
                    case ("6Spade"):
                        DrawSpade(i, i);
                        Draw6(i, i);
                        usedCards.Add("6Spade");
                        break;
                    case ("7Spade"):
                        DrawSpade(i, i);
                        Draw7(i, i);
                        usedCards.Add("7Spade");
                        break;
                    case ("8Spade"):
                        DrawSpade(i, i);
                        Draw8(i, i);
                        usedCards.Add("8Spade");
                        break;
                    case ("9Spade"):
                        DrawSpade(i, i);
                        Draw9(i, i);
                        usedCards.Add("9Spade");
                        break;
                    case ("10Spade"):
                        DrawSpade(i, i);
                        Draw10(i, i);
                        usedCards.Add("10Spade");
                        break;
                    case ("JSpade"):
                        DrawSpade(i, i);
                        DrawJ(i, i);
                        usedCards.Add("JSpade");
                        break;
                    case ("QSpade"):
                        DrawSpade(i, i);
                        DrawQ(i, i);
                        usedCards.Add("QSpade");
                        break;
                    case ("KSpade"):
                        DrawSpade(i, i);
                        DrawK(i, i);
                        usedCards.Add("KSpade");
                        break;
                    case ("TSpade"):
                        DrawSpade(i, i);
                        DrawT(i, i);
                        usedCards.Add("TSpade");
                        break;
                    default:
                        break;
                }
                System.Threading.Thread.Sleep(500);
            }
        }
    }
}
