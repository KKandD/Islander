using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodItem : MonoBehaviour
{
    
    public void Use()
    {
        Debug.Log("we use Food");
        Destroy(gameObject);
    }
}
