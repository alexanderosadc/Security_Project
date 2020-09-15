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
            this.selectAllButton = new MaterialSkin.Controls.MaterialButton();
            this.SearchBox = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.SearchButton = new MaterialSkin.Controls.MaterialButton();
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
            this.checkButton.Location = new System.Drawing.Point(12, 324);
            this.checkButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.checkButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(69, 36);
            this.checkButton.TabIndex = 1;
            this.checkButton.Text = "Check";
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
            // selectAllButton
            // 
            this.selectAllButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.selectAllButton.Depth = 0;
            this.selectAllButton.DrawShadows = true;
            this.selectAllButton.HighEmphasis = true;
            this.selectAllButton.Icon = null;
            this.selectAllButton.Location = new System.Drawing.Point(270, 324);
            this.selectAllButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.selectAllButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.selectAllButton.Name = "selectAllButton";
            this.selectAllButton.Size = new System.Drawing.Size(103, 36);
            this.selectAllButton.TabIndex = 4;
            this.selectAllButton.Text = "Select All";
            this.selectAllButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.selectAllButton.UseAccentColor = false;
            this.selectAllButton.UseVisualStyleBackColor = true;
            this.selectAllButton.Click += new System.EventHandler(this.selectAllButton_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SearchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchBox.Depth = 0;
            this.SearchBox.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
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
            // SearchButton
            // 
            this.SearchButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SearchButton.Depth = 0;
            this.SearchButton.DrawShadows = true;
            this.SearchButton.HighEmphasis = true;
            this.SearchButton.Icon = null;
            this.SearchButton.Location = new System.Drawing.Point(295, 74);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.SearchButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(78, 36);
            this.SearchButton.TabIndex = 6;
            this.SearchButton.Text = "Search";
            this.SearchButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.SearchButton.UseAccentColor = false;
            this.SearchButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 390);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.selectAllButton);
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
        private MaterialSkin.Controls.MaterialButton selectAllButton;
        private MaterialSkin.Controls.MaterialMultiLineTextBox SearchBox;
        private MaterialSkin.Controls.MaterialButton SearchButton;
    }
}