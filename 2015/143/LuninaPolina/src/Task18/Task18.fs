﻿module Task18
open Task15
open Task16
open Task17

let toMyString (s:string) = 
    let rec f (s1:MyString) i = 
        if i = s.Length + 1
        then s1
        else f (s1.add(s.[s.Length - i])) (i + 1)
    let (s1:MyString) = Empty
    f s1 1

    

