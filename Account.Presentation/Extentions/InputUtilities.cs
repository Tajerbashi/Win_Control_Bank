using System.Text.RegularExpressions;

namespace Account.Presentation.Extentions
{
    public static class InputUtilities
    {
        public static TextBox Thirth3Numeric(this TextBox textBox, decimal number = 0)
        {
            if (textBox.Text.Length > 0)
            {
                if (textBox.Text.Split(",")[0] == "," || textBox.Text.Split(",")[0] == "")
                {
                    textBox.Text = number.ToString();
                    return textBox;
                }
                var checkNumber = Convert.ToDecimal(textBox.Text);
                if (checkNumber > 0)
                {
                    decimal price;
                    price = decimal.Parse(textBox.Text, System.Globalization.NumberStyles.Currency);
                    price += number;
                    textBox.Text = price.ToString("#,#");
                    textBox.SelectionStart = textBox.Text.Length;
                }
                else
                {
                    textBox.Text = "";
                }
            }
            
            return textBox;
        }
        public static TextBox FourNumericSpace(this TextBox textBox)
        {
            var a = Regex.Split("1234123412341234", "(?<=\\G\\d{4})");
            string number = textBox.Text;


            if (textBox.Text.Length > 0)
            {
                if (textBox.Text.Split(",")[0] == "," || textBox.Text.Split(",")[0] == "")
                {
                    textBox.Text = number.ToString();
                    return textBox;
                }
                var checkNumber = Convert.ToDecimal(textBox.Text);
                if (checkNumber > 0)
                {
                    decimal price;
                    price = decimal.Parse(textBox.Text, System.Globalization.NumberStyles.None);
                    textBox.Text = price.ToString("4,#");
                    textBox.SelectionStart = textBox.Text.Length;
                }
                else
                {
                    textBox.Text = "";
                }
            }

            return textBox;
        }
    }
}
