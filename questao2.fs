
let calculaMes dias = 
    dias/30
let calculaRestoMes dias=
    dias%30
let calculaRestoAno dias=
    dias%365
let calculaAno dias=
    dias/365
let escreveResultado dia mes ano =
    printf "O numero total de anos é de %i " ano
    printf "O numero total de meses é de %i " mes
    printf "O numero total de dias é de %i " dia



let mensagemDia ()=
    printf "Digite quantos dias de vida: "
    System.Console.ReadLine() |> System.Int32.Parse
       

[<EntryPoint>]
let main argv =
    
    
    let mutable dias = mensagemDia()
    let ano = calculaAno dias 
    dias <- calculaRestoAno dias
    let mes = calculaMes dias
    dias <-  calculaRestoMes dias
    escreveResultado dias mes ano


        
    0 
