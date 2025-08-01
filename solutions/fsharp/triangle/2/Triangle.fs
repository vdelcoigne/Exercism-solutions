module Triangle

let isValid triangle =
    triangle |> List.forall(fun l -> l > 0.0) &&
    triangle.[0] + triangle.[1] >= triangle.[2] &&
    triangle.[0] + triangle.[2] >= triangle.[1] && 
    triangle.[1] + triangle.[2] >= triangle.[0]

let equilateral triangle = 
    triangle |> isValid && 
    (triangle.[0] = triangle.[1] && triangle.[1] = triangle.[2])

let isosceles triangle = 
    triangle |> isValid && 
    (triangle.[0] = triangle.[1] || triangle.[1] = triangle.[2] || triangle.[0] = triangle.[2])

let scalene triangle = 
    triangle |> isValid && 
    (triangle.[0] <> triangle.[1] && triangle.[1] <> triangle.[2])