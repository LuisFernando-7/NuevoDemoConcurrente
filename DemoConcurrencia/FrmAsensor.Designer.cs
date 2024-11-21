namespace DemoConcurrencia
{
    partial class FrmAsensor
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
            splitContainer1 = new SplitContainer();
            btnSubir = new Button();
            btnbajar = new Button();
            LblContador = new Label();
            txtResultado = new TextBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = SystemColors.ButtonShadow;
            splitContainer1.Panel1.Controls.Add(btnSubir);
            splitContainer1.Panel1.Controls.Add(btnbajar);
            splitContainer1.Panel1.Controls.Add(LblContador);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(txtResultado);
            splitContainer1.Size = new Size(721, 339);
            splitContainer1.SplitterDistance = 239;
            splitContainer1.TabIndex = 0;
            // 
            // btnSubir
            // 
            btnSubir.BackColor = Color.FromArgb(128, 255, 128);
            btnSubir.Font = new Font("News706 BT", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubir.Location = new Point(45, 34);
            btnSubir.Name = "btnSubir";
            btnSubir.Size = new Size(168, 46);
            btnSubir.TabIndex = 3;
            btnSubir.Text = "Subir ";
            btnSubir.UseVisualStyleBackColor = false;
            btnSubir.Click += btnSubir_Click;
            // 
            // btnbajar
            // 
            btnbajar.BackColor = Color.FromArgb(128, 128, 255);
            btnbajar.Font = new Font("News706 BT", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnbajar.Location = new Point(45, 184);
            btnbajar.Name = "btnbajar";
            btnbajar.Size = new Size(168, 46);
            btnbajar.TabIndex = 5;
            btnbajar.Text = "Bajar";
            btnbajar.UseVisualStyleBackColor = false;
            btnbajar.Click += btnbajar_Click;
            // 
            // LblContador
            // 
            LblContador.AutoSize = true;
            LblContador.Font = new Font("Exotc350 Bd BT", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblContador.Location = new Point(103, 105);
            LblContador.Name = "LblContador";
            LblContador.Size = new Size(54, 56);
            LblContador.TabIndex = 4;
            LblContador.Text = "0";
            // 
            // txtResultado
            // 
            txtResultado.Dock = DockStyle.Fill;
            txtResultado.Font = new Font("News706 BT", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtResultado.Location = new Point(0, 0);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(478, 339);
            txtResultado.TabIndex = 2;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(721, 339);
            Controls.Add(splitContainer1);
            Name = "Form3";
            Text = "Form3";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Button btnSubir;
        private Button btnbajar;
        private Label LblContador;
        private TextBox txtResultado;
    }
}