module SumOfMultiples

let sum (numbers: int list) (upperBound: int): int = 
    if (upperBound > 0) then
        let allMultiplesList = List.map (fun x -> (if(x > 0) then seq{0 .. x .. (upperBound - 1)} else seq{0}) |> Seq.toList) numbers
        let allMultiples = List.concat allMultiplesList |> Seq.ofList
        let uniqueMultiples = Seq.distinct allMultiples
        printf "%A" (uniqueMultiples |> Seq.toList)
        Seq.sum uniqueMultiples
    else 0