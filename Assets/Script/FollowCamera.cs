using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] private float speed;
    private float currentPosX;
    private Vector3 velocity = Vector3.zero;

    [SerializeField] private Transform Player;
    
    private void Update()
    {
        transform.position = Vector3.SmoothDamp(transform.position, new Vector3(currentPosX, transform.position.y, transform.position.z), ref velocity,
            speed);

        transform.position = new Vector3(transform.position.x , Player.position.y, transform.position.z);
        
    }
   
    public void MovetoNewRoom(Transform _newRoom)
    {
        currentPosX = _newRoom.position.x;
    }    
}

