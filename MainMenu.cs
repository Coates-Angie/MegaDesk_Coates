using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Coates
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void AddQuotebutton_Click(object sender, EventArgs e)
        {
            AddQuote viewAddQuote = new AddQuote();
            viewAddQuote.Tag = this;
            viewAddQuote.Show(this);
            Hide();
        }

        private void searchQuotes_Click(object sender, EventArgs e)
        {
            SearchQuotes viewSearchQuote = new SearchQuotes();
            viewSearchQuote.Tag = this;
            viewSearchQuote.Show(this);
            Hide();
        }

        private void viewQuote_Click(object sender, EventArgs e)
        {
            ViewAllQuotes viewViewAllQuotes = new ViewAllQuotes();
            viewViewAllQuotes.Tag = this;
            viewViewAllQuotes.Show(this);
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
