namespace MegaDesk_Coates
{
    partial class MainMenu
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
            this.AddQuotebutton = new System.Windows.Forms.Button();
            this.viewQuote = new System.Windows.Forms.Button();
            this.searchQuotes = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.deskPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.deskPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // AddQuotebutton
            // 
            this.AddQuotebutton.BackColor = System.Drawing.SystemColors.GrayText;
            this.AddQuotebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddQuotebutton.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddQuotebutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddQuotebutton.Location = new System.Drawing.Point(38, 43);
            this.AddQuotebutton.Name = "AddQuotebutton";
            this.AddQuotebutton.Padding = new System.Windows.Forms.Padding(5);
            this.AddQuotebutton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AddQuotebutton.Size = new System.Drawing.Size(190, 45);
            this.AddQuotebutton.TabIndex = 0;
            this.AddQuotebutton.Text = "Add New Quote";
            this.AddQuotebutton.UseVisualStyleBackColor = false;
            this.AddQuotebutton.Click += new System.EventHandler(this.AddQuotebutton_Click);
            // 
            // viewQuote
            // 
            this.viewQuote.BackColor = System.Drawing.SystemColors.GrayText;
            this.viewQuote.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewQuote.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewQuote.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.viewQuote.Location = new System.Drawing.Point(38, 117);
            this.viewQuote.Name = "viewQuote";
            this.viewQuote.Padding = new System.Windows.Forms.Padding(5);
            this.viewQuote.Size = new System.Drawing.Size(190, 45);
            this.viewQuote.TabIndex = 1;
            this.viewQuote.Text = "View Quotes";
            this.viewQuote.UseVisualStyleBackColor = false;
            this.viewQuote.Click += new System.EventHandler(this.viewQuote_Click);
            // 
            // searchQuotes
            // 
            this.searchQuotes.BackColor = System.Drawing.SystemColors.GrayText;
            this.searchQuotes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchQuotes.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchQuotes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.searchQuotes.Location = new System.Drawing.Point(38, 190);
            this.searchQuotes.Name = "searchQuotes";
            this.searchQuotes.Padding = new System.Windows.Forms.Padding(5);
            this.searchQuotes.Size = new System.Drawing.Size(190, 45);
            this.searchQuotes.TabIndex = 2;
            this.searchQuotes.Text = "Search Quotes";
            this.searchQuotes.UseVisualStyleBackColor = false;
            this.searchQuotes.Click += new System.EventHandler(this.searchQuotes_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.SystemColors.GrayText;
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Exit.Location = new System.Drawing.Point(402, 319);
            this.Exit.Name = "Exit";
            this.Exit.Padding = new System.Windows.Forms.Padding(5);
            this.Exit.Size = new System.Drawing.Size(128, 44);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // deskPicture
            // 
            this.deskPicture.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deskPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.deskPicture.Image = global::MegaDesk_Coates.Properties.Resources.desk;
            this.deskPicture.Location = new System.Drawing.Point(306, 43);
            this.deskPicture.Name = "deskPicture";
            this.deskPicture.Size = new System.Drawing.Size(224, 226);
            this.deskPicture.TabIndex = 4;
            this.deskPicture.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 396);
            this.Controls.Add(this.deskPicture);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.searchQuotes);
            this.Controls.Add(this.viewQuote);
            this.Controls.Add(this.AddQuotebutton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainMenu";
            this.Text = "Mega Desk";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.deskPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddQuotebutton;
        private System.Windows.Forms.Button viewQuote;
        private System.Windows.Forms.Button searchQuotes;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.PictureBox deskPicture;
    }
}

