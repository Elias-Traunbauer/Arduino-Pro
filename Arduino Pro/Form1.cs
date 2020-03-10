using System;
using Skybrud.SyntaxHighlighter;
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
        bool isHandled = false;

        string[] autoComplete = { "#include", "int", "float", "String", "double", "digitalRead", "digitalWrite", "pinMode", "analogRead", "analogReference", "analogWrite", "analogReadResolution", "analogWriteResolution", "noTone", "pulseIn", "pulseInLong", "shiftIn", "shiftOut", "tone", "delay", "delayMicroseconds", "micros", "millis", "abs", "constrain", "map", "max", "min", "pow", "sq", "sqrt", "cos", "sin", "tan", "isAlpha", "isAlphaNumeric", "isAscii", "isControl", "isDigit", "isGraph", "isHexadecimalDigit", "isLowerCase", "isPrintable", "isPunct", "isSpace", "isUpperCase", "isWhitespace", "random", "randomSeed", "bit", "bitClear", "bitRead", "bitSet", "bitWrite", "highByte", "lowByte", "attachInterrupt", "detachInterrupt", "interrupts", "noInterrupts", "Serial", "Stream", "HIGH", "LOW", "INPUT", "OUTPUT" };

        public MainWindow()
        {
            InitializeComponent();

            CheckForIllegalCrossThreadCalls = false;

            SyntaxHighlighter highlighter = new SyntaxHighlighter(tbCode, lbCompletion);

            highlighter.AddPattern(new PatternDefinition(new string[] { "int", "float", "String", "double", "void", "HIGH", "LOW", "INPUT", "OUTPUT" }), new SyntaxStyle(Color.LightBlue));

            highlighter.AddPattern(new PatternDefinition(new string[] { "digitalRead", "digitalWrite", "pinMode", "analogRead", "analogReference", "analogWrite", "analogReadResolution", "analogWriteResolution", "noTone", "pulseIn", "pulseInLong", "shiftIn", "shiftOut", "tone", "delay", "delayMicroseconds", "micros", "millis", "abs", "constrain", "map", "max", "min", "pow", "sq", "sqrt", "cos", "sin", "tan", "isAlpha", "isAlphaNumeric", "isAscii", "isControl", "isDigit", "isGraph", "isHexadecimalDigit", "isLowerCase", "isPrintable", "isPunct", "isSpace", "isUpperCase", "isWhitespace", "random", "randomSeed", "bit", "bitClear", "bitRead", "bitSet", "bitWrite", "highByte", "lowByte", "attachInterrupt", "detachInterrupt", "interrupts", "noInterrupts", "Serial", "Stream" }), new SyntaxStyle(Color.Orange));

            highlighter.AddPattern(new PatternDefinition(new string[] { "#include", "#define" }), new SyntaxStyle(Color.DarkOliveGreen));
        }

        public void IntelliSense()
        {
            lbCompletion.Items.Clear();

            string text = " " + tbCode.Text;

            int pos = tbCode.SelectionStart;

            for (int i = pos; i > 0; i--)
            {
                if (text[i].ToString() == " ")
                {
                    i++;

                    int length = pos - i + 1;

                    foreach (string item in autoComplete)
                    {
                        try
                        {
                            if (text.Substring(i, length) == item.Substring(0, length))
                            {
                                lbCompletion.Items.Add(item);
                            }
                        }
                        catch (Exception)
                        {

                        }
                    }

                    break;
                }

            }

            if (lbCompletion.Items.Count > 0)
            {
                Point temp = tbCode.GetPositionFromCharIndex(pos);

                temp.X += tbCode.Location.X + 3;

                temp.Y += tbCode.Location.Y + 20;

                lbCompletion.Location = temp;

                lbCompletion.SetSelected(0, true);

                lbCompletion.Enabled = true;

                lbCompletion.Visible = true;

                lbCompletion.BringToFront();
            }
            else
            {
                lbCompletion.Enabled = false;

                lbCompletion.Visible = false;
            }
        }

        private void IntelliSenseWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            //IntelliSense();
        }

        private void tbCode_Key(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                tbCode.Text.Insert(tbCode.SelectionStart, "          ");
            }
        }

        private void tbCode_TextChanged(object sender, EventArgs e)
        {
            IntelliSense();   
        }

        private void TbCodeOnPreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (lbCompletion.Enabled)
            {
                if (e.KeyCode == Keys.Tab)
                {
                    isHandled = true;

                    Debug.WriteLine("YEYE");
                }
            }
        }

        private void tbCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (isHandled)
            {
                e.Handled = true;

                isHandled = false;
            }
        }
    }
}
