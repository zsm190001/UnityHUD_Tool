using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro; //you need it dumbA for TMP stuff

public class Player_Test : MonoBehaviour
{
    [Header("General Bar Stats")]
    //variables for max & current health/mp/energy
    [SerializeField] private int maxHealth = 10; //health
    private int currentHealth;
    [SerializeField] private int maxMP = 10; //mp
    private int currentMP;
    [SerializeField] private int maxEnergy = 10; //energy
    private int currentEnergy;
    [SerializeField] private int maxXP = 100; //xp
    private int startingXP = 0;
    private int currentXP;
    public int playerLevel = 1;

    //link other scripts for variables & field to drag into
    public HealthBar healthBar;
    public MPBar mpBar;
    public EnergyBar energyBar;
    public XPBar xpBar;

//TMP Progres Bars stuff
    //TMP progress bar current values
    [Header("Progress Bar Current Values Text Bar")]
        [SerializeField] private TextMeshProUGUI levelNumberText; //TMP uses TextMeshProUGUI SMH DumbA
        [SerializeField] private TextMeshProUGUI hpNumberText;
        [SerializeField] private TextMeshProUGUI mpNumberText;
        [SerializeField] private TextMeshProUGUI energyNumberText;
        [SerializeField] private TextMeshProUGUI xpNumberText;
    //TMP progress bar max values
    [Header("Progress Bar Out-Of Values")]
        [SerializeField] private TextMeshProUGUI hpMaxNumberText;
        [SerializeField] private TextMeshProUGUI mpMaxNumberText;
        [SerializeField] private TextMeshProUGUI energyMaxNumberText;
        [SerializeField] private TextMeshProUGUI xpMaxNumberText;

    // Start is called before the first frame update
    void Start() 
    {
        //set max health & health bar to max health
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        //set max MP & MP bar to max MP
        currentMP = maxMP;
        mpBar.SetMaxMP(maxMP);
        //set max energy & energy bar to max energy
        currentEnergy = maxEnergy;
        energyBar.SetMaxEnergy(maxEnergy);

        currentXP = startingXP;
        xpBar.SetXP(startingXP);
    }
    
    // Update is called once per frame
    void Update()
    {
        
    //Progress Bar Testing
        //Test Decreases
        //test decrease health bar
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(1);
        }
        //test decrease MP bar
        if (Input.GetKeyDown(KeyCode.M))
        {
            TakeMP(1);
        }
        //test decrease energy bar
        if (Input.GetKeyDown(KeyCode.E))
        {
            TakeEnergy(1);
        }

    //Test Increases
        //test increase health bar
        if (Input.GetKeyDown(KeyCode.H))
        {
            GiveHealth(1);
        }
        //test increase MP bar
        if (Input.GetKeyDown(KeyCode.N))
        {
            GiveMP(1);
        }
        //test increase energy bar
        if (Input.GetKeyDown(KeyCode.W))
        {
            GiveEnergy(1);
        }
        //test increase xp bar
        if (Input.GetKeyDown(KeyCode.X))
        {
            GiveXP(5);
            
        }

        //set current Number/values(?) txt of progress bars to slider values "?/Max #"
        hpNumberText.text = healthBar.slider.value.ToString("");
        mpNumberText.text = mpBar.slider.value.ToString("");
        energyNumberText.text = energyBar.slider.value.ToString("");
        xpNumberText.text = xpBar.slider.value.ToString("");

        //set max number values(?) txt of progress bars "#/?"
        hpMaxNumberText.text = healthBar.slider.maxValue.ToString("");
        mpMaxNumberText.text = mpBar.slider.maxValue.ToString("");
        energyMaxNumberText.text = energyBar.slider.maxValue.ToString("");
        xpMaxNumberText.text = xpBar.slider.maxValue.ToString("");
    }

    void TakeDamage(int hp)
    {
        currentHealth -= hp;
        healthBar.SetHealth(currentHealth);
    }

    void TakeMP(int mp)
    {
        currentMP -= mp;
        mpBar.SetMP(currentMP);
    }

    void TakeEnergy(int energy)
    {
        currentEnergy -= energy;
        energyBar.SetEnergy(currentEnergy);
    }

    void GiveHealth(int hp)
    {
        currentHealth += hp;
        healthBar.SetHealth(currentHealth);
    }

    void GiveMP(int mp)
    {
        currentMP += mp;
        mpBar.SetMP(currentMP);
    }

    void GiveEnergy(int energy)
    {
        currentEnergy += energy;
        energyBar.SetEnergy(currentEnergy);
    }

    void GiveXP(int xp)
    {
        currentXP += xp;
        xpBar.SetXP(currentXP);
        //level up if xp reqs met
        if (currentXP >= maxXP)
        {
            playerLevel++;
            levelNumberText.text = playerLevel.ToString("");
            currentXP = 0;
            maxXP *= playerLevel;
        }
    }
}
