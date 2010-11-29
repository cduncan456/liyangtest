namespace MemberInfo
{
    partial class SaleForm
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
            this.completeSaleButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.createNewMemButton = new System.Windows.Forms.Button();
            this.logOutButton = new System.Windows.Forms.Button();
            this.searchCategoriesComboBox = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.searchBy = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.queryResultGrid = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rentalDataGrid = new System.Windows.Forms.DataGridView();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.memberResultGrid = new System.Windows.Forms.DataGridView();
            this.memberSearchButton = new System.Windows.Forms.Button();
            this.memberPhoneSearch = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.sqlButton = new System.Windows.Forms.Button();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.furnitureItemsDataGrid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.rental_numberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesPersonColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.due_dateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.start_dateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.queryResultGrid)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rentalDataGrid)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memberResultGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.furnitureItemsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // completeSaleButton
            // 
            this.completeSaleButton.Location = new System.Drawing.Point(449, 266);
            this.completeSaleButton.Name = "completeSaleButton";
            this.completeSaleButton.Size = new System.Drawing.Size(96, 23);
            this.completeSaleButton.TabIndex = 0;
            this.completeSaleButton.Text = "Complete Sale";
            this.completeSaleButton.UseVisualStyleBackColor = true;
            this.completeSaleButton.Click += new System.EventHandler(this.completeSaleButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(303, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Subtotal";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(324, 284);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Tax";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(318, 313);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Total";
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 82;
            this.lineShape1.X2 = 210;
            this.lineShape1.Y1 = 264;
            this.lineShape1.Y2 = 264;
            // 
            // createNewMemButton
            // 
            this.createNewMemButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createNewMemButton.Location = new System.Drawing.Point(1, 555);
            this.createNewMemButton.Name = "createNewMemButton";
            this.createNewMemButton.Size = new System.Drawing.Size(140, 55);
            this.createNewMemButton.TabIndex = 17;
            this.createNewMemButton.Text = "Create New Member";
            this.createNewMemButton.UseVisualStyleBackColor = true;
            this.createNewMemButton.Click += new System.EventHandler(this.createNewMemButton_Click);
            // 
            // logOutButton
            // 
            this.logOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutButton.Location = new System.Drawing.Point(634, 577);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(82, 33);
            this.logOutButton.TabIndex = 18;
            this.logOutButton.Text = "Log Out";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // searchCategoriesComboBox
            // 
            this.searchCategoriesComboBox.FormattingEnabled = true;
            this.searchCategoriesComboBox.Items.AddRange(new object[] {
            "Bed",
            "Couch",
            "Chair",
            "Table"});
            this.searchCategoriesComboBox.Location = new System.Drawing.Point(138, 68);
            this.searchCategoriesComboBox.Name = "searchCategoriesComboBox";
            this.searchCategoriesComboBox.Size = new System.Drawing.Size(121, 21);
            this.searchCategoriesComboBox.TabIndex = 19;
            this.searchCategoriesComboBox.SelectedIndexChanged += new System.EventHandler(this.searchCategoriesComboBox_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "color",
            "origin",
            "style",
            "furniture_Id",
            "category"});
            this.comboBox1.Location = new System.Drawing.Point(11, 68);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 24;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // searchBy
            // 
            this.searchBy.AutoSize = true;
            this.searchBy.Location = new System.Drawing.Point(10, 52);
            this.searchBy.Name = "searchBy";
            this.searchBy.Size = new System.Drawing.Size(56, 13);
            this.searchBy.TabIndex = 25;
            this.searchBy.Text = "Search By";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(135, 52);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(31, 13);
            this.typeLabel.TabIndex = 26;
            this.typeLabel.Text = "Type";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(1, 162);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(722, 367);
            this.tabControl1.TabIndex = 27;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.queryResultGrid);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.typeLabel);
            this.tabPage1.Controls.Add(this.searchBy);
            this.tabPage1.Controls.Add(this.searchCategoriesComboBox);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(714, 341);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Furniture Search";
            // 
            // queryResultGrid
            // 
            this.queryResultGrid.BackgroundColor = System.Drawing.Color.White;
            this.queryResultGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.queryResultGrid.Location = new System.Drawing.Point(12, 95);
            this.queryResultGrid.Name = "queryResultGrid";
            this.queryResultGrid.ReadOnly = true;
            this.queryResultGrid.Size = new System.Drawing.Size(694, 229);
            this.queryResultGrid.TabIndex = 40;
            this.queryResultGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.queryResultGrid_CellDoubleClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(7, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(216, 31);
            this.label10.TabIndex = 32;
            this.label10.Text = "Furniture Search";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.furnitureItemsDataGrid);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.rentalDataGrid);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.completeSaleButton);
            this.tabPage2.Controls.Add(this.shapeContainer2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(714, 341);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Rent";
            // 
            // rentalDataGrid
            // 
            this.rentalDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.rentalDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rentalDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rental_numberColumn,
            this.salesPersonColumn,
            this.memberIdColumn,
            this.due_dateColumn,
            this.start_dateColumn});
            this.rentalDataGrid.Location = new System.Drawing.Point(6, 29);
            this.rentalDataGrid.Name = "rentalDataGrid";
            this.rentalDataGrid.Size = new System.Drawing.Size(560, 79);
            this.rentalDataGrid.TabIndex = 17;
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(3, 3);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer2.Size = new System.Drawing.Size(708, 335);
            this.shapeContainer2.TabIndex = 16;
            this.shapeContainer2.TabStop = false;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.memberResultGrid);
            this.tabPage3.Controls.Add(this.memberSearchButton);
            this.tabPage3.Controls.Add(this.memberPhoneSearch);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(714, 341);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Member Search";
            // 
            // memberResultGrid
            // 
            this.memberResultGrid.BackgroundColor = System.Drawing.Color.White;
            this.memberResultGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.memberResultGrid.Location = new System.Drawing.Point(9, 87);
            this.memberResultGrid.Name = "memberResultGrid";
            this.memberResultGrid.Size = new System.Drawing.Size(697, 226);
            this.memberResultGrid.TabIndex = 42;
            // 
            // memberSearchButton
            // 
            this.memberSearchButton.Location = new System.Drawing.Point(257, 56);
            this.memberSearchButton.Name = "memberSearchButton";
            this.memberSearchButton.Size = new System.Drawing.Size(75, 23);
            this.memberSearchButton.TabIndex = 37;
            this.memberSearchButton.Text = "Search";
            this.memberSearchButton.UseVisualStyleBackColor = true;
            this.memberSearchButton.Click += new System.EventHandler(this.memberSearchButton_Click_1);
            // 
            // memberPhoneSearch
            // 
            this.memberPhoneSearch.Location = new System.Drawing.Point(154, 60);
            this.memberPhoneSearch.MaxLength = 10;
            this.memberPhoneSearch.Name = "memberPhoneSearch";
            this.memberPhoneSearch.Size = new System.Drawing.Size(97, 20);
            this.memberPhoneSearch.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Member ID Lookup Phone #";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(1, 26);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(205, 31);
            this.label13.TabIndex = 34;
            this.label13.Text = "Member Search";
            // 
            // sqlButton
            // 
            this.sqlButton.Location = new System.Drawing.Point(484, 577);
            this.sqlButton.Name = "sqlButton";
            this.sqlButton.Size = new System.Drawing.Size(87, 33);
            this.sqlButton.TabIndex = 28;
            this.sqlButton.Text = "SQL ";
            this.sqlButton.UseVisualStyleBackColor = true;
            this.sqlButton.Visible = false;
            this.sqlButton.Click += new System.EventHandler(this.sqlButton_Click);
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(10, 21);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(127, 29);
            this.welcomeLabel.TabIndex = 29;
            this.welcomeLabel.Text = "Welcome: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(250, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(193, 55);
            this.label11.TabIndex = 30;
            this.label11.Text = "RentMe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "label1";
            // 
            // furnitureItemsDataGrid
            // 
            this.furnitureItemsDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.furnitureItemsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.furnitureItemsDataGrid.Location = new System.Drawing.Point(3, 127);
            this.furnitureItemsDataGrid.Name = "furnitureItemsDataGrid";
            this.furnitureItemsDataGrid.Size = new System.Drawing.Size(708, 114);
            this.furnitureItemsDataGrid.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "label2";
            // 
            // rental_numberColumn
            // 
            this.rental_numberColumn.HeaderText = "Rental Number";
            this.rental_numberColumn.Name = "rental_numberColumn";
            this.rental_numberColumn.ReadOnly = true;
            // 
            // salesPersonColumn
            // 
            this.salesPersonColumn.HeaderText = "Rented By:";
            this.salesPersonColumn.Name = "salesPersonColumn";
            // 
            // memberIdColumn
            // 
            this.memberIdColumn.HeaderText = "Member Id";
            this.memberIdColumn.Name = "memberIdColumn";
            // 
            // due_dateColumn
            // 
            this.due_dateColumn.HeaderText = "Due Date";
            this.due_dateColumn.Name = "due_dateColumn";
            // 
            // start_dateColumn
            // 
            this.start_dateColumn.HeaderText = "Check Out Date";
            this.start_dateColumn.Name = "start_dateColumn";
            // 
            // SaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 622);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.sqlButton);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.createNewMemButton);
            this.Name = "SaleForm";
            this.Text = "Sale";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SaleForm_FormClosed);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.queryResultGrid)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rentalDataGrid)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memberResultGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.furnitureItemsDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button completeSaleButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Button createNewMemButton;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.ComboBox searchCategoriesComboBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label searchBy;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView queryResultGrid;
        private System.Windows.Forms.Button sqlButton;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView memberResultGrid;
        private System.Windows.Forms.Button memberSearchButton;
        private System.Windows.Forms.TextBox memberPhoneSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView rentalDataGrid;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView furnitureItemsDataGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rental_numberColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesPersonColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn due_dateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn start_dateColumn;
    }
}

