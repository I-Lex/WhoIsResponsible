using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WhoIsResponsible
{
    public partial class ProjectSelection : Form
    {
        public ProjectSelection()
        {
            InitializeComponent();
        }

        private void OpenProjectButton_Click(object sender, EventArgs e)
        {
            if (openProjectDialog.ShowDialog() == DialogResult.OK)
            {
                label1.Text = openProjectDialog.FileName;
            }

        }
    }
}
