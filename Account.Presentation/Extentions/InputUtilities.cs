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
    }
}
