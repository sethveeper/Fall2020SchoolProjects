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
            this.updownBook = new System.Windows.Forms.NumericUpDown();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listboxBooks = new System.Windows.Forms.ListBox();
            this.tabGames = new System.Windows.Forms.TabPage();
            this.updownGame = new System.Windows.Forms.NumericUpDown();
            this.btnAddGame = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listboxGames = new System.Windows.Forms.ListBox();
            this.tabCheckout = new System.Windows.Forms.TabPage();
            this.textGameDescription = new System.Windows.Forms.TextBox();
            this.textBookDescription = new System.Windows.Forms.TextBox();
            this.listboxCart = new System.Windows.Forms.ListBox();
            this.tabControl.SuspendLayout();
            this.tabBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updownBook)).BeginInit();
            this.tabGames.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updownGame)).BeginInit();
            this.tabCheckout.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabBooks);
            this.tabControl.Controls.Add(this.tabGames);
            this.tabControl.Controls.Add(this.tabCheckout);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(6);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(866, 576);
            this.tabControl.TabIndex = 0;
            // 
            // tabBooks
            // 
            this.tabBooks.Controls.Add(this.textBookDescription);
            this.tabBooks.Controls.Add(this.updownBook);
            this.tabBooks.Controls.Add(this.btnAddBook);
            this.tabBooks.Controls.Add(this.label2);
            this.tabBooks.Controls.Add(this.listboxBooks);
            this.tabBooks.Location = new System.Drawing.Point(4, 34);
            this.tabBooks.Margin = new System.Windows.Forms.Padding(6);
            this.tabBooks.Name = "tabBooks";
            this.tabBooks.Padding = new System.Windows.Forms.Padding(6);
            this.tabBooks.Size = new System.Drawing.Size(858, 538);
            this.tabBooks.TabIndex = 0;
            this.tabBooks.Text = "Books";
            this.tabBooks.UseVisualStyleBackColor = true;
            // 
            // updownBook
            // 
            this.updownBook.Location = new System.Drawing.Point(120, 432);
            this.updownBook.Name = "updownBook";
            this.updownBook.Size = new System.Drawing.Size(67, 33);
            this.updownBook.TabIndex = 8;
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(8, 471);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(179, 53);
            this.btnAddBook.TabIndex = 7;
            this.btnAddBook.Text = "Add to Cart";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 436);
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
            this.listboxBooks.Location = new System.Drawing.Point(342, 6);
            this.listboxBooks.Name = "listboxBooks";
            this.listboxBooks.Size = new System.Drawing.Size(510, 526);
            this.listboxBooks.TabIndex = 5;
            this.listboxBooks.SelectedIndexChanged += new System.EventHandler(this.listboxBooks_SelectedIndexChanged);
            // 
            // tabGames
            // 
            this.tabGames.Controls.Add(this.textGameDescription);
            this.tabGames.Controls.Add(this.updownGame);
            this.tabGames.Controls.Add(this.btnAddGame);
            this.tabGames.Controls.Add(this.label1);
            this.tabGames.Controls.Add(this.listboxGames);
            this.tabGames.Location = new System.Drawing.Point(4, 34);
            this.tabGames.Margin = new System.Windows.Forms.Padding(6);
            this.tabGames.Name = "tabGames";
            this.tabGames.Padding = new System.Windows.Forms.Padding(6);
            this.tabGames.Size = new System.Drawing.Size(858, 538);
            this.tabGames.TabIndex = 1;
            this.tabGames.Text = "Games";
            this.tabGames.UseVisualStyleBackColor = true;
            // 
            // updownGame
            // 
            this.updownGame.Location = new System.Drawing.Point(130, 435);
            this.updownGame.Name = "updownGame";
            this.updownGame.Size = new System.Drawing.Size(67, 33);
            this.updownGame.TabIndex = 3;
            // 
            // btnAddGame
            // 
            this.btnAddGame.Location = new System.Drawing.Point(18, 474);
            this.btnAddGame.Name = "btnAddGame";
            this.btnAddGame.Size = new System.Drawing.Size(179, 53);
            this.btnAddGame.TabIndex = 2;
            this.btnAddGame.Text = "Add to Cart";
            this.btnAddGame.UseVisualStyleBackColor = true;
            this.btnAddGame.Click += new System.EventHandler(this.btnAddGame_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 439);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quantity:";
            // 
            // listboxGames
            // 
            this.listboxGames.Dock = System.Windows.Forms.DockStyle.Right;
            this.listboxGames.FormattingEnabled = true;
            this.listboxGames.ItemHeight = 25;
            this.listboxGames.Location = new System.Drawing.Point(342, 6);
            this.listboxGames.Name = "listboxGames";
            this.listboxGames.Size = new System.Drawing.Size(510, 526);
            this.listboxGames.TabIndex = 0;
            this.listboxGames.SelectedIndexChanged += new System.EventHandler(this.listboxGames_SelectedIndexChanged);
            // 
            // tabCheckout
            // 
            this.tabCheckout.Controls.Add(this.listboxCart);
            this.tabCheckout.Location = new System.Drawing.Point(4, 34);
            this.tabCheckout.Margin = new System.Windows.Forms.Padding(6);
            this.tabCheckout.Name = "tabCheckout";
            this.tabCheckout.Padding = new System.Windows.Forms.Padding(6);
            this.tabCheckout.Size = new System.Drawing.Size(858, 538);
            this.tabCheckout.TabIndex = 2;
            this.tabCheckout.Text = "Checkout";
            this.tabCheckout.UseVisualStyleBackColor = true;
            // 
            // textGameDescription
            // 
            this.textGameDescription.BackColor = System.Drawing.SystemColors.Window;
            this.textGameDescription.Location = new System.Drawing.Point(18, 6);
            this.textGameDescription.Multiline = true;
            this.textGameDescription.Name = "textGameDescription";
            this.textGameDescription.ReadOnly = true;
            this.textGameDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textGameDescription.Size = new System.Drawing.Size(318, 419);
            this.textGameDescription.TabIndex = 4;
            // 
            // textBookDescription
            // 
            this.textBookDescription.BackColor = System.Drawing.SystemColors.Window;
            this.textBookDescription.Location = new System.Drawing.Point(18, 6);
            this.textBookDescription.Multiline = true;
            this.textBookDescription.Name = "textBookDescription";
            this.textBookDescription.ReadOnly = true;
            this.textBookDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBookDescription.Size = new System.Drawing.Size(318, 419);
            this.textBookDescription.TabIndex = 9;
            // 
            // listboxCart
            // 
            this.listboxCart.Dock = System.Windows.Forms.DockStyle.Top;
            this.listboxCart.FormattingEnabled = true;
            this.listboxCart.ItemHeight = 25;
            this.listboxCart.Location = new System.Drawing.Point(6, 6);
            this.listboxCart.Name = "listboxCart";
            this.listboxCart.Size = new System.Drawing.Size(846, 454);
            this.listboxCart.TabIndex = 0;
            // 
            // FormStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 576);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormStore";
            this.Text = "Froggy\'s Book & Game Store";
            this.Load += new System.EventHandler(this.FormStore_Load);
            this.tabControl.ResumeLayout(false);
            this.tabBooks.ResumeLayout(false);
            this.tabBooks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updownBook)).EndInit();
            this.tabGames.ResumeLayout(false);
            this.tabGames.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updownGame)).EndInit();
            this.tabCheckout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabBooks;
        private System.Windows.Forms.TabPage tabGames;
        private System.Windows.Forms.TabPage tabCheckout;
        private System.Windows.Forms.NumericUpDown updownBook;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listboxBooks;
        private System.Windows.Forms.NumericUpDown updownGame;
        private System.Windows.Forms.Button btnAddGame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listboxGames;
        private System.Windows.Forms.TextBox textGameDescription;
        private System.Windows.Forms.TextBox textBookDescription;
        private System.Windows.Forms.ListBox listboxCart;
    }
}

