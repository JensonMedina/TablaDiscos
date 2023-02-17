
namespace Principal
{
    partial class FrmDiscoNuevo
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblUrlImagen = new System.Windows.Forms.Label();
            this.lblEstilo = new System.Windows.Forms.Label();
            this.lblTipoEdicion = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtUrlImagen = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pbxDiscoNuevo = new System.Windows.Forms.PictureBox();
            this.dtpFechaLanzamiento = new System.Windows.Forms.DateTimePicker();
            this.nudCantidadCanciones = new System.Windows.Forms.NumericUpDown();
            this.cboEstilos = new System.Windows.Forms.ComboBox();
            this.cboEdicion = new System.Windows.Forms.ComboBox();
            this.btnImagenLocal = new System.Windows.Forms.Button();
            this.lblValidarTitulo = new System.Windows.Forms.Label();
            this.lblValidarCantidad = new System.Windows.Forms.Label();
            this.lblValidarImagen = new System.Windows.Forms.Label();
            this.lblValidarEstilo = new System.Windows.Forms.Label();
            this.lblValidarEdicion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDiscoNuevo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadCanciones)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(36, 32);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(33, 13);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Titulo";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(36, 63);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "Fecha";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(36, 94);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(49, 13);
            this.lblCantidad.TabIndex = 2;
            this.lblCantidad.Text = "Cantidad";
            // 
            // lblUrlImagen
            // 
            this.lblUrlImagen.AutoSize = true;
            this.lblUrlImagen.Location = new System.Drawing.Point(36, 125);
            this.lblUrlImagen.Name = "lblUrlImagen";
            this.lblUrlImagen.Size = new System.Drawing.Size(55, 13);
            this.lblUrlImagen.TabIndex = 3;
            this.lblUrlImagen.Text = "UrlImagen";
            // 
            // lblEstilo
            // 
            this.lblEstilo.AutoSize = true;
            this.lblEstilo.Location = new System.Drawing.Point(36, 156);
            this.lblEstilo.Name = "lblEstilo";
            this.lblEstilo.Size = new System.Drawing.Size(32, 13);
            this.lblEstilo.TabIndex = 4;
            this.lblEstilo.Text = "Estilo";
            // 
            // lblTipoEdicion
            // 
            this.lblTipoEdicion.AutoSize = true;
            this.lblTipoEdicion.Location = new System.Drawing.Point(36, 187);
            this.lblTipoEdicion.Name = "lblTipoEdicion";
            this.lblTipoEdicion.Size = new System.Drawing.Size(66, 13);
            this.lblTipoEdicion.TabIndex = 5;
            this.lblTipoEdicion.Text = "Tipo Edicion";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(117, 32);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(115, 20);
            this.txtTitulo.TabIndex = 0;
            this.txtTitulo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTitulo_KeyPress);
            // 
            // txtUrlImagen
            // 
            this.txtUrlImagen.Location = new System.Drawing.Point(117, 122);
            this.txtUrlImagen.Name = "txtUrlImagen";
            this.txtUrlImagen.Size = new System.Drawing.Size(115, 20);
            this.txtUrlImagen.TabIndex = 3;
            this.txtUrlImagen.TextChanged += new System.EventHandler(this.txtUrlImagen_TextChanged);
            this.txtUrlImagen.Leave += new System.EventHandler(this.txtUrlImagen_Leave);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(39, 256);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(133, 256);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // pbxDiscoNuevo
            // 
            this.pbxDiscoNuevo.Location = new System.Drawing.Point(296, 30);
            this.pbxDiscoNuevo.Name = "pbxDiscoNuevo";
            this.pbxDiscoNuevo.Size = new System.Drawing.Size(183, 175);
            this.pbxDiscoNuevo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxDiscoNuevo.TabIndex = 14;
            this.pbxDiscoNuevo.TabStop = false;
            // 
            // dtpFechaLanzamiento
            // 
            this.dtpFechaLanzamiento.Location = new System.Drawing.Point(117, 62);
            this.dtpFechaLanzamiento.Name = "dtpFechaLanzamiento";
            this.dtpFechaLanzamiento.Size = new System.Drawing.Size(115, 20);
            this.dtpFechaLanzamiento.TabIndex = 1;
            // 
            // nudCantidadCanciones
            // 
            this.nudCantidadCanciones.Location = new System.Drawing.Point(117, 92);
            this.nudCantidadCanciones.Name = "nudCantidadCanciones";
            this.nudCantidadCanciones.Size = new System.Drawing.Size(115, 20);
            this.nudCantidadCanciones.TabIndex = 2;
            this.nudCantidadCanciones.ValueChanged += new System.EventHandler(this.nudCantidadCanciones_ValueChanged);
            this.nudCantidadCanciones.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nudCantidadCanciones_KeyPress);
            // 
            // cboEstilos
            // 
            this.cboEstilos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstilos.FormattingEnabled = true;
            this.cboEstilos.Location = new System.Drawing.Point(117, 152);
            this.cboEstilos.Name = "cboEstilos";
            this.cboEstilos.Size = new System.Drawing.Size(115, 21);
            this.cboEstilos.TabIndex = 4;
            this.cboEstilos.SelectedIndexChanged += new System.EventHandler(this.cboEstilos_SelectedIndexChanged);
            // 
            // cboEdicion
            // 
            this.cboEdicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEdicion.FormattingEnabled = true;
            this.cboEdicion.Location = new System.Drawing.Point(117, 183);
            this.cboEdicion.Name = "cboEdicion";
            this.cboEdicion.Size = new System.Drawing.Size(115, 21);
            this.cboEdicion.TabIndex = 5;
            this.cboEdicion.SelectedIndexChanged += new System.EventHandler(this.cboEdicion_SelectedIndexChanged);
            // 
            // btnImagenLocal
            // 
            this.btnImagenLocal.Location = new System.Drawing.Point(238, 123);
            this.btnImagenLocal.Name = "btnImagenLocal";
            this.btnImagenLocal.Size = new System.Drawing.Size(22, 23);
            this.btnImagenLocal.TabIndex = 15;
            this.btnImagenLocal.Text = "+";
            this.btnImagenLocal.UseVisualStyleBackColor = true;
            this.btnImagenLocal.Click += new System.EventHandler(this.btnImagenLocal_Click);
            // 
            // lblValidarTitulo
            // 
            this.lblValidarTitulo.AutoSize = true;
            this.lblValidarTitulo.Location = new System.Drawing.Point(235, 35);
            this.lblValidarTitulo.Name = "lblValidarTitulo";
            this.lblValidarTitulo.Size = new System.Drawing.Size(0, 13);
            this.lblValidarTitulo.TabIndex = 16;
            // 
            // lblValidarCantidad
            // 
            this.lblValidarCantidad.AutoSize = true;
            this.lblValidarCantidad.Location = new System.Drawing.Point(235, 94);
            this.lblValidarCantidad.Name = "lblValidarCantidad";
            this.lblValidarCantidad.Size = new System.Drawing.Size(0, 13);
            this.lblValidarCantidad.TabIndex = 17;
            // 
            // lblValidarImagen
            // 
            this.lblValidarImagen.AutoSize = true;
            this.lblValidarImagen.Location = new System.Drawing.Point(266, 128);
            this.lblValidarImagen.Name = "lblValidarImagen";
            this.lblValidarImagen.Size = new System.Drawing.Size(0, 13);
            this.lblValidarImagen.TabIndex = 18;
            // 
            // lblValidarEstilo
            // 
            this.lblValidarEstilo.AutoSize = true;
            this.lblValidarEstilo.Location = new System.Drawing.Point(238, 161);
            this.lblValidarEstilo.Name = "lblValidarEstilo";
            this.lblValidarEstilo.Size = new System.Drawing.Size(0, 13);
            this.lblValidarEstilo.TabIndex = 19;
            // 
            // lblValidarEdicion
            // 
            this.lblValidarEdicion.AutoSize = true;
            this.lblValidarEdicion.Location = new System.Drawing.Point(238, 187);
            this.lblValidarEdicion.Name = "lblValidarEdicion";
            this.lblValidarEdicion.Size = new System.Drawing.Size(0, 13);
            this.lblValidarEdicion.TabIndex = 20;
            // 
            // FrmDiscoNuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(498, 318);
            this.Controls.Add(this.lblValidarEdicion);
            this.Controls.Add(this.lblValidarEstilo);
            this.Controls.Add(this.lblValidarImagen);
            this.Controls.Add(this.lblValidarCantidad);
            this.Controls.Add(this.lblValidarTitulo);
            this.Controls.Add(this.btnImagenLocal);
            this.Controls.Add(this.cboEdicion);
            this.Controls.Add(this.cboEstilos);
            this.Controls.Add(this.nudCantidadCanciones);
            this.Controls.Add(this.dtpFechaLanzamiento);
            this.Controls.Add(this.pbxDiscoNuevo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtUrlImagen);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lblTipoEdicion);
            this.Controls.Add(this.lblEstilo);
            this.Controls.Add(this.lblUrlImagen);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblTitulo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(493, 357);
            this.Name = "FrmDiscoNuevo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Disco";
            this.Load += new System.EventHandler(this.FrmDiscoNuevo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxDiscoNuevo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadCanciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblUrlImagen;
        private System.Windows.Forms.Label lblEstilo;
        private System.Windows.Forms.Label lblTipoEdicion;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtUrlImagen;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.PictureBox pbxDiscoNuevo;
        private System.Windows.Forms.DateTimePicker dtpFechaLanzamiento;
        private System.Windows.Forms.NumericUpDown nudCantidadCanciones;
        private System.Windows.Forms.ComboBox cboEstilos;
        private System.Windows.Forms.ComboBox cboEdicion;
        private System.Windows.Forms.Button btnImagenLocal;
        private System.Windows.Forms.Label lblValidarTitulo;
        private System.Windows.Forms.Label lblValidarCantidad;
        private System.Windows.Forms.Label lblValidarImagen;
        private System.Windows.Forms.Label lblValidarEstilo;
        private System.Windows.Forms.Label lblValidarEdicion;
    }
}