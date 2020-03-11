using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsSyntaxHighlighter;
using System.Diagnostics;

namespace Arduino_Pro
{
    public partial class MainWindow : Form
    {
        bool handle = false;

        Keys key = Keys.X;

        string[] autoComplete = { "#include", "int", "float", "String", "double", "digitalRead", "digitalWrite", "pinMode", "analogRead", "analogReference", "analogWrite", "analogReadResolution", "analogWriteResolution", "noTone", "pulseIn", "pulseInLong", "shiftIn", "shiftOut", "tone", "delay", "delayMicroseconds", "micros", "millis", "abs", "constrain", "map", "max", "min", "pow", "sq", "sqrt", "cos", "sin", "tan", "isAlpha", "isAlphaNumeric", "isAscii", "isControl", "isDigit", "isGraph", "isHexadecimalDigit", "isLowerCase", "isPrintable", "isPunct", "isSpace", "isUpperCase", "isWhitespace", "random", "randomSeed", "bit", "bitClear", "bitRead", "bitSet", "bitWrite", "highByte", "lowByte", "attachInterrupt", "detachInterrupt", "interrupts", "noInterrupts", "Serial", "Stream", "HIGH", "LOW", "INPUT", "OUTPUT" };

        public MainWindow()
        {
            InitializeComponent();

            CheckForIllegalCrossThreadCalls = false;

            SyntaxHighlighter highlighter = new SyntaxHighlighter(tbCode);

            highlighter.AddPattern(new PatternDefinition(new string[] { "int", "float", "String", "double", "void", "HIGH", "LOW", "INPUT", "OUTPUT" }), new SyntaxStyle(Color.LightBlue));

            highlighter.AddPattern(new PatternDefinition(new string[] { "digitalRead", "digitalWrite", "pinMode", "analogRead", "analogReference", "analogWrite", "analogReadResolution", "analogWriteResolution", "noTone", "pulseIn", "pulseInLong", "shiftIn", "shiftOut", "tone", "delay", "delayMicroseconds", "micros", "millis", "abs", "constrain", "map", "max", "min", "pow", "sq", "sqrt", "cos", "sin", "tan", "isAlpha", "isAlphaNumeric", "isAscii", "isControl", "isDigit", "isGraph", "isHexadecimalDigit", "isLowerCase", "isPrintable", "isPunct", "isSpace", "isUpperCase", "isWhitespace", "random", "randomSeed", "bit", "bitClear", "bitRead", "bitSet", "bitWrite", "highByte", "lowByte", "attachInterrupt", "detachInterrupt", "interrupts", "noInterrupts", "Serial", "Stream" }), new SyntaxStyle(Color.Orange));

            highlighter.AddPattern(new PatternDefinition(new string[] { "#include", "#define" }), new SyntaxStyle(Color.DarkOliveGreen));
        }
        private void tbCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void IntelliSense()
        {


            lbCompletion.Items.Clear();

            string text = tbCode.Text;

            int pos = tbCode.SelectionStart - 1;

            text = text.Replace('\n', ' ');

            text = text.Replace('\r', ' ');

            for (int i = pos - 1; i > 0; i--)
            {
                if (text[i] == ' ')
                {
                    string currentWord = text.Substring(i + 1, pos - i);

                    if (currentWord != " ")
                    foreach (string item in autoComplete)
                    {
                        if (item.Substring(0, Math.Min(currentWord.Length, item.Length)) == currentWord)
                        {
                            lbCompletion.Items.Add(item);
                        }
                    }

                    break;
                }
            }

            if (lbCompletion.Items.Count > 0)
            {
                Point point = tbCode.GetPositionFromCharIndex(pos + 1);

                point.X += 12;

                point.Y += 48;

                lbCompletion.Location = point;

                lbCompletion.Enabled = true;

                lbCompletion.Visible = true;

                lbCompletion.SelectedIndex = 0;

                lbCompletion.BringToFront();

                lbCompletion.Update();
            }
            else
            {
                lbCompletion.Visible = false;

                lbCompletion.Enabled = false;
            }
        }

        private void tbCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;

            IntelliSense();

            if (!handle)
            {
                int pos = tbCode.SelectionStart;

                tbCode.Text = tbCode.Text.Substring(0, tbCode.SelectionStart) + e.KeyChar + tbCode.Text.Substring(tbCode.SelectionStart);

                tbCode.SelectionStart = pos + 1;
            }
            else
            {
                if (key == Keys.Delete)
                {
                    int pos = tbCode.SelectionStart;

                    tbCode.Text = tbCode.Text.Substring(0, pos - 1) + tbCode.Text.Substring(pos);

                    tbCode.SelectionStart = pos - 1;
                }

                if (key == Keys.Tab)
                {
                    if (lbCompletion.Enabled)
                    {
                        string text = tbCode.Text;

                        int pos = tbCode.SelectionStart - 1;

                        for (int i = pos - 1; i > 0; i--)
                        {
                            if (text[i] == ' ')
                            {
                                i++;

                                tbCode.Text = tbCode.Text.Substring(0, i) + lbCompletion.SelectedItem.ToString() + tbCode.Text.Substring(pos + 1);

                                tbCode.SelectionStart = pos + lbCompletion.SelectedItem.ToString().Length - 3;

                                break;
                            }
                        }
                    }
                    else
                    {
                        int pos = tbCode.SelectionStart;

                        tbCode.Text = tbCode.Text.Substring(0, tbCode.SelectionStart) + "          " + tbCode.Text.Substring(tbCode.SelectionStart);

                        tbCode.SelectionStart = pos + 10;
                    }
                }
            }
        }

        private void tbCode_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            handle = false;

            Debug.WriteLine(e.KeyCode);

            if (e.KeyCode == Keys.Back)
            {
                key = e.KeyCode;

                handle = true;
            }

            if (e.KeyCode == Keys.Tab)
            {
                key = e.KeyCode;

                handle = true;
            }
        }
    }
}