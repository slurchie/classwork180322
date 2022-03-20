
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
            this.paintingsdata = new System.Windows.Forms.DataGridView();
            this.visitors = new System.Windows.Forms.TabPage();
            this.kritiks = new System.Windows.Forms.TabPage();
            this.pid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearofmastering = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visitorsdata = new System.Windows.Forms.DataGridView();
            this.vid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kritikdata = new System.Windows.Forms.DataGridView();
            this.kid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.procentofalcoholizm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.review = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exhibition.SuspendLayout();
            this.paintings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paintingsdata)).BeginInit();
            this.visitors.SuspendLayout();
            this.kritiks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visitorsdata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kritikdata)).BeginInit();
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
            this.paintings.Controls.Add(this.paintingsdata);
            this.paintings.Location = new System.Drawing.Point(4, 25);
            this.paintings.Name = "paintings";
            this.paintings.Padding = new System.Windows.Forms.Padding(3);
            this.paintings.Size = new System.Drawing.Size(780, 426);
            this.paintings.TabIndex = 0;
            this.paintings.Text = "paintings";
            this.paintings.UseVisualStyleBackColor = true;
            // 
            // paintingsdata
            // 
            this.paintingsdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.paintingsdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pid,
            this.pname,
            this.author,
            this.yearofmastering});
            this.paintingsdata.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paintingsdata.Location = new System.Drawing.Point(3, 3);
            this.paintingsdata.Name = "paintingsdata";
            this.paintingsdata.RowHeadersWidth = 51;
            this.paintingsdata.RowTemplate.Height = 24;
            this.paintingsdata.Size = new System.Drawing.Size(774, 420);
            this.paintingsdata.TabIndex = 0;
            // 
            // visitors
            // 
            this.visitors.Controls.Add(this.visitorsdata);
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
            this.kritiks.Controls.Add(this.kritikdata);
            this.kritiks.Location = new System.Drawing.Point(4, 25);
            this.kritiks.Name = "kritiks";
            this.kritiks.Padding = new System.Windows.Forms.Padding(3);
            this.kritiks.Size = new System.Drawing.Size(780, 426);
            this.kritiks.TabIndex = 2;
            this.kritiks.Text = "kritiks";
            this.kritiks.UseVisualStyleBackColor = true;
            // 
            // pid
            // 
            this.pid.HeaderText = "id";
            this.pid.MinimumWidth = 6;
            this.pid.Name = "pid";
            this.pid.Width = 125;
            // 
            // pname
            // 
            this.pname.HeaderText = "name";
            this.pname.MinimumWidth = 6;
            this.pname.Name = "pname";
            this.pname.Width = 125;
            // 
            // author
            // 
            this.author.HeaderText = "author";
            this.author.MinimumWidth = 6;
            this.author.Name = "author";
            this.author.Width = 125;
            // 
            // yearofmastering
            // 
            this.yearofmastering.HeaderText = "year";
            this.yearofmastering.MinimumWidth = 6;
            this.yearofmastering.Name = "yearofmastering";
            this.yearofmastering.Width = 125;
            // 
            // visitorsdata
            // 
            this.visitorsdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.visitorsdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vid,
            this.vname,
            this.vage,
            this.score});
            this.visitorsdata.Location = new System.Drawing.Point(8, 8);
            this.visitorsdata.Name = "visitorsdata";
            this.visitorsdata.RowHeadersWidth = 51;
            this.visitorsdata.RowTemplate.Height = 24;
            this.visitorsdata.Size = new System.Drawing.Size(555, 185);
            this.visitorsdata.TabIndex = 0;
            // 
            // vid
            // 
            this.vid.HeaderText = "id";
            this.vid.MinimumWidth = 6;
            this.vid.Name = "vid";
            this.vid.Width = 125;
            // 
            // vname
            // 
            this.vname.HeaderText = "name";
            this.vname.MinimumWidth = 6;
            this.vname.Name = "vname";
            this.vname.Width = 125;
            // 
            // vage
            // 
            this.vage.HeaderText = "age";
            this.vage.MinimumWidth = 6;
            this.vage.Name = "vage";
            this.vage.Width = 125;
            // 
            // score
            // 
            this.score.HeaderText = "score";
            this.score.MinimumWidth = 6;
            this.score.Name = "score";
            this.score.Width = 125;
            // 
            // kritikdata
            // 
            this.kritikdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kritikdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kid,
            this.kname,
            this.kage,
            this.procentofalcoholizm,
            this.review});
            this.kritikdata.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kritikdata.Location = new System.Drawing.Point(3, 3);
            this.kritikdata.Name = "kritikdata";
            this.kritikdata.RowHeadersWidth = 51;
            this.kritikdata.RowTemplate.Height = 24;
            this.kritikdata.Size = new System.Drawing.Size(774, 420);
            this.kritikdata.TabIndex = 0;
            // 
            // kid
            // 
            this.kid.HeaderText = "id";
            this.kid.MinimumWidth = 6;
            this.kid.Name = "kid";
            this.kid.Width = 125;
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
            this.procentofalcoholizm.HeaderText = "% of alcocolizm";
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
            this.paintings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paintingsdata)).EndInit();
            this.visitors.ResumeLayout(false);
            this.kritiks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.visitorsdata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kritikdata)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl exhibition;
        private System.Windows.Forms.TabPage paintings;
        private System.Windows.Forms.TabPage visitors;
        private System.Windows.Forms.TabPage kritiks;
        private System.Windows.Forms.DataGridView paintingsdata;
        private System.Windows.Forms.DataGridViewTextBoxColumn pid;
        private System.Windows.Forms.DataGridViewTextBoxColumn pname;
        private System.Windows.Forms.DataGridViewTextBoxColumn author;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearofmastering;
        private System.Windows.Forms.DataGridView visitorsdata;
        private System.Windows.Forms.DataGridViewTextBoxColumn vid;
        private System.Windows.Forms.DataGridViewTextBoxColumn vname;
        private System.Windows.Forms.DataGridViewTextBoxColumn vage;
        private System.Windows.Forms.DataGridViewTextBoxColumn score;
        private System.Windows.Forms.DataGridView kritikdata;
        private System.Windows.Forms.DataGridViewTextBoxColumn kid;
        private System.Windows.Forms.DataGridViewTextBoxColumn kname;
        private System.Windows.Forms.DataGridViewTextBoxColumn kage;
        private System.Windows.Forms.DataGridViewTextBoxColumn procentofalcoholizm;
        private System.Windows.Forms.DataGridViewTextBoxColumn review;
    }
}

