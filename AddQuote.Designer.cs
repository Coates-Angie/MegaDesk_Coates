namespace MegaDesk_Coates
{
    partial class AddQuote
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
            this.components = new System.ComponentModel.Container();
            this.close = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Width = new System.Windows.Forms.TextBox();
            this.enterWidth = new System.Windows.Forms.Label();
            this.Welcome = new System.Windows.Forms.Label();
            this.Depth = new System.Windows.Forms.TextBox();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fullName = new System.Windows.Forms.TextBox();
            this.CustNameLabel = new System.Windows.Forms.TextBox();
            this.InfoLabel = new System.Windows.Forms.RichTextBox();
            this.submitAddQuote = new System.Windows.Forms.Button();
            this.numDrawers = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.SystemColors.GrayText;
            this.close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.close.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.close.Location = new System.Drawing.Point(644, 376);
            this.close.Name = "close";
            this.close.Padding = new System.Windows.Forms.Padding(5);
            this.close.Size = new System.Drawing.Size(129, 49);
            this.close.TabIndex = 0;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // Width
            // 
            this.Width.AcceptsReturn = true;
            this.Width.AcceptsTab = true;
            this.Width.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Width.Location = new System.Drawing.Point(66, 354);
            this.Width.Margin = new System.Windows.Forms.Padding(10);
            this.Width.Name = "Width";
            this.Width.Size = new System.Drawing.Size(145, 26);
            this.Width.TabIndex = 3;
            this.Width.Text = "in.";
            this.Width.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // enterWidth
            // 
            this.enterWidth.AutoSize = true;
            this.enterWidth.BackColor = System.Drawing.SystemColors.GrayText;
            this.enterWidth.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.enterWidth.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterWidth.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.enterWidth.Location = new System.Drawing.Point(67, 325);
            this.enterWidth.Name = "enterWidth";
            this.enterWidth.Padding = new System.Windows.Forms.Padding(3);
            this.enterWidth.Size = new System.Drawing.Size(144, 26);
            this.enterWidth.TabIndex = 4;
            this.enterWidth.Text = "Enter Desk Width";
            // 
            // Welcome
            // 
            this.Welcome.AutoSize = true;
            this.Welcome.BackColor = System.Drawing.SystemColors.GrayText;
            this.Welcome.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Welcome.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Welcome.Location = new System.Drawing.Point(67, 255);
            this.Welcome.Name = "Welcome";
            this.Welcome.Padding = new System.Windows.Forms.Padding(3);
            this.Welcome.Size = new System.Drawing.Size(146, 26);
            this.Welcome.TabIndex = 5;
            this.Welcome.Text = "Enter Desk Depth";
            // 
            // Depth
            // 
            this.Depth.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Depth.Location = new System.Drawing.Point(67, 284);
            this.Depth.Name = "Depth";
            this.Depth.Size = new System.Drawing.Size(145, 26);
            this.Depth.TabIndex = 6;
            this.Depth.Text = "in. ";
            this.Depth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Depth.TextChanged += new System.EventHandler(this.Depth_TextChanged);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // fullName
            // 
            this.fullName.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullName.Location = new System.Drawing.Point(67, 152);
            this.fullName.Name = "fullName";
            this.fullName.Size = new System.Drawing.Size(179, 26);
            this.fullName.TabIndex = 9;
            // 
            // CustNameLabel
            // 
            this.CustNameLabel.BackColor = System.Drawing.SystemColors.GrayText;
            this.CustNameLabel.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustNameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CustNameLabel.Location = new System.Drawing.Point(67, 120);
            this.CustNameLabel.Name = "CustNameLabel";
            this.CustNameLabel.Size = new System.Drawing.Size(179, 26);
            this.CustNameLabel.TabIndex = 10;
            this.CustNameLabel.Text = "Customers Full Name";
            // 
            // InfoLabel
            // 
            this.InfoLabel.BackColor = System.Drawing.SystemColors.GrayText;
            this.InfoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InfoLabel.CausesValidation = false;
            this.InfoLabel.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.InfoLabel.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.InfoLabel.Location = new System.Drawing.Point(67, 27);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(422, 55);
            this.InfoLabel.TabIndex = 11;
            this.InfoLabel.Text = "Please enter the following information to add a quote:";
            // 
            // submitAddQuote
            // 
            this.submitAddQuote.BackColor = System.Drawing.SystemColors.GrayText;
            this.submitAddQuote.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitAddQuote.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.submitAddQuote.Location = new System.Drawing.Point(387, 333);
            this.submitAddQuote.Name = "submitAddQuote";
            this.submitAddQuote.Size = new System.Drawing.Size(102, 47);
            this.submitAddQuote.TabIndex = 12;
            this.submitAddQuote.Text = "Submit";
            this.submitAddQuote.UseVisualStyleBackColor = false;
            // 
            // numDrawers
            // 
            this.numDrawers.AllowDrop = true;
            this.numDrawers.BackColor = System.Drawing.SystemColors.GrayText;
            this.numDrawers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.numDrawers.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDrawers.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.numDrawers.FormattingEnabled = true;
            this.numDrawers.ItemHeight = 18;
            this.numDrawers.Items.AddRange(new object[] {
            "0",
            "1 drawer -  $50.00",
            "2 drawers - $100.00",
            "3 drawers - $150.00",
            "4 drawers - $200.00",
            "5 drawers - $250.00",
            "6 drawers - $300.00",
            "7 drawers - $350.00"});
            this.numDrawers.Location = new System.Drawing.Point(67, 206);
            this.numDrawers.Margin = new System.Windows.Forms.Padding(7, 5, 5, 7);
            this.numDrawers.Name = "numDrawers";
            this.numDrawers.Size = new System.Drawing.Size(178, 26);
            this.numDrawers.TabIndex = 13;
            this.numDrawers.Text = "Number of Drawers";
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CancelButton = this.close;
            this.ClientSize = new System.Drawing.Size(526, 409);
            this.Controls.Add(this.numDrawers);
            this.Controls.Add(this.submitAddQuote);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.CustNameLabel);
            this.Controls.Add(this.fullName);
            this.Controls.Add(this.Depth);
            this.Controls.Add(this.Welcome);
            this.Controls.Add(this.enterWidth);
            this.Controls.Add(this.Width);
            this.Controls.Add(this.close);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddQuote";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Add  Quote";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button close;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.TextBox Width;
        private System.Windows.Forms.Label enterWidth;
        private System.Windows.Forms.Label Welcome;
        private System.Windows.Forms.TextBox Depth;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.TextBox fullName;
        private System.Windows.Forms.TextBox CustNameLabel;
        private System.Windows.Forms.RichTextBox InfoLabel;
        private System.Windows.Forms.Button submitAddQuote;
        private System.Windows.Forms.ComboBox numDrawers;
    }
}