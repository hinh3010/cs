using System.Text;
using System;

namespace Main
{
    class Home
    {
        static void Main(string[] args)
        {
            Console.Clear();
            
            // validate
            string isNaN(string text = "is not a Number")
            {
                return text;
            }

            string isRequire(string text = "is require")
            {
                return text;
            }

            string isSuccess(string text = "")
            {
                return text;
            }
        
            // check number
            bool stringToNumberText(string text)
            {
                bool res = false;
                if(text != "") {
                    float a;
                    res = float.TryParse(text, out a);
                }
                return res;
            }

            // MessageBox
            void messageBox(string content , string title , string icon = "i" )
            {
                MessageBox.Show($"{content}",
                    $"{title}",
                    MessageBoxButtons.YesNo,
                    icon=="i" ? MessageBoxIcon.Information
                        : (icon == "e" ? MessageBoxIcon.Error 
                        : (icon == "w" ? MessageBoxIcon.Warning
                        : MessageBoxIcon.Question))
                );
            }
            
            // KeyUp
            private void textBox1_KeyUp(object sender, KeyEventArgs e)
            {
                if (textBox1.Text.Trim() == "")
                {
                    label2.Text = isRequire();
                }
                else
                {
                    if (stringToNumberText(textBox1.Text))
                    {
                        float ad = float.Parse(textBox1.Text);
                        label1.Text = ad.ToString();
                        label2.Text = isSuccess();
                    }
                    else
                    {
                        label1.Text = "";
                        label2.Text = isNaN();
                    }
                }
            }
        }
    }            
}



