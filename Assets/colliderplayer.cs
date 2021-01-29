using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colliderplayer : MonoBehaviour
{
    [SerializeField]
    private float speed;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator takeobstacle()
    {
        Debug.Log("color");
        yield return new WaitForSeconds(5f);
        transform.parent.Translate(Vector2.right * (speed + 3) * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "obstacle")
        {
            Debug.Log("touchobstacle");
            transform.parent.Translate(Vector2.right * (speed + 3) * Time.deltaTime);
            StartCoroutine("takeobstacle");
        }

        if(other.gameObject.tag == "monster")
        {

            Destroy(transform.parent.gameObject);
        }
    }
}
