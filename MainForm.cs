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
            bool executeCancelled = false;

            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "Select your /engine directory";
                DialogResult result = folderDialog.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderDialog.SelectedPath))
                {
                    mExtractPath = folderDialog.SelectedPath;
                }
                else
                {
                    executeCancelled = true;
                }
            }

            if (!executeCancelled)
            {
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
                            mSavePath = Path.Combine(selectedPath, folderName);
                            Directory.CreateDirectory(mSavePath);
                        }
                        else
                        {
                            executeCancelled = true;
                        }
                    }
                    else
                    {
                        executeCancelled = true;
                    }
                }
            }

            if (!executeCancelled)
            {
                ExecuteAllTasks();
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

        private void ExecuteAllTasks()
        {
            foreach (KeyValuePair<string, string> task in mTasksList)
            {
                if ((task.Key.Trim().Length != 0) && (task.Value.Trim().Length != 0))
                {
                    // Which file from extract path?
                    Dictionary<string, string> fileNamePairs = new Dictionary<string, string>();

                    // Extract filenames, new filenames
                    fileNamePairs.Add(ReturnSoundFileNameFromListEntry(task.Value) + ".es", ReturnSoundFileNameFromListEntry(task.Key) + ".es");
                    fileNamePairs.Add(ReturnSoundFileNameFromListEntry(task.Value) + "_n0.es", ReturnSoundFileNameFromListEntry(task.Key) + "_n0.es");
                    fileNamePairs.Add(ReturnSoundFileNameFromListEntry(task.Value) + "_n1.es", ReturnSoundFileNameFromListEntry(task.Key) + "_n1.es");
                    fileNamePairs.Add(ReturnSoundFileNameFromListEntry(task.Value) + "_n2.es", ReturnSoundFileNameFromListEntry(task.Key) + "_n2.es");
                    fileNamePairs.Add(ReturnSoundFileNameFromListEntry(task.Value) + "_n3.es", ReturnSoundFileNameFromListEntry(task.Key) + "_n3.es");
                    fileNamePairs.Add(ReturnSoundFileNameFromListEntry(task.Value) + "_t0.es", ReturnSoundFileNameFromListEntry(task.Key) + "_t0.es");
                    fileNamePairs.Add(ReturnSoundFileNameFromListEntry(task.Value) + "_t1.es", ReturnSoundFileNameFromListEntry(task.Key) + "_t1.es");
                    fileNamePairs.Add(ReturnSoundFileNameFromListEntry(task.Value) + "_t2.es", ReturnSoundFileNameFromListEntry(task.Key) + "_t2.es");
                    fileNamePairs.Add(ReturnSoundFileNameFromListEntry(task.Value) + "_t3.es", ReturnSoundFileNameFromListEntry(task.Key) + "_t3.es");

                    foreach (KeyValuePair<string, string> fileNamePair in fileNamePairs)
                    {
                        // Save it to save path
                        DuplicateFile(mExtractPath + "/" + fileNamePair.Key, mSavePath, fileNamePair.Value);
                    }
                }
                else
                {
                    throw new Exception("Error! Failed to perform task " + task.Value + " -> " + task.Key);
                }
            }

            errorIndicator_Label.ForeColor = Color.Green;
            errorIndicator_Label.Text = "Operation complete";

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

        public string ReturnSoundFileNameFromListEntry(string listEntry)
        {
            string fileName = string.Empty;

            string fileId = listEntry.Split(' ')[0];

            return GetEntryStartingWith(FileNames.mSoundFileNames, fileId);
        }

        public static string GetEntryStartingWith(List<string> list, string keyString)
        {
            return list.FirstOrDefault(entry => entry.StartsWith(keyString));
        }

        public static void DuplicateFile(string sourceFilePath, string destinationDirectory, string newFileName)
        {
            if (!Directory.Exists(destinationDirectory))
            {
                Directory.CreateDirectory(destinationDirectory);
            }

            string destinationFilePath = Path.Combine(destinationDirectory, newFileName);

            try
            {
                File.Copy(sourceFilePath, destinationFilePath, overwrite: true);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
    }
}