using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelReservation
{
    public class Helpers
    {
        public enum Gender
        {
            diger, erkek, kadin
        }
        public static void ContainerClear(Control control)
        {

            if (control.Controls.Count > 0)
            {
                foreach (Control item in control.Controls)
                {
                    if (item is TextBox)
                    {
                        ((TextBox)item).Text = null;
                    }
                   
                    else if (item is RadioButton)
                    {
                        ((RadioButton)item).Checked = false;
                    }
                
                    else if (item.Controls.Count > 0)
                    {
                        ContainerClear(item);
                    }
                }
            }


        }
        public static void PanelButonEnabledFalse(Control control)
        {
                foreach (Button item in control.Controls)
                {
                item.Enabled = false;
            
                }
        }
        public static void PanelButonEnabledTrue(Control control)
        {
            foreach (Button item in control.Controls)
            {
                item.Enabled = true;
            }
        }
        public static void PanelButonColorBlue(Control control)
        {
            foreach (Button item in control.Controls)
            {
                item.BackColor = System.Drawing.Color.Blue;
            }
        }


        public enum Yetki
        {
            admin, mudur, resepsiyonist
        }

       public static bool IsValidEmail(string strIn)
        {
            // Return true if strIn is in valid e-mail format.
            return Regex.IsMatch(strIn, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
        }


    }
}
