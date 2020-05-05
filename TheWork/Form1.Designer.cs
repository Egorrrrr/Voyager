namespace TheWork
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TheGrid = new System.Windows.Forms.DataGridView();
            this.Add = new System.Windows.Forms.Button();
            this.AddR = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TheGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // TheGrid
            // 
            this.TheGrid.AllowUserToAddRows = false;
            this.TheGrid.AllowUserToDeleteRows = false;
            this.TheGrid.AllowUserToResizeColumns = false;
            this.TheGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TheGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.TheGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TheGrid.ColumnHeadersVisible = false;
            this.TheGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.TheGrid.Location = new System.Drawing.Point(34, 38);
            this.TheGrid.MultiSelect = false;
            this.TheGrid.Name = "TheGrid";
            this.TheGrid.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TheGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.TheGrid.RowHeadersVisible = false;
            this.TheGrid.RowHeadersWidth = 62;
            this.TheGrid.RowTemplate.Height = 28;
            this.TheGrid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TheGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.TheGrid.Size = new System.Drawing.Size(572, 362);
            this.TheGrid.TabIndex = 0;
            this.TheGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TheGrid_CellClick_1);
            this.TheGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TheGrid_CellContentClick);
            this.TheGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TheGrid_CellClick);
            this.TheGrid.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.TheGrid_CellMouseEnter);
            this.TheGrid.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.TheGrid_CellMouseLeave);
            this.TheGrid.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.TheGrid_CellPainting);
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.Add.Location = new System.Drawing.Point(630, 317);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(153, 83);
            this.Add.TabIndex = 1;
            this.Add.Text = "Нарисовать случайный маршрут (тест графики)";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // AddR
            // 
            this.AddR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AddR.Location = new System.Drawing.Point(630, 140);
            this.AddR.Name = "AddR";
            this.AddR.Size = new System.Drawing.Size(153, 58);
            this.AddR.TabIndex = 2;
            this.AddR.Text = "Random";
            this.AddR.UseVisualStyleBackColor = true;
            this.AddR.Click += new System.EventHandler(this.AddR_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(630, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 58);
            this.button1.TabIndex = 4;
            this.button1.Text = "Таблица";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(813, 38);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(278, 364);
            this.listBox1.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button2.Location = new System.Drawing.Point(630, 38);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 58);
            this.button2.TabIndex = 7;
            this.button2.Text = "CLEAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(29, 403);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Координаты: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(630, 181);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(153, 26);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(555, 407);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 441);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AddR);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.TheGrid);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.MouseEnter += new System.EventHandler(this.Form1_MouseEnter);
            ((System.ComponentModel.ISupportInitialize)(this.TheGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TheGrid;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button AddR;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
    }
}

