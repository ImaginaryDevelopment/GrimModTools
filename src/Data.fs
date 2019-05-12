module GrimModTools.Data
open Schema
open Schema.DamageShorts

let gdClasses : GdClass list = [
  Classes.D3.NotImplemented.DemonHunter.cls
  Classes.D3.NotImplemented.WitchDoctor.cls
  Classes.D3.NotImplemented.Monk.cls
  Classes.D3.NotImplemented.Wizard.cls
  Classes.D3.NotImplemented.Crusader.cls
  Classes.D3.NotImplemented.Necromancer.cls
  Classes.D3.NotImplemented.Barbarian.cls

  Classes.Grim.NotImplemented.Soldier.cls
  Classes.Grim.NotImplemented.Demolitionist.cls
  Classes.Grim.NotImplemented.Occultist.cls
  Classes.Grim.NotImplemented.Nightblade.cls
  Classes.Grim.NotImplemented.Necromancer.cls

  Classes.Titan.Rogue.cls
  Classes.Titan.NotImplemented.Nature.cls
  Classes.Titan.NotImplemented.Spirit.cls
  Classes.Titan.NotImplemented.Dream.cls
  Classes.Titan.NotImplemented.Storm.cls
  Classes.Titan.NotImplemented.Earth.cls
  Classes.Titan.NotImplemented.Defender.cls
  Classes.Titan.NotImplemented.Warfare.cls
  Classes.Titan.NotImplemented.Hunting.cls

  Classes.Other.NotImplemented.TerrorKnight.cls
  Classes.Other.NotImplemented.Elementalist.cls
  Classes.Other.NotImplemented.Outrider.cls
  Classes.Other.NotImplemented.Champion.cls
  Classes.Other.NotImplemented.Riftstalker.cls
  Classes.Other.NotImplemented.Necrotic.cls

]

let allTags =
  gdClasses
  |> List.collect(fun gc ->
    gc.skills
  )
  |> List.collect (fun sk ->
    let modTags =
      sk.mods
      |> List.collect (fun m -> m.tags)
      |> List.distinct
    sk.tags@modTags
    |> List.distinct
  )
  |> List.distinct
  |> List.sortBy(fun x ->
    let isDamage = match x with |Damage _ -> true | _ -> false
    let isConversion = match x with |DirectConversion _ -> true | DoTConversion _ -> true | _ -> false
    isConversion, isDamage, string x
  )
let allTagDisplays =
  allTags
  |> List.map (Tag.ToDisplay)

printfn "%A" allTagDisplays