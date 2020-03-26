using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wpftest.HelpClasses
{
    public class Sportsmen
    {
        public string Country   { get; set; }
        public string Name      { get; set; }
        public string Surname   { get; set; }
        public string Sport     { get; set; }
        public int Age          { get; set; }
        public int Gold         { get; set; }
        public int Silver       { get; set; }
        public int Bronze       { get; set; }

        public Sportsmen Create()
        {
            Random random = new Random();

            Country = infobase.countryArray[random.Next(0, infobase.countryArray.Length)];

            switch (Country)
            {
                case "Japan":
                    Name = infobase.JapanNameArray[random.Next(0, infobase.JapanNameArray.Length)];
                    Surname = infobase.JapanSurnameArray[random.Next(0, infobase.JapanSurnameArray.Length)];
                    break;
                case "Germany":
                    Name = infobase.GermanyNameArray[random.Next(0, infobase.GermanyNameArray.Length)];
                    Surname = infobase.GermanySurnameArray[random.Next(0, infobase.GermanySurnameArray.Length)];
                    break;
                case "Russia":
                    Name = infobase.RussianNameArray[random.Next(0, infobase.RussianNameArray.Length)];
                    Surname = infobase.RussianSurnameArray[random.Next(0, infobase.RussianSurnameArray.Length)];
                    break;
                case "French":
                    Name = infobase.FrenchNameArray[random.Next(0, infobase.FrenchNameArray.Length)];
                    Surname = infobase.FrenchSurnameArray[random.Next(0, infobase.FrenchSurnameArray.Length)];
                    break;
                case "Gr. Britain":
                    Name = infobase.EnNameArray[random.Next(0, infobase.EnNameArray.Length)];
                    Surname = infobase.EnSurnameArray[random.Next(0, infobase.EnSurnameArray.Length)];
                    break;
                case "USA":
                    Name = infobase.EnNameArray[random.Next(0, infobase.EnNameArray.Length)];
                    Surname = infobase.EnSurnameArray[random.Next(0, infobase.EnSurnameArray.Length)];
                    break;
                case "Canada":
                    Name = infobase.CanadaNameArray[random.Next(0, infobase.CanadaNameArray.Length)];
                    Surname = infobase.CanadaSurnameArray[random.Next(0, infobase.CanadaSurnameArray.Length)];
                    break;
            }

            Sport = infobase.sportArray[random.Next(0, infobase.sportArray.Length)];

            Age = random.Next(20, 41);
            Gold = random.Next(0, 11);
            Silver = random.Next(0, 21);
            Bronze = random.Next(0, 31);

            return this;
        }
    }
}
