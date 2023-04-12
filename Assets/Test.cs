using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//発展課題class
public class Boss
{
    private int mp = 53;

    public void Magic()
    {
        if (this.mp >= 5)
        {
            this.mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + this.mp);
        }
        else
        {
            Debug.Log("MPが足りないため、魔法が使えない。");
        }
        
    }
}


public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //通常課題
        int[] array = { 100, 300, 500, 700, 1000 };

        for(int i = 0; i < 5; i++)
        {
            Debug.Log(array[i]);
        }

        for(int i = 4; i >= 0; i--)
        {
            Debug.Log(array[i]);
        }

        //発展課題start関数から呼び出し
        Boss lastboss = new Boss();

        for(int i = 0; i <= 10; i++)
        {
            lastboss.Magic();
        }
        
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
