
namespace json
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
            this.exhibition = new System.Windows.Forms.TabControl();
            this.paintings = new System.Windows.Forms.TabPage();
            this.visitors = new System.Windows.Forms.TabPage();
            this.kritiks = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exhibition.SuspendLayout();
            this.paintings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // exhibition
            // 
            this.exhibition.Controls.Add(this.paintings);
            this.exhibition.Controls.Add(this.visitors);
            this.exhibition.Controls.Add(this.kritiks);
            this.exhibition.Location = new System.Drawing.Point(0, 0);
            this.exhibition.Name = "exhibition";
            this.exhibition.SelectedIndex = 0;
            this.exhibition.Size = new System.Drawing.Size(788, 455);
            this.exhibition.TabIndex = 0;
            // 
            // paintings
            // 
            this.paintings.Controls.Add(this.dataGridView1);
            this.paintings.Location = new System.Drawing.Point(4, 25);
            this.paintings.Name = "paintings";
            this.paintings.Padding = new System.Windows.Forms.Padding(3);
            this.paintings.Size = new System.Drawing.Size(780, 426);
            this.paintings.TabIndex = 0;
            this.paintings.Text = "paintings";
            this.paintings.UseVisualStyleBackColor = true;
            // 
            // visitors
            // 
            this.visitors.Location = new System.Drawing.Point(4, 25);
            this.visitors.Name = "visitors";
            this.visitors.Padding = new System.Windows.Forms.Padding(3);
            this.visitors.Size = new System.Drawing.Size(780, 426);
            this.visitors.TabIndex = 1;
            this.visitors.Text = "visitors";
            this.visitors.UseVisualStyleBackColor = true;
            // 
            // kritiks
            // 
            this.kritiks.Location = new System.Drawing.Point(4, 25);
            this.kritiks.Name = "kritiks";
            this.kritiks.Padding = new System.Windows.Forms.Padding(3);
            this.kritiks.Size = new System.Drawing.Size(780, 426);
            this.kritiks.TabIndex = 2;
            this.kritiks.Text = "kritiks";
            this.kritiks.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pname});
            this.dataGridView1.Location = new System.Drawing.Point(8, 8);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(240, 248);
            this.dataGridView1.TabIndex = 0;
          
            // 
            // pname
            // 
            this.pname.HeaderText = "name";
            this.pname.MinimumWidth = 6;
            this.pname.Name = "pname";
            this.pname.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exhibition);
            this.Name = "Form1";
            this.Text = "Form1";
            this.exhibition.ResumeLayout(false);
            this.paintings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl exhibition;
        private System.Windows.Forms.TabPage paintings;
        private System.Windows.Forms.TabPage visitors;
        private System.Windows.Forms.TabPage kritiks;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pname;
    }
}

