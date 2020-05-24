let verificarBissexto ano=
    if(ano % 4 =0 && (ano % 400 =0||ano % 100 <>0))then
        true
    else 
        false

let imprimir ano=
   if(verificarBissexto ano)then
         printf"%i é um ano bissexto  "ano

    else 
        printf "%i não é um ano bissexto  "ano



 
let mensagemAno ()=
    printf "digite o ano "
    System.Console.ReadLine() |> System.Int32.Parse

       

[<EntryPoint>]
let main argv =
    
    
    let ano=mensagemAno()

    imprimir ano
    


        
    0 
