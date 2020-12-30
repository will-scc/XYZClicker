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
        private IKeyboardMouseEvents m_GlobalHook;
        private CancellationTokenSource cts;
        private InputSimulator input = new InputSimulator();

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

        private async void btnStart_Click(object sender, EventArgs e)
        {
            btnStop.Visible = true;
            btnStart.Visible = false;

            decimal clicks = numClicks.Value;
            decimal interval = numInterval.Value;
            decimal delay = numDelay.Value;

            cts = new CancellationTokenSource();

            await Task.Run(() => Thread.Sleep((int)delay * 1000));

            Thread thread = new Thread(
                () =>
                {
                    try
                    {
                        ClickingLoop(clicks, interval, cts.Token);
                    }
                    finally
                    {
                        this.Invoke(new Action(() => Completed()));
                    }
                }) { IsBackground = true };
            thread.Start();
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

        private void ClickingLoop(decimal clicks, decimal interval, CancellationToken token)
        {
            int waitTime = (int)interval;

            for (int i = 1; i <= clicks; i++)
            {
                if (token.IsCancellationRequested)
                {
                    return;
                }

                input.Mouse.LeftButtonClick();
                Thread.Sleep(waitTime);
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        private void frmClickerMain_Load(object sender, EventArgs e)
        {

        }
    }
}
