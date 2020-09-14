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
            this.checkButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.applyButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.consoleOutput = new System.Windows.Forms.RichTextBox();
            this.ElementsListBox = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // checkButton
            // 
            this.checkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkButton.AutoSize = true;
            this.checkButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.checkButton.Depth = 0;
            this.checkButton.Location = new System.Drawing.Point(12, 324);
            this.checkButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.checkButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkButton.Name = "checkButton";
            this.checkButton.Primary = false;
            this.checkButton.Size = new System.Drawing.Size(56, 36);
            this.checkButton.TabIndex = 1;
            this.checkButton.Text = "Check";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // applyButton
            // 
            this.applyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.applyButton.AutoSize = true;
            this.applyButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.applyButton.Depth = 0;
            this.applyButton.Location = new System.Drawing.Point(327, 324);
            this.applyButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.applyButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.applyButton.Name = "applyButton";
            this.applyButton.Primary = false;
            this.applyButton.Size = new System.Drawing.Size(54, 36);
            this.applyButton.TabIndex = 1;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // consoleOutput
            // 
            this.consoleOutput.Location = new System.Drawing.Point(12, 231);
            this.consoleOutput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.consoleOutput.Name = "consoleOutput";
            this.consoleOutput.Size = new System.Drawing.Size(359, 86);
            this.consoleOutput.TabIndex = 2;
            this.consoleOutput.Text = "";
            // 
            // ElementsListBox
            // 
            this.ElementsListBox.FormattingEnabled = true;
            this.ElementsListBox.Location = new System.Drawing.Point(12, 77);
            this.ElementsListBox.Name = "ElementsListBox";
            this.ElementsListBox.Size = new System.Drawing.Size(359, 139);
            this.ElementsListBox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 366);
            this.Controls.Add(this.ElementsListBox);
            this.Controls.Add(this.consoleOutput);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.checkButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Sizable = false;
            this.Text = "Top Secret";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialFlatButton checkButton;
        private MaterialSkin.Controls.MaterialFlatButton applyButton;
        private System.Windows.Forms.RichTextBox consoleOutput;
        private System.Windows.Forms.CheckedListBox ElementsListBox;
    }
}