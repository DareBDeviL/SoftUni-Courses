﻿namespace Formula1
{
    using Formula1.Core;
    using Formula1.Core.Contracts;
    using Formula1.Models;
    using Formula1.Models.Contracts;
    using Formula1.Repositories;
    using Formula1.Repositories.Contracts;

    public class StartUp
    {
        public static void Main()
        {
            //IEngine engine = new Engine();
            //engine.Run();
            Car car = new Car("asd", " ", 12, 2);
           ICar car2 = new Car("asd", " ", 12, 2);
            
        }
    }
}
