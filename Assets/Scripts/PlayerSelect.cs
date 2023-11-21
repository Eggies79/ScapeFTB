using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSelect : MonoBehaviour
{
    public bool enableSelectCharacter;
    public enum Player {Astro, Bolo, Red}
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
                case Player.Astro:
                    spriteRenderer.sprite = playersSprite[0];
                    animator.runtimeAnimatorController = playersController[0];
                    break;
                case Player.Bolo:
                    spriteRenderer.sprite = playersSprite[1];
                    animator.runtimeAnimatorController = playersController[1];
                    break;
                case Player.Red:
                    spriteRenderer.sprite = playersSprite[2];
                    animator.runtimeAnimatorController = playersController[2];
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
            case "Astro":
                spriteRenderer.sprite = playersSprite[0];
                animator.runtimeAnimatorController = playersController[0];
                break;
            case "Bolo":
                spriteRenderer.sprite = playersSprite[1];
                animator.runtimeAnimatorController = playersController[1];
                break;
            case "Red":
                spriteRenderer.sprite = playersSprite[2];
                animator.runtimeAnimatorController = playersController[2];
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
