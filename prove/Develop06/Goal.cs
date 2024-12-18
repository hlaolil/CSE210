using System;
using System.Collections.Generic;
using System.IO;

public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetStringRepresentation();

    public virtual string GetDetailsString()
    {
        return $"{_name} - {_description} - {_points} Points";
    }

    public int GetPoints()
    {
        return _points;
    }
}