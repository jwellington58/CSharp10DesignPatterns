using Singleton;

Console.Title = "Singleton";

var instance1 = Logger.Instance;
var instance2 = Logger.Instance;

if(instance1 == instance2 && instance2 == Logger.Instance)
    Console.WriteLine("Instances are the same");

instance1.Log("From instance 1");