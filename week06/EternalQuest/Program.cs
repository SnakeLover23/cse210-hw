using System;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        List<Goal> goals = new List<Goal>();
        int points = 0;
        bool exit = false;
        do
        {
            Console.Clear();
            Console.WriteLine($"You have {points} points.");
            Console.WriteLine("");
            Console.WriteLine("Menu options:");
            Console.WriteLine("  1) Create New Goal");
            Console.WriteLine("  2) List Goals");
            Console.WriteLine("  3) Save Goals");
            Console.WriteLine("  4) Load Goals");
            Console.WriteLine("  5) Record Event");
            Console.WriteLine("  6) Quit");
            Console.Write("Select an potion from the menu: ");
            string input = Console.ReadLine();
            if (input == "1")
            {
                string name = "";
                string description = "";
                int goalPoints = 0;
                Console.Clear();
                Console.WriteLine("Goal types: ");
                Console.WriteLine("  1) Simple Goal");
                Console.WriteLine("  2) Eternal Goal");
                Console.WriteLine("  3) Checklist Goal");
                Console.Write("Select a goal type: ");
                input = Console.ReadLine();
                if (input == "1")
                {
                    Console.Clear();
                    Console.WriteLine("Selected Simple Goal.");
                    Console.Write("Goal name: ");
                    name = Console.ReadLine();
                    Console.Write("Goal description: ");
                    description = Console.ReadLine();
                    Console.Write("Goal point value: ");
                    string tempPoints = Console.ReadLine();
                    goalPoints = int.Parse(tempPoints);
                    Simple newSimple = new Simple(name, description, goalPoints);
                    Console.Clear();
                    goals.Add(newSimple);
                    Console.WriteLine($"New simple goal {newSimple.GetName()} created.");
                    Console.Write("Press [Enter] to continue.");
                    Console.ReadLine();
                }
                else if (input == "2")
                {
                    Console.Clear();
                    Console.WriteLine("Selected Eternal Goal.");
                    Console.Write("Goal name: ");
                    name = Console.ReadLine();
                    Console.Write("Goal description: ");
                    description = Console.ReadLine();
                    Console.Write("Goal point value: ");
                    string tempPoints = Console.ReadLine();
                    goalPoints = int.Parse(tempPoints);
                    Eternal newEternal = new Eternal(name, description, goalPoints);
                    Console.Clear();
                    goals.Add(newEternal);
                    Console.WriteLine($"New eternal goal {newEternal.GetName()} created.");
                    Console.Write("Press [Enter] to continue.");
                    Console.ReadLine();
                }
                else if (input == "3")
                {
                    int bonusPoints = 0;
                    int timesRequired = 0;
                    Console.Clear();
                    Console.WriteLine("Selected Checklist Goal.");
                    Console.Write("Goal name: ");
                    name = Console.ReadLine();
                    Console.Write("Goal description: ");
                    description = Console.ReadLine();
                    Console.Write("Goal point value: ");
                    string tempPoints = Console.ReadLine();
                    goalPoints = int.Parse(tempPoints);
                    Console.Write("Completion bonus value: ");
                    string tempBonus = Console.ReadLine();
                    bonusPoints = int.Parse(tempBonus);
                    Console.Write("Times required for completion: ");
                    string tempTimes = Console.ReadLine();
                    timesRequired = int.Parse(tempTimes);
                    Checklist newChecklist = new Checklist(name, description, goalPoints, bonusPoints, timesRequired);
                    Console.Clear();
                    goals.Add(newChecklist);
                    Console.WriteLine($"New checklist goal {newChecklist.GetName()} created.");
                    Console.Write("Press [Enter] to continue.");
                    Console.ReadLine();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("I don't understand.");
                    Console.Write("Press [Enter] to continue.");
                    Console.ReadLine();
                }
            }
            else if (input == "2")
            {
                Console.Clear();
                Console.WriteLine("----Your Goals----");
                Console.WriteLine("");
                foreach (Goal goal in goals)
                {
                    Console.WriteLine(goal.GetGoal());
                }
                Console.Write("Press [Enter] to continue.");
                Console.ReadLine();
            }
            else if (input == "3")
            {
                Console.Clear();
                Console.Write("What file path would you like to save too: ");
                string fileName = Console.ReadLine();
                using (StreamWriter file = new StreamWriter(fileName))
                {
                    file.WriteLine(points);
                    foreach (Goal goal in goals)
                    {
                        file.WriteLine(goal.SaveGoal());
                    }
                }
                Console.Clear();
                Console.WriteLine("Your goals have been saved.");
                Console.Write("Press [Enter] to continue.");
                Console.ReadLine();
            }
            else if (input == "4")
            {
                Console.Clear();
                Console.Write("What file path would you like to load from: ");
                List<Goal> newGoals = new List<Goal>();
                string fileName = Console.ReadLine();
                string[] lines = System.IO.File.ReadAllLines(fileName);
                foreach (string line in lines)
                {
                    string[] parts = line.Split(":");
                    if (parts[0] == "Simple")
                    {
                        string[] newGoal = parts[1].Split(",");
                        Simple newSimple = new Simple(newGoal[0], newGoal[1], int.Parse(newGoal[2]));
                        newSimple.SetIsComplete(bool.Parse(newGoal[3]));
                        newGoals.Add(newSimple);
                    }
                    else if (parts[0] == "Eternal")
                    {
                        string[] newGoal = parts[1].Split(",");
                        Eternal newEternal = new Eternal(newGoal[0], newGoal[1], int.Parse(newGoal[2]));
                        newGoals.Add(newEternal);
                    }
                    else if (parts[0] == "Checklist")
                    {
                        string[] newGoal = parts[1].Split(",");
                        Checklist newChecklist = new Checklist(newGoal[0], newGoal[1], int.Parse(newGoal[2]), int.Parse(newGoal[3]), int.Parse(newGoal[4]));
                        newChecklist.SetTimesDone(int.Parse(newGoal[5]));
                        newGoals.Add(newChecklist);
                    }
                    else
                    {
                        points = int.Parse(parts[0]);
                    }
                }
                goals = newGoals;
                Console.Clear();
                Console.WriteLine("Your goals have been loaded.");
                Console.Write("Press [Enter] to continue.");
                Console.ReadLine();
            }
            else if (input == "5")
            {
                Console.Clear();
                List<Goal> tempGoals = new List<Goal>();
                int count = 1;
                foreach (Goal goal in goals)
                {
                    if (goal.IsComplete() == false)
                    {
                        tempGoals.Add(goal);
                    }
                }
                Console.WriteLine("Your uncompleted Goals: ");
                foreach (Goal goal in tempGoals)
                {
                    Console.WriteLine($"  {count}) {goal.GetName()}");
                    count = count + 1;
                }
                Console.Write("Which goal did you accomplish: ");
                string tempInput = Console.ReadLine();
                int goalNumber = int.Parse(tempInput);
                int tempPoints = tempGoals[goalNumber - 1].StepGoal();
                points = points + tempPoints;
                Console.Clear();
                Console.WriteLine($"You have earned {tempPoints} points!");
                Console.Write("Press [Enter] to continue.");
                Console.ReadLine();
            }
            else if (input == "6")
            {
                Console.Clear();
                exit = true;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("I don't understand.");
                Console.Write("Press [Enter] to continue.");
                Console.ReadLine();
            }
        } while (exit == false);
        Console.WriteLine("Goodbuy");
    }
}