# marta-csharp

### Table of Contents
**[Nuget](#nuget)**<br>
**[Useage](#useage)**<br>
**[Contributing](#contributing)**<br>


## Nuget

 ```
    PM> Install-Package marta-csharp
```


## Useage
Obtain an API Key [here](https://www.itsmarta.com/developer-reg-rtt.aspx).

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


## Contributing

Pull requests are welcome. 

For large changes, please open an issue first to discuss what you would like to add.
