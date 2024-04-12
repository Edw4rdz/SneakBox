using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SneakerBox
{
        public class ShoeModel
        {
            public List<LoginShoes> NikeList = new List<LoginShoes>();
            public List<LoginShoes> AdidasList = new List<LoginShoes>();
            public List<LoginShoes> NBList = new List<LoginShoes>();

            public ShoeModel()
            {

                LoginShoes NikeOne = new LoginShoes();
                NikeOne.brand = "Nike";
                NikeOne.model = "Sabrina 1";
                NikeOne.description = "Basketball Shoes";

                LoginShoes NikeTwo = new LoginShoes();
                NikeTwo.brand = "Nike";
                NikeTwo.model = "Lebron 20";
                NikeTwo.description = "Basketball Shoes";

                NikeList.Add(NikeOne);
                NikeList.Add(NikeTwo);

                LoginShoes AdidasOne = new LoginShoes();
                AdidasOne.brand = "Adidas";
                AdidasOne.model = "Samba";
                AdidasOne.description = "Lifestyle Shoes";

                LoginShoes AdidasTwo = new LoginShoes();
                AdidasTwo.brand = "Adidas";
                AdidasTwo.model = "AE 1";
                AdidasTwo.description = "Basketball Shoes";

                AdidasList.Add(AdidasOne);
                AdidasList.Add(AdidasTwo);

                LoginShoes NBOne = new LoginShoes();
                NBOne.brand = "New Balance";
                NBOne.model = "Kawhi 1";
                NBOne.description = "Basketball Shoes";

                LoginShoes NBTwo = new LoginShoes();
                NBTwo.brand = "New Balance";
                NBTwo.model = "Galaxy 1";
                NBTwo.description = "Hiking" + " Shoes";

                NBList.Add(NBOne);
                NBList.Add(NBTwo);
            }
            public void DisplayShoeInfo(string brand)

            {
                switch (brand.ToLower())
                {
                    case "nike":
                        Console.WriteLine("Nike Shoes:");
                        foreach (var shoe in NikeList)
                        {
                            Console.WriteLine($"Model: {shoe.model}, Description: {shoe.description}");
                        }
                        break;

                    case "adidas":
                        Console.WriteLine("Adidas Shoes:");
                        foreach (var shoe in AdidasList)
                        {
                            Console.WriteLine($"Model: {shoe.model}, Description: {shoe.description}");
                        }
                        break;

                    case "new balance":
                        Console.WriteLine("New Balance Shoes:");
                        foreach (var shoe in NBList)
                        {
                            Console.WriteLine($"Model: {shoe.model}, Description: {shoe.description}");
                        }
                        break;

                    default:
                        Console.WriteLine("Brand not found in the closet.");
                        break;
                }
            }
        }
    }
