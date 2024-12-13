using System.Collections.Generic;
using System.Linq;

namespace GT2EngineSoundEd
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.source_comboBox = new System.Windows.Forms.ComboBox();
            this.dest_comboBox = new System.Windows.Forms.ComboBox();
            this.source_Label = new System.Windows.Forms.Label();
            this.dest_Label = new System.Windows.Forms.Label();
            this.addTask_Button = new System.Windows.Forms.Button();
            this.executeTask_Button = new System.Windows.Forms.Button();
            this.removeTask_Button = new System.Windows.Forms.Button();
            this.tasksQueue_TextBox = new System.Windows.Forms.TextBox();
            this.tasksQueue_Label = new System.Windows.Forms.Label();
            this.errorIndicator_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // source_comboBox
            // 
            this.source_comboBox.FormattingEnabled = true;
            this.source_comboBox.Items.AddRange(new object[] { "Select Engine Sound" } );
            this.source_comboBox.Location = new System.Drawing.Point(24, 24);
            this.source_comboBox.Name = "source_comboBox";
            this.source_comboBox.Size = new System.Drawing.Size(723, 21);
            this.source_comboBox.TabIndex = 0;
            // 
            // dest_comboBox
            // 
            this.dest_comboBox.FormattingEnabled = true;
            this.dest_comboBox.Items.AddRange(new object[] { "Select Destination Car(s)" });
            this.dest_comboBox.Location = new System.Drawing.Point(24, 84);
            this.dest_comboBox.Name = "dest_comboBox";
            this.dest_comboBox.Size = new System.Drawing.Size(723, 21);
            this.dest_comboBox.TabIndex = 1;
            // 
            // source_Label
            // 
            this.source_Label.AutoSize = true;
            this.source_Label.Location = new System.Drawing.Point(340, 8);
            this.source_Label.Name = "source_Label";
            this.source_Label.Size = new System.Drawing.Size(111, 13);
            this.source_Label.TabIndex = 2;
            this.source_Label.Text = "Source Engine Sound";
            // 
            // dest_Label
            // 
            this.dest_Label.AutoSize = true;
            this.dest_Label.Location = new System.Drawing.Point(351, 68);
            this.dest_Label.Name = "dest_Label";
            this.dest_Label.Size = new System.Drawing.Size(90, 13);
            this.dest_Label.TabIndex = 3;
            this.dest_Label.Text = "Destination Car(s)";
            // 
            // addTask_Button
            // 
            this.addTask_Button.Location = new System.Drawing.Point(591, 281);
            this.addTask_Button.Name = "addTask_Button";
            this.addTask_Button.Size = new System.Drawing.Size(75, 23);
            this.addTask_Button.TabIndex = 4;
            this.addTask_Button.Text = "Add Task";
            this.addTask_Button.UseVisualStyleBackColor = true;
            this.addTask_Button.Click += new System.EventHandler(this.addTask_ButtonClick);
            // 
            // executeTask_Button
            // 
            this.executeTask_Button.Location = new System.Drawing.Point(672, 281);
            this.executeTask_Button.Name = "executeTask_Button";
            this.executeTask_Button.Size = new System.Drawing.Size(75, 23);
            this.executeTask_Button.TabIndex = 5;
            this.executeTask_Button.Text = "Execute All";
            this.executeTask_Button.UseVisualStyleBackColor = true;
            this.executeTask_Button.Click += new System.EventHandler(this.executeTask_ButtonClick);
            // 
            // removeTask_Button
            // 
            this.removeTask_Button.Location = new System.Drawing.Point(495, 281);
            this.removeTask_Button.Name = "removeTask_Button";
            this.removeTask_Button.Size = new System.Drawing.Size(90, 23);
            this.removeTask_Button.TabIndex = 6;
            this.removeTask_Button.Text = "Remove Task";
            this.removeTask_Button.UseVisualStyleBackColor = true;
            this.removeTask_Button.Click += new System.EventHandler(this.removeTask_ButtonClick);
            // 
            // tasksQueue_TextBox
            // 
            this.tasksQueue_TextBox.Location = new System.Drawing.Point(24, 131);
            this.tasksQueue_TextBox.Multiline = true;
            this.tasksQueue_TextBox.Name = "tasksQueue_TextBox";
            this.tasksQueue_TextBox.Size = new System.Drawing.Size(723, 144);
            this.tasksQueue_TextBox.TabIndex = 7;
            this.tasksQueue_TextBox.WordWrap = false;
            // 
            // tasksQueue_Label
            // 
            this.tasksQueue_Label.AutoSize = true;
            this.tasksQueue_Label.Location = new System.Drawing.Point(360, 115);
            this.tasksQueue_Label.Name = "tasksQueue_Label";
            this.tasksQueue_Label.Size = new System.Drawing.Size(71, 13);
            this.tasksQueue_Label.TabIndex = 8;
            this.tasksQueue_Label.Text = "Tasks Queue";
            // 
            // errorIndicator_Label
            // 
            this.errorIndicator_Label.AutoSize = true;
            this.errorIndicator_Label.Location = new System.Drawing.Point(30, 291);
            this.errorIndicator_Label.Name = "errorIndicator_Label";
            this.errorIndicator_Label.Size = new System.Drawing.Size(38, 13);
            this.errorIndicator_Label.TabIndex = 9;
            this.errorIndicator_Label.Text = "Ready";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 316);
            this.Controls.Add(this.errorIndicator_Label);
            this.Controls.Add(this.tasksQueue_Label);
            this.Controls.Add(this.tasksQueue_TextBox);
            this.Controls.Add(this.removeTask_Button);
            this.Controls.Add(this.executeTask_Button);
            this.Controls.Add(this.addTask_Button);
            this.Controls.Add(this.dest_Label);
            this.Controls.Add(this.source_Label);
            this.Controls.Add(this.dest_comboBox);
            this.Controls.Add(this.source_comboBox);
            this.Name = "MainForm";
            this.Text = "GT2 Engine Sound Editor v0.1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox source_comboBox;
        private System.Windows.Forms.ComboBox dest_comboBox;
        private System.Windows.Forms.Label source_Label;
        private System.Windows.Forms.Label dest_Label;
        private System.Windows.Forms.Button addTask_Button;
        private System.Windows.Forms.Button executeTask_Button;
        private System.Windows.Forms.Button removeTask_Button;
        private System.Windows.Forms.TextBox tasksQueue_TextBox;
        private System.Windows.Forms.Label tasksQueue_Label;
        private System.Windows.Forms.Label errorIndicator_Label;
    }
}

