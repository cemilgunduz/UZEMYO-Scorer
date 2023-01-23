namespace UZEMYO
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtCorrectAnswers = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStudentAnswers = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numPoints = new System.Windows.Forms.NumericUpDown();
            this.txtResults = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCopy = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.errAnswers = new System.Windows.Forms.ErrorProvider(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.lblFPath = new System.Windows.Forms.Label();
            this.grp1 = new System.Windows.Forms.GroupBox();
            this.chkEmptyPapers = new System.Windows.Forms.CheckBox();
            this.cmbCol2 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbCol1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.grp2 = new System.Windows.Forms.GroupBox();
            this.lblCharacterCount = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPoints)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errAnswers)).BeginInit();
            this.grp1.SuspendLayout();
            this.grp2.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 934);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1321, 32);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(299, 25);
            this.lblStatus.Text = "Hazır - Optik Form Dosyasını Seçiniz";
            // 
            // txtCorrectAnswers
            // 
            this.txtCorrectAnswers.Location = new System.Drawing.Point(141, 24);
            this.txtCorrectAnswers.Name = "txtCorrectAnswers";
            this.txtCorrectAnswers.Size = new System.Drawing.Size(689, 31);
            this.txtCorrectAnswers.TabIndex = 2;
            this.txtCorrectAnswers.TextChanged += new System.EventHandler(this.txtCorrectAnswers_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cevap Anahtarı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Optik Cevapları";
            // 
            // txtStudentAnswers
            // 
            this.txtStudentAnswers.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtStudentAnswers.Location = new System.Drawing.Point(12, 241);
            this.txtStudentAnswers.Multiline = true;
            this.txtStudentAnswers.Name = "txtStudentAnswers";
            this.txtStudentAnswers.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtStudentAnswers.Size = new System.Drawing.Size(778, 678);
            this.txtStudentAnswers.TabIndex = 5;
            this.txtStudentAnswers.WordWrap = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Soru Puanı";
            // 
            // numPoints
            // 
            this.numPoints.DecimalPlaces = 2;
            this.numPoints.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numPoints.Location = new System.Drawing.Point(109, 102);
            this.numPoints.Name = "numPoints";
            this.numPoints.Size = new System.Drawing.Size(203, 31);
            this.numPoints.TabIndex = 8;
            this.numPoints.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numPoints.ValueChanged += new System.EventHandler(this.numPoints_ValueChanged);
            // 
            // txtResults
            // 
            this.txtResults.Location = new System.Drawing.Point(796, 241);
            this.txtResults.Multiline = true;
            this.txtResults.Name = "txtResults";
            this.txtResults.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResults.Size = new System.Drawing.Size(509, 678);
            this.txtResults.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(796, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(206, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Değerlendirme Sonuçları";
            // 
            // btnCopy
            // 
            this.btnCopy.AutoSize = true;
            this.btnCopy.BackColor = System.Drawing.SystemColors.Window;
            this.btnCopy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCopy.LinkColor = System.Drawing.Color.Navy;
            this.btnCopy.Location = new System.Drawing.Point(1103, 881);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(165, 25);
            this.btnCopy.TabIndex = 11;
            this.btnCopy.TabStop = true;
            this.btnCopy.Text = "Sonuçları Kopyala";
            this.btnCopy.Visible = false;
            this.btnCopy.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnCopy_LinkClicked);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(688, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 53);
            this.button1.TabIndex = 12;
            this.button1.Text = "Değerlendir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // errAnswers
            // 
            this.errAnswers.ContainerControl = this;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(136, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Optik Form Dosyası : ";
            // 
            // lblFPath
            // 
            this.lblFPath.AutoSize = true;
            this.lblFPath.Location = new System.Drawing.Point(334, 22);
            this.lblFPath.Name = "lblFPath";
            this.lblFPath.Size = new System.Drawing.Size(0, 25);
            this.lblFPath.TabIndex = 14;
            // 
            // grp1
            // 
            this.grp1.Controls.Add(this.chkEmptyPapers);
            this.grp1.Controls.Add(this.cmbCol2);
            this.grp1.Controls.Add(this.label7);
            this.grp1.Controls.Add(this.cmbCol1);
            this.grp1.Controls.Add(this.label6);
            this.grp1.Enabled = false;
            this.grp1.Location = new System.Drawing.Point(12, 57);
            this.grp1.Name = "grp1";
            this.grp1.Size = new System.Drawing.Size(451, 153);
            this.grp1.TabIndex = 15;
            this.grp1.TabStop = false;
            this.grp1.Text = "Birinci Aşama";
            // 
            // chkEmptyPapers
            // 
            this.chkEmptyPapers.AutoSize = true;
            this.chkEmptyPapers.Checked = true;
            this.chkEmptyPapers.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEmptyPapers.Location = new System.Drawing.Point(92, 103);
            this.chkEmptyPapers.Name = "chkEmptyPapers";
            this.chkEmptyPapers.Size = new System.Drawing.Size(221, 29);
            this.chkEmptyPapers.TabIndex = 22;
            this.chkEmptyPapers.Text = "Boş Optikleri Gösterme";
            this.chkEmptyPapers.UseVisualStyleBackColor = true;
            this.chkEmptyPapers.CheckedChanged += new System.EventHandler(this.chkEmptyPapers_CheckedChanged);
            // 
            // cmbCol2
            // 
            this.cmbCol2.FormattingEnabled = true;
            this.cmbCol2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cmbCol2.Location = new System.Drawing.Point(330, 63);
            this.cmbCol2.Name = "cmbCol2";
            this.cmbCol2.Size = new System.Drawing.Size(106, 33);
            this.cmbCol2.TabIndex = 21;
            this.cmbCol2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(269, 25);
            this.label7.TabIndex = 20;
            this.label7.Text = "Varsa Devam Sütunu Hangisidir?";
            // 
            // cmbCol1
            // 
            this.cmbCol1.FormattingEnabled = true;
            this.cmbCol1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cmbCol1.Location = new System.Drawing.Point(330, 22);
            this.cmbCol1.Name = "cmbCol1";
            this.cmbCol1.Size = new System.Drawing.Size(106, 33);
            this.cmbCol1.TabIndex = 19;
            this.cmbCol1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(301, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "Cevaplarınız Optikte Hangi Sütunda?";
            // 
            // grp2
            // 
            this.grp2.Controls.Add(this.lblCharacterCount);
            this.grp2.Controls.Add(this.label1);
            this.grp2.Controls.Add(this.txtCorrectAnswers);
            this.grp2.Controls.Add(this.label3);
            this.grp2.Controls.Add(this.numPoints);
            this.grp2.Controls.Add(this.button1);
            this.grp2.Enabled = false;
            this.grp2.Location = new System.Drawing.Point(469, 57);
            this.grp2.Name = "grp2";
            this.grp2.Size = new System.Drawing.Size(836, 153);
            this.grp2.TabIndex = 16;
            this.grp2.TabStop = false;
            this.grp2.Text = "İkinci Aşama";
            // 
            // lblCharacterCount
            // 
            this.lblCharacterCount.AutoSize = true;
            this.lblCharacterCount.Location = new System.Drawing.Point(6, 67);
            this.lblCharacterCount.Name = "lblCharacterCount";
            this.lblCharacterCount.Size = new System.Drawing.Size(0, 25);
            this.lblCharacterCount.TabIndex = 18;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(18, 17);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 34);
            this.button2.TabIndex = 17;
            this.button2.Text = "Dosya Seç";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1321, 966);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.grp2);
            this.Controls.Add(this.grp1);
            this.Controls.Add(this.lblFPath);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtResults);
            this.Controls.Add(this.txtStudentAnswers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "UZEMYO Optik Form Değerlendirme Yazılımı";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPoints)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errAnswers)).EndInit();
            this.grp1.ResumeLayout(false);
            this.grp1.PerformLayout();
            this.grp2.ResumeLayout(false);
            this.grp2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblStatus;
        private TextBox txtCorrectAnswers;
        private Label label1;
        private Label label2;
        private TextBox txtStudentAnswers;
        private Label label3;
        private NumericUpDown numPoints;
        private TextBox txtResults;
        private Label label4;
        private LinkLabel btnCopy;
        private Button button1;
        private ErrorProvider errAnswers;
        private Label lblFPath;
        private Label label5;
        private GroupBox grp2;
        private GroupBox grp1;
        private ComboBox cmbCol2;
        private Label label7;
        private ComboBox cmbCol1;
        private Label label6;
        private Button button2;
        private CheckBox chkEmptyPapers;
        private Label lblCharacterCount;
    }
}