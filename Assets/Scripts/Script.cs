using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using UnityEngine;
using UnityEngine.UI;


public class Script : MonoBehaviour
{
    public Sprite sprite1;
    public Sprite sprite2;
    public Sprite sprite3;
    public Sprite sprite4;
    public Sprite sprite5;
    public Sprite sprite6;
    public Sprite sprite7;
    public Sprite sprite8;
    public Sprite sprite9;
    public Sprite sprite10;
    public Sprite sprite11;
    public Sprite sprite12;
    public Sprite sprite13;
    public Sprite sprite14;
    public Sprite sprite15;
    public Sprite sprite16;
    public Sprite sprite17;
    public Sprite sprite18;
    public Sprite sword1;
    public Sprite sword2;
    public Sprite sword3;
    public Sprite sword4;
    public Sprite sword5;
    public Sprite sword6;
    public Sprite sword7;
    public Sprite sword8;
    public Sprite sword9;
    public Sprite sword10;
    public Sprite sword11;
    public Sprite sword12;
    public Sprite sword13;
    public Sprite sword14;
    public Sprite sword15;
    public Sprite sword16;
    public Sprite sword17;
    public Sprite sword18;
    public Sprite sword19;
    public Sprite sword20;
    public GameObject swordimg;
    public GameObject enemyimg;
    public Button enemy;
    public Button buy;
    public Button next;
    public Button back;
    public Text price;
    public bool clicking;
    public int duration = 3;
    public int timeRemaining;
    public bool isCountingDown = false;
    public int dmg;
    public Text damage;
    public bool dead = false;
    public int duration2;
    public int timeRemaining2 = 3;
    public bool isCountingDown2 = false;
    public int duration3;
    public int timeRemaining3;
    public bool isCountingDown3 = false;
    public int duration4;
    public int timeRemaining4;
    public bool isCountingDown4 = false;
    public int duration5;
    public int timeRemaining5;
    public bool isCountingDown5 = false;
    public int duration6;
    public int timeRemaining6;
    public bool isCountingDown6 = false;
    public int sword;
    public Text dmgtext;
    public bool swordowning1=true;
    public bool swordowning2 = false;
    public bool swordowning3 = false;
    public bool swordowning4 = false;
    public bool swordowning5 = false;
    public bool swordowning6 = false;
    public bool swordowning7 = false;
    public bool swordowning8 = false;
    public bool swordowning9 = false;
    public bool swordowning10 = false;
    public bool swordowning11 = false;
    public bool swordowning12 = false;
    public bool swordowning13 = false;
    public bool swordowning14 = false;
    public bool swordowning15 = false;
    public bool swordowning16 = false;
    public bool swordowning17 = false;
    public bool swordowning18 = false;
    public bool swordowning19 = false;
    public bool swordowning20 = false;
    public int swordprice;
    public int money=0;
    public Text moneyText;
    public int enemycount;
    public Button next2;
    public Button back2;
    public bool bool1;
    public bool enemy1owning;
    public bool enemy2owning;
    public bool enemy3owning;
    public bool enemy4owning;
    public bool enemy5owning;
    public bool enemy6owning;
    public int sword1price;
    public int sword2price;
    public int sword3price;
    public int sword4price;
    public int sword5price;
    public int sword6price;
    public int sword7price;
    public int sword8price;
    public int sword9price;
    public int sword10price;
    public int sword11price;
    public int sword12price;
    public int sword13price;
    public int sword14price;
    public int sword15price;
    public int sword16price;
    public int sword17price;
    public int sword18price;
    public int sword19price;
    public int sword20price;
    void Start()
    {
        enemycount = 1;
        sword = 1;
        dmg = 10;
        enemy.onClick.AddListener(enemyclick);
        next.onClick.AddListener(nextvoid);
        back.onClick.AddListener(backvoid);
        buy.onClick.AddListener(buyvoid);
        next2.onClick.AddListener(next2void);
        back2.onClick.AddListener(back2void);
        duration = 1;
        bool1 = false;
        enemy1owning=true;
    enemy2owning=false;
     enemy3owning=false;
     enemy4owning=false;
    enemy5owning=false;
        enemy6owning = false;
        sword1price = 0;       
sword2price=1000;
   sword3price=2500;
sword4price=5000;
    sword5price=10000;
 sword6price=25000;
sword7price=50000;
sword8price=75000;
sword9price=100000;
sword10price=125000;
sword11price=150000;
 sword12price=200000;
 sword13price=250000;
 sword14price=350000;
 sword15price=450000;
 sword16price=600000;
  sword17price=750000;
 sword18price=1000000;
 sword19price=2500000;
 sword20price=5000000;


}

    void enemyclick()
    {
      
        switch (enemycount)
        {
            case 1:
                if (!isCountingDown)
                {
                    isCountingDown = true;
                    timeRemaining = duration;
                    Invoke("_tick", 1f);
                    enemyimg.GetComponent<Image>().sprite = sprite2;
                    bool1 = false;
                }
                if (bool1 == true)
                {
                    enemyimg.GetComponent<Image>().sprite = sprite3;
                }
                break;
            case 2:
                if (!isCountingDown)
                {
                    isCountingDown = true;
                    timeRemaining = duration;
                    Invoke("_tick", 1f);
                    enemyimg.GetComponent<Image>().sprite = sprite5;
                    bool1 = false;
                }
                if (bool1 == true)
                {
                    enemyimg.GetComponent<Image>().sprite = sprite6;
                }
                break;
            case 3:
                if (!isCountingDown)
                {
                    isCountingDown = true;
                    timeRemaining = duration;
                    Invoke("_tick", 1f);
                    enemyimg.GetComponent<Image>().sprite = sprite8;
                    bool1 = false;
                }
                if (bool1 == true)
                {
                    enemyimg.GetComponent<Image>().sprite = sprite9;
                }
                break;
            case 4:
                if (!isCountingDown)
                {
                    isCountingDown = true;
                    timeRemaining = duration;
                    Invoke("_tick", 1f);
                    enemyimg.GetComponent<Image>().sprite = sprite11;
                    bool1 = false;
                }
                if (bool1 == true)
                {
                    enemyimg.GetComponent<Image>().sprite = sprite12;
                }
                break;
            case 5:
                if (!isCountingDown)
                {
                    isCountingDown = true;
                    timeRemaining = duration;
                    Invoke("_tick", 1f);
                    enemyimg.GetComponent<Image>().sprite = sprite14;
                    bool1 = false;
                }
                if (bool1 == true)
                {
                    enemyimg.GetComponent<Image>().sprite = sprite15;
                }
                break;
            case 6:
                if (!isCountingDown)
                {
                    isCountingDown = true;
                    timeRemaining = duration;
                    Invoke("_tick", 1f);
                    enemyimg.GetComponent<Image>().sprite = sprite17;
                    bool1 = false;
                }
                if (bool1 == true)
                {
                    enemyimg.GetComponent<Image>().sprite = sprite18;
                }
                break;
        }







        money += dmg;


    }
    void nextvoid()
    {
        switch (sword)
        {
            case 1:
                swordimg.GetComponent<Image>().sprite = sword2;
                sword = 2;
                swordprice = 1000;
                if (swordowning2==true)
                {
                    dmg = dmg * 2;
                }
                break;
            case 2:
                swordimg.GetComponent<Image>().sprite = sword3;
                sword = 3;
                swordprice = 2500;
                if (swordowning3 == true)
                {
                    dmg = dmg * 2;
                }
                break;
            case 3:
                swordimg.GetComponent<Image>().sprite = sword4;
                sword = 4;
                swordprice = 5000;
                if (swordowning4 == true)
                {
                    dmg = dmg * 2;
                }
                break;
            case 4:
                swordimg.GetComponent<Image>().sprite = sword5;
                sword = 5;
                swordprice = 10000;
                if (swordowning5 == true)
                {
                    dmg = dmg * 2;
                }
                break;
            case 5:
                swordimg.GetComponent<Image>().sprite = sword6;
                sword = 6;
                swordprice = 25000;
                if (swordowning6 == true)
                {
                    dmg = dmg * 2;
                }
                break;
            case 6:
                swordimg.GetComponent<Image>().sprite = sword7;
                sword = 7;
                swordprice = 50000;
                if (swordowning7 == true)
                {
                    dmg = dmg * 2;
                }
                break;
            case 7:
                swordimg.GetComponent<Image>().sprite = sword8;
                sword = 8;
                swordprice = 75000;
                if (swordowning8 == true)
                {
                    dmg = dmg * 2;
                }
                break;
            case 8:
                swordimg.GetComponent<Image>().sprite = sword9;
                sword = 9;
                swordprice = 100000;
                if (swordowning9 == true)
                {
                    dmg = dmg * 2;
                }
                break;
            case 9:
                swordimg.GetComponent<Image>().sprite = sword10;
                sword = 10;
                swordprice = 125000;
                if (swordowning10 == true)
                {
                    dmg = dmg * 2;
                }
                break;
            case 10:
                swordimg.GetComponent<Image>().sprite = sword11;
                sword = 11;
                swordprice = 150000;
                if (swordowning11 == true)
                {
                    dmg = dmg * 2;
                }
                break;
            case 11:
                swordimg.GetComponent<Image>().sprite = sword12;
                sword = 12;
                swordprice = 200000;
                if (swordowning12 == true)
                {
                    dmg = dmg * 2;
                }
                break;
            case 12:
                swordimg.GetComponent<Image>().sprite = sword13;
                sword = 13;
                swordprice = 250000;
                if (swordowning13 == true)
                {
                    dmg = dmg * 2;
                }
                break;
            case 13:
                swordimg.GetComponent<Image>().sprite = sword14;
                sword = 14;
                swordprice = 350000;
                if (swordowning14 == true)
                {
                    dmg = dmg * 2;
                }
                break;
            case 14:
                swordimg.GetComponent<Image>().sprite = sword15;
                sword = 15;
                swordprice = 450000;
                if (swordowning15 == true)
                {
                    dmg = dmg * 2;
                }
                break;
            case 15:
                swordimg.GetComponent<Image>().sprite = sword16;
                sword = 16;
                swordprice = 600000;
                if (swordowning16 == true)
                {
                    dmg = dmg * 2;
                }
                break;
            case 16:
                swordimg.GetComponent<Image>().sprite = sword17;
                sword = 17;
                swordprice = 750000;
                if (swordowning17 == true)
                {
                    dmg = dmg * 2;
                }
                break;
            case 17:
                swordimg.GetComponent<Image>().sprite = sword18;
                sword = 18;
                swordprice = 1000000;
                if (swordowning18 == true)
                {
                    dmg = dmg * 2;
                }
                break;
            case 18:
                swordimg.GetComponent<Image>().sprite = sword19;
                sword = 19;
                swordprice = 2500000;
                if (swordowning19 == true)
                {
                    dmg = dmg * 2;
                }
                break;
            case 19:
                swordimg.GetComponent<Image>().sprite = sword20;
                sword = 20;
                swordprice = 5000000;
                if (swordowning20 == true)
                {
                    dmg = dmg * 2;
                }
                break;
            case 20:
                swordimg.GetComponent<Image>().sprite = sword20;
                sword = 20;
                swordprice = 5000000;
                if (swordowning20 == true)
                {
                    dmg = 5242880;
                }
                
                break;
        }
    }
    void buyvoid()
    {
        switch (sword)
        {
            case 1:
                
                if (money >= swordprice)
                {
                    swordprice += sword1price;
                    money -= swordprice;
                }
                swordowning1 = true;
                break;
            case 2:
                
                if (swordowning2 == false)
                {
                    
                    if (money >= swordprice)
                    {
                        
                        swordowning2 = true;
                        dmg *= 2;
                    }

                    if (swordowning2 == true)
                    {
                        swordprice = 0;
                    }
                }
                break;
            case 3:
                
                if (swordowning3 == false)
                {
                    
                    if (money >= swordprice)
                    {
                        money -= swordprice;
                        swordowning3 = true;
                        dmg *= 2;
                    }

                    if (swordowning3 == true)
                    {
                        swordprice = 0;
                    }
                }

                break;
            case 4:
                
                if (money >= swordprice)
                {
                    
                    money -= swordprice;
                    swordowning4 = true;
                    dmg *= 2;
                }

                if (swordowning4 == true)
                {
                    swordprice = 0;
                }

                break;
            case 5:
                
                if (money >= swordprice)
                {
                    
                    money -= swordprice;
                    swordowning5 = true;
                    dmg *= 2;
                }

                if (swordowning5 == true)
                {
                    swordprice = 0;
                }
                break;
            case 6:
                
                if (money >= swordprice)
                {
                   
                    money -= swordprice;
                    swordowning6 = true;
                    dmg *= 2;
                }

                if (swordowning6 == true)
                {
                    swordprice = 0;
                }
                break;
            case 7:
                
                if (money >= swordprice)
                {
                    
                    money -= swordprice;
                    swordowning7 = true;
                    dmg *= 2;
                }

                if (swordowning7 == true)
                {
                    swordprice = 0;
                }
                break;
            case 8:
                
                if (money >= swordprice)
                {
                   
                    money -= swordprice;
                    swordowning8 = true;
                    dmg *= 2;
                }

                if (swordowning8 == true)
                {
                    swordprice = 0;
                }
                break;
            case 9:
                
                if (money >= swordprice)
                {
                    
                    money -= swordprice;
                    swordowning9 = true;
                    dmg *= 2;
                }

                if (swordowning9 == true)
                {
                    swordprice = 0;
                }
                break;
            case 10:
                
                if (money >= swordprice)
                {
                   
                    money -= swordprice;
                    swordowning10 = true;
                    dmg *= 2;
                }

                if (swordowning10 == true)
                {
                    swordprice = 0;
                }
                break;
            case 11:
               
                if (money >= swordprice)
                {
                    
                    money -= swordprice;
                    swordowning11 = true;
                    dmg *= 2;
                }

                if (swordowning11 == true)
                {
                    swordprice = 0;
                }
                break;
            case 12:
                
                if (money >= swordprice)
                {
                   
                    money -= swordprice;
                    swordowning12 = true;
                    dmg *= 2;
                }

                if (swordowning12 == true)
                {
                    swordprice = 0;
                }
                break;
            case 13:
                
                if (money >= swordprice)
                {
                    
                    money -= swordprice;
                    swordowning13 = true;
                    dmg *= 2;
                }

                if (swordowning13 == true)
                {
                    swordprice = 0;
                }
                break;
            case 14:
               
                if (money >= swordprice)
                {
                   
                    money -= swordprice;
                    swordowning14 = true;
                    dmg *= 2;
                }

                if (swordowning14 == true)
                {
                    swordprice = 0;
                }
                break;
            case 15:
                
                if (money >= swordprice)
                {
                    
                    money -= swordprice;
                    swordowning15 = true;
                    dmg *= 2;
                }

                if (swordowning15 == true)
                {
                    swordprice = 0;
                }
                break;
            case 16:
                
                if (money >= swordprice)
                {
                    
                    money -= swordprice;
                    swordowning16 = true;
                    dmg *= 2;
                }

                if (swordowning16 == true)
                {
                    swordprice = 0;
                }
                break;
            case 17:
                
                if (money >= swordprice)
                {
                    
                    money -= swordprice;
                    swordowning17 = true;
                    dmg *= 2;
                }

                if (swordowning17 == true)
                {
                    swordprice = 0;
                }
                break;
            case 18:
                
                if (money >= swordprice)
                {
                    
                    money -= swordprice;
                    swordowning18 = true;
                    dmg *= 2;
                }

                if (swordowning18 == true)
                {
                    swordprice = 0;
                }
                break;
            case 19:
               
                if (money >= swordprice)
                {
                    
                    money -= swordprice;
                    swordowning19 = true;
                    dmg *= 2;
                }

                if (swordowning19 == true)
                {
                    swordprice = 0;
                }
                break;
            case 20:
                
                if (money >= swordprice)
                {
                   
                    money -= swordprice;
                    swordowning20 = true;
                    dmg *= 2;
                }

                if (swordowning20 == true)
                {
                    swordprice = 0;
                }
                break;

        }
        switch (enemycount)
        {
            case 1:
                
                break;
            case 2:
                if (money >= swordprice)
                {
                    money -= swordprice;
                    enemy2owning = true;
                }
                break;
            case 3:
                if (money >= swordprice)
                {
                    money -= swordprice;
                    enemy3owning = true;
                }
                break;
            case 4:
                if (money >= swordprice)
                {
                    money -= swordprice;
                    enemy4owning = true;
                }
                break;
            case 5:
                if (money >= swordprice)
                {
                    money -= swordprice;
                    enemy5owning = true;
                }
                break;
            case 6:
                if (money >= swordprice)
                {
                    money -= swordprice;
                    enemy6owning = true;
                }
                break;
            
        }

    }
    void backvoid()
    {
        switch (sword)
        {
            case 1:
                swordimg.GetComponent<Image>().sprite = sword1;
                sword = 1;
               
                
                break;
            case 2:
                swordimg.GetComponent<Image>().sprite = sword1;
                sword = 1;
                if (swordowning2==true)
                {
                    dmg = dmg / 2;

                }
                swordprice = sword1price;
                break;
                
            case 3:
                swordimg.GetComponent<Image>().sprite = sword2;
                sword = 2;
                if (swordowning3 == true)
                {
                    dmg = dmg / 2;

                }
                swordprice -=sword2price;
                break;
            case 4:
                swordimg.GetComponent<Image>().sprite = sword3;
                sword = 3;
                if (swordowning4 == true)
                {
                    dmg = dmg / 2;

                }
                swordprice = sword3price;
                break;
            case 5:
                swordimg.GetComponent<Image>().sprite = sword4;
                sword = 4;
                if (swordowning5 == true)
                {
                    dmg = dmg / 2;

                }
                swordprice -=sword4price;
                break;
            case 6:
                swordimg.GetComponent<Image>().sprite = sword5;
                sword = 5;
                if (swordowning6 == true)
                {
                    dmg = dmg / 2;

                }
                swordprice -=sword5price;
                break;
            case 7:
                swordimg.GetComponent<Image>().sprite = sword6;
                sword = 6;
                if (swordowning7 == true)
                {
                    dmg = dmg / 2;

                }
                swordprice -=sword6price;
                break;
            case 8:
                swordimg.GetComponent<Image>().sprite = sword7;
                sword = 7;
                if(swordowning8 == true)
                {
                    dmg = dmg / 2;

                }
                swordprice -=sword7price;
                break;
            case 9:
                swordimg.GetComponent<Image>().sprite = sword8;
                sword = 8;
                if (swordowning9 == true)
                {
                    dmg = dmg / 2;

                }
                swordprice -=sword8price;
                break;
            case 10:
                swordimg.GetComponent<Image>().sprite = sword9;
                sword = 9;
                if (swordowning10 == true)
                {
                    dmg = dmg / 2;

                }
                swordprice -=sword9price;
                break;
            case 11:
                swordimg.GetComponent<Image>().sprite = sword10;
                sword = 10;
                if (swordowning11 == true)
                {
                    dmg = dmg / 2;

                }
                swordprice -=sword10price;
                break;
            case 12:
                swordimg.GetComponent<Image>().sprite = sword11;
                sword = 11;
                if (swordowning12 == true)
                {
                    dmg = dmg / 2;

                }
                swordprice -=sword11price;
                break;
            case 13:
                swordimg.GetComponent<Image>().sprite = sword12;
                sword = 12;
                if (swordowning13 == true)
                {
                    dmg = dmg / 2;

                }
                swordprice -=sword12price;
                break;
            case 14:
                swordimg.GetComponent<Image>().sprite = sword13;
                sword = 13;
                if (swordowning14 == true)
                {
                    dmg = dmg / 2;

                }
                swordprice -= sword13price;
                break;
            case 15:
                swordimg.GetComponent<Image>().sprite = sword14;
                sword = 14;
                if(swordowning15 == true)
                {
                    dmg = dmg / 2;

                }
                swordprice -=sword14price;
                break;
            case 16:
                swordimg.GetComponent<Image>().sprite = sword15;
                sword = 15;
                if (swordowning16 == true)
                {
                    dmg = dmg / 2;

                }
                swordprice -=sword15price;
                break;
            case 17:
                swordimg.GetComponent<Image>().sprite = sword16;
                sword = 16;
                if (swordowning17 == true)
                {
                    dmg = dmg / 2;

                }
                swordprice -=sword16price;
                break;
            case 18:
                swordimg.GetComponent<Image>().sprite = sword17;
                sword = 17;
                if (swordowning18 == true)
                {
                    dmg = dmg / 2;

                }
                swordprice -=sword17price;
                break;
            case 19:
                swordimg.GetComponent<Image>().sprite = sword18;
                sword = 18;
                if (swordowning19 == true)
                {
                    dmg = dmg / 2;

                }
                swordprice -=sword18price;
                break;
            case 20:
                swordimg.GetComponent<Image>().sprite = sword19;
                sword = 19;
                if (swordowning20 == true)
                {
                    dmg = dmg / 2;

                }
                swordprice -=sword19price;
                break;
        }
        }
    void next2void()
    {
        switch (enemycount)
        {
            case 1:
                enemyimg.GetComponent<Image>().sprite = sprite4;
                enemycount = 2;
                if (enemy2owning==true)
                {
                    dmg *= 2;
                }
                swordprice += 10000;
                break;
            case 2:
                enemyimg.GetComponent<Image>().sprite = sprite7;
                enemycount = 3;
                if (enemy3owning == true)
                {
                    dmg *= 2;
                }
                swordprice += 50000;
                break;
            case 3:
                enemyimg.GetComponent<Image>().sprite = sprite10;
                enemycount = 4;
                if (enemy4owning == true)
                {
                    dmg *= 2;
                }
                swordprice += 100000;
                break;
            case 4:
                enemyimg.GetComponent<Image>().sprite = sprite13;
                enemycount = 5;
                if (enemy5owning == true)
                {
                    dmg *= 2;
                }
                swordprice += 500000;
                break;
            case 5:
                enemyimg.GetComponent<Image>().sprite = sprite16;
                enemycount = 6;
                if (enemy6owning == true)
                {
                    dmg *= 2;
                }
                swordprice += 1000000;
                break;
        }
    }
    void back2void()
    {
        switch (enemycount)
        {
            case 1:
                enemyimg.GetComponent<Image>().sprite = sprite1;
                enemycount = 1;
                if (enemy1owning == true)
                {
                    
                }
                
                break;
            case 2:
                enemyimg.GetComponent<Image>().sprite = sprite1;
                enemycount = 1;
                if (enemy2owning == true)
                {
                    dmg /= 2;
                    
                }
                swordprice -= 10000;
                
                
                break;
            case 3:
                enemyimg.GetComponent<Image>().sprite = sprite4;
                enemycount = 2;
                if (enemy3owning == true)
                {
                    dmg /= 2;
                    
                }
                swordprice -= 50000;

                break;
            case 4:
                enemyimg.GetComponent<Image>().sprite = sprite7;
                enemycount = 3;
                if (enemy5owning == true)
                {
                    dmg /= 2;
                    
                }
                swordprice -= 100000;
                break;
            case 5:
                enemyimg.GetComponent<Image>().sprite = sprite10;
                enemycount = 4;
                if (enemy6owning == true)
                {
                    dmg /= 2;
                    
                }
                swordprice -= 500000;
                break;
            case 6:
                enemyimg.GetComponent<Image>().sprite = sprite13;
                enemycount = 5;
                if (enemy6owning == true)
                {
                    dmg /= 2;
                    
                }
                swordprice -= 1000000;
                break;
        }
    }
    private void _tick()
    {
        timeRemaining--;
        if (timeRemaining > 0)
        {
            Invoke("_tick", 1f);
        }
        else
        {
            isCountingDown = false;
        }
    }
    private void _tick2()
    {
        timeRemaining2--;
        if (timeRemaining2 > 0)
        {
            Invoke("_tick2", 1f);
        }
        else
        {
            isCountingDown2 = false;
        }
    }
    private void _tick3()
    {
        timeRemaining3--;
        if (timeRemaining3 > 0)
        {
            Invoke("_tick3", 1f);
        }
        else
        {
            isCountingDown3 = false;
        }
    }
    private void _tick4()
    {
        timeRemaining4--;
        if (timeRemaining4 > 0)
        {
            Invoke("_tick4", 1f);
        }
        else
        {
            isCountingDown4 = false;
        }
    }
    private void _tick5()
    {
        timeRemaining5--;
        if (timeRemaining5 > 0)
        {
            Invoke("_tick5", 1f);
        }
        else
        {
            isCountingDown5 = false;
        }
    }
    private void _tick6()
    {
        timeRemaining6--;
        if (timeRemaining6 > 0)
        {
            Invoke("_tick6", 1f);
        }
        else
        {
            isCountingDown6 = false;
        }
    }
    void Update()
    {
        if (timeRemaining <= 0 && enemycount == 1)
        {
            enemyimg.GetComponent<Image>().sprite = sprite1;
            isCountingDown = false;
        }
        if (timeRemaining <= 0 && enemycount == 2)
        {
            enemyimg.GetComponent<Image>().sprite = sprite4;
            isCountingDown = false;
        }
        if (timeRemaining <= 0 && enemycount == 3)
        {
            enemyimg.GetComponent<Image>().sprite = sprite7;
            isCountingDown = false;
        }
        if (timeRemaining <= 0 && enemycount == 4)
        {
            enemyimg.GetComponent<Image>().sprite = sprite10;
            isCountingDown = false;
        }
        if (timeRemaining <= 0 && enemycount == 5)
        {
            enemyimg.GetComponent<Image>().sprite = sprite13;
            isCountingDown = false;
        }
        if (timeRemaining <= 0 && enemycount == 6)
        {
            enemyimg.GetComponent<Image>().sprite = sprite16;
            isCountingDown = false;
        }
        dmgtext.text = Convert.ToString(dmg);
        moneyText.text = Convert.ToString(money);
        price.text = Convert.ToString(swordprice);
        bool1 = true;

    }
   
}