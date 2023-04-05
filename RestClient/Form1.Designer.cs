namespace RestClient
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            textBoxRestURL = new TextBox();
            buttonGO = new Button();
            textBoxResponse = new TextBox();
            label1 = new Label();
            label2 = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.359375F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 81.640625F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 0);
            tableLayoutPanel1.Controls.Add(textBoxResponse, 1, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.454545F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 89.5454559F));
            tableLayoutPanel1.Size = new Size(486, 351);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75.84541F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.1545887F));
            tableLayoutPanel2.Controls.Add(textBoxRestURL, 0, 0);
            tableLayoutPanel2.Controls.Add(buttonGO, 1, 0);
            tableLayoutPanel2.Location = new Point(92, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(391, 30);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // textBoxRestURL
            // 
            textBoxRestURL.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxRestURL.Location = new Point(3, 3);
            textBoxRestURL.Multiline = true;
            textBoxRestURL.Name = "textBoxRestURL";
            textBoxRestURL.Size = new Size(290, 24);
            textBoxRestURL.TabIndex = 0;
            // 
            // buttonGO
            // 
            buttonGO.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonGO.Location = new Point(299, 3);
            buttonGO.Name = "buttonGO";
            buttonGO.Size = new Size(89, 24);
            buttonGO.TabIndex = 1;
            buttonGO.Text = "GO";
            buttonGO.UseVisualStyleBackColor = true;
            buttonGO.Click += buttonGO_Click;
            // 
            // textBoxResponse
            // 
            textBoxResponse.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxResponse.Location = new Point(92, 39);
            textBoxResponse.Multiline = true;
            textBoxResponse.Name = "textBoxResponse";
            textBoxResponse.ScrollBars = ScrollBars.Vertical;
            textBoxResponse.Size = new Size(391, 309);
            textBoxResponse.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(83, 36);
            label1.TabIndex = 2;
            label1.Text = "Request URL :";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(3, 36);
            label2.Name = "label2";
            label2.Size = new Size(83, 315);
            label2.TabIndex = 3;
            label2.Text = "Response :";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(510, 375);
            Controls.Add(tableLayoutPanel1);
            MinimumSize = new Size(526, 414);
            Name = "Form1";
            Text = "RestClient";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox textBoxRestURL;
        private TextBox textBoxResponse;
        private Label label1;
        private Label label2;
        private Button buttonGO;
    }
}