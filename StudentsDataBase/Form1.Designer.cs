namespace StudentsDataBase
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
            this.LastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SecondName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Group = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.Find = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LastName
            // 
            this.LastName.Location = new System.Drawing.Point(104, 29);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(108, 26);
            this.LastName.TabIndex = 1;
            this.LastName.TextChanged += new System.EventHandler(this.LastName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Фамилия:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Имя:";
            // 
            // FirstName
            // 
            this.FirstName.Location = new System.Drawing.Point(304, 29);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(108, 26);
            this.FirstName.TabIndex = 4;
            this.FirstName.TextChanged += new System.EventHandler(this.FirstName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(456, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Отчество:";
            // 
            // SecondName
            // 
            this.SecondName.Location = new System.Drawing.Point(549, 29);
            this.SecondName.Name = "SecondName";
            this.SecondName.Size = new System.Drawing.Size(108, 26);
            this.SecondName.TabIndex = 6;
            this.SecondName.TextChanged += new System.EventHandler(this.SecondName_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(694, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Группа:";
            // 
            // Group
            // 
            this.Group.Location = new System.Drawing.Point(765, 29);
            this.Group.Name = "Group";
            this.Group.Size = new System.Drawing.Size(108, 26);
            this.Group.TabIndex = 8;
            this.Group.TextChanged += new System.EventHandler(this.Group_TextChanged);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(930, 21);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(102, 43);
            this.Add.TabIndex = 9;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Find
            // 
            this.Find.Location = new System.Drawing.Point(258, 141);
            this.Find.Name = "Find";
            this.Find.Size = new System.Drawing.Size(166, 78);
            this.Find.TabIndex = 10;
            this.Find.Text = "Поиск";
            this.Find.UseVisualStyleBackColor = true;
            this.Find.Click += new System.EventHandler(this.Find_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(627, 141);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(166, 78);
            this.Delete.TabIndex = 11;
            this.Delete.Text = "Удаление";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(17, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 27);
            this.label5.TabIndex = 12;
            this.label5.Text = "ПИ - 221 = 1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(847, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 27);
            this.label6.TabIndex = 13;
            this.label6.Text = "ИТ - 221 = 3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(17, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 27);
            this.label7.TabIndex = 14;
            this.label7.Text = "ПИ - 222 = 2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(847, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 27);
            this.label8.TabIndex = 15;
            this.label8.Text = "ИТ - 222 = 4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(1061, 316);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Find);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Group);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SecondName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LastName);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Students";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SecondName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Group;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Find;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

