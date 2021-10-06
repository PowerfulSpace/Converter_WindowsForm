namespace WindowsFormsApp2
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
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDownload = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxDownload = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxUpdate = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBoxCurrency1 = new System.Windows.Forms.TextBox();
            this.textBoxCurrency2 = new System.Windows.Forms.TextBox();
            this.listBoxSearch = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(22, 30);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(98, 33);
            this.buttonUpdate.TabIndex = 0;
            this.buttonUpdate.Text = "Обновить";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDownload
            // 
            this.buttonDownload.Location = new System.Drawing.Point(126, 30);
            this.buttonDownload.Name = "buttonDownload";
            this.buttonDownload.Size = new System.Drawing.Size(98, 33);
            this.buttonDownload.TabIndex = 1;
            this.buttonDownload.Text = "Загрузить";
            this.buttonDownload.UseVisualStyleBackColor = true;
            this.buttonDownload.Click += new System.EventHandler(this.buttonDownload_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(126, 316);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(98, 33);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.Text = "Поиск";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSearch.Location = new System.Drawing.Point(22, 316);
            this.textBoxSearch.Multiline = true;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(98, 33);
            this.textBoxSearch.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(256, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Курс валют ЦБ на сегодня";
            // 
            // listBoxDownload
            // 
            this.listBoxDownload.FormattingEnabled = true;
            this.listBoxDownload.Location = new System.Drawing.Point(22, 79);
            this.listBoxDownload.Name = "listBoxDownload";
            this.listBoxDownload.Size = new System.Drawing.Size(202, 212);
            this.listBoxDownload.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Конвертровать";
            // 
            // listBoxUpdate
            // 
            this.listBoxUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxUpdate.FormattingEnabled = true;
            this.listBoxUpdate.Location = new System.Drawing.Point(259, 79);
            this.listBoxUpdate.Name = "listBoxUpdate";
            this.listBoxUpdate.Size = new System.Drawing.Size(316, 95);
            this.listBoxUpdate.TabIndex = 8;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(259, 241);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(139, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(259, 270);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(139, 21);
            this.comboBox2.TabIndex = 10;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // textBoxCurrency1
            // 
            this.textBoxCurrency1.Location = new System.Drawing.Point(431, 241);
            this.textBoxCurrency1.Multiline = true;
            this.textBoxCurrency1.Name = "textBoxCurrency1";
            this.textBoxCurrency1.Size = new System.Drawing.Size(144, 21);
            this.textBoxCurrency1.TabIndex = 11;
            this.textBoxCurrency1.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBoxCurrency2
            // 
            this.textBoxCurrency2.Location = new System.Drawing.Point(431, 270);
            this.textBoxCurrency2.Multiline = true;
            this.textBoxCurrency2.Name = "textBoxCurrency2";
            this.textBoxCurrency2.Size = new System.Drawing.Size(144, 21);
            this.textBoxCurrency2.TabIndex = 12;
            this.textBoxCurrency2.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // listBoxSearch
            // 
            this.listBoxSearch.FormattingEnabled = true;
            this.listBoxSearch.Location = new System.Drawing.Point(259, 316);
            this.listBoxSearch.Name = "listBoxSearch";
            this.listBoxSearch.Size = new System.Drawing.Size(316, 82);
            this.listBoxSearch.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 431);
            this.Controls.Add(this.listBoxSearch);
            this.Controls.Add(this.textBoxCurrency2);
            this.Controls.Add(this.textBoxCurrency1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.listBoxUpdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxDownload);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonDownload);
            this.Controls.Add(this.buttonUpdate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDownload;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxDownload;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxUpdate;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBoxCurrency1;
        private System.Windows.Forms.TextBox textBoxCurrency2;
        private System.Windows.Forms.ListBox listBoxSearch;
    }
}

