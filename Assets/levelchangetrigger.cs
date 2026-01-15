using UnityEngine;


public class levelchangetrigger : MonoBehaviour
{

    public LevelManager levelmanager; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        levelmanager = SurviceHub.Instance.levelManager;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("entered");
        if (collision.CompareTag("Player"))
        {
            levelmanager.levelchange();

        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
