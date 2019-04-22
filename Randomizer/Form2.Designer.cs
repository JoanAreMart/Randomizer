namespace Randomizer
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.labelHotKey = new System.Windows.Forms.Label();
            this.textBoxHotkey = new System.Windows.Forms.TextBox();
            this.labelEnable = new System.Windows.Forms.Label();
            this.labelEnableCtrl = new System.Windows.Forms.Label();
            this.labelQuit = new System.Windows.Forms.Label();
            this.labelQuitCtrl = new System.Windows.Forms.Label();
            this.labelFrom = new System.Windows.Forms.Label();
            this.groupBoxEnableQuit = new System.Windows.Forms.GroupBox();
            this.labelTo = new System.Windows.Forms.Label();
            this.groupBoxBGColor = new System.Windows.Forms.GroupBox();
            this.radioButtonWhite = new System.Windows.Forms.RadioButton();
            this.radioButtonBlack = new System.Windows.Forms.RadioButton();
            this.checkBoxTopMost = new System.Windows.Forms.CheckBox();
            this.checkBoxSaveLog = new System.Windows.Forms.CheckBox();
            this.trackBarOpacity = new System.Windows.Forms.TrackBar();
            this.labelOpacity = new System.Windows.Forms.Label();
            this.textBoxFrom = new System.Windows.Forms.TextBox();
            this.textBoxTo = new System.Windows.Forms.TextBox();
            this.textBoxEnable = new System.Windows.Forms.TextBox();
            this.textBoxQuit = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBoxEnableQuit.SuspendLayout();
            this.groupBoxBGColor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarOpacity)).BeginInit();
            this.SuspendLayout();
            // 
            // labelHotKey
            // 
            this.labelHotKey.AutoSize = true;
            this.labelHotKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHotKey.Location = new System.Drawing.Point(12, 18);
            this.labelHotKey.Name = "labelHotKey";
            this.labelHotKey.Size = new System.Drawing.Size(85, 20);
            this.labelHotKey.TabIndex = 1;
            this.labelHotKey.Text = "HOTKEY:";
            // 
            // textBoxHotkey
            // 
            this.textBoxHotkey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHotkey.Location = new System.Drawing.Point(103, 15);
            this.textBoxHotkey.MaxLength = 1;
            this.textBoxHotkey.Name = "textBoxHotkey";
            this.textBoxHotkey.Size = new System.Drawing.Size(100, 26);
            this.textBoxHotkey.TabIndex = 2;
            this.textBoxHotkey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxHotkey.TextChanged += new System.EventHandler(this.textBoxHotkey_TextChanged);
            this.textBoxHotkey.Enter += new System.EventHandler(this.textBoxHotkey_Enter);
            // 
            // labelEnable
            // 
            this.labelEnable.AutoSize = true;
            this.labelEnable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnable.Location = new System.Drawing.Point(19, 22);
            this.labelEnable.Name = "labelEnable";
            this.labelEnable.Size = new System.Drawing.Size(187, 17);
            this.labelEnable.TabIndex = 4;
            this.labelEnable.Text = "Enable/Disable Randomizer:";
            // 
            // labelEnableCtrl
            // 
            this.labelEnableCtrl.AutoSize = true;
            this.labelEnableCtrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnableCtrl.Location = new System.Drawing.Point(255, 22);
            this.labelEnableCtrl.Name = "labelEnableCtrl";
            this.labelEnableCtrl.Size = new System.Drawing.Size(67, 17);
            this.labelEnableCtrl.TabIndex = 5;
            this.labelEnableCtrl.Text = "CTRL + ";
            // 
            // labelQuit
            // 
            this.labelQuit.AutoSize = true;
            this.labelQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuit.Location = new System.Drawing.Point(19, 56);
            this.labelQuit.Name = "labelQuit";
            this.labelQuit.Size = new System.Drawing.Size(38, 17);
            this.labelQuit.TabIndex = 7;
            this.labelQuit.Text = "Quit:";
            // 
            // labelQuitCtrl
            // 
            this.labelQuitCtrl.AutoSize = true;
            this.labelQuitCtrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuitCtrl.Location = new System.Drawing.Point(255, 56);
            this.labelQuitCtrl.Name = "labelQuitCtrl";
            this.labelQuitCtrl.Size = new System.Drawing.Size(67, 17);
            this.labelQuitCtrl.TabIndex = 8;
            this.labelQuitCtrl.Text = "CTRL + ";
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFrom.Location = new System.Drawing.Point(23, 176);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(145, 17);
            this.labelFrom.TabIndex = 10;
            this.labelFrom.Text = "Random number from";
            // 
            // groupBoxEnableQuit
            // 
            this.groupBoxEnableQuit.Controls.Add(this.textBoxQuit);
            this.groupBoxEnableQuit.Controls.Add(this.textBoxEnable);
            this.groupBoxEnableQuit.Controls.Add(this.labelEnable);
            this.groupBoxEnableQuit.Controls.Add(this.labelEnableCtrl);
            this.groupBoxEnableQuit.Controls.Add(this.labelQuitCtrl);
            this.groupBoxEnableQuit.Controls.Add(this.labelQuit);
            this.groupBoxEnableQuit.Location = new System.Drawing.Point(16, 57);
            this.groupBoxEnableQuit.Name = "groupBoxEnableQuit";
            this.groupBoxEnableQuit.Size = new System.Drawing.Size(452, 86);
            this.groupBoxEnableQuit.TabIndex = 3;
            this.groupBoxEnableQuit.TabStop = false;
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTo.Location = new System.Drawing.Point(298, 176);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(20, 17);
            this.labelTo.TabIndex = 12;
            this.labelTo.Text = "to";
            // 
            // groupBoxBGColor
            // 
            this.groupBoxBGColor.Controls.Add(this.radioButtonBlack);
            this.groupBoxBGColor.Controls.Add(this.radioButtonWhite);
            this.groupBoxBGColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxBGColor.Location = new System.Drawing.Point(16, 230);
            this.groupBoxBGColor.Name = "groupBoxBGColor";
            this.groupBoxBGColor.Size = new System.Drawing.Size(156, 84);
            this.groupBoxBGColor.TabIndex = 14;
            this.groupBoxBGColor.TabStop = false;
            this.groupBoxBGColor.Text = "Background Color";
            // 
            // radioButtonWhite
            // 
            this.radioButtonWhite.AutoSize = true;
            this.radioButtonWhite.Checked = true;
            this.radioButtonWhite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonWhite.Location = new System.Drawing.Point(23, 26);
            this.radioButtonWhite.Name = "radioButtonWhite";
            this.radioButtonWhite.Size = new System.Drawing.Size(62, 21);
            this.radioButtonWhite.TabIndex = 15;
            this.radioButtonWhite.TabStop = true;
            this.radioButtonWhite.Text = "White";
            this.radioButtonWhite.UseVisualStyleBackColor = true;
            // 
            // radioButtonBlack
            // 
            this.radioButtonBlack.AutoSize = true;
            this.radioButtonBlack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonBlack.Location = new System.Drawing.Point(23, 53);
            this.radioButtonBlack.Name = "radioButtonBlack";
            this.radioButtonBlack.Size = new System.Drawing.Size(60, 21);
            this.radioButtonBlack.TabIndex = 16;
            this.radioButtonBlack.Text = "Black";
            this.radioButtonBlack.UseVisualStyleBackColor = true;
            // 
            // checkBoxTopMost
            // 
            this.checkBoxTopMost.AutoSize = true;
            this.checkBoxTopMost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxTopMost.Location = new System.Drawing.Point(243, 248);
            this.checkBoxTopMost.Name = "checkBoxTopMost";
            this.checkBoxTopMost.Size = new System.Drawing.Size(193, 21);
            this.checkBoxTopMost.TabIndex = 17;
            this.checkBoxTopMost.Text = "Randomizer always on top";
            this.checkBoxTopMost.UseVisualStyleBackColor = true;
            // 
            // checkBoxSaveLog
            // 
            this.checkBoxSaveLog.AutoSize = true;
            this.checkBoxSaveLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSaveLog.Location = new System.Drawing.Point(243, 284);
            this.checkBoxSaveLog.Name = "checkBoxSaveLog";
            this.checkBoxSaveLog.Size = new System.Drawing.Size(82, 21);
            this.checkBoxSaveLog.TabIndex = 18;
            this.checkBoxSaveLog.Text = "Save log";
            this.checkBoxSaveLog.UseVisualStyleBackColor = true;
            // 
            // trackBarOpacity
            // 
            this.trackBarOpacity.Location = new System.Drawing.Point(16, 374);
            this.trackBarOpacity.Minimum = 1;
            this.trackBarOpacity.Name = "trackBarOpacity";
            this.trackBarOpacity.Size = new System.Drawing.Size(452, 45);
            this.trackBarOpacity.TabIndex = 20;
            this.trackBarOpacity.TickFrequency = 5;
            this.trackBarOpacity.Value = 10;
            // 
            // labelOpacity
            // 
            this.labelOpacity.AutoSize = true;
            this.labelOpacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOpacity.Location = new System.Drawing.Point(23, 342);
            this.labelOpacity.Name = "labelOpacity";
            this.labelOpacity.Size = new System.Drawing.Size(60, 17);
            this.labelOpacity.TabIndex = 19;
            this.labelOpacity.Text = "Opacity:";
            // 
            // textBoxFrom
            // 
            this.textBoxFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFrom.Location = new System.Drawing.Point(179, 173);
            this.textBoxFrom.MaxLength = 10;
            this.textBoxFrom.Name = "textBoxFrom";
            this.textBoxFrom.Size = new System.Drawing.Size(100, 23);
            this.textBoxFrom.TabIndex = 11;
            this.textBoxFrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxFrom.Enter += new System.EventHandler(this.textBoxFrom_Enter);
            this.textBoxFrom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFrom_KeyPress);
            // 
            // textBoxTo
            // 
            this.textBoxTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTo.Location = new System.Drawing.Point(336, 173);
            this.textBoxTo.MaxLength = 10;
            this.textBoxTo.Name = "textBoxTo";
            this.textBoxTo.Size = new System.Drawing.Size(100, 23);
            this.textBoxTo.TabIndex = 13;
            this.textBoxTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxTo.Enter += new System.EventHandler(this.textBoxTo_Enter);
            this.textBoxTo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTo_KeyPress);
            // 
            // textBoxEnable
            // 
            this.textBoxEnable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEnable.Location = new System.Drawing.Point(334, 19);
            this.textBoxEnable.MaxLength = 1;
            this.textBoxEnable.Name = "textBoxEnable";
            this.textBoxEnable.Size = new System.Drawing.Size(100, 23);
            this.textBoxEnable.TabIndex = 6;
            this.textBoxEnable.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxEnable.TextChanged += new System.EventHandler(this.textBoxEnable_TextChanged);
            this.textBoxEnable.Enter += new System.EventHandler(this.textBoxEnable_Enter);
            // 
            // textBoxQuit
            // 
            this.textBoxQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxQuit.Location = new System.Drawing.Point(334, 53);
            this.textBoxQuit.MaxLength = 1;
            this.textBoxQuit.Name = "textBoxQuit";
            this.textBoxQuit.Size = new System.Drawing.Size(100, 23);
            this.textBoxQuit.TabIndex = 9;
            this.textBoxQuit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxQuit.TextChanged += new System.EventHandler(this.textBoxQuit_TextChanged);
            this.textBoxQuit.Enter += new System.EventHandler(this.textBoxQuit_Enter);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.LightBlue;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(384, 444);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(84, 34);
            this.buttonSave.TabIndex = 22;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.BurlyWood;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(274, 444);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(84, 34);
            this.buttonCancel.TabIndex = 21;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 492);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxTo);
            this.Controls.Add(this.textBoxFrom);
            this.Controls.Add(this.labelOpacity);
            this.Controls.Add(this.trackBarOpacity);
            this.Controls.Add(this.checkBoxSaveLog);
            this.Controls.Add(this.checkBoxTopMost);
            this.Controls.Add(this.groupBoxBGColor);
            this.Controls.Add(this.labelTo);
            this.Controls.Add(this.groupBoxEnableQuit);
            this.Controls.Add(this.labelFrom);
            this.Controls.Add(this.textBoxHotkey);
            this.Controls.Add(this.labelHotKey);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBoxEnableQuit.ResumeLayout(false);
            this.groupBoxEnableQuit.PerformLayout();
            this.groupBoxBGColor.ResumeLayout(false);
            this.groupBoxBGColor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarOpacity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHotKey;
        private System.Windows.Forms.TextBox textBoxHotkey;
        private System.Windows.Forms.Label labelEnable;
        private System.Windows.Forms.Label labelEnableCtrl;
        private System.Windows.Forms.Label labelQuit;
        private System.Windows.Forms.Label labelQuitCtrl;
        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.GroupBox groupBoxEnableQuit;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.GroupBox groupBoxBGColor;
        private System.Windows.Forms.RadioButton radioButtonBlack;
        private System.Windows.Forms.RadioButton radioButtonWhite;
        private System.Windows.Forms.CheckBox checkBoxTopMost;
        private System.Windows.Forms.TextBox textBoxQuit;
        private System.Windows.Forms.TextBox textBoxEnable;
        private System.Windows.Forms.CheckBox checkBoxSaveLog;
        private System.Windows.Forms.TrackBar trackBarOpacity;
        private System.Windows.Forms.Label labelOpacity;
        private System.Windows.Forms.TextBox textBoxFrom;
        private System.Windows.Forms.TextBox textBoxTo;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
    }
}