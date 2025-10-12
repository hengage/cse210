// Creative Additions
// Added a TimedGoal class that creates deadline-based goals with bonus points for timely completion.
// Goals show deadline dates and expire if not completed on time, providing visual feedback with [EXPIRED] status.

using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}