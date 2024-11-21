﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoConcurrencia
{
    public partial class FrmAsensor : Form
    {
        private int contador = 0;
        private object bloqueo = new();
        private SemaphoreSlim semaforo = new SemaphoreSlim(2);
        public FrmAsensor()
        {
            InitializeComponent();
        }

        private void btnSubir_Click(object sender, EventArgs e)
        {


            Task.Run(() =>
            {
                semaforo.Wait();

                lock (bloqueo)
                {
                    contador++;
                    Thread.Sleep(1000);

                    this.Invoke((MethodInvoker)delegate
                    {
                        LblContador.Text = contador.ToString();
                    });
                    Monitor.Pulse(bloqueo);
                }

            });

        }

        private void btnbajar_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                lock (bloqueo)
                {
                    while (contador <= 0)
                    {
                        ActulizarResultado("Subiendo...");
                        Monitor.Wait(bloqueo);
                    }

                    if (contador > 0)
                    {

                        contador--;
                        Thread.Sleep(1000);

                        this.Invoke((MethodInvoker)delegate
                        {
                            LblContador.Text = contador.ToString();
                        });
                    }
                    ActulizarResultado("Bajando...");
                }
            });
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
    }
    
}
