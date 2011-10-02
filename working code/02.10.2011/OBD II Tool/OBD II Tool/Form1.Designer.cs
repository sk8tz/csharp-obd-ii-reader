namespace OBD_II_Tool
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_rpm = new System.Windows.Forms.TextBox();
            this.rpmworker = new System.ComponentModel.BackgroundWorker();
            this.rpmbar = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_live = new System.Windows.Forms.Button();
            this.tb_speed = new System.Windows.Forms.TextBox();
            this.speedbar = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.loadbar = new System.Windows.Forms.ProgressBar();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_test = new System.Windows.Forms.TextBox();
            this.btn_about = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_rpm
            // 
            this.tb_rpm.Location = new System.Drawing.Point(12, 12);
            this.tb_rpm.Name = "tb_rpm";
            this.tb_rpm.Size = new System.Drawing.Size(100, 20);
            this.tb_rpm.TabIndex = 1;
            // 
            // rpmbar
            // 
            this.rpmbar.Location = new System.Drawing.Point(12, 38);
            this.rpmbar.Maximum = 7500;
            this.rpmbar.Name = "rpmbar";
            this.rpmbar.Size = new System.Drawing.Size(586, 23);
            this.rpmbar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.rpmbar.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(150, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "NA";
            // 
            // btn_live
            // 
            this.btn_live.Location = new System.Drawing.Point(12, 126);
            this.btn_live.Name = "btn_live";
            this.btn_live.Size = new System.Drawing.Size(75, 23);
            this.btn_live.TabIndex = 4;
            this.btn_live.Text = "Live";
            this.btn_live.UseVisualStyleBackColor = true;
            this.btn_live.Click += new System.EventHandler(this.btn_live_Click);
            // 
            // tb_speed
            // 
            this.tb_speed.Location = new System.Drawing.Point(13, 68);
            this.tb_speed.Name = "tb_speed";
            this.tb_speed.Size = new System.Drawing.Size(100, 20);
            this.tb_speed.TabIndex = 5;
            // 
            // speedbar
            // 
            this.speedbar.Location = new System.Drawing.Point(13, 95);
            this.speedbar.Maximum = 255;
            this.speedbar.Name = "speedbar";
            this.speedbar.Size = new System.Drawing.Size(585, 23);
            this.speedbar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.speedbar.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(150, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "NA";
            // 
            // loadbar
            // 
            this.loadbar.Location = new System.Drawing.Point(498, 126);
            this.loadbar.Name = "loadbar";
            this.loadbar.Size = new System.Drawing.Size(100, 23);
            this.loadbar.Step = 1;
            this.loadbar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.loadbar.TabIndex = 8;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "COM0",
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9",
            "CNCA0",
            "CNCB0"});
            this.comboBox1.Location = new System.Drawing.Point(93, 128);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.Text = "PORT";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(309, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_test
            // 
            this.tb_test.Location = new System.Drawing.Point(392, 128);
            this.tb_test.Name = "tb_test";
            this.tb_test.Size = new System.Drawing.Size(100, 20);
            this.tb_test.TabIndex = 11;
            // 
            // btn_about
            // 
            this.btn_about.Location = new System.Drawing.Point(523, 9);
            this.btn_about.Name = "btn_about";
            this.btn_about.Size = new System.Drawing.Size(75, 23);
            this.btn_about.TabIndex = 12;
            this.btn_about.Text = "ABOUT";
            this.btn_about.UseVisualStyleBackColor = true;
            this.btn_about.Click += new System.EventHandler(this.btn_about_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 173);
            this.Controls.Add(this.btn_about);
            this.Controls.Add(this.tb_test);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.loadbar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.speedbar);
            this.Controls.Add(this.tb_speed);
            this.Controls.Add(this.btn_live);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rpmbar);
            this.Controls.Add(this.tb_rpm);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_rpm;
        private System.ComponentModel.BackgroundWorker rpmworker;
        private System.Windows.Forms.ProgressBar rpmbar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_live;
        private System.Windows.Forms.TextBox tb_speed;
        private System.Windows.Forms.ProgressBar speedbar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar loadbar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_test;
        private System.Windows.Forms.Button btn_about;
    }
}

