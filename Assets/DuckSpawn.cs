using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckSpawn : MonoBehaviour
{
    public GameObject duckGO;
    // Start is called before the first frame update
    void Start()
    {
        var i = 0;
        while (i < 10)
        {
            var duck = Instantiate(duckGO) as GameObject;
            duck.transform.position = new Vector2(Random.Range(-3, 3), 5);
            duck.transform.parent = transform;
            i++;
        }
    }

    // Update is called once per frame
}
