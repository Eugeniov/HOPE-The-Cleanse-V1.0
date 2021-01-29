using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class MovePlayer : MonoBehaviour
{
    public float speed;
    public Camera playercamera;
    [SerializeField]
    private bool IsGrounded = false;

    [SerializeField]
    private BoxCollider2D boxCollider2d;
    
    [SerializeField]
    private Rigidbody2D rigidbody2d;

    [SerializeField]
    private Animator animator;
    // Start is called before the first frame update
    void Awake()
    {
        rigidbody2d = transform.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
        animator.SetBool("Start", true);

        if(IsGrounded == true && (Input.GetKeyDown(KeyCode.UpArrow)|| Input.GetKeyDown(KeyCode.Space)))
        {
            float jumpVelocity = 13.0f;
            rigidbody2d.velocity = Vector2.up * jumpVelocity;
            Debug.Log("Jump");
            animator.SetBool("IsGrounded", false);
            IsGrounded = false;
        }
        
        /*if (IsGrounded == true && Input.GetKeyDown(KeyCode.DownArrow))
        {
            animator.SetBool("glissade", true);
        }
        if (IsGrounded == true && Input.GetKeyUp(KeyCode.DownArrow))
        {
            animator.SetBool("glissade", false);
        }*/
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "plateform")
        {
            IsGrounded = true;
            Debug.Log("IsGrounded");
            animator.SetBool("IsGrounded", true);
        }
    }
    IEnumerator takeobstacle()
    {
        Debug.Log("color");
        yield return new WaitForSeconds(5f);
        speed = speed + 2;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "obstacle")
        {
            Debug.Log("touchobstacle");
            speed = speed - 2;
            StartCoroutine("takeobstacle");
        }

        if (other.gameObject.tag == "monster")
        {
          
            Destroy(transform.gameObject);
            GameplayManager.Instance.ShowGameOver();
        }
    }
}
