namespace TP_MODUL6_103022400008
{
    public class SayaMusicTrack {

        private int id;
        private string count;
        private string title;

        public SayaMusicTrack(string title) 
        {
            Random rand = new Random();
            int randomNum = rand.Next(10000, 100000);
            this.id = randomNum;

            this.count = "0";
            this.title = title;
        }

        public void IncreasePlayCount(int count) 
        {
            int currentCount = int.Parse(this.count);
            currentCount += count;
            this.count = currentCount.ToString();
        }

        public void PrintTrackDetails() {
            Console.WriteLine("| " + this.id + " | " + this.count + " | " + this.title + " |");
        }
    }
}