namespace BootRoutine
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.runroutine = new System.Windows.Forms.Button();
            this.routinelist = new System.Windows.Forms.ComboBox();
            this.tasklist = new System.Windows.Forms.CheckedListBox();
            this.newroutine = new System.Windows.Forms.Button();
            this.editroutine = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.newroutinename = new System.Windows.Forms.TextBox();
            this.saveroutine = new System.Windows.Forms.Button();
            this.remove_tasks = new System.Windows.Forms.Button();
            this.newtask = new System.Windows.Forms.Button();
            this.removeroutine = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipText = "Still working";
            this.notifyIcon1.BalloonTipTitle = "Still working";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Still working";
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // runroutine
            // 
            this.runroutine.Location = new System.Drawing.Point(525, 12);
            this.runroutine.Name = "runroutine";
            this.runroutine.Size = new System.Drawing.Size(75, 23);
            this.runroutine.TabIndex = 7;
            this.runroutine.Text = "Run";
            this.runroutine.UseVisualStyleBackColor = true;
            this.runroutine.Click += new System.EventHandler(this.button1_Click);
            // 
            // routinelist
            // 
            this.routinelist.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.routinelist.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.routinelist.FormattingEnabled = true;
            this.routinelist.Location = new System.Drawing.Point(12, 12);
            this.routinelist.MaxDropDownItems = 20;
            this.routinelist.Name = "routinelist";
            this.routinelist.Size = new System.Drawing.Size(121, 21);
            this.routinelist.Sorted = true;
            this.routinelist.TabIndex = 1;
            this.routinelist.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tasklist
            // 
            this.tasklist.FormattingEnabled = true;
            this.tasklist.Location = new System.Drawing.Point(139, 12);
            this.tasklist.Name = "tasklist";
            this.tasklist.Size = new System.Drawing.Size(380, 184);
            this.tasklist.TabIndex = 999;
            this.tasklist.TabStop = false;
            this.tasklist.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // newroutine
            // 
            this.newroutine.Location = new System.Drawing.Point(12, 39);
            this.newroutine.Name = "newroutine";
            this.newroutine.Size = new System.Drawing.Size(121, 23);
            this.newroutine.TabIndex = 3;
            this.newroutine.Text = "New";
            this.newroutine.UseVisualStyleBackColor = true;
            this.newroutine.Click += new System.EventHandler(this.button2_Click);
            // 
            // editroutine
            // 
            this.editroutine.Location = new System.Drawing.Point(12, 68);
            this.editroutine.Name = "editroutine";
            this.editroutine.Size = new System.Drawing.Size(121, 23);
            this.editroutine.TabIndex = 5;
            this.editroutine.Text = "Edit";
            this.editroutine.UseVisualStyleBackColor = true;
            this.editroutine.Click += new System.EventHandler(this.button3_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // newroutinename
            // 
            this.newroutinename.Location = new System.Drawing.Point(12, 71);
            this.newroutinename.Name = "newroutinename";
            this.newroutinename.Size = new System.Drawing.Size(121, 20);
            this.newroutinename.TabIndex = 4;
            this.newroutinename.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // saveroutine
            // 
            this.saveroutine.Location = new System.Drawing.Point(12, 97);
            this.saveroutine.Name = "saveroutine";
            this.saveroutine.Size = new System.Drawing.Size(121, 23);
            this.saveroutine.TabIndex = 7;
            this.saveroutine.Text = "Save";
            this.saveroutine.UseVisualStyleBackColor = true;
            this.saveroutine.Click += new System.EventHandler(this.button4_Click);
            // 
            // remove_tasks
            // 
            this.remove_tasks.Location = new System.Drawing.Point(12, 97);
            this.remove_tasks.Name = "remove_tasks";
            this.remove_tasks.Size = new System.Drawing.Size(121, 23);
            this.remove_tasks.TabIndex = 6;
            this.remove_tasks.Text = "Remove selected";
            this.remove_tasks.UseVisualStyleBackColor = true;
            this.remove_tasks.Click += new System.EventHandler(this.button5_Click);
            // 
            // newtask
            // 
            this.newtask.Location = new System.Drawing.Point(12, 126);
            this.newtask.Name = "newtask";
            this.newtask.Size = new System.Drawing.Size(121, 23);
            this.newtask.TabIndex = 7;
            this.newtask.Text = "Add path";
            this.newtask.UseVisualStyleBackColor = true;
            this.newtask.Click += new System.EventHandler(this.button6_Click);
            // 
            // removeroutine
            // 
            this.removeroutine.Location = new System.Drawing.Point(12, 173);
            this.removeroutine.Name = "removeroutine";
            this.removeroutine.Size = new System.Drawing.Size(121, 23);
            this.removeroutine.TabIndex = 9;
            this.removeroutine.Text = "Delete routine";
            this.removeroutine.UseVisualStyleBackColor = true;
            this.removeroutine.Click += new System.EventHandler(this.removeroutine_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(525, 173);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 8;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 211);
            this.ControlBox = false;
            this.Controls.Add(this.exit);
            this.Controls.Add(this.removeroutine);
            this.Controls.Add(this.newtask);
            this.Controls.Add(this.remove_tasks);
            this.Controls.Add(this.saveroutine);
            this.Controls.Add(this.newroutinename);
            this.Controls.Add(this.editroutine);
            this.Controls.Add(this.newroutine);
            this.Controls.Add(this.tasklist);
            this.Controls.Add(this.routinelist);
            this.Controls.Add(this.runroutine);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "BootRoutine";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button runroutine;
        private System.Windows.Forms.ComboBox routinelist;
        private System.Windows.Forms.CheckedListBox tasklist;
        private System.Windows.Forms.Button newroutine;
        private System.Windows.Forms.Button editroutine;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox newroutinename;
        private System.Windows.Forms.Button saveroutine;
        private System.Windows.Forms.Button remove_tasks;
        private System.Windows.Forms.Button newtask;
        private System.Windows.Forms.Button removeroutine;
        private System.Windows.Forms.Button exit;
    }
}

