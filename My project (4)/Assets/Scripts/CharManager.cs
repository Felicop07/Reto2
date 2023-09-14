using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharManager : MonoBehaviour
{
    public static int User = 4;
    public int charID;
    public void changeID()
    {
        CharManager.User = charID;
    }
    void Update()
    {
        if (User != 4)
        {
            gameObject.SetActive(false);
        }
    }
}
