
namespace xml
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idpainting = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameofthepainting = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearofthemastering = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.idofthevisitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameofthevisitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.procentofalcoholizm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.review = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exhibition.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // exhibition
            // 
            this.exhibition.Controls.Add(this.tabPage1);
            this.exhibition.Controls.Add(this.tabPage2);
            this.exhibition.Controls.Add(this.tabPage3);
            this.exhibition.Location = new System.Drawing.Point(0, 0);
            this.exhibition.Name = "exhibition";
            this.exhibition.SelectedIndex = 0;
            this.exhibition.Size = new System.Drawing.Size(676, 408);
            this.exhibition.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(668, 379);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "paintings";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView3);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(668, 379);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Visitors";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView1);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(668, 379);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Kritik";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.kname,
            this.kage,
            this.procentofalcoholizm,
            this.review});
            this.dataGridView1.Location = new System.Drawing.Point(8, 8);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(664, 212);
            this.dataGridView1.TabIndex = 0;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Width = 125;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idpainting,
            this.nameofthepainting,
            this.author,
            this.yearofthemastering});
            this.dataGridView2.Location = new System.Drawing.Point(23, 32);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(550, 301);
            this.dataGridView2.TabIndex = 0;
            // 
            // idpainting
            // 
            this.idpainting.HeaderText = "id";
            this.idpainting.MinimumWidth = 6;
            this.idpainting.Name = "idpainting";
            this.idpainting.Width = 125;
            // 
            // nameofthepainting
            // 
            this.nameofthepainting.HeaderText = "name";
            this.nameofthepainting.MinimumWidth = 6;
            this.nameofthepainting.Name = "nameofthepainting";
            this.nameofthepainting.Width = 125;
            // 
            // author
            // 
            this.author.HeaderText = "author";
            this.author.MinimumWidth = 6;
            this.author.Name = "author";
            this.author.Width = 125;
            // 
            // yearofthemastering
            // 
            this.yearofthemastering.HeaderText = "year";
            this.yearofthemastering.MinimumWidth = 6;
            this.yearofthemastering.Name = "yearofthemastering";
            this.yearofthemastering.Width = 125;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idofthevisitor,
            this.nameofthevisitor,
            this.age,
            this.score});
            this.dataGridView3.Location = new System.Drawing.Point(8, 8);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(551, 265);
            this.dataGridView3.TabIndex = 0;
            // 
            // idofthevisitor
            // 
            this.idofthevisitor.HeaderText = "id";
            this.idofthevisitor.MinimumWidth = 6;
            this.idofthevisitor.Name = "idofthevisitor";
            this.idofthevisitor.Width = 125;
            // 
            // nameofthevisitor
            // 
            this.nameofthevisitor.HeaderText = "name";
            this.nameofthevisitor.MinimumWidth = 6;
            this.nameofthevisitor.Name = "nameofthevisitor";
            this.nameofthevisitor.Width = 125;
            // 
            // age
            // 
            this.age.HeaderText = "age";
            this.age.MinimumWidth = 6;
            this.age.Name = "age";
            this.age.Width = 125;
            // 
            // score
            // 
            this.score.HeaderText = "score";
            this.score.MinimumWidth = 6;
            this.score.Name = "score";
            this.score.Width = 125;
            // 
            // kname
            // 
            this.kname.HeaderText = "name";
            this.kname.MinimumWidth = 6;
            this.kname.Name = "kname";
            this.kname.Width = 125;
            // 
            // kage
            // 
            this.kage.HeaderText = "age";
            this.kage.MinimumWidth = 6;
            this.kage.Name = "kage";
            this.kage.Width = 125;
            // 
            // procentofalcoholizm
            // 
            this.procentofalcoholizm.HeaderText = "% алкоголизма";
            this.procentofalcoholizm.MinimumWidth = 6;
            this.procentofalcoholizm.Name = "procentofalcoholizm";
            this.procentofalcoholizm.Width = 125;
            // 
            // review
            // 
            this.review.HeaderText = "review";
            this.review.MinimumWidth = 6;
            this.review.Name = "review";
            this.review.Width = 125;
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
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl exhibition;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpainting;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameofthepainting;
        private System.Windows.Forms.DataGridViewTextBoxColumn author;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearofthemastering;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idofthevisitor;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameofthevisitor;
        private System.Windows.Forms.DataGridViewTextBoxColumn age;
        private System.Windows.Forms.DataGridViewTextBoxColumn score;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn kname;
        private System.Windows.Forms.DataGridViewTextBoxColumn kage;
        private System.Windows.Forms.DataGridViewTextBoxColumn procentofalcoholizm;
        private System.Windows.Forms.DataGridViewTextBoxColumn review;
    }
}

