using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseRentingSystem.Data.Constants
{
    public static class Constants
    {
        // House
        public const int HouseTitleMinLength = 10;
        public const int HouseTitleMaxLength = 50;
        public const int HouseAddressMinLength = 30;
        public const int HouseAddressMaxLength = 150;
        public const int HouseDescriptionMinLength = 50;
        public const int HouseDescriptionMaxLength = 500;
        public const double HousePricePerMonthMinValue = 0;
        public const double HousePricePerMonthMaxValue = 2000;

        // Category
        public const int CategoryNameMaxLength = 50;

        // Agent
        public const int AgentPhoneNumberMinLength = 7;
        public const int AgentPhoneNumberMaxLength = 15;
    }
}
