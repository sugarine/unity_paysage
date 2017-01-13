using UnityEngine;
using System.Collections;

public class spawnersardine : MonoBehaviour{
    public GameObject sardine;

    private int sards = 0;
    // Use this for initialization
    void Start () {
        StartCoroutine("spawn");
    }

    // Update is called once per frame
    void Update () {
        if (sards == 30)
        {
            StopCoroutine("spawn");
        }
    }
    IEnumerator spawn()
    {
        Instantiate(sardine, new Vector3(transform.position.x + Random.Range(-15, 21), transform.position.y + Random.Range(-10, 11), transform.position.z), Quaternion.Euler(0,180,0));
        sards++;
        yield return new WaitForSeconds(0.6f);
        StartCoroutine("spawn");
    }
}