namespace Ejercicio_7
{
    partial class frmAnimal
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
            lbTitulo = new Label();
            btnAgregar = new Button();
            lbNombre = new Label();
            txbNombre = new TextBox();
            txbRaza = new TextBox();
            lbRaza = new Label();
            txbAltura = new TextBox();
            lblAltura = new Label();
            txbPeso = new TextBox();
            lblPeso = new Label();
            SuspendLayout();
            // 
            // lbTitulo
            // 
            lbTitulo.AutoSize = true;
            lbTitulo.Font = new Font("Snap ITC", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTitulo.Location = new Point(140, 39);
            lbTitulo.Name = "lbTitulo";
            lbTitulo.Size = new Size(238, 31);
            lbTitulo.TabIndex = 0;
            lbTitulo.Text = "Agregar Animal";
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(166, 432);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(212, 40);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // lbNombre
            // 
            lbNombre.AutoSize = true;
            lbNombre.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbNombre.Location = new Point(55, 146);
            lbNombre.Name = "lbNombre";
            lbNombre.Size = new Size(77, 21);
            lbNombre.TabIndex = 2;
            lbNombre.Text = "Nombre:";
            // 
            // txbNombre
            // 
            txbNombre.Location = new Point(151, 146);
            txbNombre.Name = "txbNombre";
            txbNombre.Size = new Size(257, 23);
            txbNombre.TabIndex = 3;
            // 
            // txbRaza
            // 
            txbRaza.Location = new Point(151, 220);
            txbRaza.Name = "txbRaza";
            txbRaza.Size = new Size(257, 23);
            txbRaza.TabIndex = 5;
            // 
            // lbRaza
            // 
            lbRaza.AutoSize = true;
            lbRaza.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbRaza.Location = new Point(55, 220);
            lbRaza.Name = "lbRaza";
            lbRaza.Size = new Size(50, 21);
            lbRaza.TabIndex = 4;
            lbRaza.Text = "Raza:";
            // 
            // txbAltura
            // 
            txbAltura.Location = new Point(151, 282);
            txbAltura.Name = "txbAltura";
            txbAltura.Size = new Size(257, 23);
            txbAltura.TabIndex = 7;
            // 
            // lblAltura
            // 
            lblAltura.AutoSize = true;
            lblAltura.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAltura.Location = new Point(55, 282);
            lblAltura.Name = "lblAltura";
            lblAltura.Size = new Size(61, 21);
            lblAltura.TabIndex = 6;
            lblAltura.Text = "Altura:";
            // 
            // txbPeso
            // 
            txbPeso.Location = new Point(151, 347);
            txbPeso.Name = "txbPeso";
            txbPeso.Size = new Size(257, 23);
            txbPeso.TabIndex = 9;
            // 
            // lblPeso
            // 
            lblPeso.AutoSize = true;
            lblPeso.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPeso.Location = new Point(55, 347);
            lblPeso.Name = "lblPeso";
            lblPeso.Size = new Size(50, 21);
            lblPeso.TabIndex = 8;
            lblPeso.Text = "Peso:";
            // 
            // frmAnimal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(539, 511);
            Controls.Add(txbPeso);
            Controls.Add(lblPeso);
            Controls.Add(txbAltura);
            Controls.Add(lblAltura);
            Controls.Add(txbRaza);
            Controls.Add(lbRaza);
            Controls.Add(txbNombre);
            Controls.Add(lbNombre);
            Controls.Add(btnAgregar);
            Controls.Add(lbTitulo);
            MaximizeBox = false;
            MaximumSize = new Size(555, 550);
            MinimizeBox = false;
            MinimumSize = new Size(555, 550);
            Name = "frmAnimal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTitulo;
        private Button btnAgregar;
        private Label lbNombre;
        private TextBox txbNombre;
        private TextBox txbRaza;
        private Label lbRaza;
        private TextBox txbAltura;
        private Label lblAltura;
        private TextBox txbPeso;
        private Label lblPeso;
    }
}