using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace KnockoutShoppingCart.Models
{
    public class DataInitializer : DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var classicCars = new List<Product>();
            var categories = new List<Category>();

            classicCars.Add(new Product { Name = "1952 Citroen-15CV", Price = 47.25 });
            classicCars.Add(new Product { Name = "1952 Alpine Renault 1300", Price = 72.82 });
            classicCars.Add(new Product { Name = "1956 Porsche 356A Coupe", Price = 98.3 });
            classicCars.Add(new Product { Name = "11957 Corvette Convertible", Price = 69.93 });
            classicCars.Add(new Product { Name = "11957 Ford Thunderbird", Price = 34.21 });
            classicCars.Add(new Product { Name = "1948 Porsche 356-A Roadster", Price = 53.9 });
            classicCars.Add(new Product { Name = "1958 Chevy Corvette Limited Edition", Price = 15.91 });
            classicCars.Add(new Product { Name = "1961 Chevrolet Impala", Price = 32.33 });
            classicCars.Add(new Product { Name = "1962 LanciaA Delta 16V", Price = 103.42 });
            classicCars.Add(new Product { Name = "1965 Aston Martin DB5", Price = 65.96 });
            classicCars.Add(new Product { Name = "1966 Shelby Cobra 427 S/C", Price = 29.18 });
            classicCars.Add(new Product { Name = "1968 Dodge Charger", Price = 75.16 });
            classicCars.Add(new Product { Name = "1968 Ford Mustang", Price = 53.9 });
            classicCars.Add(new Product { Name = "1948 Porsche 356-A Roadster", Price = 95.34 });
            classicCars.Add(new Product { Name = "1969 Chevrolet Camaro Z28", Price = 50.51 });
            classicCars.Add(new Product { Name = "1969 Corvair Monza", Price = 89.14 });
            classicCars.Add(new Product { Name = "1969 Dodge Charger", Price = 58.73 });
            classicCars.Add(new Product { Name = "1969 Dodge Super Bee", Price = 49.05 });
            classicCars.Add(new Product { Name = "1969 Ford Falcon", Price = 83.05 });
            classicCars.Add(new Product { Name = "1970 Chevy Chevelle SS 454", Price = 49.24 });
            classicCars.Add(new Product { Name = "1970 Dodge Coronet", Price = 32.37 });
            classicCars.Add(new Product { Name = "1970 Plymouth Hemi Cuda", Price = 31.92 });
            classicCars.Add(new Product { Name = "1970 Triumph Spitfire", Price = 91.92 });
            classicCars.Add(new Product { Name = "1971 Alpine Renault 1600s", Price = 38.58 });
            classicCars.Add(new Product { Name = "1972 Alfa Romeo GTA", Price = 85.68 });
            classicCars.Add(new Product { Name = "1976 Ford Gran Torino", Price = 73.49 });
            classicCars.Add(new Product { Name = "1982 Camaro Z28", Price = 46.53 });
            classicCars.Add(new Product { Name = "1982 Lamborghini Diablo", Price = 16.24 });
            classicCars.Add(new Product { Name = "1985 Toyota Supra", Price = 57.01 });
            classicCars.Add(new Product { Name = "1992 Ferrari 360 Spider red", Price = 77.9 });
            classicCars.Add(new Product { Name = "1992 Porsche Cayenne Turbo Silver", Price = 69.78 });
            classicCars.Add(new Product { Name = "1993 Mazda RX-7", Price = 83.51 });
            classicCars.Add(new Product { Name = "1995 Honda Civic", Price = 93.89 });
            classicCars.Add(new Product { Name = "1998 Chrysler Plymouth Prowler", Price = 101.51 });
            classicCars.Add(new Product { Name = "1999 Indy 500 Monte Carlo SS", Price = 56.76 });
            classicCars.Add(new Product { Name = "2001 Ferrari Enzo", Price = 95.59 });
            classicCars.Add(new Product { Name = "2002 Chevy Corvette", Price = 62.11 });
            // classic cars
            categories.Add(new Category { Name = "Classic Cars", Products = classicCars });


            var motorcycles = new List<Product>();
            motorcycles.Add(new Product { Name = "1936 Harley Davidson El Knucklehead", Price = 24.23 });
            motorcycles.Add(new Product { Name = "1957 Vespa GS150", Price = 32.95 });
            motorcycles.Add(new Product { Name = "1960 BSA Gold Star DBD34", Price = 37.32 });
            motorcycles.Add(new Product { Name = "1969 Harley Davidson Ultimate Chopper", Price = 48.81 });
            motorcycles.Add(new Product { Name = "1974 Ducati 350 Mk3 Desmo", Price = 24.23 });
            motorcycles.Add(new Product { Name = "1982 Ducati 900 Monster", Price = 56.13 });
            motorcycles.Add(new Product { Name = "1982 Ducati 996 R", Price = 24.14 });
            motorcycles.Add(new Product { Name = "1996 Moto Guzzi 1100i", Price = 68.99 });
            motorcycles.Add(new Product { Name = "1997 BMW F650 ST", Price = 66.92 });
            motorcycles.Add(new Product { Name = "1997 BMW R 1100 S", Price = 60.86 });
            motorcycles.Add(new Product { Name = "2002 Suzuki XREO", Price = 66.27 });
            motorcycles.Add(new Product { Name = "2002 Yamaha YZR M1", Price = 34.17 });
            motorcycles.Add(new Product { Name = "2003 Harley-Davidson Eagle Drag Bike", Price = 91.02 });
            // motorcycles
            categories.Add(new Category { Name = "Motorcycles", Products = motorcycles });


            var planes = new List<Product>();
            planes.Add(new Product { Name = "1900s Vintage Bi-Plane", Price = 34.25 });
            planes.Add(new Product { Name = "1900s Vintage Tri-Plane", Price = 36.23 });
            planes.Add(new Product { Name = "1928 British Royal Navy Airplane", Price = 66.74 });
            planes.Add(new Product { Name = "ATA: B757-300", Price = 59.33 });
            planes.Add(new Product { Name = "America West Airlines B757-200", Price = 68.8 });
            planes.Add(new Product { Name = "1American Airlines: B767-300", Price = 51.15 });
            planes.Add(new Product { Name = "American Airlines: MD-11S", Price = 36.27 });
            planes.Add(new Product { Name = "Boeing X-32A JSF", Price = 32.77 });
            planes.Add(new Product { Name = "Corsair F4U ( Bird Cage)", Price = 29.34 });
            planes.Add(new Product { Name = "F/A 18 Hornet 1/72", Price = 54.4 });
            planes.Add(new Product { Name = "P-51-D Mustang", Price = 49.0 });
            //planes
            categories.Add(new Category { Name = "Planes", Products = planes });

            var ships = new List<Product>();
            ships.Add(new Product { Name = "18th century schooner", Price = 82.34 });
            ships.Add(new Product { Name = "1999 Yamaha Speed Boat", Price = 51.61 });
            ships.Add(new Product { Name = "HMS Bounty", Price = 39.83 });
            ships.Add(new Product { Name = "Pont Yacht", Price = 33.3 });
            ships.Add(new Product { Name = "The Mayflower", Price = 43.3 });
            ships.Add(new Product { Name = "The Queen Mary", Price = 53.63 });
            ships.Add(new Product { Name = "The Schooner Bluenose", Price = 34.0 });
            ships.Add(new Product { Name = "The Titanic", Price = 51.09 });
            ships.Add(new Product { Name = "The USS Constitution Ship", Price = 33.97 });
            //ships
            categories.Add(new Category { Name = "Ships", Products = ships });

            var trains = new List<Product>();
            trains.Add(new Product { Name = "1950's Chicago Surface Lines Streetcar", Price = 26.72 });
            trains.Add(new Product { Name = "1962 City of Detroit Streetcar", Price = 37.49 });
            trains.Add(new Product { Name = "Collectable Wooden Train", Price = 67.56 });
            //trains
            categories.Add(new Category { Name = "Trains", Products = trains });

            var trucksAndBuses = new List<Product>();
            trucksAndBuses.Add(new Product { Name = "1926 Ford Fire Engine", Price = 24.92 });
            trucksAndBuses.Add(new Product { Name = "1940 Ford Pickup Truck", Price = 58.33 });
            trucksAndBuses.Add(new Product { Name = "1940s Ford truck", Price = 84.76 });
            trucksAndBuses.Add(new Product { Name = "1954 Greyhound Scenicruiser", Price = 25.98 });
            trucksAndBuses.Add(new Product { Name = "1957 Chevy Pickup", Price = 55.7 });
            trucksAndBuses.Add(new Product { Name = "11958 Setra Bus", Price = 77.9 });
            trucksAndBuses.Add(new Product { Name = "1962 Volkswagen Microbus", Price = 61.34 });
            trucksAndBuses.Add(new Product { Name = "1964 Mercedes Tour Bus", Price = 74.86 });
            trucksAndBuses.Add(new Product { Name = "1980’s GM Manhattan Express", Price = 53.93 });
            trucksAndBuses.Add(new Product { Name = "1996 Peterbilt 379 Stake Bed with Outrigger", Price = 33.61 });
            trucksAndBuses.Add(new Product { Name = "Diamond T620 Semi-Skirted Tanker", Price = 68.29 });
            //trucks and buses
            categories.Add(new Category { Name = "Trucks and Buses", Products = trucksAndBuses });

            var vintageCars = new List<Product>();
            vintageCars.Add(new Product { Name = "18th Century Vintage Horse Carriage", Price = 60.74 });
            vintageCars.Add(new Product { Name = "1903 Ford Model A", Price = 68.3 });
            vintageCars.Add(new Product { Name = "1904 Buick Runabout", Price = 52.66 });
            vintageCars.Add(new Product { Name = "1911 Ford Town Car", Price = 33.3 });
            vintageCars.Add(new Product { Name = "1912 Ford Model T Delivery Wagon", Price = 46.91 });
            vintageCars.Add(new Product { Name = "1913 Ford Model T Speedster", Price = 60.78 });
            vintageCars.Add(new Product { Name = "1917 Grand Touring Sedan", Price = 86.7 });
            vintageCars.Add(new Product { Name = "1917 Maxwell Touring Car", Price = 57.54 });
            vintageCars.Add(new Product { Name = "1928 Ford Phaeton Deluxe", Price = 33.02 });
            vintageCars.Add(new Product { Name = "1928 Mercedes-Benz SSK", Price = 72.56 });
            vintageCars.Add(new Product { Name = "1930 Buick Marquette Phaeton", Price = 27.06 });
            vintageCars.Add(new Product { Name = "1932 Model A Ford J-Coupe", Price = 58.48 });
            vintageCars.Add(new Product { Name = "1934 Ford V8 Coupe", Price = 34.35 });
            vintageCars.Add(new Product { Name = "1936 Chrysler Airflow", Price = 43.26 });
            vintageCars.Add(new Product { Name = "1936 Mercedes Benz 500k Roadster", Price = 21.75 });
            vintageCars.Add(new Product { Name = "1936 Mercedes-Benz 500K Special Roadster", Price = 24.26 });
            vintageCars.Add(new Product { Name = "1937 Horch 930V Limousine", Price = 26.3 });
            vintageCars.Add(new Product { Name = "1937 Lincoln Berline", Price = 60.62 });
            vintageCars.Add(new Product { Name = "11938 Cadillac V-16 Presidential Limousine", Price = 20.61 });
            vintageCars.Add(new Product { Name = "1939 Cadillac Limousine", Price = 23.14 });
            vintageCars.Add(new Product { Name = "11939 Chevrolet Deluxe Coupe", Price = 22.57 });
            vintageCars.Add(new Product { Name = "1940 Ford Delivery Sedan", Price = 48.64 });
            vintageCars.Add(new Product { Name = "1941 Chevrolet Special Deluxe Cabriolet", Price = 64.58 });
            //vintage cars
            categories.Add(new Category { Name = "Vintage Cars", Products = vintageCars });

            categories.ForEach(c => context.Categories.Add(c));
            context.SaveChanges();

        }
    }
}
