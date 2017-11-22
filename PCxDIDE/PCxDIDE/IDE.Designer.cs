namespace PCxDIDE
{
    partial class IDE
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IDE));
            this.scintilla = new ScintillaNET.Scintilla();
            this.tbErrors = new System.Windows.Forms.DataGridView();
            this.Ln = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Message = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mnOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnRun = new System.Windows.Forms.ToolStripMenuItem();
            this.mnBuild = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.tsRun = new System.Windows.Forms.ToolStripButton();
            this.tsPause = new System.Windows.Forms.ToolStripButton();
            this.tsOpen = new System.Windows.Forms.ToolStripButton();
            this.tsSave = new System.Windows.Forms.ToolStripButton();
            this.tsOptions = new System.Windows.Forms.ToolStripButton();
            this.tsExit = new System.Windows.Forms.ToolStripButton();
            this.tbLexer = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLexeme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colToken = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabOutputs = new System.Windows.Forms.TabControl();
            this.tabErrors = new System.Windows.Forms.TabPage();
            this.tabMessage = new System.Windows.Forms.TabPage();
            this.txtMessage = new System.Windows.Forms.RichTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsCaretPosition = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSemantic = new System.Windows.Forms.Label();
            this.txtSyntax = new System.Windows.Forms.Label();
            this.txtLexical = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Var = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Expression = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Equivalent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tbErrors)).BeginInit();
            this.menu.SuspendLayout();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbLexer)).BeginInit();
            this.tabOutputs.SuspendLayout();
            this.tabErrors.SuspendLayout();
            this.tabMessage.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // scintilla
            // 
            this.scintilla.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scintilla.EdgeColor = System.Drawing.Color.Gray;
            this.scintilla.EdgeColumn = 1;
            this.scintilla.EdgeMode = ScintillaNET.EdgeMode.MultiLine;
            this.scintilla.ImeMode = System.Windows.Forms.ImeMode.On;
            this.scintilla.Lexer = ScintillaNET.Lexer.Cpp;
            this.scintilla.Location = new System.Drawing.Point(12, 52);
            this.scintilla.Name = "scintilla";
            this.scintilla.PhasesDraw = ScintillaNET.Phases.One;
            this.scintilla.Size = new System.Drawing.Size(646, 410);
            this.scintilla.TabIndex = 0;
            this.scintilla.Technology = ScintillaNET.Technology.DirectWrite;
            this.scintilla.UseTabs = true;
            this.scintilla.InsertCheck += new System.EventHandler<ScintillaNET.InsertCheckEventArgs>(this.scintilla_InsertCheck);
            this.scintilla.UpdateUI += new System.EventHandler<ScintillaNET.UpdateUIEventArgs>(this.scintilla_UpdateUI);
            this.scintilla.TextChanged += new System.EventHandler(this.scintilla_TextChanged);
            // 
            // tbErrors
            // 
            this.tbErrors.AllowUserToDeleteRows = false;
            this.tbErrors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbErrors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ln,
            this.Col,
            this.Message});
            this.tbErrors.Location = new System.Drawing.Point(3, 4);
            this.tbErrors.Name = "tbErrors";
            this.tbErrors.ReadOnly = true;
            this.tbErrors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tbErrors.Size = new System.Drawing.Size(824, 92);
            this.tbErrors.TabIndex = 1;
            this.tbErrors.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbErrors_CellDoubleClick);
            // 
            // Ln
            // 
            this.Ln.HeaderText = "Ln";
            this.Ln.Name = "Ln";
            this.Ln.ReadOnly = true;
            this.Ln.Width = 50;
            // 
            // Col
            // 
            this.Col.HeaderText = "Col";
            this.Col.Name = "Col";
            this.Col.ReadOnly = true;
            this.Col.Width = 50;
            // 
            // Message
            // 
            this.Message.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Message.HeaderText = "Message";
            this.Message.Name = "Message";
            this.Message.ReadOnly = true;
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.SystemColors.Control;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.runToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1124, 24);
            this.menu.TabIndex = 2;
            this.menu.Text = "menu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnNew,
            this.mnOpen,
            this.mnSave,
            this.mnExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // mnNew
            // 
            this.mnNew.Name = "mnNew";
            this.mnNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mnNew.Size = new System.Drawing.Size(162, 22);
            this.mnNew.Text = "New File";
            // 
            // mnOpen
            // 
            this.mnOpen.Name = "mnOpen";
            this.mnOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mnOpen.Size = new System.Drawing.Size(162, 22);
            this.mnOpen.Text = "Open";
            this.mnOpen.Click += new System.EventHandler(this.mnOpen_Click);
            // 
            // mnSave
            // 
            this.mnSave.Name = "mnSave";
            this.mnSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mnSave.Size = new System.Drawing.Size(162, 22);
            this.mnSave.Text = "Save";
            this.mnSave.Click += new System.EventHandler(this.mnSaveAs_Click);
            // 
            // mnExit
            // 
            this.mnExit.Name = "mnExit";
            this.mnExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.mnExit.Size = new System.Drawing.Size(162, 22);
            this.mnExit.Text = "Exit";
            this.mnExit.Click += new System.EventHandler(this.mnExit_Click);
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnRun,
            this.mnBuild});
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            this.runToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.runToolStripMenuItem.Text = "Run";
            // 
            // mnRun
            // 
            this.mnRun.Name = "mnRun";
            this.mnRun.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.mnRun.Size = new System.Drawing.Size(142, 22);
            this.mnRun.Text = "Run";
            // 
            // mnBuild
            // 
            this.mnBuild.Name = "mnBuild";
            this.mnBuild.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.mnBuild.Size = new System.Drawing.Size(142, 22);
            this.mnBuild.Text = "Build";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // toolStrip
            // 
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsRun,
            this.tsPause,
            this.tsOpen,
            this.tsSave,
            this.tsOptions,
            this.tsExit});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip.Size = new System.Drawing.Size(1124, 25);
            this.toolStrip.TabIndex = 3;
            this.toolStrip.Text = "toolStrip1";
            // 
            // tsRun
            // 
            this.tsRun.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsRun.Image = global::PCxDIDE.Properties.Resources._006_play_button;
            this.tsRun.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsRun.Margin = new System.Windows.Forms.Padding(10, 1, 0, 2);
            this.tsRun.Name = "tsRun";
            this.tsRun.Size = new System.Drawing.Size(23, 22);
            this.tsRun.Text = "toolStripButton1";
            this.tsRun.ToolTipText = "Run";
            this.tsRun.Click += new System.EventHandler(this.tsRun_Click);
            // 
            // tsPause
            // 
            this.tsPause.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsPause.Image = global::PCxDIDE.Properties.Resources._005_pause_bars;
            this.tsPause.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsPause.Margin = new System.Windows.Forms.Padding(3, 1, 0, 2);
            this.tsPause.Name = "tsPause";
            this.tsPause.Size = new System.Drawing.Size(23, 22);
            this.tsPause.Text = "toolStripButton2";
            this.tsPause.ToolTipText = "Pause";
            // 
            // tsOpen
            // 
            this.tsOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsOpen.Image = global::PCxDIDE.Properties.Resources._003_open_folder;
            this.tsOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsOpen.Margin = new System.Windows.Forms.Padding(3, 1, 0, 2);
            this.tsOpen.Name = "tsOpen";
            this.tsOpen.Size = new System.Drawing.Size(23, 22);
            this.tsOpen.Text = "toolStripButton3";
            this.tsOpen.ToolTipText = "Open";
            this.tsOpen.Click += new System.EventHandler(this.tsOpen_Click);
            // 
            // tsSave
            // 
            this.tsSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsSave.Image = global::PCxDIDE.Properties.Resources._004_save_button;
            this.tsSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSave.Margin = new System.Windows.Forms.Padding(3, 1, 0, 2);
            this.tsSave.Name = "tsSave";
            this.tsSave.Size = new System.Drawing.Size(23, 22);
            this.tsSave.Text = "toolStripButton4";
            this.tsSave.ToolTipText = "Save";
            this.tsSave.Click += new System.EventHandler(this.tsSave_Click);
            // 
            // tsOptions
            // 
            this.tsOptions.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsOptions.Image = global::PCxDIDE.Properties.Resources._002_open_wrench_tool_silhouette;
            this.tsOptions.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsOptions.Margin = new System.Windows.Forms.Padding(3, 1, 0, 2);
            this.tsOptions.Name = "tsOptions";
            this.tsOptions.Size = new System.Drawing.Size(23, 22);
            this.tsOptions.Text = "toolStripButton5";
            this.tsOptions.ToolTipText = "Options";
            // 
            // tsExit
            // 
            this.tsExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsExit.Image = global::PCxDIDE.Properties.Resources._001_exit;
            this.tsExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsExit.Margin = new System.Windows.Forms.Padding(3, 1, 0, 2);
            this.tsExit.Name = "tsExit";
            this.tsExit.Size = new System.Drawing.Size(23, 22);
            this.tsExit.Text = "toolStripButton6";
            this.tsExit.ToolTipText = "Exit";
            this.tsExit.Click += new System.EventHandler(this.tsExit_Click);
            // 
            // tbLexer
            // 
            this.tbLexer.AllowUserToDeleteRows = false;
            this.tbLexer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbLexer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colLexeme,
            this.colToken});
            this.tbLexer.Location = new System.Drawing.Point(676, 52);
            this.tbLexer.Name = "tbLexer";
            this.tbLexer.ReadOnly = true;
            this.tbLexer.Size = new System.Drawing.Size(436, 206);
            this.tbLexer.TabIndex = 4;
            // 
            // colID
            // 
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Width = 35;
            // 
            // colLexeme
            // 
            this.colLexeme.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colLexeme.HeaderText = "Lexeme";
            this.colLexeme.Name = "colLexeme";
            this.colLexeme.ReadOnly = true;
            // 
            // colToken
            // 
            this.colToken.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colToken.HeaderText = "Token";
            this.colToken.Name = "colToken";
            this.colToken.ReadOnly = true;
            // 
            // tabOutputs
            // 
            this.tabOutputs.Controls.Add(this.tabErrors);
            this.tabOutputs.Controls.Add(this.tabMessage);
            this.tabOutputs.Location = new System.Drawing.Point(12, 468);
            this.tabOutputs.Name = "tabOutputs";
            this.tabOutputs.SelectedIndex = 0;
            this.tabOutputs.Size = new System.Drawing.Size(838, 125);
            this.tabOutputs.TabIndex = 5;
            // 
            // tabErrors
            // 
            this.tabErrors.Controls.Add(this.tbErrors);
            this.tabErrors.Location = new System.Drawing.Point(4, 22);
            this.tabErrors.Name = "tabErrors";
            this.tabErrors.Padding = new System.Windows.Forms.Padding(3);
            this.tabErrors.Size = new System.Drawing.Size(830, 99);
            this.tabErrors.TabIndex = 0;
            this.tabErrors.Text = "Errors";
            this.tabErrors.UseVisualStyleBackColor = true;
            // 
            // tabMessage
            // 
            this.tabMessage.Controls.Add(this.txtMessage);
            this.tabMessage.Location = new System.Drawing.Point(4, 22);
            this.tabMessage.Name = "tabMessage";
            this.tabMessage.Padding = new System.Windows.Forms.Padding(3);
            this.tabMessage.Size = new System.Drawing.Size(830, 99);
            this.tabMessage.TabIndex = 1;
            this.tabMessage.Text = "Message";
            this.tabMessage.UseVisualStyleBackColor = true;
            // 
            // txtMessage
            // 
            this.txtMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMessage.Location = new System.Drawing.Point(3, 6);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(821, 87);
            this.txtMessage.TabIndex = 0;
            this.txtMessage.Text = "";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tsCaretPosition});
            this.statusStrip1.Location = new System.Drawing.Point(0, 592);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1124, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Margin = new System.Windows.Forms.Padding(10, 3, 0, 2);
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(72, 17);
            this.toolStripStatusLabel1.Text = "Version 2.0.0";
            // 
            // tsCaretPosition
            // 
            this.tsCaretPosition.Margin = new System.Windows.Forms.Padding(10, 3, 0, 2);
            this.tsCaretPosition.Name = "tsCaretPosition";
            this.tsCaretPosition.Size = new System.Drawing.Size(67, 17);
            this.tsCaretPosition.Text = "Ch: 0 Sel: 0 ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtSemantic);
            this.panel1.Controls.Add(this.txtSyntax);
            this.panel1.Controls.Add(this.txtLexical);
            this.panel1.Location = new System.Drawing.Point(856, 490);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 99);
            this.panel1.TabIndex = 7;
            // 
            // txtSemantic
            // 
            this.txtSemantic.AutoSize = true;
            this.txtSemantic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSemantic.ForeColor = System.Drawing.Color.Black;
            this.txtSemantic.Location = new System.Drawing.Point(15, 65);
            this.txtSemantic.Name = "txtSemantic";
            this.txtSemantic.Size = new System.Drawing.Size(138, 20);
            this.txtSemantic.TabIndex = 0;
            this.txtSemantic.Text = "Semantic Analysis";
            // 
            // txtSyntax
            // 
            this.txtSyntax.AutoSize = true;
            this.txtSyntax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSyntax.ForeColor = System.Drawing.Color.Black;
            this.txtSyntax.Location = new System.Drawing.Point(15, 41);
            this.txtSyntax.Name = "txtSyntax";
            this.txtSyntax.Size = new System.Drawing.Size(119, 20);
            this.txtSyntax.TabIndex = 0;
            this.txtSyntax.Text = "Syntax Analysis";
            // 
            // txtLexical
            // 
            this.txtLexical.AutoSize = true;
            this.txtLexical.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLexical.ForeColor = System.Drawing.Color.Black;
            this.txtLexical.Location = new System.Drawing.Point(15, 17);
            this.txtLexical.Name = "txtLexical";
            this.txtLexical.Size = new System.Drawing.Size(119, 20);
            this.txtLexical.TabIndex = 0;
            this.txtLexical.Text = "Lexical Analysis";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Var,
            this.Expression,
            this.Equivalent});
            this.dataGridView1.Location = new System.Drawing.Point(676, 275);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(436, 187);
            this.dataGridView1.TabIndex = 8;
            // 
            // Var
            // 
            this.Var.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Var.HeaderText = "Var";
            this.Var.Name = "Var";
            this.Var.ReadOnly = true;
            // 
            // Expression
            // 
            this.Expression.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Expression.HeaderText = "Expression";
            this.Expression.Name = "Expression";
            this.Expression.ReadOnly = true;
            // 
            // Equivalent
            // 
            this.Equivalent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Equivalent.HeaderText = "Equivalent";
            this.Equivalent.Name = "Equivalent";
            this.Equivalent.ReadOnly = true;
            // 
            // IDE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1124, 614);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabOutputs);
            this.Controls.Add(this.tbLexer);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.scintilla);
            this.Controls.Add(this.menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.MaximizeBox = false;
            this.Name = "IDE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PCxD Compiler";
            this.Load += new System.EventHandler(this.form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbErrors)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbLexer)).EndInit();
            this.tabOutputs.ResumeLayout(false);
            this.tabErrors.ResumeLayout(false);
            this.tabMessage.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ScintillaNET.Scintilla scintilla;
        private System.Windows.Forms.DataGridView tbErrors;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ln;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Message;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton tsRun;
        private System.Windows.Forms.ToolStripButton tsPause;
        private System.Windows.Forms.ToolStripButton tsOpen;
        private System.Windows.Forms.ToolStripButton tsSave;
        private System.Windows.Forms.ToolStripButton tsOptions;
        private System.Windows.Forms.ToolStripButton tsExit;
        private System.Windows.Forms.DataGridView tbLexer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLexeme;
        private System.Windows.Forms.DataGridViewTextBoxColumn colToken;
        private System.Windows.Forms.ToolStripMenuItem mnNew;
        private System.Windows.Forms.ToolStripMenuItem mnOpen;
        private System.Windows.Forms.ToolStripMenuItem mnSave;
        private System.Windows.Forms.ToolStripMenuItem mnExit;
        private System.Windows.Forms.ToolStripMenuItem mnRun;
        private System.Windows.Forms.ToolStripMenuItem mnBuild;
        private System.Windows.Forms.TabControl tabOutputs;
        private System.Windows.Forms.TabPage tabErrors;
        private System.Windows.Forms.TabPage tabMessage;
        private System.Windows.Forms.RichTextBox txtMessage;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsCaretPosition;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txtSemantic;
        private System.Windows.Forms.Label txtSyntax;
        private System.Windows.Forms.Label txtLexical;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Var;
        private System.Windows.Forms.DataGridViewTextBoxColumn Expression;
        private System.Windows.Forms.DataGridViewTextBoxColumn Equivalent;
    }
}

