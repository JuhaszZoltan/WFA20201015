namespace WFA20201015
{
    partial class FrmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTurazok = new System.Windows.Forms.DataGridView();
            this.btnUj = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFrissites = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pbSadCat = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurazok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSadCat)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Természetjárók nyilvántartása";
            // 
            // dgvTurazok
            // 
            this.dgvTurazok.AllowUserToAddRows = false;
            this.dgvTurazok.AllowUserToDeleteRows = false;
            this.dgvTurazok.AllowUserToResizeColumns = false;
            this.dgvTurazok.AllowUserToResizeRows = false;
            this.dgvTurazok.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTurazok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTurazok.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvTurazok.Location = new System.Drawing.Point(12, 142);
            this.dgvTurazok.Name = "dgvTurazok";
            this.dgvTurazok.RowHeadersVisible = false;
            this.dgvTurazok.Size = new System.Drawing.Size(577, 181);
            this.dgvTurazok.TabIndex = 1;
            // 
            // btnUj
            // 
            this.btnUj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUj.Location = new System.Drawing.Point(12, 342);
            this.btnUj.Name = "btnUj";
            this.btnUj.Size = new System.Drawing.Size(252, 48);
            this.btnUj.TabIndex = 2;
            this.btnUj.Text = "Új személy felvétele";
            this.btnUj.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(362, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "A nyilvántartásban szereplő túrázók adatai:";
            // 
            // btnFrissites
            // 
            this.btnFrissites.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnFrissites.Location = new System.Drawing.Point(337, 342);
            this.btnFrissites.Name = "btnFrissites";
            this.btnFrissites.Size = new System.Drawing.Size(252, 48);
            this.btnFrissites.TabIndex = 2;
            this.btnFrissites.Text = "Adatok frissítése";
            this.btnFrissites.UseVisualStyleBackColor = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Azonosító";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Vezetéknév";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Keresztnév";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Város";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Telefonszám";
            this.Column5.Name = "Column5";
            // 
            // pbSadCat
            // 
            this.pbSadCat.Image = global::WFA20201015.Properties.Resources.rndimage;
            this.pbSadCat.Location = new System.Drawing.Point(411, 12);
            this.pbSadCat.Name = "pbSadCat";
            this.pbSadCat.Size = new System.Drawing.Size(178, 115);
            this.pbSadCat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSadCat.TabIndex = 3;
            this.pbSadCat.TabStop = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 401);
            this.Controls.Add(this.pbSadCat);
            this.Controls.Add(this.btnFrissites);
            this.Controls.Add(this.btnUj);
            this.Controls.Add(this.dgvTurazok);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmMain";
            this.Text = "Túra nyilvántartó program";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurazok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSadCat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTurazok;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button btnUj;
        private System.Windows.Forms.PictureBox pbSadCat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFrissites;
    }
}

