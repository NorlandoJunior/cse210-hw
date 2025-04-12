using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EternalQuest;

namespace EternalQuest
{
    public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonusPoints;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints)
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _currentCount = 0;
        _bonusPoints = bonusPoints;
    }

    public override int RecordEvent()
    {
        if (_currentCount < _targetCount)
        {
            _currentCount++;
            if (_currentCount == _targetCount)
            {
                _isComplete = true;
                return _points + _bonusPoints;
            }
            return _points;
        }
        return 0;
    }

    public override string GetStatus() => $"[{(_isComplete ? "X" : " ")}] {_name} — Completed {_currentCount}/{_targetCount}";

    public override string SaveString() =>
        $"ChecklistGoal|{_name}|{_description}|{_points}|{_bonusPoints}|{_targetCount}|{_currentCount}|{_isComplete}";
}

}