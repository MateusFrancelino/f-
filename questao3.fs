let somaPeso peso1 peso2 peso3 =
    peso1+peso2+peso3
   
let calculaMedia1 nota1 peso1=
        nota1*peso1

let calculaMedia2 nota2 peso2 =
    nota2*peso2

let calculaMedia3 nota3 peso3 =
    nota3*peso3
    
let escreveResultado media =
    printf "A media é de  %f " media



let calculaMedia nota1 nota2 nota3 peso1 peso2 peso3  = 
    
    let resultado = (((calculaMedia1 nota1 peso1)+(calculaMedia2 nota2 peso2)+(calculaMedia3 nota3 peso3))/somaPeso peso1 peso2 peso3 )
    resultado


    




let mensagemPrimeiraNota ()=
    printf "digite sua primeira nota "
    System.Console.ReadLine() |> System.Double.Parse
let mensagemSegundaNota ()=
    printf "digite sua segunda nota "
    System.Console.ReadLine() |> System.Double.Parse
let mensagemTerceiraNota ()=
    printf "digite sua terceira nota "
    System.Console.ReadLine() |> System.Double.Parse
       

[<EntryPoint>]
let main argv =
    
    
    let nota1=mensagemPrimeiraNota()
    let nota2=mensagemSegundaNota()
    let nota3=mensagemTerceiraNota()
    

    let resultado = calculaMedia nota1 nota2 nota3 2.0 3.0 5.0
    escreveResultado resultado


        
    0 
