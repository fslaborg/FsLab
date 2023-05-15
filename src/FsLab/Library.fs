namespace FsLab

open Deedle
open FSharp.Stats
open Plotly.NET

module Say =
    let hello name =
        printfn "Hello %s" name
