//	Для заданного списка слов найти слова, содержащие не менее одной буквы Т и не более двух букв О

let countVowels (str:string) =
    let charList = List.ofSeq str

    let accFunc (Ts, Os) letter =
        if   letter = 'T' || letter = 't' then (Ts + 1, Os)
        elif letter = 'O' || letter = 'o' then (Ts, Os + 1)
        else                   (Ts, Os)
    
    let calc (x, y) = 
        if x >= 1 && y <= 2 then true
        else false

    let result = List.fold accFunc (0, 0) charList
    if calc result then printf "%s " str
    


[<EntryPoint>]
let main argv =
    List.map countVowels ["The"; "quick"; "lazy"; "broown"; "fox"; "jumps"; "over"; "the"; "broownt"; "dog"] |> ignore
    0 
