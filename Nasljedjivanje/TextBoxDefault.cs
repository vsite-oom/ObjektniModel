using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nasljeđivanje
{
    class TextBoxDefault: TextBox
    {
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            SetStyle(ControlStyles.UserPaint, TextLenght == 0);
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (TextLenght == 0)
                DrawDefaultText(e.Graphics);

        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            SetStyle(ControlStyles.UserPaint, TextLenght == 0);
            Invalidate();
            
        }
        private void DrawDefaultText(Graphics g)
        {
            TextRenderer.DrawText(g, defaultText, Font, ClientRectangle, SystemColors.GrayText);
        }

        private string defaultText = "Default";

        public int TextLenght { get; private set; }
    }

}
