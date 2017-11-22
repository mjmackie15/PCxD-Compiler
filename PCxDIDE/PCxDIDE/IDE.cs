using ScintillaNET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using Lexicanalysis;
using ProductionClass;
using LexemeClass;
using SemanticAnalyzer;


namespace PCxDIDE
{
    public partial class IDE : Form
    {
        Lexicanalysis.Lexer lex = new Lexicanalysis.Lexer();

        public IDE()
        {
            InitializeComponent();
            scintilla_Properties();
        }

        private void restart_State()
        {
            txtLexical.ForeColor = Color.Black;
            txtSyntax.ForeColor = Color.Black;
            txtSemantic.ForeColor = Color.Black;
            txtMessage.Clear();
            tbErrors.Rows.Clear();
            tbLexer.Rows.Clear();
        }

        private void tsRun_Click(object sender, EventArgs e)
        {
            restart_State();
            Tuple<List<Lexeme>, List<Tuple<string, int, int>>, bool> lexResult;
            lexResult = lex.lexAnalyzer(scintilla.Text);
            string text = scintilla.Text;
            txtMessage.Text += "Running Compiler...\n";
            txtMessage.Text += "Lexical Analysis started...\n";
            lexResult.Item1.ForEach(delegate (Lexeme tk)
            {
                tbLexer.Rows.Add(tk.getType() + tk.getId(), tk.getLexeme(), tk.getToken());
            });
            if (!lexResult.Item3)
            {
                Production syn = new Production();
                txtMessage.Text += "Lexical Analysis successful...\n";
                tabOutputs.SelectedTab = tabMessage;
                txtLexical.ForeColor = Color.Green;
                txtMessage.Text += "Syntax Analysis started...\n";
                Tuple<bool, int, int, string> synResult;
                synResult = syn.startProduction(lexResult.Item1);
                if (synResult.Item1)
                {
                    Semantic sem = new Semantic();
                    txtMessage.Text += "Syntax Analysis successful...\n";
                    tabOutputs.SelectedTab = tabMessage;
                    txtSyntax.ForeColor = Color.Green;
                    txtMessage.Text += "Semantic Analysis started...\n";
                    Tuple<bool, int, int, string> semResult;
                    semResult = sem.startSemantic(lexResult.Item1);
                    if (semResult.Item1)
                    {
                        txtMessage.Text += "Semantic Analysis successful...\n";
                        tabOutputs.SelectedTab = tabMessage;
                        txtSemantic.ForeColor = Color.Green;
                    }
                    else
                    {
                        txtMessage.Text += "Compilation stopped due to Semantic errors...\n";
                        tabOutputs.SelectedTab = tabErrors;
                        txtSemantic.ForeColor = Color.Red;
                        tbErrors.Rows.Add(semResult.Item2, semResult.Item3, semResult.Item4);
                        DataGridViewRow row = tbErrors.Rows[0];
                        scintilla.Lines[Int32.Parse(row.Cells["Ln"].Value.ToString()) - 1].Goto();
                        scintilla.Focus();
                    }
                }
                else
                {
                    txtMessage.Text += "Compilation stopped due to Syntax errors...\n";
                    tabOutputs.SelectedTab = tabErrors;
                    txtSyntax.ForeColor = Color.Red;
                    tbErrors.Rows.Add(synResult.Item2, synResult.Item3, synResult.Item4);
                    DataGridViewRow row = tbErrors.Rows[0];
                    scintilla.Lines[Int32.Parse(row.Cells["Ln"].Value.ToString()) - 1].Goto();
                    scintilla.Focus();
                }
            }
            else
            {
                txtMessage.Text += "Compilation stopped due to Lexical errors...\n";
                tabOutputs.SelectedTab = tabErrors;
                txtLexical.ForeColor = Color.Red;
                lexResult.Item2.ForEach(delegate (Tuple<string, int, int> result)
                {
                    tbErrors.Rows.Add(result.Item2, result.Item3, result.Item1);
                });
                DataGridViewRow row = tbErrors.Rows[0];
                scintilla.Lines[Int32.Parse(row.Cells["Ln"].Value.ToString()) - 1].Goto();
                scintilla.Focus();
            }
        }

        //Scintilla IDE Formatting

        public void scintilla_Properties()
        {
            // Configuring the default style with properties
            // we have common to every lexer style saves time.
            scintilla.StyleResetDefault();
            scintilla.Styles[Style.Default].Font = "Consolas";
            scintilla.Styles[Style.Default].Size = 10;
            scintilla.StyleClearAll();
            scintilla.SetProperty("fold", "1");
            scintilla.SetProperty("fold.compact", "1");

            // Configure a margin to display folding symbols
            scintilla.Margins[2].Type = MarginType.Symbol;
            scintilla.Margins[2].Mask = Marker.MaskFolders;
            scintilla.Margins[2].Sensitive = true;
            scintilla.Margins[2].Width = 20;

            // Set colors for all folding markers
            for (int i = 25; i <= 31; i++)
            {
                scintilla.Markers[i].SetForeColor(SystemColors.ControlLightLight);
                scintilla.Markers[i].SetBackColor(SystemColors.ControlDark);
            }

            // Configure folding markers with respective symbols
            scintilla.Markers[Marker.Folder].Symbol = MarkerSymbol.BoxPlus;
            scintilla.Markers[Marker.FolderOpen].Symbol = MarkerSymbol.BoxMinus;
            scintilla.Markers[Marker.FolderEnd].Symbol = MarkerSymbol.BoxPlusConnected;
            scintilla.Markers[Marker.FolderMidTail].Symbol = MarkerSymbol.TCorner;
            scintilla.Markers[Marker.FolderOpenMid].Symbol = MarkerSymbol.BoxMinusConnected;
            scintilla.Markers[Marker.FolderSub].Symbol = MarkerSymbol.VLine;
            scintilla.Markers[Marker.FolderTail].Symbol = MarkerSymbol.LCorner;

            // Enable automatic folding
            scintilla.AutomaticFold = (AutomaticFold.Show | AutomaticFold.Click | AutomaticFold.Change);

            scintilla.Margins[0].Width = 16;
        }

        private int maxLineNumberCharLength;

        private void scintilla_TextChanged(object sender, EventArgs e)
        {
            // Did the number of characters in the line number display change?
            // i.e. nnn VS nn, or nnnn VS nn, etc...
            var maxLineNumberCharLength = scintilla.Lines.Count.ToString().Length;
            if (maxLineNumberCharLength == this.maxLineNumberCharLength)
                return;

            // Calculate the width required to display the last line number
            // and include some padding for good measure.
            const int padding = 2;
            scintilla.Margins[0].Width = scintilla.TextWidth(Style.LineNumber, new string('9', maxLineNumberCharLength + 1)) + padding;
            this.maxLineNumberCharLength = maxLineNumberCharLength;
        }

        int lastCaretPos = 0;

        private void form_Load(object sender, EventArgs e)
        {
            scintilla.IndentationGuides = IndentView.LookBoth;
            scintilla.Styles[Style.BraceLight].BackColor = Color.LightGray;
            scintilla.Styles[Style.BraceLight].ForeColor = Color.BlueViolet;
            scintilla.Styles[Style.BraceBad].ForeColor = Color.Red;
        }

        private static bool IsBrace(int c)
        {
            switch (c)
            {
                case '(':
                case ')':
                case '[':
                case ']':
                case '{':
                case '}':
                case '<':
                case '>':
                    return true;
            }

            return false;
        }

        private void scintilla_UpdateUI(object sender, UpdateUIEventArgs e)
        {
            // Has the caret changed position?
            var caretPos = scintilla.CurrentPosition;
            if (lastCaretPos != caretPos)
            {
                lastCaretPos = caretPos;
                var bracePos1 = -1;
                var bracePos2 = -1;

                // Is there a brace to the left or right?
                if (caretPos > 0 && IsBrace(scintilla.GetCharAt(caretPos - 1)))
                    bracePos1 = (caretPos - 1);
                else if (IsBrace(scintilla.GetCharAt(caretPos)))
                    bracePos1 = caretPos;

                if (bracePos1 >= 0)
                {
                    // Find the matching brace
                    bracePos2 = scintilla.BraceMatch(bracePos1);
                    if (bracePos2 == Scintilla.InvalidPosition)
                    {
                        scintilla.BraceBadLight(bracePos1);
                        scintilla.HighlightGuide = 0;
                    }
                    else
                    {
                        scintilla.BraceHighlight(bracePos1, bracePos2);
                        scintilla.HighlightGuide = scintilla.GetColumn(bracePos1);
                    }
                }
                else
                {
                    // Turn off brace matching
                    scintilla.BraceHighlight(Scintilla.InvalidPosition, Scintilla.InvalidPosition);
                    scintilla.HighlightGuide = 0;
                }

                if ((e.Change & UpdateChange.Selection) > 0)
                {
                    // The caret/selection changed
                    var currentPos = scintilla.CurrentPosition;
                    var anchorPos = scintilla.AnchorPosition;
                    tsCaretPosition.Text = "Ch: " + currentPos + " Sel: " + Math.Abs(anchorPos - currentPos);
                }
            }
        }

        private void scintilla_InsertCheck(object sender, InsertCheckEventArgs e)
        {
            if ((e.Text.EndsWith("\r") || e.Text.EndsWith("\n")))
            {
                var curLine = scintilla.LineFromPosition(e.Position);
                var curLineText = scintilla.Lines[curLine].Text;

                var indent = Regex.Match(curLineText, @"^\s*");
                e.Text += indent.Value; // Add indent following "\r\n"

                // Current line end with bracket?
                if (Regex.IsMatch(curLineText, @"{\s*$"))
                    e.Text += '\t'; // Add tab
            }
        }

        public void fileOpen()
        {
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Open PCxD File";
            theDialog.Filter = "PCxD files|*.pcxd";
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                string s = File.ReadAllText(theDialog.FileName);
                scintilla.Text = s;
            }
        }

        public void fileSave()
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Title = "Save PCxD File";
            save.FileName = "Untitled.pcxd";
            save.Filter = "PCxD File | *.pcxd";
            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(save.OpenFile());
                writer.WriteLine(scintilla.Text);
                writer.Dispose();
                writer.Close();
            }
        }

        public void programExit()
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit?", "Exit PCxD Compiler", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (System.Windows.Forms.Application.MessageLoop)
                {
                    // WinForms app
                    System.Windows.Forms.Application.Exit();
                }
                else
                {
                    // Console app
                    System.Environment.Exit(1);
                }
            }
        }

        private void tsSave_Click(object sender, EventArgs e)
        {
            fileSave();
        }

        private void mnSaveAs_Click(object sender, EventArgs e)
        {
            fileSave();
        }

        private void tsOpen_Click(object sender, EventArgs e)
        {
            fileOpen();
        }

        private void mnOpen_Click(object sender, EventArgs e)
        {
            fileOpen();
        }

        private void mnExit_Click(object sender, EventArgs e)
        {
            programExit();
        }

        private void tsExit_Click(object sender, EventArgs e)
        {
            programExit();
        }

        private void tbErrors_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = tbErrors.Rows[e.RowIndex];
            scintilla.Lines[Int32.Parse(row.Cells["Ln"].Value.ToString()) - 1].Goto();
            scintilla.Focus();
        }

    }
}
