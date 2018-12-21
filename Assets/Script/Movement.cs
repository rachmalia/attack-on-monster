using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Movement : MonoBehaviour {
    public GameObject karakter;
    public GameObject karakter2;
    private bool isKarakter2 = false;
    public GameObject point0, point1, point2, point3, point4, point5, point6, point7, point8, point9, point10, point11, point12, point13, point14, point15, point16, point17, point18, point19, point20, point21, point22, point23, point24, point25, point26, point27, point28, point29, point30, point31, point32, point33, point34, point35, point36, point37, point38, point39, point40, point41, point42, point43, point44, point45, point46, point47, point48, point49, point50, point51, point52, point53, point54, point55, point56, point57, point58, point59, point60, point61, point62, point63;
    private int[] pointCard;
    public GameObject card;
    public Sprite fish, goblin, golem, hydra, kraken, minotour, def;
    private int hpKarakter1, hpKarakter2, scoreKarakter1, scoreKarakter2;
    public GameObject goHpKarakter1, goHpKarakter2, goScoreKarakter1, goScoreKarakter2;
    public GameObject stat;

    public void PindahScene(string winner)
    {
        stat.GetComponent<TMPro.TMP_Text>().text = winner;

    }
    
    // Use this for initialization
    void Start () {
        pointCard = new int[64];
        for(int i = 0; i < pointCard.Length; i++)
        {
            pointCard[i] = 0;
        }
        hpKarakter1 = 30;
        hpKarakter2 = 30;
        scoreKarakter1 = 0;
        scoreKarakter2 = 0;
	}
	
	// Update is called once per frame
	void Update () {
        if (Dice.finalSide!=0)
        {
            setColor(getPosition(),255f);
            click(Dice.finalSide,getPosition());
        }  
        //karakter.transform.position = point.transform.position;
    }
    
    private int getPosition()
    {
        GameObject[] points = getPoints();
        GameObject[] points2 = getPoints();
        int res = 0;
        if(isKarakter2 == false){
            for(int i = 0; i < points.Length; i++)
            {
                if (karakter.transform.position == points[i].transform.position)
                {
                    res = i;
                }
                
            }
        }else{
            for(int i = 0; i < points2.Length; i++)
            {
                if (karakter2.transform.position == points2[i].transform.position)
                {
                    res = i;
                }
                
            }
        }
        
        return res;
    }

    private GameObject[] getPoints()
    {
        GameObject[] points = { point0, point1, point2, point3, point4, point5, point6, point7, point8, point9, point10, point11, point12, point13, point14, point15, point16, point17, point18, point19, point20, point21, point22, point23, point24, point25, point26, point27, point28, point29, point30, point31, point32, point33, point34, point35, point36, point37, point38, point39, point40, point41, point42, point43, point44, point45, point46, point47, point48, point49, point50, point51, point52, point53, point54, point55, point56, point57, point58, point59, point60, point61, point62, point63 };
        return points;
    }

    private void setColor(int position, float a)
    {
        Color color = point0.GetComponent<SpriteRenderer>().color;
        color.a = a;
        if(position+1<64)
        getPoints()[position+1].GetComponent<SpriteRenderer>().color = color;
        if(position-1>-1)
            getPoints()[position-1].GetComponent<SpriteRenderer>().color = color;
        if (position + 8 < 64)
            getPoints()[position + 8].GetComponent<SpriteRenderer>().color = color;
        if (position  -8 > -1)
            getPoints()[position-8].GetComponent<SpriteRenderer>().color = color;
    }
    public void click(int dice, int position)
    {
        int currentPos = 0;
        if (Input.GetKey(KeyCode.UpArrow))
        {
            if(isKarakter2 == false){
                if (position - (dice*8) > -1)
                {
                    setColor(getPosition(), 0f);
                    karakter.transform.position = getPoints()[position - (8 * dice)].transform.position;
                    setPointCard(position - (8 * dice));
                    Dice.finalSide = 0;
                    isKarakter2 = true;
                }
            } else{
                if (position - (dice*8) > -1)
                {
                    setColor(getPosition(), 0f);
                    karakter2.transform.position = getPoints()[position - (8 * dice)].transform.position;
                    setPointCard(position - (8 * dice));
                    Dice.finalSide = 0;
                    isKarakter2 = false;
                }
            }
            currentPos = position - (8 * dice);
            setCard(pointCard[currentPos]);
            
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            if(isKarakter2 == false){
                if (position + (8*dice) < 64)
                {
                    setColor(getPosition(), 0f);
                    karakter.transform.position = getPoints()[position + (8 * dice)].transform.position;
                    setPointCard(position + (8 * dice));
                    Dice.finalSide = 0;
                    isKarakter2 = true;
                }
            }else{
                if (position + (8*dice) < 64)
                {
                    setColor(getPosition(), 0f);
                    karakter2.transform.position = getPoints()[position + (8 * dice)].transform.position;
                    setPointCard(position + (8 * dice));
                    Dice.finalSide = 0;
                    isKarakter2 = false;
                }
            }
            currentPos = position + (8 * dice);
            setCard(pointCard[currentPos]);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            int posrow = (position / 7) + 1;
            int minrow = (posrow * 7)-7;
            if(isKarakter2 == false){
                if (position - 1 > -1 && position-dice>minrow)
                {
                    setColor(getPosition(), 0f);
                    karakter.transform.position = getPoints()[position - dice].transform.position;
                    setPointCard(position - dice);
                    Dice.finalSide = 0;
                    isKarakter2 = true;
                }
            }else{
                if (position - 1 > -1 && position-dice>minrow)
                {
                    setColor(getPosition(), 0f);
                    karakter2.transform.position = getPoints()[position - dice].transform.position;
                    setPointCard(position - dice);
                    Dice.finalSide = 0;
                    isKarakter2 = false;
                }
            }
            currentPos = position - dice;
            setCard(pointCard[currentPos]);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {

            int posrow = (position / 7) + 1;
            int maxrow = posrow * 7;
            if(isKarakter2==false){
                if (position +1 < 64 && position + dice < maxrow)
                {
                    setColor(getPosition(), 0f);
                    karakter.transform.position = getPoints()[position + dice].transform.position;
                    setPointCard(position + dice);
                    Dice.finalSide = 0;
                    isKarakter2 = true;
                }
            }else{
                if (position +1 < 64 && position + dice < maxrow)
                {
                    setColor(getPosition(), 0f);
                    karakter2.transform.position = getPoints()[position + dice].transform.position;
                    setPointCard(position + dice);
                    Dice.finalSide = 0;
                    isKarakter2 = false;
                }
            }
            currentPos = position + dice;
            setCard(pointCard[currentPos]);
        }
        
    }
    private void setPointCard(int position)
    {
        if (pointCard[position]==0)
        {
            if(Dice.finalSide > 3)
            {
                if (position > 31)
                {
                    pointCard[position] = Random.Range(4, 7);
                }
                else
                {
                    pointCard[position] = Random.Range(1, 4);
                }
            }
        }
        else
        {
            attack(position);
        }
    }
    private void setCard(int res)
    {
        if (res == 0)
        {
            card.GetComponent<SpriteRenderer>().sprite = def;
        }
        if (res == 1)
        {
            card.GetComponent<SpriteRenderer>().sprite = golem;
        }
        if (res == 2)
        {
            card.GetComponent<SpriteRenderer>().sprite = goblin;
        }
        if (res == 3)
        {
            card.GetComponent<SpriteRenderer>().sprite = minotour;
        }
        if (res == 4)
        {
            card.GetComponent<SpriteRenderer>().sprite = hydra;
        }
        if (res == 5)
        {
            card.GetComponent<SpriteRenderer>().sprite = kraken;
        }
        if (res == 6)
        {
            card.GetComponent<SpriteRenderer>().sprite = fish;
        }
    }
    private void attack(int position)
    {
        if (isKarakter2)
        {
            if (pointCard[position] != 0)
            {
                hpKarakter2 = hpKarakter2 - getMonsterAtack(pointCard[position]);
                scoreKarakter2 = scoreKarakter2 + getMonsterPoint(pointCard[position]);
                pointCard[position] = 0;
            }
        }
        else
        {
            if (pointCard[position] != 0)
            {
                hpKarakter1 = hpKarakter1 - getMonsterAtack(pointCard[position]);
                scoreKarakter1 = scoreKarakter1 + getMonsterPoint(pointCard[position]);
                pointCard[position] = 0;
            }
        }
        if (hpKarakter1 <= 0 || hpKarakter2 <= 0)
        {
            if(scoreKarakter1<scoreKarakter2)
                PindahScene("Winner Player 2");
            else
                PindahScene("Winner Player 1");
        }
        updatePlayer();
    }
    private void updatePlayer()
    {
        goHpKarakter1.GetComponent<TMPro.TMP_Text>().text = hpKarakter1.ToString();
        goHpKarakter2.GetComponent<TMPro.TMP_Text>().text = hpKarakter2.ToString();
        goScoreKarakter1.GetComponent<TMPro.TMP_Text>().text = scoreKarakter1.ToString();
        goScoreKarakter2.GetComponent<TMPro.TMP_Text>().text = scoreKarakter2.ToString();
    }
    private int getMonsterAtack(int monster)
    {
        if (monster == 1)
        {
            return 10;
        }
        else if(monster == 2)
        {
            return 6;
        }
        else if(monster == 3)
        {
            return 7;
        }
        else if (monster == 4)
        {
            return 20;
        }
        else if (monster == 5)
        {
            return 15;
        }
        else if (monster == 6)
        {
            return 7;
        }
        else
        {
            return 0;
        }
    }
    private int getMonsterPoint(int monster)
    {
        if (monster == 1)
        {
            return 8;
        }
        else if (monster == 2)
        {
            return 3;
        }
        else if (monster == 3)
        {
            return 5;
        }
        else if (monster == 4)
        {
            return 15;
        }
        else if (monster == 5)
        {
            return 10;
        }
        else if (monster == 6)
        {
            return 8;
        }
        else
        {
            return 0;
        }
    }
}
