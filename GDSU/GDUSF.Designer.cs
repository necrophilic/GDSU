namespace GDSU
{
    partial class GDUSF
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GDUSF));
            this.label1 = new System.Windows.Forms.Label();
            this.TopBar = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ExitButton = new Guna.UI2.WinForms.Guna2ControlBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SaveToFile = new Guna.UI2.WinForms.Guna2Button();
            this.Search = new Guna.UI2.WinForms.Guna2Button();
            this.UsernameInput = new Guna.UI.WinForms.GunaLineTextBox();
            this.UsernameSearchResults = new System.Windows.Forms.ListBox();
            this.ChangeColors = new Guna.UI2.WinForms.Guna2Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.GitHubLabel = new System.Windows.Forms.Label();
            this.TwitterLabel = new System.Windows.Forms.Label();
            this.googleWorker = new System.ComponentModel.BackgroundWorker();
            this.TopBarAnimation = new Zeroit.Framework.Transitions.SpecAnimator.ZeroitSpecBackColorAnimator(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TopBarAnimation)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(132, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 33);
            this.label1.TabIndex = 8;
            this.label1.Text = "Cri\'s GDUS";
            // 
            // TopBar
            // 
            this.TopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TopBar.Location = new System.Drawing.Point(-1, 22);
            this.TopBar.Name = "TopBar";
            this.TopBar.Size = new System.Drawing.Size(400, 1);
            this.TopBar.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panel1.Controls.Add(this.ExitButton);
            this.panel1.Location = new System.Drawing.Point(-10, -18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(410, 41);
            this.panel1.TabIndex = 5;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.T_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.T_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.T_MouseUp);
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitButton.Animated = true;
            this.ExitButton.BackColor = System.Drawing.Color.Transparent;
            this.ExitButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ExitButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ExitButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ExitButton.HoverState.Parent = this.ExitButton;
            this.ExitButton.IconColor = System.Drawing.Color.White;
            this.ExitButton.Location = new System.Drawing.Point(369, 18);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.ShadowDecoration.Parent = this.ExitButton;
            this.ExitButton.Size = new System.Drawing.Size(22, 20);
            this.ExitButton.TabIndex = 153;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panel3.Controls.Add(this.SaveToFile);
            this.panel3.Controls.Add(this.Search);
            this.panel3.Controls.Add(this.UsernameInput);
            this.panel3.Location = new System.Drawing.Point(12, 67);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(356, 66);
            this.panel3.TabIndex = 7;
            // 
            // SaveToFile
            // 
            this.SaveToFile.CheckedState.Parent = this.SaveToFile;
            this.SaveToFile.CustomImages.Parent = this.SaveToFile;
            this.SaveToFile.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SaveToFile.ForeColor = System.Drawing.Color.White;
            this.SaveToFile.HoverState.Parent = this.SaveToFile;
            this.SaveToFile.Location = new System.Drawing.Point(212, 37);
            this.SaveToFile.Name = "SaveToFile";
            this.SaveToFile.ShadowDecoration.Parent = this.SaveToFile;
            this.SaveToFile.Size = new System.Drawing.Size(137, 22);
            this.SaveToFile.TabIndex = 332;
            this.SaveToFile.Text = "Save To File";
            this.SaveToFile.Click += new System.EventHandler(this.SaveToFile_Click);
            // 
            // Search
            // 
            this.Search.CheckedState.Parent = this.Search;
            this.Search.CustomImages.Parent = this.Search;
            this.Search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Search.ForeColor = System.Drawing.Color.White;
            this.Search.HoverState.Parent = this.Search;
            this.Search.Location = new System.Drawing.Point(5, 37);
            this.Search.Name = "Search";
            this.Search.ShadowDecoration.Parent = this.Search;
            this.Search.Size = new System.Drawing.Size(137, 22);
            this.Search.TabIndex = 331;
            this.Search.Text = "Search";
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // UsernameInput
            // 
            this.UsernameInput.Animated = true;
            this.UsernameInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.UsernameInput.Cursor = System.Windows.Forms.Cursors.Default;
            this.UsernameInput.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UsernameInput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.UsernameInput.ForeColor = System.Drawing.Color.White;
            this.UsernameInput.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UsernameInput.LineSize = 1;
            this.UsernameInput.Location = new System.Drawing.Point(5, 5);
            this.UsernameInput.Name = "UsernameInput";
            this.UsernameInput.PasswordChar = '\0';
            this.UsernameInput.SelectedText = "";
            this.UsernameInput.Size = new System.Drawing.Size(344, 26);
            this.UsernameInput.TabIndex = 330;
            this.UsernameInput.Text = "Username";
            this.UsernameInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UsernameSearchResults
            // 
            this.UsernameSearchResults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.UsernameSearchResults.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UsernameSearchResults.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameSearchResults.ForeColor = System.Drawing.Color.White;
            this.UsernameSearchResults.FormattingEnabled = true;
            this.UsernameSearchResults.HorizontalScrollbar = true;
            this.UsernameSearchResults.Items.AddRange(new object[] {
            ""});
            this.UsernameSearchResults.Location = new System.Drawing.Point(12, 181);
            this.UsernameSearchResults.Name = "UsernameSearchResults";
            this.UsernameSearchResults.Size = new System.Drawing.Size(356, 340);
            this.UsernameSearchResults.TabIndex = 145;
            this.UsernameSearchResults.DoubleClick += new System.EventHandler(this.UsernameSearchResults_DoubleClick);
            // 
            // ChangeColors
            // 
            this.ChangeColors.CheckedState.Parent = this.ChangeColors;
            this.ChangeColors.CustomImages.Parent = this.ChangeColors;
            this.ChangeColors.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ChangeColors.ForeColor = System.Drawing.Color.White;
            this.ChangeColors.HoverState.Parent = this.ChangeColors;
            this.ChangeColors.Location = new System.Drawing.Point(4, 6);
            this.ChangeColors.Name = "ChangeColors";
            this.ChangeColors.ShadowDecoration.Parent = this.ChangeColors;
            this.ChangeColors.Size = new System.Drawing.Size(99, 22);
            this.ChangeColors.TabIndex = 2;
            this.ChangeColors.Text = "Change Colors";
            this.ChangeColors.Click += new System.EventHandler(this.ChangeColors_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panel6.Controls.Add(this.ChangeColors);
            this.panel6.Location = new System.Drawing.Point(12, 140);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(109, 35);
            this.panel6.TabIndex = 147;
            // 
            // GitHubLabel
            // 
            this.GitHubLabel.AutoSize = true;
            this.GitHubLabel.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GitHubLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.GitHubLabel.Location = new System.Drawing.Point(123, 140);
            this.GitHubLabel.Name = "GitHubLabel";
            this.GitHubLabel.Size = new System.Drawing.Size(31, 12);
            this.GitHubLabel.TabIndex = 148;
            this.GitHubLabel.Text = "Github";
            this.GitHubLabel.Click += new System.EventHandler(this.GitHubLabel_Click);
            // 
            // TwitterLabel
            // 
            this.TwitterLabel.AutoSize = true;
            this.TwitterLabel.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TwitterLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TwitterLabel.Location = new System.Drawing.Point(160, 140);
            this.TwitterLabel.Name = "TwitterLabel";
            this.TwitterLabel.Size = new System.Drawing.Size(33, 12);
            this.TwitterLabel.TabIndex = 149;
            this.TwitterLabel.Text = "Twitter";
            this.TwitterLabel.Click += new System.EventHandler(this.TwitterLabel_Click);
            // 
            // googleWorker
            // 
            this.googleWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.googleWorker_DoWork);
            // 
            // TopBarAnimation
            // 
            this.TopBarAnimation.Control = this.TopBar;
            this.TopBarAnimation.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TopBarAnimation.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TopBarAnimation.ZeroitSpecLoopMode = Zeroit.Framework.Transitions.SpecAnimator.ZeroitSpecLoopMode.Bidirectional;
            this.TopBarAnimation.ZeroitSpecSynchronizationMode = Zeroit.Framework.Transitions.SpecAnimator.ZeroitSpecSynchronizationMode.None;
            // 
            // GDUSF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(380, 535);
            this.Controls.Add(this.TwitterLabel);
            this.Controls.Add(this.GitHubLabel);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.UsernameSearchResults);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TopBar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GDUSF";
            this.Text = "<3 Cri";
            this.Load += new System.EventHandler(this.GDUSF_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TopBarAnimation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel TopBar;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2ControlBox ExitButton;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2Button SaveToFile;
        private Guna.UI2.WinForms.Guna2Button Search;
        private Guna.UI.WinForms.GunaLineTextBox UsernameInput;
        private System.Windows.Forms.ListBox UsernameSearchResults;
        private Guna.UI2.WinForms.Guna2Button ChangeColors;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label GitHubLabel;
        private System.Windows.Forms.Label TwitterLabel;
        private System.ComponentModel.BackgroundWorker googleWorker;
        private Zeroit.Framework.Transitions.SpecAnimator.ZeroitSpecBackColorAnimator TopBarAnimation;
    }
}

