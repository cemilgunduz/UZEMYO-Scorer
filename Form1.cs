using System.Collections.Specialized;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms.Design;
using static System.Formats.Asn1.AsnWriter;

namespace UZEMYO
{
    public partial class Form1 : Form
    {
        private List<paper> papers = new List<paper>();
        public Form1()
        {
            InitializeComponent();
        }
        class paper
        {
            public string stuID { get; set; }
            public string column1 { get; set; }
            public string column2 { get; set; }
            public string column3 { get; set; }
            public string column4 { get; set; }
            public string column5 { get; set; }
            public string column6 { get; set; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private string selectFile() {
            OpenFileDialog file = new();
            file.Filter = "Optik Form Dosyası |*.DAT";
            file.RestoreDirectory = true;
            file.Title = "Optik Form Dosyasını Seçiniz";
            string fname = "";
            if (file.ShowDialog() == DialogResult.OK)
            {
                 fname = file.FileName;            
            }
            return fname;
        }

        private List<paper> readFile(string fname) {
            string[] lines = File.ReadAllLines(fname);
            List<paper> papers = new List<paper>();
            foreach (string line in lines) {
                paper paperLine = new paper();
                paperLine.stuID = line.Substring(20, 9);
                paperLine.column1 = line.Substring(42, 40);
                paperLine.column2 = line.Substring(92, 40);
                paperLine.column3 = line.Substring(142, 40);
                paperLine.column4 = line.Substring(192, 40);
                paperLine.column5 = line.Substring(246, 40);
                paperLine.column6 = line.Substring(296, 40);
                papers.Add(paperLine); 
            }
            return papers;
        }
        
        private void writePapers(List<paper> papers, int colIndex, int secColIndex=-1, bool dontShowEmpty=false) {
            txtStudentAnswers.Clear();
            foreach (paper paperx in papers)
            {
                string line = paperx.stuID + "\t";
                string firstColStr = getColumnContents(paperx, colIndex);
                if (dontShowEmpty)
                {
                    if (string.IsNullOrWhiteSpace(firstColStr))
                    {
                        continue;
                    }
                }
                line += firstColStr;
                if (secColIndex!=-1){
                    line += getColumnContents(paperx, secColIndex);
                }
                line += "\r\n";
                txtStudentAnswers.Text += line;
            }
        }

        private string getColumnContents(paper paperx, int colIndex)
        {
            switch (colIndex)
            {
                case 1:
                    return paperx.column1;
                case 2:
                    return paperx.column2;
                case 3:
                    return paperx.column3;
                case 4:
                    return paperx.column4;
                case 5:
                    return paperx.column5;
                case 6:
                    return paperx.column6;
                default:
                    return "";
            }
        }

        private void CalculateScores() {
            try
            {
                string[] answers = txtStudentAnswers.Text.Split("\r\n");
                foreach (string answer in answers)
                {
                    string[] parts = answer.Split("\t");
                    if (parts.Length > 2)
                    {
                        MessageBox.Show("Sadece öğrenci numarası ve cevap sütunlarını seçtiğinizden emin olunuz.");
                        break;
                    }
                    if (parts.Length == 2)
                    {
                        string stuNr = parts[0];
                        string stuAnswers = parts[1];
                        string score = "";
                        if (stuAnswers == "")
                        {
                            score = "Girmedi";
                        }
                        else
                        {
                            stuAnswers = stuAnswers.PadRight(txtCorrectAnswers.Text.Length, ' ');
                            score = Compare(txtCorrectAnswers.Text, stuAnswers).ToString();
                        }

                        txtResults.Text += stuNr + "\t" + score.ToString() + "\r\n";
                    }
                }
                lblStatus.Text = "Okuma Tamamlandı";
            }
            catch (Exception ex)
            {
                lblStatus.Text = "Değerlendirilemedi " + ex.Message;
            }
        }

        private decimal Compare(string s1, string s2) {
            decimal score = 0;
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] == s2[i] || s1[i]=='X') {
                    score += numPoints.Value;
                }
            }
            return score;
        }

        private void btnCopy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clipboard.SetText(txtResults.Text);
            lblStatus.Text = "Sonuçlar Panoya Kopyalandı";
            btnCopy.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtCorrectAnswers.Text = txtCorrectAnswers.Text.ToUpper();
            if (checkCorrectAnswers()) {
                txtResults.Text = "";
                CalculateScores();
                btnCopy.Visible = true;
            }
        }

        private bool checkCorrectAnswers() {
            errAnswers.SetError(txtCorrectAnswers, "");
            bool validInput = true;
            char[] allowedCharacters = {'A', 'B', 'C', 'D', 'E', 'X' };
            foreach (char c in txtCorrectAnswers.Text)
            {
                if (!allowedCharacters.Contains(c))
                {
                    errAnswers.SetError(txtCorrectAnswers, "Girdi Hatalı");
                    lblStatus.Text = "Cevap Anahtarını Kontrol Ediniz. Kabul Edilen Değerler : A, B, C, D, E, X";
                    validInput = false;
                    break;
                }
            }
            return validInput;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string fname = selectFile();
            if (fname != "")
            {
                lblFPath.Text = fname;
                lblStatus.Text = "Optik form dosyası seçildi : " + fname;
                papers = readFile(fname);
                this.BringToFront();
                this.Activate();
                grp1.Enabled = true;
                lblStatus.Text = "Sınavınızın Optik Formda Kaçıncı Sütuna İşaretlendiğini Seçiniz";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            writePapers(papers, cmbCol1.SelectedIndex+1, dontShowEmpty: chkEmptyPapers.Enabled);
            lblStatus.Text = "Eğer Sınav Cevapları İlk Sütuna Sığmamış İse Hangi Sütundan Devam Ettiğini Seçiniz";
            grp2.Enabled = true;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCol1.SelectedIndex != -1)
            {
                writePapers(papers, cmbCol1.SelectedIndex + 1, cmbCol2.SelectedIndex + 1, chkEmptyPapers.Enabled);
            }
            else {
                cmbCol2.SelectedIndex = -1;
                lblStatus.Text = "Öncelikle 1. Sütunu Seçiniz";
            }
            
        }

        private void chkEmptyPapers_CheckedChanged(object sender, EventArgs e)
        {
            if (cmbCol2.SelectedIndex == -1)
            {
                writePapers(papers, cmbCol1.SelectedIndex + 1, dontShowEmpty: chkEmptyPapers.Checked);
            }
            else { 
                writePapers(papers, cmbCol1.SelectedIndex + 1, cmbCol2.SelectedIndex + 1, chkEmptyPapers.Checked);
            }
        }

        private void txtCorrectAnswers_TextChanged(object sender, EventArgs e)
        {
            lblCharacterCount.Text = "Soru Sayısı : " + txtCorrectAnswers.Text.Count();
            lblStatus.Text = "Cevap Anahtarınızı Tamamladıktan Sonra Soruların Puan Değerini Girerek Devam Ediniz";
        }

        private void numPoints_ValueChanged(object sender, EventArgs e)
        {
            lblStatus.Text = "Cevap Anahtarı ve Diğer Parametreleri Kontrol Edip Değerlendirmeye Başlayabilirsiniz";
        }
    }
}