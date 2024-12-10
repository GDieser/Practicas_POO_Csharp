namespace WinForm
{
    partial class frmAgregarDisco
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
            lblTitulo = new Label();
            txbTitulo = new TextBox();
            lblFecha = new Label();
            dtpFechaLanzamiento = new DateTimePicker();
            lblCanciones = new Label();
            nudCantidad = new NumericUpDown();
            lblUrlImagen = new Label();
            txbUrlImagen = new TextBox();
            lblEstilo = new Label();
            lblTipoEdicion = new Label();
            cboxEstilo = new ComboBox();
            cBoxTipoEdicion = new ComboBox();
            btnAgregarDisco = new Button();
            pbUrlImagen = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbUrlImagen).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(158, 44);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(59, 21);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Titulo:";
            // 
            // txbTitulo
            // 
            txbTitulo.Location = new Point(239, 42);
            txbTitulo.Name = "txbTitulo";
            txbTitulo.Size = new Size(218, 23);
            txbTitulo.TabIndex = 1;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFecha.Location = new Point(56, 100);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(161, 21);
            lblFecha.TabIndex = 2;
            lblFecha.Text = "Fecha Lanzamiento:";
            // 
            // dtpFechaLanzamiento
            // 
            dtpFechaLanzamiento.Location = new Point(239, 100);
            dtpFechaLanzamiento.Name = "dtpFechaLanzamiento";
            dtpFechaLanzamiento.Size = new Size(218, 23);
            dtpFechaLanzamiento.TabIndex = 3;
            // 
            // lblCanciones
            // 
            lblCanciones.AutoSize = true;
            lblCanciones.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCanciones.Location = new Point(29, 165);
            lblCanciones.Name = "lblCanciones";
            lblCanciones.Size = new Size(188, 21);
            lblCanciones.TabIndex = 4;
            lblCanciones.Text = "Cantidad de Canciones:";
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(239, 163);
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(130, 23);
            nudCantidad.TabIndex = 5;
            // 
            // lblUrlImagen
            // 
            lblUrlImagen.AutoSize = true;
            lblUrlImagen.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUrlImagen.Location = new Point(111, 227);
            lblUrlImagen.Name = "lblUrlImagen";
            lblUrlImagen.Size = new Size(106, 21);
            lblUrlImagen.TabIndex = 6;
            lblUrlImagen.Text = "URL Imagen:";
            // 
            // txbUrlImagen
            // 
            txbUrlImagen.Location = new Point(239, 229);
            txbUrlImagen.Name = "txbUrlImagen";
            txbUrlImagen.Size = new Size(218, 23);
            txbUrlImagen.TabIndex = 7;
            txbUrlImagen.Leave += txbUrlImagen_Leave;
            // 
            // lblEstilo
            // 
            lblEstilo.AutoSize = true;
            lblEstilo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEstilo.Location = new Point(161, 287);
            lblEstilo.Name = "lblEstilo";
            lblEstilo.Size = new Size(56, 21);
            lblEstilo.TabIndex = 8;
            lblEstilo.Text = "Estilo:";
            // 
            // lblTipoEdicion
            // 
            lblTipoEdicion.AutoSize = true;
            lblTipoEdicion.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTipoEdicion.Location = new Point(108, 334);
            lblTipoEdicion.Name = "lblTipoEdicion";
            lblTipoEdicion.Size = new Size(109, 21);
            lblTipoEdicion.TabIndex = 10;
            lblTipoEdicion.Text = "Tipo Edicion:";
            // 
            // cboxEstilo
            // 
            cboxEstilo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboxEstilo.FormattingEnabled = true;
            cboxEstilo.Location = new Point(239, 285);
            cboxEstilo.Name = "cboxEstilo";
            cboxEstilo.Size = new Size(218, 23);
            cboxEstilo.TabIndex = 9;
            cboxEstilo.SelectedIndexChanged += cboxEstilo_SelectedIndexChanged;
            // 
            // cBoxTipoEdicion
            // 
            cBoxTipoEdicion.DropDownStyle = ComboBoxStyle.DropDownList;
            cBoxTipoEdicion.FormattingEnabled = true;
            cBoxTipoEdicion.Location = new Point(239, 336);
            cBoxTipoEdicion.Name = "cBoxTipoEdicion";
            cBoxTipoEdicion.Size = new Size(218, 23);
            cBoxTipoEdicion.TabIndex = 11;
            // 
            // btnAgregarDisco
            // 
            btnAgregarDisco.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarDisco.Location = new Point(147, 412);
            btnAgregarDisco.Name = "btnAgregarDisco";
            btnAgregarDisco.Size = new Size(241, 34);
            btnAgregarDisco.TabIndex = 12;
            btnAgregarDisco.Text = "Agregar Disco";
            btnAgregarDisco.UseVisualStyleBackColor = true;
            btnAgregarDisco.Click += btnAgregarDisco_Click;
            // 
            // pbUrlImagen
            // 
            pbUrlImagen.Location = new Point(497, 88);
            pbUrlImagen.Name = "pbUrlImagen";
            pbUrlImagen.Size = new Size(305, 267);
            pbUrlImagen.SizeMode = PictureBoxSizeMode.StretchImage;
            pbUrlImagen.TabIndex = 13;
            pbUrlImagen.TabStop = false;
            // 
            // frmAgregarDisco
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(836, 483);
            Controls.Add(pbUrlImagen);
            Controls.Add(btnAgregarDisco);
            Controls.Add(cBoxTipoEdicion);
            Controls.Add(cboxEstilo);
            Controls.Add(lblTipoEdicion);
            Controls.Add(lblEstilo);
            Controls.Add(txbUrlImagen);
            Controls.Add(lblUrlImagen);
            Controls.Add(nudCantidad);
            Controls.Add(lblCanciones);
            Controls.Add(dtpFechaLanzamiento);
            Controls.Add(lblFecha);
            Controls.Add(txbTitulo);
            Controls.Add(lblTitulo);
            Name = "frmAgregarDisco";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar Disco";
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbUrlImagen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private TextBox txbTitulo;
        private Label lblFecha;
        private DateTimePicker dtpFechaLanzamiento;
        private Label lblCanciones;
        private NumericUpDown nudCantidad;
        private Label lblUrlImagen;
        private TextBox txbUrlImagen;
        private Label lblEstilo;
        private Label lblTipoEdicion;
        private ComboBox cboxEstilo;
        private ComboBox cBoxTipoEdicion;
        private Button btnAgregarDisco;
        private PictureBox pbUrlImagen;
    }
}