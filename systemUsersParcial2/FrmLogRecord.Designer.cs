
namespace systemUsersParcial2
{
    partial class FrmLogRecord
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
            this.dgvLogRecord = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogRecord)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLogRecord
            // 
            this.dgvLogRecord.BackgroundColor = System.Drawing.Color.White;
            this.dgvLogRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLogRecord.Location = new System.Drawing.Point(27, 91);
            this.dgvLogRecord.Name = "dgvLogRecord";
            this.dgvLogRecord.Size = new System.Drawing.Size(745, 314);
            this.dgvLogRecord.TabIndex = 0;
            // 
            // FrmLogRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvLogRecord);
            this.Name = "FrmLogRecord";
            this.Text = "Log-in Record";
            this.Load += new System.EventHandler(this.FrmLogRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogRecord)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLogRecord;
    }
}