using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LevelUpApplication
{
    public partial class AwardDetailsForm : Form
    {
        public AwardDetailsForm()
        {
            InitializeComponent();
            OpenFileDialog.Filter = "jpg files (*.jpg)|*.jpg|png files (*.png)|*.png|All files (*.*)|*.*";
        }

        private void FileSelectButton_Click(object sender, EventArgs e)
        {
            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                PhotoPictureBox.Image = Image.FromFile(OpenFileDialog.FileName);
            }
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {

        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {

        }

        private void TypeComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }
    }
}
