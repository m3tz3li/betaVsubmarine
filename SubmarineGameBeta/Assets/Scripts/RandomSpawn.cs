using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour
{
    public GameObject heart;
    public GameObject fish;
    public GameObject shark;

    public float fishTimer = 3;
    public float sharkTimer = 5;
    public int maxFish = 4;

    private void Start()
    {
        InvokeRepeating("SpawnFish", 0, fishTimer);
        InvokeRepeating("SpawnShark", 0, sharkTimer);
    }

    private void SpawnFish()
    {
        int randomNumberOfFish = Random.Range(1, maxFish + 1);
        for (int i = 0; i < randomNumberOfFish; i++)
        {
            Vector3 randomPos = new Vector3(transform.position.x, Random.Range(-7, 10), transform.position.z);
            Instantiate(fish, randomPos, Quaternion.identity);
        }
    }

    private void SpawnShark()
    {
        Vector3 randomPos = new Vector3(transform.position.x, Random.Range(-7, 10), transform.position.z);
        Instantiate(shark, randomPos, Quaternion.identity);
        Instantiate(heart, randomPos, Quaternion.identity);
    }
}
