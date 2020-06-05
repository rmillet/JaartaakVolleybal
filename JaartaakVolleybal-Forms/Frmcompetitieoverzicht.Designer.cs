namespace JaartaakVolleybal_Forms
{
    partial class Frmcompetitieoverzicht
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
            this.grdcompetitietabel = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdcompetitietabel)).BeginInit();
            this.SuspendLayout();
            // 
            // grdcompetitietabel
            // 
            this.grdcompetitietabel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdcompetitietabel.Location = new System.Drawing.Point(56, 12);
            this.grdcompetitietabel.Name = "grdcompetitietabel";
            this.grdcompetitietabel.Size = new System.Drawing.Size(713, 411);
            this.grdcompetitietabel.TabIndex = 0;
            // 
            // Frmcompetitieoverzicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grdcompetitietabel);
            this.Name = "Frmcompetitieoverzicht";
            this.Text = "Frmcompetitieoverzicht";
            this.Load += new System.EventHandler(this.Frmcompetitieoverzicht_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdcompetitietabel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdcompetitietabel;
    }
}