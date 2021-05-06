using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodItem : MonoBehaviour
{
    
    public void Use()
    {
        Debug.Log("we use Food");
        var gplayer = GameObject.FindGameObjectWithTag("Player");
        var player = gplayer.GetComponent<Player>();
        player.GetHealthByDrinkOrEat(10);
        Destroy(gameObject);
    }
}
