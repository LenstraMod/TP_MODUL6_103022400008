using System.Diagnostics;

namespace TP_MODUL6_103022400008
{
    public class SayaMusicTrack {

        private int id;
        private string count;
        private string title;

        public SayaMusicTrack(string title) 
        {

            Debug.Assert(title != null , "Title tidak boleh kosong");
            Debug.Assert(title.Length <= 100, "Title kepanjangan");

            Random rand = new Random();
            int randomNum = rand.Next(10000, 100000);
            this.id = randomNum;

            this.count = "0";
            this.title = title;
        }

        public void IncreasePlayCount(int count) 
        {

            Debug.Assert(count <= 10000000, "Tidak boleh lebih dari 10.000.000");

            int currentCount = int.Parse(this.count);
            try {
                checked {
                    currentCount += count;
                }

                this.count = currentCount.ToString();
            } catch (OverflowException e) {
                Console.WriteLine("ERROR: MEMENUHI BATAS MAKSIMAL : " + e.ToString());
            }
            
        }

        public void PrintTrackDetails() {
            Console.WriteLine("| " + this.id + " | " + this.count + " | " + this.title + " |");
        }
    }
}