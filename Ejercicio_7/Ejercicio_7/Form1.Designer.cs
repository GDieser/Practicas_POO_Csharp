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
            btnAgregar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = SystemColors.ActiveCaptionText;
            btnAgregar.Location = new Point(128, 324);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(156, 35);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txbNombre
            // 
            txbNombre.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txbNombre.Location = new Point(188, 84);
            txbNombre.Name = "txbNombre";
            txbNombre.Size = new Size(168, 23);
            txbNombre.TabIndex = 1;
            // 
            // txbApellido
            // 
            txbApellido.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txbApellido.Location = new Point(188, 134);
            txbApellido.Name = "txbApellido";
            txbApellido.Size = new Size(168, 23);
            txbApellido.TabIndex = 2;
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtpFechaNacimiento.Location = new Point(188, 196);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(200, 23);
            dtpFechaNacimiento.TabIndex = 3;
            // 
            // rbArgentina
            // 
            rbArgentina.Anchor = AnchorStyles.Top;
            rbArgentina.AutoSize = true;
            rbArgentina.Location = new Point(30, 22);
            rbArgentina.Name = "rbArgentina";
            rbArgentina.Size = new Size(87, 21);
            rbArgentina.TabIndex = 4;
            rbArgentina.TabStop = true;
            rbArgentina.Text = "Argentina";
            rbArgentina.UseVisualStyleBackColor = true;
            // 
            // rbParaguay
            // 
            rbParaguay.Anchor = AnchorStyles.Top;
            rbParaguay.AutoSize = true;
            rbParaguay.Location = new Point(139, 22);
            rbParaguay.Name = "rbParaguay";
            rbParaguay.Size = new Size(83, 21);
            rbParaguay.TabIndex = 5;
            rbParaguay.TabStop = true;
            rbParaguay.Text = "Paraguay";
            rbParaguay.UseVisualStyleBackColor = true;
            // 
            // rbUruguay
            // 
            rbUruguay.Anchor = AnchorStyles.Top;
            rbUruguay.AutoSize = true;
            rbUruguay.Location = new Point(255, 22);
            rbUruguay.Name = "rbUruguay";
            rbUruguay.Size = new Size(78, 21);
            rbUruguay.TabIndex = 6;
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
            gbNacionalidad.Location = new Point(34, 243);
            gbNacionalidad.Name = "gbNacionalidad";
            gbNacionalidad.Size = new Size(357, 55);
            gbNacionalidad.TabIndex = 7;
            gbNacionalidad.TabStop = false;
            gbNacionalidad.Text = "Nacionalidad";
            // 
            // lbNombre
            // 
            lbNombre.AutoSize = true;
            lbNombre.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbNombre.Location = new Point(64, 82);
            lbNombre.Name = "lbNombre";
            lbNombre.Size = new Size(73, 21);
            lbNombre.TabIndex = 8;
            lbNombre.Text = "Nombre";
            // 
            // lbApellido
            // 
            lbApellido.AutoSize = true;
            lbApellido.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbApellido.Location = new Point(64, 134);
            lbApellido.Name = "lbApellido";
            lbApellido.Size = new Size(75, 21);
            lbApellido.TabIndex = 9;
            lbApellido.Text = "Apellido";
            // 
            // lbFechaNacimiento
            // 
            lbFechaNacimiento.AutoSize = true;
            lbFechaNacimiento.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbFechaNacimiento.Location = new Point(21, 196);
            lbFechaNacimiento.Name = "lbFechaNacimiento";
            lbFechaNacimiento.Size = new Size(148, 21);
            lbFechaNacimiento.TabIndex = 10;
            lbFechaNacimiento.Text = "Fecha Nacimiento";
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(100, 25);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(244, 30);
            lblTitulo.TabIndex = 11;
            lblTitulo.Text = "Agregar Persona";
            // 
            // Persona
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(431, 404);
            Controls.Add(lblTitulo);
            Controls.Add(lbFechaNacimiento);
            Controls.Add(lbApellido);
            Controls.Add(lbNombre);
            Controls.Add(gbNacionalidad);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(txbApellido);
            Controls.Add(txbNombre);
            Controls.Add(btnAgregar);
            MaximizeBox = false;
            MaximumSize = new Size(642, 528);
            MinimumSize = new Size(447, 443);
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
