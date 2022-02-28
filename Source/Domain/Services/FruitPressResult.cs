using Domain.Entities;
using System;
using System.Collections.Generic;

namespace Domain.Services
{
    public class FruitPressResult : IFruitPressService
    {
        public List<string> Produce(Recipe recipe, Dictionary<string, decimal> fruits, int moneyPaid, int orderedGlassQuantity)
        {
            //DECLARE LISTS WHERE WE WILL STORE STRINGS OF OUR RESULT AFTER PRODUCE METHOD HAS BEEN COMPLITED
            List<string> errorList = new();
            List<string> successList = new();

            //DECLARE PAYMENT CALCULATION VARIABLES
            int moneyRequired = recipe.PricePerGlass * orderedGlassQuantity;
            int moneyExchange = moneyPaid - moneyRequired;
            int missingMoneyAmmount = moneyRequired - moneyPaid;
            int payableAmountOfGlasses = moneyPaid / recipe.PricePerGlass;

            //DECLARE TYPE AND QUANTITY CALCULATION VARIABLES
            decimal consumptionPerGlass = recipe.ConsumptionPerGlass;
            decimal fruitRequired = orderedGlassQuantity * consumptionPerGlass;

            //DECLARE VALIDATION STATUS TYPE
            bool isSuccess = false;

            //CHECK IF MONEY IS ENOUGH TO BUY SELECTED QUANTITY OF GLASSES
            if (moneyPaid >= moneyRequired)
            {
                //LOOP TRUE FRUIT DICTIONARY TO PERFORM TYPE AND QUANTITY CALCULATIONS
                foreach (var fruit in fruits)
                {
                    //FOR ALL THE FRUITS THAT ARE NOT ALLOWED AND QUANTITY IS NOT ZERO SHOW AN ERROR MESSAGE
                    if (fruit.Key != recipe.AllowedFruit && fruit.Value > 0)
                    {
                        isSuccess = false;
                        errorList.Add("Error! " + fruit.Key + "(s) are not allowed in this recipe! This value must be 0!");
                    }

                    //FOR ALL THE FRUITS THAT ARE ALLOWED CHECK REQUIRED PARAMETERS
                    else
                    {
                        decimal fruitLeftover = fruit.Value - fruitRequired;
                        decimal missingFruitQuantity = fruitRequired - fruit.Value;

                        //IF ALLOWED FRUIT QUANTITY IS NOT ENOUGH TO PRODUCE THE JUICE SHOW AN ERROR MESSAGE
                        if (fruit.Key == recipe.AllowedFruit && fruit.Value < fruitRequired)
                        {
                            isSuccess = false;
                            errorList.Add("Error! " + "You don't have enough " + fruit.Key.ToLower() + "(s) for selected quantity! You must add " + missingFruitQuantity + "" + fruit.Key.ToLower() + "(s) to produce this order!");
                        }

                        //IF ALLOWED FRUIT QUANTITY IS ABOVE REQUIRED QUANTITY SHOW SUCCESS MESSAGE
                        if (fruit.Key == recipe.AllowedFruit && fruit.Value >= fruitRequired)
                        {
                            isSuccess = true;
                            successList.Add("Success! " + fruitLeftover + " " + fruit.Key.ToLower() + "(s) will remain after the production of this juice! You must return " + moneyExchange + " SEK to your customer!");
                        }
                    }
                }
            }

            //SHOW AN ERROR BECAUSE MONEY IS NOT ENOUGH TO COMPLETE THE ORDER
            else
            {
                isSuccess = false;
                errorList.Add("Error! " + "Money only enough for " + payableAmountOfGlasses + " glass (es). Money: " + moneyRequired + " SEK needed! Missing amount: " + missingMoneyAmmount + " SEK!");
            }

            //IF SUCCESS STATUS TYPE IS FALSE WE WILL RETURN ERROR LIST
            if (!isSuccess)
            {
                return errorList;
            }
            //IF SUCCESS STATUS TYPE IS TRUE WE WILL RETURN SUCCESS LIST
            else
            {
                return successList;
            }
        }
    }
}