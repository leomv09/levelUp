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
    public partial class AddAchievementPerUserForm : Form
    {
        private Controller m_controller;
        private AchievementPerUser m_achievement;

        public AddAchievementPerUserForm(Department department)
        {
            InitializeComponent();
            m_controller = Controller.Instance;
            m_achievement = new AchievementPerUser();
            AchievementComboBox.DataSource = m_controller.GetDepartmentAchievements(department);
            AchievementComboBox.DisplayMember = "Name";
            m_achievement.Achievement = (Achievement) AchievementComboBox.SelectedItem;
        }

        private void AcceptAchievementButton_Click(object sender, EventArgs e)
        {
            this.Close();
            this.DialogResult = DialogResult.OK;
        }

        public AchievementPerUser SelectedAchievement
        {
            get { return m_achievement; }
        }

        private void AchievementComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            m_achievement.Achievement = (Achievement)AchievementComboBox.SelectedItem;
        }

        private void DetailTextBox_TextChanged(object sender, EventArgs e)
        {
            m_achievement.Detail = DetailTextBox.Text;
        }
    }
}
