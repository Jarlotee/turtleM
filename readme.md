# turtleM

turtleM is a micro library that bootstrap's the [mediator pattern] in your .Net projects.

### What is the mediator pattern?
If you are unfamiliary with the mediator pattern and why you might want to see this [blog post]. It provides a good example on how you can de-clutter your controller, seperate your concerns and create cleaner, more maintanable code.

TLDR; It is like automapper for the logic of your application, without the downsides.

Here are three major advantages to using mediators:

1. Streamline your dependencies (and thereby decouple them)
1. Promotes single responsibility 
1. Enable application composition

### Why turtleM?
turtleM (turtle mediator) was created to reduce boilerplate and maximize flexibility. It is also designed to be easy to grok, through it's explict interfaces and methods.

### Installation
The [core library] is available on nuget `install-package turtleM`

Currently Supported IoC Packages include:
- [Unity] `install-package turtleM.Unity`
- [Ninject] `install-package turtleM.Ninject`

### Usage

TODO

### Version
0.1.0

### License
MIT

[mediator pattern]:https://en.wikipedia.org/?title=Mediator_pattern
[blog post]:https://lostechies.com/jimmybogard/2013/12/19/put-your-controllers-on-a-diet-posts-and-commands/
[core library]:https://www.nuget.org/packages/turtleM/
[Unity]:https://www.nuget.org/packages/turtleM.Unity/
[Ninject]:https://www.nuget.org/packages/turtleM.Ninject/

