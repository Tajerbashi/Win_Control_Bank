namespace Infrastructure.Test.ExternalHandler
{
    public class ReadData_FromCSVFile : TheoryData<int, bool>
    {
        public ReadData_FromCSVFile(string fileName, string splitor)
        {
            var dataFromFile = File.ReadLines(fileName);
            foreach (var line in dataFromFile)
            {
                //  Splite the string
                var splitString = line.Split(splitor);
                //  try parsing
                if (int.TryParse(splitString[0], out int value1)
                    && bool.TryParse(splitString[1], out bool value2)
                    )
                {
                    //  add test data
                    Add(value1, value2);
                }
            }
        }
        //  Usage
        //  [ClassData(typeof(ReadData_FromCSVFile))]
    }
}
