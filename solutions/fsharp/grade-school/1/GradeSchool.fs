module GradeSchool

type School = Map<int, string list>

let empty: School = Map.empty

let add (student: string) (grade: int) (school: School): School = 
    match school.TryGetValue(grade) with
    | (true, students) -> school.Add(grade, student::students |> List.sort)
    | (false, _) -> school.Add(grade, [student])

let roster (school: School): string list = 
    school |> Map.fold (fun current _ students -> current@students) []

let grade (number: int) (school: School): string list = 
    match school.TryFind number with
    | Some value -> value
    | None -> []