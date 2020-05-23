
let calculaMes mes = 
    mes*30
let calculaAno ano=
    ano*365
let escreveResultado num =
    printf "O numero total de dias é de %i " num
let escreveImpar num=
    printf "o numero %i é impar" num

let mensagemDia ()=
    printf "Digite quantos dias de vida: "
    System.Console.ReadLine() |> System.Int32.Parse
let mensagemMes()=
    printf "Digite quantos meses de vida "
    System.Console.ReadLine() |> System.Int32.Parse
let mensagemAno()=
    printf "Digite quantos anos de vida"
    System.Console.ReadLine() |> System.Int32.Parse
       

[<EntryPoint>]
let main argv =
    
    
    let dia = mensagemDia()
    let mes = mensagemMes()
    let ano = mensagemAno()
    let mutable resultado=0
    resultado<-(resultado+dia)
    resultado <- (resultado+(calculaMes mes))
    resultado <- (resultado+(calculaAno ano))
   
    escreveResultado resultado
    


        
    0 
