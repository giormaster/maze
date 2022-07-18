using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "GCards", menuName = "GCard")]
public class GCards : ScriptableObject
{
    public Sprite GCardSprite;
    public string Type;
    public bool Got = false;
    
}
