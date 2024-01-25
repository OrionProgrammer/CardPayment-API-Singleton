﻿namespace CardPayment.API.Business_Rules;
public class ChargeSingleton
{
    private static ChargeSingleton _instance = null;
    private static readonly object chekLock = new();
    private static readonly Random random = new Random();
    private int hour;
    private decimal fee;
    
    private ChargeSingleton() { }

    public static ChargeSingleton Instance
    {
        get
        {
            lock (chekLock)
            {
                if (_instance == null)
                    _instance = new ChargeSingleton();
                return _instance;
            }
        }
    }

    public virtual decimal CalculateUFEPrice(decimal totalAmount)
    {
        if (hour != DateTime.Now.Hour)
        {
            //question did say how to calculate or set the initial fee
            //so, if last fee amount = 0, then set last fee amount = 3% of total amount
            if (fee == 0)
            {
                fee = (totalAmount * 3) / 100;
            }

            //calculate new fee
            fee *= RandomDecimal();
        }

        //set latest hour
        hour = DateTime.Now.Hour;

        return fee;
    }

    private decimal RandomDecimal()
    {
        var next = random.NextDouble();

        return (decimal)(0.0 + (next * (2.0 - 0.0)));
    }

}