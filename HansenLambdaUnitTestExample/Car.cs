using System;
using System.Collections.Generic;
using System.Text;

namespace HansenLambdaUnitTestExample
{
    public enum Condition
    {
        BAD,
        FAIR,
        GOOD,
        EXCELLENT
    }
    public class Car
    {
        public static int _speed =0;
        public string Make;
        public Condition Condition;

        public Car(string m, Condition c)
        {
            this.Make = m;
            this.Condition = c;
        }

        public int Speed
        {
            get => _speed;
            set
            {
                if (value <= -50)
                {
                    _speed = -50;
                }
                else if(value >= 200){
                    _speed = 200;
                }
                else
                {
                    _speed = value;
                }
            }
        }
    }   
}

