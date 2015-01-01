namespace WebcamNesneTespit
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.baslatBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.yonLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.manBtn = new System.Windows.Forms.Button();
            this.otoBtn = new System.Windows.Forms.Button();
            this.mangroupBox = new System.Windows.Forms.GroupBox();
            this.controlTextBox = new System.Windows.Forms.TextBox();
            this.geriBtn = new System.Windows.Forms.Button();
            this.ileriBtn = new System.Windows.Forms.Button();
            this.solBtn = new System.Windows.Forms.Button();
            this.sagBtn = new System.Windows.Forms.Button();
            this.kontoltipLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.mangroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(948, 291);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 379);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(169, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Text = "Kamerayı Seçiniz";
            // 
            // baslatBtn
            // 
            this.baslatBtn.Location = new System.Drawing.Point(12, 410);
            this.baslatBtn.Name = "baslatBtn";
            this.baslatBtn.Size = new System.Drawing.Size(75, 23);
            this.baslatBtn.TabIndex = 2;
            this.baslatBtn.Text = "Başlat";
            this.baslatBtn.UseVisualStyleBackColor = true;
            this.baslatBtn.Click += new System.EventHandler(this.baslatBtn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 439);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Durdur";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(93, 406);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(88, 56);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(15, 33);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(48, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Mavi";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(15, 10);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(51, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Siyah";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(500, 404);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Yön :";
            // 
            // yonLabel
            // 
            this.yonLabel.AutoSize = true;
            this.yonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yonLabel.ForeColor = System.Drawing.Color.Teal;
            this.yonLabel.Location = new System.Drawing.Point(543, 404);
            this.yonLabel.Name = "yonLabel";
            this.yonLabel.Size = new System.Drawing.Size(19, 13);
            this.yonLabel.TabIndex = 6;
            this.yonLabel.Text = "...";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.manBtn);
            this.groupBox2.Controls.Add(this.otoBtn);
            this.groupBox2.Location = new System.Drawing.Point(207, 379);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(177, 85);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kontrol Tipi";
            // 
            // manBtn
            // 
            this.manBtn.Enabled = false;
            this.manBtn.Location = new System.Drawing.Point(99, 29);
            this.manBtn.Name = "manBtn";
            this.manBtn.Size = new System.Drawing.Size(72, 33);
            this.manBtn.TabIndex = 10;
            this.manBtn.Text = "Manuel";
            this.manBtn.UseVisualStyleBackColor = true;
            this.manBtn.Click += new System.EventHandler(this.manBtn_Click);
            // 
            // otoBtn
            // 
            this.otoBtn.Location = new System.Drawing.Point(6, 29);
            this.otoBtn.Name = "otoBtn";
            this.otoBtn.Size = new System.Drawing.Size(72, 33);
            this.otoBtn.TabIndex = 9;
            this.otoBtn.Text = "Otomatik";
            this.otoBtn.UseVisualStyleBackColor = true;
            this.otoBtn.Click += new System.EventHandler(this.otoBtn_Click);
            // 
            // mangroupBox
            // 
            this.mangroupBox.Controls.Add(this.controlTextBox);
            this.mangroupBox.Controls.Add(this.geriBtn);
            this.mangroupBox.Controls.Add(this.ileriBtn);
            this.mangroupBox.Controls.Add(this.solBtn);
            this.mangroupBox.Controls.Add(this.sagBtn);
            this.mangroupBox.Location = new System.Drawing.Point(746, 354);
            this.mangroupBox.Name = "mangroupBox";
            this.mangroupBox.Size = new System.Drawing.Size(177, 127);
            this.mangroupBox.TabIndex = 11;
            this.mangroupBox.TabStop = false;
            this.mangroupBox.Text = "Manuel Kontrol";
            // 
            // controlTextBox
            // 
            this.controlTextBox.Location = new System.Drawing.Point(45, 102);
            this.controlTextBox.Name = "controlTextBox";
            this.controlTextBox.Size = new System.Drawing.Size(100, 20);
            this.controlTextBox.TabIndex = 18;
            this.controlTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // geriBtn
            // 
            this.geriBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.geriBtn.Location = new System.Drawing.Point(70, 55);
            this.geriBtn.Name = "geriBtn";
            this.geriBtn.Size = new System.Drawing.Size(46, 41);
            this.geriBtn.TabIndex = 17;
            this.geriBtn.Text = "↓";
            this.geriBtn.UseVisualStyleBackColor = true;
            this.geriBtn.Click += new System.EventHandler(this.geriBtn_Click);
            // 
            // ileriBtn
            // 
            this.ileriBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ileriBtn.Location = new System.Drawing.Point(70, 14);
            this.ileriBtn.Name = "ileriBtn";
            this.ileriBtn.Size = new System.Drawing.Size(46, 41);
            this.ileriBtn.TabIndex = 16;
            this.ileriBtn.Text = "↑";
            this.ileriBtn.UseVisualStyleBackColor = true;
            this.ileriBtn.Click += new System.EventHandler(this.ileriBtn_Click);
            // 
            // solBtn
            // 
            this.solBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.solBtn.Location = new System.Drawing.Point(21, 55);
            this.solBtn.Name = "solBtn";
            this.solBtn.Size = new System.Drawing.Size(46, 41);
            this.solBtn.TabIndex = 15;
            this.solBtn.Text = "←";
            this.solBtn.UseVisualStyleBackColor = true;
            this.solBtn.Click += new System.EventHandler(this.solBtn_Click);
            // 
            // sagBtn
            // 
            this.sagBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sagBtn.Location = new System.Drawing.Point(119, 55);
            this.sagBtn.Name = "sagBtn";
            this.sagBtn.Size = new System.Drawing.Size(46, 41);
            this.sagBtn.TabIndex = 14;
            this.sagBtn.Text = "→";
            this.sagBtn.UseVisualStyleBackColor = true;
            this.sagBtn.Click += new System.EventHandler(this.sagBtn_Click);
            // 
            // kontoltipLabel
            // 
            this.kontoltipLabel.AutoSize = true;
            this.kontoltipLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kontoltipLabel.ForeColor = System.Drawing.Color.Teal;
            this.kontoltipLabel.Location = new System.Drawing.Point(543, 436);
            this.kontoltipLabel.Name = "kontoltipLabel";
            this.kontoltipLabel.Size = new System.Drawing.Size(48, 13);
            this.kontoltipLabel.TabIndex = 13;
            this.kontoltipLabel.Text = "Manuel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(411, 437);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Mevcut Kontrol Tipi :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 476);
            this.Controls.Add(this.kontoltipLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mangroupBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.yonLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.baslatBtn);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Çizgi İzleyen Robot Kontrol Paneli";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.mangroupBox.ResumeLayout(false);
            this.mangroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button baslatBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label yonLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button manBtn;
        private System.Windows.Forms.Button otoBtn;
        private System.Windows.Forms.GroupBox mangroupBox;
        private System.Windows.Forms.Button sagBtn;
        private System.Windows.Forms.Button geriBtn;
        private System.Windows.Forms.Button ileriBtn;
        private System.Windows.Forms.Button solBtn;
        private System.Windows.Forms.Label kontoltipLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox controlTextBox;
    }
}

