using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSelect : MonoBehaviour
{
    public bool enableSelectCharacter;
    public enum Player {Astronaut, Scp}
    public Player playerSelected;   

    public Animator animator;
    public SpriteRenderer spriteRenderer;

    public RuntimeAnimatorController[] playersController;
    public Sprite[] playersSprite;

    // Start is called before the first frame update
    void Start()
    {
        if (!enableSelectCharacter)
        {
            ChangePlayerInMenu();
        }
        else
        {
            switch (playerSelected)
            {
                case Player.Astronaut:
                    spriteRenderer.sprite = playersSprite[0];
                    animator.runtimeAnimatorController = playersController[0];
                    break;
                case Player.Scp:
                    spriteRenderer.sprite = playersSprite[1];
                    animator.runtimeAnimatorController = playersController[1];
                    break;
                default:
                    break;
            }
        }
        
    }

    public void ChangePlayerInMenu()
    {
        switch (PlayerPrefs.GetString("PlayerSelected"))
        {
            case "Astronaut":
                spriteRenderer.sprite = playersSprite[0];
                animator.runtimeAnimatorController = playersController[0];
                break;
            case "SCP":
                spriteRenderer.sprite = playersSprite[1];
                animator.runtimeAnimatorController = playersController[1];
                break;
            default:
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
