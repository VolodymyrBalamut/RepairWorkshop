namespace RepairerWorkshop
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.itemDictionary = new System.Windows.Forms.ToolStripMenuItem();
            this.itemDictionaryEquipment = new System.Windows.Forms.ToolStripMenuItem();
            this.itemDictionaryDepartment = new System.Windows.Forms.ToolStripMenuItem();
            this.itemDictionaryEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.itemDictionaryRepairerItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.itemOrderView = new System.Windows.Forms.ToolStripMenuItem();
            this.itemOrderAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.itemOrderRepair = new System.Windows.Forms.ToolStripMenuItem();
            this.itemProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.проПрограмуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvOrderOpen = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvOrderRepair = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvOrderClosed = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvOrderTest = new System.Windows.Forms.DataGridView();
            this.itemOrderTest = new System.Windows.Forms.ToolStripMenuItem();
            this.itemOrderClose = new System.Windows.Forms.ToolStripMenuItem();
            this.itemAddRepairItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderOpen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderRepair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderClosed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderTest)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemDictionary,
            this.itemOrder,
            this.itemProfile,
            this.проПрограмуToolStripMenuItem,
            this.itemExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1233, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // itemDictionary
            // 
            this.itemDictionary.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemDictionaryEquipment,
            this.itemDictionaryDepartment,
            this.itemDictionaryEmployee,
            this.itemDictionaryRepairerItem});
            this.itemDictionary.Image = ((System.Drawing.Image)(resources.GetObject("itemDictionary.Image")));
            this.itemDictionary.Name = "itemDictionary";
            this.itemDictionary.Size = new System.Drawing.Size(92, 20);
            this.itemDictionary.Text = "Довідники";
            // 
            // itemDictionaryEquipment
            // 
            this.itemDictionaryEquipment.Name = "itemDictionaryEquipment";
            this.itemDictionaryEquipment.Size = new System.Drawing.Size(191, 22);
            this.itemDictionaryEquipment.Text = "Обладнання";
            this.itemDictionaryEquipment.Click += new System.EventHandler(this.itemDictionaryEquipment_Click);
            // 
            // itemDictionaryDepartment
            // 
            this.itemDictionaryDepartment.Name = "itemDictionaryDepartment";
            this.itemDictionaryDepartment.Size = new System.Drawing.Size(191, 22);
            this.itemDictionaryDepartment.Text = "Підрозділи";
            this.itemDictionaryDepartment.Click += new System.EventHandler(this.itemDictionaryDepartment_Click);
            // 
            // itemDictionaryEmployee
            // 
            this.itemDictionaryEmployee.Name = "itemDictionaryEmployee";
            this.itemDictionaryEmployee.Size = new System.Drawing.Size(191, 22);
            this.itemDictionaryEmployee.Text = "Працівники";
            // 
            // itemDictionaryRepairerItem
            // 
            this.itemDictionaryRepairerItem.Name = "itemDictionaryRepairerItem";
            this.itemDictionaryRepairerItem.Size = new System.Drawing.Size(191, 22);
            this.itemDictionaryRepairerItem.Text = "Ремонтні запчастини";
            this.itemDictionaryRepairerItem.Click += new System.EventHandler(this.itemDictionaryRepairerItem_Click);
            // 
            // itemOrder
            // 
            this.itemOrder.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemOrderView,
            this.itemOrderAdd,
            this.itemOrderRepair,
            this.itemOrderTest,
            this.itemOrderClose,
            this.itemAddRepairItem});
            this.itemOrder.Image = ((System.Drawing.Image)(resources.GetObject("itemOrder.Image")));
            this.itemOrder.Name = "itemOrder";
            this.itemOrder.Size = new System.Drawing.Size(103, 20);
            this.itemOrder.Text = "Замовлення";
            // 
            // itemOrderView
            // 
            this.itemOrderView.Image = ((System.Drawing.Image)(resources.GetObject("itemOrderView.Image")));
            this.itemOrderView.Name = "itemOrderView";
            this.itemOrderView.Size = new System.Drawing.Size(152, 22);
            this.itemOrderView.Text = "Перегляд";
            this.itemOrderView.Click += new System.EventHandler(this.itemOrderView_Click);
            // 
            // itemOrderAdd
            // 
            this.itemOrderAdd.Image = ((System.Drawing.Image)(resources.GetObject("itemOrderAdd.Image")));
            this.itemOrderAdd.Name = "itemOrderAdd";
            this.itemOrderAdd.Size = new System.Drawing.Size(152, 22);
            this.itemOrderAdd.Text = "Додати";
            this.itemOrderAdd.Click += new System.EventHandler(this.itemOrderAdd_Click);
            // 
            // itemOrderRepair
            // 
            this.itemOrderRepair.Image = ((System.Drawing.Image)(resources.GetObject("itemOrderRepair.Image")));
            this.itemOrderRepair.Name = "itemOrderRepair";
            this.itemOrderRepair.Size = new System.Drawing.Size(152, 22);
            this.itemOrderRepair.Text = "Ремонт";
            this.itemOrderRepair.Click += new System.EventHandler(this.itemOrderRepair_Click);
            // 
            // itemProfile
            // 
            this.itemProfile.Image = ((System.Drawing.Image)(resources.GetObject("itemProfile.Image")));
            this.itemProfile.Name = "itemProfile";
            this.itemProfile.Size = new System.Drawing.Size(83, 20);
            this.itemProfile.Text = "Профіль";
            this.itemProfile.Click += new System.EventHandler(this.itemProfile_Click);
            // 
            // проПрограмуToolStripMenuItem
            // 
            this.проПрограмуToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("проПрограмуToolStripMenuItem.Image")));
            this.проПрограмуToolStripMenuItem.Name = "проПрограмуToolStripMenuItem";
            this.проПрограмуToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.проПрограмуToolStripMenuItem.Text = "Про програму";
            this.проПрограмуToolStripMenuItem.Click += new System.EventHandler(this.проПрограмуToolStripMenuItem_Click);
            // 
            // itemExit
            // 
            this.itemExit.Image = ((System.Drawing.Image)(resources.GetObject("itemExit.Image")));
            this.itemExit.Name = "itemExit";
            this.itemExit.Size = new System.Drawing.Size(63, 20);
            this.itemExit.Text = "Вихід";
            this.itemExit.Click += new System.EventHandler(this.itemExit_Click);
            // 
            // dgvOrderOpen
            // 
            this.dgvOrderOpen.AllowUserToAddRows = false;
            this.dgvOrderOpen.AllowUserToDeleteRows = false;
            this.dgvOrderOpen.AllowUserToResizeColumns = false;
            this.dgvOrderOpen.AllowUserToResizeRows = false;
            this.dgvOrderOpen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrderOpen.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrderOpen.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOrderOpen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderOpen.Location = new System.Drawing.Point(35, 84);
            this.dgvOrderOpen.Name = "dgvOrderOpen";
            this.dgvOrderOpen.ReadOnly = true;
            this.dgvOrderOpen.Size = new System.Drawing.Size(519, 196);
            this.dgvOrderOpen.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Lime;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(193, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Нові замовлення";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Orange;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(874, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ремонт";
            // 
            // dgvOrderRepair
            // 
            this.dgvOrderRepair.AllowUserToAddRows = false;
            this.dgvOrderRepair.AllowUserToDeleteRows = false;
            this.dgvOrderRepair.AllowUserToResizeColumns = false;
            this.dgvOrderRepair.AllowUserToResizeRows = false;
            this.dgvOrderRepair.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dgvOrderRepair.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrderRepair.BackgroundColor = System.Drawing.Color.White;
            this.dgvOrderRepair.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderRepair.Location = new System.Drawing.Point(661, 84);
            this.dgvOrderRepair.Name = "dgvOrderRepair";
            this.dgvOrderRepair.ReadOnly = true;
            this.dgvOrderRepair.Size = new System.Drawing.Size(519, 196);
            this.dgvOrderRepair.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Red;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(833, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Закриті замовлення";
            // 
            // dgvOrderClosed
            // 
            this.dgvOrderClosed.AllowUserToAddRows = false;
            this.dgvOrderClosed.AllowUserToDeleteRows = false;
            this.dgvOrderClosed.AllowUserToResizeColumns = false;
            this.dgvOrderClosed.AllowUserToResizeRows = false;
            this.dgvOrderClosed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOrderClosed.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrderClosed.BackgroundColor = System.Drawing.Color.White;
            this.dgvOrderClosed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderClosed.Location = new System.Drawing.Point(661, 342);
            this.dgvOrderClosed.Name = "dgvOrderClosed";
            this.dgvOrderClosed.ReadOnly = true;
            this.dgvOrderClosed.Size = new System.Drawing.Size(519, 196);
            this.dgvOrderClosed.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DodgerBlue;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(212, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Тестування";
            // 
            // dgvOrderTest
            // 
            this.dgvOrderTest.AllowUserToAddRows = false;
            this.dgvOrderTest.AllowUserToDeleteRows = false;
            this.dgvOrderTest.AllowUserToResizeColumns = false;
            this.dgvOrderTest.AllowUserToResizeRows = false;
            this.dgvOrderTest.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrderTest.BackgroundColor = System.Drawing.Color.White;
            this.dgvOrderTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderTest.Location = new System.Drawing.Point(35, 342);
            this.dgvOrderTest.Name = "dgvOrderTest";
            this.dgvOrderTest.ReadOnly = true;
            this.dgvOrderTest.Size = new System.Drawing.Size(519, 196);
            this.dgvOrderTest.TabIndex = 5;
            // 
            // itemOrderTest
            // 
            this.itemOrderTest.Image = ((System.Drawing.Image)(resources.GetObject("itemOrderTest.Image")));
            this.itemOrderTest.Name = "itemOrderTest";
            this.itemOrderTest.Size = new System.Drawing.Size(152, 22);
            this.itemOrderTest.Text = "Тест";
            this.itemOrderTest.Click += new System.EventHandler(this.itemOrderTest_Click);
            // 
            // itemOrderClose
            // 
            this.itemOrderClose.Image = ((System.Drawing.Image)(resources.GetObject("itemOrderClose.Image")));
            this.itemOrderClose.Name = "itemOrderClose";
            this.itemOrderClose.Size = new System.Drawing.Size(152, 22);
            this.itemOrderClose.Text = "Прийом";
            this.itemOrderClose.Click += new System.EventHandler(this.itemOrderClose_Click);
            // 
            // itemAddRepairItem
            // 
            this.itemAddRepairItem.Name = "itemAddRepairItem";
            this.itemAddRepairItem.Size = new System.Drawing.Size(152, 22);
            this.itemAddRepairItem.Text = "Додати деталь";
            this.itemAddRepairItem.Click += new System.EventHandler(this.itemAddRepairItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1233, 558);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvOrderClosed);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvOrderTest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvOrderRepair);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvOrderOpen);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "АІС \"Ремонт устаткування\"";
            this.Activated += new System.EventHandler(this.FormMain_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderOpen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderRepair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderClosed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderTest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem itemDictionary;
        private System.Windows.Forms.ToolStripMenuItem itemDictionaryEquipment;
        private System.Windows.Forms.ToolStripMenuItem itemDictionaryDepartment;
        private System.Windows.Forms.ToolStripMenuItem itemDictionaryEmployee;
        private System.Windows.Forms.ToolStripMenuItem itemDictionaryRepairerItem;
        private System.Windows.Forms.ToolStripMenuItem проПрограмуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemExit;
        private System.Windows.Forms.ToolStripMenuItem itemOrder;
        private System.Windows.Forms.ToolStripMenuItem itemOrderView;
        private System.Windows.Forms.ToolStripMenuItem itemOrderAdd;
        private System.Windows.Forms.ToolStripMenuItem itemOrderRepair;
        private System.Windows.Forms.DataGridView dgvOrderOpen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvOrderRepair;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvOrderClosed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvOrderTest;
        private System.Windows.Forms.ToolStripMenuItem itemProfile;
        private System.Windows.Forms.ToolStripMenuItem itemOrderTest;
        private System.Windows.Forms.ToolStripMenuItem itemOrderClose;
        private System.Windows.Forms.ToolStripMenuItem itemAddRepairItem;
    }
}