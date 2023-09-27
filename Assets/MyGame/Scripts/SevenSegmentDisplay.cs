using UnityEngine;

public class SevenSegmentDisplay : MonoBehaviour
{
    public GameObject[] digits;
    public int currentNumber;
    public void Start()
    {
        digits[0].SetActive(false);
        digits[1].SetActive(false);
        digits[2].SetActive(false);
        digits[3].SetActive(false);
        digits[4].SetActive(false);
        digits[5].SetActive(false);
        digits[6].SetActive(false);
    }
    private void ButtonClick0()
    {
        digits[0].SetActive(true);
        digits[1].SetActive(true);
        digits[2].SetActive(true);
        digits[3].SetActive(true);
        digits[4].SetActive(true);
        digits[5].SetActive(true);
        digits[6].SetActive(false);
    }
    public void ButtonClick1()
    {
        digits[0].SetActive(false);
        digits[1].SetActive(false);
        digits[2].SetActive(false);
        digits[3].SetActive(false);
        digits[4].SetActive(true);
        digits[5].SetActive(true);
        digits[6].SetActive(false);
    }

    public void ButtonClick2()
    {
        digits[0].SetActive(true);
        digits[1].SetActive(true);
        digits[2].SetActive(false);
        digits[3].SetActive(true);
        digits[4].SetActive(true);
        digits[5].SetActive(false);
        digits[6].SetActive(true);
    }

    public void ButtonClick3()
    {
        digits[0].SetActive(true);
        digits[1].SetActive(true);
        digits[2].SetActive(true);
        digits[3].SetActive(true);
        digits[4].SetActive(false);
        digits[5].SetActive(false);
        digits[6].SetActive(true);
    }

    public void ButtonClick4()
    {
        digits[0].SetActive(false);
        digits[1].SetActive(true);
        digits[2].SetActive(true);
        digits[3].SetActive(false);
        digits[4].SetActive(false);
        digits[5].SetActive(true);
        digits[6].SetActive(true);
    }
    public void ButtonClick5()
    {
        digits[0].SetActive(true);
        digits[1].SetActive(false);
        digits[2].SetActive(true);
        digits[3].SetActive(true);
        digits[4].SetActive(false);
        digits[5].SetActive(true);
        digits[6].SetActive(true);
    }
    public void ButtonClick6()
    {
        digits[0].SetActive(true);
        digits[1].SetActive(false);
        digits[2].SetActive(true);
        digits[3].SetActive(true);
        digits[4].SetActive(true);
        digits[5].SetActive(true);
        digits[6].SetActive(true);
    }
    public void ButtonClick7()
    {
        digits[0].SetActive(true);
        digits[1].SetActive(true);
        digits[2].SetActive(true);
        digits[3].SetActive(false);
        digits[4].SetActive(false);
        digits[5].SetActive(false);
        digits[6].SetActive(false);
    }
    public void ButtonClick8()
    {
        digits[0].SetActive(true);
        digits[1].SetActive(true);
        digits[2].SetActive(true);
        digits[3].SetActive(true);
        digits[4].SetActive(true);
        digits[5].SetActive(true);
        digits[6].SetActive(true);
    }
    public void ButtonClick9()
    {
        digits[0].SetActive(true);
        digits[1].SetActive(true);
        digits[2].SetActive(true);
        digits[3].SetActive(false);
        digits[4].SetActive(false);
        digits[5].SetActive(true);
        digits[6].SetActive(true);
    }

    public void Update()
    {
        int currentNumber = int.Parse(Input.inputString);
        if (currentNumber == 1)
        {
            ButtonClick1();
        }
        if (currentNumber == 2)
        {
            ButtonClick2();
        }
        if (currentNumber == 3)
        {
            ButtonClick3();
        }
        if (currentNumber == 4)
        {
            ButtonClick4();
        }
        if (currentNumber == 5)
        {
            ButtonClick5();
        }
        if (currentNumber == 6)
        {
            ButtonClick6();
        }
        if (currentNumber == 7)
        {
            ButtonClick7();
        }
        if (currentNumber == 8)
        {
            ButtonClick8();
        }
        if (currentNumber == 9)
        {
            ButtonClick9();
        }
        if (currentNumber == 0)
        {
            ButtonClick0();
        }
    }
}
