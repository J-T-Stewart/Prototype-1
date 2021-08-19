using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private bool trigger = true;
    [SerializeField] Vector3 offsetPosition = new Vector3(0, 5, -8);

    void LateUpdate()
    {
        transform.position = player.transform.position + offsetPosition;

        if(Input.GetKeyDown("space")) {
            if (trigger) {
                trigger = false;
                offsetPosition = new Vector3(0, 2.5f, 0);
            } else {
                trigger = true;
                offsetPosition = new Vector3(0, 5, -8);
            }
        }
    }
}
