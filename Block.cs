using UnityEngine;
using System.Collections;

public class Block : MonoBehaviour {

    void OnMouseDown()
    {
        GameObject.Find("Player").transform.position = transform.position;
    }

}
