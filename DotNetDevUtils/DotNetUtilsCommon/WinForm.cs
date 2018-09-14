using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ults
{
    namespace Windows.Forms
    {
        public class MainFormBase : System.Windows.Forms.Form
        {
            private static readonly string _myEntryAssemblyVersionText = null;

            static MainFormBase()
            {
                var entryAsm = System.Reflection.Assembly.GetEntryAssembly();
                if(entryAsm != null)
                {
                    var location = entryAsm.Location;
                    if(location != null)
                    {
                        _myEntryAssemblyVersionText = System.Diagnostics.FileVersionInfo.GetVersionInfo(location).FileVersion.ToString();
                    }
                }
            }

            private string _text;

            public new System.Windows.Forms.FormStartPosition StartPosition { get; } = System.Windows.Forms.FormStartPosition.CenterScreen;
            public new string Text {
                get { return _text; }
                set { _text = value; base.Text = _text + ((_myEntryAssemblyVersionText == null) ? string.Empty : (" version " + _myEntryAssemblyVersionText)); }
            }

            public MainFormBase() : base()
            {
                base.StartPosition = this.StartPosition;
            }
        }

        public class SplitContainerEx : System.Windows.Forms.SplitContainer
        {
            protected override void OnPaint(PaintEventArgs e)
            {
                base.OnPaint(e);

                var rect = this.SplitterRectangle;
                rect.Inflate(1, -2);
                e.Graphics.FillRectangle(System.Drawing.SystemBrushes.GrayText, rect);
            }
        }

        public class TextBoxEx : System.Windows.Forms.TextBox
        {
            protected override void OnKeyDown(KeyEventArgs e)
            {
                base.OnKeyDown(e);
                if(e.Control && e.KeyCode.Equals(Keys.A))
                {
                    this.SelectAll();
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                    return;
                }
            }

            protected override void OnGotFocus(EventArgs e)
            {
                base.OnGotFocus(e);
                this.SelectAll();
            }

            protected override void OnPaint(PaintEventArgs e)
            {
                base.OnPaint(e);
            }


        }
    }
}
