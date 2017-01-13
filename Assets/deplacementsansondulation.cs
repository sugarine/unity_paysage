using UnityEngine;
using System.Collections;

public class deplacementsansondulation : MonoBehaviour {

    Transform t;
    public Vector3 deplacement;

    // Use this for initialization
    void Start()
    {
        t = GetComponent<Transform>();
        if (t == null) Debug.Log("no transform !");
    }

    // Update is called once per frame
    void Update()
    {
        t.position = t.position + deplacement * Time.deltaTime;

    }
}