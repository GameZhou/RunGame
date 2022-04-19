using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//背景纹理偏移
public class BackgroundFollow : MonoBehaviour
{
    //public float scrollSpeed = 0.5f;
    //public Renderer rend;
    public float scrollSpeed = 0.03f;
    void Start ()
    {
        //rend = GetComponent<Renderer>();
	}
	void Update ()
    {
        //float offset = Time.time * scrollSpeed;
        //rend.material.mainTextureOffset = new Vector2(offset, 0);    //纹理偏移
        
        transform.position = new Vector3(transform.position.x- scrollSpeed, transform.position.y,transform.position.z);
    }
}
