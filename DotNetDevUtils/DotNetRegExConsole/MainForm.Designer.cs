namespace DotNetRegExConsole
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.splittContainerEx1 = new Ults.Windows.Forms.SplitContainerEx();
            this.buttonOpenRead = new System.Windows.Forms.Button();
            this.checkedListBoxOptions = new System.Windows.Forms.CheckedListBox();
            this.buttonDoMatches = new System.Windows.Forms.Button();
            this.textBoxExPattern = new Ults.Windows.Forms.TextBoxEx();
            this.buttonDoReplace = new System.Windows.Forms.Button();
            this.textBoxExReplacement = new Ults.Windows.Forms.TextBoxEx();
            this.textBoxExInput = new Ults.Windows.Forms.TextBoxEx();
            this.radioButtonCaptures = new System.Windows.Forms.RadioButton();
            this.radioButtonGroups = new System.Windows.Forms.RadioButton();
            this.radioButtonMatches = new System.Windows.Forms.RadioButton();
            this.textBoxExOutput = new Ults.Windows.Forms.TextBoxEx();
            ((System.ComponentModel.ISupportInitialize)(this.splittContainerEx1)).BeginInit();
            this.splittContainerEx1.Panel1.SuspendLayout();
            this.splittContainerEx1.Panel2.SuspendLayout();
            this.splittContainerEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splittContainerEx1
            // 
            this.splittContainerEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splittContainerEx1.Location = new System.Drawing.Point(0, 0);
            this.splittContainerEx1.Name = "splittContainerEx1";
            // 
            // splittContainerEx1.Panel1
            // 
            this.splittContainerEx1.Panel1.Controls.Add(this.buttonOpenRead);
            this.splittContainerEx1.Panel1.Controls.Add(this.checkedListBoxOptions);
            this.splittContainerEx1.Panel1.Controls.Add(this.buttonDoMatches);
            this.splittContainerEx1.Panel1.Controls.Add(this.textBoxExPattern);
            this.splittContainerEx1.Panel1.Controls.Add(this.buttonDoReplace);
            this.splittContainerEx1.Panel1.Controls.Add(this.textBoxExReplacement);
            this.splittContainerEx1.Panel1.Controls.Add(this.textBoxExInput);
            this.splittContainerEx1.Panel1MinSize = 300;
            // 
            // splittContainerEx1.Panel2
            // 
            this.splittContainerEx1.Panel2.Controls.Add(this.radioButtonCaptures);
            this.splittContainerEx1.Panel2.Controls.Add(this.radioButtonGroups);
            this.splittContainerEx1.Panel2.Controls.Add(this.radioButtonMatches);
            this.splittContainerEx1.Panel2.Controls.Add(this.textBoxExOutput);
            this.splittContainerEx1.Panel2MinSize = 300;
            this.splittContainerEx1.Size = new System.Drawing.Size(1036, 660);
            this.splittContainerEx1.SplitterDistance = 457;
            this.splittContainerEx1.TabIndex = 0;
            // 
            // buttonOpenRead
            // 
            this.buttonOpenRead.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpenRead.Location = new System.Drawing.Point(360, 201);
            this.buttonOpenRead.Name = "buttonOpenRead";
            this.buttonOpenRead.Size = new System.Drawing.Size(94, 29);
            this.buttonOpenRead.TabIndex = 7;
            this.buttonOpenRead.Text = "Read";
            this.buttonOpenRead.UseVisualStyleBackColor = true;
            this.buttonOpenRead.Click += new System.EventHandler(this.buttonOpenRead_Click);
            // 
            // checkedListBoxOptions
            // 
            this.checkedListBoxOptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListBoxOptions.CheckOnClick = true;
            this.checkedListBoxOptions.Font = new System.Drawing.Font("ＭＳ ゴシック", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.checkedListBoxOptions.FormattingEnabled = true;
            this.checkedListBoxOptions.Location = new System.Drawing.Point(3, 3);
            this.checkedListBoxOptions.MultiColumn = true;
            this.checkedListBoxOptions.Name = "checkedListBoxOptions";
            this.checkedListBoxOptions.Size = new System.Drawing.Size(451, 112);
            this.checkedListBoxOptions.TabIndex = 1;
            // 
            // buttonDoMatches
            // 
            this.buttonDoMatches.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDoMatches.Location = new System.Drawing.Point(360, 133);
            this.buttonDoMatches.Name = "buttonDoMatches";
            this.buttonDoMatches.Size = new System.Drawing.Size(94, 29);
            this.buttonDoMatches.TabIndex = 3;
            this.buttonDoMatches.Text = "Matches";
            this.buttonDoMatches.UseVisualStyleBackColor = true;
            this.buttonDoMatches.Click += new System.EventHandler(this.buttonDoMatches_Click);
            // 
            // textBoxExPattern
            // 
            this.textBoxExPattern.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxExPattern.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxExPattern.Location = new System.Drawing.Point(3, 137);
            this.textBoxExPattern.Name = "textBoxExPattern";
            this.textBoxExPattern.Size = new System.Drawing.Size(351, 25);
            this.textBoxExPattern.TabIndex = 2;
            // 
            // buttonDoReplace
            // 
            this.buttonDoReplace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDoReplace.Location = new System.Drawing.Point(360, 166);
            this.buttonDoReplace.Name = "buttonDoReplace";
            this.buttonDoReplace.Size = new System.Drawing.Size(94, 29);
            this.buttonDoReplace.TabIndex = 5;
            this.buttonDoReplace.Text = "Replace";
            this.buttonDoReplace.UseVisualStyleBackColor = true;
            this.buttonDoReplace.Click += new System.EventHandler(this.buttonDoReplace_Click);
            // 
            // textBoxExReplacement
            // 
            this.textBoxExReplacement.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxExReplacement.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxExReplacement.Location = new System.Drawing.Point(3, 168);
            this.textBoxExReplacement.Name = "textBoxExReplacement";
            this.textBoxExReplacement.Size = new System.Drawing.Size(351, 25);
            this.textBoxExReplacement.TabIndex = 4;
            // 
            // textBoxExInput
            // 
            this.textBoxExInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxExInput.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxExInput.Location = new System.Drawing.Point(3, 230);
            this.textBoxExInput.MaxLength = 0;
            this.textBoxExInput.Multiline = true;
            this.textBoxExInput.Name = "textBoxExInput";
            this.textBoxExInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxExInput.Size = new System.Drawing.Size(451, 427);
            this.textBoxExInput.TabIndex = 6;
            // 
            // radioButtonCaptures
            // 
            this.radioButtonCaptures.AutoSize = true;
            this.radioButtonCaptures.Checked = true;
            this.radioButtonCaptures.Location = new System.Drawing.Point(244, 12);
            this.radioButtonCaptures.Name = "radioButtonCaptures";
            this.radioButtonCaptures.Size = new System.Drawing.Size(101, 22);
            this.radioButtonCaptures.TabIndex = 9;
            this.radioButtonCaptures.TabStop = true;
            this.radioButtonCaptures.Text = "Captures";
            this.radioButtonCaptures.UseVisualStyleBackColor = true;
            // 
            // radioButtonGroups
            // 
            this.radioButtonGroups.AutoSize = true;
            this.radioButtonGroups.Location = new System.Drawing.Point(139, 12);
            this.radioButtonGroups.Name = "radioButtonGroups";
            this.radioButtonGroups.Size = new System.Drawing.Size(86, 22);
            this.radioButtonGroups.TabIndex = 8;
            this.radioButtonGroups.TabStop = true;
            this.radioButtonGroups.Text = "Groups";
            this.radioButtonGroups.UseVisualStyleBackColor = true;
            // 
            // radioButtonMatches
            // 
            this.radioButtonMatches.AutoSize = true;
            this.radioButtonMatches.Location = new System.Drawing.Point(16, 12);
            this.radioButtonMatches.Name = "radioButtonMatches";
            this.radioButtonMatches.Size = new System.Drawing.Size(96, 22);
            this.radioButtonMatches.TabIndex = 7;
            this.radioButtonMatches.TabStop = true;
            this.radioButtonMatches.Text = "Matches";
            this.radioButtonMatches.UseVisualStyleBackColor = true;
            // 
            // textBoxExOutput
            // 
            this.textBoxExOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxExOutput.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxExOutput.Location = new System.Drawing.Point(3, 40);
            this.textBoxExOutput.MaxLength = 0;
            this.textBoxExOutput.Multiline = true;
            this.textBoxExOutput.Name = "textBoxExOutput";
            this.textBoxExOutput.ReadOnly = true;
            this.textBoxExOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxExOutput.Size = new System.Drawing.Size(569, 617);
            this.textBoxExOutput.TabIndex = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 660);
            this.Controls.Add(this.splittContainerEx1);
            this.MinimumSize = new System.Drawing.Size(750, 400);
            this.Name = "MainForm";
            this.Text = "DotNet RegularExpressions test console";
            this.splittContainerEx1.Panel1.ResumeLayout(false);
            this.splittContainerEx1.Panel1.PerformLayout();
            this.splittContainerEx1.Panel2.ResumeLayout(false);
            this.splittContainerEx1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splittContainerEx1)).EndInit();
            this.splittContainerEx1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Ults.Windows.Forms.SplitContainerEx splittContainerEx1;
        private Ults.Windows.Forms.TextBoxEx textBoxExInput;
        private Ults.Windows.Forms.TextBoxEx textBoxExOutput;
        private Ults.Windows.Forms.TextBoxEx textBoxExReplacement;
        private System.Windows.Forms.Button buttonDoReplace;
        private System.Windows.Forms.Button buttonDoMatches;
        private Ults.Windows.Forms.TextBoxEx textBoxExPattern;
        private System.Windows.Forms.CheckedListBox checkedListBoxOptions;
        private System.Windows.Forms.RadioButton radioButtonCaptures;
        private System.Windows.Forms.RadioButton radioButtonGroups;
        private System.Windows.Forms.RadioButton radioButtonMatches;
        private System.Windows.Forms.Button buttonOpenRead;
    }
}

