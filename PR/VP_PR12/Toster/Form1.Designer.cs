namespace Toster
{
    partial class Toster
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Toster));
            pictureBoxToster = new PictureBox();
            groupBoxSettings = new GroupBox();
            labelTime = new Label();
            labelRed = new Label();
            labelGreen = new Label();
            buttonStart = new Button();
            labelYellow = new Label();
            trackBarTime = new TrackBar();
            radioButtonTwoBreads = new RadioButton();
            radioButtonOneBread = new RadioButton();
            labelBreadType = new Label();
            comboBoxBreadType = new ComboBox();
            vScrollBarOnOff = new VScrollBar();
            groupBoxScroll = new GroupBox();
            timer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBoxToster).BeginInit();
            groupBoxSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarTime).BeginInit();
            groupBoxScroll.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBoxToster
            // 
            pictureBoxToster.Location = new Point(363, 12);
            pictureBoxToster.Name = "pictureBoxToster";
            pictureBoxToster.Size = new Size(425, 426);
            pictureBoxToster.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxToster.TabIndex = 0;
            pictureBoxToster.TabStop = false;
            // 
            // groupBoxSettings
            // 
            groupBoxSettings.Controls.Add(labelTime);
            groupBoxSettings.Controls.Add(labelRed);
            groupBoxSettings.Controls.Add(labelGreen);
            groupBoxSettings.Controls.Add(buttonStart);
            groupBoxSettings.Controls.Add(labelYellow);
            groupBoxSettings.Controls.Add(trackBarTime);
            groupBoxSettings.Controls.Add(radioButtonTwoBreads);
            groupBoxSettings.Controls.Add(radioButtonOneBread);
            groupBoxSettings.Controls.Add(labelBreadType);
            groupBoxSettings.Controls.Add(comboBoxBreadType);
            groupBoxSettings.Location = new Point(12, 12);
            groupBoxSettings.Name = "groupBoxSettings";
            groupBoxSettings.Size = new Size(249, 310);
            groupBoxSettings.TabIndex = 1;
            groupBoxSettings.TabStop = false;
            groupBoxSettings.Text = "Настройки тостера";
            // 
            // labelTime
            // 
            labelTime.AutoSize = true;
            labelTime.BackColor = SystemColors.Control;
            labelTime.Location = new Point(15, 181);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(54, 20);
            labelTime.TabIndex = 6;
            labelTime.Text = "Время";
            // 
            // labelRed
            // 
            labelRed.AutoSize = true;
            labelRed.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            labelRed.ForeColor = Color.Red;
            labelRed.Location = new Point(153, 172);
            labelRed.Name = "labelRed";
            labelRed.Size = new Size(76, 46);
            labelRed.TabIndex = 9;
            labelRed.Text = "____";
            // 
            // labelGreen
            // 
            labelGreen.AutoSize = true;
            labelGreen.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            labelGreen.ForeColor = Color.Green;
            labelGreen.Location = new Point(80, 173);
            labelGreen.Name = "labelGreen";
            labelGreen.Size = new Size(85, 45);
            labelGreen.TabIndex = 8;
            labelGreen.Text = "_____";
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(80, 275);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(94, 29);
            buttonStart.TabIndex = 5;
            buttonStart.Text = "Включить";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // labelYellow
            // 
            labelYellow.AutoSize = true;
            labelYellow.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            labelYellow.ForeColor = Color.Yellow;
            labelYellow.Location = new Point(15, 172);
            labelYellow.Name = "labelYellow";
            labelYellow.Size = new Size(90, 46);
            labelYellow.TabIndex = 7;
            labelYellow.Text = "_____";
            // 
            // trackBarTime
            // 
            trackBarTime.BackColor = SystemColors.Control;
            trackBarTime.Location = new Point(15, 222);
            trackBarTime.Maximum = 15;
            trackBarTime.Name = "trackBarTime";
            trackBarTime.Size = new Size(214, 56);
            trackBarTime.TabIndex = 2;
            trackBarTime.Scroll += trackBarTime_Scroll;
            // 
            // radioButtonTwoBreads
            // 
            radioButtonTwoBreads.AutoSize = true;
            radioButtonTwoBreads.Location = new Point(15, 136);
            radioButtonTwoBreads.Name = "radioButtonTwoBreads";
            radioButtonTwoBreads.Size = new Size(83, 24);
            radioButtonTwoBreads.TabIndex = 3;
            radioButtonTwoBreads.Text = "2 штуки";
            radioButtonTwoBreads.UseVisualStyleBackColor = true;
            // 
            // radioButtonOneBread
            // 
            radioButtonOneBread.AutoSize = true;
            radioButtonOneBread.Checked = true;
            radioButtonOneBread.Location = new Point(15, 106);
            radioButtonOneBread.Name = "radioButtonOneBread";
            radioButtonOneBread.Size = new Size(82, 24);
            radioButtonOneBread.TabIndex = 2;
            radioButtonOneBread.TabStop = true;
            radioButtonOneBread.Text = "1 штука";
            radioButtonOneBread.UseVisualStyleBackColor = true;
            radioButtonOneBread.CheckedChanged += radioButtonOneBread_CheckedChanged;
            // 
            // labelBreadType
            // 
            labelBreadType.AutoSize = true;
            labelBreadType.Location = new Point(15, 32);
            labelBreadType.Name = "labelBreadType";
            labelBreadType.Size = new Size(79, 20);
            labelBreadType.TabIndex = 1;
            labelBreadType.Text = "Тип хлеба";
            // 
            // comboBoxBreadType
            // 
            comboBoxBreadType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxBreadType.FormattingEnabled = true;
            comboBoxBreadType.Items.AddRange(new object[] { "Белый хлеб", "Черный хлеб", "Багет", "Хачапури с сыром и ветчиной" });
            comboBoxBreadType.Location = new Point(15, 55);
            comboBoxBreadType.Name = "comboBoxBreadType";
            comboBoxBreadType.Size = new Size(214, 28);
            comboBoxBreadType.TabIndex = 0;
            comboBoxBreadType.SelectedIndexChanged += comboBoxBreadType_SelectedIndexChanged;
            // 
            // vScrollBarOnOff
            // 
            vScrollBarOnOff.Location = new Point(14, 13);
            vScrollBarOnOff.Maximum = 25;
            vScrollBarOnOff.Name = "vScrollBarOnOff";
            vScrollBarOnOff.Size = new Size(31, 291);
            vScrollBarOnOff.TabIndex = 6;
            vScrollBarOnOff.ValueChanged += vScrollBarOnOff_ValueChanged;
            // 
            // groupBoxScroll
            // 
            groupBoxScroll.Controls.Add(vScrollBarOnOff);
            groupBoxScroll.Location = new Point(277, 12);
            groupBoxScroll.Name = "groupBoxScroll";
            groupBoxScroll.Size = new Size(60, 310);
            groupBoxScroll.TabIndex = 7;
            groupBoxScroll.TabStop = false;
            // 
            // timer
            // 
            timer.Tick += timer_Tick;
            // 
            // Toster
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxScroll);
            Controls.Add(groupBoxSettings);
            Controls.Add(pictureBoxToster);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Toster";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Тостер";
            ((System.ComponentModel.ISupportInitialize)pictureBoxToster).EndInit();
            groupBoxSettings.ResumeLayout(false);
            groupBoxSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarTime).EndInit();
            groupBoxScroll.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxToster;
        private GroupBox groupBoxSettings;
        private ComboBox comboBoxBreadType;
        private Button buttonStart;
        private RadioButton radioButtonTwoBreads;
        private RadioButton radioButtonOneBread;
        private Label labelBreadType;
        private VScrollBar vScrollBarOnOff;
        private TrackBar trackBarTime;
        private Label labelTime;
        private GroupBox groupBoxScroll;
        private System.Windows.Forms.Timer timer;
        private Label labelYellow;
        private Label labelGreen;
        private Label labelRed;
    }
}