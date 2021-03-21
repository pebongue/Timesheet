using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Aculocity.ProjectName.PL
{
    class AlignUI
    {
        public class Align
        {
            public static void Lefts(Control Control1, Control Control2)
            {
                Control2.Left = Control1.Left;
            }

            public static void Centers(Control Control1, Control Control2)
            {
                int center = Control1.Left + (Control1.Width / 2);
                Control2.Left = center - (Control2.Width / 2);
            }

            public static void Rights(Control Control1, Control Control2)
            {
                int right = Control1.Left + Control1.Width;
                Control2.Left = right - Control2.Width;
            }

            public static void Tops(Control Control1, Control Control2)
            {
                Control2.Top = Control1.Top;
            }

            public static void Middles(Control Control1, Control Control2)
            {
                int middle = Control1.Top + (Control1.Height / 2);
                Control2.Top = middle - (Control2.Height / 2);
            }

            public static void Bottoms(Control Control1, Control Control2)
            {
                int bottom = Control1.Top + Control1.Height;
                Control2.Top = bottom - Control2.Height;
            }
        }

        public class MakeSameSize
        {
            public static void Width(Control Control1, Control Control2)
            {
                Control2.Width = Control1.Width;
            }

            public static void Height(Control Control1, Control Control2)
            {
                Control2.Height = Control1.Height;
            }

            public static void Both(Control Control1, Control Control2)
            {
                Control2.Width = Control1.Width;
                Control2.Height = Control1.Height;
            }
        }

        public class CenterInForm
        {
            public static void Horizontally(Form ParentForm, Control ChildControl)
            {
                Rectangle surfaceRect = ParentForm.ClientRectangle;

                ChildControl.Left = (surfaceRect.Width / 2) - (ChildControl.Width / 2);
            }

            public static void Vertically(Form ParentForm, Control ChildControl)
            {
                Rectangle surfaceRect = ParentForm.ClientRectangle;

                ChildControl.Top = (surfaceRect.Height / 2) - (ChildControl.Height / 2);
            }
        }
        /// <summary>
        /// TODO: check on this method
        /// </summary>
        public class SizeWithParent
        {
            public static void LeftMargin(Control ParentForm, Control ChildForm)
            {
                Rectangle surfaceRect = ParentForm.ClientRectangle;
                ChildForm.Left += ParentForm.Size.Width-surfaceRect.Width;
            }
        }
    }
}
