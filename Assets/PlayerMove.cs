using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{   public float speed=3.0f;
	public bool moved=false;
    void Update()
    {
        if(moved){
			transform.position=transform.position+Camera.main.transform.forward*speed*Time.deltaTime;
		}
    }
}
