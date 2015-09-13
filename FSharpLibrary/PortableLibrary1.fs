namespace FSharpLibrary

type DemoTypeA = {
    Property: int;
    AnotherProperty: string;
}

type DemoTypeB = {
    Data: string list;
    Message: string;
}

type CompositeType = {
    A: DemoTypeA;
    B: DemoTypeB;
}

type Serialise() = 
    member this.X =
        let a = { Property = 0
                  AnotherProperty = "hello" }
        let b = { Data = []
                  Message = "a message"
                }
        let c = { A = a; B = b }

        let serialised = c |> Newtonsoft.Json.JsonConvert.SerializeObject
        serialised