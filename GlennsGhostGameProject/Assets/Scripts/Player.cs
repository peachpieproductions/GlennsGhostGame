using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public int playerId;
    public float moveSpeed = 3f;

    string inputMoveHorizontal;
    string inputMoveVertical;
    Rigidbody2D rb;

    private void Awake() {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Start() {
        SetControls(playerId);
    }

    private void Update() {
        rb.velocity = new Vector2(Input.GetAxisRaw(inputMoveHorizontal), Input.GetAxisRaw(inputMoveVertical)) * moveSpeed;
    }

    public void SetControls(int id) {
        inputMoveHorizontal = "Horizontal_" + (id + 1);
        inputMoveVertical = "Vertical_" + (id + 1);
    }





}
