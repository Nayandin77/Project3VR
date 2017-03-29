using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour {

    //Create a reference to the CoinPoofPrefab
	public GameObject coinPoof;

    public void OnCoinClicked() {
        // Instantiate the CoinPoof Prefab where this coin is located
        // Make sure the poof animates vertically
		Vector3 positionOfCoin = new Vector3 (this.transform.position.x,
			                    this.transform.position.y,
			                    this.transform.position.z);
		Instantiate(coinPoof, positionOfCoin, Quaternion.Euler(-90,0,0)); 
			
        // Destroy this coin. Check the Unity documentation on how to use Destroy
		Destroy (gameObject);
    }

}
