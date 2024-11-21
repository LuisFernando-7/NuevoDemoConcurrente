namespace DemoConcurrencia
{
    partial class FrmBloqueos
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
            btnIncrementar = new Button();
            LblContador = new Label();
            btnDisminuir = new Button();
            splitContainer1 = new SplitContainer();
            txtResultado = new TextBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // btnIncrementar
            // 
            btnIncrementar.BackColor = Color.FromArgb(255, 255, 128);
            btnIncrementar.Font = new Font("News706 BT", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIncrementar.Location = new Point(29, 21);
            btnIncrementar.Name = "btnIncrementar";
            btnIncrementar.Size = new Size(168, 46);
            btnIncrementar.TabIndex = 0;
            btnIncrementar.Text = "Incrementar";
            btnIncrementar.UseVisualStyleBackColor = false;
            btnIncrementar.Click += btnIncrementar_Click;
            // 
            // LblContador
            // 
            LblContador.AutoSize = true;
            LblContador.Font = new Font("Exotc350 Bd BT", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblContador.Location = new Point(89, 239);
            LblContador.Name = "LblContador";
            LblContador.Size = new Size(54, 56);
            LblContador.TabIndex = 1;
            LblContador.Text = "0";
            LblContador.Click += LblContador_Click;
            // 
            // btnDisminuir
            // 
            btnDisminuir.BackColor = Color.FromArgb(255, 128, 128);
            btnDisminuir.Font = new Font("News706 BT", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDisminuir.Location = new Point(29, 81);
            btnDisminuir.Name = "btnDisminuir";
            btnDisminuir.Size = new Size(168, 46);
            btnDisminuir.TabIndex = 2;
            btnDisminuir.Text = "Disminuir";
            btnDisminuir.UseVisualStyleBackColor = false;
            btnDisminuir.Click += btnDisminuir_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.FromArgb(224, 224, 224);
            splitContainer1.Panel1.Controls.Add(btnIncrementar);
            splitContainer1.Panel1.Controls.Add(btnDisminuir);
            splitContainer1.Panel1.Controls.Add(LblContador);
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(txtResultado);
            splitContainer1.Size = new Size(658, 358);
            splitContainer1.SplitterDistance = 219;
            splitContainer1.TabIndex = 3;
            // 
            // txtResultado
            // 
            txtResultado.Dock = DockStyle.Fill;
            txtResultado.Font = new Font("News706 BT", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtResultado.Location = new Point(0, 0);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(435, 358);
            txtResultado.TabIndex = 1;
            // 
            // FrmBloqueos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(658, 358);
            Controls.Add(splitContainer1);
            Name = "FrmBloqueos";
            Text = "Gestion de Bloqueos";
            Load += FrmBloqueos_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnIncrementar;
        private Label LblContador;
        private Button btnDisminuir;
        private SplitContainer splitContainer1;
        private TextBox txtResultado;
    }
}