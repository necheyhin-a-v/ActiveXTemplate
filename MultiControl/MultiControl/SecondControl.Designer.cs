namespace CSActiveX
{
    partial class SecondControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.FirstColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SecondColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThirdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FourthColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(136, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "На главную";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FirstColumn,
            this.SecondColumn,
            this.ThirdColumn,
            this.FourthColumn});
            this.dataGridView1.Location = new System.Drawing.Point(3, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(418, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // FirstColumn
            // 
            this.FirstColumn.HeaderText = "Первая колонка";
            this.FirstColumn.Name = "FirstColumn";
            // 
            // SecondColumn
            // 
            this.SecondColumn.HeaderText = "Вторая колонка";
            this.SecondColumn.Name = "SecondColumn";
            // 
            // ThirdColumn
            // 
            this.ThirdColumn.HeaderText = "Третья колонка";
            this.ThirdColumn.Name = "ThirdColumn";
            // 
            // FourthColumn
            // 
            this.FourthColumn.HeaderText = "Четвертая колонка";
            this.FourthColumn.Name = "FourthColumn";
            // 
            // SecondControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "SecondControl";
            this.Size = new System.Drawing.Size(424, 216);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SecondColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThirdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FourthColumn;
    }
}
