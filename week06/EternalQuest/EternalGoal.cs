using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EternalQuest;

namespace EternalQuest
{
   public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points) { }

    public override int RecordEvent() => _points;

    public override string GetStatus() => $"[∞] {_name}";

    public override string SaveString() => $"EternalGoal|{_name}|{_description}|{_points}";
}

}