using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EternalQuest;

namespace EternalQuest
{
    public class GoalManager
{
    private List<Goal> _goals = new();
    private int _score = 0;

    public void AddGoal(Goal goal) => _goals.Add(goal);

    public void RecordGoal(int index)
    {
        if (index >= 0 && index < _goals.Count)
        {
            int points = _goals[index].RecordEvent();
            _score += points;
            Console.WriteLine($"You earned {points} points! Total score: {_score}");
        }
    }

    public void ShowGoals()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetStatus()}");
        }
    }

    public void Save(string file)
    {
        var lines = new List<string> { _score.ToString() };
        lines.AddRange(_goals.Select(g => g.SaveString()));
        File.WriteAllLines(file, lines);
    }

    public void Load(string file)
    {
        if (!File.Exists(file)) return;
        string[] lines = File.ReadAllLines(file);
        _score = int.Parse(lines[0]);
        _goals.Clear();

        foreach (string line in lines.Skip(1))
        {
            string[] parts = line.Split('|');
            switch (parts[0])
            {
                case "SimpleGoal":
                    _goals.Add(new SimpleGoal(parts[1], parts[2], int.Parse(parts[3])));
                    break;
                case "EternalGoal":
                    _goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
                    break;
                case "ChecklistGoal":
                    ChecklistGoal cg = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[5]), int.Parse(parts[4]));
                    cg.RecordEvent(); // fix up current count
                    _goals.Add(cg);
                    break;
            }
        }
    }

    public int GetScore() => _score;
}

}