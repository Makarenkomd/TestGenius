namespace TestGenius
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
            this.labelNumberQuestion = new System.Windows.Forms.Label();
            this.labelTextQuestion = new System.Windows.Forms.Label();
            this.textBoxAnswerQuestion = new System.Windows.Forms.TextBox();
            this.buttonNextQuestion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNumberQuestion
            // 
            this.labelNumberQuestion.AutoSize = true;
            this.labelNumberQuestion.Location = new System.Drawing.Point(34, 32);
            this.labelNumberQuestion.Name = "labelNumberQuestion";
            this.labelNumberQuestion.Size = new System.Drawing.Size(67, 13);
            this.labelNumberQuestion.TabIndex = 0;
            this.labelNumberQuestion.Text = "Вопрос № 1";
            // 
            // labelTextQuestion
            // 
            this.labelTextQuestion.AutoSize = true;
            this.labelTextQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTextQuestion.Location = new System.Drawing.Point(30, 64);
            this.labelTextQuestion.Name = "labelTextQuestion";
            this.labelTextQuestion.Size = new System.Drawing.Size(86, 31);
            this.labelTextQuestion.TabIndex = 1;
            this.labelTextQuestion.Text = "label2";
            // 
            // textBoxAnswerQuestion
            // 
            this.textBoxAnswerQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAnswerQuestion.Location = new System.Drawing.Point(30, 174);
            this.textBoxAnswerQuestion.Name = "textBoxAnswerQuestion";
            this.textBoxAnswerQuestion.Size = new System.Drawing.Size(157, 38);
            this.textBoxAnswerQuestion.TabIndex = 2;
            // 
            // buttonNextQuestion
            // 
            this.buttonNextQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNextQuestion.Location = new System.Drawing.Point(190, 171);
            this.buttonNextQuestion.Name = "buttonNextQuestion";
            this.buttonNextQuestion.Size = new System.Drawing.Size(302, 41);
            this.buttonNextQuestion.TabIndex = 3;
            this.buttonNextQuestion.Text = "Следующий вопрос";
            this.buttonNextQuestion.UseVisualStyleBackColor = true;
            this.buttonNextQuestion.Click += new System.EventHandler(this.buttonNextQuestion_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 296);
            this.Controls.Add(this.buttonNextQuestion);
            this.Controls.Add(this.textBoxAnswerQuestion);
            this.Controls.Add(this.labelTextQuestion);
            this.Controls.Add(this.labelNumberQuestion);
            this.Name = "Form1";
            this.Text = "тест ГЕНИЙ-ИДИОТ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNumberQuestion;
        private System.Windows.Forms.Label labelTextQuestion;
        private System.Windows.Forms.TextBox textBoxAnswerQuestion;
        private System.Windows.Forms.Button buttonNextQuestion;
    }
}

