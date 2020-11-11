using System;

class MainClass {
  public static void Main (string[] args) {
    int num, startHr, startMin, startSec, goalHour, goalMin, goalSec, finishTime, finishHr, finishMin, finishSec;
    int i = 0;
    int winnerFinishTime = 0;
    int winnerNum = 0;
    int winnerFinishHr = 0;
    int winnerFinishMin = 0;
    int winnerFinishSec = 0;
    while (true) 
    {
      Console.Write("Enter player number:");
      num = Convert.ToInt32(Console.ReadLine());
      if (num < 1) {
        break;
      }
      i++;
      Console.Write("Enter start hour:");
      startHr = Convert.ToInt32(Console.ReadLine());
      Console.Write("Enter start minute:");
      startMin = Convert.ToInt32(Console.ReadLine());
      Console.Write("Enter start second:");
      startSec = Convert.ToInt32(Console.ReadLine());
      Console.Write("Enter goal hour:");
      goalHour = Convert.ToInt32(Console.ReadLine());
      Console.Write("Enter goal minute:");
      goalMin = Convert.ToInt32(Console.ReadLine());
      Console.Write("Enter goal second:");
      goalSec = Convert.ToInt32(Console.ReadLine());
      finishHr = goalHour - startHr;
      finishMin = goalMin - startMin;
      if (finishMin < 0) {
        finishMin = 60 + finishMin;
        finishHr = finishHr - 1;
      };
      finishSec = goalSec - startSec;
      if (finishSec < 0) {
        finishSec = 60 +finishSec;
        finishMin = finishMin -1;
        if (finishMin < 0) {
          finishMin = 60 + finishMin;
          finishHr = finishHr - 1;
        }
      };
      if (finishHr < 0 || finishMin < 0 || finishSec < 0) {
        Console.WriteLine("goal time have to be greater than start time");
        continue;
      };
      
      finishTime = int.Parse(finishHr.ToString("D2") + finishMin.ToString("D2") + finishSec.ToString("D2"));
      Console.WriteLine("test to see the finish time " + finishTime);
      if (finishTime < winnerFinishTime || i == 1) {
        winnerFinishTime = finishTime;
        winnerFinishHr = finishHr;
        winnerFinishMin = finishMin;
        winnerFinishSec = finishSec;
        winnerNum = num;
      }
    }

     Console.WriteLine("player number " + winnerNum + " is the winner");
     Console.WriteLine("Winning finish time: " + winnerFinishHr + " hours " + winnerFinishMin + "minutes " + winnerFinishSec + " seconds");
     Console.WriteLine("Number of competitors: " + i);
  }
}
