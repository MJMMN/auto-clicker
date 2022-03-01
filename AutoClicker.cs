using System.Runtime.InteropServices;
using Timer = System.Windows.Forms.Timer;

namespace auto_clicker;

public partial class AutoClicker : Form
{
    private bool _running;

    public AutoClicker()
    {
        InitializeComponent();

        Stop();
    }

    private void _btnStart_Click(object sender, EventArgs e)
    {
        Start();
    }

    private void _btnStop_Click(object sender, EventArgs e)
    {
        Stop();
    }

    private void Form1_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.F6 && !_running)
        {
            Start();
        }
        else if (e.KeyCode == Keys.F7 && _running)
        {
            Stop();
        }
    }

    private void Start()
    {
        if (_running) return;

        _clickDurationTimer.Interval = (int)_numericDurationS.Value * 1000;
        _clickEveryTimer.Interval = (int)_numericEveryMS.Value;


        _btnStop.Enabled = true;
        _btnStart.Enabled = false;

        _clickDurationTimer.Start();
        _clickEveryTimer.Start();

        _running = true;
    }

    private void Stop()
    {
        _clickDurationTimer.Stop();
        _clickEveryTimer.Stop();

        _btnStop.Enabled = false;
        _btnStart.Enabled = true;

        _running = false;
    }

    private void _clickDurationTimer_Tick(object sender, EventArgs e)
    {
        Stop();
    }

    private void _clickEveryTimer_Tick(object sender, EventArgs e)
    {
        //Call the imported function with the cursor's current position
        uint X = (uint)Cursor.Position.X;
        uint Y = (uint)Cursor.Position.Y;
        mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
    }

    [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
    public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);
    //Mouse actions
    private const int MOUSEEVENTF_LEFTDOWN = 0x02;
    private const int MOUSEEVENTF_LEFTUP = 0x04;
    private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
    private const int MOUSEEVENTF_RIGHTUP = 0x10;

}
