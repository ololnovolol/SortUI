﻿namespace SortUI
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.FillButton = new System.Windows.Forms.Button();
            this.FillTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.AddTextBox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SwopLbl = new System.Windows.Forms.Label();
            this.CompareLbl = new System.Windows.Forms.Label();
            this.TimeLbl = new System.Windows.Forms.Label();
            this.BubleSortButton = new System.Windows.Forms.Button();
            this.CoctailButton = new System.Windows.Forms.Button();
            this.InsertButton = new System.Windows.Forms.Button();
            this.ShellSort = new System.Windows.Forms.Button();
            this.TreeSortButton = new System.Windows.Forms.Button();
            this.HeapSortButton = new System.Windows.Forms.Button();
            this.SelectedSortButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.GnomeSortButton = new System.Windows.Forms.Button();
            this.MargeSBtn = new System.Windows.Forms.Button();
            this.LsdBtn = new System.Windows.Forms.Button();
            this.MsdDtn = new System.Windows.Forms.Button();
            this.QuickBtn = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.FillButton);
            this.panel2.Controls.Add(this.FillTextBox);
            this.panel2.Location = new System.Drawing.Point(0, 207);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(333, 59);
            this.panel2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(289, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "заполнить случайными числами( введите кол-во чисел)";
            // 
            // FillButton
            // 
            this.FillButton.Location = new System.Drawing.Point(239, 32);
            this.FillButton.Name = "FillButton";
            this.FillButton.Size = new System.Drawing.Size(75, 23);
            this.FillButton.TabIndex = 1;
            this.FillButton.Text = "Заролнить!";
            this.FillButton.UseVisualStyleBackColor = true;
            this.FillButton.Click += new System.EventHandler(this.FillButton_Click);
            // 
            // FillTextBox
            // 
            this.FillTextBox.Location = new System.Drawing.Point(6, 35);
            this.FillTextBox.Name = "FillTextBox";
            this.FillTextBox.Size = new System.Drawing.Size(204, 20);
            this.FillTextBox.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.AddButton);
            this.panel1.Controls.Add(this.AddTextBox);
            this.panel1.Location = new System.Drawing.Point(0, 145);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 59);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "введите числа";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(239, 32);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AddTextBox
            // 
            this.AddTextBox.Location = new System.Drawing.Point(6, 35);
            this.AddTextBox.Name = "AddTextBox";
            this.AddTextBox.Size = new System.Drawing.Size(204, 20);
            this.AddTextBox.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.MenuBar;
            this.panel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(675, 142);
            this.panel3.TabIndex = 4;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // SwopLbl
            // 
            this.SwopLbl.AutoSize = true;
            this.SwopLbl.Location = new System.Drawing.Point(358, 222);
            this.SwopLbl.Name = "SwopLbl";
            this.SwopLbl.Size = new System.Drawing.Size(119, 13);
            this.SwopLbl.TabIndex = 11;
            this.SwopLbl.Text = "Количество обменов: ";
            // 
            // CompareLbl
            // 
            this.CompareLbl.AutoSize = true;
            this.CompareLbl.Location = new System.Drawing.Point(358, 200);
            this.CompareLbl.Name = "CompareLbl";
            this.CompareLbl.Size = new System.Drawing.Size(130, 13);
            this.CompareLbl.TabIndex = 10;
            this.CompareLbl.Text = "Количество Сравнений: ";
            // 
            // TimeLbl
            // 
            this.TimeLbl.AutoSize = true;
            this.TimeLbl.Location = new System.Drawing.Point(358, 178);
            this.TimeLbl.Name = "TimeLbl";
            this.TimeLbl.Size = new System.Drawing.Size(43, 13);
            this.TimeLbl.TabIndex = 9;
            this.TimeLbl.Text = "Время:";
            // 
            // BubleSortButton
            // 
            this.BubleSortButton.Location = new System.Drawing.Point(100, 304);
            this.BubleSortButton.Name = "BubleSortButton";
            this.BubleSortButton.Size = new System.Drawing.Size(76, 53);
            this.BubleSortButton.TabIndex = 0;
            this.BubleSortButton.Text = "Пузырёк";
            this.BubleSortButton.UseVisualStyleBackColor = true;
            this.BubleSortButton.Click += new System.EventHandler(this.BubleSortButton_Click);
            // 
            // CoctailButton
            // 
            this.CoctailButton.Location = new System.Drawing.Point(182, 304);
            this.CoctailButton.Name = "CoctailButton";
            this.CoctailButton.Size = new System.Drawing.Size(76, 53);
            this.CoctailButton.TabIndex = 12;
            this.CoctailButton.Text = "Шейкер";
            this.CoctailButton.UseVisualStyleBackColor = true;
            this.CoctailButton.Click += new System.EventHandler(this.CoctailButton_Click);
            // 
            // InsertButton
            // 
            this.InsertButton.Location = new System.Drawing.Point(264, 304);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(76, 53);
            this.InsertButton.TabIndex = 13;
            this.InsertButton.Text = "Вставка";
            this.InsertButton.UseVisualStyleBackColor = true;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // ShellSort
            // 
            this.ShellSort.BackColor = System.Drawing.SystemColors.Control;
            this.ShellSort.Location = new System.Drawing.Point(100, 373);
            this.ShellSort.Name = "ShellSort";
            this.ShellSort.Size = new System.Drawing.Size(76, 53);
            this.ShellSort.TabIndex = 14;
            this.ShellSort.Text = "сортировка\r\nШелла";
            this.ShellSort.UseVisualStyleBackColor = false;
            this.ShellSort.Click += new System.EventHandler(this.ShellSort_Click);
            // 
            // TreeSortButton
            // 
            this.TreeSortButton.Location = new System.Drawing.Point(346, 373);
            this.TreeSortButton.Name = "TreeSortButton";
            this.TreeSortButton.Size = new System.Drawing.Size(76, 53);
            this.TreeSortButton.TabIndex = 15;
            this.TreeSortButton.Text = "Дерево\r\n(binary)";
            this.TreeSortButton.UseVisualStyleBackColor = true;
            this.TreeSortButton.Click += new System.EventHandler(this.TreeButton);
            // 
            // HeapSortButton
            // 
            this.HeapSortButton.Location = new System.Drawing.Point(510, 304);
            this.HeapSortButton.Name = "HeapSortButton";
            this.HeapSortButton.Size = new System.Drawing.Size(76, 53);
            this.HeapSortButton.TabIndex = 16;
            this.HeapSortButton.Text = "Куча";
            this.HeapSortButton.UseVisualStyleBackColor = true;
            this.HeapSortButton.Click += new System.EventHandler(this.HeapSortButton_Click);
            // 
            // SelectedSortButton
            // 
            this.SelectedSortButton.Location = new System.Drawing.Point(346, 304);
            this.SelectedSortButton.Name = "SelectedSortButton";
            this.SelectedSortButton.Size = new System.Drawing.Size(76, 53);
            this.SelectedSortButton.TabIndex = 17;
            this.SelectedSortButton.Text = "Выбором";
            this.SelectedSortButton.UseVisualStyleBackColor = true;
            this.SelectedSortButton.Click += new System.EventHandler(this.SelectedSortButto);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 324);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "O  (n^2)";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 393);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "O  (n log)";
            // 
            // GnomeSortButton
            // 
            this.GnomeSortButton.Location = new System.Drawing.Point(428, 304);
            this.GnomeSortButton.Name = "GnomeSortButton";
            this.GnomeSortButton.Size = new System.Drawing.Size(76, 53);
            this.GnomeSortButton.TabIndex = 20;
            this.GnomeSortButton.Text = "Гном";
            this.GnomeSortButton.UseVisualStyleBackColor = true;
            this.GnomeSortButton.Click += new System.EventHandler(this.GnomeSortButton_Click);
            // 
            // MargeSBtn
            // 
            this.MargeSBtn.Location = new System.Drawing.Point(264, 373);
            this.MargeSBtn.Name = "MargeSBtn";
            this.MargeSBtn.Size = new System.Drawing.Size(76, 53);
            this.MargeSBtn.TabIndex = 21;
            this.MargeSBtn.Text = "Marge";
            this.MargeSBtn.UseVisualStyleBackColor = true;
            this.MargeSBtn.Click += new System.EventHandler(this.MargeSBtn_Click);
            // 
            // LsdBtn
            // 
            this.LsdBtn.Location = new System.Drawing.Point(428, 373);
            this.LsdBtn.Name = "LsdBtn";
            this.LsdBtn.Size = new System.Drawing.Size(76, 53);
            this.LsdBtn.TabIndex = 22;
            this.LsdBtn.Text = "Lsd";
            this.LsdBtn.UseVisualStyleBackColor = true;
            this.LsdBtn.Click += new System.EventHandler(this.LsdBtn_Click);
            // 
            // MsdDtn
            // 
            this.MsdDtn.Location = new System.Drawing.Point(510, 373);
            this.MsdDtn.Name = "MsdDtn";
            this.MsdDtn.Size = new System.Drawing.Size(76, 53);
            this.MsdDtn.TabIndex = 23;
            this.MsdDtn.Text = "Msd";
            this.MsdDtn.UseVisualStyleBackColor = true;
            this.MsdDtn.Click += new System.EventHandler(this.MsdDtn_Click);
            // 
            // QuickBtn
            // 
            this.QuickBtn.Location = new System.Drawing.Point(182, 373);
            this.QuickBtn.Name = "QuickBtn";
            this.QuickBtn.Size = new System.Drawing.Size(76, 53);
            this.QuickBtn.TabIndex = 24;
            this.QuickBtn.Text = "Быстрая";
            this.QuickBtn.UseVisualStyleBackColor = true;
            this.QuickBtn.Click += new System.EventHandler(this.QuickBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 483);
            this.Controls.Add(this.QuickBtn);
            this.Controls.Add(this.MsdDtn);
            this.Controls.Add(this.LsdBtn);
            this.Controls.Add(this.MargeSBtn);
            this.Controls.Add(this.GnomeSortButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SelectedSortButton);
            this.Controls.Add(this.HeapSortButton);
            this.Controls.Add(this.TreeSortButton);
            this.Controls.Add(this.ShellSort);
            this.Controls.Add(this.InsertButton);
            this.Controls.Add(this.CoctailButton);
            this.Controls.Add(this.BubleSortButton);
            this.Controls.Add(this.SwopLbl);
            this.Controls.Add(this.CompareLbl);
            this.Controls.Add(this.TimeLbl);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "algorithmUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button FillButton;
        private System.Windows.Forms.TextBox FillTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox AddTextBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label SwopLbl;
        private System.Windows.Forms.Label CompareLbl;
        private System.Windows.Forms.Label TimeLbl;
        private System.Windows.Forms.Button BubleSortButton;
        private System.Windows.Forms.Button CoctailButton;
        private System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.Button ShellSort;
        private System.Windows.Forms.Button TreeSortButton;
        private System.Windows.Forms.Button HeapSortButton;
        private System.Windows.Forms.Button SelectedSortButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button GnomeSortButton;
        private System.Windows.Forms.Button MargeSBtn;
        private System.Windows.Forms.Button LsdBtn;
        private System.Windows.Forms.Button MsdDtn;
        private System.Windows.Forms.Button QuickBtn;
    }
}

