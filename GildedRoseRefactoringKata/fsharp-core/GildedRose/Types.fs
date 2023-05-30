module GildedRose.Types
    
    type Item = { Name: string; SellIn: int; Quality: int }    
    
    type IQualityCalculator =
        abstract member CalculateQuality : item:Item -> unit
        
    type ISellInCalculator =
        abstract member CalculateSellIn : item:Item -> unit
        
    type ICalculator =
        abstract member Calculate : Item -> (int * int)

    type AgedCalculator private () =
        static member val Instance = AgedCalculator ()
        
        interface ICalculator with
                member this.Calculate item =
                    let quality =
                        match item.Quality with
                        | q when q < 50 -> item.Quality + 1
                        | _ -> item.Quality
                        
                    let sellIn = item.SellIn - 1
                    
                    let quality =
                        match (sellIn, quality) with
                        | s, q when s < 0 && q < 50 -> quality + 1
                        | _ -> quality
                    (sellIn, quality)
            
    type BackstageCalculator private () =
        static member val Instance = BackstageCalculator ()
        
        interface ICalculator with   
            member this.Calculate item =
                    let sellIn = item.SellIn - 1
                    
                    let quality =
                        match (sellIn, item.Quality) with
                        | s, q when q < 50 && s > 10 -> item.Quality + 1
                        | s, q when q < 50 && s > 5 -> item.Quality + 2
                        | s, q when q < 50 && s > 0 -> item.Quality + 3
                        | s, q when  s < 0 -> 0
                        | _ -> item.Quality
                        
                    (sellIn, quality)

    type SulfurasCalculator private () =
        static member val Instance = SulfurasCalculator ()
        interface ICalculator with
            member this.Calculate item = (item.SellIn, item.Quality)
            
    type ConjuredCalculator private () =
        static member val Instance = ConjuredCalculator ()
        interface ICalculator with
            member this.Calculate item = failwith "todo"  
            
    type OtherCalculator private () =
        static member val Instance = OtherCalculator ()
        interface ICalculator with
            member this.Calculate item =
                    let quality =
                        match item.Quality with
                        | q when q > 0 -> item.Quality - 1
                        | _ -> item.Quality
                        
                    let sellIn = item.SellIn - 1
                    (sellIn, quality)
            
    type Groups =
        | Aged
        | Backstage
        | Sulfuras
        | Conjured
        | Other        

