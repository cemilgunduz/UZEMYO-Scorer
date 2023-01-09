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
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPoints)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errAnswers)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 784);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1326, 32);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(280, 25);
            this.lblStatus.Text = "Hazır - Cevap Anahtarınızı Giriniz...";
            // 
            // txtCorrectAnswers
            // 
            this.txtCorrectAnswers.Location = new System.Drawing.Point(154, 12);
            this.txtCorrectAnswers.Name = "txtCorrectAnswers";
            this.txtCorrectAnswers.Size = new System.Drawing.Size(674, 31);
            this.txtCorrectAnswers.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cevap Anahtarı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Optik Cevapları";
            // 
            // txtStudentAnswers
            // 
            this.txtStudentAnswers.Location = new System.Drawing.Point(12, 78);
            this.txtStudentAnswers.Multiline = true;
            this.txtStudentAnswers.Name = "txtStudentAnswers";
            this.txtStudentAnswers.Size = new System.Drawing.Size(638, 678);
            this.txtStudentAnswers.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(846, 15);
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
            this.numPoints.Location = new System.Drawing.Point(949, 12);
            this.numPoints.Name = "numPoints";
            this.numPoints.Size = new System.Drawing.Size(203, 31);
            this.numPoints.TabIndex = 8;
            this.numPoints.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // txtResults
            // 
            this.txtResults.Location = new System.Drawing.Point(667, 78);
            this.txtResults.Multiline = true;
            this.txtResults.Name = "txtResults";
            this.txtResults.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResults.Size = new System.Drawing.Size(638, 678);
            this.txtResults.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(667, 50);
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
            this.btnCopy.Location = new System.Drawing.Point(1100, 719);
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
            this.button1.Location = new System.Drawing.Point(1167, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 34);
            this.button1.TabIndex = 12;
            this.button1.Text = "Değerlendir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // errAnswers
            // 
            this.errAnswers.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 816);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtResults);
            this.Controls.Add(this.numPoints);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtStudentAnswers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCorrectAnswers);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPoints)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errAnswers)).EndInit();
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
    }
}