﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blob_On_Hit : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
		if (other.tag == "Weapon") 
		{//Checks for weapon hit
			if (this.transform.parent.GetComponent<BlobAI> ().curr_hp != 0) {//gets variable from main script
				this.transform.parent.GetComponent<BlobAI> ().curr_hp -= GameObject.Find ("Player").GetComponent<Player> ().Player_Damage;//changes variable from parent object
				this.transform.parent.GetComponent<BlobAI> ().blink = true;
				this.transform.parent.GetComponent<BlobAI> ().hit_sound = true;
			}
		}
		if (other.tag == "Arrow")//Checks for weapon hit
		{
			if (this.transform.parent.GetComponent<BlobAI>().curr_hp != 0)//gets variable from main script
			{
                this.transform.parent.GetComponent<BlobAI>().curr_hp -= GameObject.Find("Player").GetComponent<Player>().Player_Damage;//changes variable from parent object
				this.transform.parent.GetComponent<BlobAI>().blink = true;
				this.transform.parent.GetComponent<BlobAI>().hit_sound = true;
				this.transform.parent.GetComponent<BlobAI> ().forceMove = true;

			}
		}
        if (other.tag == "Arrow2")//Checks for weapon hit
        {
            if (this.transform.parent.GetComponent<BlobAI>().curr_hp != 0)//gets variable from main script
            {
                BlobAI.arrowHit2 = true;
                BlobAI.onceAround = true;
                this.transform.parent.GetComponent<BlobAI>().curr_hp -= GameObject.Find("Player").GetComponent<Player>().Player_Damage;//changes variable from parent object
                this.transform.parent.GetComponent<BlobAI>().blink = true;
                this.transform.parent.GetComponent<BlobAI>().hit_sound = true;
                this.transform.parent.GetComponent<BlobAI>().forceMove = true;

            }
        }
    }
}
