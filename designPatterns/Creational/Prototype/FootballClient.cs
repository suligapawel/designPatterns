namespace designPatterns.Creational.Prototype
{
    public class FootballClient
    {
        public void RunClientCode()
        {
            Football[] footballs = new Football[3];

            footballs[0] = new Football(false);
            footballs[1] = footballs[0].Clone() as Football;

            footballs[1].InflateFootball();
            
            footballs[2] = footballs[1].Clone() as Football;

            foreach (Football football in footballs)
            {
                football.InflateFootball();
            }
        }
    }
}