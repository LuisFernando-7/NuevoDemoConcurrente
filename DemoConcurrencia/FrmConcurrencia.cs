namespace DemoConcurrencia
{
    public partial class FrmConcurrencia : Form
    {
        private CancellationTokenSource _cts;
        public FrmConcurrencia()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmConcurrencia_Load(object sender, EventArgs e)
        {

        }

        private void btnIniciarSecuencial_Click(object sender, EventArgs e)
        {
            ActulizarResultado("Iniciando proceso secuencial");
            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(2000);
                ActulizarResultado($" Actividad - paso {i + 1}");
            }
            ActulizarResultado("Fin del proceso secuencial");
        }
        private void ActulizarResultado(string mensaje)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => ActulizarResultado(mensaje)));
                return;
            }
            txtResultado.AppendText($"{DateTime.Now:HH:mm:ss.fff}: {mensaje} {Environment.NewLine} ");
        }

        private void btnIniciarHilo_Click(object sender, EventArgs e)
        {
            _cts = new CancellationTokenSource();
            var token = _cts.Token;

            Thread hilo1 = new Thread(() =>
            {
                try
                {
                    ActulizarResultado($"Iniciar nuevo thread {Thread.CurrentThread.ManagedThreadId}...");
                    for (int i = 0; i < 5; i++)
                    {
                        token.ThrowIfCancellationRequested();

                        Thread.Sleep(2000);
                        ActulizarResultado($" Actividad en hilo {Thread.CurrentThread.ManagedThreadId} - Paso {i + 1} ");
                    }
                    ActulizarResultado($"Thread {Thread.CurrentThread.ManagedThreadId} terminado.");
                }
                catch (OperationCanceledException)
                {

                    ActulizarResultado("Hilo cancelado. ");
                }
                
            });
            hilo1.Start();
        }

        private async void btnIniciarTarea_Click(object sender, EventArgs e)
        {
            _cts = new CancellationTokenSource();
            var token = _cts.Token;

            await Task.Run(() =>
                  {
                      try
                      {
                          ActulizarResultado($"Iniciando Task {Task.CurrentId}...");
                          for (int i = 0; i < 5; i++)
                          {
                              token.ThrowIfCancellationRequested();

                              Thread.Sleep(2000);
                              ActulizarResultado($" Actividad en tarea {Task.CurrentId} - paso {i + 1}");
                          }
                          ActulizarResultado($"Task {Task.CurrentId} completada");
                      }
                      catch (OperationCanceledException)
                      {

                          ActulizarResultado("Tarea Cancelada. ");
                      }
                    
                  });
        }

        private void btnCanselarHilo_Click(object sender, EventArgs e)
        {
            _cts?.Cancel();
        }
    }
}
