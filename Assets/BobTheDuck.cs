using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class BobTheDuck : MonoBehaviour
{
    public string duckName;
    [HideInInspector]
    public bool dead;
    public Color duckColor;
    public int[] someNumbers;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -5)
        {
            gameObject.SetActive(false);
        }
    }
}
