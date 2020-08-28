namespace FroggyStore
{
    partial class FormStore
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabBooks = new System.Windows.Forms.TabPage();
            this.tabGames = new System.Windows.Forms.TabPage();
            this.tabCheckout = new System.Windows.Forms.TabPage();
            this.listboxGames = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddGame = new System.Windows.Forms.Button();
            this.updownGame = new System.Windows.Forms.NumericUpDown();
            this.lblGameDescription = new System.Windows.Forms.Label();
            this.lblBookDescription = new System.Windows.Forms.Label();
            this.updownBook = new System.Windows.Forms.NumericUpDown();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listboxBooks = new System.Windows.Forms.ListBox();
            this.lblReceipt = new System.Windows.Forms.Label();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabBooks.SuspendLayout();
            this.tabGames.SuspendLayout();
            this.tabCheckout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updownGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updownBook)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabBooks);
            this.tabControl.Controls.Add(this.tabGames);
            this.tabControl.Controls.Add(this.tabCheckout);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Right;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(507, 328);
            this.tabControl.TabIndex = 0;
            // 
            // tabBooks
            // 
            this.tabBooks.Controls.Add(this.lblBookDescription);
            this.tabBooks.Controls.Add(this.updownBook);
            this.tabBooks.Controls.Add(this.btnAddBook);
            this.tabBooks.Controls.Add(this.label2);
            this.tabBooks.Controls.Add(this.listboxBooks);
            this.tabBooks.Location = new System.Drawing.Point(4, 34);
            this.tabBooks.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabBooks.Name = "tabBooks";
            this.tabBooks.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabBooks.Size = new System.Drawing.Size(499, 290);
            this.tabBooks.TabIndex = 0;
            this.tabBooks.Text = "Books";
            this.tabBooks.UseVisualStyleBackColor = true;
            // 
            // tabGames
            // 
            this.tabGames.Controls.Add(this.lblGameDescription);
            this.tabGames.Controls.Add(this.updownGame);
            this.tabGames.Controls.Add(this.btnAddGame);
            this.tabGames.Controls.Add(this.label1);
            this.tabGames.Controls.Add(this.listboxGames);
            this.tabGames.Location = new System.Drawing.Point(4, 34);
            this.tabGames.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabGames.Name = "tabGames";
            this.tabGames.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabGames.Size = new System.Drawing.Size(499, 290);
            this.tabGames.TabIndex = 1;
            this.tabGames.Text = "Games";
            this.tabGames.UseVisualStyleBackColor = true;
            // 
            // tabCheckout
            // 
            this.tabCheckout.Controls.Add(this.lblReceipt);
            this.tabCheckout.Controls.Add(this.btnCheckout);
            this.tabCheckout.Location = new System.Drawing.Point(4, 34);
            this.tabCheckout.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabCheckout.Name = "tabCheckout";
            this.tabCheckout.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabCheckout.Size = new System.Drawing.Size(499, 290);
            this.tabCheckout.TabIndex = 2;
            this.tabCheckout.Text = "Checkout";
            this.tabCheckout.UseVisualStyleBackColor = true;
            // 
            // listboxGames
            // 
            this.listboxGames.Dock = System.Windows.Forms.DockStyle.Right;
            this.listboxGames.FormattingEnabled = true;
            this.listboxGames.ItemHeight = 25;
            this.listboxGames.Location = new System.Drawing.Point(231, 6);
            this.listboxGames.Name = "listboxGames";
            this.listboxGames.Size = new System.Drawing.Size(262, 278);
            this.listboxGames.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quantity:";
            // 
            // btnAddGame
            // 
            this.btnAddGame.Location = new System.Drawing.Point(13, 222);
            this.btnAddGame.Name = "btnAddGame";
            this.btnAddGame.Size = new System.Drawing.Size(179, 53);
            this.btnAddGame.TabIndex = 2;
            this.btnAddGame.Text = "Add to Cart";
            this.btnAddGame.UseVisualStyleBackColor = true;
            // 
            // updownGame
            // 
            this.updownGame.Location = new System.Drawing.Point(125, 183);
            this.updownGame.Name = "updownGame";
            this.updownGame.Size = new System.Drawing.Size(67, 33);
            this.updownGame.TabIndex = 3;
            // 
            // lblGameDescription
            // 
            this.lblGameDescription.AutoSize = true;
            this.lblGameDescription.Location = new System.Drawing.Point(13, 10);
            this.lblGameDescription.Name = "lblGameDescription";
            this.lblGameDescription.Size = new System.Drawing.Size(67, 25);
            this.lblGameDescription.TabIndex = 4;
            this.lblGameDescription.Text = "label2";
            // 
            // lblBookDescription
            // 
            this.lblBookDescription.AutoSize = true;
            this.lblBookDescription.Location = new System.Drawing.Point(12, 10);
            this.lblBookDescription.Name = "lblBookDescription";
            this.lblBookDescription.Size = new System.Drawing.Size(67, 25);
            this.lblBookDescription.TabIndex = 9;
            this.lblBookDescription.Text = "label2";
            // 
            // updownBook
            // 
            this.updownBook.Location = new System.Drawing.Point(124, 183);
            this.updownBook.Name = "updownBook";
            this.updownBook.Size = new System.Drawing.Size(67, 33);
            this.updownBook.TabIndex = 8;
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(12, 222);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(179, 53);
            this.btnAddBook.TabIndex = 7;
            this.btnAddBook.Text = "Add to Cart";
            this.btnAddBook.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Quantity:";
            // 
            // listboxBooks
            // 
            this.listboxBooks.Dock = System.Windows.Forms.DockStyle.Right;
            this.listboxBooks.FormattingEnabled = true;
            this.listboxBooks.ItemHeight = 25;
            this.listboxBooks.Location = new System.Drawing.Point(231, 6);
            this.listboxBooks.Name = "listboxBooks";
            this.listboxBooks.Size = new System.Drawing.Size(262, 278);
            this.listboxBooks.TabIndex = 5;
            // 
            // lblReceipt
            // 
            this.lblReceipt.AutoSize = true;
            this.lblReceipt.Location = new System.Drawing.Point(12, 10);
            this.lblReceipt.Name = "lblReceipt";
            this.lblReceipt.Size = new System.Drawing.Size(67, 25);
            this.lblReceipt.TabIndex = 9;
            this.lblReceipt.Text = "label2";
            // 
            // btnCheckout
            // 
            this.btnCheckout.Location = new System.Drawing.Point(12, 222);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(179, 53);
            this.btnCheckout.TabIndex = 7;
            this.btnCheckout.Text = "Add to Cart";
            this.btnCheckout.UseVisualStyleBackColor = true;
            // 
            // FormStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 328);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FormStore";
            this.Text = "Froggy\'s Book & Game Store";
            this.tabControl.ResumeLayout(false);
            this.tabBooks.ResumeLayout(false);
            this.tabBooks.PerformLayout();
            this.tabGames.ResumeLayout(false);
            this.tabGames.PerformLayout();
            this.tabCheckout.ResumeLayout(false);
            this.tabCheckout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updownGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updownBook)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabBooks;
        private System.Windows.Forms.TabPage tabGames;
        private System.Windows.Forms.TabPage tabCheckout;
        private System.Windows.Forms.Label lblBookDescription;
        private System.Windows.Forms.NumericUpDown updownBook;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listboxBooks;
        private System.Windows.Forms.Label lblGameDescription;
        private System.Windows.Forms.NumericUpDown updownGame;
        private System.Windows.Forms.Button btnAddGame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listboxGames;
        private System.Windows.Forms.Label lblReceipt;
        private System.Windows.Forms.Button btnCheckout;
    }
}

