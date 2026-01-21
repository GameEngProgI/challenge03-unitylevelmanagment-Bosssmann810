using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public Transform playerlocation;

    public void levelchange(GameObject leveltoload, Transform spawn, GameObject leveltodespawn)
    {
        leveltodespawn.SetActive(false);
        leveltoload.SetActive(true);
        playerlocation.position = spawn.position;
    }
}
