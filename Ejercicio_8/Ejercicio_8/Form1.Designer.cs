﻿namespace Ejercicio_8
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(924, 636);
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
    }
}
