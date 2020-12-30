using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsInput;
using System.Threading;
using Gma.System.MouseKeyHook;

namespace XYZClicker
{
    public partial class frmClickerMain : Form
    {
        private CancellationTokenSource cts;
        
        private readonly IKeyboardMouseEvents m_GlobalHook;
        private readonly InputSimulator input = new InputSimulator();

        public frmClickerMain()
        {
            InitializeComponent();
            
            m_GlobalHook = Hook.GlobalEvents();
            m_GlobalHook.KeyDown += GlobalHookKeyPress;
        }

        private void GlobalHookKeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Cancel();
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Visible = false;
            btnStop.Visible = true;

            decimal clicks = numClicks.Value;
            decimal interval = numInterval.Value;
            decimal delay = numDelay.Value;

            cts = new CancellationTokenSource();

            await Task.Run(() => Thread.Sleep((int)delay * 1000));

            Thread thread = new Thread( async () =>
            {
                try
                {
                    await Clicking(clicks, interval, cts.Token);
                }
                finally
                {
                    Invoke(new Action(() => Completed()));
                }
            })
            { IsBackground = true };
            thread.Start();
        }

        private async Task Clicking(decimal clicks, decimal interval, CancellationToken token)
        {
            int waitTime = (int)interval;

            await Task.Run(() =>
            {
                for (int i = 1; i <= clicks; i++)
                {
                    if (token.IsCancellationRequested)
                    {
                        return;
                    }

                    input.Mouse.LeftButtonClick();
                    Thread.Sleep(waitTime);
                }
            });
        }

        private void Completed()
        {
            btnStop.Visible = false;
            btnStart.Visible = true;
        }

        private void Cancel()
        {
            if (cts != null)
            {
                cts.Cancel();
                Completed();
            }
        }
    }
}
