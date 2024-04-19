namespace UserRegisterApp
{
    partial class LoginPage
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
            this.txtLogPass = new System.Windows.Forms.TextBox();
            this.txtLogUN = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLogPage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtLogPass
            // 
            this.txtLogPass.Font = new System.Drawing.Font("Bell MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogPass.Location = new System.Drawing.Point(323, 199);
            this.txtLogPass.Name = "txtLogPass";
            this.txtLogPass.Size = new System.Drawing.Size(270, 26);
            this.txtLogPass.TabIndex = 21;
            this.txtLogPass.UseSystemPasswordChar = true;
            // 
            // txtLogUN
            // 
            this.txtLogUN.Font = new System.Drawing.Font("Bell MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogUN.Location = new System.Drawing.Point(323, 135);
            this.txtLogUN.Name = "txtLogUN";
            this.txtLogUN.Size = new System.Drawing.Size(270, 26);
            this.txtLogUN.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bell MT", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(197, 203);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 22);
            this.label9.TabIndex = 19;
            this.label9.Text = "Password :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bell MT", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(197, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 22);
            this.label4.TabIndex = 18;
            this.label4.Text = "User Name :";
            // 
            // btnLogPage
            // 
            this.btnLogPage.Font = new System.Drawing.Font("Bell MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogPage.Location = new System.Drawing.Point(412, 281);
            this.btnLogPage.Name = "btnLogPage";
            this.btnLogPage.Size = new System.Drawing.Size(98, 40);
            this.btnLogPage.TabIndex = 22;
            this.btnLogPage.Text = "Login";
            this.btnLogPage.UseVisualStyleBackColor = true;
            this.btnLogPage.Click += new System.EventHandler(this.btnLogPage_Click);
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLogPage);
            this.Controls.Add(this.txtLogPass);
            this.Controls.Add(this.txtLogUN);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Name = "LoginPage";
            this.Text = "LoginPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLogPass;
        private System.Windows.Forms.TextBox txtLogUN;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLogPage;
    }
}