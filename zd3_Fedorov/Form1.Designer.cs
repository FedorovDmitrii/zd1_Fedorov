
namespace zd3_Fedorov
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
            this.panelInput = new System.Windows.Forms.Panel();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.buttonAddByFields = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.buttonGoToStart = new System.Windows.Forms.Button();
            this.buttonRemoveByIndex = new System.Windows.Forms.Button();
            this.buttonRemoveByValue = new System.Windows.Forms.Button();
            this.labelCurrentSong = new System.Windows.Forms.Label();
            this.listBoxSongs = new System.Windows.Forms.ListBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.textBoxInputRemove = new System.Windows.Forms.TextBox();
            this.panelInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelInput
            // 
            this.panelInput.Controls.Add(this.textBoxInputRemove);
            this.panelInput.Controls.Add(this.buttonClear);
            this.panelInput.Controls.Add(this.labelCurrentSong);
            this.panelInput.Controls.Add(this.buttonRemoveByValue);
            this.panelInput.Controls.Add(this.buttonRemoveByIndex);
            this.panelInput.Controls.Add(this.buttonGoToStart);
            this.panelInput.Controls.Add(this.buttonPrev);
            this.panelInput.Controls.Add(this.buttonNext);
            this.panelInput.Controls.Add(this.buttonAddByFields);
            this.panelInput.Controls.Add(this.textBoxFileName);
            this.panelInput.Controls.Add(this.textBoxTitle);
            this.panelInput.Controls.Add(this.textBoxAuthor);
            this.panelInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInput.Location = new System.Drawing.Point(0, 0);
            this.panelInput.Name = "panelInput";
            this.panelInput.Size = new System.Drawing.Size(800, 142);
            this.panelInput.TabIndex = 0;
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.Location = new System.Drawing.Point(10, 10);
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.Size = new System.Drawing.Size(150, 20);
            this.textBoxAuthor.TabIndex = 1;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(170, 10);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(150, 20);
            this.textBoxTitle.TabIndex = 2;
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Location = new System.Drawing.Point(330, 10);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.Size = new System.Drawing.Size(150, 20);
            this.textBoxFileName.TabIndex = 3;
            // 
            // buttonAddByFields
            // 
            this.buttonAddByFields.Location = new System.Drawing.Point(490, 8);
            this.buttonAddByFields.Name = "buttonAddByFields";
            this.buttonAddByFields.Size = new System.Drawing.Size(75, 23);
            this.buttonAddByFields.TabIndex = 4;
            this.buttonAddByFields.Text = "Добавить";
            this.buttonAddByFields.UseVisualStyleBackColor = true;
            this.buttonAddByFields.Click += new System.EventHandler(this.buttonAddByFields_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(80, 40);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(60, 23);
            this.buttonNext.TabIndex = 5;
            this.buttonNext.Text = "▶";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonPrev
            // 
            this.buttonPrev.Location = new System.Drawing.Point(10, 40);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(60, 23);
            this.buttonPrev.TabIndex = 6;
            this.buttonPrev.Text = "◀";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // buttonGoToStart
            // 
            this.buttonGoToStart.Location = new System.Drawing.Point(150, 40);
            this.buttonGoToStart.Name = "buttonGoToStart";
            this.buttonGoToStart.Size = new System.Drawing.Size(60, 23);
            this.buttonGoToStart.TabIndex = 7;
            this.buttonGoToStart.Text = "|<<";
            this.buttonGoToStart.UseVisualStyleBackColor = true;
            this.buttonGoToStart.Click += new System.EventHandler(this.buttonGoToStart_Click);
            // 
            // buttonRemoveByIndex
            // 
            this.buttonRemoveByIndex.AutoSize = true;
            this.buttonRemoveByIndex.Location = new System.Drawing.Point(220, 40);
            this.buttonRemoveByIndex.Name = "buttonRemoveByIndex";
            this.buttonRemoveByIndex.Size = new System.Drawing.Size(119, 23);
            this.buttonRemoveByIndex.TabIndex = 8;
            this.buttonRemoveByIndex.Text = "Удалить по индексу";
            this.buttonRemoveByIndex.UseVisualStyleBackColor = true;
            this.buttonRemoveByIndex.Click += new System.EventHandler(this.buttonRemoveByIndex_Click);
            // 
            // buttonRemoveByValue
            // 
            this.buttonRemoveByValue.AutoSize = true;
            this.buttonRemoveByValue.Location = new System.Drawing.Point(350, 40);
            this.buttonRemoveByValue.Name = "buttonRemoveByValue";
            this.buttonRemoveByValue.Size = new System.Drawing.Size(128, 23);
            this.buttonRemoveByValue.TabIndex = 9;
            this.buttonRemoveByValue.Text = "Удалить по названию";
            this.buttonRemoveByValue.UseVisualStyleBackColor = true;
            this.buttonRemoveByValue.Click += new System.EventHandler(this.buttonRemoveByValue_Click);
            // 
            // labelCurrentSong
            // 
            this.labelCurrentSong.AutoSize = true;
            this.labelCurrentSong.Location = new System.Drawing.Point(10, 70);
            this.labelCurrentSong.Name = "labelCurrentSong";
            this.labelCurrentSong.Size = new System.Drawing.Size(94, 13);
            this.labelCurrentSong.TabIndex = 10;
            this.labelCurrentSong.Text = "Текущая песня --";
            // 
            // listBoxSongs
            // 
            this.listBoxSongs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxSongs.FormattingEnabled = true;
            this.listBoxSongs.Location = new System.Drawing.Point(0, 142);
            this.listBoxSongs.Name = "listBoxSongs";
            this.listBoxSongs.Size = new System.Drawing.Size(800, 308);
            this.listBoxSongs.TabIndex = 1;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(480, 40);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 11;
            this.buttonClear.Text = "Очистить";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // textBoxInputRemove
            // 
            this.textBoxInputRemove.Location = new System.Drawing.Point(10, 115);
            this.textBoxInputRemove.Name = "textBoxInputRemove";
            this.textBoxInputRemove.Size = new System.Drawing.Size(300, 20);
            this.textBoxInputRemove.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxSongs);
            this.Controls.Add(this.panelInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelInput.ResumeLayout(false);
            this.panelInput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelInput;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label labelCurrentSong;
        private System.Windows.Forms.Button buttonRemoveByValue;
        private System.Windows.Forms.Button buttonRemoveByIndex;
        private System.Windows.Forms.Button buttonGoToStart;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonAddByFields;
        private System.Windows.Forms.TextBox textBoxFileName;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.ListBox listBoxSongs;
        private System.Windows.Forms.TextBox textBoxInputRemove;
    }
}

