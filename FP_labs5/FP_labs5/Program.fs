// Для массива текстовых файлов выполнить задание в парадигме параллельного программирования и сформировать единый выходной файл.
//	Для текстового файла изменить порядок слов на противоположный


open System.IO

let getFile file = file
                  |> Seq.toList
                  |> List.rev
             

let spl(str:char list) = str
                      |> Seq.toList
                      |> List.rev
                      |> Seq.iter (printf "%A ")

                  
let secretData = 
    Directory.GetFiles(@"C:/Users/pavlo/source/repos/FP_labs5/files/", "*.txt")
    |> Array.Parallel.map (fun filePath -> File.ReadAllText(filePath))
    |> Array.Parallel.map Seq.toList
    |> Array.Parallel.map List.rev
    |> Array.Parallel.iter spl

[<EntryPoint>]
let main argv =
    let lst = secretData
    lst
    0 

    