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
        bool isHandled = false;

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
            IntelliSense();
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
                Point point = tbCode.GetPositionFromCharIndex(pos);

                point.X += 12;

                point.Y += 48;

                lbCompletion.Location = point;

                lbCompletion.Enabled = true;

                lbCompletion.Visible = true;

                lbCompletion.BringToFront();

                lbCompletion.Update();
            }
            else
            {
                //lbCompletion.Visible = false;

                //lbCompletion.Enabled = false;
            }
        }
    }
}
