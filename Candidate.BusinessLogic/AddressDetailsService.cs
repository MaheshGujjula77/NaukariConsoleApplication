using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate.BusinessLogic
{
    public class AddressDetailsService
    {
        /// <summary>
        /// Method that reads Candidate Address details from  Console screen
        /// </summary>
        public AddressDetails ReadAddressDetails()
        {
            AddressDetails addressDetails = new AddressDetails();
            StringBuilder validations = new StringBuilder();
            try
            {
                Console.WriteLine("Provide Candidate Address Details:\n");
                Console.WriteLine("Different values for Address Type :");
                List<string> addressList = new List<string>();
                addressList.Add(Constants.AddressTypeConstants.PRESENT_ADDRESS);
                addressList.Add(Constants.AddressTypeConstants.PERMANENT_ADDRESS);

                //Print Address Type List
                Utility.Utility.PrintListValues(addressList);

                Console.Write("Select value for Address Type(EX: 1 for Present Address): ");
                int addressOutput = 0;
                bool isAddressHasValue = int.TryParse(Console.ReadLine(), out addressOutput);
                string addressValue = string.Empty;
                if (isAddressHasValue)
                {
                    switch (addressOutput)
                    {
                        case (int)Enums.AddressType.Present_Address:
                            addressValue = Constants.AddressTypeConstants.PRESENT_ADDRESS;
                            break;
                        case (int)Enums.AddressType.Permanent_Address:
                            addressValue = Constants.AddressTypeConstants.PERMANENT_ADDRESS;
                            break;
                        default:
                            validations.Append("Unknown value for Address Type is selected.\n");
                            break;
                    }
                    addressDetails.AddressType = addressValue;
                }
                else
                    validations.Append("Please select integer value for Address Type(EX: 1 for Present Address)\n");
                Console.WriteLine();
                Console.Write("Enter Building Number :");
                string buildingNumber = Console.ReadLine();

                if (!string.IsNullOrEmpty(buildingNumber))
                    addressDetails.BuildingNumber = buildingNumber;
                else
                    validations.Append("Candidate Building Number is missing.\n");

                Console.Write("Enter the House Number :");
                string houseNumber = Console.ReadLine();

                if (!string.IsNullOrEmpty(houseNumber))
                    addressDetails.HouseNumber = houseNumber;
                else
                    validations.Append("Candidate House Number is missing.\n");

                Console.Write("Enter the Street :");
                string street = Console.ReadLine();

                if (!string.IsNullOrEmpty(street))
                    addressDetails.Street = street;
                else
                    validations.Append("Candidate Street is missing.\n");

                Console.Write("Enter the Land Mark :");
                string landMark = Console.ReadLine();

                if (!string.IsNullOrEmpty(landMark))
                    addressDetails.LandMark = landMark;
                else
                    validations.Append("Candidate Land Mark is missing.\n");

                Console.Write("Enter the City :");
                string city = Console.ReadLine();

                if (!string.IsNullOrEmpty(city))
                    addressDetails.City = city;
                else
                    validations.Append("Candidate City is missing.\n");

                Console.Write("Enter the State :");
                string state = Console.ReadLine();

                if (!string.IsNullOrEmpty(state))
                    addressDetails.State = state;
                else
                    validations.Append("Candidate State is missing.\n");

                Console.Write("Enter the Country :");
                string country = Console.ReadLine();

                if (!string.IsNullOrEmpty(country))
                    addressDetails.Country = country;
                else
                    validations.Append("Candidate Country is missing.\n");

                Console.Write("Enter the Postal code :");
                string postalCode = Console.ReadLine();

                if (!string.IsNullOrEmpty(postalCode))
                    addressDetails.PostalCode = postalCode;
                else
                    validations.Append("Candidate Postal Code is missing.\n");


                //Validations Errors  Displayed here
                if (!string.IsNullOrEmpty(validations.ToString()))
                {
                    Console.WriteLine($"\n\nValidation Errors:\n{validations}");
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Message: {0}", ex.Message);
                Console.WriteLine();
                Console.WriteLine("Exception Trace: {0}", ex.StackTrace);
            }
            return addressDetails;
        }

        /// <summary>
        ///  Method that  writes/prints Candidate Address details to the Console Screen
        /// </summary>
        /// <param name="details"></param>
        public void PrintAddressDetails(AddressDetails details)
        {
            try
            {
                Console.WriteLine();
                Console.WriteLine("Address Details :");
                Console.WriteLine($"Address Type : {details.AddressType}");
                Console.WriteLine($"Building Number : {details.BuildingNumber}");
                Console.WriteLine($"House Number : {details.HouseNumber}");
                Console.WriteLine($"Street : {details.Street}");
                Console.WriteLine($"Land Mark : {details.LandMark}");
                Console.WriteLine($"City : {details.City}");
                Console.WriteLine($"State : {details.State}");
                Console.WriteLine($"Country : {details.Country}");
                Console.WriteLine($"Postal Code : {details.PostalCode}");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Message: {0}", ex.Message);
                Console.WriteLine();
                Console.WriteLine("Exception Trace: {0}", ex.StackTrace);
            }
        }
    }
}
