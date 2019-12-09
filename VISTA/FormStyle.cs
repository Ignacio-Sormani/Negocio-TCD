using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VISTA
{
    public static class FormStyle
    {
        //GENERAL FORM STYLE
        public static void defaultBackGroundColor(Form _form)
        {
            _form.BackColor = Color.Linen;
        }
        public static void defaultForeColor(Form _form)
        {
            _form.ForeColor = Color.Black;
        }
        public static void defaultStartPosition(Form _form)
        {
            _form.StartPosition = FormStartPosition.CenterScreen;
        }
        public static void defaultFont(Form _form)
        {
            _form.Font = new Font("Arial", 9.0F, FontStyle.Regular);
        }
        public static void windowStyle(Form _form)
        {
            _form.BackColor = Color.Moccasin;
            _form.ForeColor = Color.Black;
            _form.Font = new Font("Arial", 10F, FontStyle.Regular);
            _form.StartPosition = FormStartPosition.CenterScreen;
            _form.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            _form.ControlBox = false;
            ControlsStyle(_form);
        }
        public static void defaultWindowStyle(Form _form)
        {
            defaultBackGroundColor(_form);
            defaultForeColor(_form);
            defaultStartPosition(_form);
            defaultFont(_form);
            defaultControlsStyle(_form);
            _form.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            _form.ControlBox = false;
        }
        //CONTROLS DEFAULT STYLE
        public static void defaultControlsStyle(Form _form)
        {
            foreach (var control in _form.Controls)
            {
                //button
                if (control.GetType() == typeof(Button))
                {
                    var a = (Button)control;
                    a.Font = new Font("Arial", 9.0F, FontStyle.Bold);
                    a.BackColor = Color.Goldenrod;
                    a.ForeColor = Color.White;
                    a.FlatStyle = FlatStyle.Flat;
                    a.FlatAppearance.BorderColor = Color.DarkOliveGreen;
                    a.FlatAppearance.MouseOverBackColor = Color.DarkGoldenrod;
                    a.FlatAppearance.BorderSize = 0;
                }
                //control
                if (control.GetType() == typeof(DataGridView))
                {
                    var a = (DataGridView)control;
                    a.BackgroundColor = Color.Gainsboro;
                    a.Font = new Font("Arial", 10.0F, FontStyle.Regular);
                }
                //label
                if (control.GetType() == typeof(Label))
                {
                    var a = (Label)control;
                    a.ForeColor = Color.Black;
                }
                //textbox
                if (control.GetType() == typeof(TextBox))
                {
                    var a = (TextBox)control;
                    a.ForeColor = Color.Brown;
                    a.Font = new Font("Arial", 10.0F, FontStyle.Bold);
                }
                if (control.GetType() == typeof(ToolStrip))
                {
                    var a = (ToolStrip)control;
                    a.BackColor = Color.DarkOliveGreen;
                    a.Font = new Font("Arial", 10.0F, FontStyle.Bold);
                }
            }
        }
        //CONTROL STYLE
        public static void ControlsStyle(Form _form)
        {
            foreach (var control in _form.Controls)
            {
                //button
                if (control.GetType() == typeof(Button))
                {
                    var a = (Button)control;
                    a.ForeColor = Color.White;
                    a.BackColor = Color.Orange;
                    a.FlatStyle = FlatStyle.Flat;
                    a.FlatAppearance.BorderColor = Color.DarkOliveGreen;
                    a.FlatAppearance.MouseOverBackColor = Color.DarkOrange;
                    a.FlatAppearance.BorderSize = 0;
                }
                //label
                if (control.GetType() == typeof(Label))
                {
                    var a = (Label)control;
                    a.ForeColor = Color.Black;
                }
                //textbox
                if (control.GetType() == typeof(TextBox))
                {
                    var a = (TextBox)control;
                    a.ForeColor = Color.Brown;
                }
            }
        }

    }
}
