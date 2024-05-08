using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindJobApplication
{
    public partial class FCompanySeeCV : Form
    {
        string filePath;
        public FCompanySeeCV()
        {
            InitializeComponent();
        }

        public FCompanySeeCV(string filePath) : this()
        {
            this.filePath = filePath;
        }

        private void FCompanySeeCV_Load(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(this.filePath))
            {
                try
                {
                    Image image = Image.FromFile(filePath);
                    pBFile.Image = image;
                }
                catch (OutOfMemoryException ex)
                {
                    MessageBox.Show("An error occurred while loading the image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Image file does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
