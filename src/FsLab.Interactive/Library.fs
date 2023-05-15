namespace FsLab.Interactive

open Deedle.Interactive
open FSharp.Stats.Interactive
open Plotly.NET.Interactive

module Say =
    let hello name =
        printfn "Hello %s" name
