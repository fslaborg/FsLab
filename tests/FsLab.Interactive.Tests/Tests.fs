module Tests

open System
open Xunit
open FsCheck.Xunit

[<Fact>]
let ``true is true`` () =
    Assert.True(true)

// a property-based test are parametrized test, which are tested with a range of random inputs. 
// This can be helpful to find edge cases that you might not have thought of.
[<Property>]
let ``Boolean is true or false`` (b: bool) =
    b = true || b = false