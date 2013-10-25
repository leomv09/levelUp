using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LevelUp.Data;
using LevelUp.Logic;

namespace LevelUp.App
{
    public partial class AddAwardForm : Form
    {
        private Controller m_controller;
        private Award m_award;

        public AddAwardForm(Department department)
        {
            InitializeComponent();
            m_controller = Controller.Instance;
            AwardComboBox.DataSource = m_controller.GetDepartmentAwards(department);
            AwardComboBox.DisplayMember = "Name";
            m_award = (Award)AwardComboBox.SelectedItem;
        }

        private void AwardComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            m_award = (Award)AwardComboBox.SelectedItem;
        }

        public Award Award
        {
            get { return m_award; }
        }

        private void AcceptAwardButton_Click(object sender, EventArgs e)
        {
            this.Close();
            this.DialogResult = DialogResult.OK;
        }
    }
}
