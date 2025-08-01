module Seq

let keep pred xs =
    seq {
        for item in xs do
            if pred item then yield item
    }

let discard pred xs =
    seq {
        for item in xs do
            if (not (item |> pred)) then yield item
    }
