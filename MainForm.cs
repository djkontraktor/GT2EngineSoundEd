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
            LoadFormContents();
            ResizeAllControls();
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
                folderDialog.Description = "Select your GT2 extracted /engine directory:";
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
                    folderDialog.Description = "Select the directory to save output to:";
                    DialogResult result = folderDialog.ShowDialog();
                    if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderDialog.SelectedPath))
                    {
                        mSavePath = folderDialog.SelectedPath;
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
                    string sourceFileName = ReturnSoundFileNameFromListEntry(task.Value);
                    string destFileName = ReturnSoundFileNameFromListEntry(task.Key);

                    // Save it to save path
                    DuplicateFile(mExtractPath + "/" + sourceFileName, mSavePath, destFileName);
                }
                else
                {
                    throw new Exception("Error! Failed to perform task " + task.Value + " -> " + task.Key);
                }
            }

            errorIndicator_Label.ForeColor = Color.Green;
            errorIndicator_Label.Text = "Operation complete";
        }

        public string ReturnSoundFileNameFromListEntry(string listEntry)
        {
            string fileName = string.Empty;

            string fileId = listEntry.Split('(')[1].Split(')')[0];

            return fileId;
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

        public string GenerateSoundFileName(SoundFile soundFile)
        {
            string fileName = string.Empty;

            string fileId = soundFile.SoundId.ToString().PadLeft(5, '0');

            string exhaustType = soundFile.ExhaustType.ToString().Contains("Stock") ? string.Empty : "_" + soundFile.ExhaustType.ToString();

            fileName = fileId + exhaustType + ".es";

            return fileName;
        }

        public void LoadFormContents()
        {
            List<string> sourceItems = new List<string>();

            foreach (KeyValuePair<int, string> carName in FileNames.mCarNames)
            {
                string thisCarName = carName.Value;

                // Want to find all matching SoundFiles and their ExhaustType in mSoundsList
                foreach (SoundFile soundFile in FileNames.mSoundsList)
                {
                    if (soundFile.SoundId == carName.Key)
                    {
                        thisCarName = carName.Value + ", " + soundFile.ExhaustType.ToString() + " (" + GenerateSoundFileName(soundFile) + ")";
                        sourceItems.Add(thisCarName);
                    }
                }
            }

            List<string> soundDescriptions = new List<string>();

            foreach (SoundFile soundFile in FileNames.mSoundsList)
            {
                soundDescriptions.Add(soundFile.Description + " (" + GenerateSoundFileName(soundFile) + ")");
            }

            source_comboBox.Items.Clear();
            source_comboBox.Items.AddRange(soundDescriptions.ToArray());

            dest_comboBox.Items.Clear();
            dest_comboBox.Items.AddRange(sourceItems.ToArray());
        }

        private void Resize_MainForm(object sender, EventArgs e)
        {
            ResizeAllControls();
        }

        private void ResizeAllControls()
        {
            executeTask_Button.Location = new System.Drawing.Point(this.Size.Width - 100, this.Size.Height - 80);
            addTask_Button.Location = new System.Drawing.Point(this.Size.Width - 180, this.Size.Height - 80);
            removeTask_Button.Location = new System.Drawing.Point(this.Size.Width - 280, this.Size.Height - 80);
            errorIndicator_Label.Location = new System.Drawing.Point(20, this.Size.Height - 70);
            tasksQueue_TextBox.Size = new System.Drawing.Size(this.Size.Width - 65, this.Size.Height - 220);
            dest_comboBox.Size = new System.Drawing.Size(this.Size.Width - 65, 21);
            source_comboBox.Size = new System.Drawing.Size(this.Size.Width - 65, 21);
            dest_Label.Location = new System.Drawing.Point(this.Size.Width / 2, 68);
            tasksQueue_Label.Location = new System.Drawing.Point(this.Size.Width / 2, 115);
            source_Label.Location = new System.Drawing.Point(this.Size.Width / 2, 8);
        }
    }
}