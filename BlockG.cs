using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class BlockG : MonoBehaviour
{
    public GameObject block1;
    public GameObject block2;
    public GameObject block3;
    public GameObject block4;

    public static float blockspeed = 3.0f;
    public static string pro;

    private float time = 0;

    private int x;
    private int y;
    public static int ans1;
    public static int ans2;
    public static int ans3;
    public static int ans4;
    public static int shuf;
    // Start is called before the first frame update
    void Start()
    {
        x = Random.Range(1, 11);
        y = Random.Range(1, 11);
        ans1 = x + y;
        ans2 = x + y - 1;
        ans3 = x + y - 2;
        ans4 = x + y + 1;
        shuf = Random.Range(0, 4);
        // shuf에 따른 트리거 수정

        pro = string.Format("{0} + {1}", x, y);

        if (shuf == 0)
        {
            GameObject newblock = Instantiate(block1);
            Destroy(newblock, 10.0f);
        }

        else if (shuf == 1)
        {
            GameObject newblock = Instantiate(block2);
            Destroy(newblock, 10.0f);
        }

        else if (shuf == 2)
        {
            GameObject newblock = Instantiate(block3);
        }

        else if (shuf == 3)
        {
            GameObject newblock = Instantiate(block4);
        }
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time > 5)
        {
            blockspeed += 0.5f;

            x = Random.Range(1, 11);
            y = Random.Range(1, 11);
            ans1 = x + y;
            ans2 = x + y - 1;
            ans3 = x + y - 2;
            ans4 = x + y + 1;
            shuf = Random.Range(0, 4);
            // shuf에 따른 트리거 수정

            pro = string.Format("{0} + {1}", x, y);

            if (shuf == 0)
            {
                GameObject newblock = Instantiate(block1);
                Destroy(newblock, 10.0f);
            }

            else if (shuf == 1)
            {
                GameObject newblock = Instantiate(block2);
                Destroy(newblock, 10.0f);
            }

            else if (shuf == 2)
            {
                GameObject newblock = Instantiate(block3);
            }

            else if (shuf == 3)
            {
                GameObject newblock = Instantiate(block4);
            }

            time = 0;
        }
    }
}
