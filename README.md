## FsLab

This repo contains the curated FsLab stack and acts as a public discussion board for all things FsLab.

[![Discord](https://img.shields.io/discord/836161044501889064?color=purple&label=Join%20our%20Discord%21&logo=discord&logoColor=white)](https://discord.gg/6nju7mRQ9G)
[![Twitter](https://img.shields.io/twitter/follow/fslaborg?style=social)](https://twitter.com/fslaborg)
[![OpenCollectiveCount](https://img.shields.io/opencollective/all/fslab)](https://opencollective.com/fslab)
![GH Stars stats](https://img.shields.io/badge/dynamic/json?logo=github&label=GitHub%20Stars&style=social&query=%24.stars&url=https://api.github-star-counter.workers.dev/user/fslaborg)

This repo acts twofold:

## A **public discussion board** for FsLab

We encourage to post discussions, ideas, and proposals for FsLab to this repo's [discussion board]().

FsLab will undergo some organisational consolidation soon, and we will use that board to share information in full transparency.

While we have our quite active discord server, discussions on discord are not indexable for search engines.
Therefore, discussions from discord can be copied to this repo's discussion board when it is of interest for a broader audience.

## A stack of high quality F# packages for data science

This repo contains two projects - `FsLab` and `FsLab.Interactive` - that act as 'glue' to provide a out-of-the-box solution à la `tydiverse` or `scipy`, but for for F#.

### The FsLab package

The aim of the `FsLab` package is that users only have to reference one package to use the full power of FsLab, e.g.:

```fsharp
#r "nuget: FsLab"

open Deedle
//access data

open FSharp.Stats
//do some modelling

open Plotly.NET
//visualize the results
```

Additionally, it provides 'glue' to further improve how well these libraries play together.

An example would be implementing visualization functions that can be used directly with data frames as input.

`FsLab` currently references the following packages:

- [Deedle]() - the fslab dataframe implementation for data access
- [FSharp.Stats]() - the one-stop F# package for all kinds of (statistical) modelling
- [Plotly.NET]() - the feature-complete charting library for .NET

Packages under consideration currently are:
- [Cytoscape.NET]() - a package for graph visualization. Would nicely complete the visualization package, but is in a pretty early stage
- [flips]() - an F# library for modeling and solving Linear Programming (LP) and Mixed-Integer Programming (MIP) problems, focus might might be too narrow.

### The FsLab.Interactive package

The aim of the `FsLab.Interactive` package is the same as FsLab, but designed for usage in [Polyglot notebooks]() e.g.:

```fsharp
#r "nuget: FsLab.Interactive"

open Deedle
// access data
// inspect data frame as cell output

open FSharp.Stats
// do some modelling
// inspect summary statistics as cell output

open Plotly.NET
// visualize the results
// inspect interactive plot as cell output
```

Additionally, it provides 'glue' to further improve how well these libraries play together in a notebook context.

An example could be an interactive formatting extension that visualizes probability distributions from FSharp.Stats directly as an area chart using Plotly.NET.

`FsLab.Interactive` currently references the following packages:

- [Deedle.Interactive]() - visualizes Deedle data frames as neatly formatted html tables
- [FSharp.Stats.Interactive]() - formatting extensions for e.g the `Matrix` and `Vector` types
- [Plotly.NET.Interactive]() - All kinds of interactive visualizations

Packages under consideration currently are:
- [Cytoscape.NET.Interactive]() - Would nicely complete the visualization package, but is in a pretty early stage
