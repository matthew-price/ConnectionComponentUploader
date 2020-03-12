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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // uploadBtn
            // 
            this.uploadBtn.Location = new System.Drawing.Point(139, 44);
            this.uploadBtn.Name = "uploadBtn";
            this.uploadBtn.Size = new System.Drawing.Size(75, 23);
            this.uploadBtn.TabIndex = 0;
            this.uploadBtn.Text = "Upload";
            this.uploadBtn.UseVisualStyleBackColor = true;
            this.uploadBtn.Click += new System.EventHandler(this.uploadBtn_Click);
            // 
            // pvwaTextBox
            // 
            this.pvwaTextBox.Location = new System.Drawing.Point(98, 31);
            this.pvwaTextBox.Name = "pvwaTextBox";
            this.pvwaTextBox.Size = new System.Drawing.Size(306, 20);
            this.pvwaTextBox.TabIndex = 1;
            // 
            // pvwaLabel
            // 
            this.pvwaLabel.AutoSize = true;
            this.pvwaLabel.Location = new System.Drawing.Point(-3, 34);
            this.pvwaLabel.Name = "pvwaLabel";
            this.pvwaLabel.Size = new System.Drawing.Size(64, 13);
            this.pvwaLabel.TabIndex = 2;
            this.pvwaLabel.Text = "PVWA URL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-3, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "PVWA Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-3, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "PVWA Password";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(98, 81);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(100, 20);
            this.usernameTextBox.TabIndex = 5;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(98, 127);
            this.passwordTextBox.MaxLength = 30;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(100, 20);
            this.passwordTextBox.TabIndex = 6;
            // 
            // selectXMLFileBtn
            // 
            this.selectXMLFileBtn.Location = new System.Drawing.Point(10, 44);
            this.selectXMLFileBtn.Name = "selectXMLFileBtn";
            this.selectXMLFileBtn.Size = new System.Drawing.Size(75, 23);
            this.selectXMLFileBtn.TabIndex = 7;
            this.selectXMLFileBtn.Text = "Select ZIP";
            this.selectXMLFileBtn.UseVisualStyleBackColor = true;
            this.selectXMLFileBtn.Click += new System.EventHandler(this.selectXMLFileBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pvwaLabel);
            this.groupBox1.Controls.Add(this.pvwaTextBox);
            this.groupBox1.Controls.Add(this.passwordTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.usernameTextBox);
            this.groupBox1.Location = new System.Drawing.Point(25, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 178);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Web Portal Settings";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.selectXMLFileBtn);
            this.groupBox2.Controls.Add(this.uploadBtn);
            this.groupBox2.Location = new System.Drawing.Point(25, 232);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(254, 100);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Zip File Settings";
            // 
            // MainDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainDialog";
            this.Text = "Connection Component Uploader";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

