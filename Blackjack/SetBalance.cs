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
    public partial class SetBalance : Form
    {
        public int money;
        public SetBalance()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void buttonStart_Click(object sender, EventArgs e)
        { 
            if(textBoxMoney.Text.ToString() != "")
            { if (isNumber(textBoxMoney.Text.ToString()))
                {                    
                    money = int.Parse(textBoxMoney.Text);
                    if (money > 0)
                    {
                        this.Close();
                    }
                }
            }
        }
         
        private bool isNumber(string s)
        {
            for (int i = 0; i < s.Length; i++)
                if ((s[i] > 'a' && s[i] < 'z') || (s[i] > 'A' && s[i] < 'Z'))
                    return false;
            return true;
        }

    }
}
