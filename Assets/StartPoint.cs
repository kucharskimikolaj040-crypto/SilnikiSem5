using UnityEngine;

public class StartPoint : Checkpoint
{
    public void Start()
    {
        GameObject player = GameObject.Find("Player");
        player.transform.position = transform.position;
    }
}
