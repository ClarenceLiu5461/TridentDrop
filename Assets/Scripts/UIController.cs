using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public Text LifeCount;

    private int Life;
    void Update()
    {
        Life = PlayerController.Health;
        LifeCount.text = Life.ToString();
        if (Life <= 0)
        {
            Application.Quit();
        }
    }

}
