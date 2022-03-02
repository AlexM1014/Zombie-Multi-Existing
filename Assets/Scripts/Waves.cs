using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waves : MonoBehaviour
{
    List<GameObject> Zombielist;


    // Update is called once per frame
    void Update()
    {
        if(Zombielist.Count == 0)
        {
            SpawnWave();
        }

        for(int i = Zombielist.Count; i > 0; i++)
        {
            if(Zombielist[i] == null)
            {
                Zombielist.RemoveAt(i);
            }
        }
    }

    public void SpawnWave()
    {

    }
}
