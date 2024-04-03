namespace PriceChecker
{
    partial class Form1
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
            label1 = new Label();
            txtName = new TextBox();
            txtUrl = new TextBox();
            textSelector = new TextBox();
            URL = new Label();
            label3 = new Label();
            listTrackers = new ListView();
            hdrName = new ColumnHeader();
            hdrPrev = new ColumnHeader();
            hdrCurrent = new ColumnHeader();
            hdrLastChecked = new ColumnHeader();
            hdrLastChanged = new ColumnHeader();
            button1 = new Button();
            lblTest = new Label();
            Addbutton = new Button();
            Removebutton = new Button();
            trackBar1 = new TrackBar();
            StartTrackingButton = new Button();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 44);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            label1.Click += label1_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(116, 41);
            txtName.Name = "txtName";
            txtName.Size = new Size(212, 23);
            txtName.TabIndex = 1;
            // 
            // txtUrl
            // 
            txtUrl.Location = new Point(116, 86);
            txtUrl.Name = "txtUrl";
            txtUrl.Size = new Size(212, 23);
            txtUrl.TabIndex = 2;
            // 
            // textSelector
            // 
            textSelector.Location = new Point(116, 130);
            textSelector.Name = "textSelector";
            textSelector.Size = new Size(212, 23);
            textSelector.TabIndex = 3;
            // 
            // URL
            // 
            URL.AutoSize = true;
            URL.Location = new Point(71, 89);
            URL.Name = "URL";
            URL.Size = new Size(31, 15);
            URL.TabIndex = 4;
            URL.Text = "URL:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(63, 133);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 5;
            label3.Text = "Selector:";
            // 
            // listTrackers
            // 
            listTrackers.Columns.AddRange(new ColumnHeader[] { hdrName, hdrPrev, hdrCurrent, hdrLastChecked, hdrLastChanged });
            listTrackers.Location = new Point(68, 209);
            listTrackers.Name = "listTrackers";
            listTrackers.Size = new Size(662, 187);
            listTrackers.TabIndex = 6;
            listTrackers.UseCompatibleStateImageBehavior = false;
            listTrackers.View = View.Details;
            // 
            // hdrName
            // 
            hdrName.Text = "Name";
            // 
            // hdrPrev
            // 
            hdrPrev.Text = "Prev Price";
            // 
            // hdrCurrent
            // 
            hdrCurrent.Text = "Current Price";
            // 
            // hdrLastChecked
            // 
            hdrLastChecked.Text = "Last Checked";
            // 
            // hdrLastChanged
            // 
            hdrLastChanged.Text = "LastChanged";
            // 
            // button1
            // 
            button1.Location = new Point(527, 86);
            button1.Name = "button1";
            button1.Size = new Size(169, 34);
            button1.TabIndex = 7;
            button1.Text = "Test";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblTest
            // 
            lblTest.AutoSize = true;
            lblTest.Location = new Point(599, 49);
            lblTest.Name = "lblTest";
            lblTest.Size = new Size(17, 15);
            lblTest.TabIndex = 8;
            lblTest.Text = "__";
            // 
            // Addbutton
            // 
            Addbutton.ForeColor = SystemColors.Highlight;
            Addbutton.Location = new Point(68, 180);
            Addbutton.Name = "Addbutton";
            Addbutton.Size = new Size(75, 23);
            Addbutton.TabIndex = 9;
            Addbutton.Text = "Add";
            Addbutton.UseVisualStyleBackColor = true;
            Addbutton.Click += Addbutton_Click;
            // 
            // Removebutton
            // 
            Removebutton.BackColor = Color.DarkGray;
            Removebutton.ForeColor = Color.Maroon;
            Removebutton.Location = new Point(149, 180);
            Removebutton.Name = "Removebutton";
            Removebutton.Size = new Size(75, 23);
            Removebutton.TabIndex = 10;
            Removebutton.Text = "Remove";
            Removebutton.UseVisualStyleBackColor = false;
            Removebutton.Click += Removebutton_Click;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(566, 143);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(104, 45);
            trackBar1.TabIndex = 11;
            trackBar1.Value = 5;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // StartTrackingButton
            // 
            StartTrackingButton.Location = new Point(566, 402);
            StartTrackingButton.Name = "StartTrackingButton";
            StartTrackingButton.Size = new Size(208, 36);
            StartTrackingButton.TabIndex = 12;
            StartTrackingButton.Text = "Start Tracking";
            StartTrackingButton.UseVisualStyleBackColor = true;
            StartTrackingButton.Click += StartTrackingButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(StartTrackingButton);
            Controls.Add(trackBar1);
            Controls.Add(Removebutton);
            Controls.Add(Addbutton);
            Controls.Add(lblTest);
            Controls.Add(button1);
            Controls.Add(listTrackers);
            Controls.Add(label3);
            Controls.Add(URL);
            Controls.Add(textSelector);
            Controls.Add(txtUrl);
            Controls.Add(txtName);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private TextBox txtUrl;
        private TextBox textSelector;
        private Label URL;
        private Label label3;
        private ListView listTrackers;
        private ColumnHeader hdrName;
        private ColumnHeader hdrPrev;
        private ColumnHeader hdrCurrent;
        private ColumnHeader hdrLastChecked;
        private ColumnHeader hdrLastChanged;
        private Button button1;
        private Label lblTest;
        private Button Addbutton;
        private Button Removebutton;
        private TrackBar trackBar1;
        private Button StartTrackingButton;
    }
}