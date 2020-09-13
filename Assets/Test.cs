using UnityEngine;
using System.Collections;


public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    public class Boss
    {
            private int mp = 53;


            public void Magic()
            {


                  if(mp >= 5)
                  {
                    this.mp -= 5;
                      Debug.Log("魔法攻撃をした。残りMPは" + mp + "。");
                  }
                  else
                  {
                      Debug.Log("MPが足りないため魔法が使えない。");
                  }

            }

    }


    void Start()
    {
        int[] array = { 20, 30, 10, 40, 100 };

    for (int i = 0; i < array.Length; i++)
    {
      Debug.Log(array [i]);
    }

    for (int i = array.Length - 1; i >= 0; i--)
      {
    Debug.Log(array [i]);
      }

      Boss mag = new Boss();

      for (int i = 0; i <= 10; i++)
      {
        mag.Magic();
      }

    }



    // Update is called once per frame
    void Update()
    {

    }
}
