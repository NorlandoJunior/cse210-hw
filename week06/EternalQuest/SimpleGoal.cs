using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EternalQuest;

namespace EternalQuest
{
    public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points)
        : base(name, description, points) { }

    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            return _points;
        }
        return 0;
    }

    public override string GetStatus() => $"[{(_isComplete ? "X" : " ")}] {_name}";

    public override string SaveString() => $"SimpleGoal|{_name}|{_description}|{_points}|{_isComplete}";
}

}