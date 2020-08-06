using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxSpawner : MonoBehaviour
{
    //All locations in the scene
    public Transform[] RandomLocations;

    //Prefab of Box
    public GameObject BoxPrefab;

    //can edit from inspector
    public int _NoBoxesToSpawn = 20;

    [HideInInspector]
    public bool[] Usedlocation;
    public static int S_no =0;
    // Start is called before the first frame update
    void Start()
    {
        Usedlocation = new bool[RandomLocations.Length];
        S_no = 0;
        //for (int i = 0; i < RandomLocations.Length; i++)
        //{
        //    Usedlocation[i] = false;
        //}

        for (int i = 0; i < _NoBoxesToSpawn; i++)
        {
            checkAgain:
            int randLocation = Random.Range(0, RandomLocations.Length);

            if (!Usedlocation[randLocation])
            {
                Usedlocation[randLocation] = true;
                var box = Instantiate(BoxPrefab, RandomLocations[randLocation].position, Quaternion.identity);
                //if (i > 12)
                //{
                //    box.GetComponent<Rotator>().palindrom += S_no;
                //}

            }
            else
            {
                goto checkAgain;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
