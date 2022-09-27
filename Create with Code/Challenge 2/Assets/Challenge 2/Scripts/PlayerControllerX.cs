using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float timevar = 0;

    // Update is called once per frame
    void Update()
    {
        if(timevar > 0f)
        {
            timevar -= Time.deltaTime;
        }
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && timevar <= 0)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            timevar = 2f;
        }
    }
}
