using UnityEngine;
using System.Collections;

public class spawner : MonoBehaviour {
    public GameObject baleine;

    private int bals = 0;
	// Use this for initialization
	void Start () {
        StartCoroutine("spawn");
	}
	
	// Update is called once per frame
	void Update () {
	    if(bals == 3)
        {
            StopCoroutine("spawn");
        }
	}
    IEnumerator spawn()
    {
        GameObject go = Instantiate(baleine, new Vector3(transform.position.x + Random.Range(-120,131), transform.position.y + Random.Range(-30,121), transform.position.z), Quaternion.identity) as GameObject;
        bals++;
        yield return new WaitForSeconds(0.35f);
        StartCoroutine("spawn");
    }
}
