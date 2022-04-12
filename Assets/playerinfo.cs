using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerinfo : MonoBehaviour
{
    public static playerinfo Instance;
    public int WhichPlayer;
    private void Awake()
    {
        Instance = this;
    }
}
