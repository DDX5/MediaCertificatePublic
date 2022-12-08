namespace MediaCertificateUtility
{
    partial class CertificateGenerator
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NameField = new System.Windows.Forms.TextBox();
            this.NameStatic = new System.Windows.Forms.Label();
            this.IDStatic = new System.Windows.Forms.Label();
            this.IDField = new System.Windows.Forms.Label();
            this.PasswordStatic = new System.Windows.Forms.Label();
            this.PasswordField = new System.Windows.Forms.TextBox();
            this.PasswordShow = new System.Windows.Forms.CheckBox();
            this.ExpiryStatic = new System.Windows.Forms.Label();
            this.ExpiryField = new System.Windows.Forms.DateTimePicker();
            this.GenerateID = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Writer = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // NameField
            // 
            this.NameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameField.Location = new System.Drawing.Point(129, 9);
            this.NameField.Name = "NameField";
            this.NameField.Size = new System.Drawing.Size(221, 30);
            this.NameField.TabIndex = 1;
            // 
            // NameStatic
            // 
            this.NameStatic.AutoSize = true;
            this.NameStatic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameStatic.Location = new System.Drawing.Point(3, 12);
            this.NameStatic.Name = "NameStatic";
            this.NameStatic.Size = new System.Drawing.Size(70, 25);
            this.NameStatic.TabIndex = 6;
            this.NameStatic.Text = "Name:";
            // 
            // IDStatic
            // 
            this.IDStatic.AutoSize = true;
            this.IDStatic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDStatic.Location = new System.Drawing.Point(3, 51);
            this.IDStatic.Name = "IDStatic";
            this.IDStatic.Size = new System.Drawing.Size(42, 25);
            this.IDStatic.TabIndex = 7;
            this.IDStatic.Text = "ID: ";
            // 
            // IDField
            // 
            this.IDField.AutoSize = true;
            this.IDField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDField.Location = new System.Drawing.Point(124, 51);
            this.IDField.Name = "IDField";
            this.IDField.Size = new System.Drawing.Size(40, 25);
            this.IDField.TabIndex = 8;
            this.IDField.Text = "----";
            // 
            // PasswordStatic
            // 
            this.PasswordStatic.AutoSize = true;
            this.PasswordStatic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordStatic.Location = new System.Drawing.Point(3, 91);
            this.PasswordStatic.Name = "PasswordStatic";
            this.PasswordStatic.Size = new System.Drawing.Size(104, 25);
            this.PasswordStatic.TabIndex = 9;
            this.PasswordStatic.Text = "Password:";
            // 
            // PasswordField
            // 
            this.PasswordField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordField.Location = new System.Drawing.Point(129, 86);
            this.PasswordField.Name = "PasswordField";
            this.PasswordField.Size = new System.Drawing.Size(221, 30);
            this.PasswordField.TabIndex = 10;
            this.PasswordField.UseSystemPasswordChar = true;
            // 
            // PasswordShow
            // 
            this.PasswordShow.AutoSize = true;
            this.PasswordShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordShow.Location = new System.Drawing.Point(377, 92);
            this.PasswordShow.Name = "PasswordShow";
            this.PasswordShow.Size = new System.Drawing.Size(151, 24);
            this.PasswordShow.TabIndex = 11;
            this.PasswordShow.Text = "Show Password";
            this.PasswordShow.UseVisualStyleBackColor = true;
            this.PasswordShow.CheckedChanged += new System.EventHandler(this.PasswordShow_CheckedChanged);
            // 
            // ExpiryStatic
            // 
            this.ExpiryStatic.AutoSize = true;
            this.ExpiryStatic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpiryStatic.Location = new System.Drawing.Point(3, 137);
            this.ExpiryStatic.Name = "ExpiryStatic";
            this.ExpiryStatic.Size = new System.Drawing.Size(72, 25);
            this.ExpiryStatic.TabIndex = 12;
            this.ExpiryStatic.Text = "Expiry:";
            // 
            // ExpiryField
            // 
            this.ExpiryField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpiryField.Location = new System.Drawing.Point(129, 136);
            this.ExpiryField.Name = "ExpiryField";
            this.ExpiryField.Size = new System.Drawing.Size(200, 26);
            this.ExpiryField.TabIndex = 13;
            // 
            // GenerateID
            // 
            this.GenerateID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerateID.Location = new System.Drawing.Point(8, 179);
            this.GenerateID.Name = "GenerateID";
            this.GenerateID.Size = new System.Drawing.Size(147, 74);
            this.GenerateID.TabIndex = 14;
            this.GenerateID.Text = "Generate ID";
            this.GenerateID.UseVisualStyleBackColor = true;
            this.GenerateID.Click += new System.EventHandler(this.GenerateID_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(377, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 74);
            this.button1.TabIndex = 16;
            this.button1.Text = "Generate Certificate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CertificateGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GenerateID);
            this.Controls.Add(this.ExpiryField);
            this.Controls.Add(this.ExpiryStatic);
            this.Controls.Add(this.PasswordShow);
            this.Controls.Add(this.PasswordField);
            this.Controls.Add(this.PasswordStatic);
            this.Controls.Add(this.IDField);
            this.Controls.Add(this.IDStatic);
            this.Controls.Add(this.NameStatic);
            this.Controls.Add(this.NameField);
            this.Name = "CertificateGenerator";
            this.Size = new System.Drawing.Size(1023, 347);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameField;
        private System.Windows.Forms.Label NameStatic;
        private System.Windows.Forms.Label IDStatic;
        private System.Windows.Forms.Label IDField;
        private System.Windows.Forms.Label PasswordStatic;
        private System.Windows.Forms.TextBox PasswordField;
        private System.Windows.Forms.CheckBox PasswordShow;
        private System.Windows.Forms.Label ExpiryStatic;
        private System.Windows.Forms.DateTimePicker ExpiryField;
        private System.Windows.Forms.Button GenerateID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SaveFileDialog Writer;
    }
}
