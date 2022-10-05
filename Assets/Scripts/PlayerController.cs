using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public static float bpm = 120;
    public static float bpm_timer;

    public static int curx, cury;

    // Start is called before the first frame update
    void Start()
    {
        bpm_timer = Time.time;
        curx = 0;
        cury = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - bpm_timer >= 60 / bpm) {
            if (Input.GetKey(KeyCode.UpArrow)) {
                cury += 1;
            }
            if (Input.GetKey(KeyCode.DownArrow)) {
                cury -= 1;
            }
            if (Input.GetKey(KeyCode.LeftArrow)) {
                curx -= 1;
            }
            if (Input.GetKey(KeyCode.RightArrow)) {
                curx += 1;
            }
            bpm_timer = Time.time;
        }
    }
}
