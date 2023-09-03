using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    // Start is called before the first frame update
    int i;
    public Renderer rend;
    int randomInt;

    void Start()
    {
        i = 3;
        randomInt = Random.Range(150, 251);
    }

    // Update is called once per frame
    void Update()
    {
        i++;
        Debug.Log(gameObject.name + ":" + i);
        if (gameObject.CompareTag("Red") && i == 100)
            gameObject.SetActive(false);
        if (gameObject.CompareTag("Blue") && i == randomInt)
            rend.enabled = false;

    }
}
