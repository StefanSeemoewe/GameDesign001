using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove2 : MonoBehaviour
{
    private bool turnleft, turnRight;
    public float speed = 7.0f;
    private CharacterController myCharacterController;

    // Start is called before the first frame update
    void Start()
    {
        myCharacterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        turnleft = Input.GetKeyDown(KeyCode.S);
        turnRight = Input.GetKeyDown(KeyCode.W);

        if (turnleft)
            transform.Rotate(new Vector3(0f, -90f, 0f));
        else if (turnRight)
            transform.Rotate(new Vector3(0f, 90f, 0f));

        myCharacterController.SimpleMove(new Vector3(0f, 0f, 0f));
        myCharacterController.Move(transform.forward * speed * Time.deltaTime);
    }
}
