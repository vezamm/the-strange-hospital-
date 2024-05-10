using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Uiscripts : MonoBehaviour
{
    [SerializeField] GameObject pausemenu;
    [SerializeField] GameObject pauseButton;
    [SerializeField] Playermove playermovescript;
    [SerializeField] GameObject Inventory;
    [SerializeField] manager inventorymanager;
    private bool cursorlock=true;
    public void pause()
    {
        pausemenu.SetActive(true);
        pauseButton.SetActive(false);
        Time.timeScale = 0;

    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            playermovescript.ToggleMovement();
            pause();
            Cursor.lockState = CursorLockMode.None;
        }
        openinventory();


    }
    
    private void Inventoryonoroff()
    {
        if (Inventory != null)
        {
            Inventory.SetActive(!Inventory.activeSelf);
        }
    }
    public void curlock()
    {
            Cursor.lockState = CursorLockMode.Locked;
    }
    public void openinventory()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            Cursor.lockState = CursorLockMode.None;
            Inventoryonoroff();
            inventorymanager.ListItem();

        }
    }
}