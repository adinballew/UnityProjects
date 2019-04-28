using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitSpawner : MonoBehaviour {

	public GameObject fruitPrefab;
    public GameObject fruitSlicedPrefab;
	public Transform[] spawnPoints;

    public float minDelay = .1f;
	public float maxDelay = 1f;

	// Use this for initialization
	void Start () {
        float spawnSpeed = Options.spawnSpeedVal;
        resizeFruit(Options.fruitSizeVal);
		StartCoroutine(SpawnFruits(spawnSpeed));
	}

    private void resizeFruit(float size)
    {
        fruitPrefab.transform.localScale = new Vector3(size, size, size);
        fruitSlicedPrefab.transform.localScale = new Vector3(size, size, size);
    }

	IEnumerator SpawnFruits (float spawnSpeed)
	{
		while (true)
		{
			float delay = 1 - spawnSpeed;
			yield return new WaitForSeconds(delay);

			int spawnIndex = Random.Range(0, spawnPoints.Length);
			Transform spawnPoint = spawnPoints[spawnIndex];

			GameObject spawnedFruit = Instantiate(fruitPrefab, spawnPoint.position, spawnPoint.rotation);
            Score.fruitsSpawned++;
            Score.fruitsLost++;
            Destroy(spawnedFruit, 5f);
		}
	}
	
}