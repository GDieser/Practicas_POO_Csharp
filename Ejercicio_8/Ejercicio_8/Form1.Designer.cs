namespace Ejercicio_8
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
            dgvDiscos = new DataGridView();
            pbDiscos = new PictureBox();
            btnAgregarDisco = new Button();
            btnModificar = new Button();
            btnAgregarEstilo = new Button();
            btnTipo = new Button();
            btnEliminarFisico = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDiscos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbDiscos).BeginInit();
            SuspendLayout();
            // 
            // dgvDiscos
            // 
            dgvDiscos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDiscos.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvDiscos.Location = new Point(369, 94);
            dgvDiscos.MultiSelect = false;
            dgvDiscos.Name = "dgvDiscos";
            dgvDiscos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDiscos.Size = new Size(541, 249);
            dgvDiscos.TabIndex = 0;
            dgvDiscos.SelectionChanged += dgvDiscos_SelectionChanged;
            // 
            // pbDiscos
            // 
            pbDiscos.Location = new Point(28, 64);
            pbDiscos.Name = "pbDiscos";
            pbDiscos.Size = new Size(330, 298);
            pbDiscos.SizeMode = PictureBoxSizeMode.StretchImage;
            pbDiscos.TabIndex = 1;
            pbDiscos.TabStop = false;
            // 
            // btnAgregarDisco
            // 
            btnAgregarDisco.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarDisco.Location = new Point(28, 382);
            btnAgregarDisco.Name = "btnAgregarDisco";
            btnAgregarDisco.Size = new Size(125, 47);
            btnAgregarDisco.TabIndex = 2;
            btnAgregarDisco.Text = "Agregar Disco";
            btnAgregarDisco.UseVisualStyleBackColor = true;
            btnAgregarDisco.Click += btnAgregarDisco_Click;
            // 
            // btnModificar
            // 
            btnModificar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModificar.Location = new Point(28, 450);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(186, 47);
            btnModificar.TabIndex = 3;
            btnModificar.Text = "Modificar Disco";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnAgregarEstilo
            // 
            btnAgregarEstilo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarEstilo.Location = new Point(195, 382);
            btnAgregarEstilo.Name = "btnAgregarEstilo";
            btnAgregarEstilo.Size = new Size(125, 47);
            btnAgregarEstilo.TabIndex = 4;
            btnAgregarEstilo.Text = "Agregar Estilo";
            btnAgregarEstilo.UseVisualStyleBackColor = true;
            btnAgregarEstilo.Click += btnAgregarEstilo_Click;
            // 
            // btnTipo
            // 
            btnTipo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTipo.Location = new Point(350, 382);
            btnTipo.Name = "btnTipo";
            btnTipo.Size = new Size(175, 47);
            btnTipo.TabIndex = 6;
            btnTipo.Text = "Agregar Tipo de Lanzamiento";
            btnTipo.UseVisualStyleBackColor = true;
            btnTipo.Click += btnTipo_Click;
            // 
            // btnEliminarFisico
            // 
            btnEliminarFisico.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminarFisico.Location = new Point(28, 515);
            btnEliminarFisico.Name = "btnEliminarFisico";
            btnEliminarFisico.Size = new Size(186, 47);
            btnEliminarFisico.TabIndex = 7;
            btnEliminarFisico.Text = "Eliminar Disco";
            btnEliminarFisico.UseVisualStyleBackColor = true;
            btnEliminarFisico.Click += btnEliminarFisico_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(924, 636);
            Controls.Add(btnEliminarFisico);
            Controls.Add(btnTipo);
            Controls.Add(btnAgregarEstilo);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregarDisco);
            Controls.Add(pbDiscos);
            Controls.Add(dgvDiscos);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Discografias";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDiscos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbDiscos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvDiscos;
        private PictureBox pbDiscos;
        private Button btnAgregarDisco;
        private Button btnModificar;
        private Button btnAgregarEstilo;
        private Button btnTipo;
        private Button btnEliminarFisico;
    }
}
