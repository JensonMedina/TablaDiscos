
namespace Principal
{
    partial class Papelera
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
            this.dgvPapelera = new System.Windows.Forms.DataGridView();
            this.pbxPapelera = new System.Windows.Forms.PictureBox();
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.btnEliminarFisico = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPapelera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPapelera)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPapelera
            // 
            this.dgvPapelera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPapelera.Location = new System.Drawing.Point(12, 41);
            this.dgvPapelera.Name = "dgvPapelera";
            this.dgvPapelera.Size = new System.Drawing.Size(487, 159);
            this.dgvPapelera.TabIndex = 0;
            // 
            // pbxPapelera
            // 
            this.pbxPapelera.Location = new System.Drawing.Point(517, 41);
            this.pbxPapelera.Name = "pbxPapelera";
            this.pbxPapelera.Size = new System.Drawing.Size(172, 159);
            this.pbxPapelera.TabIndex = 1;
            this.pbxPapelera.TabStop = false;
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Location = new System.Drawing.Point(28, 238);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(75, 23);
            this.btnRestaurar.TabIndex = 2;
            this.btnRestaurar.Text = "Restaurar";
            this.btnRestaurar.UseVisualStyleBackColor = true;
            // 
            // btnEliminarFisico
            // 
            this.btnEliminarFisico.Location = new System.Drawing.Point(124, 238);
            this.btnEliminarFisico.Name = "btnEliminarFisico";
            this.btnEliminarFisico.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarFisico.TabIndex = 3;
            this.btnEliminarFisico.Text = "Eliminar";
            this.btnEliminarFisico.UseVisualStyleBackColor = true;
            // 
            // Papelera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 302);
            this.Controls.Add(this.btnEliminarFisico);
            this.Controls.Add(this.btnRestaurar);
            this.Controls.Add(this.pbxPapelera);
            this.Controls.Add(this.dgvPapelera);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(736, 341);
            this.Name = "Papelera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Papelera";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPapelera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPapelera)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPapelera;
        private System.Windows.Forms.PictureBox pbxPapelera;
        private System.Windows.Forms.Button btnRestaurar;
        private System.Windows.Forms.Button btnEliminarFisico;
    }
}