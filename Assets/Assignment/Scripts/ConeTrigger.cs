using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConeTrigger : MonoBehaviour
{

    public GameObject Barrier1;
    public GameObject Barrier2;

    // Start is called before the first frame update
    void Start()
    {
        Barrier1.SetActive(false);
        Barrier2.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (Barrier1.activeInHierarchy == true)
        {
            Barrier1.SetActive(false);
            Barrier2.SetActive(true);
        }
        else
        {
            Barrier1.SetActive(true);
            Barrier2.SetActive(false);
        }
    }
}
