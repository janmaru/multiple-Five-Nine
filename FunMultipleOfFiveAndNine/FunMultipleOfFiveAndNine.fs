namespace  FunMultipleOfFiveAndNine

module public MultiplesOf5And9  =
    let mod5And9 (x:int64)=
        if(x%5L=0L || x%9L=0L) then x else 0L

    let mod5And9Minus5Times9 (x:int64, max:int64)=
         let a = x*5L
         let b = x*9L
         let c = x*(5L*9L) 
         (a + b - c, a >max &&  b >max &&  c >max)

    let rec verify n m = 
      if n <= m then 
        verify (n + 1) m  

    let CalculateSumList (n:int64) = 
        [1L..n] |> 
             List.fold (fun acc (x) -> acc + mod5And9(x)) 0L

    let CalculateSumSeq (n:int64) = 
        {1L..n} |> 
             Seq.fold (fun acc (x) -> acc + mod5And9(x)) 0L 

    let CalculateSumSeqOptimized (n:int64) = 
         {1L..n} |> 
              Seq.map (fun x -> mod5And9Minus5Times9(x, n))
              |> Seq.takeWhile (fun x ->  snd x )
 