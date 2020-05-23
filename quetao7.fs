
let somar n1 n2=
    n1+n2
let calculaSegundos segundos1 segundos2=
    let mutable  segundos3 = somar segundos1 segundos2
    while segundos3>60 do
        segundos3<-segundos3-60

    segundos3

let calculaMinutos minutos1 minutos2 =
    let mutable minutos = somar minutos1 minutos2
    while minutos>60 do
        minutos<-(minutos-60)

    minutos



let segundo segundos1 segundos2=
    let numero = calculaSegundos segundos1 segundos2
    if(segundos1+segundos2>60)then
         printf"segundos %i "numero

      else 
         printf "segundo %i" (segundos1+segundos2)

let minuto minuto1 minuto2=
    let numero=calculaMinutos minuto1 minuto2
    if( minuto1+minuto2 > 60)then
         printf "segundos %i" numero
    else    
         printf "minutos %i" (minuto1+minuto2)


let hora hora1 hora2 =
    printf "hora %i "(hora1+hora2)

let somarTempo hora1 minuto1 segundos1 hora2 minuto2 segundos2 =
   
    segundo segundos1 segundos2

    minuto minuto1 minuto2
    
    hora hora1 hora2
    

    

     

 
let mensagemValor1 ()=
    printf "digite a hora "
    System.Console.ReadLine() |> System.Int32.Parse
let mensagemValor2 ()=
    printf "digite o minuto "
    System.Console.ReadLine() |> System.Int32.Parse
let mensagemValor3 ()=
    printf "digite os segundos "
    System.Console.ReadLine() |> System.Int32.Parse
       

[<EntryPoint>]
let main argv =
    
    
    let hora1=mensagemValor1()
    let minuto1= mensagemValor2()
    let segundos1= mensagemValor3()
    let hora2=mensagemValor1()
    let minuto2= mensagemValor2()
    let segundos2= mensagemValor3()

    somarTempo hora1 minuto1 segundos1 hora2 minuto2 segundos2


        
    0 
