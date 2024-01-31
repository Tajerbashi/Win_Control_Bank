using Infrastructure.Library.Models.Controls;

namespace Presentation.Generator
{
    public class ComboBoxGenerator<T>
    {
        public static ComboBox FillData(ComboBox comboBox, IEnumerable<KeyValue<T>> data, long value = 0)
        {
            comboBox.Items.Clear();
            comboBox.Items.Add(new KeyValue<long>
            {
                Key = "---   انتخاب کنید   ---",
                Value = 0
            });
            foreach (var item in data)
            {
                comboBox.Items.Add(item);
            }
            if (value != 0)
            {
                var index = 0;
                foreach (var i in comboBox.Items)
                {
                    var t = (KeyValue<long>)i;
                    if (t.Value == Convert.ToByte(value))
                    {
                        comboBox.SelectedIndex = index;
                    }
                    index++;
                }
            }
            else
            {
                comboBox.SelectedIndex = Convert.ToByte(value);
            }
            return comboBox;
        }
    }
}
