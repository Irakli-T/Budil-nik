namespace Будильник_и_таймер_сна
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxHour = new System.Windows.Forms.TextBox();
            this.textBoxMinut = new System.Windows.Forms.TextBox();
            this.textBoxSecond = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonMusicSelection = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBoxVolume = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Label();
            this.ButtonWelding = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(87, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Сигнал сработает в";
            // 
            // textBoxHour
            // 
            this.textBoxHour.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxHour.Location = new System.Drawing.Point(66, 47);
            this.textBoxHour.Name = "textBoxHour";
            this.textBoxHour.Size = new System.Drawing.Size(50, 31);
            this.textBoxHour.TabIndex = 2;
            this.textBoxHour.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxHour_KeyPress);
            this.textBoxHour.Leave += new System.EventHandler(this.textBoxHour_Leave);
            // 
            // textBoxMinut
            // 
            this.textBoxMinut.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxMinut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMinut.Location = new System.Drawing.Point(154, 47);
            this.textBoxMinut.Name = "textBoxMinut";
            this.textBoxMinut.Size = new System.Drawing.Size(50, 31);
            this.textBoxMinut.TabIndex = 3;
            this.textBoxMinut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMinut_KeyPress);
            this.textBoxMinut.Leave += new System.EventHandler(this.textBoxMinut_Leave);
            // 
            // textBoxSecond
            // 
            this.textBoxSecond.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSecond.Location = new System.Drawing.Point(239, 47);
            this.textBoxSecond.Name = "textBoxSecond";
            this.textBoxSecond.Size = new System.Drawing.Size(50, 31);
            this.textBoxSecond.TabIndex = 4;
            this.textBoxSecond.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSecond_KeyPress);
            this.textBoxSecond.Leave += new System.EventHandler(this.textBoxSecond_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(118, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ч";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(205, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "М";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(291, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "С";
            // 
            // buttonMusicSelection
            // 
            this.buttonMusicSelection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMusicSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMusicSelection.Location = new System.Drawing.Point(85, 107);
            this.buttonMusicSelection.Name = "buttonMusicSelection";
            this.buttonMusicSelection.Size = new System.Drawing.Size(133, 35);
            this.buttonMusicSelection.TabIndex = 8;
            this.buttonMusicSelection.Text = "Выберите песню";
            this.buttonMusicSelection.UseVisualStyleBackColor = true;
            this.buttonMusicSelection.Click += new System.EventHandler(this.buttonMusicSelection_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(139)))), ((int)(((byte)(159)))));
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStart.Location = new System.Drawing.Point(85, 166);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(133, 30);
            this.buttonStart.TabIndex = 9;
            this.buttonStart.Text = "Запустить";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBoxVolume
            // 
            this.textBoxVolume.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxVolume.Location = new System.Drawing.Point(273, 109);
            this.textBoxVolume.Name = "textBoxVolume";
            this.textBoxVolume.Size = new System.Drawing.Size(50, 31);
            this.textBoxVolume.TabIndex = 10;
            this.textBoxVolume.TextChanged += new System.EventHandler(this.textBoxVolume_TextChanged);
            this.textBoxVolume.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVolume_KeyPress);
            this.textBoxVolume.Leave += new System.EventHandler(this.textBoxVolume_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(329, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "Громкость";
            // 
            // CloseButton
            // 
            this.CloseButton.AutoSize = true;
            this.CloseButton.BackColor = System.Drawing.Color.Transparent;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(139)))), ((int)(((byte)(159)))));
            this.CloseButton.Location = new System.Drawing.Point(428, 3);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(27, 26);
            this.CloseButton.TabIndex = 12;
            this.CloseButton.Text = "Х";
            this.CloseButton.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            this.CloseButton.MouseEnter += new System.EventHandler(this.CloseButton_MouseEnter);
            this.CloseButton.MouseLeave += new System.EventHandler(this.CloseButton_MouseLeave);
            // 
            // ButtonWelding
            // 
            this.ButtonWelding.AutoSize = true;
            this.ButtonWelding.BackColor = System.Drawing.Color.Transparent;
            this.ButtonWelding.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonWelding.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonWelding.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(139)))), ((int)(((byte)(159)))));
            this.ButtonWelding.Location = new System.Drawing.Point(397, -3);
            this.ButtonWelding.Name = "ButtonWelding";
            this.ButtonWelding.Size = new System.Drawing.Size(32, 31);
            this.ButtonWelding.TabIndex = 13;
            this.ButtonWelding.Text = "--";
            this.ButtonWelding.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.ButtonWelding.Click += new System.EventHandler(this.ButtonWelding_Click);
            this.ButtonWelding.MouseEnter += new System.EventHandler(this.ButtonWelding_MouseEnter);
            this.ButtonWelding.MouseLeave += new System.EventHandler(this.ButtonWelding_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cascadia Code SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(139)))), ((int)(((byte)(159)))));
            this.label1.Location = new System.Drawing.Point(312, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Tomaradze";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(139)))), ((int)(((byte)(159)))));
            this.label7.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label7.Location = new System.Drawing.Point(418, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "I.T.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Будильник.Properties.Resources.Фон_будильник;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(457, 236);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonWelding);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxVolume);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonMusicSelection);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxSecond);
            this.Controls.Add(this.textBoxMinut);
            this.Controls.Add(this.textBoxHour);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Будильник";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxHour;
        private System.Windows.Forms.TextBox textBoxMinut;
        private System.Windows.Forms.TextBox textBoxSecond;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonMusicSelection;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBoxVolume;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Label ButtonWelding;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
    }
}

