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
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
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
            this.checkButton.Location = new System.Drawing.Point(296, 71);
            this.checkButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
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
            this.ElementsListBox.FormattingEnabled = true;
            this.ElementsListBox.Location = new System.Drawing.Point(14, 116);
            this.ElementsListBox.Name = "ElementsListBox";
            this.ElementsListBox.Size = new System.Drawing.Size(359, 199);
            this.ElementsListBox.TabIndex = 3;
            // 
            // SearchBox
            // 
            this.SearchBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SearchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchBox.Depth = 0;
            this.SearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.SearchBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SearchBox.Hint = "";
            this.SearchBox.Location = new System.Drawing.Point(14, 78);
            this.SearchBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.SearchBox.Size = new System.Drawing.Size(274, 32);
            this.SearchBox.TabIndex = 5;
            this.SearchBox.Text = "";
            // 
            // selectAllSwitch
            // 
            this.selectAllSwitch.AutoSize = true;
            this.selectAllSwitch.Depth = 0;
            this.selectAllSwitch.Location = new System.Drawing.Point(251, 318);
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
            this.SaveButton.Location = new System.Drawing.Point(14, 339);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
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
            this.SaveAsButton.Location = new System.Drawing.Point(80, 339);
            this.SaveAsButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 390);
            this.Controls.Add(this.SaveAsButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.selectAllSwitch);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.ElementsListBox);
            this.Controls.Add(this.checkButton);
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}