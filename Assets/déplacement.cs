using UnityEngine;
using System.Collections;

public class déplacement : MonoBehaviour {

    Transform t;
    public Vector3 deplacement;
    public float animSpeed = 1.0f;

    // Use this for initialization
    void Start ()
    {
        t = GetComponent<Transform>();
        if (t == null) Debug.Log("no transform !");
    }
	
	// Update is called once per frame
	void Update ()
    {
        t.position = t.position + deplacement * Time.deltaTime;
        t.position = t.position + new Vector3(0, Mathf.Sin(Time.time)*2, 0) * Time.deltaTime;
        Animation a = GetComponent<Animation>();
        if(a)
            a.clip.frameRate = 30 * animSpeed;
    }
}