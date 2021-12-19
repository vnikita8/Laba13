using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BanksFabric;
using BuildsFabric;


namespace Laba13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int NewAccountNumber = BankAccountCreator.CreateAccount(AccountType.текущий, 2000);
            Build build = BuildCreator.CreateBuld();
            richTextBox1.Text = $"Номер банковского аккаунта, созданного через фабрику и отдельную dll: {NewAccountNumber}\n" +
                $"Номер здания, созданного через фабрику и отдельную dll: {build.GetNumber()}";
        }
    }
}
