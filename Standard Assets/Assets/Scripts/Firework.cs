using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firework : MonoBehaviour
{
    // Start is called before the first frame update
    const int SECONDS_TO_EXPLODE_MIN = 3;
    const int SECONDS_TO_EXPLODE_MAX = 5 + 1; // + 1 for the random non-inclusive offset

    void Start()
    {
        Invoke("Explode", UnityEngine.Random.Range(SECONDS_TO_EXPLODE_MIN, SECONDS_TO_EXPLODE_MAX));
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position += new Vector3(0, 1 * Time.deltaTime, 0);
        transform.position += new Vector3(0, 10 * Time.deltaTime, 0);
    }

    void Explode()
    {
        // handle explosion logic and delete
        Destroy(this.gameObject);
    }
}
