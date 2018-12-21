# marta-csharp

This repository was inspired by [marta-python](https://github.com/itsmarta/marta-python). The Metropolitan Atlanta Rapid Transit Authority (MARTA) is the principal public transport operator in the Atlanta metropolitan area. MARTA operates a network of bus routes linked to a rapid transit system consisting of 48 miles of rail track with 38 train stations. It is the eighth-largest rapid transit system in the United States by ridership. This library will get real-time data about the trains and buses.

### Table of Contents
**[Nuget](#nuget)**<br>
**[Useage](#useage)**<br>
**[Tains](#trains)**<br>
**[Buses](#buses)**<br>
**[Contributing](#contributing)**<br>


## Nuget

 ```
    PM> Install-Package marta-csharp
```


## Useage
Obtain an API Key [here](https://www.itsmarta.com/developer-reg-rtt.aspx).


## Trains
```csharp
using Marta.Services;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var apiKey = "API_KEY"
            ITrainRepository trainRepository = new TrainRepository(apiKey);
            var trains = trainRepository.GetTrainsAsync().Result;
        }
    }
}
```

## Buses
```csharp
using Marta.Services;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var apiKey = "API_KEY";
            IBusRepository busRepository = new BusRepository(apiKey);
            var buses = busRepository.GetBusesAsync().Result;
            var route3Buses = busRepository.GetBusByRouteAsync(3).Result;
        }
    }
}
```

## Contributing

Pull requests are welcome. 

For large changes, please open an issue first to discuss what you would like to add.
