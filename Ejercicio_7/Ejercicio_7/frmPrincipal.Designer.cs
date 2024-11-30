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
            btnAgregarPersona.Location = new Point(12, 74);
            btnAgregarPersona.Name = "btnAgregarPersona";
            btnAgregarPersona.Size = new Size(161, 50);
            btnAgregarPersona.TabIndex = 0;
            btnAgregarPersona.Text = "Agregar Persona";
            btnAgregarPersona.UseVisualStyleBackColor = true;
            btnAgregarPersona.Click += btnAgregarPersona_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { menusPersona, menusBotella, menusAnimal });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(552, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // menusPersona
            // 
            menusPersona.DropDownItems.AddRange(new ToolStripItem[] { agregarPersonaToolStripMenuItem });
            menusPersona.Name = "menusPersona";
            menusPersona.Size = new Size(61, 20);
            menusPersona.Text = "Persona";
            // 
            // agregarPersonaToolStripMenuItem
            // 
            agregarPersonaToolStripMenuItem.Name = "agregarPersonaToolStripMenuItem";
            agregarPersonaToolStripMenuItem.Size = new Size(161, 22);
            agregarPersonaToolStripMenuItem.Text = "Agregar Persona";
            agregarPersonaToolStripMenuItem.Click += agregarPersonaToolStripMenuItem_Click;
            // 
            // menusBotella
            // 
            menusBotella.DropDownItems.AddRange(new ToolStripItem[] { agregarBotellaToolStripMenuItem });
            menusBotella.Name = "menusBotella";
            menusBotella.Size = new Size(55, 20);
            menusBotella.Text = "Botella";
            // 
            // agregarBotellaToolStripMenuItem
            // 
            agregarBotellaToolStripMenuItem.Name = "agregarBotellaToolStripMenuItem";
            agregarBotellaToolStripMenuItem.Size = new Size(155, 22);
            agregarBotellaToolStripMenuItem.Text = "Agregar Botella";
            agregarBotellaToolStripMenuItem.Click += agregarBotellaToolStripMenuItem_Click;
            // 
            // menusAnimal
            // 
            menusAnimal.DropDownItems.AddRange(new ToolStripItem[] { agregarAnimalToolStripMenuItem });
            menusAnimal.Name = "menusAnimal";
            menusAnimal.Size = new Size(57, 20);
            menusAnimal.Text = "Animal";
            // 
            // agregarAnimalToolStripMenuItem
            // 
            agregarAnimalToolStripMenuItem.Name = "agregarAnimalToolStripMenuItem";
            agregarAnimalToolStripMenuItem.Size = new Size(157, 22);
            agregarAnimalToolStripMenuItem.Text = "Agregar Animal";
            agregarAnimalToolStripMenuItem.Click += agregarAnimalToolStripMenuItem_Click;
            // 
            // btnBotella
            // 
            btnBotella.Location = new Point(199, 74);
            btnBotella.Name = "btnBotella";
            btnBotella.Size = new Size(161, 50);
            btnBotella.TabIndex = 2;
            btnBotella.Text = "Agregar Botella";
            btnBotella.UseVisualStyleBackColor = true;
            btnBotella.Click += btnBotella_Click;
            // 
            // btnAnimal
            // 
            btnAnimal.Location = new Point(379, 74);
            btnAnimal.Name = "btnAnimal";
            btnAnimal.Size = new Size(161, 50);
            btnAnimal.TabIndex = 3;
            btnAnimal.Text = "Agregar Animal";
            btnAnimal.UseVisualStyleBackColor = true;
            btnAnimal.Click += btnAnimal_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(552, 217);
            Controls.Add(btnAnimal);
            Controls.Add(btnBotella);
            Controls.Add(btnAgregarPersona);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MaximumSize = new Size(568, 256);
            MinimumSize = new Size(568, 256);
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