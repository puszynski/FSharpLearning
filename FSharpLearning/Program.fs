open System

// For more information see https://aka.ms/fsharp-console-apps
printf "Hello from F# "  (*no new line*)
printfn "Hello F#"

//function lang applay functions to data insted of foucse on state changes lake in object oriented programming languages
//function languages are often shortened than object oriented one
//data in immutable, when value is assing to variable, it can not be chahnged


let hello () =
    printf "Enter you name: "

    let name = Console.ReadLine()
    printfn "Hello %s" name (*%s means its a string, %i integers, %f floats, %b boolean, %A touples, %O object*)
    //end of function

let floats_displaying_precission() =
    printfn "Display as regular float:"
    printfn "PI : %f" 3.14159265359 (*PI decimals will be cuted to 6*)
    printfn "PI : %.4f" 3.14159265359 (*You can c=lower decimal, e.g. to 4*)

    let big_pi = 3.14159265359M 
    printfn "PI : %M" big_pi    (*use big to display whole number*)


let do_functions() =    
    let get_sum (x: int, y: int) : int = x + y    
    printfn "5 + 7 = %i" (get_sum(5, 6))

    let rec factorial x =   (*recursive function*)
        if x < 1 then 1
        else x * factorial (x - 1)
    printfn "Factorial of 4 : %i" (factorial(4))    (*4 * 3 * 2 * 1*)


let work_with_collection_and_map_function() =

    let random_list = [1;2;3]
    let random_list_with_duplicated_values = List.map (fun x -> x * 2) random_list

    printfn "display doubled values list: %A" random_list_with_duplicated_values


let list_filter_to_get_even_numbers() =

    [1;2;3;4;5;6;7;8;9;10]

    |> List.filter(fun x -> (x % 2) = 0) (*do some filter*)
    |> List.map (fun x -> x * 2)  (*do some stuff*)

    |> printfn "event numbers from list multiple by 2: %A"



let using_many_functions() =

    let multiply_by_3 x = x * 3
    let add_five x = x + 5

    let multiplay_then_add = multiply_by_3 >> add_five
    let add_then_multiply = multiply_by_3 << add_five

    printfn "First miltiply then add: %i" (multiplay_then_add 10)
    printfn "First add then multiply: %i" (add_then_multiply 10)
 

//basic math operations => https://youtu.be/c7eNDJN758U?t=1341


let while_loop() = 
    let number_to_guest = "7"
    let mutable guess_number = "" (*you can override values*)

    while not (number_to_guest.Equals(guess_number)) do
        printf "Type number to guess : "
        guess_number <- Console.ReadLine()  (*assign value from user*)

    printfn "Gratulations!"

let loop() =
    for i = 1 to 10 do
        printf "%i " i

    for i = 10 downto 1 do
        printf "%i " i

    for i in [1..10] do
        printf "%i " i

    [1..10] |> List.iter (printf "%i ")

    let sum = List.reduce (+) [1..10]
    printfn "Sum: %i" sum

//todo continue tutorial https://youtu.be/c7eNDJN758U?t=2370



//call your function
while_loop()
using_many_functions()
list_filter_to_get_even_numbers()
work_with_collection_and_map_function()
do_functions()
floats_displaying_precission()
hello()

Console.ReadKey() |> ignore (*just to keep console window open*)