using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElixirItem : MonoBehaviour
{
    
    public void Use()
    {
        Debug.Log("we use Elixir ");
        var gplayer = GameObject.FindGameObjectWithTag("Player");
        var player = gplayer.GetComponent<Player>();
        player.GetHealthByDrinkOrEat(15);
        Destroy(gameObject);
    }
}
