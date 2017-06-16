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
    public partial class Form2 : Form
    {
        int sayac = 0;

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sayac++;
            if (sayac > 2)
                sayac = 0;
        }

        private void yedekklavye(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (sayac == 0)
            {
               
                if (btn.Text == "1")
                {
                    form2txtbox.AppendText("1");
                }
                if (btn.Text == "2")
                {
                    form2txtbox.AppendText("2");
                }
                if (btn.Text == "3")
                {
                    form2txtbox.AppendText("3");
                }
                if (btn.Text == "4")
                {
                    form2txtbox.AppendText("4");
                }
                if (btn.Text == "5")
                {
                    form2txtbox.AppendText("5");
                }
                if (btn.Text == "6")
                {
                    form2txtbox.AppendText("6");
                }
                if (btn.Text == "7")
                {
                    form2txtbox.AppendText("7");
                }
                if (btn.Text == "8")
                {
                    form2txtbox.AppendText("8");
                }
                if (btn.Text == "9")
                {
                    form2txtbox.AppendText("9");
                }
                if (btn.Text == "0")
                {
                    form2txtbox.AppendText("0");
                }
                if (btn.Text == "A")
                {
                    form2txtbox.AppendText("A");
                }
                if (btn.Text == "B")
                {
                    form2txtbox.AppendText("B");
                }
                if (btn.Text == "C")
                {
                    form2txtbox.AppendText("C");
                }
                if (btn.Text == "D")
                {
                    form2txtbox.AppendText("D");
                }
                if (btn.Text == "E")
                {
                    form2txtbox.AppendText("E");
                }
                if (btn.Text == "F")
                {
                    form2txtbox.AppendText("F");
                }
                if (btn.Text == "G")
                {
                    form2txtbox.AppendText("G");
                }
                if (btn.Text == "H")
                {
                    form2txtbox.AppendText("H");
                }
                if (btn.Text == "I")
                {
                    form2txtbox.AppendText("I");
                }
                if (btn.Text == "J")
                {
                    form2txtbox.AppendText("J");
                }
                if (btn.Text == "K")
                {
                    form2txtbox.AppendText("K");
                }
                if (btn.Text == "L")
                {
                    form2txtbox.AppendText("L");
                }
                if (btn.Text == "M")
                {
                    form2txtbox.AppendText("M");
                }
                if (btn.Text == "N")
                {
                    form2txtbox.AppendText("N");
                }
                if (btn.Text == "O")
                {
                    form2txtbox.AppendText("O");
                }
                if (btn.Text == "P")
                {
                    form2txtbox.AppendText("P");
                }
                if (btn.Text == "R")
                {
                    form2txtbox.AppendText("R");
                }
                if (btn.Text == "S")
                {
                    form2txtbox.AppendText("S");
                }
                if (btn.Text == "T")
                {
                    form2txtbox.AppendText("T");
                }
                if (btn.Text == "U")
                {
                    form2txtbox.AppendText("U");
                }
                if (btn.Text == "V")
                {
                    form2txtbox.AppendText("V");
                }
                if (btn.Text == "Y")
                {
                    form2txtbox.AppendText("Y");
                }
                if (btn.Text == "Z")
                {
                    form2txtbox.AppendText("Z");
                }
                if (btn.Text == "Q")
                {
                    form2txtbox.AppendText("Q");
                }
                if (btn.Text == "W")
                {
                    form2txtbox.AppendText("W");
                }
                if (btn.Text == "X")
                {
                    form2txtbox.AppendText("X");
                }
                if (btn.Text == "DEL")
                {
                    form2txtbox.Text = "";
                }
                if (btn.Text == "BACK")
                {
                    form2txtbox.Text = form2txtbox.Text.Remove(form2txtbox.Text.Length - 1, 1);
                }

                if (btn.Text == "@")
                {
                    form2txtbox.AppendText("@");
                }
                if (btn.Text == ".")
                {
                    form2txtbox.AppendText(".");
                }
                if (btn.Text == ",")
                {
                    form2txtbox.AppendText(",");
                }
                if (btn.Text == "-")
                {
                    form2txtbox.AppendText("-");
                }
                if (btn.Text == "?")
                {
                    form2txtbox.AppendText("?");
                }
                if (btn.Text == "!")
                {
                    form2txtbox.AppendText("!");
                }
                if (btn.Text == ".com")
                {
                    form2txtbox.AppendText(".com");
                }

                if (btn.Text == "+")
                {
                    form2txtbox.AppendText("+");
                }
                if (btn.Text == "#")
                {
                    form2txtbox.AppendText("#");
                }
                if (btn.Text == "*")
                {
                    form2txtbox.AppendText("*");
                }
                if (btn.Text == "_")
                {
                    form2txtbox.AppendText("_");
                }


                if (btn.Text == "a")
                {
                    form2txtbox.AppendText("a");
                }
                if (btn.Text == "b")
                {
                    form2txtbox.AppendText("b");
                }
                if (btn.Text == "c")
                {
                    form2txtbox.AppendText("c");
                }
                if (btn.Text == "d")
                {
                    form2txtbox.AppendText("d");
                }
                if (btn.Text == "e")
                {
                    form2txtbox.AppendText("e");
                }
                if (btn.Text == "f")
                {
                    form2txtbox.AppendText("f");
                }
                if (btn.Text == "g")
                {
                    form2txtbox.AppendText("g");
                }
                if (btn.Text == "h")
                {
                    form2txtbox.AppendText("h");
                }
                if (btn.Text == "i")
                {
                    form2txtbox.AppendText("i");
                }
                if (btn.Text == "j")
                {
                    form2txtbox.AppendText("j");
                }
                if (btn.Text == "k")
                {
                    form2txtbox.AppendText("k");
                }
                if (btn.Text == "l")
                {
                    form2txtbox.AppendText("l");
                }
                if (btn.Text == "m")
                {
                    form2txtbox.AppendText("m");
                }
                if (btn.Text == "n")
                {
                    form2txtbox.AppendText("n");
                }
                if (btn.Text == "o")
                {
                    form2txtbox.AppendText("o");
                }
                if (btn.Text == "p")
                {
                    form2txtbox.AppendText("p");
                }
                if (btn.Text == "r")
                {
                    form2txtbox.AppendText("r");
                }
                if (btn.Text == "s")
                {
                    form2txtbox.AppendText("s");
                }
                if (btn.Text == "t")
                {
                    form2txtbox.AppendText("t");
                }
                if (btn.Text == "u")
                {
                    form2txtbox.AppendText("u");
                }
                if (btn.Text == "v")
                {
                    form2txtbox.AppendText("v");
                }
                if (btn.Text == "y")
                {
                    form2txtbox.AppendText("y");
                }
                if (btn.Text == "z")
                {
                    form2txtbox.AppendText("z");
                }
                if (btn.Text == "q")
                {
                    form2txtbox.AppendText("q");
                }
                if (btn.Text == "w")
                {
                    form2txtbox.AppendText("w");
                }
                if (btn.Text == "x")
                {
                    form2txtbox.AppendText("x");
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

            if (sayac == 1)
            {

                if (btn.Text == "1")
                {
                    form2txtbox2.AppendText("1");
                }
                if (btn.Text == "2")
                {
                    form2txtbox2.AppendText("2");
                }
                if (btn.Text == "3")
                {
                    form2txtbox2.AppendText("3");
                }
                if (btn.Text == "4")
                {
                    form2txtbox2.AppendText("4");
                }
                if (btn.Text == "5")
                {
                    form2txtbox2.AppendText("5");
                }
                if (btn.Text == "6")
                {
                    form2txtbox2.AppendText("6");
                }
                if (btn.Text == "7")
                {
                    form2txtbox2.AppendText("7");
                }
                if (btn.Text == "8")
                {
                    form2txtbox2.AppendText("8");
                }
                if (btn.Text == "9")
                {
                    form2txtbox2.AppendText("9");
                }
                if (btn.Text == "0")
                {
                    form2txtbox2.AppendText("0");
                }
                if (btn.Text == "A")
                {
                    form2txtbox2.AppendText("A");
                }
                if (btn.Text == "B")
                {
                    form2txtbox2.AppendText("B");
                }
                if (btn.Text == "C")
                {
                    form2txtbox2.AppendText("C");
                }
                if (btn.Text == "D")
                {
                    form2txtbox2.AppendText("D");
                }
                if (btn.Text == "E")
                {
                    form2txtbox2.AppendText("E");
                }
                if (btn.Text == "F")
                {
                    form2txtbox2.AppendText("F");
                }
                if (btn.Text == "G")
                {
                    form2txtbox2.AppendText("G");
                }
                if (btn.Text == "H")
                {
                    form2txtbox2.AppendText("H");
                }
                if (btn.Text == "I")
                {
                    form2txtbox2.AppendText("I");
                }
                if (btn.Text == "J")
                {
                    form2txtbox2.AppendText("J");
                }
                if (btn.Text == "K")
                {
                    form2txtbox2.AppendText("K");
                }
                if (btn.Text == "L")
                {
                    form2txtbox2.AppendText("L");
                }
                if (btn.Text == "M")
                {
                    form2txtbox2.AppendText("M");
                }
                if (btn.Text == "N")
                {
                    form2txtbox2.AppendText("N");
                }
                if (btn.Text == "O")
                {
                    form2txtbox2.AppendText("O");
                }
                if (btn.Text == "P")
                {
                    form2txtbox2.AppendText("P");
                }
                if (btn.Text == "R")
                {
                    form2txtbox2.AppendText("R");
                }
                if (btn.Text == "S")
                {
                    form2txtbox2.AppendText("S");
                }
                if (btn.Text == "T")
                {
                    form2txtbox2.AppendText("T");
                }
                if (btn.Text == "U")
                {
                    form2txtbox2.AppendText("U");
                }
                if (btn.Text == "V")
                {
                    form2txtbox2.AppendText("V");
                }
                if (btn.Text == "Y")
                {
                    form2txtbox2.AppendText("Y");
                }
                if (btn.Text == "Z")
                {
                    form2txtbox2.AppendText("Z");
                }
                if (btn.Text == "Q")
                {
                    form2txtbox2.AppendText("Q");
                }
                if (btn.Text == "W")
                {
                    form2txtbox2.AppendText("W");
                }
                if (btn.Text == "X")
                {
                    form2txtbox2.AppendText("X");
                }
                if (btn.Text == "DEL")
                {
                    form2txtbox2.Text = "";
                }
                if (btn.Text == "BACK")
                {
                    form2txtbox2.Text = form2txtbox2.Text.Remove(form2txtbox2.Text.Length - 1, 1);
                }

                if (btn.Text == "@")
                {
                    form2txtbox2.AppendText("@");
                }
                if (btn.Text == ".")
                {
                    form2txtbox2.AppendText(".");
                }
                if (btn.Text == ",")
                {
                    form2txtbox2.AppendText(",");
                }
                if (btn.Text == "-")
                {
                    form2txtbox2.AppendText("-");
                }
                if (btn.Text == "?")
                {
                    form2txtbox2.AppendText("?");
                }
                if (btn.Text == "!")
                {
                    form2txtbox2.AppendText("!");
                }
                if (btn.Text == ".com")
                {
                    form2txtbox2.AppendText(".com");
                }

                if (btn.Text == "+")
                {
                    form2txtbox2.AppendText("+");
                }
                if (btn.Text == "#")
                {
                    form2txtbox2.AppendText("#");
                }
                if (btn.Text == "*")
                {
                    form2txtbox2.AppendText("*");
                }
                if (btn.Text == "_")
                {
                    form2txtbox2.AppendText("_");
                }


                if (btn.Text == "a")
                {
                    form2txtbox2.AppendText("a");
                }
                if (btn.Text == "b")
                {
                    form2txtbox2.AppendText("b");
                }
                if (btn.Text == "c")
                {
                    form2txtbox2.AppendText("c");
                }
                if (btn.Text == "d")
                {
                    form2txtbox2.AppendText("d");
                }
                if (btn.Text == "e")
                {
                    form2txtbox2.AppendText("e");
                }
                if (btn.Text == "f")
                {
                    form2txtbox2.AppendText("f");
                }
                if (btn.Text == "g")
                {
                    form2txtbox2.AppendText("g");
                }
                if (btn.Text == "h")
                {
                    form2txtbox2.AppendText("h");
                }
                if (btn.Text == "i")
                {
                    form2txtbox2.AppendText("i");
                }
                if (btn.Text == "j")
                {
                    form2txtbox2.AppendText("j");
                }
                if (btn.Text == "k")
                {
                    form2txtbox2.AppendText("k");
                }
                if (btn.Text == "l")
                {
                    form2txtbox2.AppendText("l");
                }
                if (btn.Text == "m")
                {
                    form2txtbox2.AppendText("m");
                }
                if (btn.Text == "n")
                {
                    form2txtbox2.AppendText("n");
                }
                if (btn.Text == "o")
                {
                    form2txtbox2.AppendText("o");
                }
                if (btn.Text == "p")
                {
                    form2txtbox2.AppendText("p");
                }
                if (btn.Text == "r")
                {
                    form2txtbox2.AppendText("r");
                }
                if (btn.Text == "s")
                {
                    form2txtbox2.AppendText("s");
                }
                if (btn.Text == "t")
                {
                    form2txtbox2.AppendText("t");
                }
                if (btn.Text == "u")
                {
                    form2txtbox2.AppendText("u");
                }
                if (btn.Text == "v")
                {
                    form2txtbox2.AppendText("v");
                }
                if (btn.Text == "y")
                {
                    form2txtbox2.AppendText("y");
                }
                if (btn.Text == "z")
                {
                    form2txtbox2.AppendText("z");
                }
                if (btn.Text == "q")
                {
                    form2txtbox2.AppendText("q");
                }
                if (btn.Text == "w")
                {
                    form2txtbox2.AppendText("w");
                }
                if (btn.Text == "x")
                {
                    form2txtbox2.AppendText("x");
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

            if (sayac == 2)
            {

                if (btn.Text == "1")
                {
                    form2textBox3.AppendText("1");
                }
                if (btn.Text == "2")
                {
                    form2textBox3.AppendText("2");
                }
                if (btn.Text == "3")
                {
                    form2textBox3.AppendText("3");
                }
                if (btn.Text == "4")
                {
                    form2textBox3.AppendText("4");
                }
                if (btn.Text == "5")
                {
                    form2textBox3.AppendText("5");
                }
                if (btn.Text == "6")
                {
                    form2textBox3.AppendText("6");
                }
                if (btn.Text == "7")
                {
                    form2textBox3.AppendText("7");
                }
                if (btn.Text == "8")
                {
                    form2textBox3.AppendText("8");
                }
                if (btn.Text == "9")
                {
                    form2textBox3.AppendText("9");
                }
                if (btn.Text == "0")
                {
                    form2textBox3.AppendText("0");
                }
                if (btn.Text == "A")
                {
                    form2textBox3.AppendText("A");
                }
                if (btn.Text == "B")
                {
                    form2textBox3.AppendText("B");
                }
                if (btn.Text == "C")
                {
                    form2textBox3.AppendText("C");
                }
                if (btn.Text == "D")
                {
                    form2textBox3.AppendText("D");
                }
                if (btn.Text == "E")
                {
                    form2textBox3.AppendText("E");
                }
                if (btn.Text == "F")
                {
                    form2textBox3.AppendText("F");
                }
                if (btn.Text == "G")
                {
                    form2textBox3.AppendText("G");
                }
                if (btn.Text == "H")
                {
                    form2textBox3.AppendText("H");
                }
                if (btn.Text == "I")
                {
                    form2textBox3.AppendText("I");
                }
                if (btn.Text == "J")
                {
                    form2textBox3.AppendText("J");
                }
                if (btn.Text == "K")
                {
                    form2textBox3.AppendText("K");
                }
                if (btn.Text == "L")
                {
                    form2textBox3.AppendText("L");
                }
                if (btn.Text == "M")
                {
                    form2textBox3.AppendText("M");
                }
                if (btn.Text == "N")
                {
                    form2textBox3.AppendText("N");
                }
                if (btn.Text == "O")
                {
                    form2textBox3.AppendText("O");
                }
                if (btn.Text == "P")
                {
                    form2textBox3.AppendText("P");
                }
                if (btn.Text == "R")
                {
                    form2textBox3.AppendText("R");
                }
                if (btn.Text == "S")
                {
                    form2textBox3.AppendText("S");
                }
                if (btn.Text == "T")
                {
                    form2textBox3.AppendText("T");
                }
                if (btn.Text == "U")
                {
                    form2textBox3.AppendText("U");
                }
                if (btn.Text == "V")
                {
                    form2textBox3.AppendText("V");
                }
                if (btn.Text == "Y")
                {
                    form2textBox3.AppendText("Y");
                }
                if (btn.Text == "Z")
                {
                    form2textBox3.AppendText("Z");
                }
                if (btn.Text == "Q")
                {
                    form2textBox3.AppendText("Q");
                }
                if (btn.Text == "W")
                {
                    form2textBox3.AppendText("W");
                }
                if (btn.Text == "X")
                {
                    form2textBox3.AppendText("X");
                }
                if (btn.Text == "DEL")
                {
                    form2textBox3.Text = "";
                }
                if (btn.Text == "BACK")
                {
                    form2textBox3.Text = form2textBox3.Text.Remove(form2textBox3.Text.Length - 1, 1);
                }

                if (btn.Text == "@")
                {
                    form2textBox3.AppendText("@");
                }
                if (btn.Text == ".")
                {
                    form2textBox3.AppendText(".");
                }
                if (btn.Text == ",")
                {
                    form2textBox3.AppendText(",");
                }
                if (btn.Text == "-")
                {
                    form2textBox3.AppendText("-");
                }
                if (btn.Text == "?")
                {
                    form2textBox3.AppendText("?");
                }
                if (btn.Text == "!")
                {
                    form2textBox3.AppendText("!");
                }
                if (btn.Text == ".com")
                {
                    form2textBox3.AppendText(".com");
                }

                if (btn.Text == "+")
                {
                    form2textBox3.AppendText("+");
                }
                if (btn.Text == "#")
                {
                    form2textBox3.AppendText("#");
                }
                if (btn.Text == "*")
                {
                    form2textBox3.AppendText("*");
                }
                if (btn.Text == "_")
                {
                    form2textBox3.AppendText("_");
                }


                if (btn.Text == "a")
                {
                    form2textBox3.AppendText("a");
                }
                if (btn.Text == "b")
                {
                    form2textBox3.AppendText("b");
                }
                if (btn.Text == "c")
                {
                    form2textBox3.AppendText("c");
                }
                if (btn.Text == "d")
                {
                    form2textBox3.AppendText("d");
                }
                if (btn.Text == "e")
                {
                    form2textBox3.AppendText("e");
                }
                if (btn.Text == "f")
                {
                    form2textBox3.AppendText("f");
                }
                if (btn.Text == "g")
                {
                    form2textBox3.AppendText("g");
                }
                if (btn.Text == "h")
                {
                    form2textBox3.AppendText("h");
                }
                if (btn.Text == "i")
                {
                    form2textBox3.AppendText("i");
                }
                if (btn.Text == "j")
                {
                    form2textBox3.AppendText("j");
                }
                if (btn.Text == "k")
                {
                    form2textBox3.AppendText("k");
                }
                if (btn.Text == "l")
                {
                    form2textBox3.AppendText("l");
                }
                if (btn.Text == "m")
                {
                    form2textBox3.AppendText("m");
                }
                if (btn.Text == "n")
                {
                    form2textBox3.AppendText("n");
                }
                if (btn.Text == "o")
                {
                    form2textBox3.AppendText("o");
                }
                if (btn.Text == "p")
                {
                    form2textBox3.AppendText("p");
                }
                if (btn.Text == "r")
                {
                    form2textBox3.AppendText("r");
                }
                if (btn.Text == "s")
                {
                    form2textBox3.AppendText("s");
                }
                if (btn.Text == "t")
                {
                    form2textBox3.AppendText("t");
                }
                if (btn.Text == "u")
                {
                    form2textBox3.AppendText("u");
                }
                if (btn.Text == "v")
                {
                    form2textBox3.AppendText("v");
                }
                if (btn.Text == "y")
                {
                    form2textBox3.AppendText("y");
                }
                if (btn.Text == "z")
                {
                    form2textBox3.AppendText("z");
                }
                if (btn.Text == "q")
                {
                    form2textBox3.AppendText("q");
                }
                if (btn.Text == "w")
                {
                    form2textBox3.AppendText("w");
                }
                if (btn.Text == "x")
                {
                    form2textBox3.AppendText("x");
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


                if (btn.Text == "OK")
                {
                    string mail;
                    string form2sifre = "";
                    string GeciciSifre;

                    mail = form2txtbox.Text.ToString();


                    GeciciSifre = form2txtbox2.Text.ToString();

                    if (GeciciSifre == form2textBox3.Text.ToString()&& GeciciSifre.Length>=6 && mail.Contains("@gmail.com") == true)
                    {
                        form2sifre = GeciciSifre;
                        Form1.sifre = GeciciSifre;
                        XmlTextWriter yaz = new XmlTextWriter("bilgi.xml", System.Text.UTF8Encoding.UTF8);
                        yaz.Formatting = Formatting.Indented;

                        yaz.WriteStartDocument();
                        yaz.WriteStartElement("Banka");
                        yaz.WriteStartElement("MüşteriMail");
                        yaz.WriteAttributeString("id", "1");
                        yaz.WriteElementString("sifre", form2sifre);
                        yaz.WriteElementString("eposta", mail);
                        yaz.WriteEndElement();
                        yaz.WriteEndElement();

                        yaz.Close();
                        XmlTextReader bilgi = new XmlTextReader("bilgi.xml");
                        while (bilgi.Read())
                        {
                            if (bilgi.NodeType == XmlNodeType.Element)
                            {
                                switch (bilgi.Name)
                                {
                                    case "eposta": mail = (Convert.ToString(bilgi.ReadString()));
                                        break;
                                    case "sifre": GeciciSifre = (Convert.ToString(bilgi.ReadString()));
                                        break;
                                }

                            }
                        }
                        try
                        {
                            MailMessage mesaj = new MailMessage();
                            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                            mesaj.From = new MailAddress("metinvatansevernitem@gmail.com");
                            mesaj.To.Add(mail);
                            mesaj.Subject = "Sifre Degisim";
                            mesaj.Body = "Yeni sifreniz:\n" + GeciciSifre;

                            SmtpServer.Port = 587;
                            SmtpServer.Credentials = new System.Net.NetworkCredential("metinvatansevernitem@gmail.com", "mv123456");
                            SmtpServer.EnableSsl = true;

                            SmtpServer.Send(mesaj);
                            MessageBox.Show("Mail Gönderimi Başarılı");
                            Form1.mail = mail;
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


                        
                        this.Hide();
                        Form1 frm1 = new Form1();
                        frm1.Show();
                    }

                    else
                    {
                        if (GeciciSifre.Length<=6)
                        {
                            MessageBox.Show("Şifrenizin uzunluğu 6 karakter ve daha fazlası olması gerekiyor", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        if (mail.Contains("@gmail.com") == false)
                        {
                            MessageBox.Show("Lütfen @gmail.com ile sonlanan bir adres kullanınız", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        if (GeciciSifre != form2textBox3.Text.ToString())
                        {
                            MessageBox.Show("Şifreler uyumsuz !! Yeniden giriniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
            


        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

       

        
    }
}
