namespace MetripolCamera
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.m_CbDevices = new System.Windows.Forms.ComboBox();
            this.m_LblDevName = new System.Windows.Forms.Label();
            this.m_LbVlRes = new System.Windows.Forms.Label();
            this.m_CbVRes = new System.Windows.Forms.ComboBox();
            this.m_BtnUpdate = new System.Windows.Forms.Button();
            this.m_LblSRes = new System.Windows.Forms.Label();
            this.m_CbSnapRes = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(685, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(685, 261);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Disconnect";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(685, 336);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "MkPhoto";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(44, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(402, 294);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(546, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Interval = 33;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // m_CbDevices
            // 
            this.m_CbDevices.FormattingEnabled = true;
            this.m_CbDevices.Location = new System.Drawing.Point(522, 70);
            this.m_CbDevices.Name = "m_CbDevices";
            this.m_CbDevices.Size = new System.Drawing.Size(121, 21);
            this.m_CbDevices.TabIndex = 5;
            this.m_CbDevices.SelectedIndexChanged += new System.EventHandler(this.m_CbDevices_SelectedIndexChanged);
            // 
            // m_LblDevName
            // 
            this.m_LblDevName.AutoSize = true;
            this.m_LblDevName.Location = new System.Drawing.Point(519, 54);
            this.m_LblDevName.Name = "m_LblDevName";
            this.m_LblDevName.Size = new System.Drawing.Size(41, 13);
            this.m_LblDevName.TabIndex = 6;
            this.m_LblDevName.Text = "Device";
            // 
            // m_LbVlRes
            // 
            this.m_LbVlRes.AutoSize = true;
            this.m_LbVlRes.Location = new System.Drawing.Point(519, 99);
            this.m_LbVlRes.Name = "m_LbVlRes";
            this.m_LbVlRes.Size = new System.Drawing.Size(87, 13);
            this.m_LbVlRes.TabIndex = 8;
            this.m_LbVlRes.Text = "Video Resolution";
            // 
            // m_CbVRes
            // 
            this.m_CbVRes.FormattingEnabled = true;
            this.m_CbVRes.Location = new System.Drawing.Point(522, 115);
            this.m_CbVRes.Name = "m_CbVRes";
            this.m_CbVRes.Size = new System.Drawing.Size(121, 21);
            this.m_CbVRes.TabIndex = 7;
            // 
            // m_BtnUpdate
            // 
            this.m_BtnUpdate.Location = new System.Drawing.Point(649, 70);
            this.m_BtnUpdate.Name = "m_BtnUpdate";
            this.m_BtnUpdate.Size = new System.Drawing.Size(75, 66);
            this.m_BtnUpdate.TabIndex = 9;
            this.m_BtnUpdate.Text = "Update";
            this.m_BtnUpdate.UseVisualStyleBackColor = true;
            this.m_BtnUpdate.Click += new System.EventHandler(this.m_BtnUpdate_Click);
            // 
            // m_LblSRes
            // 
            this.m_LblSRes.AutoSize = true;
            this.m_LblSRes.Location = new System.Drawing.Point(519, 148);
            this.m_LblSRes.Name = "m_LblSRes";
            this.m_LblSRes.Size = new System.Drawing.Size(111, 13);
            this.m_LblSRes.TabIndex = 11;
            this.m_LblSRes.Text = "Snapshoot Resolution";
            // 
            // m_CbSnapRes
            // 
            this.m_CbSnapRes.FormattingEnabled = true;
            this.m_CbSnapRes.Location = new System.Drawing.Point(522, 164);
            this.m_CbSnapRes.Name = "m_CbSnapRes";
            this.m_CbSnapRes.Size = new System.Drawing.Size(121, 21);
            this.m_CbSnapRes.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.m_LblSRes);
            this.Controls.Add(this.m_CbSnapRes);
            this.Controls.Add(this.m_BtnUpdate);
            this.Controls.Add(this.m_LbVlRes);
            this.Controls.Add(this.m_CbVRes);
            this.Controls.Add(this.m_LblDevName);
            this.Controls.Add(this.m_CbDevices);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox m_CbDevices;
        private System.Windows.Forms.Label m_LblDevName;
        private System.Windows.Forms.Label m_LbVlRes;
        private System.Windows.Forms.ComboBox m_CbVRes;
        private System.Windows.Forms.Button m_BtnUpdate;
        private System.Windows.Forms.Label m_LblSRes;
        private System.Windows.Forms.ComboBox m_CbSnapRes;
    }
}

