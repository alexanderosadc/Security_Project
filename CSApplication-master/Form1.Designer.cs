namespace PoliciesManager
{
    partial class Form1
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
            this.checkButton = new MaterialSkin.Controls.MaterialButton();
            this.ElementsListBox = new System.Windows.Forms.CheckedListBox();
            this.SearchBox = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.selectAllSwitch = new MaterialSkin.Controls.MaterialSwitch();
            this.SaveButton = new MaterialSkin.Controls.MaterialButton();
            this.SaveAsButton = new MaterialSkin.Controls.MaterialButton();
            this.CheckSysButton = new MaterialSkin.Controls.MaterialButton();
            this.applyPolicyButton = new MaterialSkin.Controls.MaterialButton();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // checkButton
            // 
            this.checkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.checkButton.Depth = 0;
            this.checkButton.DrawShadows = true;
            this.checkButton.HighEmphasis = true;
            this.checkButton.Icon = null;
            this.checkButton.Location = new System.Drawing.Point(571, 87);
            this.checkButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.checkButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(78, 36);
            this.checkButton.TabIndex = 1;
            this.checkButton.Text = "Search";
            this.checkButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.checkButton.UseAccentColor = false;
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // ElementsListBox
            // 
            this.ElementsListBox.CheckOnClick = true;
            this.ElementsListBox.FormattingEnabled = true;
            this.ElementsListBox.HorizontalScrollbar = true;
            this.ElementsListBox.Location = new System.Drawing.Point(19, 143);
            this.ElementsListBox.Margin = new System.Windows.Forms.Padding(4);
            this.ElementsListBox.Name = "ElementsListBox";
            this.ElementsListBox.Size = new System.Drawing.Size(667, 242);
            this.ElementsListBox.TabIndex = 3;
            this.ElementsListBox.UseCompatibleTextRendering = true;
            this.ElementsListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.ElementsListBox_ItemCheck);
            // 
            // SearchBox
            // 
            this.SearchBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SearchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchBox.Depth = 0;
            this.SearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.SearchBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SearchBox.Hint = "";
            this.SearchBox.Location = new System.Drawing.Point(19, 96);
            this.SearchBox.Margin = new System.Windows.Forms.Padding(4);
            this.SearchBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.SearchBox.Size = new System.Drawing.Size(543, 38);
            this.SearchBox.TabIndex = 5;
            this.SearchBox.Text = "";
            // 
            // selectAllSwitch
            // 
            this.selectAllSwitch.AutoSize = true;
            this.selectAllSwitch.Depth = 0;
            this.selectAllSwitch.Location = new System.Drawing.Point(563, 389);
            this.selectAllSwitch.Margin = new System.Windows.Forms.Padding(0);
            this.selectAllSwitch.MouseLocation = new System.Drawing.Point(-1, -1);
            this.selectAllSwitch.MouseState = MaterialSkin.MouseState.HOVER;
            this.selectAllSwitch.Name = "selectAllSwitch";
            this.selectAllSwitch.Ripple = true;
            this.selectAllSwitch.Size = new System.Drawing.Size(123, 37);
            this.selectAllSwitch.TabIndex = 6;
            this.selectAllSwitch.Text = "Select All";
            this.selectAllSwitch.UseVisualStyleBackColor = true;
            this.selectAllSwitch.CheckedChanged += new System.EventHandler(this.selectAllSwitch_CheckedChanged);
            // 
            // SaveButton
            // 
            this.SaveButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SaveButton.Depth = 0;
            this.SaveButton.DrawShadows = true;
            this.SaveButton.HighEmphasis = true;
            this.SaveButton.Icon = null;
            this.SaveButton.Location = new System.Drawing.Point(19, 417);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.SaveButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(58, 36);
            this.SaveButton.TabIndex = 7;
            this.SaveButton.Text = "Save";
            this.SaveButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.SaveButton.UseAccentColor = false;
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // SaveAsButton
            // 
            this.SaveAsButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SaveAsButton.Depth = 0;
            this.SaveAsButton.DrawShadows = true;
            this.SaveAsButton.HighEmphasis = true;
            this.SaveAsButton.Icon = null;
            this.SaveAsButton.Location = new System.Drawing.Point(113, 417);
            this.SaveAsButton.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.SaveAsButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.SaveAsButton.Name = "SaveAsButton";
            this.SaveAsButton.Size = new System.Drawing.Size(80, 36);
            this.SaveAsButton.TabIndex = 8;
            this.SaveAsButton.Text = "Save As";
            this.SaveAsButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.SaveAsButton.UseAccentColor = false;
            this.SaveAsButton.UseVisualStyleBackColor = true;
            this.SaveAsButton.Click += new System.EventHandler(this.SaveAsButton_Click);
            // 
            // CheckSysButton
            // 
            this.CheckSysButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CheckSysButton.Depth = 0;
            this.CheckSysButton.DrawShadows = true;
            this.CheckSysButton.HighEmphasis = true;
            this.CheckSysButton.Icon = null;
            this.CheckSysButton.Location = new System.Drawing.Point(226, 417);
            this.CheckSysButton.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.CheckSysButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.CheckSysButton.Name = "CheckSysButton";
            this.CheckSysButton.Size = new System.Drawing.Size(129, 36);
            this.CheckSysButton.TabIndex = 9;
            this.CheckSysButton.Text = "Check System";
            this.CheckSysButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.CheckSysButton.UseAccentColor = false;
            this.CheckSysButton.UseVisualStyleBackColor = true;
            this.CheckSysButton.Click += new System.EventHandler(this.CheckSysButton_Click);
            // 
            // applyPolicyButton
            // 
            this.applyPolicyButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.applyPolicyButton.Depth = 0;
            this.applyPolicyButton.DrawShadows = true;
            this.applyPolicyButton.HighEmphasis = true;
            this.applyPolicyButton.Icon = null;
            this.applyPolicyButton.Location = new System.Drawing.Point(416, 417);
            this.applyPolicyButton.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.applyPolicyButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.applyPolicyButton.Name = "applyPolicyButton";
            this.applyPolicyButton.Size = new System.Drawing.Size(67, 36);
            this.applyPolicyButton.TabIndex = 10;
            this.applyPolicyButton.Text = "Apply";
            this.applyPolicyButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.applyPolicyButton.UseAccentColor = false;
            this.applyPolicyButton.UseVisualStyleBackColor = true;
            this.applyPolicyButton.Click += new System.EventHandler(this.applyPolicyButton_Click);
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Depth = 0;
            this.materialButton1.DrawShadows = true;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(19, 474);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.Size = new System.Drawing.Size(75, 36);
            this.materialButton1.TabIndex = 11;
            this.materialButton1.Text = "Revert";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 526);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.applyPolicyButton);
            this.Controls.Add(this.CheckSysButton);
            this.Controls.Add(this.SaveAsButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.selectAllSwitch);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.ElementsListBox);
            this.Controls.Add(this.checkButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Sizable = false;
            this.Text = "Top Secret";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton checkButton;
        private System.Windows.Forms.CheckedListBox ElementsListBox;
        private MaterialSkin.Controls.MaterialMultiLineTextBox SearchBox;
        private MaterialSkin.Controls.MaterialSwitch selectAllSwitch;
        private MaterialSkin.Controls.MaterialButton SaveButton;
        private MaterialSkin.Controls.MaterialButton SaveAsButton;
        private MaterialSkin.Controls.MaterialButton CheckSysButton;
        private MaterialSkin.Controls.MaterialButton applyPolicyButton;
        private MaterialSkin.Controls.MaterialButton materialButton1;
    }
}