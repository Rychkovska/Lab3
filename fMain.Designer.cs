namespace Lab3
{
	partial class fMain
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
			this.tbBooksInfo = new System.Windows.Forms.TextBox();
			this.btnAddBook = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// tbBooksInfo
			// 
			this.tbBooksInfo.Location = new System.Drawing.Point(12, 12);
			this.tbBooksInfo.Multiline = true;
			this.tbBooksInfo.Name = "tbBooksInfo";
			this.tbBooksInfo.ReadOnly = true;
			this.tbBooksInfo.Size = new System.Drawing.Size(669, 354);
			this.tbBooksInfo.TabIndex = 0;
			// 
			// btnAddBook
			// 
			this.btnAddBook.Location = new System.Drawing.Point(694, 12);
			this.btnAddBook.Name = "btnAddBook";
			this.btnAddBook.Size = new System.Drawing.Size(94, 24);
			this.btnAddBook.TabIndex = 1;
			this.btnAddBook.Text = "Додати книгу";
			this.btnAddBook.UseVisualStyleBackColor = true;
			this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
			// 
			// btnClose
			// 
			this.btnClose.Location = new System.Drawing.Point(694, 342);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(94, 24);
			this.btnClose.TabIndex = 2;
			this.btnClose.Text = "Закрити";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// fMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 379);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnAddBook);
			this.Controls.Add(this.tbBooksInfo);
			this.MaximizeBox = false;
			this.Name = "fMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Лабораторна робота №3";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tbBooksInfo;
		private System.Windows.Forms.Button btnAddBook;
		private System.Windows.Forms.Button btnClose;
	}
}

