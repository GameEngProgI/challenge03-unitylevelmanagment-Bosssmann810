using UnityEngine;

public class levelchangetrigger : MonoBehaviour
{
    public GameObject currentlevel;
    public GameObject nextlevel;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("entered");
        if (collision.CompareTag("Player"))
        {
            currentlevel.SetActive(false);
            nextlevel.SetActive(true);

        }

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
