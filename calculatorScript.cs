using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class calculatorScript : MonoBehaviour
{
    //assignment didn't specify that user should be able to enter numbers with decimals
    //user will only be allowed to enter two numbers at a time
    //in order to do the squared by 2 function you need to enter another digit for it not to produce an error
    //i was going to add decimal points but they weren't working in the end so i removed the button and the function

    public double num1 = 0;
    public double num2 = 0;
    public double ansNum = 0;
    public string symbolChosen;
    public GameObject numPickedText;
    public GameObject ansToDisplayText;

    public GameObject num0Button;
    public GameObject num1Button;
    public GameObject num2Button;
    public GameObject num3Button;
    public GameObject num4Button;
    public GameObject num5Button;
    public GameObject num6Button;
    public GameObject num7Button;
    public GameObject num8Button;
    public GameObject num9Button;
    public GameObject additionButton;
    public GameObject subtractionButton;
    public GameObject multiplyButton;
    public GameObject divideButton;
    public GameObject clearButton;
    public GameObject squareRootButton;
    public GameObject squareBy2Button;
    public GameObject squareByUserNumButton;
    public GameObject equalsButton;
    public GameObject modButton;
    public GameObject decimalPointButton;

    // Start is called before the first frame update
    void Start()
    {
        //button0Clicked.onClick.addListener(() => button0Clicked("0"));

    }

    //method if button 0 is clicked displays user input
    public void button0Clicked()
    {
        numPickedText.GetComponent<Text>().text += "0";
    }
    //method if button 1 is clicked displays user input
    public void button1Clicked()
    {
        numPickedText.GetComponent<Text>().text += "1";
    }
    //method if button 2 is clicked displays user input
    public void button2Clicked()
    {
        numPickedText.GetComponent<Text>().text += "2";
    }
    //method if button 3 is clicked displays user input
    public void button3Clicked()
    {
        numPickedText.GetComponent<Text>().text += "3";
    }
    //method if button 4 is clicked displays user input
    public void button4Clicked()
    {
        numPickedText.GetComponent<Text>().text += "4";
    }
    //method if button 5 is clicked displays user input
    public void button5Clicked()
    {
        numPickedText.GetComponent<Text>().text += "5";
    }
    //method if button 6 is clicked displays user input
    public void button6Clicked()
    {
        numPickedText.GetComponent<Text>().text += "6";
    }
    //method if button 7 is clicked displays user input
    public void button7Clicked()
    {
        numPickedText.GetComponent<Text>().text += "7";
    }
    //method if button 8 is clicked displays user input
    public void button8Clicked()
    {
        numPickedText.GetComponent<Text>().text += "8";
    }
    //method if button 9 is clicked displays user input
    public void button9Clicked()
    {
        numPickedText.GetComponent<Text>().text += "9";
    }

    //method to clear text in textfield
    public void buttonClearClicked()
    {
        numPickedText.GetComponent<Text>().text = "";
        ansToDisplayText.GetComponent<Text>().text = "";
    }
    //button to multiply being displayed and selecting a symbol
    public void buttonMultiplyClicked()
    {
        symbolChosen = "*";
        numPickedText.GetComponent<Text>().text += "x";
    }
    //button to divide being displayed and selecting a symbol
    public void buttonDivisionClicked()
    {
        symbolChosen = "/";
        numPickedText.GetComponent<Text>().text += "/";
    }
    //button to addition being displayed and selecting a symbol
    public void buttonAddtionClicked()
    {
        symbolChosen = "+";
        numPickedText.GetComponent<Text>().text += "+";
    }
    //button to subtract being displayed and selecting a symbol
    public void buttonSubtractClicked()
    {
        symbolChosen = "-";
        numPickedText.GetComponent<Text>().text += "-";
    }
    
    //button to show mod being displayed and selecting a symbol
    public void buttonModClicked()
    {
        symbolChosen = "%";
        numPickedText.GetComponent<Text>().text += "%";
    }
    //button to show square root being displayed and selecting a symbol
    public void buttonSqRootClicked()
    {
        symbolChosen = "?/";
        numPickedText.GetComponent<Text>().text += "//";
    }
    //button to show square by 2 being displayed and selecting a symbol
    public void buttonSquaredBy2Clicked()
    {
        symbolChosen = "^2";
        numPickedText.GetComponent<Text>().text += "^2";
    }
    //button to show exponential option being displayed and selecting a symbol
    public void buttonExponentialClicked()
    {
        symbolChosen = "^";
        numPickedText.GetComponent<Text>().text += "^";
    }

    //method that puts two numbers together and displays the output of the operation
    public void buttonEqualsClicked()
    {
        //checking if user has inputted a valid symbol
        if(!numPickedText.GetComponent<Text>().text.Contains(symbolChosen))
        {
            ansToDisplayText.GetComponent<Text>().text = "Error!";
            return;
        }
        //splitting input using symbol
        string[] inputs = numPickedText.GetComponent<Text>().text.Split(new string[] { symbolChosen }, StringSplitOptions.RemoveEmptyEntries);
        //checking if numbers are parsed correctly and successfully
        if(inputs.Length!=2 || !double.TryParse(inputs[0], out num1) || !double.TryParse(inputs[1], out num2))
        {
            ansToDisplayText.GetComponent<Text>().text = "Error!";
            return;
        }
        //choosing operation to perform based on symbol chosen by user
        switch(symbolChosen)
        {
            case "+":
                ansNum = num1 + num2;
                break;
            case "-":
                ansNum = num1 - num2;
                break;
            case "*":
                ansNum = num1 * num2;
                break;
            case "/":
                if(num2 == 0)
                {
                    ansToDisplayText.GetComponent<Text>().text = "Error!";
                }
                ansNum = num1 / num2;
                break;
            case "%":
                ansNum = num1 % num2;
                break;
            case "^":
                ansNum = Math.Pow(num1, num2);
                break;
            case "^2":
                ansNum = Math.Pow(num1, 2);
                break;
            case "?/":
                if(num1 < 0)
                {
                    ansToDisplayText.GetComponent<Text>().text = "Error!";
                    return;
                }
                ansNum = Math.Sqrt(num1);
                break;
            default:
                ansToDisplayText.GetComponent<Text>().text = "Error!";
                return;
        }
        ansNum = Math.Round(ansNum, 2);
        ansToDisplayText.GetComponent<Text>().text = ansNum.ToString();
    }
}
