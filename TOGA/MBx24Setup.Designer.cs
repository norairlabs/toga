namespace TOGA
{
    partial class MBx24Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MBx24Form));
            label13 = new System.Windows.Forms.Label();
            label14 = new System.Windows.Forms.Label();
            label16 = new System.Windows.Forms.Label();
            panel4 = new System.Windows.Forms.Panel();
            FirstButtonPanel = new System.Windows.Forms.Panel();
            FirstButtonLabel = new System.Windows.Forms.Label();
            FirstButton = new System.Windows.Forms.NumericUpDown();
            Interpolation = new System.Windows.Forms.CheckBox();
            label8 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label15 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            label9 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            OUTPUTSPANEL = new System.Windows.Forms.Panel();
            label2 = new System.Windows.Forms.Label();
            INPUTSPANEL = new System.Windows.Forms.Panel();
            label3 = new System.Windows.Forms.Label();
            DESCRIPTION = new System.Windows.Forms.TextBox();
            ExitButton = new System.Windows.Forms.Button();
            SaveButton = new System.Windows.Forms.Button();
            ID = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            SERIAL = new System.Windows.Forms.TextBox();
            statusStrip1 = new System.Windows.Forms.StatusStrip();
            StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            panel4.SuspendLayout();
            FirstButtonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)FirstButton).BeginInit();
            panel2.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new System.Drawing.Point(344, 80);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(64, 15);
            label13.TabIndex = 79;
            label13.Text = "Behaves as";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new System.Drawing.Point(5, 66);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(61, 30);
            label14.TabIndex = 77;
            label14.Text = "Input\r\nconnector";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new System.Drawing.Point(79, 80);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(67, 15);
            label16.TabIndex = 71;
            label16.Text = "Description";
            // 
            // panel4
            // 
            panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel4.Controls.Add(FirstButtonPanel);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label13);
            panel4.Controls.Add(label14);
            panel4.Controls.Add(label15);
            panel4.Controls.Add(label16);
            panel4.Location = new System.Drawing.Point(13, 50);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(614, 102);
            panel4.TabIndex = 92;
            // 
            // FirstButtonPanel
            // 
            FirstButtonPanel.Controls.Add(FirstButtonLabel);
            FirstButtonPanel.Controls.Add(FirstButton);
            FirstButtonPanel.Controls.Add(Interpolation);
            FirstButtonPanel.Location = new System.Drawing.Point(103, 30);
            FirstButtonPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            FirstButtonPanel.Name = "FirstButtonPanel";
            FirstButtonPanel.Size = new System.Drawing.Size(289, 29);
            FirstButtonPanel.TabIndex = 94;
            // 
            // FirstButtonLabel
            // 
            FirstButtonLabel.Location = new System.Drawing.Point(3, 4);
            FirstButtonLabel.Name = "FirstButtonLabel";
            FirstButtonLabel.Size = new System.Drawing.Size(94, 19);
            FirstButtonLabel.TabIndex = 94;
            FirstButtonLabel.Text = "First button";
            FirstButtonLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FirstButton
            // 
            FirstButton.InterceptArrowKeys = false;
            FirstButton.Location = new System.Drawing.Point(102, 3);
            FirstButton.Maximum = new decimal(new int[] { 168, 0, 0, 0 });
            FirstButton.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            FirstButton.Name = "FirstButton";
            FirstButton.Size = new System.Drawing.Size(52, 23);
            FirstButton.TabIndex = 95;
            FirstButton.Value = new decimal(new int[] { 21, 0, 0, 0 });
            FirstButton.ValueChanged += FirstButton_ValueChanged;
            // 
            // Interpolation
            // 
            Interpolation.Location = new System.Drawing.Point(191, 4);
            Interpolation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Interpolation.Name = "Interpolation";
            Interpolation.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            Interpolation.Size = new System.Drawing.Size(94, 18);
            Interpolation.TabIndex = 98;
            Interpolation.Text = "Interpolate";
            Interpolation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            Interpolation.UseVisualStyleBackColor = true;
            Interpolation.CheckedChanged += FirstButton_ValueChanged;
            // 
            // label8
            // 
            label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            label8.Location = new System.Drawing.Point(-1, 2);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(614, 19);
            label8.TabIndex = 96;
            label8.Text = "Joystick inputs";
            label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(534, 65);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(49, 30);
            label6.TabIndex = 80;
            label6.Text = "VICe\r\nnumber";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new System.Drawing.Point(208, 65);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(49, 30);
            label15.TabIndex = 76;
            label15.Text = "Joystick\r\nnumber";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(1, 66);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(61, 30);
            label5.TabIndex = 77;
            label5.Text = "Output\r\nconnector";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(105, 80);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(49, 15);
            label7.TabIndex = 71;
            label7.Text = "Settings";
            // 
            // panel2
            // 
            panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label7);
            panel2.Location = new System.Drawing.Point(633, 50);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(516, 102);
            panel2.TabIndex = 93;
            // 
            // label9
            // 
            label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            label9.Location = new System.Drawing.Point(1, 2);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(514, 19);
            label9.TabIndex = 97;
            label9.Text = "Annunciators setup";
            label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(281, 80);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(67, 15);
            label10.TabIndex = 78;
            label10.Text = "Description";
            // 
            // OUTPUTSPANEL
            // 
            OUTPUTSPANEL.AutoScroll = true;
            OUTPUTSPANEL.BackColor = System.Drawing.SystemColors.Control;
            OUTPUTSPANEL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            OUTPUTSPANEL.Location = new System.Drawing.Point(633, 158);
            OUTPUTSPANEL.Name = "OUTPUTSPANEL";
            OUTPUTSPANEL.Size = new System.Drawing.Size(516, 342);
            OUTPUTSPANEL.TabIndex = 80;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(718, 10);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(17, 15);
            label2.TabIndex = 85;
            label2.Text = "Id";
            label2.Visible = false;
            // 
            // INPUTSPANEL
            // 
            INPUTSPANEL.AutoScroll = true;
            INPUTSPANEL.AutoScrollMargin = new System.Drawing.Size(5, 0);
            INPUTSPANEL.BackColor = System.Drawing.SystemColors.Control;
            INPUTSPANEL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            INPUTSPANEL.Location = new System.Drawing.Point(13, 158);
            INPUTSPANEL.Name = "INPUTSPANEL";
            INPUTSPANEL.Size = new System.Drawing.Size(614, 342);
            INPUTSPANEL.TabIndex = 77;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(232, 10);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(67, 15);
            label3.TabIndex = 90;
            label3.Text = "Description";
            // 
            // DESCRIPTION
            // 
            DESCRIPTION.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            DESCRIPTION.Location = new System.Drawing.Point(328, 6);
            DESCRIPTION.Name = "DESCRIPTION";
            DESCRIPTION.ReadOnly = true;
            DESCRIPTION.Size = new System.Drawing.Size(342, 23);
            DESCRIPTION.TabIndex = 89;
            // 
            // ExitButton
            // 
            ExitButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(255, 128, 0);
            ExitButton.FlatAppearance.BorderSize = 2;
            ExitButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Tomato;
            ExitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Sienna;
            ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            ExitButton.Location = new System.Drawing.Point(908, 6);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new System.Drawing.Size(102, 38);
            ExitButton.TabIndex = 88;
            ExitButton.Text = "Close";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(255, 128, 0);
            SaveButton.FlatAppearance.BorderSize = 2;
            SaveButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Tomato;
            SaveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Sienna;
            SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            SaveButton.Location = new System.Drawing.Point(1047, 6);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new System.Drawing.Size(102, 38);
            SaveButton.TabIndex = 87;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // ID
            // 
            ID.Location = new System.Drawing.Point(738, 8);
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Size = new System.Drawing.Size(35, 23);
            ID.TabIndex = 86;
            ID.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(10, 8);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(80, 15);
            label1.TabIndex = 83;
            label1.Text = "Serial number";
            // 
            // SERIAL
            // 
            SERIAL.Location = new System.Drawing.Point(117, 6);
            SERIAL.Name = "SERIAL";
            SERIAL.ReadOnly = true;
            SERIAL.Size = new System.Drawing.Size(88, 23);
            SERIAL.TabIndex = 84;
            // 
            // statusStrip1
            // 
            statusStrip1.AutoSize = false;
            statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { StatusLabel });
            statusStrip1.Location = new System.Drawing.Point(0, 532);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 12, 0);
            statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            statusStrip1.Size = new System.Drawing.Size(1196, 24);
            statusStrip1.SizingGrip = false;
            statusStrip1.Stretch = false;
            statusStrip1.TabIndex = 95;
            statusStrip1.Text = "Ready";
            // 
            // StatusLabel
            // 
            StatusLabel.AutoSize = false;
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new System.Drawing.Size(1313, 19);
            StatusLabel.Text = "Ready";
            StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MBx24Form
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1196, 556);
            ControlBox = false;
            Controls.Add(statusStrip1);
            Controls.Add(OUTPUTSPANEL);
            Controls.Add(panel4);
            Controls.Add(INPUTSPANEL);
            Controls.Add(panel2);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(DESCRIPTION);
            Controls.Add(ExitButton);
            Controls.Add(SaveButton);
            Controls.Add(ID);
            Controls.Add(label1);
            Controls.Add(SERIAL);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "MBx24Form";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "MBx24 Setup";
            FormClosing += MBx24Form_FormClosing;
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            FirstButtonPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)FirstButton).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel OUTPUTSPANEL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel INPUTSPANEL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DESCRIPTION;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SERIAL;
        private System.Windows.Forms.Label FirstButtonLabel;
        private System.Windows.Forms.NumericUpDown FirstButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox Interpolation;
        private System.Windows.Forms.Panel FirstButtonPanel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
    }
}