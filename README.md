Bluebeam Software, Inc.
55 South Lake
Pasadena, CA 91101

# What is Bluebeam looking for in a *Back-End Developer*?

We are looking for talented software engineers that understand both SOA and CAA because we offer both Enterprise and Cloud system offerings.

> Have you heard of Service Oriented Architecture (SOA) or Cloud as Architecture (CAA)? If you haven't then please check this out: http://blogs.vmware.com/vcloud/2010/04/soa-and-cloud-computing-are-they-the-same.html. Its a really great article on the differences between the two types of architectures.

Really, it all boils down to the following:
* We want engineers that can build new services or integrate existing services with ease
* We want engineers that understand how to scale services vertically (up) and horizontally (out)
* We want engineers that can design algorithms at scale (i.e. we want engineers that know the difference between $O(N^2)$, $O(N \log N)$, $O(N)$, $O(\log N)$, and $O(1)$ when they design algorithms)
* We want engineers that know how to build software using SOLID principles
> Have you heard of SOLID principles? If you haven't then please check this out: http://butunclebob.com/ArticleS.UncleBob.PrinciplesOfOod. Its a really great article on what makes for good object oriented design from Uncle Bob himself (i.e. Robert C. Martin).
* We want engineers that are familiar with design patterns (i.e. Gang of Four, Domain Driven Design, etc.) and have a firm understanding of object oriented programming
> Have you heard of design patterns from the Gang of Four? Take a quick glance at the book on Amazon here: http://www.amazon.com/Design-Patterns-Elements-Reusable-Object-Oriented-ebook/dp/B000SEIBB8. You can catch up on the patterns here: http://www.dofactory.com/net/design-patterns.
* *Most importantly* we want engineers that are quick learners and can apply their knowledge to solve difficult problems

## What can I expect from a *Back-End Developer* position?

As a *Back-End Developer*, you will be an integral part of the **Studio Team** and will be enhancing/extending the realtime collaboration services that integrate tightly with our flagship product **Revu**. Studio is powered by AWS technologies and so you will have cloud computing at your fingertips.

# Homework Problem for Back-End Web Developer Position

It's been a long week! You have been so busy and its time to relax; so you plop yourself in front of your TV and realize you can't decide what to watch! You think to yourself, "Jon mentioned this really cool show earlier... what was it called again?" Now you can just call him, *OR* you can let the new TV service *NetFace* figure out what to watch for you. Picking up your phone... its just too heavy!

In this homework assignment, you will design a subset of the features for the service *NetFace* that will help solve the problem of deciding what to watch. *NetFace* is a combination of *Netflix* and *Facebook* where users sign in and make friends. At the same time, each user tracks their favorite TV shows. The idea is that users might like the same TV shows as their friends, and when they can't decide what to watch, they can tune into their friend's channel to watch new stuff. They can also tune into their own channel and let *NetFace* figure out what the TV line up should be. Finally, no more scrolling through endless TV shows for hours only to give up and watch nothing!

## Okay, how does this work?

We will provide you with an ASP.NET Web API project to extend. You will be designing the data structures on the back end to materialize the following features:
* Registering friends
* Registering TV shows and their episodes
* Registering a user's favorite TV shows
* Creating the TV Channel Line-Up from users

You are not required to use any external dependencies; however, if you feel strongly about it, then by all means do so.
When you submit your assignment, please let us know how to set it up (ideally, you should provide us with a README and script to run).

### Users

Users are the fundamental units at *NetFace*. They literally represent the consumer of the service.

We start you off with creating new users by handling the POST request:

```
POST http://localhost/users
```
Where it's payload might be:
```
{
	"UserName": "jon",
	"Password": "SECRETPASSWORD"
}
```

We also start you off by handling the GET request:
```
GET http://localhost/users/{id}
```
When requesting http://localhost/users/1, it's response might be:
```
{
	"UserId": 1,
	"UserName": "jon",
}
```

### TV-Shows

TV-Shows are another fundamental unit at *NetFace*. They literally represent what users pay to get access to.

We start you off with creating new TV-shows by handling the POST request:

```
POST http://localhost/shows
```
Where it's payload might be:
```
{
	"Name": "Breaking Bad"
}
```
We also start you off by handling the GET request:
```
GET http://localhost/shows/{id}
```
When requesting http://localhost/shows/1, it's response might be:
```
{
	"ShowId": 1,
	"Name": "Breaking Bad"
}
```

### Accessing a User's Favorite Shows

Now that Users and Shows are a part of the system, we might want to know what a user's favorite shows are.

We start you off with accessing a user's favorite shows:

```
GET http://localhost/users/{id}/shows
```
When requesting http://localhost/users/1/shows, it's response might be:
```
["Breaking Bad", "House of Cards"]
```
## What you will build

You can change any part of the *NetFace* app to accomplish your goals (think CRUD operations):
* Registering a user's friends
* Registering a TV show into the system
* Registering episodes onto a TV show
* Registering a user's favorite TV shows
* Producing a channel line up for the following scenarios:
 * The current user
 * The current user and their immediate friends
 * The current user and all their potential friends (i.e. if you are friends with Tim and Tim is friends with Eric then you would create a channel line up of the favorite shows between you, Tim and Eric)

You can get a visual of your API by visiting http://localhost/swagger/ui/index whenever you build.

## What you will submit

Please create a zip file and send it over to the recruiter when you are finished. It should include the following:
* Your Solution folder and projects
* A README file with examples on how to use your API and anything you want to address (i.e. concerns, open questions, etc.)

## What we Expect

This problem is purposefully vague and there are many possible solutions. There is no right or wrong answser. We want to see your ability to solve problems.

That being said, don't leave anything out. We will be going over everything.
