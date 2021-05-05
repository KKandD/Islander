using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElixirItem : MonoBehaviour
{
    
    public void Use()
    {
        Debug.Log("we use Elixir ");
        Destroy(gameObject);
    }
}
