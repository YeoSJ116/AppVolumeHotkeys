using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace AppVolumeHotkeys
{
    public partial class MainWindow : Form
    {
        Keys ComboKey;
        Keys[] keyID = new Keys[12];
        byte[] hotkeys = new byte[12];
        ComboBox[] KeyArry = new ComboBox[12];
        const int HOTKEY_PORT = 153;

        enum ComboID{
            Alt = 0,
            Shift = 1,
            Ctrl = 2,
            non = 3
        }
        enum FnID
        {
            non = 0,
            ptt = 1,
            mute = 2,
            down = 3,
            up = 4
        }
        int VolumeSteps, AppVolume, SoftMuteLevel;
        bool AppMute;
        bool isPTTPressed = false;
        bool SoftMute = false;

        VolumeMixer volumeMixer;

        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, Keys vk);
        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);
        [DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(Keys vKey);

        const int WM_HOTKEY = 0x0312;

        public MainWindow()
        {
            InitializeComponent();
            
            notifyIcon.ContextMenuStrip = cmsTray;

            ComboKey = Properties.Settings.Default.ComboKey;

            VolumeSteps = Properties.Settings.Default.LastVolStep;
            if (VolumeSteps != 0)
                nudVolumeSteps.Value = VolumeSteps;

            SoftMuteLevel = Properties.Settings.Default.SoftMuteLevel;
            if (SoftMuteLevel != 0)
                nudSoftMuteLevel.Value = SoftMuteLevel;

            KeyArry[0] = F1;
            KeyArry[1] = F2;
            KeyArry[2] = F3;
            KeyArry[3] = F4;
            KeyArry[4] = F5;
            KeyArry[5] = F6;
            KeyArry[6] = F7;
            KeyArry[7] = F8;
            KeyArry[8] = F9;
            KeyArry[9] = F10;
            KeyArry[10] = F11;
            KeyArry[11] = F12;

            keyID[0] = Keys.F1;
            keyID[1] = Keys.F2;
            keyID[2] = Keys.F3;
            keyID[3] = Keys.F4;
            keyID[4] = Keys.F5;
            keyID[5] = Keys.F6;
            keyID[6] = Keys.F7;
            keyID[7] = Keys.F8;
            keyID[8] = Keys.F9;
            keyID[9] = Keys.F10;
            keyID[10] = Keys.F11;
            keyID[11] = Keys.F12;

            //Double 형태로 저장된 레이아웃 불러오기
            Double rawKeys = Properties.Settings.Default.Keys;
            Debug.WriteLine(rawKeys);
            Double mask = 100000000000;
            for (int i = 11; i >= 0; i--) {
                hotkeys[i] = (byte)(rawKeys / mask);
                rawKeys = rawKeys % mask;
                
                mask = mask / 10;
            }

            //단축키 레이아웃 불러오기
            for (int i = 0; i < 12; i++)
            {
                try
                {
                    KeyArry[i].SelectedIndex = hotkeys[i];
                }
                catch
                {
                    MessageBox.Show("잘못된 단축키 레이아웃 입니다.\n이전 레이아웃 데이터는 손실 됩니다.");
                    Properties.Settings.Default.Keys = 0;
                    Properties.Settings.Default.Save();
                    break;
                }
            }

            var converter = new KeysConverter();

            switch ((int)ComboKey)
            {
                case (int)Keys.Alt:
                    cmbComboKey.SelectedIndex = (int)ComboID.Alt;
                    break;
                case (int)Keys.Shift:
                    cmbComboKey.SelectedIndex = (int)ComboID.Shift;
                    break;
                case (int)Keys.Control:
                    cmbComboKey.SelectedIndex = (int)ComboID.Ctrl;
                    break;
                case (int)Keys.None:
                    cmbComboKey.SelectedIndex = (int)ComboID.non;
                    break;
                default:
                    MessageBox.Show("단축키의 조합키를 가져오는데 실패 했습니다.\n 기본 값인 non 값으로 재 설정 됩니다.");
                    Properties.Settings.Default.ComboKey = Keys.None;
                    Properties.Settings.Default.Save();
                    cmbComboKey.SelectedIndex = (int)ComboID.non;
                    break;
            }

            VolumeSteps = decimal.ToInt32(nudVolumeSteps.Value);

            volumeMixer = new VolumeMixer();

            cmbEndpoints.DataSource = volumeMixer.GetEndpointNames();
            cmbAppName.DataSource = volumeMixer.GetSessionNames();

            int maxwidth = 166;

            foreach (string item in cmbEndpoints.Items)
                if (maxwidth < TextRenderer.MeasureText(item, cmbEndpoints.Font).Width)
                    maxwidth = TextRenderer.MeasureText(item, cmbEndpoints.Font).Width;

            cmbEndpoints.DropDownWidth = maxwidth;

            maxwidth = 166;

            foreach (string item in cmbAppName.Items)
                if (maxwidth < TextRenderer.MeasureText(item, cmbAppName.Font).Width)
                    maxwidth = TextRenderer.MeasureText(item, cmbAppName.Font).Width;

            cmbAppName.DropDownWidth = maxwidth;

            if (cmbEndpoints.FindStringExact(Properties.Settings.Default.LastEndpointName) != -1)
                cmbEndpoints.SelectedIndex = cmbEndpoints.FindStringExact(Properties.Settings.Default.LastEndpointName);

            hotkeyRegist();
            for (int i = 0; i < 12; i++)
            {
                KeyArry[i].SelectedIndexChanged += updateKeyList;
            }
            cmbComboKey.SelectedIndexChanged += cmbComboKey_SelectedIndexChanged;
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_HOTKEY)
            {
                Debug.WriteLine("WM_HOTKEY" + ((int)m.WParam - HOTKEY_PORT));
                try
                {
                    switch (KeyArry[(int)m.WParam - HOTKEY_PORT].SelectedIndex)
                    {
                        case (int)FnID.up:
                            Debug.WriteLine("Hotkey up");
                            VolumeUp();
                            break;
                        case (int)FnID.down:
                            Debug.WriteLine("Hotkey down");
                            VolumeDown();
                            break;
                        case (int)FnID.mute:
                            Debug.WriteLine("Hotkey mute");
                            ToggleMute();
                            break;
                        default:
                            Debug.WriteLine("Hotkey throw");
                            break;
                    }
                }
                catch
                {
                    Debug.WriteLine("out of range hotkeys");
                }
                
            }

            base.WndProc(ref m);
        }
        private void btnAppNameRefresh_Click(object sender, EventArgs e)
        {
            cmbAppName.DataSource = volumeMixer.GetSessionNames();
        }

        private void btnEndpointsRefresh_Click(object sender, EventArgs e)
        {
            cmbEndpoints.DataSource = volumeMixer.GetEndpointNames();
        }

        /// <summary>
        /// 이 함수에 버그가 있음
        /// 기존 프로그램의 볼륨을 변경한 다음 다른 프로그램을 선택하면 해당 볼륨에도 영향을 줍니다.
        /// 프로그램 선택이 바뀐 경우 이전에 설정된 볼륨을 사용하기 이전에 변경된 프로그램의 볼륨을 먼저 읽어야 합니다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbAppName_SelectedIndexChanged(object sender, EventArgs e)
        {
            volumeMixer.SetEndpoint(cmbEndpoints.SelectedIndex);
            WriteVolumeValue();
            WriteMuteLabel();
        }

        private void cmbEndpoints_SelectedIndexChanged(object sender, EventArgs e)
        {
            volumeMixer.SetEndpoint(cmbEndpoints.SelectedIndex);
            cmbAppName.DataSource = volumeMixer.GetSessionNames();
        }

        public void VolumeUp()
        {
            volumeMixer.SetApplicationVolume(cmbAppName.SelectedIndex, AppVolume + VolumeSteps);
            WriteVolumeValue();
        }

        public void VolumeDown()
        {
            volumeMixer.SetApplicationVolume(cmbAppName.SelectedIndex, AppVolume - VolumeSteps);
            WriteVolumeValue();
        }
        public void ToggleMute()
        {
            if (AppMute == false)
                volumeMixer.SetApplicationMute(cmbAppName.SelectedIndex, true);
            else volumeMixer.SetApplicationMute(cmbAppName.SelectedIndex, false);
            WriteMuteLabel();
        }

        public void WriteVolumeValue()
        {
            AppVolume = volumeMixer.GetApplicationVolume(cmbAppName.SelectedIndex);
            //Debug.WriteLine("Volume: " + AppVolume +"\t"+ cmbAppName.SelectedIndex);
            lblAppVolume.Text = AppVolume.ToString();
            trackVolume.Value = AppVolume;
            WriteMuteLabel();
        }

        public void WriteMuteLabel()
        {
            AppMute = volumeMixer.GetApplicationMute(cmbAppName.SelectedIndex);
            if (AppMute)
                lblAppVolume.Text = "Mute";
            else lblAppVolume.Text = AppVolume.ToString();
        }

        private void numericUpDown_VolumeSteps_ValueChanged(object sender, EventArgs e)
        {
            VolumeSteps = (int)nudVolumeSteps.Value;
        }

        private void numericUpDown_VolumeSteps_KeyDown(object sender, KeyEventArgs e)
        {
            VolumeSteps = (int)nudVolumeSteps.Value;
        }

        private Keys cmbComboKeys2Keys()
        {
            switch (cmbComboKey.SelectedIndex)
            {
                case (int)ComboID.Alt:
                    ComboKey = Keys.Alt;
                    Debug.WriteLine("alt");
                    break;
                case (int)ComboID.Shift:
                    ComboKey = Keys.Shift;
                    Debug.WriteLine("shift");
                    break;
                case (int)ComboID.Ctrl:
                    ComboKey = Keys.Control;
                    Debug.WriteLine("ctrl");
                    break;
                default:
                    ComboKey = Keys.Alt;
                    Debug.WriteLine("alt - defualt");
                    break;
            }

            return ComboKey;
        }
        private void keys2cmbComboKeys()
        {
            switch (ComboKey)
            {
                case Keys.Alt:
                    cmbComboKey.SelectedIndex = (int)ComboID.Alt;
                    Debug.WriteLine("k2c alt");
                    break;
                case Keys.Shift:
                    cmbComboKey.SelectedIndex = (int)ComboID.Shift;
                    Debug.WriteLine("k2c shift");
                    break;
                case Keys.Control:
                    cmbComboKey.SelectedIndex = (int)ComboID.Ctrl;
                    Debug.WriteLine("k2c ctrl");
                    break;
                default:
                    ComboKey = Keys.Alt;
                    Debug.WriteLine("k2c alt - defualt");
                    break;
            }
        }

        private void button_SaveHotkeys_Click(object sender, EventArgs e)
        {
            Double rawHotKeys = 0;
            Double mask = 1;
            for (int i = 0; i < 12; i++)
            {
                rawHotKeys += hotkeys[i] * mask;
                mask *= 10;
            }
            Properties.Settings.Default.Keys = rawHotKeys;
            Properties.Settings.Default.ComboKey = ComboKey;
            Properties.Settings.Default.Save();
        }

        private void button_ResetHotkeys_Click(object sender, EventArgs e)
        {
            ComboKey = Keys.None;
            cmbComboKey.SelectedIndex = (int)ComboID.non;

            F1.SelectedIndex = (int)FnID.non;
            F2.SelectedIndex = (int)FnID.non;
            F3.SelectedIndex = (int)FnID.non;
            F4.SelectedIndex = (int)FnID.non;
            F5.SelectedIndex = (int)FnID.non;
            F6.SelectedIndex = (int)FnID.non;
            F7.SelectedIndex = (int)FnID.non;
            F8.SelectedIndex = (int)FnID.non;
            F9.SelectedIndex = (int)FnID.down;
            F10.SelectedIndex = (int)FnID.mute;
            F11.SelectedIndex = (int)FnID.up;
            F12.SelectedIndex = (int)FnID.ptt;

            updateKeyList();

            button_SaveHotkeys_Click(sender, e);
        }

        /// <summary>
        /// 이 함수에 버그가 있음
        /// 새로운 구성요소인 슬라이드와 함께 사용되면 timer_Refresh_Tick에 의해 볼륨이 다시 복구되는 버그가 생김
        /// 이 timer가 없어도 잘 동작함
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_Refresh_Tick(object sender, EventArgs e)
        {
            //WriteVolumeValue();
            //WriteVolumeLabel();
        }

        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
        }

        private void notifyIcon_MouseMove(object sender, MouseEventArgs e)
        {
            if (AppMute)
                notifyIcon.Text = "Program volume controller\n볼륨: " + AppVolume.ToString() + " | 음소거됨";
            else notifyIcon.Text = "Program volume controller\n볼륨: " + AppVolume.ToString();
        }

        private void itemOpen_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void timer_ptt_Tick(object sender, EventArgs e)
        {
            /*
            if ((GetAsyncKeyState(PTTHotkey) & 0x8000) != 0 && !isPTTPressed)
            {
                volumeMixer.SetApplicationVolume(cmbAppName.SelectedIndex, (int)nudSoftMuteLevel.Value);
                isPTTPressed = true;
            }
            if ((GetAsyncKeyState(PTTHotkey) & 0x8000) == 0)
            {
                isPTTPressed = false;
                volumeMixer.SetApplicationVolume(
                    cmbAppName.SelectedIndex,
                    AppVolume);
            }
            */
        }

        private void trackVolume_Scroll(object sender, EventArgs e)
        {
            AppVolume = trackVolume.Value;
            volumeMixer.SetApplicationVolume(cmbAppName.SelectedIndex, AppVolume);
            WriteVolumeValue();
        }

        private void nudSoftMuteLevel_ValueChanged(object sender, EventArgs e)
        {
            SoftMuteLevel = (int)nudSoftMuteLevel.Value;
        }
        private void nudSoftMuteLevel_KeyDown(object sender, KeyEventArgs e)
        {
            SoftMuteLevel = (int)nudSoftMuteLevel.Value;
        }

        private void checkBox_SoftMute_CheckedChanged(object sender, EventArgs e)
        {
            SoftMute = !SoftMute;
        }

        private void itemVolUp_Click(object sender, EventArgs e)
        {
            VolumeUp();
        }

        private void itemVolDown_Click(object sender, EventArgs e)
        {
            VolumeDown();
        }

        private void itemMute_Click(object sender, EventArgs e)
        {
            ToggleMute();
        }
        private void itemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.LastVolStep = decimal.ToInt32(nudVolumeSteps.Value);
            Properties.Settings.Default.SoftMuteLevel = decimal.ToInt32(nudSoftMuteLevel.Value);
            Properties.Settings.Default.LastEndpointName = cmbEndpoints.Text;
            Properties.Settings.Default.Save();

            if (e.CloseReason == CloseReason.UserClosing)
            {
                this.Hide();

                if (Properties.Settings.Default.FirstNotification)
                {
                    notifyIcon.ShowBalloonTip(5, string.Empty, "창을 닫아도 볼륨 조절 프로그램은 여전히 백그라운드로 실행되고 있습니다. 종료를 원하시면 Tray아이콘 영역에서 우클릭 후 Exit 메뉴를 클릭해 주세요.", ToolTipIcon.None);
                    Properties.Settings.Default.FirstNotification = false;
                    Properties.Settings.Default.Save();
                }

                e.Cancel = true;
                return;
            }

            unHotkeyRegist();
        }

        ///////////////////////////////////////////////
        private void updateKeyList(object sender = null, EventArgs e = null)
        {
            //객체화 되지 않은 키 동작 메뉴(콤보박스)를 자동화 처리를 할 수 없으므로 하나씩 코드를 처리해야합니다.
            for (int i = 0; i < 12; i++)
            {
                  hotkeys[i] = (byte)KeyArry[i].SelectedIndex;
            }
            unHotkeyRegist();
            hotkeyRegist();
        }

        private void cmbComboKey_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void hotkeyRegist()
        {
            int combokey_t = 0; //combo key 없음
            switch (ComboKey)
            {
                case Keys.Alt:
                    combokey_t = 1;
                    Debug.WriteLine("Combo key convert to Alt");
                    break;
                case Keys.Shift:
                    combokey_t = 4;
                    Debug.WriteLine("Combo key convert to Shift");
                    break;
                case Keys.Control:
                    combokey_t = 2;
                    Debug.WriteLine("Combo key convert to Ctrl");
                    break;
                default:
                    break;  
            }
            for (int i = 0; i < 12; i++)
            {
                switch (KeyArry[i].SelectedIndex)
                {
                    case (int)FnID.up:
                        RegisterHotKey(this.Handle, i + HOTKEY_PORT, combokey_t, keyID[i]);
                        Debug.WriteLine(keyID[i].ToString() + "\t" + (i+1) + "\tRegisted up");
                        break;
                    case (int)FnID.down:
                        RegisterHotKey(this.Handle, i + HOTKEY_PORT, combokey_t, keyID[i]);
                        Debug.WriteLine(keyID[i].ToString() + "\t" + (i+1) + "\tRegisted down");
                        break;
                    case (int)FnID.mute:
                        RegisterHotKey(this.Handle, i + HOTKEY_PORT, combokey_t, keyID[i]);
                        Debug.WriteLine(keyID[i].ToString() + "\t" + (i+1) + "\tRegisted mute");
                        break;
                    case (int)FnID.ptt:
                        break;
                    default:
                        break;
                }
            }

        }
        private void unHotkeyRegist()
        {
            for (int i = 0; i < 12; i++)
            {
                UnregisterHotKey(this.Handle, i + HOTKEY_PORT);
                Debug.WriteLine("Un regist F" + (i+1));
            }
        }

    }
}