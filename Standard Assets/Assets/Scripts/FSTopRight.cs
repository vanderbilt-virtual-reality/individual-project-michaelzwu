using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FSTopRight : MonoBehaviour
{
    public GameObject match;
    [SerializeField]
    GameObject fireworkPrefab;

    float lastSpawnTime = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }


    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject == match)
        {
            // if 2.5 sec have elapsed, set newest spawn time to now and spawn a firework
            if (Time.time - lastSpawnTime > 2.5f)
            {
                lastSpawnTime = Time.time;
                SpawnFirework();
            }

        }
    }

    void SpawnFirework()
    {
        /*Instantiate(fireworkPrefab, transform.position + new Vector3(transform.position.x + UnityEngine.Random.Range(1, 11),
           transform.position.y + UnityEngine.Random.Range(1,11), transform.position.z + UnityEngine.Random.Range(1, 11)), Quaternion.identity);*/
        Instantiate(fireworkPrefab, transform.position + new Vector3(transform.position.x + UnityEngine.Random.Range(-1, -50),
           transform.position.y + UnityEngine.Random.Range(-1, -50), transform.position.z + UnityEngine.Random.Range(-1, -50)), Quaternion.identity);
    }

}

