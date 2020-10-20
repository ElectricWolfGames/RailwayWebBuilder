using eWolfBootstrap.HtmlExtracts;
using System;
using System.Linq;

namespace RailwayWebBuilderCore.LocoDetails
{
    public class HtmlTableExtractLoco
    {
        private HtmlTableExtract _htmlTableExtract;

        public HtmlTableExtractLoco(HtmlTableExtract htmlTableExtract)
        {
            _htmlTableExtract = htmlTableExtract;
        }

        public string Designer
        {
            get
            {
                return _htmlTableExtract.GetDisplayText("Designer");
            }
        }

        public string Name
        {
            get
            {
                return _htmlTableExtract.Name;
            }
        }

        public string BuildDate
        {
            get
            {
                return _htmlTableExtract.GetDisplayText("Build date");
            }
        }

        public DateTime BuildDateTime
        {
            get
            {
                string date = _htmlTableExtract.GetDisplayText("Build date");
                string digits = new String(date.Where(Char.IsDigit).ToArray());

                string year = digits.Substring(0, 4);
                if (year == "6400")
                    year = digits.Substring(4, 4);

                int yearValue = int.Parse(year);

                DateTime dt = new DateTime(yearValue, 1, 1);

                /*

                if (date == "February – September 1954")
                {
                    return new DateTime(1954, 2, 1);
                }

                if (date == "1937–1948")
                {
                    return new DateTime(1937, 1, 1);
                }

                if (date == "1935–1938")
                {
                    return new DateTime(1935, 1, 1);
                }

                if (date == "1933 (2), 1935 (10)")
                {
                    return new DateTime(1933, 1, 1);
                }

                if (date == "1922–1935")
                {
                    return new DateTime(1922, 1, 1);
                }

                string[] parts = date.Split("–");
                parts = parts[0].Split("-");
                DateTime dt;
                try
                {
                    dt = DateTime.ParseExact(parts[0].Trim(), "MMMM yyyy",
                                              CultureInfo.InvariantCulture);
                }
                catch
                {
                    dt = DateTime.Now;
                }*/
                return dt;
            }
        }

        public string Whyte
        {
            get
            {
                return _htmlTableExtract.GetDisplayText("Whyte");
            }
        }

        public int TotalProduced
        {
            get
            {
                return _htmlTableExtract.GetIntDisplayText("Total produced");
            }
        }

        public string Length
        {
            get
            {
                return _htmlTableExtract.GetDisplayText("Length");
            }
        }
    }
}
