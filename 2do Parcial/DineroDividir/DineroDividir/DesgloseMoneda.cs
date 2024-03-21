using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DineroDividir
{
    class DesgloseMoneda
    {
        //Atributos de la clase.
        private double money;
        private int[] contNum;

        //Constructor por omision
        public DesgloseMoneda() { }
        //Constructor definido por el programador
        public DesgloseMoneda(double money)
        {
            this.money = money;
            this.contNum = new int[ + 1];
        }

        //Propiedades GET y SET.
        public double Money { get => money; set => money = value; }
        public int[] ContNum { get => contNum; set => contNum = value; }

        //Metodos.

        public double M500()
        {
            int P500 = 0;
            if ((money >= 500))
            {
                P500 = ((int)money / 500);
                money = money - (P500 * 500);
            }
            return P500;
        }
        
        public double M200()
        {
            int P200 = 0;
            if ((money >= 200))
            {
                P200 = ((int)money / 200);
                money = money - (P200 * 200);
            }
            return P200;
        }
        public double M100()
        {
            int P100 = 0;
            if ((money >= 100))
            {
                P100 = ((int)money / 100);
                money = money - (P100 * 100);
            }
            return P100;
        }
        public double M50()
        {
            int P50 = 0;
            if ((money >= 50))
            {
                P50 = ((int)money / 50);
                money = money - (P50 * 50);
            }
            return P50;
        }
        public double M20()
        {
            int P20 = 0;
            if ((money >= 20))
            {
                P20 = ((int)money / 20);
                money = money - (P20 * 20);
            }
            return P20;
        }
        public double M10()
        {
            int P10 = 0;
            if ((money >= 10))
            {
                P10 = ((int)money / 10);
                money = money - (P10 * 10);
            }
            return P10;
        }
        public double M5()
        {
            int P5 = 0;
            if ((money >= 5))
            {
                P5 = ((int)money / 5);
                money = money - (P5 * 5);
            }
            return P5;
        }
        public double M2()
        {
            int P2 = 0;
            if ((money >= 2))
            {
                P2 = ((int)money / 2);
                money = money - (P2 * 2);
            }
            return P2;
        }
        public double M1()
        {
            int P1 = 0;
            if ((money >= 1))
            {
                P1 = ((int)money / 1);
                money = money - (P1 * 1);
            }
            return P1;
        }
        public void Desglose()
        {
            int P500 = 0;
            int P200 = 0;
            int P100 = 0;
            int P50 = 0;
            int P20 = 0;
            int P10 = 0;
            int P5 = 0;
            int P2 = 0;
            int P1 = 0;

            for (int j = 1; j < contNum.Length; j++)
            {
                if ((money >= 500))
                {
                    P500 = ((int)money / 500);
                    money = money - (P500 * 500);
                    contNum[j]++;
                }
                if ((money >= 200))
                {
                    P200 = ((int)money / 200);
                    money = money - (P200 * 200);
                    contNum[j]++;
                }
                if ((money >= 100))
                {
                    P100 = ((int)money / 100);
                    money = money - (P100 * 100);
                    contNum[j]++;
                }
                if ((money >= 50))
                {
                    P50 = ((int)money / 50);
                    money = money - (P50 * 50);
                    contNum[j]++;
                }
                if ((money >= 20))
                {
                    P20 = ((int)money / 20);
                    money = money - (P20 * 20);
                    contNum[j]++;
                }
                if ((money >= 10))
                {
                    P10 = ((int)money / 10);
                    money = money - (P10 * 10);
                    contNum[j]++;
                }
                if ((money >= 5))
                {
                    P5 = ((int)money / 5);
                    money = money - (P5 * 5);
                    contNum[j]++;
                }
                if ((money >= 2))
                {
                    P2 = ((int)money / 2);
                    money = money - (P2 * 2);
                    contNum[j]++;
                }
                if ((money >= 1))
                {
                    P1 = ((int)money / 1);
                    money = money - (P1 * 1);
                    contNum[j]++;
                }
            }

            
        }
    }
}
