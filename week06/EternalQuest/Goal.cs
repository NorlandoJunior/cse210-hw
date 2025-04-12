using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EternalQuest;

namespace EternalQuest
{
        public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;
    protected bool _isComplete;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
        _isComplete = false;
    }

    public abstract int RecordEvent();
    public abstract string GetStatus();
    public abstract string SaveString();

    public string GetName() => _name;
    public bool IsComplete() => _isComplete;
}
 }
