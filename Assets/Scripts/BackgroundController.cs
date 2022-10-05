using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - PlayerController.bpm_timer >= 60 / PlayerController.bpm) {
            int bx = (PlayerController.curx + 2) % 2;
            int by = (PlayerController.cury + 2) % 2;
            transform.position = new Vector3(bx + 0.5f, by + 0.5f, 0);
        }
    }

}
