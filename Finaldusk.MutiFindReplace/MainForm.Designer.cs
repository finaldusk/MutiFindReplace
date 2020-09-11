namespace Finaldusk.MutiFindReplace
{
    partial class MainForm
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
            this.textBoxTarget = new System.Windows.Forms.TextBox();
            this.label_Tips = new System.Windows.Forms.Label();
            this.ColumnFind = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnReplace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_DoIt = new System.Windows.Forms.Button();
            this.button_paste = new System.Windows.Forms.Button();
            this.dataGridViewKeyValues = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKeyValues)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxTarget
            // 
            this.textBoxTarget.Location = new System.Drawing.Point(296, 35);
            this.textBoxTarget.Multiline = true;
            this.textBoxTarget.Name = "textBoxTarget";
            this.textBoxTarget.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxTarget.Size = new System.Drawing.Size(492, 403);
            this.textBoxTarget.TabIndex = 1;
            // 
            // label_Tips
            // 
            this.label_Tips.AutoSize = true;
            this.label_Tips.Location = new System.Drawing.Point(15, 6);
            this.label_Tips.Name = "label_Tips";
            this.label_Tips.Size = new System.Drawing.Size(270, 17);
            this.label_Tips.TabIndex = 2;
            this.label_Tips.Text = "Tips:You can copy from Excel and paste here";
            // 
            // ColumnFind
            // 
            this.ColumnFind.HeaderText = "Find";
            this.ColumnFind.Name = "ColumnFind";
            // 
            // ColumnReplace
            // 
            this.ColumnReplace.HeaderText = "Replace";
            this.ColumnReplace.Name = "ColumnReplace";
            // 
            // button_DoIt
            // 
            this.button_DoIt.Location = new System.Drawing.Point(712, 6);
            this.button_DoIt.Name = "button_DoIt";
            this.button_DoIt.Size = new System.Drawing.Size(75, 23);
            this.button_DoIt.TabIndex = 3;
            this.button_DoIt.Text = "Do It !";
            this.button_DoIt.UseVisualStyleBackColor = true;
            this.button_DoIt.Click += new System.EventHandler(this.button_DoIt_Click);
            // 
            // button_paste
            // 
            this.button_paste.Location = new System.Drawing.Point(584, 6);
            this.button_paste.Name = "button_paste";
            this.button_paste.Size = new System.Drawing.Size(122, 23);
            this.button_paste.TabIndex = 5;
            this.button_paste.Text = "Fill with clipboard";
            this.button_paste.UseVisualStyleBackColor = true;
            this.button_paste.Click += new System.EventHandler(this.button_paste_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            // 
            // dataGridViewKeyValues
            // 
            this.dataGridViewKeyValues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKeyValues.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnFind,
            this.ColumnReplace});
            this.dataGridViewKeyValues.Location = new System.Drawing.Point(12, 35);
            this.dataGridViewKeyValues.Name = "dataGridViewKeyValues";
            this.dataGridViewKeyValues.Size = new System.Drawing.Size(278, 403);
            this.dataGridViewKeyValues.TabIndex = 0;
            this.dataGridViewKeyValues.Text = "dataGridView1";
            this.dataGridViewKeyValues.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.dataGridViewKeyValues_PreviewKeyDown);
            this.Controls.Add(this.button_paste);
            this.Controls.Add(this.button_DoIt);
            this.Controls.Add(this.label_Tips);
            this.Controls.Add(this.textBoxTarget);
            this.Controls.Add(this.dataGridViewKeyValues);
            this.Name = "MainForm";
            this.Text = "MutiFindREplace";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKeyValues)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTarget;
        private System.Windows.Forms.Label label_Tips;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFind;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnReplace;
        private System.Windows.Forms.Button button_DoIt;
        private System.Windows.Forms.Button button_paste;
        private System.Windows.Forms.DataGridView dataGridViewKeyValues;
    }
}

