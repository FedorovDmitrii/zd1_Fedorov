
namespace zd2_Fedorov
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
            this.toolStripMenuItemAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAllProducts = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSellMultiple = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemShowProfit = new System.Windows.Forms.ToolStripMenuItem();
            this.panelInput = new System.Windows.Forms.Panel();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.labelPrompt = new System.Windows.Forms.Label();
            this.listBoxOutput = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.panelInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemAdd,
            this.toolStripMenuItemAllProducts,
            this.toolStripMenuItemSellMultiple,
            this.toolStripMenuItemShowProfit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItemAdd
            // 
            this.toolStripMenuItemAdd.Name = "toolStripMenuItemAdd";
            this.toolStripMenuItemAdd.Size = new System.Drawing.Size(105, 20);
            this.toolStripMenuItemAdd.Text = "Добавить товар";
            this.toolStripMenuItemAdd.Click += new System.EventHandler(this.menuAddProduct_Click);
            // 
            // toolStripMenuItemAllProducts
            // 
            this.toolStripMenuItemAllProducts.Name = "toolStripMenuItemAllProducts";
            this.toolStripMenuItemAllProducts.Size = new System.Drawing.Size(129, 20);
            this.toolStripMenuItemAllProducts.Text = "Посмотреть товары";
            this.toolStripMenuItemAllProducts.Click += new System.EventHandler(this.menuViewProducts_Click);
            // 
            // toolStripMenuItemSellMultiple
            // 
            this.toolStripMenuItemSellMultiple.Name = "toolStripMenuItemSellMultiple";
            this.toolStripMenuItemSellMultiple.Size = new System.Drawing.Size(173, 20);
            this.toolStripMenuItemSellMultiple.Text = "Продать несколько товаров";
            this.toolStripMenuItemSellMultiple.Click += new System.EventHandler(this.toolStripMenuItemSellMultiple_Click);
            // 
            // toolStripMenuItemShowProfit
            // 
            this.toolStripMenuItemShowProfit.Name = "toolStripMenuItemShowProfit";
            this.toolStripMenuItemShowProfit.Size = new System.Drawing.Size(104, 20);
            this.toolStripMenuItemShowProfit.Text = "Показать доход";
            this.toolStripMenuItemShowProfit.Click += new System.EventHandler(this.menuShowProfitWithTax_Click);
            // 
            // panelInput
            // 
            this.panelInput.Controls.Add(this.buttonConfirm);
            this.panelInput.Controls.Add(this.textBoxInput);
            this.panelInput.Controls.Add(this.labelPrompt);
            this.panelInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInput.Location = new System.Drawing.Point(0, 24);
            this.panelInput.Name = "panelInput";
            this.panelInput.Size = new System.Drawing.Size(800, 100);
            this.panelInput.TabIndex = 1;
            this.panelInput.Visible = false;
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.AutoSize = true;
            this.buttonConfirm.Location = new System.Drawing.Point(16, 71);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(83, 23);
            this.buttonConfirm.TabIndex = 2;
            this.buttonConfirm.Text = "Подтвердить";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.ButtonConfirmAll_Clicks);
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(3, 20);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(432, 20);
            this.textBoxInput.TabIndex = 1;
            // 
            // labelPrompt
            // 
            this.labelPrompt.AutoSize = true;
            this.labelPrompt.Location = new System.Drawing.Point(13, 4);
            this.labelPrompt.Name = "labelPrompt";
            this.labelPrompt.Size = new System.Drawing.Size(0, 13);
            this.labelPrompt.TabIndex = 0;
            // 
            // listBoxOutput
            // 
            this.listBoxOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxOutput.FormattingEnabled = true;
            this.listBoxOutput.Location = new System.Drawing.Point(0, 124);
            this.listBoxOutput.Name = "listBoxOutput";
            this.listBoxOutput.Size = new System.Drawing.Size(800, 326);
            this.listBoxOutput.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxOutput);
            this.Controls.Add(this.panelInput);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelInput.ResumeLayout(false);
            this.panelInput.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAdd;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAllProducts;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemShowProfit;
        private System.Windows.Forms.Panel panelInput;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Label labelPrompt;
        private System.Windows.Forms.ListBox listBoxOutput;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSellMultiple;
    }
}

