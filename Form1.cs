using System.Security.Cryptography.X509Certificates;
using static System.Formats.Asn1.AsnWriter;

namespace UZEMYO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
    }
}