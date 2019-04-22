using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Diagnostics;
using System.Runtime.InteropServices;
using System.IO;

namespace Randomizer
{
    static class Program
    {
        private const int WH_KEYBOARD_LL = 13;
        private const int WM_KEYDOWN = 0x0100;
        private static LowLevelKeyboardProc _proc = HookCallback;
        private static IntPtr _hookID = IntPtr.Zero;

        public static Form1 form;
        public static Random rand;

        private const string logFile = @"\log.txt";
        public const string configFile = @"\config.txt";
        public static string rootFolder = Application.StartupPath;

        public static int hotkey;
        public static int disableApp;
        public static int quit;

        public static int min;
        public static int max;

        public static string backColor;
        public static bool alwaysOnTop;
        public static int opacity;
        public static bool saveLog = false;

        public static bool disabled = false;
        private static bool lastKeyControl = false;

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            readConfigFile();
            rand = new Random();

            //var handle = GetConsoleWindow();

            // Hide
            //ShowWindow(handle, SW_HIDE);

            _hookID = SetHook(_proc);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(form = new Form1());

            UnhookWindowsHookEx(_hookID);
        }

        private static IntPtr SetHook(LowLevelKeyboardProc proc)
        {
            using (Process curProcess = Process.GetCurrentProcess())
            using (ProcessModule curModule = curProcess.MainModule)
            {
                return SetWindowsHookEx(WH_KEYBOARD_LL, proc,
                    GetModuleHandle(curModule.ModuleName), 0);
            }
        }

        private delegate IntPtr LowLevelKeyboardProc(
            int nCode, IntPtr wParam, IntPtr lParam);

        private static IntPtr HookCallback(
            int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0 && wParam == (IntPtr)WM_KEYDOWN)
            {
                int vkCode = Marshal.ReadInt32(lParam);

                //Console.WriteLine((Keys)vkCode);
                if (saveLog)
                {
                    StreamWriter sw = new StreamWriter(rootFolder + logFile, true);
                    sw.Write((Keys)vkCode);
                    sw.Close();
                }

                if (vkCode == hotkey && !disabled)
                {
                    form.textBox1.Text = rand.Next(min, max).ToString();
                }
                else if (lastKeyControl && (vkCode == disableApp))
                {
                    if (disabled) disabled = false;
                    else disabled = true;
                }
                else if (lastKeyControl && (vkCode == quit))
                {
                    System.Environment.Exit(0);
                }

                if ((vkCode == 162) || (vkCode == 163))
                {
                    lastKeyControl = true;
                }
                else
                {
                    lastKeyControl = false;
                }

            }
            return CallNextHookEx(_hookID, nCode, wParam, lParam);
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook,
            LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode,
            IntPtr wParam, IntPtr lParam);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);

        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        const int SW_HIDE = 0;


        //Read config file
        private static void readConfigFile()
        {
            try
            {
                if (File.Exists(rootFolder + configFile))
                {
                    string[] lines = new string[9];

                    using (StreamReader file = new StreamReader(rootFolder + configFile))
                    {
                        int counter = 0;
                        string ln;

                        while ((ln = file.ReadLine()) != null)
                        {
                            if(counter < 9) lines[counter] = ln;
                            //Console.WriteLine(ln);
                            counter++;
                        }
                        file.Close();
                    }

                    if (String.IsNullOrEmpty(lines[8]))
                    {
                        MessageBox.Show("Configuration file is empty or corrupted. Randomizer will delete this one and create a new one in the next start.");

                        File.Delete(rootFolder + configFile);
                        System.Environment.Exit(0);
                    }
                    else
                    {
                        //PUT VALUES
                        hotkey = Convert.ToInt32(lines[0]);
                        disableApp = Convert.ToInt32(lines[1]);
                        quit = Convert.ToInt32(lines[2]);
                        min = Convert.ToInt32(lines[3]);
                        max = Convert.ToInt32(lines[4]);
                        backColor = lines[5];
                        alwaysOnTop = Convert.ToBoolean(lines[6]);
                        opacity = Convert.ToInt32(lines[7]);
                        saveLog = Convert.ToBoolean(lines[8]);
                    }
                }
                else
                {
                    MessageBox.Show("Configuration file not found. A new configuration file will be created using the default options.");

                    hotkey = 82;
                    disableApp = 68;
                    quit = 81;
                    min = 1;
                    max = 100;

                    backColor = "White";
                    alwaysOnTop = false;
                    opacity = 9;
                    saveLog = false;

                    string[] lines = new string[9];
                    lines[0] = hotkey.ToString();
                    lines[1] = disableApp.ToString();
                    lines[2] = quit.ToString();
                    lines[3] = min.ToString();
                    lines[4] = max.ToString();
                    lines[5] = backColor;
                    lines[6] = alwaysOnTop.ToString();
                    lines[7] = opacity.ToString();
                    lines[8] = saveLog.ToString();

                    File.WriteAllLines(rootFolder + configFile, lines);
                }
            }
            catch (Exception oEx)
            {
                MessageBox.Show("Exception: "+oEx.Message);
            }
        }
    }
}
