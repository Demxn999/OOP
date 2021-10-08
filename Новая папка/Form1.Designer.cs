
namespace практика
{
    partial class Конвертер
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
            this.Rubles = new System.Windows.Forms.TextBox();
            this.Dollars = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Rubles
            // 
            this.Rubles.BackColor = System.Drawing.SystemColors.Window;
            this.Rubles.Cursor = System.Windows.Forms.Cursors.Default;
            this.Rubles.Font = new System.Drawing.Font("Calibri", 18F);
            this.Rubles.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Rubles.Location = new System.Drawing.Point(163, 109);
            this.Rubles.MaxLength = 30;
            this.Rubles.Name = "Rubles";
            this.Rubles.Size = new System.Drawing.Size(227, 51);
            this.Rubles.TabIndex = 0;
            this.Rubles.TextChanged += new System.EventHandler(this.Rubles_TextChanged);
            // 
            // Dollars
            // 
            this.Dollars.Cursor = System.Windows.Forms.Cursors.Default;
            this.Dollars.Font = new System.Drawing.Font("Calibri", 18F);
            this.Dollars.Location = new System.Drawing.Point(163, 305);
            this.Dollars.Name = "Dollars";
            this.Dollars.Size = new System.Drawing.Size(227, 51);
            this.Dollars.TabIndex = 1;
            this.Dollars.TextChanged += new System.EventHandler(this.Dollars_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.CadetBlue;
            this.label1.Font = new System.Drawing.Font("Calibri", 25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(163, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 61);
            this.label1.TabIndex = 2;
            this.label1.Text = "Доллары";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.CadetBlue;
            this.label2.Font = new System.Drawing.Font("Calibri", 25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Cornsilk;
            this.label2.Location = new System.Drawing.Point(204, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 61);
            this.label2.TabIndex = 3;
            this.label2.Text = "Рубли";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(93, 465);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 37);
            this.label3.TabIndex = 4;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(124, 396);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(288, 37);
            this.label4.TabIndex = 5;
            this.label4.Text = "Работает и наоборот";
            // 
            // Конвертер
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(545, 528);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Dollars);
            this.Controls.Add(this.Rubles);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Name = "Конвертер";
            this.Text = "Конвертер";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Rubles;
        private System.Windows.Forms.TextBox Dollars;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

