namespace MegaDesk_Coates
{
    partial class SearchQuotes
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
            this.closeSearchQuotes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // closeSearchQuotes
            // 
            this.closeSearchQuotes.BackColor = System.Drawing.SystemColors.GrayText;
            this.closeSearchQuotes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeSearchQuotes.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeSearchQuotes.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeSearchQuotes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.closeSearchQuotes.Location = new System.Drawing.Point(644, 376);
            this.closeSearchQuotes.Name = "closeSearchQuotes";
            this.closeSearchQuotes.Padding = new System.Windows.Forms.Padding(5);
            this.closeSearchQuotes.Size = new System.Drawing.Size(129, 49);
            this.closeSearchQuotes.TabIndex = 0;
            this.closeSearchQuotes.Text = "Close";
            this.closeSearchQuotes.UseVisualStyleBackColor = false;
            this.closeSearchQuotes.Click += new System.EventHandler(this.closeSearchQuotes_Click);
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.closeSearchQuotes;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.closeSearchQuotes);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchQuotes";
            this.Text = "SearchQuotes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button closeSearchQuotes;
    }
}