using UnityEngine;


public class levelchangetrigger : MonoBehaviour
{

    public LevelManager _levelManager;
    public GameObject _levelToActivate;
    public Transform _spawnLocal;
    public GameObject _currentLevel;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _levelManager = SurviceHub.Instance.levelManager;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("entered");
        if (collision.CompareTag("Player"))
        {
            _levelManager.levelchange(_levelToActivate, _spawnLocal, _currentLevel);

        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
