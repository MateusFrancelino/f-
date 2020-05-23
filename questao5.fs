
let verificarPar valor=
    valor%2=0

let verificaNegativo valor=
    if valor<0 then 
        true
    else 
        false

let indicarNegativoPositivo valor =
    if(verificaNegativo valor)then
        printf "o valor %i é negativo " valor
    else 
        printf "o valor %i é positivo " valor

let indicarParImpar valor=
    if(verificarPar valor)then
           printf "o valor %i é par"valor
       else
           printf "o valor %i é impar"valor

let indicar valor =
    indicarNegativoPositivo valor

    indicarParImpar valor
    0
    

 
    




 
let mensagemValor1 ()=
    printf "digite o primeiro valor "
    System.Console.ReadLine() |> System.Int32.Parse
let mensagemValor2 ()=
    printf "digite sua segunda nota "
    System.Console.ReadLine() |> System.Int32.Parse
       

[<EntryPoint>]
let main argv =
    
    
    let valor1=mensagemValor1()
    
    indicar valor1


        
    0 
