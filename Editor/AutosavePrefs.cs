using UnityEngine;
public class AutosavePrefs : ScriptableObject
{
    public bool enable = true, log = true, onPlay = false;
    public int interval = 10;
}