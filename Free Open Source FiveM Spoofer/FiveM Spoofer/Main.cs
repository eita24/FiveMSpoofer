using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Management;
using System.Media;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using KeyAuth;
using KeyAuth.Properties;
using Microsoft.Win32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace KeyAuth
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void siticoneControlBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        string chatchannel = "testing"; // chat channel name

        private void Main_Load(object sender, EventArgs e)
        {
            Login.KeyAuthApp.check();

            var onlineUsers = Login.KeyAuthApp.fetchOnline();

            foreach (var user in onlineUsers)
            {

            }

        }

        public static bool SubExist(string name, int len)
        {
            for (var i = 0; i < len; i++)
            {
                if (Login.KeyAuthApp.user_data.subscriptions[i].subscription == name)
                {
                    return true;
                }
            }
            return false;
        }

        public DateTime UnixTimeToDateTime(long unixtime)
        {
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Local);
            dtDateTime = dtDateTime.AddSeconds(unixtime).ToLocalTime();
            return dtDateTime;
        }

        private void sendmsg_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 15000; // get chat messages every 15 seconds
            if (!String.IsNullOrEmpty(chatchannel))
            {
                var messages = Login.KeyAuthApp.chatget(chatchannel);
                if (messages == null)
                {

                }
                else
                {
                    foreach (var message in messages)
                    {

                    }
                }
            }
        }

        private void siticoneRoundedButton2_Click(object sender, EventArgs e)
        {
            string tempFilename = Path.ChangeExtension(Path.GetTempFileName(), ".bat");
            using (StreamWriter writer = new StreamWriter(tempFilename))
            {
                writer.WriteLine("@echo off");
                writer.WriteLine(@"rmdir / s / q %LocalAppData%\FiveM\FiveM.app\cache\browser");
                writer.WriteLine(@"rmdir / s / q %LocalAppData%\FiveM\FiveM.app\cache\db");
                writer.WriteLine(@"rmdir / s / q %LocalAppData%\FiveM\FiveM.app\cache\priv");
                writer.WriteLine(@"rmdir / s / q %LocalAppData%\FiveM\FiveM.app\cache\servers");
                writer.WriteLine(@"rmdir / s / q %LocalAppData%\FiveM\FiveM.app\cache\subprocess");
                writer.WriteLine(@"rmdir / s / q %LocalAppData%\FiveM\FiveM.app\cache\unconfirmed");
                writer.WriteLine(@"del / s / q / f %LocalAppData%\FiveM\FiveM.app\crashometry");
                writer.WriteLine(@"del / s / q / f %LocalAppData%\FiveM\FiveM.app\launcher_skip_mtl2");
                writer.WriteLine(@"del / s / q / f %LocalAppData%\FiveM\FiveM.app\session");
                writer.WriteLine(@"rmdir / s / q %LocalAppData%\FiveM\FiveM.app\plugins");
                writer.WriteLine(@"rmdir / s / q %LocalAppData%\FiveM\FiveM.app\mods");
                writer.WriteLine(@"rmdir / s / q %LocalAppData%\FiveM\FiveM.app\logs");
                writer.WriteLine(@"rmdir / s / q %LocalAppData%\FiveM\FiveM.app\crashes");
                writer.WriteLine(@"del / s / q / f %LocalAppData%\FiveM\FiveM.app\caches.XML");
                writer.WriteLine(@"del / s / q / f %LocalAppData%\FiveM\FiveM.app\adhesive.dll");
                writer.WriteLine("@echo off");
                writer.WriteLine(@"powercfg - s 8c5e7fda - e8bf - 4a96 - 9a85 - a6e23a8c635c");
                writer.WriteLine(@"taskkill / f / im GTAVLauncher.exe");
                writer.WriteLine(@"wmic process where name = FiveM_b2189_GTAProcess.exe CALL setpriority 128");
                writer.WriteLine(@"taskkill / f / im wmpnetwk.exe.exe");
                writer.WriteLine(@"taskkill / f / im OneDrive.exe");
                writer.WriteLine(@"taskkill / f / im speedfan.exe");
                writer.WriteLine(@"taskkill / f / im TeamWiever_Service.exe");
                writer.WriteLine(@"taskkill / f / im opera.exe");
                writer.WriteLine(@"taskkill / f / im java.exe");
                writer.WriteLine("@echo off");
                writer.WriteLine("del /s /q %systemdrive%\\$Recycle.bin\\*.*");
                writer.WriteLine("@echo off");
                writer.WriteLine("ipconfig /flushdns");
                writer.WriteLine("@echo off");
                writer.WriteLine("del /s /q %systemdrive%\\Windows\\Temp\\*.*");
                writer.WriteLine("del / s / q % userprofile %\\AppData\\Local\\Temp\\*.* ");
            }
            Process process = Process.Start(tempFilename);
            process.WaitForExit();
            File.Delete(tempFilename);
            {
                Process.Start("taskkill", "/F /IM gamingservicesnet.exe");
                Process.Start("taskkill", "/F /IM gamingservices.exe");
                Process.Start("taskkill", "/F /IM gamingservices.exe");
                Process.Start("taskkill", "/F /IM steam.exe");
                Process.Start("taskkill", "/F /IM EpicGamesLauncher.exe");
                Process.Start("taskkill", "/F /IM NVDisplay.Container.exe");
                Process.Start("taskkill", "/F /IM RockstarService.exe");
                Process.Start("taskkill", "/F /IM FiveM.exe");

                Process.Start("https://discord.gg/unban");

                string message = "FiveM Spoofed!";
                string title = "discord.gg/unban";
                MessageBox.Show(message, title);
            }
        }

        private void siticoneRoundedButton1_Click(object sender, EventArgs e)
        {

            string tempFilename = Path.ChangeExtension(Path.GetTempFileName(), ".bat");
            using (StreamWriter writer = new StreamWriter(tempFilename))
            {
                writer.WriteLine(@"echo off");
                writer.WriteLine(@"taskkill / f / im Steam.exe / t");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"rmdir / s / q % LocalAppData%\DigitalEntitlements");
                writer.WriteLine(@"taskkill / f / im Steam.exe / t");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"rmdir / s / q % userprofile %\AppData\Roaming\CitizenFX");
                writer.WriteLine(@"taskkill / f / im Steam.exe / t");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"set hostspath =% windir %\System32\drivers\etc\hosts");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"echo 127.0.0.1 xboxlive.com >> % hostspath %");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"echo 127.0.0.1 user.auth.xboxlive.com >> % hostspath %");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"echo 127.0.0.1 presence - heartbeat.xboxlive.com >> % hostspath %");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"REG DELETE HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\MSLicensing\HardwareID / f");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"REG DELETE HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\MSLicensing\Store / f");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"DELETE HKEY_CURRENT_USER\Software\WinRAR\ArcHistory / f");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"REG DELETE HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Services\bam\State\UserSettings\S - 1 - 5 - 21 - 1282084573 - 1681065996 - 3115981261 - 1001 / va / f");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"REG DELETEH KEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\FeatureUsage\ShowJumpView / f");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"REG DELETEH KEY_CURRENT_USER\Software\Classes\Local Settings\Software\Microsoft\Windows\Shell\MuiCache / f");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"REG DELETE HKEY_CURRENT_USER\Software\WinRAR\ArcHistory / f");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"REG DELETE HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\FeatureUsage\AppSwitched / f");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"REG DELETE HKEY_CLASSES_ROOT\Local Settings\Software\Microsoft\Windows\Shell\MuiCache / f");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"REG DELETE HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\FeatureUsage\ShowJumpView / f");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"REG DELETE HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Services\bam\State\UserSettings\S - 1 - 5 - 21 - 332004695 - 2829936588 - 140372829 - 1002 / f");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"REG DELETE HKEY_CLASSES_ROOT\Local Settings\Software\Microsoft\Windows\Shell\MuiCache / f");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"REG DELETE HKEY_CURRENT_USER\Software\Classes\Local Settings\Software\Microsoft\Windows\Shell\MuiCache / f");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"REG DELETE HKEY_CURRENT_USER\Software\Microsoft\Windows NT\CurrentVersion\AppCompatFlags\Compatibility Assistant\Store / f");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"REG DELETE HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\FeatureUsage\AppSwitched / f");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"REG DELETE HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Services\bam\State\UserSettings\S - 1 - 5 - 21 - 1282084573 - 1681065996 - 3115981261 - 1001 / f");
                writer.WriteLine("cls");
                writer.WriteLine(@"REG DELETE HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\FeatureUsage\AppSwitched / f");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"del / s / q / f % LocalAppData %\FiveM\FiveM.app\CitizenFX_SubProcess_chrome.bin");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"del / s / q / f % LocalAppData %\FiveM\FiveM.app\CitizenFX_SubProcess_game.bin");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"del / s / q / f % LocalAppData %\FiveM\FiveM.app\CitizenFX_SubProcess_game_372.bin");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"del / s / q / f % LocalAppData %\FiveM\FiveM.app\CitizenFX_SubProcess_game_1604.bin");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"del / s / q / f % LocalAppData %\FiveM\FiveM.app\CitizenFX_SubProcess_game_1868.bin");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"del / s / q / f % LocalAppData %\FiveM\FiveM.app\CitizenFX_SubProcess_game_2060.bin");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"del / s / q / f % LocalAppData %\FiveM\FiveM.app\CitizenFX_SubProcess_game_2189.bin");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"del / s / q / f % LocalAppData %\FiveM\FiveM.app\botan.dll");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"del / s / q / f % LocalAppData %\FiveM\FiveM.app\asi - five.dll");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"del / s / q / f % LocalAppData %\FiveM\FiveM.app\steam.dll");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"del / s / q / f % LocalAppData %\FiveM\FiveM.app\steam_api64.dll");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"del / s / q / f % LocalAppData %\FiveM\FiveM.app\CitizenGame.dll");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"del / s / q / f % LocalAppData %\FiveM\FiveM.app\profiles.dll");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"del / s / q / f %LocalAppData%\FiveM\FiveM.app\cfx_curl_x86_64.dll");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"del / s / q / f % LocalAppData %\FiveM\FiveM.app\CitizenFX.ini");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"del / s / q / f % LocalAppData %\FiveM\FiveM.app\caches.XML");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"del / s / q / f % LocalAppData %\FiveM\FiveM.app\adhesive.dll");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"taskkill / f / im Steam.exe / t");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"del / s / q / f % LocalAppData %\FiveM\FiveM.app\discord.dll");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"RENAME % userprofile %\AppData\Roaming\discord\0.0.309\modules\discord_rpc STARCHARMS_SPOOFER");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"rmdir / s / q %LocalAppData%\FiveM\FiveM.app\cache\Browser");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"rmdir / s / q %LocalAppData%\FiveM\FiveM.app\cache\db");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"rmdir / s / q %LocalAppData%\FiveM\FiveM.app\cache\dunno");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"rmdir / s / q %LocalAppData%\FiveM\FiveM.app\cache\priv");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"rmdir / s / q %LocalAppData%\FiveM\FiveM.app\cache\servers");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"rmdir / s / q %LocalAppData%\FiveM\FiveM.app\cache\subprocess");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"rmdir / s / q %LocalAppData%\FiveM\FiveM.app\cache\unconfirmed");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"rmdir / s / q %LocalAppData%\FiveM\FiveM.app\cache\authbrowser");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"del / s / q / f %LocalAppData%\FiveM\FiveM.app\cache\crashometry");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"del / s / q / f %LocalAppData%\FiveM\FiveM.app\cache\launcher_skip");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"del / s / q / f %LocalAppData%\FiveM\FiveM.app\cache\launcher_skip_mtl2");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"del / s / q / f %LocalAppData%\FiveM\FiveM.app\crashes\*.* ");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"del / s / q / f %LocalAppData%\FiveM\FiveM.app\logs\*.* ");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"del / s / q / f %LocalAppData%\FiveM\FiveM.app\mods\*.* ");
                writer.WriteLine(@":folderclean");
                writer.WriteLine(@"call :getDiscordVersion");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"goto :xboxclean");
                writer.WriteLine(@": getDiscordVersion");
                writer.WriteLine(@"for / d %% a in (' % appdata%\Discord\*') do (");
                writer.WriteLine(@"     set 'varLoc =%%a'");
                writer.WriteLine(@"   goto :d1");
                writer.WriteLine(@")");
                writer.WriteLine(@":d1");
                writer.WriteLine(@"for / f 'delims =\ tokens=7' %% z in ('echo %varLoc%') do (");
                writer.WriteLine(@"     set 'discordVersion =%%z'");
                writer.WriteLine(@")");
                writer.WriteLine(@"goto :EOF");
                writer.WriteLine(@": xboxclean");
                writer.WriteLine(@" cls");
                writer.WriteLine(@"powershell - Command ' & {Get-AppxPackage -AllUsers xbox | Remove-AppxPackage}'");
                writer.WriteLine(@"sc stop XblAuthManager");
                writer.WriteLine(@"sc stop XblGameSave");
                writer.WriteLine(@"sc stop XboxNetApiSvc");
                writer.WriteLine(@"sc stop XboxGipSvc");
                writer.WriteLine(@"sc delete XblAuthManager");
                writer.WriteLine(@"sc delete XblGameSave");
                writer.WriteLine(@"sc delete XboxNetApiSvc");
                writer.WriteLine(@"sc delete XboxGipSvc");
                writer.WriteLine(@"reg delete 'HKLM\SYSTEM\CurrentControlSet\Services\xbgm' / f");
                writer.WriteLine(@"schtasks / Change / TN 'Microsoft\XblGameSave\XblGameSaveTask' / disable");
                writer.WriteLine(@"schtasks / Change / TN 'Microsoft\XblGameSave\XblGameSaveTaskLogon' / disableL");
                writer.WriteLine(@"reg add 'HKLM\SOFTWARE\Policies\Microsoft\Windows\GameDVR' / v AllowGameDVR / t REG_DWORD / d 0 / f");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"set hostspath =% windir %\System32\drivers\etc\hosts");
                writer.WriteLine(@"echo 127.0.0.1 xboxlive.com >> % hostspath %");
                writer.WriteLine(@"echo 127.0.0.1 user.auth.xboxlive.com >> % hostspath % ");
                writer.WriteLine(@"echo 127.0.0.1 presence - heartbeat.xboxlive.com >> % hostspath %");
                writer.WriteLine(@"rd % userprofile %\AppData\Local\DigitalEntitlements / q / s");
                writer.WriteLine(@"exit");
                writer.WriteLine(@"goto :eof");
            }
            Process process = Process.Start(tempFilename);
            process.WaitForExit();
            File.Delete(tempFilename);

            Process.Start("https://discord.gg/unban");

            string message = "Unlinked Successfully!";
            string title = "discord.gg/unban";
            MessageBox.Show(message, title);
        }

        private void siticoneRoundedButton3_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/unban");
        }
    }
}