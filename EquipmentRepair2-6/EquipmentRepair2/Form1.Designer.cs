namespace EquipmentRepair2
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.довідникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.цехаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.персониToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обладнанняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видиРобітToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вхіднаІнформаціяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.створенняЗамовленняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.замовленняНаРемонтАбоЗаточуванняІнструментівприладівToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.створенняАктуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.актПрийманняздачіВідремонтованихРеконструйованихТаМодернізованихОбєктівToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вихіднаІнформаціяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.контрольПроведенняРемонтівОбладнанняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.створенняЗвітуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.вихідToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Enabled = false;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.довідникиToolStripMenuItem,
            this.вхіднаІнформаціяToolStripMenuItem,
            this.вихіднаІнформаціяToolStripMenuItem,
            this.вихідToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(826, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // довідникиToolStripMenuItem
            // 
            this.довідникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.цехаToolStripMenuItem,
            this.персониToolStripMenuItem,
            this.обладнанняToolStripMenuItem,
            this.видиРобітToolStripMenuItem});
            this.довідникиToolStripMenuItem.Name = "довідникиToolStripMenuItem";
            this.довідникиToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.довідникиToolStripMenuItem.Text = "Довідники";
            // 
            // цехаToolStripMenuItem
            // 
            this.цехаToolStripMenuItem.Name = "цехаToolStripMenuItem";
            this.цехаToolStripMenuItem.Size = new System.Drawing.Size(280, 22);
            this.цехаToolStripMenuItem.Text = "Організаційна одиниця підприємства";
            this.цехаToolStripMenuItem.Click += new System.EventHandler(this.DepartmentMenuItem_Click);
            // 
            // персониToolStripMenuItem
            // 
            this.персониToolStripMenuItem.Name = "персониToolStripMenuItem";
            this.персониToolStripMenuItem.Size = new System.Drawing.Size(280, 22);
            this.персониToolStripMenuItem.Text = "Персони";
            this.персониToolStripMenuItem.Click += new System.EventHandler(this.PersonsMenuItem_Click);
            // 
            // обладнанняToolStripMenuItem
            // 
            this.обладнанняToolStripMenuItem.Name = "обладнанняToolStripMenuItem";
            this.обладнанняToolStripMenuItem.Size = new System.Drawing.Size(280, 22);
            this.обладнанняToolStripMenuItem.Text = "Обладнання";
            this.обладнанняToolStripMenuItem.Click += new System.EventHandler(this.EquipmentMenuItem_Click);
            // 
            // видиРобітToolStripMenuItem
            // 
            this.видиРобітToolStripMenuItem.Name = "видиРобітToolStripMenuItem";
            this.видиРобітToolStripMenuItem.Size = new System.Drawing.Size(280, 22);
            this.видиРобітToolStripMenuItem.Text = "Види робіт";
            this.видиРобітToolStripMenuItem.Click += new System.EventHandler(this.WorkTypesMenuItem_Click);
            // 
            // вхіднаІнформаціяToolStripMenuItem
            // 
            this.вхіднаІнформаціяToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.створенняЗамовленняToolStripMenuItem,
            this.замовленняНаРемонтАбоЗаточуванняІнструментівприладівToolStripMenuItem,
            this.створенняАктуToolStripMenuItem,
            this.актПрийманняздачіВідремонтованихРеконструйованихТаМодернізованихОбєктівToolStripMenuItem});
            this.вхіднаІнформаціяToolStripMenuItem.Name = "вхіднаІнформаціяToolStripMenuItem";
            this.вхіднаІнформаціяToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.вхіднаІнформаціяToolStripMenuItem.Text = "Вхідна інформація";
            // 
            // створенняЗамовленняToolStripMenuItem
            // 
            this.створенняЗамовленняToolStripMenuItem.Name = "створенняЗамовленняToolStripMenuItem";
            this.створенняЗамовленняToolStripMenuItem.Size = new System.Drawing.Size(550, 22);
            this.створенняЗамовленняToolStripMenuItem.Text = "Створення замовлення";
            this.створенняЗамовленняToolStripMenuItem.Click += new System.EventHandler(this.CreateOrderMenuItem_Click);
            // 
            // замовленняНаРемонтАбоЗаточуванняІнструментівприладівToolStripMenuItem
            // 
            this.замовленняНаРемонтАбоЗаточуванняІнструментівприладівToolStripMenuItem.Name = "замовленняНаРемонтАбоЗаточуванняІнструментівприладівToolStripMenuItem";
            this.замовленняНаРемонтАбоЗаточуванняІнструментівприладівToolStripMenuItem.Size = new System.Drawing.Size(550, 22);
            this.замовленняНаРемонтАбоЗаточуванняІнструментівприладівToolStripMenuItem.Text = "Замовлення на ремонт або заточування інструментів/приладів";
            this.замовленняНаРемонтАбоЗаточуванняІнструментівприладівToolStripMenuItem.Click += new System.EventHandler(this.OrderMenuItem_Click);
            // 
            // створенняАктуToolStripMenuItem
            // 
            this.створенняАктуToolStripMenuItem.Name = "створенняАктуToolStripMenuItem";
            this.створенняАктуToolStripMenuItem.Size = new System.Drawing.Size(550, 22);
            this.створенняАктуToolStripMenuItem.Text = "Створення акту";
            this.створенняАктуToolStripMenuItem.Click += new System.EventHandler(this.CreateActMenuItem_Click);
            // 
            // актПрийманняздачіВідремонтованихРеконструйованихТаМодернізованихОбєктівToolStripMenuItem
            // 
            this.актПрийманняздачіВідремонтованихРеконструйованихТаМодернізованихОбєктівToolStripMenuItem.Name = "актПрийманняздачіВідремонтованихРеконструйованихТаМодернізованихОбєктівToolStripM" +
    "enuItem";
            this.актПрийманняздачіВідремонтованихРеконструйованихТаМодернізованихОбєктівToolStripMenuItem.Size = new System.Drawing.Size(550, 22);
            this.актПрийманняздачіВідремонтованихРеконструйованихТаМодернізованихОбєктівToolStripMenuItem.Text = "Акт приймання-здачі відремонтованих, реконструйованих та модернізованих об’єктів " +
    "";
            this.актПрийманняздачіВідремонтованихРеконструйованихТаМодернізованихОбєктівToolStripMenuItem.Click += new System.EventHandler(this.ActMenuItem_Click);
            // 
            // вихіднаІнформаціяToolStripMenuItem
            // 
            this.вихіднаІнформаціяToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.контрольПроведенняРемонтівОбладнанняToolStripMenuItem,
            this.створенняЗвітуToolStripMenuItem});
            this.вихіднаІнформаціяToolStripMenuItem.Name = "вихіднаІнформаціяToolStripMenuItem";
            this.вихіднаІнформаціяToolStripMenuItem.Size = new System.Drawing.Size(127, 20);
            this.вихіднаІнформаціяToolStripMenuItem.Text = "Вихідна інформація";
            // 
            // контрольПроведенняРемонтівОбладнанняToolStripMenuItem
            // 
            this.контрольПроведенняРемонтівОбладнанняToolStripMenuItem.Name = "контрольПроведенняРемонтівОбладнанняToolStripMenuItem";
            this.контрольПроведенняРемонтівОбладнанняToolStripMenuItem.Size = new System.Drawing.Size(317, 22);
            this.контрольПроведенняРемонтівОбладнанняToolStripMenuItem.Text = "Контроль проведення ремонтів обладнання";
            this.контрольПроведенняРемонтівОбладнанняToolStripMenuItem.Click += new System.EventHandler(this.ControlMenuItem_Click);
            // 
            // створенняЗвітуToolStripMenuItem
            // 
            this.створенняЗвітуToolStripMenuItem.Name = "створенняЗвітуToolStripMenuItem";
            this.створенняЗвітуToolStripMenuItem.Size = new System.Drawing.Size(317, 22);
            this.створенняЗвітуToolStripMenuItem.Text = "Створення звіту";
            this.створенняЗвітуToolStripMenuItem.Click += new System.EventHandler(this.CreateRepornMenuItem_Click);
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=idea-pc;Initial Catalog=EquipmentRepair2;Integrated Security=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(193, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(442, 374);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(275, 104);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(298, 211);
            this.panel1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(113, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Війти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(100, 96);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(131, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Пароль:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(100, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(131, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Логін:";
            // 
            // вихідToolStripMenuItem
            // 
            this.вихідToolStripMenuItem.Name = "вихідToolStripMenuItem";
            this.вихідToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.вихідToolStripMenuItem.Text = "Вихід";
            this.вихідToolStripMenuItem.Click += new System.EventHandler(this.вихідToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(826, 413);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(842, 452);
            this.Name = "Form1";
            this.Text = "Металургійний завод КО";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem довідникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem персониToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem цехаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обладнанняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видиРобітToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вхіднаІнформаціяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem створенняЗамовленняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem замовленняНаРемонтАбоЗаточуванняІнструментівприладівToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem створенняАктуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem актПрийманняздачіВідремонтованихРеконструйованихТаМодернізованихОбєктівToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вихіднаІнформаціяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem контрольПроведенняРемонтівОбладнанняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem створенняЗвітуToolStripMenuItem;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem вихідToolStripMenuItem;
    }
}

