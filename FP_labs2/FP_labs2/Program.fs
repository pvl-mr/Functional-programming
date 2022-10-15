//	Для текстового файла изменить порядок слов на противоположный

let getFile = System.IO.File.ReadLines("C:/Users/pavlo/source/repos/FP_labs2/file2.txt")
              |> Seq.toList
              |> List.rev
             

    

let spl(str:string) = str.Split [|' '|]
                      |> Seq.toList
                      |> List.rev
                      |> Seq.iter (printf "%s ")
                      

[<EntryPoint>]
let main argv =
    let lst = getFile
    List.iter spl lst
    0 
