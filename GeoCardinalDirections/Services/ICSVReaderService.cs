using GeoCardinalDirections.Models;

namespace GeoCardinalDirections.Services
{
    public interface ICSVReaderService
    {
        Cordinate GetEastCordinate();
        Cordinate GetNorthCordinate();
        Cordinate GetSouthCordinate();
        Cordinate GetWestCordinate();
    }
}
