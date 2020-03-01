module Isogram

let isIsogram str = 
    let valid = [ 'A' .. 'Z' ]
    let upper = Seq.map System.Char.ToUpper str
    let upperChar = Seq.filter (fun x -> List.contains x valid) upper
    let unique = Seq.distinct upperChar
    (Seq.length upperChar = Seq.length unique)
