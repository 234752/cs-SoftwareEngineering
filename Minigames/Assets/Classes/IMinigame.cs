using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IMinigame
{
    public bool IsCompleted { get; set; }
    public int EnvironmentPoints { get; set; }

    public int StartMinigame();
    public int CalculateEnvironmentPoints();
}
