using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotNetRegExConsole
{
    public partial class MainForm : Ults.Windows.Forms.MainFormBase
    {
        public MainForm()
        {
            InitializeComponent();

            var optionItems = Enum.GetValues(typeof(System.Text.RegularExpressions.RegexOptions))
                .Cast<System.Text.RegularExpressions.RegexOptions>()
                .Where(f => f!= System.Text.RegularExpressions.RegexOptions.None)
                .Select(f => new ListBoxItem<System.Text.RegularExpressions.RegexOptions>(f))
                .ToArray();
            checkedListBoxOptions.Items.AddRange(optionItems);

            textBoxExInput.Text = Properties.Settings.Default.InputText;
            textBoxExPattern.Text = Properties.Settings.Default.PatternText;
            textBoxExReplacement.Text = Properties.Settings.Default.ReplacementText;

            if (!Properties.Settings.Default.FormSize.IsEmpty)
            {
                this.Size = Properties.Settings.Default.FormSize;
                splittContainerEx1.SplitterDistance = Properties.Settings.Default.SplitterDistance;
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            Properties.Settings.Default.InputText = textBoxExInput.Text;
            Properties.Settings.Default.PatternText = textBoxExPattern.Text;
            Properties.Settings.Default.ReplacementText = textBoxExReplacement.Text;
            Properties.Settings.Default.RegExOptions = 0;
            Properties.Settings.Default.SplitterDistance = splittContainerEx1.SplitterDistance;
            Properties.Settings.Default.Save();
        }

        protected override void OnResizeEnd(EventArgs e)
        {
            base.OnResizeEnd(e);

            Properties.Settings.Default.FormSize = this.Size;
            Properties.Settings.Default.Save();
        }

        private void buttonDoMatches_Click(object sender, EventArgs e)
        {
            try
            {
                var mts = System.Text.RegularExpressions.Regex.Matches(textBoxExInput.Text, textBoxExPattern.Text, GetSelectedRegExOptions());
                if(mts.Count == 0)
                {
                    textBoxExOutput.Text = "No matches.";
                    return;
                }

                var matchIndex = 0;
                textBoxExOutput.Text = string.Concat(mts.Cast<System.Text.RegularExpressions.Match>().Select(f => string.Format("[Match:{0}] {1}\r\n\r\n", matchIndex++, f.Value)));
            }
            catch(System.Exception ex)
            {
                textBoxExOutput.Text = string.Format("[{0}]\r\n{1}", ex.GetType().Name, ex.Message);
            }
        }

        private void buttonDoReplace_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxExOutput.Text = System.Text.RegularExpressions.Regex.Replace(textBoxExInput.Text, textBoxExPattern.Text, textBoxExReplacement.Text, GetSelectedRegExOptions());
            }
            catch (System.Exception ex)
            {
                textBoxExOutput.Text = string.Format("[{0}]\r\n{1}", ex.GetType().Name, ex.Message);
            }

        }

        private void buttonOpenRead_Click(object sender, EventArgs e)
        {
            using(var dlg = new System.Windows.Forms.OpenFileDialog())
            {
                dlg.InitialDirectory = Properties.Settings.Default.FileReadInitialDirectory;
                if (dlg.ShowDialog() != DialogResult.OK)
                    return;

                textBoxExInput.Text = System.IO.File.ReadAllText(dlg.FileName);
                // Encoding...
                Properties.Settings.Default.FileReadInitialDirectory = System.IO.Path.GetDirectoryName(dlg.FileName);
                Properties.Settings.Default.Save();
            }
        }

        private System.Text.RegularExpressions.RegexOptions GetSelectedRegExOptions()
        {
            return checkedListBoxOptions.SelectedItems
                .Cast<ListBoxItem<System.Text.RegularExpressions.RegexOptions>>()
                .Select(f => f.Value)
                .Aggregate(System.Text.RegularExpressions.RegexOptions.None, (v, a) => v | a);
        }

        private class ListBoxItem<T>
        {
            public T Value { get; private set; }

            public ListBoxItem(T value)
            {
                this.Value = value;
            }

            public override string ToString()
            {
                return this.Value.ToString();
            }
        }
    }
}
