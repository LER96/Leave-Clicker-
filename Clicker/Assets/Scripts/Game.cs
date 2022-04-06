using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System;

public class Game : MonoBehaviour
{
    public Text ui;
    public List<int> shovel;
    public List<int> tree;
    public List<int> airgun;
    public void Increment()
    {
        //GameManager.leave += GameManager.multiplier;
        GameManager.leave += 1;
    }

    public void Buy(int num)
    {
        if (num == 1 && GameManager.leave >= 25)
        {
            //GameManager.multiplier += 1;
            shovel.Add(1);
            GameManager.leave -= 25;
        }
        if (num == 2 && GameManager.leave >= 40)
        {
            //GameManager.multiplier += 10;
            tree.Add(2);
            GameManager.leave -= 40;
        }
        if (num == 3 && GameManager.leave >= 80)
        {
            //GameManager.multiplier += 100;
            tree.Add(3);
            GameManager.leave -= 80;
        }
    }

    public void Update()
    {
        //
        GameManager.leave += shovel.Count* Time.fixedDeltaTime*0.03f;
        GameManager.leave += tree.Count * Time.fixedDeltaTime*0.1f;
        GameManager.leave += airgun.Count * Time.fixedDeltaTime*0.3f;

        ui.text = "Leaves: " + (int)GameManager.leave;
    }


}

