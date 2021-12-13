using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAgro : MonoBehaviour
{

    [SerializeField] Transform player;
    [SerializeField] float agroRange;

    private bool facingRight = false;

    Rigidbody2D rb2d;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Distance to the player
        float distance = Vector2.Distance(transform.position, player.position);
        Debug.Log("Distance to player: " + distance + " Facing Right?: " + facingRight);

        if (distance <= agroRange) {
            if (facingRight == false) {
                if (player.position.x <= transform.position.x) {
                    enterAgro();
                }
            }
            else {
                enterAgro();
            }
        }
    }

    void enterAgro() {
        Debug.Log("I'm Angy >:O");
    }

    void exitAgro() {
        
    }
}
