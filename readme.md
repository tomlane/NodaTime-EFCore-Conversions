# NodaTime + EntityFrameworkCore

[![Build status](https://ci.appveyor.com/api/projects/status/sfe7n0a2r1ckllod/branch/develop?svg=true)](https://ci.appveyor.com/project/TomLane77791/nodatime-entityframeworkcore-conversions/branch/develop)

## What is this?

This repository contains an a netstandard project which has example implementations of type conversions, introduced in EntityFrameworkCore 2.1.0, that allow EntityFramework to understand and convert NodaTime types to usable types in EntityFramework. 

## Is this a Nuget Library?

Yes, it is! After much whailing and gnashing of teeth this is now a nuget package on [nuget.org](https://www.nuget.org/packages/NodaTime.EntityFrameworkCore.Conversions/)!

## What do I need to use these features?

You'll need to ensure your project is using the latest EntityFrameworkCore. 
