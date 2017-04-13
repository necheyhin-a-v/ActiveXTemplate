namespace CSActiveX
{
    partial class CSActiveXCtrl
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.btnMessage = new System.Windows.Forms.Button();
            this.lbFloatProperty = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "CSActiveXCtrl";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "FloatProperty:";
            // 
            // tbMessage
            // 
            this.tbMessage.Location = new System.Drawing.Point(15, 75);
            this.tbMessage.Margin = new System.Windows.Forms.Padding(4);
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(203, 22);
            this.tbMessage.TabIndex = 3;
            // 
            // btnMessage
            // 
            this.btnMessage.Location = new System.Drawing.Point(227, 73);
            this.btnMessage.Margin = new System.Windows.Forms.Padding(4);
            this.btnMessage.Name = "btnMessage";
            this.btnMessage.Size = new System.Drawing.Size(121, 28);
            this.btnMessage.TabIndex = 4;
            this.btnMessage.Text = "Сообщение";
            this.btnMessage.UseVisualStyleBackColor = true;
            this.btnMessage.Click += new System.EventHandler(this.btnMessage_Click);
            // 
            // lbFloatProperty
            // 
            this.lbFloatProperty.AutoSize = true;
            this.lbFloatProperty.Location = new System.Drawing.Point(115, 43);
            this.lbFloatProperty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFloatProperty.Name = "lbFloatProperty";
            this.lbFloatProperty.Size = new System.Drawing.Size(16, 17);
            this.lbFloatProperty.TabIndex = 2;
            this.lbFloatProperty.Text = "0";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(14, 105);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 5;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(227, 109);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(98, 21);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(227, 137);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 7;
            // 
            // CSActiveXCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.lbFloatProperty);
            this.Controls.Add(this.btnMessage);
            this.Controls.Add(this.tbMessage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CSActiveXCtrl";
            this.Size = new System.Drawing.Size(571, 329);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.Button btnMessage;
        private System.Windows.Forms.Label lbFloatProperty;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
