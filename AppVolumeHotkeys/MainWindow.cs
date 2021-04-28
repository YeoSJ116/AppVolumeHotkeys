﻿using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace AppVolumeHotkeys
{
    public partial class MainWindow : Form
    {
        Keys VolUpHotkey, VolDownHotkey, MuteHotkey, PTTHotkey, ComboKey;
        ComboBox[] KeyArry = new ComboBox[12];

        int VolumeSteps, AppVolume, SoftMuteLevel;
        bool AppMute;
        bool isPTTPressed = false;
        bool SoftMute = false;

        VolumeMixer volumeMixer;

        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);
        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);
        [DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(Keys vKey);

        const int WM_HOTKEY = 0x0312;

        public MainWindow()
        {
            InitializeComponent();

            notifyIcon.ContextMenuStrip = cmsTray;

            VolUpHotkey = Properties.Settings.Default.VolUpHotkey;
            VolDownHotkey = Properties.Settings.Default.VolDownHotkey;
            MuteHotkey = Properties.Settings.Default.MuteHotkey;

            ComboKey = Properties.Settings.Default.ComboKey;

            VolumeSteps = Properties.Settings.Default.LastVolStep;
            SoftMuteLevel = Properties.Settings.Default.SoftMuteLevel;
            PTTHotkey = Properties.Settings.Default.PTTHotkey;

            if (VolumeSteps != 0)
                nudVolumeSteps.Value = VolumeSteps;

            if (SoftMuteLevel != 0)
                nudSoftMuteLevel.Value = SoftMuteLevel;

            RegisterHotKey(this.Handle, 1, (int)ComboKey, (int)VolUpHotkey);
            RegisterHotKey(this.Handle, 2, (int)ComboKey, (int)VolDownHotkey);
            RegisterHotKey(this.Handle, 3, (int)ComboKey, (int)MuteHotkey);

            var converter = new KeysConverter();

            switch ((int)ComboKey)
            {
                case (int)Keys.Alt:
                    cmbComboKey.SelectedIndex = 0;
                    break;
                case (int)Keys.Shift:
                    cmbComboKey.SelectedIndex = 1;
                    break;
                case (int)Keys.Control:
                    cmbComboKey.SelectedIndex = 3;
                    break;
                default:
                    MessageBox.Show("단축키의 조합키를 가져오는데 실패 했습니다.\n 기본 값인 Alt 값으로 재 설정 됩니다.");
                    Properties.Settings.Default.ComboKey = Keys.Alt;
                    Properties.Settings.Default.Save();
                    cmbComboKey.SelectedIndex = 0;
                    break;

            }
            /*
            tbxVolUpHotkey.AppendText(converter.ConvertToString(VolUpHotkey));
            tbxVolDownHotkey.AppendText(converter.ConvertToString(VolDownHotkey));
            tbxMuteHotkey.AppendText(converter.ConvertToString(MuteHotkey));
            tbxPTTHotkey.AppendText(converter.ConvertToString(PTTHotkey))
            */
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
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_HOTKEY && (int)m.WParam == 1)
                VolumeUp();

            if (m.Msg == WM_HOTKEY && (int)m.WParam == 2)
                VolumeDown();

            if (m.Msg == WM_HOTKEY && (int)m.WParam == 3)
            {
                ToggleMute();
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
            //Console.WriteLine(AppVolume +"  "+ cmbAppName.SelectedIndex);
            lblAppVolume.Text = AppVolume.ToString();
            trackVolume.Value = AppVolume;
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

        private void textBox_VolUpHotkey_KeyUp(object sender, KeyEventArgs e)
        {
            if (((int)(e.KeyData ^ e.Modifiers) == 16) || ((int)(e.KeyData ^ e.Modifiers) == 17) || ((int)(e.KeyData ^ e.Modifiers) == 18))
                return;

            var converter = new KeysConverter();
            //tbxVolUpHotkey.Text = converter.ConvertToString(e.KeyData).ToUpper();

            cmbComboKeys2Keys();

            VolUpHotkey = e.KeyData ^ e.Modifiers;

            UnregisterHotKey(this.Handle, 1);
            RegisterHotKey(this.Handle, 1, (int)ComboKey, (int)VolUpHotkey);

            lblAppVolume.Focus(); //dirty workaround to remove focus from textbox after setting hotkey
        }

        private void textBox_VolDownHotkey_KeyUp(object sender, KeyEventArgs e)
        {
            if (((int)(e.KeyData ^ e.Modifiers) == 16) || ((int)(e.KeyData ^ e.Modifiers) == 17) || ((int)(e.KeyData ^ e.Modifiers) == 18))
                return;

            var converter = new KeysConverter();
            //tbxVolDownHotkey.Text = converter.ConvertToString(e.KeyData).ToUpper();

            cmbComboKeys2Keys();

            VolDownHotkey = e.KeyData ^ e.Modifiers;

            UnregisterHotKey(this.Handle, 2);
            RegisterHotKey(this.Handle, 2, (int)ComboKey, (int)VolDownHotkey);

            lblAppVolume.Focus(); //dirty workaround to remove focus from textbox after setting hotkey
        }

        private void textBox_MuteHotkey_KeyUp(object sender, KeyEventArgs e)
        {
            if (((int)(e.KeyData ^ e.Modifiers) == 16) || ((int)(e.KeyData ^ e.Modifiers) == 17) || ((int)(e.KeyData ^ e.Modifiers) == 18))
                return;

            var converter = new KeysConverter();
            //tbxMuteHotkey.Text = converter.ConvertToString(e.KeyData).ToUpper();

            cmbComboKeys2Keys();

            MuteHotkey = e.KeyData ^ e.Modifiers;

            UnregisterHotKey(this.Handle, 3);
            RegisterHotKey(this.Handle, 3, (int)ComboKey, (int)MuteHotkey);

            lblAppVolume.Focus(); //dirty workaround to remove focus from textbox after setting hotkey
        }
        private void tbxPTTHotkey_KeyUp(object sender, KeyEventArgs e)
        {
            var converter = new KeysConverter();
            //tbxPTTHotkey.Text = converter.ConvertToString(e.KeyData).ToUpper();

            PTTHotkey = e.KeyData;

            lblAppVolume.Focus(); //dirty workaround to remove focus from textbox after setting hotkey
        }

        private Keys cmbComboKeys2Keys()
        {
            switch (cmbComboKey.SelectedIndex)
            {
                case 0:
                    ComboKey = Keys.Alt;
                    Debug.WriteLine("alt");
                    break;
                case 1:
                    ComboKey = Keys.Shift;
                    Debug.WriteLine("shift");
                    break;
                case 2:
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

        private void button_SaveHotkeys_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.VolUpHotkey = VolUpHotkey;
            Properties.Settings.Default.VolDownHotkey = VolDownHotkey;
            Properties.Settings.Default.MuteHotkey = MuteHotkey;
            Properties.Settings.Default.PTTHotkey = PTTHotkey;
            Properties.Settings.Default.ComboKey = ComboKey;
            Properties.Settings.Default.Save();
        }

        private void button_ResetHotkeys_Click(object sender, EventArgs e)
        {
            VolUpHotkey = Keys.None;
            VolDownHotkey = Keys.None;
            MuteHotkey = Keys.None;
            PTTHotkey = Keys.None;
            ComboKey = Keys.Alt;

            F1.SelectedIndex = 0;
            F2.SelectedIndex = 0;
            F3.SelectedIndex = 0;
            F4.SelectedIndex = 0;
            F5.SelectedIndex = 0;
            F6.SelectedIndex = 0;
            F7.SelectedIndex = 0;
            F8.SelectedIndex = 0;
            F9.SelectedIndex = 1;
            F10.SelectedIndex = 3;
            F11.SelectedIndex = 2;
            F12.SelectedIndex = 4;
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

                if (!Properties.Settings.Default.FirstNotification)
                {
                    notifyIcon.ShowBalloonTip(5, string.Empty, "창을 닫아도 볼륨 조절 프로그램은 여전히 백그라운드로 실행되고 있습니다. 종료를 원하시면 Tray아이콘 영역에서 우클릭 후 Exit 메뉴를 클릭해 주세요.", ToolTipIcon.None);
                    Properties.Settings.Default.FirstNotification = false;
                    Properties.Settings.Default.Save();
                }

                e.Cancel = true;
                return;
            }

            UnregisterHotKey(this.Handle, 1);
            UnregisterHotKey(this.Handle, 2);
            UnregisterHotKey(this.Handle, 3);
        }

        ///////////////////////////////////////////////
        private void updateKeyList()
        {
            //객체화 되지 않은 키 동작 메뉴(콤보박스)를 자동화 처리를 할 수 없으므로 하나씩 코드를 처리해야합니다.
        }
    }
}