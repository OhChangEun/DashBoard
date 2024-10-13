using System.Runtime.InteropServices;

namespace DashBoard
{
    public partial class Form1 : Form
    {
        private Button currentButton;

        // 윈도우 메시지를 처리하기 위한 Win32 API 상수
        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;
        private const int HTLEFT = 10;
        private const int HTRIGHT = 11;
        private const int HTTOP = 12;
        private const int HTTOPLEFT = 13;
        private const int HTTOPRIGHT = 14;
        private const int HTBOTTOM = 15;
        private const int HTBOTTOMLEFT = 16;
        private const int HTBOTTOMRIGHT = 17;

        public Form1()
        {
            InitializeComponent();
        }

        // WinAPI 함수 선언
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern IntPtr SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        // 상수 설정
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            // 폼 위치 이동
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }
        protected override void WndProc(ref Message m) // 폼 크기 조절
        {
            base.WndProc(ref m);

            if (m.Msg == WM_NCHITTEST)
            {
                // 마우스 위치에 따른 크기 조절 방향 설정
                var pos = this.PointToClient(new System.Drawing.Point(m.LParam.ToInt32()));
                if (pos.X <= 5)
                {
                    if (pos.Y <= 5) m.Result = (IntPtr)HTTOPLEFT;
                    else if (pos.Y >= ClientSize.Height - 5) m.Result = (IntPtr)HTBOTTOMLEFT;
                    else m.Result = (IntPtr)HTLEFT;
                }
                else if (pos.X >= ClientSize.Width - 5)
                {
                    if (pos.Y <= 5) m.Result = (IntPtr)HTTOPRIGHT;
                    else if (pos.Y >= ClientSize.Height - 5) m.Result = (IntPtr)HTBOTTOMRIGHT;
                    else m.Result = (IntPtr)HTRIGHT;
                }
                else if (pos.Y <= 5) m.Result = (IntPtr)HTTOP;
                else if (pos.Y >= ClientSize.Height - 5) m.Result = (IntPtr)HTBOTTOM;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new Font("맑은 고딕", 12, FontStyle.Regular, GraphicsUnit.Point);
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control prevBtn in panelMenu.Controls)
            {
                if (prevBtn.GetType() == typeof(Button))
                {
                    prevBtn.BackColor = Color.FromArgb(51, 51, 76);
                    prevBtn.ForeColor = Color.Gainsboro;
                    prevBtn.Font = new Font("맑은 고딕", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
                }

            }
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }
    }
}