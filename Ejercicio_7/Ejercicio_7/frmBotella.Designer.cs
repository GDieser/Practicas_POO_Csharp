namespace Ejercicio_7
{
    partial class frmBotella
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
            btnAgregar = new Button();
            gbCapacidad = new GroupBox();
            rb600cc = new RadioButton();
            rb400cc = new RadioButton();
            rb200cc = new RadioButton();
            lbTitulo = new Label();
            lbColor = new Label();
            txbColor = new TextBox();
            txbMaterial = new TextBox();
            lbMaterial = new Label();
            gbCapacidad.SuspendLayout();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(121, 330);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(167, 45);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // gbCapacidad
            // 
            gbCapacidad.Controls.Add(rb600cc);
            gbCapacidad.Controls.Add(rb400cc);
            gbCapacidad.Controls.Add(rb200cc);
            gbCapacidad.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbCapacidad.Location = new Point(34, 74);
            gbCapacidad.Name = "gbCapacidad";
            gbCapacidad.Size = new Size(382, 75);
            gbCapacidad.TabIndex = 1;
            gbCapacidad.TabStop = false;
            gbCapacidad.Text = "Capacidad";
            // 
            // rb600cc
            // 
            rb600cc.AutoSize = true;
            rb600cc.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rb600cc.Location = new Point(283, 32);
            rb600cc.Name = "rb600cc";
            rb600cc.Size = new Size(59, 21);
            rb600cc.TabIndex = 2;
            rb600cc.TabStop = true;
            rb600cc.Text = "600cc";
            rb600cc.UseVisualStyleBackColor = true;
            // 
            // rb400cc
            // 
            rb400cc.AutoSize = true;
            rb400cc.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rb400cc.Location = new Point(155, 32);
            rb400cc.Name = "rb400cc";
            rb400cc.Size = new Size(59, 21);
            rb400cc.TabIndex = 1;
            rb400cc.TabStop = true;
            rb400cc.Text = "400cc";
            rb400cc.UseVisualStyleBackColor = true;
            // 
            // rb200cc
            // 
            rb200cc.AutoSize = true;
            rb200cc.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rb200cc.Location = new Point(29, 32);
            rb200cc.Name = "rb200cc";
            rb200cc.Size = new Size(59, 21);
            rb200cc.TabIndex = 0;
            rb200cc.TabStop = true;
            rb200cc.Text = "200cc";
            rb200cc.UseVisualStyleBackColor = true;
            // 
            // lbTitulo
            // 
            lbTitulo.AutoSize = true;
            lbTitulo.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTitulo.Location = new Point(114, 11);
            lbTitulo.Name = "lbTitulo";
            lbTitulo.Size = new Size(214, 27);
            lbTitulo.TabIndex = 2;
            lbTitulo.Text = "Agregar Botella";
            // 
            // lbColor
            // 
            lbColor.AutoSize = true;
            lbColor.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbColor.Location = new Point(43, 196);
            lbColor.Name = "lbColor";
            lbColor.Size = new Size(51, 21);
            lbColor.TabIndex = 3;
            lbColor.Text = "Color";
            // 
            // txbColor
            // 
            txbColor.Location = new Point(126, 194);
            txbColor.Name = "txbColor";
            txbColor.Size = new Size(217, 23);
            txbColor.TabIndex = 4;
            // 
            // txbMaterial
            // 
            txbMaterial.Location = new Point(126, 257);
            txbMaterial.Name = "txbMaterial";
            txbMaterial.Size = new Size(217, 23);
            txbMaterial.TabIndex = 6;
            // 
            // lbMaterial
            // 
            lbMaterial.AutoSize = true;
            lbMaterial.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbMaterial.Location = new Point(43, 259);
            lbMaterial.Name = "lbMaterial";
            lbMaterial.Size = new Size(74, 21);
            lbMaterial.TabIndex = 5;
            lbMaterial.Text = "Material";
            // 
            // frmBotella
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(441, 409);
            Controls.Add(txbMaterial);
            Controls.Add(lbMaterial);
            Controls.Add(txbColor);
            Controls.Add(lbColor);
            Controls.Add(lbTitulo);
            Controls.Add(gbCapacidad);
            Controls.Add(btnAgregar);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MaximumSize = new Size(457, 448);
            MinimizeBox = false;
            MinimumSize = new Size(457, 448);
            Name = "frmBotella";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmBotella";
            gbCapacidad.ResumeLayout(false);
            gbCapacidad.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregar;
        private GroupBox gbCapacidad;
        private RadioButton rb600cc;
        private RadioButton rb400cc;
        private RadioButton rb200cc;
        private Label lbTitulo;
        private Label lbColor;
        private TextBox txbColor;
        private TextBox txbMaterial;
        private Label lbMaterial;
    }
}