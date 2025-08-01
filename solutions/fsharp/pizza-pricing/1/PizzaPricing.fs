module PizzaPricing

type Pizza = 
    | Margherita
    | Caprese
    | Formaggio
    | ExtraSauce of Pizza
    | ExtraToppings of Pizza

let rec pizzaPrice = function 
    | Margherita -> 7
    | Caprese -> 9
    | Formaggio -> 10
    | ExtraSauce pizza -> (pizzaPrice pizza) + 1
    | ExtraToppings pizza -> (pizzaPrice pizza) + 2

let orderPrice(pizzas: Pizza list): int = 
    let price = pizzas |> List.sumBy pizzaPrice

    match pizzas with
    | [_] -> price + 3
    | [_;_] -> price + 2
    | _ -> price
        
