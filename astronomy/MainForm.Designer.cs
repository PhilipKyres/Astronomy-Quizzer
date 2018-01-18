namespace astronomy
{
    partial class MainQuizForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainQuizForm));
            this.done = new System.Windows.Forms.Button();
            this.choicesGridView = new System.Windows.Forms.DataGridView();
            this.questionTextBox = new System.Windows.Forms.RichTextBox();
            this.rightLabel = new System.Windows.Forms.Label();
            this.wrongLabel = new System.Windows.Forms.Label();
            this.totalsLabel = new System.Windows.Forms.Label();
            this.reviewBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.choicesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // done
            // 
            this.done.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.done.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.done.Location = new System.Drawing.Point(12, 318);
            this.done.Name = "done";
            this.done.Size = new System.Drawing.Size(140, 33);
            this.done.TabIndex = 2;
            this.done.Text = "Next";
            this.done.UseVisualStyleBackColor = true;
            this.done.Click += new System.EventHandler(this.done_Click);
            // 
            // choicesGridView
            // 
            this.choicesGridView.AllowUserToAddRows = false;
            this.choicesGridView.AllowUserToDeleteRows = false;
            this.choicesGridView.AllowUserToResizeColumns = false;
            this.choicesGridView.AllowUserToResizeRows = false;
            this.choicesGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.choicesGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.choicesGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.choicesGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.choicesGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.choicesGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.choicesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.choicesGridView.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.choicesGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.choicesGridView.Location = new System.Drawing.Point(13, 118);
            this.choicesGridView.MultiSelect = false;
            this.choicesGridView.Name = "choicesGridView";
            this.choicesGridView.ReadOnly = true;
            this.choicesGridView.RowHeadersVisible = false;
            this.choicesGridView.Size = new System.Drawing.Size(764, 194);
            this.choicesGridView.TabIndex = 4;
            // 
            // questionTextBox
            // 
            this.questionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.questionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.questionTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.questionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionTextBox.Location = new System.Drawing.Point(13, 13);
            this.questionTextBox.Name = "questionTextBox";
            this.questionTextBox.ReadOnly = true;
            this.questionTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.questionTextBox.Size = new System.Drawing.Size(763, 99);
            this.questionTextBox.TabIndex = 5;
            this.questionTextBox.Text = resources.GetString("questionTextBox.Text");
            this.questionTextBox.Enter += new System.EventHandler(this.questionTextBox_Enter);
            // 
            // rightLabel
            // 
            this.rightLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.rightLabel.AutoSize = true;
            this.rightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rightLabel.Location = new System.Drawing.Point(508, 323);
            this.rightLabel.Name = "rightLabel";
            this.rightLabel.Size = new System.Drawing.Size(44, 31);
            this.rightLabel.TabIndex = 6;
            this.rightLabel.Text = "35";
            // 
            // wrongLabel
            // 
            this.wrongLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.wrongLabel.AutoSize = true;
            this.wrongLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wrongLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.wrongLabel.Location = new System.Drawing.Point(558, 323);
            this.wrongLabel.Name = "wrongLabel";
            this.wrongLabel.Size = new System.Drawing.Size(44, 31);
            this.wrongLabel.TabIndex = 7;
            this.wrongLabel.Text = "10";
            // 
            // totalsLabel
            // 
            this.totalsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.totalsLabel.AutoSize = true;
            this.totalsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalsLabel.ForeColor = System.Drawing.Color.Black;
            this.totalsLabel.Location = new System.Drawing.Point(620, 323);
            this.totalsLabel.Name = "totalsLabel";
            this.totalsLabel.Size = new System.Drawing.Size(156, 31);
            this.totalsLabel.TabIndex = 8;
            this.totalsLabel.Text = "453 of 1006";
            // 
            // reviewBtn
            // 
            this.reviewBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.reviewBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reviewBtn.Location = new System.Drawing.Point(314, 318);
            this.reviewBtn.Name = "reviewBtn";
            this.reviewBtn.Size = new System.Drawing.Size(140, 33);
            this.reviewBtn.TabIndex = 9;
            this.reviewBtn.Text = "Review Incorrect";
            this.reviewBtn.UseVisualStyleBackColor = true;
            this.reviewBtn.Click += new System.EventHandler(this.reviewBtn_Click);
            // 
            // MainQuizForm
            // 
            this.AcceptButton = this.done;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 363);
            this.Controls.Add(this.reviewBtn);
            this.Controls.Add(this.totalsLabel);
            this.Controls.Add(this.wrongLabel);
            this.Controls.Add(this.rightLabel);
            this.Controls.Add(this.questionTextBox);
            this.Controls.Add(this.choicesGridView);
            this.Controls.Add(this.done);
            this.KeyPreview = true;
            this.Name = "MainQuizForm";
            this.Text = "Astronomy";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyPress);
            ((System.ComponentModel.ISupportInitialize)(this.choicesGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button done;
        private System.Windows.Forms.DataGridView choicesGridView;
        private System.Windows.Forms.RichTextBox questionTextBox;
        private System.Windows.Forms.Label rightLabel;
        private System.Windows.Forms.Label wrongLabel;
        private System.Windows.Forms.Label totalsLabel;
        private System.Windows.Forms.Button reviewBtn;
    }
}

