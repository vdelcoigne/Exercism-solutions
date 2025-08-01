module ValentinesDay

type Approval = 
| Yes
| No 
| Maybe

type Cuisine = 
| Korean
| Turkish

type Genre = 
| Crime
| Horror 
| Romance 
| Thriller

type Activity = 
| BoardGame 
| Chill
| Movie of Genre
| Restaurant of Cuisine
| Walk of int

let rateActivity (activity: Activity): Approval = 
    match activity with
    | BoardGame | Chill -> No
    | Movie g -> if g = Romance then Yes else No
    | Restaurant r -> if r = Korean then Yes else Maybe
    | Walk w when w < 3 -> Yes
    | Walk w when w < 5 -> Maybe
    | _ -> No 