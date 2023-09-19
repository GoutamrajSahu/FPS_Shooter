using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathHandler : MonoBehaviour
{
    [SerializeField] Canvas GameOverCanves;

    private void Start()
    {
        GameOverCanves.enabled = false;
    }

    public void HandleDeath(bool boolval = true)
    {
        GameOverCanves.enabled = boolval;
        Time.timeScale = 0;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
