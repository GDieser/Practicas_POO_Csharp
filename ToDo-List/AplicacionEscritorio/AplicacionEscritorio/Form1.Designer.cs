namespace AplicacionEscritorio
{
    partial class Form1
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
            lblLista = new Label();
            btnAgregar = new Button();
            tboxItem = new TextBox();
            lblTitulo = new Label();
            clLista = new CheckedListBox();
            SuspendLayout();
            // 
            // lblLista
            // 
            lblLista.AutoSize = true;
            lblLista.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLista.Location = new Point(118, 33);
            lblLista.Name = "lblLista";
            lblLista.Size = new Size(201, 30);
            lblLista.TabIndex = 0;
            lblLista.Text = "Lista de Pendientes";
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(326, 90);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(88, 28);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // tboxItem
            // 
            tboxItem.Location = new Point(118, 94);
            tboxItem.Name = "tboxItem";
            tboxItem.Size = new Size(186, 23);
            tboxItem.TabIndex = 2;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(49, 94);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(48, 21);
            lblTitulo.TabIndex = 3;
            lblTitulo.Text = "ITEM";
            // 
            // clLista
            // 
            clLista.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clLista.FormattingEnabled = true;
            clLista.Location = new Point(49, 155);
            clLista.Name = "clLista";
            clLista.Size = new Size(365, 346);
            clLista.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(459, 557);
            Controls.Add(clLista);
            Controls.Add(lblTitulo);
            Controls.Add(tboxItem);
            Controls.Add(btnAgregar);
            Controls.Add(lblLista);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLista;
        private Button btnAgregar;
        private TextBox tboxItem;
        private Label lblTitulo;
        private CheckedListBox clLista;
    }
}
