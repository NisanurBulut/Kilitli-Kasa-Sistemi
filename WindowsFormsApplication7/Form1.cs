using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Net.Sockets;
using System.Net.Mail;

namespace WindowsFormsApplication7
{
    public partial class Form1 : Form
    {
        public static string sifre = "1a35BRd";
        public static string mail;
        public  int counter=0;
        Form2 frm = new Form2();

        public Form1()
        {
            InitializeComponent();
        }
        public void klavye(object sender, EventArgs e)
        {
          
       
            Button btn = (Button)sender;
            

            if (btn.Text == "1")
            {
                txtarayuz.AppendText("1");
            }
            if (btn.Text == "2")
            {
                txtarayuz.AppendText("2");
            }
            if (btn.Text == "3")
            {
                txtarayuz.AppendText("3");
            }
            if (btn.Text == "4")
            {
                txtarayuz.AppendText("4");
            }
            if (btn.Text == "5")
            {
                txtarayuz.AppendText("5");
            }
            if (btn.Text == "6")
            {
                txtarayuz.AppendText("6");
            }
            if (btn.Text == "7")
            {
                txtarayuz.AppendText("7");
            }
            if (btn.Text == "8")
            {
                txtarayuz.AppendText("8");
            }
            if (btn.Text == "9")
            {
                txtarayuz.AppendText("9");
            }
            if (btn.Text == "0")
            {
                txtarayuz.AppendText("0");
            }
            if (btn.Text == "A")
            {
                txtarayuz.AppendText("A");
            }
            if (btn.Text == "B")
            {
                txtarayuz.AppendText("B");
            }
            if (btn.Text == "C")
            {
                txtarayuz.AppendText("C");
            }
            if (btn.Text == "D")
            {
                txtarayuz.AppendText("D");
            }
            if (btn.Text == "E")
            {
                txtarayuz.AppendText("E");
            }
            if (btn.Text == "F")
            {
                txtarayuz.AppendText("F");
            }
            if (btn.Text == "G")
            {
                txtarayuz.AppendText("G");
            }
            if (btn.Text == "H")
            {
                txtarayuz.AppendText("H");
            }
            if (btn.Text == "I")
            {
                txtarayuz.AppendText("I");
            }
            if (btn.Text == "J")
            {
                txtarayuz.AppendText("J");
            }
            if (btn.Text == "K")
            {
                txtarayuz.AppendText("K");
            }
            if (btn.Text == "L")
            {
                txtarayuz.AppendText("L");
            }
            if (btn.Text == "M")
            {
                txtarayuz.AppendText("M");
            }
            if (btn.Text == "N")
            {
                txtarayuz.AppendText("N");
            }
            if (btn.Text == "O")
            {
                txtarayuz.AppendText("O");
            }
            if (btn.Text == "P")
            {
                txtarayuz.AppendText("P");
            }
            if (btn.Text == "R")
            {
                txtarayuz.AppendText("R");
            }
            if (btn.Text == "S")
            {
                txtarayuz.AppendText("S");
            }
            if (btn.Text == "T")
            {
                txtarayuz.AppendText("T");
            }
            if (btn.Text == "U")
            {
                txtarayuz.AppendText("U");
            }
            if (btn.Text == "V")
            {
                txtarayuz.AppendText("V");
            }
            if (btn.Text == "Y")
            {
                txtarayuz.AppendText("Y");
            }
            if (btn.Text == "Z")
            {
                txtarayuz.AppendText("Z");
            }
            if (btn.Text == "Q")
            {
                txtarayuz.AppendText("Q");
            }
            if (btn.Text == "W")
            {
                txtarayuz.AppendText("W");
            }
            if (btn.Text == "X")
            {
                txtarayuz.AppendText("X");
            }
            if (btn.Text == "DEL")
            {
                txtarayuz.Text = "";
            }
            if (btn.Text == "BACK")
            {
                txtarayuz.Text = txtarayuz.Text.Remove(txtarayuz.Text.Length - 1, 1);
            }
          
            if (btn.Text == "@")
            {
                txtarayuz.AppendText("@");
            }
            if (btn.Text == ".")
            {
                txtarayuz.AppendText(".");
            }
            if (btn.Text == ",")
            {
                txtarayuz.AppendText(",");
            }
            if (btn.Text == "-")
            {
                txtarayuz.AppendText("-");
            }
            if (btn.Text == "?")
            {
                txtarayuz.AppendText("?");
            }
            if (btn.Text == "!")
            {
                txtarayuz.AppendText("!");
            }
            if (btn.Text == ".com")
            {
                txtarayuz.AppendText(".com");
            }

            if (btn.Text == "+")
            {
                txtarayuz.AppendText("+");
            }
            if (btn.Text == "#")
            {
                txtarayuz.AppendText("#");
            }
            if (btn.Text == "*")
            {
                txtarayuz.AppendText("*");
            }
            if (btn.Text == "_")
            {
                txtarayuz.AppendText("_");
            }


            if (btn.Text == "a")
            {
                txtarayuz.AppendText("a");
            }
            if (btn.Text == "b")
            {
                txtarayuz.AppendText("b");
            }
            if (btn.Text == "c")
            {
                txtarayuz.AppendText("c");
            }
            if (btn.Text == "d")
            {
                txtarayuz.AppendText("d");
            }
            if (btn.Text == "e")
            {
                txtarayuz.AppendText("e");
            }
            if (btn.Text == "f")
            {
                txtarayuz.AppendText("f");
            }
            if (btn.Text == "g")
            {
                txtarayuz.AppendText("g");
            }
            if (btn.Text == "h")
            {
                txtarayuz.AppendText("h");
            }
            if (btn.Text == "i")
            {
                txtarayuz.AppendText("i");
            }
            if (btn.Text == "j")
            {
                txtarayuz.AppendText("j");
            }
            if (btn.Text == "k")
            {
                txtarayuz.AppendText("k");
            }
            if (btn.Text == "l")
            {
                txtarayuz.AppendText("l");
            }
            if (btn.Text == "m")
            {
                txtarayuz.AppendText("m");
            }
            if (btn.Text == "n")
            {
                txtarayuz.AppendText("n");
            }
            if (btn.Text == "o")
            {
                txtarayuz.AppendText("o");
            }
            if (btn.Text == "p")
            {
                txtarayuz.AppendText("p");
            }
            if (btn.Text == "r")
            {
                txtarayuz.AppendText("r");
            }
            if (btn.Text == "s")
            {
                txtarayuz.AppendText("s");
            }
            if (btn.Text == "t")
            {
                txtarayuz.AppendText("t");
            }
            if (btn.Text == "u")
            {
                txtarayuz.AppendText("u");
            }
            if (btn.Text == "v")
            {
                txtarayuz.AppendText("v");
            }
            if (btn.Text == "y")
            {
                txtarayuz.AppendText("y");
            }
            if (btn.Text == "z")
            {
                txtarayuz.AppendText("z");
            }
            if (btn.Text == "q")
            {
                txtarayuz.AppendText("q");
            }
            if (btn.Text == "w")
            {
                txtarayuz.AppendText("w");
            }
            if (btn.Text == "x")
            {
                txtarayuz.AppendText("x");
            }

            if (btn.Text == "DOWN")
            {
             
                button11.Text = "q";
                button12.Text = "w";
                button13.Text = "e";
                button14.Text = "r";
                button15.Text = "t";
                button16.Text = "y";
                button17.Text = "u";
                button18.Text = "i";
                button19.Text = "o";
                button20.Text = "p";
                button21.Text = "a";
                button22.Text = "s";
                button23.Text = "d";
                button24.Text = "f";
                button25.Text = "g";
                button26.Text = "h";
                button27.Text = "j";
                button28.Text = "k";
                button29.Text = "l";
                button31.Text = "z";
                button32.Text = "x";
                button33.Text = "c";
                button34.Text = "v";
                button35.Text = "b";
                button36.Text = "n";
                button37.Text = "m";
            }

            if (btn.Text == "UP")
            {
                button11.Text = "Q";
                button12.Text = "W";
                button13.Text = "E";
                button14.Text = "R";
                button15.Text = "T";
                button16.Text = "Y";
                button17.Text = "U";
                button18.Text = "I";
                button19.Text = "O";
                button20.Text = "P";
                button21.Text = "A";
                button22.Text = "S";
                button23.Text = "D";
                button24.Text = "F";
                button25.Text = "G";
                button26.Text = "H";
                button27.Text = "J";
                button28.Text = "K";
                button29.Text = "L";
                button31.Text = "Z";
                button32.Text = "X";
                button33.Text = "C";
                button34.Text = "V";
                button35.Text = "B";
                button36.Text = "N";
                button37.Text = "M";


            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void KontrolSifre(object sender, EventArgs e)
        {
            string s = txtarayuz.Text.ToString();
            DialogResult soru;

            if (s == "1a35BRd")
            {
                MessageBox.Show("Size verilen ilk şifreyle giriş yaptınız.Güvenlik için kasanın şifresini güncellemeniz önerilir.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
            if (s == sifre)
            {
                counter = 0;
                soru = MessageBox.Show("Güncelleme yapılsın mı", "Bildirim", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (soru == DialogResult.Yes)
                {
                    frm.Show();
                    this.Hide();
                }
                else if (soru == DialogResult.No)
                {
                    MessageBox.Show("Kasa açıldı...","Bildirim",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                   
                }

                else
                {
                    MessageBox.Show("Kasa açıldı...", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    
                }
            }
            else
            {
                MessageBox.Show("Girdiğiniz şifre yanlış!!!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                counter++;
            }
            if (counter == 3)
            {
                if (mail == null)
                {
                    MessageBox.Show("Lütfen size vermiş olduğumuz ilk şifre ile giriş yapıp bilgilerinizi güncelleyiniz", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    counter = 0;
                }
                else
                {
                    counter = 0;
                    try
                    {
                        MailMessage mesaj = new MailMessage();
                        SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                        mesaj.From = new MailAddress("metinvatansevernitem@gmail.com");
                        mesaj.To.Add(mail);
                        mesaj.Subject = "Sistem Uyarı";
                        mesaj.Body = "Şifreniz 3. kez yanlış girildi!Dikkatinize!15 dakika sonra sisteminiz tekrar devreye girecektir";

                        SmtpServer.Port = 587;
                        SmtpServer.Credentials = new System.Net.NetworkCredential("metinvatansevernitem@gmail.com", "mv123456");
                        SmtpServer.EnableSsl = true;

                        SmtpServer.Send(mesaj);
                        MessageBox.Show("Mail Gönderimi Başarılı");
                        this.Hide();
                        timer2.Enabled = true;


                    }
                    catch (Exception ex)
                    {
                        MailMessage mesaj = new MailMessage();
                        SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                        mesaj.From = new MailAddress("metinvatansevernitem@gmail.com");
                        mesaj.To.Add("nisanurrunasin@gmail.com");
                        mesaj.Subject = "Sistem Hatası";
                        mesaj.Body = ex.ToString() + "Kullanici hesabi:" + mail;

                        SmtpServer.Port = 587;
                        SmtpServer.Credentials = new System.Net.NetworkCredential("metinvatansevernitem@gmail.com", "mv123456");
                        SmtpServer.EnableSsl = true;

                        SmtpServer.Send(mesaj);
                        MessageBox.Show("Mail gönderme işleminiz başarısız olmuştur.Hata bilgileriniz sistemimize ulastirildi.En yakın zamanda sorununuzun çözümü size ulastirilacaktir", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                }
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < 4; i++)
            {
                int ascii = rastgele.Next(48, 57);
                char karakter = Convert.ToChar(ascii);
                sb.Append(karakter);
            }
            for (int i = 0; i < 3; i++)
            {
                int ascii = rastgele.Next(65, 87);
                char karakter = Convert.ToChar(ascii);
                sb.Append(karakter);
            }
            for (int i = 0; i < 3; i++)
            {
                int ascii = rastgele.Next(97, 122);
                char karakter = Convert.ToChar(ascii);
                sb.Append(karakter);
            }


            if (mail != null)
            {
                sifre = sb.ToString();


                try
                {
                    MailMessage mesaj = new MailMessage();
                    SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                    mesaj.From = new MailAddress("metinvatansevernitem@gmail.com");
                    mesaj.To.Add(mail);


                    mesaj.Subject = "Sifre Degisim";
                    mesaj.Body = "Yeni sifreniz:\n" + sifre;

                    SmtpServer.Port = 587;
                    SmtpServer.Credentials = new System.Net.NetworkCredential("metinvatansevernitem@gmail.com", "mv123456");
                    SmtpServer.EnableSsl = true;

                    SmtpServer.Send(mesaj);
                    MessageBox.Show("Mail Gönderimi Başarılı");
                }
                catch (Exception ex)
                {
                    MailMessage mesaj = new MailMessage();
                    SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                    mesaj.From = new MailAddress("metinvatansevernitem@gmail.com");
                    mesaj.To.Add("nisanurrunasin@gmail.com");
                    mesaj.Subject = "Sistem Hatası";
                    mesaj.Body = ex.ToString() + "Kullanici hesabi:" + mail;

                    SmtpServer.Port = 587;
                    SmtpServer.Credentials = new System.Net.NetworkCredential("metinvatansevernitem@gmail.com", "mv123456");
                    SmtpServer.EnableSsl = true;

                    SmtpServer.Send(mesaj);
                    MessageBox.Show("Mail gönderme işleminiz başarısız olmuştur.Hata bilgileriniz sistemimize ulastirildi.En yakın zamanda sorununuzun çözümü size ulastirilacaktir", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }

              else
                  {
                    MessageBox.Show("Sistem bilgileri güncellenmediği için şifre maili gönderilemedi.Lütfen size verdiğimiz şifreyle bilgilerinizi güncelleyiniz.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                  }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
            Form1 frm3 = new Form1();
            frm3.Show();
            timer2.Enabled = false;
        }

        private void button49_MouseHover(object sender, EventArgs e)
        {
            ToolTip Aciklama = new ToolTip();
            Aciklama.SetToolTip(button49, "Harfler Küçülür");
            Aciklama.ToolTipTitle = "Dikkat!";
        }

        private void button39_MouseHover(object sender, EventArgs e)
        {
            ToolTip Aciklama = new ToolTip();
            Aciklama.SetToolTip(button39, "Son Harfi Siler");
            Aciklama.ToolTipTitle = "Dikkat!";
        }

        private void button38_MouseHover(object sender, EventArgs e)
        {
            ToolTip Aciklama = new ToolTip();
            Aciklama.SetToolTip(button38, "Textbox Tamamen Silinir");
            Aciklama.ToolTipTitle = "Dikkat!";
        }

        private void button30_MouseHover(object sender, EventArgs e)
        {
            ToolTip Aciklama = new ToolTip();
            Aciklama.SetToolTip(button30, "Harfler üyür");
            Aciklama.ToolTipTitle = "Dikkat!";
        }

       
            }



        }
    

