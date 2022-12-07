using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeanOfTransport
{
    public string Name { get; set; }
    public int PointsValue { get; set; }

    public MeanOfTransport(string name, int points)
    {
        Name = name;
        PointsValue = points;
    }
}
