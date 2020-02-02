using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Overloaded: MonoBehaviour {
    [SerializeField]
    string myName;
    [SerializeField]
    int repeat;

    [SerializeField]
    int num1;
    [SerializeField]
    int num2;
    [SerializeField]
    int num3;

    void Start() {
        Greet();
        Greet(myName);
        Greet(myName, repeat);

        Debug.Log(MaxInt(num1, num2) + " is the largest of the two");
        Debug.Log(MaxInt(num1, num2, num3) + " is the largest of the two");

    }

    void Greet() {
        Debug.Log(myName);
    }

    void Greet(string name) {
        Debug.Log("Hello " + name);
    }

    void Greet(string name, int times) {
        for (int i = 0; i < times; i ++) {
            Debug.Log(name);
        }
    }

    int MaxInt(int number1, int number2) {
        int maxInt;
        if (number1 > number2) {
            maxInt = number1;
        } else {
            maxInt = number2;
        }
        return maxInt;
    }

    int MaxInt(int number1, int number2, int number3) {
        int maxInt;
        if (number1 > number2) {
            if (number1 > number3) {
                maxInt = number1;
            } else {
                maxInt = number3;
            }
        } else if (number2 > number3) {
            maxInt = number2;
        } else {
            maxInt = number3;
        }
        return maxInt;
    }
}
