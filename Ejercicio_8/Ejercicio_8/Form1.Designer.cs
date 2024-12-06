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
            ((System.ComponentModel.ISupportInitialize)dgvDiscos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbDiscos).BeginInit();
            SuspendLayout();
            // 
            // dgvDiscos
            // 
            dgvDiscos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDiscos.Location = new Point(47, 47);
            dgvDiscos.Name = "dgvDiscos";
            dgvDiscos.Size = new Size(524, 249);
            dgvDiscos.TabIndex = 0;
            dgvDiscos.SelectionChanged += dgvDiscos_SelectionChanged;
            // 
            // pbDiscos
            // 
            pbDiscos.Location = new Point(631, 47);
            pbDiscos.Name = "pbDiscos";
            pbDiscos.Size = new Size(264, 249);
            pbDiscos.SizeMode = PictureBoxSizeMode.StretchImage;
            pbDiscos.TabIndex = 1;
            pbDiscos.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(924, 407);
            Controls.Add(pbDiscos);
            Controls.Add(dgvDiscos);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDiscos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbDiscos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvDiscos;
        private PictureBox pbDiscos;
    }
}
