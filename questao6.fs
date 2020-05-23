let equilatero valor1 valor2 valor3=
    if(valor1=valor2 && valor2=valor3 && valor1=valor3)then
        true
    else 
        false

let isoceles valor1 valor2 valor3=
    if(valor1=valor2||valor2=valor3||valor1=valor3)then
        true

    else
        false

let escaleno valor1 valor2 valor3=
    if(valor1 <> valor2 && valor2 <> valor3 && valor1 <> valor3)then
        true
    else
        false

let verificaTriangulo valor1 valor2 valor3=
    if(valor1+valor2<=valor3||valor2+valor3<=valor1||valor1+valor3<=valor2)then
        true
    else    
        false

let verificarTriangulo valor1 valor2 valor3 =
    if(verificaTriangulo valor1 valor2 valor3)then
        printf "não é tringulo"
        
    elif (equilatero valor1 valor2 valor3)then
        printf  "triangulo equilatero"

    elif (isoceles valor1 valor2 valor3)then

        printf "triangulo isoceles"

    elif (escaleno valor1 valor2 valor3)then
        printf "triangulo escaleno"
    else    
        printf "como vc chegou aqui?"
     



    




 
let mensagemValor1 ()=
    printf "digite o primeiro valor "
    System.Console.ReadLine() |> System.Int32.Parse
let mensagemValor2 ()=
    printf "digite o segundo valor "
    System.Console.ReadLine() |> System.Int32.Parse
let mensagemValor3 ()=
    printf "digite o terceiro valor "
    System.Console.ReadLine() |> System.Int32.Parse
       

[<EntryPoint>]
let main argv =
    
    
    let valor1=mensagemValor1()
    let valor2= mensagemValor2()
    let valor3= mensagemValor3()
    
    verificarTriangulo valor1 valor2 valor3 


        
    0 
