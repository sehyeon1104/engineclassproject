using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Define : MonoBehaviour
{
    public enum State
    {
        Idle,
        Moving,
        Die,
    }
    
    public enum Layer
    {
        monster =7,
        Ground=8,
        Block=9
    }

    public enum MouseEvent
    {
        Press,
        Click,
    }
    public enum CameraMode
    {
        QuarterView,
    }
}