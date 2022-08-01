using GeoCardinalDirections.Models;
using GeoCardinalDirections.Services;
using Microsoft.AspNetCore.Mvc;

namespace GeoCardinalDirections.Controllers
{
    public class CordinateController : ControllerBase
    {
        private readonly ICSVReaderService readerService;

        public CordinateController(ICSVReaderService readerService)
        {
            this.readerService = readerService;
        }

        [HttpGet("north")]
        public ActionResult<Cordinate> North()
        {
            Cordinate northCordinate;
            
            try
            {
                northCordinate = readerService.GetNorthCordinate();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            return Ok(northCordinate);
        }

        [HttpGet("east")]
        public ActionResult<Cordinate> East()
        {
            Cordinate eastCordinate;

            try
            {
                eastCordinate = readerService.GetEastCordinate();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            return Ok(eastCordinate);
        }

        [HttpGet("south")]
        public ActionResult<Cordinate> South()
        {
            Cordinate southCordinate;

            try
            {
                southCordinate = readerService.GetSouthCordinate();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            return Ok(southCordinate);
        }

        [HttpGet("west")]
        public ActionResult<Cordinate> West()
        {
            Cordinate westCordinate;

            try
            {
                westCordinate = readerService.GetWestCordinate();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            return Ok(westCordinate);
        }
    }
}
