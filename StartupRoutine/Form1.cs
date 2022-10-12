using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Collections;
using System.Text;
using System.Globalization;
using System.Xml;
using GemCard;
using SmartCardPlayer;
using System.Diagnostics;
using System.Threading;

namespace BootRoutine
{

    public partial class Form1 : Form
    {
        string CurrentPath = "";
        void ptf(string path, string text, bool del = true)
        {
            if (File.Exists(path) && del)
            {
                File.Delete(path);
                File.Create(path);
            }
            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.Write(text);
            }
        }
        bool IsFileLocked(FileInfo file)
        {
            FileStream stream = null;

            try
            {
                stream = file.Open(FileMode.Open, FileAccess.ReadWrite, FileShare.None);
            }
            catch (IOException)
            {
                return true;
            }
            finally
            {
                if (stream != null)
                    stream.Close();
            }
            return false;
        }
        void RefreshCheckList()
        {
            if (routinelist.SelectedItem.ToString() != "")
            {
                tasklist.Items.Clear();
                {
                    int i = 0;
                    while (IsFileLocked(new FileInfo(CurrentPath)))
                    {
                        i++;
                        Thread.Sleep(10);
                        if (i > 50)
                            RefreshComboBox();
                        return;
                    }
                }
                string[] allines = File.ReadAllLines(CurrentPath);
                foreach (string line in allines)
                    tasklist.Items.Add(line);
                for (int i = 0; i < tasklist.Items.Count; i++)
                {
                    tasklist.SetItemChecked(i, true);
                }
            }
            else
                tasklist.Items.Clear();
        }
        void RefreshComboBox()
        {
            routinelist.SelectedText = string.Empty;
            routinelist.Hide();
            Thread.Sleep(500);
            routinelist.Items.Clear();
            string[] filePaths = Directory.GetFiles("data");
            if (filePaths.Length == 0)
            {
                return;
            }
            for (int i = 0; i < filePaths.Length; i++)
            {
                routinelist.Items.Add(filePaths[i].Split('\\')[1].Split('.')[0]);
            }
            routinelist.Show();
        }
        public Form1()
        {
            InitializeComponent();

            newroutine.Show();
            editroutine.Hide();
            saveroutine.Hide();
            remove_tasks.Hide();
            removeroutine.Hide();
            newtask.Hide();
            newroutinename.Hide();
            if (!Directory.Exists("data"))
            {
                Directory.CreateDirectory("data");
            }
            RefreshComboBox();
        }
        public static void startprocess(string path, string args = "")
        {
            Process ExternalProcess = new Process();
            ExternalProcess.StartInfo.FileName = path;
            ExternalProcess.StartInfo.Arguments = args;
            ExternalProcess.Start();
            ExternalProcess.WaitForExit();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            List<string> tasks = new List<string>();
            for (int i = 0; i <= (tasklist.Items.Count - 1); i++)
            {
                if (tasklist.GetItemChecked(i))
                {
                    tasks.Add((tasklist.Items[i]).ToString());
                }
            }
            List<Thread> procs = new List<Thread>();
            for (int i = 0; i < tasks.Count; i++)
            {
                procs.Add(new Thread(() => startprocess(tasks[i])));
                procs[i].Start();
            }
            notifyIcon1.Visible = true;
            Hide();
            
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            notifyIcon1.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurrentPath = "data/" + routinelist.SelectedItem + ".wsr";
            RefreshCheckList();
            editroutine.Show();
            removeroutine.Show();
            saveroutine.Hide();
            remove_tasks.Hide();
            newtask.Hide();
            newroutinename.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < tasklist.Items.Count; i++)
            {
                tasklist.SetItemChecked(i, false);
            }
            remove_tasks.Show();
            newtask.Show();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            newroutinename.Show();
            removeroutine.Hide();
            editroutine.Hide();
            saveroutine.Hide();
            remove_tasks.Hide();
            newtask.Hide();

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (newroutinename.Text != "")
            {
                saveroutine.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string fileName = "data/" + newroutinename.Text + ".wsr";
            if (File.Exists(fileName))
                System.Windows.Forms.MessageBox.Show("This routine already exists");
            else
                System.IO.File.Create("data/" + newroutinename.Text + ".wsr");
            RefreshComboBox();
            newroutine.Show();
            editroutine.Hide();
            saveroutine.Hide();
            remove_tasks.Hide();
            removeroutine.Hide();
            newtask.Hide();
            newroutinename.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            List<string> dat = new List<string>();
            string s = "";
            for (int i = 0; i <= (tasklist.Items.Count - 1); i++)
            {

                if (!tasklist.GetItemChecked(i))
                {
                    dat.Add(tasklist.Items[i].ToString());
                    s += tasklist.Items[i].ToString() + "\n";
                }
            }

            File.WriteAllText(CurrentPath, s);
            RefreshCheckList();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            try
            {
                string path = openFileDialog1.FileName;
                if (path == null || path == "openFileDialog1" || tasklist.Items.Contains(path))
                {
                    int t = 0, s = 1 / t;
                }
                ptf(CurrentPath, path + "\n", false);
            }
            catch
            {
                DialogResult dialogResult = MessageBox.Show("Add path manually?", "Windows didn't like that", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    startprocess("notepad", Path.GetFullPath(CurrentPath));
                }
                else if (dialogResult == DialogResult.No)
                {
                }
            }
            //File.AppendAllText(CurrentPath, path+"\n");
            RefreshCheckList();

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void removeroutine_Click(object sender, EventArgs e)
        {
            {
                int i = 0;
                while (IsFileLocked(new FileInfo(CurrentPath)))
                {
                    i++;
                    Thread.Sleep(10);
                    if (i > 50)
                        return;
                }
            }
            File.Delete(CurrentPath);
            RefreshCheckList();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
