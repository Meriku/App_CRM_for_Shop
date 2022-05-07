namespace CRM_UI
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.сущностиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sellerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddSellerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddCustomerToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ReceiptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modelingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сущностиToolStripMenuItem,
            this.modelingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(520, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // сущностиToolStripMenuItem
            // 
            this.сущностиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productToolStripMenuItem,
            this.sellerToolStripMenuItem,
            this.customerToolStripMenuItem,
            this.ReceiptToolStripMenuItem});
            this.сущностиToolStripMenuItem.Name = "сущностиToolStripMenuItem";
            this.сущностиToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.сущностиToolStripMenuItem.Text = "Меню";
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddProductToolStripMenuItem});
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.productToolStripMenuItem.Text = "Товар";
            this.productToolStripMenuItem.Click += new System.EventHandler(this.ProductToolStripMenuItem_Click);
            // 
            // AddProductToolStripMenuItem
            // 
            this.AddProductToolStripMenuItem.Name = "AddProductToolStripMenuItem";
            this.AddProductToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.AddProductToolStripMenuItem.Text = "Добавить";
            this.AddProductToolStripMenuItem.Click += new System.EventHandler(this.AddProductToolStripMenuItem_Click);
            // 
            // sellerToolStripMenuItem
            // 
            this.sellerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddSellerToolStripMenuItem1});
            this.sellerToolStripMenuItem.Name = "sellerToolStripMenuItem";
            this.sellerToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.sellerToolStripMenuItem.Text = "Продавец";
            this.sellerToolStripMenuItem.Click += new System.EventHandler(this.SellerToolStripMenuItem_Click);
            // 
            // AddSellerToolStripMenuItem1
            // 
            this.AddSellerToolStripMenuItem1.Name = "AddSellerToolStripMenuItem1";
            this.AddSellerToolStripMenuItem1.Size = new System.Drawing.Size(159, 26);
            this.AddSellerToolStripMenuItem1.Text = "Добавить";
            this.AddSellerToolStripMenuItem1.Click += new System.EventHandler(this.AddSellerToolStripMenuItem1_Click);
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddCustomerToolStripMenuItem2});
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.customerToolStripMenuItem.Text = "Покупатель";
            this.customerToolStripMenuItem.Click += new System.EventHandler(this.CustomerToolStripMenuItem_Click);
            // 
            // AddCustomerToolStripMenuItem2
            // 
            this.AddCustomerToolStripMenuItem2.Name = "AddCustomerToolStripMenuItem2";
            this.AddCustomerToolStripMenuItem2.Size = new System.Drawing.Size(159, 26);
            this.AddCustomerToolStripMenuItem2.Text = "Добавить";
            this.AddCustomerToolStripMenuItem2.Click += new System.EventHandler(this.AddCustomerToolStripMenuItem2_Click);
            // 
            // ReceiptToolStripMenuItem
            // 
            this.ReceiptToolStripMenuItem.Name = "ReceiptToolStripMenuItem";
            this.ReceiptToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.ReceiptToolStripMenuItem.Text = "Чек";
            this.ReceiptToolStripMenuItem.Click += new System.EventHandler(this.ReceiptToolStripMenuItem_Click);
            // 
            // modelingToolStripMenuItem
            // 
            this.modelingToolStripMenuItem.Name = "modelingToolStripMenuItem";
            this.modelingToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.modelingToolStripMenuItem.Text = "Моделирование";
            this.modelingToolStripMenuItem.Click += new System.EventHandler(this.modelingToolStripMenuItem_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 31);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(254, 404);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(298, 63);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(203, 308);
            this.listBox2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(295, 385);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Итого";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(298, 411);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Оплатить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(298, 32);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(130, 16);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Здравствуй, гость!";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 450);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem сущностиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sellerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReceiptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddSellerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem AddCustomerToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem modelingToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

