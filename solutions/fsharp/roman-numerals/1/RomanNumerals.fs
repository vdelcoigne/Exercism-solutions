module RomanNumerals

let roman arabicNumeral = 
    let replace (oldValue:string) newValue (s:string) = s.Replace(oldValue, newValue)

    String.replicate arabicNumeral "I"
    |> replace "IIIII" "V"
    |> replace "VV" "X"
    |> replace "XXXXX" "L"
    |> replace "LL" "C"
    |> replace "CCCCC" "D"
    |> replace "DD" "M"
    // special cases
    |> replace "VIIII" "IX"
    |> replace "IIII" "IV"
    |> replace "LXXXX" "XC"
    |> replace "XXXX" "XL"
    |> replace "DCCCC" "CM"
    |> replace "CCCC" "CD"
   