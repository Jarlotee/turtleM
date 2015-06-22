# turtleM

turtleM (turtle mediator) is a micro library that bootstrap's the [mediator pattern] in your .Net projects.

If you are unfamiliary with the mediator pattern and why you might want to see this [blog post]. 
It provides a good example on how you can de-clutter your controller, seperate your concerns and create cleaner, more maintanable code.

Here are three major advantages to using mediators:

1. Streamline your dependencies (and thereby decouple them)
1. Promote single responsibility 
1. Enable application composition

### Why turtleM?
turtleM was created to reduce boilerplate and maximize flexibility and supports the following out of the box:

1. Async\Await
1. Any object can be used for request and response objects (no inheritance or interface tagging required)
1. Handler chaining (more than one response type can be returned for any request)
1. Named mediators (useful if you have multiple handlers with the same signature)


### Installation
The [core library] is available on nuget 

`install-package turtleM`

Currently Supported IoC Packages include:

- [Unity] 
  * `install-package turtleM.Unity`
- [Ninject] 
  * `install-package turtleM.Ninject`

### Usage


> Setup (Unity)

```csharp

//IoC
var container = new UnityContainer();

//Register componenets required by turtleM
container.RegisterType<IDependencyInjector, UnityDependencyInjector>();
container.RegisterType<IMediator, Mediator>();

//Register one or more handlers
container.RegisterType<IRequestHandler<Ping, Pong>, PingPongHandler>();

```

> Runtime

```csharp

public class Ping { }
 
public class Pong
{
    public string Message { get; set; }
}


public class PingPongHandler : IRequestHandler<Ping, Pong>
{
    public Pong Handle(Ping request)
    {
        return new Pong
        {
            Message = "Pong Object"
        };
    }
}

//xUnit test
public class PingPongTest
{
	[Fact]
	public void ExecuteTest()
	{
		//Resolve mediator
		var mediator = container.Resolve<IMediator>();
		
		var result = mediator.Get<Ping, Pong>(new Ping());
		
		Assert.Equal("Pong Object", result.Message);	
	}
}


```

> For more examples or to check out a different IoC framework see the [unit test projects] 

### Version
0.1.0

### License
MIT

[mediator pattern]:https://en.wikipedia.org/?title=Mediator_pattern
[blog post]:https://lostechies.com/jimmybogard/2013/12/19/put-your-controllers-on-a-diet-posts-and-commands/
[core library]:https://www.nuget.org/packages/turtleM/
[Unity]:https://www.nuget.org/packages/turtleM.Unity/
[Ninject]:https://www.nuget.org/packages/turtleM.Ninject/
[unit test projects]:https://github.com/Jarlotee/turtleM/tree/master/tests

