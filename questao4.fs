
let imprimeValor maiorValor1 = 
    printf "o maior valor é %i" maiorValor1


let maiorValor valor1 valor2=
    if valor1>valor2 then
        imprimeValor valor1
    else
        imprimeValor valor2
 
let mensagemValor1 ()=
    printf "digite o primeiro valor "
    System.Console.ReadLine() |> System.Int32.Parse
let mensagemValor2 ()=
    printf "digite sua segunda nota "
    System.Console.ReadLine() |> System.Int32.Parse
       

[<EntryPoint>]
let main argv =
    
    
    let valor1=mensagemValor1()
    let valor2=mensagemValor2()
    
    maiorValor valor1 valor2


        
    0 
