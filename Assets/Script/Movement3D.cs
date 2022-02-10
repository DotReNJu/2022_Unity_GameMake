using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement3D : MonoBehaviour
{
    [SerializeField]
    private float   moveSpeed = 5.0f;   //이동속도
    private Vector3 moveDirection;      //이동방향
    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        characterController.Move(moveDirection * moveSpeed * Time.deltaTime);
    }

    public void MoveTo(Vector3 private void OnDisconnectedFromServer(NetworkDisconnection info) {
    {
            moveDirection = direction;

    }
}
