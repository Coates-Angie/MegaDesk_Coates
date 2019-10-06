namespace MegaDesk_Coates
{
    partial class ViewAllQuotes
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
            this.closeViewQuotes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // closeViewQuotes
            // 
            this.closeViewQuotes.BackColor = System.Drawing.SystemColors.GrayText;
            this.closeViewQuotes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeViewQuotes.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeViewQuotes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.closeViewQuotes.Location = new System.Drawing.Point(644, 376);
            this.closeViewQuotes.Name = "closeViewQuotes";
            this.closeViewQuotes.Size = new System.Drawing.Size(129, 49);
            this.closeViewQuotes.TabIndex = 0;
            this.closeViewQuotes.Text = "Close";
            this.closeViewQuotes.UseVisualStyleBackColor = false;
            this.closeViewQuotes.Click += new System.EventHandler(this.closeViewQuotes_Click);
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.closeViewQuotes);
            this.Name = "ViewAllQuotes";
            this.Text = "ViewAllQuotes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button closeViewQuotes;
    }
}