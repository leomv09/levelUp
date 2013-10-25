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
    public partial class AddAchievementForm : Form
    {
        private Controller m_controller;
        private Achievement m_achievement;

        public AddAchievementForm(Department department)
        {
            InitializeComponent();
            m_controller = Controller.Instance;
            AchievementComboBox.DataSource = m_controller.GetDepartmentAchievements(department);
            AchievementComboBox.DisplayMember = "Name";
            m_achievement = (Achievement)AchievementComboBox.SelectedItem;
        }

        private void AchievementComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            m_achievement = (Achievement)AchievementComboBox.SelectedItem;
        }

        private void AcceptAchievementButton_Click(object sender, EventArgs e)
        {
            this.Close();
            this.DialogResult = DialogResult.OK;
        }

        public Achievement SelectedAchievement
        {
            get { return m_achievement; }
        }
    }
}
