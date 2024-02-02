using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLineBarrier : MonoBehaviour
{

    public GameObject WWA;

    // Start is called before the first frame update
    void Start()
    {
        WWA.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        WWA.SetActive(true);
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        WWA.SetActive(false);
    }
}
