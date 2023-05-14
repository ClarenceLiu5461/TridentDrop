using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TridentGenerator : MonoBehaviour
{
    public GameObject TridentPrefab;
    float span = 1.0f;
    float delta = 0;
    void Update()
    {
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(TridentPrefab) as GameObject;
            int px = Random.Range(-8, 8);
            go.transform.position = new Vector3(px, 6, 0);
        }
    }
}
