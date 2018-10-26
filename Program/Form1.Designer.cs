namespace WindowsFormsApp1
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
            this.B1 = new System.Windows.Forms.Button();
            this.TBa = new System.Windows.Forms.TextBox();
            this.TBb = new System.Windows.Forms.TextBox();
            this.TBc = new System.Windows.Forms.TextBox();
            this.TBd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LX1 = new System.Windows.Forms.Label();
            this.LX2 = new System.Windows.Forms.Label();
            this.AnswerX1 = new System.Windows.Forms.Label();
            this.AnswerX2 = new System.Windows.Forms.Label();
            this.labelD = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.LX = new System.Windows.Forms.Label();
            this.X = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Lend = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // B1
            // 
            this.B1.FlatAppearance.BorderColor = System.Drawing.Color.Olive;
            this.B1.FlatAppearance.BorderSize = 4;
            this.B1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.B1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.B1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.B1.Location = new System.Drawing.Point(364, 307);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(119, 49);
            this.B1.TabIndex = 0;
            this.B1.Text = "Решить";
            this.B1.UseVisualStyleBackColor = true;
            this.B1.Click += new System.EventHandler(this.B1_Click);
            // 
            // TBa
            // 
            this.TBa.Location = new System.Drawing.Point(12, 12);
            this.TBa.Name = "TBa";
            this.TBa.Size = new System.Drawing.Size(80, 22);
            this.TBa.TabIndex = 1;
            // 
            // TBb
            // 
            this.TBb.Location = new System.Drawing.Point(120, 12);
            this.TBb.Name = "TBb";
            this.TBb.Size = new System.Drawing.Size(122, 22);
            this.TBb.TabIndex = 2;
            // 
            // TBc
            // 
            this.TBc.Location = new System.Drawing.Point(270, 13);
            this.TBc.Name = "TBc";
            this.TBc.Size = new System.Drawing.Size(141, 22);
            this.TBc.TabIndex = 3;
            // 
            // TBd
            // 
            this.TBd.Location = new System.Drawing.Point(461, 13);
            this.TBd.Name = "TBd";
            this.TBd.Size = new System.Drawing.Size(120, 22);
            this.TBd.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(417, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "+";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "+";
            // 
            // LX1
            // 
            this.LX1.AutoSize = true;
            this.LX1.Location = new System.Drawing.Point(12, 217);
            this.LX1.Name = "LX1";
            this.LX1.Size = new System.Drawing.Size(0, 17);
            this.LX1.TabIndex = 8;
            // 
            // LX2
            // 
            this.LX2.AutoSize = true;
            this.LX2.Location = new System.Drawing.Point(12, 248);
            this.LX2.Name = "LX2";
            this.LX2.Size = new System.Drawing.Size(0, 17);
            this.LX2.TabIndex = 9;
            // 
            // AnswerX1
            // 
            this.AnswerX1.AutoSize = true;
            this.AnswerX1.Location = new System.Drawing.Point(65, 216);
            this.AnswerX1.Name = "AnswerX1";
            this.AnswerX1.Size = new System.Drawing.Size(0, 17);
            this.AnswerX1.TabIndex = 10;
            // 
            // AnswerX2
            // 
            this.AnswerX2.AutoSize = true;
            this.AnswerX2.Location = new System.Drawing.Point(64, 248);
            this.AnswerX2.Name = "AnswerX2";
            this.AnswerX2.Size = new System.Drawing.Size(0, 17);
            this.AnswerX2.TabIndex = 11;
            // 
            // labelD
            // 
            this.labelD.AutoSize = true;
            this.labelD.Location = new System.Drawing.Point(15, 137);
            this.labelD.Name = "labelD";
            this.labelD.Size = new System.Drawing.Size(0, 17);
            this.labelD.TabIndex = 12;
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(15, 172);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(0, 17);
            this.labelX.TabIndex = 13;
            // 
            // LX
            // 
            this.LX.AutoSize = true;
            this.LX.Location = new System.Drawing.Point(15, 158);
            this.LX.Name = "LX";
            this.LX.Size = new System.Drawing.Size(0, 17);
            this.LX.TabIndex = 14;
            // 
            // X
            // 
            this.X.AutoSize = true;
            this.X.Location = new System.Drawing.Point(67, 157);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(0, 17);
            this.X.TabIndex = 15;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(137, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(444, 22);
            this.textBox1.TabIndex = 16;
            this.textBox1.Text = "Автор программы - Игорь Мукминов; fatalrew@gmail.com";
            // 
            // Lend
            // 
            this.Lend.AutoSize = true;
            this.Lend.Location = new System.Drawing.Point(218, 323);
            this.Lend.Name = "Lend";
            this.Lend.Size = new System.Drawing.Size(0, 17);
            this.Lend.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 396);
            this.Controls.Add(this.Lend);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.X);
            this.Controls.Add(this.LX);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.labelD);
            this.Controls.Add(this.AnswerX2);
            this.Controls.Add(this.AnswerX1);
            this.Controls.Add(this.LX2);
            this.Controls.Add(this.LX1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBd);
            this.Controls.Add(this.TBc);
            this.Controls.Add(this.TBb);
            this.Controls.Add(this.TBa);
            this.Controls.Add(this.B1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Решение квадратного уравнения";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.TextBox TBa;
        private System.Windows.Forms.TextBox TBb;
        private System.Windows.Forms.TextBox TBc;
        private System.Windows.Forms.TextBox TBd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LX1;
        private System.Windows.Forms.Label LX2;
        private System.Windows.Forms.Label AnswerX1;
        private System.Windows.Forms.Label AnswerX2;
        private System.Windows.Forms.Label labelD;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label LX;
        private System.Windows.Forms.Label X;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Lend;
    }
}

