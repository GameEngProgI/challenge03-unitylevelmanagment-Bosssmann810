using UnityEngine;


public class levelchangetrigger : MonoBehaviour
{
    public GameObject player;
    private bool transitionlockedstate;
    public LevelManager _levelManager;
    public GameObject _levelToActivate;
    public Transform _spawnLocal;
    public GameObject _currentLevel;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = SurviceHub.Instance.playerController.gameObject;
        _levelManager = SurviceHub.Instance.levelManager;
    }
    private void OnEnable()
    {
        transitionlockedstate = GetComponent<Collider2D>().OverlapPoint(player.transform.position);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("entered");
        if (collision.CompareTag("Player") && transitionlockedstate == false)
        {
            _levelManager.levelchange(_levelToActivate, _spawnLocal);

        }

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("player"))
        {
            transitionlockedstate = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
