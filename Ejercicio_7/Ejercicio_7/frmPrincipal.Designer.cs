namespace Ejercicio_7
{
    partial class frmPrincipal
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
            btnAgregarPersona = new Button();
            menuStrip1 = new MenuStrip();
            menusPersona = new ToolStripMenuItem();
            agregarPersonaToolStripMenuItem = new ToolStripMenuItem();
            menusBotella = new ToolStripMenuItem();
            agregarBotellaToolStripMenuItem = new ToolStripMenuItem();
            menusAnimal = new ToolStripMenuItem();
            agregarAnimalToolStripMenuItem = new ToolStripMenuItem();
            btnBotella = new Button();
            btnAnimal = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAgregarPersona
            // 
            btnAgregarPersona.Location = new Point(14, 94);
            btnAgregarPersona.Margin = new Padding(3, 4, 3, 4);
            btnAgregarPersona.Name = "btnAgregarPersona";
            btnAgregarPersona.Size = new Size(184, 63);
            btnAgregarPersona.TabIndex = 1;
            btnAgregarPersona.Text = "Agregar Persona";
            btnAgregarPersona.UseVisualStyleBackColor = true;
            btnAgregarPersona.Click += btnAgregarPersona_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(18, 18);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menusPersona, menusBotella, menusAnimal });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(629, 29);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menusPersona
            // 
            menusPersona.DropDownItems.AddRange(new ToolStripItem[] { agregarPersonaToolStripMenuItem });
            menusPersona.Name = "menusPersona";
            menusPersona.Size = new Size(71, 23);
            menusPersona.Text = "Persona";
            // 
            // agregarPersonaToolStripMenuItem
            // 
            agregarPersonaToolStripMenuItem.Name = "agregarPersonaToolStripMenuItem";
            agregarPersonaToolStripMenuItem.Size = new Size(187, 24);
            agregarPersonaToolStripMenuItem.Text = "Agregar Persona";
            agregarPersonaToolStripMenuItem.Click += agregarPersonaToolStripMenuItem_Click;
            // 
            // menusBotella
            // 
            menusBotella.DropDownItems.AddRange(new ToolStripItem[] { agregarBotellaToolStripMenuItem });
            menusBotella.Name = "menusBotella";
            menusBotella.Size = new Size(64, 23);
            menusBotella.Text = "Botella";
            // 
            // agregarBotellaToolStripMenuItem
            // 
            agregarBotellaToolStripMenuItem.Name = "agregarBotellaToolStripMenuItem";
            agregarBotellaToolStripMenuItem.Size = new Size(180, 24);
            agregarBotellaToolStripMenuItem.Text = "Agregar Botella";
            agregarBotellaToolStripMenuItem.Click += agregarBotellaToolStripMenuItem_Click;
            // 
            // menusAnimal
            // 
            menusAnimal.DropDownItems.AddRange(new ToolStripItem[] { agregarAnimalToolStripMenuItem });
            menusAnimal.Name = "menusAnimal";
            menusAnimal.Size = new Size(65, 23);
            menusAnimal.Text = "Animal";
            // 
            // agregarAnimalToolStripMenuItem
            // 
            agregarAnimalToolStripMenuItem.Name = "agregarAnimalToolStripMenuItem";
            agregarAnimalToolStripMenuItem.Size = new Size(181, 24);
            agregarAnimalToolStripMenuItem.Text = "Agregar Animal";
            agregarAnimalToolStripMenuItem.Click += agregarAnimalToolStripMenuItem_Click;
            // 
            // btnBotella
            // 
            btnBotella.Location = new Point(227, 94);
            btnBotella.Margin = new Padding(3, 4, 3, 4);
            btnBotella.Name = "btnBotella";
            btnBotella.Size = new Size(184, 63);
            btnBotella.TabIndex = 2;
            btnBotella.Text = "Agregar Botella";
            btnBotella.UseVisualStyleBackColor = true;
            btnBotella.Click += btnBotella_Click;
            // 
            // btnAnimal
            // 
            btnAnimal.Location = new Point(433, 94);
            btnAnimal.Margin = new Padding(3, 4, 3, 4);
            btnAnimal.Name = "btnAnimal";
            btnAnimal.Size = new Size(184, 63);
            btnAnimal.TabIndex = 3;
            btnAnimal.Text = "Agregar Animal";
            btnAnimal.UseVisualStyleBackColor = true;
            btnAnimal.Click += btnAnimal_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(629, 269);
            Controls.Add(btnAnimal);
            Controls.Add(btnBotella);
            Controls.Add(btnAgregarPersona);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MaximumSize = new Size(647, 313);
            MinimumSize = new Size(647, 313);
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmPrincipal";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregarPersona;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menusPersona;
        private ToolStripMenuItem agregarPersonaToolStripMenuItem;
        private ToolStripMenuItem menusBotella;
        private ToolStripMenuItem agregarBotellaToolStripMenuItem;
        private ToolStripMenuItem menusAnimal;
        private ToolStripMenuItem agregarAnimalToolStripMenuItem;
        private Button btnBotella;
        private Button btnAnimal;
    }
}