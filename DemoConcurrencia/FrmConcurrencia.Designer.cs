namespace DemoConcurrencia
{
    partial class FrmConcurrencia
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
            splitContainer1 = new SplitContainer();
            btnCancelarProceso = new Button();
            btnIniciarTarea = new Button();
            btnIniciarHilo = new Button();
            btnIniciarSecuencial = new Button();
            txtResultado = new TextBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(2, 1);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(btnCancelarProceso);
            splitContainer1.Panel1.Controls.Add(btnIniciarTarea);
            splitContainer1.Panel1.Controls.Add(btnIniciarHilo);
            splitContainer1.Panel1.Controls.Add(btnIniciarSecuencial);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(txtResultado);
            splitContainer1.Size = new Size(773, 437);
            splitContainer1.SplitterDistance = 257;
            splitContainer1.TabIndex = 3;
            // 
            // btnCancelarProceso
            // 
            btnCancelarProceso.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnCancelarProceso.BackColor = Color.FromArgb(255, 128, 128);
            btnCancelarProceso.Location = new Point(10, 242);
            btnCancelarProceso.Name = "btnCancelarProceso";
            btnCancelarProceso.Size = new Size(203, 45);
            btnCancelarProceso.TabIndex = 3;
            btnCancelarProceso.Text = "Cancelar Proceso";
            btnCancelarProceso.UseVisualStyleBackColor = false;
            btnCancelarProceso.Click += btnCanselarHilo_Click;
            // 
            // btnIniciarTarea
            // 
            btnIniciarTarea.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnIniciarTarea.BackColor = Color.Yellow;
            btnIniciarTarea.Location = new Point(10, 140);
            btnIniciarTarea.Name = "btnIniciarTarea";
            btnIniciarTarea.Size = new Size(203, 45);
            btnIniciarTarea.TabIndex = 2;
            btnIniciarTarea.Text = "Iniciar Tarea";
            btnIniciarTarea.UseVisualStyleBackColor = false;
            btnIniciarTarea.Click += btnIniciarTarea_Click;
            // 
            // btnIniciarHilo
            // 
            btnIniciarHilo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnIniciarHilo.BackColor = Color.DodgerBlue;
            btnIniciarHilo.Location = new Point(10, 77);
            btnIniciarHilo.Name = "btnIniciarHilo";
            btnIniciarHilo.Size = new Size(203, 45);
            btnIniciarHilo.TabIndex = 1;
            btnIniciarHilo.Text = "Iniciar Hilo";
            btnIniciarHilo.UseVisualStyleBackColor = false;
            btnIniciarHilo.Click += btnIniciarHilo_Click;
            // 
            // btnIniciarSecuencial
            // 
            btnIniciarSecuencial.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnIniciarSecuencial.BackColor = Color.FromArgb(128, 255, 128);
            btnIniciarSecuencial.Location = new Point(10, 11);
            btnIniciarSecuencial.Name = "btnIniciarSecuencial";
            btnIniciarSecuencial.Size = new Size(203, 46);
            btnIniciarSecuencial.TabIndex = 0;
            btnIniciarSecuencial.Text = "Iniciar Secuencial";
            btnIniciarSecuencial.UseVisualStyleBackColor = false;
            btnIniciarSecuencial.Click += btnIniciarSecuencial_Click;
            // 
            // txtResultado
            // 
            txtResultado.Dock = DockStyle.Fill;
            txtResultado.Location = new Point(0, 0);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(512, 437);
            txtResultado.TabIndex = 0;
            // 
            // FrmConcurrencia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(779, 442);
            Controls.Add(splitContainer1);
            Name = "FrmConcurrencia";
            Text = "Demostracion de Concurrencia";
            Load += FrmConcurrencia_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Button btnIniciarSecuencial;
        private TextBox txtResultado;
        private Button btnIniciarTarea;
        private Button btnIniciarHilo;
        private Button btnCancelarProceso;
    }
}
