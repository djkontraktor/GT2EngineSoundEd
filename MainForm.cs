using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GT2EngineSoundEd
{
    public partial class MainForm : Form
    {
        public Dictionary<string, string> mTasksList = new Dictionary<string, string>();
        public string mExtractPath = string.Empty;
        public string mSavePath = string.Empty;

        public MainForm()
        {
            InitializeComponent();
        }

        private void addTask_ButtonClick(object sender, EventArgs e)
        {
            try
            {
                mTasksList.Add((string)dest_comboBox.SelectedItem, (string)source_comboBox.SelectedItem);
                errorIndicator_Label.ForeColor = Color.Black;
                errorIndicator_Label.Text = "Task added";
            }
            catch (Exception ex)
            {
                errorIndicator_Label.ForeColor = Color.Red;
                errorIndicator_Label.Text = ex.Message.Replace(Environment.NewLine, " ");
            }

            UpdateTasksGraphic();
        }

        private void executeTask_ButtonClick(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "Select your /engine directory";
                DialogResult result = folderDialog.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderDialog.SelectedPath))
                {
                    mExtractPath = folderDialog.SelectedPath;
                }
            }

            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "Select the directory to create a new folder in:";
                DialogResult result = folderDialog.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderDialog.SelectedPath))
                {
                    string selectedPath = folderDialog.SelectedPath;
                    string folderName = PromptForFolderName();
                    if (!string.IsNullOrEmpty(folderName))
                    {
                        string newFolderPath = Path.Combine(selectedPath, folderName);
                        Directory.CreateDirectory(newFolderPath);
                        //MessageBox.Show($"New folder created: {newFolderPath}", "Folder Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void removeTask_ButtonClick(object sender, EventArgs e)
        {
            try
            {
                mTasksList.Remove(mTasksList.Last().Key);
                errorIndicator_Label.ForeColor = Color.Black;
                errorIndicator_Label.Text = "Task removed";
            }
            catch (Exception ex)
            {
                errorIndicator_Label.ForeColor = Color.Red;
                errorIndicator_Label.Text = ex.Message.Replace(Environment.NewLine, " ");
            }
            
            UpdateTasksGraphic();
        }

        private void UpdateTasksGraphic()
        {
            string tasksList = string.Empty;

            foreach (KeyValuePair<string, string> task in mTasksList)
            {
                tasksList += task.Value + " -> " + task.Key + Environment.NewLine;
            }

            tasksQueue_TextBox.Text = tasksList;
        }

        public static string PromptForFolderName()
        {
            using (Form prompt = new Form())
            {
                prompt.Width = 400;
                prompt.Height = 150;
                prompt.Text = "Enter New Folder Name";
                Label textLabel = new Label() { Left = 20, Top = 20, Text = "New Folder Name:" };
                TextBox textBox = new TextBox() { Left = 20, Top = 50, Width = 340 };
                Button confirmation = new Button() { Text = "Create Folder", Left = 280, Width = 80, Top = 80, DialogResult = DialogResult.OK };
                prompt.Controls.Add(textLabel);
                prompt.Controls.Add(textBox);
                prompt.Controls.Add(confirmation);
                prompt.AcceptButton = confirmation;
                return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : string.Empty;
            }
        }
    }
}
