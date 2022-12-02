namespace AdventOfCode2023
{
    public abstract class DayChallenge
    {
        public abstract void RunPart1();
        public abstract void RunPart2();

        public void RunDay()
        {
            this.RunPart1();
            this.RunPart2();
        }
    }
}
