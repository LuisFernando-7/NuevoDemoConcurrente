namespace DemoConcurrencia
{
    partial class FrmPatronSingleton
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
            btnAsignar = new Button();
            btnRecuperar = new Button();
            label1 = new Label();
            txtCadenaConexion = new TextBox();
            LblCadenaDeConeccionRecuperada = new Label();
            SuspendLayout();
            // 
            // btnAsignar
            // 
            btnAsignar.Location = new Point(40, 75);
            btnAsignar.Name = "btnAsignar";
            btnAsignar.Size = new Size(118, 58);
            btnAsignar.TabIndex = 0;
            btnAsignar.Text = "Asignar Cadena de Coneccion ";
            btnAsignar.UseVisualStyleBackColor = true;
            btnAsignar.Click += btnAsignar_Click;
            // 
            // btnRecuperar
            // 
            btnRecuperar.Location = new Point(40, 186);
            btnRecuperar.Name = "btnRecuperar";
            btnRecuperar.Size = new Size(118, 58);
            btnRecuperar.TabIndex = 1;
            btnRecuperar.Text = "Obtener Cadena de Coneccion ";
            btnRecuperar.UseVisualStyleBackColor = true;
            btnRecuperar.Click += btnRecuperar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 27);
            label1.Name = "label1";
            label1.Size = new Size(117, 15);
            label1.TabIndex = 2;
            label1.Text = "Cadena de Conexion";
            // 
            // txtCadenaConexion
            // 
            txtCadenaConexion.Location = new Point(40, 46);
            txtCadenaConexion.Name = "txtCadenaConexion";
            txtCadenaConexion.Size = new Size(412, 23);
            txtCadenaConexion.TabIndex = 3;
            // 
            // LblCadenaDeConeccionRecuperada
            // 
            LblCadenaDeConeccionRecuperada.AutoSize = true;
            LblCadenaDeConeccionRecuperada.Location = new Point(182, 208);
            LblCadenaDeConeccionRecuperada.Name = "LblCadenaDeConeccionRecuperada";
            LblCadenaDeConeccionRecuperada.Size = new Size(16, 15);
            LblCadenaDeConeccionRecuperada.TabIndex = 4;
            LblCadenaDeConeccionRecuperada.Text = "...";
            // 
            // FrmPatronSingleton
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(513, 300);
            Controls.Add(LblCadenaDeConeccionRecuperada);
            Controls.Add(txtCadenaConexion);
            Controls.Add(label1);
            Controls.Add(btnRecuperar);
            Controls.Add(btnAsignar);
            Name = "FrmPatronSingleton";
            Text = "Demostracion de Patron Singleton";
            Load += FrmPatronSingleton_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAsignar;
        private Button btnRecuperar;
        private Label label1;
        private TextBox txtCadenaConexion;
        private Label LblCadenaDeConeccionRecuperada;
    }
}