namespace Millionare
{
    partial class MainForm
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
            this.QuestionLabel = new System.Windows.Forms.Label();
            this.answer0 = new System.Windows.Forms.Button();
            this.answer1 = new System.Windows.Forms.Button();
            this.answer2 = new System.Windows.Forms.Button();
            this.answer3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BalanceLabel = new System.Windows.Forms.Label();
            this.hint0 = new System.Windows.Forms.Button();
            this.hint1 = new System.Windows.Forms.Button();
            this.hint2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // QuestionLabel
            // 
            this.QuestionLabel.AutoSize = true;
            this.QuestionLabel.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuestionLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.QuestionLabel.Location = new System.Drawing.Point(12, 220);
            this.QuestionLabel.Name = "QuestionLabel";
            this.QuestionLabel.Size = new System.Drawing.Size(387, 40);
            this.QuestionLabel.TabIndex = 1;
            this.QuestionLabel.Text = "Сколько IQ у дельфина?";
            this.QuestionLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // answer0
            // 
            this.answer0.BackColor = System.Drawing.Color.Navy;
            this.answer0.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answer0.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.answer0.Location = new System.Drawing.Point(12, 281);
            this.answer0.Name = "answer0";
            this.answer0.Size = new System.Drawing.Size(318, 83);
            this.answer0.TabIndex = 2;
            this.answer0.Text = "Каккос";
            this.answer0.UseVisualStyleBackColor = false;
            // 
            // answer1
            // 
            this.answer1.BackColor = System.Drawing.Color.Navy;
            this.answer1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answer1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.answer1.Location = new System.Drawing.Point(336, 281);
            this.answer1.Name = "answer1";
            this.answer1.Size = new System.Drawing.Size(318, 83);
            this.answer1.TabIndex = 3;
            this.answer1.Text = "Фиг знает";
            this.answer1.UseVisualStyleBackColor = false;
            // 
            // answer2
            // 
            this.answer2.BackColor = System.Drawing.Color.Navy;
            this.answer2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answer2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.answer2.Location = new System.Drawing.Point(12, 370);
            this.answer2.Name = "answer2";
            this.answer2.Size = new System.Drawing.Size(318, 76);
            this.answer2.TabIndex = 4;
            this.answer2.Text = "Мы не должны лезть в голову дельфинов";
            this.answer2.UseVisualStyleBackColor = false;
            // 
            // answer3
            // 
            this.answer3.BackColor = System.Drawing.Color.Navy;
            this.answer3.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answer3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.answer3.Location = new System.Drawing.Point(336, 370);
            this.answer3.Name = "answer3";
            this.answer3.Size = new System.Drawing.Size(318, 76);
            this.answer3.TabIndex = 5;
            this.answer3.Text = "Больше чем у человека";
            this.answer3.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Balance";
            // 
            // BalanceLabel
            // 
            this.BalanceLabel.AutoSize = true;
            this.BalanceLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BalanceLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BalanceLabel.Location = new System.Drawing.Point(95, 9);
            this.BalanceLabel.Name = "BalanceLabel";
            this.BalanceLabel.Size = new System.Drawing.Size(54, 24);
            this.BalanceLabel.TabIndex = 7;
            this.BalanceLabel.Text = "1500";
            // 
            // hint0
            // 
            this.hint0.BackColor = System.Drawing.Color.CadetBlue;
            this.hint0.Location = new System.Drawing.Point(438, 12);
            this.hint0.Name = "hint0";
            this.hint0.Size = new System.Drawing.Size(68, 65);
            this.hint0.TabIndex = 8;
            this.hint0.Text = "50/50";
            this.hint0.UseVisualStyleBackColor = false;
            // 
            // hint1
            // 
            this.hint1.BackColor = System.Drawing.Color.CadetBlue;
            this.hint1.Location = new System.Drawing.Point(512, 12);
            this.hint1.Name = "hint1";
            this.hint1.Size = new System.Drawing.Size(68, 65);
            this.hint1.TabIndex = 9;
            this.hint1.Text = "Call";
            this.hint1.UseVisualStyleBackColor = false;
            // 
            // hint2
            // 
            this.hint2.BackColor = System.Drawing.Color.CadetBlue;
            this.hint2.Location = new System.Drawing.Point(586, 12);
            this.hint2.Name = "hint2";
            this.hint2.Size = new System.Drawing.Size(68, 65);
            this.hint2.TabIndex = 10;
            this.hint2.Text = "Help";
            this.hint2.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(664, 460);
            this.Controls.Add(this.hint2);
            this.Controls.Add(this.hint1);
            this.Controls.Add(this.hint0);
            this.Controls.Add(this.BalanceLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.answer3);
            this.Controls.Add(this.answer2);
            this.Controls.Add(this.answer1);
            this.Controls.Add(this.answer0);
            this.Controls.Add(this.QuestionLabel);
            this.Name = "MainForm";
            this.Text = "Millionare";
            this.TransparencyKey = System.Drawing.Color.Aqua;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label QuestionLabel;
        private System.Windows.Forms.Button answer0;
        private System.Windows.Forms.Button answer1;
        private System.Windows.Forms.Button answer2;
        private System.Windows.Forms.Button answer3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label BalanceLabel;
        private System.Windows.Forms.Button hint0;
        private System.Windows.Forms.Button hint1;
        private System.Windows.Forms.Button hint2;
    }
}

