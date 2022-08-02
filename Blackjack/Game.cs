using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Blackjack
{
    public partial class Game : Form
    {

        int moneyBet;
        int playerCount;
        int dealerCount;
        int playerCards;
        int dealerCards;

        Image[,] img = new Image[13,4];
        bool[,] used = new bool[13, 4];
        Random random = new Random();
        

        public Game()
        {
            SetBalance sb = new SetBalance();
            sb.ShowDialog();
                    
            InitializeComponent();
            
            labelMoney.Text = sb.money.ToString();
            buttonHit.Visible = false;
            buttonStand.Visible = false;
            buttonRestart.Visible = false;

            pictureBoxD1.Visible = false;
            pictureBoxD2.Visible = false;
            pictureBoxD3.Visible = false;
            pictureBoxD4.Visible = false;
            pictureBoxD5.Visible = false;
            pictureBoxD6.Visible = false;
            pictureBoxD7.Visible = false;
            pictureBoxD8.Visible = false;
            pictureBoxD9.Visible = false;

            pictureBoxP1.Visible = false;
            pictureBoxP2.Visible = false;
            pictureBoxP3.Visible = false;
            pictureBoxP4.Visible = false;
            pictureBoxP5.Visible = false;
            pictureBoxP6.Visible = false;
            pictureBoxP7.Visible = false;
            pictureBoxP8.Visible = false;
            pictureBoxP9.Visible = false;


            img[0, 0] = Image.FromFile("as-1.jpg");
            img[0, 1] = Image.FromFile("as-2.jpg");
            img[0, 2] = Image.FromFile("as-3.jpg");
            img[0, 3] = Image.FromFile("as-4.jpg");

            img[1, 0] = Image.FromFile("2-1.jpg");
            img[1, 1] = Image.FromFile("2-2.jpg");
            img[1, 2] = Image.FromFile("2-3.jpg");
            img[1, 3] = Image.FromFile("2-4.jpg");

            img[2, 0] = Image.FromFile("3-1.jpg");
            img[2, 1] = Image.FromFile("3-2.jpg");
            img[2, 2] = Image.FromFile("3-3.jpg");
            img[2, 3] = Image.FromFile("3-4.jpg");
           
            img[3, 0] = Image.FromFile("4-1.jpg");
            img[3, 1] = Image.FromFile("4-2.jpg");
            img[3, 2] = Image.FromFile("4-3.jpg");
            img[3, 3] = Image.FromFile("4-4.jpg");

            img[4, 0] = Image.FromFile("5-1.jpg");
            img[4, 1] = Image.FromFile("5-2.jpg");
            img[4, 2] = Image.FromFile("5-3.jpg");
            img[4, 3] = Image.FromFile("5-4.jpg");

            img[5, 0] = Image.FromFile("6-1.jpg");
            img[5, 1] = Image.FromFile("6-2.jpg");
            img[5, 2] = Image.FromFile("6-3.jpg");
            img[5, 3] = Image.FromFile("6-4.jpg");

            img[6, 0] = Image.FromFile("7-1.jpg");
            img[6, 1] = Image.FromFile("7-2.jpg");
            img[6, 2] = Image.FromFile("7-3.jpg");
            img[6, 3] = Image.FromFile("7-4.jpg");

            img[7, 0] = Image.FromFile("8-1.jpg");
            img[7, 1] = Image.FromFile("8-2.jpg");
            img[7, 2] = Image.FromFile("8-3.jpg");
            img[7, 3] = Image.FromFile("8-4.jpg");

            img[8, 0] = Image.FromFile("9-1.jpg");
            img[8, 1] = Image.FromFile("9-2.jpg");
            img[8, 2] = Image.FromFile("9-3.jpg");
            img[8, 3] = Image.FromFile("9-4.jpg");

            img[9, 0] = Image.FromFile("10-1.jpg");
            img[9, 1] = Image.FromFile("10-2.jpg");
            img[9, 2] = Image.FromFile("10-3.jpg");
            img[9, 3] = Image.FromFile("10-4.jpg");

            img[10, 0] = Image.FromFile("j-1.jpg");
            img[10, 1] = Image.FromFile("j-2.jpg");
            img[10, 2] = Image.FromFile("j-3.jpg");
            img[10, 3] = Image.FromFile("j-4.jpg");

            img[11, 0] = Image.FromFile("q-1.jpg");
            img[11, 1] = Image.FromFile("q-2.jpg");
            img[11, 2] = Image.FromFile("q-3.jpg");
            img[11, 3] = Image.FromFile("q-4.jpg");

            img[12, 0] = Image.FromFile("k-1.jpg");
            img[12, 1] = Image.FromFile("k-2.jpg");
            img[12, 2] = Image.FromFile("k-3.jpg");
            img[12, 3] = Image.FromFile("k-4.jpg");

            for(int i = 0; i < 13; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    used[i, j] = false;
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private bool isNumber(string s)
        {
            for (int i = 0; i < s.Length; i++)
                if ((s[i] > 'a' && s[i] < 'z') || (s[i] > 'A' && s[i] < 'Z'))
                    return false;
            return true;
        }

        public int RandomNumber(int min, int max)
        { 
            return random.Next(min, max);
        }
        private void buttonRestart_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 13; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    used[i, j] = false;
                }
            }

            buttonHit.Visible = true;
            buttonStand.Visible = true;

            buttonHit.Enabled = true;
            buttonStand.Enabled = true;

            pictureBoxP1.Visible = false;
            pictureBoxP2.Visible = false;
            pictureBoxP3.Visible = false;
            pictureBoxP4.Visible = false;
            pictureBoxP5.Visible = false;
            pictureBoxP6.Visible = false;
            pictureBoxP7.Visible = false;
            pictureBoxP8.Visible = false;
            pictureBoxP9.Visible = false;

            playerCount = 0;
            dealerCount = 0;
            playerCards = 2;
            dealerCards = 1;

            int xD, yD, xP, yP;
            xD = RandomNumber(0, 12);
            yD = RandomNumber(0, 3);
            if (xD < 9)
            {
                dealerCount =  xD + 1; 
            }
            else
            {
                dealerCount = 10;
            }

            used[xD, yD] = true;
            pictureBoxD5.Image = img[xD, yD];
            pictureBoxD5.Visible = true;

            Bitmap back = new Bitmap(Properties.Resources.backcard);            
            pictureBoxD6.Image = back;
            pictureBoxD6.Visible = true;

            do
            {
                xP = RandomNumber(0, 12);
                yP = RandomNumber(0, 3);

            } while (used[xP, yP] == true);

            if (xP < 9)
            {
                playerCount = playerCount + xD + 1;
            }
            else
            {
                playerCount = playerCount + 10;
            }

            used[xP, yP] = true;
            pictureBoxP5.Image = img[xP, yP];
            pictureBoxP5.Visible = true;

            do
            {
                xP = RandomNumber(0, 12);
                yP = RandomNumber(0, 3);
            } while (used[xP, yP] == true);     

            if (xP < 9)
            {
                playerCount = playerCount + xP + 1;
            }
            else
            {
                playerCount = playerCount + 10;
            }

            used[xP, yP] = true;
            pictureBoxP6.Image = img[xP, yP];
            pictureBoxP6.Visible = true;

            labelScoreDealer.Text = dealerCount.ToString();
            labelScorePlayer.Text = playerCount.ToString();

        }

        private void buttonBet_Click(object sender, EventArgs e)
        {

            if (textBoxBet.Text.ToString() != "")
            {
                if (isNumber(textBoxBet.Text.ToString()))
                {
                    moneyBet = int.Parse(textBoxBet.Text);
                    
                    if(moneyBet <= int.Parse(labelMoney.Text))
                    {
                        buttonRestart.Visible = true;
                    }
                }
            }
        }

        private void buttonHit_Click(object sender, EventArgs e)
        {
            if (playerCount < 21)
            {
                int xP, yP, score;
                switch (playerCards)
                {
                    case 2:

                        pictureBoxP4.Image = pictureBoxP5.Image;
                        pictureBoxP4.Visible = true;
                        pictureBoxP5.Image = pictureBoxP6.Image;
                        
                        do
                        {
                            xP = RandomNumber(0, 12);
                            yP = RandomNumber(0, 3);
                        } while (used[xP, yP] == true);

                        if (xP < 9)
                        {
                            playerCount = playerCount + xP + 1;
                        }
                        else
                        {
                            playerCount = playerCount + 10;
                        }

                        used[xP, yP] = true;
                        pictureBoxP6.Image = img[xP, yP];

                        playerCards++;

                        if (playerCount > 21)
                        {
                            buttonHit.Enabled = false;
                            buttonStand.Enabled = false;

                            DialogResult dialog = MessageBox.Show("YOU LOST:((((");
                        }

                        score = int.Parse(labelScorePlayer.Text) + playerCount;
                        labelScorePlayer.Text = score.ToString();

                        break;

                    case 3:

                        do
                        {
                            xP = RandomNumber(0, 12);
                            yP = RandomNumber(0, 3);
                        } while (used[xP, yP] == true);

                        if (xP < 9)
                        {
                            playerCount = playerCount + xP + 1;
                        }
                        else
                        {
                            playerCount = playerCount + 10;
                        }

                        used[xP, yP] = true;
                        pictureBoxP7.Image = img[xP, yP];
                        pictureBoxP7.Visible = true;

                        playerCards++;

                        if (playerCount > 21)
                        {
                            buttonHit.Enabled = false;
                            buttonStand.Enabled = false;

                            DialogResult dialog = MessageBox.Show("YOU LOST:((((");
                        }

                        break;

                    case 4:

                        pictureBoxP3.Image = pictureBoxP4.Image;
                        pictureBoxP3.Visible = true;
                        pictureBoxP4.Image = pictureBoxP5.Image;
                        pictureBoxP5.Image = pictureBoxP6.Image;
                        pictureBoxP6.Image = pictureBoxP7.Image;

                        do
                        {
                            xP = RandomNumber(0, 12);
                            yP = RandomNumber(0, 3);
                        } while (used[xP, yP] == true);

                        if (xP < 9)
                        {
                            playerCount = playerCount + xP + 1;
                        }
                        else
                        {
                            playerCount = playerCount + 10;
                        }

                        used[xP, yP] = true;
                        pictureBoxP7.Image = img[xP, yP];

                        playerCards++;

                        if (playerCount > 21)
                        {
                            buttonHit.Enabled = false;
                            buttonStand.Enabled = false;

                            DialogResult dialog = MessageBox.Show("YOU LOST:((((");
                        }

                        break;

                    case 5:

                        do
                        {
                            xP = RandomNumber(0, 12);
                            yP = RandomNumber(0, 3);
                        } while (used[xP, yP] == true);

                        if (xP < 9)
                        {
                            playerCount = playerCount + xP + 1;
                        }
                        else
                        {
                            playerCount = playerCount + 10;
                        }

                        used[xP, yP] = true;
                        pictureBoxP8.Image = img[xP, yP];
                        pictureBoxP8.Visible = true;

                        playerCards++;

                        if (playerCount > 21)
                        {
                            buttonHit.Enabled = false;
                            buttonStand.Enabled = false;

                            DialogResult dialog = MessageBox.Show("YOU LOST:((((");
                        }

                        break;

                    case 6:

                        pictureBoxP2.Image = pictureBoxP3.Image;
                        pictureBoxP2.Visible = true;
                        pictureBoxP3.Image = pictureBoxP4.Image;
                        pictureBoxP4.Image = pictureBoxP5.Image;
                        pictureBoxP5.Image = pictureBoxP6.Image;
                        pictureBoxP6.Image = pictureBoxP7.Image;

                        do
                        {
                            xP = RandomNumber(0, 12);
                            yP = RandomNumber(0, 3);
                        } while (used[xP, yP] == true);

                        if (xP < 9)
                        {
                            playerCount = playerCount + xP + 1;
                        }
                        else
                        {
                            playerCount = playerCount + 10;
                        }

                        used[xP, yP] = true;
                        pictureBoxP8.Image = img[xP, yP];

                        playerCards++;

                        if (playerCount > 21)
                        {
                            buttonHit.Enabled = false;
                            buttonStand.Enabled = false;

                            DialogResult dialog = MessageBox.Show("YOU LOST:((((");
                        }

                        break;

                    case 7:

                        do
                        {
                            xP = RandomNumber(0, 12);
                            yP = RandomNumber(0, 3);
                        } while (used[xP, yP] == true);

                        if (xP < 9)
                        {
                            playerCount = playerCount + xP + 1;
                        }
                        else
                        {
                            playerCount = playerCount + 10;
                        }

                        used[xP, yP] = true;
                        pictureBoxP9.Image = img[xP, yP];
                        pictureBoxP9.Visible = true;

                        playerCards++;
                        
                        if (playerCount > 21)
                        {
                            buttonHit.Enabled = false;
                            buttonStand.Enabled = false;

                            DialogResult dialog = MessageBox.Show("YOU LOST:((((");
                        }
                        break;

                    case 8:

                        pictureBoxP1.Image = pictureBoxP2.Image;
                        pictureBoxP1.Visible = true;
                        pictureBoxP2.Image = pictureBoxP3.Image;
                        pictureBoxP3.Image = pictureBoxP4.Image;
                        pictureBoxP4.Image = pictureBoxP5.Image;
                        pictureBoxP5.Image = pictureBoxP6.Image;
                        pictureBoxP6.Image = pictureBoxP7.Image;

                        do
                        {
                            xP = RandomNumber(0, 12);
                            yP = RandomNumber(0, 3);
                        } while (used[xP, yP] == true);

                        if (xP < 9)
                        {
                            playerCount = playerCount + xP + 1;
                        }
                        else
                        {
                            playerCount = playerCount + 10;
                        }

                        used[xP, yP] = true;
                        pictureBoxP9.Image = img[xP, yP];

                        playerCards++;

                        if (playerCount > 21)
                        {
                            buttonHit.Enabled = false;
                            buttonStand.Enabled = false;

                            DialogResult dialog = MessageBox.Show("YOU LOST:((((");
                        }
                        break;
                }
            }
            else if(playerCount == 21)
            {
                DialogResult dialog = MessageBox.Show("YOU WON!!!");
                       
                buttonHit.Enabled = false;
                buttonStand.Enabled = false;
            }

           
        }

        private void buttonStand_Click(object sender, EventArgs e)
        {

        }
    }
}
