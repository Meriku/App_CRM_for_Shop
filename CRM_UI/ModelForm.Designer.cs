namespace CRM_UI
{
    partial class ModelForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_end = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelCashDesk = new System.Windows.Forms.Label();
            this.labelMoney = new System.Windows.Forms.Label();
            this.labelDownload = new System.Windows.Forms.Label();
            this.trackBarCustomerSpeed = new System.Windows.Forms.TrackBar();
            this.labelClientAdd = new System.Windows.Forms.Label();
            this.trackBarCashDesk = new System.Windows.Forms.TrackBar();
            this.labelCashDeskSpeed = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCustomerSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCashDesk)).BeginInit();
            this.SuspendLayout();
            // 
            // button_end
            // 
            this.button_end.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_end.Location = new System.Drawing.Point(665, 408);
            this.button_end.Name = "button_end";
            this.button_end.Size = new System.Drawing.Size(117, 30);
            this.button_end.TabIndex = 0;
            this.button_end.Text = "Завершить";
            this.button_end.UseVisualStyleBackColor = true;
            this.button_end.Click += new System.EventHandler(this.start_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonStart.Location = new System.Drawing.Point(12, 408);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(117, 30);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Старт";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelCashDesk
            // 
            this.labelCashDesk.AutoSize = true;
            this.labelCashDesk.Location = new System.Drawing.Point(12, 5);
            this.labelCashDesk.Name = "labelCashDesk";
            this.labelCashDesk.Size = new System.Drawing.Size(62, 16);
            this.labelCashDesk.TabIndex = 2;
            this.labelCashDesk.Text = "Касса №";
            // 
            // labelMoney
            // 
            this.labelMoney.AutoSize = true;
            this.labelMoney.Location = new System.Drawing.Point(100, 5);
            this.labelMoney.Name = "labelMoney";
            this.labelMoney.Size = new System.Drawing.Size(49, 16);
            this.labelMoney.TabIndex = 3;
            this.labelMoney.Text = "Доход:";
            // 
            // labelDownload
            // 
            this.labelDownload.AutoSize = true;
            this.labelDownload.Location = new System.Drawing.Point(275, 5);
            this.labelDownload.Name = "labelDownload";
            this.labelDownload.Size = new System.Drawing.Size(104, 16);
            this.labelDownload.TabIndex = 4;
            this.labelDownload.Text = "Нагруженость:";
            // 
            // trackBarCustomerSpeed
            // 
            this.trackBarCustomerSpeed.LargeChange = 50;
            this.trackBarCustomerSpeed.Location = new System.Drawing.Point(160, 382);
            this.trackBarCustomerSpeed.Maximum = 1000;
            this.trackBarCustomerSpeed.Name = "trackBarCustomerSpeed";
            this.trackBarCustomerSpeed.Size = new System.Drawing.Size(172, 56);
            this.trackBarCustomerSpeed.TabIndex = 5;
            this.trackBarCustomerSpeed.Value = 500;
            this.trackBarCustomerSpeed.Scroll += new System.EventHandler(this.trackBarCustomerSpeed_Scroll);
            // 
            // labelClientAdd
            // 
            this.labelClientAdd.AutoSize = true;
            this.labelClientAdd.Location = new System.Drawing.Point(142, 346);
            this.labelClientAdd.Name = "labelClientAdd";
            this.labelClientAdd.Size = new System.Drawing.Size(219, 16);
            this.labelClientAdd.TabIndex = 6;
            this.labelClientAdd.Text = "Скорость добавление клиентов:";
            this.labelClientAdd.Click += new System.EventHandler(this.label1_Click);
            // 
            // trackBarCashDesk
            // 
            this.trackBarCashDesk.LargeChange = 50;
            this.trackBarCashDesk.Location = new System.Drawing.Point(452, 382);
            this.trackBarCashDesk.Maximum = 1000;
            this.trackBarCashDesk.Name = "trackBarCashDesk";
            this.trackBarCashDesk.Size = new System.Drawing.Size(172, 56);
            this.trackBarCashDesk.TabIndex = 7;
            this.trackBarCashDesk.Value = 500;
            this.trackBarCashDesk.ValueChanged += new System.EventHandler(this.trackBarCashDesk_ValueChanged);
            // 
            // labelCashDeskSpeed
            // 
            this.labelCashDeskSpeed.AutoSize = true;
            this.labelCashDeskSpeed.Location = new System.Drawing.Point(449, 346);
            this.labelCashDeskSpeed.Name = "labelCashDeskSpeed";
            this.labelCashDeskSpeed.Size = new System.Drawing.Size(186, 16);
            this.labelCashDeskSpeed.TabIndex = 8;
            this.labelCashDeskSpeed.Text = "Скорость работы кассиров:";
            // 
            // ModelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelCashDeskSpeed);
            this.Controls.Add(this.trackBarCashDesk);
            this.Controls.Add(this.labelClientAdd);
            this.Controls.Add(this.trackBarCustomerSpeed);
            this.Controls.Add(this.labelDownload);
            this.Controls.Add(this.labelMoney);
            this.Controls.Add(this.labelCashDesk);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.button_end);
            this.Name = "ModelForm";
            this.Text = "ModelForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ModelForm_FormClosing);
            this.Load += new System.EventHandler(this.ModelForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCustomerSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCashDesk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_end;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelCashDesk;
        private System.Windows.Forms.Label labelMoney;
        private System.Windows.Forms.Label labelDownload;
        private System.Windows.Forms.TrackBar trackBarCustomerSpeed;
        private System.Windows.Forms.Label labelClientAdd;
        private System.Windows.Forms.TrackBar trackBarCashDesk;
        private System.Windows.Forms.Label labelCashDeskSpeed;
    }
}