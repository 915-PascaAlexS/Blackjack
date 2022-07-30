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
        public Game()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetBalance sb = new SetBalance();
            sb.ShowDialog();
            labelMoney.Text = sb.money.ToString();
            InitializeComponent();
            
        }
        private bool isNumber(string s)
        {
            for (int i = 0; i < s.Length; i++)
                if ((s[i] > 'a' && s[i] < 'z') || (s[i] > 'A' && s[i] < 'Z'))
                    return false;
            return true;
        }

        private void buttonRestart_Click(object sender, EventArgs e)
        {
            
        }
    }
}
