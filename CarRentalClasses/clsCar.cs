using System;

namespace CarRentalClasses
{
    public class clsCar
    {
       
        public string CarName { get; set; }
        public string CarColour { get; set; }
        public string RegPlate { get; set; }
        public string CarModel { get; set; }
        public string EngineSize { get; set; }
        public int Price { get; set; }
        public int CarID { get; set; }
        public bool Find(int primaryKey)
        {
            return true;
        }

        public string Valid(string text1, string text2, string text3, string text4, string text5, string text6, string text7)
        {
            throw new NotImplementedException();
        }
    }
}