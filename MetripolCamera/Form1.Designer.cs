﻿namespace MetripolCamera
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
            this.m_LblRes = new System.Windows.Forms.Label();
            this.m_CbRes = new System.Windows.Forms.ComboBox();
            this.m_BtnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(649, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(649, 207);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Disconnect";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(649, 282);
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
            // m_LblRes
            // 
            this.m_LblRes.AutoSize = true;
            this.m_LblRes.Location = new System.Drawing.Point(519, 99);
            this.m_LblRes.Name = "m_LblRes";
            this.m_LblRes.Size = new System.Drawing.Size(57, 13);
            this.m_LblRes.TabIndex = 8;
            this.m_LblRes.Text = "Resolution";
            // 
            // m_CbRes
            // 
            this.m_CbRes.FormattingEnabled = true;
            this.m_CbRes.Location = new System.Drawing.Point(522, 115);
            this.m_CbRes.Name = "m_CbRes";
            this.m_CbRes.Size = new System.Drawing.Size(121, 21);
            this.m_CbRes.TabIndex = 7;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.m_BtnUpdate);
            this.Controls.Add(this.m_LblRes);
            this.Controls.Add(this.m_CbRes);
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
        private System.Windows.Forms.Label m_LblRes;
        private System.Windows.Forms.ComboBox m_CbRes;
        private System.Windows.Forms.Button m_BtnUpdate;
    }
}

