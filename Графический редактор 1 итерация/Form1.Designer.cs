namespace Графический_редактор_1_итерация
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.DrawObject = new System.Windows.Forms.ToolStripMenuItem();
            this.DrawLine = new System.Windows.Forms.ToolStripMenuItem();
            this.DrawCircle = new System.Windows.Forms.ToolStripMenuItem();
            this.DrawSquare = new System.Windows.Forms.ToolStripMenuItem();
            this.DrawGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearForm = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DrawObject,
            this.DrawGroup,
            this.ClearForm});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // DrawObject
            // 
            this.DrawObject.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DrawLine,
            this.DrawCircle,
            this.DrawSquare});
            this.DrawObject.Name = "DrawObject";
            this.DrawObject.Size = new System.Drawing.Size(158, 26);
            this.DrawObject.Text = "Нарисовать объект";
            // 
            // DrawLine
            // 
            this.DrawLine.Name = "DrawLine";
            this.DrawLine.Size = new System.Drawing.Size(224, 26);
            this.DrawLine.Text = "Прямая";
            this.DrawLine.Click += new System.EventHandler(this.DrawLine_Click);
            // 
            // DrawCircle
            // 
            this.DrawCircle.Name = "DrawCircle";
            this.DrawCircle.Size = new System.Drawing.Size(224, 26);
            this.DrawCircle.Text = "Окружность";
            this.DrawCircle.Click += new System.EventHandler(this.DrawCircle_Click);
            // 
            // DrawSquare
            // 
            this.DrawSquare.Name = "DrawSquare";
            this.DrawSquare.Size = new System.Drawing.Size(224, 26);
            this.DrawSquare.Text = "Квадрат";
            this.DrawSquare.Click += new System.EventHandler(this.DrawSquare_Click);
            // 
            // DrawGroup
            // 
            this.DrawGroup.Name = "DrawGroup";
            this.DrawGroup.Size = new System.Drawing.Size(157, 24);
            this.DrawGroup.Text = "Нарисовать группу";
            this.DrawGroup.Click += new System.EventHandler(this.DrawGroup_Click);
            // 
            // ClearForm
            // 
            this.ClearForm.Name = "ClearForm";
            this.ClearForm.Size = new System.Drawing.Size(137, 24);
            this.ClearForm.Text = "Очистить форму";
            this.ClearForm.Click += new System.EventHandler(this.ClearForm_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 424);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem DrawObject;
        private System.Windows.Forms.ToolStripMenuItem DrawLine;
        private System.Windows.Forms.ToolStripMenuItem DrawCircle;
        private System.Windows.Forms.ToolStripMenuItem DrawSquare;
        private System.Windows.Forms.ToolStripMenuItem DrawGroup;
        private System.Windows.Forms.ToolStripMenuItem ClearForm;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

