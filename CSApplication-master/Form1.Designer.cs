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
            this.consoleOutput = new MaterialSkin.Controls.MaterialLabel();
            this.checkButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.applyButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // consoleOutput
            // 
            this.consoleOutput.Depth = 0;
            this.consoleOutput.Font = new System.Drawing.Font("Roboto", 11F);
            this.consoleOutput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.consoleOutput.Location = new System.Drawing.Point(12, 290);
            this.consoleOutput.MouseState = MaterialSkin.MouseState.HOVER;
            this.consoleOutput.Name = "consoleOutput";
            this.consoleOutput.Size = new System.Drawing.Size(426, 99);
            this.consoleOutput.TabIndex = 0;
            // 
            // checkButton
            // 
            this.checkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkButton.AutoSize = true;
            this.checkButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.checkButton.Depth = 0;
            this.checkButton.Location = new System.Drawing.Point(16, 399);
            this.checkButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.checkButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkButton.Name = "checkButton";
            this.checkButton.Primary = false;
            this.checkButton.Size = new System.Drawing.Size(68, 36);
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
            this.applyButton.Location = new System.Drawing.Point(369, 399);
            this.applyButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.applyButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.applyButton.Name = "applyButton";
            this.applyButton.Primary = false;
            this.applyButton.Size = new System.Drawing.Size(66, 36);
            this.applyButton.TabIndex = 1;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 450);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.consoleOutput);
            this.Name = "Form1";
            this.Sizable = false;
            this.Text = "Top Secret";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel consoleOutput;
        private MaterialSkin.Controls.MaterialFlatButton checkButton;
        private MaterialSkin.Controls.MaterialFlatButton applyButton;
    }
}