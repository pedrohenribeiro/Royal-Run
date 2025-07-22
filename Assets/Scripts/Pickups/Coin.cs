using UnityEngine;

public class Coin : PickUp
{
    protected override void OnPickup()
    {
        Debug.Log("Add 100 points");
    }
}
