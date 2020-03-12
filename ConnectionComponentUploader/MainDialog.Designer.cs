namespace ConnectionComponentUploader
{
    partial class MainDialog
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
            this.uploadBtn = new System.Windows.Forms.Button();
            this.pvwaTextBox = new System.Windows.Forms.TextBox();
            this.pvwaLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.selectXMLFileBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uploadBtn
            // 
            this.uploadBtn.Location = new System.Drawing.Point(531, 356);
            this.uploadBtn.Name = "uploadBtn";
            this.uploadBtn.Size = new System.Drawing.Size(75, 23);
            this.uploadBtn.TabIndex = 0;
            this.uploadBtn.Text = "Upload";
            this.uploadBtn.UseVisualStyleBackColor = true;
            this.uploadBtn.Click += new System.EventHandler(this.uploadBtn_Click);
            // 
            // pvwaTextBox
            // 
            this.pvwaTextBox.Location = new System.Drawing.Point(262, 68);
            this.pvwaTextBox.Name = "pvwaTextBox";
            this.pvwaTextBox.Size = new System.Drawing.Size(306, 20);
            this.pvwaTextBox.TabIndex = 1;
            // 
            // pvwaLabel
            // 
            this.pvwaLabel.AutoSize = true;
            this.pvwaLabel.Location = new System.Drawing.Point(52, 71);
            this.pvwaLabel.Name = "pvwaLabel";
            this.pvwaLabel.Size = new System.Drawing.Size(64, 13);
            this.pvwaLabel.TabIndex = 2;
            this.pvwaLabel.Text = "PVWA URL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "PVWA Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "PVWA Password";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(262, 112);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(100, 20);
            this.usernameTextBox.TabIndex = 5;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(262, 151);
            this.passwordTextBox.MaxLength = 30;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(100, 20);
            this.passwordTextBox.TabIndex = 6;
            // 
            // selectXMLFileBtn
            // 
            this.selectXMLFileBtn.Location = new System.Drawing.Point(262, 212);
            this.selectXMLFileBtn.Name = "selectXMLFileBtn";
            this.selectXMLFileBtn.Size = new System.Drawing.Size(75, 23);
            this.selectXMLFileBtn.TabIndex = 7;
            this.selectXMLFileBtn.Text = "Select XML";
            this.selectXMLFileBtn.UseVisualStyleBackColor = true;
            this.selectXMLFileBtn.Click += new System.EventHandler(this.selectXMLFileBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.selectXMLFileBtn);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pvwaLabel);
            this.Controls.Add(this.pvwaTextBox);
            this.Controls.Add(this.uploadBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uploadBtn;
        private System.Windows.Forms.TextBox pvwaTextBox;
        private System.Windows.Forms.Label pvwaLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button selectXMLFileBtn;
    }
}

