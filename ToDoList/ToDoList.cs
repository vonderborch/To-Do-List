using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList
{
    public partial class ToDoList : Form
    {
        public ToDoList()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var about = new AboutBox();
            about.ShowDialog();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openListToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void closeListToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveListToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveListAsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clearListToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toggleAllItemsCompletedToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
