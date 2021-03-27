using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleLevel : MonoBehaviour
{
    public GameObject Easy;
    public GameObject Hard;
    public void ToggleEasy()
    {
        Easy.SetActive(true);
        //Hard.SetActive(false);
    }

    public void ToggleHard()
    {
        Hard.SetActive(true);
        Easy.SetActive(false);
    }
}
