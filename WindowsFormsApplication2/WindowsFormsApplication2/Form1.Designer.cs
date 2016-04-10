namespace WindowsFormsApplication2
{
    partial class Form1
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
            this.listBoxPhone = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBoxOption = new System.Windows.Forms.ListBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxProc = new System.Windows.Forms.TextBox();
            this.textBoxOS = new System.Windows.Forms.TextBox();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxPhone = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.addPhone = new System.Windows.Forms.Button();
            this.AddOption = new System.Windows.Forms.Button();
            this.textBoxAddOption = new System.Windows.Forms.TextBox();
            this.SaveBtnEdit = new System.Windows.Forms.Button();
            this.textBoxEditPrice = new System.Windows.Forms.TextBox();
            this.textBoxEditPicture = new System.Windows.Forms.TextBox();
            this.textBoxEditProcessor = new System.Windows.Forms.TextBox();
            this.textBoxEditOs = new System.Windows.Forms.TextBox();
            this.textBoxEditModel = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkedListBoxEditOption = new System.Windows.Forms.CheckedListBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.BtnDlt = new System.Windows.Forms.Button();
            this.BtnDltAllList = new System.Windows.Forms.Button();
            this.SaveFile = new System.Windows.Forms.Button();
            this.ReturnPhone = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhone)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxPhone
            // 
            this.listBoxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxPhone.FormattingEnabled = true;
            this.listBoxPhone.ItemHeight = 24;
            this.listBoxPhone.Location = new System.Drawing.Point(23, 23);
            this.listBoxPhone.Name = "listBoxPhone";
            this.listBoxPhone.Size = new System.Drawing.Size(253, 388);
            this.listBoxPhone.TabIndex = 0;
            this.listBoxPhone.SelectedIndexChanged += new System.EventHandler(this.listBoxPhone_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(346, 23);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(494, 620);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.textBoxPrice);
            this.tabPage1.Controls.Add(this.textBoxProc);
            this.tabPage1.Controls.Add(this.textBoxOS);
            this.tabPage1.Controls.Add(this.textBoxModel);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.pictureBoxPhone);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(486, 594);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Информация о телефоне";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBoxOption);
            this.groupBox1.Location = new System.Drawing.Point(16, 381);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(464, 181);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Опции";
            // 
            // listBoxOption
            // 
            this.listBoxOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxOption.FormattingEnabled = true;
            this.listBoxOption.ItemHeight = 20;
            this.listBoxOption.Location = new System.Drawing.Point(32, 26);
            this.listBoxOption.Name = "listBoxOption";
            this.listBoxOption.Size = new System.Drawing.Size(403, 144);
            this.listBoxOption.TabIndex = 0;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(274, 290);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.ReadOnly = true;
            this.textBoxPrice.Size = new System.Drawing.Size(145, 26);
            this.textBoxPrice.TabIndex = 7;
            // 
            // textBoxProc
            // 
            this.textBoxProc.Location = new System.Drawing.Point(274, 257);
            this.textBoxProc.Name = "textBoxProc";
            this.textBoxProc.ReadOnly = true;
            this.textBoxProc.Size = new System.Drawing.Size(145, 26);
            this.textBoxProc.TabIndex = 6;
            // 
            // textBoxOS
            // 
            this.textBoxOS.Location = new System.Drawing.Point(274, 221);
            this.textBoxOS.Name = "textBoxOS";
            this.textBoxOS.ReadOnly = true;
            this.textBoxOS.Size = new System.Drawing.Size(145, 26);
            this.textBoxOS.TabIndex = 5;
            // 
            // textBoxModel
            // 
            this.textBoxModel.Location = new System.Drawing.Point(274, 186);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.ReadOnly = true;
            this.textBoxModel.Size = new System.Drawing.Size(145, 26);
            this.textBoxModel.TabIndex = 2;
            this.textBoxModel.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Цена";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Процессор";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "ОС";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Модель";
            // 
            // pictureBoxPhone
            // 
            this.pictureBoxPhone.Location = new System.Drawing.Point(109, 6);
            this.pictureBoxPhone.Name = "pictureBoxPhone";
            this.pictureBoxPhone.Size = new System.Drawing.Size(245, 168);
            this.pictureBoxPhone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPhone.TabIndex = 0;
            this.pictureBoxPhone.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.addPhone);
            this.tabPage2.Controls.Add(this.AddOption);
            this.tabPage2.Controls.Add(this.textBoxAddOption);
            this.tabPage2.Controls.Add(this.SaveBtnEdit);
            this.tabPage2.Controls.Add(this.textBoxEditPrice);
            this.tabPage2.Controls.Add(this.textBoxEditPicture);
            this.tabPage2.Controls.Add(this.textBoxEditProcessor);
            this.tabPage2.Controls.Add(this.textBoxEditOs);
            this.tabPage2.Controls.Add(this.textBoxEditModel);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.checkedListBoxEditOption);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(486, 594);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Редактирование информации";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // addPhone
            // 
            this.addPhone.Location = new System.Drawing.Point(312, 507);
            this.addPhone.Name = "addPhone";
            this.addPhone.Size = new System.Drawing.Size(158, 49);
            this.addPhone.TabIndex = 17;
            this.addPhone.Text = "Добавить телефон";
            this.addPhone.UseVisualStyleBackColor = true;
            this.addPhone.Click += new System.EventHandler(this.addPhone_Click);
            // 
            // AddOption
            // 
            this.AddOption.Location = new System.Drawing.Point(312, 454);
            this.AddOption.Name = "AddOption";
            this.AddOption.Size = new System.Drawing.Size(158, 29);
            this.AddOption.TabIndex = 16;
            this.AddOption.Text = "Добавить опцию";
            this.AddOption.UseVisualStyleBackColor = true;
            this.AddOption.Click += new System.EventHandler(this.AddOption_Click);
            // 
            // textBoxAddOption
            // 
            this.textBoxAddOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAddOption.Location = new System.Drawing.Point(23, 454);
            this.textBoxAddOption.Name = "textBoxAddOption";
            this.textBoxAddOption.Size = new System.Drawing.Size(243, 29);
            this.textBoxAddOption.TabIndex = 15;
            // 
            // SaveBtnEdit
            // 
            this.SaveBtnEdit.Location = new System.Drawing.Point(20, 423);
            this.SaveBtnEdit.Name = "SaveBtnEdit";
            this.SaveBtnEdit.Size = new System.Drawing.Size(450, 24);
            this.SaveBtnEdit.TabIndex = 14;
            this.SaveBtnEdit.Text = "Сохранить изменения";
            this.SaveBtnEdit.UseVisualStyleBackColor = true;
            this.SaveBtnEdit.Click += new System.EventHandler(this.SaveBtnEdit_Click);
            // 
            // textBoxEditPrice
            // 
            this.textBoxEditPrice.Location = new System.Drawing.Point(196, 203);
            this.textBoxEditPrice.Name = "textBoxEditPrice";
            this.textBoxEditPrice.Size = new System.Drawing.Size(225, 20);
            this.textBoxEditPrice.TabIndex = 13;
            // 
            // textBoxEditPicture
            // 
            this.textBoxEditPicture.Location = new System.Drawing.Point(196, 158);
            this.textBoxEditPicture.Name = "textBoxEditPicture";
            this.textBoxEditPicture.Size = new System.Drawing.Size(225, 20);
            this.textBoxEditPicture.TabIndex = 12;
            // 
            // textBoxEditProcessor
            // 
            this.textBoxEditProcessor.Location = new System.Drawing.Point(196, 118);
            this.textBoxEditProcessor.Name = "textBoxEditProcessor";
            this.textBoxEditProcessor.Size = new System.Drawing.Size(225, 20);
            this.textBoxEditProcessor.TabIndex = 11;
            // 
            // textBoxEditOs
            // 
            this.textBoxEditOs.Location = new System.Drawing.Point(196, 81);
            this.textBoxEditOs.Name = "textBoxEditOs";
            this.textBoxEditOs.Size = new System.Drawing.Size(225, 20);
            this.textBoxEditOs.TabIndex = 10;
            // 
            // textBoxEditModel
            // 
            this.textBoxEditModel.Location = new System.Drawing.Point(196, 42);
            this.textBoxEditModel.Name = "textBoxEditModel";
            this.textBoxEditModel.Size = new System.Drawing.Size(225, 20);
            this.textBoxEditModel.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(114, 209);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Цена:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(92, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Картинка:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(84, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Процессор:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(125, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "ОС:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(101, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Модель:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 2;
            // 
            // checkedListBoxEditOption
            // 
            this.checkedListBoxEditOption.FormattingEnabled = true;
            this.checkedListBoxEditOption.Location = new System.Drawing.Point(20, 266);
            this.checkedListBoxEditOption.Name = "checkedListBoxEditOption";
            this.checkedListBoxEditOption.Size = new System.Drawing.Size(450, 154);
            this.checkedListBoxEditOption.TabIndex = 1;
            // 
            // BtnDlt
            // 
            this.BtnDlt.Location = new System.Drawing.Point(23, 443);
            this.BtnDlt.Name = "BtnDlt";
            this.BtnDlt.Size = new System.Drawing.Size(116, 49);
            this.BtnDlt.TabIndex = 2;
            this.BtnDlt.Text = "Удалить";
            this.BtnDlt.UseVisualStyleBackColor = true;
            this.BtnDlt.Click += new System.EventHandler(this.BtnDlt_Click);
            // 
            // BtnDltAllList
            // 
            this.BtnDltAllList.Location = new System.Drawing.Point(156, 443);
            this.BtnDltAllList.Name = "BtnDltAllList";
            this.BtnDltAllList.Size = new System.Drawing.Size(120, 49);
            this.BtnDltAllList.TabIndex = 3;
            this.BtnDltAllList.Text = "Очистить список";
            this.BtnDltAllList.UseVisualStyleBackColor = true;
            this.BtnDltAllList.Click += new System.EventHandler(this.BtnDltAllList_Click);
            // 
            // SaveFile
            // 
            this.SaveFile.Location = new System.Drawing.Point(23, 504);
            this.SaveFile.Name = "SaveFile";
            this.SaveFile.Size = new System.Drawing.Size(116, 56);
            this.SaveFile.TabIndex = 4;
            this.SaveFile.Text = "Сохранить в файл";
            this.SaveFile.UseVisualStyleBackColor = true;
            this.SaveFile.Click += new System.EventHandler(this.SaveFile_Click);
            // 
            // ReturnPhone
            // 
            this.ReturnPhone.Location = new System.Drawing.Point(160, 504);
            this.ReturnPhone.Name = "ReturnPhone";
            this.ReturnPhone.Size = new System.Drawing.Size(116, 56);
            this.ReturnPhone.TabIndex = 5;
            this.ReturnPhone.Text = "Прочитать из файла";
            this.ReturnPhone.UseVisualStyleBackColor = true;
            this.ReturnPhone.Click += new System.EventHandler(this.ReturnPhone_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 710);
            this.Controls.Add(this.ReturnPhone);
            this.Controls.Add(this.SaveFile);
            this.Controls.Add(this.BtnDltAllList);
            this.Controls.Add(this.BtnDlt);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.listBoxPhone);
            this.Name = "Form1";
            this.Text = "PhoneShop";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhone)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxPhone;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxPhone;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxProc;
        private System.Windows.Forms.TextBox textBoxOS;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBoxOption;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.CheckedListBox checkedListBoxEditOption;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxEditPrice;
        private System.Windows.Forms.TextBox textBoxEditPicture;
        private System.Windows.Forms.TextBox textBoxEditProcessor;
        private System.Windows.Forms.TextBox textBoxEditOs;
        private System.Windows.Forms.TextBox textBoxEditModel;
        private System.Windows.Forms.Button BtnDlt;
        private System.Windows.Forms.Button BtnDltAllList;
        private System.Windows.Forms.Button SaveBtnEdit;
        private System.Windows.Forms.Button AddOption;
        private System.Windows.Forms.TextBox textBoxAddOption;
        private System.Windows.Forms.Button addPhone;
        private System.Windows.Forms.Button SaveFile;
        private System.Windows.Forms.Button ReturnPhone;
    }
}

