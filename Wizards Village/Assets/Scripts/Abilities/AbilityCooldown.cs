using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AbilityCooldown : MonoBehaviour
{
    [SerializeField]
    private Image imageCooldown;
    [SerializeField]
    private TMP_Text textCooldown;
    public bool isActive = false;
    public Sprite icon;

    public bool isCooldown = false;
    public float cooldownTime = 10f;
    private float cooldownTimer = 0f;

    // Start is called before the first frame update
    void Start()
    {
        textCooldown = transform.GetComponentInChildren<TMP_Text>();
        //Set the cooldown timer to not be seen
        textCooldown.gameObject.SetActive(false);

        //Sets the image cooldown visual to be disabled
        imageCooldown.fillAmount = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        //This will set the ability icon to the respective Ability
        //this.GetComponent<Image>().sprite = icon;
        
        //While something is on cooldown do this
        if(isCooldown)
        {
            ApplyCooldown();
        }
    }
    public void ApplyCooldown()
    {
        //reduce the cooldown
        cooldownTimer -= Time.deltaTime;

        //Do this when the cooldown timer runs out
        if(cooldownTimer < 0.0f)
        {
            isCooldown = false;
            textCooldown.gameObject.SetActive(false);
            imageCooldown.fillAmount = 0.0f;
        }
        else
        {
            textCooldown.text = Mathf.RoundToInt(cooldownTimer).ToString();
            imageCooldown.fillAmount = cooldownTimer / cooldownTime;
        }
    }
    public void UseSpell(float cooldown)
    {
        cooldownTime = cooldown;
        if(isCooldown)
        {
            //user has clicked spell while on cooldown
        }
        else
        {
            isCooldown = true;
            textCooldown.gameObject.SetActive(true);
            cooldownTimer = cooldownTime;
        }
    }

}
