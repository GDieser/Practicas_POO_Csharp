namespace Ejercicio_7
{
    partial class Persona
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
            btnAgregar = new Button();
            txbNombre = new TextBox();
            txbApellido = new TextBox();
            dtpFechaNacimiento = new DateTimePicker();
            rbArgentina = new RadioButton();
            rbParaguay = new RadioButton();
            rbUruguay = new RadioButton();
            gbNacionalidad = new GroupBox();
            lbNombre = new Label();
            lbApellido = new Label();
            lbFechaNacimiento = new Label();
            lblTitulo = new Label();
            gbNacionalidad.SuspendLayout();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnAgregar.FlatAppearance.BorderColor = Color.Black;
            btnAgregar.FlatAppearance.MouseDownBackColor = Color.Red;
            btnAgregar.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 0);
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = SystemColors.ActiveCaptionText;
            btnAgregar.Location = new Point(146, 410);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(178, 44);
            btnAgregar.TabIndex = 5;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txbNombre
            // 
            txbNombre.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txbNombre.Location = new Point(215, 106);
            txbNombre.Margin = new Padding(3, 4, 3, 4);
            txbNombre.Name = "txbNombre";
            txbNombre.Size = new Size(191, 26);
            txbNombre.TabIndex = 1;
            // 
            // txbApellido
            // 
            txbApellido.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txbApellido.Location = new Point(215, 170);
            txbApellido.Margin = new Padding(3, 4, 3, 4);
            txbApellido.Name = "txbApellido";
            txbApellido.Size = new Size(191, 26);
            txbApellido.TabIndex = 2;
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtpFechaNacimiento.Location = new Point(215, 248);
            dtpFechaNacimiento.Margin = new Padding(3, 4, 3, 4);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(228, 26);
            dtpFechaNacimiento.TabIndex = 3;
            // 
            // rbArgentina
            // 
            rbArgentina.Anchor = AnchorStyles.Top;
            rbArgentina.AutoSize = true;
            rbArgentina.Location = new Point(34, 28);
            rbArgentina.Margin = new Padding(3, 4, 3, 4);
            rbArgentina.Name = "rbArgentina";
            rbArgentina.Size = new Size(97, 24);
            rbArgentina.TabIndex = 0;
            rbArgentina.TabStop = true;
            rbArgentina.Text = "Argentina";
            rbArgentina.UseVisualStyleBackColor = true;
            // 
            // rbParaguay
            // 
            rbParaguay.Anchor = AnchorStyles.Top;
            rbParaguay.AutoSize = true;
            rbParaguay.Location = new Point(159, 28);
            rbParaguay.Margin = new Padding(3, 4, 3, 4);
            rbParaguay.Name = "rbParaguay";
            rbParaguay.Size = new Size(92, 24);
            rbParaguay.TabIndex = 1;
            rbParaguay.TabStop = true;
            rbParaguay.Text = "Paraguay";
            rbParaguay.UseVisualStyleBackColor = true;
            // 
            // rbUruguay
            // 
            rbUruguay.Anchor = AnchorStyles.Top;
            rbUruguay.AutoSize = true;
            rbUruguay.Location = new Point(291, 28);
            rbUruguay.Margin = new Padding(3, 4, 3, 4);
            rbUruguay.Name = "rbUruguay";
            rbUruguay.Size = new Size(87, 24);
            rbUruguay.TabIndex = 2;
            rbUruguay.TabStop = true;
            rbUruguay.Text = "Uruguay";
            rbUruguay.UseVisualStyleBackColor = true;
            // 
            // gbNacionalidad
            // 
            gbNacionalidad.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gbNacionalidad.Controls.Add(rbArgentina);
            gbNacionalidad.Controls.Add(rbUruguay);
            gbNacionalidad.Controls.Add(rbParaguay);
            gbNacionalidad.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbNacionalidad.Location = new Point(39, 308);
            gbNacionalidad.Margin = new Padding(3, 4, 3, 4);
            gbNacionalidad.Name = "gbNacionalidad";
            gbNacionalidad.Padding = new Padding(3, 4, 3, 4);
            gbNacionalidad.Size = new Size(408, 70);
            gbNacionalidad.TabIndex = 4;
            gbNacionalidad.TabStop = false;
            gbNacionalidad.Text = "Nacionalidad";
            // 
            // lbNombre
            // 
            lbNombre.AutoSize = true;
            lbNombre.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbNombre.Location = new Point(73, 104);
            lbNombre.Name = "lbNombre";
            lbNombre.Size = new Size(86, 25);
            lbNombre.TabIndex = 8;
            lbNombre.Text = "Nombre";
            // 
            // lbApellido
            // 
            lbApellido.AutoSize = true;
            lbApellido.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbApellido.Location = new Point(73, 170);
            lbApellido.Name = "lbApellido";
            lbApellido.Size = new Size(86, 25);
            lbApellido.TabIndex = 9;
            lbApellido.Text = "Apellido";
            // 
            // lbFechaNacimiento
            // 
            lbFechaNacimiento.AutoSize = true;
            lbFechaNacimiento.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbFechaNacimiento.Location = new Point(24, 248);
            lbFechaNacimiento.Name = "lbFechaNacimiento";
            lbFechaNacimiento.Size = new Size(169, 25);
            lbFechaNacimiento.TabIndex = 10;
            lbFechaNacimiento.Text = "Fecha Nacimiento";
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(114, 32);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(286, 35);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Agregar Persona";
            // 
            // Persona
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(493, 512);
            Controls.Add(lblTitulo);
            Controls.Add(lbFechaNacimiento);
            Controls.Add(lbApellido);
            Controls.Add(lbNombre);
            Controls.Add(gbNacionalidad);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(txbApellido);
            Controls.Add(txbNombre);
            Controls.Add(btnAgregar);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MaximumSize = new Size(731, 657);
            MinimumSize = new Size(508, 549);
            Name = "Persona";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar Persona";
            gbNacionalidad.ResumeLayout(false);
            gbNacionalidad.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregar;
        private TextBox txbNombre;
        private TextBox txbApellido;
        private DateTimePicker dtpFechaNacimiento;
        private RadioButton rbArgentina;
        private RadioButton rbParaguay;
        private RadioButton rbUruguay;
        private GroupBox gbNacionalidad;
        private Label lbNombre;
        private Label lbApellido;
        private Label lbFechaNacimiento;
        private Label lblTitulo;
    }
}
