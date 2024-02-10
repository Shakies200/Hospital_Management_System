namespace Hospital_Management_System
{
    partial class Login
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
            this.Enter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Can = new System.Windows.Forms.Button();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.checkfilepa = new System.Windows.Forms.Button();
            this.linknafw = new System.Windows.Forms.Button();
            this.Dept_Engineering = new System.Windows.Forms.Button();
            this.Req = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // Enter
            // 
            this.Enter.BackColor = System.Drawing.Color.Honeydew;
            this.Enter.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enter.ForeColor = System.Drawing.Color.DarkRed;
            this.Enter.Location = new System.Drawing.Point(12, 565);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(102, 38);
            this.Enter.TabIndex = 1;
            this.Enter.Text = "LOG IN";
            this.Enter.UseVisualStyleBackColor = false;
            this.Enter.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(24, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(364, 33);
            this.label2.TabIndex = 6;
            this.label2.Text = "Welcome you in your Database";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(12, 388);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "USER ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(12, 479);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "PASSWORD";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.textBox1.Location = new System.Drawing.Point(16, 428);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(142, 20);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.textBox2.Location = new System.Drawing.Point(16, 519);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(142, 20);
            this.textBox2.TabIndex = 10;
            // 
            // Can
            // 
            this.Can.BackColor = System.Drawing.Color.DarkRed;
            this.Can.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Can.ForeColor = System.Drawing.Color.Transparent;
            this.Can.Location = new System.Drawing.Point(886, 571);
            this.Can.Name = "Can";
            this.Can.Size = new System.Drawing.Size(79, 27);
            this.Can.TabIndex = 11;
            this.Can.Text = "EXIT";
            this.Can.UseVisualStyleBackColor = false;
            this.Can.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonCheck
            // 
            this.buttonCheck.BackColor = System.Drawing.Color.Honeydew;
            this.buttonCheck.BackgroundImage = global::Hospital_Management_System.Properties.Resources.banner;
            this.buttonCheck.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCheck.ForeColor = System.Drawing.Color.DarkRed;
            this.buttonCheck.Location = new System.Drawing.Point(836, 45);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(152, 38);
            this.buttonCheck.TabIndex = 12;
            this.buttonCheck.Text = "Check Status";
            this.buttonCheck.UseVisualStyleBackColor = false;
            this.buttonCheck.Click += new System.EventHandler(this.button3_Click);
            // 
            // checkfilepa
            // 
            this.checkfilepa.BackColor = System.Drawing.Color.Honeydew;
            this.checkfilepa.BackgroundImage = global::Hospital_Management_System.Properties.Resources.banner;
            this.checkfilepa.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkfilepa.ForeColor = System.Drawing.Color.DarkRed;
            this.checkfilepa.Location = new System.Drawing.Point(836, 111);
            this.checkfilepa.Name = "checkfilepa";
            this.checkfilepa.Size = new System.Drawing.Size(152, 38);
            this.checkfilepa.TabIndex = 13;
            this.checkfilepa.Text = "Check File";
            this.checkfilepa.UseVisualStyleBackColor = false;
            // 
            // linknafw
            // 
            this.linknafw.BackColor = System.Drawing.Color.Honeydew;
            this.linknafw.BackgroundImage = global::Hospital_Management_System.Properties.Resources.banner;
            this.linknafw.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linknafw.ForeColor = System.Drawing.Color.DarkRed;
            this.linknafw.Location = new System.Drawing.Point(836, 181);
            this.linknafw.Name = "linknafw";
            this.linknafw.Size = new System.Drawing.Size(152, 38);
            this.linknafw.TabIndex = 14;
            this.linknafw.Text = "Inquiry from Nafaz";
            this.linknafw.UseVisualStyleBackColor = false;
            // 
            // Dept_Engineering
            // 
            this.Dept_Engineering.BackColor = System.Drawing.Color.Honeydew;
            this.Dept_Engineering.BackgroundImage = global::Hospital_Management_System.Properties.Resources.banner;
            this.Dept_Engineering.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dept_Engineering.ForeColor = System.Drawing.Color.DarkRed;
            this.Dept_Engineering.Location = new System.Drawing.Point(836, 255);
            this.Dept_Engineering.Name = "Dept_Engineering";
            this.Dept_Engineering.Size = new System.Drawing.Size(152, 52);
            this.Dept_Engineering.TabIndex = 15;
            this.Dept_Engineering.Text = "Maintenance Request";
            this.Dept_Engineering.UseVisualStyleBackColor = false;
            // 
            // Req
            // 
            this.Req.BackColor = System.Drawing.Color.Honeydew;
            this.Req.BackgroundImage = global::Hospital_Management_System.Properties.Resources.banner;
            this.Req.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Req.ForeColor = System.Drawing.Color.DarkRed;
            this.Req.Location = new System.Drawing.Point(836, 341);
            this.Req.Name = "Req";
            this.Req.Size = new System.Drawing.Size(152, 52);
            this.Req.TabIndex = 17;
            this.Req.Text = "Room EM";
            this.Req.UseVisualStyleBackColor = false;
            this.Req.Click += new System.EventHandler(this.button8_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            this.fileSystemWatcher1.Changed += new System.IO.FileSystemEventHandler(this.fileSystemWatcher1_Changed);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::Hospital_Management_System.Properties.Resources.y2mate_is_Abstractwavebackground_cEkUbUfjGvw_1080pp_1707105539_ezgif_com_video_to_gif_converter;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1009, 629);
            this.Controls.Add(this.Req);
            this.Controls.Add(this.Dept_Engineering);
            this.Controls.Add(this.linknafw);
            this.Controls.Add(this.checkfilepa);
            this.Controls.Add(this.buttonCheck);
            this.Controls.Add(this.Can);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Enter);
            this.DoubleBuffered = true;
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Enter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Can;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.Button checkfilepa;
        private System.Windows.Forms.Button linknafw;
        private System.Windows.Forms.Button Dept_Engineering;
        private System.Windows.Forms.Button Req;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}

