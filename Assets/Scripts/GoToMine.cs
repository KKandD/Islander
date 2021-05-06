using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToMine : MonoBehaviour
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

        if (PlayerPosition.x < 9 && PlayerPosition.x > 7 && PlayerPosition.y > 0 && PlayerPosition.y < 2 && Input.GetKeyDown(KeyCode.E))
        {
            Application.LoadLevel("Level1 Cave");
        }
        
    }
}
