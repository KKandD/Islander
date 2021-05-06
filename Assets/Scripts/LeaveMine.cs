using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeaveMine : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var playerObject = GameObject.Find("Player");
        var PlayerPosition = playerObject.transform.position;

        if (PlayerPosition.x < 11 && PlayerPosition.x > 9 && PlayerPosition.y > (-6) && PlayerPosition.y < (-3) && Input.GetKeyDown(KeyCode.E))
        {
            PlayerPosition.x = 8;
            PlayerPosition.y = 1;
            Application.LoadLevel("Level1");
        }

    }
}
