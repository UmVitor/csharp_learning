using System;
using System.Globalization;
namespace InterfaceLocadora.Entities
{
    public class Rent
    {
        public string CarModel {get; set;}
        public DateTime PickupCar { get; set; }
        public DateTime ReturnCar { get; set; }
        public double PricePerHour {get; set;}
        public double PricePerDay {get; set;}


        public Rent(){

        }
        public Rent(string carModel, DateTime pickupCar, DateTime returnCar, double pricePerHour, double pricePerDay){
            CarModel = carModel;
            PickupCar = pickupCar;
            ReturnCar = returnCar;
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;

        }

        public int DurationPerHour(){
            TimeSpan duration = ReturnCar.Subtract(PickupCar);
            return (int)Math.Ceiling(duration.TotalHours);
        }
        public int DurationPerDay(){
            TimeSpan duration = ReturnCar.Subtract(PickupCar);
            return (int)Math.Ceiling(duration.TotalDays);
        }
        public double Tax(){
            double payment = BasicPayment();
            if(payment <= 100.00){
                return payment*0.2;
            }else{
                return payment*0.15;
            }
        }
        public double BasicPayment(){
            int durationPerHour = DurationPerHour();
            int durationPerDay = DurationPerDay();
            if(durationPerHour <= 12){
                return PricePerHour*durationPerHour;
            }else{
                return PricePerDay*durationPerDay;
            }
        }
        public double TotalPayment(){
            return BasicPayment() + Tax();
        }

        public override string ToString(){
            return "Basic payment: " + BasicPayment().ToString("F2", CultureInfo.InvariantCulture) + "\n" + 
                   "Tax: " + Tax().ToString("F2", CultureInfo.InvariantCulture) +  "\n" + 
                   "Total payment: " + TotalPayment().ToString("F2", CultureInfo.InvariantCulture);

        }

    }
}