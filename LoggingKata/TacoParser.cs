namespace LoggingKata
{
    
    public class TacoParser
    {
        readonly ILog logger = new TacoLogger();
        
        public ITrackable Parse(string line)
        {
            logger.LogInfo("Begin parsing");


            var cells = line.Split(',');


            if (cells.Length < 3)
            {
                logger.LogError("Less than three items in input.");

                return null;
            }

            var lat = double.Parse(cells[0]);

            var lng = double.Parse(cells[1]);

            var name = cells[2];

            var point = new Point();
            point.Latitude = lat;
            point.Longitude = lng;

            var tacoBell = new TacoBell();
            tacoBell.Name = name;
            tacoBell.Location = point;

            return tacoBell;

        }
    }
}