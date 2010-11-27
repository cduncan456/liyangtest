namespace MemberInfo
{
    partial class adminQueryInterface
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
            this.sqlStatementBox = new System.Windows.Forms.RichTextBox();
            this.errorTextBox = new System.Windows.Forms.RichTextBox();
            this.runQueryButton = new System.Windows.Forms.Button();
            this.resultDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.resultDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // sqlStatementBox
            // 
            this.sqlStatementBox.Location = new System.Drawing.Point(12, 128);
            this.sqlStatementBox.Name = "sqlStatementBox";
            this.sqlStatementBox.Size = new System.Drawing.Size(584, 127);
            this.sqlStatementBox.TabIndex = 0;
            this.sqlStatementBox.Text = "";
            // 
            // errorTextBox
            // 
            this.errorTextBox.Location = new System.Drawing.Point(12, 12);
            this.errorTextBox.Name = "errorTextBox";
            this.errorTextBox.Size = new System.Drawing.Size(584, 96);
            this.errorTextBox.TabIndex = 2;
            this.errorTextBox.Text = "";
            this.errorTextBox.Visible = false;
            // 
            // runQueryButton
            // 
            this.runQueryButton.Location = new System.Drawing.Point(521, 261);
            this.runQueryButton.Name = "runQueryButton";
            this.runQueryButton.Size = new System.Drawing.Size(75, 23);
            this.runQueryButton.TabIndex = 3;
            this.runQueryButton.Text = "Go";
            this.runQueryButton.UseVisualStyleBackColor = true;
            this.runQueryButton.Click += new System.EventHandler(this.runQueryButton_Click);
            // 
            // resultDataGrid
            // 
            this.resultDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.resultDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultDataGrid.Location = new System.Drawing.Point(12, 290);
            this.resultDataGrid.Name = "resultDataGrid";
            this.resultDataGrid.Size = new System.Drawing.Size(584, 150);
            this.resultDataGrid.TabIndex = 4;
            // 
            // adminQueryInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 476);
            this.Controls.Add(this.resultDataGrid);
            this.Controls.Add(this.runQueryButton);
            this.Controls.Add(this.errorTextBox);
            this.Controls.Add(this.sqlStatementBox);
            this.Name = "adminQueryInterface";
            this.Text = "adminQueryInterface";
            ((System.ComponentModel.ISupportInitialize)(this.resultDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox sqlStatementBox;
        private System.Windows.Forms.RichTextBox errorTextBox;
        private System.Windows.Forms.Button runQueryButton;
        private System.Windows.Forms.DataGridView resultDataGrid;
    }
}