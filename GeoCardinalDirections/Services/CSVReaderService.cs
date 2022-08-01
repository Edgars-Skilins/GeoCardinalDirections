using CsvHelper;
using CsvHelper.Configuration;
using GeoCardinalDirections.Models;
using System.Globalization;
using System.Text;

namespace GeoCardinalDirections.Services
{
    public class CSVReaderService : ICSVReaderService
    {
        public Cordinate GetNorthCordinate()
        {
            List<Cordinate> cordinates = readCordinates();
            var result = cordinates.MaxBy(x => x.KOORD_X);
            return result;
        }
        public Cordinate GetEastCordinate()
        {
            List<Cordinate> cordinates = readCordinates();

            return cordinates.MaxBy(x => x.KOORD_Y);
        }
        public Cordinate GetSouthCordinate()
        {
            List<Cordinate> cordinates = readCordinates();

            return cordinates.MinBy(x => x.KOORD_X);
        }
        public Cordinate GetWestCordinate()
        {
            List<Cordinate> cordinates = readCordinates();

            return cordinates.MinBy(x => x.KOORD_Y);
        }

        private List<Cordinate> readCordinates()
        {
            List<Cordinate> Cordinates = new();

            var config = new CsvConfiguration(new CultureInfo("lv-LV")) { Delimiter = ";", Encoding = Encoding.UTF8, BadDataFound = null };

            using (var reader = new StreamReader("Data/AW_VIETU_CENTROIDI.CSV"))
            using (var csv = new CsvReader(reader, config))
            {
                Cordinates = csv.GetRecords<Cordinate>().ToList();
            }
            return Cordinates;
        }

    }
}
